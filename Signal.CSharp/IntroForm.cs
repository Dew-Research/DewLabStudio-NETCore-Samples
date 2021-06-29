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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 59);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to DSP Master v6";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(0, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(642, 427);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // IntroForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(642, 486);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Name = "IntroForm";
            this.Text = "IntroForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion
	}
}
