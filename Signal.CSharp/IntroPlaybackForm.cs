using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DSPDemo
{
	public class IntroPlaybackForm : DSPDemo.BasicForm3
	{
		private System.ComponentModel.IContainer components = null;

		public IntroPlaybackForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 10, FontStyle.Bold);
			richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
			richTextBox1.SelectionColor = Color.FromArgb(51,51,153);
			Add("Playback and record:");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.BulletIndent = 10;
			Add("96kHz/24 bit extensible audio format support.");
			Add("8,16,24 and 32 bit support for reading/writing, playback/recording");
			Add("Arbitrary sampling frequency.");            
			Add("Multichannel audio card support.");
			Add("Audio compression manager support when reading wav files.");    
			Add("Real time signal monitor during playback and recording.");
			Add("Triggering support with pre-trigger, post-trigger,..");
			Add("Configurable display delay and skip protection for trigger and monitoring.");
			Add("Full access to audio buffers.");
			Add("Additional binary/text file format support.");
			Add("Ready to use user interface instantly adds playback/recording capabilities to any application.");    
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
            richTextBox1.Size = new Size(875, 755);
            // 
            // IntroPlaybackForm
            // 
            ClientSize = new Size(875, 755);
            Name = "IntroPlaybackForm";
            ResumeLayout(false);
        }
        #endregion
    }
}

