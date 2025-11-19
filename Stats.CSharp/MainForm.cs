using System;
using System.Drawing;
using System.Windows.Forms;
using Dew.Stats.Tee;
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
        private Splitter splitter1;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public MainForm()
        {
            // Get Dew.Stats.Tee series registered with TeeChart
            // Without this registration, Chart Editor would raise errors when displaying series editors
            //
            StatsTee.RegisterSeries();
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
            panel1 = new Panel();
            labelCurrent = new Label();
            panel2 = new Panel();
            treeView1 = new TreeView();
            tabControl1 = new TabControl();
            tabPageExample = new TabPage();
            tabPageSource = new TabPage();
            richTextBox1 = new RichTextBox();
            splitter1 = new Splitter();
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
            panel1.Size = new Size(851, 79);
            panel1.TabIndex = 0;
            // 
            // labelCurrent
            // 
            labelCurrent.BackColor = Color.Transparent;
            labelCurrent.Font = new Font("Arial", 15F, FontStyle.Bold);
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
            panel2.Location = new Point(0, 476);
            panel2.Name = "panel2";
            panel2.Size = new Size(851, 30);
            panel2.TabIndex = 1;
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Left;
            treeView1.Location = new Point(0, 79);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(250, 397);
            treeView1.TabIndex = 2;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Controls.Add(tabPageExample);
            tabControl1.Controls.Add(tabPageSource);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(250, 79);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(601, 397);
            tabControl1.TabIndex = 3;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPageExample
            // 
            tabPageExample.Location = new Point(4, 4);
            tabPageExample.Name = "tabPageExample";
            tabPageExample.Size = new Size(593, 369);
            tabPageExample.TabIndex = 0;
            tabPageExample.Text = "Example";
            // 
            // tabPageSource
            // 
            tabPageSource.Controls.Add(richTextBox1);
            tabPageSource.Location = new Point(4, 4);
            tabPageSource.Name = "tabPageSource";
            tabPageSource.Size = new Size(675, 369);
            tabPageSource.TabIndex = 1;
            tabPageSource.Text = "Source";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Window;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Courier New", 9F);
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(675, 369);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(250, 79);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 397);
            splitter1.TabIndex = 4;
            splitter1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(851, 506);
            Controls.Add(splitter1);
            Controls.Add(tabControl1);
            Controls.Add(treeView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Dew Stats Master Demo";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPageSource.ResumeLayout(false);
            ResumeLayout(false);
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
            treeView1.Nodes.Add(new Utils.DemoTreeNode("Binary tests", "ShowBTWizard.cs", "StatsMasterDemo.ShowBTWizard"));

            node1 = new Utils.DemoTreeNode("Curve fitting", null, null);
            node1.Nodes.Add(new Utils.DemoTreeNode("Growth and other models", "ShowGMWizard.cs", "StatsMasterDemo.ShowGMWizard"));
            treeView1.Nodes.Add(node1);

            // Regression
            node1 = new Utils.DemoTreeNode("Regression", null, null);
            node1.Nodes.Add(new Utils.DemoTreeNode("Linear regression models", "RModels.cs", "StatsMasterDemo.RModels"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Regression wizard", "ShowRegWizard.cs", "StatsMasterDemo.ShowRegWizard"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Non-linear regression models", "NISTNonLinear.cs", "StatsMasterDemo.NISTNonLinear"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Logistic regression", "LogistReg.cs", "StatsMasterDemo.LogistReg"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Principal Component Regression", "ShowPCRWizard.cs", "StatsMasterDemo.ShowPCRWizard"));
            treeView1.Nodes.Add(node1);

            // Hypothesis testing
            node1 = new Utils.DemoTreeNode("Hypothesis testing", null, null);
            node1.Nodes.Add(new Utils.DemoTreeNode("GOF Chi2 test", "GOFChi2.cs", "StatsMasterDemo.GOFChi2"));
            node1.Nodes.Add(new Utils.DemoTreeNode("GOF Kolmogorov-Smirnov test", "GOFKS.cs", "StatsMasterDemo.GOFKS"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Hypothesis testing Wizard", "ShowHTWizard.cs", "StatsMasterDemo.ShowHTWizard"));
            treeView1.Nodes.Add(node1);

            // Multivariate analysis
            node1 = new Utils.DemoTreeNode("Multivariate analysis", null, null);
            node1.Nodes.Add(new Utils.DemoTreeNode("Principal Component Analysis", "PCAWizard.cs", "StatsMasterDemo.ShowPCAWizard"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Multidimensional Scaling", "ShowMDSWizard.cs", "StatsMasterDemo.ShowMDSWizard"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Item Analysis", "ItemAnalysis.cs", "StatsMasterDemo.ItemAnalysis"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Hotelling T2 test", "ShowH2Wizard.cs", "StatsMasterDemo.ShowH2Wizard"));
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
            node1.Nodes.Add(new Utils.DemoTreeNode("Decomposition forecasting", "ShowDecForWizard.cs", "StatsMasterDemo.ShowDecForWizard"));
            node1.Nodes.Add(new Utils.DemoTreeNode("ARMA/ARIMA model simulations", "TSARIMASim.cs", "StatsMasterDemo.TSARIMASim"));
            node1.Nodes.Add(new Utils.DemoTreeNode("ARMA/ARIMA forecasting", "ShowARMAWizard.cs", "StatsMasterDemo.ShowARMAWizard"));
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
