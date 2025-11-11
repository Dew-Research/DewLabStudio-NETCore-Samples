using System;
using System.Reflection;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Dew.Demo;
using Dew.Math.Units;
using Dew.Signal.Units;

namespace DSPDemo
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
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
			// TODO
			// Dew.Math.Units.MtxVec.Controller.Free(); // used to safely Free memory controller
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
            panel1.Size = new Size(933, 79);
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
            panel2.Location = new Point(0, 514);
            panel2.Name = "panel2";
            panel2.Size = new Size(933, 30);
            panel2.TabIndex = 1;
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Left;
            treeView1.Location = new Point(0, 79);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(168, 435);
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
            tabControl1.Size = new Size(765, 435);
            tabControl1.TabIndex = 3;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPageExample
            // 
            tabPageExample.Location = new Point(4, 4);
            tabPageExample.Name = "tabPageExample";
            tabPageExample.Size = new Size(757, 407);
            tabPageExample.TabIndex = 0;
            tabPageExample.Text = "Example";
            // 
            // tabPageSource
            // 
            tabPageSource.Controls.Add(richTextBox1);
            tabPageSource.Location = new Point(4, 4);
            tabPageSource.Name = "tabPageSource";
            tabPageSource.Size = new Size(552, 260);
            tabPageSource.TabIndex = 1;
            tabPageSource.Text = "Source";
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(552, 260);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(933, 544);
            Controls.Add(tabControl1);
            Controls.Add(treeView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Dew Research - DSP Master v6";
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}

		private void MainForm_Load(object sender, System.EventArgs e) {
			LoadTreeItems();
			labelCurrent.BackColor = Color.Transparent;
		}

		private void LoadTreeItems() {
			Utils.DemoTreeNode node1 = new Utils.DemoTreeNode("Introduction",null,"DSPDemo.IntroForm");
			treeView1.Nodes.Add(node1);
			node1 = new Utils.DemoTreeNode("What is new",null,"DSPDemo.WhatIsNewForm");
			treeView1.Nodes.Add(node1);
			node1 = new Utils.DemoTreeNode("Spectral analysis",null,"DSPDemo.IntroSpectralForm");
			node1.Nodes.Add(new Utils.DemoTreeNode("Windows","WindowsDemoForm.cs","DSPDemo.WindowsDemoForm"));
			node1.Nodes.Add(new Utils.DemoTreeNode("Cross-spectrum","CoherenceTestForm.cs","DSPDemo.CoherenceTestForm"));
			node1.Nodes.Add(new Utils.DemoTreeNode("Spectrum estimation","AutoRegressDemoForm.cs","DSPDemo.AutoRegressDemoForm"));
			node1.Nodes.Add(new Utils.DemoTreeNode("Chirp-Z-transform","CZTDemoForm.cs","DSPDemo.CZTDemoForm"));
			node1.Nodes.Add(new Utils.DemoTreeNode("Energy of bands","FrequencyBandsForm.cs","DSPDemo.FrequencyBandsForm"));
			node1.Nodes.Add(new Utils.DemoTreeNode("Cepstral analysis","CepstrumDemoForm.cs","DSPDemo.CepstrumDemoForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Signal browsing", "BrowseDemoForm.cs", "DSPDemo.BrowseDemoForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Spectrogram", "SpectrogramDemoForm.cs", "DSPDemo.SpectrogramDemoForm"));
			treeView1.Nodes.Add(node1);

			node1 = new Utils.DemoTreeNode("Spectrum peak analysis",null,"DSPDemo.IntroPeakSpectralForm");
			node1.Nodes.Add(new Utils.DemoTreeNode("Peak marking","PeakMarkingBasicForm.cs","DSPDemo.PeakMarkingBasicForm"));
			node1.Nodes.Add(new Utils.DemoTreeNode("Peak formatting","PeakMarkingFormattingForm.cs","DSPDemo.PeakMarkingFormattingForm"));
			node1.Nodes.Add(new Utils.DemoTreeNode("Peak filtering","PeakFilteringForm.cs","DSPDemo.PeakFilteringForm"));
			node1.Nodes.Add(new Utils.DemoTreeNode("Peak interpolation","PeakInterpolateForm.cs","DSPDemo.PeakInterpolateForm"));
			node1.Nodes.Add(new Utils.DemoTreeNode("Order tracking","OrderTrackingForm.cs","DSPDemo.OrderTrackingForm"));
			node1.Nodes.Add(new Utils.DemoTreeNode("Amplt ratios","AmpltRatiosForm.cs","DSPDemo.AmpltRatiosForm"));
			treeView1.Nodes.Add(node1);

			node1 = new Utils.DemoTreeNode("Higher order spectral analysis",null,"DSPDemo.IntroHigherSpectralForm");
			node1.Nodes.Add(new Utils.DemoTreeNode("Bicoherence","BispectrumTestForm.cs","DSPDemo.BispectrumTestForm"));
			node1.Nodes.Add(new Utils.DemoTreeNode("Bicoherence surface","BispectrumSurface.cs","DSPDemo.BispectrumSurface"));
			node1.Nodes.Add(new Utils.DemoTreeNode("Bicoherence grid","BiSpectrumGridForm.cs","DSPDemo.BiSpectrumGridForm"));
			node1.Nodes.Add(new Utils.DemoTreeNode("Bicoherence test","BicoherenceTestForm.cs","DSPDemo.BicoherenceTestForm"));
            treeView1.Nodes.Add(node1);

            node1 = new Utils.DemoTreeNode("Kalman filtering", null, "DSPDemo.IntroKalmanForm");
            node1.Nodes.Add(new Utils.DemoTreeNode("Basic example/tutorial", "KalmanBasicForm.cs", "DSPDemo.KalmanBasicForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Standard filter example", "KalmanStdExampleForm.cs", "DSPDemo.KalmanStdExampleForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Extended/non-linear filter example", "KalmanExtExampleForm.cs", "DSPDemo.KalmanExtExampleForm"));
            treeView1.Nodes.Add(node1);

            node1 = new Utils.DemoTreeNode("Rate conversion", null, "DSPDemo.IntroSignalRateForm");
            node1.Nodes.Add(new Utils.DemoTreeNode("Decimation/Interpolation", "InterpolateDecimateForm.cs", "DSPDemo.InterpolateDecimateForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Zoom-spectrum", "DemodulatorForm.cs", "DSPDemo.DemodulatorForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Signal modulator", "ModulatorForm.cs", "DSPDemo.ModulatorForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Narrow bandpass", "NarrowBandpassForm.cs", "DSPDemo.NarrowBandpassForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Envelope detection", "EnvelopeDemoForm.cs", "DSPDemo.EnvelopeDemoForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Rate conversion", "RateConvertForm.cs", "DSPDemo.RateConvertForm"));
            treeView1.Nodes.Add(node1);

            node1 = new Utils.DemoTreeNode("Signal processing", null, "DSPDemo.IntroSignalForm");
            node1.Nodes.Add(new Utils.DemoTreeNode("Window based filters", "WindowFiltersForm.cs", "DSPDemo.WindowFiltersForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Parks McClellan", "OptimalFiltersForm.cs", "DSPDemo.OptimalFiltersForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("IIR Filters", "IIRFilteringForm.cs", "DSPDemo.IIRFilteringForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Pole-Zero", "IIRZerosForm.cs", "DSPDemo.IIRZerosForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Group delay", "IIRGroupDelayForm.cs", "DSPDemo.IIRGroupDelayForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Integration/Differentiation", "DifferentiatorForm.cs", "DSPDemo.DifferentiatorForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Phase shifters", "PhaseShifterForm.cs", "DSPDemo.PhaseShifterForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Savitzky-Golay filter", "SavGolayDemoForm.cs", "DSPDemo.SavGolayDemoForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Median filter", "MedianDemoForm.cs", "DSPDemo.MedianDemoForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Signal generator", "GeneratorDemoForm.cs", "DSPDemo.GeneratorDemoForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Discrete series", "DiscreteSeriesDemoForm.cs", "DSPDemo.DiscreteSeriesDemoForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Phase demo", "PhaseDemoForm.cs", "DSPDemo.PhaseDemoForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Filter editor", "FilterEditorForm.cs", "DSPDemo.FilterEditorForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Signal analysis", "SignalAnalysisDemoForm.cs", "DSPDemo.SignalAnalysisDemoForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Circular buffer", "CircularBufferForm.cs", "DSPDemo.CircularBufferForm"));						
			treeView1.Nodes.Add(node1);

            node1 = new Utils.DemoTreeNode("ASIO Support", null, "DSPDemo.IntroAsioForm");
            node1.Nodes.Add(new Utils.DemoTreeNode("ASIO playback", "AsioPlaybackForm.cs", "DSPDemo.AsioPlaybackForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("ASIO recording", "AsioRecordForm.cs", "DSPDemo.AsioRecordForm"));
            treeView1.Nodes.Add(node1);

			node1 = new Utils.DemoTreeNode("Playback and Recording",null,"DSPDemo.IntroPlaybackForm");            
            node1.Nodes.Add(new Utils.DemoTreeNode("Monitor playback", "PlaybackDemoForm.cs", "DSPDemo.PlaybackDemoForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Monitor recording", "MonitorDemoForm.cs", "DSPDemo.MonitorDemoForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Recording trigger", "TriggerDemoForm.cs", "DSPDemo.TriggerDemoForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Cross spectrum", "OnlineCoherenceForm.cs", "DSPDemo.OnlineCoherenceForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Bicoherence", "OnlineBicoherenceForm.cs", "DSPDemo.OnlineBicoherenceForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Phase scope", "PhaseScopeForm.cs", "DSPDemo.PhaseScopeForm"));
            node1.Nodes.Add(new Utils.DemoTreeNode("Lissajous", "LissajousScopeForm.cs", "DSPDemo.LissajousScopeForm"));
			treeView1.Nodes.Add(node1);

			node1 = new Utils.DemoTreeNode("Applications",null,"DSPDemo.IntroApplicationForm");
			treeView1.Nodes.Add(node1);
			node1 = new Utils.DemoTreeNode("Design",null,"DSPDemo.IntroDesignForm");
			treeView1.Nodes.Add(node1);
			node1 = new Utils.DemoTreeNode("Performance",null,"DSPDemo.IntroPerformanceForm");
			treeView1.Nodes.Add(node1);
			node1 = new Utils.DemoTreeNode("Function list",null,"DSPDemo.IntroFunctionListForm");
			treeView1.Nodes.Add(node1);
			node1 = new Utils.DemoTreeNode("Component list",null,"DSPDemo.IntroComponentsListForm");
			treeView1.Nodes.Add(node1);
			node1 = new Utils.DemoTreeNode("Register",null,"DSPDemo.RegisterSignalForm");
			treeView1.Nodes.Add(node1);						
		}

		private void OpenExample(Type exampleFormType, String filename) {
			// closing previously opened form...
			if (currentOpenForm != null) {
				tabPageExample.Controls.Remove(currentOpenForm);
				currentOpenForm.Dispose();
				currentOpenForm = null;
			}
            Object Obj = Activator.CreateInstance(exampleFormType);
			Form exampleForm =  Obj as Form;
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

		private Form currentOpenForm;

		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e) {
			if (tabControl1.SelectedIndex == 1) {			
                String path = Utils.SourcePath();
				Utils.DemoTreeNode node = treeView1.SelectedNode as Utils.DemoTreeNode;
				if (node.FileName==null) return;
				richTextBox1.LoadFile(path + node.FileName, RichTextBoxStreamType.PlainText);
				Utils.Highlight(richTextBox1);
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
            Math387.ERaise("Test");
        }
	}	
}
