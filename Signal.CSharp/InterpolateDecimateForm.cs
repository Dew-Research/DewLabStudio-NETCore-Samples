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

            SignalRead1.FileName = Dew.Demo.Utils.SourcePath() + @"\Data\bz.sfs";
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
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
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
            this.SpectrumAnalyzerDialog = new Dew.Signal.SpectrumAnalyzerDialog(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpectrumChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(720, 98);
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
            this.panel1.Location = new System.Drawing.Point(0, 554);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 43);
            this.panel1.TabIndex = 1;
            // 
            // SpectrumButton
            // 
            this.SpectrumButton.Location = new System.Drawing.Point(14, 7);
            this.SpectrumButton.Name = "SpectrumButton";
            this.SpectrumButton.Size = new System.Drawing.Size(90, 29);
            this.SpectrumButton.TabIndex = 15;
            this.SpectrumButton.Text = "Spectrum";
            this.SpectrumButton.UseVisualStyleBackColor = true;
            this.SpectrumButton.Click += new System.EventHandler(this.SpectrumButton_Click);
            // 
            // ChartButton
            // 
            this.ChartButton.Location = new System.Drawing.Point(126, 7);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(95, 29);
            this.ChartButton.TabIndex = 14;
            this.ChartButton.Text = "Chart";
            this.ChartButton.UseVisualStyleBackColor = true;
            this.ChartButton.Click += new System.EventHandler(this.ChartButton_Click);
            // 
            // filePos2Edit
            // 
            this.filePos2Edit.Increment = "1";
            this.filePos2Edit.Location = new System.Drawing.Point(560, 7);
            this.filePos2Edit.Name = "filePos2Edit";
            this.filePos2Edit.ReFormat = "0";
            this.filePos2Edit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.filePos2Edit.Scientific = false;
            this.filePos2Edit.Size = new System.Drawing.Size(87, 23);
            this.filePos2Edit.TabIndex = 13;
            this.filePos2Edit.Value = "1650";
            this.filePos2Edit.TextChanged += new System.EventHandler(this.filePos2Edit_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(455, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "File position 2:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // filePos1Edit
            // 
            this.filePos1Edit.Increment = "1";
            this.filePos1Edit.Location = new System.Drawing.Point(368, 7);
            this.filePos1Edit.Name = "filePos1Edit";
            this.filePos1Edit.ReFormat = "0";
            this.filePos1Edit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.filePos1Edit.Scientific = false;
            this.filePos1Edit.Size = new System.Drawing.Size(87, 23);
            this.filePos1Edit.TabIndex = 11;
            this.filePos1Edit.TextChanged += new System.EventHandler(this.filePos1Edit_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(244, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "File position 1:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.SpectrumChart1.Axes.Bottom.Grid.Visible = false;
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
            this.SpectrumChart1.Axes.Left.AxisPen.Visible = false;
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
            this.SpectrumChart1.Axes.Right.AxisPen.Visible = false;
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
            this.SpectrumChart1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.SpectrumChart1.Location = new System.Drawing.Point(0, 98);
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
            this.SpectrumChart1.Series.Add(this.OriginalSeries);
            this.SpectrumChart1.Series.Add(this.FilteredSeries);
            this.SpectrumChart1.Series.Add(this.MarkSeries);
            this.SpectrumChart1.Size = new System.Drawing.Size(720, 456);
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
            // 
            // 
            // 
            this.SpectrumChart1.Zoom.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.SpectrumChart1.Zoom.Brush.Solid = true;
            this.SpectrumChart1.Zoom.Brush.Visible = true;
            // 
            // OriginalSeries
            // 
            // 
            // 
            // 
            this.OriginalSeries.Brush.Color = System.Drawing.Color.Empty;
            this.OriginalSeries.Brush.Solid = true;
            this.OriginalSeries.Brush.Visible = true;
            this.OriginalSeries.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.OriginalSeries.ColorEach = false;
            cursor1.CursorType = Steema.TeeChart.Drawing.CursorType.Default;
            this.OriginalSeries.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.OriginalSeries.Legend.Brush.Color = System.Drawing.Color.White;
            this.OriginalSeries.Legend.Brush.Solid = true;
            this.OriginalSeries.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.OriginalSeries.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.OriginalSeries.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.OriginalSeries.Legend.Font.Brush.Solid = true;
            this.OriginalSeries.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.OriginalSeries.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.OriginalSeries.Legend.Font.Shadow.Brush.Solid = true;
            this.OriginalSeries.Legend.Font.Shadow.Brush.Visible = true;
            this.OriginalSeries.Legend.Font.Size = 8;
            this.OriginalSeries.Legend.Font.SizeFloat = 8F;
            this.OriginalSeries.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.OriginalSeries.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.OriginalSeries.Legend.ImageBevel.Brush.Solid = true;
            this.OriginalSeries.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.OriginalSeries.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.OriginalSeries.Legend.Shadow.Brush.Solid = true;
            this.OriginalSeries.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.OriginalSeries.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OriginalSeries.Marks.Brush.Solid = true;
            this.OriginalSeries.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.OriginalSeries.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.OriginalSeries.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.OriginalSeries.Marks.Font.Brush.Solid = true;
            this.OriginalSeries.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.OriginalSeries.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.OriginalSeries.Marks.Font.Shadow.Brush.Solid = true;
            this.OriginalSeries.Marks.Font.Shadow.Brush.Visible = true;
            this.OriginalSeries.Marks.Font.Size = 8;
            this.OriginalSeries.Marks.Font.SizeFloat = 8F;
            this.OriginalSeries.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.OriginalSeries.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.OriginalSeries.Marks.ImageBevel.Brush.Solid = true;
            this.OriginalSeries.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.OriginalSeries.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.OriginalSeries.Marks.Shadow.Brush.Solid = true;
            this.OriginalSeries.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.OriginalSeries.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.OriginalSeries.Marks.Symbol.Brush.Solid = true;
            this.OriginalSeries.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.OriginalSeries.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.OriginalSeries.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.OriginalSeries.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.OriginalSeries.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.OriginalSeries.Marks.Symbol.Shadow.Brush.Solid = true;
            this.OriginalSeries.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.OriginalSeries.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
            this.OriginalSeries.Marks.TailParams.Margin = 0F;
            this.OriginalSeries.Marks.TailParams.PointerHeight = 8D;
            this.OriginalSeries.Marks.TailParams.PointerWidth = 8D;
            this.OriginalSeries.OriginalCursor = cursor1;
            this.OriginalSeries.RandomData = true;
            this.OriginalSeries.Title = "Original";
            this.OriginalSeries.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.OriginalSeries.Type = "Steema.TeeChart.Styles.FastLine";
            this.OriginalSeries.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.OriginalSeries.XValues.DataMember = "X";
            this.OriginalSeries.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.OriginalSeries.XValues.Series = this.OriginalSeries;
            // 
            // 
            // 
            this.OriginalSeries.YValues.DataMember = "Y";
            this.OriginalSeries.YValues.Series = this.OriginalSeries;
            // 
            // FilteredSeries
            // 
            // 
            // 
            // 
            this.FilteredSeries.Brush.Color = System.Drawing.Color.Empty;
            this.FilteredSeries.Brush.Solid = true;
            this.FilteredSeries.Brush.Visible = true;
            this.FilteredSeries.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.FilteredSeries.ColorEach = false;
            this.FilteredSeries.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.FilteredSeries.Legend.Brush.Color = System.Drawing.Color.White;
            this.FilteredSeries.Legend.Brush.Solid = true;
            this.FilteredSeries.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.FilteredSeries.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.FilteredSeries.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.FilteredSeries.Legend.Font.Brush.Solid = true;
            this.FilteredSeries.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.FilteredSeries.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.FilteredSeries.Legend.Font.Shadow.Brush.Solid = true;
            this.FilteredSeries.Legend.Font.Shadow.Brush.Visible = true;
            this.FilteredSeries.Legend.Font.Size = 8;
            this.FilteredSeries.Legend.Font.SizeFloat = 8F;
            this.FilteredSeries.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.FilteredSeries.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.FilteredSeries.Legend.ImageBevel.Brush.Solid = true;
            this.FilteredSeries.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.FilteredSeries.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.FilteredSeries.Legend.Shadow.Brush.Solid = true;
            this.FilteredSeries.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.FilteredSeries.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FilteredSeries.Marks.Brush.Solid = true;
            this.FilteredSeries.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.FilteredSeries.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.FilteredSeries.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.FilteredSeries.Marks.Font.Brush.Solid = true;
            this.FilteredSeries.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.FilteredSeries.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.FilteredSeries.Marks.Font.Shadow.Brush.Solid = true;
            this.FilteredSeries.Marks.Font.Shadow.Brush.Visible = true;
            this.FilteredSeries.Marks.Font.Size = 8;
            this.FilteredSeries.Marks.Font.SizeFloat = 8F;
            this.FilteredSeries.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.FilteredSeries.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.FilteredSeries.Marks.ImageBevel.Brush.Solid = true;
            this.FilteredSeries.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.FilteredSeries.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.FilteredSeries.Marks.Shadow.Brush.Solid = true;
            this.FilteredSeries.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.FilteredSeries.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.FilteredSeries.Marks.Symbol.Brush.Solid = true;
            this.FilteredSeries.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.FilteredSeries.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.FilteredSeries.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.FilteredSeries.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.FilteredSeries.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.FilteredSeries.Marks.Symbol.Shadow.Brush.Solid = true;
            this.FilteredSeries.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.FilteredSeries.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
            this.FilteredSeries.Marks.TailParams.Margin = 0F;
            this.FilteredSeries.Marks.TailParams.PointerHeight = 8D;
            this.FilteredSeries.Marks.TailParams.PointerWidth = 8D;
            this.FilteredSeries.OriginalCursor = cursor1;
            this.FilteredSeries.RandomData = true;
            this.FilteredSeries.Title = "Filtered";
            this.FilteredSeries.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.FilteredSeries.Type = "Steema.TeeChart.Styles.FastLine";
            this.FilteredSeries.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.FilteredSeries.XValues.DataMember = "X";
            this.FilteredSeries.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.FilteredSeries.XValues.Series = this.FilteredSeries;
            // 
            // 
            // 
            this.FilteredSeries.YValues.DataMember = "Y";
            this.FilteredSeries.YValues.Series = this.FilteredSeries;
            // 
            // MarkSeries
            // 
            // 
            // 
            // 
            this.MarkSeries.Brush.Color = System.Drawing.Color.Empty;
            this.MarkSeries.Brush.Solid = true;
            this.MarkSeries.Brush.Visible = true;
            this.MarkSeries.Color = System.Drawing.Color.Red;
            this.MarkSeries.ColorEach = false;
            this.MarkSeries.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries.Legend.Brush.Color = System.Drawing.Color.White;
            this.MarkSeries.Legend.Brush.Solid = true;
            this.MarkSeries.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.MarkSeries.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.MarkSeries.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.MarkSeries.Legend.Font.Brush.Solid = true;
            this.MarkSeries.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.MarkSeries.Legend.Font.Shadow.Brush.Solid = true;
            this.MarkSeries.Legend.Font.Shadow.Brush.Visible = true;
            this.MarkSeries.Legend.Font.Size = 8;
            this.MarkSeries.Legend.Font.SizeFloat = 8F;
            this.MarkSeries.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.MarkSeries.Legend.ImageBevel.Brush.Solid = true;
            this.MarkSeries.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.MarkSeries.Legend.Shadow.Brush.Solid = true;
            this.MarkSeries.Legend.Shadow.Brush.Visible = true;
            this.MarkSeries.Legend.Visible = false;
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
            this.MarkSeries.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MarkSeries.Marks.Brush.Solid = true;
            this.MarkSeries.Marks.Brush.Visible = false;
            // 
            // 
            // 
            this.MarkSeries.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.MarkSeries.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.MarkSeries.Marks.Font.Brush.Solid = true;
            this.MarkSeries.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.MarkSeries.Marks.Font.Shadow.Brush.Solid = true;
            this.MarkSeries.Marks.Font.Shadow.Brush.Visible = true;
            this.MarkSeries.Marks.Font.Size = 8;
            this.MarkSeries.Marks.Font.SizeFloat = 8F;
            this.MarkSeries.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.MarkSeries.Marks.ImageBevel.Brush.Solid = true;
            this.MarkSeries.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.MarkSeries.Marks.Shadow.Brush.Solid = true;
            this.MarkSeries.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.MarkSeries.Marks.Symbol.Brush.Solid = true;
            this.MarkSeries.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.MarkSeries.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.MarkSeries.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.MarkSeries.Marks.Symbol.Shadow.Brush.Solid = true;
            this.MarkSeries.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.MarkSeries.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos2")));
            this.MarkSeries.Marks.TailParams.Margin = 0F;
            this.MarkSeries.Marks.TailParams.PointerHeight = 8D;
            this.MarkSeries.Marks.TailParams.PointerWidth = 8D;
            this.MarkSeries.Marks.Transparent = true;
            this.MarkSeries.Marks.Visible = true;
            this.MarkSeries.OriginalCursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries.Pointer.Brush.Color = System.Drawing.Color.Red;
            this.MarkSeries.Pointer.Brush.Solid = true;
            this.MarkSeries.Pointer.Brush.Visible = true;
            this.MarkSeries.Pointer.HorizSize = 3;
            // 
            // 
            // 
            this.MarkSeries.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MarkSeries.Pointer.SizeDouble = 0D;
            this.MarkSeries.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.MarkSeries.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.MarkSeries.Pointer.VertSize = 3;
            this.MarkSeries.RandomData = true;
            this.MarkSeries.Title = "point1";
            this.MarkSeries.Type = "Steema.TeeChart.Styles.Points";
            this.MarkSeries.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.MarkSeries.XValues.DataMember = "X";
            this.MarkSeries.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.MarkSeries.XValues.Series = this.MarkSeries;
            // 
            // 
            // 
            this.MarkSeries.YValues.DataMember = "Y";
            this.MarkSeries.YValues.Series = this.MarkSeries;
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
            this.SpectrumAnalyzer1.Input = this.SignalRead3;
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
            this.SpectrumAnalyzer1.SpectrumScale = 0D;
            this.SpectrumAnalyzer1.Stats.Averaged = 0;
            this.SpectrumAnalyzer1.Stats.Averages = 30;
            this.SpectrumAnalyzer1.Stats.ExpDecay = 5;
            this.SpectrumAnalyzer1.Window = Dew.Signal.TSignalWindowType.wtHanning;
            this.SpectrumAnalyzer1.ZeroPadding = 1;
            // 
            // SignalRead3
            // 
            this.SignalRead3.BandwidthL = 0D;
            this.SignalRead3.BlockAssign = false;
            this.SignalRead3.ChannelCount = 1;
            this.SignalRead3.Complex = false;
            this.SignalRead3.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.SignalRead3.FloatPrecisionLock = false;
            this.SignalRead3.FramesPerSecond = 0.0009765625D;
            this.SignalRead3.Input = null;
            this.SignalRead3.IsDouble = true;
            this.SignalRead3.Length = 1024;
            this.SignalRead3.Name = "";
            this.SignalRead3.OnAfterUpdate = null;
            this.SignalRead3.OnBeforeUpdate = null;
            this.SignalRead3.OnDisplayUpdate = null;
            this.SignalRead3.OnGetInput = null;
            this.SignalRead3.OnNotifyUpdate = null;
            this.SignalRead3.OnParameterUpdate = null;
            this.SignalRead3.OnProcessAll = null;
            this.SignalRead3.OnRecordPositionChange = null;
            this.SignalRead3.OverlappingSamples = 0;
            this.SignalRead3.PostBufferSamples = 0;
            this.SignalRead3.RecordNumber = 0;
            this.SignalRead3.RecordPosition = ((long)(0));
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
            // SignalRead2
            // 
            this.SignalRead2.BandwidthL = 0D;
            this.SignalRead2.BlockAssign = false;
            this.SignalRead2.ChannelCount = 1;
            this.SignalRead2.Complex = false;
            this.SignalRead2.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.SignalRead2.FloatPrecisionLock = false;
            this.SignalRead2.FramesPerSecond = 0.0009765625D;
            this.SignalRead2.Input = null;
            this.SignalRead2.IsDouble = true;
            this.SignalRead2.Length = 1024;
            this.SignalRead2.Name = "";
            this.SignalRead2.OnAfterUpdate = null;
            this.SignalRead2.OnBeforeUpdate = null;
            this.SignalRead2.OnDisplayUpdate = null;
            this.SignalRead2.OnGetInput = null;
            this.SignalRead2.OnNotifyUpdate = null;
            this.SignalRead2.OnParameterUpdate = null;
            this.SignalRead2.OnProcessAll = null;
            this.SignalRead2.OnRecordPositionChange = null;
            this.SignalRead2.OverlappingSamples = 0;
            this.SignalRead2.PostBufferSamples = 0;
            this.SignalRead2.RecordNumber = 0;
            this.SignalRead2.RecordPosition = ((long)(0));
            // 
            // SignalWrite1
            // 
            this.SignalWrite1.AuthorInfo = "Unknown";
            this.SignalWrite1.BandwidthL = 0D;
            this.SignalWrite1.BlockAssign = false;
            this.SignalWrite1.ChannelCount = 1;
            this.SignalWrite1.Complex = false;
            this.SignalWrite1.FileName = "bz.dat";
            this.SignalWrite1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.SignalWrite1.FloatPrecisionLock = false;
            this.SignalWrite1.ImFormat = null;
            this.SignalWrite1.Input = this.SignalInterpolator1;
            this.SignalWrite1.IsDouble = true;
            this.SignalWrite1.Length = 128;
            this.SignalWrite1.Name = "";
            this.SignalWrite1.OnAfterUpdate = null;
            this.SignalWrite1.OnBeforeUpdate = null;
            this.SignalWrite1.OnDisplayUpdate = null;
            this.SignalWrite1.OnGetInput = null;
            this.SignalWrite1.OnNotifyUpdate = null;
            this.SignalWrite1.OnParameterUpdate = null;
            this.SignalWrite1.RecordNumber = 0;
            this.SignalWrite1.ReFormat = null;
            // 
            // SignalInterpolator1
            // 
            this.SignalInterpolator1.BandwidthL = 0D;
            this.SignalInterpolator1.BlockAssign = false;
            this.SignalInterpolator1.ChannelCount = 1;
            this.SignalInterpolator1.Complex = false;
            this.SignalInterpolator1.Factor = 32;
            this.SignalInterpolator1.FilterDelay = 919D;
            this.SignalInterpolator1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.SignalInterpolator1.FloatPrecisionLock = false;
            this.SignalInterpolator1.Input = this.SignalDecimator1;
            this.SignalInterpolator1.IsDouble = true;
            this.SignalInterpolator1.Length = 128;
            this.SignalInterpolator1.Name = "";
            this.SignalInterpolator1.OnAfterUpdate = null;
            this.SignalInterpolator1.OnBeforeUpdate = null;
            this.SignalInterpolator1.OnDisplayUpdate = null;
            this.SignalInterpolator1.OnGetFilterTaps = null;
            this.SignalInterpolator1.OnGetInput = null;
            this.SignalInterpolator1.OnNotifyUpdate = null;
            this.SignalInterpolator1.OnParameterUpdate = null;
            // 
            // SignalDecimator1
            // 
            this.SignalDecimator1.BandwidthL = 0D;
            this.SignalDecimator1.BlockAssign = false;
            this.SignalDecimator1.ChannelCount = 1;
            this.SignalDecimator1.Complex = false;
            this.SignalDecimator1.EnvelopeFactor = 0;
            this.SignalDecimator1.Factor = 32;
            this.SignalDecimator1.FilterDelay = 28.71875D;
            this.SignalDecimator1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.SignalDecimator1.FloatPrecisionLock = false;
            this.SignalDecimator1.Input = this.SignalRead1;
            this.SignalDecimator1.IsDouble = true;
            this.SignalDecimator1.Length = 128;
            this.SignalDecimator1.Name = "";
            this.SignalDecimator1.OnAfterUpdate = null;
            this.SignalDecimator1.OnBeforeUpdate = null;
            this.SignalDecimator1.OnDisplayUpdate = null;
            this.SignalDecimator1.OnGetFilterTaps = null;
            this.SignalDecimator1.OnGetInput = null;
            this.SignalDecimator1.OnNotifyUpdate = null;
            this.SignalDecimator1.OnParameterUpdate = null;
            // 
            // SpectrumAnalyzer
            // 
            this.SpectrumAnalyzer.ArOrder = 100;
            this.SpectrumAnalyzer.Bands.TemplateIndex = -1;
            this.SpectrumAnalyzer.Bands.Templates = ((Dew.Signal.TStringStreamList)(resources.GetObject("resource.Templates1")));
            this.SpectrumAnalyzer.BlockAssign = false;
            this.SpectrumAnalyzer.Complex = false;
            this.SpectrumAnalyzer.DCDump = false;
            this.SpectrumAnalyzer.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.SpectrumAnalyzer.FloatPrecisionLock = false;
            this.SpectrumAnalyzer.Harmonics = 10;
            this.SpectrumAnalyzer.Input = this.SignalRead2;
            this.SpectrumAnalyzer.IsDouble = true;
            this.SpectrumAnalyzer.Length = 64;
            this.SpectrumAnalyzer.Logarithmic = true;
            this.SpectrumAnalyzer.LogBase = 0D;
            this.SpectrumAnalyzer.LogScale = 0D;
            this.SpectrumAnalyzer.LogSpan = Dew.Signal.TLogSpan.ls150;
            this.SpectrumAnalyzer.LogType = Dew.Signal.TLogType.ltRelative;
            this.SpectrumAnalyzer.MainlobeWidth = 8;
            this.SpectrumAnalyzer.Name = "";
            this.SpectrumAnalyzer.OnAfterAverage = null;
            this.SpectrumAnalyzer.OnAfterComplexSpectrum = null;
            this.SpectrumAnalyzer.OnAfterUpdate = null;
            this.SpectrumAnalyzer.OnBandsUpdate = null;
            this.SpectrumAnalyzer.OnBeforeAverage = null;
            this.SpectrumAnalyzer.OnBeforeSpectrumType = null;
            this.SpectrumAnalyzer.OnBeforeUpdate = null;
            this.SpectrumAnalyzer.OnDisplayUpdate = null;
            this.SpectrumAnalyzer.OnGetInput = null;
            this.SpectrumAnalyzer.OnNotifyUpdate = null;
            this.SpectrumAnalyzer.OnParameterUpdate = null;
            this.SpectrumAnalyzer.OnPeaksUpdate = null;
            this.SpectrumAnalyzer.Output = null;
            this.SpectrumAnalyzer.Peaks.HarmonicsCount = 10;
            this.SpectrumAnalyzer.Peaks.Interpolation.Method = Dew.Signal.TInterpolationMethod.imNone;
            this.SpectrumAnalyzer.Peaks.Interpolation.RecursiveHarmonics = Dew.Signal.TRecursiveHarmonics.rhNone;
            this.SpectrumAnalyzer.Peaks.LargestCount = 1;
            this.SpectrumAnalyzer.Report.AmplitudeFormat = null;
            this.SpectrumAnalyzer.Report.FrequencyFormat = null;
            this.SpectrumAnalyzer.Report.PhaseFormat = null;
            this.SpectrumAnalyzer.Report.UseTab = false;
            this.SpectrumAnalyzer.Rotation = 0;
            this.SpectrumAnalyzer.SidelobeAtt = 130D;
            this.SpectrumAnalyzer.SpectrumScale = 0D;
            this.SpectrumAnalyzer.Stats.Averaged = 0;
            this.SpectrumAnalyzer.Stats.Averages = 30;
            this.SpectrumAnalyzer.Stats.ExpDecay = 5;
            this.SpectrumAnalyzer.Window = Dew.Signal.TSignalWindowType.wtKaiser;
            this.SpectrumAnalyzer.ZeroPadding = 1;
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
            // SpectrumAnalyzerDialog
            // 
            this.SpectrumAnalyzerDialog.BlockAssign = false;
            this.SpectrumAnalyzerDialog.Docking = false;
            this.SpectrumAnalyzerDialog.FormCaption = null;
            this.SpectrumAnalyzerDialog.Name = null;
            this.SpectrumAnalyzerDialog.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.SpectrumAnalyzerDialog.ShowLive = false;
            this.SpectrumAnalyzerDialog.Source = this.SpectrumAnalyzer;
            this.SpectrumAnalyzerDialog.SourceListIndex = 0;
            // 
            // InterpolateDecimateForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(720, 597);
            this.Controls.Add(this.SpectrumChart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "InterpolateDecimateForm";
            this.Text = "InterpolateDecimateForm";
            this.Load += new System.EventHandler(this.InterpolateDecimateForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpectrumChart1)).EndInit();
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
