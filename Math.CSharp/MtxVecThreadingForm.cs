using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using Dew.Math;
using Dew.Math.Units;
using System.Linq;
using System.CodeDom;

namespace MtxVecDemo
{
    public delegate void CalcMethod();

    public partial class MtxVecThreadingForm : Form
    {
        private int nx, ny, nz, nxyz;
        private int nh, nk, nl, nhkl;
        private double[] h, k, l, x, y, z; 
        private Vector vx, vy, vz; 
        private TCplx[] F, Fgold; 
        private string calcName;
        private double calcTime;
        private bool firstRun;
        private TOpenCLDevice device;
        private int cpuCores;
        private RichTextBox textBox1;

        public MtxVecThreadingForm()
        {
            InitializeComponent();
            FormCreate();
        }

        private void FormCreate()
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("The example tests several multithreading designs and compares to Open CL version of the same algorithm.\r\n" +
                "The algorithm tested is best suitable for Open CL acceleration, but it also serves great to show different approaches when applying multithreading to MtxVec based code running on CPU. Check out the source of this form for details about what is being compared.\r\n" +
                "For an in-depth analysis of the results please have look at the \"MtxVec Users Guide.pdf\".\r\n" +
                "(MtxVec needs to run in single precision to be directly comparable to Open CL results.)\r\n\r\n" +
                "The algorithm tested is a real world example kindly given by Matthew Wormington in use by www.jsvmi.com and takes roughly 5 lines of code.\r\n" +
                "The algorithm is based on the article: Fast computation of scattering maps of nanostructures using graphical processing units. Published in Journal of Applied Crystallography, Vol. 44, part 3, 2011.");

            firstRun = true;
            cpuCores = MtxVec.Controller.CpuCores;
            if (MtxForLoop.mtxThreadPool == null)
            {
                MtxForLoop.mtxThreadPool = new TMtxForLoop();
                MtxForLoop.mtxThreadPool.ThreadCount = cpuCores;
                MtxVec.Controller.ThreadDimension = MtxForLoop.mtxThreadPool.ThreadCount + 2;
            }

            // Configure thread pool for TParallel.For equivalent
            System.Threading.Tasks.ParallelOptions parallelOptions = new System.Threading.Tasks.ParallelOptions
            {
                MaxDegreeOfParallelism = cpuCores
            };
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            if (MtxForLoop.mtxThreadPool != null)
            {
                MtxForLoop.mtxThreadPool.Destroy();
                MtxForLoop.mtxThreadPool = null;
            }
            base.Dispose(disposing);
        }

        private void Fhkl(TOpenCLVector F, TOpenCLVector h, TOpenCLVector k, TOpenCLVector l, TOpenCLVector x, TOpenCLVector y, TOpenCLVector z)
        {
            TOpenCLKernel aKernel = device.Kernels.Locate("Fhkl");
            aKernel.SetArgBuffer(0, F.CData);
            aKernel.SetArgInt32(1, (int) F.CDataIndex(0));
            aKernel.SetArgBuffer(2, h.SData);
            aKernel.SetArgInt32(3, (int) h.SDataIndex(0));
            aKernel.SetArgBuffer(4, k.SData);
            aKernel.SetArgInt32(5, (int) k.SDataIndex(0));
            aKernel.SetArgBuffer(6, l.SData);
            aKernel.SetArgInt32(7, (int) l.SDataIndex(0));
            aKernel.SetArgInt32(8, h.Length);
            aKernel.SetArgBuffer(9, x.SData);
            aKernel.SetArgInt32(10, (int) x.SDataIndex(0));
            aKernel.SetArgBuffer(11, y.SData);
            aKernel.SetArgInt32(12, (int) y.SDataIndex(0));
            aKernel.SetArgBuffer(13, z.SData);
            aKernel.SetArgInt32(14, (int) z.SDataIndex(0));
            aKernel.SetArgInt32(15, z.Length);
            aKernel.Enqueue(h.CmdQueue, h.Length, false);
        }

