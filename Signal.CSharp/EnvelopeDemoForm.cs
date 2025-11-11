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
using Dew.Signal.Editors;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for EnvelopeDemoForm.
	/// </summary>
	public class EnvelopeDemoForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private SpectrumChart SpectrumChart1;
		private System.Windows.Forms.Splitter splitter1;
		private Steema.TeeChart.Styles.FastLine Series1;
		private Steema.TeeChart.Styles.FastLine Series2;
		private Dew.Signal.TSignalRead SignalRead1;
		private Dew.Signal.TSpectrumAnalyzer SpectrumAnalyzer1;
		private Dew.Signal.TSignalIncBuffer SignalIncBuffer1;
		private Dew.Signal.TSignalIncBuffer SignalIncBuffer2;
		private Dew.Signal.TSignalDecimator SignalDecimator1;
		private SignalChart SignalChart1;
		private Steema.TeeChart.Styles.Points MarkSeries1;
        private Button SpectrumChartButton;
        private Button SpectrumButton;
        private Steema.TeeChart.Editor ChartEditor;
        private SpectrumAnalyzerDialog SpectrumAnalyzerDialog;
		private System.ComponentModel.IContainer components;

		public EnvelopeDemoForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			SpectrumChart1.Spectrums.Add();
			SpectrumChart1.Spectrums[0].Input = SpectrumAnalyzer1;
			SpectrumChart1.Spectrums[0].Series = Series1;
			
			SignalChart1.Signals.Add();
			SignalChart1.Signals[0].Input = SignalIncBuffer2;
			SignalChart1.Signals[0].Series = Series2;

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

			AxisScaleTool tool = new AxisScaleTool(SpectrumChart1.Chart);
			tool.UpperMargin = 20;
			tool.LowerMargin = 5;
			tool.AxisScaleMode = AxisScaleMode.amAuto;
			tool.DataIsSpectrum = true;
			tool.Axis = SpectrumChart1.Axes.Left;
			SpectrumChart1.Tools.Add(tool);

            Series1.Color = Color.Navy;
            Series2.Color = Color.Navy;

            SignalRead1.FileName = Dew.Demo.Utils.SourcePath() + @"\Data\bz.sfs";
			SignalIncBuffer2.SuspendNotifyUpdate = true; //prevent chart updates for every call to Update
			SignalIncBuffer2.Factor = 13;  //increase the buffer by 13x, because SignalRead1.Length = 1024 and SignalRead1.RecordLength = 14000
			SignalIncBuffer1.Factor = 11;  //increase the buffer of the decimator output only by 11x,
			//because the first two blocks will contain FIR filter delay
			//in that way the 12th and 13th block will push out blocks 0 and 1
			//from the circular buffer
			while (SignalIncBuffer1.Pull() != TPipeState.pipeEnd) { //Pull is True until the end of file. (Until the last full frame)
				SignalIncBuffer2.Update(); //Copy data from SignalRead1 to SignalIncBuffer2
			}
			SpectrumAnalyzer1.ZeroPadding = 4;
			SpectrumAnalyzer1.Update(); //compute the spectrum and update SpectrumChart
			SignalIncBuffer2.UpdateNotify();  //update SignalChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnvelopeDemoForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SpectrumChartButton = new System.Windows.Forms.Button();
            this.SpectrumButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SignalChart1 = new Dew.Signal.Tee.SignalChart();
            this.Series2 = new Steema.TeeChart.Styles.FastLine();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SpectrumChart1 = new Dew.Signal.Tee.SpectrumChart();
            this.Series1 = new Steema.TeeChart.Styles.FastLine();
            this.MarkSeries1 = new Steema.TeeChart.Styles.Points();
            this.SignalRead1 = new Dew.Signal.TSignalRead(this.components);
            this.SpectrumAnalyzer1 = new Dew.Signal.TSpectrumAnalyzer(this.components);
            this.SignalIncBuffer1 = new Dew.Signal.TSignalIncBuffer(this.components);
            this.SignalDecimator1 = new Dew.Signal.TSignalDecimator(this.components);
            this.SignalIncBuffer2 = new Dew.Signal.TSignalIncBuffer(this.components);
            this.SpectrumAnalyzerDialog = new Dew.Signal.Editors.SpectrumAnalyzerDialog(this.components);
            this.ChartEditor = new Steema.TeeChart.Editor(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignalChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpectrumChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(656, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SpectrumChartButton);
            this.panel1.Controls.Add(this.SpectrumButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 520);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 37);
            this.panel1.TabIndex = 1;
            // 
            // SpectrumChartButton
            // 
            this.SpectrumChartButton.Location = new System.Drawing.Point(111, 6);
            this.SpectrumChartButton.Name = "SpectrumChartButton";
            this.SpectrumChartButton.Size = new System.Drawing.Size(102, 23);
            this.SpectrumChartButton.TabIndex = 1;
            this.SpectrumChartButton.Text = "Spectrum chart...";
            this.SpectrumChartButton.UseVisualStyleBackColor = true;
            this.SpectrumChartButton.Click += new System.EventHandler(this.SpectrumChartButton_Click);
            // 
            // SpectrumButton
            // 
            this.SpectrumButton.Location = new System.Drawing.Point(12, 6);
            this.SpectrumButton.Name = "SpectrumButton";
            this.SpectrumButton.Size = new System.Drawing.Size(75, 23);
            this.SpectrumButton.TabIndex = 0;
            this.SpectrumButton.Text = "Spectrum...";
            this.SpectrumButton.UseVisualStyleBackColor = true;
            this.SpectrumButton.Click += new System.EventHandler(this.SpectrumButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SignalChart1);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.SpectrumChart1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 424);
            this.panel2.TabIndex = 2;
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
            this.SignalChart1.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.SignalChart1.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.SignalChart1.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.SignalChart1.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.SignalChart1.Axes.Right.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.SignalChart1.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.SignalChart1.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
             
            this.SignalChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.SignalChart1.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
        "Original time signal"};
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
            this.SignalChart1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            // 
            // 
            // 
            this.SignalChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SignalChart1.Legend.Shadow.Brush.Solid = true;
            this.SignalChart1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
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
            this.SignalChart1.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            // 
            // 
            // 
            this.SignalChart1.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Legend.Title.Shadow.Brush.Solid = true;
            this.SignalChart1.Legend.Title.Shadow.Brush.Visible = true;
            this.SignalChart1.Legend.Visible = false;
            this.SignalChart1.Location = new System.Drawing.Point(0, 179);
            this.SignalChart1.Name = "SignalChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            this.SignalChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
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
            // 
            // 
            // 
            this.SignalChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Panel.Shadow.Brush.Solid = true;
            this.SignalChart1.Panel.Shadow.Brush.Visible = true;
            this.SignalChart1.Series.Add(this.Series2);
            this.SignalChart1.Size = new System.Drawing.Size(656, 245);
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.SignalChart1.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.SignalChart1.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.SignalChart1.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.SignalChart1.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.SignalChart1.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            // Series2
            // 
            this.Series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
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
            this.Series2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.Series2.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.Series2.Marks.TailParams.Margin = 0F;
            this.Series2.Marks.TailParams.PointerHeight = 8D;
            this.Series2.Marks.TailParams.PointerWidth = 8D;
            this.Series2.OriginalCursor = Steema.TeeChart.Drawing.Cursor.Current;
            this.Series2.Title = "fastLine1";
            this.Series2.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
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
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 176);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(656, 3);
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
            this.SpectrumChart1.Axes.Depth.Automatic = false;
            this.SpectrumChart1.Axes.Depth.AutomaticMaximum = false;
            this.SpectrumChart1.Axes.Depth.AutomaticMinimum = false;
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
            this.SpectrumChart1.Axes.Depth.Maximum = 0D;
            this.SpectrumChart1.Axes.Depth.Minimum = 0D;
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
            this.SpectrumChart1.Axes.DepthTop.Automatic = false;
            this.SpectrumChart1.Axes.DepthTop.AutomaticMaximum = false;
            this.SpectrumChart1.Axes.DepthTop.AutomaticMinimum = false;
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
            this.SpectrumChart1.Axes.DepthTop.Maximum = 0D;
            this.SpectrumChart1.Axes.DepthTop.Minimum = 0D;
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
            this.SpectrumChart1.Axes.Right.Automatic = false;
            this.SpectrumChart1.Axes.Right.AutomaticMaximum = false;
            this.SpectrumChart1.Axes.Right.AutomaticMinimum = false;
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
            this.SpectrumChart1.Axes.Right.Maximum = 0D;
            this.SpectrumChart1.Axes.Right.Minimum = 0D;
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
            this.SpectrumChart1.Axes.Top.Automatic = false;
            this.SpectrumChart1.Axes.Top.AutomaticMaximum = false;
            this.SpectrumChart1.Axes.Top.AutomaticMinimum = false;
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
            this.SpectrumChart1.Axes.Top.Maximum = 0D;
            this.SpectrumChart1.Axes.Top.Minimum = 0D;
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
        "Frequency spectrum of the envelope"};
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
            this.SpectrumChart1.Series.Add(this.Series1);
            this.SpectrumChart1.Series.Add(this.MarkSeries1);
            this.SpectrumChart1.Size = new System.Drawing.Size(656, 176);
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
            this.SpectrumChart1.Zoom.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SpectrumChart1.Zoom.Brush.Solid = true;
            this.SpectrumChart1.Zoom.Brush.Visible = false;
            this.SpectrumChart1.Zoom.FullRepaint = true;
            // 
            // 
            // 
            this.SpectrumChart1.Zoom.Pen.Visible = true;
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
            this.Series1.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.Series1.Marks.TailParams.Margin = 0F;
            this.Series1.Marks.TailParams.PointerHeight = 8D;
            this.Series1.Marks.TailParams.PointerWidth = 8D;
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
            // MarkSeries1
            // 
            this.MarkSeries1.Color = System.Drawing.Color.Red;
            this.MarkSeries1.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.MarkSeries1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.MarkSeries1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.MarkSeries1.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.MarkSeries1.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.MarkSeries1.Marks.TailParams.Margin = 0F;
            this.MarkSeries1.Marks.TailParams.PointerHeight = 8D;
            this.MarkSeries1.Marks.TailParams.PointerWidth = 8D;
            this.MarkSeries1.Marks.Transparent = true;
            this.MarkSeries1.Marks.Visible = true;
            this.MarkSeries1.OriginalCursor = Steema.TeeChart.Drawing.Cursor.Current;
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
            this.MarkSeries1.Title = "point1";
            this.MarkSeries1.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.MarkSeries1.XValues.DataMember = "X";
            this.MarkSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.MarkSeries1.YValues.DataMember = "Y";
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
            this.SpectrumAnalyzer1.Input = this.SignalIncBuffer1;
            this.SpectrumAnalyzer1.IsDouble = true;
            this.SpectrumAnalyzer1.LogBase = 0D;
            this.SpectrumAnalyzer1.LogScale = 0D;
            this.SpectrumAnalyzer1.Name = "";
            this.SpectrumAnalyzer1.Output = null;
            this.SpectrumAnalyzer1.Peaks.Interpolation.Method = Dew.Signal.TInterpolationMethod.imNone;
            this.SpectrumAnalyzer1.Peaks.Interpolation.RecursiveHarmonics = Dew.Signal.TRecursiveHarmonics.rhNone;
            this.SpectrumAnalyzer1.Report.AmplitudeFormat = null;
            this.SpectrumAnalyzer1.Report.FrequencyFormat = null;
            this.SpectrumAnalyzer1.Report.PhaseFormat = null;
            this.SpectrumAnalyzer1.Report.UseTab = false;
            this.SpectrumAnalyzer1.SpectrumScale = 0D;
            this.SpectrumAnalyzer1.Window = Dew.Signal.TSignalWindowType.wtHanning;
            // 
            // SignalIncBuffer1
            // 
            this.SignalIncBuffer1.BandwidthL = 0D;
            this.SignalIncBuffer1.BlockAssign = false;
            this.SignalIncBuffer1.Complex = false;
            this.SignalIncBuffer1.Factor = 11;
            this.SignalIncBuffer1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.SignalIncBuffer1.FloatPrecisionLock = false;
            this.SignalIncBuffer1.Input = this.SignalDecimator1;
            this.SignalIncBuffer1.IsDouble = true;
            this.SignalIncBuffer1.Length = 0;
            this.SignalIncBuffer1.Name = "";
            // 
            // SignalDecimator1
            // 
            this.SignalDecimator1.BandwidthL = 0D;
            this.SignalDecimator1.BlockAssign = false;
            this.SignalDecimator1.Complex = false;
            this.SignalDecimator1.EnvelopeFactor = 1;
            this.SignalDecimator1.Factor = 64;
            this.SignalDecimator1.FilterDelay = 28.859375D;
            this.SignalDecimator1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.SignalDecimator1.FloatPrecisionLock = false;
            this.SignalDecimator1.Input = this.SignalRead1;
            this.SignalDecimator1.IsDouble = true;
            this.SignalDecimator1.Name = "";
            // 
            // SignalIncBuffer2
            // 
            this.SignalIncBuffer2.BandwidthL = 0D;
            this.SignalIncBuffer2.BlockAssign = false;
            this.SignalIncBuffer2.Complex = false;
            this.SignalIncBuffer2.Factor = 13;
            this.SignalIncBuffer2.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.SignalIncBuffer2.FloatPrecisionLock = false;
            this.SignalIncBuffer2.Input = this.SignalRead1;
            this.SignalIncBuffer2.IsDouble = true;
            this.SignalIncBuffer2.Length = 0;
            this.SignalIncBuffer2.Name = "";
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
            this.ChartEditor.Chart = this.SpectrumChart1;
            this.ChartEditor.HighLightTabs = false;
            this.ChartEditor.Location = new System.Drawing.Point(0, 0);
            this.ChartEditor.Name = "ChartEditor";
            this.ChartEditor.Options = null;
            this.ChartEditor.TabIndex = 0;
            // 
            // EnvelopeDemoForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(656, 557);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "EnvelopeDemoForm";
            this.Text = "EnvelopeDemoForm";
            this.Load += new System.EventHandler(this.EnvelopeDemoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SignalChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpectrumChart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private void SpectrumButton_Click(object sender, EventArgs e)
        {
            SpectrumAnalyzerDialog.ExecuteModal();
        }

        private void SpectrumChartButton_Click(object sender, EventArgs e)
        {
            ChartEditor.ShowModal();
        }

        protected void Add(String s)
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void EnvelopeDemoForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("The strongest peak in the spectrum shows the "
            + "frequency of the envelope. That frequency is noticed "
            + "on the bottom chart when looking at the peaks of the "
            + "time signal only. The sampling frequency is reduced "
            + "by 64 times.");
        }

        private void SpectrumChart1_Click(object sender, EventArgs e)
        {

        }
	}
}
