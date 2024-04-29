using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Units;
using Dew.Stats;
using Dew.Stats.Units;
using Dew.Math.Editors;
using Dew.Math.Tee;


namespace StatsMasterDemo
{
    public class ARMAWizard : StatsMasterDemo.BaseStatWizard
    {

        private Vector timeseries;
        private Vector data;
        private Vector residuals;
        private Vector forecasts;
        private Vector forecastsd;
        private Vector phi, phiInit;
        private Vector theta, thetaInit;
        private int p = 0;
        private int q = 0;
        private int d = 0;
        private int forper = 10;
        private int maxLag = -1;
        private double dMean;
        private double chartlcl, chartucl;
        private OpenFileDialog openFileDialog1;
        private Dew.Math.Controls.WizardPage wizardPageForecasts;
        private Dew.Math.Controls.WizardPage wizardPageModel;
        private Dew.Math.Controls.WizardPage wizardPageTimeSeries;
        private GroupBox groupBox5;
        private RadioButton radioButtonPACF;
        private RadioButton radioButtonACF;
        private RadioButton radioButtonTS;
        private GroupBox groupBox4;
        private Label labelTrStat;
        private GroupBox groupBox3;
        private Label labelUnTrStat;
        private Steema.TeeChart.TChart tChartData;
        private GroupBox groupBox6;
        private NumericUpDown numericUpDownDiff;
        private Label label6;
        private CheckBox checkBoxRemoveMean;
        private Button buttonLoad;
        private Steema.TeeChart.Styles.Line line1;
        private GroupBox groupBoxInitMA;
        private ComboBox comboBox2;
        private GroupBox groupBoxEditPhiTheta;
        private Label label8;
        private Button buttonEditMA;
        private Button buttonEditAR;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private Label label7;
        private Label label9;
        private ComboBox comboBox1;
        private GroupBox groupBox9;
        private ComboBox comboBox3;
        private GroupBox groupBox10;
        private Label label10;
        private Button button1;
        private Button button2;
        private GroupBox groupBox11;
        private CheckBox checkBoxMLE;
        private GroupBox groupBox12;
        private NumericUpDown numericUpDown1;
        private Label label11;
        private NumericUpDown numericUpDown2;
        private Label label12;
        private GroupBox groupBox13;
        private CheckBox checkBoxIntegrate;
        private CheckBox checkBoxAddMean;
        private NumericUpDown numericUpDownACFLag;
        private Label label13;
        private NumericUpDown numericUpDownForNum;
        private Label label14;
        private GroupBox groupBox2;
        private ComboBox comboBox4;
        private TcfInitMethod armainit = TcfInitMethod.cfInitFixed;

        public ARMAWizard()
        {
            InitializeComponent();
            timeseries = new Vector(0);
            data = new Vector(0);
            residuals = new Vector(0);
            forecasts = new Vector(0);
            forecastsd = new Vector(0);
            phi = new Vector(0);
            theta = new Vector(0);

            phiInit = new Vector(0);
            thetaInit = new Vector(0);

            openFileDialog1.Filter = "vectors (*.vec)|*.vec";

            // Reposition ARMA wizard pages
            wizard.Pages.Remove(wizardPageTimeSeries);
            wizard.Pages.Remove(wizardPageModel);
            wizard.Pages.Remove(wizardPageForecasts);
            wizard.Pages.Insert(1, wizardPageForecasts);
            wizard.Pages.Insert(1, wizardPageModel);
            wizard.Pages.Insert(1, wizardPageTimeSeries);
        }
        #region Reports

        private void TextReport()
        {
            richTextBox.SuspendLayout();
            wizard.NextEnabled = false;
            wizard.BackEnabled = false;

            TransformTimeSeries();

            if (armainit == TcfInitMethod.cfInitFixed)
            {
                phi.Copy(phiInit);
                theta.Copy(thetaInit);
            } 
            else
            { 
                phi.Size(p);
                phi.SetZero();

                theta.Size(q);
                theta.SetZero();
            }


            this.Cursor = Cursors.WaitCursor;
            try
            {
                richTextBox.Clear();

                progressBar.Value = 0;
                InitEstimateReport();

                progressBar.Value = 40;
                if (checkBoxMLE.Checked) MLEReport();

                progressBar.Value = 70;
                ForecastReport();

                progressBar.Value = 100;
                richTextBox.SelectionStart = 0;
            }
            finally
            {
                wizard.BackEnabled = true;
                richTextBox.ResumeLayout();
                this.Cursor = Cursors.Default;
            }

        }

        /// <summary>
        /// Check if model is causal and invertible
        /// </summary>
        private string CausalReport()
        {
            string result = "";
            if (p > 0)
                if (StatTimeSerAnalysis.CheckARMACoeffs(phi, true)) result += "Model causal\n"; else result += "Model not causal\n";

            if (q > 0)
                if (StatTimeSerAnalysis.CheckARMACoeffs(theta, false)) result += "Model invertible\n"; else result += "Model not invertible\n";
            return result;
        }

        private string CoeffReport(Vector coeff, string ccaption)
        {
            string result = "";
            for (int i = 0; i < coeff.Length; i++)
                result += ccaption + "[" + (i + 1) + "]" + "\t" + Math387.FormatSample(FmtString, coeff.Values[i]) + "\n";
            return result;
        }

        private string CoeffReport(Vector coeff, Vector cstderr, string ccaption)
        {
            Vector tvals = new Vector(0);
            Vector pvals = new Vector(0);
            string result = "";

            // Calculate t values
            // This is the t-test value for testing the hypothesis that j = 0 versus 
            // the alternative that after removing the influence of all other X's. 
            // The degrees of freedom is equal to the N minus the number of model parameters and differences.
            tvals = coeff / cstderr;

            // calculate p values
            // The p-value is the probability that above T-statistic will take on a value 
            // at least as extreme as the actually observed value, assuming that the null hypothesis
            // is true (i.e., the regression estimate is equal to zero). If the p-value is less than
            // alpha, say 0.05, the null hypothesis is rejected. 
            // This p-value is for a two-tail test.
            int df = data.Length - p - q - d;
            Probabilities.StudentCDF(tvals, df, pvals);
            for (int i = 0; i < pvals.Length; i++)
                pvals.Values[i] = 2.0 * Math387.Min(pvals.Values[i], 1.0 - pvals.Values[i]);
            for (int i = 0; i < coeff.Length; i++)
            {
                result += ccaption + "[" + (i + 1) + "]" + "\t" + Math387.FormatSample(FmtString, coeff.Values[i]) + "\t";
                result += Math387.FormatSample(FmtString, cstderr.Values[i]) + "\t";
                result += Math387.FormatSample(FmtString, tvals.Values[i]) + "\t";
                result += Math387.FormatSample(FmtString, pvals.Values[i]) + "\n";
            }
            return result;
        }

