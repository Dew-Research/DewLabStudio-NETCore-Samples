using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math.Controls;
using Dew.Math;
using Dew.Math.Units;
using Dew.Stats.Units;
using Dew.Stats;


namespace StatsMasterDemo
{
    public class PCRWizard : StatsMasterDemo.BaseStatWizard
    {
        public PCRWizard()
        {
            InitializeComponent();
            // Manually reposition Data wizard page after the Welcome page
            wizard.Pages.Remove(wizardPageData);
            wizard.Pages.Insert(1, wizardPageData);
        }

        private Matrix a = new Matrix(0, 0);
        private Vector y = new Vector(0);
        private Vector w = new Vector(0);
        private Vector b = new Vector(0);
        // private vectors for calc
        private Vector bstd = new Vector(0);
        private Vector bse = new Vector(0);
        private Vector ycalc = new Vector(0);
        private Vector res = new Vector(0);
        private int numOmmit = 0;

        private WizardPage wizardPageData;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private CheckBox checkBox1;
        private Button button3;
        private Label label6;
        private Button button2;
        private Label label5;
        private Button button1;
        private Label label4;
        private CheckBox checkBoxCorrMtx;
        private CheckBox checkBoxDescStat;
        private CheckBox checkBoxLS;
        private CheckBox checkBoxRes;
        private CheckBox checkBoxPC;
        private CheckBox checkBoxEigen;
        private NumericUpDown numericUpDown1;
        private Label label7;

        public Matrix A
        {
            get { return a; }
            set { a = value; }
        }

        public Vector Y
        {
            get { return y; }
            set { y = value; }
        }

        public Vector Weights
        {
            get { return w; }
            set { w = value; }
        }

        public Vector B
        {
            get { return b; }
        }

