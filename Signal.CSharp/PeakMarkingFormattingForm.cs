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
        private Dew.Signal.Editors.SpectrumAnalyzerDialog SpectrumAnalyzerDialog;
        private Steema.TeeChart.Editor ChartEditor;
		private System.ComponentModel.IContainer components;

		public PeakMarkingFormattingForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

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

            SignalRead1.FileName = Dew.Demo.Utils.SourcePath() + @"\Data\bz.dat";
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
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(PeakMarkingFormattingForm));
            Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            ChartButton = new Button();
            SpectrumButton = new Button();
            SignalRead1 = new Dew.Signal.TSignalRead(components);
            SpectrumAnalyzer1 = new Dew.Signal.TSpectrumAnalyzer(components);
            SpectrumAnalyzerDialog = new Dew.Signal.Editors.SpectrumAnalyzerDialog(components);
            SpectrumChart = new SpectrumChart();
            Series1 = new Steema.TeeChart.Styles.FastLine();
            Series2 = new Steema.TeeChart.Styles.Points();
            ChartEditor = new Steema.TeeChart.Editor(components);
            panel1.SuspendLayout();
            ((ISupportInitialize)SpectrumChart).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Top;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1208, 118);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            panel1.Controls.Add(ChartButton);
            panel1.Controls.Add(SpectrumButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 807);
            panel1.Name = "panel1";
            panel1.Size = new Size(1208, 48);
            panel1.TabIndex = 1;
            // 
            // ChartButton
            // 
            ChartButton.Location = new Point(130, 7);
            ChartButton.Name = "ChartButton";
            ChartButton.Size = new Size(120, 29);
            ChartButton.TabIndex = 4;
            ChartButton.Text = "Chart series...";
            ChartButton.UseVisualStyleBackColor = true;
            ChartButton.Click += ChartButton_Click;
            // 
            // SpectrumButton
            // 
            SpectrumButton.Location = new Point(14, 7);
            SpectrumButton.Name = "SpectrumButton";
            SpectrumButton.Size = new Size(90, 29);
            SpectrumButton.TabIndex = 3;
            SpectrumButton.Text = "Spectrum...";
            SpectrumButton.UseVisualStyleBackColor = true;
            SpectrumButton.Click += SpectrumButton_Click;
            // 
            // SignalRead1
            // 
            SignalRead1.ChannelCount = 1;
            SignalRead1.Complex = false;
            SignalRead1.DataSerialization = resources.GetString("SignalRead1.DataSerialization");
            SignalRead1.FloatPrecision = TMtxFloatPrecision.mvDouble;
            SignalRead1.FloatPrecisionLock = false;
            SignalRead1.FramesPerSecond = 0.0009765625D;
            SignalRead1.IsDouble = true;
            SignalRead1.Length = 1024;
            SignalRead1.OverlappingSamples = 0;
            SignalRead1.PostBufferSamples = 0;
            SignalRead1.RecordNumber = 0;
            SignalRead1.RecordPosition = 0L;
            // 
            // SpectrumAnalyzer1
            // 
            SpectrumAnalyzer1.ArOrder = 100;
            SpectrumAnalyzer1.Bands.TemplateIndex = -1;
            SpectrumAnalyzer1.Bands.TemplatesSerialization = "AAAAAA==";
            SpectrumAnalyzer1.Complex = false;
            SpectrumAnalyzer1.FloatPrecision = TMtxFloatPrecision.mvDouble;
            SpectrumAnalyzer1.FloatPrecisionLock = false;
            SpectrumAnalyzer1.Harmonics = 10;
            SpectrumAnalyzer1.Input = SignalRead1;
            SpectrumAnalyzer1.IsDouble = true;
            SpectrumAnalyzer1.Length = 64;
            SpectrumAnalyzer1.LogBase = 0D;
            SpectrumAnalyzer1.LogScale = 0D;
            SpectrumAnalyzer1.MainlobeWidth = 8;
            SpectrumAnalyzer1.Peaks.HarmonicsCount = 10;
            SpectrumAnalyzer1.Peaks.Interpolation.Method = Dew.Signal.TInterpolationMethod.imNone;
            SpectrumAnalyzer1.Peaks.Interpolation.RecursiveHarmonics = Dew.Signal.TRecursiveHarmonics.rhNone;
            SpectrumAnalyzer1.Peaks.LargestCount = 1;
            SpectrumAnalyzer1.Peaks.LargestRatio = 1E+15D;
            SpectrumAnalyzer1.Peaks.NormalizedAmplt.PeakNumber = 1;
            SpectrumAnalyzer1.Peaks.NormalizedFreq.PeakNumber = 1;
            SpectrumAnalyzer1.Report.AmplitudeFormat = null;
            SpectrumAnalyzer1.Report.FrequencyFormat = null;
            SpectrumAnalyzer1.Report.PhaseFormat = null;
            SpectrumAnalyzer1.Report.UseTab = false;
            SpectrumAnalyzer1.Rotation = 0;
            SpectrumAnalyzer1.SamplingFrequency = 16D;
            SpectrumAnalyzer1.Stats.Averaged = 0;
            SpectrumAnalyzer1.Stats.Averages = 30;
            SpectrumAnalyzer1.Stats.ExpDecay = 5;
            SpectrumAnalyzer1.Window = Dew.Signal.TSignalWindowType.wtHanning;
            SpectrumAnalyzer1.ZeroPadding = 1;
            SpectrumAnalyzer1.OnParameterUpdateEvent += SpectrumAnalyzer1_OnParameterUpdate;
            // 
            // SpectrumAnalyzerDialog
            // 
            SpectrumAnalyzerDialog.Docking = false;
            SpectrumAnalyzerDialog.FormCaption = null;
            SpectrumAnalyzerDialog.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            SpectrumAnalyzerDialog.ShowLive = false;
            SpectrumAnalyzerDialog.Source = SpectrumAnalyzer1;
            SpectrumAnalyzerDialog.SourceListIndex = 0;
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
            SpectrumChart.Axes.Bottom.Grid.DrawEvery = 1;
            SpectrumChart.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.Labels.Brush.Color = Color.White;
            SpectrumChart.Axes.Bottom.Labels.Brush.Solid = true;
            SpectrumChart.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart.Axes.Bottom.Labels.Font.Brush.Solid = true;
            SpectrumChart.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.Bottom.Labels.Font.Size = 9;
            SpectrumChart.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            SpectrumChart.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            SpectrumChart.Axes.Bottom.Labels.Separation = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.Title.Brush.Color = Color.Silver;
            SpectrumChart.Axes.Bottom.Title.Brush.Solid = true;
            SpectrumChart.Axes.Bottom.Title.Brush.Visible = true;
            SpectrumChart.Axes.Bottom.Title.Caption = "Frequency [Hz]";
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart.Axes.Bottom.Title.Font.Brush.Solid = true;
            SpectrumChart.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.Bottom.Title.Font.Size = 11;
            SpectrumChart.Axes.Bottom.Title.Font.SizeFloat = 11F;
            SpectrumChart.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            SpectrumChart.Axes.Bottom.Title.Lines = new string[]
    {
    "Frequency [Hz]"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Depth.Labels.Brush.Color = Color.White;
            SpectrumChart.Axes.Depth.Labels.Brush.Solid = true;
            SpectrumChart.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart.Axes.Depth.Labels.Font.Brush.Solid = true;
            SpectrumChart.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.Depth.Labels.Font.Size = 9;
            SpectrumChart.Axes.Depth.Labels.Font.SizeFloat = 9F;
            SpectrumChart.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Depth.Title.Brush.Color = Color.Silver;
            SpectrumChart.Axes.Depth.Title.Brush.Solid = true;
            SpectrumChart.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart.Axes.Depth.Title.Font.Brush.Solid = true;
            SpectrumChart.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.Depth.Title.Font.Size = 11;
            SpectrumChart.Axes.Depth.Title.Font.SizeFloat = 11F;
            SpectrumChart.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Depth.Title.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.DepthTop.Labels.Brush.Color = Color.White;
            SpectrumChart.Axes.DepthTop.Labels.Brush.Solid = true;
            SpectrumChart.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            SpectrumChart.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.DepthTop.Labels.Font.Size = 9;
            SpectrumChart.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            SpectrumChart.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.DepthTop.Title.Brush.Color = Color.Silver;
            SpectrumChart.Axes.DepthTop.Title.Brush.Solid = true;
            SpectrumChart.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart.Axes.DepthTop.Title.Font.Brush.Solid = true;
            SpectrumChart.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.DepthTop.Title.Font.Size = 11;
            SpectrumChart.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            SpectrumChart.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Grid.DrawEvery = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Labels.Brush.Color = Color.White;
            SpectrumChart.Axes.Left.Labels.Brush.Solid = true;
            SpectrumChart.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart.Axes.Left.Labels.Font.Brush.Solid = true;
            SpectrumChart.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.Left.Labels.Font.Size = 9;
            SpectrumChart.Axes.Left.Labels.Font.SizeFloat = 9F;
            SpectrumChart.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Left.Labels.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Title.Brush.Color = Color.Silver;
            SpectrumChart.Axes.Left.Title.Brush.Solid = true;
            SpectrumChart.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart.Axes.Left.Title.Font.Brush.Solid = true;
            SpectrumChart.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.Left.Title.Font.Size = 11;
            SpectrumChart.Axes.Left.Title.Font.SizeFloat = 11F;
            SpectrumChart.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Left.Title.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Right.Labels.Brush.Color = Color.White;
            SpectrumChart.Axes.Right.Labels.Brush.Solid = true;
            SpectrumChart.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart.Axes.Right.Labels.Font.Brush.Solid = true;
            SpectrumChart.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.Right.Labels.Font.Size = 9;
            SpectrumChart.Axes.Right.Labels.Font.SizeFloat = 9F;
            SpectrumChart.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Right.Labels.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Right.Title.Brush.Color = Color.Silver;
            SpectrumChart.Axes.Right.Title.Brush.Solid = true;
            SpectrumChart.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Axes.Right.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart.Axes.Right.Title.Font.Brush.Solid = true;
            SpectrumChart.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.Right.Title.Font.Size = 11;
            SpectrumChart.Axes.Right.Title.Font.SizeFloat = 11F;
            SpectrumChart.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Right.Title.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Top.Labels.Brush.Color = Color.White;
            SpectrumChart.Axes.Top.Labels.Brush.Solid = true;
            SpectrumChart.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart.Axes.Top.Labels.Font.Brush.Solid = true;
            SpectrumChart.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.Top.Labels.Font.Size = 9;
            SpectrumChart.Axes.Top.Labels.Font.SizeFloat = 9F;
            SpectrumChart.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Top.Labels.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Top.Title.Brush.Color = Color.Silver;
            SpectrumChart.Axes.Top.Title.Brush.Solid = true;
            SpectrumChart.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Axes.Top.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart.Axes.Top.Title.Font.Brush.Solid = true;
            SpectrumChart.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.Top.Title.Font.Size = 11;
            SpectrumChart.Axes.Top.Title.Font.SizeFloat = 11F;
            SpectrumChart.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Top.Title.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Top.Title.Shadow.Brush.Visible = true;
            SpectrumChart.Color = Color.Silver;
            SpectrumChart.Dock = DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Footer.Brush.Color = Color.Silver;
            SpectrumChart.Footer.Brush.Solid = true;
            SpectrumChart.Footer.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Footer.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Footer.Font.Brush.Color = Color.Red;
            SpectrumChart.Footer.Font.Brush.Solid = true;
            SpectrumChart.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Footer.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Footer.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Footer.Font.Size = 8;
            SpectrumChart.Footer.Font.SizeFloat = 8F;
            SpectrumChart.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Footer.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Footer.ImageBevel.Brush.Solid = true;
            SpectrumChart.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Footer.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Footer.Shadow.Brush.Solid = true;
            SpectrumChart.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Header.Brush.Color = Color.FromArgb(192, 192, 192);
            SpectrumChart.Header.Brush.Solid = true;
            SpectrumChart.Header.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Header.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Header.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart.Header.Font.Brush.Solid = true;
            SpectrumChart.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Header.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Header.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Header.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Header.Font.Size = 12;
            SpectrumChart.Header.Font.SizeFloat = 12F;
            SpectrumChart.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Header.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Header.ImageBevel.Brush.Solid = true;
            SpectrumChart.Header.ImageBevel.Brush.Visible = true;
            SpectrumChart.Header.Lines = new string[]
    {
    "Frequency spectrum"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Header.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            SpectrumChart.Header.Shadow.Brush.Solid = true;
            SpectrumChart.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Legend.Brush.Color = Color.White;
            SpectrumChart.Legend.Brush.Solid = true;
            SpectrumChart.Legend.Brush.Visible = true;
            SpectrumChart.Legend.CheckBoxes = false;
            // 
            // 
            // 
            SpectrumChart.Legend.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Legend.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart.Legend.Font.Brush.Solid = true;
            SpectrumChart.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Legend.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Legend.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Legend.Font.Size = 9;
            SpectrumChart.Legend.Font.SizeFloat = 9F;
            SpectrumChart.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Legend.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Legend.ImageBevel.Brush.Solid = true;
            SpectrumChart.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Legend.Shadow.Brush.Color = Color.FromArgb(0, 0, 0);
            SpectrumChart.Legend.Shadow.Brush.Solid = true;
            SpectrumChart.Legend.Shadow.Brush.Visible = true;
            SpectrumChart.Legend.Shadow.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Legend.Symbol.Shadow.Brush.Solid = true;
            SpectrumChart.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Legend.Title.Brush.Color = Color.White;
            SpectrumChart.Legend.Title.Brush.Solid = true;
            SpectrumChart.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            SpectrumChart.Legend.Title.Font.Brush.Color = Color.Black;
            SpectrumChart.Legend.Title.Font.Brush.Solid = true;
            SpectrumChart.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Legend.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Legend.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Legend.Title.Font.Size = 8;
            SpectrumChart.Legend.Title.Font.SizeFloat = 8F;
            SpectrumChart.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Legend.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Legend.Title.Shadow.Brush.Solid = true;
            SpectrumChart.Legend.Title.Shadow.Brush.Visible = true;
            SpectrumChart.Legend.Visible = false;
            SpectrumChart.Location = new Point(0, 118);
            SpectrumChart.Name = "SpectrumChart";
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            // 
            // 
            // 
            SpectrumChart.Panel.Brush.Color = Color.Silver;
            SpectrumChart.Panel.Brush.Solid = true;
            SpectrumChart.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Panel.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Panel.ImageBevel.Brush.Solid = true;
            SpectrumChart.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Panel.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Panel.Shadow.Brush.Solid = true;
            SpectrumChart.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            SpectrumChart.Printer.Margins = margins1;
            SpectrumChart.Series.Add(Series1);
            SpectrumChart.Series.Add(Series2);
            SpectrumChart.Size = new Size(1208, 689);
            SpectrumChart.SpectrumPart = SpectrumPart.sppAmplt;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.SubFooter.Brush.Color = Color.Silver;
            SpectrumChart.SubFooter.Brush.Solid = true;
            SpectrumChart.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.SubFooter.Font.Brush.Color = Color.Red;
            SpectrumChart.SubFooter.Font.Brush.Solid = true;
            SpectrumChart.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.SubFooter.Font.Shadow.Brush.Solid = true;
            SpectrumChart.SubFooter.Font.Shadow.Brush.Visible = true;
            SpectrumChart.SubFooter.Font.Size = 8;
            SpectrumChart.SubFooter.Font.SizeFloat = 8F;
            SpectrumChart.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.SubFooter.ImageBevel.Brush.Solid = true;
            SpectrumChart.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.SubFooter.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.SubFooter.Shadow.Brush.Solid = true;
            SpectrumChart.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.SubHeader.Brush.Color = Color.FromArgb(192, 192, 192);
            SpectrumChart.SubHeader.Brush.Solid = true;
            SpectrumChart.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.SubHeader.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart.SubHeader.Font.Brush.Solid = true;
            SpectrumChart.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.SubHeader.Font.Shadow.Brush.Solid = true;
            SpectrumChart.SubHeader.Font.Shadow.Brush.Visible = true;
            SpectrumChart.SubHeader.Font.Size = 12;
            SpectrumChart.SubHeader.Font.SizeFloat = 12F;
            SpectrumChart.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.SubHeader.ImageBevel.Brush.Solid = true;
            SpectrumChart.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.SubHeader.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            SpectrumChart.SubHeader.Shadow.Brush.Solid = true;
            SpectrumChart.SubHeader.Shadow.Brush.Visible = true;
            SpectrumChart.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Walls.Back.Brush.Color = Color.Silver;
            SpectrumChart.Walls.Back.Brush.Solid = true;
            SpectrumChart.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Walls.Back.ImageBevel.Brush.Solid = true;
            SpectrumChart.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Walls.Back.Shadow.Brush.Solid = true;
            SpectrumChart.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Walls.Bottom.Brush.Color = Color.White;
            SpectrumChart.Walls.Bottom.Brush.Solid = true;
            SpectrumChart.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Walls.Bottom.ImageBevel.Brush.Solid = true;
            SpectrumChart.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Walls.Bottom.Shadow.Brush.Solid = true;
            SpectrumChart.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Walls.Left.Brush.Color = Color.LightYellow;
            SpectrumChart.Walls.Left.Brush.Solid = true;
            SpectrumChart.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Walls.Left.ImageBevel.Brush.Solid = true;
            SpectrumChart.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Walls.Left.Shadow.Brush.Solid = true;
            SpectrumChart.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Walls.Right.Brush.Color = Color.LightYellow;
            SpectrumChart.Walls.Right.Brush.Solid = true;
            SpectrumChart.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Walls.Right.ImageBevel.Brush.Solid = true;
            SpectrumChart.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Walls.Right.Shadow.Brush.Solid = true;
            SpectrumChart.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Zoom.Animated = true;
            // 
            // 
            // 
            SpectrumChart.Zoom.Brush.Color = Color.LightBlue;
            SpectrumChart.Zoom.Brush.Solid = true;
            SpectrumChart.Zoom.Brush.Visible = false;
            SpectrumChart.Zoom.History = true;
            // 
            // 
            // 
            SpectrumChart.Zoom.Pen.Visible = true;
            SpectrumChart.Click += SpectrumChart_Click;
            // 
            // Series1
            // 
            // 
            // 
            // 
            Series1.Brush.Color = Color.Empty;
            Series1.Brush.Solid = true;
            Series1.Brush.Visible = true;
            Series1.Color = Color.FromArgb(119, 153, 214);
            Series1.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            Series1.Legend.Brush.Color = Color.White;
            Series1.Legend.Brush.Solid = true;
            Series1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            Series1.Legend.Font.Bold = false;
            // 
            // 
            // 
            Series1.Legend.Font.Brush.Color = Color.Black;
            Series1.Legend.Font.Brush.Solid = true;
            Series1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            Series1.Legend.Font.Shadow.Brush.Solid = true;
            Series1.Legend.Font.Shadow.Brush.Visible = true;
            Series1.Legend.Font.Size = 8;
            Series1.Legend.Font.SizeFloat = 8F;
            Series1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Series1.Legend.ImageBevel.Brush.Color = Color.LightGray;
            Series1.Legend.ImageBevel.Brush.Solid = true;
            Series1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series1.Legend.Shadow.Brush.Color = Color.DarkGray;
            Series1.Legend.Shadow.Brush.Solid = true;
            Series1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series1.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            Series1.Marks.Brush.Solid = true;
            Series1.Marks.Brush.Visible = true;
            // 
            // 
            // 
            Series1.Marks.Font.Bold = false;
            // 
            // 
            // 
            Series1.Marks.Font.Brush.Color = Color.Black;
            Series1.Marks.Font.Brush.Solid = true;
            Series1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series1.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            Series1.Marks.Font.Shadow.Brush.Solid = true;
            Series1.Marks.Font.Shadow.Brush.Visible = true;
            Series1.Marks.Font.Shadow.Visible = true;
            Series1.Marks.Font.Size = 8;
            Series1.Marks.Font.SizeFloat = 8F;
            Series1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Series1.Marks.ImageBevel.Brush.Color = Color.LightGray;
            Series1.Marks.ImageBevel.Brush.Solid = true;
            Series1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series1.Marks.Shadow.Brush.Color = Color.Gray;
            Series1.Marks.Shadow.Brush.Solid = true;
            Series1.Marks.Shadow.Brush.Visible = true;
            Series1.Marks.Shadow.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series1.Marks.Symbol.Brush.Color = Color.White;
            Series1.Marks.Symbol.Brush.Solid = true;
            Series1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series1.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            Series1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            Series1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series1.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            Series1.Marks.Symbol.Shadow.Brush.Solid = true;
            Series1.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            Series1.Marks.TailParams.PointerHeight = 9D;
            Series1.Title = "fastLine1";
            Series1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            // 
            // 
            // 
            Series1.XValues.DataMember = "X";
            Series1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            Series1.XValues.Value = new double[]
    {
    0D,
    1D,
    2D,
    3D,
    4D,
    5D,
    6D,
    7D,
    8D,
    9D,
    10D,
    11D,
    12D,
    13D,
    14D,
    15D,
    16D,
    17D,
    18D,
    19D,
    20D,
    21D,
    22D,
    23D,
    24D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D
    };
            // 
            // 
            // 
            Series1.YValues.DataMember = "Y";
            Series1.YValues.Value = new double[]
    {
    137D,
    222D,
    175D,
    284D,
    311D,
    330D,
    209D,
    257D,
    270D,
    299D,
    365D,
    423D,
    538D,
    490D,
    516D,
    582D,
    648D,
    663D,
    656D,
    706D,
    719D,
    806D,
    765D,
    788D,
    776D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D
    };
            // 
            // Series2
            // 
            // 
            // 
            // 
            Series2.Brush.Color = Color.Empty;
            Series2.Brush.Solid = true;
            Series2.Brush.Visible = true;
            Series2.Color = Color.Red;
            Series2.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            Series2.Legend.Brush.Color = Color.White;
            Series2.Legend.Brush.Solid = true;
            Series2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            Series2.Legend.Font.Bold = false;
            // 
            // 
            // 
            Series2.Legend.Font.Brush.Color = Color.Black;
            Series2.Legend.Font.Brush.Solid = true;
            Series2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series2.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            Series2.Legend.Font.Shadow.Brush.Solid = true;
            Series2.Legend.Font.Shadow.Brush.Visible = true;
            Series2.Legend.Font.Size = 8;
            Series2.Legend.Font.SizeFloat = 8F;
            Series2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Series2.Legend.ImageBevel.Brush.Color = Color.LightGray;
            Series2.Legend.ImageBevel.Brush.Solid = true;
            Series2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series2.Legend.Shadow.Brush.Color = Color.DarkGray;
            Series2.Legend.Shadow.Brush.Solid = true;
            Series2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            Series2.Marks.Angle = 90D;
            // 
            // 
            // 
            Series2.Marks.Arrow.Visible = false;
            Series2.Marks.ArrowLength = 21;
            // 
            // 
            // 
            Series2.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            // 
            // 
            // 
            Series2.Marks.Brush.Gradient.GammaCorrection = true;
            Series2.Marks.Brush.Gradient.Transparency = 30;
            Series2.Marks.Brush.Gradient.UseMiddle = true;
            Series2.Marks.Brush.Gradient.Visible = true;
            Series2.Marks.Brush.Solid = true;
            Series2.Marks.Brush.Visible = true;
            // 
            // 
            // 
            Series2.Marks.Font.Bold = false;
            // 
            // 
            // 
            Series2.Marks.Font.Brush.Color = Color.Black;
            Series2.Marks.Font.Brush.Solid = true;
            Series2.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series2.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            Series2.Marks.Font.Shadow.Brush.Solid = true;
            Series2.Marks.Font.Shadow.Brush.Visible = true;
            Series2.Marks.Font.Size = 8;
            Series2.Marks.Font.SizeFloat = 8F;
            Series2.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Series2.Marks.ImageBevel.Brush.Color = Color.LightGray;
            Series2.Marks.ImageBevel.Brush.Solid = true;
            Series2.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series2.Marks.Shadow.Brush.Color = Color.Gray;
            Series2.Marks.Shadow.Brush.Solid = true;
            Series2.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series2.Marks.Symbol.Brush.Color = Color.Red;
            Series2.Marks.Symbol.Brush.Solid = true;
            Series2.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series2.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            Series2.Marks.Symbol.ImageBevel.Brush.Solid = true;
            Series2.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series2.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            Series2.Marks.Symbol.Shadow.Brush.Solid = true;
            Series2.Marks.Symbol.Shadow.Brush.Visible = true;
            Series2.Marks.TailStyle = Steema.TeeChart.Styles.MarksTail.None;
            Series2.Marks.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series2.Pointer.Brush.Color = Color.Red;
            Series2.Pointer.Brush.Solid = true;
            Series2.Pointer.Brush.Visible = true;
            Series2.Pointer.HorizSize = 3;
            // 
            // 
            // 
            Series2.Pointer.Pen.Color = Color.FromArgb(254, 0, 0, 0);
            Series2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            Series2.Pointer.VertSize = 3;
            Series2.Title = "point1";
            // 
            // 
            // 
            Series2.XValues.DataMember = "X";
            Series2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            Series2.XValues.Value = new double[]
    {
    0D,
    1D,
    2D,
    3D,
    4D,
    5D,
    6D,
    7D,
    8D,
    9D,
    10D,
    11D,
    12D,
    13D,
    14D,
    15D,
    16D,
    17D,
    18D,
    19D,
    20D,
    21D,
    22D,
    23D,
    24D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D
    };
            // 
            // 
            // 
            Series2.YValues.DataMember = "Y";
            Series2.YValues.Value = new double[]
    {
    510D,
    459D,
    516D,
    598D,
    544D,
    496D,
    520D,
    447D,
    464D,
    464D,
    535D,
    515D,
    514D,
    556D,
    522D,
    592D,
    542D,
    620D,
    628D,
    578D,
    540D,
    473D,
    465D,
    426D,
    459D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D
    };
            // 
            // ChartEditor
            // 
            ChartEditor.AlwaysShowFuncSrc = false;
            ChartEditor.Chart = SpectrumChart;
            ChartEditor.HighLightTabs = false;
            ChartEditor.Location = new Point(0, 0);
            ChartEditor.Name = "ChartEditor";
            ChartEditor.Options = null;
            ChartEditor.TabIndex = 0;
            // 
            // PeakMarkingFormattingForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(1208, 855);
            Controls.Add(SpectrumChart);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Name = "PeakMarkingFormattingForm";
            Text = "PeakMarkingFormatting";
            Load += PeakMarkingFormattingForm_Load;
            panel1.ResumeLayout(false);
            ((ISupportInitialize)SpectrumChart).EndInit();
            ResumeLayout(false);

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

        private void SpectrumAnalyzer1_OnParameterUpdate(object Sender)
        {
            SpectrumAnalyzer1.Update();
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
	}
}
