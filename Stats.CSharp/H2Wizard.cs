using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math.Units;
using Dew.Math;
using Dew.Stats.Units;
using Dew.Math.Editors;
using Dew.Math.Controls;


namespace StatsMasterDemo
{
    public class H2Wizard : StatsMasterDemo.BaseStatWizard
    {
        
        private Matrix X1, X2;
        private Vector Means;
        public bool TwoSampleTest = false;
        public bool UseMean = true;
        private double T2Total = 0.0;
        private Dew.Stats.THypothesisResult hres;
        private Dew.Math.Controls.WizardPage wizardPageData;
        private GroupBox groupBox3;
        private Button button1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private GroupBox groupBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox5;
        private Label labelDS2;
        private Button button3;
        private GroupBox groupBox4;
        private Label labelDS1;
        private Button button2;
        private double signif;

        public H2Wizard()
        {
            InitializeComponent();
            X1 = new Matrix(0, 0);
            X2 = new Matrix(0, 0);
            Means = new Vector(0);
            // Manually reposition Data wizard page after the Welcome page
            wizard.Pages.Remove(wizardPageData);
            wizard.Pages.Insert(1, wizardPageData);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(H2Wizard));
            this.wizardPageData = new Dew.Math.Controls.WizardPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelDS2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelDS1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.wizard.SuspendLayout();
            this.wizardPageReport.SuspendLayout();
            this.wizardPageFormat.SuspendLayout();
            this.wizardPageData.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizard
            // 
            this.wizard.Controls.Add(this.wizardPageData);
            this.wizard.Pages.AddRange(new Dew.Math.Controls.WizardPage[] {
            this.wizardPageData});
            this.wizard.Size = new System.Drawing.Size(546, 348);
            this.wizard.AfterSwitchPages += new Dew.Math.Controls.Wizard.AfterSwitchPagesEventHandler(this.wizard_AfterSwitchPages);
            this.wizard.Controls.SetChildIndex(this.wizardPageData, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageReport, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageFormat, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageWelcome, 0);
            // 
            // wizardPageReport
            // 
            this.wizardPageReport.Size = new System.Drawing.Size(468, 247);
            this.wizardPageReport.Title = "Hotelling T2 test: Report";
            // 
            // richTextBox
            // 
            this.richTextBox.Size = new System.Drawing.Size(441, 108);
            // 
            // wizardPageFormat
            // 
            this.wizardPageFormat.Size = new System.Drawing.Size(468, 247);
            this.wizardPageFormat.Title = "Step 2: Define report options";
            // 
            // wizardPageWelcome
            // 
            this.wizardPageWelcome.Description = resources.GetString("wizardPageWelcome.Description");
            this.wizardPageWelcome.Size = new System.Drawing.Size(468, 247);
            this.wizardPageWelcome.Title = "Hotelling T2 Test";
            // 
            // wizardPageData
            // 
            this.wizardPageData.Controls.Add(this.groupBox5);
            this.wizardPageData.Controls.Add(this.groupBox4);
            this.wizardPageData.Controls.Add(this.groupBox3);
            this.wizardPageData.Controls.Add(this.groupBox2);
            this.wizardPageData.Description = "Define one or two sample Hotelling T2 test";
            this.wizardPageData.Location = new System.Drawing.Point(0, 0);
            this.wizardPageData.Name = "wizardPageData";
            this.wizardPageData.Size = new System.Drawing.Size(546, 300);
            this.wizardPageData.TabIndex = 13;
            this.wizardPageData.Title = "Step 1: Define test";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelDS2);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Location = new System.Drawing.Point(235, 156);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 65);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Second dataset";
            this.groupBox5.Visible = false;
            // 
            // labelDS2
            // 
            this.labelDS2.Location = new System.Drawing.Point(97, 26);
            this.labelDS2.Name = "labelDS2";
            this.labelDS2.Size = new System.Drawing.Size(97, 34);
            this.labelDS2.TabIndex = 2;
            this.labelDS2.Text = "label1";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(6, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Edit";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelDS1);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Location = new System.Drawing.Point(235, 76);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 74);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "First dataset";
            // 
            // labelDS1
            // 
            this.labelDS1.Location = new System.Drawing.Point(97, 26);
            this.labelDS1.Name = "labelDS1";
            this.labelDS1.Size = new System.Drawing.Size(97, 34);
            this.labelDS1.TabIndex = 1;
            this.labelDS1.Text = "label1";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(6, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Edit";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Location = new System.Drawing.Point(12, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 87);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Means";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(81, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Define";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.Checked = true;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton4.Location = new System.Drawing.Point(6, 53);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(69, 23);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Defined";
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Location = new System.Drawing.Point(6, 30);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(69, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.Text = "Equal";
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(12, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 72);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Define test type";
            // 
            // radioButton2
            // 
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Location = new System.Drawing.Point(6, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(189, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Two sample";
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Location = new System.Drawing.Point(6, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(189, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "One sample (paired or unpaired)";
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // H2Wizard
            // 
            this.ClientSize = new System.Drawing.Size(546, 348);
            this.Name = "H2Wizard";
            this.Load += new System.EventHandler(this.H2Wizard_Load);
            this.wizard.ResumeLayout(false);
            this.wizardPageReport.ResumeLayout(false);
            this.wizardPageReport.PerformLayout();
            this.wizardPageFormat.ResumeLayout(false);
            this.wizardPageFormat.PerformLayout();
            this.wizardPageData.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public TMtx Data1
        {
            get { return (TMtx)X1; }
        }

        public TMtx Data2
        {
            get { return (TMtx)X2; }
        }

        public TVec TestMeans
        {
            get { return (TVec)Means; }
        }

        private void UpdateGUI()
        {
            groupBox5.Visible = TwoSampleTest;
            if (X1.Length > 0) labelDS1.Text = "Samples: " + X1.Rows.ToString() + "\nVariables: " + X1.Cols.ToString();
            else labelDS1.Text = "Empty dataset";

            if (X2.Length > 0) labelDS2.Text = "Samples: " + X2.Rows.ToString() + "\nVariables: " + X2.Cols.ToString();
            else labelDS2.Text = "Empty dataset";

            if (wizard.SelectedPage == wizardPageData) wizard.NextEnabled = ((X1.Length > 0) & (!TwoSampleTest)) | ((X1.Cols > 0) & (X1.Cols == X2.Cols));
        }

        #region Reports
        // remove variable from matrix
        private void RemoveVariable(TMtx amtx, TMtx bmtx, TVec ameans, TVec bmeans, int index)
        {
            Vector v1 = new Vector(0);
            bmtx.Size(amtx.Rows, amtx.Cols - 1);
            if (ameans != null) bmeans.Size(ameans.Length - 1);
            int c = 0;
            for (int j = 0; j < amtx.Cols; j++)
            {
                if (j != index)
                {
                    v1.GetCol(amtx, j);
                    bmtx.SetCol(v1, c);
                    if (ameans != null) bmeans.Values[c] = ameans.Values[j];
                    c++;
                }
            }
        }

        /// <summary>
        /// Descriptive statistics report
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        private void DescriptiveStats(TMtx m1, TMtx m2)
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Descriptive Statistics\n";
            int p = X1.Cols; // number of variables
            if (m2 != null) SetupTabs(richTextBox, 5); else SetupTabs(richTextBox, 3);
            Vector v1 = new Vector(0);
            richTextBox.SelectionColor = Color.Blue;
            if (m2 != null) richTextBox.SelectedText = "Var.\tMean(1)\tStd(1)\tMean(2)\tStd(2)\n";
            else richTextBox.SelectedText = "Var.\tMean\tStd\n";
            string st = "";
            double m, std;
            for (int i = 0; i < p; i++)
            {
                st += i.ToString() + "\t";
                v1.GetCol(X1, i);
                m = v1.Mean();
                std = v1.StdDev(m);
                st += Math387.FormatSample(FmtString, m) + "\t" + Math387.FormatSample(FmtString, std);
                if (m2 != null)
                {
                    v1.GetCol(X2, i);
                    m = v1.Mean();
                    std = v1.StdDev(m);
                    st += "\t" + Math387.FormatSample(FmtString, m) + "\t" + Math387.FormatSample(FmtString, std);
                }
                st += "\n";
            }
            richTextBox.SelectedText = st + "\n";
        }

        private void BoxTest(TMtx m1, TMtx m2)
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "M-Box test for equal covariance matrices\n";
            SetupTabs(richTextBox, 5);

            int df1, df2;
            double mb = Statistics.MBoxTest(m1, m2, out signif, out hres, out df1, out df2, Alpha);
            richTextBox.SelectionColor = Color.Blue;
            richTextBox.SelectedText = "Statistics\tdf1\tdf2\tSignif.\tHyp.result\n";
            string st = Math387.FormatSample(FmtString, mb) + "\t" + df1.ToString() + "\t"
                + df2.ToString() + "\t" + Math387.FormatSample(FmtString, signif) + "\t";
            if (hres == Dew.Stats.THypothesisResult.hrNotReject) st += "Accept\n"; else st += "Reject\n";
            richTextBox.SelectedText = st + "\n";
        }

        private void IndividualVars(TMtx m1, TMtx m2, TVec vmean)
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Individual variables\n";
            SetupTabs(richTextBox, 7);
            string st = "Ommited\tT2\tProb.\tT2\tProb.\tT2\tProb\nvariable\tothers\tlevel\tchange\tlevel\talone\tlevel\n";

            richTextBox.SelectionColor = Color.Blue;
            richTextBox.SelectedText = st;

            double T2, v;
			double T2Change,T2ChangeProb;

			Vector v1 = new Vector(0);
            Matrix m3 = new Matrix(0, 0);
            Matrix m4 = new Matrix(0, 0);
            st = "";
            for (int i = 0; i < m1.Cols; i++)
            {
                if (m2 != null) // two sample test
                {
                    if (UseMean)
                    {
                        RemoveVariable(m1, m3, Means, v1, i);
                        RemoveVariable(m2, m4, Means, v1, i);
                        T2 = Statistics.HotellingT2Two(m3, m4, out signif, out hres, out v, v1, true, Alpha);
                    }
                    else
                    {
                        RemoveVariable(m1, m3, null, null, i);
                        RemoveVariable(m2, m4, null, null, i);
                        T2 = Statistics.HotellingT2Two(m3, m4, out signif, out hres, out v, v1, true, Alpha);
                    }
					T2Change = T2Total-T2;
					T2ChangeProb = Probabilities.FCDF(T2Change,1,m1.Rows+m2.Rows-2-(m1.Cols-1));
				}
                else // one sample test
                {
                    if (UseMean)
                    {
                        RemoveVariable(m1, m3, Means, v1, i);
                        T2 = Statistics.HotellingT2One(m3, v1, out signif, out hres, Alpha);
                    }
                    else
                    {
                        RemoveVariable(m1, m3, null, null, i);
                        T2 = Statistics.HotellingT2One(m3, null, out signif, out hres, Alpha);
                    }
					T2Change = T2Total-T2;
					T2ChangeProb = Probabilities.FCDF(T2Change,1,m1.Rows-m1.Cols);
				}


				st += i.ToString() + "\t" + Math387.FormatSample(FmtString, T2) + "\t" + Math387.FormatSample(FmtString, signif) + "\t";
                st += Math387.FormatSample(FmtString, T2Change) + "\t" + Math387.FormatSample(FmtString, T2ChangeProb) + "\t";
                st += "\n";

                // Calculate T-test statistics for ommited variable
            }
            richTextBox.SelectedText = st + "\n";
        }

        private void H2Test(TMtx m1, TMtx m2, TVec vmean)
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Hotelling _T2 test\n";
            SetupTabs(richTextBox, 7);
            richTextBox.SelectionColor = Color.Blue;
            richTextBox.SelectedText = "Hypothesis\t\tT2 value\tdf1\tdf2\tProb.\tHyp.result\n";

            Vector v1 = new Vector(0);
            string st = "";
            double T2, v;
            int df1, df2;
            if (m2 != null) // Two samples
            {
                st = "Equal covariance matrices\t";
                if (UseMean) T2 = Statistics.HotellingT2Two(X1, X2, out signif, out hres, out v, Means, true, Alpha);
                else T2 = Statistics.HotellingT2Two(X1, X2, out signif, out hres, out v, null, true, Alpha);
                T2Total = T2;
                df1 = X1.Cols;
                df2 = Convert.ToInt16(v);
                st += Math387.FormatSample(FmtString, T2) + "\t" + df1.ToString() + "\t" + df2.ToString() + "\t";
                st += Math387.FormatSample(FmtString, signif) + "\t";
                st += HypResult(hres) + "\n";
            }
            else // One sample
            {
                st = "Means all equal\t";
                T2 = Statistics.HotellingT2One(X1, null, out signif, out hres, Alpha);
                df1 = X1.Cols-1;
                df2 = X1.Rows - 1;
                st += Math387.FormatSample(FmtString, T2) + "\t" + df1.ToString() + "\t" + df2.ToString() + "\t" + Math387.FormatSample(FmtString, signif) + "\t";
                st += HypResult(hres) + "\n";

                if (UseMean)
                {
                    st += "Means equal to Means\t";
                    T2 = Statistics.HotellingT2One(X1, Means, out signif, out hres, Alpha);
                    df1 = X1.Cols;
                    df2 = X1.Rows - 1;
                    st += Math387.FormatSample(FmtString, T2) + "\t" + df1.ToString() + "\t" + df2.ToString() + "\t" + Math387.FormatSample(FmtString, signif) + "\t" + HypResult(hres)+"\n";
                }
                else
                {
                    st += "Means equal to zero\t";
                    v1.Size(X1.Cols);
                    v1.SetZero();
                    T2 = Statistics.HotellingT2One(X1, v1, out signif, out hres, Alpha);
                    df1 = X1.Cols;
                    df2 = X1.Rows - 1;
                    st += Math387.FormatSample(FmtString, T2) + "\t" + df1.ToString() + "\t" + df2.ToString() + "\t" + Math387.FormatSample(FmtString, signif) + "\t";
                    st += HypResult(hres) + "\n";
                }
                T2Total = T2;
            }

            richTextBox.SelectedText = st + "\n";
        }

        private void TextReport()
        {
            wizard.BackEnabled = false;
            wizard.NextEnabled = false;
            
            richTextBox.Clear();
            progressBar.Value = 0;
            if (TwoSampleTest) // Two sample
            {
                DescriptiveStats(X1, X2);
                if (UseMean)
                {
                    H2Test(X1, X2, Means);
                    IndividualVars(X1, X2, Means);
                }
                else
                {
                    H2Test(X1, X2, null);
                    IndividualVars(X1, X2, null);
                }
                BoxTest(X1, X2);
            }
            else
            {
                DescriptiveStats(X1, null);
                if (UseMean)
                {
                    H2Test(X1, null, Means);
                    IndividualVars(X1, null, Means);
                }
                else
                {
                    H2Test(X1, null, null);
                    IndividualVars(X1, null, null);
                }
            }
            progressBar.Value = 100;
            wizard.BackEnabled = true;
        }

#endregion

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
                wizard.NextEnabled = ((X1.Length > 0) & (!TwoSampleTest)) | ((X1.Cols > 0) & (X1.Cols == X2.Cols));
            }
            else wizard.CancelEnabled = true;

        }

        private void H2Wizard_Load(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MtxVecEdit.ViewValues(Means, "Editing means...", true, false, true);
            UpdateGUI();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TwoSampleTest = radioButton2.Checked;
            UpdateGUI();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            UseMean = radioButton4.Checked;
            button1.Visible = UseMean;
            UpdateGUI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MtxVecEdit.ViewValues(X1, "First dataset", true, false, true);
            UpdateGUI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MtxVecEdit.ViewValues(X2, "Second dataset", true, false, true);
            UpdateGUI();
        }
    }
}

