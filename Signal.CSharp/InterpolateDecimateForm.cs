using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Dew.Signal;
using Dew.Signal.Editors;
using Dew.Math;
using Dew.Signal.Tee;
using Dew.Signal.Units;
using Dew.Math.Units;
using Dew.Math.Controls;
using Dew.Demo;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for InterpolateDecimateForm.
	/// </summary>
	public class InterpolateDecimateForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private Steema.TeeChart.Styles.FastLine OriginalSeries;
		private Steema.TeeChart.Styles.FastLine FilteredSeries;
		private Steema.TeeChart.Styles.Points MarkSeries;
		private FloatEdit filePos1Edit;
		private System.Windows.Forms.Label label1;
		private FloatEdit filePos2Edit;
		private System.Windows.Forms.Label label2;
		private Dew.Signal.TSpectrumAnalyzer SpectrumAnalyzer1;
		private Dew.Signal.TSignalRead SignalRead1;
		private Dew.Signal.TSignalRead SignalRead2;
		private Dew.Signal.TSignalRead SignalRead3;
		private Dew.Signal.TSignalWrite SignalWrite1;
		private Dew.Signal.TSpectrumAnalyzer SpectrumAnalyzer;
		private Dew.Signal.TSignalDecimator SignalDecimator1;
		private Dew.Signal.TSignalInterpolator SignalInterpolator1;
		private SpectrumChart SpectrumChart1;
        private Button SpectrumButton;
        private Button ChartButton;
        private Steema.TeeChart.Editor ChartEditor;
        private SpectrumAnalyzerDialog SpectrumAnalyzerDialog;
		private System.ComponentModel.IContainer components;

		public InterpolateDecimateForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			SpectrumChart1.Spectrums.Add();
			SpectrumChart1.Spectrums[0].Input = SpectrumAnalyzer;
			SpectrumChart1.Spectrums[0].Series = OriginalSeries;

			SpectrumChart1.Spectrums.Add();
			SpectrumChart1.Spectrums[1].Input = SpectrumAnalyzer1;
			SpectrumChart1.Spectrums[1].Series = FilteredSeries;

            OriginalSeries.Color = Color.Navy;
            FilteredSeries.Color = Color.Red;

			SpectrumMarkTool smt = new SpectrumMarkTool(SpectrumChart1.Chart);
			smt.CursorActive = true;
			smt.DoubleClickClear = true;
			smt.PeakFilterMode = false;
			smt.MarkMode = SpectrumMarkMode.mmSingle;
			smt.MarkType = SpectrumMarkType.mtAmplt;
			smt.MarkSeries = MarkSeries;
			smt.Series = OriginalSeries;
			smt.AmpltFormat = "0.00#";
			smt.PhaseFormat = "0.00#";
			smt.FreqFormat = "0.00#";
			smt.LabelHeaders = true;
			smt.PeakZoomBand = false;
			SpectrumChart1.Tools.Add(smt);

			AxisScaleTool tool = new AxisScaleTool(SpectrumChart1.Chart);
			tool.UpperMargin = 20;
			tool.LowerMargin = 5;
			tool.AxisScaleMode = AxisScaleMode.amAuto;
			tool.DataIsSpectrum = true;
			tool.Axis = SpectrumChart1.Axes.Left;
			SpectrumChart1.Tools.Add(tool);

            SignalRead1.FileName = Dew.Demo.Utils.SourcePath() + @"\Data\bz.dat";
            SignalRead1.OpenFile();
            SignalWrite1.FileName = Dew.Demo.Utils.SourcePath() + "\\bz.dat";
            SignalWrite1.PullUntilEnd();

            SignalRead1.CloseFile();
            SignalWrite1.CloseFile();

            SignalRead2.Length = 1024;
            SignalRead3.Length = 1024;

            SignalRead2.FileName = SignalRead1.FileName;
            SignalRead3.FileName = SignalWrite1.FileName;

            SignalRead2.OpenFile();
            SignalRead2.RecordPosition = 0;

            SpectrumAnalyzer.DCDump = false;
            SpectrumAnalyzer.LogType = TLogType.ltRelative;
            SpectrumAnalyzer.LogSpan = TLogSpan.ls150;
            SpectrumAnalyzer.Logarithmic = true;
            SpectrumAnalyzer.Window = TSignalWindowType.wtKaiser;
            SpectrumAnalyzer.SidelobeAtt = 130;

            //Make the second analyzer the same:
            SpectrumAnalyzer1.DCDump = false;
            SpectrumAnalyzer1.LogType = TLogType.ltRelative;
            SpectrumAnalyzer1.LogSpan = TLogSpan.ls150;
            SpectrumAnalyzer1.Logarithmic = true;
            SpectrumAnalyzer1.Window = TSignalWindowType.wtKaiser;
            SpectrumAnalyzer1.SidelobeAtt = 130;

            SpectrumAnalyzer.Update();

			SignalRead1.OpenFile();
			SignalRead1.CloseFile();
			SignalWrite1.CloseFile();
			SignalRead2.FileName = SignalRead1.FileName;
			SignalRead3.FileName = SignalWrite1.FileName;
			SignalRead2.RecordPosition = 0;

            filePos2Edit.Position = 1838;
			
