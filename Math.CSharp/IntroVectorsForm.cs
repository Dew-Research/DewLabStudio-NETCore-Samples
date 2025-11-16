using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MtxVecDemo {
	/// <summary>
	/// Summary description for IntroVectors.
	/// </summary>
	public class IntroVectorsForm : System.Windows.Forms.Form {
		private System.Windows.Forms.RichTextBox richTextBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public IntroVectorsForm() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void Add(String s) {
			richTextBox1.SelectedText = s + "\n";
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if(components != null) {
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
            richTextBox1.Size = new Size(949, 583);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // IntroVectorsForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(949, 583);
            Controls.Add(richTextBox1);
            Name = "IntroVectorsForm";
            Text = "IntroVectors";
            Load += IntroVectors_Load;
            ResumeLayout(false);

        }
        #endregion

        private void IntroVectors_Load(object sender, System.EventArgs e) {
			richTextBox1.Clear();
			richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,11,FontStyle.Bold);
			richTextBox1.SelectionColor = Color.FromArgb(51,104,196);
			Add("Vector operations:");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.SelectionIndent = 10;
			Add("Real and complex FFT");
			Add("Auto and cross correlations");
			Add("Convolution and filtering");
			Add("Complete vector arithmetic");
			Add("Sorting real and complex numbers");
			Add("Random generators");
            Add("Integration.");
            richTextBox1.SelectionBullet = false;
			richTextBox1.SelectionIndent = 0;

			}
	}
}
