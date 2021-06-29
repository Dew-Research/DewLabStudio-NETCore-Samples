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
    public partial class clCustomFunctionForm : Form
    {
        int VectorLen;
        Dew.Math.TOpenCLDevice selectedDevice;
        TOpenCLPlatformList clPlatforms;

        public clCustomFunctionForm()
        {
            InitializeComponent();
            clPlatforms = clMtxVec.clPlatform();
        }
       
        private void platformListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
              int i;
              TStringList DeviceList = new TStringList();

              for (i = 0; i < clPlatforms[platformListBox.SelectedIndex].Count; i++)  {
                     DeviceList.Add(clPlatforms[platformListBox.SelectedIndex][i].Name);
              }

              deviceListBox.Items.Clear();
              for (i = 0; i < DeviceList.Count; i++)      {
                   deviceListBox.Items.Add(DeviceList[i]);
              }
              deviceListBox.SelectedIndex = 0;
        }

        private void CreateCustom() //compile custom function
        {
            TStringList SourceCode = new TStringList();  
            string aBinFileName;
            TOpenCLProgram aProgram;

            if (selectedDevice.Programs.Count > 1 ) selectedDevice.Programs.Delete(1);
            aProgram = selectedDevice.Programs.Add();

            SourceCode.Add("__kernel void vec_sin_f (__global const float *a, const int aIdx,");
            SourceCode.Add("  	               __global const float *b, const int bIdx,      ");
            SourceCode.Add("		       	     __global float *c, const int cIdx,              ");
            SourceCode.Add("                             const int Length)                   ");
            SourceCode.Add("{                                                                ");
            SourceCode.Add("	size_t i = get_global_id(0);                                   ");
            SourceCode.Add("                                                                 ");
            SourceCode.Add("	c[i + cIdx] = sin(a[i + aIdx]) + b[i + bIdx];                  ");
            SourceCode.Add("                                                                 ");
            SourceCode.Add("}                                                                ");

            aBinFileName = aProgram.BinaryFileName("MySource.cl"); //give a unique and descriptive name
            aProgram.LoadProgram(aBinFileName, SourceCode, "", "", true); //always rebuild source
        }

        private void vec_sin_f(TOpenCLVector a, TOpenCLVector b, TOpenCLVector Result)
        {
             TOpenCLKernel aKernel;
             if (a.Length != b.Length) throw new Exception("a.Length <> b.Length");
             Result.Size(a);

             aKernel = a.Device.Kernels.Locate("vec_sin_f");
             aKernel.SetArgBuffer(0, a.SData);
             aKernel.SetArgInt32(1, (int) a.SDataIndex(0)); //SDataIndex typically does not return 0 (!!)
             aKernel.SetArgBuffer(2, b.SData);
             aKernel.SetArgInt32(3, (int) b.SDataIndex(0)); //SDataIndex typically does not return 0 (!!)
             aKernel.SetArgBuffer(4, Result.SData);
             aKernel.SetArgInt32(5, (int) Result.SDataIndex(0)); //SDataIndex typically does not return 0 (!!)
             aKernel.SetArgInt32(6, a.Length);

            aKernel.Enqueue(a.CmdQueue, a.Length, false); //auto local work size and no CPU adjust
        }

        private void DoCompute()
        {
            Vector A = new Vector(VectorLen, TMtxFloatPrecision.mvSingle);
            Vector B = new Vector(VectorLen, TMtxFloatPrecision.mvSingle);               
            Vector R = new Vector(VectorLen, TMtxFloatPrecision.mvSingle);
            Vector C; 
            TOpenCLVector clB, clC, clA;
            
            A.SetVal(0.5);
            B.SetVal(0);


            clMtxVec.CreateIt(out clB,out clC);
            clMtxVec.CreateIt(out clA);
            try
            {                    
                clA.Copy(A);
                clB.Copy(B);
                vec_sin_f(clA, clB, clC);  //call custom function here
                C = MtxExpr.Sin(A) + B;

                clC.CopyTo(R);
                if (!C.IsEqual(R, 1E-4, TCompare.cmpAbsolute))
                {
                    throw new Exception("Not equal");
                }
                else MessageBox.Show("Function works!");
            }
            finally
            {
                clMtxVec.FreeIt(ref clA, ref clB);
                clMtxVec.FreeIt(ref clC);
                this.Cursor = Cursors.Default;
            }
         }

        private void button2_Click(object sender, EventArgs e)
        {
            VectorLen = Convert.ToInt32(vectorLengthBox.Text);

            clPlatforms.UnMarkThreads();
            selectedDevice = clPlatforms[platformListBox.SelectedIndex][deviceListBox.SelectedIndex];
            selectedDevice.Cache.SetCacheSize(50, VectorLen, 50, 50, 50);
            selectedDevice.CommandQueue[0].MarkThread(); //UserThread := GetCurrentThreadID;
            CreateCustom();
            DoCompute();

        }

        private void LoadTest(object Sender)
        {
            TOpenCLVector clB, clC, clA, clD;
            int i;

            clMtxVec.CreateIt(out clA, out clB, out clC, out clD);
            try
            {
                clA.Size(VectorLen, TclFloatPrecision.clFloat, false);
                clA.SetVal(1);

                clB.Size(VectorLen, TclFloatPrecision.clFloat, false);
                clB.SetVal(2);

                for (i = 0; i < 300; i++)
                {
                    clD.Sin(clA);
                    clC.Add(clD, clB);
                }

                clC.Finish(); //Wait for computation on GPU to finish
            }
            finally {
                clMtxVec.FreeIt(ref clA, ref clB, ref clC, ref clD);
            }

        }

        private void AutoDeviceButton_Click(object sender, EventArgs e)
        {
            TOpenCLDevice aDevice;
            VectorLen = Convert.ToInt32(vectorLengthBox.Text);

            this.Cursor = Cursors.WaitCursor;

            aDevice = clPlatforms.AutoDeviceSelect(LoadTest, 10, VectorLen);

            platformListBox.SelectedIndex = aDevice.PlatformIndex;
            platformListBox_SelectedIndexChanged(null, null);
            deviceListBox.SelectedIndex = aDevice.DeviceIndex;

            this.Cursor = Cursors.Default;
        }

        private void clCustomFunctionForm_Load(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "The platform list shows the Open CL drivers  " +
                                        "available on your computer. If you dont have a AMD or Nvidia GPU " + 
                                        "you can still install Intel or Open CL drivers which " 
                                      + "run on the CPU alone. "
                                      + "Intel drivers require at least SSE4.x (Core 2) capable hardware. "
                                      + "Presence of Intel drivers also slows down the start of the "
                                      + "application by 20seconds. \n"
                                      + "Press run to execute the custom function on the selected platform. \n";

            //Main form requires:
            //protected override void Dispose( bool disposing )
            //{
            //    clMtxVec.clPlatform.Free();

            int i, k, kernelSum;

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
                MessageBox.Show("When loading the first time, the Open CL drivers need to recompile the source code."
                      + "This may take a minute or longer. If you have Intel Open CL drivers installed they "
                      + "add 20s delay regardless, if the program is precompiled.");
                clPlatforms.LoadProgramsForDevices(false, false, true, false, false);
                this.Cursor = Cursors.Default;
            }

            VectorLen = (int)Math.Round(Math387.Exp2(19));
            vectorLengthBox.Text = VectorLen.ToString();
        }         
    }
}
