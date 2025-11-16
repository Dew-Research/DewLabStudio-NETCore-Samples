using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MtxVecDemo {
	/// <summary>
	/// Summary description for IntroMatrices.
	/// </summary>
	public class IntroMatricesForm : System.Windows.Forms.Form {
		private System.Windows.Forms.RichTextBox richTextBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public IntroMatricesForm() {
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
            richTextBox1.Size = new Size(892, 596);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // IntroMatricesForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(892, 596);
            Controls.Add(richTextBox1);
            Name = "IntroMatricesForm";
            Text = "IntroMatrices";
            Load += IntroMatricesForm_Load;
            ResumeLayout(false);

        }
        #endregion

        private void Add(String s) {
			richTextBox1.SelectedText = s + "\n";
		}

		private void IntroMatricesForm_Load(object sender, System.EventArgs e) {
			richTextBox1.Clear();
			richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,11,FontStyle.Bold);
			richTextBox1.SelectionColor = Color.FromArgb(51,104,196);
			Add("Matrix operations:");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.SelectionIndent = 10;

			Add("Least squares solution to a system of linear equations");
			Add("Refining solution of linear systems and error estimate");
			Add("Singular value decomposition and solution of a system of equations");
			Add("Eigenvalues and eigenvectors");
			Add("Toeplitz systems of linear equations");
			Add("Complete support for complex numbers");
			Add("2D FFT");
			Add("Complete matrix arithmetics");
			Add("Support for sparse matrices");

			richTextBox1.SelectionBullet = false;
			richTextBox1.SelectionIndent = 0;

		}
	}
}
