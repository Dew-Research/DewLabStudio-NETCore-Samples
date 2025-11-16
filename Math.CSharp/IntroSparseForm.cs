using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MtxVecDemo
{
	/// <summary>
	/// Summary description for IntroSparse.
	/// </summary>
	public class IntroSparseForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public IntroSparseForm()
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
            richTextBox1.BackColor = SystemColors.Window;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(981, 591);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // IntroSparseForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(981, 591);
            Controls.Add(richTextBox1);
            Name = "IntroSparseForm";
            Text = "IntroSparse";
            Load += IntroSparseForm_Load;
            ResumeLayout(false);

        }
        #endregion

        private void Add(String s) {
			richTextBox1.SelectedText = s + "\n";
		}

		private void IntroSparseForm_Load(object sender, System.EventArgs e) {
			richTextBox1.Clear();
			richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,11,FontStyle.Bold);
			richTextBox1.SelectionColor = Color.FromArgb(51,104,196);
			Add("Sparse matrix class features:");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.SelectionIndent = 10;
			Add("Support for real and complex sparse matrices");
			Add("UMFPack v4.3 direct sparse sparse solver");
			Add("Pardiso multithreaded sparse solver");
			Add("Iterative sparse solvers (cg, bcg, gmres,..)");
			Add("Many conversion routines to convert to and from different matrix formats "+
				"(triplet, banded, dense, Harwell Boeing)");
			Add("Support for MatrixMarket file format.");
			Add("Very fast banded matrix solvers already available in TMtx");
			Add("Add, subtract, multiply routines for sparse/sparse and dense/sparse matrices/vectors");
			Add("PixelDownSample routine to allow fast display of the non-zero " +
				"pattern of the matrices of large sizes.  (1000 000 x 1000 000 elements)");
			Add("Complete set of standard math routines (Log, Power, Sin,...)");
			richTextBox1.SelectionBullet = false;
			richTextBox1.SelectionIndent = 0;

		}
	}
}
