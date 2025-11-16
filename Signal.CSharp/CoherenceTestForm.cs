using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Dew.Signal;
using Dew.Signal.Units;
using Dew.Math;
using Dew.Math.Units;
using Dew.Signal.Tee;
using Dew.Signal.Editors;
using Dew.Demo;
using Dew.Math.Editors;


namespace DSPDemo {
	/// <summary>
	/// Summary description for CoherenceTestForm.
	/// </summary>
	public class CoherenceTestForm : System.Windows.Forms.Form {
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button ChartEditButton;
		private System.Windows.Forms.Button EditSpectrumButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBoxPhase;
		private Dew.Signal.TSignal FilteredSignal;
		private Dew.Signal.TSignalRead SignalRead1;
		private Dew.Signal.TCrossSpectrumAnalyzer CrossAnalyzer;
		private Steema.TeeChart.Styles.FastLine Series1;
		private Steema.TeeChart.Styles.Points Series2;
		private System.Windows.Forms.ComboBox spectrumBox;
		private SpectrumChart SpectrumChart;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Panel panel1;
        private Steema.TeeChart.Editor ChartEditor;
        private CrossSpectrumAnalyzerDialog CrossSpectrumAnalyzerDialog;
        private CheckBox MarkCursorBox;
		private System.ComponentModel.IContainer components;
        private SpectrumMarkTool smt;
        private TFirState firState;

		public CoherenceTestForm() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			SpectrumChart.Spectrums.Add();
			SpectrumChart.Spectrums[0].Input = CrossAnalyzer;
			SpectrumChart.Spectrums[0].Series = SpectrumChart.Series[0];


			smt = new SpectrumMarkTool(SpectrumChart.Chart); //also added to the Tools property
			smt.CursorActive = true;
			smt.DoubleClickClear = true;
			smt.PeakFilterMode = false;
			smt.MarkMode = SpectrumMarkMode.mmSingle;
			smt.MarkType = SpectrumMarkType.mtAmplt;
			smt.MarkSeries = SpectrumChart.Series[1];
			smt.Series =  SpectrumChart.Series[0];
			smt.AmpltFormat = "0.00#";
			smt.PhaseFormat = "0.00#";
			smt.FreqFormat = "0.00#";
			smt.LabelHeaders = true;
			smt.PeakZoomBand = false;		

//			CrossAnalyzer.Input = SignalRead1;
//			CrossAnalyzer.Output = FilteredSignal;

			Vector h = new Vector(0);			
			SignalUtils.KaiserImpulse(h,new double[]{0.2,0.25},0.001,TFilterType.ftLowpass,1,2,false);
			SignalUtils.FirInit(h,ref firState,1,0,1,0);

