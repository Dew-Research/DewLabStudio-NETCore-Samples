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

namespace StatsMasterDemo
{
    public class PCAWizard : StatsMasterDemo.BaseStatWizard
    {
        public PCAWizard()
        {
            InitializeComponent();
            // Manually reposition Data wizard page after the Welcome page
            wizard.Pages.Remove(wizardPageData);
            wizard.Pages.Insert(1, wizardPageData);
        }

        private CheckBox checkBoxZ;
        private CheckBox checkBoxPCA;
        private CheckBox checkBoxEigen;
        private CheckBox checkBoxCorrelation;
        private CheckBox checkBoxBarlett;
        private CheckBox checkBoxDescStat;
        private OpenFileDialog openFileDialog1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCAWizard));
            this.wizardPageData = new Dew.Math.Controls.WizardPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tMtxPCA1 = new Dew.Stats.TMtxPCA(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxZ = new System.Windows.Forms.CheckBox();
            this.checkBoxPCA = new System.Windows.Forms.CheckBox();
            this.checkBoxEigen = new System.Windows.Forms.CheckBox();
            this.checkBoxCorrelation = new System.Windows.Forms.CheckBox();
            this.checkBoxBarlett = new System.Windows.Forms.CheckBox();
            this.checkBoxDescStat = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.wizard.Size = new System.Drawing.Size(707, 459);
            this.wizard.AfterSwitchPages += new Dew.Math.Controls.Wizard.AfterSwitchPagesEventHandler(this.wizard_AfterSwitchPages);
            this.wizard.Controls.SetChildIndex(this.wizardPageWelcome, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageFormat, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageReport, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageData, 0);
            // 
            // wizardPageReport
            // 
            this.wizardPageReport.Size = new System.Drawing.Size(562, 306);
            this.wizardPageReport.Title = "PCA: Report";
            // 
            // richTextBox
            // 
            this.richTextBox.Size = new System.Drawing.Size(529, 135);
            // 
            // progressBar
            // 
            this.progressBar.Size = new System.Drawing.Size(464, 16);
            // 
            // wizardPageFormat
            // 
            this.wizardPageFormat.Controls.Add(this.groupBox3);
            this.wizardPageFormat.Description = "Define which reports to included in PCA";
            this.wizardPageFormat.Size = new System.Drawing.Size(562, 306);
            this.wizardPageFormat.Title = "Step 2: Define reports";
            this.wizardPageFormat.Controls.SetChildIndex(this.checkBoxCharts, 0);
            this.wizardPageFormat.Controls.SetChildIndex(this.groupBox3, 0);
            // 
            // wizardPageWelcome
            // 
            this.wizardPageWelcome.Description = resources.GetString("wizardPageWelcome.Description");
            this.wizardPageWelcome.Size = new System.Drawing.Size(562, 306);
            this.wizardPageWelcome.Title = "Principal Component Analysis";
            // 
            // wizardPageData
            // 
            this.wizardPageData.Controls.Add(this.groupBox2);
            this.wizardPageData.Description = "Define options for PCA analysis";
            this.wizardPageData.Location = new System.Drawing.Point(0, 0);
            this.wizardPageData.Name = "wizardPageData";
            this.wizardPageData.Size = new System.Drawing.Size(707, 411);
            this.wizardPageData.TabIndex = 13;
            this.wizardPageData.Title = "Step 1: Define data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(15, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "Correlation",
            "Variance-covariance",
            "Raw data"});
            this.comboBox1.Location = new System.Drawing.Point(125, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 23);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Matrix type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Number of observables (rows)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Number of variables (columns)";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(97, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Edit";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(7, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tMtxPCA1
            // 
            this.tMtxPCA1.BlockAssign = false;
            this.tMtxPCA1.Dirty = false;
            this.tMtxPCA1.Name = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxZ);
            this.groupBox3.Controls.Add(this.checkBoxPCA);
            this.groupBox3.Controls.Add(this.checkBoxEigen);
            this.groupBox3.Controls.Add(this.checkBoxCorrelation);
            this.groupBox3.Controls.Add(this.checkBoxBarlett);
            this.groupBox3.Controls.Add(this.checkBoxDescStat);
            this.groupBox3.Location = new System.Drawing.Point(257, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 192);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Report on";
            // 
            // checkBoxZ
            // 
            this.checkBoxZ.Checked = true;
            this.checkBoxZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxZ.Location = new System.Drawing.Point(26, 164);
            this.checkBoxZ.Name = "checkBoxZ";
            this.checkBoxZ.Size = new System.Drawing.Size(214, 21);
            this.checkBoxZ.TabIndex = 11;
            this.checkBoxZ.Text = "Z scores";
            // 
            // checkBoxPCA
            // 
            this.checkBoxPCA.Checked = true;
            this.checkBoxPCA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPCA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxPCA.Location = new System.Drawing.Point(26, 135);
            this.checkBoxPCA.Name = "checkBoxPCA";
            this.checkBoxPCA.Size = new System.Drawing.Size(207, 21);
            this.checkBoxPCA.TabIndex = 10;
            this.checkBoxPCA.Text = "Principal components";
            // 
            // checkBoxEigen
            // 
            this.checkBoxEigen.Checked = true;
            this.checkBoxEigen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxEigen.Location = new System.Drawing.Point(26, 107);
            this.checkBoxEigen.Name = "checkBoxEigen";
            this.checkBoxEigen.Size = new System.Drawing.Size(207, 21);
            this.checkBoxEigen.TabIndex = 9;
            this.checkBoxEigen.Text = "Eigenvalues";
            // 
            // checkBoxCorrelation
            // 
            this.checkBoxCorrelation.Checked = true;
            this.checkBoxCorrelation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCorrelation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCorrelation.Location = new System.Drawing.Point(26, 79);
            this.checkBoxCorrelation.Name = "checkBoxCorrelation";
            this.checkBoxCorrelation.Size = new System.Drawing.Size(207, 21);
            this.checkBoxCorrelation.TabIndex = 8;
            this.checkBoxCorrelation.Text = "Correlation matrix";
            // 
            // checkBoxBarlett
            // 
            this.checkBoxBarlett.Checked = true;
            this.checkBoxBarlett.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBarlett.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxBarlett.Location = new System.Drawing.Point(26, 50);
            this.checkBoxBarlett.Name = "checkBoxBarlett";
            this.checkBoxBarlett.Size = new System.Drawing.Size(207, 21);
            this.checkBoxBarlett.TabIndex = 7;
            this.checkBoxBarlett.Text = "Barlett test for dimensionality";
            // 
            // checkBoxDescStat
            // 
            this.checkBoxDescStat.Checked = true;
            this.checkBoxDescStat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDescStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxDescStat.Location = new System.Drawing.Point(26, 22);
            this.checkBoxDescStat.Name = "checkBoxDescStat";
            this.checkBoxDescStat.Size = new System.Drawing.Size(207, 21);
            this.checkBoxDescStat.TabIndex = 6;
            this.checkBoxDescStat.Text = "Descriptive statistics";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PCAWizard
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(707, 459);
            this.Name = "PCAWizard";
            this.Load += new System.EventHandler(this.PCAWizard_Load);
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

        private Dew.Math.Controls.WizardPage wizardPageData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Dew.Stats.TMtxPCA tMtxPCA1;
        private System.Windows.Forms.GroupBox groupBox3;


        private void TextReport()
        {

            wizard.BackEnabled = false;
            wizard.NextEnabled = false;

            progressBar.Value = 0;
            richTextBox.SuspendLayout();
            try
            {

                tMtxPCA1.Recalc();
                richTextBox.Clear();

                if (checkBoxDescStat.Checked) DescStatReport();

                progressBar.Value = 15;
                if (checkBoxBarlett.Checked) BarlettTestReport();

                progressBar.Value = 30;
                if (checkBoxCorrelation.Checked) CorrelationReport();


                progressBar.Value = 60;
                if (checkBoxEigen.Checked) EigenvaluesReport();


                progressBar.Value = 75;
                if (checkBoxPCA.Checked) PrinCompReport();

                progressBar.Value = 90;
                if (checkBoxZ.Checked) ZReport();

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
            for (int i = 0; i < Data.Cols; i++)
            {
                tvec.GetCol(Data, 0, i, Data.Rows);
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
                    BoxPlot bplot;
                    Chart.Series.Add(bplot = new BoxPlot());
                    bplot.Position = i;
                    bplot.Title = "Column " + i.ToString();
                    bplot.PlotStyle = BoxPlotStyle.bpDiamond;
                    tvec.SortAscend();
                    Dew.Math.Tee.MtxVecTee.DrawValues(tvec, bplot, 0, 1, false);
                }
            }

            richTextBox.SelectedText = st + "\n";

            if (checkBoxCharts.Checked)
            {
                CopyToRichBox(richTextBox);
                richTextBox.SelectedText = "\n";
            }
        }

        private void CorrelationReport()
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            switch (tMtxPCA1.PCAMode)
            {
                case Dew.Stats.TPCAMode.PCACovMat:
                    {
                        richTextBox.SelectedText = "Covariance matrix\n";
                        Statistics.Covariance(Data, tmtx, false);
                    }; break;
                case Dew.Stats.TPCAMode.PCACorrMat:
                    {
                        richTextBox.SelectedText = "Correlation matrix\n";
                        Statistics.CorrCoef(Data, tmtx);
                    }; break;
            }
            SetupTabs(richTextBox, Data.Cols);
            string txt = tmtx.ValuesToText("\t", FmtString, FmtString);
            richTextBox.SelectedText = txt + "\n";

            // Ln(R)
            richTextBox.SelectedText = "ln(R):\t" + Math387.FormatSample(FmtString, Math.Log(tmtx.Determinant(TMtxType.mtGeneral))) + "\n\n";
        }

        private void PrinCompReport()
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Principal components (Eigenvectors)\n\n";
            SetupTabs(richTextBox, Data.Cols);
            string txt;
            tMtxPCA1.PC.ValuesToText(out txt, "\t", FmtString, FmtString);            
            richTextBox.SelectedText = txt + "\n\n"; //convert to richedit format
            if (checkBoxCharts.Checked)
            {
                // Bi-plot
                Chart.Series.Clear();
                Chart.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
                Chart.Axes.Left.Automatic = true;
                Chart.Header.Text = "Biplot";
                Chart.Legend.Visible = true;
                Chart.Axes.Left.Title.Text = "Dimension 2";
                Chart.Axes.Bottom.Title.Text = "Dimension 1";
                // point series for scores
                Chart.Series.Add(new Steema.TeeChart.Styles.Points());
                // bi-plot series for coefficients
                Chart.Series.Add(new Dew.Stats.Tee.BiPlot());
                Chart.Series[0].Title = "Scores";
                Chart.Series[1].Marks.Visible = true;
                Chart.Series[1].Title = "Coefficients";
                Chart.Axes.Bottom.Labels.Style = Steema.TeeChart.AxisLabelStyle.Value;
                for (int i = 0; i < tMtxPCA1.ZScores.Rows; i++)
                    Chart.Series[0].Add(tMtxPCA1.ZScores.Values[i, 0], tMtxPCA1.ZScores.Values[i, 1]);

                for (int i = 0; i < tMtxPCA1.PC.Cols; i++)
                    Chart.Series[1].Add(tMtxPCA1.PC.Values[0, i], tMtxPCA1.PC.Values[1, i], "Column " + i.ToString());

                CopyToRichBox(richTextBox);
                richTextBox.SelectedText = "\n";
            }

        }

        private void BarlettTestReport()
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Barlett test for dimensionality of data\n\n";
            // Barlett test for dimensionality
            Vector vsignif = new Vector(0);
            int numdim = 0;
            string st = "";
            Statistics.BartlettTest(Data, out numdim, vsignif, 0.05);
            richTextBox.SelectedText = "Barlett test (Alpha = 0.05 ) = " + numdim.ToString() + "\n";
            richTextBox.SelectionColor = Color.Blue;
            richTextBox.SelectedText = "Variable\tSignif. probability\n";
            for (int i = 0; i < vsignif.Length; i++)
            {
                st += i.ToString() + "\t" + Math387.FormatSample(FmtString, vsignif.Values[i]) + "\n";
            }
            richTextBox.SelectedText = st + "\n";
        }

        private void EigenvaluesReport()
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Eigenvalues\n\n";
            richTextBox.SelectionColor = Color.Blue;
            richTextBox.SelectedText = "Variable\tEigenvalue\tPercentage\tScree plot\n";
            string st = "";
            for (int i = 0; i < tMtxPCA1.EigValues.Length; i++)
            {
                st += i.ToString() + "\t" + Math387.FormatSample(FmtString, tMtxPCA1.EigValues.Values[i]) + "\t";
                st += Math387.FormatSample(FmtString, tMtxPCA1.TotalVarPct.Values[i]) + "\t" + HTextBar(tMtxPCA1.TotalVarPct.Values[i], 100, 10) + "\n";
            }
            richTextBox.SelectedText = st + "\n";

            if (checkBoxCharts.Checked)
            {
                // Scree plot
                Chart.Series.Clear();
                Chart.Legend.Visible = true;
                Chart.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
                Chart.Header.Text = "Scree plot";
                Chart.Axes.Left.Title.Text = "Percentage";
                Chart.Axes.Left.SetMinMax(0, 101);
                Chart.Axes.Bottom.Title.Text = "Eigenvalue";
                // add Line + bar series
                Chart.Series.Add(new Steema.TeeChart.Styles.Bar());
                Chart.Series.Add(new Steema.TeeChart.Styles.Line());
                Chart.Series[0].Title = "Eigenvalue";
                Chart.Series[1].Title = "Cumulative value";
                tvec.CumSum(tMtxPCA1.TotalVarPct);
                Dew.Math.Tee.MtxVecTee.DrawValues(tMtxPCA1.TotalVarPct, Chart.Series[0], 0, 1, false);
                Dew.Math.Tee.MtxVecTee.DrawValues(tvec, Chart.Series[1], 0, 1, false);
                CopyToRichBox(richTextBox);
                richTextBox.SelectedText = "\n";
            }
        }

        private void ZReport()
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Z Scores\n\n";
            SetupTabs(richTextBox, tMtxPCA1.ZScores.Cols);
            string txt;
            tMtxPCA1.ZScores.ValuesToText(out txt, "\t", FmtString, FmtString);

            richTextBox.SelectedText = txt + "\n\n";

            if (checkBoxCharts.Checked)
            {
                // Z-scores 2d plot
                Chart.Series.Clear();
                Chart.Header.Text = "Z Scores";
                Chart.Legend.Alignment = Steema.TeeChart.LegendAlignments.Right;
                Chart.Legend.Visible = true;
                Chart.Axes.DrawBehind = false;
                Chart.Legend.VertSpacing = 0;
                Chart.Axes.Left.Increment = 1.0;
                Chart.Axes.Left.Title.Text = "Column";
                Chart.Axes.Left.Automatic = true;
                Chart.Axes.Bottom.Increment = 1.0;
                Chart.Axes.Bottom.Title.Text = "Row";
                Matrix m1 = new Matrix(0, 0);
                Dew.Math.Tee.MtxGridSeries gridseries1;
                Chart.Series.Add(gridseries1 = new Dew.Math.Tee.MtxGridSeries());
                gridseries1.XOffset = 0.5;
                gridseries1.YOffset = 0.5;
                m1.Transp(tMtxPCA1.ZScores);
                gridseries1.LegendItemsCount = 10;
                Dew.Math.Tee.MtxVecTee.DrawValues(m1, gridseries1);
                CopyToRichBox(richTextBox);
                richTextBox.SelectedText = "\n";
            }
        }

        #endregion


        /// <summary>
        /// Access to data matrix.
        /// </summary>
        public TMtx Data
        {
            get { return tMtxPCA1.Data; }
        }

        private Vector tvec = new Vector(0);
        private Matrix tmtx = new Matrix(0, 0);

        private void UpdatePCASystem()
        {
            label6.Text = "Number of variables (columns): " + tMtxPCA1.Data.Cols.ToString();
            label5.Text = "Number of observables (rows): " + tMtxPCA1.Data.Rows.ToString();
            wizard.NextEnabled = Data.Length > 0 || wizard.SelectedPage == wizardPageWelcome;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tMtxPCA1.PCAMode = (Dew.Stats.TPCAMode)comboBox1.SelectedIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dew.Math.Editors.MtxVecEdit.ViewValues(tMtxPCA1.Data, "Values", true, false, true);
            UpdatePCASystem();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tMtxPCA1.Data.LoadFromFile(openFileDialog1.FileName);
                UpdatePCASystem();
            }

        }

        private void PCAWizard_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "matrix files(*.mtx)|*.mtx";
            openFileDialog1.FilterIndex = 1;            
            comboBox1.SelectedIndex = 2; // data matrix
            UpdatePCASystem();
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
                wizard.NextEnabled = (Data.Length>0);
            }
            else wizard.CancelEnabled = true;

        }
    }
}

