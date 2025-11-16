using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Reflection;
using Dew.Math.Units;
using System.Threading;

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
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(841, 79);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Dew Math";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Window;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox1.Location = new Point(0, 79);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(841, 472);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // IntroductionForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(841, 551);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Name = "IntroductionForm";
            Text = "Introduction";
            Load += IntroductionForm_Load;
            ResumeLayout(false);

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
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Assembly assembly = Assembly.GetExecutingAssembly();
            if (assembly != null) 
                richTextBox1.SelectedText = Utils.AssemblyInfo(assembly);
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionIndent = 0;

            richTextBox1.AppendText("\n");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 195);          
            richTextBox1.AppendText("System info\n");
            richTextBox1.AppendText("\n");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            richTextBox1.AppendText($"CPU Logical Core Count = {MtxVec.Controller.CpuCoresLogical}\n");
            richTextBox1.AppendText($"CPU Physical Core Count = {MtxVec.Controller.CpuCoresPhysical}\n");
            richTextBox1.AppendText($"CPU NUMA Node Count = {MtxVec.Controller.CpuNumaNodes}\n");
            richTextBox1.AppendText($"CPU L1 Cache size per Core = {(MtxVec.Controller.CpuCacheL1SizeInBytes / 1024)} KB\n");
            richTextBox1.AppendText($"CPU L2 Cache size per Core = {(MtxVec.Controller.CpuCacheL2SizeInBytes / 1024)} KB\n");
            if (MtxVec.Controller.CpuCacheL3SizeInBytes > 0)
            {
                richTextBox1.AppendText($"CPU L3 Cache Size = {(MtxVec.Controller.CpuCacheL3SizeInBytes / 1024)} KB\n");
            }
            richTextBox1.AppendText($"CPU Vendor: {MtxVec.Controller.CPUVendor}\n");
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionIndent = 0;

            // MtxVec Config Section
            richTextBox1.AppendText("\n");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 195);
            richTextBox1.AppendText("MtxVec config\n");
            richTextBox1.AppendText("\n");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            richTextBox1.AppendText($"CPU/Thread Count = {MtxVec.Controller.CpuCores}\n");
            richTextBox1.AppendText($"Thread Dimension = {MtxVec.Controller.ThreadDimension}\n");
            richTextBox1.AppendText($"Blas internal threads = {MtxVec.Controller.BlasThreadCount} \n");
            richTextBox1.AppendText($"Lapack internal threads = {MtxVec.Controller.LapackThreadCount} \n");
            richTextBox1.AppendText($"FFT internal threads = {MtxVec.Controller.FftThreadCount} \n");
            richTextBox1.AppendText($"VML internal threads = {MtxVec.Controller.VmlThreadCount}\n");
            richTextBox1.AppendText($"IPP acceleration (double) = ON\n");
            richTextBox1.AppendText($"IPP acceleration (float) = ON\n");
            richTextBox1.AppendText($"LAPACK acceleration (double) =ON\n");
            richTextBox1.AppendText($"LAPACK acceleration (floate) = ON\n");
            richTextBox1.AppendText($"FFT acceleration (float and double) = ON\n");
            richTextBox1.AppendText($"VML acceleration (double) = ON\n");
            richTextBox1.AppendText($"VML acceleration (float) = ON\n");
            richTextBox1.AppendText($"Random Gen acceleration (float and double) = ON\n");
            richTextBox1.AppendText($"MtxVec Block Size (double) = {Math387.MtxVecBlockSize}\n");
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionIndent = 0;            

            // Enabled CPU Support Section
            
            richTextBox1.AppendText("\n");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 195);
            richTextBox1.AppendText("Enabled CPU instruction support\n");
            richTextBox1.AppendText("\n");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;

            if (MtxVec.Controller.CpuSSSE3) richTextBox1.AppendText("SSSE3\n");
            if (MtxVec.Controller.CpuSSE42) richTextBox1.AppendText("SSE42\n");
            if (MtxVec.Controller.CpuAVX)   richTextBox1.AppendText("AVX\n");
            if (MtxVec.Controller.CpuAVX2)  richTextBox1.AppendText("AVX2\n");
            if (MtxVec.Controller.CpuAVX512F) richTextBox1.AppendText("AVX512F\n");
            if (MtxVec.Controller.CpuAVX512CD) richTextBox1.AppendText("AVX512CD\n");
            if (MtxVec.Controller.CpuAVX512BW) richTextBox1.AppendText("AVX512BW\n");
            if (MtxVec.Controller.CpuAVX512DQ) richTextBox1.AppendText("AVX512DQ\n");
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionIndent = 0;
            richTextBox1.AppendText("\n");

            if (!MtxVec.Controller.CpuFeaturesEnabledMatchAvailable())
            {
                MessageBox.Show("Warning: The CPU features enabled do not match the CPU features available!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
