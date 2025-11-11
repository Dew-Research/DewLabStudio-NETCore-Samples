using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DSPDemo
{
	public class IntroApplicationForm : DSPDemo.BasicForm3
	{
		private System.ComponentModel.IContainer components = null;

		public IntroApplicationForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 10, FontStyle.Bold);
			richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
			richTextBox1.SelectionColor = Color.FromArgb(51,51,153);
			Add("Building applications:");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.BulletIndent = 10;
			Add("All key components have ready to use user dialogs.");
			Add("All components support streaming of their states and/or data " +
				"to and from TStream. Partial or complete application configuration " +
				"can be saved or restored instantly.");
			Add("With only a few drop-in components a signal analysis " +
				"application with complete user interface can be built!");
			Add("Real-time and off-line processing.");
			Add("By changing a DEFINE statement the application can be recompiled " +
				"in double or single precision!");
			Add("Instant support for latest CPU architectures via dll update!");
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
            richTextBox1.Size = new Size(755, 592);
            // 
            // IntroApplicationForm
            // 
            ClientSize = new Size(755, 592);
            Name = "IntroApplicationForm";
            ResumeLayout(false);
        }
        #endregion
    }
}

