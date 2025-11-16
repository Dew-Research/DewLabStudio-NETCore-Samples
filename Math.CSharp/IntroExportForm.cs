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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(628, 505);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // IntroExportForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(628, 505);
            this.Controls.Add(this.richTextBox1);
            this.Name = "IntroExportForm";
            this.Text = "IntroExport";
            this.Load += new System.EventHandler(this.IntroExportForm_Load);
            this.ResumeLayout(false);

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
