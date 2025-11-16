using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MtxVecDemo
{
	/// <summary>
	/// Summary description for IntroExport.
	/// </summary>
	public class IntroExportForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public IntroExportForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
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
            richTextBox1.BackColor = SystemColors.Window;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(820, 574);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // IntroExportForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(820, 574);
            Controls.Add(richTextBox1);
            Name = "IntroExportForm";
            Text = "IntroExport";
            Load += IntroExportForm_Load;
            ResumeLayout(false);

        }
        #endregion

        private void Add(String s) {
			richTextBox1.SelectedText = s + "\n";
		}

		private void IntroExportForm_Load(object sender, System.EventArgs e) {
			richTextBox1.Clear();
			richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,11,FontStyle.Bold);
			richTextBox1.SelectionColor = Color.FromArgb(51,104,196);
			Add("Quick and easy Export/Import to screen, file, "
				+ "database... text or binary.");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.SelectionIndent = 10;
			Add("Values to text, text to values (real and complex)");
			Add("Read/Write stream");
			Add("Read/Write file (binary or text)");
			Add("Read/Write datagrid");
			richTextBox1.SelectionBullet = false;
			richTextBox1.SelectionIndent = 0;
			Add("");
			richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,11,FontStyle.Bold);
			richTextBox1.SelectionColor = Color.FromArgb(51,104,196);
			Add("Ready to use Matrix Viewer and charting tools:");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.SelectionIndent = 10;
			Add("Use ViewValues to display the contents of the matrix or vector");
			Add("Edit data on the fly");
			Add("Draw data while viewing");
			Add("Save/Load from file");
			Add("Use DrawValues and DrawIt for immediate data display");
			richTextBox1.SelectionBullet = false;
			richTextBox1.SelectionIndent = 0;
		}
	}
}
