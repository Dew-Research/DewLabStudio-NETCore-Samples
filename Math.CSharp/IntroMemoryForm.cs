using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MtxVecDemo
{
	/// <summary>
	/// Summary description for IntroMemory.
	/// </summary>
	public class IntroMemoryForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public IntroMemoryForm()
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
            richTextBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(852, 554);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // IntroMemoryForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(852, 554);
            Controls.Add(richTextBox1);
            Name = "IntroMemoryForm";
            Text = "IntroMemory";
            Load += IntroMemoryForm_Load;
            ResumeLayout(false);

        }
        #endregion

        private void Add(String s) {
			richTextBox1.SelectedText = s + "\n";
		}

		private void IntroMemoryForm_Load(object sender, System.EventArgs e) {
			richTextBox1.Clear();
			richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,11,FontStyle.Bold);
			richTextBox1.SelectionColor = Color.FromArgb(51,104,196);
	    Add("Enhanced memory handling:");
	    Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.SelectionIndent = 10;
			Add("Built in dynamic memory allocation makes it easier for the user");
			Add("Object cache with object precreation speeds up Create and Destroy");
			Add("Memory preallocation gives you instant access to new memory");
			Add("Joining several calls to GetMem/FreeMem to one, "
				+ "increases overall performance");
			richTextBox1.SelectionBullet = false;
			richTextBox1.SelectionIndent = 0;
			Add("");
			richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,11,FontStyle.Bold);
			richTextBox1.SelectionColor = Color.FromArgb(51,104,196);
			Add("Array access options:");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.SelectionIndent = 10;
			Add("Default arrays allow cleaner syntax");
			Add("Array pointers give you more speed");
			Add("Single memory block matrices allow "
				+ "even faster matrix operations");
			richTextBox1.SelectionBullet = false;
			richTextBox1.SelectionIndent = 0;
		}
	}
}
