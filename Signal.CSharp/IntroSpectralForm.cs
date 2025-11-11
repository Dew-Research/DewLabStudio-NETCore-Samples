using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DSPDemo
{
	public class IntroSpectralForm : DSPDemo.BasicForm3
	{
		private System.ComponentModel.IContainer components = null;

		public IntroSpectralForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 10, FontStyle.Bold);
			richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
			richTextBox1.SelectionColor = Color.FromArgb(51,51,153);
			Add("Frequency spectrum analysis features:");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.BulletIndent = 10;
			Add("Very fast FFT for real and complex signals");
			Add("Chirp-Z Transform for high speed frequency zoom-in");
			Add("4 autoregressive methods for spectral estimation: " +
				"Yulle-Walker, Burg, Covariance and Modified covariance");
			Add("10 different time signal windows: Hanning, Hamming, FlatTop, " +
				"Bartlet, Blackman, BlackmanHarris, BlackmanExact, "+
				"Cosine-tappered, Kaiser, Chebyshev and  Exponential");
			Add("THD, THD-N, SNR, NF, RMS, SFDR spectral statistics");
			Add("Integration and differentiation in the frequency domain");
			Add("Amplitude, power, peak-peak and RMS spectrums.");
			Add("Real and complex cepstrum.");
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
            richTextBox1.Size = new Size(1017, 660);
            // 
            // IntroSpectralForm
            // 
            ClientSize = new Size(1017, 660);
            Name = "IntroSpectralForm";
            ResumeLayout(false);
        }
        #endregion
    }
}

