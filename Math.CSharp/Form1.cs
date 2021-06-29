using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Dew.Math.Units;
using Dew.Math;

namespace MtxVecDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageExample;
		private System.Windows.Forms.TabPage tabPageSource;
		private System.Windows.Forms.Label labelCurrent;
		private System.Windows.Forms.RichTextBox richTextBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MainForm()
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
            //clMtxVec.clPlatform().Free();
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
            clMtxVec.finalization();

			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageExample = new System.Windows.Forms.TabPage();
            this.tabPageSource = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.labelCurrent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 79);
            this.panel1.TabIndex = 0;
            // 
            // labelCurrent
            // 
            this.labelCurrent.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrent.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCurrent.Location = new System.Drawing.Point(190, 36);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(516, 26);
            this.labelCurrent.TabIndex = 0;
            this.labelCurrent.Text = "label1";
            this.labelCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 554);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 30);
            this.panel2.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 79);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(213, 475);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPageExample);
            this.tabControl1.Controls.Add(this.tabPageSource);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(213, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(742, 475);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageExample
            // 
            this.tabPageExample.Location = new System.Drawing.Point(4, 4);
            this.tabPageExample.Name = "tabPageExample";
            this.tabPageExample.Size = new System.Drawing.Size(734, 447);
            this.tabPageExample.TabIndex = 0;
            this.tabPageExample.Text = "Example";
            // 
            // tabPageSource
            // 
            this.tabPageSource.Controls.Add(this.richTextBox1);
            this.tabPageSource.Location = new System.Drawing.Point(4, 4);
            this.tabPageSource.Name = "tabPageSource";
            this.tabPageSource.Size = new System.Drawing.Size(779, 447);
            this.tabPageSource.TabIndex = 1;
            this.tabPageSource.Text = "Source";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(779, 447);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(955, 584);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.Text = "Dew Lab Studio for .NET - MtxVec Demo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSource.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private Form currentOpenForm;
        
        private void MainForm_Load(object sender, System.EventArgs e)
        {
			LoadTreeItems();
			labelCurrent.BackColor = Color.Transparent;
		}

		private void LoadTreeItems() {
            Utils.DemoTreeNode node1 = new Utils.DemoTreeNode("Introduction", null, "MtxVecDemo.IntroductionForm");
            node1.Nodes.Add(new Utils.DemoTreeNode("Why Dew Math", null, "MtxVecDemo.IntroWhyMtxVecForm"));
			treeView1.Nodes.Add(node1);

            treeView1.Nodes.Add(new Utils.DemoTreeNode("What's new", null, "MtxVecDemo.WhatsNewForm"));
            node1 = new Utils.DemoTreeNode("Matrix operations", null, "MtxVecDemo.IntroMatricesForm");
            node1.Nodes.Add(new Utils.DemoTreeNode("Multiplying large matrices", "Multiply1.cs", "MtxVecDemo.Multiply1Form"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Copy and transpose operation", "CopyCompare.cs", "MtxVecDemo.CopyCompareForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Calculating the inverse of squared matrix", "InverseMtx.cs", "MtxVecDemo.InverseMtxForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Calculating squared root of matrix", "CalcSqrtMtx.cs", "MtxVecDemo.CalcSqrtMtxForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Eigenvalues and eigenvectors", "EigenVectors1.cs", "MtxVecDemo.EigenVectors1Form"));
            node1.Nodes.Add(new Utils.DemoTreeNode("LQ and QR decomposition", "LQRDemo.cs", "MtxVecDemo.LQRDemoForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Solving system of equations", "SysLinear.cs", "MtxVecDemo.SysLinearForm"));
			node1.Nodes.Add(new Utils.DemoTreeNode("Viewing matrix values","MatrixSeries.cs","MtxVecDemo.MatrixSeriesForm"));
			treeView1.Nodes.Add(node1);	

			node1 = new Utils.DemoTreeNode("Vector operations",null,"MtxVecDemo.IntroVectorsForm");
			node1.Nodes.Add(new Utils.DemoTreeNode("Levinson Yule Walker","YuleLevinson.cs","MtxVecDemo.YuleLevinsonForm"));
			node1.Nodes.Add(new Utils.DemoTreeNode("Displaying large amounts of data","PixelDownSample.cs","MtxVecDemo.PixelDownSampleForm"));
			node1.Nodes.Add(new Utils.DemoTreeNode("Block processing","BlockProcessing.cs","MtxVecDemo.BlockProcessingForm"));
			node1.Nodes.Add(new Utils.DemoTreeNode("Dirichlet and Riemann functions","DirichletTest.cs","MtxVecDemo.DirichletTestForm"));
			node1.Nodes.Add(new Utils.DemoTreeNode("Benchmarks","BenchmarkX.cs","MtxVecDemo.BenchmarkXForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Numerical integration (1D)", "NumInt1D.cs", "MtxVecDemo.NumInt1D"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Optimized fast drawing", "MtxFastlineDemo.cs", "MtxVecDemo.MtxFastlineDemo"));
            treeView1.Nodes.Add(node1);

			node1 = new Utils.DemoTreeNode("Exporting/Importing",null,"MtxVecDemo.IntroExportForm");
			node1.Nodes.Add(new Utils.DemoTreeNode("Saving/Loading","SavingLoading.cs","MtxVecDemo.SavingLoadingForm"));
			node1.Nodes.Add(new Utils.DemoTreeNode("Different numeric precision","Precision.cs","MtxVecDemo.PrecisionForm"));
			node1.Nodes.Add(new Utils.DemoTreeNode("MSOffice","ClipboardMSOffice.cs","MtxVecDemo.ClipboardMSOfficeForm"));
			treeView1.Nodes.Add(node1);

            node1 = new Utils.DemoTreeNode("Open CL", null, "MtxVecDemo.introOpenCLForm");
            node1.Nodes.Add(new Utils.DemoTreeNode("Bennchmark", "clBenchmarkForm.cs", "MtxVecDemo.clBenchmarkForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Custom function", "clCustomFunctionForm.cs", "MtxVecDemo.clCustomFunctionForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Multi device test", "clMultiDeviceForm.cs", "MtxVecDemo.clMultiDeviceForm"));
            treeView1.Nodes.Add(node1);

			node1 = new Utils.DemoTreeNode("Memory management",null,"MtxVecDemo.IntroMemoryForm");
			node1.Nodes.Add(new Utils.DemoTreeNode("Comparing CreateIt/FreeIt with Garbage collector","MemoryCompare.cs","MtxVecDemo.MemoryCompareForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Garbage collector benchmarks", "GCProcessing.cs", "MtxVecDemo.GCProcessingForm"));
			treeView1.Nodes.Add(node1);

			node1 = new Utils.DemoTreeNode("Polynomial routines",null,"MtxVecDemo.IntroPolynomsForm");
			node1.Nodes.Add(new Utils.DemoTreeNode("Linear and cubic interpolation","Interpolation.cs","MtxVecDemo.InterpolationForm"));
			node1.Nodes.Add(new Utils.DemoTreeNode("Least-square fitting","QRPoly.cs","MtxVecDemo.QRPolyForm"));
			treeView1.Nodes.Add(node1);

			node1 = new Utils.DemoTreeNode("Optimization problems",null,null);
            node1.Nodes.Add(new Utils.DemoTreeNode("Linear Programming", "LPDemo.cs", "MtxVecDemo.LPDemo"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Minimization algorithms", "MtxOptim.cs", "MtxVecDemo.MtxOptimForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Simplex: Bounded constraints", "Optim_Bounded.cs", "MtxVecDemo.Optim_Bounded"));
            treeView1.Nodes.Add(node1);

            node1 = new Utils.DemoTreeNode("Probabilities unit", "ProbCalculator.cs", "MtxVecDemo.ProbCalculator");
			treeView1.Nodes.Add(node1);

			node1 = new Utils.DemoTreeNode("Sparse matrices",null,"MtxVecDemo.IntroSparseForm");
			node1.Nodes.Add(new Utils.DemoTreeNode("Sparse solvers","SparseTest.cs","MtxVecDemo.SparseTestForm"));
			treeView1.Nodes.Add(node1);

            node1 = new Utils.DemoTreeNode("Math Parser", null, "MtxVecDemo.IntroParser");
            node1.Nodes.Add(new Utils.DemoTreeNode("Scripting", "Scripting.cs", "MtxVecDemo.Scripting"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Powerfull math parser", "MathParser.cs", "MtxVecDemo.MathParser"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Vectorized performance", "ParserVectorized.cs", "MtxVecDemo.ParserVectorized"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Using math parser in real-case scenario", "Optim_Bounded.cs", "MtxVecDemo.Optim_Bounded"));
            treeView1.Nodes.Add(node1);

            node1 = new Utils.DemoTreeNode("Dew Math controls",null,null);
			node1.Nodes.Add(new Utils.DemoTreeNode("FloatEdit control","FloatEdit.cs","MtxVecDemo.FloatEditForm"));
			node1.Nodes.Add(new Utils.DemoTreeNode("ProgressDialog control","ProgressDialog.cs","MtxVecDemo.ProgressDialogForm"));
			node1.Nodes.Add(new Utils.DemoTreeNode("MtxDataSet control","DataSetDemo.cs","MtxVecDemo.DataSetDemo"));
            node1.Nodes.Add(new Utils.DemoTreeNode("MtxGridView control", "MtxGridViewDemo.cs", "MtxVecDemo.MtxGridViewDemo"));
            treeView1.Nodes.Add(node1);

            node1 = new Utils.DemoTreeNode("New in version 3.x", null, null);
            node1.Nodes.Add(new Utils.DemoTreeNode("Using expression evaluator for scripting", "Scripting.cs", "MtxVecDemo.Scripting"));
            node1.Nodes.Add(new Utils.DemoTreeNode("New MtxFastline style for TeeChart .NET", "MtxFastlineDemo.cs", "MtxVecDemo.MtxFastlineDemo"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Linear Programming", "LPDemo.cs", "MtxVecDemo.LPDemo"));
            node1.Nodes.Add(new Utils.DemoTreeNode("MtxGridView control", "MtxGridViewDemo.cs", "MtxVecDemo.MtxGridViewDemo"));
            node1.Nodes.Add(new Utils.DemoTreeNode("MtxDataSet control", "DataSetDemo.cs", "MtxVecDemo.DataSetDemo"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Numerical integration (1D)", "NumInt1D.cs", "MtxVecDemo.NumInt1D"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Powerfull math parser", "MathParser.cs", "MtxVecDemo.MathParser"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Simplex: Bounded constraints", "Optim_Bounded.cs", "MtxVecDemo.Optim_Bounded"));
            treeView1.Nodes.Add(node1);

			treeView1.Nodes.Add(new Utils.DemoTreeNode("MtxVec function list",null,"MtxVecDemo.FunctionListForm"));
			treeView1.Nodes.Add(new Utils.DemoTreeNode("Registering MtxVec",null,"MtxVecDemo.RegisterMtxVecForm"));
			treeView1.Nodes.Add(new Utils.DemoTreeNode("Quick start",null,"MtxVecDemo.QuickStartForm"));
		}

		private void OpenExample(Type exampleFormType, String filename) {
			// closing previously opened form...
			if (currentOpenForm != null) {
				tabPageExample.Controls.Remove(currentOpenForm);
				currentOpenForm.Dispose();
				currentOpenForm = null;
			}
			Form exampleForm = Activator.CreateInstance(exampleFormType) as Form;
			exampleForm.Dock = DockStyle.Fill;
			exampleForm.TopLevel = false;
			exampleForm.Parent = tabPageExample;
			exampleForm.FormBorderStyle = FormBorderStyle.None;
			exampleForm.Show();
			currentOpenForm = exampleForm;
			tabControl1.SelectedIndex = 0;
		}

		private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e) {
            Utils.DemoTreeNode node = e.Node as Utils.DemoTreeNode;
			if (node.FormType!=null)
				OpenExample(node.FormType,node.FileName);
			labelCurrent.Text = node.Text;
			if (node.FileName==null) {
				if (tabControl1.Controls.IndexOf(tabPageSource)!=-1)
					tabControl1.Controls.Remove(tabPageSource);
			}	else {
				if (tabControl1.Controls.IndexOf(tabPageSource)==-1)
					tabControl1.Controls.Add(tabPageSource);
			}
		}


		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e) {
			if (tabControl1.SelectedIndex == 1) {
				String path = Utils.SourcePath();
                Utils.DemoTreeNode node = treeView1.SelectedNode as Utils.DemoTreeNode;
				if (node.FileName==null) return;
				richTextBox1.LoadFile(path + node.FileName, RichTextBoxStreamType.PlainText);
				Utils.Highlight(richTextBox1);
			}
		}	
	}
}