//			filePos1Edit_TextChanged(this, EventArgs.Empty);
			filePos2Edit_TextChanged(this, EventArgs.Empty);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterpolateDecimateForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SpectrumButton = new System.Windows.Forms.Button();
            this.ChartButton = new System.Windows.Forms.Button();
            this.filePos2Edit = new Dew.Math.Controls.FloatEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.filePos1Edit = new Dew.Math.Controls.FloatEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.SpectrumChart1 = new Dew.Signal.Tee.SpectrumChart();
            this.OriginalSeries = new Steema.TeeChart.Styles.FastLine();
            this.FilteredSeries = new Steema.TeeChart.Styles.FastLine();
            this.MarkSeries = new Steema.TeeChart.Styles.Points();
            this.SpectrumAnalyzer1 = new Dew.Signal.TSpectrumAnalyzer(this.components);
            this.SignalRead3 = new Dew.Signal.TSignalRead(this.components);
            this.SignalRead1 = new Dew.Signal.TSignalRead(this.components);
            this.SignalRead2 = new Dew.Signal.TSignalRead(this.components);
            this.SignalWrite1 = new Dew.Signal.TSignalWrite(this.components);
            this.SignalInterpolator1 = new Dew.Signal.TSignalInterpolator(this.components);
            this.SignalDecimator1 = new Dew.Signal.TSignalDecimator(this.components);
            this.SpectrumAnalyzer = new Dew.Signal.TSpectrumAnalyzer(this.components);
            this.ChartEditor = new Steema.TeeChart.Editor(this.components);
            this.SpectrumAnalyzerDialog = new Dew.Signal.Editors.SpectrumAnalyzerDialog(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(688, 80);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SpectrumButton);
            this.panel1.Controls.Add(this.ChartButton);
            this.panel1.Controls.Add(this.filePos2Edit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.filePos1Edit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 562);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 35);
            this.panel1.TabIndex = 1;
            // 
            // SpectrumButton
            // 
            this.SpectrumButton.Location = new System.Drawing.Point(12, 6);
            this.SpectrumButton.Name = "SpectrumButton";
            this.SpectrumButton.Size = new System.Drawing.Size(75, 23);
            this.SpectrumButton.TabIndex = 15;
            this.SpectrumButton.Text = "Spectrum";
            this.SpectrumButton.UseVisualStyleBackColor = true;
            this.SpectrumButton.Click += new System.EventHandler(this.SpectrumButton_Click);
            // 
            // ChartButton
            // 
            this.ChartButton.Location = new System.Drawing.Point(105, 6);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(79, 23);
            this.ChartButton.TabIndex = 14;
            this.ChartButton.Text = "Chart";
            this.ChartButton.UseVisualStyleBackColor = true;
            this.ChartButton.Click += new System.EventHandler(this.ChartButton_Click);
            // 
            // filePos2Edit
            // 
            this.filePos2Edit.Increment = "1";
            this.filePos2Edit.Location = new System.Drawing.Point(467, 6);
            this.filePos2Edit.Name = "filePos2Edit";
            this.filePos2Edit.ReFormat = "0";
            this.filePos2Edit.Scientific = false;
            this.filePos2Edit.Size = new System.Drawing.Size(72, 20);
            this.filePos2Edit.TabIndex = 13;
            this.filePos2Edit.Text = "1650";
            this.filePos2Edit.Value = "1650";
            this.filePos2Edit.TextChanged += new System.EventHandler(this.filePos2Edit_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(379, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "File position 2:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // filePos1Edit
            // 
            this.filePos1Edit.Increment = "1";
            this.filePos1Edit.Location = new System.Drawing.Point(307, 6);
            this.filePos1Edit.Name = "filePos1Edit";
            this.filePos1Edit.ReFormat = "0";
            this.filePos1Edit.Scientific = false;
            this.filePos1Edit.Size = new System.Drawing.Size(72, 20);
            this.filePos1Edit.TabIndex = 11;
            this.filePos1Edit.Text = "0";
            this.filePos1Edit.TextChanged += new System.EventHandler(this.filePos1Edit_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(203, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "File position 1:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SpectrumChart1
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Aspect.View3D = false;
            this.SpectrumChart1.Aspect.ZOffset = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Labels.Separation = 0;
            this.SpectrumChart1.Axes.Bottom.MaximumOffset = 4;
            this.SpectrumChart1.Axes.Bottom.MinimumOffset = 4;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Title.Caption = "Frequency [Hz]";
            this.SpectrumChart1.Axes.Bottom.Title.Lines = new string[] {
        "Frequency [Hz]"};
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.MaximumOffset = 4;
            this.SpectrumChart1.Axes.Left.MinimumOffset = 4;
            this.SpectrumChart1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SpectrumChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.SpectrumChart1.Header.Lines = new string[] {
        "Frequency spectrum"};
            this.SpectrumChart1.Location = new System.Drawing.Point(0, 80);
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
            this.SpectrumChart1.Series.Add(this.OriginalSeries);
            this.SpectrumChart1.Series.Add(this.FilteredSeries);
            this.SpectrumChart1.Series.Add(this.MarkSeries);
            this.SpectrumChart1.Size = new System.Drawing.Size(688, 482);
            this.SpectrumChart1.SpectrumPart = Dew.Signal.Tee.SpectrumPart.sppAmplt;
            this.SpectrumChart1.TabIndex = 2;
            // 
            // OriginalSeries
            // 
            this.OriginalSeries.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.OriginalSeries.ColorEach = false;
            // 
            // 
            // 
            this.OriginalSeries.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.OriginalSeries.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.OriginalSeries.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.OriginalSeries.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.OriginalSeries.Marks.Callout.Distance = 0;
            this.OriginalSeries.Marks.Callout.Draw3D = false;
            this.OriginalSeries.Marks.Callout.Length = 10;
            this.OriginalSeries.Marks.Callout.Series = this.OriginalSeries;
            this.OriginalSeries.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.OriginalSeries.Marks.Callout.Visible = false;
            this.OriginalSeries.Marks.Series = this.OriginalSeries;
            this.OriginalSeries.Title = "Original";
            this.OriginalSeries.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            // 
            // 
            // 
            this.OriginalSeries.XValues.DataMember = "X";
            this.OriginalSeries.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.OriginalSeries.YValues.DataMember = "Y";
            // 
            // FilteredSeries
            // 
            this.FilteredSeries.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.FilteredSeries.ColorEach = false;
            // 
            // 
            // 
            this.FilteredSeries.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.FilteredSeries.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.FilteredSeries.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.FilteredSeries.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.FilteredSeries.Marks.Callout.Distance = 0;
            this.FilteredSeries.Marks.Callout.Draw3D = false;
            this.FilteredSeries.Marks.Callout.Length = 10;
            this.FilteredSeries.Marks.Callout.Series = this.FilteredSeries;
            this.FilteredSeries.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.FilteredSeries.Marks.Callout.Visible = false;
            this.FilteredSeries.Marks.Series = this.FilteredSeries;
            this.FilteredSeries.Title = "Filtered";
            this.FilteredSeries.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            // 
            // 
            // 
            this.FilteredSeries.XValues.DataMember = "X";
            this.FilteredSeries.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.FilteredSeries.YValues.DataMember = "Y";
            // 
            // MarkSeries
            // 
            this.MarkSeries.Color = System.Drawing.Color.Red;
            this.MarkSeries.ColorEach = false;
            // 
            // 
            // 
            this.MarkSeries.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries.Marks.Arrow.Visible = false;
            this.MarkSeries.Marks.ArrowLength = 10;
            // 
            // 
            // 
            this.MarkSeries.Marks.Brush.Visible = false;
            // 
            // 
            // 
            this.MarkSeries.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.MarkSeries.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.MarkSeries.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.MarkSeries.Marks.Callout.Distance = 0;
            this.MarkSeries.Marks.Callout.Draw3D = false;
            this.MarkSeries.Marks.Callout.Length = 10;
            this.MarkSeries.Marks.Callout.Series = this.MarkSeries;
            this.MarkSeries.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.MarkSeries.Marks.Callout.Visible = false;
            this.MarkSeries.Marks.Series = this.MarkSeries;
            this.MarkSeries.Marks.Transparent = true;
            this.MarkSeries.Marks.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries.Pointer.Brush.Color = System.Drawing.Color.Red;
            this.MarkSeries.Pointer.HorizSize = 3;
            // 
            // 
            // 
            this.MarkSeries.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MarkSeries.Pointer.Series = this.MarkSeries;
            this.MarkSeries.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.MarkSeries.Pointer.VertSize = 3;
            this.MarkSeries.Legend.Visible = false;
            this.MarkSeries.Title = "point1";
            // 
            // 
            // 
            this.MarkSeries.XValues.DataMember = "X";
            this.MarkSeries.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.MarkSeries.YValues.DataMember = "Y";
            // 
            // SpectrumAnalyzer1
            // 
            this.SpectrumAnalyzer1.Bands.TemplateIndex = -1;
            this.SpectrumAnalyzer1.Bands.Templates = new Dew.Signal.TStringStreamList(System.Convert.FromBase64String("AAAAAA=="));
            this.SpectrumAnalyzer1.BlockAssign = false;
            this.SpectrumAnalyzer1.Input = this.SignalRead3;
            this.SpectrumAnalyzer1.Name = "";
            this.SpectrumAnalyzer1.Peaks.Interpolation.Method = Dew.Signal.TInterpolationMethod.imNone;
            this.SpectrumAnalyzer1.Report.AmplitudeFormat = null;
            this.SpectrumAnalyzer1.Report.FrequencyFormat = null;
            this.SpectrumAnalyzer1.Report.PhaseFormat = null;
            this.SpectrumAnalyzer1.Window = Dew.Signal.TSignalWindowType.wtHanning;
            // 
            // SignalRead3
            // 
            this.SignalRead3.BandwidthL = 0;
            this.SignalRead3.BlockAssign = false;
            this.SignalRead3.FramesPerSecond = 0.0009765625;
            this.SignalRead3.Input = null;
            this.SignalRead3.Length = 1024;
            this.SignalRead3.Name = "";
            this.SignalRead3.RecordPosition = ((long)(0));
            // 
            // SignalRead1
            // 
            this.SignalRead1.BandwidthL = 0;
            this.SignalRead1.BlockAssign = false;
            this.SignalRead1.FramesPerSecond = 0.0009765625;
            this.SignalRead1.Input = null;
            this.SignalRead1.Length = 1024;
            this.SignalRead1.Name = "";
            this.SignalRead1.RecordPosition = ((long)(0));
            // 
            // SignalRead2
            // 
            this.SignalRead2.BandwidthL = 0;
            this.SignalRead2.BlockAssign = false;
            this.SignalRead2.FramesPerSecond = 0.0009765625;
            this.SignalRead2.Input = null;
            this.SignalRead2.Length = 1024;
            this.SignalRead2.Name = "";
            this.SignalRead2.RecordPosition = ((long)(0));
            // 
            // SignalWrite1
            // 
            this.SignalWrite1.AuthorInfo = "Unknown";
            this.SignalWrite1.BandwidthL = 0;
            this.SignalWrite1.BlockAssign = false;
            this.SignalWrite1.FileName = "bz.dat";
            this.SignalWrite1.ImFormat = null;
            this.SignalWrite1.Input = this.SignalInterpolator1;
            this.SignalWrite1.Name = "";
            this.SignalWrite1.ReFormat = null;
            // 
            // SignalInterpolator1
            // 
            this.SignalInterpolator1.BandwidthL = 0;
            this.SignalInterpolator1.BlockAssign = false;
            this.SignalInterpolator1.Factor = 32;
            this.SignalInterpolator1.FilterDelay = 919;
            this.SignalInterpolator1.Input = this.SignalDecimator1;
            this.SignalInterpolator1.Name = "";
            // 
            // SignalDecimator1
            // 
            this.SignalDecimator1.BandwidthL = 0;
            this.SignalDecimator1.BlockAssign = false;
            this.SignalDecimator1.Factor = 32;
            this.SignalDecimator1.FilterDelay = 28.71875;
            this.SignalDecimator1.Input = this.SignalRead1;
            this.SignalDecimator1.Name = "";
            // 
            // SpectrumAnalyzer
            // 
            this.SpectrumAnalyzer.Bands.TemplateIndex = -1;
            this.SpectrumAnalyzer.Bands.Templates = new Dew.Signal.TStringStreamList(System.Convert.FromBase64String("AAAAAA=="));
            this.SpectrumAnalyzer.BlockAssign = false;
            this.SpectrumAnalyzer.DCDump = false;
            this.SpectrumAnalyzer.Input = this.SignalRead2;
            this.SpectrumAnalyzer.Logarithmic = true;
            this.SpectrumAnalyzer.LogSpan = Dew.Signal.TLogSpan.ls150;
            this.SpectrumAnalyzer.LogType = Dew.Signal.TLogType.ltRelative;
            this.SpectrumAnalyzer.Name = "";
            this.SpectrumAnalyzer.Peaks.Interpolation.Method = Dew.Signal.TInterpolationMethod.imNone;
            this.SpectrumAnalyzer.Report.AmplitudeFormat = null;
            this.SpectrumAnalyzer.Report.FrequencyFormat = null;
            this.SpectrumAnalyzer.Report.PhaseFormat = null;
            this.SpectrumAnalyzer.SidelobeAtt = 130;
            this.SpectrumAnalyzer.Window = Dew.Signal.TSignalWindowType.wtKaiser;
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
            this.SpectrumAnalyzerDialog.FormCaption = null;
           
            this.SpectrumAnalyzerDialog.Name = null;
            this.SpectrumAnalyzerDialog.Source = this.SpectrumAnalyzer;
            this.SpectrumAnalyzerDialog.SourceList = null;
            this.SpectrumAnalyzerDialog.SourceListIndex = 0;
            // 
            // InterpolateDecimateForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(688, 597);
            this.Controls.Add(this.SpectrumChart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "InterpolateDecimateForm";
            this.Text = "InterpolateDecimateForm";
            this.Load += new System.EventHandler(this.InterpolateDecimateForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void filePos1Edit_TextChanged(object sender, System.EventArgs e) {
			SignalRead2.RecordPosition = filePos1Edit.IntPosition;
			SpectrumAnalyzer.Update();
		}

		private void filePos2Edit_TextChanged(object sender, System.EventArgs e) {
			SignalRead3.RecordPosition = filePos2Edit.IntPosition;
			SpectrumAnalyzer1.Update();
		}


        protected void Add(String s)
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void InterpolateDecimateForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("High speed low-pass filter. When it is neccessary to obtain "
            +   "extremely narrow transition bands, eliptic IIR and ParksMcClellan FIR "
            +   "filters fail to perform. An alternative in such cases is to employ multi-rate "
            +   "multi-stage FIR decimation and then interpolation. In the example below, "
            +   "the signal has a cutoff at 73 Hz and stopband attenuation of 80dB. The "
            +   "width of the transition region is only 3 Hz. The sampling frequency of "
            +   "the signal is 4666Hz. 3 Hz is less then 0.1% of the bandwidth. Examine "
            +   "the chart and notice that in the pass band both frequency spectrums have "
            +   "an exact match. This type of low-pass filtering takes only a small "
            +   "fraction of time of a single FIR low pass filter whose length would "
            +   "exceed 3600 taps. To processing time required is about the same as "
            +   "filtering the original signal 4x with a 30 taps long filter. To make the "
            +   "strong attenuation in the passband evident, Kaiser window has been "
            +   "employed with sidelobe attenuation of 130dB. Try lowering the sidelobe "
            +   "attenuation in the spectrum analyzer dialog and observe what happens. "
            +   "The transition band is not as narrow as was the filter specification, "
            +   "but this is only because the Kaiser has a very wide mainlobe (frequency "
            +   "spectrum does not show the true reality). With TSignalDemodulator and "
            +   "TSignalModulator components this filtering approach can be used for "
            +   "any lowpass, bandpass, highpass filter specification.");

        }

        private void SpectrumButton_Click(object sender, EventArgs e)
        {
            SpectrumAnalyzerDialog.ExecuteModal();
        }

        private void ChartButton_Click(object sender, EventArgs e)
        {
            ChartEditor.ShowModal();
        }
	}
}
