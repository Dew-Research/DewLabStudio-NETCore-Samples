using System;
using System.Reflection;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Dew.Demo;
using Dew.Math.Units;

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
            this.panel1.Size = new System.Drawing.Size(840, 79);
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
            this.panel2.Location = new System.Drawing.Point(0, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 30);
            this.panel2.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 79);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(168, 330);
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
            this.tabControl1.Size = new System.Drawing.Size(672, 330);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageExample
            // 
            this.tabPageExample.Location = new System.Drawing.Point(4, 4);
            this.tabPageExample.Name = "tabPageExample";
            this.tabPageExample.Size = new System.Drawing.Size(664, 302);
            this.tabPageExample.TabIndex = 0;
            this.tabPageExample.Text = "Example";
            // 
            // tabPageSource
            // 
            this.tabPageSource.Controls.Add(this.richTextBox1);
            this.tabPageSource.Location = new System.Drawing.Point(4, 4);
            this.tabPageSource.Name = "tabPageSource";
            this.tabPageSource.Size = new System.Drawing.Size(552, 260);
            this.tabPageSource.TabIndex = 1;
            this.tabPageSource.Text = "Source";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(552, 260);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(840, 439);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Dew Research - DSP Master v6";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSource.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion


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
