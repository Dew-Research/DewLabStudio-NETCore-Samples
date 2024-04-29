using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace StatsMasterDemo
{
	/// <summary>
	/// Summary description for WhatsNew.
	/// </summary>
	public class WhatsNewForm : System.Windows.Forms.Form {
		private System.Windows.Forms.RichTextBox richTextBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public WhatsNewForm() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(444, 395);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // WhatsNewForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(444, 395);
            this.Controls.Add(this.richTextBox1);
            this.Name = "WhatsNewForm";
            this.Text = "WhatsNew";
            this.Load += new System.EventHandler(this.WhatsNewForm_Load);
            this.ResumeLayout(false);

		}
		#endregion
		private void Add(String s) {
			richTextBox1.SelectedText = s + "\n";
		}

		private void WhatsNewForm_Load(object sender, System.EventArgs e) {
			richTextBox1.Clear();

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);
            Add("Release 6.2.0 List of changes");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Support for Visual Studio 2022 v17.9.3");
            Add("Support for .NET Core 7.0 and 8.0");
            Add("Support for TeeChart.NET v4.2024.3.15");
            Add("Bug fix for MannWhitneyTest");
            Add("Rewritten the ARMA MLE fitting and the forecasting function used by ARIMA.");
            Add("Added an example for ARIMA fitting with trend decomposition.");
            Add("Bug fix for Stepwise multiple regression when running with enabled assertions (debug mode).");
            Add("Fixed a bug when fitting parameters of the Fisher random distribution.");
            Add("Added vectorized version of the Fisher PDF.");
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionIndent = 0;
            Add("");

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);
            Add("Release 6.0.8 List of changes");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Support for combined (either double or single) precision where meaningfull with MtxVec v6.");
            Add("Added new CDF and Inverse CDF for Studentized Range distribution.");
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionIndent = 0;
            Add("");

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);
            Add("List of new features in Stats Master v5:");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Added new faster overload for histogram computation");
            Add("Fixed double and tripple exponential smoothing");
            Add("Fixed a potential round off error with two-level full factorial design");
            Add("Support for VS 2013.NET and newer version of TeeChart.");
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionIndent = 0;
            Add("");


            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);
            Add("List of new features in Stats Master v4.0:");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Support for VS 2010.NET");
            Add("Support for TeeChart 2010.NET");
            Add("Fixed GrubbsTest");
            Add("Fixed bug with RegressTest and Constant param");           
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionIndent = 0;
            Add("");

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);
            Add("List of new features in Stats Master v3.5:");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Added: logistic and Maxwell distribution random generators.");
            Add("Fixed: Hypothesis tests - hypothesis result when test statistics was Inf or Nan.");
            Add("Several changes in Covatiance and CorrCoef implementation (vectorized).");
            Add("Fixed: several bugs in A-D test.");
            Add("Fixed: GOF Kolmogorov - when two samples with different sizes were compared.");
            Add("Percentile: Added overload when multiple percentiles were needed from the same dataset.");
            Add("Added: Maxwell, Logistic and Student-T distribution parameter(s) estimation routines.");
            Add("Added: Mode routine.");
            Add("Added: Lilliefors test for normal distribution.");
            Add("Added: TMtxANOVA direct support for dataGrid control (.NET)");
            Add("Fixed: Q-Q plot when plotting only one dataset.");
            Add("Added: More options for box plot in 3D.");
            Add("Completely rewritten help files. Code declaration and several xamples for C# added.");
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionIndent = 0;
            Add("");

            
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);
            Add("List of new features in Stats Master v3.1:");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Distributions: Improved random generators.");
            Add("Distributions: Added Gumbel, Triangular, Erlang distribution random number generators.");
            Add("Distributions: Changed implementation for all random generators to allow either use of MtxVec.Random.dll or \"inhouse\" simplified random generators.");
            Add("Distributions: Added Chi-Squared distribution parameter estimate.");
            Add("Distributions: Added Cauchy distribution MLE parameter estimates.");
            Add("Distributions: Added Erlang distribution parameter estimates.");
            Add("Distributions: Added Negative Binomial distribution parameter estimates.");
            Add("Distributions: Added Laplace distribution MLE parameter estimates.");
            Add("Regression: Expanded several regression routines.");
            Add("Regression: Added PRESS and R2 functions.");
            Add("Regression: ML regresion now support LQR, SVD or LU solving method.");
            Add("GOF: Added support for ChiSquare, Erlang and Laplace distribution.");
			Add("GOF: Anderson-Darling normality test now returns correct P values.");
			Add("Dew Stats Demo now utilizes new wizards.");
			Add("Several new examples added.");
            Add("All TeeChart code moved to separate assembly (Dew.Stats.Tee). Assembly can be compiled against any TeeChart .NET version.");
            Add("Improved documentation and help files.");
            Add("Support for HTML2 help file system.");
            Add("Several minor bug fixes.");

            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionIndent = 0;
			Add("");
			richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,11,FontStyle.Bold);
			richTextBox1.SelectionColor = Color.FromArgb(51,104,196);
			Add("List of new features in Stats Master v2.1:");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.SelectionIndent = 10;
			Add("Support for .NET platform. Single source code compiles " +
				"on .NET and W32.");
            Add("Several new routines for handling/manipulating time series.");
            Add("New tests for normal distribution, detecting outliers, etc.");
            Add("Stats Master now compiles and installs under VS2003 and VS2005.");
            Add("Added Kolmogorov-Smirnov goodnes of fit test (one and two sample).");
            Add("Added empirical cumulative distribution function.");
            Add("Chi2 GOF test: added support for log-normal and uniform distribution.");
            Add("Added ZScores for vector.");
            Add("Added Bera-Jarque test of composite normality.");
            Add("Added Grubbs's test for outliers.");
            Add("Several bugs in routine Histogram fixed.");
            Add("Added single moving average function.");
            Add("Added sigle, double and triple exponential smoothing routines.");
            Add("Added sigle, double and triple exponential forecasting routines.");
            Add("Added ARMA/ARIMA simulation routines.");
            Add("Added ARMA/ARIMA estimation (MLE) routines.");
            Add("Added ARMA/ARIMA forecasting routines.");
            Add("Added Yule-Walker AR coefficients estimation.");
            Add("Added Burg AR coefficients estimation.");
            Add("Added Innovations ARMA and MA coefficients estimation.");
            Add("Added innovations and Durbin-Levinson algorithms.");
            Add("Added ARAR model fitting and forecasting routines.");
            Add("Added Box-Cox and inverse Box-Cox transformation.");
            Add("Added rational model fit.");
            Add("Added logistic model fit.");
            Add("Added Poisson regression.");
            Add("Added tMtxBinaryTest component for performing one and two test(s) binary diagnostic test.");
            Add("Added several new examples demonstrating time series analysis routines.");
            Add("Fixed several bugs in examples.");
            richTextBox1.SelectionBullet = false;
			richTextBox1.SelectionIndent = 0;

		}
	}
}
