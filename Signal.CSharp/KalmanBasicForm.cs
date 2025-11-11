using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Units;
using Dew.Signal;
using Dew.Signal.Units;
using static Dew.Math.Tee.MtxVecTee;

namespace DSPDemo
{
    public partial class KalmanBasicForm : Form
    {
        int n_iter = 250;
        double x = -0.37727; //# truth value (typo in example at top of p. 13 calls this z)
        double NoiseSigma = 0.1;
        Vector z = new Vector(0);        

        public KalmanBasicForm()
        {
            InitializeComponent();
        }


        private void KalmanBasicForm_ResizeEnd(object sender, EventArgs e)
        {
            tChart2.Height = (tChart1.Height + tChart2.Height) / 2;
        }

        private void KalmanBasicForm_Resize(object sender, EventArgs e)
        {
            tChart2.Height = (tChart1.Height + tChart2.Height) / 2;
        }

        private void tChart1_Click(object sender, EventArgs e)
        {

        }

        protected void Add(String s)
        {
            RichEdit1.SelectedText = s + "\n";
        }

        private void Compute()
        {
             int i;
             double Q, R; //: TSample;
             Vector xhat = new Vector();
             Vector P = new Vector();
             Vector xhatminus = new Vector();
             Vector pMinus = new Vector();
             Vector K = new Vector();
             Vector truthValue = new Vector();
             
             Q = qEdit.Position; //-5; // # process variance

        //    # allocate space for arrays

            truthValue.Size(n_iter);
            truthValue.SetVal(x);

            xhat.Size(n_iter); // xhat=numpy.zeros(sz)      # a posteri estimate of x
            xhat.SetZero();

            P.Size(n_iter);     // P=numpy.zeros(sz)         # a posteri error estimate
            P.SetZero();

            xhatminus.Size(n_iter); //xhatminus=numpy.zeros(sz) # a priori estimate of x
            xhatminus.SetZero();

            pMinus.Size(n_iter); // Pminus=numpy.zeros(sz)    # a priori error estimate
            pMinus.SetZero();

            K.Size(n_iter);      //     # gain or blending factor
            K.SetZero();

            //Variance = E((X[i] - mu)^2)
            //StdDev = sqrt(Variance);
            R = rEdit.Position; // # estimate of measurement variance, change to see effect

        //    # intial guesses
            xhat.Values[0] = 0.0;
            P.Values[0] = 1.0;

            for (i = 1; i < n_iter; i++)
            {
                //        # time update
                xhatminus.Values[i] = xhat.Values[i - 1];
                pMinus.Values[i] = P.Values[i - 1] + Q;

                //        # measurement update
                K.Values[i] = pMinus.Values[i] / (pMinus.Values[i] + R);
                xhat.Values[i] = xhatminus.Values[i] + K.Values[i] * (z.Values[i] - xhatminus.Values[i]);
                P.Values[i] = (1 - K.Values[i]) * pMinus.Values[i];
            }
           
            DrawValues(z,fastLine1, 0, 1, false);
            DrawValues(xhat, fastLine2, 0, 1, false);
            DrawValues(truthValue, fastLine3, 0, 1, false);

            pMinus.SetSubRange(2,n_iter-2);
            DrawValues(pMinus, fastLine4, 0, 1, false);
        }


        private void KalmanBasicForm_Load(object sender, EventArgs e)
        {
            RichEdit1.Clear();
            Add("Lesson 1. To use the Kalman filter the mathemathical model for the process has to be known. " +
                           "When we perform filtering we use the mathemathical model as a source of additional information " +
                           "to reduce the measurement noise. We are therefore reducing noise for a known system. " +
                           "The example demonstrates the effect of Q (process variance) " +
                           "and the effect of R (measurement variance). Both parameters are inputs " +
                           "for the Kalman filter:");
            Add("");
            Add(" - Q is the square of the standard deviation (variance) of the process without noise. ");
            Add(" - R is the square of the standard deviation (variance) of the measurement noise. ");
            Add("");
            Add("Both Q and R have to be estimated one way (trial and error) or the other (computed somehow) " +
                "before we can start filtering.");
            Add("");
            Add("The process estimated in this example is a simple straight line at -0.37727 " +
                "and the code exploits all the simplifications in the Kalman filtering " +                
                "algorithm arising from that.");

            z = MtxExpr.RandGauss(n_iter,TMtxFloatPrecision.mvDouble, x,NoiseSigma);
            rEdit.Position = NoiseSigma * NoiseSigma;
            qEdit.Position = 1E-5;
        }

        private void rEdit_TextChanged(object sender, EventArgs e)
        {
            Compute();
        }

        private void qEdit_TextChanged(object sender, EventArgs e)
        {
            Compute();
        }
    }
}