        private void InitEstimateReport()
        {
            int innoLag; 

            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Preliminary estimates for coefficients\n\n";

            if (maxLag < 0)
            {
                innoLag = (int)Math387.Ceil(10 * Math.Log10(data.Length));
            }
            else
            {
                innoLag = maxLag;
            }

            Vector d1 = new Vector(0);
            Vector d2 = new Vector(0);
            if (p > 0)
            {
                d1.Size(phi);
                d1.SetZero();
            }
            if (q > 0)
            {
                d2.Size(theta);
                d2.SetZero();
            }

            double estvar = 1.0;
            double zval = Probabilities.NormalCDFInv(1.0 - 0.5 * Alpha, 0, 1);
            // Retrieve coefficients
            switch (armainit)
            {
                case TcfInitMethod.cfInitYW:
                    {
                        StatTimeSerAnalysis.ARYuleWalkerFit(data, phi, out estvar, d1);
                        richTextBox.SelectedText = "Method used: Yule-Walker\n";
                    }; break;
                case TcfInitMethod.cfInitBurg:
                    {
                        StatTimeSerAnalysis.ARBurgFit(data, phi, out estvar, d1);
                        richTextBox.SelectedText = "Method used: Burg\n";
                    }; break;
                case TcfInitMethod.cfInitInno:
                    {
                        if (p == 0) StatTimeSerAnalysis.ARMAInnovationsFit(data, theta, out estvar, d2, innoLag);
                        else StatTimeSerAnalysis.ARMAInnovationsFit(data, phi, theta, out estvar, d1, d2, innoLag);
                        richTextBox.SelectedText = "Method used: Innovations with " + innoLag.ToString() + " lags\n";
                    }; break;
                case TcfInitMethod.cfInitHannah:
                    {
                        StatTimeSerAnalysis.ARMAHannahFit(data, phi, theta, out estvar);
                        richTextBox.SelectedText = "Method used: Hannah\n";
                    }; break;
            }
            if (armainit != TcfInitMethod.cfInitFixed)
            {
                richTextBox.SelectedText = "Estimated WN variance: " + Math387.FormatSample(FmtString, estvar) + "\n";
            }

            richTextBox.SelectedText = CausalReport() + "\n";

            SetupTabs(richTextBox, 5);
            richTextBox.SelectedText = "Model coefficients:\n";
            richTextBox.SelectionColor = Color.Blue;
            richTextBox.SelectedText = "Coefficient\tCoefficient\tStandard\tT-value\tP-value\nname\testimate\terror\tHo:Coef.=0\t\n";
            if (p > 0) richTextBox.SelectedText = CoeffReport(phi, d1, "AR");
            if (q > 0) richTextBox.SelectedText = CoeffReport(theta, d2, "MA");
            richTextBox.SelectedText = "\n";
        }

        private void MLEReport()
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "MLE estimates for coefficients\n\n";
            double mle = 0.0;
            string st = "";

            // estimate by using initial value from InitEstimateReport() routine
            int iters = StatTimeSerAnalysis.ARMAMLE(data, phi, theta, residuals, out mle, out dMean);

            st = "Number of iterations needed: " + iters.ToString() + "\n";
            st += "-2log(likelihood): " + Math387.FormatSample(FmtString, mle) + "\n";
            st += CausalReport() + "\n";
            richTextBox.SelectedText = st;

            SetupTabs(richTextBox, 2);
            richTextBox.SelectedText = "Model coefficients:\n";
            richTextBox.SelectionColor = Color.Blue;
            richTextBox.SelectedText = "Coefficient\tCoefficient\n";
            if (p > 0) richTextBox.SelectedText = CoeffReport(phi, "AR");
            if (q > 0) richTextBox.SelectedText = CoeffReport(theta, "MA");
            richTextBox.SelectedText = "\n";
        }

