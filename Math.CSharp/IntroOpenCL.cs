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
	public class introOpenCLForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public introOpenCLForm()
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(619, 421);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // introOpenCLForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(619, 421);
            this.Controls.Add(this.richTextBox1);
            this.Name = "introOpenCLForm";
            this.Text = "IntroOpenCL";
            this.Load += new System.EventHandler(this.IntroSparseForm_Load);
            this.ResumeLayout(false);

		}
		#endregion
		
		private void Add(String s) {
			richTextBox1.SelectedText = s + "\n";
		}

		private void IntroSparseForm_Load(object sender, System.EventArgs e) {
			richTextBox1.Clear();
			richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,11,FontStyle.Bold);
			richTextBox1.SelectionColor = Color.FromArgb(51,104,196);
			Add("Open CL features:");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.SelectionIndent = 10;
            Add("Open CL is a standard designed to make it easier to write high-performance code for GPU/CPU devices and make that code portable across different GPU and CPU devices");
			Add("Cross-platform support. Same code is to run on embedded devices (like mobile phones), desktop PCs and super computers across a wide range of operating systems.");
            Add("Support for both ATI and Nvidia GPUs");
			Add("Support for CPU devices. There exists a great opportunity that an extended Open CL will become the main target for accelerated code running on CPUs. Both Intel and AMD currently offer their own drivers for Open CL code to run on CPUs.");
			Add("Dynamic code compilation. The compiler is included with the drivers and the code is compiled only for the target device. End users running applications have the possibility to specify expressions which (through the Open CL) can run on GPU or be compiled in to native CPU code.");
			Add("Open CL drivers are free for all supported platforms and included with drivers for the hardware.");
            Add("End user application can be distributed without any dlls");			
			richTextBox1.SelectionBullet = false;
			richTextBox1.SelectionIndent = 0;
            Add("");

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);
            Add("Features of Cougar Open CL:");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Uses dynamic Open CL dll loading and can be included in end user applications possibly running on machines without Open CL drivers.");
            Add("Automatically detects all platforms (Intel, AMD, NVidia) and devices and loads their parameters.");
            Add("Provides routines to store encrypted source code in to resource files that are embedded in to the final application");
            Add("Caches binaries compiled on the first run for subsequent faster load times.");
            Add("Automatically detects changes to the hardware or Open CL driver versions and rebuilds the cached binaries.");
            Add("Loads all the kernels (functions) present in the Open CL source code, including their properties.");
            Add("Implements a shared context between CPU and GPU devices for more efficient heterogeneous computing. (one context per platform)");
            Add("Allows build options and source headers to be specified at program load time optionally requesting unconditional recompile.");
            Add("Can automatically detect the fastest device in the system and have the code running on it.");
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionIndent = 0;
            Add("");

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);
            Add("Features of Cougar Open CL:");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Implements all standard math functions.");
            Add("Support for real and complex numbers across all functions (where applicable).");
            Add("Makes use of object cache concept known from MtxVec for faster memory handling and higher performance.");
            Add("Implements separate kernels for CPU and GPU devices to achieve best performance on both architectures.");
            Add("Can run in single and double precision concurrently.");
            Add("Integrated debugger support for debugger visualizers allows GPU code debugging as if it would be running on the CPU.");
            Add("Delivers over 500 unique kernels. When considering also single/double and CPU/GPU variants, it is well over 2000.");
            Add("Full support for operator overloading.");
            Add("Supports execution of “micro” kernels. Micro kernels are short functions which could normally not be accelerated with Open CL.");
            Add("The performance penalty for micro-kernels is estimated at 50% of peak performance for GPU devices. This comes however with the benefit of utter simplicity of code writing and debugging with programmers productivity matching the work on CPU.");
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionIndent = 0;
            Add("");
		}
	}
}
