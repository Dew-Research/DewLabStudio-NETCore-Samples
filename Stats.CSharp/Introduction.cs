using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Reflection;

namespace StatsMasterDemo
{
	/// <summary>
	/// Summary description for Introduction.
	/// </summary>
	public class IntroductionForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public IntroductionForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
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
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Stats Master 6";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(0, 79);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(601, 373);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // IntroductionForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(601, 452);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "IntroductionForm";
            this.Text = "Introduction";
            this.Load += new System.EventHandler(this.IntroductionForm_Load);
            this.ResumeLayout(false);

		}
		#endregion

		private void IntroductionForm_Load(object sender, System.EventArgs e) {
			richTextBox1.Clear();
			richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,11,FontStyle.Bold);
			richTextBox1.SelectionColor = Color.FromArgb(51,104,195);

            richTextBox1.SelectedText = "Welcome to Stats Master for Delphi and .NET platforms\n";
			richTextBox1.SelectedText = "\n";
            richTextBox1.SelectedText = "Stats Master is a (c) Dew Math Add-On library with many statistical and mathematical routines. It comes with:\n";
            richTextBox1.SelectedText = "\n";
			richTextBox1.SelectionBullet = true;
			richTextBox1.SelectionIndent = 10;
            richTextBox1.SelectedText = "23 different distributions random generators\n";
        richTextBox1.SelectedText = "Hypothesis testing\n";
        richTextBox1.SelectedText = "Analysis of variance\n";
        richTextBox1.SelectedText = "Regression models: linear, multiple, Principal Component, Poisson, Ridge, ...\n";
        richTextBox1.SelectedText = "Principal component analysis, Multidimensional Scaling\n";
        richTextBox1.SelectedText = "Time series analysis\n";
        richTextBox1.SelectedText = "Easy-to-use set of controls\n";
        richTextBox1.SelectedText = "Statistical charts\n";
        richTextBox1.SelectedText = "and more...\n";
        richTextBox1.SelectionBullet = false;
			richTextBox1.SelectionIndent = 0;
			richTextBox1.SelectedText = "\n";
            richTextBox1.SelectedText = "Stats Master demonstrates how easy, fast and performance efficient it is to build advanced "
        + "numerical algorithms with MtxVec. Many of the essential statistical routines presented in this package were not available to "
        + " VS developers at all - until now.";
			richTextBox1.SelectedText = "\n";
			richTextBox1.SelectedText = "Navigate through the demo application, to learn "
      + "more about Stats Master and experience it''s unmatched "
      + "performance and ease of use.\n\n\n";

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 195);
            richTextBox1.SelectedText = "Used assemblies:\n\n";

            Assembly assembly = Assembly.GetExecutingAssembly();
            if (assembly != null)
                richTextBox1.SelectedText = Utils.AssemblyInfo(assembly);

		}
	}
}
