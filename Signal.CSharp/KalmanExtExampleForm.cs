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

/*

x is the real plant behavior, in this case a sinus wave
with the following formulation:

x(time)=sin(frec(@ time-1)*time-1) + ramdom error signal("sigmav")
frec(time)=frec(@ time-1)

x_ is the predicted state, this is where Kalman filter will come
and where we will correct our estimations using an observation

z is the observation of the real plant, in this case corresponding only to
the position at a given time. Note that this observation is subject to an
error, therefore the resulting equation is: z(time)=x(time)+ramdom error("sigmaw")

Our first prediction will come from the plant ideal behavior, then
using the observations and error covariance we will obtain a better estimate.

xc is the ideal plant behavior... this is used just for comparison

P is the state error covariances at a given time of all the involved variables,
note that we are forming x as a 2 by 1 matrix with the following:
x(1,n) -> position
x(2,n) -> frecuency

Our functions are as following for this example:
Let's say:
f1: x1(time)=sin(x2(time-1)*(time-1))+ w     w->ramdom plant error
f2: x2(time)=x2(time-1)
h:  y=x1+ v                                  v->ramdom sensor error

A is the Jacobian of the transfer function due to the involved variables,
in this case these are x1 and x2, therefore A will be a 2 by 2 matrix
(always the matrix is square). The resulting A depends on time and must be
computed for every step that the system takes.

A is as follows:
A -> df1/dx1 = 0    df1/dx2 = cos(x2*time)*time
     df2/dx1 = 0    df2/dx1 = 1

*/


    public partial class KalmanExtExampleForm : Form
    {
        int n_iter = 1000;
        Vector zV = new Vector(0);
        Vector xV = new Vector(0);

        TExtendedKalmanFilter KalmanFilter = new TExtendedKalmanFilter();

        public KalmanExtExampleForm()
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

        private void GenerateProcess(TMtx x)
        { 
            // x(k) = f (x(k – 1), u(k – 1), 0)

            int i;
            i = KalmanFilter.Iter;
            x[0,0] = Math.Sin(x[1,0] * (i - 1));
            x[1,0] = x[1,0];

            //recalculate A(k) because f updated (!) and A is formed from df/dx

            KalmanFilter.A[0,0] = 0;
            KalmanFilter.A[1,0] = 0;

            KalmanFilter.A[0,1] = i*Math.Cos(x[1,0]*i);
            KalmanFilter.A[1,1] = 1;
        }

        private void GenerateMeasurement(TMtx z)
        {
            // z(k) = h(x(k), 0)
            z[0,0] = KalmanFilter.x[0,0];
        }

        private void Compute()
        {
             int i;             
             Matrix xhat = new Matrix();
             Matrix P = new Matrix();

             //Allocate arrays

             xhat.Size(n_iter, 2); // xhat=numpy.zeros(sz)      # a posteri estimate of x
             xhat.SetZero();

             P.Size(n_iter, 2);     // P=numpy.zeros(sz)         # a posteri error estimate
             P.SetZero();

            //Configure Kalman Filter

             KalmanFilter.Q[0, 0] = qEdit.Position; //  the covariance coeficient for the position error (plant)
             KalmanFilter.R[0, 0] = rEdit.Position; //  the covariance coeficient for the frequency error (sensor)

             KalmanFilter.x.SetIt(2,1, false, new double[2] { 0, 0.04 }); 

             KalmanFilter.z.Size(1,1);
             KalmanFilter.z[0] = zV.Values[0];
            
             KalmanFilter.P.SetIt(2,2,false,new double[4] {0.01,    0,
                                                              0, 0.01});

            //Do the filtering
    
             for (i = 1; i < n_iter; i++)
             {

                //Add new measurement    
                KalmanFilter.z[0] = zV.Values[i]; //start with the second measurement
                KalmanFilter.Iter = i+1; //Let the filter object know the iteration count, not used by Kalman Filter algorithm

                //Filter
                KalmanFilter.Update();

                 //Get Results:
                xhat.Values[i,0] = KalmanFilter.x[0];
                xhat.Values[i,1] = KalmanFilter.x[1];

                P.Values[i,0] = KalmanFilter.P[0,0];
                P.Values[i,1] = KalmanFilter.P[1,1];
            }
           
            DrawValues(zV,fastLine1, 0, 1, false);
            DrawValues(MtxExpr.Col(xhat,0), fastLine2, 0, 1, false);
            DrawValues(xV, fastLine3, 0, 1, false);
           
            DrawValues(MtxExpr.Select(MtxExpr.Col(P,0),1,P.Rows-1), fastLine4, 0, 1, false);
        }

        protected void Add(String s)
        {
            RichEdit1.SelectedText = s + "\n";
        }


        private void KalmanBasicForm_Load(object sender, EventArgs e)
        {
            RichEdit1.Clear();
            Add("Lesson 3. Filtering a non-linear process using Extended Kalman Filter. ");

            double sigmaw = 0.1;
            double sigmav = 0.5;

            SignalUtils.Tone(xV, n_iter, 8.0/1000, 0, 1,false);            //generate process without noise
            Vector tmp = xV + MtxExpr.RandGauss(n_iter, TMtxFloatPrecision.mvDouble,0, sigmaw);  //get process with noise
            zV = tmp + MtxExpr.RandGauss(n_iter,TMtxFloatPrecision.mvDouble, 0,sigmav);  //get measurement with noise ( = plant + plan noise + measurement noise)

            KalmanFilter.A.Size(2,2);

            KalmanFilter.Q[0,0] = sigmaw * sigmaw; //sized to scalar by default
            KalmanFilter.R[0,0] = sigmav * sigmav; //sized to scalar by default

            KalmanFilter.H.Size(1,2);
            KalmanFilter.H[0,0] = 1;
            KalmanFilter.H[0,1] = 0;

            KalmanFilter.W.Size(2,1);
            KalmanFilter.W[0,0] = 1;
            KalmanFilter.W[1,0] = 0;

            KalmanFilter.OnGenerateProcess += new TKalmanProcessEvent(GenerateProcess);
            KalmanFilter.OnGenerateMeasurement += new TKalmanMeasurementEvent(GenerateMeasurement);            

            rEdit.Position = sigmav * sigmav;
            qEdit.Position = sigmaw * sigmaw;
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
