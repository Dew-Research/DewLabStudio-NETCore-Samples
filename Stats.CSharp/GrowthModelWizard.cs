using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Dew.Math.Units;
using Dew.Math;
using Dew.Math.Tee;
using Dew.Math.Editors;
using Dew.Stats;
using Dew.Math.Controls;
using Dew.Stats.Units;

namespace StatsMasterDemo
{
	public class GrowthModelWizard : StatsMasterDemo.BaseStatWizard
	{
		
		#region Transformations

        internal delegate void TransformationEventHandler(TDenseMtxVec source, TDenseMtxVec destination, bool inverse);

		// Helper class for transformation
		internal class Transformation
		{

			private string desc;
            private string trtext;

			public Transformation(){}

			public virtual event TransformationEventHandler Operation;


            public string Description
			{
				get { return desc;}
				set { desc = value;}
			}

            public string TransformationText
            {
                get { return trtext; }
                set { trtext = value; }
            }

			public void DoTransformation(TDenseMtxVec source, TDenseMtxVec destination)
			{
				if (Operation!=null) Operation(source,destination,false);
			}

			public void DoInverseTransformation(TDenseMtxVec source, TDenseMtxVec destination)
			{
                if (Operation != null) Operation(source,destination, true);
			}
		}

        private void tr_SQR(TDenseMtxVec source,TDenseMtxVec destination, bool inverse)
        {
            if (inverse) destination.Sqrt(source); else destination.Sqr(source);
        }

       
        private void tr_SQRT(TDenseMtxVec source, TDenseMtxVec destination, bool inverse)
        {
            if (inverse) destination.Sqr(source); else destination.Sqrt(source);
        }

        private void tr_INV(TDenseMtxVec source, TDenseMtxVec destination, bool inverse)
        {
            destination.Inv(source);
        }

        private void tr_LN(TDenseMtxVec source, TDenseMtxVec destination, bool inverse)
        {
            if (inverse) destination.Exp(source); else destination.Ln(source);
        }

        private void tr_EXP(TDenseMtxVec source, TDenseMtxVec destination, bool inverse)
        {
            if (inverse) destination.Ln(source); else destination.Exp(source);
        }

        private void tr_NONE(TDenseMtxVec source, TDenseMtxVec destination, bool inverse)
        {
            destination.Copy(source);
        }

        private void SetupTransformations()
        {
            TransformationsX = new ArrayList();
            TransformationsY = new ArrayList();
            Transformation tr;

            // No transformation
            tr = new Transformation();
            tr.Operation += new TransformationEventHandler(tr_NONE);
            tr.Description = "u -> u";
            tr.TransformationText = "u";
            TransformationsX.Add(tr);
            TransformationsY.Add(tr);
            // 1/x
            tr = new Transformation();
            tr.Operation += new TransformationEventHandler(tr_INV);
            tr.Description = "u -> 1/u";
            tr.TransformationText = "1/u";
            TransformationsX.Add(tr);
            TransformationsY.Add(tr);

            // Sqr
            tr = new Transformation();
            tr.Operation += new TransformationEventHandler(tr_SQR);
            tr.Description = "u -> Sqr(u)";
            tr.TransformationText = "Sqr(u)";
            TransformationsX.Add(tr);
            TransformationsY.Add(tr);
            // Sqrr
            tr = new Transformation();
            tr.Operation += new TransformationEventHandler(tr_SQRT);
            tr.Description = "u -> Sqrt(u)";
            tr.TransformationText = "Sqrt(u)";
            TransformationsX.Add(tr);
            TransformationsY.Add(tr);

            // exp
            tr = new Transformation();
            tr.Operation += new TransformationEventHandler(tr_EXP);
            tr.Description = "u -> Exp(u)";
            tr.TransformationText = "Exp(u)";
            TransformationsX.Add(tr);
            TransformationsY.Add(tr);
            // ln
            tr = new Transformation();
            tr.Operation += new TransformationEventHandler(tr_LN);
            tr.Description = "u -> Ln(u)";
            tr.TransformationText = "Ln(u)";
            TransformationsX.Add(tr);
            TransformationsY.Add(tr);


            // Populate combo boxes
            comboBoxXTran.DataSource = TransformationsX;
            comboBoxXTran.DisplayMember = "Description";
            comboBoxYTran.DataSource = TransformationsY;
            comboBoxYTran.DisplayMember = "Description";
        }

		#endregion

        #region Models

        private string TransformedCoordinate(string equation, string oldpar, string newpar)
        {
            return equation.Replace(oldpar, newpar);
        }

        /// Linear model : y=b[0]+b[1]*x
        private double Linear(TVec B, double x)
        {
            return B[0] + B[1]*x;
        }

        /// Reciprocal model : y=1/(b[0]+b[1]*x)
        private double Reciprocal(TVec B, double x)
        {
            return 1.0 / (B[0] + B[1] * x);
        }

        /// Exponential model : y=Exp(B[0]*(x-B[1]))
        private double Exponential(TVec B, double x)
        {
            return System.Math.Exp(B[0] * (x - B[1]));
        }

        // Sum of exponentials B[0]*(Math.Exp(-B[1]*x) + -B[2]*Math.Exp(-B[3]*x))
        private double SumOfExponentials(TVec B, double x)
        {
            return B[0]*(Math.Exp(-B[1]*x) + B[2]*Math.Exp(-B[3]*x));
        }

        // Three parameter logistic : B[0] / (1.0 + B[1] * Math.Exp(-B[2] * x))
        private double Logistic3(TVec B, double x)
        {
            return B[0] / (1.0 + B[1] * Math.Exp(-B[2] * x));
        }

        // Holliday : 1/(B[0]+B[1]*x+B[2]*x*x)
        private double Holliday(TVec B, double x)
        {
            return 1.0 / (B[0] + B[1] * x + B[2] * x * x);
        }