        private void ForecastReport()
        {
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Forecasting " + forper.ToString() + " points\n\n";
            this.Cursor = Cursors.WaitCursor;
            int endperiod;
            string st = "";
            try
            {
                StatTimeSerAnalysis.ARMAForecast(data, phi, theta, residuals, forper, dMean, forecasts, forecastsd);

                // integrate, if required
                if ((d > 0) && (checkBoxIntegrate.Checked))
                {
                    Vector v0 = new Vector(0);
                    // setup initial values for integration
                    StatTimeSerAnalysis.TimeSeriesIntInit(timeseries, v0, d, true);
                    // integrate d times
                    forecasts.Integrate(v0);
                    endperiod = data.Length + d - 1;
                }
                else endperiod = data.Length - 1;

                SetupTabs(richTextBox, 3);
                richTextBox.SelectionColor = Color.Blue;
                richTextBox.SelectedText = "Period\tForecast\tForecast std.dev\n";
                for (int i = 1; i <= forper; i++)
                {
                    st += i + endperiod + "\t" + Math387.FormatSample(FmtString, forecasts.Values[i - 1]) + "\t";
                    st += Math387.FormatSample(FmtString, forecastsd.Values[i - 1]) + "\n";
                }
                richTextBox.SelectedText = st + "\n";

                // Forecasts chart
                int offset;
                Chart.Series.Clear();
                Chart.Aspect.View3D = false;
                Chart.Legend.Visible = false;
                Chart.Axes.Left.Automatic = true;
                Vector v1 = new Vector(0);
                Vector v2 = new Vector(0);
                Chart.Axes.Bottom.Visible = true;
                Chart.Legend.Visible = true;
                // original time series
                Chart.Series.Add(new Steema.TeeChart.Styles.Line());
                Chart.Series[0].Title = "Time series";
                // forecasts
                Chart.Series.Add(new Steema.TeeChart.Styles.Line());
                Chart.Series[1].Title = "Forecasts";
                // ucl,lcl
                Chart.Series.Add(new Steema.TeeChart.Styles.Line());
                Chart.Series.Add(new Steema.TeeChart.Styles.Line());
                Chart.Series[2].Title = "CI";
                Chart.Series[2].Color = Color.Black;
                Chart.Series[3].Color = Color.Black;
                Chart.Series[3].Legend.Visible = false;
                v1.Copy(data);

                // integrate, if required
                if ((d > 0) && (checkBoxIntegrate.Checked))
                {
                    StatTimeSerAnalysis.TimeSeriesIntInit(timeseries, v2, d, false);
                    v1.Integrate(v2);
                    MtxVecTee.DrawValues(v1, Chart.Series[0], d, 1, false);
                    offset = v1.Length + d;
                }
                else
                {
                    MtxVecTee.DrawValues(v1, Chart.Series[0], 0, 1, false);
                    offset = v1.Length;
                }
                // forecasts
                MtxVecTee.DrawValues(forecasts, Chart.Series[1], offset, 1, false);
                v1.Size(forecasts);
                v2.Size(v1);
                // 1.0-Alpha CI
                for (int i = 0; i < v1.Length; i++)
                {
                    v1.Values[i] = Probabilities.NormalCDFInv(0.5 * Alpha, forecasts.Values[i], forecastsd.Values[i]);
                    v2.Values[i] = Probabilities.NormalCDFInv(1.0 - 0.5 * Alpha, forecasts.Values[i], forecastsd.Values[i]);
                }
                MtxVecTee.DrawValues(v1, Chart.Series[2], offset, 1, false);
                MtxVecTee.DrawValues(v2, Chart.Series[3], offset, 1, false);
                Chart.Header.Text = "Forecasting up to " + forecasts.Length.ToString() + " points.";
                CopyToRichBox(richTextBox);
                richTextBox.SelectedText = "\n";


            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #endregion

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
            Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ARMAWizard));
            openFileDialog1 = new OpenFileDialog();
            wizardPageTimeSeries = new Dew.Math.Controls.WizardPage();
            groupBox5 = new GroupBox();
            radioButtonPACF = new RadioButton();
            radioButtonACF = new RadioButton();
            radioButtonTS = new RadioButton();
            groupBox4 = new GroupBox();
            labelTrStat = new Label();
            groupBox3 = new GroupBox();
            labelUnTrStat = new Label();
            tChartData = new Steema.TeeChart.TChart();
            line1 = new Steema.TeeChart.Styles.Line();
            groupBox6 = new GroupBox();
            numericUpDownDiff = new NumericUpDown();
            label6 = new Label();
            checkBoxRemoveMean = new CheckBox();
            buttonLoad = new Button();
            wizardPageModel = new Dew.Math.Controls.WizardPage();
            groupBox2 = new GroupBox();
            comboBox4 = new ComboBox();
            groupBox9 = new GroupBox();
            comboBox3 = new ComboBox();
            groupBox10 = new GroupBox();
            label10 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox11 = new GroupBox();
            checkBoxMLE = new CheckBox();
            groupBox12 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            label11 = new Label();
            numericUpDown2 = new NumericUpDown();
            label12 = new Label();
            wizardPageForecasts = new Dew.Math.Controls.WizardPage();
            groupBox13 = new GroupBox();
            checkBoxIntegrate = new CheckBox();
            checkBoxAddMean = new CheckBox();
            numericUpDownACFLag = new NumericUpDown();
            label13 = new Label();
            numericUpDownForNum = new NumericUpDown();
            label14 = new Label();
            groupBoxInitMA = new GroupBox();
            comboBox2 = new ComboBox();
            groupBoxEditPhiTheta = new GroupBox();
            label8 = new Label();
            buttonEditMA = new Button();
            buttonEditAR = new Button();
            groupBox7 = new GroupBox();
            groupBox8 = new GroupBox();
            label7 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            wizard.SuspendLayout();
            wizardPageReport.SuspendLayout();
            wizardPageFormat.SuspendLayout();
            wizardPageTimeSeries.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox6.SuspendLayout();
            ((ISupportInitialize)numericUpDownDiff).BeginInit();
            wizardPageModel.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox12.SuspendLayout();
            ((ISupportInitialize)numericUpDown1).BeginInit();
            ((ISupportInitialize)numericUpDown2).BeginInit();
            wizardPageForecasts.SuspendLayout();
            groupBox13.SuspendLayout();
            ((ISupportInitialize)numericUpDownACFLag).BeginInit();
            ((ISupportInitialize)numericUpDownForNum).BeginInit();
            groupBoxInitMA.SuspendLayout();
            groupBoxEditPhiTheta.SuspendLayout();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // wizard
            // 
            wizard.Controls.Add(wizardPageTimeSeries);
            wizard.Controls.Add(wizardPageModel);
            wizard.Controls.Add(wizardPageForecasts);
            wizard.Pages.AddRange(new Dew.Math.Controls.WizardPage[] { wizardPageTimeSeries, wizardPageModel, wizardPageForecasts });
            wizard.Size = new Size(745, 521);
            wizard.AfterSwitchPages += wizard_AfterSwitchPages;
            wizard.Load += wizard_Load;
            wizard.Controls.SetChildIndex(wizardPageFormat, 0);
            wizard.Controls.SetChildIndex(wizardPageForecasts, 0);
            wizard.Controls.SetChildIndex(wizardPageWelcome, 0);
            wizard.Controls.SetChildIndex(wizardPageReport, 0);
            wizard.Controls.SetChildIndex(wizardPageModel, 0);
            wizard.Controls.SetChildIndex(wizardPageTimeSeries, 0);
            // 
            // wizardPageReport
            // 
            wizardPageReport.Size = new Size(751, 530);
            wizardPageReport.Title = "ARMA : Report";
            // 
            // richTextBox
            // 
            richTextBox.Size = new Size(719, 359);
            // 
            // progressBar
            // 
            progressBar.Size = new Size(654, 16);
            // 
            // wizardPageFormat
            // 
            wizardPageFormat.Description = "Define ARMA Report output options";
            wizardPageFormat.Location = new Point(22, 23);
            wizardPageFormat.Size = new Size(729, 450);
            wizardPageFormat.Title = "Step 4: Report options";
            wizardPageFormat.Click += wizardPageFormat_Click;
            // 
            // wizardPageWelcome
            // 
            wizardPageWelcome.Size = new Size(562, 306);
            // 
            // textBoxAlpha
            // 
            textBoxAlpha.TextChanged += textBoxAlpha_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // wizardPageTimeSeries
            // 
            wizardPageTimeSeries.Controls.Add(groupBox5);
            wizardPageTimeSeries.Controls.Add(groupBox4);
            wizardPageTimeSeries.Controls.Add(groupBox3);
            wizardPageTimeSeries.Controls.Add(tChartData);
            wizardPageTimeSeries.Controls.Add(groupBox6);
            wizardPageTimeSeries.Description = "Define transformation applied to time series prior to ARMA";
            wizardPageTimeSeries.Location = new Point(0, 0);
            wizardPageTimeSeries.Name = "wizardPageTimeSeries";
            wizardPageTimeSeries.Size = new Size(540, 297);
            wizardPageTimeSeries.TabIndex = 13;
            wizardPageTimeSeries.Title = "Step 1: Define time series";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(radioButtonPACF);
            groupBox5.Controls.Add(radioButtonACF);
            groupBox5.Controls.Add(radioButtonTS);
            groupBox5.Location = new Point(239, 102);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(213, 117);
            groupBox5.TabIndex = 17;
            groupBox5.TabStop = false;
            groupBox5.Text = "Plot";
            // 
            // radioButtonPACF
            // 
            radioButtonPACF.FlatStyle = FlatStyle.Flat;
            radioButtonPACF.Location = new Point(13, 81);
            radioButtonPACF.Name = "radioButtonPACF";
            radioButtonPACF.Size = new Size(167, 21);
            radioButtonPACF.TabIndex = 2;
            radioButtonPACF.Text = "Time series PACF";
            radioButtonPACF.CheckedChanged += radioButtonTS_CheckedChanged;
            // 
            // radioButtonACF
            // 
            radioButtonACF.FlatStyle = FlatStyle.Flat;
            radioButtonACF.Location = new Point(13, 53);
            radioButtonACF.Name = "radioButtonACF";
            radioButtonACF.Size = new Size(167, 21);
            radioButtonACF.TabIndex = 1;
            radioButtonACF.Text = "Time series ACF";
            radioButtonACF.CheckedChanged += radioButtonTS_CheckedChanged;
            // 
            // radioButtonTS
            // 
            radioButtonTS.Checked = true;
            radioButtonTS.FlatStyle = FlatStyle.Flat;
            radioButtonTS.Location = new Point(13, 25);
            radioButtonTS.Name = "radioButtonTS";
            radioButtonTS.Size = new Size(167, 21);
            radioButtonTS.TabIndex = 0;
            radioButtonTS.TabStop = true;
            radioButtonTS.Text = "Time series";
            radioButtonTS.CheckedChanged += radioButtonTS_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(labelTrStat);
            groupBox4.Location = new Point(235, 247);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(220, 117);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Transformed series statistics";
            // 
            // labelTrStat
            // 
            labelTrStat.Location = new Point(13, 33);
            labelTrStat.Name = "labelTrStat";
            labelTrStat.Size = new Size(189, 72);
            labelTrStat.TabIndex = 0;
            labelTrStat.Text = "label2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(labelUnTrStat);
            groupBox3.Location = new Point(12, 247);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(220, 116);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Untransformed series statistics";
            // 
            // labelUnTrStat
            // 
            labelUnTrStat.Location = new Point(10, 26);
            labelUnTrStat.Name = "labelUnTrStat";
            labelUnTrStat.Size = new Size(201, 70);
            labelUnTrStat.TabIndex = 0;
            labelUnTrStat.Text = "label2";
            // 
            // tChartData
            // 
            tChartData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Bottom.Labels.Brush.Color = Color.White;
            tChartData.Axes.Bottom.Labels.Brush.Solid = true;
            tChartData.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            tChartData.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            tChartData.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChartData.Axes.Bottom.Labels.Font.Brush.Solid = true;
            tChartData.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            tChartData.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            tChartData.Axes.Bottom.Labels.Font.Size = 9;
            tChartData.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            tChartData.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
            tChartData.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            tChartData.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            tChartData.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Bottom.Title.Brush.Color = Color.Silver;
            tChartData.Axes.Bottom.Title.Brush.Solid = true;
            tChartData.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            tChartData.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            tChartData.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChartData.Axes.Bottom.Title.Font.Brush.Solid = true;
            tChartData.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            tChartData.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            tChartData.Axes.Bottom.Title.Font.Size = 11;
            tChartData.Axes.Bottom.Title.Font.SizeFloat = 11F;
            tChartData.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChartData.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            tChartData.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            tChartData.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Depth.Labels.Brush.Color = Color.White;
            tChartData.Axes.Depth.Labels.Brush.Solid = true;
            tChartData.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            tChartData.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            tChartData.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChartData.Axes.Depth.Labels.Font.Brush.Solid = true;
            tChartData.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            tChartData.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            tChartData.Axes.Depth.Labels.Font.Size = 9;
            tChartData.Axes.Depth.Labels.Font.SizeFloat = 9F;
            tChartData.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
            tChartData.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            tChartData.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            tChartData.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Depth.Title.Brush.Color = Color.Silver;
            tChartData.Axes.Depth.Title.Brush.Solid = true;
            tChartData.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            tChartData.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            tChartData.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChartData.Axes.Depth.Title.Font.Brush.Solid = true;
            tChartData.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            tChartData.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            tChartData.Axes.Depth.Title.Font.Size = 11;
            tChartData.Axes.Depth.Title.Font.SizeFloat = 11F;
            tChartData.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChartData.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            tChartData.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Axes.Depth.Title.Shadow.Brush.Solid = true;
            tChartData.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.DepthTop.Labels.Brush.Color = Color.White;
            tChartData.Axes.DepthTop.Labels.Brush.Solid = true;
            tChartData.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            tChartData.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            tChartData.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChartData.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            tChartData.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            tChartData.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            tChartData.Axes.DepthTop.Labels.Font.Size = 9;
            tChartData.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            tChartData.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
            tChartData.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            tChartData.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            tChartData.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.DepthTop.Title.Brush.Color = Color.Silver;
            tChartData.Axes.DepthTop.Title.Brush.Solid = true;
            tChartData.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            tChartData.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            tChartData.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChartData.Axes.DepthTop.Title.Font.Brush.Solid = true;
            tChartData.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            tChartData.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            tChartData.Axes.DepthTop.Title.Font.Size = 11;
            tChartData.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            tChartData.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChartData.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            tChartData.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            tChartData.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Left.Labels.Brush.Color = Color.White;
            tChartData.Axes.Left.Labels.Brush.Solid = true;
            tChartData.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            tChartData.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            tChartData.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChartData.Axes.Left.Labels.Font.Brush.Solid = true;
            tChartData.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            tChartData.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            tChartData.Axes.Left.Labels.Font.Size = 9;
            tChartData.Axes.Left.Labels.Font.SizeFloat = 9F;
            tChartData.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
            tChartData.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            tChartData.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Axes.Left.Labels.Shadow.Brush.Solid = true;
            tChartData.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Left.Title.Brush.Color = Color.Silver;
            tChartData.Axes.Left.Title.Brush.Solid = true;
            tChartData.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            tChartData.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            tChartData.Axes.Left.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChartData.Axes.Left.Title.Font.Brush.Solid = true;
            tChartData.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            tChartData.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            tChartData.Axes.Left.Title.Font.Size = 11;
            tChartData.Axes.Left.Title.Font.SizeFloat = 11F;
            tChartData.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChartData.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            tChartData.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Axes.Left.Title.Shadow.Brush.Solid = true;
            tChartData.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Right.Labels.Brush.Color = Color.White;
            tChartData.Axes.Right.Labels.Brush.Solid = true;
            tChartData.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            tChartData.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            tChartData.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChartData.Axes.Right.Labels.Font.Brush.Solid = true;
            tChartData.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            tChartData.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            tChartData.Axes.Right.Labels.Font.Size = 9;
            tChartData.Axes.Right.Labels.Font.SizeFloat = 9F;
            tChartData.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
            tChartData.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            tChartData.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Axes.Right.Labels.Shadow.Brush.Solid = true;
            tChartData.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Right.Title.Brush.Color = Color.Silver;
            tChartData.Axes.Right.Title.Brush.Solid = true;
            tChartData.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            tChartData.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            tChartData.Axes.Right.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChartData.Axes.Right.Title.Font.Brush.Solid = true;
            tChartData.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            tChartData.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            tChartData.Axes.Right.Title.Font.Size = 11;
            tChartData.Axes.Right.Title.Font.SizeFloat = 11F;
            tChartData.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChartData.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            tChartData.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Axes.Right.Title.Shadow.Brush.Solid = true;
            tChartData.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Top.Labels.Brush.Color = Color.White;
            tChartData.Axes.Top.Labels.Brush.Solid = true;
            tChartData.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            tChartData.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            tChartData.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChartData.Axes.Top.Labels.Font.Brush.Solid = true;
            tChartData.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            tChartData.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            tChartData.Axes.Top.Labels.Font.Size = 9;
            tChartData.Axes.Top.Labels.Font.SizeFloat = 9F;
            tChartData.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
            tChartData.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            tChartData.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Axes.Top.Labels.Shadow.Brush.Solid = true;
            tChartData.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Top.Title.Brush.Color = Color.Silver;
            tChartData.Axes.Top.Title.Brush.Solid = true;
            tChartData.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            tChartData.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            tChartData.Axes.Top.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChartData.Axes.Top.Title.Font.Brush.Solid = true;
            tChartData.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            tChartData.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            tChartData.Axes.Top.Title.Font.Size = 11;
            tChartData.Axes.Top.Title.Font.SizeFloat = 11F;
            tChartData.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChartData.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            tChartData.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Axes.Top.Title.Shadow.Brush.Solid = true;
            tChartData.Axes.Top.Title.Shadow.Brush.Visible = true;
            tChartData.BackColor = Color.Transparent;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Footer.Brush.Color = Color.Silver;
            tChartData.Footer.Brush.Solid = true;
            tChartData.Footer.Brush.Visible = true;
            // 
            // 
            // 
            tChartData.Footer.Font.Bold = false;
            // 
            // 
            // 
            tChartData.Footer.Font.Brush.Color = Color.Red;
            tChartData.Footer.Font.Brush.Solid = true;
            tChartData.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Footer.Font.Shadow.Brush.Solid = true;
            tChartData.Footer.Font.Shadow.Brush.Visible = true;
            tChartData.Footer.Font.Size = 8;
            tChartData.Footer.Font.SizeFloat = 8F;
            tChartData.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Footer.ImageBevel.Brush.Color = Color.LightGray;
            tChartData.Footer.ImageBevel.Brush.Solid = true;
            tChartData.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Footer.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Footer.Shadow.Brush.Solid = true;
            tChartData.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Header.Brush.Color = Color.FromArgb(192, 192, 192);
            tChartData.Header.Brush.Solid = true;
            tChartData.Header.Brush.Visible = true;
            // 
            // 
            // 
            tChartData.Header.Font.Bold = false;
            // 
            // 
            // 
            tChartData.Header.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChartData.Header.Font.Brush.Solid = true;
            tChartData.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Header.Font.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Header.Font.Shadow.Brush.Solid = true;
            tChartData.Header.Font.Shadow.Brush.Visible = true;
            tChartData.Header.Font.Size = 12;
            tChartData.Header.Font.SizeFloat = 12F;
            tChartData.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Header.ImageBevel.Brush.Color = Color.LightGray;
            tChartData.Header.ImageBevel.Brush.Solid = true;
            tChartData.Header.ImageBevel.Brush.Visible = true;
            tChartData.Header.Lines = new string[]
    {
    "Transformed time series"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Header.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            tChartData.Header.Shadow.Brush.Solid = true;
            tChartData.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Legend.Brush.Color = Color.White;
            tChartData.Legend.Brush.Solid = true;
            tChartData.Legend.Brush.Visible = true;
            tChartData.Legend.ActiveStyle = Steema.TeeChart.LegendActiveStyles.CheckBox;
            // 
            // 
            // 
            tChartData.Legend.Font.Bold = false;
            // 
            // 
            // 
            tChartData.Legend.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChartData.Legend.Font.Brush.Solid = true;
            tChartData.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Legend.Font.Shadow.Brush.Solid = true;
            tChartData.Legend.Font.Shadow.Brush.Visible = true;
            tChartData.Legend.Font.Size = 9;
            tChartData.Legend.Font.SizeFloat = 9F;
            tChartData.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Legend.ImageBevel.Brush.Color = Color.LightGray;
            tChartData.Legend.ImageBevel.Brush.Solid = true;
            tChartData.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Legend.Shadow.Brush.Color = Color.FromArgb(0, 0, 0);
            tChartData.Legend.Shadow.Brush.Solid = true;
            tChartData.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Legend.Symbol.Shadow.Brush.Solid = true;
            tChartData.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Legend.Title.Brush.Color = Color.White;
            tChartData.Legend.Title.Brush.Solid = true;
            tChartData.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            tChartData.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            tChartData.Legend.Title.Font.Brush.Color = Color.Black;
            tChartData.Legend.Title.Font.Brush.Solid = true;
            tChartData.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Legend.Title.Font.Shadow.Brush.Solid = true;
            tChartData.Legend.Title.Font.Shadow.Brush.Visible = true;
            tChartData.Legend.Title.Font.Size = 8;
            tChartData.Legend.Title.Font.SizeFloat = 8F;
            tChartData.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChartData.Legend.Title.ImageBevel.Brush.Solid = true;
            tChartData.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Legend.Title.Shadow.Brush.Solid = true;
            tChartData.Legend.Title.Shadow.Brush.Visible = true;
            tChartData.Legend.Visible = false;
            tChartData.Location = new Point(462, 96);
            tChartData.Name = "tChartData";
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Panel.Brush.Color = Color.FromArgb(255, 255, 255);
            tChartData.Panel.Brush.Solid = true;
            tChartData.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Panel.ImageBevel.Brush.Color = Color.LightGray;
            tChartData.Panel.ImageBevel.Brush.Solid = true;
            tChartData.Panel.ImageBevel.Brush.Visible = true;
            tChartData.Panel.ImageBevel.Width = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Panel.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Panel.Shadow.Brush.Solid = true;
            tChartData.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            tChartData.Printer.Margins = margins1;
            tChartData.Series.Add(line1);
            tChartData.Size = new Size(66, 192);
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.SubFooter.Brush.Color = Color.Silver;
            tChartData.SubFooter.Brush.Solid = true;
            tChartData.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            tChartData.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            tChartData.SubFooter.Font.Brush.Color = Color.Red;
            tChartData.SubFooter.Font.Brush.Solid = true;
            tChartData.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
            tChartData.SubFooter.Font.Shadow.Brush.Solid = true;
            tChartData.SubFooter.Font.Shadow.Brush.Visible = true;
            tChartData.SubFooter.Font.Size = 8;
            tChartData.SubFooter.Font.SizeFloat = 8F;
            tChartData.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
            tChartData.SubFooter.ImageBevel.Brush.Solid = true;
            tChartData.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.SubFooter.Shadow.Brush.Color = Color.DarkGray;
            tChartData.SubFooter.Shadow.Brush.Solid = true;
            tChartData.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.SubHeader.Brush.Color = Color.FromArgb(192, 192, 192);
            tChartData.SubHeader.Brush.Solid = true;
            tChartData.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            tChartData.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            tChartData.SubHeader.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChartData.SubHeader.Font.Brush.Solid = true;
            tChartData.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
            tChartData.SubHeader.Font.Shadow.Brush.Solid = true;
            tChartData.SubHeader.Font.Shadow.Brush.Visible = true;
            tChartData.SubHeader.Font.Size = 12;
            tChartData.SubHeader.Font.SizeFloat = 12F;
            tChartData.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
            tChartData.SubHeader.ImageBevel.Brush.Solid = true;
            tChartData.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.SubHeader.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            tChartData.SubHeader.Shadow.Brush.Solid = true;
            tChartData.SubHeader.Shadow.Brush.Visible = true;
            tChartData.TabIndex = 14;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Walls.Back.Brush.Color = Color.Silver;
            tChartData.Walls.Back.Brush.Solid = true;
            tChartData.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
            tChartData.Walls.Back.ImageBevel.Brush.Solid = true;
            tChartData.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Walls.Back.Shadow.Brush.Solid = true;
            tChartData.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Walls.Bottom.Brush.Color = Color.White;
            tChartData.Walls.Bottom.Brush.Solid = true;
            tChartData.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
            tChartData.Walls.Bottom.ImageBevel.Brush.Solid = true;
            tChartData.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Walls.Bottom.Shadow.Brush.Solid = true;
            tChartData.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Walls.Left.Brush.Color = Color.LightYellow;
            tChartData.Walls.Left.Brush.Solid = true;
            tChartData.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
            tChartData.Walls.Left.ImageBevel.Brush.Solid = true;
            tChartData.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Walls.Left.Shadow.Brush.Solid = true;
            tChartData.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Walls.Right.Brush.Color = Color.LightYellow;
            tChartData.Walls.Right.Brush.Solid = true;
            tChartData.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
            tChartData.Walls.Right.ImageBevel.Brush.Solid = true;
            tChartData.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
            tChartData.Walls.Right.Shadow.Brush.Solid = true;
            tChartData.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChartData.Zoom.Brush.Color = Color.FromArgb(150, 173, 216, 230);
            tChartData.Zoom.Brush.Solid = true;
            tChartData.Zoom.Brush.Visible = true;
            tChartData.AfterDraw += tChartData_AfterDraw;
            tChartData.BeforeDrawSeries += tChartData_BeforeDrawSeries;
            // 
            // line1
            // 
            // 
            // 
            // 
            line1.AreaBrush.Color = Color.White;
            line1.AreaBrush.Solid = true;
            line1.AreaBrush.Visible = false;
            // 
            // 
            // 
            line1.Brush.Color = Color.FromArgb(119, 153, 214);
            line1.Brush.Solid = true;
            line1.Brush.Visible = true;
            line1.Color = Color.FromArgb(119, 153, 214);
            line1.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            line1.Legend.Brush.Color = Color.White;
            line1.Legend.Brush.Solid = true;
            line1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            line1.Legend.Font.Bold = false;
            // 
            // 
            // 
            line1.Legend.Font.Brush.Color = Color.Black;
            line1.Legend.Font.Brush.Solid = true;
            line1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            line1.Legend.Font.Shadow.Brush.Solid = true;
            line1.Legend.Font.Shadow.Brush.Visible = true;
            line1.Legend.Font.Size = 8;
            line1.Legend.Font.SizeFloat = 8F;
            line1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            line1.Legend.ImageBevel.Brush.Color = Color.LightGray;
            line1.Legend.ImageBevel.Brush.Solid = true;
            line1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line1.Legend.Shadow.Brush.Color = Color.DarkGray;
            line1.Legend.Shadow.Brush.Solid = true;
            line1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line1.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            line1.Marks.Brush.Solid = true;
            line1.Marks.Brush.Visible = true;
            // 
            // 
            // 
            line1.Marks.Font.Bold = false;
            // 
            // 
            // 
            line1.Marks.Font.Brush.Color = Color.Black;
            line1.Marks.Font.Brush.Solid = true;
            line1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line1.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            line1.Marks.Font.Shadow.Brush.Solid = true;
            line1.Marks.Font.Shadow.Brush.Visible = true;
            line1.Marks.Font.Size = 8;
            line1.Marks.Font.SizeFloat = 8F;
            line1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            line1.Marks.ImageBevel.Brush.Color = Color.LightGray;
            line1.Marks.ImageBevel.Brush.Solid = true;
            line1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            line1.Marks.Pen.Color = Color.FromArgb(107, 138, 193);
            // 
            // 
            // 
            // 
            // 
            // 
            line1.Marks.Shadow.Brush.Color = Color.Gray;
            line1.Marks.Shadow.Brush.Solid = true;
            line1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line1.Marks.Symbol.Brush.Color = Color.White;
            line1.Marks.Symbol.Brush.Solid = true;
            line1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line1.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            line1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            line1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line1.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            line1.Marks.Symbol.Shadow.Brush.Solid = true;
            line1.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line1.Pointer.Brush.Color = Color.Red;
            line1.Pointer.Brush.Solid = true;
            line1.Pointer.Brush.Visible = true;
            line1.Title = "line1";
            // 
            // 
            // 
            line1.XValues.DataMember = "X";
            line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            line1.XValues.Value = new double[]
    {
    0D,
    1D,
    2D,
    3D,
    4D,
    5D,
    6D,
    7D,
    8D,
    9D,
    10D,
    11D,
    12D,
    13D,
    14D,
    15D,
    16D,
    17D,
    18D,
    19D,
    20D,
    21D,
    22D,
    23D,
    24D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D
    };
            // 
            // 
            // 
            line1.YValues.DataMember = "Y";
            line1.YValues.Value = new double[]
    {
    50D,
    81D,
    22D,
    28D,
    46D,
    35D,
    100D,
    12D,
    66D,
    3D,
    44D,
    165D,
    157D,
    202D,
    140D,
    149D,
    268D,
    235D,
    349D,
    283D,
    339D,
    384D,
    352D,
    264D,
    312D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D
    };
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(numericUpDownDiff);
            groupBox6.Controls.Add(label6);
            groupBox6.Controls.Add(checkBoxRemoveMean);
            groupBox6.Controls.Add(buttonLoad);
            groupBox6.FlatStyle = FlatStyle.Flat;
            groupBox6.Location = new Point(14, 96);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(220, 123);
            groupBox6.TabIndex = 12;
            groupBox6.TabStop = false;
            groupBox6.Text = "Time series";
            // 
            // numericUpDownDiff
            // 
            numericUpDownDiff.Location = new Point(125, 81);
            numericUpDownDiff.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownDiff.Name = "numericUpDownDiff";
            numericUpDownDiff.Size = new Size(51, 23);
            numericUpDownDiff.TabIndex = 3;
            numericUpDownDiff.ValueChanged += numericUpDownDiff_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 84);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 2;
            label6.Text = "# of differencing";
            // 
            // checkBoxRemoveMean
            // 
            checkBoxRemoveMean.Checked = true;
            checkBoxRemoveMean.CheckState = CheckState.Checked;
            checkBoxRemoveMean.FlatStyle = FlatStyle.Flat;
            checkBoxRemoveMean.Location = new Point(10, 59);
            checkBoxRemoveMean.Name = "checkBoxRemoveMean";
            checkBoxRemoveMean.Size = new Size(124, 21);
            checkBoxRemoveMean.TabIndex = 1;
            checkBoxRemoveMean.Text = "Remove mean";
            checkBoxRemoveMean.CheckedChanged += checkBoxRemoveMean_CheckedChanged;
            // 
            // buttonLoad
            // 
            buttonLoad.FlatStyle = FlatStyle.Flat;
            buttonLoad.Location = new Point(7, 23);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(90, 29);
            buttonLoad.TabIndex = 0;
            buttonLoad.Text = "&Load";
            buttonLoad.Click += buttonLoad_Click;
            // 
            // wizardPageModel
            // 
            wizardPageModel.Controls.Add(groupBox2);
            wizardPageModel.Controls.Add(groupBox9);
            wizardPageModel.Controls.Add(groupBox10);
            wizardPageModel.Controls.Add(groupBox11);
            wizardPageModel.Controls.Add(groupBox12);
            wizardPageModel.Description = "Define ARMA model settings";
            wizardPageModel.Location = new Point(0, 0);
            wizardPageModel.Name = "wizardPageModel";
            wizardPageModel.Size = new Size(540, 297);
            wizardPageModel.TabIndex = 14;
            wizardPageModel.Title = "Step 2: ARMA model";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox4);
            groupBox2.Location = new Point(278, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(197, 98);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Preliminary estimation";
            groupBox2.Visible = false;
            // 
            // comboBox4
            // 
            comboBox4.Items.AddRange(new object[] { "Yule-Walker", "Burg", "Fixed" });
            comboBox4.Location = new Point(7, 23);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(183, 23);
            comboBox4.TabIndex = 0;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(comboBox3);
            groupBox9.Location = new Point(278, 96);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(197, 98);
            groupBox9.TabIndex = 8;
            groupBox9.TabStop = false;
            groupBox9.Text = "Preliminary estimation";
            groupBox9.Visible = false;
            // 
            // comboBox3
            // 
            comboBox3.Items.AddRange(new object[] { "User supplied", "Yule-Walker", "Burg", "Innovations", "Hannah-Rissanen" });
            comboBox3.Location = new Point(7, 23);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(183, 23);
            comboBox3.TabIndex = 0;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            comboBox3.SelectedItem = comboBox3.Items[1];
            comboBox3.SelectedIndex = 1;
            
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(label10);
            groupBox10.Controls.Add(button1);
            groupBox10.Controls.Add(button2);
            groupBox10.Location = new Point(506, 96);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(233, 98);
            groupBox10.TabIndex = 7;
            groupBox10.TabStop = false;
            groupBox10.Text = "Initial values";
            groupBox10.Visible = false;
            // 
            // label10
            // 
            label10.Location = new Point(128, 27);
            label10.Name = "label10";
            label10.Size = new Size(93, 62);
            label10.TabIndex = 6;
            label10.Text = "label10";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(7, 59);
            button1.Name = "button1";
            button1.Size = new Size(114, 28);
            button1.TabIndex = 1;
            button1.Text = "MA coefficients";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(7, 23);
            button2.Name = "button2";
            button2.Size = new Size(114, 29);
            button2.TabIndex = 0;
            button2.Text = "AR coefficients";
            button2.Click += button2_Click;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(checkBoxMLE);
            groupBox11.Location = new Point(14, 220);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(240, 89);
            groupBox11.TabIndex = 6;
            groupBox11.TabStop = false;
            groupBox11.Text = "Estimation";
            // 
            // checkBoxMLE
            // 
            checkBoxMLE.FlatStyle = FlatStyle.Flat;
            checkBoxMLE.Location = new Point(11, 34);
            checkBoxMLE.Name = "checkBoxMLE";
            checkBoxMLE.Size = new Size(181, 21);
            checkBoxMLE.TabIndex = 0;
            checkBoxMLE.Text = "Do MLE estimation";
            checkBoxMLE.Checked = true;
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(numericUpDown1);
            groupBox12.Controls.Add(label11);
            groupBox12.Controls.Add(numericUpDown2);
            groupBox12.Controls.Add(label12);
            groupBox12.Location = new Point(14, 96);
            groupBox12.Name = "groupBox12";
            groupBox12.Size = new Size(240, 98);
            groupBox12.TabIndex = 5;
            groupBox12.TabStop = false;
            groupBox12.Text = "Order";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(74, 62);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(70, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            numericUpDown1.Value = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 64);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 2;
            label11.Text = "MA order";
            
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(73, 30);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(70, 23);
            numericUpDown2.TabIndex = 1;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            numericUpDown2.Value = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 32);
            label12.Name = "label12";
            label12.Size = new Size(53, 15);
            label12.TabIndex = 0;
            label12.Text = "AR order";
            // 
            // wizardPageForecasts
            // 
            wizardPageForecasts.Controls.Add(groupBox13);
            wizardPageForecasts.Controls.Add(numericUpDownACFLag);
            wizardPageForecasts.Controls.Add(label13);
            wizardPageForecasts.Controls.Add(numericUpDownForNum);
            wizardPageForecasts.Controls.Add(label14);
            wizardPageForecasts.Description = "Define forecasts options";
            wizardPageForecasts.Location = new Point(78, 57);
            wizardPageForecasts.Name = "wizardPageForecasts";
            wizardPageForecasts.Size = new Size(667, 416);
            wizardPageForecasts.TabIndex = 15;
            wizardPageForecasts.Title = "Step 3: Forecasts";
            // 
            // groupBox13
            // 
            groupBox13.Controls.Add(checkBoxIntegrate);
            groupBox13.Controls.Add(checkBoxAddMean);
            groupBox13.FlatStyle = FlatStyle.Flat;
            groupBox13.Location = new Point(18, 188);
            groupBox13.Name = "groupBox13";
            groupBox13.Size = new Size(251, 106);
            groupBox13.TabIndex = 9;
            groupBox13.TabStop = false;
            groupBox13.Text = "Transformation";
            // 
            // checkBoxIntegrate
            // 
            checkBoxIntegrate.Checked = true;
            checkBoxIntegrate.CheckState = CheckState.Checked;
            checkBoxIntegrate.Enabled = false;
            checkBoxIntegrate.Location = new Point(7, 64);
            checkBoxIntegrate.Name = "checkBoxIntegrate";
            checkBoxIntegrate.Size = new Size(223, 21);
            checkBoxIntegrate.TabIndex = 1;
            checkBoxIntegrate.Text = "Forecast the undifferenced data";
            // 
            // checkBoxAddMean
            // 
            checkBoxAddMean.Checked = true;
            checkBoxAddMean.CheckState = CheckState.Checked;
            checkBoxAddMean.Location = new Point(7, 36);
            checkBoxAddMean.Name = "checkBoxAddMean";
            checkBoxAddMean.Size = new Size(175, 21);
            checkBoxAddMean.TabIndex = 0;
            checkBoxAddMean.Text = "Add mean to forecasts";
            // 
            // numericUpDownACFLag
            // 
            numericUpDownACFLag.Location = new Point(108, 138);
            numericUpDownACFLag.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numericUpDownACFLag.Name = "numericUpDownACFLag";
            numericUpDownACFLag.Size = new Size(60, 23);
            numericUpDownACFLag.TabIndex = 8;
            numericUpDownACFLag.Value = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numericUpDownACFLag.ValueChanged += numericUpDownACFLag_ValueChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(48, 138);
            label13.Name = "label13";
            label13.Size = new Size(48, 15);
            label13.TabIndex = 7;
            label13.Text = "ACF max lag";
            // 
            // numericUpDownForNum
            // 
            numericUpDownForNum.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownForNum.Location = new Point(108, 97);
            numericUpDownForNum.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numericUpDownForNum.Name = "numericUpDownForNum";
            numericUpDownForNum.Size = new Size(60, 23);
            numericUpDownForNum.TabIndex = 6;
            numericUpDownForNum.Value = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDownForNum.ValueChanged += numericUpDownForNum_ValueChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(14, 100);
            label14.Name = "label14";
            label14.Size = new Size(78, 15);
            label14.TabIndex = 5;
            label14.Text = "# of forecasts";
            // 
            // groupBoxInitMA
            // 
            groupBoxInitMA.Controls.Add(comboBox2);
            groupBoxInitMA.Location = new Point(218, 17);
            groupBoxInitMA.Name = "groupBoxInitMA";
            groupBoxInitMA.Size = new Size(164, 80);
            groupBoxInitMA.TabIndex = 4;
            groupBoxInitMA.TabStop = false;
            groupBoxInitMA.Text = "Preliminary estimation";
            groupBoxInitMA.Visible = false;
            // 
            // comboBox2
            // 
            comboBox2.Items.AddRange(new object[] { "User supplied", "Yule-Walker","Burg", "Innovations", "Hannah-Rissanen" });
            comboBox2.Location = new Point(6, 19);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(152, 23);
            comboBox2.TabIndex = 0;
            comboBox2.SelectedIndex = 1;
            // 
            // groupBoxEditPhiTheta
            // 
            groupBoxEditPhiTheta.Controls.Add(label8);
            groupBoxEditPhiTheta.Controls.Add(buttonEditMA);
            groupBoxEditPhiTheta.Controls.Add(buttonEditAR);
            groupBoxEditPhiTheta.Location = new Point(418, 17);
            groupBoxEditPhiTheta.Name = "groupBoxEditPhiTheta";
            groupBoxEditPhiTheta.Size = new Size(194, 80);
            groupBoxEditPhiTheta.TabIndex = 2;
            groupBoxEditPhiTheta.TabStop = false;
            groupBoxEditPhiTheta.Text = "Initial values";
            groupBoxEditPhiTheta.Visible = false;
            // 
            // label8
            // 
            label8.Location = new Point(107, 22);
            label8.Name = "label8";
            label8.Size = new Size(77, 50);
            label8.TabIndex = 6;
            label8.Text = "label8";
            // 
            // buttonEditMA
            // 
            buttonEditMA.FlatStyle = FlatStyle.Flat;
            buttonEditMA.Location = new Point(6, 48);
            buttonEditMA.Name = "buttonEditMA";
            buttonEditMA.Size = new Size(95, 23);
            buttonEditMA.TabIndex = 1;
            buttonEditMA.Text = "MA coefficients";
            // 
            // buttonEditAR
            // 
            buttonEditAR.FlatStyle = FlatStyle.Flat;
            buttonEditAR.Location = new Point(6, 19);
            buttonEditAR.Name = "buttonEditAR";
            buttonEditAR.Size = new Size(95, 23);
            buttonEditAR.TabIndex = 0;
            buttonEditAR.Text = "AR coefficients";
            // 
            // groupBox7
            // 
            groupBox7.Location = new Point(8, 118);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(200, 72);
            groupBox7.TabIndex = 1;
            groupBox7.TabStop = false;
            groupBox7.Text = "Estimation";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(label7);
            groupBox8.Controls.Add(label9);
            groupBox8.Location = new Point(8, 17);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(200, 80);
            groupBox8.TabIndex = 0;
            groupBox8.TabStop = false;
            groupBox8.Text = "Order";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 52);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 2;
            label7.Text = "MA order";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 26);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 0;
            label9.Text = "AR order";
            // 
            // comboBox1
            // 
            comboBox1.Items.AddRange(new object[] { "Yule-Walker", "Burg", "User supplied" });
            comboBox1.Location = new Point(6, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(152, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndex = 0; 
            // 
            // ARMAWizard
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(745, 521);
            Name = "ARMAWizard";
            Load += ARMAWizard_Load;
            wizard.ResumeLayout(false);
            wizardPageReport.ResumeLayout(false);
            wizardPageReport.PerformLayout();
            wizardPageFormat.ResumeLayout(false);
            wizardPageFormat.PerformLayout();
            wizardPageTimeSeries.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((ISupportInitialize)numericUpDownDiff).EndInit();
            wizardPageModel.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox10.ResumeLayout(false);
            groupBox11.ResumeLayout(false);
            groupBox12.ResumeLayout(false);
            groupBox12.PerformLayout();
            ((ISupportInitialize)numericUpDown1).EndInit();
            ((ISupportInitialize)numericUpDown2).EndInit();
            wizardPageForecasts.ResumeLayout(false);
            wizardPageForecasts.PerformLayout();
            groupBox13.ResumeLayout(false);
            ((ISupportInitialize)numericUpDownACFLag).EndInit();
            ((ISupportInitialize)numericUpDownForNum).EndInit();
            groupBoxInitMA.ResumeLayout(false);
            groupBoxEditPhiTheta.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion


        public TVec TimeSeries
        {
            get { return (TVec)timeseries; }
        }
       

        #region GUI
        private void RefreshChart()
        {
            // recalculate lb and ub for acf and pacf chart
            if (!radioButtonTS.Checked)
            {
                chartucl = Probabilities.NormalCDFInv(1.0 - 0.5 * Alpha, 0, 1) / Math.Sqrt(data.Length);
                chartlcl = -chartucl;
            }
            tChartData.Series.Clear();
            tChartData.Legend.Visible = false;
            tChartData.Axes.Bottom.Visible = false;
            tChartData.Axes.Left.Automatic = true;
            tChartData.Axes.Bottom.Automatic = true;
            Vector v1 = new Vector(0);
            Vector v2 = new Vector(0);

            tChartData.Series.Add(new Steema.TeeChart.Styles.Line(tChartData.Chart));

            if (radioButtonTS.Checked) // time series
            {
                tChartData.Axes.Bottom.Visible = true;
                tChartData.Header.Text = "Transformed time series";
                MtxVecTee.DrawValues(data, tChartData.Series[0], 0, 1, false);
            }
            else if (radioButtonACF.Checked) // acf
            {
                tChartData.Axes.Left.SetMinMax(-1, 1);
                tChartData.Axes.Bottom.AutomaticMinimum = false;
                tChartData.Axes.Bottom.Minimum = -1;
                tChartData.Header.Text = "Transformed time series ACF";
                StatTimeSerAnalysis.ACF(data, v1, -1);
                MtxVecTee.DrawValues(v1, tChartData.Series[0], 0, 1, false);
            }
            else if (radioButtonPACF.Checked) // pacf
            {
                tChartData.Axes.Left.SetMinMax(-1, 1);
                tChartData.Axes.Bottom.AutomaticMinimum = false;
                tChartData.Axes.Bottom.Minimum = -1;
                tChartData.Header.Text = "Transformed time series PACF";
                StatTimeSerAnalysis.ACF(data, v1, -1);
                StatTimeSerAnalysis.PACF(v1, v2);
                MtxVecTee.DrawValues(v2, tChartData.Series[0], 0, 1, false);
            }
        }

        /// <summary>
        /// Collects time series and transformed time series statistics
        /// </summary>
        private void InfoReport()
        {
            double sd = timeseries.StdDev();
            string st = "";
            st = "size:\t" + timeseries.Length.ToString() + "\n";
            st += "mean:\t" + Math387.FormatSample(FmtString, timeseries.Mean()) + "\n";
            st += "std.dev:\t" + Math387.FormatSample(FmtString, sd) + "\n";
            st += "variance:\t" + Math387.FormatSample(FmtString, sd * sd) + "\n";
            labelUnTrStat.Text = st;

            TransformTimeSeries();
            numericUpDownACFLag.Maximum = data.Length - 2;
            // transformed series ...
            sd = data.StdDev();
            st = "size:\t" + data.Length.ToString() + "\n";
            st += "mean:\t" + Math387.FormatSample(FmtString, data.Mean()) + "\n";
            st += "std.dev:\t" + Math387.FormatSample(FmtString, sd) + "\n";
            st += "variance:\t" + Math387.FormatSample(FmtString, sd * sd) + "\n";
            labelTrStat.Text = st;
            // draw transformed time series
            RefreshChart();
        }

        private void RefreshModelControls()
        {
            groupBox2.Visible = ((p > 0) && (q == 0));
            groupBox9.Visible = (q > 0);
            groupBox10.Visible = (armainit == TcfInitMethod.cfInitFixed) && ((p > 0) || (q > 0));
            label10.Visible = (armainit == TcfInitMethod.cfInitFixed) && ((p > 0) || (q > 0));
            if (label10.Visible)
            {
                string st = "Model:\n";
                if (p > 0)
                    if (StatTimeSerAnalysis.CheckARMACoeffs(phi, true)) st += "causal\n"; else st += "NOT causal\n";
                if (q > 0)
                    if (StatTimeSerAnalysis.CheckARMACoeffs(theta, false)) st += "invertible"; else st += "NOT invertible";

                label10.Text = st;
            }
        }

        private void RefreshWizardControls()
        {
            if (wizard.SelectedPage == wizardPageTimeSeries) wizard.NextEnabled = timeseries.Length > 0;
            else if (wizard.SelectedPage == wizardPageModel) wizard.NextEnabled = (p > 0) || (q > 0);
        }

        #endregion

        #region Calculations

        private void TransformTimeSeries()
        {
            data.Copy(timeseries);
            // differenciate, if needed
            if (d > 0)
                for (int i = 1; i <= d; i++) data.Difference(1);
            dMean = data.Mean();
            // remove mean, if specified
            //if (checkBoxRemoveMean.Checked) data -= dMean;
        }

        #endregion

        private void wizard_AfterSwitchPages(object sender, Dew.Math.Controls.Wizard.AfterSwitchPagesEventArgs e)
        {
            Dew.Math.Controls.WizardPage newpage = wizard.Pages[e.NewIndex];
            if (newpage == wizardPageReport)
            {
                TextReport();
                wizard.CancelEnabled = false;
            }
            else if (newpage == wizardPageTimeSeries)
            {
                wizard.NextEnabled = timeseries.Length > 0;
            }
            else if (newpage == wizardPageModel)
            {
                wizard.NextEnabled = (p > 0) || (q > 0);
            }
            else wizard.CancelEnabled = true;

        }

        private void ARMAWizard_Load(object sender, EventArgs e)
        {
            wizardPageWelcome.Description = "The ARMA/ARIMA forecasting is often used to forecast time series "
                + "of medium (N over 50) to long lengths.  It requires the forecaster to be highly trained "
                + "in selecting the appropriate model.\n\n"
                + "ARMA Wizard performs the following steps:\n\n"
                + "+ Checks if time series is \"aproximately\" stationary. If this is "
                + "not the case, it tries using differencing operator to make it stationary.\n"
                + "+ Removes mean from transformed stationary time series.\n"
                + "+ Selects appropriate AR and MA degrees.\n"
                + "+ If needed, calculates initial estimates for ARMA model by using "
                + "Yule-Walker, Burg, Innovations or Hannah-Rissanen algorithm.\n"
                + "+ Uses MLE to estimate \"best\" coefficients for ARMA model.\n"
                + "+ Forecasts time series values by using calculated ARMA model coefficients.\n";

            // user supplied

            comboBox3.SelectedIndex = 1;

            InfoReport();

        }

        private void checkBoxRemoveMean_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxAddMean.Enabled = checkBoxRemoveMean.Checked;
            InfoReport();
        }

        private void numericUpDownDiff_ValueChanged(object sender, EventArgs e)
        {
            d = (int)numericUpDownDiff.Value;
            checkBoxIntegrate.Enabled = (d > 0);
            InfoReport();
        }

        private void radioButtonTS_CheckedChanged(object sender, EventArgs e)
        {
            RefreshChart();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                timeseries.LoadFromFile(openFileDialog1.FileName);
                timeseries.Caption = openFileDialog1.FileName;
                RefreshWizardControls();
                InfoReport();
            }
        }

        private void tChartData_BeforeDrawSeries(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
        {
            if (!tChartData.Axes.Bottom.Visible)
            {
                int ypos = tChartData.Axes.Left.CalcYPosValue(0.0);
                tChartData.Axes.Bottom.Draw(ypos + 10, ypos + 15, ypos, false);
            }
        }

        private void tChartData_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
        {
            if (!radioButtonTS.Checked) // acf or pacf
            {
                Rectangle r = tChartData.Chart.ChartRect;
                int ypos = tChartData.Axes.Left.CalcYPosValue(chartucl);
                g.Pen.Style = Steema.TeeChart.Drawing.DashStyle.Dot;
                g.Pen.Width = 2;
                g.Pen.Color = Color.Blue;
                g.ClipRectangle(r);
                g.Line(r.Left, ypos, r.Right, ypos);
                g.Font.Bold = true;
                g.Font.Color = Color.Blue;
                g.TextOut(r.Right - 80, ypos - 15, Math387.FormatSample("0.00%", 100.0 * (1.0 - Alpha)) + " CI");
                ypos = tChartData.Axes.Left.CalcYPosValue(chartlcl);
                g.Line(r.Left, ypos, r.Right, ypos);
                g.TextOut(r.Right - 80, ypos, Math387.FormatSample("0.00%", 100.0 * (1.0 - Alpha)) + " CI");
                g.UnClip();
            }
        }

        private void textBoxAlpha_TextChanged(object sender, EventArgs e)
        {
            RefreshChart();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            p = (int)numericUpDown2.Value;
            phi.Length = p;
            phi.SetZero();

            phiInit.Size(phi);
            phiInit.SetZero();

            RefreshModelControls();
            RefreshWizardControls();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            q = (int)numericUpDown1.Value;
            theta.Length = q;

            thetaInit.Size(theta);
            thetaInit.SetZero();

            RefreshModelControls();
            RefreshWizardControls();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0: 
                    armainit = TcfInitMethod.cfInitFixed; break;
                case 1:
                    armainit = TcfInitMethod.cfInitYW; break;
                case 2:
                    armainit = TcfInitMethod.cfInitBurg; break;
                case 3: // Innovations
                    armainit = TcfInitMethod.cfInitInno; break;
                case 4:
                    armainit = TcfInitMethod.cfInitHannah; break;
                default: // user supplied
                    armainit = TcfInitMethod.cfInitFixed; break;
            }
            RefreshModelControls();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MtxVecEdit.ViewValues(phiInit, "AR coefficients", true, false, true);
            RefreshModelControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MtxVecEdit.ViewValues(thetaInit, "MA coefficients", true, false, true);
            RefreshModelControls();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.SelectedIndex)
            {
                case 0: // Yule-Walker
                    armainit = TcfInitMethod.cfInitYW; break;
                case 1: // Burg
                    armainit = TcfInitMethod.cfInitBurg; break;
                default: // user supplied
                    armainit = TcfInitMethod.cfInitFixed; break;
            }
            RefreshModelControls();
        }

        private void numericUpDownForNum_ValueChanged(object sender, EventArgs e)
        {
            forper = (int)numericUpDownForNum.Value;
        }

        private void numericUpDownACFLag_ValueChanged(object sender, EventArgs e)
        {
            maxLag = (int)numericUpDownACFLag.Value;
        }

        private void wizardPageFormat_Click(object sender, EventArgs e)
        {

        }

        private void wizard_Load(object sender, EventArgs e)
        {

        }
    }
}

