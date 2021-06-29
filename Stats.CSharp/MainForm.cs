using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace StatsMasterDemo
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
            this.panel1.Size = new System.Drawing.Size(851, 79);
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
            this.panel2.Location = new System.Drawing.Point(0, 476);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 30);
            this.panel2.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 79);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(168, 397);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPageExample);
            this.tabControl1.Controls.Add(this.tabPageSource);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(168, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(683, 397);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageExample
            // 
            this.tabPageExample.Location = new System.Drawing.Point(4, 4);
            this.tabPageExample.Name = "tabPageExample";
            this.tabPageExample.Size = new System.Drawing.Size(675, 369);
            this.tabPageExample.TabIndex = 0;
            this.tabPageExample.Text = "Example";
            // 
            // tabPageSource
            // 
            this.tabPageSource.Controls.Add(this.richTextBox1);
            this.tabPageSource.Location = new System.Drawing.Point(4, 4);
            this.tabPageSource.Name = "tabPageSource";
            this.tabPageSource.Size = new System.Drawing.Size(637, 337);
            this.tabPageSource.TabIndex = 1;
            this.tabPageSource.Text = "Source";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(637, 337);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(851, 506);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Dew Stats Master Demo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSource.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            LoadTreeItems();
            // Select first item...
            treeView1.SelectedNode = treeView1.TopNode;
            treeView1.SelectedNode.Expand();
            labelCurrent.BackColor = Color.Transparent;
        }

        private void LoadTreeItems()
        {
            // Intro stuff
            Utils.DemoTreeNode node1 = new Utils.DemoTreeNode("Introduction", null, "StatsMasterDemo.IntroductionForm");
            node1.Nodes.Add(new Utils.DemoTreeNode("What's new", null, "StatsMasterDemo.WhatsNewForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Complete function list", null, "StatsMasterDemo.FunctionListForm"));
            treeView1.Nodes.Add(node1);

            // Random number generators
            treeView1.Nodes.Add(new Utils.DemoTreeNode("Random number generators", "RandGen.cs", "StatsMasterDemo.RandGen"));

            // Binary test wizard
            treeView1.Nodes.Add(new Utils.DemoTreeNode("Binary tests", "BinaryTestWizard.cs", "StatsMasterDemo.ShowBTWizard"));

            node1 = new Utils.DemoTreeNode("Curve fitting", null, null);
            node1.Nodes.Add(new Utils.DemoTreeNode("Growth and other models", "GrowthModelWizard.cs", "StatsMasterDemo.ShowGMWizard"));
            treeView1.Nodes.Add(node1);

            // Regression
            node1 = new Utils.DemoTreeNode("Regression", null, null);
            node1.Nodes.Add(new Utils.DemoTreeNode("Linear regression models", "RModels.cs", "StatsMasterDemo.RModels"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Regression wizard", "RegWizard.cs", "StatsMasterDemo.ShowRegWizard"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Non-linear regression models", "NISTNonLinear.cs", "StatsMasterDemo.NISTNonLinear"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Logistic regression", "LogistReg.cs", "StatsMasterDemo.LogistReg"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Principal Component Regression", "PCRegWizard.cs", "StatsMasterDemo.ShowPCRWizard"));
            treeView1.Nodes.Add(node1);

            // Hypothesis testing
            node1 = new Utils.DemoTreeNode("Hypothesis testing", null, null);
            node1.Nodes.Add(new Utils.DemoTreeNode("GOF Chi2 test", "GOFChi2.cs", "StatsMasterDemo.GOFChi2"));
            node1.Nodes.Add(new Utils.DemoTreeNode("GOF Kolmogorov-Smirnov test", "GOFKS.cs", "StatsMasterDemo.GOFKS"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Hypothesis testing Wizard", "HypTestWizard.cs", "StatsMasterDemo.ShowHTWizard"));
            treeView1.Nodes.Add(node1);

            // Multivariate analysis
            node1 = new Utils.DemoTreeNode("Multivariate analysis", null, null);
            node1.Nodes.Add(new Utils.DemoTreeNode("Principal Component Analysis", "PCAWizard.cs", "StatsMasterDemo.ShowPCAWizard"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Multidimensional Scaling", "MDSWizard.cs", "StatsMasterDemo.ShowMDSWizard"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Item Analysis", "ItemAnalysis.cs", "StatsMasterDemo.ItemAnalysis"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Hotelling T2 test", "H2Wizard.cs", "StatsMasterDemo.ShowH2Wizard"));
            treeView1.Nodes.Add(node1);

            // Quality control charts
            node1 = new Utils.DemoTreeNode("Quality control charts", null, null);
            node1.Nodes.Add(new Utils.DemoTreeNode("Pareto chart", "ParetoDemo.cs", "StatsMasterDemo.ParetoDemo"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Variable control charts", "QCCVariable.cs", "StatsMasterDemo.QCCVariable"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Attribute control charts", "QCCAttribute.cs", "StatsMasterDemo.QCCAttribute"));
            node1.Nodes.Add(new Utils.DemoTreeNode("EWMA charts", "QCCEWMA.cs", "StatsMasterDemo.QCCEWMA"));
            node1.Nodes.Add(new Utils.DemoTreeNode("CP and CPK charts", "QCCPChart.cs", "StatsMasterDemo.QCCPChart"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Levey-Jennings control chart", "QCLevey.cs", "StatsMasterDemo.QCLevey"));
            treeView1.Nodes.Add(node1);

            // Probability plots
            treeView1.Nodes.Add((new Utils.DemoTreeNode("Probability plots", "QQPlotDemo.cs", "StatsMasterDemo.QQPlotDemo")));

            // Time series analysis
            node1 = new Utils.DemoTreeNode("Time series analysis", null, null);
            node1.Nodes.Add(new Utils.DemoTreeNode("ACF and PACF plots", "TSACF.cs", "StatsMasterDemo.TSACF"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Exponential smoothing", "TSExpSmooth.cs", "StatsMasterDemo.TSExpSmooth"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Decomposition forecasting", "DecForecastWizard.cs", "StatsMasterDemo.ShowDecForWizard"));
            node1.Nodes.Add(new Utils.DemoTreeNode("ARMA/ARIMA model simulations", "TSARIMASim.cs", "StatsMasterDemo.TSARIMASim"));
            node1.Nodes.Add(new Utils.DemoTreeNode("ARMA/ARIMA forecasting", "ARMAWizard.cs", "StatsMasterDemo.ShowARMAWizard"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Using ARAR model", "TSARAR.cs", "StatsMasterDemo.TSARAR"));
            treeView1.Nodes.Add(node1);

            // NIST statistical tests
            node1 = new Utils.DemoTreeNode("NIST statistical tests", null, "StatsMasterDemo.NISTIntro");
            node1.Nodes.Add(new Utils.DemoTreeNode("Non-linear regression models", "NISTNonLinear.cs", "StatsMasterDemo.NISTNonLinear"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Analysis of variance", "NISTANOVA.cs", "StatsMasterDemo.NISTANOVA"));
            treeView1.Nodes.Add(node1);

            // TeeChart .NET (lite or registered) series
            node1 = new Utils.DemoTreeNode("TeeChart.NET goodies", null, "StatsMasterDemo.TeeChartIntro");
            node1.Nodes.Add((new Utils.DemoTreeNode("Probability plot series", "QQPlotDemo.cs", "StatsMasterDemo.QQPlotDemo")));
            node1.Nodes.Add(new Utils.DemoTreeNode("Quality control series", "QCCVariable.cs", "StatsMasterDemo.QCCVariable"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Histogram", "QCCPChart.cs", "StatsMasterDemo.QCCPChart"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Dot Plot", "DotPlotDemo.cs", "StatsMasterDemo.DotPlotDemo"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Biplot", "Steema_BiPlot.cs", "StatsMasterDemo.Steema_BiPlot"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Box Plot", "Steema_BoxPlot.cs", "StatsMasterDemo.Steema_BoxPlot"));
            treeView1.Nodes.Add(node1);

            // Order form
            treeView1.Nodes.Add((new Utils.DemoTreeNode("How to order", null, "StatsMasterDemo.OrderForm")));

            // Quick start
            treeView1.Nodes.Add((new Utils.DemoTreeNode("Quick start", null, "StatsMasterDemo.QuickStart")));

        }

        private void OpenExample(Type exampleFormType, String filename)
        {
            // closing previously opened form...
            if (currentOpenForm != null)
            {
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

        private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            Utils.DemoTreeNode node = e.Node as Utils.DemoTreeNode;
            if (node.FormType != null)
                OpenExample(node.FormType, node.FileName);
            labelCurrent.Text = node.Text;
            if (node.FileName == null)
            {
                if (tabControl1.Controls.IndexOf(tabPageSource) != -1)
                    tabControl1.Controls.Remove(tabPageSource);
            }
            else
            {
                if (tabControl1.Controls.IndexOf(tabPageSource) == -1)
                    tabControl1.Controls.Add(tabPageSource);
            }
        }

        private Form currentOpenForm;

        private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                String path = Utils.ReadDemoPath();
                Utils.DemoTreeNode node = treeView1.SelectedNode as Utils.DemoTreeNode;
                if (node.FileName == null) return;
                richTextBox1.LoadFile(path + node.FileName, RichTextBoxStreamType.PlainText);
                Utils.Highlight(richTextBox1);
            }
        }

    }
}