        // Normal : B[0] + B[1] * Math.Exp(-B[2] * Math.Pow(x-B[3], 2))
        private double Normal(TVec B, double x)
        {
            return B[0] + B[1] * Math.Exp(-B[2] * Math.Pow(x-B[3], 2));
        }

        // Gompertz : B[0] * Math.Exp(-Math.Exp(-B[1]*(x-B[2])))
        private double Gompertz(TVec B, double x)
        {
            return B[0] * Math.Exp(-Math.Exp(-B[1]*(x-B[2])));

        }

        // Gompertz : B[0]*(1-Exp(-B[1](x-B[2]))) 	
        private double Monomolecular(TVec B, double x)
        {
            return B[0] * Math.Exp(-B[1]*(x-B[2]));
        }
        


        #endregion

        private void FitModel(TVec fx, TVec fy, TVec fb)
        {

            nlr.X.Copy(fx);
            nlr.Y.Copy(fy);
            nlr.B.Copy(fb);
            nlr.Verbose = checkBoxOptLog.Checked ? log : null;
            nlr.Recalc();
        }


        private void AutoInitB(TVec fx, TVec fy, TVec fb)
        {
            Random r = new Random();
            switch (comboBoxModel.SelectedIndex)
            {
                case 0: // Linear
                    {
                        fb.Size(2);
                        fb.SetZero(); // guarantees convergence
                        parnames[0] = "a";
                        parnames[1] = "b";
                    }; break;
                case 1: // Reciprocal
                    {
                        fb.Size(2);
                        fb.SetVal(1.0);
                        parnames[0] = "a";
                        parnames[1] = "b";
                    }; break;

                case 2: // Exponential
                    {
                        fb.Size(2);
                        fb.SetIt(new double[] { fy.Values[0], 1.0 / fy.Mean() });
                        parnames[0] = "a";
                        parnames[1] = "b";
                    }; break;

                case 3: // Sum of exponentials
                    {
                        fb.Size(4);
                        fb.SetIt(new double[] { fy.Values[0], 1.0 / fy.Mean(), fy.Values[0], 1.0 / fy.Mean() });
                        parnames[0] = "a";
                        parnames[1] = "b";
                        parnames[2] = "c";
                        parnames[3] = "d";
                    }; break;
                case 4: // Three parameter logistic
                    {
                        fb.Size(3);
                        fb.SetIt(new double[] { fy.Values[0], fy.Values[0], 1.0/fy.Mean() });
                        parnames[0] = "a";
                        parnames[1] = "b";
                        parnames[2] = "c";
                    }; break;
                case 5: // Holiday
                    {
                        fb.Size(3);
                        fb.SetIt(new double[] { 1.0, 1.0, 1.0 });
                        parnames[0] = "a";
                        parnames[1] = "b";
                        parnames[2] = "c";
                    }; break;
                case 6: // Normal
                    {
                        fb.Size(4);
                        fb.SetIt(new double[] { 1.0, 1.0, fy.Mean(),fy.StdDev()});
                        parnames[0] = "a";
                        parnames[1] = "b";
                        parnames[2] = "c";
                        parnames[3] = "d";
                    }; break;
                case 7: // Gompertz
                    {
                        fb.Size(3);
                        fb.SetIt(new double[] { 1.0, 1.0, 0.0 });
                        parnames[0] = "a";
                        parnames[1] = "b";
                        parnames[2] = "c";
                    }; break;
                case 8: // Monomolecular
                    {
                        fb.Size(3);
                        fb.SetIt(new double[] { 1.0, 1.0, 0.0 });
                        parnames[0] = "a";
                        parnames[1] = "b";
                        parnames[2] = "c";
                    }; break;
            }
        }

        #region Reports

        private void OptimizationReport()
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Optimization using Marquardt algorithm.\n\n";

            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Italic);
            richTextBox.SelectedText = "Optimization settings:\n";
            richTextBox.SelectedText += "Tolerance:\t" + nlr.Tolerance.ToString() + "\n"
                + "Max.iterations:\t" + nlr.MaxIteration.ToString() + "\n"
                + "Model:\t" + comboBoxModel.SelectedItem.ToString() + "\n\n";

            richTextBox.SelectionColor = Color.Blue;
            SetupTabs(richTextBox, 2);
            richTextBox.SelectedText = "Parameter\tInitial value\n";
            for (int i = 0; i < b.Length; i++)
            {
                richTextBox.SelectedText += parnames[i] + "\t" + b.Values[i].ToString(FmtString) + "\n";
            }
            richTextBox.SelectedText += "\n";

