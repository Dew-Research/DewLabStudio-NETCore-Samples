using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Dew.Signal;
using Dew.Math;
using Dew.Math.Controls;
using Dew.Signal.Units;
using Dew.Math.Units;
using Dew.Signal.Tee;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for SignalAnalysisDemoForm.
	/// </summary>
	public class SignalAnalysisDemoForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private SignalChart SignalChart1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private Steema.TeeChart.Styles.FastLine Series1;
		private Steema.TeeChart.Styles.Points MarkSeries1;
		private Dew.Signal.TSignalRead SignalRead1;
		private Dew.Signal.TSignalAnalyzer SignalAnalyzer1;
        private Button AnalysisButton;
        private Button ChartButton;
        private Steema.TeeChart.Editor ChartEditor;
        private SignalAnalyzerDialog SignalAnalyzerDialog;
        private System.ComponentModel.IContainer components;

		public SignalAnalysisDemoForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            Series1.Color = Color.Navy;

			SignalMarkTool smt = new SignalMarkTool(SignalChart1.Chart);
			smt.CursorActive = false;
			smt.MarkSeries = MarkSeries1;
			smt.Series =  Series1;
			smt.AmpltFormat = "0.00#";
			smt.TimeFormat = "0.00#";
			smt.MarkMode = SignalMarkMode.tmFreeStyle;
			SignalChart1.Tools.Add(smt);

            SignalRead1.FileName = Dew.Demo.Utils.SourcePath() + @"\Data\bz.sfs";
            SignalRead1.RecordPosition = 0;
			comboBox1.SelectedIndex = 0;
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
            Dew.Signal.TSignalItem tSignalItem1 = new Dew.Signal.TSignalItem();
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignalAnalysisDemoForm));
            Dew.Signal.Tee.SignalTeeItem signalTeeItem1 = new Dew.Signal.Tee.SignalTeeItem();
            this.SignalRead1 = new Dew.Signal.TSignalRead(this.components);
            this.SignalAnalyzer1 = new Dew.Signal.TSignalAnalyzer(this.components);
            this.Series1 = new Steema.TeeChart.Styles.FastLine();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AnalysisButton = new System.Windows.Forms.Button();
            this.ChartButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SignalAnalyzerDialog = new Dew.Signal.SignalAnalyzerDialog(this.components);
            this.SignalChart1 = new Dew.Signal.Tee.SignalChart();
            this.MarkSeries1 = new Steema.TeeChart.Styles.Points();
            this.ChartEditor = new Steema.TeeChart.Editor(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignalChart1)).BeginInit();
            this.SuspendLayout();
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
            this.SignalRead1.SamplingFrequency = 4666.666666666667D;
            // 
            // SignalAnalyzer1
            // 
            this.SignalAnalyzer1.BandwidthL = 0D;
            this.SignalAnalyzer1.BlockAssign = false;
            this.SignalAnalyzer1.ChannelCount = 1;
            this.SignalAnalyzer1.Complex = false;
            this.SignalAnalyzer1.CorrTaps1 = 100;
            this.SignalAnalyzer1.CorrTaps2 = 0;
            this.SignalAnalyzer1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.SignalAnalyzer1.FloatPrecisionLock = false;
            tSignalItem1.Input = this.SignalRead1;
            tSignalItem1.OnInputUpdated = null;
            this.SignalAnalyzer1.Inputs.Add(tSignalItem1);
            this.SignalAnalyzer1.IsDouble = true;
            this.SignalAnalyzer1.Length = 128;
            this.SignalAnalyzer1.Name = "";
            this.SignalAnalyzer1.OnAfterUpdate = null;
            this.SignalAnalyzer1.OnBeforeUpdate = null;
            this.SignalAnalyzer1.OnDisplayUpdate = null;
            this.SignalAnalyzer1.OnGetInput = null;
            this.SignalAnalyzer1.OnNotifyUpdate = null;
            this.SignalAnalyzer1.OnParameterUpdate = null;
            this.SignalAnalyzer1.Report.AmplitudeFormat = null;
            this.SignalAnalyzer1.Report.TimeFormat = null;
            this.SignalAnalyzer1.Report.UseTab = false;
            this.SignalAnalyzer1.Rotation = 0;
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
            this.Series1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
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
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(759, 118);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AnalysisButton);
            this.panel1.Controls.Add(this.ChartButton);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 490);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 43);
            this.panel1.TabIndex = 1;
            // 
            // AnalysisButton
            // 
            this.AnalysisButton.Location = new System.Drawing.Point(121, 7);
            this.AnalysisButton.Name = "AnalysisButton";
            this.AnalysisButton.Size = new System.Drawing.Size(90, 29);
            this.AnalysisButton.TabIndex = 3;
            this.AnalysisButton.Text = "Analysis";
            this.AnalysisButton.UseVisualStyleBackColor = true;
            this.AnalysisButton.Click += new System.EventHandler(this.AnalysisButton_Click);
            // 
            // ChartButton
            // 
            this.ChartButton.Location = new System.Drawing.Point(14, 7);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(90, 29);
            this.ChartButton.TabIndex = 2;
            this.ChartButton.Text = "Chart";
            this.ChartButton.UseVisualStyleBackColor = true;
            this.ChartButton.Click += new System.EventHandler(this.ChartButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Window",
            "AutoCorr",
            "CrossCorr",
            "Dct",
            "InverseDct",
            "RealCepstrum",
            "CplxCepstrum"});
            this.comboBox1.Location = new System.Drawing.Point(346, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transform:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SignalAnalyzerDialog
            // 
            this.SignalAnalyzerDialog.BlockAssign = false;
            this.SignalAnalyzerDialog.Docking = false;
            this.SignalAnalyzerDialog.FormCaption = null;
            this.SignalAnalyzerDialog.Name = null;
            this.SignalAnalyzerDialog.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.SignalAnalyzerDialog.ShowLive = false;
            this.SignalAnalyzerDialog.Source = this.SignalAnalyzer1;
            this.SignalAnalyzerDialog.SourceListIndex = 0;
            // 
            // SignalChart1
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
            this.SignalChart1.Axes.Bottom.Grid.DrawEvery = 1;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Labels.Axis = this.SignalChart1.Axes.Bottom;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Axes.Bottom.Labels.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SignalChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Bottom.Labels.Font.Size = 9;
            this.SignalChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            this.SignalChart1.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            this.SignalChart1.Axes.Bottom.Labels.Separation = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Bottom.MaximumOffset = 4;
            this.SignalChart1.Axes.Bottom.MinimumOffset = 4;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.MinorTicks.Length = 2;
            this.SignalChart1.Axes.Bottom.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Ticks.Length = 4;
            this.SignalChart1.Axes.Bottom.Ticks.Visible = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.TicksInner.Length = 0;
            this.SignalChart1.Axes.Bottom.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.Axes.Bottom.Title.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Title.Brush.Visible = true;
            this.SignalChart1.Axes.Bottom.Title.Caption = "Time [s]";
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignalChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Bottom.Title.Font.Size = 11;
            this.SignalChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            this.SignalChart1.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            this.SignalChart1.Axes.Bottom.Title.Lines = new string[] {
        "Time [s]"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.AxisPen.Visible = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Labels.Axis = this.SignalChart1.Axes.Depth;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Axes.Depth.Labels.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SignalChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Depth.Labels.Font.Size = 9;
            this.SignalChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            this.SignalChart1.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.MinorTicks.Length = 2;
            this.SignalChart1.Axes.Depth.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Ticks.Length = 4;
            this.SignalChart1.Axes.Depth.Ticks.Visible = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.TicksInner.Length = 0;
            this.SignalChart1.Axes.Depth.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.Axes.Depth.Title.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignalChart1.Axes.Depth.Title.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Depth.Title.Font.Size = 11;
            this.SignalChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            this.SignalChart1.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.AxisPen.Visible = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Labels.Axis = this.SignalChart1.Axes.DepthTop;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Axes.DepthTop.Labels.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SignalChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.DepthTop.Labels.Font.Size = 9;
            this.SignalChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            this.SignalChart1.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.MinorTicks.Length = 2;
            this.SignalChart1.Axes.DepthTop.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Ticks.Length = 4;
            this.SignalChart1.Axes.DepthTop.Ticks.Visible = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.TicksInner.Length = 0;
            this.SignalChart1.Axes.DepthTop.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.Axes.DepthTop.Title.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignalChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.DepthTop.Title.Font.Size = 11;
            this.SignalChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            this.SignalChart1.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Grid.DrawEvery = 1;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Labels.Axis = this.SignalChart1.Axes.Left;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Axes.Left.Labels.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SignalChart1.Axes.Left.Labels.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Left.Labels.Font.Size = 9;
            this.SignalChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            this.SignalChart1.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Left.MaximumOffset = 4;
            this.SignalChart1.Axes.Left.MinimumOffset = 4;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.MinorTicks.Length = 2;
            this.SignalChart1.Axes.Left.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Ticks.Length = 4;
            this.SignalChart1.Axes.Left.Ticks.Visible = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.TicksInner.Length = 0;
            this.SignalChart1.Axes.Left.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.Axes.Left.Title.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignalChart1.Axes.Left.Title.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Left.Title.Font.Size = 11;
            this.SignalChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            this.SignalChart1.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.AxisPen.Visible = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Labels.Axis = this.SignalChart1.Axes.Right;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Axes.Right.Labels.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SignalChart1.Axes.Right.Labels.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Right.Labels.Font.Size = 9;
            this.SignalChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            this.SignalChart1.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.MinorTicks.Length = 2;
            this.SignalChart1.Axes.Right.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Ticks.Length = 4;
            this.SignalChart1.Axes.Right.Ticks.Visible = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.TicksInner.Length = 0;
            this.SignalChart1.Axes.Right.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.Axes.Right.Title.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignalChart1.Axes.Right.Title.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Right.Title.Font.Size = 11;
            this.SignalChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            this.SignalChart1.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Labels.Axis = this.SignalChart1.Axes.Top;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Axes.Top.Labels.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SignalChart1.Axes.Top.Labels.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Top.Labels.Font.Size = 9;
            this.SignalChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            this.SignalChart1.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.MinorTicks.Length = 2;
            this.SignalChart1.Axes.Top.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Ticks.Length = 4;
            this.SignalChart1.Axes.Top.Ticks.Visible = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.TicksInner.Length = 0;
            this.SignalChart1.Axes.Top.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.Axes.Top.Title.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignalChart1.Axes.Top.Title.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Top.Title.Font.Size = 11;
            this.SignalChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            this.SignalChart1.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.SignalChart1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SignalChart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.SignalChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.Footer.Brush.Solid = true;
            this.SignalChart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.SignalChart1.Footer.Font.Brush.Solid = true;
            this.SignalChart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Footer.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Footer.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Footer.Font.Size = 8;
            this.SignalChart1.Footer.Font.SizeFloat = 8F;
            this.SignalChart1.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Footer.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Footer.Shadow.Brush.Solid = true;
            this.SignalChart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SignalChart1.Header.Brush.Solid = true;
            this.SignalChart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Header.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SignalChart1.Header.Font.Brush.Solid = true;
            this.SignalChart1.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Header.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Header.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Header.Font.Size = 12;
            this.SignalChart1.Header.Font.SizeFloat = 12F;
            this.SignalChart1.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Header.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Header.ImageBevel.Brush.Visible = true;
            this.SignalChart1.Header.Lines = new string[] {
        "Time signal"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignalChart1.Header.Shadow.Brush.Solid = true;
            this.SignalChart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Legend.Brush.Solid = true;
            this.SignalChart1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignalChart1.Legend.Font.Brush.Solid = true;
            this.SignalChart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Legend.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Legend.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Legend.Font.Size = 9;
            this.SignalChart1.Legend.Font.SizeFloat = 9F;
            this.SignalChart1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Legend.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Legend.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SignalChart1.Legend.Shadow.Brush.Solid = true;
            this.SignalChart1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Legend.Symbol.Legend = this.SignalChart1.Legend;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Legend.Symbol.Shadow.Brush.Solid = true;
            this.SignalChart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Legend.Title.Brush.Solid = true;
            this.SignalChart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.SignalChart1.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.SignalChart1.Legend.Title.Font.Brush.Solid = true;
            this.SignalChart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Legend.Title.Font.Size = 8;
            this.SignalChart1.Legend.Title.Font.SizeFloat = 8F;
            this.SignalChart1.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Legend.Title.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Legend.Title.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Legend.Title.Shadow.Brush.Solid = true;
            this.SignalChart1.Legend.Title.Shadow.Brush.Visible = true;
            this.SignalChart1.Legend.Visible = false;
            this.SignalChart1.Location = new System.Drawing.Point(0, 118);
            this.SignalChart1.Name = "SignalChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            // 
            // 
            // 
            this.SignalChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.SignalChart1.Panel.Brush.Gradient.UseMiddle = true;
            this.SignalChart1.Panel.Brush.Solid = true;
            this.SignalChart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Panel.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Panel.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Panel.Shadow.Brush.Solid = true;
            this.SignalChart1.Panel.Shadow.Brush.Visible = true;
            this.SignalChart1.Series.Add(this.Series1);
            this.SignalChart1.Series.Add(this.MarkSeries1);
            signalTeeItem1.Caption = null;
            signalTeeItem1.Input = this.SignalAnalyzer1;
            signalTeeItem1.Inputs = null;
            signalTeeItem1.Series = this.Series1;
            signalTeeItem1.SeriesName = "fastLine1";
            this.SignalChart1.Signals.Add(signalTeeItem1);
            this.SignalChart1.Size = new System.Drawing.Size(759, 372);
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.SubFooter.Brush.Solid = true;
            this.SignalChart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.SignalChart1.SubFooter.Font.Brush.Solid = true;
            this.SignalChart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.SubFooter.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.SubFooter.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.SubFooter.Font.Size = 8;
            this.SignalChart1.SubFooter.Font.SizeFloat = 8F;
            this.SignalChart1.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.SubFooter.ImageBevel.Brush.Solid = true;
            this.SignalChart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.SubFooter.Shadow.Brush.Solid = true;
            this.SignalChart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SignalChart1.SubHeader.Brush.Solid = true;
            this.SignalChart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SignalChart1.SubHeader.Font.Brush.Solid = true;
            this.SignalChart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.SubHeader.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.SubHeader.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.SubHeader.Font.Size = 12;
            this.SignalChart1.SubHeader.Font.SizeFloat = 12F;
            this.SignalChart1.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.SubHeader.ImageBevel.Brush.Solid = true;
            this.SignalChart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignalChart1.SubHeader.Shadow.Brush.Solid = true;
            this.SignalChart1.SubHeader.Shadow.Brush.Visible = true;
            this.SignalChart1.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.Walls.Back.Brush.Solid = true;
            this.SignalChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Walls.Back.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Walls.Back.Shadow.Brush.Solid = true;
            this.SignalChart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Walls.Bottom.Brush.Solid = true;
            this.SignalChart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Walls.Bottom.Shadow.Brush.Solid = true;
            this.SignalChart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.SignalChart1.Walls.Left.Brush.Solid = true;
            this.SignalChart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Walls.Left.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Walls.Left.Shadow.Brush.Solid = true;
            this.SignalChart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.SignalChart1.Walls.Right.Brush.Solid = true;
            this.SignalChart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Walls.Right.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Walls.Right.Shadow.Brush.Solid = true;
            this.SignalChart1.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Zoom.Animated = true;
            // 
            // 
            // 
            this.SignalChart1.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.SignalChart1.Zoom.Brush.Solid = true;
            this.SignalChart1.Zoom.Brush.Visible = false;
            this.SignalChart1.Zoom.FullRepaint = true;
            this.SignalChart1.Zoom.History = true;
            // 
            // 
            // 
            this.SignalChart1.Zoom.Pen.Visible = true;
            // 
            // MarkSeries1
            // 
            // 
            // 
            // 
            this.MarkSeries1.Brush.Color = System.Drawing.Color.Empty;
            this.MarkSeries1.Brush.Solid = true;
            this.MarkSeries1.Brush.Visible = true;
            this.MarkSeries1.Color = System.Drawing.Color.Red;
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
            this.MarkSeries1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MarkSeries1.Marks.Brush.Solid = true;
            this.MarkSeries1.Marks.Brush.Visible = true;
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
            this.MarkSeries1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
            this.MarkSeries1.Marks.TailParams.Margin = 0F;
            this.MarkSeries1.Marks.TailParams.PointerHeight = 8D;
            this.MarkSeries1.Marks.TailParams.PointerWidth = 8D;
            this.MarkSeries1.OriginalCursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries1.Pointer.Brush.Color = System.Drawing.Color.Red;
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
            // ChartEditor
            // 
            this.ChartEditor.AlwaysShowFuncSrc = false;
            this.ChartEditor.Chart = this.SignalChart1;
            this.ChartEditor.HighLightTabs = false;
            this.ChartEditor.Location = new System.Drawing.Point(0, 0);
            this.ChartEditor.Name = "ChartEditor";
            this.ChartEditor.Options = null;
            this.ChartEditor.TabIndex = 0;
            // 
            // SignalAnalysisDemoForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(759, 533);
            this.Controls.Add(this.SignalChart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "SignalAnalysisDemoForm";
            this.Text = "SignalAnalysisDemoForm";
            this.Load += new System.EventHandler(this.SignalAnalysisDemoForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SignalChart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e) {
			SignalAnalyzer1.Transform = (TTimeTransform)comboBox1.SelectedIndex;
			SignalAnalyzer1.Update();
		}

        protected void Add(String s)
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void SignalAnalysisDemoForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("A simple drop-in component gives instant access to a wide "
            + "array of standard signal processing operations like "
            + "autocorrelation, discrete cosine transform, signal "
            + "statistics and more...");
        }

        private void ChartButton_Click(object sender, EventArgs e)
        {
            ChartEditor.ShowModal();
        }

        private void AnalysisButton_Click(object sender, EventArgs e)
        {
            SignalAnalyzerDialog.ExecuteModal();
        }

        private void SignalAnalyzer1_OnParameterUpdate(object Sender)
        {
            SignalAnalyzer1.Update();
        }
	}
}