        private void CreateCustomKernels()
        {
            if (device.Programs.Count > 1) device.Programs.Delete(1);
            TOpenCLProgram aProgram = device.Programs.Add();
            string binFileName = aProgram.BinaryFileName("XRD.c");
            TStringList sourceCode = new TStringList();
            sourceCode.Add(" __kernel void Fhkl (                          ");
            sourceCode.Add("  __global float *vf, const int vfIdx,        ");
            sourceCode.Add("  __global const float *vh, const int vhIdx,  ");
            sourceCode.Add("  __global const float *vk, const int vkIdx,  ");
            sourceCode.Add("  __global const float *vl, const int vlIdx,  ");
            sourceCode.Add("  const int nhkl,                             ");
            sourceCode.Add("  __global const float *vx, const int vxIdx,  ");
            sourceCode.Add("  __global const float *vy, const int vyIdx,  ");
            sourceCode.Add("  __global const float *vz, const int vzIdx,  ");
            sourceCode.Add("  const int nxyz)                             ");
            sourceCode.Add("{                                             ");
            sourceCode.Add("  for (int ix = get_global_id(0); ix < nhkl; ix += get_global_size(0))");
            sourceCode.Add("  {                                                                   ");
            sourceCode.Add("    const float TWOPI = 6.2831853071795862;                           ");
            sourceCode.Add("    const float h=TWOPI*vh[ix + vhIdx];                               ");
            sourceCode.Add("    const float k=TWOPI*vk[ix + vkIdx];                               ");
            sourceCode.Add("    const float l=TWOPI*vl[ix + vlIdx];                               ");
            sourceCode.Add("    float x, y, z, tmp;                                               ");
            sourceCode.Add("    float fr=0, fi=0;                                                 ");
            sourceCode.Add("                                                                      ");
            sourceCode.Add("    for(int i=0; i<nxyz; i++)                                         ");
            sourceCode.Add("    {                                                                 ");
            sourceCode.Add("      x=vx[i + vxIdx];                                                ");
            sourceCode.Add("      y=vy[i + vyIdx];                                                ");
            sourceCode.Add("      z=vz[i + vzIdx];                                                ");
            sourceCode.Add("      tmp=h*x + k*y + l*z;                                            ");
            sourceCode.Add("      fr += native_cos(tmp);                                          ");
            sourceCode.Add("      fi += native_sin(tmp);                                          ");
            sourceCode.Add("    }                                                                 ");
            sourceCode.Add("                                                                      ");
            sourceCode.Add("    vf[2*(ix + vfIdx)] = fr;                                          ");
            sourceCode.Add("    vf[2*(ix + vfIdx)+1] = fi;                                        ");
            sourceCode.Add("  }                                                                   ");
            sourceCode.Add("}                                                                     ");
            sourceCode.Add(" ");
            aProgram.LoadProgram(binFileName, sourceCode, "", "", true);
        }

        private void SetupOpenCL(int vectorLen)
        {
            if (firstRun)
            {
                firstRun  = false;
                ClMtxVec.clPlatform().UnMarkThreads();
                ClMtxVec.clPlatform().LoadProgramsForDevices(false, false, true, false, false);
                device = ClMtxVec.clPlatform().GetFirstGPUDevice();
                vectorLen = 2 * x.Length;
                device.Cache.SetCacheSize(15, vectorLen, 15, 15, 10);
                device.CommandQueue[0].MarkThread();
                CreateCustomKernels();
            }
        }

        private void Fcpu()
        {
            calcName = "CPU - only .NET code, one CPU core";
            Math387.StartTimer();
            int nhkl = h.Length;
            int nxyz = x.Length;
            for (int i = 0; i < nhkl; i++)
            {
                F[i] = Math387.C_ZERO;
                for (int j = 0; j < nxyz; j++)
                {
                    F[i] = F[i] + Math387.Expj(Math387.TWOPI * (h[i] * x[j] + k[i] * y[j] + l[i] * z[j]));
                }
            }
            calcTime = Math387.StopTimer();
        }

        private void Fmv()
        {
            calcName = "CPU - MtxVec (with expressions, without blocks, one CPU core)";
            Vector res = new Vector(); 
            Math387.StartTimer();
            vx.CopyFromArray(x);
            vy.CopyFromArray(y);
            vz.CopyFromArray(z);
            int nhkl = h.Length;
            for (int i = 0; i < nhkl; i++)
            {
                res.Expj(Math387.TWOPI * (h[i] * vx + k[i] * vy + l[i] * vz));
                F[i] = res.Sumc();
            }
            calcTime = Math387.StopTimer();
        }

