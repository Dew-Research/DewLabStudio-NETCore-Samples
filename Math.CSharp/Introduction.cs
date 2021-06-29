using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Reflection;

namespace MtxVecDemo
{
	/// <summary>
	/// Summary description for Introduction.
	/// </summary>
    public class IntroductionForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public IntroductionForm()
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(702, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Dew Math";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(0, 79);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(702, 440);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // IntroductionForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(702, 519);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "IntroductionForm";
            this.Text = "Introduction";
            this.Load += new System.EventHandler(this.IntroductionForm_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private void IntroductionForm_Load(object sender, System.EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 195);

            richTextBox1.SelectedText = "Welcome to Dew Math, an object oriented vectorized numerical library " +
                "for Delphi and .NET platform\n";
            richTextBox1.SelectedText = "\n";
            richTextBox1.SelectedText = "Dew Math adds the following capabilities to your development environment:\n";
            richTextBox1.SelectedText = "\n";
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            richTextBox1.SelectedText = "Comprehensive set of mathematical and statistical functions\n";
            richTextBox1.SelectedText = "Substantial performance improvements of floating point math by exploiting the SSE2, SSE3, SSE4 and Intel AVX instruction sets\n";
            richTextBox1.SelectedText = "Improved compactness and readability of code\n";
            richTextBox1.SelectedText = "Significantly shorter development times by protecting the developer from a wide range of possible errors.\n";
            richTextBox1.SelectedText = "Support for super-conductive memory allocation without thread-congestion in heavily multithreaded apps.\n";
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionIndent = 0;
            richTextBox1.SelectedText = "\n";
            richTextBox1.SelectedText = "Typical performance improvements observed by most users are 2-3 times for " +
            "vector functions, but speed ups up to 10 times are not rare. The matrix " +
            "multiplication for example is faster up to 20 times. For .NET applications these factors should be multiplied by about 1.3.";
            richTextBox1.SelectedText = "\n";
            richTextBox1.SelectedText = "Navigate through the demo application, to learn "
      + "more about MtxVec and experience it''s unmatched "
      + "performance and ease of use.\n\n\n";

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 195);
            richTextBox1.SelectedText = "Used assemblies:\n\n";

            Assembly assembly = Assembly.GetExecutingAssembly();
            if (assembly != null) 
                richTextBox1.SelectedText = Utils.AssemblyInfo(assembly);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