        public int NumOmmit
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; numOmmit = value; }
        }

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCRWizard));
            this.wizardPageData = new Dew.Math.Controls.WizardPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxRes = new System.Windows.Forms.CheckBox();
            this.checkBoxPC = new System.Windows.Forms.CheckBox();
            this.checkBoxEigen = new System.Windows.Forms.CheckBox();
            this.checkBoxLS = new System.Windows.Forms.CheckBox();
            this.checkBoxCorrMtx = new System.Windows.Forms.CheckBox();
            this.checkBoxDescStat = new System.Windows.Forms.CheckBox();
            this.wizard.SuspendLayout();
            this.wizardPageReport.SuspendLayout();
            this.wizardPageFormat.SuspendLayout();
            this.wizardPageData.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizard
            // 
            this.wizard.Controls.Add(this.wizardPageData);
            this.wizard.Pages.AddRange(new Dew.Math.Controls.WizardPage[] {
            this.wizardPageData});
            this.wizard.Size = new System.Drawing.Size(756, 452);
            this.wizard.AfterSwitchPages += new Dew.Math.Controls.Wizard.AfterSwitchPagesEventHandler(this.wizard_AfterSwitchPages);
            this.wizard.Controls.SetChildIndex(this.wizardPageData, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageReport, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageFormat, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageWelcome, 0);
            // 
            // wizardPageReport
            // 
            this.wizardPageReport.Size = new System.Drawing.Size(562, 316);
            this.wizardPageReport.Title = "PCR: Report";
            // 
            // richTextBox
            // 
            this.richTextBox.Size = new System.Drawing.Size(529, 145);
            // 
            // progressBar
            // 
            this.progressBar.Size = new System.Drawing.Size(464, 16);
            // 
            // wizardPageFormat
            // 
            this.wizardPageFormat.Controls.Add(this.groupBox2);
            this.wizardPageFormat.Description = "Define reports included in PCR";
            this.wizardPageFormat.Size = new System.Drawing.Size(562, 316);
            this.wizardPageFormat.Title = "Step 2: Define reports";
            this.wizardPageFormat.Controls.SetChildIndex(this.checkBoxCharts, 0);
            this.wizardPageFormat.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // wizardPageWelcome
            // 
            this.wizardPageWelcome.Description = resources.GetString("wizardPageWelcome.Description");
            this.wizardPageWelcome.Size = new System.Drawing.Size(562, 316);
            this.wizardPageWelcome.Title = "Principal Component Regression";
            // 
            // wizardPageData
            // 
            this.wizardPageData.Controls.Add(this.groupBox3);
            this.wizardPageData.Description = "Defines the parameters for PCR";
            this.wizardPageData.Location = new System.Drawing.Point(0, 0);
            this.wizardPageData.Name = "wizardPageData";
            this.wizardPageData.Size = new System.Drawing.Size(756, 404);
            this.wizardPageData.TabIndex = 14;
            this.wizardPageData.Title = "Step 1: Define system";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(14, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 185);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Equation: Ab=y";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(120, 146);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 23);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Omitted variables";
            // 
            // checkBox1
            // 
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(179, 106);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Use";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(80, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "Edit";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Weights";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(80, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Edit";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Y";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(80, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Edit";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxRes);
            this.groupBox2.Controls.Add(this.checkBoxPC);
            this.groupBox2.Controls.Add(this.checkBoxEigen);
            this.groupBox2.Controls.Add(this.checkBoxLS);
            this.groupBox2.Controls.Add(this.checkBoxCorrMtx);
            this.groupBox2.Controls.Add(this.checkBoxDescStat);
            this.groupBox2.Location = new System.Drawing.Point(251, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 193);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report on";
            // 
            // checkBoxRes
            // 
            this.checkBoxRes.Checked = true;
            this.checkBoxRes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxRes.Location = new System.Drawing.Point(7, 162);
            this.checkBoxRes.Name = "checkBoxRes";
            this.checkBoxRes.Size = new System.Drawing.Size(108, 21);
            this.checkBoxRes.TabIndex = 5;
            this.checkBoxRes.Text = "Residuals";
            // 
            // checkBoxPC
            // 
            this.checkBoxPC.Checked = true;
            this.checkBoxPC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxPC.Location = new System.Drawing.Point(7, 134);
            this.checkBoxPC.Name = "checkBoxPC";
            this.checkBoxPC.Size = new System.Drawing.Size(166, 21);
            this.checkBoxPC.TabIndex = 4;
            this.checkBoxPC.Text = "Principal Components";
            // 
            // checkBoxEigen
            // 
            this.checkBoxEigen.Checked = true;
            this.checkBoxEigen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxEigen.Location = new System.Drawing.Point(10, 106);
            this.checkBoxEigen.Name = "checkBoxEigen";
            this.checkBoxEigen.Size = new System.Drawing.Size(153, 21);
            this.checkBoxEigen.TabIndex = 3;
            this.checkBoxEigen.Text = "Eigenvalues";
            // 
            // checkBoxLS
            // 
            this.checkBoxLS.Checked = true;
            this.checkBoxLS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxLS.Location = new System.Drawing.Point(7, 78);
            this.checkBoxLS.Name = "checkBoxLS";
            this.checkBoxLS.Size = new System.Drawing.Size(147, 20);
            this.checkBoxLS.TabIndex = 2;
            this.checkBoxLS.Text = "LS Multicollinearity";
            // 
            // checkBoxCorrMtx
            // 
            this.checkBoxCorrMtx.Checked = true;
            this.checkBoxCorrMtx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCorrMtx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCorrMtx.Location = new System.Drawing.Point(7, 52);
            this.checkBoxCorrMtx.Name = "checkBoxCorrMtx";
            this.checkBoxCorrMtx.Size = new System.Drawing.Size(166, 21);
            this.checkBoxCorrMtx.TabIndex = 1;
            this.checkBoxCorrMtx.Text = "Correlation matrix";
            // 
            // checkBoxDescStat
            // 
            this.checkBoxDescStat.Checked = true;
            this.checkBoxDescStat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDescStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxDescStat.Location = new System.Drawing.Point(7, 23);
            this.checkBoxDescStat.Name = "checkBoxDescStat";
            this.checkBoxDescStat.Size = new System.Drawing.Size(166, 21);
            this.checkBoxDescStat.TabIndex = 0;
            this.checkBoxDescStat.Text = "Descriptive statistics";
            // 
            // PCRWizard
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(756, 452);
            this.Name = "PCRWizard";
            this.wizard.ResumeLayout(false);
            this.wizardPageReport.ResumeLayout(false);
            this.wizardPageReport.PerformLayout();
            this.wizardPageFormat.ResumeLayout(false);
            this.wizardPageFormat.PerformLayout();
            this.wizardPageData.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private void TextReport()
        {
            wizard.BackEnabled = false;
            wizard.NextEnabled = false;

            progressBar.Value = 0;
            DoCalc(); // Calculate PC regression
            richTextBox.SuspendLayout();
            try
            {

                richTextBox.Clear();

                if (checkBoxDescStat.Checked) DescStatReport();

                progressBar.Value = 15;
                if (checkBoxCorrMtx.Checked) CorrMtxReport();

                progressBar.Value = 30;
                if (checkBoxLS.Checked) LSMultiCollinearityReport();

                progressBar.Value = 60;
                if (checkBoxEigen.Checked) EigenvaluesReport();

                progressBar.Value = 70;
                if (checkBoxPC.Checked) PCRegReport();

                progressBar.Value = 90;
                if (checkBoxRes.Checked) ResidualsReport();

                progressBar.Value = 100;

                wizard.BackEnabled = true;
            }
            finally
            {
                richTextBox.SelectionStart = 0;
                richTextBox.ResumeLayout();
            }
        }

        #region Reports

        private void DoCalc()
        {
            if (checkBox1.Checked) Regress.PCRegress(Y,A,B,w,ycalc,bse,numOmmit);
            else Regress.PCRegress(Y,A,B,ycalc,bse,numOmmit);

            res = ycalc - y;
            // Standardized coefficients
            double sy = y.StdDev();
            Vector sa = new Vector(0);
            A.StdDevCols(sa);
            bstd.Size(b.Length-1);
            bstd.Copy(B,1,0,B.Length-1);
            bstd.Mul(sa);
            bstd.Mul(1.0/sy);
        }

        private void DescStatReport()
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Descriptive Statistics\n\n";
            richTextBox.SelectionColor = Color.Blue;
            SetupTabs(richTextBox, 5);
            richTextBox.SelectedText = "Variable\tMean\tStd.Dev.\tMin\tMax\n";
            double cmean, cstddev, cmax, cmin;
            string st = "";
            Vector tvec = new Vector(0);

            if (checkBoxCharts.Checked)
            {
                // Setup box plot chart
                Chart.Legend.Visible = false;
                Chart.Header.Text = "Box plot";
                Chart.Axes.Bottom.Title.Text = "Group (column)";
                Chart.Axes.Left.Title.Text = "Values";
                Chart.Aspect.View3D = false;
                Chart.Axes.Bottom.Increment = 1.0;
                Chart.Series.Clear();
            }

            // basic descriptive statistics
            for (int i = 0; i < A.Cols; i++)
            {
                tvec.GetCol(A, 0, i, A.Rows);
                cmean = tvec.Mean();
                cstddev = tvec.StdDev(cmean);
                cmax = tvec.Max();
                cmin = tvec.Min();
                st += "A column " + i.ToString() + "\t";
                st += Math387.FormatSample(FmtString, cmean) + "\t";
                st += Math387.FormatSample(FmtString, cstddev) + "\t";
                st += Math387.FormatSample(FmtString, cmin) + "\t";
                st += Math387.FormatSample(FmtString, cmax) + "\t\n";

                if (checkBoxCharts.Checked)
                {
                    Dew.Stats.Tee.BoxPlot bplot;
                    Chart.Series.Add(bplot = new Dew.Stats.Tee.BoxPlot());
                    bplot.Position = i;
                    bplot.Title = "Column " + i.ToString();
                    bplot.PlotStyle = Dew.Stats.Tee.BoxPlotStyle.bpDiamond;
                    tvec.SortAscend();
                    Dew.Math.Tee.MtxVecTee.DrawValues(tvec, bplot, 0, 1, false);
                }
            }

            st += "Y column\t" + Math387.FormatSample(FmtString, Y.Mean()) + "\t";
            st += Math387.FormatSample(FmtString, Y.StdDev()) + "\t";
            st += Math387.FormatSample(FmtString, Y.Min()) + "\t";
            st += Math387.FormatSample(FmtString, Y.Max()) + "\t\n";
            richTextBox.SelectedText = st + "\n";

            if (checkBoxCharts.Checked)
            {
                CopyToRichBox(richTextBox);
                richTextBox.SelectedText = "\n";
            }
        }

        private void CorrMtxReport()
        {
            Matrix adjcorr = new Matrix(0, 0);
            Matrix tmtx = new Matrix(0, 0);
            string st;
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Correlation matrix\n\n";
            adjcorr.Size(A.Rows, A.Cols + 1);
            SetupTabs(richTextBox, adjcorr.Cols);
            adjcorr.Copy(A, 0, 0, 0, 0, A.Rows, A.Cols, false);
            adjcorr.SetCol(Y, A.Cols);
            Statistics.CorrCoef(adjcorr, tmtx);
            st = tmtx.ValuesToText("\t", FmtString, FmtString); 
            richTextBox.SelectedText = st+"\n";  
        }

        private double R2Calc(Vector y, Matrix M)
        {
            Vector b = new Vector(0);
            Vector ycalc = new Vector(0);
            Regress.MulLinRegress(y,M,b,true,ycalc,null,TRegSolveMethod.regSolveLQR);
            return Regress.R2(y,ycalc);
        }

        private void LSMultiCollinearityReport()
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Least Squares Multicollinearity\n\n";
            SetupTabs(richTextBox, 4);
            richTextBox.SelectionColor = Color.Blue;
            richTextBox.SelectedText = "Variable\tVIF\tR2 vs. other\tTolerance\n";

            double r2,vif;
            string linetext = "";
            Matrix tmpm = new Matrix(0,0);
            Vector tmpv = new Vector(0);
            for (int i=0; i<A.Cols; i++)
            {
                Statistics.RemoveColumn(A,tmpm,i);
                tmpv.GetCol(A,i);
                r2 = R2Calc(tmpv,tmpm);
                vif = 1.0/(1.0-r2);
                linetext += i.ToString()+"\t"+Math387.FormatSample(vif,FmtString)+"\t";
                linetext += Math387.FormatSample(r2,FmtString)+"\t"+Math387.FormatSample(1.0-r2,FmtString)+"\n";
            }
            linetext += "\nIf some VIF’s are greater than 10, multicollinearity is a problem.\n\n";
            richTextBox.SelectedText = linetext;
        }

        private void EigenvaluesReport()
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Eigenvalues of Correlations\n\n";
            SetupTabs(richTextBox, 4);
            richTextBox.SelectionColor = Color.Blue;
            richTextBox.SelectedText = "Number\tEigenvalue\tPercent\tCond. number\n";
            Matrix PC = new Matrix(0, 0);
            Matrix Z = new Matrix(0, 0);
            Vector eigen = new Vector(0);
            Vector pct = new Vector(0);
            Statistics.PCA(A, PC, Z, eigen, pct, Dew.Stats.TPCAMode.PCACorrMat);
            string linetext = "";
            for (int i = 0; i < eigen.Length; i++)
            {
                linetext += i.ToString() + "\t" + Math387.FormatSample(eigen.Values[i], FmtString) + "\t";
                linetext += Math387.FormatSample(pct.Values[i], "0.00") + "\t" + Math387.FormatSample(eigen.Max() / eigen.Values[i], FmtString) + "\n";
            }
            richTextBox.SelectedText = linetext + "\n";
            richTextBox.SelectedText = "If some Condition Numbers are between 100 and 1000, Multicollinearity is a MILD problem.\n"
                + "If some Condition Numbers are greater than 1000, Multicollinearity is a SEVERE problem.\n\n";
        }

        private void ResidualsReport()
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Estimated values and residuals\n";
            richTextBox.SelectedText = "with " + numOmmit.ToString() + " variable(s) removed.\n\n";

            SetupTabs(richTextBox, 3);
            richTextBox.SelectionColor = Color.Blue;
            richTextBox.SelectedText = "Actual Y\tPredicted Y\tResidual\n";
            string linetext = "";
            for (int i = 0; i < y.Length; i++)
            {
                linetext += Math387.FormatSample(y.Values[i], FmtString) + "\t" + Math387.FormatSample(ycalc.Values[i], FmtString) + "\t";
                linetext += Math387.FormatSample(res.Values[i], FmtString) + "\n";
            }
            linetext += "\n";
            richTextBox.SelectedText = linetext;

            if (checkBoxCharts.Checked)
            {
                // Residuals histogram chart
                Chart.Legend.Visible = false;
                Chart.Header.Text = "Histogram of residuals";
                Chart.Axes.Bottom.Title.Text = "Residuals";
                Chart.Axes.Left.Title.Text = "Count";
                Chart.Aspect.View3D = false;
                Chart.Series.Clear();
                Steema.TeeChart.Styles.Bar bar;
                Chart.Series.Add(bar = new Steema.TeeChart.Styles.Bar());
                bar.Pen.Visible = false;
                bar.Marks.Visible = false;
                bar.BarWidthPercent = 100;
                Vector tv1 = new Vector(0);
                Vector tv2 = new Vector(0);
                Statistics.Histogram(res, 10, tv1, tv2, true);
                Dew.Math.Tee.MtxVecTee.DrawValues(tv2, tv1, bar, false);
                CopyToRichBox(richTextBox);
                richTextBox.SelectedText = "\n";

                // Residuals normal probability plot
                Chart.Header.Text = "Residuals normal probability plot";
                Chart.Axes.Bottom.Title.Text = "Residuals";
                Chart.Axes.Left.Title.Text = "Z value";
                Chart.Series.Clear();
                Dew.Stats.Tee.ProbabilityPlot ppseries;
                Chart.Series.Add(ppseries = new Dew.Stats.Tee.ProbabilityPlot());
                double minx, maxx, miny, maxy;
                StatProbPlots.StatNormalPlot(res, tv1, tv2, out minx, out maxx, out miny, out maxy, null, false);
                ppseries.minX = minx;
                ppseries.maxX = maxx;
                ppseries.minY = miny;
                ppseries.maxY = maxy;
                ppseries.SlopePen.Visible = true;
                ppseries.SlopePen.Color = Color.Black;
                ppseries.SlopePen.Style = Steema.TeeChart.Drawing.DashStyle.Dot;
                Dew.Math.Tee.MtxVecTee.DrawValues(tv1, tv2, ppseries, false);
                CopyToRichBox(richTextBox);
                richTextBox.SelectedText = "\n";
            }
        }

        private void PCRegReport()
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "PC Regression Coefficients\n";
            richTextBox.SelectedText = "with " + numOmmit.ToString() + " variable(s) removed.\n\n";
            SetupTabs(richTextBox, 4);
            richTextBox.SelectionColor = Color.Blue;
            richTextBox.SelectedText = "Variable\tCoeff.\tCoeff. SE\tStd(Coeff.)\n";
            string linetext = "";
            for (int i = 0; i < b.Length; i++)
            {
                if (i == 0) linetext += "Intercept\t"; else linetext += i - 1 + "\t";
                linetext += Math387.FormatSample(b.Values[i], FmtString) + "\t";
                if (i > 0)
                {
                    linetext += Math387.FormatSample(bse.Values[i - 1], FmtString) + "\t" + Math387.FormatSample(bstd.Values[i - 1], FmtString);
                }
                linetext += "\n";
            }
            linetext += "\n";
            richTextBox.SelectedText = linetext;
            double mse = res.SumOfSquares() / (double)(res.Length - b.Length);
            
            richTextBox.SelectedText = "Model R2:\t" + Math387.FormatSample(Regress.R2(y, ycalc), FmtString) + "\n";
            richTextBox.SelectedText = "Model Sigma:\t" + Math387.FormatSample(Math.Sqrt(mse), FmtString) + "\n\n";
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Dew.Math.Editors.MtxVecEdit.ViewValues(A, "A in Ab=y", true, true, true);
            wizard.NextEnabled = (A.Rows == Y.Length);
            numericUpDown1.Maximum = A.Cols - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dew.Math.Editors.MtxVecEdit.ViewValues(Y, "y in Ab=y", true, true, true);
            wizard.NextEnabled = (A.Rows == Y.Length);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dew.Math.Editors.MtxVecEdit.ViewValues(Weights, "Weights", true, true, true);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button3.Enabled = checkBox1.Checked;
        }

        private void wizard_AfterSwitchPages(object sender, Wizard.AfterSwitchPagesEventArgs e)
        {
            WizardPage newpage = wizard.Pages[e.NewIndex];
            if (newpage == wizardPageReport)
            {
                TextReport();
                wizard.CancelEnabled = false;
            }
            else if (newpage == wizardPageData)
            {
                wizard.NextEnabled = (A.Rows == Y.Length);
            }
            else wizard.CancelEnabled = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numOmmit = (int)numericUpDown1.Value;
        }


    }
}

