using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Dew.Signal;
using Dew.Math;
using Dew.Signal.Tee;
using Dew.Signal.Units;
using Dew.Math.Units;
using Dew.Math.Controls;
using Dew.Demo;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for DemodulatorForm.
	/// </summary>
	public class DemodulatorForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private SpectrumChart SpectrumChart1;
		private System.Windows.Forms.Splitter splitter1;
		private SpectrumChart SpectrumChart2;
		private Steema.TeeChart.Styles.FastLine Series1;
		private Steema.TeeChart.Styles.Points MarkSeries1;
		private Steema.TeeChart.Styles.FastLine Series2;
		private FloatEdit freqEdit;
		private System.Windows.Forms.Label label1;
		private FloatEdit bwEdit;
		private System.Windows.Forms.Label label2;
		private Dew.Signal.TSignalRead SignalRead1;
		private Dew.Signal.TSignalDemodulator SignalDemodulator1;
		private Dew.Signal.TSpectrumAnalyzer SpectrumAnalyzer1;
		private Dew.Signal.TSpectrumAnalyzer SpectrumAnalyzer2;
		private Steema.TeeChart.Styles.Points MarkSeries2;
        private Button SpectrumChartButton;
        private Button SpectrumButton;
        private SpectrumAnalyzerDialog SpectrumAnalyzerDialog;
        private Steema.TeeChart.Editor ChartEditor;
		private System.ComponentModel.IContainer components;

		public DemodulatorForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