        private void Fmvb()
        {
            calcName = "CPU - MtxVec (with expressions, with blocks, one CPU core).";
            Math387.MtxVecBlockSize = 500;
            Vector res = new Vector();
            Math387.StartTimer();
            vx.CopyFromArray(x);
            vy.CopyFromArray(y);
            vz.CopyFromArray(z);
            int nhkl = h.Length;
            for (int i = 0; i < nhkl; i++)
            {
                vx.BlockInit();
                vy.BlockInit();
                vz.BlockInit();
                while (!vx.BlockEnd)
                {
                    res.Expj(Math387.TWOPI * (h[i] * vx + k[i] * vy + l[i] * vz));
                    F[i] = F[i] + res.Sumc();
                    vx.BlockNext();
                    vy.BlockNext();
                    vz.BlockNext();
                }
            }
            calcTime = Math387.StopTimer();
        }

        private void Fmvbb()
        {
            calcName = "CPU - MtxVec (without expressions, with blocks, one CPU core)";
            Math387.MtxVecBlockSize = 1000;
            Vector res = new Vector();
            Vector temp = new Vector();
            Math387.StartTimer();
            vx.CopyFromArray(x);
            vy.CopyFromArray(y);
            vz.CopyFromArray(z);
            int nhkl = h.Length;
            for (int i = 0; i < nhkl; i++)
            {
                vx.BlockInit();
                vy.BlockInit();
                vz.BlockInit();
                while (!vx.BlockEnd)
                {
                    temp.Mul(vx, h[i] * Math387.TWOPI);
                    temp.AddScaled(vy, k[i] * Math387.TWOPI);
                    temp.AddScaled(vz, l[i] * Math387.TWOPI);
                    res.Expj(temp);
                    F[i] = F[i] + res.Sumc();
                    vx.BlockNext();
                    vy.BlockNext();
                    vz.BlockNext();
                }
            }
            calcTime = Math387.StopTimer();
        }

        private void MyLoop(int loopIndex, object[] context, int threadingIndex)
        {
            Vector res = new Vector();
            res.Expj(Math387.TWOPI * (h[loopIndex] * vx + k[loopIndex] * vy + l[loopIndex] * vz));
            F[loopIndex] = res.Sumc();
        }

        private void Fmvt()
        {
            calcName = "CPU - MtxVec (with expressions, without blocks, threaded (naive) with DoForLoop)";
            MtxForLoop.mtxThreadPool.ThreadCount = cpuCores;
            Math387.StartTimer();
            int nhkl = h.Length;
            vx.CopyFromArray(x);
            vy.CopyFromArray(y);
            vz.CopyFromArray(z);
            MtxVec.DoForLoop(0, nhkl - 1, MyLoop, null, null);
            calcTime = Math387.StopTimer();
        }

        private void MyLoopB(int idxMin, int idxMax, object[] context, int threadingIndex)
        {
            MtxVec.CreateIt(out TVec vxb, out TVec vyb, out TVec vzb, out TVec res);
            MtxVec.CreateIt(out TVec temp);
            try
            {
                vxb.BlockInit(vx);
                vyb.BlockInit(vy);
                vzb.BlockInit(vz);
                while (!vxb.BlockEnd)
                {
                    for (int i = idxMin; i <= idxMax; i++)
                    {
                        temp.Mul(vxb, h[i] * Math387.TWOPI);
                        temp.AddScaled(vyb, k[i] * Math387.TWOPI);
                        temp.AddScaled(vzb, l[i] * Math387.TWOPI);
                        res.Expj(temp);
                        F[i] = F[i] + res.Sumc();
                    }
                    vxb.BlockNext();
                    vyb.BlockNext();
                    vzb.BlockNext();
                }
            }
            finally
            {
                MtxVec.FreeIt(ref vxb, ref vyb, ref vzb, ref res);
                MtxVec.FreeIt(ref temp);
            }
        }

        private void Fmvtb()
        {
            calcName = "CPU - MtxVec (without expressions, with blocks, threaded with DoForLoop)";
            MtxForLoop.mtxThreadPool.ThreadCount = cpuCores;
            int nhkl = h.Length;
            Math387.StartTimer();
            vx.CopyFromArray(x);
            vy.CopyFromArray(y);
            vz.CopyFromArray(z);
            MtxVec.DoForLoop(0, nhkl - 1, MyLoopB, null, null);
            calcTime = Math387.StopTimer();
        }

