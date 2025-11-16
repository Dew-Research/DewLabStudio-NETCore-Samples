using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for BasicForm3.
	/// </summary>
	public class BasicForm3 : System.Windows.Forms.Form
	{
		protected System.Windows.Forms.RichTextBox richTextBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public BasicForm3()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}

        protected void Add(string s)
        {
            richTextBox1.SelectionStart = richTextBox1.TextLength; // <- ensure insertion point is at end
            richTextBox1.SelectionLength = 0;                      // <- ensure no selection
            richTextBox1.SelectedText = s + Environment.NewLine;   // <- now correct formatting applies
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
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1142, 952);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // BasicForm3
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(1142, 952);
            Controls.Add(richTextBox1);
            Name = "BasicForm3";
            Text = "BasicForm3";
            ResumeLayout(false);

        }
        #endregion
    }
}
