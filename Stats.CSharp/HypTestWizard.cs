using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Editors;
using Dew.Math.Units;
using Dew.Math.Tee;
using Dew.Stats.Units;
using Dew.Stats;
using Dew.Math.Controls;

namespace StatsMasterDemo
{
    public class HypTestWizard : StatsMasterDemo.BaseStatWizard
    {


        /// <summary>
        /// Distribution helper class
        /// </summary>
        sealed private class HypTest
        {

            private string mydesc, myhelp;
            private THypothesisMethod mymethod;
            private bool myalltypes;

            public HypTest(string desc, THypothesisMethod method, string help, bool alltypes)
            {
                mydesc = desc;
                mymethod = method;
                myhelp = help;
                myalltypes = alltypes;
            }


            public string Description
            {
                get { return mydesc; }
            }

            public string Help
            {
                get { return myhelp; }
            }

            public THypothesisMethod Method
            {
                get { return mymethod; }

            }
            public bool AllTypes
            {
                get { return myalltypes; }
            }
        }

        private int numdatasets = 0;
        private ArrayList oneDSList, twoDSList;
        private TMtxHypothesisTest hypControl;

        private ListBox listBoxTests;
        private Label label5;
        private ToolTip toolTipHelp;
        private GroupBox groupBoxHypType;
        private RadioButton radioButtonRightTailed;
        private RadioButton radioButtonLeftTailed;
        private RadioButton radioButtonTwoTailed;
       

        private TextBox textBoxPar2;
        private Label labelPar2;
        private TextBox textBoxPar1;
        private Label labelPar1;
        private GroupBox groupBoxTestValues;

        public HypTestWizard()
        {
            InitializeComponent();
            // Manually reposition Data wizard page after the Welcome page
            wizard.Pages.Remove(wizardPageData);
            wizard.Pages.Insert(1, wizardPageData);
            hypControl = new TMtxHypothesisTest();
            dataInfo1.Data = hypControl.DataVec1;
            dataInfo2.Data = hypControl.DataVec2;
            hypControl.AutoUpdate = false;

            // load hypothesis types
            oneDSList = new ArrayList();
			oneDSList.Add(new HypTest("Anderson-Darling test", THypothesisMethod.hmAndersonDarling, "Test for normality of data.", false));
			oneDSList.Add(new HypTest("Chi-Square test", THypothesisMethod.hmChiSquareTest, "Compares sample deviation to\ntest sigma value.", true));
            oneDSList.Add(new HypTest("Shapiro-Francia test", THypothesisMethod.hmShapiroFrancia, "Test for normality of data.", false));
            oneDSList.Add(new HypTest("Shapiro-Wilks test", THypothesisMethod.hmShapiroWilks, "Test for normality of data.", false));
            oneDSList.Add(new HypTest("Sign test", THypothesisMethod.hmSignTest, "Compares data median to\ntest median value.", true));
            oneDSList.Add(new HypTest("T test", THypothesisMethod.hmTTest1, "Compares data mean to\ntest mean value.", true));
            oneDSList.Add(new HypTest("Z test", THypothesisMethod.hmZTest, "Compares normally distributed data with\nmean and sigma to test mean value.", true));
            oneDSList.Add(new HypTest("Willcoxon signed rank test", THypothesisMethod.hmWilcoxonSign, "Compares data median to\ntest median value.", true));

            twoDSList = new ArrayList();
            twoDSList.Add(new HypTest("F test", THypothesisMethod.hmFTest, "Compares two datasets\n standard deviations.", true));
            twoDSList.Add(new HypTest("Mann-Whitney U test", THypothesisMethod.hmMannWhitney, "Compares two individual random samples.", false));
            twoDSList.Add(new HypTest("Sign test (paired)", THypothesisMethod.hmSignTestPaired, "Compares two datasets median values.", true));
            twoDSList.Add(new HypTest("T test (paired)", THypothesisMethod.hmTTest2Paired, "Compares two paired datasets mean values with assumption\n that both datasets"
                                + "have the same but unknown variance.", true));
            twoDSList.Add(new HypTest("T test (pooled)", THypothesisMethod.hmTTest2Pooled, "Compares two pooled datasets mean values with assumption\n that both datasets"
                                + "have the same but unknown variance.", true));
            twoDSList.Add(new HypTest("Willcoxon signed rank test (paired)", THypothesisMethod.hmWilcoxonSignPaired, "Compares two datasets\nmedian values.", true));
        }