        private void Fmvtba()
        {
            calcName = "CPU - MtxVec (without expressions, with blocks, threaded with DoForLoop and Anonymous method)";
            MtxForLoop.mtxThreadPool.ThreadCount = cpuCores;
            int nhkl = h.Length;
            Math387.StartTimer();
            vx.CopyFromArray(x);
            vy.CopyFromArray(y);
            vz.CopyFromArray(z);
            MtxVec.DoForLoop(0, nhkl - 1, (idxMin, idxMax, context, threadingIndex) =>
            {
                MtxVec.CreateIt(out TVec vxb, out TVec vyb, out TVec vzb, out TVec res);
                MtxVec.CreateIt(out TVec temp);
                try
                {
                    vxb.BlockInit(vx);
                    vyb.BlockInit(vy);
                    vzb.BlockInit(vz);
                    while (!vxb.BlockEnd)
                    {
                        for (int i = idxMin; i <= idxMax; i++)
                        {
                            temp.Mul(vxb, h[i] * Math387.TWOPI);
                            temp.AddScaled(vyb, k[i] * Math387.TWOPI);
                            temp.AddScaled(vzb, l[i] * Math387.TWOPI);
                            res.Expj(temp);
                            F[i] = F[i] + res.Sumc();
                        }
                        vxb.BlockNext();
                        vyb.BlockNext();
                        vzb.BlockNext();
                    }
                }
                finally
                {
                    MtxVec.FreeIt(ref vxb, ref vyb, ref vzb, ref res);
                    MtxVec.FreeIt(ref temp);
                }
            }, null, null);
            calcTime = Math387.StopTimer();
        }

        private void MtxVecThreadingForm_Load(object sender, EventArgs e)
        {

        }

        /*        private void MyLoopB2(int idxMin, int idxMax, object[] context, int threadingIndex)
                {
                    MtxVec.CreateIt(out TVec vxb, out TVec vyb, out TVec vzb, out TVec res);
                    MtxVec.CreateIt(out TVec temp);
                    try
                    {
                        vxb.BlockInit(vx);
                        vyb.BlockInit(vy);
                        vzb.BlockInit(vz);
                        while (!vxb.BlockEnd)
                        {
                            for (int i = idxMin; i <= idxMax; i++)
                            {
                                temp.Mul(vxb, h[i] * Math387.TWOPI);
                                temp.AddScaled(vyb, k[i] * Math387.TWOPI);
                                temp.AddScaled(vzb, l[i] * Math387.TWOPI);
                                res.Expj(temp);
                                F[i] = F[i] + res.Sumc();
                            }
                            vxb.BlockNext();
                            vyb.BlockNext();
                            vzb.BlockNext();
                        }
                    }
                    finally
                    {
                        MtxVec.FreeIt(ref vxb, ref vyb, ref vzb, ref res);
                        MtxVec.FreeIt(ref temp);
                    }
                }*/

        /*        private void Fmvtbb()
                {
                    calcName = "CPU - using MtxVec ( hand written blocks, threaded with DoForLoop)";
                    MtxForLoop.mtxThreadPool.ThreadCount = cpuCores;
                    int nhkl = h.Length;
                    Math387.StartTimer();
                    vx.CopyFromArray(x);
                    vy.CopyFromArray(y);
                    vz.CopyFromArray(z);
                    MtxVec.DoForLoop(0, nhkl - 1, MyLoopB2, null, null);
                    calcTime = Math387.StopTimer();
                }*/

        private void InternalFmvtbd(int aIndex, int aThreadCount, Vector vh, Vector vk, Vector vl)
        {
            int k = nhkl / aThreadCount;
            int idxMin = k * aIndex;
            int idxMax = k * (aIndex + 1);
            if (aIndex + 1 == aThreadCount) idxMax = nhkl - 1;

            MtxVec.CreateIt(out TVec vxb, out TVec vyb, out TVec vzb, out TVec res);
            MtxVec.CreateIt(out TVec tmp);
            try
            { 
                vxb.BlockInit(vx);
                vyb.BlockInit(vy);
                vzb.BlockInit(vz);
                while (!vxb.BlockEnd)
                {
                    for (int i = idxMin; i <= idxMax; i++)
                    {
                        tmp.Mul(vxb, vh.Values[i]* Math387.TWOPI);
                        tmp.AddScaled(vyb, vk.Values[i]* Math387.TWOPI);
                        tmp.AddScaled(vzb, vl.Values[i]* Math387.TWOPI);
                        //res.Expj(Math387.TWOPI * (vh.Values[i] * vxb + vk.Values[i] * vyb + vl.Values[i] * vzb));
                        res.Expj(tmp);
                        F[i] = F[i] + res.Sumc();
                    }
                    vxb.BlockNext();
                    vyb.BlockNext();
                    vzb.BlockNext();
                }
            }
            finally
            {
                MtxVec.FreeIt(ref vxb, ref vyb, ref vzb, ref res);
                MtxVec.FreeIt(ref tmp);
            }
        }

