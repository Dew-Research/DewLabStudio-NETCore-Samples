using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Dew.Math;
using static Dew.Math.Units.Math387;
using Dew.Math.Units;

namespace MtxVecDemo
{
    public partial class clBenchmarkForm : Form
    {
        int VectorLen;
        Dew.Math.TOpenCLDevice selectedDevice;
        TOpenCLPlatformList clPlatforms;

        public clBenchmarkForm()
        {
            InitializeComponent();
            clPlatforms = clMtxVec.clPlatform();
        }

        private void clBenchmarkForm_Load(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "The platform list shows the Open CL drivers  " +
                                        "available on your computer. If you dont have a AMD or Nvidia GPU "
            + "you can still install Intel or Open CL drivers which "
            + "run on the CPU alone. Note that GPU device speed is sensitive "
            + "to vector lengths which are not divisable by 4. "
            + "Intel drivers require at least SSE4.x (Core 2) capable hardware. "
            + "Presence of Intel drivers also slows down the start of the "
            + "application by 20seconds. \n"
            + "Select various functions and see how they perform in compare to "
            + "intel IPP (MtxVec) and native C# code. Dont forget however "
            + "that data also needs to be copied to GPU and back and this is "
            + "currently still fairly slow.\n"
            + "If the same graphics card is used also for display next to its OpenCL purpose "
            + "the performance degradation of Open CL code can be substantial. This depends largely also "
            + "on the amount of total memory allocated on the GPU by the Open CL library.\n";

            int i, k, kernelSum;
            i = (int)(sizeof(double) * 8);            

            floatPrecisionBox.SelectedIndex = 0;
            switch (floatPrecisionBox.SelectedIndex)
            {
                case 0:
                    cpuFloatPrecisionLabel.Text = "CPU (MtxVec) float precision: " + (sizeof(float) * 8).ToString() + "bit";
                    break;
                case 1:
                    cpuFloatPrecisionLabel.Text = "CPU (MtxVec) float precision: " + (sizeof(double) * 8).ToString() + "bit";
                    break;
            }

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
                MessageBox.Show("When loading the first time, the Open CL drivers need to recompile the source code." + 
                                "This may take a minute or longer. If you have Intel Open CL drivers installed they " + 
                                "add 20s delay regardless, if the program is precompiled. Similar for AMD. The NVidia " + 
                                "compiled code load times are much faster, but GPU has limits (2s) on maximum kernel " + 
                                "execution time for gaming GPUs.");
                clPlatforms.LoadProgramsForDevices(false, false, true, false, false);
                this.Cursor = Cursors.Default;
            }
            functionBox.SelectedIndex = 0;

            VectorLen = (int)Math.Round(Math387.Exp2(19));
            vectorLengthBox.Text = VectorLen.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int CacheLength;

            VectorLen = Convert.ToInt32(vectorLengthBox.Text);
            CacheLength = VectorLen;
            if (complexBox.Checked) CacheLength = CacheLength * 2;
            if (floatPrecisionBox.SelectedIndex > 0) CacheLength = CacheLength * 2;

            clPlatforms.UnMarkThreads();
            selectedDevice = clPlatforms[platformListBox.SelectedIndex][deviceListBox.SelectedIndex];
            if ((selectedDevice.DevicePlatform.Name == clMtxVec.INTEL_PLATFORM) & clPlatforms.IgnoreIntel)
            {
                MessageBox.Show("clPlatform.IgnoreIntel = True. If you want to run benchmark for Intel platform set this flag to false first!");
            }
            selectedDevice.Cache.SetCacheSize(12, CacheLength, 12, 12, 12);
            selectedDevice.CommandQueue[0].MarkThread(); //UserThread := GetCurrentThreadID;
            DoCompute();

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
              deviceListBox.SelectedIndex = 0;
        }

