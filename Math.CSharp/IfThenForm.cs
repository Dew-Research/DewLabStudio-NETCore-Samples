using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Units;

namespace MtxVecDemo
{
        public struct ThreadStats
        {
            public double TotalTime;
            public int PoolIndex;
            public int aCI;
            public int bCI;
            public int agCI;
            public int bgCI;
            public int aiCI;
            public int cCI;
            public int TotalLength;
            public int BlockLength;
        }

        public partial class IfThenForm : Form
        {
            private const double DPOS_FRAC = 0.5;
            private const float SPOS_FRAC = 0.5f;
            private ThreadStats[] stats;

            public IfThenForm()
            {
                InitializeComponent();
                FormCreate();
            }

            private void FormCreate()
            {
                if (MtxForLoop.mtxThreadPool == null)
                {
                        MtxForLoop.mtxThreadPool = new TMtxForLoop();
                }
                MtxForLoop.mtxThreadPool.ThreadCount = MtxVec.Controller.CpuCores;
                MtxVec.Controller.ThreadDimension = MtxForLoop.mtxThreadPool.ThreadCount + 2;

                Memo1.Clear();
                Memo1.AppendText("Efficient if-then vectorization is possible with the use of masks. Using sparse indexes does not allow for vectorization.\r\n" +
                                 "The example below handles memory block much larger than CPU cache and applies:\r\n\r\n" +
                                 "if a[i] >= 0.5 then b[i] := (b[i] + 1)*2;\r\n\r\n" +
                                 "The different cases start with Delphi and end with multithreaded vectorized code. The performance of multi-threaded " +
                                 "variants depends heavily on active CPU memory channel count (typically 1, 2 or 4).\r\n" +
                                 "The example demonstrates two features: ability to vectorize if-then and ability to thread code, which takes less than 20ms to execute.");

                DataLenBox.SelectedIndex = 2;
                GranBox.SelectedIndex = 1; 
        }

            private void DoAssign(ref int dst, int src)
            {
                if (dst == -2) dst = src;
            }

            private void ForLoopR(int idxMin, int idxMax, object[] context, int threadIndex)
            {
                long aTime = 0;
                Math387.StartTimer(ref aTime);

                MtxVec.CreateIt(out TVec ag, out TVec bg, out TVec a, out TVec b);
                MtxVec.CreateIt(out TVec c, out TVec c2);
                MtxVecInt.CreateIt(out TVecInt ai);
                try
                {
                    ag.SetSubRange((TVec)context[0], idxMin, idxMax - idxMin + 1);
                    bg.SetSubRange((TVec)context[1], idxMin, idxMax - idxMin + 1);

                    a.BlockInit(ag);
                    b.BlockInit(bg);

                    stats[threadIndex].BlockLength = a.Length;

                    while (!a.BlockEnd)
                    {
                        AbstractMtxVec.FindMask(ai, a, TMtxCompareOp.cmpGT_EQ, DPOS_FRAC);
                        //ai.FindMask(a, ">=", DPOS_FRAC);
                        c2.GatherByMask(b, ai, -1 );

                        c.AddAndMul(c2, 1, 2);
                        //c.Add(1);
                        //c.Mul(2);
                        b.ScatterByMask(c, ai, false);

                        a.BlockNext();
                        b.BlockNext();
                    }

                    DoAssign(ref stats[threadIndex].PoolIndex, ag.PoolIndex);
                    DoAssign(ref stats[threadIndex].TotalLength, ag.Length);
                    DoAssign(ref stats[threadIndex].aCI, a.CacheIndex);
                    DoAssign(ref stats[threadIndex].bCI, b.CacheIndex);
                    DoAssign(ref stats[threadIndex].cCI, c.CacheIndex);
                    DoAssign(ref stats[threadIndex].agCI, ag.CacheIndex);
                    DoAssign(ref stats[threadIndex].bgCI, bg.CacheIndex);
                    DoAssign(ref stats[threadIndex].aiCI, ai.CacheIndex);
                }
                finally 
                {
                    MtxVec.FreeIt(ref ag, ref bg, ref a, ref b);
                    MtxVec.FreeIt(ref c, ref c2);
                    MtxVecInt.FreeIt(ref ai);
                }

                stats[threadIndex].TotalTime = Math387.StopTimer(aTime);
            }

            private void ForLoopRI(int idxMin, int idxMax, object[] context, int threadIndex)
            {                
                 TVec a = (TVec) context[0];
                 TVec b = (TVec) context[1];

                 if (a.IsDouble)
                 {
                     for (int i = idxMin; i <= idxMax; i++)
                     {
                         if (a.Values[i] >= DPOS_FRAC) b.Values[i] = (b.Values[i] + 1.0) * 2.0;
                     }
                 }
                 else
                 {
                     for (int i = idxMin; i <= idxMax; i++)
                     {
                         if (a.SValues[i] >= SPOS_FRAC) b.SValues[i] = (b.SValues[i] + 1) * 2;
                     }
                 }
            }

