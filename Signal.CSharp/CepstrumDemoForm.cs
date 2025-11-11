using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Dew.Math;
using Dew.Signal;
using Dew.Signal.Units;
using Dew.Signal.Tee;
using Dew.Signal.Editors;
using Dew.Demo;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for CepstrumDemoForm.
	/// </summary>
	public class CepstrumDemoForm : System.Windows.Forms.Form
	{

		private TVec data;

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private Dew.Signal.TSignal Signal1;
		private Dew.Signal.TSignalRead SignalRead1;
		private Dew.Signal.TSpectrumAnalyzer SpectrumAnalyzer1;
		private System.Windows.Forms.ComboBox cepstrumComboBox;
		private System.Windows.Forms.Splitter splitter1;
        private SpectrumChart SpectrumChart1;
		private Steema.TeeChart.Styles.FastLine SpectrumSeries;
        private Steema.TeeChart.Styles.Points SpectrumMarks;
        private Button CepstrumChartButton;
        private Button SpectrumChartButton;
        private Button button1;
        private Label label1;
        private Steema.TeeChart.Editor ChartEditor;
        private SpectrumAnalyzerDialog SpectrumAnalyzerDialog;
        private SignalChart signalChart1;
        private Steema.TeeChart.Styles.FastLine CepstrumSeries;
        private Steema.TeeChart.Styles.Points CepstrumMarks;
        private Steema.TeeChart.Editor CepstrumChartEditor;
        private CheckBox MarkCursorBox;
		private System.ComponentModel.IContainer components;
        private SpectrumMarkTool smt;
        private SignalMarkTool signalMarkTool;

		public CepstrumDemoForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			SpectrumChart1.Spectrums.Add();
			SpectrumChart1.Spectrums[0].Input = SpectrumAnalyzer1;
			SpectrumChart1.Spectrums[0].Series = SpectrumSeries;

			smt = new SpectrumMarkTool(SpectrumChart1.Chart);
			smt.CursorActive = true;
			smt.DoubleClickClear = true;
			smt.PeakFilterMode = false;
			smt.MarkMode = SpectrumMarkMode.mmSingle;
			smt.MarkType = SpectrumMarkType.mtAmplt;
			smt.MarkSeries = SpectrumChart1.Series[1];
			smt.Series =  SpectrumChart1.Series[0];
			smt.AmpltFormat = "0.00#";
			smt.PhaseFormat = "0.00#";
			smt.FreqFormat = "0.00#";
			smt.LabelHeaders = true;
			smt.PeakZoomBand = false;
			SpectrumChart1.Tools.Add(smt);

			signalChart1.Signals.Add();
			signalChart1.Signals[0].Input = Signal1;
			signalChart1.Signals[0].Series = CepstrumSeries;

			signalMarkTool = new SignalMarkTool(signalChart1.Chart);
            signalMarkTool.CursorActive = true;
            signalMarkTool.DoubleClickClear = true;
            signalMarkTool.MarkSeries = signalChart1.Series[1];
            signalMarkTool.Series = signalChart1.Series[0];
            signalMarkTool.AmpltFormat = "0.00#";
            signalMarkTool.TimeFormat = "0.00#";
            signalMarkTool.MarkMode = SignalMarkMode.tmMaximum;

			signalChart1.Tools.Add(signalMarkTool);

			SignalRead1.Length = 4096;
            SignalRead1.FileName = Utils.SourcePath() + @"\Data\bz.sfs";
			SignalRead1.OverlappingPercent = 50;
			SignalRead1.OpenFile();
			data = new TVec();
			cepstrumComboBox.SelectedIndex = 0;
			
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CepstrumDemoForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MarkCursorBox = new System.Windows.Forms.CheckBox();
            this.CepstrumChartButton = new System.Windows.Forms.Button();
            this.SpectrumChartButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cepstrumComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.signalChart1 = new Dew.Signal.Tee.SignalChart();
            this.CepstrumSeries = new Steema.TeeChart.Styles.FastLine();
            this.CepstrumMarks = new Steema.TeeChart.Styles.Points();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SpectrumChart1 = new Dew.Signal.Tee.SpectrumChart();
            this.SpectrumSeries = new Steema.TeeChart.Styles.FastLine();
            this.SpectrumMarks = new Steema.TeeChart.Styles.Points();
            this.Signal1 = new Dew.Signal.TSignal(this.components);
            this.SignalRead1 = new Dew.Signal.TSignalRead(this.components);
            this.SpectrumAnalyzer1 = new Dew.Signal.TSpectrumAnalyzer(this.components);
            this.ChartEditor = new Steema.TeeChart.Editor(this.components);
            this.SpectrumAnalyzerDialog = new Dew.Signal.Editors.SpectrumAnalyzerDialog(this.components);
            this.CepstrumChartEditor = new Steema.TeeChart.Editor(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signalChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpectrumChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(664, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MarkCursorBox);
            this.panel1.Controls.Add(this.CepstrumChartButton);
            this.panel1.Controls.Add(this.SpectrumChartButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cepstrumComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 537);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 36);
            this.panel1.TabIndex = 1;
            // 
            // MarkCursorBox
            // 
            this.MarkCursorBox.AutoSize = true;
            this.MarkCursorBox.Checked = true;
            this.MarkCursorBox.CheckState = System.Windows.Forms.CheckState.Checked;
             
            this.MarkCursorBox.Location = new System.Drawing.Point(570, 11);
            this.MarkCursorBox.Name = "MarkCursorBox";
            this.MarkCursorBox.Size = new System.Drawing.Size(82, 17);
            this.MarkCursorBox.TabIndex = 5;
            this.MarkCursorBox.Text = "Mark cursor";
            this.MarkCursorBox.UseVisualStyleBackColor = true;
            this.MarkCursorBox.CheckedChanged += new System.EventHandler(this.MarkCursorBox_CheckedChanged);
            // 
            // CepstrumChartButton
            // 
            this.CepstrumChartButton.Location = new System.Drawing.Point(237, 6);
            this.CepstrumChartButton.Name = "CepstrumChartButton";
            this.CepstrumChartButton.Size = new System.Drawing.Size(103, 23);
            this.CepstrumChartButton.TabIndex = 4;
            this.CepstrumChartButton.Text = "Cepstrum chart";
            this.CepstrumChartButton.UseVisualStyleBackColor = true;
            this.CepstrumChartButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // SpectrumChartButton
            // 
            this.SpectrumChartButton.Location = new System.Drawing.Point(118, 6);
            this.SpectrumChartButton.Name = "SpectrumChartButton";
            this.SpectrumChartButton.Size = new System.Drawing.Size(104, 23);
            this.SpectrumChartButton.TabIndex = 3;
            this.SpectrumChartButton.Text = "Spectrum chart";
            this.SpectrumChartButton.UseVisualStyleBackColor = true;
            this.SpectrumChartButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Spectrum";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cepstrum";
            // 
            // cepstrumComboBox
            // 
            this.cepstrumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cepstrumComboBox.Items.AddRange(new object[] {
            "Real",
            "Complex"});
            this.cepstrumComboBox.Location = new System.Drawing.Point(421, 8);
            this.cepstrumComboBox.Name = "cepstrumComboBox";
            this.cepstrumComboBox.Size = new System.Drawing.Size(121, 21);
            this.cepstrumComboBox.TabIndex = 0;
            this.cepstrumComboBox.SelectedIndexChanged += new System.EventHandler(this.cepstrumComboBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.signalChart1);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.SpectrumChart1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 441);
            this.panel2.TabIndex = 2;
            this.panel2.SizeChanged += new System.EventHandler(this.panel2_SizeChanged);
            // 
            // signalChart1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Grid.DrawEvery = 1;
            this.signalChart1.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Axes.Bottom.Labels.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Bottom.Labels.Font.Size = 9;
            this.signalChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            this.signalChart1.Axes.Bottom.Labels.Separation = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Bottom.MaximumOffset = 4;
            this.signalChart1.Axes.Bottom.MinimumOffset = 4;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Axes.Bottom.Title.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Title.Brush.Visible = true;
            this.signalChart1.Axes.Bottom.Title.Caption = "Spectral frequency (quefrency) [Hz]";
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Bottom.Title.Font.Size = 11;
            this.signalChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            this.signalChart1.Axes.Bottom.Title.Lines = new string[] {
        "Spectral frequency (quefrency) [Hz]"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Axes.Depth.Labels.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Depth.Labels.Font.Size = 9;
            this.signalChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Axes.Depth.Title.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart1.Axes.Depth.Title.Font.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Depth.Title.Font.Size = 11;
            this.signalChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Axes.DepthTop.Labels.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.DepthTop.Labels.Font.Size = 9;
            this.signalChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Axes.DepthTop.Title.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.DepthTop.Title.Font.Size = 11;
            this.signalChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Axes.Left.Labels.Brush.Solid = true;
            this.signalChart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart1.Axes.Left.Labels.Font.Brush.Solid = true;
            this.signalChart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Left.Labels.Font.Size = 9;
            this.signalChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Left.MaximumOffset = 4;
            this.signalChart1.Axes.Left.MinimumOffset = 4;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Axes.Left.Title.Brush.Solid = true;
            this.signalChart1.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart1.Axes.Left.Title.Font.Brush.Solid = true;
            this.signalChart1.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Left.Title.Font.Size = 11;
            this.signalChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Right.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Axes.Right.Labels.Brush.Solid = true;
            this.signalChart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart1.Axes.Right.Labels.Font.Brush.Solid = true;
            this.signalChart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Right.Labels.Font.Size = 9;
            this.signalChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Axes.Right.Title.Brush.Solid = true;
            this.signalChart1.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart1.Axes.Right.Title.Font.Brush.Solid = true;
            this.signalChart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Right.Title.Font.Size = 11;
            this.signalChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Axes.Top.Labels.Brush.Solid = true;
            this.signalChart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart1.Axes.Top.Labels.Font.Brush.Solid = true;
            this.signalChart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Top.Labels.Font.Size = 9;
            this.signalChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Axes.Top.Title.Brush.Solid = true;
            this.signalChart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart1.Axes.Top.Title.Font.Brush.Solid = true;
            this.signalChart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Top.Title.Font.Size = 11;
            this.signalChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.signalChart1.Color = System.Drawing.Color.Silver;
             
            this.signalChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Footer.Brush.Solid = true;
            this.signalChart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.signalChart1.Footer.Font.Brush.Solid = true;
            this.signalChart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Footer.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Footer.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Footer.Font.Size = 8;
            this.signalChart1.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Footer.ImageBevel.Brush.Solid = true;
            this.signalChart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Footer.Shadow.Brush.Solid = true;
            this.signalChart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.signalChart1.Header.Brush.Solid = true;
            this.signalChart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Header.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart1.Header.Font.Brush.Solid = true;
            this.signalChart1.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Header.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Header.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Header.Font.Size = 12;
            this.signalChart1.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Header.ImageBevel.Brush.Solid = true;
            this.signalChart1.Header.ImageBevel.Brush.Visible = true;
            this.signalChart1.Header.Lines = new string[] {
        "Cepstrum"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signalChart1.Header.Shadow.Brush.Solid = true;
            this.signalChart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Legend.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Legend.Brush.Solid = true;
            this.signalChart1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart1.Legend.Font.Brush.Solid = true;
            this.signalChart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Legend.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Legend.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Legend.Font.Size = 9;
            this.signalChart1.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Legend.ImageBevel.Brush.Solid = true;
            this.signalChart1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signalChart1.Legend.Shadow.Brush.Solid = true;
            this.signalChart1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Legend.Symbol.Shadow.Brush.Solid = true;
            this.signalChart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Legend.Title.Brush.Solid = true;
            this.signalChart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.signalChart1.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.signalChart1.Legend.Title.Font.Brush.Solid = true;
            this.signalChart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Legend.Title.Font.Size = 8;
            this.signalChart1.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Legend.Title.ImageBevel.Brush.Solid = true;
            this.signalChart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Legend.Title.Shadow.Brush.Solid = true;
            this.signalChart1.Legend.Title.Shadow.Brush.Visible = true;
            this.signalChart1.Legend.Visible = false;
            this.signalChart1.Location = new System.Drawing.Point(0, 203);
            this.signalChart1.Name = "signalChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            this.signalChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Panel.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Panel.Brush.Solid = true;
            this.signalChart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Panel.ImageBevel.Brush.Solid = true;
            this.signalChart1.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Panel.Shadow.Brush.Solid = true;
            this.signalChart1.Panel.Shadow.Brush.Visible = true;
            this.signalChart1.Series.Add(this.CepstrumSeries);
            this.signalChart1.Series.Add(this.CepstrumMarks);
            this.signalChart1.Size = new System.Drawing.Size(664, 238);
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.SubFooter.Brush.Solid = true;
            this.signalChart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.signalChart1.SubFooter.Font.Brush.Solid = true;
            this.signalChart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.SubFooter.Font.Shadow.Brush.Solid = true;
            this.signalChart1.SubFooter.Font.Shadow.Brush.Visible = true;
            this.signalChart1.SubFooter.Font.Size = 8;
            this.signalChart1.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.SubFooter.ImageBevel.Brush.Solid = true;
            this.signalChart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.SubFooter.Shadow.Brush.Solid = true;
            this.signalChart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.signalChart1.SubHeader.Brush.Solid = true;
            this.signalChart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart1.SubHeader.Font.Brush.Solid = true;
            this.signalChart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.SubHeader.Font.Shadow.Brush.Solid = true;
            this.signalChart1.SubHeader.Font.Shadow.Brush.Visible = true;
            this.signalChart1.SubHeader.Font.Size = 12;
            this.signalChart1.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.SubHeader.ImageBevel.Brush.Solid = true;
            this.signalChart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signalChart1.SubHeader.Shadow.Brush.Solid = true;
            this.signalChart1.SubHeader.Shadow.Brush.Visible = true;
            this.signalChart1.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Walls.Back.Brush.Solid = true;
            this.signalChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Walls.Back.ImageBevel.Brush.Solid = true;
            this.signalChart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Walls.Back.Shadow.Brush.Solid = true;
            this.signalChart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Walls.Bottom.Brush.Solid = true;
            this.signalChart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.signalChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Walls.Bottom.Shadow.Brush.Solid = true;
            this.signalChart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.signalChart1.Walls.Left.Brush.Solid = true;
            this.signalChart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Walls.Left.ImageBevel.Brush.Solid = true;
            this.signalChart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Walls.Left.Shadow.Brush.Solid = true;
            this.signalChart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.signalChart1.Walls.Right.Brush.Solid = true;
            this.signalChart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Walls.Right.ImageBevel.Brush.Solid = true;
            this.signalChart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Walls.Right.Shadow.Brush.Solid = true;
            this.signalChart1.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Zoom.Animated = true;
            // 
            // 
            // 
            this.signalChart1.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.signalChart1.Zoom.Brush.Solid = true;
            this.signalChart1.Zoom.Brush.Visible = false;
            this.signalChart1.Zoom.FullRepaint = true;
            this.signalChart1.Zoom.History = true;
            // 
            // 
            // 
            this.signalChart1.Zoom.Pen.Visible = true;
            this.signalChart1.Click += new System.EventHandler(this.signalChart1_Click_1);
            // 
            // CepstrumSeries
            // 
            this.CepstrumSeries.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.CepstrumSeries.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.CepstrumSeries.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.CepstrumSeries.Legend.Brush.Color = System.Drawing.Color.White;
            this.CepstrumSeries.Legend.Brush.Solid = true;
            this.CepstrumSeries.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.CepstrumSeries.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.CepstrumSeries.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.CepstrumSeries.Legend.Font.Brush.Solid = true;
            this.CepstrumSeries.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.CepstrumSeries.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.CepstrumSeries.Legend.Font.Shadow.Brush.Solid = true;
            this.CepstrumSeries.Legend.Font.Shadow.Brush.Visible = true;
            this.CepstrumSeries.Legend.Font.Size = 8;
            this.CepstrumSeries.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.CepstrumSeries.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.CepstrumSeries.Legend.ImageBevel.Brush.Solid = true;
            this.CepstrumSeries.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.CepstrumSeries.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.CepstrumSeries.Legend.Shadow.Brush.Solid = true;
            this.CepstrumSeries.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.CepstrumSeries.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.CepstrumSeries.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.CepstrumSeries.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CepstrumSeries.Marks.Brush.Solid = true;
            this.CepstrumSeries.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.CepstrumSeries.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.CepstrumSeries.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.CepstrumSeries.Marks.Font.Brush.Solid = true;
            this.CepstrumSeries.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.CepstrumSeries.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.CepstrumSeries.Marks.Font.Shadow.Brush.Solid = true;
            this.CepstrumSeries.Marks.Font.Shadow.Brush.Visible = true;
            this.CepstrumSeries.Marks.Font.Size = 8;
            this.CepstrumSeries.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.CepstrumSeries.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.CepstrumSeries.Marks.ImageBevel.Brush.Solid = true;
            this.CepstrumSeries.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.CepstrumSeries.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.CepstrumSeries.Marks.Shadow.Brush.Solid = true;
            this.CepstrumSeries.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.CepstrumSeries.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.CepstrumSeries.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.CepstrumSeries.Marks.Symbol.Brush.Solid = true;
            this.CepstrumSeries.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.CepstrumSeries.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.CepstrumSeries.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.CepstrumSeries.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.CepstrumSeries.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.CepstrumSeries.Marks.Symbol.Shadow.Brush.Solid = true;
            this.CepstrumSeries.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.CepstrumSeries.Marks.TailParams.Margin = 0F;
            this.CepstrumSeries.Marks.TailParams.PointerHeight = 8D;
            this.CepstrumSeries.Marks.TailParams.PointerWidth = 8D;
            this.CepstrumSeries.OriginalCursor = Steema.TeeChart.Drawing.Cursor.Current;
            this.CepstrumSeries.Title = "fastLine1";
            this.CepstrumSeries.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.CepstrumSeries.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.CepstrumSeries.XValues.DataMember = "X";
            this.CepstrumSeries.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.CepstrumSeries.YValues.DataMember = "Y";
            // 
            // CepstrumMarks
            // 
            this.CepstrumMarks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CepstrumMarks.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.CepstrumMarks.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.CepstrumMarks.Legend.Brush.Color = System.Drawing.Color.White;
            this.CepstrumMarks.Legend.Brush.Solid = true;
            this.CepstrumMarks.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.CepstrumMarks.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.CepstrumMarks.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.CepstrumMarks.Legend.Font.Brush.Solid = true;
            this.CepstrumMarks.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.CepstrumMarks.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.CepstrumMarks.Legend.Font.Shadow.Brush.Solid = true;
            this.CepstrumMarks.Legend.Font.Shadow.Brush.Visible = true;
            this.CepstrumMarks.Legend.Font.Size = 8;
            this.CepstrumMarks.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.CepstrumMarks.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.CepstrumMarks.Legend.ImageBevel.Brush.Solid = true;
            this.CepstrumMarks.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.CepstrumMarks.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.CepstrumMarks.Legend.Shadow.Brush.Solid = true;
            this.CepstrumMarks.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.CepstrumMarks.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.CepstrumMarks.Marks.Arrow.Visible = false;
            this.CepstrumMarks.Marks.ArrowLength = 8;
            // 
            // 
            // 
            this.CepstrumMarks.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.CepstrumMarks.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CepstrumMarks.Marks.Brush.Solid = true;
            this.CepstrumMarks.Marks.Brush.Visible = false;
            // 
            // 
            // 
            this.CepstrumMarks.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.CepstrumMarks.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.CepstrumMarks.Marks.Font.Brush.Solid = true;
            this.CepstrumMarks.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.CepstrumMarks.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.CepstrumMarks.Marks.Font.Shadow.Brush.Solid = true;
            this.CepstrumMarks.Marks.Font.Shadow.Brush.Visible = true;
            this.CepstrumMarks.Marks.Font.Size = 8;
            this.CepstrumMarks.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.CepstrumMarks.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.CepstrumMarks.Marks.ImageBevel.Brush.Solid = true;
            this.CepstrumMarks.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.CepstrumMarks.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.CepstrumMarks.Marks.Shadow.Brush.Solid = true;
            this.CepstrumMarks.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.CepstrumMarks.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.CepstrumMarks.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.CepstrumMarks.Marks.Symbol.Brush.Solid = true;
            this.CepstrumMarks.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.CepstrumMarks.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.CepstrumMarks.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.CepstrumMarks.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.CepstrumMarks.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.CepstrumMarks.Marks.Symbol.Shadow.Brush.Solid = true;
            this.CepstrumMarks.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.CepstrumMarks.Marks.TailParams.Margin = 0F;
            this.CepstrumMarks.Marks.TailParams.PointerHeight = 8D;
            this.CepstrumMarks.Marks.TailParams.PointerWidth = 8D;
            this.CepstrumMarks.Marks.Transparent = true;
            this.CepstrumMarks.Marks.Visible = true;
            this.CepstrumMarks.OriginalCursor = Steema.TeeChart.Drawing.Cursor.Current;
            // 
            // 
            // 
            // 
            // 
            // 
            this.CepstrumMarks.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CepstrumMarks.Pointer.Brush.Solid = true;
            this.CepstrumMarks.Pointer.Brush.Visible = true;
            this.CepstrumMarks.Pointer.HorizSize = 3;
            // 
            // 
            // 
            this.CepstrumMarks.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CepstrumMarks.Pointer.SizeDouble = 0D;
            this.CepstrumMarks.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.CepstrumMarks.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.CepstrumMarks.Pointer.VertSize = 3;
            this.CepstrumMarks.Title = "points1";
            this.CepstrumMarks.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.CepstrumMarks.XValues.DataMember = "X";
            this.CepstrumMarks.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.CepstrumMarks.YValues.DataMember = "Y";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 200);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(664, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // SpectrumChart1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Grid.DrawEvery = 1;
            this.SpectrumChart1.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart1.Axes.Bottom.Labels.Brush.Solid = true;
            this.SpectrumChart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.SpectrumChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart1.Axes.Bottom.Labels.Font.Size = 9;
            this.SpectrumChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.SpectrumChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            this.SpectrumChart1.Axes.Bottom.Labels.Separation = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            this.SpectrumChart1.Axes.Bottom.MaximumOffset = 4;
            this.SpectrumChart1.Axes.Bottom.MinimumOffset = 4;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart1.Axes.Bottom.Title.Brush.Solid = true;
            this.SpectrumChart1.Axes.Bottom.Title.Brush.Visible = true;
            this.SpectrumChart1.Axes.Bottom.Title.Caption = "Frequency [Hz]";
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.SpectrumChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart1.Axes.Bottom.Title.Font.Size = 11;
            this.SpectrumChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            this.SpectrumChart1.Axes.Bottom.Title.Lines = new string[] {
        "Frequency [Hz]"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart1.Axes.Depth.Labels.Brush.Solid = true;
            this.SpectrumChart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.SpectrumChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart1.Axes.Depth.Labels.Font.Size = 9;
            this.SpectrumChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.SpectrumChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart1.Axes.Depth.Title.Brush.Solid = true;
            this.SpectrumChart1.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart1.Axes.Depth.Title.Font.Brush.Solid = true;
            this.SpectrumChart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart1.Axes.Depth.Title.Font.Size = 11;
            this.SpectrumChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart1.Axes.DepthTop.Labels.Brush.Solid = true;
            this.SpectrumChart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.SpectrumChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart1.Axes.DepthTop.Labels.Font.Size = 9;
            this.SpectrumChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.SpectrumChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart1.Axes.DepthTop.Title.Brush.Solid = true;
            this.SpectrumChart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.SpectrumChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart1.Axes.DepthTop.Title.Font.Size = 11;
            this.SpectrumChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart1.Axes.Left.Labels.Brush.Solid = true;
            this.SpectrumChart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart1.Axes.Left.Labels.Font.Brush.Solid = true;
            this.SpectrumChart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart1.Axes.Left.Labels.Font.Size = 9;
            this.SpectrumChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.SpectrumChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            this.SpectrumChart1.Axes.Left.MaximumOffset = 4;
            this.SpectrumChart1.Axes.Left.MinimumOffset = 4;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart1.Axes.Left.Title.Brush.Solid = true;
            this.SpectrumChart1.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart1.Axes.Left.Title.Font.Brush.Solid = true;
            this.SpectrumChart1.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart1.Axes.Left.Title.Font.Size = 11;
            this.SpectrumChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart1.Axes.Right.Labels.Brush.Solid = true;
            this.SpectrumChart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart1.Axes.Right.Labels.Font.Brush.Solid = true;
            this.SpectrumChart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart1.Axes.Right.Labels.Font.Size = 9;
            this.SpectrumChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.SpectrumChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart1.Axes.Right.Title.Brush.Solid = true;
            this.SpectrumChart1.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart1.Axes.Right.Title.Font.Brush.Solid = true;
            this.SpectrumChart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart1.Axes.Right.Title.Font.Size = 11;
            this.SpectrumChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart1.Axes.Top.Labels.Brush.Solid = true;
            this.SpectrumChart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart1.Axes.Top.Labels.Font.Brush.Solid = true;
            this.SpectrumChart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart1.Axes.Top.Labels.Font.Size = 9;
            this.SpectrumChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.SpectrumChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart1.Axes.Top.Title.Brush.Solid = true;
            this.SpectrumChart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart1.Axes.Top.Title.Font.Brush.Solid = true;
            this.SpectrumChart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart1.Axes.Top.Title.Font.Size = 11;
            this.SpectrumChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.SpectrumChart1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
             
            this.SpectrumChart1.Dock = System.Windows.Forms.DockStyle.Top;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumChart1.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart1.Footer.Brush.Solid = true;
            this.SpectrumChart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart1.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.SpectrumChart1.Footer.Font.Brush.Solid = true;
            this.SpectrumChart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Footer.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Footer.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart1.Footer.Font.Size = 8;
            this.SpectrumChart1.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.Footer.ImageBevel.Brush.Solid = true;
            this.SpectrumChart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Footer.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SpectrumChart1.Header.Brush.Solid = true;
            this.SpectrumChart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart1.Header.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart1.Header.Font.Brush.Solid = true;
            this.SpectrumChart1.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Header.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Header.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart1.Header.Font.Size = 12;
            this.SpectrumChart1.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.Header.ImageBevel.Brush.Solid = true;
            this.SpectrumChart1.Header.ImageBevel.Brush.Visible = true;
            this.SpectrumChart1.Header.Lines = new string[] {
        "Frequency spectrum"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SpectrumChart1.Header.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart1.Legend.Brush.Solid = true;
            this.SpectrumChart1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart1.Legend.Font.Brush.Solid = true;
            this.SpectrumChart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Legend.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Legend.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart1.Legend.Font.Size = 9;
            this.SpectrumChart1.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.Legend.ImageBevel.Brush.Solid = true;
            this.SpectrumChart1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SpectrumChart1.Legend.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Legend.Symbol.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart1.Legend.Title.Brush.Solid = true;
            this.SpectrumChart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.SpectrumChart1.Legend.Title.Font.Brush.Solid = true;
            this.SpectrumChart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart1.Legend.Title.Font.Size = 8;
            this.SpectrumChart1.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.Legend.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Legend.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Legend.Title.Shadow.Brush.Visible = true;
            this.SpectrumChart1.Legend.Visible = false;
            this.SpectrumChart1.Location = new System.Drawing.Point(0, 0);
            this.SpectrumChart1.Name = "SpectrumChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            this.SpectrumChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SpectrumChart1.Panel.Brush.Solid = true;
            this.SpectrumChart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.Panel.ImageBevel.Brush.Solid = true;
            this.SpectrumChart1.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Panel.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Panel.Shadow.Brush.Visible = true;
            this.SpectrumChart1.Series.Add(this.SpectrumSeries);
            this.SpectrumChart1.Series.Add(this.SpectrumMarks);
            this.SpectrumChart1.Size = new System.Drawing.Size(664, 200);
            this.SpectrumChart1.SpectrumPart = Dew.Signal.Tee.SpectrumPart.sppAmplt;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumChart1.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart1.SubFooter.Brush.Solid = true;
            this.SpectrumChart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart1.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.SpectrumChart1.SubFooter.Font.Brush.Solid = true;
            this.SpectrumChart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.SubFooter.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart1.SubFooter.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart1.SubFooter.Font.Size = 8;
            this.SpectrumChart1.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.SubFooter.ImageBevel.Brush.Solid = true;
            this.SpectrumChart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.SubFooter.Shadow.Brush.Solid = true;
            this.SpectrumChart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumChart1.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SpectrumChart1.SubHeader.Brush.Solid = true;
            this.SpectrumChart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart1.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart1.SubHeader.Font.Brush.Solid = true;
            this.SpectrumChart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.SubHeader.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart1.SubHeader.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart1.SubHeader.Font.Size = 12;
            this.SpectrumChart1.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.SubHeader.ImageBevel.Brush.Solid = true;
            this.SpectrumChart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SpectrumChart1.SubHeader.Shadow.Brush.Solid = true;
            this.SpectrumChart1.SubHeader.Shadow.Brush.Visible = true;
            this.SpectrumChart1.TabIndex = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart1.Walls.Back.Brush.Solid = true;
            this.SpectrumChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.Walls.Back.ImageBevel.Brush.Solid = true;
            this.SpectrumChart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Walls.Back.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart1.Walls.Bottom.Brush.Solid = true;
            this.SpectrumChart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.SpectrumChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Walls.Bottom.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.SpectrumChart1.Walls.Left.Brush.Solid = true;
            this.SpectrumChart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.Walls.Left.ImageBevel.Brush.Solid = true;
            this.SpectrumChart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Walls.Left.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.SpectrumChart1.Walls.Right.Brush.Solid = true;
            this.SpectrumChart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.Walls.Right.ImageBevel.Brush.Solid = true;
            this.SpectrumChart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Walls.Right.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart1.Zoom.Animated = true;
            // 
            // 
            // 
            this.SpectrumChart1.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.SpectrumChart1.Zoom.Brush.Solid = true;
            this.SpectrumChart1.Zoom.Brush.Visible = false;
            this.SpectrumChart1.Zoom.FullRepaint = true;
            this.SpectrumChart1.Zoom.History = true;
            // 
            // 
            // 
            this.SpectrumChart1.Zoom.Pen.Visible = true;
            this.SpectrumChart1.Click += new System.EventHandler(this.SpectrumChart1_Click);
            // 
            // SpectrumSeries
            // 
            this.SpectrumSeries.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.SpectrumSeries.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumSeries.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumSeries.Legend.Brush.Color = System.Drawing.Color.White;
            this.SpectrumSeries.Legend.Brush.Solid = true;
            this.SpectrumSeries.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumSeries.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumSeries.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.SpectrumSeries.Legend.Font.Brush.Solid = true;
            this.SpectrumSeries.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumSeries.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumSeries.Legend.Font.Shadow.Brush.Solid = true;
            this.SpectrumSeries.Legend.Font.Shadow.Brush.Visible = true;
            this.SpectrumSeries.Legend.Font.Size = 8;
            this.SpectrumSeries.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumSeries.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumSeries.Legend.ImageBevel.Brush.Solid = true;
            this.SpectrumSeries.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumSeries.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumSeries.Legend.Shadow.Brush.Solid = true;
            this.SpectrumSeries.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumSeries.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumSeries.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumSeries.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SpectrumSeries.Marks.Brush.Solid = true;
            this.SpectrumSeries.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumSeries.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumSeries.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.SpectrumSeries.Marks.Font.Brush.Solid = true;
            this.SpectrumSeries.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumSeries.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumSeries.Marks.Font.Shadow.Brush.Solid = true;
            this.SpectrumSeries.Marks.Font.Shadow.Brush.Visible = true;
            this.SpectrumSeries.Marks.Font.Size = 8;
            this.SpectrumSeries.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumSeries.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumSeries.Marks.ImageBevel.Brush.Solid = true;
            this.SpectrumSeries.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumSeries.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.SpectrumSeries.Marks.Shadow.Brush.Solid = true;
            this.SpectrumSeries.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumSeries.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumSeries.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.SpectrumSeries.Marks.Symbol.Brush.Solid = true;
            this.SpectrumSeries.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumSeries.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumSeries.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.SpectrumSeries.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumSeries.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumSeries.Marks.Symbol.Shadow.Brush.Solid = true;
            this.SpectrumSeries.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumSeries.Marks.TailParams.Margin = 0F;
            this.SpectrumSeries.Marks.TailParams.PointerHeight = 8D;
            this.SpectrumSeries.Marks.TailParams.PointerWidth = 8D;
            this.SpectrumSeries.OriginalCursor = Steema.TeeChart.Drawing.Cursor.Current;
            this.SpectrumSeries.Title = "Spectrum";
            this.SpectrumSeries.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.SpectrumSeries.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.SpectrumSeries.XValues.DataMember = "X";
            this.SpectrumSeries.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.SpectrumSeries.YValues.DataMember = "Y";
            // 
            // SpectrumMarks
            // 
            this.SpectrumMarks.Color = System.Drawing.Color.OrangeRed;
            this.SpectrumMarks.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumMarks.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumMarks.Legend.Brush.Color = System.Drawing.Color.White;
            this.SpectrumMarks.Legend.Brush.Solid = true;
            this.SpectrumMarks.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumMarks.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumMarks.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.SpectrumMarks.Legend.Font.Brush.Solid = true;
            this.SpectrumMarks.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumMarks.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumMarks.Legend.Font.Shadow.Brush.Solid = true;
            this.SpectrumMarks.Legend.Font.Shadow.Brush.Visible = true;
            this.SpectrumMarks.Legend.Font.Size = 8;
            this.SpectrumMarks.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumMarks.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumMarks.Legend.ImageBevel.Brush.Solid = true;
            this.SpectrumMarks.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumMarks.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumMarks.Legend.Shadow.Brush.Solid = true;
            this.SpectrumMarks.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumMarks.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(41)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumMarks.Marks.Arrow.Visible = false;
            this.SpectrumMarks.Marks.ArrowLength = 10;
            // 
            // 
            // 
            this.SpectrumMarks.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumMarks.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SpectrumMarks.Marks.Brush.Solid = true;
            this.SpectrumMarks.Marks.Brush.Visible = false;
            // 
            // 
            // 
            this.SpectrumMarks.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumMarks.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.SpectrumMarks.Marks.Font.Brush.Solid = true;
            this.SpectrumMarks.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumMarks.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumMarks.Marks.Font.Shadow.Brush.Solid = true;
            this.SpectrumMarks.Marks.Font.Shadow.Brush.Visible = true;
            this.SpectrumMarks.Marks.Font.Size = 8;
            this.SpectrumMarks.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumMarks.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumMarks.Marks.ImageBevel.Brush.Solid = true;
            this.SpectrumMarks.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumMarks.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.SpectrumMarks.Marks.Shadow.Brush.Solid = true;
            this.SpectrumMarks.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumMarks.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumMarks.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.SpectrumMarks.Marks.Symbol.Brush.Solid = true;
            this.SpectrumMarks.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumMarks.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumMarks.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.SpectrumMarks.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumMarks.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumMarks.Marks.Symbol.Shadow.Brush.Solid = true;
            this.SpectrumMarks.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumMarks.Marks.TailParams.Margin = 0F;
            this.SpectrumMarks.Marks.TailParams.PointerHeight = 8D;
            this.SpectrumMarks.Marks.TailParams.PointerWidth = 8D;
            this.SpectrumMarks.Marks.Transparent = true;
            this.SpectrumMarks.Marks.Visible = true;
            this.SpectrumMarks.OriginalCursor = Steema.TeeChart.Drawing.Cursor.Current;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumMarks.Pointer.Brush.Color = System.Drawing.Color.OrangeRed;
            this.SpectrumMarks.Pointer.Brush.Solid = true;
            this.SpectrumMarks.Pointer.Brush.Visible = true;
            this.SpectrumMarks.Pointer.HorizSize = 3;
            // 
            // 
            // 
            this.SpectrumMarks.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(41)))), ((int)(((byte)(0)))));
            this.SpectrumMarks.Pointer.SizeDouble = 0D;
            this.SpectrumMarks.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.SpectrumMarks.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.SpectrumMarks.Pointer.VertSize = 3;
            this.SpectrumMarks.Title = "SpectrumMarks";
            this.SpectrumMarks.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.SpectrumMarks.XValues.DataMember = "X";
            this.SpectrumMarks.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.SpectrumMarks.YValues.DataMember = "Y";
            // 
            // Signal1
            // 
            this.Signal1.BandwidthL = 0D;
            this.Signal1.BlockAssign = false;
            this.Signal1.Complex = false;
            this.Signal1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.Signal1.FloatPrecisionLock = false;
            this.Signal1.Input = null;
            this.Signal1.IsDouble = true;
            this.Signal1.Name = "";
            // 
            // SignalRead1
            // 
            this.SignalRead1.BandwidthL = 0D;
            this.SignalRead1.BlockAssign = false;
            this.SignalRead1.Complex = false;
            this.SignalRead1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.SignalRead1.FloatPrecisionLock = false;
            this.SignalRead1.FramesPerSecond = 0.0009765625D;
            this.SignalRead1.Input = null;
            this.SignalRead1.IsDouble = true;
            this.SignalRead1.LastFrameCheck = Dew.Signal.TLastFrameCheck.lfcZeroPadded;
            this.SignalRead1.Length = 1024;
            this.SignalRead1.Name = "";
            this.SignalRead1.PostBufferSamples = 0;
            this.SignalRead1.RecordPosition = ((long)(0));
            this.SignalRead1.SamplingFrequency = 4666.66666666667D;
            // 
            // SpectrumAnalyzer1
            // 
            this.SpectrumAnalyzer1.Bands.TemplateIndex = -1;
            this.SpectrumAnalyzer1.Bands.Templates = new Dew.Signal.TStringStreamList(System.Convert.FromBase64String("AAAAAA=="));
            this.SpectrumAnalyzer1.BlockAssign = false;
            this.SpectrumAnalyzer1.Complex = false;
            this.SpectrumAnalyzer1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.SpectrumAnalyzer1.FloatPrecisionLock = false;
            this.SpectrumAnalyzer1.Input = this.SignalRead1;
            this.SpectrumAnalyzer1.IsDouble = true;
            this.SpectrumAnalyzer1.LogBase = 0D;
            this.SpectrumAnalyzer1.LogScale = 0D;
            this.SpectrumAnalyzer1.Name = "";
            this.SpectrumAnalyzer1.Output = null;
            this.SpectrumAnalyzer1.Peaks.Interpolation.Method = Dew.Signal.TInterpolationMethod.imNone;
            this.SpectrumAnalyzer1.Peaks.Interpolation.RecursiveHarmonics = Dew.Signal.TRecursiveHarmonics.rhNone;
            this.SpectrumAnalyzer1.Report.UseTab = false;
            this.SpectrumAnalyzer1.SamplingFrequency = 8192D;
            this.SpectrumAnalyzer1.SpectrumScale = 0D;
            this.SpectrumAnalyzer1.Stats.Averaged = 0;
            this.SpectrumAnalyzer1.Stats.Averages = 30;
            this.SpectrumAnalyzer1.ZeroPadding = 2;
            this.SpectrumAnalyzer1.OnAfterUpdateEvent += new Dew.Math.TNotifyEvent(this.SpectrumAnalyzer1_OnAfterUpdate);
            this.SpectrumAnalyzer1.OnParameterUpdateEvent += new Dew.Math.TNotifyEvent(this.SpectrumAnalyzer1_OnParameterUpdate);
            // 
            // ChartEditor
            // 
            this.ChartEditor.Chart = this.SpectrumChart1;
            this.ChartEditor.HighLightTabs = false;
            this.ChartEditor.Location = new System.Drawing.Point(0, 0);
            this.ChartEditor.Name = "ChartEditor";
            this.ChartEditor.Options = null;
            this.ChartEditor.TabIndex = 0;
            // 
            // SpectrumAnalyzerDialog
            // 
            this.SpectrumAnalyzerDialog.BlockAssign = false;
            this.SpectrumAnalyzerDialog.Docking = false;
            this.SpectrumAnalyzerDialog.FormCaption = null;
            this.SpectrumAnalyzerDialog.Name = null;
            this.SpectrumAnalyzerDialog.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.SpectrumAnalyzerDialog.ShowLive = false;
            this.SpectrumAnalyzerDialog.Source = this.SpectrumAnalyzer1;
            this.SpectrumAnalyzerDialog.SourceListIndex = 0;
            // 
            // CepstrumChartEditor
            // 
            this.CepstrumChartEditor.Chart = this.signalChart1;
            this.CepstrumChartEditor.HighLightTabs = false;
            this.CepstrumChartEditor.Location = new System.Drawing.Point(0, 0);
            this.CepstrumChartEditor.Name = "ChartEditor";
            this.CepstrumChartEditor.Options = null;
            this.CepstrumChartEditor.TabIndex = 0;
            // 
            // CepstrumDemoForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(664, 573);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "CepstrumDemoForm";
            this.Text = "CepstrumDemoForm";
            this.Load += new System.EventHandler(this.CepstrumDemoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.signalChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpectrumChart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void SpectrumAnalyzer1_OnAfterUpdate(object Sender) {
			switch (cepstrumComboBox.SelectedIndex) {
				case 0:SignalUtils.RealCepstrum(SignalRead1.Data,data,true,TSignalWindowType.wtHanning,true);break;
				case 1:SignalUtils.CplxCepstrum(SignalRead1.Data,data,16);break;
			}
                Signal1.Data[0] = 0; //set DC to zero
                SignalUtils.RunningAverage(Signal1.Data, data, (int)SignalRead1.FrameNumber,0);

		}

		private void SpectrumAnalyzer1_OnParameterUpdate(object Sender) {

            SpectrumAnalyzer1.Update();
		}

		private void cepstrumComboBox_SelectedIndexChanged(object sender, System.EventArgs e) {
			SignalRead1.RecordPosition = 0;
			SpectrumAnalyzer1.ResetAveraging();
			SpectrumAnalyzer1.PullUntilEnd();
			SpectrumAnalyzer1.UpdateNotify(); 
			Signal1.SamplingTime = Signal1.Length;
			Signal1.UpdateNotify();  //update connected chart.
		}

		private void panel2_SizeChanged(object sender, System.EventArgs e) {
			//signalChart1.Height = SpectrumChart1.Height = (panel2.Height - splitter1.Height) / 2;
		}

        private void SpectrumChart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpectrumAnalyzerDialog.ExecuteModal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChartEditor.ShowModal();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CepstrumChartEditor.ShowModal();
        }

        protected void Add(String s)
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void CepstrumDemoForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("Complex cepstrum can be used to measure echo " +
                "delays and for homomorphic filtering. Real cepstrum " +
                "can detect periodicities in the frequency spectrum. ");
        }

        private void signalChart1_Click_1(object sender, EventArgs e)
        {

        }

        private void MarkCursorBox_CheckedChanged(object sender, EventArgs e)
        {            
            signalMarkTool.CursorActive =  MarkCursorBox.Checked;
            smt.CursorActive = MarkCursorBox.Checked;            
        }
	}
}
