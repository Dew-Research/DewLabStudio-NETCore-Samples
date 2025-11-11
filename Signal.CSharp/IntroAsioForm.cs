using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DSPDemo
{
	public class IntroAsioForm : DSPDemo.BasicForm3
    {
		private System.ComponentModel.IContainer components = null;

		public IntroAsioForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 10, FontStyle.Bold);
			richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
			richTextBox1.SelectionColor = Color.FromArgb(51,51,153);
			Add("Real time audio processing using Steinberg ASIO:");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.BulletIndent = 10;
            Add("High performance wrappers for concurrent playback and recording.");
            Add("Support for processing within and outside of the drivers thread.");
            Add("Auto bit-depth conversion");
            Add("Auto buffer size conversion");
            Add("Click protection for start, stop and pause.");
            Add("Implements playback and recording skip protection buffers.");
            Add("Real-time monitoring of playback and recording streams.");
            Add("Support for multiple ASIO devices.");
			richTextBox1.SelectionBullet = false;
			richTextBox1.BulletIndent = 0;
            Add("");

            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
            richTextBox1.SelectionColor = Color.FromArgb(51, 51, 153);
            Add("Important notes:");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.BulletIndent = 10;
            Add("Use of ASIO drivers requires hardware (sound card) which includes ASIO drivers.");
            Add("ASIO bit-depth and sampling frequency is defined by the driver and cannot be changed from the application.");
            Add("Both playback and recording use same bit-depth and sampling frequency.");
            Add("A single ASIO driver can only be used by one application at one time.");
            Add("ASIO drivers can be simulated with ASIO4ALL (free driver set).");
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
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Size = new Size(870, 627);
            // 
            // IntroAsioForm
            // 
            ClientSize = new Size(870, 627);
            Name = "IntroAsioForm";
            Load += IntroAsioForm_Load;
            ResumeLayout(false);

        }
        #endregion

        private void IntroAsioForm_Load(object sender, EventArgs e)
        {

        }
	}
}

