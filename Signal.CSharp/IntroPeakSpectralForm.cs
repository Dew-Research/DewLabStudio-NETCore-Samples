using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DSPDemo
{
	public class IntroPeakSpectralForm : DSPDemo.BasicForm3
	{
		private System.ComponentModel.IContainer components = null;

        public IntroPeakSpectralForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 10, FontStyle.Bold);
			richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
			richTextBox1.SelectionColor = Color.FromArgb(51,51,153);
			Add("Frequency spectrum peak analysis:");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.BulletIndent = 10;
			Add("6 methods for frequency and amplitude interpolation: "+
				"Numeric, Quadratic, Barycentric, Quinn's First, Quinn's second, Jain's");
			Add("Auto find peaks in the frequency spectrum: largest, harmonics or retrace existing");
			Add("Add and delete peak marks on the fly with a dedicated TeeTool");
			Add("Peak order tracking");
			Add("Limit search for peaks within a frequency band");
			Add("Link RMS calculation of frequency bands to peak position");
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