            SignalRead1.FileName = Utils.SourcePath() + @"\Data\bz.dat";
			buttonUpdate_Click(null,EventArgs.Empty);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if(components != null) {
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(CoherenceTestForm));
            Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            richTextBox1 = new RichTextBox();
            ChartEditButton = new Button();
            EditSpectrumButton = new Button();
            buttonUpdate = new Button();
            label1 = new Label();
            spectrumBox = new ComboBox();
            checkBoxPhase = new CheckBox();
            FilteredSignal = new TSignal(components);
            SignalRead1 = new TSignalRead(components);
            CrossAnalyzer = new TCrossSpectrumAnalyzer(components);
            panel1 = new Panel();
            MarkCursorBox = new CheckBox();
            CrossSpectrumAnalyzerDialog = new CrossSpectrumAnalyzerDialog(components);
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
            richTextBox1.Size = new Size(1142, 118);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "richTextBox1";
            // 
            // ChartEditButton
            // 
            ChartEditButton.Location = new Point(19, 10);
            ChartEditButton.Name = "ChartEditButton";
            ChartEditButton.Size = new Size(90, 28);
            ChartEditButton.TabIndex = 2;
            ChartEditButton.Text = "Chart";
            ChartEditButton.Click += ChartEditButton_Click;
            // 
            // EditSpectrumButton
            // 
            EditSpectrumButton.Location = new Point(115, 10);
            EditSpectrumButton.Name = "EditSpectrumButton";
            EditSpectrumButton.Size = new Size(90, 28);
            EditSpectrumButton.TabIndex = 3;
            EditSpectrumButton.Text = "Spectrum";
            EditSpectrumButton.Click += SpectrumEditButton_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(211, 10);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(90, 28);
            buttonUpdate.TabIndex = 4;
            buttonUpdate.Text = "Update";
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label1
            // 
            label1.Location = new Point(326, 10);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 5;
            label1.Text = "Spectrum:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // spectrumBox
            // 
            spectrumBox.DropDownStyle = ComboBoxStyle.DropDownList;
            spectrumBox.Items.AddRange(new object[] { "Input spectrum", "Output spectrum", "Cross spectrum", "Coherence", "TransferFunction" });
            spectrumBox.Location = new Point(451, 10);
            spectrumBox.Name = "spectrumBox";
            spectrumBox.Size = new Size(145, 23);
            spectrumBox.TabIndex = 6;
            spectrumBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // checkBoxPhase
            // 
            checkBoxPhase.Location = new Point(605, 10);
            checkBoxPhase.Name = "checkBoxPhase";
            checkBoxPhase.Size = new Size(125, 29);
            checkBoxPhase.TabIndex = 7;
            checkBoxPhase.Text = "Phase";
            checkBoxPhase.CheckedChanged += checkBoxPhase_CheckedChanged;
            // 
            // FilteredSignal
            // 
            FilteredSignal.ChannelCount = 1;
            FilteredSignal.Complex = false;
            FilteredSignal.DataSerialization = "AAAAAAAAQEEAAAAAAACAPwAAAAAAgB9EAAAAQQAAAAAAE3pHAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            FilteredSignal.FloatPrecision = TMtxFloatPrecision.mvDouble;
            FilteredSignal.FloatPrecisionLock = false;
            FilteredSignal.IsDouble = true;
            FilteredSignal.Length = 12;
            FilteredSignal.OnAfterUpdateEvent += FilteredSignal_OnAfterUpdate;
            // 
            // SignalRead1
            // 
            SignalRead1.ChannelCount = 1;
            SignalRead1.Complex = false;
            SignalRead1.DataSerialization = resources.GetString("SignalRead1.DataSerialization");
            SignalRead1.FloatPrecision = TMtxFloatPrecision.mvDouble;
            SignalRead1.FloatPrecisionLock = false;
            SignalRead1.FramesPerSecond = 0.00048828125D;
            SignalRead1.IsDouble = true;
            SignalRead1.Length = 2048;
            SignalRead1.OverlappingSamples = 1843;
            SignalRead1.PostBufferSamples = 0;
            SignalRead1.RecordNumber = 0;
            SignalRead1.RecordPosition = 0L;
            SignalRead1.SamplingFrequency = 4666.66666666667D;
            // 
            // CrossAnalyzer
            // 
            CrossAnalyzer.ArOrder = 100;
            CrossAnalyzer.Bands.TemplateIndex = -1;
            CrossAnalyzer.Bands.TemplatesSerialization = "AAAAAA==";
            CrossAnalyzer.Complex = false;
            CrossAnalyzer.FloatPrecision = TMtxFloatPrecision.mvDouble;
            CrossAnalyzer.FloatPrecisionLock = false;
            CrossAnalyzer.Harmonics = 10;
            CrossAnalyzer.Input = SignalRead1;
            CrossAnalyzer.IsDouble = true;
            CrossAnalyzer.Length = 64;
            CrossAnalyzer.LogBase = 0D;
            CrossAnalyzer.LogScale = 0D;
            CrossAnalyzer.MainlobeWidth = 8;
            CrossAnalyzer.Output = FilteredSignal;
            CrossAnalyzer.Peaks.HarmonicsCount = 10;
            CrossAnalyzer.Peaks.Interpolation.Method = TInterpolationMethod.imNone;
            CrossAnalyzer.Peaks.Interpolation.RecursiveHarmonics = TRecursiveHarmonics.rhNone;
            CrossAnalyzer.Peaks.LargestCount = 1;
            CrossAnalyzer.Peaks.LargestRatio = 1E+15D;
            CrossAnalyzer.Peaks.NormalizedAmplt.PeakNumber = 1;
            CrossAnalyzer.Peaks.NormalizedFreq.PeakNumber = 1;
            CrossAnalyzer.Report.UseTab = false;
            CrossAnalyzer.Rotation = 0;
            CrossAnalyzer.RunningPhase = TRunningPhase.rpDefault;
            CrossAnalyzer.Stats.Averaged = 0;
            CrossAnalyzer.Stats.Averages = 30;
            CrossAnalyzer.Stats.Averaging = TAveraging.avLinearInf;
            CrossAnalyzer.Stats.ExpDecay = 5;
            CrossAnalyzer.UnwrapPhase = true;
            CrossAnalyzer.Window = TSignalWindowType.wtHanning;
            CrossAnalyzer.ZeroPadding = 8;
            CrossAnalyzer.OnParameterUpdateEvent += CrossAnalyzer_OnParameterUpdate;
            // 
            // panel1
            // 
            panel1.Controls.Add(MarkCursorBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(spectrumBox);
            panel1.Controls.Add(ChartEditButton);
            panel1.Controls.Add(checkBoxPhase);
            panel1.Controls.Add(EditSpectrumButton);
            panel1.Controls.Add(buttonUpdate);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 778);
            panel1.Name = "panel1";
            panel1.Size = new Size(1142, 47);
            panel1.TabIndex = 8;
            // 
            // MarkCursorBox
            // 
            MarkCursorBox.Checked = true;
            MarkCursorBox.CheckState = CheckState.Checked;
            MarkCursorBox.Location = new Point(701, 10);
            MarkCursorBox.Name = "MarkCursorBox";
            MarkCursorBox.Size = new Size(125, 29);
            MarkCursorBox.TabIndex = 8;
            MarkCursorBox.Text = "Mark cursor";
            MarkCursorBox.CheckedChanged += MarkCursorBox_CheckedChanged;
            // 
            // CrossSpectrumAnalyzerDialog
            // 
            CrossSpectrumAnalyzerDialog.Docking = false;
            CrossSpectrumAnalyzerDialog.FormCaption = null;
            CrossSpectrumAnalyzerDialog.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            CrossSpectrumAnalyzerDialog.ShowLive = false;
            CrossSpectrumAnalyzerDialog.Source = CrossAnalyzer;
            CrossSpectrumAnalyzerDialog.SourceListIndex = 0;
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
            SpectrumChart.Axes.Bottom.MaximumOffset = 4;
            SpectrumChart.Axes.Bottom.MinimumOffset = 4;
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
            SpectrumChart.Axes.Left.MaximumOffset = 4;
            SpectrumChart.Axes.Left.MinimumOffset = 4;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Title.Brush.Color = Color.Silver;
            SpectrumChart.Axes.Left.Title.Brush.Solid = true;
            SpectrumChart.Axes.Left.Title.Brush.Visible = true;
            SpectrumChart.Axes.Left.Title.Caption = "Amplitude [dB]";
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
            SpectrumChart.Axes.Left.Title.Lines = new string[]
    {
    "Amplitude [dB]"
    };
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
            SpectrumChart.Axes.Top.Visible = false;
            SpectrumChart.BackColor = Color.Transparent;
            SpectrumChart.Color = Color.FromArgb(192, 192, 192);
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
    "Transfer function"
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
            SpectrumChart.Panel.Brush.Color = Color.FromArgb(192, 192, 192);
            // 
            // 
            // 
            SpectrumChart.Panel.Brush.Gradient.Sigma = true;
            SpectrumChart.Panel.Brush.Gradient.SigmaFocus = 0.518F;
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
            SpectrumChart.Size = new Size(1142, 660);
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
            SpectrumChart.TabIndex = 1;
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
            Series1.Color = Color.FromArgb(68, 102, 163);
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
    20D,
    82D,
    63D,
    119D,
    44D,
    10D,
    31D,
    58D,
    5D,
    108D,
    10D,
    80D,
    168D,
    178D,
    95D,
    132D,
    127D,
    57D,
    5D,
    104D,
    85D,
    115D,
    89D,
    17D,
    2D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // 
            // 
            // 
            Series2.Marks.Arrow.Visible = false;
            Series2.Marks.ArrowLength = 12;
            // 
            // 
            // 
            Series2.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            Series2.Marks.Brush.Solid = true;
            Series2.Marks.Brush.Visible = false;
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
            Series2.Marks.Symbol.Brush.Color = Color.White;
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
            Series2.Marks.Transparent = true;
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
    59D,
    66D,
    60D,
    78D,
    69D,
    74D,
    83D,
    63D,
    66D,
    54D,
    38D,
    51D,
    29D,
    24D,
    20D,
    37D,
    28D,
    29D,
    17D,
    27D,
    14D,
    17D,
    13D,
    13D,
    17D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // CoherenceTestForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(1142, 825);
            Controls.Add(SpectrumChart);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Name = "CoherenceTestForm";
            Text = "CoherenceTestForm";
            Load += CoherenceTestForm_Load;
            panel1.ResumeLayout(false);
            ((ISupportInitialize)SpectrumChart).EndInit();
            ResumeLayout(false);

        }
        #endregion

