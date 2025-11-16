using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MtxVecDemo
{
	/// <summary>
	/// Summary description for BasicForm2.
	/// </summary>
	public class BasicForm2 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		protected System.Windows.Forms.Panel panel2;
		protected System.Windows.Forms.Panel panel3;
		protected System.Windows.Forms.RichTextBox richTextBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public BasicForm2()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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

		protected void Add(String s) {
			richTextBox1.SelectedText = s + "\n";
		}

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(richTextBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(924, 138);
            panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(924, 138);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(924, 420);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 558);
            panel3.Name = "panel3";
            panel3.Size = new Size(924, 59);
            panel3.TabIndex = 2;
            // 
            // BasicForm2
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(924, 617);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "BasicForm2";
            Text = "BasicForm2";
            panel1.ResumeLayout(false);
            ResumeLayout(false);

        }
        #endregion
    }
}
