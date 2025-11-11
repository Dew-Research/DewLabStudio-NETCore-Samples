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
    public partial class KalmanStdExampleForm : Form
    {
        int n_iter = 250;
        double x = -0.37727; //# truth value 
        double NoiseSigma = 0.1;
        Vector z = new Vector(0);
        TKalmanFilter KalmanFilter = new TKalmanFilter();

        public KalmanStdExampleForm()
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
             Vector xhat = new Vector();
             Vector P = new Vector();             
             Vector truthValue = new Vector();

            //configure the kalman filter

             KalmanFilter.Q.Size(1, 1);             
             KalmanFilter.Q[0,0] = qEdit.Position;
             KalmanFilter.R.Size(1, 1);
             KalmanFilter.R[0,0] = rEdit.Position;

             KalmanFilter.A.Size(1, 1);
             KalmanFilter.A[0, 0] = 1;

             KalmanFilter.x.Size(1,1);
             KalmanFilter.x[0,0] = 0; //-0.37727;

             KalmanFilter.z.Size(1,1);
             KalmanFilter.z[0,0] = z.Values[0];                         

             KalmanFilter.H.Size(1, 1);
             KalmanFilter.H[0, 0] = 1;

             KalmanFilter.P.Size(1, 1);
             KalmanFilter.P[0, 0] = 1;

            //Storage arrays

             truthValue.Size(n_iter); //array storing the truth value (ideal process without noise)
             truthValue.SetVal(x);

             xhat.Size(n_iter);  //array to store estimates
             xhat.SetZero();

             P.Size(n_iter);    //array to store error covariance
             P.SetZero();           

            //perform kalman filtering

             for (i = 1; i < n_iter; i++)
             {
                KalmanFilter.z[0] = z.Values[i]; //start with the second measurement

                KalmanFilter.Update();

                //Get Results:
                xhat.Values[i] = KalmanFilter.x[0];
                P.Values[i] = KalmanFilter.P[0,0];
             }
           
             DrawValues(z,fastLine1, 0, 1, false);
             DrawValues(xhat, fastLine2, 0, 1, false);
             DrawValues(truthValue, fastLine3, 0, 1, false);

             P.SetSubRange(1,n_iter-1);
             DrawValues(P, fastLine4, 0, 1, false);
        }


        private void KalmanBasicForm_Load(object sender, EventArgs e)
        {
            RichEdit1.Clear();
            Add("Lesson 2. The example from the tutorial now implemented with the TKalmanFilter object. ");
            Add("");
            Add(" - Q is the square of the standard deviation (variance) of the process without noise. ");
            Add(" - R is the square of the standard deviation (variance) of the measurement noise. ");
            Add("");
            Add("Both Q and R have to be estimated one way (trial and error) or the other (computed somehow) " +
                "before we can start filtering.");

            z = MtxExpr.RandGauss(n_iter,TMtxFloatPrecision.mvDouble,x,NoiseSigma);           

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