            private void MaskThreadButtonClick(object sender, EventArgs e)
            {
                stats = new ThreadStats[MtxForLoop.mtxThreadPool.ThreadCount];
                for (int i = 0; i < stats.Length; i++)
                {
                    stats[i].TotalTime = -2;
                    stats[i].PoolIndex = -2;
                    stats[i].TotalLength = -2;
                    stats[i].BlockLength = -2;
                    stats[i].aCI = -2;
                    stats[i].bCI = -2;
                    stats[i].cCI = -2;
                    stats[i].agCI = -2;
                    stats[i].bgCI = -2;
                    stats[i].aiCI = -2;
                }

                barSeries.Clear();
                double[] ar = new double[6];

                int dataLen = 100000 * (int)Math.Pow(10, DataLenBox.SelectedIndex);

                TVecInt ai = new TVecInt();
                TVec c = new TVec();
                TVec c2 = new TVec();

                TVec a = new TVec();
                TVec b1 = new TVec();
                TVec b2 = new TVec();

                a.Size(dataLen);
                a.RandUniform(0, 1);
                b1.Size(a);
                b1.SetVal(1);
                b2.Copy(b1);

                Math387.StartTimer();

                for (int i = 0; i < a.Length; i++)
                {
                    if (a.Values[i] >= DPOS_FRAC) b1.Values[i] = (b1.Values[i] + 1) * 2;
                }

                ar[0] = Math.Round(Math387.StopTimer() * 1000);

                if (PlainBox.Checked)
                {
                    barSeries.Add(ar[0], "Plain");
                }

                if (VecBox.Checked)
                {
                    Math387.StartTimer();

                    AbstractMtxVec.FindMask(ai, a, TMtxCompareOp.cmpGT_EQ, DPOS_FRAC);
                    c2.GatherByMask(b2, ai, -1);
                    c.AddAndMul(c2, 1, 2);
                    //c.Add(1);
                    //c.Mul(2);
                    b2.ScatterByMask(c, ai, false);

                    ar[1] = Math387.StopTimer() * 1000;
                    barSeries.Add(ar[1], "Vectorized\r\n");

                    if (!b1.IsEqual(b2, 0.001, TCompare.cmpAbsolute)) throw new Exception("Not equal");
                    b2.SetVal(1); // reset
                }

                if (FindIndexBlockBox.Checked)
                {
                    Math387.StartTimer();

                    a.BlockInit();
                    b2.BlockInit();
                    while (!a.BlockEnd)
                    {
                        MtxVec.FindIndexes(ai, a, ">=", DPOS_FRAC);
                        c2.GatherByIndex(b2, ai);
                        c.AddAndMul(c2, 1, 2);
                        //c.Add(1);
                        //c.Mul(2);
                        b2.ScatterByIndexes(c, ai);

                        a.BlockNext();
                        b2.BlockNext();
                    }
                    b2.SetFullRange();
                    ai.SetFullRange();

                    ar[2] = Math387.StopTimer() * 1000;
                    barSeries.Add(ar[2], "Vectorized with bp (FindIndexes)");

                    if (!b1.IsEqual(b2, 0.001, TCompare.cmpAbsolute)) throw new Exception("Not equal");
                    b2.SetVal(1); // reset
                }

                if (MaskBlockBox.Checked)
                {
                    Math387.StartTimer();

                    a.BlockInit();
                    b2.BlockInit();
                    while (!a.BlockEnd)
                    {
                        AbstractMtxVec.FindMask(ai, a, TMtxCompareOp.cmpGT_EQ, DPOS_FRAC);
                        c2.GatherByMask(b2, ai, -1);
                        c.AddAndMul(c2, 1, 2);  
                    //  c.Add(1);
                    //  c.Mul(2);
                        b2.ScatterByMask(c, ai, false);

                        a.BlockNext();
                        b2.BlockNext();
                    }
                    b2.SetFullRange();

                    ar[3] = Math387.StopTimer() * 1000;
                    barSeries.Add(ar[3], "Vectorized with bp (FindMask)\r\n");

                    if (!b1.IsEqual(b2, 0.001, TCompare.cmpAbsolute)) throw new Exception("Not equal");
                    b2.SetVal(1); // reset
                }

                MtxForLoop.mtxThreadPool.BlockGranularity = (int)Math.Pow(2, GranBox.SelectedIndex);

                if (MaskBlockThreadBox.Checked)
                {
                    Math387.StartTimer();
                    MtxVec.DoForLoop(0, a.Length - 1, ForLoopR, null, new object[] { (TVec) a, (TVec) b2 });
                    ar[4] = Math387.StopTimer() * 1000;
                    barSeries.Add(ar[4], "Vectorized, bp and threaded");

                    if (!b1.IsEqual(b2, 0.001, TCompare.cmpAbsolute)) throw new Exception("Not equal");
                    b2.SetVal(1); // reset
                }

                if (PlainThreadBox.Checked)
                {
                    Math387.StartTimer();
                    MtxVec.DoForLoop(0, a.Length - 1, ForLoopRI, null, new object[] { (TVec)a, (TVec)b2 });
                    ar[5] = Math387.StopTimer() * 1000;
                    barSeries.Add(ar[5], "Plain and threaded\r\n");

                    if (!b1.IsEqual(b2, 0.001, TCompare.cmpAbsolute)) throw new Exception("Not equal");
                }

                Memo1.Clear();
                Memo1.AppendText("ThrdIdx\tTime\t\tPool\tLength\tbLength\ta_cIdx\tb_cIdx\tc_cIdx\tag_cIdx\tbg_cIdx\tai_cIdx\r\n");
                for (int i = 0; i < stats.Length; i++)
                {
                    Memo1.AppendText($"{i}\t\t{stats[i].TotalTime * 1000:F2}ms\t{stats[i].PoolIndex}\t{stats[i].TotalLength}\t{stats[i].BlockLength}\t\t" +
                                     $"{stats[i].aCI}\t\t{stats[i].bCI}\t\t{stats[i].cCI}\t\t{stats[i].agCI}\t\t{stats[i].bgCI}\t\t{stats[i].aiCI}\r\n");
                }
            }

        private void DataLenBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
