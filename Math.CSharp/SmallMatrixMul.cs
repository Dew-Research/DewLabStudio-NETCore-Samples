using Dew.Math;
using Dew.Math.Units;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steema.TeeChart;
using Steema.TeeChart.Styles;

namespace MtxVecDemo
{
    public partial class SmallMatrixForm : Form
    {
        public SmallMatrixForm()
        {
            InitializeComponent();
            
            RichEdit1.Clear();
            RichEdit1.AppendText("Multiplying small matrices is challenging, because any error checking or layout detection code, will " +
                                "easily take more time than the computation itself. Hence the error checking needs to be reduced. For these reason the small matrix multiply routines " +
                                "are to be used with due care, with the code properly tested before deployed.\r\n\r\n" +
                                "Although we would expect that the overhead would be mostly visible for matrices 2x2 and 3x3, a considerable overhead exists all the way up to sizes of 30x30. " +
                                "It would appear that the multiplication kernel is so efficient, that if we are able to work without error checking, the performance benefit is considerable. " +
                                "It is true that at the matrix size 2x2 the maximum performance improvement is 100x, but even at 50x50 it is still 30%.\r\n\r\n" +
                                "Another interesting observation are the breaks at matrix sizes 24, 32, 40 and 48, which are most efficient sizes to use and recommended to match " +
                                "when used for block processing. Furthermore, by looking at the ratios of time between matrix 16x16 and 4x4, even though the bigger matrix has (16/4)^3 = 64x more processing " +
                                "requirement, it is roughly only 8-14x slower. This points to the next small matrix optimization possibility. Batched processing of small matrices should be even more " +
                                "performance efficient, aiming for another factor of 10x improvement, for very small matrices over what JIT can deliver, if of course we can rearrange our own code in such a way, that we can take advantage of that.\r\n\r\n" +
                                "Press run to run the benchmark, which compares different APIs for small matrix multiply. " +
                                "Check the benchmark source code to determine how individual api interfaces look. Smaller values in the chart below are better.\r\n\r\n" +
                                "The recommended api to start with is TMtx.MulSmallInit and TMtx.MulSmall. This api maintains some of the error checking and ease of use, but still delivers decent " +
                                "performance in most cases.");

            Chart1.Series.Clear();
            string[] titles = new string[] { "Matrix.Mul (dgemm)", "C#", "Jitted array", "Jitted pointer", "Jitted TMtx", "Jitted Matrix", "Jitted Matrix.MulSmall" };
            PointerStyles[] styles = new PointerStyles[] { PointerStyles.Rectangle, PointerStyles.Circle, PointerStyles.Triangle, PointerStyles.Cross, PointerStyles.DiagCross, PointerStyles.Star, PointerStyles.Diamond };

            for (int i = 0; i < 7; i++)
            {
                Line series = new Line();
                series.Title = titles[i];
                series.Pointer.Visible = true;
                series.Pointer.Style = styles[i];
                Chart1.Series.Add(series);
            }

            jit = new TSmallMatrixMultiply();
        }

        private void FormDestroy(object sender, FormClosingEventArgs e)
        {
            jit.Destroy();
            base.Dispose(true);
        }

