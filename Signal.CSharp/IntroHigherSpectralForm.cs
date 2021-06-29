using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DSPDemo
{
	public class IntroHigherSpectralForm : DSPDemo.BasicForm3
	{
		private System.ComponentModel.IContainer components = null;

		public IntroHigherSpectralForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 10, FontStyle.Bold);
			richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
			richTextBox1.SelectionColor = Color.FromArgb(51,51,153);
			Add("Make use of higher order spectral analysis:");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.BulletIndent = 10;
			Add("Compute bispectrum and/or bicoherence of real and complex signals");
			Add("Compute bicoherence for only preselected frequency pairs");
			Add("View bicoherence in real time with running average");
			Add("Select from 10 time window functions");
			Add("Supports spectrum sizes with more then 16384 lines for preselected "+
				"frequency pairs");
			Add("Full set of peak marking/tracking features");
			Add("Frequency band statistics");
			richTextBox1.SelectionBullet = false;
			richTextBox1.BulletIndent = 0;
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
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(350, 273);
            // 
            // IntroHigherSpectralForm
            // 
            this.ClientSize = new System.Drawing.Size(350, 273);
            this.Name = "IntroHigherSpectralForm";
            this.ResumeLayout(false);

		}
		#endregion
	}
}

