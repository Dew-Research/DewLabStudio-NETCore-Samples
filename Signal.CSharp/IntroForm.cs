using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for IntroForm.
	/// </summary>
	public class IntroForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
	
		private void Add(String s) {
			richTextBox1.SelectedText = s + "\n";
		}
		
		public IntroForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            richTextBox1.BackColor = Color.White;
			richTextBox1.SelectionColor = Color.FromArgb(226, 226, 226);
			richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 14, richTextBox1.Font.Style);
			Add("Welcome to DSP Master");
			Add("");
			richTextBox1.BulletIndent = 10;
			richTextBox1.SelectionBullet = true;
			Add("Written entirely with MtxVec and taking advantage  "
				+ "of full vector/matrix design.");
			Add("Supports signal processing algorithms in streaming "
				+ "or single block mode.");
			Add("Features a large set of ready to use components "
				+ "covering digital filter design and frequency analysis.");
			Add("Visually connect signal processing components to form " +
				"signal processing pipes capable of streaming. " );
			Add("Supports multichannel, aribtrary sampling frequency, "+
				"complex or real, double or single precision, signal processing pipes.");
			richTextBox1.BulletIndent = 0;
			richTextBox1.SelectionBullet = false;
			Add("");
			richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Italic);
			Add("\"MtxVec was created to help shorten the "
				+ "development time of commercial scientific "
				+ "applications.\"");
			Add("");
			Add("Navigate through the demo application, to learn "
				+ "more about DSP Master.");
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
            panel1 = new Panel();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1014, 59);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(994, 39);
            label1.TabIndex = 0;
            label1.Text = "Welcome to DSP Master v6";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            richTextBox1.Location = new Point(0, 59);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(1014, 672);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // IntroForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(1014, 731);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            Name = "IntroForm";
            Text = "IntroForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);

        }
        #endregion
    }
}
