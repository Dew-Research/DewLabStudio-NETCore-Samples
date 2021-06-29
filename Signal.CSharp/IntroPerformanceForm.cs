using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DSPDemo
{
	public class IntroPerformanceForm : DSPDemo.BasicForm3
	{
		private System.ComponentModel.IContainer components = null;

		public IntroPerformanceForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 10, FontStyle.Bold);
			richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
			richTextBox1.SelectionColor = Color.FromArgb(51,51,153);
			Add("Optimal signal processing performance is ensured with:");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.BulletIndent = 10;
			Add("CPU specific support and code optimization. Exceptional performance for P4 systems.");
			Add("Data is processed in \"blocks\". This allows highly efficient optimization of tight loops.");
			Add("Ultra fast decimation and interpolation algorithm with multi-rate, multi-stage, half-band filters.");
			Add("Most of the routines are vectorized and can take advantage of SSE (P3) and SSE2 (Pentium 4) instruction sets.");
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
			components = new System.ComponentModel.Container();
		}
		#endregion
	}
}