        private void CrossAnalyzer_OnParameterUpdate(object Sender) {

			CrossAnalyzer.Update();
		}

		private void FilteredSignal_OnAfterUpdate(object Sender) {

			SignalUtils.FirFilter(SignalRead1.Data, FilteredSignal.Data,ref firState);
			FilteredSignal.SamplingFrequency = SignalRead1.SamplingFrequency;
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e) {

			CrossAnalyzer.CrossAnalyzer.Transform = (TCrossTransform) spectrumBox.SelectedIndex;
			SpectrumChart.Header.Text =  SignalAnalysis.CrossTransformToString(CrossAnalyzer.CrossAnalyzer.Transform);
			CrossAnalyzer.UpdateSpectrum();
		}

		private void buttonUpdate_Click(object sender, System.EventArgs e) {

            SignalRead1.OverlappingPercent = 0;

            SignalRead1.OpenFile();
            SignalRead1.RecordPosition = 0; 	//SignalRead1.OverlappingPercent = 50;  we can not use this, because of the filter
			SignalRead1.LastFrameCheck = TLastFrameCheck.lfcLastFullBlock;		

			CrossAnalyzer.ResetAveraging();
			CrossAnalyzer.Logarithmic = true;
			CrossAnalyzer.Window = TSignalWindowType.wtHanning;
			CrossAnalyzer.LogType = TLogType.ltRelative;

			CrossAnalyzer.CrossAnalyzer.Recursive = false;
            CrossAnalyzer.PullUntilEnd();

			CrossAnalyzer.CrossAnalyzer.Update();  //if recursive would be True, this would not be neccessary.
			CrossAnalyzer.Update();

            if (spectrumBox.SelectedIndex < 0)
            {
                spectrumBox.SelectedIndex = 4;
            }
            else
            {
                comboBox1_SelectedIndexChanged(sender, EventArgs.Empty);
            }
		}
	

