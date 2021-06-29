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
using Dew.Stats.Tee;
using Dew.Math.Tee;

namespace StatsMasterDemo
{
    public class MulRegWizard : StatsMasterDemo.BaseStatWizard
    {
        public MulRegWizard()
        {
            InitializeComponent();
            // Manually reposition Data wizard page after the Welcome page
            wizard.Pages.Remove(wizardPageData);
            wizard.Pages.Insert(1, wizardPageData);
        }

        private Dew.Stats.TMtxMulLinReg tMtxMulLinReg1;
        private WizardPage wizardPageData;
        private GroupBox groupBox2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox checkBoxIntercept;
        private CheckBox checkBoxWeights;
        private GroupBox groupBox3;
        private CheckBox checkBoxANOVA;
        private CheckBox checkBoxNormality;
        private CheckBox checkBoxSerCorr;
        private CheckBox checkBoxCorr;
        private CheckBox checkBoxRegStat;
        private CheckBox checkBoxResiduals;
        private CheckBox checkBoxDescStat;
        private CheckBox checkBoxRegCoeff;
        private ComboBox comboBox1;
        private Label label7;
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
            this.components = new System.ComponentModel.Container();
            this.tMtxMulLinReg1 = new Dew.Stats.TMtxMulLinReg(this.components);
            this.wizardPageData = new Dew.Math.Controls.WizardPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxIntercept = new System.Windows.Forms.CheckBox();
            this.checkBoxWeights = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxANOVA = new System.Windows.Forms.CheckBox();
            this.checkBoxNormality = new System.Windows.Forms.CheckBox();
            this.checkBoxSerCorr = new System.Windows.Forms.CheckBox();
            this.checkBoxCorr = new System.Windows.Forms.CheckBox();
            this.checkBoxRegStat = new System.Windows.Forms.CheckBox();
            this.checkBoxResiduals = new System.Windows.Forms.CheckBox();
            this.checkBoxDescStat = new System.Windows.Forms.CheckBox();
            this.checkBoxRegCoeff = new System.Windows.Forms.CheckBox();
            this.wizard.SuspendLayout();
            this.wizardPageReport.SuspendLayout();
            this.wizardPageFormat.SuspendLayout();
            this.wizardPageData.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizard
            // 
            this.wizard.Controls.Add(this.wizardPageData);
            this.wizard.Pages.AddRange(new Dew.Math.Controls.WizardPage[] {
            this.wizardPageData});
            this.wizard.Size = new System.Drawing.Size(569, 461);
            this.wizard.AfterSwitchPages += new Dew.Math.Controls.Wizard.AfterSwitchPagesEventHandler(this.wizard_AfterSwitchPages);
            this.wizard.Load += new System.EventHandler(this.wizard_Load);
            this.wizard.Controls.SetChildIndex(this.wizardPageData, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageReport, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageFormat, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageWelcome, 0);
            // 
            // wizardPageReport
            // 
            this.wizardPageReport.Size = new System.Drawing.Size(562, 388);
            this.wizardPageReport.Title = "MLR: Report";
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(18, 144);
            this.richTextBox.Size = new System.Drawing.Size(529, 217);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(83, 95);
            this.progressBar.Size = new System.Drawing.Size(464, 16);
            // 
            // checkBoxCharts
            // 
            this.checkBoxCharts.Location = new System.Drawing.Point(25, 240);
            // 
            // wizardPageFormat
            // 
            this.wizardPageFormat.Controls.Add(this.groupBox3);
            this.wizardPageFormat.Description = "Define which reports to include in MLR analysis";
            this.wizardPageFormat.Size = new System.Drawing.Size(562, 388);
            this.wizardPageFormat.Title = "Step 2: Define reports";
            this.wizardPageFormat.Controls.SetChildIndex(this.checkBoxCharts, 0);
            this.wizardPageFormat.Controls.SetChildIndex(this.groupBox3, 0);
            // 
            // wizardPageWelcome
            // 
            this.wizardPageWelcome.Size = new System.Drawing.Size(562, 388);
            this.wizardPageWelcome.Title = "Multiple Linear Regression";
            // 
            // textBoxAlpha
            // 
            this.textBoxAlpha.Location = new System.Drawing.Point(98, 74);
            this.textBoxAlpha.Size = new System.Drawing.Size(102, 23);
            // 
            // tMtxMulLinReg1
            // 
            this.tMtxMulLinReg1.BlockAssign = false;
            this.tMtxMulLinReg1.Dirty = false;
            this.tMtxMulLinReg1.Name = null;
            // 
            // wizardPageData
            // 
            this.wizardPageData.Controls.Add(this.groupBox2);
            this.wizardPageData.Description = "Define A*b=y parameters";
            this.wizardPageData.Location = new System.Drawing.Point(0, 0);
            this.wizardPageData.Name = "wizardPageData";
            this.wizardPageData.Size = new System.Drawing.Size(569, 413);
            this.wizardPageData.TabIndex = 13;
            this.wizardPageData.Title = "Step 1: Define equation system";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.checkBoxIntercept);
            this.groupBox2.Controls.Add(this.checkBoxWeights);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(14, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 256);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System";
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "LQR",
            "SVD",
            "LU"});
            this.comboBox1.Location = new System.Drawing.Point(110, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 23);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Solving method";
            // 
            // checkBoxIntercept
            // 
            this.checkBoxIntercept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxIntercept.Location = new System.Drawing.Point(11, 165);
            this.checkBoxIntercept.Name = "checkBoxIntercept";
            this.checkBoxIntercept.Size = new System.Drawing.Size(150, 21);
            this.checkBoxIntercept.TabIndex = 7;
            this.checkBoxIntercept.Text = "Remove intercept";
            this.checkBoxIntercept.Click += new System.EventHandler(this.checkBoxIntercept_Click);
            // 
            // checkBoxWeights
            // 
            this.checkBoxWeights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxWeights.Location = new System.Drawing.Point(11, 137);
            this.checkBoxWeights.Name = "checkBoxWeights";
            this.checkBoxWeights.Size = new System.Drawing.Size(150, 21);
            this.checkBoxWeights.TabIndex = 6;
            this.checkBoxWeights.Text = "Use weights";
            this.checkBoxWeights.CheckedChanged += new System.EventHandler(this.checkBoxWeights_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(168, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "Edit";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(168, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Edit";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(168, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Edit";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Weights (optional)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Dependentnt variables (y)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Independent variables (A)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxANOVA);
            this.groupBox3.Controls.Add(this.checkBoxNormality);
            this.groupBox3.Controls.Add(this.checkBoxSerCorr);
            this.groupBox3.Controls.Add(this.checkBoxCorr);
            this.groupBox3.Controls.Add(this.checkBoxRegStat);
            this.groupBox3.Controls.Add(this.checkBoxResiduals);
            this.groupBox3.Controls.Add(this.checkBoxDescStat);
            this.groupBox3.Controls.Add(this.checkBoxRegCoeff);
            this.groupBox3.Location = new System.Drawing.Point(258, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 282);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Report on";
            // 
            // checkBoxANOVA
            // 
            this.checkBoxANOVA.Checked = true;
            this.checkBoxANOVA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxANOVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxANOVA.Location = new System.Drawing.Point(23, 144);
            this.checkBoxANOVA.Name = "checkBoxANOVA";
            this.checkBoxANOVA.Size = new System.Drawing.Size(169, 21);
            this.checkBoxANOVA.TabIndex = 15;
            this.checkBoxANOVA.Text = "Analysis of variance";
            // 
            // checkBoxNormality
            // 
            this.checkBoxNormality.Checked = true;
            this.checkBoxNormality.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNormality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxNormality.Location = new System.Drawing.Point(23, 116);
            this.checkBoxNormality.Name = "checkBoxNormality";
            this.checkBoxNormality.Size = new System.Drawing.Size(150, 21);
            this.checkBoxNormality.TabIndex = 14;
            this.checkBoxNormality.Text = "Normality tests";
            // 
            // checkBoxSerCorr
            // 
            this.checkBoxSerCorr.Checked = true;
            this.checkBoxSerCorr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSerCorr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxSerCorr.Location = new System.Drawing.Point(23, 229);
            this.checkBoxSerCorr.Name = "checkBoxSerCorr";
            this.checkBoxSerCorr.Size = new System.Drawing.Size(150, 21);
            this.checkBoxSerCorr.TabIndex = 13;
            this.checkBoxSerCorr.Text = "Serial correlation";
            // 
            // checkBoxCorr
            // 
            this.checkBoxCorr.Checked = true;
            this.checkBoxCorr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCorr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCorr.Location = new System.Drawing.Point(23, 201);
            this.checkBoxCorr.Name = "checkBoxCorr";
            this.checkBoxCorr.Size = new System.Drawing.Size(159, 21);
            this.checkBoxCorr.TabIndex = 12;
            this.checkBoxCorr.Text = "Correlation matrix";
            // 
            // checkBoxRegStat
            // 
            this.checkBoxRegStat.Checked = true;
            this.checkBoxRegStat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRegStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxRegStat.Location = new System.Drawing.Point(23, 172);
            this.checkBoxRegStat.Name = "checkBoxRegStat";
            this.checkBoxRegStat.Size = new System.Drawing.Size(207, 21);
            this.checkBoxRegStat.TabIndex = 11;
            this.checkBoxRegStat.Text = "Additional regression statistics";
            // 
            // checkBoxResiduals
            // 
            this.checkBoxResiduals.Checked = true;
            this.checkBoxResiduals.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxResiduals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxResiduals.Location = new System.Drawing.Point(23, 87);
            this.checkBoxResiduals.Name = "checkBoxResiduals";
            this.checkBoxResiduals.Size = new System.Drawing.Size(111, 21);
            this.checkBoxResiduals.TabIndex = 10;
            this.checkBoxResiduals.Text = "Residuals";
            // 
            // checkBoxDescStat
            // 
            this.checkBoxDescStat.Checked = true;
            this.checkBoxDescStat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDescStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxDescStat.Location = new System.Drawing.Point(23, 59);
            this.checkBoxDescStat.Name = "checkBoxDescStat";
            this.checkBoxDescStat.Size = new System.Drawing.Size(169, 21);
            this.checkBoxDescStat.TabIndex = 9;
            this.checkBoxDescStat.Text = "Descriptive statistics";
            // 
            // checkBoxRegCoeff
            // 
            this.checkBoxRegCoeff.Checked = true;
            this.checkBoxRegCoeff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRegCoeff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxRegCoeff.Location = new System.Drawing.Point(23, 31);
            this.checkBoxRegCoeff.Name = "checkBoxRegCoeff";
            this.checkBoxRegCoeff.Size = new System.Drawing.Size(169, 21);
            this.checkBoxRegCoeff.TabIndex = 8;
            this.checkBoxRegCoeff.Text = "Regression coefficients";
            // 
            // MulRegWizard
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(569, 461);
            this.Name = "MulRegWizard";
            this.Load += new System.EventHandler(this.MulRegWizard_Load);
            this.wizard.ResumeLayout(false);
            this.wizardPageReport.ResumeLayout(false);
            this.wizardPageReport.PerformLayout();
            this.wizardPageFormat.ResumeLayout(false);
            this.wizardPageFormat.PerformLayout();
            this.wizardPageData.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private Vector tmpV = new Vector(0);
        private Matrix tmpM = new Matrix(0, 0);

        public TVec Y
        {
            get { return tMtxMulLinReg1.Y; }
        }

        public TMtx A
        {
            get { return tMtxMulLinReg1.A; }
        }

        public TVec Weights
        {
            get { return tMtxMulLinReg1.Weights; }
        }


        private void UpdateMLSystem()
        {
            wizard.NextEnabled = tMtxMulLinReg1.ValidSystem() || wizard.SelectedPage == wizardPageWelcome;
        }
        
        private void TextReport()
        {
            wizard.BackEnabled = false;
            wizard.NextEnabled = false;
            this.Cursor = Cursors.WaitCursor;

            progressBar.Value = 0;
            tMtxMulLinReg1.Recalc();

            richTextBox.SuspendLayout();
            try
            {
                richTextBox.Clear();
                if (checkBoxDescStat.Checked) DescStatReport();

                progressBar.Value = 15;
                if (checkBoxRegStat.Checked) RegStatReport();

                progressBar.Value = 30;
                if (checkBoxRegCoeff.Checked) RegCoeffReport();

                progressBar.Value = 45;
                if (checkBoxResiduals.Checked) ResidualsReport();

                progressBar.Value = 60;
                if (checkBoxNormality.Checked) NormalityReport();

                progressBar.Value = 70;
                if (checkBoxANOVA.Checked) ANOVAReport();

                progressBar.Value = 80;
                if (checkBoxCorr.Checked) CorrReport();

                progressBar.Value = 90;
                if (checkBoxSerCorr.Checked) SerCorrReport();

                progressBar.Value = 100;

                wizard.BackEnabled = true;
            }
            finally
            {
                richTextBox.SelectionStart = 0;
                richTextBox.ResumeLayout();
                this.Cursor = Cursors.Default;
            }
        }

        private void checkBoxWeights_CheckedChanged(object sender, EventArgs e)
        {
            tMtxMulLinReg1.UseWeights = checkBoxWeights.Checked;
            button3.Enabled = checkBoxWeights.Checked;
        }

        private void checkBoxIntercept_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dew.Math.Editors.MtxVecEdit.ViewValues(A, "Independent variables", true, false, true);
            UpdateMLSystem();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dew.Math.Editors.MtxVecEdit.ViewValues(Y, "Dependent variables", true, false, true);
            UpdateMLSystem();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dew.Math.Editors.MtxVecEdit.ViewValues(Weights, "weights", true, false, true);
            UpdateMLSystem();
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
                wizard.NextEnabled = tMtxMulLinReg1.ValidSystem();
            }
            else wizard.CancelEnabled = true;

        }

        #region Reports

        private void ResidualsReport()
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Residuals\n\n";
            richTextBox.SelectionColor = Color.Blue;
            SetupTabs(richTextBox, 3);
            richTextBox.SelectedText = "Actual\tPredicted\tResidual\n";
            // regression coefficients
            string st = "";
            for (int i = 0; i < Y.Length; i++)
            {
                st += Math387.FormatSample(FmtString, Y.Values[i]) + "\t";
                st += Math387.FormatSample(FmtString, tMtxMulLinReg1.RegressResult.YCalc.Values[i]) + "\t";
                st += Math387.FormatSample(FmtString, tMtxMulLinReg1.RegressResult.Residuals.Values[i]) + "\n";
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
                Statistics.Histogram(tMtxMulLinReg1.RegressResult.Residuals, 10, tmpV, tvec1, true);
                TeeChart.DrawValues(tvec1, tmpV, bar, false);
                CopyToRichBox(richTextBox);
                richTextBox.SelectedText = "\n";

                // #2: Serial correlation lag
                Chart.Series.Clear();
                Chart.Header.Text = "Residuals Serial Correlation";
                Chart.Axes.Left.Title.Text = "Residuals";
                Chart.Axes.Bottom.Title.Text = "Residuals Lagged Once";
                Chart.Series.Add(new Steema.TeeChart.Styles.Points());
                Vector x = new Vector(0);
                Vector y = new Vector(0);
                x.Size(tMtxMulLinReg1.RegressResult.Residuals.Length - 1);
                y.Size(x);
                x.Copy(tMtxMulLinReg1.RegressResult.Residuals, 1, 0, x.Length);
                y.Copy(tMtxMulLinReg1.RegressResult.Residuals, 0, 0, x.Length);
                TeeChart.DrawValues(y, x, Chart.Series[0], false);
                CopyToRichBox(richTextBox);
                richTextBox.SelectedText = "\n";

                // #3: Residuals vs predicted values
                Chart.Series.Clear();
                Chart.Header.Text = "Residuals versus predicted values";
                Chart.Axes.Left.Title.Text = "Residuals";
                Chart.Axes.Bottom.Title.Text = "Predicted";
                Chart.Series.Add(new Steema.TeeChart.Styles.Points());
                TeeChart.DrawValues(tMtxMulLinReg1.RegressResult.Residuals, tMtxMulLinReg1.RegressResult.YCalc, Chart.Series[0], false);
                CopyToRichBox(richTextBox);
                richTextBox.SelectedText = "\n";
            }
        }

        private void RegStatReport()
        {
            double press = Regress.PRESS(A, Y);
            double pressR2 = 1.0 - press / tMtxMulLinReg1.RegressStatistics.TSS;
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Additional regression statistics\r\n\r\n";
            richTextBox.SelectionTabs = new int[] { 150 };
            richTextBox.SelectedText = "Residuals variance:\t" + Math387.FormatSample(FmtString, tMtxMulLinReg1.RegressStatistics.ResidualVar) + "\r\n";
            richTextBox.SelectedText += "R squared:\t" + Math387.FormatSample(FmtString, tMtxMulLinReg1.RegressStatistics.R2) + "\r\n";
            richTextBox.SelectedText += "Adjusted R squared:\t" + Math387.FormatSample(FmtString, tMtxMulLinReg1.RegressStatistics.AdjustedR2) + "\r\n";
            richTextBox.SelectedText += "PRESS :\t" + Math387.FormatSample(press, FmtString) + "\r\n";
            richTextBox.SelectedText += "PRESS R2:\t" + Math387.FormatSample(pressR2, FmtString) + "\r\n";
            richTextBox.SelectedText += "F value:\t" + Math387.FormatSample(FmtString, tMtxMulLinReg1.RegressStatistics.F) + "\r\n";
            richTextBox.SelectedText += "Probability of F:\t" + Math387.FormatSample(FmtString, tMtxMulLinReg1.RegressStatistics.SignifProb) + "\r\n";
            richTextBox.SelectedText += "Total SS:\t" + Math387.FormatSample(FmtString, tMtxMulLinReg1.RegressStatistics.TSS) + "\r\n";
            richTextBox.SelectedText += "Regression SS:\t" + Math387.FormatSample(FmtString, tMtxMulLinReg1.RegressStatistics.RSS) + "\r\n";
            richTextBox.SelectedText += "Errors SS:\t" + Math387.FormatSample(FmtString, tMtxMulLinReg1.RegressStatistics.SSE) + "\r\n\r\n";
        }

        private void CorrReport()
        {
            Matrix adjcorr = new Matrix(0, 0);
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Correlation matrix\n\n";
            adjcorr.Size(A.Rows, A.Cols + 1);
            SetupTabs(richTextBox, adjcorr.Cols);
            adjcorr.Copy(A, 0, 0, 0, 0, A.Rows, A.Cols, false);
            adjcorr.SetCol(Y, A.Cols);
            Statistics.CorrCoef(adjcorr, tmpM);
            string txt = tmpM.ValuesToText("\t", FmtString, FmtString);
            richTextBox.SelectedText = txt + "\n\n";
            
        }

        private void DescStatReport()
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Descriptive Statistics\n\n";
            richTextBox.SelectionColor = Color.Blue;
            SetupTabs(richTextBox, 5);
            richTextBox.SelectedText = "Variable\tMean\tStd.Dev.\tMin\tMax\n";

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
            double cmean, cstddev, cmax, cmin;
            string st = "";

            // basic descriptive statistics
            for (int i = 0; i < A.Cols; i++)
            {
                tmpV.GetCol(A, 0, i, A.Rows);
                cmean = tmpV.Mean();
                cstddev = tmpV.StdDev(cmean);
                cmax = tmpV.Max();
                cmin = tmpV.Min();
                st += "A column " + i.ToString() + "\t";
                st += Math387.FormatSample(FmtString, cmean) + "\t";
                st += Math387.FormatSample(FmtString, cstddev) + "\t";
                st += Math387.FormatSample(FmtString, cmin) + "\t";
                st += Math387.FormatSample(FmtString, cmax) + "\t\n";

                if (checkBoxCharts.Checked)
                {
                    BoxPlot bplot;
                    Chart.Series.Add(bplot = new BoxPlot());
                    bplot.Position = i;
                    bplot.Title = "Column " + i.ToString();
                    bplot.PlotStyle = Dew.Stats.Tee.BoxPlotStyle.bpDiamond;
                    tmpV.SortAscend();
                    Dew.Math.Tee.TeeChart.DrawValues(tmpV, bplot, 0, 1, false);
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

        private void RegCoeffReport()
        {
            Vector tVals = new Vector(0);
            Vector pVals = new Vector(0);
            // calculate t values
            // This is the t-test value for testing the hypothesis that j = 0 versus 
            // the alternative that after removing the influence of all other X's. 
            // This t-value has Rows-Cols-1 degrees of freedom.
            tVals.Divide(tMtxMulLinReg1.RegressResult.B, tMtxMulLinReg1.RegressResult.BStdDev);


            // calculate p values
            // The p-value is the probability that above T-statistic will take on a value 
            // at least as extreme as the actually observed value, assuming that the null hypothesis
            // is true (i.e., the regression estimate is equal to zero). If the p-value is less than
            // alpha, say 0.05, the null hypothesis is rejected. 
            // This p-value is for a two-tail test.
            Probabilities.StudentCDF(tVals, A.Rows - A.Cols - 1, pVals);
            for (int i = 0; i < pVals.Length; i++)
                pVals.Values[i] = 2.0 * Math387.Min(pVals.Values[i], 1.0 - pVals.Values[i]);
            string CIText = Math387.FormatSample("0.00 %", (1 - tMtxMulLinReg1.Alpha));

            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Regression coefficients\n\n";
            SetupTabs(richTextBox, 7);
            richTextBox.SelectionColor = Color.Blue;
            richTextBox.SelectedText = "Independent\tRegression\tStandard\tT Value\t\tLower\tUpper\n"
                + "variable\tcoefficient\tdeviation\tHo: B=0\tP Value\t" + CIText + " CI\t" + CIText + " CI\n";

            // regression coefficients
            Dew.Stats.TRegResultClass res = tMtxMulLinReg1.RegressResult;
            string st = "";
            for (int i = 0; i < res.B.Length; i++)
            {
                st += "Variable " + i.ToString() + "\t";
                st += Math387.FormatSample(FmtString, res.B.Values[i]) + "\t";
                st += Math387.FormatSample(FmtString, res.BStdDev.Values[i]) + "\t";
                st += Math387.FormatSample(FmtString, tVals.Values[i]) + "\t";
                st += Math387.FormatSample(FmtString, pVals.Values[i]) + "\t";
                st += Math387.FormatSample(FmtString, res.BConfInt.Values[i, 0]) + "\t";
                st += Math387.FormatSample(FmtString, res.BConfInt.Values[i, 1]) + "\n";
            }
            richTextBox.SelectedText = st + "\n";
        }

        private void SerCorrReport()
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Serial correlation (up to 10th lag)\n\n";
            richTextBox.SelectionTabs = new int[] { 50};
            richTextBox.SelectionColor = Color.Blue;
            richTextBox.SelectedText = "Lag\tCorrelation\n";
            Dew.Stats.TRegResultClass res = tMtxMulLinReg1.RegressResult;
            // max 10 lags
            int lags = Math387.Min(res.Residuals.Length, 11);
            // Sum of squares
            double ss = res.Residuals.SumOfSquares();
            tmpV.AutoCorrNormal(res.Residuals, lags);
            tmpV.Mul(1.0 / ss);
            // regression coefficients
            string st = "";
            for (int i = 1; i < tmpV.Length; i++)
            {
                st += i.ToString() + "\t" + Math387.FormatSample(FmtString, tmpV.Values[i]) + "\n";
            }
            richTextBox.SelectedText = st;
            
            if (checkBoxCharts.Checked)
            {
                // #3: Correlation vs lag
                Chart.Series.Clear();
                Chart.Header.Text = "Correlation versus Lag";
                Chart.Axes.Left.Title.Text = "Correlation";
                Chart.Axes.Bottom.Title.Text = "Lag";
                Chart.Series.Add(new Steema.TeeChart.Styles.Line());
                tmpV.SetSubRange(1, tmpV.Length - 1);
                TeeChart.DrawValues(tmpV, Chart.Series[0], 1, 1, false);
                tmpV.SetSubRange();
                CopyToRichBox(richTextBox);
                richTextBox.SelectedText = "\n";
            }


            richTextBox.SelectedText = "Serial correlations are significant if their "
                    + "absolute values are greater than " + Math387.FormatSample(FmtString, Math387.Power(2.0, Math.Sqrt(tmpV.Length))) + "\n";
            if (tmpV.Length > 1)
                richTextBox.SelectedText = "Durbin-Watson value:\t" + Math387.FormatSample(FmtString, 2.0 * (1.0 - tmpV.Values[1])) + "\n";
        }

        private void NormalityReport()
        {
            Dew.Stats.THypothesisResult hres;
            double signif, statval;
            string st = "";
            TVec data = tMtxMulLinReg1.RegressResult.Residuals;

            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Normality tests on residuals\n\n";
            richTextBox.SelectionTabs = new int[] { 130, 210, 300};
            richTextBox.SelectionColor = Color.Blue;
            richTextBox.SelectedText = "Test\tTest\tProbability\tReject Ho at\n"
                    + "name\tvalue\tlevel\talpha=" + Math387.FormatSample("0.0%", tMtxMulLinReg1.Alpha) + "\n";
			
			// Anderson-Darling test
			tmpV.Copy(data);
			tmpV.SortAscend();
			statval = Statistics.AndersonDarling(tmpV, TDistribution.distNORMAL,out hres, out signif, tMtxMulLinReg1.Alpha);
			st += "Anderson-Darling\t" + Math387.FormatSample(FmtString, statval) + "\t" + Math387.FormatSample(FmtString, signif) + "\t" + HypResult(hres) + "\n";

			// Shapiro-Wilks test
            // input vector must be ordered and unique ...
            Statistics.Unique(data, tmpV,null);
            statval = Statistics.ShapiroWilks(tmpV, out hres, out signif, Dew.Stats.THypothesisType.htTwoTailed, tMtxMulLinReg1.Alpha);
            st += "Shapiro-Wilks\t" + Math387.FormatSample(FmtString, statval) + "\t" + Math387.FormatSample(FmtString, signif) + "\t" + HypResult(hres) + "\n";

            // Shapiro-Francia test
            // input vector must be ordered and unique ...
            statval = Statistics.ShapiroFrancia(tmpV, out hres, out signif, Dew.Stats.THypothesisType.htTwoTailed, tMtxMulLinReg1.Alpha);
            st += "Shapiro-Francia\t" + Math387.FormatSample(FmtString, statval) + "\t" + Math387.FormatSample(FmtString, signif) + "\t" + HypResult(hres) + "\n";

            // KS test
            statval = Statistics.GOFKolmogorov(data, out hres, out signif, null, null, Dew.Stats.THypothesisType.htTwoTailed, tMtxMulLinReg1.Alpha);
            st += "KS\t" + Math387.FormatSample(FmtString, statval) + "\t" + Math387.FormatSample(FmtString, signif) + "\t" + HypResult(hres) + "\n";

            // Lilliefors test
            statval = Statistics.GOFLillieTest(data, out hres, out signif, tMtxMulLinReg1.Alpha,1e-2);
            st += "Lillie\t" + Math387.FormatSample(FmtString, statval) + "\t" + Math387.FormatSample(FmtString, signif) + "\t" + HypResult(hres) + "\n";

            // Bera-Jarque
            statval = Statistics.GOFBeraJarqueTest(data, out hres, out signif, tMtxMulLinReg1.Alpha);
            st += "Bera-Jarque\t" + Math387.SampleToStr(statval,6,6) + "\t" + Math387.FormatSample(FmtString, signif) + "\t" + HypResult(hres) + "\n";

			richTextBox.SelectedText = st + "\n";

            if (checkBoxCharts.Checked)
            {
                // #1:  Normal pp on residuals
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
                Vector x = new Vector(0);
                Vector y = new Vector(0);
                StatProbPlots.StatNormalPlot(tMtxMulLinReg1.RegressResult.Residuals, x, y, out minx, out maxx, out miny, out maxy, null, false);
                ser.minX = minx;
                ser.maxX = maxx;
                ser.minY = miny;
                ser.maxY = maxy;
                TeeChart.DrawValues(x, y, ser, false);
                CopyToRichBox(richTextBox);
                richTextBox.SelectedText = "\n";
            }

        }

        private void ANOVAReport()
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Analysis of variance\n\n";
            SetupTabs(richTextBox, 7);
            richTextBox.SelectionColor = Color.Blue;
            richTextBox.SelectedText = "Source\tdf\tR2\tSS\tMSS\tF-ratio\tProbability\n";

            
            string st = "";

            Dew.Stats.TRegStats stats;
            Regress.RegressTest(tMtxMulLinReg1.Y, tMtxMulLinReg1.RegressResult.YCalc, tMtxMulLinReg1.A.Rows,
                out stats, tMtxMulLinReg1.Constant, null);

            // Intercept, if applicable
            int dfIntercept = tMtxMulLinReg1.Constant ? 1 : 0;
            double ya = Y.Mean();
            double SSIntercept = A.Rows * ya * ya;

            if (tMtxMulLinReg1.Constant)
            {

                st += "Intercept\t" + dfIntercept.ToString();
                st += "\t\t";
                st += Math387.FormatSample(SSIntercept, FmtString) + "\t"; // SSE
                st += Math387.FormatSample(SSIntercept/(double)dfIntercept, FmtString) + "\t"; // MSE
                st += "\n";
            }

            // Model
            int dfModel = A.Cols;
            double SSModel = tMtxMulLinReg1.RegressStatistics.RSS;

            st += "Model\t" + dfModel.ToString()+"\t";
            st += Math387.FormatSample(tMtxMulLinReg1.RegressStatistics.R2, FmtString) + "\t";  // R2
            st += Math387.FormatSample(SSModel, FmtString) + "\t"; // SSE
            st += Math387.FormatSample(SSModel / (double)dfModel, FmtString) + "\t"; // MSE
            st += Math387.FormatSample(tMtxMulLinReg1.RegressStatistics.F, FmtString) + "\t";
            st += Math387.FormatSample(tMtxMulLinReg1.RegressStatistics.SignifProb, FmtString) + "\n";


            // Error
            int dfError = A.Rows - A.Cols - 1;
            double SSError = tMtxMulLinReg1.RegressStatistics.SSE;
            st += "Error\t" + dfError.ToString()+"\t";
            st += Math387.FormatSample(1.0-tMtxMulLinReg1.RegressStatistics.R2, FmtString) + "\t";  // 1-R2
            st += Math387.FormatSample(SSError, FmtString) + "\t"; // SSError
            st += Math387.FormatSample(SSError / (double)dfError, FmtString) + "\t"; // MSError
            st += "\n";


            // Total adjusted
            int dfTotalAdj = A.Rows - dfIntercept;
            double SSTotalAdj = tMtxMulLinReg1.RegressStatistics.TSS;
            st += "Total (adj)\t" + dfTotalAdj.ToString();
            st += "\t"+Math387.FormatSample(1.0,FmtString)+"\t";
            st += Math387.FormatSample(SSTotalAdj, FmtString) + "\t"; // SSE
            st += Math387.FormatSample(SSTotalAdj / (double)dfTotalAdj, FmtString) + "\t"; // MSE
            st += "\n";

            richTextBox.SelectedText = st + "\n\n";
        }


        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tMtxMulLinReg1.SolveMethod = (Dew.Stats.TRegSolveMethod)comboBox1.SelectedIndex;
        }


        private void checkBoxIntercept_Click(object sender, EventArgs e)
        {
            tMtxMulLinReg1.Constant = !checkBoxIntercept.Checked;
        }

        private void MulRegWizard_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = (int)tMtxMulLinReg1.SolveMethod;
            checkBoxWeights.Checked = tMtxMulLinReg1.UseWeights;
            checkBoxIntercept.Checked = !tMtxMulLinReg1.Constant;
        }

        private void wizard_Load(object sender, EventArgs e)
        {
            wizardPageWelcome.Description = "Multiple regression analysis studies the relationship between a dependent variable y (response) and independent "
                + "variables A (predictors, regressors) in the equation:\n\n\ty=A*b  ,\n\nwhere b are unknown regression coefficients.";
        }
    }

}