        private Dew.Math.Controls.WizardPage wizardPageData;
        private DataInfo dataInfo2;
        private DataInfo dataInfo1;
        private ComboBox comboBox1;
        private Label label4;
        private GroupBox groupBoxDataSet1;
        private Button buttonEditDat1;
        private GroupBox groupBoxDataSet2;
        private Button buttonEditDat2;

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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TVec Data1
        {
            get { return hypControl.DataVec1; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TVec Data2
        {
            get { return hypControl.DataVec2; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int NumDataSets
        {
            get { return numdatasets; }
            set
            {
                if (value != numdatasets)
                {
                    numdatasets = value;
					UpdateTestGUI();
                }
            }
        }

		private bool CheckData()
		{
			bool result = true;
			result = result & (numdatasets==1 & hypControl.DataVec1.Length>0);
			result = result | (numdatasets==2 & hypControl.DataVec1.Length == hypControl.DataVec2.Length);
			result = result | (numdatasets==2 & hypControl.HypothesisMethod == THypothesisMethod.hmMannWhitney & hypControl.DataVec1.Length>0 & hypControl.DataVec2.Length>0);
			result = result | (numdatasets==2 & hypControl.HypothesisMethod == THypothesisMethod.hmFTest & hypControl.DataVec1.Length>=2 & hypControl.DataVec2.Length>=2);

			return result;
		}

        private void UpdateTestGUI()
        {
		
			comboBox1.SelectedIndex = numdatasets - 1;
            dataInfo1.Visible = comboBox1.SelectedIndex >= 0;
            dataInfo2.Visible = comboBox1.SelectedIndex > 0;
            groupBoxDataSet1.Visible = comboBox1.SelectedIndex >= 0;
            groupBoxDataSet2.Visible = comboBox1.SelectedIndex > 0;
            listBoxTests.BeginUpdate();
			try
			{
				if (numdatasets==1) listBoxTests.DataSource = oneDSList;
				else if (numdatasets == 2) listBoxTests.DataSource = twoDSList;

				listBoxTests.DisplayMember = "Description";
				listBoxTests.ValueMember = "Method";
			}
			finally
			{
				listBoxTests.EndUpdate();
			}
        }

        private void TextReport()
        {
            wizard.BackEnabled = false;
            wizard.NextEnabled = false;

            this.Cursor = Cursors.WaitCursor;

            richTextBox.SuspendLayout();
            try
            {
                hypControl.Alpha = Alpha;
                // Hypothesis type
                if (radioButtonLeftTailed.Checked) hypControl.HypothesisType = THypothesisType.htLeftTailed;
                else if (radioButtonRightTailed.Checked) hypControl.HypothesisType = THypothesisType.htRightTailed;
                else hypControl.HypothesisType = THypothesisType.htTwoTailed;

                hypControl.Recalc();

                // Do reports
				richTextBox.Clear();

                // Descriptive statistics
				progressBar.Value = 0;
                DataDescStatReport(hypControl.DataVec1);
                if (NumDataSets == 2) DataDescStatReport(hypControl.DataVec2);

                // Hypothesis info
				progressBar.Value = 30;
				HypothesisInfoReport();

				// Hypothesis results (accept or reject)
				progressBar.Value = 60;
				HypothesisResultReport();

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


        private void DataDescStatReport(TVec data)
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = data.Caption + " descriptive statistics report\n\n";
            
            double mean = data.Mean();
            double stddev = data.StdDev(mean);

            richTextBox.SelectionTabs = new int[] { 70 };
            string st = "Mean:\t" + Math387.FormatSample(mean, FmtString) + "\n";
            st += "Median:\t" + Math387.FormatSample(data.Median(), FmtString) + "\n";
            st += "Std.dev.:\t" + Math387.FormatSample(stddev, FmtString) + "\n";
            st += "Skewness:\t" + Math387.FormatSample(data.Skewness(mean, stddev), FmtString) + "\n";
            st += "Kurtosis:\t" + Math387.FormatSample(data.Kurtosis(mean, stddev), FmtString) + "\n";
            st += "Mininum:\t" + Math387.FormatSample(data.Min(), FmtString) + "\n";
            st += "Maximum:\t" + Math387.FormatSample(data.Max(), FmtString) + "\n";


            richTextBox.SelectedText += st + "\n";
        }

		private void HypothesisInfoReport()
		{
			richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
			richTextBox.SelectedText = "Testing hypothesis\n\n";
            richTextBox.SelectionTabs = new int[] { 50 };
            string st = "";

			switch (hypControl.HypothesisMethod)
			{
				case THypothesisMethod.hmAndersonDarling :
				{
					st += "Using Anderson-Darling test to check for normality of data.\n\n";
				} ; break;

				case THypothesisMethod.hmChiSquareTest :
				{
					st += "Using Chi-Squared test to compare data standard deviation with "
						+ "known standard deviation.\n\n";
					st += "Data standard deviation:\t"+Math387.FormatSample(hypControl.DataVec1.StdDev(),FmtString)+"\n";
					st += "Test standard deviation:\t"+Math387.FormatSample(hypControl.Sigma,FmtString)+"\n\n";
				} ; break;
				case THypothesisMethod.hmFTest :
				{
					st += "Using F test to compare two datasets standard deviations.\n\n";
					st += "Dataset 1 standard deviation:\t"+Math387.FormatSample(hypControl.DataVec1.StdDev(),FmtString)+"\n";
					st += "Dataset 2 standard deviation:\t"+Math387.FormatSample(hypControl.DataVec2.StdDev(),FmtString)+"\n";
				} ; break;
				case THypothesisMethod.hmMannWhitney : 
				{
					st += "Using Mann-Whitney U test to check if two datasets come from the same distribution.\n\n";
				};break;
				case THypothesisMethod.hmShapiroFrancia:
				{
					st += "Using Shapiro-Francia test to check for normality of data.\n\n";
				}; break;
				case THypothesisMethod.hmShapiroWilks:
				{
					st += "Using Shapiro-Willks test to check for normality of data.\n\n";
				}; break;
				case THypothesisMethod.hmSignTest:
				{
					st += "Using Sign test to compare data (continuous) median value with known median value.\n\n";
					st += "Data median:\t"+Math387.FormatSample(hypControl.DataVec1.Median(),FmtString)+"\n";
					st += "Test median:\t"+Math387.FormatSample(hypControl.Mean,FmtString)+"\n\n";
				}; break;
				case THypothesisMethod.hmSignTestPaired:
				{
					st += "Using Sign test on paired data to check if two datasets have the same median value.\n\n";
					st += "Dataset 1 median:\t"+Math387.FormatSample(hypControl.DataVec1.Median(),FmtString)+"\n";
					st += "Dataset 2 median:\t"+Math387.FormatSample(hypControl.DataVec2.Median(),FmtString)+"\n\n";
				}; break;
				case THypothesisMethod.hmTTest1:
				{
					st += "Using T test to compare data mean with with known mean.\n\n";
					st += "Data mean:\t"+Math387.FormatSample(hypControl.DataVec1.Mean(),FmtString)+"\n";
					st += "Test mean:\t"+Math387.FormatSample(hypControl.Mean,FmtString)+"\n\n";
				}; break;
				case THypothesisMethod.hmTTest2Paired:
				{
					st += "Using T test on paired data to check if two datasets have the same mean value.\n\n";
					st += "Dataset 1 mean:\t"+Math387.FormatSample(hypControl.DataVec1.Mean(),FmtString)+"\n";
					st += "Dataset 2 mean:\t"+Math387.FormatSample(hypControl.DataVec2.Mean(),FmtString)+"\n\n";
				}; break;
				case THypothesisMethod.hmTTest2Pooled : 
				{
					st += "Using T test on pooled data to check if two datasets have the same mean value.\n\n";
					st += "Dataset 1 mean:\t"+Math387.FormatSample(hypControl.DataVec1.Mean(),FmtString)+"\n";
					st += "Dataset 2 mean:\t"+Math387.FormatSample(hypControl.DataVec2.Mean(),FmtString)+"\n\n";
				}; break;
				case THypothesisMethod.hmWilcoxonSign:
				{
					st += "Using Wilcoxon Signed-Rank test to compare dataset median value with known median value.\n\n";
					st += "Dataset median:\t"+Math387.FormatSample(hypControl.DataVec1.Median(),FmtString)+"\n";
                    st += "Test median:\t" + Math387.FormatSample(hypControl.Mean, FmtString) + "\n\n";
				}; break;
				case THypothesisMethod.hmWilcoxonSignPaired :
				{
					st += "Using Wilcoxon Signed-Rank test to check if two datasets have the same median value.\n\n";
					st += "Dataset 1 median:\t"+Math387.FormatSample(hypControl.DataVec1.Median(),FmtString)+"\n";
					st += "Dataset 2 median:\t"+Math387.FormatSample(hypControl.DataVec2.Median(),FmtString)+"\n\n";
				} ;break;
				case THypothesisMethod.hmZTest:
				{
					st += "Using Z test to compare normally distributed data mean with "
						+ "known standard deviation to known mean.\n\n";
					st += "Data mean:\t"+Math387.FormatSample(hypControl.DataVec1.Mean(),FmtString)+"\n";
                    st += "Data std.deviation:\t" + Math387.FormatSample(hypControl.DataVec1.StdDev(), FmtString) + "\n";
                    st += "Test mean:\t" + Math387.FormatSample(hypControl.Mean, FmtString) + "\n";
                    st += "Assumed std.dev:\t" + Math387.FormatSample(hypControl.Sigma, FmtString) + "\n\n";
                }; break;
			}

			switch (hypControl.HypothesisType)
			{

				case THypothesisType.htRightTailed :
				{
					st += "H:\tData value is equal to test value.\n"
						+ "Ha:\tData value is biggger than test value.\n";
				}; break;
				case THypothesisType.htLeftTailed : 
				{
					st += "H:\tData value is equal to test value.\n"
						+ "Ha:\tvalue is smaller than test value.\n";
				}; break;
				default : 
				{
					st += "H:\tData value is equal to test value.\n"
						+ "Ha:\tData value is not equal to test value.\n";
				} ;break;
			}

			richTextBox.SelectedText += st+"\n";
		}

		private void HypothesisResultReport()
		{
			string st ="";
			
			st += "Desired sig.:\t"+Math387.FormatSample(hypControl.Alpha,FmtString)+"\n";
			st += "Signficance\t"+Math387.FormatSample(hypControl.Significance,FmtString)+"\n";
            if (hypControl.HypothesisMethod != THypothesisMethod.hmShapiroFrancia && hypControl.HypothesisMethod != THypothesisMethod.hmAndersonDarling && hypControl.HypothesisMethod != THypothesisMethod.hmShapiroWilks
                && hypControl.HypothesisMethod != THypothesisMethod.hmSignTest)
            {
                st += Math387.FormatSample(1.0 - hypControl.Alpha, "0.00%") + " level confidence interval: [" +
                    Math387.FormatSample(hypControl.ConfLower, FmtString) + " , " + Math387.FormatSample(hypControl.ConfUpper, FmtString)
                    + "]\n";
            }
			st += "Test statistics:\t"+Math387.FormatSample(this.hypControl.TestStatistics,FmtString)+"\n\n";

			// Hypothesis result
			switch(hypControl.Result)
			{
				case THypothesisResult.hrNotReject:
				{
					st += "Do not reject the null hypothesis (H) at " + Math387.FormatSample(hypControl.Alpha,"0.00%")+".\n";
				} ;break;
				case THypothesisResult.hrReject : 
				{
					st += "Reject the null hypothesis (H) at " + Math387.FormatSample(hypControl.Alpha,"0.00%")+".\n";
				} ;break;
			}

			richTextBox.SelectedText = st+"\n";
		}

        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.wizardPageData = new Dew.Math.Controls.WizardPage();
            this.listBoxTests = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxDataSet2 = new System.Windows.Forms.GroupBox();
            this.buttonEditDat2 = new System.Windows.Forms.Button();
            this.groupBoxDataSet1 = new System.Windows.Forms.GroupBox();
            this.buttonEditDat1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataInfo2 = new StatsMasterDemo.DataInfo();
            this.dataInfo1 = new StatsMasterDemo.DataInfo();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxHypType = new System.Windows.Forms.GroupBox();
            this.radioButtonRightTailed = new System.Windows.Forms.RadioButton();
            this.radioButtonLeftTailed = new System.Windows.Forms.RadioButton();
            this.radioButtonTwoTailed = new System.Windows.Forms.RadioButton();
            this.groupBoxTestValues = new System.Windows.Forms.GroupBox();
            this.textBoxPar2 = new System.Windows.Forms.TextBox();
            this.labelPar2 = new System.Windows.Forms.Label();
            this.textBoxPar1 = new System.Windows.Forms.TextBox();
            this.labelPar1 = new System.Windows.Forms.Label();
            this.wizard.SuspendLayout();
            this.wizardPageReport.SuspendLayout();
            this.wizardPageFormat.SuspendLayout();
            this.wizardPageData.SuspendLayout();
            this.groupBoxDataSet2.SuspendLayout();
            this.groupBoxDataSet1.SuspendLayout();
            this.groupBoxHypType.SuspendLayout();
            this.groupBoxTestValues.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizard
            // 
            this.wizard.Controls.Add(this.wizardPageData);
            this.wizard.Pages.AddRange(new Dew.Math.Controls.WizardPage[] {
            this.wizardPageData});
            this.wizard.Size = new System.Drawing.Size(855, 526);
            this.wizard.AfterSwitchPages += new Dew.Math.Controls.Wizard.AfterSwitchPagesEventHandler(this.wizard_AfterSwitchPages);
            this.wizard.Load += new System.EventHandler(this.wizard_Load);
            this.wizard.Controls.SetChildIndex(this.wizardPageWelcome, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageFormat, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageReport, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageData, 0);
            // 
            // wizardPageReport
            // 
            this.wizardPageReport.Size = new System.Drawing.Size(684, 484);
            this.wizardPageReport.Title = "Hypothesis testing: Report";
            // 
            // richTextBox
            // 
            this.richTextBox.Size = new System.Drawing.Size(652, 313);
            // 
            // progressBar
            // 
            this.progressBar.Size = new System.Drawing.Size(587, 16);
            // 
            // wizardPageFormat
            // 
            this.wizardPageFormat.Controls.Add(this.groupBoxTestValues);
            this.wizardPageFormat.Controls.Add(this.groupBoxHypType);
            this.wizardPageFormat.Description = "Setup hypothesis parameters";
            this.wizardPageFormat.Size = new System.Drawing.Size(684, 484);
            this.wizardPageFormat.Title = "Step 2 : Test parameters";
            this.wizardPageFormat.Controls.SetChildIndex(this.checkBoxCharts, 0);
            this.wizardPageFormat.Controls.SetChildIndex(this.groupBoxHypType, 0);
            this.wizardPageFormat.Controls.SetChildIndex(this.groupBoxTestValues, 0);
            // 
            // wizardPageWelcome
            // 
            this.wizardPageWelcome.Size = new System.Drawing.Size(684, 484);
            this.wizardPageWelcome.Title = "Hypothesis Testing";
            // 
            // wizardPageData
            // 
            this.wizardPageData.Controls.Add(this.listBoxTests);
            this.wizardPageData.Controls.Add(this.label5);
            this.wizardPageData.Controls.Add(this.groupBoxDataSet2);
            this.wizardPageData.Controls.Add(this.groupBoxDataSet1);
            this.wizardPageData.Controls.Add(this.comboBox1);
            this.wizardPageData.Controls.Add(this.label4);
            this.wizardPageData.Controls.Add(this.dataInfo2);
            this.wizardPageData.Controls.Add(this.dataInfo1);
            this.wizardPageData.Description = "Define datasets and select test type.";
            this.wizardPageData.Location = new System.Drawing.Point(0, 0);
            this.wizardPageData.Name = "wizardPageData";
            this.wizardPageData.Size = new System.Drawing.Size(855, 478);
            this.wizardPageData.TabIndex = 13;
            this.wizardPageData.Title = "Step 1: Select test";
            this.wizardPageData.Resize += new System.EventHandler(this.wizardPageData_Resize);
            // 
            // listBoxTests
            // 
            this.listBoxTests.ItemHeight = 15;
            this.listBoxTests.Location = new System.Drawing.Point(19, 346);
            this.listBoxTests.Name = "listBoxTests";
            this.listBoxTests.Size = new System.Drawing.Size(213, 109);
            this.listBoxTests.TabIndex = 7;
            this.listBoxTests.SelectedIndexChanged += new System.EventHandler(this.listBoxTests_SelectedIndexChanged);
            this.listBoxTests.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxTests_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Available tests";
            // 
            // groupBoxDataSet2
            // 
            this.groupBoxDataSet2.Controls.Add(this.buttonEditDat2);
            this.groupBoxDataSet2.Location = new System.Drawing.Point(24, 212);
            this.groupBoxDataSet2.Name = "groupBoxDataSet2";
            this.groupBoxDataSet2.Size = new System.Drawing.Size(141, 68);
            this.groupBoxDataSet2.TabIndex = 5;
            this.groupBoxDataSet2.TabStop = false;
            this.groupBoxDataSet2.Text = "2nd dataset";
            // 
            // buttonEditDat2
            // 
            this.buttonEditDat2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEditDat2.Location = new System.Drawing.Point(7, 23);
            this.buttonEditDat2.Name = "buttonEditDat2";
            this.buttonEditDat2.Size = new System.Drawing.Size(126, 29);
            this.buttonEditDat2.TabIndex = 1;
            this.buttonEditDat2.Text = "Edit";
            this.buttonEditDat2.Click += new System.EventHandler(this.buttonEditDat2_Click);
            // 
            // groupBoxDataSet1
            // 
            this.groupBoxDataSet1.Controls.Add(this.buttonEditDat1);
            this.groupBoxDataSet1.Location = new System.Drawing.Point(24, 144);
            this.groupBoxDataSet1.Name = "groupBoxDataSet1";
            this.groupBoxDataSet1.Size = new System.Drawing.Size(141, 60);
            this.groupBoxDataSet1.TabIndex = 4;
            this.groupBoxDataSet1.TabStop = false;
            this.groupBoxDataSet1.Text = "1st dataset";
            // 
            // buttonEditDat1
            // 
            this.buttonEditDat1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEditDat1.Location = new System.Drawing.Point(6, 23);
            this.buttonEditDat1.Name = "buttonEditDat1";
            this.buttonEditDat1.Size = new System.Drawing.Size(126, 29);
            this.buttonEditDat1.TabIndex = 1;
            this.buttonEditDat1.Text = "Edit";
            this.buttonEditDat1.Click += new System.EventHandler(this.buttonEditDat1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox1.Location = new System.Drawing.Point(19, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Number of datasets";
            // 
            // dataInfo2
            // 
            this.dataInfo2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataInfo2.Location = new System.Drawing.Point(262, 319);
            this.dataInfo2.Name = "dataInfo2";
            this.dataInfo2.SettingsPanelVisible = true;
            this.dataInfo2.ShowData = true;
            this.dataInfo2.ShowHistogram = true;
            this.dataInfo2.ShowStat = true;
            this.dataInfo2.Size = new System.Drawing.Size(589, 143);
            this.dataInfo2.StringFormat = "0.0000";
            this.dataInfo2.TabIndex = 1;
            // 
            // dataInfo1
            // 
            this.dataInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataInfo1.Location = new System.Drawing.Point(262, 84);
            this.dataInfo1.Name = "dataInfo1";
            this.dataInfo1.SettingsPanelVisible = true;
            this.dataInfo1.ShowData = true;
            this.dataInfo1.ShowHistogram = true;
            this.dataInfo1.ShowStat = true;
            this.dataInfo1.Size = new System.Drawing.Size(589, 146);
            this.dataInfo1.StringFormat = "0.0000";
            this.dataInfo1.TabIndex = 0;
            // 
            // toolTipHelp
            // 
            this.toolTipHelp.Active = false;
            this.toolTipHelp.UseAnimation = false;
            this.toolTipHelp.UseFading = false;
            // 
            // groupBoxHypType
            // 
            this.groupBoxHypType.Controls.Add(this.radioButtonRightTailed);
            this.groupBoxHypType.Controls.Add(this.radioButtonLeftTailed);
            this.groupBoxHypType.Controls.Add(this.radioButtonTwoTailed);
            this.groupBoxHypType.Location = new System.Drawing.Point(239, 96);
            this.groupBoxHypType.Name = "groupBoxHypType";
            this.groupBoxHypType.Size = new System.Drawing.Size(375, 123);
            this.groupBoxHypType.TabIndex = 1;
            this.groupBoxHypType.TabStop = false;
            this.groupBoxHypType.Text = "Hypothesis type";
            // 
            // radioButtonRightTailed
            // 
            this.radioButtonRightTailed.Location = new System.Drawing.Point(7, 80);
            this.radioButtonRightTailed.Name = "radioButtonRightTailed";
            this.radioButtonRightTailed.Size = new System.Drawing.Size(339, 21);
            this.radioButtonRightTailed.TabIndex = 2;
            this.radioButtonRightTailed.TabStop = true;
            this.radioButtonRightTailed.Text = "Right tailed (Ha: value is MORE than test value)";
            // 
            // radioButtonLeftTailed
            // 
            this.radioButtonLeftTailed.Location = new System.Drawing.Point(7, 52);
            this.radioButtonLeftTailed.Name = "radioButtonLeftTailed";
            this.radioButtonLeftTailed.Size = new System.Drawing.Size(348, 21);
            this.radioButtonLeftTailed.TabIndex = 1;
            this.radioButtonLeftTailed.TabStop = true;
            this.radioButtonLeftTailed.Text = "Left tailed (Ha: value is LESS than test value)";
            // 
            // radioButtonTwoTailed
            // 
            this.radioButtonTwoTailed.Checked = true;
            this.radioButtonTwoTailed.Location = new System.Drawing.Point(7, 23);
            this.radioButtonTwoTailed.Name = "radioButtonTwoTailed";
            this.radioButtonTwoTailed.Size = new System.Drawing.Size(348, 21);
            this.radioButtonTwoTailed.TabIndex = 0;
            this.radioButtonTwoTailed.TabStop = true;
            this.radioButtonTwoTailed.Text = "Two tailed (Ha: value is NOT equal to test value)";
            // 
            // groupBoxTestValues
            // 
            this.groupBoxTestValues.Controls.Add(this.textBoxPar2);
            this.groupBoxTestValues.Controls.Add(this.labelPar2);
            this.groupBoxTestValues.Controls.Add(this.textBoxPar1);
            this.groupBoxTestValues.Controls.Add(this.labelPar1);
            this.groupBoxTestValues.Location = new System.Drawing.Point(239, 238);
            this.groupBoxTestValues.Name = "groupBoxTestValues";
            this.groupBoxTestValues.Size = new System.Drawing.Size(375, 87);
            this.groupBoxTestValues.TabIndex = 2;
            this.groupBoxTestValues.TabStop = false;
            this.groupBoxTestValues.Text = "Test values";
            // 
            // textBoxPar2
            // 
            this.textBoxPar2.Location = new System.Drawing.Point(95, 55);
            this.textBoxPar2.Name = "textBoxPar2";
            this.textBoxPar2.Size = new System.Drawing.Size(120, 23);
            this.textBoxPar2.TabIndex = 3;
            this.textBoxPar2.Visible = false;
            this.textBoxPar2.TextChanged += new System.EventHandler(this.textBoxPar2_TextChanged);
            // 
            // labelPar2
            // 
            this.labelPar2.AutoSize = true;
            this.labelPar2.Location = new System.Drawing.Point(7, 59);
            this.labelPar2.Name = "labelPar2";
            this.labelPar2.Size = new System.Drawing.Size(55, 15);
            this.labelPar2.TabIndex = 2;
            this.labelPar2.Text = "labelPar2";
            this.labelPar2.Visible = false;
            // 
            // textBoxPar1
            // 
            this.textBoxPar1.Location = new System.Drawing.Point(95, 26);
            this.textBoxPar1.Name = "textBoxPar1";
            this.textBoxPar1.Size = new System.Drawing.Size(120, 23);
            this.textBoxPar1.TabIndex = 1;
            this.textBoxPar1.TextChanged += new System.EventHandler(this.textBoxPar1_TextChanged);
            // 
            // labelPar1
            // 
            this.labelPar1.AutoSize = true;
            this.labelPar1.Location = new System.Drawing.Point(7, 30);
            this.labelPar1.Name = "labelPar1";
            this.labelPar1.Size = new System.Drawing.Size(55, 15);
            this.labelPar1.TabIndex = 0;
            this.labelPar1.Text = "labelPar1";
            // 
            // HypTestWizard
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(855, 526);
            this.Name = "HypTestWizard";
            this.Load += new System.EventHandler(this.HypTestWizard_Load);
            this.wizard.ResumeLayout(false);
            this.wizardPageReport.ResumeLayout(false);
            this.wizardPageReport.PerformLayout();
            this.wizardPageFormat.ResumeLayout(false);
            this.wizardPageFormat.PerformLayout();
            this.wizardPageData.ResumeLayout(false);
            this.wizardPageData.PerformLayout();
            this.groupBoxDataSet2.ResumeLayout(false);
            this.groupBoxDataSet1.ResumeLayout(false);
            this.groupBoxHypType.ResumeLayout(false);
            this.groupBoxTestValues.ResumeLayout(false);
            this.groupBoxTestValues.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

        #region Wizard control

        private void wizardPageData_Resize(object sender, EventArgs e)
        {
            dataInfo1.Height = wizardPageData.Height / 2-50;
            dataInfo2.Height = dataInfo1.Height ;
            dataInfo2.Top = dataInfo1.Bottom + 10;
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
                wizard.NextEnabled = CheckData();
            }
            else wizard.CancelEnabled = true;
        }

        #endregion

        private void wizard_Load(object sender, EventArgs e)
        {
            // Setup dataInfo controls
            dataInfo1.Height = wizardPageData.Height / 2- 50;
            dataInfo2.Height = dataInfo1.Height;
            dataInfo2.Top = dataInfo1.Bottom + 10;
			// Populate description
			wizardPageWelcome.Description = "Using this wizard you can check several statistical tests "
				+ "on one or two datasets.\nJust select number of datasets, populate them with values and "
				+ "pick a test you want to perform. Wizard will automatically generate report and give you "
				+ "the results you need.";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NumDataSets = comboBox1.SelectedIndex + 1;
        }

        private void HypTestWizard_Load(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(this,new EventArgs());
        }

        private void buttonEditDat1_Click(object sender, EventArgs e)
        {
            MtxVecEdit.ViewValues(hypControl.DataVec1, hypControl.DataVec1.Caption, true, true, true);
            dataInfo1.Update();
			wizard.NextEnabled = CheckData() || wizard.SelectedPage == wizardPageWelcome;
		}

        private void buttonEditDat2_Click(object sender, EventArgs e)
        {
            MtxVecEdit.ViewValues(hypControl.DataVec2, hypControl.DataVec2.Caption, true, true, true);
            dataInfo2.Update();
			wizard.NextEnabled = CheckData() || wizard.SelectedPage == wizardPageWelcome;
		}

        private void listBoxTests_MouseMove(object sender, MouseEventArgs e)
        {
            int index = listBoxTests.IndexFromPoint(new Point(e.X, e.Y));
            toolTipHelp.Active = index >= 0;
            if (index >= 0 && listBoxTests.Items[index] !=null)
                toolTipHelp.SetToolTip(listBoxTests, (listBoxTests.Items[index] as HypTest).Help);
        }

        private void listBoxTests_SelectedIndexChanged(object sender, EventArgs e)
        {
			wizard.NextEnabled = CheckData() || wizard.SelectedPage == wizardPageWelcome;
			
			HypTest selected = listBoxTests.SelectedItem as HypTest;
            textBoxPar2.Visible = false;
            labelPar2.Visible = false;

            if (selected != null)
            {

                hypControl.HypothesisMethod = selected.Method;
                
                // Default
				groupBoxHypType.Enabled = selected.AllTypes;
                groupBoxTestValues.Visible = false;
				radioButtonTwoTailed.Checked = true;
                
				switch (selected.Method)
                {
                    case THypothesisMethod.hmChiSquareTest:
                        {
                            labelPar1.Text = "Sigma";
                            groupBoxTestValues.Visible = true;
                        }; break;
                    case THypothesisMethod.hmSignTest:
                        {
                            labelPar1.Text = "Median";
                            groupBoxTestValues.Visible = true;
                        }; break;
                    case THypothesisMethod.hmTTest1:
                        {
                            labelPar1.Text = "Mean";
                            groupBoxTestValues.Visible = true;
                        }; break;
                    case THypothesisMethod.hmZTest:
                        {
                            // two parameters!
                            labelPar1.Text = "Mean";
                            labelPar2.Visible = true;
                            textBoxPar2.Visible = true;
                            labelPar2.Text = "Sigma";
                            groupBoxTestValues.Visible = true;
                       }; break;
                   case THypothesisMethod.hmWilcoxonSign:
                       {
                           labelPar1.Text = "Median";
                           groupBoxTestValues.Visible = true;
                       }; break;

                }
            }
        }

        private void textBoxPar1_TextChanged(object sender, EventArgs e)
        {
            if (hypControl.HypothesisMethod == THypothesisMethod.hmChiSquareTest) hypControl.Sigma = Math387.StrToSample(textBoxPar1.Text);
            else hypControl.Mean = Math387.StrToSample(textBoxPar1.Text);
        }

        private void textBoxPar2_TextChanged(object sender, EventArgs e)
        {
            hypControl.Sigma = Math387.StrToSample(textBoxPar2.Text);
        }

    }
}