//            Series1.Color = Color.White;
//            Series2.Color = Color.White;

			SpectrumChart1.Spectrums.Add();
			SpectrumChart1.Spectrums[0].Input = SpectrumAnalyzer1;
			SpectrumChart1.Spectrums[0].Series = Series1;

			SpectrumChart2.Spectrums.Add();
			SpectrumChart2.Spectrums[0].Input = SpectrumAnalyzer2;
			SpectrumChart2.Spectrums[0].Series = Series2;

			SpectrumMarkTool smt = new SpectrumMarkTool(SpectrumChart1.Chart);
			smt.CursorActive = true;
			smt.DoubleClickClear = true;
			smt.PeakFilterMode = false;
			smt.MarkMode = SpectrumMarkMode.mmSingle;
			smt.MarkType = SpectrumMarkType.mtAmplt;
			smt.MarkSeries = MarkSeries1;
			smt.Series =  Series1;
			smt.AmpltFormat = "0.00#";
			smt.PhaseFormat = "0.00#";
			smt.FreqFormat = "0.00#";
			smt.LabelHeaders = true;
			smt.PeakZoomBand = false;
			SpectrumChart1.Tools.Add(smt);

			smt = new SpectrumMarkTool(SpectrumChart2.Chart);
			smt.CursorActive = true;
			smt.DoubleClickClear = true;
			smt.PeakFilterMode = false;
			smt.MarkMode = SpectrumMarkMode.mmSingle;
			smt.MarkType = SpectrumMarkType.mtAmplt;
			smt.MarkSeries = MarkSeries2;
			smt.Series = Series2;
			smt.AmpltFormat = "0.00#";
			smt.PhaseFormat = "0.00#";
			smt.FreqFormat = "0.00#";
			smt.LabelHeaders = true;
			smt.PeakZoomBand = false;
			SpectrumChart2.Tools.Add(smt);

			AxisScaleTool tool = new AxisScaleTool(SpectrumChart1.Chart);
			tool.UpperMargin = 5;
			tool.LowerMargin = 5;
			tool.AxisScaleMode = AxisScaleMode.amAuto;
			tool.DataIsSpectrum = true;
			tool.Axis = SpectrumChart1.Axes.Left;
			SpectrumChart1.Tools.Add(tool);
            SpectrumChart1.Axes.Left.Automatic = true;

			tool = new AxisScaleTool(SpectrumChart2.Chart);
			tool.UpperMargin = 5;
			tool.LowerMargin = 5;
			tool.AxisScaleMode = AxisScaleMode.amAuto;
			tool.DataIsSpectrum = true;
			tool.Axis = SpectrumChart2.Axes.Left;
			SpectrumChart2.Tools.Add(tool);
            SpectrumChart2.Axes.Left.Automatic = true;

            SignalRead1.FileName = Dew.Demo.Utils.SourcePath() + @"\Data\bz.sfs";
			bwEdit_TextChanged(this, EventArgs.Empty);
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
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemodulatorForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SpectrumChartButton = new System.Windows.Forms.Button();
            this.SpectrumButton = new System.Windows.Forms.Button();
            this.freqEdit = new Dew.Math.Controls.FloatEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.bwEdit = new Dew.Math.Controls.FloatEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SpectrumChart2 = new Dew.Signal.Tee.SpectrumChart();
            this.Series2 = new Steema.TeeChart.Styles.FastLine();
            this.MarkSeries2 = new Steema.TeeChart.Styles.Points();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SpectrumChart1 = new Dew.Signal.Tee.SpectrumChart();
            this.Series1 = new Steema.TeeChart.Styles.FastLine();
            this.MarkSeries1 = new Steema.TeeChart.Styles.Points();
            this.SignalRead1 = new Dew.Signal.TSignalRead(this.components);
            this.SignalDemodulator1 = new Dew.Signal.TSignalDemodulator(this.components);
            this.SpectrumAnalyzer1 = new Dew.Signal.TSpectrumAnalyzer(this.components);
            this.SpectrumAnalyzer2 = new Dew.Signal.TSpectrumAnalyzer(this.components);
            this.SpectrumAnalyzerDialog = new Dew.Signal.SpectrumAnalyzerDialog(this.components);
            this.ChartEditor = new Steema.TeeChart.Editor(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpectrumChart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpectrumChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 118);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SpectrumChartButton);
            this.panel1.Controls.Add(this.SpectrumButton);
            this.panel1.Controls.Add(this.freqEdit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bwEdit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 43);
            this.panel1.TabIndex = 1;
            // 
            // SpectrumChartButton
            // 
            this.SpectrumChartButton.AutoSize = true;
            this.SpectrumChartButton.Location = new System.Drawing.Point(124, 7);
            this.SpectrumChartButton.Name = "SpectrumChartButton";
            this.SpectrumChartButton.Size = new System.Drawing.Size(128, 31);
            this.SpectrumChartButton.TabIndex = 15;
            this.SpectrumChartButton.Text = "Spectrum chart...";
            this.SpectrumChartButton.UseVisualStyleBackColor = true;
            this.SpectrumChartButton.Click += new System.EventHandler(this.SpectrumChartButton_Click);
            // 
            // SpectrumButton
            // 
            this.SpectrumButton.Location = new System.Drawing.Point(14, 7);
            this.SpectrumButton.Name = "SpectrumButton";
            this.SpectrumButton.Size = new System.Drawing.Size(90, 29);
            this.SpectrumButton.TabIndex = 14;
            this.SpectrumButton.Text = "Spectrum...";
            this.SpectrumButton.UseVisualStyleBackColor = true;
            this.SpectrumButton.Click += new System.EventHandler(this.SpectrumButton_Click);
            // 
            // freqEdit
            // 
            this.freqEdit.Increment = "0.001";
            this.freqEdit.Location = new System.Drawing.Point(398, 11);
            this.freqEdit.Name = "freqEdit";
            this.freqEdit.ReFormat = "0.00#";
            this.freqEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.freqEdit.Scientific = false;
            this.freqEdit.Size = new System.Drawing.Size(87, 23);
            this.freqEdit.TabIndex = 12;
            this.freqEdit.Value = "0.25";
            this.freqEdit.TextChanged += new System.EventHandler(this.bwEdit_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(310, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Frequency:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bwEdit
            // 
            this.bwEdit.Increment = "0.001";
            this.bwEdit.Location = new System.Drawing.Point(610, 11);
            this.bwEdit.Name = "bwEdit";
            this.bwEdit.ReFormat = "0.00#";
            this.bwEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.bwEdit.Size = new System.Drawing.Size(86, 23);
            this.bwEdit.TabIndex = 13;
            this.bwEdit.Value = "0.125";
            this.bwEdit.TextChanged += new System.EventHandler(this.bwEdit_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(494, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bandwidth:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SpectrumChart2);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.SpectrumChart1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 324);
            this.panel2.TabIndex = 2;
            this.panel2.SizeChanged += new System.EventHandler(this.panel2_SizeChanged);
            // 
            // SpectrumChart2
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
            this.SpectrumChart2.Axes.Bottom.Grid.DrawEvery = 1;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Bottom.Labels.Axis = this.SpectrumChart2.Axes.Bottom;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart2.Axes.Bottom.Labels.Brush.Solid = true;
            this.SpectrumChart2.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart2.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.SpectrumChart2.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart2.Axes.Bottom.Labels.Font.Size = 9;
            this.SpectrumChart2.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            this.SpectrumChart2.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart2.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.SpectrumChart2.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            this.SpectrumChart2.Axes.Bottom.Labels.Separation = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            this.SpectrumChart2.Axes.Bottom.MaximumOffset = 4;
            this.SpectrumChart2.Axes.Bottom.MinimumOffset = 4;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Bottom.MinorTicks.Length = 2;
            this.SpectrumChart2.Axes.Bottom.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Bottom.Ticks.Length = 4;
            this.SpectrumChart2.Axes.Bottom.Ticks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Bottom.TicksInner.Length = 0;
            this.SpectrumChart2.Axes.Bottom.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart2.Axes.Bottom.Title.Brush.Solid = true;
            this.SpectrumChart2.Axes.Bottom.Title.Brush.Visible = true;
            this.SpectrumChart2.Axes.Bottom.Title.Caption = "Frequency [Hz]";
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart2.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.SpectrumChart2.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart2.Axes.Bottom.Title.Font.Size = 11;
            this.SpectrumChart2.Axes.Bottom.Title.Font.SizeFloat = 11F;
            this.SpectrumChart2.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart2.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart2.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            this.SpectrumChart2.Axes.Bottom.Title.Lines = new string[] {
        "Frequency [Hz]"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Depth.AxisPen.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Depth.Labels.Axis = this.SpectrumChart2.Axes.Depth;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart2.Axes.Depth.Labels.Brush.Solid = true;
            this.SpectrumChart2.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart2.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.SpectrumChart2.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart2.Axes.Depth.Labels.Font.Size = 9;
            this.SpectrumChart2.Axes.Depth.Labels.Font.SizeFloat = 9F;
            this.SpectrumChart2.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart2.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.SpectrumChart2.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Depth.MinorTicks.Length = 2;
            this.SpectrumChart2.Axes.Depth.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Depth.Ticks.Length = 4;
            this.SpectrumChart2.Axes.Depth.Ticks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Depth.TicksInner.Length = 0;
            this.SpectrumChart2.Axes.Depth.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart2.Axes.Depth.Title.Brush.Solid = true;
            this.SpectrumChart2.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart2.Axes.Depth.Title.Font.Brush.Solid = true;
            this.SpectrumChart2.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart2.Axes.Depth.Title.Font.Size = 11;
            this.SpectrumChart2.Axes.Depth.Title.Font.SizeFloat = 11F;
            this.SpectrumChart2.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart2.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart2.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.DepthTop.AxisPen.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.DepthTop.Labels.Axis = this.SpectrumChart2.Axes.DepthTop;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart2.Axes.DepthTop.Labels.Brush.Solid = true;
            this.SpectrumChart2.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart2.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.SpectrumChart2.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart2.Axes.DepthTop.Labels.Font.Size = 9;
            this.SpectrumChart2.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            this.SpectrumChart2.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.SpectrumChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.DepthTop.MinorTicks.Length = 2;
            this.SpectrumChart2.Axes.DepthTop.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.DepthTop.Ticks.Length = 4;
            this.SpectrumChart2.Axes.DepthTop.Ticks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.DepthTop.TicksInner.Length = 0;
            this.SpectrumChart2.Axes.DepthTop.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart2.Axes.DepthTop.Title.Brush.Solid = true;
            this.SpectrumChart2.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart2.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.SpectrumChart2.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart2.Axes.DepthTop.Title.Font.Size = 11;
            this.SpectrumChart2.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            this.SpectrumChart2.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart2.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart2.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Left.Labels.Axis = this.SpectrumChart2.Axes.Left;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart2.Axes.Left.Labels.Brush.Solid = true;
            this.SpectrumChart2.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart2.Axes.Left.Labels.Font.Brush.Solid = true;
            this.SpectrumChart2.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart2.Axes.Left.Labels.Font.Size = 9;
            this.SpectrumChart2.Axes.Left.Labels.Font.SizeFloat = 9F;
            this.SpectrumChart2.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart2.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.SpectrumChart2.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Axes.Left.Labels.Shadow.Brush.Visible = true;
            this.SpectrumChart2.Axes.Left.MaximumOffset = 4;
            this.SpectrumChart2.Axes.Left.MinimumOffset = 4;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Left.MinorTicks.Length = 2;
            this.SpectrumChart2.Axes.Left.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Left.Ticks.Length = 4;
            this.SpectrumChart2.Axes.Left.Ticks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Left.TicksInner.Length = 0;
            this.SpectrumChart2.Axes.Left.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart2.Axes.Left.Title.Brush.Solid = true;
            this.SpectrumChart2.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart2.Axes.Left.Title.Font.Brush.Solid = true;
            this.SpectrumChart2.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart2.Axes.Left.Title.Font.Size = 11;
            this.SpectrumChart2.Axes.Left.Title.Font.SizeFloat = 11F;
            this.SpectrumChart2.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart2.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart2.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Right.Labels.Axis = this.SpectrumChart2.Axes.Right;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart2.Axes.Right.Labels.Brush.Solid = true;
            this.SpectrumChart2.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart2.Axes.Right.Labels.Font.Brush.Solid = true;
            this.SpectrumChart2.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart2.Axes.Right.Labels.Font.Size = 9;
            this.SpectrumChart2.Axes.Right.Labels.Font.SizeFloat = 9F;
            this.SpectrumChart2.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart2.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.SpectrumChart2.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Right.MinorTicks.Length = 2;
            this.SpectrumChart2.Axes.Right.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Right.Ticks.Length = 4;
            this.SpectrumChart2.Axes.Right.Ticks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Right.TicksInner.Length = 0;
            this.SpectrumChart2.Axes.Right.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart2.Axes.Right.Title.Brush.Solid = true;
            this.SpectrumChart2.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart2.Axes.Right.Title.Font.Brush.Solid = true;
            this.SpectrumChart2.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart2.Axes.Right.Title.Font.Size = 11;
            this.SpectrumChart2.Axes.Right.Title.Font.SizeFloat = 11F;
            this.SpectrumChart2.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart2.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart2.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Top.Labels.Axis = this.SpectrumChart2.Axes.Top;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart2.Axes.Top.Labels.Brush.Solid = true;
            this.SpectrumChart2.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart2.Axes.Top.Labels.Font.Brush.Solid = true;
            this.SpectrumChart2.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart2.Axes.Top.Labels.Font.Size = 9;
            this.SpectrumChart2.Axes.Top.Labels.Font.SizeFloat = 9F;
            this.SpectrumChart2.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart2.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.SpectrumChart2.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Top.MinorTicks.Length = 2;
            this.SpectrumChart2.Axes.Top.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Top.Ticks.Length = 4;
            this.SpectrumChart2.Axes.Top.Ticks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Top.TicksInner.Length = 0;
            this.SpectrumChart2.Axes.Top.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart2.Axes.Top.Title.Brush.Solid = true;
            this.SpectrumChart2.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart2.Axes.Top.Title.Font.Brush.Solid = true;
            this.SpectrumChart2.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart2.Axes.Top.Title.Font.Size = 11;
            this.SpectrumChart2.Axes.Top.Title.Font.SizeFloat = 11F;
            this.SpectrumChart2.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart2.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart2.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.SpectrumChart2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SpectrumChart2.Cursor = System.Windows.Forms.Cursors.Default;
            this.SpectrumChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart2.Footer.Brush.Solid = true;
            this.SpectrumChart2.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart2.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.SpectrumChart2.Footer.Font.Brush.Solid = true;
            this.SpectrumChart2.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Footer.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Footer.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart2.Footer.Font.Size = 8;
            this.SpectrumChart2.Footer.Font.SizeFloat = 8F;
            this.SpectrumChart2.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart2.Footer.ImageBevel.Brush.Solid = true;
            this.SpectrumChart2.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Footer.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SpectrumChart2.Header.Brush.Solid = true;
            this.SpectrumChart2.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.Header.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart2.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart2.Header.Font.Brush.Solid = true;
            this.SpectrumChart2.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Header.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Header.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart2.Header.Font.Size = 12;
            this.SpectrumChart2.Header.Font.SizeFloat = 12F;
            this.SpectrumChart2.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart2.Header.ImageBevel.Brush.Solid = true;
            this.SpectrumChart2.Header.ImageBevel.Brush.Visible = true;
            this.SpectrumChart2.Header.Lines = new string[] {
        "Original spectrum"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SpectrumChart2.Header.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Legend.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart2.Legend.Brush.Solid = true;
            this.SpectrumChart2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart2.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart2.Legend.Font.Brush.Solid = true;
            this.SpectrumChart2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Legend.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Legend.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart2.Legend.Font.Size = 9;
            this.SpectrumChart2.Legend.Font.SizeFloat = 9F;
            this.SpectrumChart2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart2.Legend.ImageBevel.Brush.Solid = true;
            this.SpectrumChart2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.Legend.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SpectrumChart2.Legend.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.Legend.Symbol.Legend = this.SpectrumChart2.Legend;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Legend.Symbol.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart2.Legend.Title.Brush.Solid = true;
            this.SpectrumChart2.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.SpectrumChart2.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.SpectrumChart2.Legend.Title.Font.Brush.Solid = true;
            this.SpectrumChart2.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart2.Legend.Title.Font.Size = 8;
            this.SpectrumChart2.Legend.Title.Font.SizeFloat = 8F;
            this.SpectrumChart2.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart2.Legend.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart2.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.Legend.Title.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Legend.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Legend.Title.Shadow.Brush.Visible = true;
            this.SpectrumChart2.Legend.Visible = false;
            this.SpectrumChart2.Location = new System.Drawing.Point(0, 201);
            this.SpectrumChart2.Name = "SpectrumChart2";
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            // 
            // 
            // 
            this.SpectrumChart2.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.SpectrumChart2.Panel.Brush.Gradient.UseMiddle = true;
            this.SpectrumChart2.Panel.Brush.Solid = true;
            this.SpectrumChart2.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart2.Panel.ImageBevel.Brush.Solid = true;
            this.SpectrumChart2.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.Panel.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Panel.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Panel.Shadow.Brush.Visible = true;
            this.SpectrumChart2.Series.Add(this.Series2);
            this.SpectrumChart2.Series.Add(this.MarkSeries2);
            this.SpectrumChart2.Size = new System.Drawing.Size(800, 123);
            this.SpectrumChart2.SpectrumPart = Dew.Signal.Tee.SpectrumPart.sppAmplt;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart2.SubFooter.Brush.Solid = true;
            this.SpectrumChart2.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart2.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.SpectrumChart2.SubFooter.Font.Brush.Solid = true;
            this.SpectrumChart2.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.SubFooter.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart2.SubFooter.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart2.SubFooter.Font.Size = 8;
            this.SpectrumChart2.SubFooter.Font.SizeFloat = 8F;
            this.SpectrumChart2.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart2.SubFooter.ImageBevel.Brush.Solid = true;
            this.SpectrumChart2.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.SubFooter.Shadow.Brush.Solid = true;
            this.SpectrumChart2.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SpectrumChart2.SubHeader.Brush.Solid = true;
            this.SpectrumChart2.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart2.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart2.SubHeader.Font.Brush.Solid = true;
            this.SpectrumChart2.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.SubHeader.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart2.SubHeader.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart2.SubHeader.Font.Size = 12;
            this.SpectrumChart2.SubHeader.Font.SizeFloat = 12F;
            this.SpectrumChart2.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart2.SubHeader.ImageBevel.Brush.Solid = true;
            this.SpectrumChart2.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SpectrumChart2.SubHeader.Shadow.Brush.Solid = true;
            this.SpectrumChart2.SubHeader.Shadow.Brush.Visible = true;
            this.SpectrumChart2.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart2.Walls.Back.Brush.Solid = true;
            this.SpectrumChart2.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart2.Walls.Back.ImageBevel.Brush.Solid = true;
            this.SpectrumChart2.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Walls.Back.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart2.Walls.Bottom.Brush.Solid = true;
            this.SpectrumChart2.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart2.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.SpectrumChart2.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Walls.Bottom.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.SpectrumChart2.Walls.Left.Brush.Solid = true;
            this.SpectrumChart2.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart2.Walls.Left.ImageBevel.Brush.Solid = true;
            this.SpectrumChart2.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Walls.Left.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.SpectrumChart2.Walls.Right.Brush.Solid = true;
            this.SpectrumChart2.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart2.Walls.Right.ImageBevel.Brush.Solid = true;
            this.SpectrumChart2.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart2.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart2.Walls.Right.Shadow.Brush.Solid = true;
            this.SpectrumChart2.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart2.Zoom.Animated = true;
            // 
            // 
            // 
            this.SpectrumChart2.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.SpectrumChart2.Zoom.Brush.Solid = true;
            this.SpectrumChart2.Zoom.Brush.Visible = false;
            this.SpectrumChart2.Zoom.FullRepaint = true;
            // 
            // 
            // 
            this.SpectrumChart2.Zoom.Pen.Visible = true;
            // 
            // Series2
            // 
            // 
            // 
            // 
            this.Series2.Brush.Color = System.Drawing.Color.Empty;
            this.Series2.Brush.Solid = true;
            this.Series2.Brush.Visible = true;
            this.Series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.Series2.ColorEach = false;
            cursor1.CursorType = Steema.TeeChart.Drawing.CursorType.Default;
            this.Series2.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Legend.Brush.Color = System.Drawing.Color.White;
            this.Series2.Legend.Brush.Solid = true;
            this.Series2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.Series2.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.Series2.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.Series2.Legend.Font.Brush.Solid = true;
            this.Series2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Series2.Legend.Font.Shadow.Brush.Solid = true;
            this.Series2.Legend.Font.Shadow.Brush.Visible = true;
            this.Series2.Legend.Font.Size = 8;
            this.Series2.Legend.Font.SizeFloat = 8F;
            this.Series2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Series2.Legend.ImageBevel.Brush.Solid = true;
            this.Series2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Series2.Legend.Shadow.Brush.Solid = true;
            this.Series2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Series2.Marks.Brush.Solid = true;
            this.Series2.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.Series2.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.Series2.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.Series2.Marks.Font.Brush.Solid = true;
            this.Series2.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Series2.Marks.Font.Shadow.Brush.Solid = true;
            this.Series2.Marks.Font.Shadow.Brush.Visible = true;
            this.Series2.Marks.Font.Size = 8;
            this.Series2.Marks.Font.SizeFloat = 8F;
            this.Series2.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Series2.Marks.ImageBevel.Brush.Solid = true;
            this.Series2.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.Series2.Marks.Shadow.Brush.Solid = true;
            this.Series2.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.Series2.Marks.Symbol.Brush.Solid = true;
            this.Series2.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Series2.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.Series2.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Series2.Marks.Symbol.Shadow.Brush.Solid = true;
            this.Series2.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.Series2.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
            this.Series2.Marks.TailParams.Margin = 0F;
            this.Series2.Marks.TailParams.PointerHeight = 8D;
            this.Series2.Marks.TailParams.PointerWidth = 8D;
            this.Series2.OriginalCursor = cursor1;
            this.Series2.RandomData = true;
            this.Series2.Title = "fastLine1";
            this.Series2.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.Series2.Type = "Steema.TeeChart.Styles.FastLine";
            this.Series2.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.Series2.XValues.DataMember = "X";
            this.Series2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.Series2.XValues.Series = this.Series2;
            // 
            // 
            // 
            this.Series2.YValues.DataMember = "Y";
            this.Series2.YValues.Series = this.Series2;
            // 
            // MarkSeries2
            // 
            // 
            // 
            // 
            this.MarkSeries2.Brush.Color = System.Drawing.Color.Empty;
            this.MarkSeries2.Brush.Solid = true;
            this.MarkSeries2.Brush.Visible = true;
            this.MarkSeries2.Color = System.Drawing.Color.Orange;
            this.MarkSeries2.ColorEach = false;
            this.MarkSeries2.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries2.Legend.Brush.Color = System.Drawing.Color.White;
            this.MarkSeries2.Legend.Brush.Solid = true;
            this.MarkSeries2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.MarkSeries2.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.MarkSeries2.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.MarkSeries2.Legend.Font.Brush.Solid = true;
            this.MarkSeries2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.MarkSeries2.Legend.Font.Shadow.Brush.Solid = true;
            this.MarkSeries2.Legend.Font.Shadow.Brush.Visible = true;
            this.MarkSeries2.Legend.Font.Size = 8;
            this.MarkSeries2.Legend.Font.SizeFloat = 8F;
            this.MarkSeries2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.MarkSeries2.Legend.ImageBevel.Brush.Solid = true;
            this.MarkSeries2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries2.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.MarkSeries2.Legend.Shadow.Brush.Solid = true;
            this.MarkSeries2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries2.Marks.Arrow.Visible = false;
            this.MarkSeries2.Marks.ArrowLength = 10;
            // 
            // 
            // 
            this.MarkSeries2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MarkSeries2.Marks.Brush.Solid = true;
            this.MarkSeries2.Marks.Brush.Visible = false;
            // 
            // 
            // 
            this.MarkSeries2.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.MarkSeries2.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.MarkSeries2.Marks.Font.Brush.Solid = true;
            this.MarkSeries2.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries2.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.MarkSeries2.Marks.Font.Shadow.Brush.Solid = true;
            this.MarkSeries2.Marks.Font.Shadow.Brush.Visible = true;
            this.MarkSeries2.Marks.Font.Size = 8;
            this.MarkSeries2.Marks.Font.SizeFloat = 8F;
            this.MarkSeries2.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries2.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.MarkSeries2.Marks.ImageBevel.Brush.Solid = true;
            this.MarkSeries2.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries2.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.MarkSeries2.Marks.Shadow.Brush.Solid = true;
            this.MarkSeries2.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries2.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.MarkSeries2.Marks.Symbol.Brush.Solid = true;
            this.MarkSeries2.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries2.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.MarkSeries2.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.MarkSeries2.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries2.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.MarkSeries2.Marks.Symbol.Shadow.Brush.Solid = true;
            this.MarkSeries2.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.MarkSeries2.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
            this.MarkSeries2.Marks.TailParams.Margin = 0F;
            this.MarkSeries2.Marks.TailParams.PointerHeight = 8D;
            this.MarkSeries2.Marks.TailParams.PointerWidth = 8D;
            this.MarkSeries2.Marks.Transparent = true;
            this.MarkSeries2.Marks.Visible = true;
            this.MarkSeries2.OriginalCursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries2.Pointer.Brush.Color = System.Drawing.Color.Orange;
            this.MarkSeries2.Pointer.Brush.Solid = true;
            this.MarkSeries2.Pointer.Brush.Visible = true;
            this.MarkSeries2.Pointer.HorizSize = 3;
            // 
            // 
            // 
            this.MarkSeries2.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MarkSeries2.Pointer.SizeDouble = 0D;
            this.MarkSeries2.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.MarkSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.MarkSeries2.Pointer.VertSize = 3;
            this.MarkSeries2.RandomData = true;
            this.MarkSeries2.Title = "point1";
            this.MarkSeries2.Type = "Steema.TeeChart.Styles.Points";
            this.MarkSeries2.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.MarkSeries2.XValues.DataMember = "X";
            this.MarkSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.MarkSeries2.XValues.Series = this.MarkSeries2;
            // 
            // 
            // 
            this.MarkSeries2.YValues.DataMember = "Y";
            this.MarkSeries2.YValues.Series = this.MarkSeries2;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 197);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(800, 4);
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
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Labels.Axis = this.SpectrumChart1.Axes.Bottom;
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
            this.SpectrumChart1.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.SpectrumChart1.Axes.Bottom.MinorTicks.Length = 2;
            this.SpectrumChart1.Axes.Bottom.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Ticks.Length = 4;
            this.SpectrumChart1.Axes.Bottom.Ticks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.TicksInner.Length = 0;
            this.SpectrumChart1.Axes.Bottom.TicksInner.Visible = false;
            // 
            // 
            // 
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
            this.SpectrumChart1.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.SpectrumChart1.Axes.Depth.AxisPen.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Labels.Axis = this.SpectrumChart1.Axes.Depth;
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
            this.SpectrumChart1.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.SpectrumChart1.Axes.Depth.MinorTicks.Length = 2;
            this.SpectrumChart1.Axes.Depth.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Ticks.Length = 4;
            this.SpectrumChart1.Axes.Depth.Ticks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.TicksInner.Length = 0;
            this.SpectrumChart1.Axes.Depth.TicksInner.Visible = false;
            // 
            // 
            // 
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
            this.SpectrumChart1.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.SpectrumChart1.Axes.DepthTop.AxisPen.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Labels.Axis = this.SpectrumChart1.Axes.DepthTop;
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
            this.SpectrumChart1.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.SpectrumChart1.Axes.DepthTop.MinorTicks.Length = 2;
            this.SpectrumChart1.Axes.DepthTop.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Ticks.Length = 4;
            this.SpectrumChart1.Axes.DepthTop.Ticks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.TicksInner.Length = 0;
            this.SpectrumChart1.Axes.DepthTop.TicksInner.Visible = false;
            // 
            // 
            // 
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
            this.SpectrumChart1.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.SpectrumChart1.Axes.Left.Labels.Axis = this.SpectrumChart1.Axes.Left;
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
            this.SpectrumChart1.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.SpectrumChart1.Axes.Left.MinorTicks.Length = 2;
            this.SpectrumChart1.Axes.Left.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Ticks.Length = 4;
            this.SpectrumChart1.Axes.Left.Ticks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.TicksInner.Length = 0;
            this.SpectrumChart1.Axes.Left.TicksInner.Visible = false;
            // 
            // 
            // 
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
            this.SpectrumChart1.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.SpectrumChart1.Axes.Right.Labels.Axis = this.SpectrumChart1.Axes.Right;
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
            this.SpectrumChart1.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.SpectrumChart1.Axes.Right.MinorTicks.Length = 2;
            this.SpectrumChart1.Axes.Right.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Ticks.Length = 4;
            this.SpectrumChart1.Axes.Right.Ticks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.TicksInner.Length = 0;
            this.SpectrumChart1.Axes.Right.TicksInner.Visible = false;
            // 
            // 
            // 
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
            this.SpectrumChart1.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.SpectrumChart1.Axes.Right.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Labels.Axis = this.SpectrumChart1.Axes.Top;
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
            this.SpectrumChart1.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.SpectrumChart1.Axes.Top.MinorTicks.Length = 2;
            this.SpectrumChart1.Axes.Top.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Ticks.Length = 4;
            this.SpectrumChart1.Axes.Top.Ticks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.TicksInner.Length = 0;
            this.SpectrumChart1.Axes.Top.TicksInner.Visible = false;
            // 
            // 
            // 
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
            this.SpectrumChart1.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.SpectrumChart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.SpectrumChart1.Dock = System.Windows.Forms.DockStyle.Top;
            // 
            // 
            // 
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
            this.SpectrumChart1.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.SpectrumChart1.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
        "Zoomed spectrum"};
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
            this.SpectrumChart1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.SpectrumChart1.Legend.Pen.Visible = false;
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
            this.SpectrumChart1.Legend.Symbol.Legend = this.SpectrumChart1.Legend;
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
            this.SpectrumChart1.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
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
            this.SpectrumChart1.Legend.Title.Pen.Visible = false;
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
            // 
            // 
            // 
            this.SpectrumChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.SpectrumChart1.Panel.Brush.Gradient.UseMiddle = true;
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
            this.SpectrumChart1.Panel.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Panel.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Panel.Shadow.Brush.Visible = true;
            this.SpectrumChart1.Series.Add(this.Series1);
            this.SpectrumChart1.Series.Add(this.MarkSeries1);
            this.SpectrumChart1.Size = new System.Drawing.Size(800, 197);
            this.SpectrumChart1.SpectrumPart = Dew.Signal.Tee.SpectrumPart.sppAmplt;
            // 
            // 
            // 
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
            this.SpectrumChart1.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.SpectrumChart1.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            // Series1
            // 
            // 
            // 
            // 
            this.Series1.Brush.Color = System.Drawing.Color.Empty;
            this.Series1.Brush.Solid = true;
            this.Series1.Brush.Visible = true;
            this.Series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.Series1.ColorEach = false;
            this.Series1.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Legend.Brush.Color = System.Drawing.Color.White;
            this.Series1.Legend.Brush.Solid = true;
            this.Series1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.Series1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.Series1.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.Series1.Legend.Font.Brush.Solid = true;
            this.Series1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Series1.Legend.Font.Shadow.Brush.Solid = true;
            this.Series1.Legend.Font.Shadow.Brush.Visible = true;
            this.Series1.Legend.Font.Size = 8;
            this.Series1.Legend.Font.SizeFloat = 8F;
            this.Series1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Series1.Legend.ImageBevel.Brush.Solid = true;
            this.Series1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Series1.Legend.Shadow.Brush.Solid = true;
            this.Series1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Series1.Marks.Brush.Solid = true;
            this.Series1.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.Series1.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.Series1.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.Series1.Marks.Font.Brush.Solid = true;
            this.Series1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Series1.Marks.Font.Shadow.Brush.Solid = true;
            this.Series1.Marks.Font.Shadow.Brush.Visible = true;
            this.Series1.Marks.Font.Size = 8;
            this.Series1.Marks.Font.SizeFloat = 8F;
            this.Series1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Series1.Marks.ImageBevel.Brush.Solid = true;
            this.Series1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.Series1.Marks.Shadow.Brush.Solid = true;
            this.Series1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.Series1.Marks.Symbol.Brush.Solid = true;
            this.Series1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Series1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.Series1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Series1.Marks.Symbol.Shadow.Brush.Solid = true;
            this.Series1.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.Series1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos2")));
            this.Series1.Marks.TailParams.Margin = 0F;
            this.Series1.Marks.TailParams.PointerHeight = 8D;
            this.Series1.Marks.TailParams.PointerWidth = 8D;
            this.Series1.OriginalCursor = cursor1;
            this.Series1.RandomData = true;
            this.Series1.Title = "fastLine1";
            this.Series1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.Series1.Type = "Steema.TeeChart.Styles.FastLine";
            this.Series1.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.Series1.XValues.DataMember = "X";
            this.Series1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.Series1.XValues.Series = this.Series1;
            // 
            // 
            // 
            this.Series1.YValues.DataMember = "Y";
            this.Series1.YValues.Series = this.Series1;
            // 
            // MarkSeries1
            // 
            // 
            // 
            // 
            this.MarkSeries1.Brush.Color = System.Drawing.Color.Empty;
            this.MarkSeries1.Brush.Solid = true;
            this.MarkSeries1.Brush.Visible = true;
            this.MarkSeries1.Color = System.Drawing.Color.Orange;
            this.MarkSeries1.ColorEach = false;
            this.MarkSeries1.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries1.Legend.Brush.Color = System.Drawing.Color.White;
            this.MarkSeries1.Legend.Brush.Solid = true;
            this.MarkSeries1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.MarkSeries1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.MarkSeries1.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.MarkSeries1.Legend.Font.Brush.Solid = true;
            this.MarkSeries1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.MarkSeries1.Legend.Font.Shadow.Brush.Solid = true;
            this.MarkSeries1.Legend.Font.Shadow.Brush.Visible = true;
            this.MarkSeries1.Legend.Font.Size = 8;
            this.MarkSeries1.Legend.Font.SizeFloat = 8F;
            this.MarkSeries1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.MarkSeries1.Legend.ImageBevel.Brush.Solid = true;
            this.MarkSeries1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.MarkSeries1.Legend.Shadow.Brush.Solid = true;
            this.MarkSeries1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries1.Marks.Arrow.Visible = false;
            this.MarkSeries1.Marks.ArrowLength = 10;
            // 
            // 
            // 
            this.MarkSeries1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MarkSeries1.Marks.Brush.Solid = true;
            this.MarkSeries1.Marks.Brush.Visible = false;
            // 
            // 
            // 
            this.MarkSeries1.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.MarkSeries1.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.MarkSeries1.Marks.Font.Brush.Solid = true;
            this.MarkSeries1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries1.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.MarkSeries1.Marks.Font.Shadow.Brush.Solid = true;
            this.MarkSeries1.Marks.Font.Shadow.Brush.Visible = true;
            this.MarkSeries1.Marks.Font.Size = 8;
            this.MarkSeries1.Marks.Font.SizeFloat = 8F;
            this.MarkSeries1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries1.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.MarkSeries1.Marks.ImageBevel.Brush.Solid = true;
            this.MarkSeries1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries1.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.MarkSeries1.Marks.Shadow.Brush.Solid = true;
            this.MarkSeries1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries1.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.MarkSeries1.Marks.Symbol.Brush.Solid = true;
            this.MarkSeries1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries1.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.MarkSeries1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.MarkSeries1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries1.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.MarkSeries1.Marks.Symbol.Shadow.Brush.Solid = true;
            this.MarkSeries1.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.MarkSeries1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos3")));
            this.MarkSeries1.Marks.TailParams.Margin = 0F;
            this.MarkSeries1.Marks.TailParams.PointerHeight = 8D;
            this.MarkSeries1.Marks.TailParams.PointerWidth = 8D;
            this.MarkSeries1.Marks.Transparent = true;
            this.MarkSeries1.Marks.Visible = true;
            this.MarkSeries1.OriginalCursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries1.Pointer.Brush.Color = System.Drawing.Color.Orange;
            this.MarkSeries1.Pointer.Brush.Solid = true;
            this.MarkSeries1.Pointer.Brush.Visible = true;
            this.MarkSeries1.Pointer.HorizSize = 3;
            // 
            // 
            // 
            this.MarkSeries1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MarkSeries1.Pointer.SizeDouble = 0D;
            this.MarkSeries1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.MarkSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.MarkSeries1.Pointer.VertSize = 3;
            this.MarkSeries1.RandomData = true;
            this.MarkSeries1.Title = "point1";
            this.MarkSeries1.Type = "Steema.TeeChart.Styles.Points";
            this.MarkSeries1.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.MarkSeries1.XValues.DataMember = "X";
            this.MarkSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.MarkSeries1.XValues.Series = this.MarkSeries1;
            // 
            // 
            // 
            this.MarkSeries1.YValues.DataMember = "Y";
            this.MarkSeries1.YValues.Series = this.MarkSeries1;
            // 
            // SignalRead1
            // 
            this.SignalRead1.BandwidthL = 0D;
            this.SignalRead1.BlockAssign = false;
            this.SignalRead1.ChannelCount = 1;
            this.SignalRead1.Complex = false;
            this.SignalRead1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.SignalRead1.FloatPrecisionLock = false;
            this.SignalRead1.FramesPerSecond = 0.0009765625D;
            this.SignalRead1.Input = null;
            this.SignalRead1.IsDouble = true;
            this.SignalRead1.Length = 1024;
            this.SignalRead1.Name = "";
            this.SignalRead1.OnAfterUpdate = null;
            this.SignalRead1.OnBeforeUpdate = null;
            this.SignalRead1.OnDisplayUpdate = null;
            this.SignalRead1.OnGetInput = null;
            this.SignalRead1.OnNotifyUpdate = null;
            this.SignalRead1.OnParameterUpdate = null;
            this.SignalRead1.OnProcessAll = null;
            this.SignalRead1.OnRecordPositionChange = null;
            this.SignalRead1.OverlappingSamples = 0;
            this.SignalRead1.PostBufferSamples = 0;
            this.SignalRead1.RecordNumber = 0;
            this.SignalRead1.RecordPosition = ((long)(0));
            this.SignalRead1.SamplingFrequency = 4666.66666666667D;
            // 
            // SignalDemodulator1
            // 
            this.SignalDemodulator1.AudioSignal = false;
            this.SignalDemodulator1.BandwidthL = 0D;
            this.SignalDemodulator1.BlockAssign = false;
            this.SignalDemodulator1.ChannelCount = 1;
            this.SignalDemodulator1.Complex = false;
            this.SignalDemodulator1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.SignalDemodulator1.FloatPrecisionLock = false;
            this.SignalDemodulator1.HalfBand = true;
            this.SignalDemodulator1.Input = this.SignalRead1;
            this.SignalDemodulator1.IsDouble = true;
            this.SignalDemodulator1.Length = 128;
            this.SignalDemodulator1.Name = "";
            this.SignalDemodulator1.OnAfterUpdate = null;
            this.SignalDemodulator1.OnBeforeUpdate = null;
            this.SignalDemodulator1.OnDisplayUpdate = null;
            this.SignalDemodulator1.OnGetInput = null;
            this.SignalDemodulator1.OnNotifyUpdate = null;
            this.SignalDemodulator1.OnParameterUpdate = null;
            this.SignalDemodulator1.Ripple = 0.0001D;
            this.SignalDemodulator1.SubBandFrequency = 0.25D;
            this.SignalDemodulator1.SubBandWidth = 0.125D;
            // 
            // SpectrumAnalyzer1
            // 
            this.SpectrumAnalyzer1.ArOrder = 100;
            this.SpectrumAnalyzer1.Bands.TemplateIndex = -1;
            this.SpectrumAnalyzer1.Bands.Templates = ((Dew.Signal.TStringStreamList)(resources.GetObject("resource.Templates")));
            this.SpectrumAnalyzer1.BlockAssign = false;
            this.SpectrumAnalyzer1.Complex = false;
            this.SpectrumAnalyzer1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.SpectrumAnalyzer1.FloatPrecisionLock = false;
            this.SpectrumAnalyzer1.Harmonics = 10;
            this.SpectrumAnalyzer1.Input = this.SignalDemodulator1;
            this.SpectrumAnalyzer1.IsDouble = true;
            this.SpectrumAnalyzer1.Length = 64;
            this.SpectrumAnalyzer1.LogBase = 0D;
            this.SpectrumAnalyzer1.LogScale = 0D;
            this.SpectrumAnalyzer1.MainlobeWidth = 8;
            this.SpectrumAnalyzer1.Name = "";
            this.SpectrumAnalyzer1.OnAfterAverage = null;
            this.SpectrumAnalyzer1.OnAfterComplexSpectrum = null;
            this.SpectrumAnalyzer1.OnAfterUpdate = null;
            this.SpectrumAnalyzer1.OnBandsUpdate = null;
            this.SpectrumAnalyzer1.OnBeforeAverage = null;
            this.SpectrumAnalyzer1.OnBeforeSpectrumType = null;
            this.SpectrumAnalyzer1.OnBeforeUpdate = null;
            this.SpectrumAnalyzer1.OnDisplayUpdate = null;
            this.SpectrumAnalyzer1.OnGetInput = null;
            this.SpectrumAnalyzer1.OnNotifyUpdate = null;
            this.SpectrumAnalyzer1.OnParameterUpdate = null;
            this.SpectrumAnalyzer1.OnPeaksUpdate = null;
            this.SpectrumAnalyzer1.Output = null;
            this.SpectrumAnalyzer1.Peaks.HarmonicsCount = 10;
            this.SpectrumAnalyzer1.Peaks.Interpolation.Method = Dew.Signal.TInterpolationMethod.imNone;
            this.SpectrumAnalyzer1.Peaks.Interpolation.RecursiveHarmonics = Dew.Signal.TRecursiveHarmonics.rhNone;
            this.SpectrumAnalyzer1.Peaks.LargestCount = 1;
            this.SpectrumAnalyzer1.Report.AmplitudeFormat = null;
            this.SpectrumAnalyzer1.Report.FrequencyFormat = null;
            this.SpectrumAnalyzer1.Report.PhaseFormat = null;
            this.SpectrumAnalyzer1.Report.UseTab = false;
            this.SpectrumAnalyzer1.Rotation = 0;
            this.SpectrumAnalyzer1.SamplingFrequency = 1024D;
            this.SpectrumAnalyzer1.SpectrumScale = 0D;
            this.SpectrumAnalyzer1.Stats.Averaged = 0;
            this.SpectrumAnalyzer1.Stats.Averages = 30;
            this.SpectrumAnalyzer1.Stats.ExpDecay = 5;
            this.SpectrumAnalyzer1.Window = Dew.Signal.TSignalWindowType.wtHanning;
            this.SpectrumAnalyzer1.ZeroPadding = 4;
            // 
            // SpectrumAnalyzer2
            // 
            this.SpectrumAnalyzer2.ArOrder = 100;
            this.SpectrumAnalyzer2.Bands.TemplateIndex = -1;
            this.SpectrumAnalyzer2.Bands.Templates = ((Dew.Signal.TStringStreamList)(resources.GetObject("resource.Templates1")));
            this.SpectrumAnalyzer2.BlockAssign = false;
            this.SpectrumAnalyzer2.Complex = false;
            this.SpectrumAnalyzer2.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.SpectrumAnalyzer2.FloatPrecisionLock = false;
            this.SpectrumAnalyzer2.Harmonics = 10;
            this.SpectrumAnalyzer2.Input = this.SignalRead1;
            this.SpectrumAnalyzer2.IsDouble = true;
            this.SpectrumAnalyzer2.Length = 64;
            this.SpectrumAnalyzer2.LogBase = 0D;
            this.SpectrumAnalyzer2.LogScale = 0D;
            this.SpectrumAnalyzer2.MainlobeWidth = 8;
            this.SpectrumAnalyzer2.Name = "";
            this.SpectrumAnalyzer2.OnAfterAverage = null;
            this.SpectrumAnalyzer2.OnAfterComplexSpectrum = null;
            this.SpectrumAnalyzer2.OnAfterUpdate = null;
            this.SpectrumAnalyzer2.OnBandsUpdate = null;
            this.SpectrumAnalyzer2.OnBeforeAverage = null;
            this.SpectrumAnalyzer2.OnBeforeSpectrumType = null;
            this.SpectrumAnalyzer2.OnBeforeUpdate = null;
            this.SpectrumAnalyzer2.OnDisplayUpdate = null;
            this.SpectrumAnalyzer2.OnGetInput = null;
            this.SpectrumAnalyzer2.OnNotifyUpdate = null;
            this.SpectrumAnalyzer2.OnParameterUpdate = null;
            this.SpectrumAnalyzer2.OnPeaksUpdate = null;
            this.SpectrumAnalyzer2.Output = null;
            this.SpectrumAnalyzer2.Peaks.HarmonicsCount = 10;
            this.SpectrumAnalyzer2.Peaks.Interpolation.Method = Dew.Signal.TInterpolationMethod.imNone;
            this.SpectrumAnalyzer2.Peaks.Interpolation.RecursiveHarmonics = Dew.Signal.TRecursiveHarmonics.rhNone;
            this.SpectrumAnalyzer2.Peaks.LargestCount = 1;
            this.SpectrumAnalyzer2.Report.AmplitudeFormat = null;
            this.SpectrumAnalyzer2.Report.FrequencyFormat = null;
            this.SpectrumAnalyzer2.Report.PhaseFormat = null;
            this.SpectrumAnalyzer2.Report.UseTab = false;
            this.SpectrumAnalyzer2.Rotation = 0;
            this.SpectrumAnalyzer2.SamplingFrequency = 1024D;
            this.SpectrumAnalyzer2.SpectrumScale = 0D;
            this.SpectrumAnalyzer2.Stats.Averaged = 0;
            this.SpectrumAnalyzer2.Stats.Averages = 30;
            this.SpectrumAnalyzer2.Stats.ExpDecay = 5;
            this.SpectrumAnalyzer2.Window = Dew.Signal.TSignalWindowType.wtHanning;
            this.SpectrumAnalyzer2.ZeroPadding = 4;
            // 
            // SpectrumAnalyzerDialog
            // 
            this.SpectrumAnalyzerDialog.BlockAssign = false;
            this.SpectrumAnalyzerDialog.Docking = false;
            this.SpectrumAnalyzerDialog.FormCaption = null;
            this.SpectrumAnalyzerDialog.Name = null;
            this.SpectrumAnalyzerDialog.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.SpectrumAnalyzerDialog.ShowLive = false;
            this.SpectrumAnalyzerDialog.Source = this.SpectrumAnalyzer2;
            this.SpectrumAnalyzerDialog.SourceListIndex = 0;
            // 
            // ChartEditor
            // 
            this.ChartEditor.AlwaysShowFuncSrc = false;
            this.ChartEditor.Chart = this.SpectrumChart2;
            this.ChartEditor.HighLightTabs = false;
            this.ChartEditor.Location = new System.Drawing.Point(0, 0);
            this.ChartEditor.Name = "ChartEditor";
            this.ChartEditor.Options = null;
            this.ChartEditor.TabIndex = 0;
            // 
            // DemodulatorForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "DemodulatorForm";
            this.Text = "DemodulatorForm";
            this.Load += new System.EventHandler(this.DemodulatorForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpectrumChart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpectrumChart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void bwEdit_TextChanged(object sender, System.EventArgs e) {
			SignalDemodulator1.SubBandWidth = bwEdit.Position; // If this is not executed - everything is O.K.
			SignalDemodulator1.SubBandFrequency = freqEdit.Position;
			SignalRead1.RecordPosition = 0;
			SpectrumAnalyzer1.Pull();
			SpectrumAnalyzer1.Pull();
			SpectrumAnalyzer2.Update();
		}

		private void panel2_SizeChanged(object sender, System.EventArgs e) {
			SpectrumChart1.Height = panel2.Height / 2;
		}

        protected void Add(String s)
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void DemodulatorForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("TSignalDemodulator component moves the selected bandwidth down to 0Hz. "
            + "The component features multi-rate, multi-stage decimation which "
            + "allows demodulation of very narrow frequency bands (less then "
            + "0.01% of original bandwidth is not a problem). In the example "
            + "below you can change the Frequency and Bandwidth parameters. "
            + "Bandwidth change will have effect only when the change made will "
            + "result in sampling frequency reduction/increase by 2x. Both "
            + "frequency and bandwidth are defined in radians and must range "
            + "between 0 and 0.5 and frequency + bandwidth may not be bigger "
            + "then 0.5. The component also allows you to sample with sampling "
            + "frequency of 44.1Khz directly from the sound card and have a real "
            + "time frequency spectrum display of bandwidth between 20 and 20.1 Khz"
            + "with frequency resolution of 1 mHz (for example).");
        }

        private void SpectrumButton_Click(object sender, EventArgs e)
        {
            SpectrumAnalyzerDialog.ExecuteModal();
        }

        private void SpectrumChartButton_Click(object sender, EventArgs e)
        {
            ChartEditor.ShowModal();
        }

        private void SpectrumChart1_Click(object sender, EventArgs e)
        {

        }
	}
}