        private void Fmvtbd()
        {
            calcName = "CPU - MtxVec (without expressions, with blocks, threaded with Parallel.For)";
            int aThreadCount = cpuCores;
            Vector vh = new Vector();
            Vector vk = new Vector();
            Vector vl = new Vector();
            Math387.StartTimer();
            vx.CopyFromArray(x);
            vy.CopyFromArray(y);
            vz.CopyFromArray(z);
            vh.CopyFromArray(h);
            vk.CopyFromArray(k);
            vl.CopyFromArray(l);
            Parallel.For(0, aThreadCount, (aIndex) =>
            {
                MtxVec.Controller.MarkThread(); //required to enable separate memory pools for each thread
                InternalFmvtbd(aIndex, aThreadCount, vh, vk, vl);
                MtxVec.Controller.UnmarkThread();
            });
            calcTime = Math387.StopTimer();
        }

        private void Fclv()
        {
            calcName = "GPU - using OpenCL (TOpenClVector)";
            SetupOpenCL(2 * x.Length);

            ClMtxVec.CreateIt(out TOpenCLVector cx, out TOpenCLVector cy, out TOpenCLVector cz, out TOpenCLVector res);
            ClMtxVec.CreateIt(out TOpenCLVector tmp);
            try
            {
                Math387.StartTimer();
                cx.CopyFromArray(x);
                cy.CopyFromArray(y);
                cz.CopyFromArray(z);
                int nhkl = h.Length;
                for (int i = 0; i < nhkl; i++)
                {
                    tmp.Mul(cx, h[i] * Math387.TWOPI);
                    tmp.AddScaled(cy, k[i] * Math387.TWOPI);
                    tmp.AddScaled(cz, l[i] * Math387.TWOPI);
                    res.Expj(tmp);
                    //                    res.Expj(Math387.TWOPI * (h[i] * cx + k[i] * cy + l[i] * cz));
                    F[i] = res.Sumc();
                }
                calcTime = Math387.StopTimer();
            }
            finally
            {
                ClMtxVec.FreeIt(ref cx, ref cy, ref cz, ref res);
                ClMtxVec.FreeIt(ref tmp);
            }
        }

        private void Fclk()
        {
            calcName = "GPU - using OpenCL (custom kernel)";
            SetupOpenCL(2 * x.Length);

            Math387.StartTimer();

            ClMtxVec.CreateIt(out TOpenCLVector vF, out TOpenCLVector vh, out TOpenCLVector vk, out TOpenCLVector vl);
            ClMtxVec.CreateIt(out TOpenCLVector cx, out TOpenCLVector cy);
            ClMtxVec.CreateIt(out TOpenCLVector cz);
            try
            {
                vh.CopyFromArray(h);
                vk.CopyFromArray(k);
                vl.CopyFromArray(l);
                cx.CopyFromArray(x);
                cy.CopyFromArray(y);
                cz.CopyFromArray(z);
                vF.Size(vh.Length, TclFloatPrecision.clFloat, true);
                vF.SetZero();
                Fhkl(vF, vh, vk, vl, cx, cy, cz);
                vF.CopyToArray(ref F);
            }
            finally
            {
                ClMtxVec.FreeIt(ref vF, ref vh, ref vk, ref vl);
                ClMtxVec.FreeIt(ref cx, ref cy);
                ClMtxVec.FreeIt(ref cz);

                calcTime = Math387.StopTimer();
            }           
        }