            int iter = nlr.Iterations;
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Italic);
            richTextBox.SelectedText = "Optimization results:\n";

            if (nlr.Verbose != null) richTextBox.SelectedText = "Optimization log:\n" + log.Text + "\n";
            log.Clear();
            
            richTextBox.SelectedText = "Iterations:\t" + iter.ToString() + "\n"
                + "Stop reason:\t" + OptimStopReason(nlr.StopReason) + "\n\n";

            richTextBox.SelectionColor = Color.Blue;
            SetupTabs(richTextBox, 2);
            richTextBox.SelectedText = "Parameter\tFinal value\n";
            for (int i = 0; i < b.Length; i++)
            {
                richTextBox.SelectedText += parnames[i] + "\t" + nlr.B.Values[i].ToString(FmtString) + "\n";
            }
            richTextBox.SelectedText += "\n\n";
        }

        private void ModelEstimationReport()
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Model estimation\n\n";
            richTextBox.SelectionColor = Color.Blue;
            SetupTabs(richTextBox, 2);
            richTextBox.SelectedText = "Parameter\tParameter\tAsymptotic\nname\testimate\tstd.error\n";
            for (int i = 0; i < nlr.B.Length; i++)
            {
                richTextBox.SelectedText += parnames[i] + "\t" + nlr.B.Values[i].ToString(FmtString) + "\n";
            }
            richTextBox.SelectedText += "\n";

            richTextBox.SelectedText = "Transformation used for x and y:\n"
                + "x variable transformation:\t" + xtrans.Description + "\n"
                + "y variable transformation:\t" + ytrans.Description + "\n\n";
            double r2 = Regress.R2(nlr.Y, nlr.YCalc);
            Vector residuals = new Vector(0);
            residuals.Sub(nlr.YCalc,nlr.Y);
            double mse = residuals.SumOfSquares()/(residuals.Length-nlr.B.Length);

            string equation= comboBoxModel.SelectedItem.ToString();
            equation = TransformedCoordinate(equation, "x", xtrans.TransformationText);
            equation = TransformedCoordinate("y", "y", ytrans.TransformationText) + " = " + equation;
            richTextBox.SelectedText = "Model:\t" + equation + "\n"
                + "Model R2:\t" + r2.ToString(FmtString) + "\n"
                + "Model MSE:\t" + mse.ToString(FmtString) + "\n\n";

            if (checkBoxCharts.Checked)
            {
                Chart.Aspect.View3D = false;
                Chart.Series.Clear();
                // #1: Fitted model
                Chart.Header.Text = "Transformed model";
                Chart.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
                Chart.Axes.Left.Title.Text = ytrans.Description;
                Chart.Axes.Bottom.Title.Text = xtrans.Description;
                Chart.Series.Add(new Steema.TeeChart.Styles.Points());
                Chart.Series.Add(new Steema.TeeChart.Styles.Line());
                Chart[0].Title = "Transformed data";
                Chart[1].Title = "Estimates";
                MtxVecTee.DrawValues(nlr.X, nlr.Y, Chart[0], false);
                MtxVecTee.DrawValues(nlr.X, nlr.YCalc, Chart[1], false);
                CopyToRichBox(richTextBox);
                richTextBox.SelectedText = "\n";

                // #2: Plot untransformed data
                Vector xuntr = new Vector(0);
                Vector yuntr = new Vector(0);
                Chart.Header.Text = "Original model";
                xtrans.DoInverseTransformation(nlr.X, xuntr);
                Chart[0].Title = "Data";
                Chart[1].Title = "Estimates";
                Chart.Axes.Left.Title.Text = "y";
                Chart.Axes.Bottom.Title.Text = "x";
                // Data
                ytrans.DoInverseTransformation(nlr.Y, yuntr);
                MtxVecTee.DrawValues(xuntr, yuntr, Chart[0], false);
                // Model
                ytrans.DoInverseTransformation(nlr.YCalc, yuntr);
                MtxVecTee.DrawValues(xuntr, yuntr, Chart[1], false);
                CopyToRichBox(richTextBox);
                richTextBox.SelectedText = "\n";
            }
        }

        private void AnalysisVarianceReport()
        {
            string st = "";

            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Analysis Of Variance\n\n";
            richTextBox.SelectionColor = Color.Blue;
            SetupTabs(richTextBox, 4);
            richTextBox.SelectedText = "\t\tSum of \tMean\nSource\tdF\tSquares\tSquare\n";

            // mean
            Vector tv = new Vector(nlr.Y.Length);
            tv.SetZero();
            tv.Add(-nlr.Y.Mean());
            double ssmean = tv.SumOfSquares();
            double mssmean = ssmean;
            st = "Mean\t1\t" + ssmean.ToString(FmtString) + "\t"+mssmean.ToString(FmtString)+"\n";

            // model
            int dfmodel = nlr.B.Length;
            double ssmodel = nlr.YCalc.SumOfSquares();
            double mssmodel = ssmodel / (double)dfmodel;
            st += "Model\t"+dfmodel.ToString()+"\t"+ssmodel.ToString(FmtString) + "\t"+mssmodel.ToString(FmtString)+"\n";

            // model adjusted
            int dfadj = dfmodel - 1;
            double ssadj = ssmodel - ssmean;
            double mssadj = ssadj / (double)dfadj;
            st += "Model (adj)\t" + dfadj.ToString() + "\t" + ssadj.ToString(FmtString) + "\t" + mssadj.ToString(FmtString) + "\n";

            // errors
            tv.Sub(nlr.YCalc, nlr.Y);
            int dferr = nlr.Y.Length - dfmodel;
            double sserror = tv.SumOfSquares();
            double msserror = sserror / (double)dferr;
            st += "Errors\t" + dferr.ToString() + "\t" + sserror.ToString(FmtString) + "\t" + msserror.ToString(FmtString) + "\n";

            // Total
            int dftotal = nlr.Y.Length;
            double sstotal = nlr.Y.SumOfSquares();
            int dftotaladj = dftotal - 1;
            double sstotaladj = sstotal - ssmean;
            st += "Total (adj)\t" + dftotaladj.ToString() + "\t" + sstotaladj.ToString(FmtString) +  "\n";
            st += "Total\t" + dftotal.ToString() + "\t" + sstotal.ToString(FmtString) + "\n";
            
            richTextBox.SelectedText = st+"\n\n";

        }

        private void ResidualsReport()
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Residuals\n\n";
            richTextBox.SelectionColor = Color.Blue;
            SetupTabs(richTextBox, 3);
            richTextBox.SelectedText = "Actual\tPredicted\tResidual\n";
            // regression coefficients
            Vector residuals = new Vector(0);
            residuals.Sub(nlr.YCalc, nlr.Y);
            string st = "";
            for (int i = 0; i < nlr.Y.Length; i++)
            {
                st += Math387.FormatSample(FmtString, nlr.Y.Values[i]) + "\t";
                st += Math387.FormatSample(FmtString, nlr.YCalc.Values[i]) + "\t";
                st += Math387.FormatSample(FmtString, residuals.Values[i]) + "\n";
            }
            richTextBox.SelectedText = st + "\r\n";

            if (checkBoxCharts.Checked)
            {
                // #1: Histogram of residuals
                Chart.Series.Clear();
                Chart.Legend.Visible = false;
                Chart.Header.Text = "Histogram of residuals";
                Chart.Axes.Left.Title.Text = "Count";
                Chart.Axes.Bottom.Title.Text = "Residuals";
                // add histogram series
                Steema.TeeChart.Styles.Bar bar;
                Chart.Series.Add(bar = new Steema.TeeChart.Styles.Bar());
                bar.Marks.Visible = false;
                bar.UseOrigin = true;
                bar.Origin = 0.0;
                bar.BarWidthPercent = 100;
                // calculate histogram
                Vector tvec1 = new Vector(0);
                Vector tvec = new Vector(0);
                Statistics.Histogram(residuals, 10, tvec, tvec1, true);
                MtxVecTee.DrawValues(tvec1, tvec, bar, false);
                CopyToRichBox(richTextBox);
                richTextBox.SelectedText = "\n";

                // Residuals normal probability plot
                Chart.Series.Clear();
                Chart.Legend.Visible = false;
                Chart.Header.Text = "Residuals normal probability plot";
                Chart.Axes.Left.Title.Text = "Z value";
                Chart.Axes.Bottom.Title.Text = "Residuals";
                Dew.Stats.Tee.ProbabilityPlot ser;
                Chart.Series.Add(ser = new Dew.Stats.Tee.ProbabilityPlot());
                ser.SlopePen.Color = Color.Black;
                ser.SlopePen.Width = 2;
                ser.SlopePen.Style = Steema.TeeChart.Drawing.DashStyle.Dot;
                double minx, maxx, miny, maxy;
                // setup normal probability plot parameters
                StatProbPlots.StatNormalPlot(residuals, tvec1, tvec, out minx, out maxx, out miny, out maxy, null, false);
                ser.minX = minx;
                ser.maxX = maxx;
                ser.minY = miny;
                ser.maxY = maxy;
                MtxVecTee.DrawValues(tvec1, tvec, ser, false);
                CopyToRichBox(richTextBox);
                richTextBox.SelectedText = "\n";
            }
        }
        #endregion

        private System.ComponentModel.IContainer components = null;

        private TStringList log = new TStringList();
        private bool formloading = true;
        private string[] parnames = new string[4];
        private Vector x,y,b;
        private Vector xtr, ytr;
        Transformation xtrans = null;
        Transformation ytrans = null;
        private Dew.Stats.TMtxNonLinReg nlr;
        private ArrayList TransformationsX, TransformationsY;
        private Dew.Math.Controls.WizardPage wizardPageData;
        private Dew.Math.Controls.WizardPage wizardPageOptim;
        private GroupBox groupBox4;
        private TextBox textBoxTolerance;
        private NumericUpDown numericUpDownMaxIter;
        private Label label7;
        private Label label6;
        private GroupBox groupBox5;
        private RadioButton radioButtonManual;
        private RadioButton radioButtonAutomatic;
        private DataGridView dataGridViewB;
        private GroupBox groupBox3;
        private ComboBox comboBoxModel;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private ComboBox comboBoxYTran;
        private ComboBox comboBoxXTran;
        private Button buttonY;
        private Button buttonX;
        private DataInfo dataInfo2;
        private DataInfo dataInfo1;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumnName;
        private System.Data.DataColumn dataColumnValue;
        private GroupBox groupBox6;
        private CheckBox checkBoxAVar;
        private CheckBox checkBoxModel;
        private CheckBox checkBoxOptim;
        private CheckBox checkBoxResiduals;
        private CheckBox checkBoxOptLog;
        private Label label8;
        private SplitContainer splitContainer1;


		public TVec X
		{
			get { return x;}
		}

		public TVec Y
		{
			get {return y;}
		}

        public TVec B
        {
            get { return b; }
        }


		public GrowthModelWizard()
		{
			InitializeComponent();
			// Manually reposition Data wizard page after the Welcome page
			wizard.Pages.Remove(wizardPageData);
            wizard.Pages.Remove(wizardPageOptim);
            wizard.Pages.Insert(1, wizardPageData);
            wizard.Pages.Insert(2, wizardPageOptim);

			x = new Vector(0);
			y = new Vector(0);
            b = new Vector(0);

            xtr = new Vector(0);
            ytr = new Vector(0);

            dataInfo1.xData = x;
			dataInfo1.Data = y;
            dataInfo1.tChartData.Header.Visible = true;
            dataInfo1.tChartData.Header.Text = "Original data";

            dataInfo2.xData = xtr;
            dataInfo2.Data = ytr;
            dataInfo2.tChartData.Header.Visible = true;
            dataInfo2.tChartData.Header.Text = "Transformed data";


            // Use numeric gradient
            nlr = new TMtxNonLinReg();
            nlr.OptMethod = TOptMethod.optMarquardt;
            dataGridViewB.DataSource = dataTable1;
            dataGridViewB.Columns[0].ReadOnly = true;

			SetupTransformations();

		}

        private void DoTransformationVector(TVec src, TVec dst, Transformation trans)
        {
            trans.DoTransformation(src, dst);
        }

        private void DoTransformation()
        {
            if (x.Length == y.Length)
            {
                TVec tx, ty;
                TVecInt maskx, masky;
                xtrans = (comboBoxXTran.Items[comboBoxXTran.SelectedIndex] as Transformation);
                ytrans = (comboBoxYTran.Items[comboBoxYTran.SelectedIndex] as Transformation);

                MtxVec.CreateIt(out tx, out ty);
                MtxVecInt.CreateIt(out maskx, out masky);
                try
                {
                    // first, transform x
                    DoTransformationVector(x, tx, xtrans);
                    dataInfo2.tChartData.Axes.Bottom.Title.Text = xtrans.Description;
                    // Find and remove nan's and inf's from xtr
                    AbstractMtxVec.FindMask(maskx, tx, TMtxCompareOp.cmpNot_EQ, Math387.NAN);

                    // next, transform y
                    DoTransformationVector(y, ty, ytrans);
                    dataInfo2.tChartData.Axes.Top.Title.Text = ytrans.Description;

                    // Find and remove nan's y
                    // Now remove all points (x,y) with either tx or ty being nan                    
                    AbstractMtxVec.FindMask(masky, ty, TMtxCompareOp.cmpNot_EQ, Math387.NAN);
                    for (int i = 0; i < masky.Length; i++)
                    {

                        masky.IValues[i] = (maskx.IValues[i] + masky.IValues[i]) / 2;
                    }
                    // masky now holds mask for x and y, remove these values
                    xtr.GatherByMask(tx, masky);
                    ytr.GatherByMask(ty, masky);

                }
                finally
                {
                    MtxVec.FreeIt(ref tx, ref ty);
                    MtxVecInt.FreeIt(ref maskx, ref masky);
                    dataInfo2.Update();
                }
            }
        }

        private void TextReport()
        {
            wizard.BackEnabled = false;
            wizard.NextEnabled = false;

            // manual mode
            if (radioButtonManual.Checked)
            {
                for (int i = 0; i < dataTable1.Rows.Count; i++)
                    b.Values[i] = Convert.ToDouble(dataTable1.Rows[i][1]);
            }

            this.Cursor = Cursors.WaitCursor;

            richTextBox.Clear();
            richTextBox.SuspendLayout();
            // Do reports
            try
            {
                progressBar.Value = 0;
                // Optimization
                FitModel(xtr, ytr, b);
                Application.DoEvents();

                progressBar.Value = 30;
                if (checkBoxOptim.Checked)
                {
                    OptimizationReport();
                    Application.DoEvents();
                }

                progressBar.Value = 60;
                if (checkBoxModel.Checked)
                {
                    ModelEstimationReport();
                    Application.DoEvents();
                }

                progressBar.Value = 60;
                if (checkBoxAVar.Checked)
                {
                    AnalysisVarianceReport();
                    Application.DoEvents();
                }


                progressBar.Value = 80;
                if (checkBoxResiduals.Checked) ResidualsReport();

                progressBar.Value = 100;
                Application.DoEvents();
            }
            finally
            {
                richTextBox.SelectionStart = 0;
                richTextBox.ResumeLayout();
                this.Cursor = Cursors.Default;
                wizard.BackEnabled = true;
            }
        }

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrowthModelWizard));
            this.wizardPageData = new Dew.Math.Controls.WizardPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxYTran = new System.Windows.Forms.ComboBox();
            this.comboBoxXTran = new System.Windows.Forms.ComboBox();
            this.buttonY = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.dataInfo2 = new StatsMasterDemo.DataInfo();
            this.dataInfo1 = new StatsMasterDemo.DataInfo();
            this.wizardPageOptim = new Dew.Math.Controls.WizardPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridViewB = new System.Windows.Forms.DataGridView();
            this.radioButtonManual = new System.Windows.Forms.RadioButton();
            this.radioButtonAutomatic = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxOptLog = new System.Windows.Forms.CheckBox();
            this.textBoxTolerance = new System.Windows.Forms.TextBox();
            this.numericUpDownMaxIter = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumnName = new System.Data.DataColumn();
            this.dataColumnValue = new System.Data.DataColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBoxResiduals = new System.Windows.Forms.CheckBox();
            this.checkBoxAVar = new System.Windows.Forms.CheckBox();
            this.checkBoxModel = new System.Windows.Forms.CheckBox();
            this.checkBoxOptim = new System.Windows.Forms.CheckBox();
            this.wizard.SuspendLayout();
            this.wizardPageReport.SuspendLayout();
            this.wizardPageFormat.SuspendLayout();
            this.wizardPageData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.wizardPageOptim.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxIter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizard
            // 
            this.wizard.Controls.Add(this.wizardPageData);
            this.wizard.Controls.Add(this.wizardPageOptim);
            this.wizard.Pages.AddRange(new Dew.Math.Controls.WizardPage[] {
            this.wizardPageData,
            this.wizardPageOptim});
            this.wizard.Size = new System.Drawing.Size(724, 460);
            this.wizard.AfterSwitchPages += new Dew.Math.Controls.Wizard.AfterSwitchPagesEventHandler(this.wizard_AfterSwitchPages);
            this.wizard.Load += new System.EventHandler(this.wizard_Load);
            this.wizard.Controls.SetChildIndex(this.wizardPageWelcome, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageFormat, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageReport, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageOptim, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageData, 0);
            // 
            // wizardPageReport
            // 
            this.wizardPageReport.Size = new System.Drawing.Size(749, 411);
            this.wizardPageReport.Title = "Growth models: Text report";
            // 
            // richTextBox
            // 
            this.richTextBox.Size = new System.Drawing.Size(716, 240);
            // 
            // progressBar
            // 
            this.progressBar.Size = new System.Drawing.Size(651, 16);
            // 
            // wizardPageFormat
            // 
            this.wizardPageFormat.Controls.Add(this.groupBox6);
            this.wizardPageFormat.Description = "Define which reports to include in textual report";
            this.wizardPageFormat.Size = new System.Drawing.Size(749, 411);
            this.wizardPageFormat.Title = "Step 3: Define reports";
            this.wizardPageFormat.Controls.SetChildIndex(this.checkBoxCharts, 0);
            this.wizardPageFormat.Controls.SetChildIndex(this.groupBox6, 0);
            // 
            // wizardPageWelcome
            // 
            this.wizardPageWelcome.Size = new System.Drawing.Size(749, 411);
            this.wizardPageWelcome.Title = "Growth and other models";
            // 
            // wizardPageData
            // 
            this.wizardPageData.Controls.Add(this.splitContainer1);
            this.wizardPageData.Description = "Define data and optional transformation prior to applying model.";
            this.wizardPageData.Location = new System.Drawing.Point(0, 0);
            this.wizardPageData.Name = "wizardPageData";
            this.wizardPageData.Size = new System.Drawing.Size(521, 297);
            this.wizardPageData.TabIndex = 13;
            this.wizardPageData.Title = "Step 1: Define data";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(4, 81);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataInfo2);
            this.splitContainer1.Panel2.Controls.Add(this.dataInfo1);
            this.splitContainer1.Panel2.Resize += new System.EventHandler(this.splitContainer1_Panel2_Resize);
            this.splitContainer1.Size = new System.Drawing.Size(513, 213);
            this.splitContainer1.SplitterDistance = 264;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.comboBoxModel);
            this.groupBox3.Location = new System.Drawing.Point(23, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 92);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Model";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Y=";
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Items.AddRange(new object[] {
            "a+b*x [Linear]",
            "1/(a+b*x) [Reciprocal]",
            "Exp(a*(x-b)) [Exponential]",
            "a*(Exp(-b*x)+c*Exp(-d*x))  [Sum of exp.]",
            "a/(1+b*Exp(-c*x)) [Logistic-3]",
            "1/(a+b*x+c*x*x) [Holliday]",
            "a+b*Exp(-c*(x-d)^2) [Normal]",
            "a*Exp(-Exp(-b*(x-c))) [Gompertz]",
            "a*Exp(-b*(x-c)) [Monomolecular]"});
            this.comboBoxModel.Location = new System.Drawing.Point(47, 23);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(207, 23);
            this.comboBoxModel.TabIndex = 0;
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBoxYTran);
            this.groupBox2.Controls.Add(this.comboBoxXTran);
            this.groupBox2.Controls.Add(this.buttonY);
            this.groupBox2.Controls.Add(this.buttonX);
            this.groupBox2.Location = new System.Drawing.Point(23, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Original data";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(134, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Transformation";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(125, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Transformation";
            // 
            // comboBoxYTran
            // 
            this.comboBoxYTran.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxYTran.Location = new System.Drawing.Point(125, 138);
            this.comboBoxYTran.Name = "comboBoxYTran";
            this.comboBoxYTran.Size = new System.Drawing.Size(129, 23);
            this.comboBoxYTran.TabIndex = 3;
            this.comboBoxYTran.Text = "Y Transformation";
            this.comboBoxYTran.SelectedIndexChanged += new System.EventHandler(this.comboBoxXTran_SelectedIndexChanged);
            // 
            // comboBoxXTran
            // 
            this.comboBoxXTran.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxXTran.Location = new System.Drawing.Point(125, 59);
            this.comboBoxXTran.Name = "comboBoxXTran";
            this.comboBoxXTran.Size = new System.Drawing.Size(129, 23);
            this.comboBoxXTran.TabIndex = 2;
            this.comboBoxXTran.Text = "X Transformation";
            this.comboBoxXTran.SelectedIndexChanged += new System.EventHandler(this.comboBoxXTran_SelectedIndexChanged);
            // 
            // buttonY
            // 
            this.buttonY.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonY.Location = new System.Drawing.Point(19, 138);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(87, 28);
            this.buttonY.TabIndex = 1;
            this.buttonY.Text = "Y: Load";
            this.buttonY.Click += new System.EventHandler(this.buttonY_Click);
            // 
            // buttonX
            // 
            this.buttonX.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonX.Location = new System.Drawing.Point(19, 59);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(87, 28);
            this.buttonX.TabIndex = 0;
            this.buttonX.Text = "X: Load";
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // dataInfo2
            // 
            this.dataInfo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataInfo2.Location = new System.Drawing.Point(0, 219);
            this.dataInfo2.Name = "dataInfo2";
            this.dataInfo2.ShowData = true;
            this.dataInfo2.ShowHistogram = false;
            this.dataInfo2.ShowStat = true;
            this.dataInfo2.Size = new System.Drawing.Size(248, 0);
            this.dataInfo2.StringFormat = "0.0000";
            this.dataInfo2.TabIndex = 1;
            // 
            // dataInfo1
            // 
            this.dataInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataInfo1.Location = new System.Drawing.Point(0, 0);
            this.dataInfo1.Name = "dataInfo1";
            this.dataInfo1.ShowData = true;
            this.dataInfo1.ShowHistogram = false;
            this.dataInfo1.ShowStat = true;
            this.dataInfo1.Size = new System.Drawing.Size(248, 219);
            this.dataInfo1.StringFormat = "0.0000";
            this.dataInfo1.TabIndex = 0;
            // 
            // wizardPageOptim
            // 
            this.wizardPageOptim.Controls.Add(this.groupBox5);
            this.wizardPageOptim.Controls.Add(this.groupBox4);
            this.wizardPageOptim.Description = "Setup Marquardt optimization algorithm parameters";
            this.wizardPageOptim.Location = new System.Drawing.Point(0, 0);
            this.wizardPageOptim.Name = "wizardPageOptim";
            this.wizardPageOptim.Size = new System.Drawing.Size(724, 412);
            this.wizardPageOptim.TabIndex = 14;
            this.wizardPageOptim.Title = "Step 2: Optimization algorithm";
            this.wizardPageOptim.Enter += new System.EventHandler(this.wizardPageOptim_Enter);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.dataGridViewB);
            this.groupBox5.Controls.Add(this.radioButtonManual);
            this.groupBox5.Controls.Add(this.radioButtonAutomatic);
            this.groupBox5.Location = new System.Drawing.Point(312, 75);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(372, 260);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Initial values";
            // 
            // dataGridViewB
            // 
            this.dataGridViewB.AllowUserToAddRows = false;
            this.dataGridViewB.AllowUserToDeleteRows = false;
            this.dataGridViewB.AllowUserToResizeColumns = false;
            this.dataGridViewB.AllowUserToResizeRows = false;
            this.dataGridViewB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewB.Location = new System.Drawing.Point(7, 106);
            this.dataGridViewB.Name = "dataGridViewB";
            this.dataGridViewB.Size = new System.Drawing.Size(355, 146);
            this.dataGridViewB.TabIndex = 2;
            // 
            // radioButtonManual
            // 
            this.radioButtonManual.AutoSize = true;
            this.radioButtonManual.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonManual.Location = new System.Drawing.Point(7, 54);
            this.radioButtonManual.Name = "radioButtonManual";
            this.radioButtonManual.Size = new System.Drawing.Size(71, 20);
            this.radioButtonManual.TabIndex = 1;
            this.radioButtonManual.Text = "Manual";
            this.radioButtonManual.UseVisualStyleBackColor = true;
            // 
            // radioButtonAutomatic
            // 
            this.radioButtonAutomatic.AutoSize = true;
            this.radioButtonAutomatic.Checked = true;
            this.radioButtonAutomatic.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonAutomatic.Location = new System.Drawing.Point(7, 25);
            this.radioButtonAutomatic.Name = "radioButtonAutomatic";
            this.radioButtonAutomatic.Size = new System.Drawing.Size(142, 20);
            this.radioButtonAutomatic.TabIndex = 0;
            this.radioButtonAutomatic.TabStop = true;
            this.radioButtonAutomatic.Text = "Automatic from data";
            this.radioButtonAutomatic.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxOptLog);
            this.groupBox4.Controls.Add(this.textBoxTolerance);
            this.groupBox4.Controls.Add(this.numericUpDownMaxIter);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(9, 72);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(291, 149);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Optimization settings";
            // 
            // checkBoxOptLog
            // 
            this.checkBoxOptLog.AutoSize = true;
            this.checkBoxOptLog.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxOptLog.Checked = true;
            this.checkBoxOptLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOptLog.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxOptLog.Location = new System.Drawing.Point(78, 101);
            this.checkBoxOptLog.Name = "checkBoxOptLog";
            this.checkBoxOptLog.Size = new System.Drawing.Size(126, 20);
            this.checkBoxOptLog.TabIndex = 5;
            this.checkBoxOptLog.Text = "Include log report";
            this.checkBoxOptLog.UseVisualStyleBackColor = true;
            // 
            // textBoxTolerance
            // 
            this.textBoxTolerance.Location = new System.Drawing.Point(190, 64);
            this.textBoxTolerance.Name = "textBoxTolerance";
            this.textBoxTolerance.Size = new System.Drawing.Size(93, 23);
            this.textBoxTolerance.TabIndex = 4;
            this.textBoxTolerance.TextChanged += new System.EventHandler(this.textBoxTolerance_TextChanged);
            // 
            // numericUpDownMaxIter
            // 
            this.numericUpDownMaxIter.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownMaxIter.Location = new System.Drawing.Point(190, 30);
            this.numericUpDownMaxIter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxIter.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownMaxIter.Name = "numericUpDownMaxIter";
            this.numericUpDownMaxIter.Size = new System.Drawing.Size(93, 23);
            this.numericUpDownMaxIter.TabIndex = 3;
            this.numericUpDownMaxIter.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxIter.ValueChanged += new System.EventHandler(this.numericUpDownMaxIter_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Desired tolerance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Maximum number of iterations";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumnName,
            this.dataColumnValue});
            this.dataTable1.Namespace = "";
            this.dataTable1.PrimaryKey = new System.Data.DataColumn[0];
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumnName
            // 
            this.dataColumnName.Caption = "Name";
            this.dataColumnName.ColumnName = "Name";
            this.dataColumnName.DefaultValue = ((object)(resources.GetObject("dataColumnName.DefaultValue")));
            this.dataColumnName.Namespace = "";
            // 
            // dataColumnValue
            // 
            this.dataColumnValue.Caption = "Value";
            this.dataColumnValue.ColumnName = "Value";
            this.dataColumnValue.DataType = typeof(double);
            this.dataColumnValue.DefaultValue = ((object)(resources.GetObject("dataColumnValue.DefaultValue")));
            this.dataColumnValue.Namespace = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBoxResiduals);
            this.groupBox6.Controls.Add(this.checkBoxAVar);
            this.groupBox6.Controls.Add(this.checkBoxModel);
            this.groupBox6.Controls.Add(this.checkBoxOptim);
            this.groupBox6.Location = new System.Drawing.Point(274, 96);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(210, 222);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Report on";
            // 
            // checkBoxResiduals
            // 
            this.checkBoxResiduals.AutoSize = true;
            this.checkBoxResiduals.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxResiduals.Location = new System.Drawing.Point(28, 130);
            this.checkBoxResiduals.Name = "checkBoxResiduals";
            this.checkBoxResiduals.Size = new System.Drawing.Size(81, 20);
            this.checkBoxResiduals.TabIndex = 3;
            this.checkBoxResiduals.Text = "Residuals";
            this.checkBoxResiduals.UseVisualStyleBackColor = true;
            // 
            // checkBoxAVar
            // 
            this.checkBoxAVar.AutoSize = true;
            this.checkBoxAVar.Checked = true;
            this.checkBoxAVar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAVar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxAVar.Location = new System.Drawing.Point(28, 101);
            this.checkBoxAVar.Name = "checkBoxAVar";
            this.checkBoxAVar.Size = new System.Drawing.Size(136, 20);
            this.checkBoxAVar.TabIndex = 2;
            this.checkBoxAVar.Text = "Analysis of Variance";
            this.checkBoxAVar.UseVisualStyleBackColor = true;
            // 
            // checkBoxModel
            // 
            this.checkBoxModel.AutoSize = true;
            this.checkBoxModel.Checked = true;
            this.checkBoxModel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxModel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxModel.Location = new System.Drawing.Point(28, 68);
            this.checkBoxModel.Name = "checkBoxModel";
            this.checkBoxModel.Size = new System.Drawing.Size(66, 20);
            this.checkBoxModel.TabIndex = 1;
            this.checkBoxModel.Text = "Model";
            this.checkBoxModel.UseVisualStyleBackColor = true;
            // 
            // checkBoxOptim
            // 
            this.checkBoxOptim.AutoSize = true;
            this.checkBoxOptim.Checked = true;
            this.checkBoxOptim.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOptim.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxOptim.Location = new System.Drawing.Point(28, 36);
            this.checkBoxOptim.Name = "checkBoxOptim";
            this.checkBoxOptim.Size = new System.Drawing.Size(101, 20);
            this.checkBoxOptim.TabIndex = 0;
            this.checkBoxOptim.Text = "Optimization";
            this.checkBoxOptim.UseVisualStyleBackColor = true;
            // 
            // GrowthModelWizard
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(724, 460);
            this.Name = "GrowthModelWizard";
            this.Load += new System.EventHandler(this.GrowthModelWizard_Load);
            this.wizard.ResumeLayout(false);
            this.wizardPageReport.ResumeLayout(false);
            this.wizardPageReport.PerformLayout();
            this.wizardPageFormat.ResumeLayout(false);
            this.wizardPageFormat.PerformLayout();
            this.wizardPageData.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.wizardPageOptim.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxIter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void buttonX_Click(object sender, System.EventArgs e)
		{
			MtxVecEdit.ViewValues(x, "x in y(x)", true, false, true);
            DoTransformation();
            dataInfo1.Update();
            wizard.NextEnabled = (X != null) & (Y != null) & (X.Length == Y.Length) || wizard.SelectedPage == wizardPageWelcome;
        }

		private void buttonY_Click(object sender, System.EventArgs e)
		{
			MtxVecEdit.ViewValues(y, "y in y(x)", true, false, true);
            DoTransformation();
            dataInfo1.Update();
            wizard.NextEnabled = (X != null) & (Y != null) & (X.Length == Y.Length) || wizard.SelectedPage == wizardPageWelcome;
        }

		private void wizard_Load(object sender, System.EventArgs e)
		{
			wizardPageWelcome.Description = "Growth models have been studied for a long time. Historically, these models have been divided into two classifications: empirical and mechanistic. \n"
				+ "An empirical model is one that was developed to be flexible enough to fit many sets of data well. However, its parameters usually do not have direct interpretation in terms of "
				+ "the physical process being modeled. A mechanistic model is derived from the mathematics of the physical process producing the data. Recently, the differentiation between these "
				+ "two classes of models has narrowed. Mechanistic models are usually based on overly simplistic assumptions and some would argue that they are really empirical.\n"
				+ "Because of these two competing classifications, many mathematical models have been developed that have similar shapes and characteristics. Often, the selection of a model is "
				+ "arbitrary and several of the available curves will do an excellent job of fitting the data.\n\n"
				+ "This wizard provides several models for use in fitting data. The parameters of these models are estimated using the Levenberg-Marquardt optimization method.";
           
		}

        private void GrowthModelWizard_Load(object sender, EventArgs e)
        {
            formloading = true;
            comboBoxXTran.SelectedIndex = 0;
            comboBoxYTran.SelectedIndex = 0;
            comboBoxModel.SelectedIndex = 0; // start with linear model

            numericUpDownMaxIter.Value = nlr.MaxIteration;
            textBoxTolerance.Text = nlr.Tolerance.ToString();

            formloading = false;
            DoTransformation();
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxModel.SelectedIndex)
            {
                case 0: nlr.RegressFunction += new TRegressFun(Linear); break;
                case 1: nlr.RegressFunction += new TRegressFun(Reciprocal); break;
                case 2: nlr.RegressFunction += new TRegressFun(Exponential); break;
                case 3: nlr.RegressFunction += new TRegressFun(SumOfExponentials); break;
                case 4: nlr.RegressFunction += new TRegressFun(Logistic3); break;
                case 5: nlr.RegressFunction += new TRegressFun(Holliday); break;
                case 6: nlr.RegressFunction += new TRegressFun(Normal); break;
                case 7: nlr.RegressFunction += new TRegressFun(Gompertz); break;
            }
        }

        #region Wizard control

        private void wizard_AfterSwitchPages(object sender, Dew.Math.Controls.Wizard.AfterSwitchPagesEventArgs e)
        {
            WizardPage newpage = wizard.Pages[e.NewIndex];
            if (newpage == wizardPageReport)
            {
                TextReport();
                wizard.CancelEnabled = false;
            }
            else if (newpage == wizardPageData)
            {
                wizard.NextEnabled = (X!=null) & (Y!=null) & (X.Length == Y.Length);
            }
            else wizard.CancelEnabled = true;

        }

        private void wizardPageOptim_Enter(object sender, EventArgs e)
        {
            AutoInitB(xtr, ytr, b);
            dataTable1.Rows.Clear();
            for (int i = 0; i < b.Length; i++)
            {
                dataTable1.Rows.Add(new object[2] { parnames[i], b.Values[i] });
            }
        }

#endregion

        private void splitContainer1_Panel2_Resize(object sender, EventArgs e)
        {
            dataInfo1.Height = splitContainer1.Panel2.Height / 2;
        }

        private void comboBoxXTran_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formloading)
                DoTransformation();
        }

        private void numericUpDownMaxIter_ValueChanged(object sender, EventArgs e)
        {
            if (!formloading) nlr.MaxIteration = (int)numericUpDownMaxIter.Value;
        }

        private void textBoxTolerance_TextChanged(object sender, EventArgs e)
        {
            if (!formloading) nlr.Tolerance = Math387.StrToSample(textBoxTolerance.Text);
        }

    }
}