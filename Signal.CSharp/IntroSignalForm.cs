using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DSPDemo
{
	public class IntroSignalForm : DSPDemo.BasicForm3
	{
		private System.ComponentModel.IContainer components = null;

		public IntroSignalForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 10, FontStyle.Bold);
			richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 10, richTextBox1.Font.Style);
			richTextBox1.SelectionColor = Color.FromArgb(51,51,153);
			Add("A wide range of signal filtering routines includes:");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.BulletIndent = 10;
			Add("Elliptic,Butterworth and Chebyshev filter designers");
			Add("Parks-McClellan optimal FIR filter design routine");
			Add("Savitzky-Golay polynomial FIR filter");
			Add("Multi-rate, multi-stage decimation and interpolation filters");
			Add("Envelope detection/amplitude demodulation");
			Add("Zoom-spectrum filter");
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
            this.richTextBox1.Size = new System.Drawing.Size(329, 273);
            // 
            // IntroSignalForm
            // 
            this.ClientSize = new System.Drawing.Size(329, 273);
            this.Name = "IntroSignalForm";
            this.ResumeLayout(false);

		}
		#endregion
	}
}

