using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MtxVecDemo {
	/// <summary>
	/// Summary description for IntroWhyMtxVec.
	/// </summary>
	public class IntroWhyMtxVecForm : System.Windows.Forms.Form {
		private System.Windows.Forms.RichTextBox richTextBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public IntroWhyMtxVecForm() {
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
		private void InitializeComponent() {
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
            this.richTextBox1.Size = new System.Drawing.Size(954, 621);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // IntroWhyMtxVecForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(954, 621);
            this.Controls.Add(this.richTextBox1);
            this.Name = "IntroWhyMtxVecForm";
            this.Text = "IntroWhyMtxVec";
            this.Load += new System.EventHandler(this.IntroWhyMtxVecForm_Load);
            this.ResumeLayout(false);

		}
		#endregion
		private void Add(String s) {
			richTextBox1.SelectedText = s + "\n";
		}
		private void IntroWhyMtxVecForm_Load(object sender, System.EventArgs e) {
			richTextBox1.Clear();
			richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,11,FontStyle.Bold);
			richTextBox1.SelectionColor = Color.FromArgb(51,104,196);
			Add("Why MtxVec (Dew Math):");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.SelectionIndent = 10;
			Add("Routines are organized in to classes");
			Add("Parameters are explicitly range checked, before they are passed to the dll routines. This ensures that all dll calls are safe to use.");
			Add("When calling Lapack routines MtxVec automatically compensates for the fact that in FORTRAN the matrices are stored by columns and in other languages by rows.");
			Add("Many LAPACK functions take many parameters. Most of them can be filled-in automatically by MtxVec, thus reducing the time to study each function extensively, before it can be used.");
			Add("Organized in to a set of \"primitive\" highly optimized functions covering all the basic math operations, which are used by all higher level algorithms, in a similar way as the BLAS is used by LAPACK.");
			Add("Although some compilers support native SSE2/SSE3/SSE4 instruction set, the resulting code can never be as optimal as a hand optimized version.");
			Add("Many linear algebra routines are multithreaded, including FFT“s and sparse matrix solvers.");
			Add("All MtxVec functions must pass very strict automated tests. It is these tests, which give the library the highest possible level of reliability, accuracy and error protection.");
			Add("All low level code is abstracted away from the user. This allows a very easy transition to any future platform supported by MtxVec.");
			Add("C/C++ and FORTRAN based functions were compiled with the latest version“s Intel C/C++ and FORTRAN compilers and with support for SSE2,SSE3,SSE4 and Intel AVX.");
			richTextBox1.SelectionBullet = false;
			richTextBox1.SelectionIndent = 0;
			Add("");
			richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,11,FontStyle.Bold);
			richTextBox1.SelectionColor = Color.FromArgb(51,104,196);
			Add("Why Dew Math for .NET:");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.SelectionIndent = 10;
			Add("Optimizing the performance of .NET code can be a real challenge. MtxVec delivers patterns which allow fast executing floating point code to be also written fast.");
			Add("The advantage of SSE2, SSE3, SSE4, AVX instruction sets can be exploited only with unmanaged code. And only hand optimized code can be truly optimal.");
			Add("Provides an interface to LAPACK to be used from any .NET language.");
			Add("Unmanaged code is encapsulated in to efficient and thin wrappers making the code \"safe\" for the end user, with little or no overhead " +
				"associated with transitions from managed to unmanaged code. Many difficult to trace bugs and performance issues are avoided in this way.");
            Add("Makes efficient use of the .NET garbage collector. ");
			Add("Especially for complex numbers, the performance gain against native .NET code can be very large.");
			richTextBox1.SelectionBullet = false;
			richTextBox1.SelectionIndent = 0;
		}
	}
}
