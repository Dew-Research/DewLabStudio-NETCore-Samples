using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Units;

namespace MtxVecDemo
{
    public partial class clMultiDeviceForm : Form
    {
        int VectorLen;
        bool IsFinished;
        DateTime startTime;
        int GlobalJobIndex;
        int floatPrecisionSelected;
        int functionSelected;
        bool complexData;
        TOpenCLPlatformList clPlatforms;

        public clMultiDeviceForm()
        {
            InitializeComponent();
            clPlatforms = ClMtxVec.clPlatform();
        }

        private void clBenchmarkForm_Load(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "The platform list shows the Open CL drivers  " +
                                        "available on your computer. Select the platform of your choice and press Run."
                                      + "Then you can observe how long it takes before the specified Job Count is computed."
                                      + "Select various functions and see how they perform on different platforms. \n ";

            int i, k, kernelSum;
            i = (int)(sizeof(double) * 8);

            floatPrecisionBox.SelectedIndex = 0;
            cpuFloatPrecisionLabel.Text = "CPU (MtxVec) float precision: " + i.ToString() + "bit";
            //    ReportMemoryLeaksOnShutDown = True;

            for (i = 0; i < clPlatforms.Count; i++)
            {
                platformListBox.Items.Add(clPlatforms[i].Name);
            }

            platformListBox.SelectedIndex = 0;

            deviceListBox.Items.Clear();

            for (i = 0; i < clPlatforms[0].Count; i++)
            {
                deviceListBox.Items.Add(clPlatforms[0][i].Name);
            }

            deviceListBox.SelectedIndex = 0;
            maximumJobCountEdit.Text = "2";

            clPlatforms.IgnoreIntel = true;
            kernelSum = 0;

            for (i = 0; i <= clPlatforms.Count - 1; i++)
            {
                for (k = 0; k <= clPlatforms[i].Count - 1; k++)
                {
                    kernelSum = kernelSum + clPlatforms[i][k].Kernels.Count;
                }
            }
            if (kernelSum == 0)
            {
                this.Cursor = Cursors.WaitCursor;
                MessageBox.Show("When loading the first time, the Open CL drivers need to recompile the source code." + "This may take a minute or longer. If you have Intel Open CL drivers installed they " + "add 20s delay regardless, if the program is precompiled. Similar for AMD. The NVidia " + "compiled code load times are much faster, but GPU has limits (2s) on maximum kernel " + "execution time for gaming GPUs.");
                clPlatforms.LoadProgramsForDevices(false, false, true, false, false);
                this.Cursor = Cursors.Default;
            }

            functionBox.SelectedIndex = 0;

            VectorLen = (int) Math.Round(Math387.Exp2(19));
            vectorLengthBox.Text = VectorLen.ToString();
            IsFinished = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TOpenCLDevice aDevice;
            int CacheLength;
            int i;

            if (!IsFinished) return;

            VectorLen = Convert.ToInt32(vectorLengthBox.Text);
            CacheLength = VectorLen;
            if (complexBox.Checked) CacheLength = CacheLength * 2;
            if (floatPrecisionBox.SelectedIndex > 0) CacheLength = CacheLength * 2;

            for (i = 0; i < deviceListBox.Items.Count; i++)  //assign events to command queue threads
            {
                aDevice = clPlatforms[platformListBox.SelectedIndex][i];
                aDevice.CommandQueue[0].JobThread.OnExecute -= DoOnExecute;
                aDevice.CommandQueue[0].JobThread.OnExecute += DoOnExecute;
                aDevice.Cache.SetCacheSize(12, CacheLength, 12, 12, 12);
            }

            IsFinished = false;
            GlobalJobIndex = 0;
            platformListBox.Enabled = false;
            deviceListBox.Enabled = false;
            functionBox.Enabled = false;
            floatPrecisionBox.Enabled = false;
            schedulerTimer.Enabled = true;
            startTime = DateTime.Now;

        }        

        private void platformListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
              int i;
              TStringList DeviceList = new TStringList();

              for (i = 0; i < clPlatforms[platformListBox.SelectedIndex].Count; i++)  {
                     DeviceList.Add(clPlatforms[platformListBox.SelectedIndex][i].Name);
              }

              deviceListBox.Items.Clear();
              for (i = 0; i < DeviceList.Count; i++)
              {
                   deviceListBox.Items.Add(DeviceList[i]);
              }

              for (i = 0; i < DeviceList.Count; i++)
              {
                  deviceListBox.SetSelected(i, true);
              }
        }

