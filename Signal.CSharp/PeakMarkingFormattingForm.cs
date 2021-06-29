using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Dew.Signal.Tee;
using Dew.Math;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for PeakMarkingFormatting.
	/// </summary>
	public class PeakMarkingFormattingForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private Dew.Signal.TSignalRead SignalRead1;
		private Dew.Signal.TSpectrumAnalyzer SpectrumAnalyzer1;
		private Steema.TeeChart.Styles.FastLine Series1;
		private Steema.TeeChart.Styles.Points Series2;
		private SpectrumChart SpectrumChart;
        private Button ChartButton;
        private Button SpectrumButton;
        private Dew.Signal.SpectrumAnalyzerDialog SpectrumAnalyzerDialog;
        private Steema.TeeChart.Editor ChartEditor;
		private System.ComponentModel.IContainer components;
        private  Dew.Math.Tee.MtxFastLine mtxFastLine1;

		public PeakMarkingFormattingForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.mtxFastLine1 = new Dew.Math.Tee.MtxFastLine();
            this.SpectrumChart.Series.Add(this.mtxFastLine1);

            SpectrumChart.Spectrums.Add();
			SpectrumChart.Spectrums[0].InputsItemIndex = 0;
			SpectrumChart.Spectrums[0].Input = SpectrumAnalyzer1;
			SpectrumChart.Spectrums[0].Series = SpectrumChart.Series[0];

			SpectrumMarkTool smt = new SpectrumMarkTool(SpectrumChart.Chart);
			smt.CursorActive = true;
			smt.DoubleClickClear = true;
			smt.PeakFilterMode = false;
			smt.MarkMode = SpectrumMarkMode.mmSingle;
			smt.MarkType = SpectrumMarkType.mtAmpltPhase;
			smt.MarkSeries = SpectrumChart.Series[1];
			smt.Series = SpectrumChart.Series[0];
			smt.AmpltFormat = "0.00#";
			smt.PhaseFormat = "0.00#";
			smt.FreqFormat = "0.00#";
			smt.LabelHeaders = true;
			smt.PeakZoomBand = false;
			SpectrumChart.Tools.Add(smt);

            AxisScaleTool axisTool = new AxisScaleTool(SpectrumChart.Chart);
            axisTool.UpperMargin = 20;
            axisTool.LowerMargin = 5;
            axisTool.AxisScaleMode = AxisScaleMode.amAuto;
            axisTool.DataIsSpectrum = true;
            axisTool.Axis = SpectrumChart.Axes.Left;
            SpectrumChart.Tools.Add(axisTool);

            //must be disabled for the AxisScaleTool to function:
            axisTool.Axis.Automatic = false;

            //Somehow the series.Color is not preserved by the IDE.
            smt.Series.Color = Color.Navy;

            SignalRead1.FileName = Dew.Demo.Utils.SourcePath() + @"\Data\bz.sfs";
			SignalRead1.OpenFile();
			SpectrumAnalyzer1.Pull();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeakMarkingFormattingForm));
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChartButton = new System.Windows.Forms.Button();
            this.SpectrumButton = new System.Windows.Forms.Button();
            this.SignalRead1 = new Dew.Signal.TSignalRead(this.components);
            this.SpectrumAnalyzer1 = new Dew.Signal.TSpectrumAnalyzer(this.components);
            this.SpectrumAnalyzerDialog = new Dew.Signal.SpectrumAnalyzerDialog(this.components);
            this.SpectrumChart = new Dew.Signal.Tee.SpectrumChart();
            this.Series1 = new Steema.TeeChart.Styles.FastLine();
            this.Series2 = new Steema.TeeChart.Styles.Points();
            this.ChartEditor = new Steema.TeeChart.Editor(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpectrumChart)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(592, 118);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChartButton);
            this.panel1.Controls.Add(this.SpectrumButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 501);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 48);
            this.panel1.TabIndex = 1;
            // 
            // ChartButton
            // 
            this.ChartButton.Location = new System.Drawing.Point(130, 7);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(120, 29);
            this.ChartButton.TabIndex = 4;
            this.ChartButton.Text = "Chart series...";
            this.ChartButton.UseVisualStyleBackColor = true;
            this.ChartButton.Click += new System.EventHandler(this.ChartButton_Click);
            // 
            // SpectrumButton
            // 
            this.SpectrumButton.Location = new System.Drawing.Point(14, 7);
            this.SpectrumButton.Name = "SpectrumButton";
            this.SpectrumButton.Size = new System.Drawing.Size(90, 29);
            this.SpectrumButton.TabIndex = 3;
            this.SpectrumButton.Text = "Spectrum...";
            this.SpectrumButton.UseVisualStyleBackColor = true;
            this.SpectrumButton.Click += new System.EventHandler(this.SpectrumButton_Click);
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
            this.SpectrumAnalyzer1.Input = this.SignalRead1;
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
            this.SpectrumAnalyzer1.SamplingFrequency = 16D;
            this.SpectrumAnalyzer1.SpectrumScale = 0D;
            this.SpectrumAnalyzer1.Stats.Averaged = 0;
            this.SpectrumAnalyzer1.Stats.Averages = 30;
            this.SpectrumAnalyzer1.Stats.ExpDecay = 5;
            this.SpectrumAnalyzer1.Window = Dew.Signal.TSignalWindowType.wtHanning;
            this.SpectrumAnalyzer1.ZeroPadding = 1;
            this.SpectrumAnalyzer1.OnParameterUpdateEvent += new Dew.Math.TNotifyEvent(this.SpectrumAnalyzer1_OnParameterUpdateEvent);
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
            // SpectrumChart
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
            this.SpectrumChart.Axes.Bottom.Grid.DrawEvery = 1;
            this.SpectrumChart.Axes.Bottom.Grid.Style = Steema.TeeChart.Drawing.DashStyle.Dash;
            this.SpectrumChart.Axes.Bottom.Grid.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Labels.Axis = this.SpectrumChart.Axes.Bottom;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart.Axes.Bottom.Labels.Brush.Solid = true;
            this.SpectrumChart.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.SpectrumChart.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.Bottom.Labels.Font.Size = 9;
            this.SpectrumChart.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            this.SpectrumChart.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            this.SpectrumChart.Axes.Bottom.Labels.Separation = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.MinorTicks.Length = 2;
            this.SpectrumChart.Axes.Bottom.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Ticks.Length = 4;
            this.SpectrumChart.Axes.Bottom.Ticks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.TicksInner.Length = 0;
            this.SpectrumChart.Axes.Bottom.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart.Axes.Bottom.Title.Brush.Solid = true;
            this.SpectrumChart.Axes.Bottom.Title.Brush.Visible = true;
            this.SpectrumChart.Axes.Bottom.Title.Caption = "Frequency [Hz]";
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.SpectrumChart.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.Bottom.Title.Font.Size = 11;
            this.SpectrumChart.Axes.Bottom.Title.Font.SizeFloat = 11F;
            this.SpectrumChart.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            this.SpectrumChart.Axes.Bottom.Title.Lines = new string[] {
        "Frequency [Hz]"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.AxisPen.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Grid.Style = Steema.TeeChart.Drawing.DashStyle.Dash;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Labels.Axis = this.SpectrumChart.Axes.Depth;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart.Axes.Depth.Labels.Brush.Solid = true;
            this.SpectrumChart.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.SpectrumChart.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.Depth.Labels.Font.Size = 9;
            this.SpectrumChart.Axes.Depth.Labels.Font.SizeFloat = 9F;
            this.SpectrumChart.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.MinorTicks.Length = 2;
            this.SpectrumChart.Axes.Depth.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Ticks.Length = 4;
            this.SpectrumChart.Axes.Depth.Ticks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.TicksInner.Length = 0;
            this.SpectrumChart.Axes.Depth.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart.Axes.Depth.Title.Brush.Solid = true;
            this.SpectrumChart.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart.Axes.Depth.Title.Font.Brush.Solid = true;
            this.SpectrumChart.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.Depth.Title.Font.Size = 11;
            this.SpectrumChart.Axes.Depth.Title.Font.SizeFloat = 11F;
            this.SpectrumChart.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.AxisPen.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Grid.Style = Steema.TeeChart.Drawing.DashStyle.Dash;
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Labels.Axis = this.SpectrumChart.Axes.DepthTop;
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart.Axes.DepthTop.Labels.Brush.Solid = true;
            this.SpectrumChart.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.SpectrumChart.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.DepthTop.Labels.Font.Size = 9;
            this.SpectrumChart.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            this.SpectrumChart.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.MinorTicks.Length = 2;
            this.SpectrumChart.Axes.DepthTop.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Ticks.Length = 4;
            this.SpectrumChart.Axes.DepthTop.Ticks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.TicksInner.Length = 0;
            this.SpectrumChart.Axes.DepthTop.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart.Axes.DepthTop.Title.Brush.Solid = true;
            this.SpectrumChart.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.SpectrumChart.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.DepthTop.Title.Font.Size = 11;
            this.SpectrumChart.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            this.SpectrumChart.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.AxisPen.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Grid.DrawEvery = 1;
            this.SpectrumChart.Axes.Left.Grid.Style = Steema.TeeChart.Drawing.DashStyle.Dash;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Labels.Axis = this.SpectrumChart.Axes.Left;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart.Axes.Left.Labels.Brush.Solid = true;
            this.SpectrumChart.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart.Axes.Left.Labels.Font.Brush.Solid = true;
            this.SpectrumChart.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.Left.Labels.Font.Size = 9;
            this.SpectrumChart.Axes.Left.Labels.Font.SizeFloat = 9F;
            this.SpectrumChart.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.MinorTicks.Length = 2;
            this.SpectrumChart.Axes.Left.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Ticks.Length = 4;
            this.SpectrumChart.Axes.Left.Ticks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.TicksInner.Length = 0;
            this.SpectrumChart.Axes.Left.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart.Axes.Left.Title.Brush.Solid = true;
            this.SpectrumChart.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart.Axes.Left.Title.Font.Brush.Solid = true;
            this.SpectrumChart.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.Left.Title.Font.Size = 11;
            this.SpectrumChart.Axes.Left.Title.Font.SizeFloat = 11F;
            this.SpectrumChart.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.AxisPen.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Grid.Style = Steema.TeeChart.Drawing.DashStyle.Dash;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Labels.Axis = this.SpectrumChart.Axes.Right;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart.Axes.Right.Labels.Brush.Solid = true;
            this.SpectrumChart.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart.Axes.Right.Labels.Font.Brush.Solid = true;
            this.SpectrumChart.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.Right.Labels.Font.Size = 9;
            this.SpectrumChart.Axes.Right.Labels.Font.SizeFloat = 9F;
            this.SpectrumChart.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.MinorTicks.Length = 2;
            this.SpectrumChart.Axes.Right.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Ticks.Length = 4;
            this.SpectrumChart.Axes.Right.Ticks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.TicksInner.Length = 0;
            this.SpectrumChart.Axes.Right.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart.Axes.Right.Title.Brush.Solid = true;
            this.SpectrumChart.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart.Axes.Right.Title.Font.Brush.Solid = true;
            this.SpectrumChart.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.Right.Title.Font.Size = 11;
            this.SpectrumChart.Axes.Right.Title.Font.SizeFloat = 11F;
            this.SpectrumChart.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Grid.Style = Steema.TeeChart.Drawing.DashStyle.Dash;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Labels.Axis = this.SpectrumChart.Axes.Top;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart.Axes.Top.Labels.Brush.Solid = true;
            this.SpectrumChart.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart.Axes.Top.Labels.Font.Brush.Solid = true;
            this.SpectrumChart.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.Top.Labels.Font.Size = 9;
            this.SpectrumChart.Axes.Top.Labels.Font.SizeFloat = 9F;
            this.SpectrumChart.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.MinorTicks.Length = 2;
            this.SpectrumChart.Axes.Top.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Ticks.Length = 4;
            this.SpectrumChart.Axes.Top.Ticks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.TicksInner.Length = 0;
            this.SpectrumChart.Axes.Top.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart.Axes.Top.Title.Brush.Solid = true;
            this.SpectrumChart.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart.Axes.Top.Title.Font.Brush.Solid = true;
            this.SpectrumChart.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.Top.Title.Font.Size = 11;
            this.SpectrumChart.Axes.Top.Title.Font.SizeFloat = 11F;
            this.SpectrumChart.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.SpectrumChart.Color = System.Drawing.Color.Silver;
            this.SpectrumChart.Cursor = System.Windows.Forms.Cursors.Default;
            this.SpectrumChart.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart.Footer.Brush.Solid = true;
            this.SpectrumChart.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.SpectrumChart.Footer.Font.Brush.Solid = true;
            this.SpectrumChart.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Footer.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Footer.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Footer.Font.Size = 8;
            this.SpectrumChart.Footer.Font.SizeFloat = 8F;
            this.SpectrumChart.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Footer.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Footer.Shadow.Brush.Solid = true;
            this.SpectrumChart.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SpectrumChart.Header.Brush.Solid = true;
            this.SpectrumChart.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Header.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart.Header.Font.Brush.Solid = true;
            this.SpectrumChart.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Header.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Header.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Header.Font.Size = 12;
            this.SpectrumChart.Header.Font.SizeFloat = 12F;
            this.SpectrumChart.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Header.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Header.ImageBevel.Brush.Visible = true;
            this.SpectrumChart.Header.Lines = new string[] {
        "Frequency spectrum"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SpectrumChart.Header.Shadow.Brush.Solid = true;
            this.SpectrumChart.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Legend.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart.Legend.Brush.Solid = true;
            this.SpectrumChart.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart.Legend.Font.Brush.Solid = true;
            this.SpectrumChart.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Legend.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Legend.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Legend.Font.Size = 9;
            this.SpectrumChart.Legend.Font.SizeFloat = 9F;
            this.SpectrumChart.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Legend.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Legend.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SpectrumChart.Legend.Shadow.Brush.Solid = true;
            this.SpectrumChart.Legend.Shadow.Brush.Visible = true;
            this.SpectrumChart.Legend.Shadow.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Legend.Symbol.Legend = this.SpectrumChart.Legend;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Legend.Symbol.Shadow.Brush.Solid = true;
            this.SpectrumChart.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart.Legend.Title.Brush.Solid = true;
            this.SpectrumChart.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.SpectrumChart.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.SpectrumChart.Legend.Title.Font.Brush.Solid = true;
            this.SpectrumChart.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Legend.Title.Font.Size = 8;
            this.SpectrumChart.Legend.Title.Font.SizeFloat = 8F;
            this.SpectrumChart.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Legend.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Legend.Title.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Legend.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart.Legend.Title.Shadow.Brush.Visible = true;
            this.SpectrumChart.Legend.Visible = false;
            this.SpectrumChart.Location = new System.Drawing.Point(0, 118);
            this.SpectrumChart.Name = "SpectrumChart";
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            // 
            // 
            // 
            this.SpectrumChart.Panel.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.SpectrumChart.Panel.Brush.Gradient.UseMiddle = true;
            this.SpectrumChart.Panel.Brush.Solid = true;
            this.SpectrumChart.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Panel.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Panel.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Panel.Shadow.Brush.Solid = true;
            this.SpectrumChart.Panel.Shadow.Brush.Visible = true;
            this.SpectrumChart.Series.Add(this.Series1);
            this.SpectrumChart.Series.Add(this.Series2);
            this.SpectrumChart.Size = new System.Drawing.Size(592, 383);
            this.SpectrumChart.SpectrumPart = Dew.Signal.Tee.SpectrumPart.sppAmplt;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart.SubFooter.Brush.Solid = true;
            this.SpectrumChart.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.SpectrumChart.SubFooter.Font.Brush.Solid = true;
            this.SpectrumChart.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.SubFooter.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.SubFooter.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.SubFooter.Font.Size = 8;
            this.SpectrumChart.SubFooter.Font.SizeFloat = 8F;
            this.SpectrumChart.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.SubFooter.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.SubFooter.Shadow.Brush.Solid = true;
            this.SpectrumChart.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SpectrumChart.SubHeader.Brush.Solid = true;
            this.SpectrumChart.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart.SubHeader.Font.Brush.Solid = true;
            this.SpectrumChart.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.SubHeader.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.SubHeader.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.SubHeader.Font.Size = 12;
            this.SpectrumChart.SubHeader.Font.SizeFloat = 12F;
            this.SpectrumChart.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.SubHeader.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SpectrumChart.SubHeader.Shadow.Brush.Solid = true;
            this.SpectrumChart.SubHeader.Shadow.Brush.Visible = true;
            this.SpectrumChart.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart.Walls.Back.Brush.Solid = true;
            this.SpectrumChart.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Walls.Back.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Walls.Back.Shadow.Brush.Solid = true;
            this.SpectrumChart.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart.Walls.Bottom.Brush.Solid = true;
            this.SpectrumChart.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Walls.Bottom.Shadow.Brush.Solid = true;
            this.SpectrumChart.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.SpectrumChart.Walls.Left.Brush.Solid = true;
            this.SpectrumChart.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Walls.Left.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Walls.Left.Shadow.Brush.Solid = true;
            this.SpectrumChart.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.SpectrumChart.Walls.Right.Brush.Solid = true;
            this.SpectrumChart.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Walls.Right.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Walls.Right.Shadow.Brush.Solid = true;
            this.SpectrumChart.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Zoom.Animated = true;
            // 
            // 
            // 
            this.SpectrumChart.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.SpectrumChart.Zoom.Brush.Solid = true;
            this.SpectrumChart.Zoom.Brush.Visible = false;
            this.SpectrumChart.Zoom.FullRepaint = true;
            this.SpectrumChart.Zoom.History = true;
            // 
            // 
            // 
            this.SpectrumChart.Zoom.Pen.Visible = true;
            this.SpectrumChart.Click += new System.EventHandler(this.SpectrumChart_Click);
            // 
            // Series1
            // 
            // 
            // 
            // 
            this.Series1.Brush.Color = System.Drawing.Color.Empty;
            this.Series1.Brush.Solid = true;
            this.Series1.Brush.Visible = true;
            this.Series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.Series1.ColorEach = false;
            cursor1.CursorType = Steema.TeeChart.Drawing.CursorType.Default;
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
            this.Series1.Marks.Font.Shadow.Visible = true;
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
            this.Series1.Marks.Shadow.Visible = true;
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
            this.Series1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
            this.Series1.Marks.TailParams.Margin = 0F;
            this.Series1.Marks.TailParams.PointerHeight = 9D;
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
            // Series2
            // 
            // 
            // 
            // 
            this.Series2.Brush.Color = System.Drawing.Color.Empty;
            this.Series2.Brush.Solid = true;
            this.Series2.Brush.Visible = true;
            this.Series2.Color = System.Drawing.Color.Red;
            this.Series2.ColorEach = false;
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
            this.Series2.Marks.Angle = 90D;
            // 
            // 
            // 
            this.Series2.Marks.Arrow.Visible = false;
            this.Series2.Marks.ArrowLength = 21;
            // 
            // 
            // 
            this.Series2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.Series2.Marks.Brush.Gradient.GammaCorrection = true;
            this.Series2.Marks.Brush.Gradient.Transparency = 30;
            this.Series2.Marks.Brush.Gradient.UseMiddle = true;
            this.Series2.Marks.Brush.Gradient.Visible = true;
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
            this.Series2.Marks.Symbol.Brush.Color = System.Drawing.Color.Red;
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
            this.Series2.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
            this.Series2.Marks.TailParams.Margin = 0F;
            this.Series2.Marks.TailParams.PointerHeight = 8D;
            this.Series2.Marks.TailParams.PointerWidth = 8D;
            this.Series2.Marks.TailStyle = Steema.TeeChart.Styles.MarksTail.None;
            this.Series2.Marks.Visible = true;
            this.Series2.OriginalCursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Pointer.Brush.Color = System.Drawing.Color.Red;
            this.Series2.Pointer.Brush.Solid = true;
            this.Series2.Pointer.Brush.Visible = true;
            this.Series2.Pointer.HorizSize = 3;
            // 
            // 
            // 
            this.Series2.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Series2.Pointer.SizeDouble = 0D;
            this.Series2.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.Series2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.Series2.Pointer.VertSize = 3;
            this.Series2.RandomData = true;
            this.Series2.Title = "point1";
            this.Series2.Type = "Steema.TeeChart.Styles.Points";
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
            // ChartEditor
            // 
            this.ChartEditor.AlwaysShowFuncSrc = false;
            this.ChartEditor.Chart = this.SpectrumChart;
            this.ChartEditor.HighLightTabs = false;
            this.ChartEditor.Location = new System.Drawing.Point(0, 0);
            this.ChartEditor.Name = "ChartEditor";
            this.ChartEditor.Options = null;
            this.ChartEditor.TabIndex = 0;
            // 
            // PeakMarkingFormattingForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(592, 549);
            this.Controls.Add(this.SpectrumChart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "PeakMarkingFormattingForm";
            this.Text = "PeakMarkingFormatting";
            this.Load += new System.EventHandler(this.PeakMarkingFormattingForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpectrumChart)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private void SpectrumButton_Click(object sender, EventArgs e)
        {
            SpectrumAnalyzerDialog.ExecuteModal();
        }

        private void ChartButton_Click(object sender, EventArgs e)
        {
            ChartEditor.ShowModal();
        }

        private void SpectrumChart_Click(object sender, EventArgs e)
        {

        }      

        protected void Add(String s)
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void PeakMarkingFormattingForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("Marked peaks can be formated in many ways:");
            Add("");
            Add(" - Change the formating of the associated chart series by clicking on the Chart button.");
            Add(" - Change the formating of displayed amplitude labels, by setting the properties of the Mark tool.");
        }

        private void SpectrumAnalyzer1_OnParameterUpdateEvent(object Sender)
        {
            SpectrumAnalyzer1.Update();
        }
    }
}