        private void CSharpMul(double[] A, double[] B, double[] C, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    double sum = 0.0;
                    for (int k = 0; k < n; k++)
                    {
                        sum += A[i * n + k] * B[k * n + j];
                    }
                    C[i * n + j] = sum;
                }
            }
        }

        private void CSharpMul(TCplx[] A, TCplx[] B, TCplx[] C, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    TCplx sum = Math387.Cplx(0, 0);
                    for (int k = 0; k < n; k++)
                    {
                        sum += A[i * n + k] * B[k * n + j];
                    }
                    C[i * n + j] = sum;
                }
            }
        }

        private void Button1Click(object sender, EventArgs e)
        {
            Matrix am = new Matrix();
            Matrix bm = new Matrix();
            Matrix cm = new Matrix();

            double[] a = null, b = null, c = null;
            double[] ac1 = null, bc1 = null, cc1 = null;
            TCplx[] ac = null, bc = null, cc = null;
            TMtx ap, bp, cp;


            int Iters = ComplexBox.Checked ? 3000 : 15000;
            int MaxSize = 50;
            Matrix aTimings = new Matrix();
            aTimings.Size(Chart1.Series.Count, MaxSize);
            Cursor.Current = Cursors.WaitCursor;
            jitLabel.Text = "JIT kernel used for all sizes";

            MtxVec.CreateIt(out TMtx am1, out TMtx bm1, out TMtx cm1);
            try
            {
                for (int i = 0; i < aTimings.Cols; i++)
                {
                    int aRows = i + 2;
                    int aCols = aRows;

                    if (!ComplexBox.Checked)
                    {
                        a = new double[aRows * aCols];
                        b = new double[aRows * aCols];
                        c = new double[aRows * aCols];
                    }
                    else
                    {
                        ac = new TCplx[aRows * aCols];
                        bc = new TCplx[aRows * aCols];
                        cc = new TCplx[aRows * aCols];

                        ac1 = new double[aRows * aCols * 2];
                        bc1 = new double[aRows * aCols * 2];
                        cc1 = new double[aRows * aCols * 2];
                    }

                    am.Size(aRows, aCols, ComplexBox.Checked);  //local vars
                    bm.Size(am);
                    cm.Size(am);

                    ap = am;
                    bp = bm;
                    cp = cm;

                    am1.Size(aRows, aCols, ComplexBox.Checked); //from object cache
                    bm1.Size(am1);
                    cm1.Size(am1);

                    // Matrix.Mul
                    Math387.StartTimer();
                    for (int j = 0; j < Iters; j++)
                    {
                        cm.Mul(am, bm);
                    }
                    aTimings.Values[0, i] = Math387.StopTimer() * 1000;

                    if (!ComplexBox.Checked)
                    {
                        if (aRows < 10)
                        {
                            Math387.StartTimer();
                            for (int j = 0; j < Iters; j++)
                            {
                                CSharpMul(a, b, c, aRows);
                            }
                            aTimings.Values[1, i] = Math387.StopTimer() * 1000;
                        }
                        else
                        {
                            aTimings.Values[1, i] = 0;
                        }
                    }
                    else
                    {
                        if (aRows < 10)
                        {
                            Math387.StartTimer();
                            for (int j = 0; j < Iters; j++)
                            {
                                CSharpMul(ac, bc, cc, aRows);
                            }
                            aTimings.Values[1, i] = Math387.StopTimer() * 1000;
                        }
                        else
                        {
                            aTimings.Values[1, i] = 0;
                        }
                    }

                    if (!jit.Init(am1, bm1, cm1, TMtxOperation.opNone, TMtxOperation.opNone, 1, 0))
                    {
                        jitLabel.Text = $"JIT worked up to size: {aRows}x{aCols}";
                    }

                    if (!ComplexBox.Checked)
                    {
                        Math387.StartTimer();
                        for (int j = 0; j < Iters; j++)
                        {
                            jit.MulKernelDouble(jit.jitter, a, b, c);
                        }
                        aTimings.Values[2, i] = Math387.StopTimer() * 1000;
                    }
                    else
                    {
                        Math387.StartTimer();
                        for (int j = 0; j < Iters; j++)
                        {
                            jit.MulKernelComplexDouble(jit.jitter, ac1, bc1, cc1);
                        }
                        aTimings.Values[2, i] = Math387.StopTimer() * 1000;
                    }

                    Math387.StartTimer();
                    for (int j = 0; j < Iters; j++)
                    {
                        jit.Mul();
                    }
                    aTimings.Values[3, i] = Math387.StopTimer() * 1000;

                    ap = am;
                    bp = bm;
                    cp = cm;

                    Math387.StartTimer();
                    for (int j = 0; j < Iters; j++)
                    {
                        jit.Mul(ap, bp, cp);
                    }
                    aTimings.Values[4, i] = Math387.StopTimer() * 1000;

                    Math387.StartTimer();
                    for (int j = 0; j < Iters; j++)
                    {
                        jit.Mul(am, bm, cm);
                    }
                    aTimings.Values[5, i] = Math387.StopTimer() * 1000;

                    cm1.MulSmallInit(am1, bm1, TMtxOperation.opNone, TMtxOperation.opNone, 1.0, 0.0);
                    Math387.StartTimer();
                    for (int j = 0; j < Iters; j++)
                    {
                        cm1.MulSmall(am1, bm1);
                    }
                    aTimings.Values[6, i] = Math387.StopTimer() * 1000;
                }
            }
            finally
            {
                MtxVec.FreeIt(ref am1, ref bm1, ref cm1);
            }

            if (ComplexBox.Checked)
            {
                aTimings.Scale(5);
            }

            Chart1.Axes.Left.Automatic = false;
            for (int i = 0; i < aTimings.Rows; i++)
            {
                Chart1.Series[i].Clear();
                for (int j = 0; j < aTimings.Cols; j++)
                {
                    if (aTimings.Values[i, j] != 0)
                    {
                        Chart1.Series[i].Add(aTimings.Values[i, j], $"{j + 2}x{j + 2}");
                    }
                }
            }

            Chart1.Axes.Left.SetMinMax(0, 1.1 * aTimings.Max());
            Cursor.Current = Cursors.Default;
        }

        private void ComplexBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
