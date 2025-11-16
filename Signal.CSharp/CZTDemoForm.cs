using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Steema.TeeChart;
using Dew.Signal;
using Dew.Signal.Tee;
using Dew.Math.Controls;
using Dew.Math;
using Dew.Signal.Editors;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for CZTDemoForm.
	/// </summary>
	public class CZTDemoForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private SpectrumChart SpectrumChart1;
		private Steema.TeeChart.Styles.FastLine Series1;
		private Steema.TeeChart.Styles.Points Series2;
		private Dew.Signal.TSpectrumAnalyzer SpectrumAnalyzer;
		private Dew.Signal.TSignalRead SignalRead1;
		private FloatEdit CZTStartEdit;
		private FloatEdit CZTBWEdit;
		private FloatEdit CZTLinesEdit;
        private Label label2;
        private Label label1;
        private Label LinesLabel;
        private Editor ChartEditor;
        private SpectrumAnalyzerDialog SpectrumAnalyzerDialog;
        private Button button1;
        private Button button2;
        private CheckBox MarkCursorBox;
        private System.ComponentModel.IContainer components;
        private AxisScaleTool axisScaleTool1;
        private SpectrumMarkTool spectrumMarkTool1;

		public CZTDemoForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			SpectrumChart1.Spectrums.Add();
			SpectrumChart1.Spectrums[0].Input = SpectrumAnalyzer;

            //tChart Serialization bug requires this
            SpectrumChart1.Axes.Automatic = true;
            SpectrumChart1.Axes.Left.Automatic = false; 
			
			//smt = new SpectrumMarkTool(SpectrumChart1.Chart);
			//smt.CursorActive = true;
			//smt.DoubleClickClear = true;
			//smt.PeakFilterMode = false;
			//smt.MarkMode = SpectrumMarkMode.mmSingle;
			//smt.MarkType = SpectrumMarkType.mtAmplt;
			//smt.MarkSeries = SpectrumChart1.Series[1];
			//smt.Series =  SpectrumChart1.Series[0];
			//smt.AmpltFormat = "0.00#";
			//smt.PhaseFormat = "0.00#";
			//smt.FreqFormat = "0.00#";
			//smt.LabelHeaders = true;
			//smt.PeakZoomBand = false;
			//SpectrumChart1.Tools.Add(smt);

            SignalRead1.FileName = Dew.Demo.Utils.SourcePath() + @"\Data\bz.dat";
			SignalRead1.OpenFile();
			SpectrumAnalyzer.Method = TSpectrumMethod.smCZT;
			SpectrumAnalyzer.Pull();
			CZTStartEdit_TextChanged(this, EventArgs.Empty);
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(CZTDemoForm));
            Margins margins1 = new Margins();
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            richTextBox1 = new RichTextBox();
            panel1 = new System.Windows.Forms.Panel();
            MarkCursorBox = new CheckBox();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            LinesLabel = new Label();
            CZTBWEdit = new FloatEdit();
            CZTStartEdit = new FloatEdit();
            CZTLinesEdit = new FloatEdit();
            SpectrumAnalyzer = new TSpectrumAnalyzer(components);
            SignalRead1 = new TSignalRead(components);
            ChartEditor = new Editor(components);
            SpectrumChart1 = new SpectrumChart();
            Series1 = new Steema.TeeChart.Styles.FastLine();
            Series2 = new Steema.TeeChart.Styles.Points();
            axisScaleTool1 = new AxisScaleTool();
            spectrumMarkTool1 = new SpectrumMarkTool();
            SpectrumAnalyzerDialog = new SpectrumAnalyzerDialog(components);
            panel1.SuspendLayout();
            ((ISupportInitialize)SpectrumChart1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Top;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1136, 118);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            panel1.Controls.Add(MarkCursorBox);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LinesLabel);
            panel1.Controls.Add(CZTBWEdit);
            panel1.Controls.Add(CZTStartEdit);
            panel1.Controls.Add(CZTLinesEdit);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 776);
            panel1.Name = "panel1";
            panel1.Size = new Size(1136, 55);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // MarkCursorBox
            // 
            MarkCursorBox.Checked = true;
            MarkCursorBox.CheckState = CheckState.Checked;
            MarkCursorBox.Location = new Point(736, 12);
            MarkCursorBox.Name = "MarkCursorBox";
            MarkCursorBox.Size = new Size(124, 30);
            MarkCursorBox.TabIndex = 9;
            MarkCursorBox.Text = "Mark cursor";
            MarkCursorBox.CheckedChanged += MarkCursorBox_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new Point(126, 12);
            button2.Name = "button2";
            button2.Size = new Size(90, 29);
            button2.TabIndex = 6;
            button2.Text = "Chart...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(14, 12);
            button1.Name = "button1";
            button1.Size = new Size(90, 29);
            button1.TabIndex = 5;
            button1.Text = "Spectrum...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 18);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Start freq.";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(460, 18);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 3;
            label1.Text = "BW:";
            label1.Click += label1_Click;
            // 
            // LinesLabel
            // 
            LinesLabel.AutoSize = true;
            LinesLabel.Location = new Point(604, 18);
            LinesLabel.Name = "LinesLabel";
            LinesLabel.Size = new Size(34, 15);
            LinesLabel.TabIndex = 2;
            LinesLabel.Text = "Lines";
            LinesLabel.Click += LinesLabel_Click;
            // 
            // CZTBWEdit
            // 
            CZTBWEdit.Increment = "0.100000001490116";
            CZTBWEdit.Location = new Point(500, 16);
            CZTBWEdit.Name = "CZTBWEdit";
            CZTBWEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            CZTBWEdit.Size = new Size(78, 23);
            CZTBWEdit.TabIndex = 1;
            CZTBWEdit.Value = "1000";
            CZTBWEdit.TextChanged += CZTBWEdit_TextChanged;
            CZTBWEdit.Click += CZTBWEdit_Click;
            // 
            // CZTStartEdit
            // 
            CZTStartEdit.Increment = "0.100000001490116";
            CZTStartEdit.Location = new Point(352, 16);
            CZTStartEdit.Name = "CZTStartEdit";
            CZTStartEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            CZTStartEdit.Size = new Size(96, 23);
            CZTStartEdit.TabIndex = 0;
            CZTStartEdit.TextChanged += CZTStartEdit_TextChanged;
            CZTStartEdit.Click += CZTStartEdit_Click;
            // 
            // CZTLinesEdit
            // 
            CZTLinesEdit.Increment = "0.100000001490116";
            CZTLinesEdit.Location = new Point(649, 16);
            CZTLinesEdit.Name = "CZTLinesEdit";
            CZTLinesEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            CZTLinesEdit.Size = new Size(58, 23);
            CZTLinesEdit.TabIndex = 1;
            CZTLinesEdit.Value = "500";
            CZTLinesEdit.TextChanged += CZTLinesEdit_TextChanged;
            CZTLinesEdit.Click += CZTLinesEdit_Click;
            // 
            // SpectrumAnalyzer
            // 
            SpectrumAnalyzer.ArOrder = 100;
            SpectrumAnalyzer.Bands.TemplateIndex = -1;
            SpectrumAnalyzer.Bands.TemplatesSerialization = "AAAAAA==";
            SpectrumAnalyzer.Complex = false;
            SpectrumAnalyzer.FloatPrecision = TMtxFloatPrecision.mvDouble;
            SpectrumAnalyzer.FloatPrecisionLock = false;
            SpectrumAnalyzer.Harmonics = 10;
            SpectrumAnalyzer.Input = SignalRead1;
            SpectrumAnalyzer.IsDouble = true;
            SpectrumAnalyzer.Length = 64;
            SpectrumAnalyzer.LogBase = 0D;
            SpectrumAnalyzer.LogScale = 0D;
            SpectrumAnalyzer.MainlobeWidth = 8;
            SpectrumAnalyzer.Peaks.HarmonicsCount = 10;
            SpectrumAnalyzer.Peaks.Interpolation.Method = TInterpolationMethod.imNone;
            SpectrumAnalyzer.Peaks.Interpolation.RecursiveHarmonics = TRecursiveHarmonics.rhNone;
            SpectrumAnalyzer.Peaks.LargestCount = 1;
            SpectrumAnalyzer.Peaks.LargestRatio = 1E+15D;
            SpectrumAnalyzer.Peaks.NormalizedAmplt.PeakNumber = 1;
            SpectrumAnalyzer.Peaks.NormalizedFreq.PeakNumber = 1;
            SpectrumAnalyzer.Report.UseTab = false;
            SpectrumAnalyzer.Rotation = 0;
            SpectrumAnalyzer.Stats.Averaged = 0;
            SpectrumAnalyzer.Stats.Averages = 30;
            SpectrumAnalyzer.Stats.ExpDecay = 5;
            SpectrumAnalyzer.Window = TSignalWindowType.wtHanning;
            SpectrumAnalyzer.ZeroPadding = 1;
            SpectrumAnalyzer.OnParameterUpdateEvent += SpectrumAnalyzer_OnParameterUpdate;
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
            // ChartEditor
            // 
            ChartEditor.AlwaysShowFuncSrc = false;
            ChartEditor.Chart = SpectrumChart1;
            ChartEditor.HighLightTabs = false;
            ChartEditor.Location = new Point(0, 0);
            ChartEditor.Name = "ChartEditor";
            ChartEditor.Options = null;
            ChartEditor.TabIndex = 0;
            // 
            // SpectrumChart1
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Automatic = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Automatic = false;
            SpectrumChart1.Axes.Bottom.AutomaticMaximum = false;
            SpectrumChart1.Axes.Bottom.AutomaticMinimum = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Grid.DrawEvery = 1;
            SpectrumChart1.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Labels.Brush.Color = Color.White;
            SpectrumChart1.Axes.Bottom.Labels.Brush.Solid = true;
            SpectrumChart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            SpectrumChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Bottom.Labels.Font.Size = 9;
            SpectrumChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            SpectrumChart1.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            SpectrumChart1.Axes.Bottom.Labels.Separation = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Bottom.Maximum = 0D;
            SpectrumChart1.Axes.Bottom.MaximumOffset = 5;
            SpectrumChart1.Axes.Bottom.Minimum = 0D;
            SpectrumChart1.Axes.Bottom.MinimumOffset = 5;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Title.Brush.Color = Color.Silver;
            SpectrumChart1.Axes.Bottom.Title.Brush.Solid = true;
            SpectrumChart1.Axes.Bottom.Title.Brush.Visible = true;
            SpectrumChart1.Axes.Bottom.Title.Caption = "Frequency [Hz]";
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            SpectrumChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Bottom.Title.Font.Size = 11;
            SpectrumChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            SpectrumChart1.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            SpectrumChart1.Axes.Bottom.Title.Lines = new string[]
    {
    "Frequency [Hz]"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Automatic = false;
            SpectrumChart1.Axes.Depth.AutomaticMaximum = false;
            SpectrumChart1.Axes.Depth.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Labels.Brush.Color = Color.White;
            SpectrumChart1.Axes.Depth.Labels.Brush.Solid = true;
            SpectrumChart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            SpectrumChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Depth.Labels.Font.Size = 9;
            SpectrumChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            SpectrumChart1.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Depth.Maximum = 0D;
            SpectrumChart1.Axes.Depth.Minimum = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Title.Brush.Color = Color.Silver;
            SpectrumChart1.Axes.Depth.Title.Brush.Solid = true;
            SpectrumChart1.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart1.Axes.Depth.Title.Font.Brush.Solid = true;
            SpectrumChart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Depth.Title.Font.Size = 11;
            SpectrumChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            SpectrumChart1.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Automatic = false;
            SpectrumChart1.Axes.DepthTop.AutomaticMaximum = false;
            SpectrumChart1.Axes.DepthTop.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Labels.Brush.Color = Color.White;
            SpectrumChart1.Axes.DepthTop.Labels.Brush.Solid = true;
            SpectrumChart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            SpectrumChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.DepthTop.Labels.Font.Size = 9;
            SpectrumChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            SpectrumChart1.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.DepthTop.Maximum = 0D;
            SpectrumChart1.Axes.DepthTop.Minimum = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Title.Brush.Color = Color.Silver;
            SpectrumChart1.Axes.DepthTop.Title.Brush.Solid = true;
            SpectrumChart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            SpectrumChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.DepthTop.Title.Font.Size = 11;
            SpectrumChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            SpectrumChart1.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Automatic = false;
            SpectrumChart1.Axes.Left.AutomaticMaximum = false;
            SpectrumChart1.Axes.Left.AutomaticMinimum = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Labels.Brush.Color = Color.White;
            SpectrumChart1.Axes.Left.Labels.Brush.Solid = true;
            SpectrumChart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart1.Axes.Left.Labels.Font.Brush.Solid = true;
            SpectrumChart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Left.Labels.Font.Size = 9;
            SpectrumChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            SpectrumChart1.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Left.Maximum = 301.4D;
            SpectrumChart1.Axes.Left.MaximumOffset = 5;
            SpectrumChart1.Axes.Left.Minimum = -2.47D;
            SpectrumChart1.Axes.Left.MinimumOffset = 5;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Title.Brush.Color = Color.Silver;
            SpectrumChart1.Axes.Left.Title.Brush.Solid = true;
            SpectrumChart1.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart1.Axes.Left.Title.Font.Brush.Solid = true;
            SpectrumChart1.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Left.Title.Font.Size = 11;
            SpectrumChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            SpectrumChart1.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Automatic = false;
            SpectrumChart1.Axes.Right.AutomaticMaximum = false;
            SpectrumChart1.Axes.Right.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Labels.Brush.Color = Color.White;
            SpectrumChart1.Axes.Right.Labels.Brush.Solid = true;
            SpectrumChart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart1.Axes.Right.Labels.Font.Brush.Solid = true;
            SpectrumChart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Right.Labels.Font.Size = 9;
            SpectrumChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            SpectrumChart1.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Right.Maximum = 0D;
            SpectrumChart1.Axes.Right.Minimum = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Title.Brush.Color = Color.Silver;
            SpectrumChart1.Axes.Right.Title.Brush.Solid = true;
            SpectrumChart1.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart1.Axes.Right.Title.Font.Brush.Solid = true;
            SpectrumChart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Right.Title.Font.Size = 11;
            SpectrumChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            SpectrumChart1.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Automatic = false;
            SpectrumChart1.Axes.Top.AutomaticMaximum = false;
            SpectrumChart1.Axes.Top.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Labels.Brush.Color = Color.White;
            SpectrumChart1.Axes.Top.Labels.Brush.Solid = true;
            SpectrumChart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart1.Axes.Top.Labels.Font.Brush.Solid = true;
            SpectrumChart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Top.Labels.Font.Size = 9;
            SpectrumChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            SpectrumChart1.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Top.Maximum = 0D;
            SpectrumChart1.Axes.Top.Minimum = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Title.Brush.Color = Color.Silver;
            SpectrumChart1.Axes.Top.Title.Brush.Solid = true;
            SpectrumChart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart1.Axes.Top.Title.Font.Brush.Solid = true;
            SpectrumChart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Top.Title.Font.Size = 11;
            SpectrumChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            SpectrumChart1.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            SpectrumChart1.BackColor = Color.White;
            SpectrumChart1.Color = Color.FromArgb(219, 218, 233);
            SpectrumChart1.Dock = DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Footer.Brush.Color = Color.Silver;
            SpectrumChart1.Footer.Brush.Solid = true;
            SpectrumChart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Footer.Font.Brush.Color = Color.Red;
            SpectrumChart1.Footer.Font.Brush.Solid = true;
            SpectrumChart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Footer.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Footer.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Footer.Font.Size = 8;
            SpectrumChart1.Footer.Font.SizeFloat = 8F;
            SpectrumChart1.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Footer.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Footer.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Footer.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Footer.Shadow.Brush.Solid = true;
            SpectrumChart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Header.Brush.Color = Color.FromArgb(192, 192, 192);
            SpectrumChart1.Header.Brush.Solid = true;
            SpectrumChart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Header.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Header.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart1.Header.Font.Brush.Solid = true;
            SpectrumChart1.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Header.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Header.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Header.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Header.Font.Size = 12;
            SpectrumChart1.Header.Font.SizeFloat = 12F;
            SpectrumChart1.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Header.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Header.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Header.ImageBevel.Brush.Visible = true;
            SpectrumChart1.Header.Lines = new string[]
    {
    "Frequency spectrum"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Header.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            SpectrumChart1.Header.Shadow.Brush.Solid = true;
            SpectrumChart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Legend.Brush.Color = Color.White;
            SpectrumChart1.Legend.Brush.Solid = true;
            SpectrumChart1.Legend.Brush.Visible = true;
            SpectrumChart1.Legend.CheckBoxes = false;
            // 
            // 
            // 
            SpectrumChart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Legend.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart1.Legend.Font.Brush.Solid = true;
            SpectrumChart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Legend.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Legend.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Legend.Font.Size = 9;
            SpectrumChart1.Legend.Font.SizeFloat = 9F;
            SpectrumChart1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Legend.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Legend.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Legend.Shadow.Brush.Color = Color.FromArgb(0, 0, 0);
            SpectrumChart1.Legend.Shadow.Brush.Solid = true;
            SpectrumChart1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Legend.Symbol.Shadow.Brush.Solid = true;
            SpectrumChart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Legend.Title.Brush.Color = Color.White;
            SpectrumChart1.Legend.Title.Brush.Solid = true;
            SpectrumChart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            SpectrumChart1.Legend.Title.Font.Brush.Color = Color.Black;
            SpectrumChart1.Legend.Title.Font.Brush.Solid = true;
            SpectrumChart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Legend.Title.Font.Size = 8;
            SpectrumChart1.Legend.Title.Font.SizeFloat = 8F;
            SpectrumChart1.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Legend.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Legend.Title.Shadow.Brush.Solid = true;
            SpectrumChart1.Legend.Title.Shadow.Brush.Visible = true;
            SpectrumChart1.Legend.Visible = false;
            SpectrumChart1.Location = new Point(0, 118);
            SpectrumChart1.Name = "SpectrumChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            // 
            // 
            // 
            SpectrumChart1.Panel.Brush.Color = Color.FromArgb(219, 218, 233);
            SpectrumChart1.Panel.Brush.Solid = true;
            SpectrumChart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Panel.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Panel.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Panel.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Panel.Shadow.Brush.Solid = true;
            SpectrumChart1.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            SpectrumChart1.Printer.Margins = margins1;
            SpectrumChart1.Series.Add(Series1);
            SpectrumChart1.Series.Add(Series2);
            SpectrumChart1.Size = new Size(1136, 658);
            SpectrumChart1.SpectrumPart = SpectrumPart.sppAmplt;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.SubFooter.Brush.Color = Color.Silver;
            SpectrumChart1.SubFooter.Brush.Solid = true;
            SpectrumChart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.SubFooter.Font.Brush.Color = Color.Red;
            SpectrumChart1.SubFooter.Font.Brush.Solid = true;
            SpectrumChart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.SubFooter.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.SubFooter.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.SubFooter.Font.Size = 8;
            SpectrumChart1.SubFooter.Font.SizeFloat = 8F;
            SpectrumChart1.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.SubFooter.ImageBevel.Brush.Solid = true;
            SpectrumChart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.SubFooter.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.SubFooter.Shadow.Brush.Solid = true;
            SpectrumChart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.SubHeader.Brush.Color = Color.FromArgb(192, 192, 192);
            SpectrumChart1.SubHeader.Brush.Solid = true;
            SpectrumChart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.SubHeader.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart1.SubHeader.Font.Brush.Solid = true;
            SpectrumChart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.SubHeader.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.SubHeader.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.SubHeader.Font.Size = 12;
            SpectrumChart1.SubHeader.Font.SizeFloat = 12F;
            SpectrumChart1.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.SubHeader.ImageBevel.Brush.Solid = true;
            SpectrumChart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.SubHeader.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            SpectrumChart1.SubHeader.Shadow.Brush.Solid = true;
            SpectrumChart1.SubHeader.Shadow.Brush.Visible = true;
            SpectrumChart1.TabIndex = 2;
            SpectrumChart1.Tools.Add(axisScaleTool1);
            SpectrumChart1.Tools.Add(spectrumMarkTool1);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Walls.Back.Brush.Color = Color.Silver;
            SpectrumChart1.Walls.Back.Brush.Solid = true;
            SpectrumChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Walls.Back.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Walls.Back.Shadow.Brush.Solid = true;
            SpectrumChart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Walls.Bottom.Brush.Color = Color.White;
            SpectrumChart1.Walls.Bottom.Brush.Solid = true;
            SpectrumChart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Walls.Bottom.Shadow.Brush.Solid = true;
            SpectrumChart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Walls.Left.Brush.Color = Color.LightYellow;
            SpectrumChart1.Walls.Left.Brush.Solid = true;
            SpectrumChart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Walls.Left.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Walls.Left.Shadow.Brush.Solid = true;
            SpectrumChart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Walls.Right.Brush.Color = Color.LightYellow;
            SpectrumChart1.Walls.Right.Brush.Solid = true;
            SpectrumChart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Walls.Right.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Walls.Right.Shadow.Brush.Solid = true;
            SpectrumChart1.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Zoom.Animated = true;
            // 
            // 
            // 
            SpectrumChart1.Zoom.Brush.Color = Color.LightBlue;
            SpectrumChart1.Zoom.Brush.Solid = true;
            SpectrumChart1.Zoom.Brush.Visible = false;
            SpectrumChart1.Zoom.History = true;
            // 
            // 
            // 
            SpectrumChart1.Zoom.Pen.Visible = true;
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
    126D,
    54D,
    20D,
    105D,
    172D,
    252D,
    155D,
    55D,
    66D,
    98D,
    120D,
    228D,
    194D,
    73D,
    98D,
    159D,
    70D,
    104D,
    77D,
    33D,
    71D,
    77D,
    63D,
    5D,
    74D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            Series2.Marks.ArrowLength = 14;
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
            Series2.Marks.Symbol.Brush.Color = Color.Green;
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
            // 
            // 
            // 
            Series2.Pointer.Pen.Color = Color.FromArgb(153, 0, 0);
            Series2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
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
    137D,
    136D,
    123D,
    134D,
    151D,
    164D,
    136D,
    120D,
    126D,
    146D,
    157D,
    180D,
    163D,
    160D,
    134D,
    122D,
    93D,
    90D,
    115D,
    112D,
    90D,
    92D,
    117D,
    89D,
    77D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // axisScaleTool1
            // 
            axisScaleTool1.Axis = SpectrumChart1.Axes.Left;
            axisScaleTool1.AxisIndex = -1;
            axisScaleTool1.AxisScaleMode = AxisScaleMode.amAuto;
            axisScaleTool1.DataIsSpectrum = true;
            axisScaleTool1.LowerMargin = 1;
            axisScaleTool1.UpperMargin = 20;
            // 
            // spectrumMarkTool1
            // 
            spectrumMarkTool1.AmpltFormat = "0.00#";
            spectrumMarkTool1.ConfMarksOnly = false;
            spectrumMarkTool1.CursorActive = true;
            spectrumMarkTool1.DoubleClickClear = true;
            spectrumMarkTool1.FreqFormat = "0.00#";
            spectrumMarkTool1.LabelHeaders = true;
            spectrumMarkTool1.LowerLimitSeries = null;
            spectrumMarkTool1.MarkMode = SpectrumMarkMode.mmSingle;
            spectrumMarkTool1.MarkSeries = Series2;
            spectrumMarkTool1.MarkType = SpectrumMarkType.mtAmplt;
            spectrumMarkTool1.PeakFilterMode = false;
            spectrumMarkTool1.PeakZoomBand = false;
            spectrumMarkTool1.PhaseFormat = "0.00#";
            spectrumMarkTool1.Series = Series1;
            spectrumMarkTool1.SeriesIndex = -1;
            spectrumMarkTool1.UpperLimitSeries = null;
            // 
            // SpectrumAnalyzerDialog
            // 
            SpectrumAnalyzerDialog.Docking = false;
            SpectrumAnalyzerDialog.FormCaption = null;
            SpectrumAnalyzerDialog.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            SpectrumAnalyzerDialog.ShowLive = false;
            SpectrumAnalyzerDialog.Source = SpectrumAnalyzer;
            SpectrumAnalyzerDialog.SourceListIndex = 0;
            // 
            // CZTDemoForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(1136, 831);
            Controls.Add(SpectrumChart1);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Name = "CZTDemoForm";
            Text = "CZTDemoForm";
            Load += CZTDemoForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)SpectrumChart1).EndInit();
            ResumeLayout(false);

        }
        #endregion

        private void SpectrumAnalyzer_OnParameterUpdate(object Sender) {

            SpectrumAnalyzer.Update();
		}

		private void CZTStartEdit_TextChanged(object sender, System.EventArgs e) {
	    SpectrumAnalyzer.CZT.StartFrequency = CZTStartEdit.Position;
			CZTBWEdit_TextChanged(sender, e);
		}

		private void CZTBWEdit_TextChanged(object sender, System.EventArgs e) {
			SpectrumAnalyzer.CZT.StopFrequency = CZTStartEdit.Position + CZTBWEdit.Position;
			CZTLinesEdit_TextChanged(sender, e);
		}

		private void CZTLinesEdit_TextChanged(object sender, System.EventArgs e) {
			SpectrumAnalyzer.CZT.FrequencyStep = 
				(SpectrumAnalyzer.CZT.StopFrequency-SpectrumAnalyzer.CZT.StartFrequency)/
				CZTLinesEdit.Position;
			SpectrumAnalyzer.Update();
		}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CZTLinesEdit_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LinesLabel_Click(object sender, EventArgs e)
        {

        }

        private void CZTBWEdit_Click(object sender, EventArgs e)
        {

        }

        private void CZTStartEdit_Click(object sender, EventArgs e)
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

        protected void Add(String s)
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void CZTDemoForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("Chirp Z-transform allows efficient oversampling of "
                + "narrow frequency bands in the frequency spectrum. Start "
                + "Freq defines the left edge of the frequency band. BW is the "
                + "bandwidth of the frequency band and Lines defines the number of "
                + "lines to be computed within that frequency band. Hold down the "
                + "CTRL key and double click the edit boxes to change the up/down step.");


        }

        private void MarkCursorBox_CheckedChanged(object sender, EventArgs e)
        {
            spectrumMarkTool1.CursorActive = MarkCursorBox.Checked;
        }
	}
}
