using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Dew.Signal;
using Dew.Signal.Editors;
using Dew.Signal.Units;
using Dew.Math.Units;
using Dew.Signal.Tee;
using Dew.Math;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for OrderTrackingForm. 
	/// </summary>
	public class OrderTrackingForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private Steema.TeeChart.Styles.FastLine Series1;
		private Steema.TeeChart.Styles.Points Series2;
		private Dew.Signal.TSignalRead SignalRead1;
		private Dew.Signal.TSpectrumAnalyzer SpectrumAnalyzer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private SpectrumChart SpectrumChart1;
        private Button ChartButton;
        private Button SpectrumButton;
        private SpectrumAnalyzerDialog SpectrumAnalyzerDialog;
        private Steema.TeeChart.Editor ChartEditor;
		private System.ComponentModel.IContainer components;

		public OrderTrackingForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			SpectrumChart1.Spectrums.Add();
			SpectrumChart1.Spectrums[0].Series = Series1;
			SpectrumChart1.Spectrums[0].Input = SpectrumAnalyzer1;

			SpectrumMarkTool markTool = new SpectrumMarkTool(SpectrumChart1.Chart);
			markTool.MarkSeries = Series2;
			markTool.Series = Series1;
			markTool.CursorActive = true;
			markTool.MarkMode = SpectrumMarkMode.mmSingle;
			markTool.AmpltFormat = "0.0000";
			markTool.PhaseFormat = "0.0000";
			markTool.FreqFormat = "0.0000";
			markTool.LabelHeaders = true;
			markTool.PeakZoomBand = false;
			markTool.DoubleClickClear = true;
			markTool.PeakFilterMode = false;
			SpectrumChart1.Tools.Add(markTool);

            Series1.Color = Color.Navy;

            SignalRead1.FileName = Dew.Demo.Utils.SourcePath() + @"\Data\bz.sfs";
			SignalRead1.OpenFile();
			comboBox1.SelectedIndex = 0;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderTrackingForm));
            Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChartButton = new System.Windows.Forms.Button();
            this.SpectrumButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SignalRead1 = new Dew.Signal.TSignalRead(this.components);
            this.SpectrumAnalyzer1 = new Dew.Signal.TSpectrumAnalyzer(this.components);
            this.SpectrumChart1 = new Dew.Signal.Tee.SpectrumChart();
            this.Series1 = new Steema.TeeChart.Styles.FastLine();
            this.Series2 = new Steema.TeeChart.Styles.Points();
            this.SpectrumAnalyzerDialog = new Dew.Signal.Editors.SpectrumAnalyzerDialog(this.components);
            this.ChartEditor = new Steema.TeeChart.Editor(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpectrumChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(696, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.ChartButton);
            this.panel1.Controls.Add(this.SpectrumButton);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 467);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 34);
            this.panel1.TabIndex = 1;
            // 
            // ChartButton
            // 
            this.ChartButton.Location = new System.Drawing.Point(112, 6);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(75, 23);
            this.ChartButton.TabIndex = 3;
            this.ChartButton.Text = "Chart...";
            this.ChartButton.UseVisualStyleBackColor = true;
            this.ChartButton.Click += new System.EventHandler(this.ChartButton_Click);
            // 
            // SpectrumButton
            // 
            this.SpectrumButton.Location = new System.Drawing.Point(12, 6);
            this.SpectrumButton.Name = "SpectrumButton";
            this.SpectrumButton.Size = new System.Drawing.Size(75, 23);
            this.SpectrumButton.TabIndex = 2;
            this.SpectrumButton.Text = "Spectrum...";
            this.SpectrumButton.UseVisualStyleBackColor = true;
            this.SpectrumButton.Click += new System.EventHandler(this.SpectrumButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Single peak",
            "Harmonic series",
            "Sidebands 1",
            "Sidebands 2",
            "Free style"});
            this.comboBox1.Location = new System.Drawing.Point(332, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(228, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mark mode:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SignalRead1
            // 
            this.SignalRead1.BandwidthL = 0D;
            this.SignalRead1.BlockAssign = false;
            this.SignalRead1.Complex = false;
            this.SignalRead1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.SignalRead1.FloatPrecisionLock = false;
            this.SignalRead1.FramesPerSecond = 0.0009765625D;
            this.SignalRead1.IsDouble = true;
            this.SignalRead1.LastFrameCheck = Dew.Signal.TLastFrameCheck.lfcZeroPadded;
            this.SignalRead1.Length = 1024;
            this.SignalRead1.Name = "";
            this.SignalRead1.PostBufferSamples = 0;
            this.SignalRead1.RecordPosition = ((long)(0));
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
            this.SpectrumAnalyzer1.Peaks.LargestRatio = 1E+15D;
            this.SpectrumAnalyzer1.Peaks.NormalizedAmplt.NormAmplitude = 1D;
            this.SpectrumAnalyzer1.Peaks.NormalizedFreq.Active = true;
            this.SpectrumAnalyzer1.Peaks.NormalizedFreq.DefaultFS = 0D;
            this.SpectrumAnalyzer1.Peaks.NormalizedFreq.DefaultHzRes = 0D;
            this.SpectrumAnalyzer1.Peaks.NormalizedFreq.NormFrequency = 1D;
            this.SpectrumAnalyzer1.Peaks.NormalizedFreq.Tracing = Dew.Signal.TNormTracing.otFirstPeak;
            this.SpectrumAnalyzer1.Report.UseTab = false;
            this.SpectrumAnalyzer1.SamplingFrequency = 0D;
            this.SpectrumAnalyzer1.SpectrumScale = 0D;
            this.SpectrumAnalyzer1.Stats.Averaged = 0;
            this.SpectrumAnalyzer1.Stats.Averages = 30;
            this.SpectrumAnalyzer1.Window = Dew.Signal.TSignalWindowType.wtHanning;
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Bottom.Labels.Font.Size = 9;
            this.SpectrumChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.Axes.Bottom.Labels.Separation = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Bottom.Title.Font.Size = 11;
            this.SpectrumChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Depth.Labels.Font.Size = 9;
            this.SpectrumChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Depth.Title.Font.Size = 11;
            this.SpectrumChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.DepthTop.Labels.Font.Size = 9;
            this.SpectrumChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.DepthTop.Title.Font.Size = 11;
            this.SpectrumChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
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
            this.SpectrumChart1.Axes.Left.Grid.DrawEvery = 1;
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Left.Labels.Font.Size = 9;
            this.SpectrumChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Left.Title.Font.Size = 11;
            this.SpectrumChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Right.Labels.Font.Size = 9;
            this.SpectrumChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Right.Title.Font.Size = 11;
            this.SpectrumChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Top.Labels.Font.Size = 9;
            this.SpectrumChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Top.Title.Font.Size = 11;
            this.SpectrumChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Color = System.Drawing.Color.Silver;
             
            this.SpectrumChart1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Footer.Font.Size = 8;
            this.SpectrumChart1.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Header.Font.Size = 12;
            this.SpectrumChart1.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart1.Header.Lines = new string[] {
        "Frequency spectrum"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Legend.Font.Size = 9;
            this.SpectrumChart1.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Legend.Title.Font.Size = 8;
            this.SpectrumChart1.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Legend.Visible = false;
            this.SpectrumChart1.Location = new System.Drawing.Point(0, 96);
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
            this.SpectrumChart1.Panel.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            this.SpectrumChart1.Printer.Margins = margins1;
            this.SpectrumChart1.Series.Add(this.Series1);
            this.SpectrumChart1.Series.Add(this.Series2);
            this.SpectrumChart1.Size = new System.Drawing.Size(696, 371);
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.SubFooter.Font.Size = 8;
            this.SpectrumChart1.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.SubHeader.Font.Size = 12;
            this.SpectrumChart1.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SpectrumChart1.TabIndex = 2;
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
            this.SpectrumChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.SpectrumChart1.Zoom.Animated = true;
            // 
            // 
            // 
            this.SpectrumChart1.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.SpectrumChart1.Zoom.Brush.Visible = false;
            this.SpectrumChart1.Zoom.History = true;
            this.SpectrumChart1.OnAfterMarkPeak += new Dew.Math.TNotifyEvent(this.SpectrumChart1_OnAfterMarkPeak);
            this.SpectrumChart1.Click += new System.EventHandler(this.SpectrumChart1_Click);
            // 
            // Series1
            // 
            this.Series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.Series1.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Series1.Legend.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Series1.Legend.Font.Size = 8;
            this.Series1.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.Series1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Series1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Series1.Marks.Font.Size = 8;
            this.Series1.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Series1.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.Series1.OriginalCursor = Steema.TeeChart.Drawing.Cursor.Current;
            this.Series1.Title = "fastLine1";
            this.Series1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.Series1.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.Series1.XValues.DataMember = "X";
            this.Series1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.Series1.YValues.DataMember = "Y";
            // 
            // Series2
            // 
            this.Series2.Color = System.Drawing.Color.Red;
            this.Series2.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Series2.Legend.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Series2.Legend.Font.Size = 8;
            this.Series2.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.Series2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Marks.Arrow.Visible = false;
            this.Series2.Marks.ArrowLength = 10;
            // 
            // 
            // 
            this.Series2.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Series2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Series2.Marks.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Series2.Marks.Font.Size = 8;
            this.Series2.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Series2.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.Series2.Marks.Transparent = true;
            this.Series2.Marks.Visible = true;
            this.Series2.OriginalCursor = Steema.TeeChart.Drawing.Cursor.Current;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Pointer.Brush.Color = System.Drawing.Color.Red;
            this.Series2.Pointer.HorizSize = 3;
            // 
            // 
            // 
            this.Series2.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Series2.Pointer.SizeDouble = 0D;
            this.Series2.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.Series2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.Series2.Pointer.VertSize = 3;
            this.Series2.Title = "point1";
            this.Series2.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.Series2.XValues.DataMember = "X";
            this.Series2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.Series2.YValues.DataMember = "Y";
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
            // ChartEditor
            // 
            this.ChartEditor.AlwaysShowFuncSrc = false;
            this.ChartEditor.Chart = this.SpectrumChart1;
            this.ChartEditor.HighLightTabs = false;
            this.ChartEditor.Location = new System.Drawing.Point(0, 0);
            this.ChartEditor.Name = "ChartEditor";
            this.ChartEditor.Options = null;
            this.ChartEditor.TabIndex = 0;
            // 
            // OrderTrackingForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(696, 501);
            this.Controls.Add(this.SpectrumChart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "OrderTrackingForm";
            this.Text = "OrderTrackingForm";
            this.Load += new System.EventHandler(this.OrderTrackingForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpectrumChart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private SpectrumMarkTool GetMarkTool() {
			foreach(object o in SpectrumChart1.Tools) {
				if (o is SpectrumMarkTool) return o as SpectrumMarkTool;
			}
			return null;
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e) {
			GetMarkTool().MarkMode = (SpectrumMarkMode) comboBox1.SelectedIndex;
		}

		private void SpectrumChart1_OnAfterMarkPeak(object Sender) {
			SpectrumAnalyzer1.Peaks.Update();
			SpectrumAnalyzer1.UpdateNotify();     
		}

        private void SpectrumChart1_Click(object sender, EventArgs e)
        {

        }

        private void SpectrumButton_Click(object sender, EventArgs e)
        {
            SpectrumAnalyzerDialog.ExecuteModal();
        }

        private void ChartButton_Click(object sender, EventArgs e)
        {
            ChartEditor.ShowModal();
        }

        protected void Add(String s)
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void OrderTrackingForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("Order tracking is a method known from vibration analysis of "
                + "shafts, which makes the sampling frequency of the A/D to "
                + "be an integer multiple of the frequency of the rotating "
                + "shaft. In the example below you can examine the ratios "
                + "between different frequency peaks. The first peak clicked "
                + "will become the order frequency.");            
        }
	}
}
