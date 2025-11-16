using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MtxVecDemo
{
	/// <summary>
	/// Summary description for QuickStart.
	/// </summary>
	public class QuickStartForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public QuickStartForm()
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
            richTextBox1.Size = new Size(536, 444);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // QuickStartForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(536, 444);
            Controls.Add(richTextBox1);
            Name = "QuickStartForm";
            Text = "QuickStart";
            Load += QuickStartForm_Load;
            ResumeLayout(false);

        }
        #endregion

        private void Add(String s) {
			richTextBox1.SelectedText = s + "\n";
		}

		private void QuickStartForm_Load(object sender, System.EventArgs e) {
			richTextBox1.Clear();
			richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,11,FontStyle.Bold);
			richTextBox1.SelectionColor = Color.FromArgb(51,104,196);
			Add("Quick start: Computing a frequency spectrum.");
			Add("Using MtxVec routines is a peace of cake. Now you can perform complex numeric tasks with only few function calls:");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.SelectionIndent = 10;
			Add("Create new project.");
			Add("Add the following assemblies to the project reference list (\"Project -> Add Reference\" menu):"
			+ "Dew.Math.dll, Dew.Math.Tee.dll, Borland.Delphi.dll.\nAll these assemblies are located in Dew Lab "
			+ "Studio Dew Math \\Assemblies\\ folder.");
			Add("Add a TChart and a Button controls on the form. Add new fast line series to TChart (right-click on the TChart, "
			+ "then select \"Edit\" menu item, then click on the \"Add Series\" button.");
			Add("In code section, add the following assemblies to the using section: Dew.Math, Dew.Math.Units, Dew.Math.Tee");
			Add("Insert the following code:");
			richTextBox1.SelectionBullet = false;
			richTextBox1.SelectionIndent = 0;
			Add("");
			richTextBox1.SelectionFont = new Font(
                "Courier New",
				richTextBox1.SelectionFont.Size);
			Add("private void button1_Click(object sender, System.EventArgs e) {\n"+
			"  Vector x = new Vector(0);\n"+
            "  Vector y = new Vector(0);\n" +
            "  Vector spec = new Vector(0);\n" +
            "  // Please include the full path of the file.\n"+
			"  // The file is included with the MtxVec BasicDemo\n"+
			"  // distribution and has 8000 values only.\n"+
			"  y.LoadFromFile(\"C:\\\\MtxVecDemo\\\\FFTData.vec\");\n"+
			"  y.Resize(1024,false);\n"+
			"  x.FFT(y,false);\n"+
			"  spec.Mag(x);\n"+
			"  MtxVecTee.DrawValues(spec,fastLine1,0,1,false);\n"+
		    "}");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.SelectionIndent = 10;
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.SelectionIndent = 10;
			Add("F5 to compile and run, press Button1.");
			Add("should be looking at the frequency spectra displaying one series of harmonics.");
			richTextBox1.SelectionBullet = false;
			richTextBox1.SelectionIndent = 0;
			Add("");
	    Add("Things to try:");
			richTextBox1.SelectionBullet = true;
			richTextBox1.SelectionIndent = 10;
			Add("Change the 1024 value to some other values that are power of two. (512 or 2048).");
			Add("Use Steema.TeeChart.Styles.Area chart style.");
			Add("Make the spectra logarithmic in the amplitude (use the Log10 method).");
			Add("Save spectra to a file, then load it and draw to the chart with DrawValues.");
			Add("Replace DrawValues(spec,Series1) with ViewValues(spec) and then try ViewValues(x). Play with the menu options in the displayed form.");
			richTextBox1.SelectionBullet = false;
			richTextBox1.SelectionIndent = 0;
		}

	}
}