        private void DoOnExecute(TOpenCLCommandQueue cmdQueue, int JobIndex)
        {
            Vector R = new Vector();        
            int i, IterCount;
            double ScalarB = 1.002;
            TOpenCLVector clA, clB, clC, clD;
            double a = 1;


            ClMtxVec.CreateIt(out clA, out clB,out clC, out clD);
            try
            {               
                switch (functionSelected)
                {
                    case 0:
                        IterCount = 8192;
                        break;
                    case 1:
                        IterCount = 8192;
                        break;
                    case 2:
                        IterCount = 8192;
                        break;
                    default: IterCount = 8192;
                        break;
                }

                clB.Size(VectorLen, (TclFloatPrecision) floatPrecisionSelected, complexData);
                clB.SetVal(ScalarB);
                clC.Size(clB);
                clC.SetVal(1);               

                for (i = 0; i < IterCount; i++)
                {
                       switch (functionSelected)
                       {
                       case 0: clC.Mul(clB);
                               break;  
                       case 1: clA.Sin(clB);
                               clD.Sin(clC);
                               clC.Add(clA, clD);                
                               break;
                       case 2: clA.Sqr(clB);
                               clC.Mul(clA, -0.5 * a);
                               clC.Exp();
                               clD.Mul(clA, clC);
                               clC.Mul(clD, Math.Sqrt(4 * a /(2*Math387.PI)) * a);

                //                 //C = Math.Sqrt(4 * a / (2 * Math387.PI)) * a * MtxExpr.Sqr(B) * MtxExpr.Exp(-0.5 * a * MtxExpr.Sqr(B));
                                 break;
                       case 3: if (!clB.Complex) { ScalarB = clB.Mean(); } else { ScalarB = clB.Meanc().Re; };
                               break;
                        }
                   }
                   clC.CopyTo(R); //from GPU to CPU                
                    if ((R.Find(Math387.NAN) != -1) || (R.Find(Math387.INF) != -1)) Math387.ERaise("NAN or INF detected!");
                }
                finally
                {
                    ClMtxVec.FreeIt(ref clA, ref clB, ref clC, ref clD);                    
                }
         }

        private void SchedulerTimer_Tick(object sender, EventArgs e)
        {
            int i, MaxJobCount;
            TOpenCLCommandQueue aCmd;
            TimeSpan deltaTime;

            MaxJobCount = Convert.ToInt32(maximumJobCountEdit.Text);
            IsFinished = true;

            for (i = 0; i < deviceListBox.Items.Count; i++)  //assign events to command queue threads
            {
                if (deviceListBox.GetSelected(i))
                {
                    aCmd = clPlatforms[platformListBox.SelectedIndex][i].CommandQueue[0];
                    if ((aCmd.JobThread.Sleeping()) && (GlobalJobIndex < MaxJobCount))
                    {
                        GlobalJobIndex = GlobalJobIndex + 1; //get next job
                        aCmd.JobThread.JobIndex = GlobalJobIndex;
                        aCmd.JobThread.Start();
                    }

                    IsFinished = (IsFinished && aCmd.JobThread.Sleeping() && (GlobalJobIndex >= MaxJobCount));
                }
            }
        

            if (!IsFinished)
            {
                currentJobCountLabel.Text = "Current job count = " + Convert. ToString(GlobalJobIndex);
                deltaTime = DateTime.Now - startTime;         
                TotalRunningTimeLabel.Text = "Total running time = " + deltaTime.Hours.ToString("00") +":" + deltaTime.Minutes.ToString("00") +":" + deltaTime.Seconds.ToString("00") + ":" + deltaTime.Milliseconds.ToString("000");
            }
            else
            {
                errorsLabel.Text = "";

                for (i = 0; i < deviceListBox.Items.Count; i++)  //assign events to command queue threads
                {
                    if (deviceListBox.GetSelected(i))
                    {           
                        aCmd = clPlatforms[platformListBox.SelectedIndex][i].CommandQueue[0];
                        
                        if (aCmd.JobThread.ExceptionMessage != "")
                        {
                            errorsLabel.Text = errorsLabel.Text + aCmd.JobThread.ExceptionMessage;
                        }
                    }
                }

                if (errorsLabel.Text == "") errorsLabel.Text = "Errors: None";

                platformListBox.Enabled = true;
                deviceListBox.Enabled = true;
                functionBox.Enabled = true;
                floatPrecisionBox.Enabled = true;
                schedulerTimer.Enabled = false;
            } 
        }

        private void clMultiDeviceForm_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < clPlatforms[platformListBox.SelectedIndex].Count; i++)
            {
                deviceListBox.SetSelected(i , true); 
            }
        }

        private void floatPrecisionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            floatPrecisionSelected = floatPrecisionBox.SelectedIndex;
        }

        private void complexBox_CheckedChanged(object sender, EventArgs e)
        {
            complexData = complexBox.Checked;
        }

        private void functionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            functionSelected = functionBox.SelectedIndex;
        }
         
    }
}