        private void Benchmark(CalcMethod calcF)
        {
            int ix, iy, iz, ixyz;
            int ih, ik, il, ihkl;
            double[] absFgold, dAbsFgold; 
            double fom;
            nx = 30;
            ny = 30;
            nz = 30;
            nxyz = nx * ny * nz;
            x = new double[nxyz];
            y = new double[nxyz];
            z = new double[nxyz];
            ixyz = 0;
            for (ix = 0; ix < nx; ix++)
            {
                for (iy = 0; iy < ny; iy++)
                {
                    for (iz = 0; iz < nz; iz++)
                    {
                        x[ixyz] = ix;
                        y[ixyz] = iy;
                        z[ixyz] = iz;
                        ixyz++;
                    }
                }
            }
            nh = 30;
            nk = 30;
            nl = 30;
            nhkl = nh * nk * nl;
            h = new double[nhkl];
            k = new double[nhkl];
            l = new double[nhkl];
            ihkl = 0;
            Random rand = new Random();
            for (ih = 0; ih < nh; ih++)
            {
                for (ik = 0; ik < nk; ik++)
                {
                    for (il = 0; il < nl; il++)
                    {
                        h[ihkl] = 0.01f + (0.5f - 0.01f) * (float)rand.NextDouble();
                        k[ihkl] = 0.01f + (0.5f - 0.01f) * (float)rand.NextDouble();
                        l[ihkl] = 2.01f + (2.5f - 2.01f) * (float)rand.NextDouble();
                        ihkl++;
                    }
                }
            }
            F = new TCplx[nhkl];
            calcF();
            Fgold = new TCplx[nhkl];
            for (int i = 0; i < nhkl; i++)
            {
                TCplx term1 = Math387.Expj(Math.PI * h[i] * (nx - 1)) * (Math.Sin(Math.PI * h[i] * nx) / Math.Sin(Math.PI * h[i]));
                TCplx term2 = Math387.Expj(Math.PI * k[i] * (ny - 1)) * (Math.Sin(Math.PI * k[i] * ny) / Math.Sin(Math.PI * k[i]));
                TCplx term3 = Math387.Expj(Math.PI * l[i] * (nz - 1)) * (Math.Sin(Math.PI * l[i] * nz) / Math.Sin(Math.PI * l[i]));
                Fgold[i] = term1 * term2 * term3; // Use TCplx operator overloading
            }
            absFgold = new double[nhkl];
            dAbsFgold = new double[nhkl];
            for (int i = 0; i < nhkl; i++)
            {
                absFgold[i] = Math387.CAbs(Fgold[i]);
                dAbsFgold[i] = Math387.CAbs(F[i] - Fgold[i]); // Use TCplx operator overloading
            }
            fom = dAbsFgold.Average() / absFgold.Average();
            string s = string.Format("{0}: {1:F2} s", calcName, calcTime);
            if (fom > 0.01) s += " ERROR!";
            textBox1.AppendText(s + "\r\n");
            Application.DoEvents();
        }

        private void btnBenchmark_Click(object sender, EventArgs e)
        {
            if (MtxVec.Controller.Pool[0].Vec.CacheSize == 0)  this.Text = "MtxVec is running in Debug mode!";
            MessageBox.Show("This test could run 1-5 minutes!");
            Application.UseWaitCursor = true;
            try
            {
                Benchmark(Fcpu);
                Benchmark(Fmv);
                Benchmark(Fmvb);
                Benchmark(Fmvbb);
                Benchmark(Fmvt);
                Benchmark(Fmvtb);
                Benchmark(Fmvtba);
                //Benchmark(Fmvtbb);/not applicable to .NET, blocks always have to be optimized (without using expressions with Vector)
                Benchmark(Fmvtbd);
                Benchmark(Fclv);
                Benchmark(Fclk);
            }
            finally
            {
                Application.UseWaitCursor = false;
                Application.DoEvents();
            }           
        }

        #region Windows Form Designer generated code
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            btnBenchmark = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            textBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnBenchmark
            // 
            btnBenchmark.Location = new System.Drawing.Point(14, 225);
            btnBenchmark.Margin = new Padding(4, 3, 4, 3);
            btnBenchmark.Name = "btnBenchmark";
            btnBenchmark.Size = new System.Drawing.Size(117, 35);
            btnBenchmark.TabIndex = 3;
            btnBenchmark.Text = "Benchmark";
            btnBenchmark.UseVisualStyleBackColor = true;
            btnBenchmark.Click += btnBenchmark_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new System.Drawing.Point(18, 37);
            richTextBox1.Margin = new Padding(4, 3, 4, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(988, 170);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(14, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 23);
            label1.TabIndex = 0;
            label1.Text = "Description";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new System.Drawing.Point(149, 225);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(856, 468);
            textBox1.TabIndex = 4;
            textBox1.Text = "";
            // 
            // MtxVecThreadingForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1020, 708);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(btnBenchmark);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MtxVecThreadingForm";
            Text = "MtxVec Threading Benchmark";
            Load += MtxVecThreadingForm_Load;
            ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnBenchmark;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        #endregion
    }
}