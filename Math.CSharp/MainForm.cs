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
            //ClMtxVec.clPlatform().Free();
			if( disposing )
			{
				if (components != null) 
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            labelCurrent = new Label();
            panel2 = new Panel();
            treeView1 = new TreeView();
            tabControl1 = new TabControl();
            tabPageExample = new TabPage();
            tabPageSource = new TabPage();
            richTextBox1 = new RichTextBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageSource.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(labelCurrent);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 79);
            panel1.TabIndex = 0;
            // 
            // labelCurrent
            // 
            labelCurrent.BackColor = Color.Transparent;
            labelCurrent.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelCurrent.Location = new Point(190, 36);
            labelCurrent.Name = "labelCurrent";
            labelCurrent.Size = new Size(516, 26);
            labelCurrent.TabIndex = 0;
            labelCurrent.Text = "label1";
            labelCurrent.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 533);
            panel2.Name = "panel2";
            panel2.Size = new Size(960, 30);
            panel2.TabIndex = 1;
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Left;
            treeView1.Location = new Point(0, 79);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(168, 454);
            treeView1.TabIndex = 2;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Controls.Add(tabPageExample);
            tabControl1.Controls.Add(tabPageSource);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(168, 79);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(792, 454);
            tabControl1.TabIndex = 3;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPageExample
            // 
            tabPageExample.Location = new Point(4, 4);
            tabPageExample.Name = "tabPageExample";
            tabPageExample.Size = new Size(784, 426);
            tabPageExample.TabIndex = 0;
            tabPageExample.Text = "Example";
            // 
            // tabPageSource
            // 
            tabPageSource.Controls.Add(richTextBox1);
            tabPageSource.Location = new Point(4, 4);
            tabPageSource.Name = "tabPageSource";
            tabPageSource.Size = new Size(766, 406);
            tabPageSource.TabIndex = 1;
            tabPageSource.Text = "Source";
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(766, 406);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(960, 563);
            Controls.Add(tabControl1);
            Controls.Add(treeView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Dew Lab Studio for .NET - MtxVec Demo";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPageSource.ResumeLayout(false);
            ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles(); // XP themes support
            Application.Run(new MainForm());
		}

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
            node1.Nodes.Add(new Utils.DemoTreeNode("Multiplying small matrices", "SmallMatrixMul.cs", "MtxVecDemo.SmallMatrixForm"));
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
            node1.Nodes.Add(new Utils.DemoTreeNode("Efficient multi-threading", "MtxVecThreading.cs", "MtxVecDemo.MtxVecThreadingForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("If clause multi-threading", "IfThenForm.cs", "MtxVecDemo.IfThenForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Compound expressions", "CompoundExpressions.cs", "MtxVecDemo.CompoundExpressionsForm"));
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