		private void checkBoxPhase_CheckedChanged(object sender, System.EventArgs e) {

            SpectrumChart.SpectrumPart = (checkBoxPhase.Checked? SpectrumPart.sppPhase: SpectrumPart.sppAmplt);

			switch (SpectrumChart.SpectrumPart) 
            {
  			 case  SpectrumPart.sppAmplt: SpectrumChart.Axes.Left.Title.Text = "Amplitude";
                                          break;
			 case  SpectrumPart.sppPhase: SpectrumChart.Axes.Left.Title.Text = "Phase [degress]";
                                          break;
			}
		}

        private void ChartEditButton_Click(object sender, EventArgs e)
        {
            ChartEditor.ShowModal();
        }

        private void SpectrumEditButton_Click(object sender, EventArgs e)
        {
            CrossSpectrumAnalyzerDialog.ExecuteModal();
        }

        protected void Add(String s)
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void CoherenceTestForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("The cross spectral analysis is usefull when trying to determine:");
            Add("");
            Add("1. What is the transfer function of the system.");
            Add("2. Is the system linear or not. If it is not linear, at which frequencies is the system non-linear.");
            Add("");
            Add("Change the value of the spectrum box to see the frequency spectrum "
                + "of the signal that wassend in to the system (input spectrum), "
                + "what came out (output spectrum), what is the frequency response "
                + "of the system (transfer function) and the test for linearity "
                + "(coherence). The system in this test case is a low pass FIR filter. "
                + "With sufficient averaging, coherence would converge to 1. A coherence "
                + "of 1 means that the system is linear at that frequency.");
        }

        private void SpectrumChart_Click(object sender, EventArgs e)
        {

        }

        private void MarkCursorBox_CheckedChanged(object sender, EventArgs e)
        {
            smt.CursorActive = MarkCursorBox.Checked;
        }
	}
}