        private void DoCompute()
        {
            Vector B, C, R;
            int i, k, IterCount;
            double aTime, bTime;
            double ScalarB;
            TOpenCLVector clB, clC, clA, clD;
            float sa;
            double a;
            TCplx ac;
            TSCplx sac;
            TMtxFloatPrecision FloatPrecision;

            B = new Vector(0);
            C = new Vector(0);
            R = new Vector(0);
            this.Cursor = Cursors.WaitCursor;
            clMtxVec.CreateIt(out clB, out clC);
            clMtxVec.CreateIt(out clA, out clD);
            try
            {
                clC.FloatPrecision = (TclFloatPrecision)floatPrecisionBox.SelectedIndex;
                clB.FloatPrecision = clC.FloatPrecision;
                FloatPrecision = TMtxFloatPrecision.mvSingle;

                memo.Clear();

                memo.AppendText("Vector length = " + Convert.ToString(VectorLen) + "\n");
                
                switch (clC.FloatPrecision)
                {
                    case TclFloatPrecision.clFloat:
                        if (complexBox.Checked) FloatPrecision = TMtxFloatPrecision.mvSingleComplex;
                        else FloatPrecision = TMtxFloatPrecision.mvSingle;
                        memo.AppendText("Float size = " + Convert.ToString((sizeof(float)) + " bytes") + "\n");
                        break;
                    case TclFloatPrecision.clDouble:
                        if (complexBox.Checked) FloatPrecision = TMtxFloatPrecision.mvDoubleComplex;
                        else FloatPrecision = TMtxFloatPrecision.mvDouble;
                        memo.AppendText("Float size = " + Convert.ToString((sizeof(double)) + " bytes") + "\n");
                        break;
                }

                a = 1;
                ScalarB = 1.02;
               

                IterCount = 1;
                switch (functionBox.SelectedIndex)
                {
                    case 0:
                        IterCount = 4096;
                        break;
                    case 1:
                        IterCount = 256;
                        break;
                    case 2:
                        IterCount = 128;
                        break;
                    case 3:
                        IterCount = 128;
                        break;
                }

                B.Size(VectorLen, FloatPrecision);
                B.SetVal(ScalarB);
                C.Size(VectorLen, FloatPrecision);
                C.SetVal(1);

                //warm up the cache
                B.Copy(C);
                C.Copy(B);

                Math387.StartTimer();
                B.Copy(C);
                C.Copy(B);
                aTime = Math387.StopTimer();
                memo.AppendText("Copy CPU->CPU (2x) = " + Math387.FormatSample("0.00us", aTime * 1000 * 1000) + "\n");

                B.SetVal(ScalarB);
                C.SetVal(1);

                Math387.StartTimer();
                clC.Copy(C);
                clB.Copy(B);
                aTime = Math387.StopTimer();
                memo.AppendText("Copy CPU->GPU (2x) = " + Math387.FormatSample("0.00us", aTime * 1000 * 1000) + "\n");

                Math387.StartTimer();
                for (i = 0; i < IterCount; i++)
                {
                    switch (functionBox.SelectedIndex)
                    {
                        case 0:
                            clC.Mul(clB);
                            break;
                        case 1:
                            clA.Sin(clB);
                            clD.Sin(clC);
                            clC.Add(clA, clD);
                            break;
                        case 2:
                            clA.Sqr(clB);
                            clC.Mul(clA, -0.5 * a);
                            clC.Exp();
                            clD.Mul(clA, clC);
                            clC.Mul(clD, Math.Sqrt(4 * a / (2 * Math387.PI)) * a);

                            C = Math.Sqrt(4 * a / (2 * Math387.PI)) * a * MtxExpr.Sqr(B) * MtxExpr.Exp(-0.5 * a * MtxExpr.Sqr(B));
                            break;
                        case 3:
                            if (!clB.Complex) { ScalarB = clB.Mean(); } else { ScalarB = clB.Meanc().Re; };
                            break;
                    }
                }
                clC.CopyTo(R); //from GPU to CPU
                aTime = Math387.StopTimer();
                memo.AppendText("");
                memo.AppendText("Open CL timings:+ \n");
                memo.AppendText("\n");
                memo.AppendText("Function kernel (1x)  = " + Math387.FormatSample("0.00us", aTime * 1000 * 1000 / IterCount) + ", TotalTime = " + Math387.FormatSample("0.000s", aTime) + "\n");

                B.SetVal(ScalarB);
                C.SetVal(1);

                Math387.StartTimer();
                for (i = 0; i < IterCount; i++)
                {
                    switch (functionBox.SelectedIndex)
                    {
                        case 0:
                            C = C * B;
                            break;
                        case 1:
                            C = MtxExpr.Sin(C) + MtxExpr.Sin(B);
                            break;
                        case 2:
                            C = Math.Sqrt(4 * a / (2 * Math387.PI)) * a * MtxExpr.Sqr(B) * MtxExpr.Exp(-0.5 * a * MtxExpr.Sqr(B));
                            break;
                        case 3:
                            if (!B.Complex) { a = B.Mean(); } else { a = B.Meanc().Re; };
                            break;
                    }
                }
                bTime = Math387.StopTimer();

                memo.AppendText("\n");
                memo.AppendText("Intel IPP timings:\n");
                memo.AppendText("\n");
                memo.AppendText("IPP (1x) = " + Math387.FormatSample("0.00us", bTime * 1000 * 1000 / IterCount) + ", TotalTime = " + Math387.FormatSample("0.000s", bTime) + "\n");
                memo.AppendText("Ratio OpenCL/IPP = " + Math387.FormatSample("0.00x", bTime / aTime) + "\n");
                memo.AppendText("Ratio OpenCL/(Threaded IPP) = " + Math387.FormatSample("0.00x", bTime / (aTime * MtxVec.Controller.CpuCores * 0.9)) + "\n");
                memo.AppendText("Time/element = " + Math387.FormatSample("0.000ns", bTime * (1000000.0 / IterCount) * (1000.0 / VectorLen)) + "\n");

                switch (functionBox.SelectedIndex)
                {
                    case 0:
                    case 1:
                    case 2:
                        if (!R.IsEqual(C, 0.01, TCompare.cmpRelative)) Math387.ERaise("CPU and GPU results not equal!");
                        //3: if not Equal(ScalarB, a, 0.001) then ERaise("GPU results more accurate!");
                        break;
                }


                B.SetVal(ScalarB);
                C.SetVal(1);

                Math387.StartTimer();
                for (i = 0; i < (IterCount / 4); i++)
                {
                    a = 0;
                    sa = 0;
                    ac = "0";
                    sac = "0";

                    switch (C.FloatPrecision)
                    {
                        case TMtxFloatPrecision.mvSingle:
                            switch (functionBox.SelectedIndex)
                            {
                                case 0:
                                    for (k = 0; k <= C.Length - 1; k++) C.SValues[k] = C.SValues[k] * B.SValues[k];
                                    break;
                                case 1:
                                    for (k = 0; k <= C.Length - 1; k++) C.SValues[k] = Sin(C.SValues[k]) + Sin(B.SValues[k]);
                                    break;
                                case 2:
                                    for (k = 0; k <= C.Length - 1; k++) C.SValues[k] = Sqrt(4 * sa / (2 * PI_SINGLE)) * sa * Sqr(B.SValues[k]) * Exp(-0.5f * sa * Sqr(B.SValues[k]));
                                    break;
                                case 3:
                                    for (k = 0; k <= C.Length - 1; k++) sa = sa + C.SValues[k];
                                    break;
                            }
                            break;
                        case TMtxFloatPrecision.mvDouble:
                            switch (functionBox.SelectedIndex)
                            {
                                case 0:
                                    for (k = 0; k <= C.Length - 1; k++) C[k] = C[k] * B[k];
                                    break;
                                case 1:
                                    for (k = 0; k <= C.Length - 1; k++) C[k] = Sin(C[k]) + Sin(B[k]);
                                    break;
                                case 2:
                                    for (k = 0; k <= C.Length - 1; k++) C[k] = Sqrt(4 * a / (2 * PI)) * a * Sqr(B[k]) * Exp(-0.5 * a * Sqr(B[k]));
                                    break;
                                case 3:
                                    for (k = 0; k <= C.Length - 1; k++) a = a + C[k];
                                    break;
                            }
                            break;
                        case TMtxFloatPrecision.mvSingleComplex:
                            switch (functionBox.SelectedIndex)
                            {
                                case 0:
                                    for (k = 0; k <= C.Length - 1; k++) C.SCValues[k] = C.SCValues[k] * B.SCValues[k];
                                    break;
                                case 1:
                                    for (k = 0; k <= C.Length - 1; k++) C.SCValues[k] = Sin(C.SCValues[k]) + Sin(B.SCValues[k]);
                                    break;
                                case 2:
                                    for (k = 0; k <= C.Length - 1; k++) C.SCValues[k] = Sqrt(4 * sa / (2 * PI_SINGLE)) * sa * CSqr(B.SCValues[k]) * Exp(-0.5f * sa * CSqr(B.SCValues[k]));
                                    break;
                                case 3:
                                    for (k = 0; k <= C.Length - 1; k++) sac = sac + C.SCValues[k];
                                    break;
                            }
                            break;
                        case TMtxFloatPrecision.mvDoubleComplex:
                            switch (functionBox.SelectedIndex)
                            {
                                case 0:
                                    for (k = 0; k <= C.Length - 1; k++) C.CValues[k] = C.CValues[k] * B.CValues[k];
                                    break;
                                case 1:
                                    for (k = 0; k <= C.Length - 1; k++) C.CValues[k] = Sin(C.CValues[k]) + Sin(B.CValues[k]);
                                    break;
                                case 2:
                                    for (k = 0; k <= C.Length - 1; k++) C.CValues[k] = Sqrt(4 * a / (2 * PI)) * a * CSqr(B.CValues[k]) * Exp(-0.5 * a * CSqr(B.CValues[k]));
                                    break;
                                case 3:
                                    for (k = 0; k <= C.Length - 1; k++) ac = ac + C.CValues[k];
                                    break;
                            }
                            break;
                    }
                }
                bTime = Math387.StopTimer() * 4; //simulate longer running time

                memo.AppendText("\n");
                memo.AppendText("C# timings:\n");
                memo.AppendText("\n");
                memo.AppendText("C# (1x) = " + Math387.FormatSample("0.00us", bTime * 1000 * 1000 / IterCount) + ", TotalTime = " + Math387.FormatSample("0.000s", bTime) + "\n");
                memo.AppendText("Ratio OpenCL/C# = " + Math387.FormatSample("0.00x", bTime / aTime) + "\n");
                memo.AppendText("Ratio OpenCL/(Threaded C#)  = " + Math387.FormatSample("0.00x", bTime / (aTime * MtxVec.Controller.CpuCores * 0.9)) + "\n");
                memo.AppendText("Time/element = " + Math387.FormatSample("0.000ns", bTime * (1000000.0 / IterCount) * (1000.0 / VectorLen)) + "\n");
            }
            finally
            {
                clMtxVec.FreeIt(ref clA, ref clB, ref clC, ref clD);
                this.Cursor = Cursors.Default;
            }
        }         
    }
}
