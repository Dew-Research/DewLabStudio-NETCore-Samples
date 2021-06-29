using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Units;
using Dew.Math.Controls;
using Dew.Stats.Units;
using Dew.Math.Tee;
using Dew.Stats;

namespace StatsMasterDemo 
{
    public class MDSWizard : StatsMasterDemo.BaseStatWizard
    {
        public MDSWizard()
        {
            InitializeComponent();
            // Manually reposition Data wizard page after the Welcome page
            wizard.Pages.Remove(wizardPageData);
            wizard.Pages.Insert(1, wizardPageData);
        }

        public Dew.Stats.TMtxMDScaling tMtxMDScaling1;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox3;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox groupBox4;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label7;
        private Label label8;
        private Label labelStatus;
        private Button button1;
        private Label labelColumns;
        private Label labelRows;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDSWizard));
            this.wizardPageData = new Dew.Math.Controls.WizardPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelColumns = new System.Windows.Forms.Label();
            this.labelRows = new System.Windows.Forms.Label();
            this.tMtxMDScaling1 = new Dew.Stats.TMtxMDScaling(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wizard.SuspendLayout();
            this.wizardPageReport.SuspendLayout();
            this.wizardPageFormat.SuspendLayout();
            this.wizardPageData.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // wizard
            // 
            this.wizard.Controls.Add(this.wizardPageData);
            this.wizard.Pages.AddRange(new Dew.Math.Controls.WizardPage[] {
            this.wizardPageData});
            this.wizard.Size = new System.Drawing.Size(570, 410);
            this.wizard.AfterSwitchPages += new Dew.Math.Controls.Wizard.AfterSwitchPagesEventHandler(this.wizard_AfterSwitchPages);
            this.wizard.Controls.SetChildIndex(this.wizardPageWelcome, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageData, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageReport, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageFormat, 0);
            // 
            // wizardPageReport
            // 
            this.wizardPageReport.Size = new System.Drawing.Size(468, 317);
            this.wizardPageReport.Title = "Classical MDS: Report";
            // 
            // richTextBox
            // 
            this.richTextBox.Size = new System.Drawing.Size(441, 178);
            // 
            // wizardPageFormat
            // 
            this.wizardPageFormat.Controls.Add(this.groupBox4);
            this.wizardPageFormat.Controls.Add(this.groupBox3);
            this.wizardPageFormat.Description = "Define which reports to include in calculation";
            this.wizardPageFormat.Size = new System.Drawing.Size(468, 317);
            this.wizardPageFormat.Title = "Step 2: Define reports";
            this.wizardPageFormat.Controls.SetChildIndex(this.checkBoxCharts, 0);
            this.wizardPageFormat.Controls.SetChildIndex(this.groupBox3, 0);
            this.wizardPageFormat.Controls.SetChildIndex(this.groupBox4, 0);
            // 
            // wizardPageWelcome
            // 
            this.wizardPageWelcome.Description = resources.GetString("wizardPageWelcome.Description");
            this.wizardPageWelcome.Size = new System.Drawing.Size(468, 317);
            this.wizardPageWelcome.Title = "Classical Multidimensional Scaling";
            // 
            // wizardPageData
            // 
            this.wizardPageData.Controls.Add(this.groupBox2);
            this.wizardPageData.Description = "Define data, metric and data type";
            this.wizardPageData.Location = new System.Drawing.Point(0, 0);
            this.wizardPageData.Name = "wizardPageData";
            this.wizardPageData.Size = new System.Drawing.Size(490, 334);
            this.wizardPageData.TabIndex = 13;
            this.wizardPageData.Title = "Step 1: Define system";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelStatus);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.labelColumns);
            this.groupBox2.Controls.Add(this.labelRows);
            this.groupBox2.Location = new System.Drawing.Point(12, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data matrix";
            // 
            // comboBox2
            // 
            this.comboBox2.Items.AddRange(new object[] {
            "Euclidian",
            "City-Block"});
            this.comboBox2.Location = new System.Drawing.Point(65, 120);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "Dissimilarities matrix",
            "Similarities matrix",
            "Raw data"});
            this.comboBox1.Location = new System.Drawing.Point(65, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Metric";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Data type";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(6, 64);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(39, 15);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Status";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Edit";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelColumns
            // 
            this.labelColumns.AutoSize = true;
            this.labelColumns.Location = new System.Drawing.Point(87, 39);
            this.labelColumns.Name = "labelColumns";
            this.labelColumns.Size = new System.Drawing.Size(55, 15);
            this.labelColumns.TabIndex = 1;
            this.labelColumns.Text = "Columns";
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Location = new System.Drawing.Point(87, 21);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(35, 15);
            this.labelRows.TabIndex = 0;
            this.labelRows.Text = "Rows";
            // 
            // tMtxMDScaling1
            // 
            this.tMtxMDScaling1.BlockAssign = false;
            this.tMtxMDScaling1.DataFormat = Dew.Stats.TMDDataFormat.mdFormatDissimilarities;
            this.tMtxMDScaling1.DHat = ((Dew.Math.TMtx)(resources.GetObject("tMtxMDScaling1.DHat")));
            this.tMtxMDScaling1.Dirty = false;
            this.tMtxMDScaling1.Name = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Location = new System.Drawing.Point(249, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Text reports";
            // 
            // checkBox3
            // 
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Location = new System.Drawing.Point(6, 76);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(108, 18);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Dissimiliarities";
            // 
            // checkBox2
            // 
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(6, 53);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(108, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Fit and solution";
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(6, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Eigenvalues";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDown3);
            this.groupBox4.Controls.Add(this.numericUpDown2);
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(249, 219);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(218, 113);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Report range";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(149, 81);
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(46, 23);
            this.numericUpDown3.TabIndex = 5;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(149, 55);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(46, 23);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(149, 30);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 23);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Reduced space dimension";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Maximum dimension";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Minimum dimension";
            // 
            // MDSWizard
            // 
            this.ClientSize = new System.Drawing.Size(570, 410);
            this.Name = "MDSWizard";
            this.Load += new System.EventHandler(this.MDSWizard_Load);
            this.wizard.ResumeLayout(false);
            this.wizardPageReport.ResumeLayout(false);
            this.wizardPageReport.PerformLayout();
            this.wizardPageFormat.ResumeLayout(false);
            this.wizardPageFormat.PerformLayout();
            this.wizardPageData.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Dew.Math.Controls.WizardPage wizardPageData;

        private void TextReport()
        {
            wizard.BackEnabled = false;
            wizard.NextEnabled = false;

            this.Cursor = Cursors.WaitCursor;

            richTextBox.SuspendLayout();
            try
            {


                tMtxMDScaling1.Recalc();

                richTextBox.Clear();

                progressBar.Value = 0;
                if (checkBox1.Checked) EigenvaluesReport();

                progressBar.Value = 25;
                if (checkBox2.Checked) FitReport();

                progressBar.Value = 50;
                if (checkBox2.Checked) SolutionReport();

                progressBar.Value = 75;
                if (checkBox3.Checked) DissimilaritiesReport();


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

        #region Reports

        private string StressToText(double stress)
        {
            if (stress == 0.0) return "exact";
            else if (stress <= 0.025) return "excelent";
            else if (stress <= 0.05) return "good";
            else if (stress <= 0.100) return "fair";
            else return "poor";
        }

        private bool CheckDataMatrix(TMtx M, TMDDataFormat mtype)
        {
            bool result = !M.Complex;
            switch (mtype)
            {
                case TMDDataFormat.mdFormatRaw: result = result & (M.Length > 0); break;
                case TMDDataFormat.mdFormatDissimilarities: result = result & (M.Quadratic) & (M.DetectMtxType(false) == TMtxType.mtSymmetric); break;
                case TMDDataFormat.mdFormatSimilarities: result = result & (M.Quadratic) & (M.DetectMtxType(false) == TMtxType.mtSymmetric); break;
            }
            return result;
        }

        private void EigenvaluesReport()
        {
            Vector eabs = new Vector(0);
            Vector eabscumsum = new Vector(0);

            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Eigenvalues\n";
            SetupTabs(richTextBox, 4);
            richTextBox.SelectionColor = Color.Blue;
            richTextBox.SelectedText = "Dimensions\tEigenvalue\tPercent\tScree plot\tCumulative pct.\n";
            tMtxMDScaling1.Dimensions = tMtxMDScaling1.Data.Cols;
            tMtxMDScaling1.Recalc();
            eabs.Abs(tMtxMDScaling1.EigenValues);
            eabs *= 100.0 / eabs.Sum();
            eabscumsum.CumSum(eabs);
            string st = "";
            for (int i = 1; i <= tMtxMDScaling1.EigenValues.Length; i++)
            {
                st += i.ToString() + "\t" + Math387.FormatSample(FmtString, tMtxMDScaling1.EigenValues.Values[i - 1])
                    + "\t" + Math387.FormatSample("0.0", eabs.Values[i - 1]) + "\t" + HTextBar(eabs.Values[i - 1],100,20)+"\t"
                    +Math387.FormatSample("0.0", eabscumsum.Values[i - 1]) + "\n";
            }
            st += "\n";
            richTextBox.SelectedText = st;
        }

        private void FitReport()
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Fit\n";
            Matrix a = new Matrix(0, 0);
            // Calculate necessary statistics
            int Nu = tMtxMDScaling1.D.Rows * (tMtxMDScaling1.D.Rows + 1) / 2 - tMtxMDScaling1.D.Rows;
            double Mu = 0.5 * tMtxMDScaling1.D.Sum() / (double)Nu; // zero diagonal, symmetric matrixd
            double ssd = 0.5 * tMtxMDScaling1.D.SumOfSquares();
            // D-<D>
            a.Normalize(tMtxMDScaling1.D, Mu, 1.0);
            for (int i = 0; i < a.Rows; i++) a.Values[i, i] = 0.0;
            double mssd = 0.5 * a.SumOfSquares();

            SetupTabs(richTextBox, 3);
            string st = "";
            richTextBox.SelectionColor = Color.Blue;
            richTextBox.SelectedText = "Dimensions\tStress\tGOF estimate(*)\n";
            for (int i = (int)numericUpDown1.Value; i <= (int)numericUpDown2.Value; i++)
            {
                tMtxMDScaling1.Dimensions = i;
                tMtxMDScaling1.Recalc();
                st += i.ToString() + "\t" + Math387.FormatSample(FmtString, tMtxMDScaling1.Stress) + "\t"
                    + StressToText(tMtxMDScaling1.Stress) + "\n";
            }
            st += "\nNumber of dissimilarities: " + Nu.ToString() + "\n";
            st += "Mean of dissimilarities: " + Math387.FormatSample(FmtString, Mu) + "\n";
            st += "Sum of Squared Dissimilarities: " + Math387.FormatSample(FmtString, mssd) + "\n";
            st += "(*) Kruskal (1964) advise about stress values based on his experience. Some authors caution "
                + "against using a table like this since acceptable values of stress depends on the quality of "
                + "the distance matrix and the number of objects in that matrix.\n\n";
            richTextBox.SelectedText = st;
        }

        private void SolutionReport()
        {
            tMtxMDScaling1.Dimensions = (int)numericUpDown3.Value;
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Solution (using " + tMtxMDScaling1.Dimensions.ToString() + " dimensions)\n";

            tMtxMDScaling1.Recalc();
            string st = "Variable\t";
            for (int i = 1; i <= tMtxMDScaling1.Dimensions; i++) st += "Dim(" + i.ToString() + ")\t";
            SetupTabs(richTextBox, tMtxMDScaling1.Dimensions + 1);
            richTextBox.SelectionColor = Color.Blue;
            richTextBox.SelectedText = st + "\n";

            // print Y values (reduced space matrix)
            st = "";
            for (int i = 0; i < tMtxMDScaling1.Y.Rows; i++)
            {
                st += i.ToString() + "\t";
                for (int j = 0; j < tMtxMDScaling1.Y.Cols; j++) st += Math387.FormatSample(FmtString, tMtxMDScaling1.Y.Values[i, j]) + "\t";
                st += "\n";
            }
            richTextBox.SelectedText = st;
            richTextBox.SelectedText = "Note: Solution based on " + tMtxMDScaling1.Dimensions.ToString() + " dimensions.\n\n";

            if (checkBoxCharts.Checked)
            {
                // Bi-plot
                if ((int)numericUpDown3.Value >= 2)
                {
                    Dew.Stats.Tee.BiPlot biplot;
                    Chart.Series.Clear();
                    Chart.Legend.Visible = false;
                    Chart.Aspect.View3D = false;
                    Chart.Series.Add(biplot = new Dew.Stats.Tee.BiPlot());
                    Chart.Axes.Left.Increment = 1;
                    Chart.Axes.Bottom.Increment = 1;
                    Chart.Header.Text = "MDS Map";
                    Chart.Axes.Bottom.Title.Text = "Dimension 1";
                    Chart.Axes.Bottom.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value;
                    Chart.Axes.Left.Title.Text = "Dimension 2";
                    Chart.Axes.Left.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value;
                    biplot.Marks.Visible = true;
                    biplot.ColorEach = true;
                    for (int i = 0; i < tMtxMDScaling1.Y.Rows; i++)
                        biplot.Add(tMtxMDScaling1.Y.Values[i, 0], tMtxMDScaling1.Y.Values[i, 01], "Variable " + i.ToString());
                }
                CopyToRichBox(richTextBox);
                richTextBox.SelectedText = "\n";
            }
        }

        private void DissimilaritiesReport()
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Dissimilarities\n";
            SetupTabs(richTextBox, 5);
            richTextBox.SelectionColor = Color.Blue;
            richTextBox.SelectedText = "Pair\tActual diss.\tPred. diss.\tDifference\tDifference pct.\n";
            double diff, pct;
            string st = "";

            for (int i = 0; i < tMtxMDScaling1.D.Rows; i++)
            {
                for (int j = i + 1; j < tMtxMDScaling1.D.Cols; j++)
                {
                    diff = tMtxMDScaling1.D.Values[i, j] - tMtxMDScaling1.DHat.Values[i, j];
                    pct = 100.0 * diff / tMtxMDScaling1.D.Values[i, j];
                    st += "(" + i.ToString() + "," + j.ToString() + ")\t";
                    st += Math387.FormatSample(FmtString, tMtxMDScaling1.D.Values[i, j]) + "\t";
                    st += Math387.FormatSample(FmtString, tMtxMDScaling1.DHat.Values[i, j]) + "\t";
                    st += Math387.FormatSample(FmtString, diff) + "\t" + Math387.FormatSample("0.0", pct) + "\n";
                }
            }
            richTextBox.SelectedText = st + "\nNote: Predicted values calculate for " + tMtxMDScaling1.Dimensions.ToString() + " dimensions.\n\n";
        }

        #endregion

        private void UpdateGUI()
        {
            labelColumns.Text = "Rows: " + tMtxMDScaling1.Data.Cols.ToString();
            labelRows.Text = "Columns: " + tMtxMDScaling1.Data.Rows.ToString();
            if (CheckDataMatrix(tMtxMDScaling1.Data, tMtxMDScaling1.DataFormat))
            {
                labelStatus.Text = "Data matrix OK";
            }
            else labelStatus.Text = "Data matrix NOT OK";
            numericUpDown1.Maximum = tMtxMDScaling1.Data.Cols;
            numericUpDown2.Maximum = tMtxMDScaling1.Data.Cols;
            numericUpDown3.Maximum = tMtxMDScaling1.Data.Cols;
            wizard.NextEnabled = CheckDataMatrix(tMtxMDScaling1.Data, tMtxMDScaling1.DataFormat);
        }

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
                wizard.NextEnabled = CheckDataMatrix(tMtxMDScaling1.Data, tMtxMDScaling1.DataFormat);
            }
            else wizard.CancelEnabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dew.Math.Editors.MtxVecEdit.ViewValues(tMtxMDScaling1.Data, "Viewing data...", true, false, true);
            UpdateGUI();
        }

        private void MDSWizard_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = (int)tMtxMDScaling1.DataFormat;
            comboBox2.SelectedIndex = (int)tMtxMDScaling1.DistanceMethod;
            numericUpDown1.Maximum = tMtxMDScaling1.Data.Cols;
            numericUpDown2.Maximum = tMtxMDScaling1.Data.Cols;
            numericUpDown2.Value = tMtxMDScaling1.Data.Cols;
            numericUpDown3.Maximum = tMtxMDScaling1.Data.Cols;
            numericUpDown3.Value = tMtxMDScaling1.Dimensions;
            UpdateGUI();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tMtxMDScaling1.DataFormat = (TMDDataFormat)comboBox1.SelectedIndex;
            UpdateGUI();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tMtxMDScaling1.DistanceMethod = (TPWDistMethod)comboBox2.SelectedIndex;
            UpdateGUI();
        }

    }
}

