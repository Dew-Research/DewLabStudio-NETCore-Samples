using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DSPDemo
{
	public class IntroKalmanForm : DSPDemo.BasicForm3
	{
		private System.ComponentModel.IContainer components = null;

		public IntroKalmanForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 10, FontStyle.Bold);
			richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
			richTextBox1.SelectionColor = Color.FromArgb(51,51,153);
			Add("Kalman Filtering:");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.BulletIndent = 10;
            Add("Standard and extended Kalman filtering algorithms");			
			Add("Fully customizable user interface allowing variation of all variables with every iteration.");
			Add("Vectorized implementation optimized for handling of large states.");			
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
            this.richTextBox1.Size = new System.Drawing.Size(304, 273);
            // 
            // IntroKalmanForm
            // 
            this.ClientSize = new System.Drawing.Size(304, 273);
            this.Name = "IntroKalmanForm";
            this.Load += new System.EventHandler(this.IntroPeakSpectralForm_Load);
            this.ResumeLayout(false);

		}
		#endregion

        private void IntroPeakSpectralForm_Load(object sender, EventArgs e)
        {

        }
	}
}

