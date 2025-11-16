using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dew.Math.Units;
using Dew.Math;
using Steema.TeeChart;
using Steema.TeeChart.Styles;
using System.Windows.Forms;


namespace MtxVecDemo
{ 
    public enum TestMethod
    {
        GetMem,
        TVec,
        Vector,
        VectorGlobal
    }

    public partial class CompoundExpressionsForm : Form
    {
        private double[,] Timings = new double[2, 6];
        //private int ak, ac;
        //private int VectorLen;
        //private int Stage;

        private void FormCreate()
        {
            Memo.Clear();
            Memo.AppendText("Compound expressions join together multiple (+,-,/,*) math operations in to a single loop thus increasing the possibility to vectorize code and lower the " +
                            "use of main memory bandwidth. The functions are available for TVec/TMtx and Vector/Matrix types. Check below the performance advantage by pressing Run. " +
                            "In this benchmark only 6 different variants are compared, but a total of 162 distinct overloads have been added with version 6.31 to the TVec and the same also to TMtx.\r\n\r\n" +
                            "Note that the more complex expressions take about equal time as the simpler math operations.");
        }

        private void DoublePrecisionMath()
        {
            int loops = 10000;
            List<string> labels = new List<string>();
            Vector aDst = new Vector();
            Vector bDst = new Vector();
            Vector x = new Vector();
            Vector y = new Vector();
            Vector z = new Vector();

            Series1.Title = "Double Compound";
            Series2.Title = "Double Sequenced";
            labels.Clear();
            x.Size(1000);
            x.Ramp();
            y.Size(x);
            y.SetVal(2.1);
            z.Size(x);
            z.SetVal(3.5);

            // X*xScale + Y*yScale + Z*zScale
            labels.Add("X*xScale + Y*yScale + Z*zScale");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.AddScaled(x, 2.0, y, 3.0, z, 4.0);
            }
            Timings[0, 0] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Mul(x, 2.0);
                bDst.AddScaled(y, 3.0);
                bDst.AddScaled(z, 4.0);
            }
            Timings[1, 0] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst, 1E-5, TCompare.cmpAbsolute)) throw new Exception("Not equal");

            // X + Y + Z
            labels.Add("X + Y + Z");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.Add(x, y, z);
            }
            Timings[0, 1] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Add(x, y);
                bDst.Add(z);
            }
            Timings[1, 1] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst, 1E-5, TCompare.cmpAbsolute)) throw new Exception("Not equal");

            // (X*xScale + Y*yScale)*Z*zScale
            labels.Add("(X*xScale + Y*yScale)*Z*zScale");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.AddAndMul(x, 2.0, y, 3.0, z, 4.0);
            }
            Timings[0, 2] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Mul(x, 2.0);
                bDst.AddScaled(y, 3.0);
                bDst.Mul(z);
                bDst.Mul(4.0);
            }
            Timings[1, 2] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst, 1E-5, TCompare.cmpAbsolute)) throw new Exception("Not equal");

            // (X + Y)*Z
            labels.Add("(X + Y)*Z");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.AddAndMul(x, y, z);
            }
            Timings[0, 3] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Add(x, y);
                bDst.Mul(z);
            }
            Timings[1, 3] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst, 1E-5, TCompare.cmpAbsolute)) throw new Exception("Not equal");

            // X*Y*xyScale + Z*zScale
            labels.Add("X*Y*xyScale + Z*zScale");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.MulAndAdd(x, y, 3.0, z, 4.0);
            }
            Timings[0, 4] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Mul(x, y);
                bDst.Mul(3.0);
                bDst.AddScaled(z, 4.0);
            }
            Timings[1, 4] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst, 1E-5, TCompare.cmpAbsolute)) throw new Exception("Not equal");

            // X*Y + Z
            labels.Add("X*Y + Z");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.MulAndAdd(x, y, z);
            }
            Timings[0, 5] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Mul(x, y);
                bDst.Add(z);
            }
            Timings[1, 5] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst, 1E-5, TCompare.cmpAbsolute)) throw new Exception("Not equal");

            Series1.Clear();
            Series2.Clear();
            for (int i = 0; i < Timings.GetLength(1); i++)
            {
                Series1.Add(Timings[0, i], labels[i]);
                Series2.Add(Timings[1, i], labels[i]);
            }
        }

        private void ComplexDoublePrecisionMath()
        {
            int loops = 10000;
            List<string> labels = new List<string>();
            Vector aDst = new Vector();
            Vector bDst = new Vector();
            Vector x = new Vector();
            Vector y = new Vector();
            Vector z = new Vector();

            Series1.Title = "Complex Compound";
            Series2.Title = "Complex Sequenced";
            labels.Clear();
            x.Size(1000, true); // Complex vector
            x.Ramp();
            y.Size(x);
            y.SetVal(Math387.Cplx(2.1, 1.9));
            z.Size(x);
            z.SetVal(Math387.Cplx(3.5, 2.5));

            // X*xScale + Y*yScale + Z*zScale
            labels.Add("X*xScale + Y*yScale + Z*zScale");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.AddScaled(x, Math387.Cplx(2.0, 1.3), y, Math387.Cplx(3.0, 1.2), z, Math387.Cplx(4.0, 1.8));
            }
            Timings[0, 0] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Mul(x, Math387.Cplx(2.0, 1.3));
                bDst.AddScaled(y, Math387.Cplx(3.0, 1.2));
                bDst.AddScaled(z, Math387.Cplx(4.0, 1.8));
            }
            Timings[1, 0] = Math387.StopTimer() * 1000;

            // Commented out in Delphi code
            // if (!aDst.IsEqual(bDst, 1E-5)) throw new Exception("Not equal");

            // X + Y + Z
            labels.Add("X + Y + Z");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.Add(x, y, z);
            }
            Timings[0, 1] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Add(x, y);
                bDst.Add(z);
            }
            Timings[1, 1] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst, 1E-5, TCompare.cmpAbsolute)) throw new Exception("Not equal");

            // (X*xScale + Y*yScale)*Z*zScale
            labels.Add("(X*xScale + Y*yScale)*Z*zScale");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.AddAndMul(x, Math387.Cplx(2.0, 1.3), y, Math387.Cplx(3.0, 1.2), z, Math387.Cplx(4.0, 1.8));
            }
            Timings[0, 2] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Mul(x, Math387.Cplx(2.0, 1.3) * Math387.Cplx(4.0, 1.8));
                bDst.AddScaled(y, Math387.Cplx(3.0, 1.2) * Math387.Cplx(4.0, 1.8));
                bDst.Mul(z);
            }
            Timings[1, 2] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst, 1E-5, TCompare.cmpAbsolute)) throw new Exception("Not equal");

            // (X + Y)*Z
            labels.Add("(X + Y)*Z");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.AddAndMul(x, y, z);
            }
            Timings[0, 3] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Add(x, y);
                bDst.Mul(z);
            }
            Timings[1, 3] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst, 1E-5, TCompare.cmpAbsolute)) throw new Exception("Not equal");

            // X*Y*xyScale + Z*zScale
            labels.Add("X*Y*xyScale + Z*zScale");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.MulAndAdd(x, y, Math387.Cplx(3.0, 1.2), z, Math387.Cplx(4.0, 1.8));
            }
            Timings[0, 4] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Mul(x, y);
                bDst.Mul(Math387.Cplx(3.0, 1.2));
                bDst.AddScaled(z, Math387.Cplx(4.0, 1.8));
            }
            Timings[1, 4] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst, 1E-5, TCompare.cmpAbsolute)) throw new Exception("Not equal");

            // X*Y + Z
            labels.Add("X*Y + Z");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.MulAndAdd(x, y, z);
            }
            Timings[0, 5] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Mul(x, y);
                bDst.Add(z);
            }
            Timings[1, 5] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst, 1E-5, TCompare.cmpAbsolute)) throw new Exception("Not equal");

            Series1.Clear();
            Series2.Clear();
            for (int i = 0; i < Timings.GetLength(1); i++)
            {
                Series1.Add(Timings[0, i], labels[i]);
                Series2.Add(Timings[1, i], labels[i]);
            }
        }

        private void SaturatedIntegerMath()
        {
            int loops = 10000;
            List<string> labels = new List<string>();
            VectorInt aDst = new VectorInt();
            VectorInt bDst = new VectorInt();
            VectorInt cDst = new VectorInt();
            VectorInt x = new VectorInt();
            VectorInt y = new VectorInt();
            VectorInt z = new VectorInt();

            Series1.Title = "Integer Compound";
            Series2.Title = "Integer Sequenced";
            labels.Clear();
            x.Size(1000, TIntPrecision.prInt32);
            x.SetVal(1);
            y.Size(x);
            y.SetVal(2);
            z.Size(x);
            z.SetVal(3);

            // X*xScale + Y*yScale + Z*zScale
            labels.Add("X*xScale + Y*yScale + Z*zScale");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.AddScaled(x, 2, y, 3, z, 4);
            }
            Timings[0, 0] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Multiply(x, 2);
                cDst.Multiply(y, 3);
                bDst.Add(cDst);
                cDst.Multiply(z, 4);
                bDst.Add(cDst);
            }
            Timings[1, 0] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst)) throw new Exception("Not equal");

            // X + Y + Z
            labels.Add("X + Y + Z");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.Add(x, y, z);
            }
            Timings[0, 1] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Add(x, y);
                bDst.Add(z);
            }
            Timings[1, 1] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst)) throw new Exception("Not equal");

            // (X*xScale + Y*yScale)*Z*zScale
            labels.Add("(X*xScale + Y*yScale)*Z*zScale");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.AddAndMul(x, 2, y, 3, z, 4);
            }
            Timings[0, 2] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Multiply(x, 2);
                cDst.Multiply(y, 3);
                bDst.Add(cDst);
                bDst.Multiply(z);
                bDst.Multiply(4);
            }
            Timings[1, 2] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst)) throw new Exception("Not equal");

            // (X + Y)*Z
            labels.Add("(X + Y)*Z");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.AddAndMul(x, y, z);
            }
            Timings[0, 3] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Add(x, y);
                bDst.Multiply(z);
            }
            Timings[1, 3] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst)) throw new Exception("Not equal");

            // X*Y*xyScale + Z*zScale
            labels.Add("X*Y*xyScale + Z*zScale");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.MulAndAdd(x, y, 3, z, 4);
            }
            Timings[0, 4] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Multiply(x, y);
                bDst.Multiply(3);
                cDst.Multiply(z, 4);
                bDst.Add(cDst);
            }
            Timings[1, 4] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst)) throw new Exception("Not equal");

            // X*Y + Z
            labels.Add("X*Y + Z");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.MulAndAdd(x, y, z);
            }
            Timings[0, 5] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Multiply(x, y);
                bDst.Add(z);
            }
            Timings[1, 5] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst)) throw new Exception("Not equal");

            Series1.Clear();
            Series2.Clear();
            for (int i = 0; i < Timings.GetLength(1); i++)
            {
                Series1.Add(Timings[0, i], labels[i]);
                Series2.Add(Timings[1, i], labels[i]);
            }
        }

        private void SaturatedSmallIntMath()
        {
            int loops = 10000;
            List<string> labels = new List<string>();
            VectorInt aDst = new VectorInt();
            VectorInt bDst = new VectorInt();
            VectorInt cDst = new VectorInt();
            VectorInt x = new VectorInt();
            VectorInt y = new VectorInt();
            VectorInt z = new VectorInt();

            Series1.Title = "SmallInt Compound";
            Series2.Title = "SmallInt Sequenced";
            labels.Clear();
            x.Size(1000, TIntPrecision.prInt16);
            x.SetVal(1);
            y.Size(x);
            y.SetVal(2);
            z.Size(x);
            z.SetVal(3);

            // X*xScale + Y*yScale + Z*zScale
            labels.Add("X*xScale + Y*yScale + Z*zScale");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.AddScaled(x, 2, y, 3, z, 4);
            }
            Timings[0, 0] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Multiply(x, 2);
                cDst.Multiply(y, 3);
                bDst.Add(cDst);
                cDst.Multiply(z, 4);
                bDst.Add(cDst);
            }
            Timings[1, 0] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst)) throw new Exception("Not equal");

            // X + Y + Z
            labels.Add("X + Y + Z");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.Add(x, y, z);
            }
            Timings[0, 1] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Add(x, y);
                bDst.Add(z);
            }
            Timings[1, 1] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst)) throw new Exception("Not equal");

            // (X*xScale + Y*yScale)*Z*zScale
            labels.Add("(X*xScale + Y*yScale)*Z*zScale");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.AddAndMul(x, 2, y, 3, z, 4);
            }
            Timings[0, 2] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Multiply(x, 2);
                cDst.Multiply(y, 3);
                bDst.Add(cDst);
                bDst.Multiply(z);
                bDst.Multiply(4);
            }
            Timings[1, 2] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst)) throw new Exception("Not equal");

            // (X + Y)*Z
            labels.Add("(X + Y)*Z");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.AddAndMul(x, y, z);
            }
            Timings[0, 3] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Add(x, y);
                bDst.Multiply(z);
            }
            Timings[1, 3] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst)) throw new Exception("Not equal");

            // X*Y*xyScale + Z*zScale
            labels.Add("X*Y*xyScale + Z*zScale");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.MulAndAdd(x, y, 3, z, 4);
            }
            Timings[0, 4] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Multiply(x, y);
                bDst.Multiply(3);
                cDst.Multiply(z, 4);
                bDst.Add(cDst);
            }
            Timings[1, 4] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst)) throw new Exception("Not equal");

            // X*Y + Z
            labels.Add("X*Y + Z");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.MulAndAdd(x, y, z);
            }
            Timings[0, 5] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Multiply(x, y);
                bDst.Add(z);
            }
            Timings[1, 5] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst)) throw new Exception("Not equal");

            Series1.Clear();
            Series2.Clear();
            for (int i = 0; i < Timings.GetLength(1); i++)
            {
                Series1.Add(Timings[0, i], labels[i]);
                Series2.Add(Timings[1, i], labels[i]);
            }
        }

        private void SaturatedByteMath()
        {
            int loops = 10000;
            List<string> labels = new List<string>();
            VectorInt aDst = new VectorInt();
            VectorInt bDst = new VectorInt();
            VectorInt cDst = new VectorInt();
            VectorInt x = new VectorInt();
            VectorInt y = new VectorInt();
            VectorInt z = new VectorInt();

            Series1.Title = "Byte Compound";
            Series2.Title = "Byte Sequenced";
            labels.Clear();
            x.Size(1000, TIntPrecision.prInt8);
            x.SetVal(1);
            y.Size(x);
            y.SetVal(2);
            z.Size(x);
            z.SetVal(3);

            // X*xScale + Y*yScale + Z*zScale
            labels.Add("X*xScale + Y*yScale + Z*zScale");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.AddScaled(x, 2, y, 3, z, 4);
            }
            Timings[0, 0] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Multiply(x, 2);
                cDst.Multiply(y, 3);
                bDst.Add(cDst);
                cDst.Multiply(z, 4);
                bDst.Add(cDst);
            }
            Timings[1, 0] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst)) throw new Exception("Not equal");

            // X + Y + Z
            labels.Add("X + Y + Z");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.Add(x, y, z);
            }
            Timings[0, 1] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Add(x, y);
                bDst.Add(z);
            }
            Timings[1, 1] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst)) throw new Exception("Not equal");

            // (X*xScale + Y*yScale)*Z*zScale
            labels.Add("(X*xScale + Y*yScale)*Z*zScale");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.AddAndMul(x, 2, y, 3, z, 4);
            }
            Timings[0, 2] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Multiply(x, 2);
                cDst.Multiply(y, 3);
                bDst.Add(cDst);
                bDst.Multiply(z);
                bDst.Multiply(4);
            }
            Timings[1, 2] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst)) throw new Exception("Not equal");

            // (X + Y)*Z
            labels.Add("(X + Y)*Z");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.AddAndMul(x, y, z);
            }
            Timings[0, 3] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Add(x, y);
                bDst.Multiply(z);
            }
            Timings[1, 3] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst)) throw new Exception("Not equal");

            // X*Y*xyScale + Z*zScale
            labels.Add("X*Y*xyScale + Z*zScale");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.MulAndAdd(x, y, 3, z, 4);
            }
            Timings[0, 4] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Multiply(x, y);
                bDst.Multiply(3);
                cDst.Multiply(z, 4);
                bDst.Add(cDst);
            }
            Timings[1, 4] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst)) throw new Exception("Not equal");

            // X*Y + Z
            labels.Add("X*Y + Z");
            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                aDst.MulAndAdd(x, y, z);
            }
            Timings[0, 5] = Math387.StopTimer() * 1000;

            Math387.StartTimer();
            for (int i = 0; i < loops; i++)
            {
                bDst.Multiply(x, y);
                bDst.Add(z);
            }
            Timings[1, 5] = Math387.StopTimer() * 1000;

            if (!aDst.IsEqual(bDst)) throw new Exception("Not equal");

            Series1.Clear();
            Series2.Clear();
            for (int i = 0; i < Timings.GetLength(1); i++)
            {
                Series1.Add(Timings[0, i], labels[i]);
                Series2.Add(Timings[1, i], labels[i]);
            }
        }

        private void RunButtonClick(object sender, EventArgs e)
        {
            int selectedIndex = GetPrecisionGroupIndex();
            switch (selectedIndex)
            {
                case 0:
                    DoublePrecisionMath();
                    break;
                case 1:
                    ComplexDoublePrecisionMath();
                    break;
                case 2:
                    SaturatedIntegerMath();
                    break;
                case 3:
                    SaturatedSmallIntMath();
                    break;
                case 4:
                    SaturatedByteMath();
                    break;
            }
        }

        private void PrecisionGroupClick(object sender, EventArgs e)
        {
            RunButtonClick(sender, e);
        }

        private int GetPrecisionGroupIndex()
        {
            if (DoublePrecisionRadio.Checked) return 0;
            if (ComplexPrecisionRadio.Checked) return 1;
            if (IntegerPrecisionRadio.Checked) return 2;
            if (SmallIntPrecisionRadio.Checked) return 3;
            if (BytePrecisionRadio.Checked) return 4;
            return 0; // Default to Double
        }

        private void CompoundExpressionsForm_Load(object sender, EventArgs e)
        {

        }

        private void Chart_Click(object sender, EventArgs e)
        {

        }
    }
}
