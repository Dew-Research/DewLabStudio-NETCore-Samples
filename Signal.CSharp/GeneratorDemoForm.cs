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
using Dew.Signal.Editors;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for GeneratorDemoForm.
	/// </summary>
	public class GeneratorDemoForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private SpectrumChart SpectrumChart1;
		private System.Windows.Forms.Splitter splitter1;
        private Dew.Signal.TSpectrumAnalyzer SpectrumAnalyzer1;
		private Dew.Signal.Editors.SignalGeneratorDialog SignalGeneratorDialog1;
		private Steema.TeeChart.Styles.FastLine SignalSeries;
		private SignalChart SignalChart1;
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Styles.FastLine Series1;
		private Steema.TeeChart.Styles.Points MarkSeries1;
		private Dew.Signal.TSignalWrite SignalWrite1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Button SignalChartButton;
        private Button SpectrumChartButton;
        private Button SpectrumButton;
        private Steema.TeeChart.Editor SpectrumChartEditor;
        private Steema.TeeChart.Editor SignalChartEditor;
        private SpectrumAnalyzerDialog SpectrumAnalyzerDialog;
        private TSignalGenerator SignalGenerator1;
		private System.ComponentModel.IContainer components;

		public GeneratorDemoForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			SpectrumChart1.Spectrums.Add();
			SpectrumChart1.Spectrums[0].Input = SpectrumAnalyzer1;
			SpectrumChart1.Spectrums[0].Series = Series1;

			SpectrumMarkTool smt = new SpectrumMarkTool(SpectrumChart1.Chart);
			smt.CursorActive = false;
			smt.DoubleClickClear = true;
			smt.PeakFilterMode = false;
			smt.MarkMode = SpectrumMarkMode.mmSingle;
			smt.MarkType = SpectrumMarkType.mtAmpltPhase;
			smt.MarkSeries = MarkSeries1;
			smt.Series = Series1;
			smt.AmpltFormat = "0.0000";
			smt.PhaseFormat = "0.0000";
			smt.FreqFormat = "0.0000";
			smt.LabelHeaders = true;
			smt.PeakZoomBand = false;
			SpectrumChart1.Tools.Add(smt);

            SignalSeries.Color = Color.Navy;
            Series1.Color = Color.Navy;

			AxisScaleTool tool = new AxisScaleTool(SpectrumChart1.Chart);
			tool.UpperMargin = 20;
			tool.LowerMargin = 5;
			tool.AxisScaleMode = AxisScaleMode.amAuto;
			tool.DataIsSpectrum = true;
			tool.Axis = SpectrumChart1.Axes.Left;
			SpectrumChart1.Tools.Add(tool);


			SignalChart1.Signals.Add();
			SignalChart1.Signals[0].Input = SignalGenerator1;
			SignalChart1.Signals[0].Series = SignalSeries;

			SignalGenerator1.SamplingFrequency = 1024;
			SignalGenerator1.Length = 1024;
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
            Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(GeneratorDemoForm));
            Steema.TeeChart.Margins margins2 = new Steema.TeeChart.Margins();
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            SignalChartButton = new Button();
            SpectrumChartButton = new Button();
            SpectrumButton = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            SignalChart1 = new SignalChart();
            SignalSeries = new Steema.TeeChart.Styles.FastLine();
            splitter1 = new Splitter();
            SpectrumChart1 = new SpectrumChart();
            Series1 = new Steema.TeeChart.Styles.FastLine();
            MarkSeries1 = new Steema.TeeChart.Styles.Points();
            SpectrumAnalyzer1 = new TSpectrumAnalyzer(components);
            SignalGenerator1 = new TSignalGenerator(components);
            SignalGeneratorDialog1 = new SignalGeneratorDialog(components);
            SignalWrite1 = new TSignalWrite(components);
            saveFileDialog1 = new SaveFileDialog();
            SpectrumChartEditor = new Steema.TeeChart.Editor(components);
            SignalChartEditor = new Steema.TeeChart.Editor(components);
            SpectrumAnalyzerDialog = new SpectrumAnalyzerDialog(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((ISupportInitialize)SignalChart1).BeginInit();
            ((ISupportInitialize)SpectrumChart1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Top;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1166, 118);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            panel1.Controls.Add(SignalChartButton);
            panel1.Controls.Add(SpectrumChartButton);
            panel1.Controls.Add(SpectrumButton);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 850);
            panel1.Name = "panel1";
            panel1.Size = new Size(1166, 40);
            panel1.TabIndex = 1;
            // 
            // SignalChartButton
            // 
            SignalChartButton.Location = new Point(253, 7);
            SignalChartButton.Name = "SignalChartButton";
            SignalChartButton.Size = new Size(113, 29);
            SignalChartButton.TabIndex = 4;
            SignalChartButton.Text = "Signal chart";
            SignalChartButton.Click += SignalChartButton_Click;
            // 
            // SpectrumChartButton
            // 
            SpectrumChartButton.Location = new Point(120, 7);
            SpectrumChartButton.Name = "SpectrumChartButton";
            SpectrumChartButton.Size = new Size(113, 29);
            SpectrumChartButton.TabIndex = 3;
            SpectrumChartButton.Text = "Spectrum chart";
            SpectrumChartButton.Click += SpectrumChartButton_Click;
            // 
            // SpectrumButton
            // 
            SpectrumButton.Location = new Point(14, 7);
            SpectrumButton.Name = "SpectrumButton";
            SpectrumButton.Size = new Size(90, 29);
            SpectrumButton.TabIndex = 2;
            SpectrumButton.Text = "Spectrum";
            SpectrumButton.Click += SpectrumButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(554, 7);
            button2.Name = "button2";
            button2.Size = new Size(90, 29);
            button2.TabIndex = 1;
            button2.Text = "Save";
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(449, 7);
            button1.Name = "button1";
            button1.Size = new Size(90, 29);
            button1.TabIndex = 0;
            button1.Text = "Generator";
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(SignalChart1);
            panel2.Controls.Add(splitter1);
            panel2.Controls.Add(SpectrumChart1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(1166, 732);
            panel2.TabIndex = 2;
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
            SignalChart1.Axes.Bottom.Grid.DrawEvery = 1;
            SignalChart1.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Bottom.Labels.Brush.Color = Color.White;
            SignalChart1.Axes.Bottom.Labels.Brush.Solid = true;
            SignalChart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SignalChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            SignalChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            SignalChart1.Axes.Bottom.Labels.Font.Size = 9;
            SignalChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            SignalChart1.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            SignalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Bottom.Title.Brush.Color = Color.Silver;
            SignalChart1.Axes.Bottom.Title.Brush.Solid = true;
            SignalChart1.Axes.Bottom.Title.Brush.Visible = true;
            SignalChart1.Axes.Bottom.Title.Caption = "Time [s]";
            // 
            // 
            // 
            SignalChart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SignalChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            SignalChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            SignalChart1.Axes.Bottom.Title.Font.Size = 11;
            SignalChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            SignalChart1.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            SignalChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            SignalChart1.Axes.Bottom.Title.Lines = new string[]
    {
    "Time [s]"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Depth.Labels.Brush.Color = Color.White;
            SignalChart1.Axes.Depth.Labels.Brush.Solid = true;
            SignalChart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SignalChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            SignalChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            SignalChart1.Axes.Depth.Labels.Font.Size = 9;
            SignalChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            SignalChart1.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            SignalChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Depth.Title.Brush.Color = Color.Silver;
            SignalChart1.Axes.Depth.Title.Brush.Solid = true;
            SignalChart1.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SignalChart1.Axes.Depth.Title.Font.Brush.Solid = true;
            SignalChart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            SignalChart1.Axes.Depth.Title.Font.Size = 11;
            SignalChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            SignalChart1.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            SignalChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.DepthTop.Labels.Brush.Color = Color.White;
            SignalChart1.Axes.DepthTop.Labels.Brush.Solid = true;
            SignalChart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SignalChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            SignalChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            SignalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            SignalChart1.Axes.DepthTop.Labels.Font.Size = 9;
            SignalChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            SignalChart1.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            SignalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            SignalChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.DepthTop.Title.Brush.Color = Color.Silver;
            SignalChart1.Axes.DepthTop.Title.Brush.Solid = true;
            SignalChart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SignalChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            SignalChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            SignalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            SignalChart1.Axes.DepthTop.Title.Font.Size = 11;
            SignalChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            SignalChart1.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            SignalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            SignalChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Left.Labels.Brush.Color = Color.White;
            SignalChart1.Axes.Left.Labels.Brush.Solid = true;
            SignalChart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SignalChart1.Axes.Left.Labels.Font.Brush.Solid = true;
            SignalChart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            SignalChart1.Axes.Left.Labels.Font.Size = 9;
            SignalChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            SignalChart1.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            SignalChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Left.Title.Brush.Color = Color.Silver;
            SignalChart1.Axes.Left.Title.Brush.Solid = true;
            SignalChart1.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Axes.Left.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SignalChart1.Axes.Left.Title.Font.Brush.Solid = true;
            SignalChart1.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            SignalChart1.Axes.Left.Title.Font.Size = 11;
            SignalChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            SignalChart1.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            SignalChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Right.Labels.Brush.Color = Color.White;
            SignalChart1.Axes.Right.Labels.Brush.Solid = true;
            SignalChart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SignalChart1.Axes.Right.Labels.Font.Brush.Solid = true;
            SignalChart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            SignalChart1.Axes.Right.Labels.Font.Size = 9;
            SignalChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            SignalChart1.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            SignalChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Right.Title.Brush.Color = Color.Silver;
            SignalChart1.Axes.Right.Title.Brush.Solid = true;
            SignalChart1.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Axes.Right.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SignalChart1.Axes.Right.Title.Font.Brush.Solid = true;
            SignalChart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            SignalChart1.Axes.Right.Title.Font.Size = 11;
            SignalChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            SignalChart1.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            SignalChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Top.Labels.Brush.Color = Color.White;
            SignalChart1.Axes.Top.Labels.Brush.Solid = true;
            SignalChart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SignalChart1.Axes.Top.Labels.Font.Brush.Solid = true;
            SignalChart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            SignalChart1.Axes.Top.Labels.Font.Size = 9;
            SignalChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            SignalChart1.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            SignalChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Top.Title.Brush.Color = Color.Silver;
            SignalChart1.Axes.Top.Title.Brush.Solid = true;
            SignalChart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Axes.Top.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SignalChart1.Axes.Top.Title.Font.Brush.Solid = true;
            SignalChart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            SignalChart1.Axes.Top.Title.Font.Size = 11;
            SignalChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            SignalChart1.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            SignalChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            SignalChart1.Color = Color.FromArgb(192, 192, 192);
            SignalChart1.Dock = DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Footer.Brush.Color = Color.Silver;
            SignalChart1.Footer.Brush.Solid = true;
            SignalChart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Footer.Font.Brush.Color = Color.Red;
            SignalChart1.Footer.Font.Brush.Solid = true;
            SignalChart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Footer.Font.Shadow.Brush.Solid = true;
            SignalChart1.Footer.Font.Shadow.Brush.Visible = true;
            SignalChart1.Footer.Font.Size = 8;
            SignalChart1.Footer.Font.SizeFloat = 8F;
            SignalChart1.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Footer.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Footer.ImageBevel.Brush.Solid = true;
            SignalChart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Footer.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Footer.Shadow.Brush.Solid = true;
            SignalChart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Header.Brush.Color = Color.FromArgb(192, 192, 192);
            SignalChart1.Header.Brush.Solid = true;
            SignalChart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Header.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Header.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SignalChart1.Header.Font.Brush.Solid = true;
            SignalChart1.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Header.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Header.Font.Shadow.Brush.Solid = true;
            SignalChart1.Header.Font.Shadow.Brush.Visible = true;
            SignalChart1.Header.Font.Size = 12;
            SignalChart1.Header.Font.SizeFloat = 12F;
            SignalChart1.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Header.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Header.ImageBevel.Brush.Solid = true;
            SignalChart1.Header.ImageBevel.Brush.Visible = true;
            SignalChart1.Header.Lines = new string[]
    {
    "Signal"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Header.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            SignalChart1.Header.Shadow.Brush.Solid = true;
            SignalChart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Legend.Brush.Color = Color.White;
            SignalChart1.Legend.Brush.Solid = true;
            SignalChart1.Legend.Brush.Visible = true;
            SignalChart1.Legend.CheckBoxes = false;
            // 
            // 
            // 
            SignalChart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Legend.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SignalChart1.Legend.Font.Brush.Solid = true;
            SignalChart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Legend.Font.Shadow.Brush.Solid = true;
            SignalChart1.Legend.Font.Shadow.Brush.Visible = true;
            SignalChart1.Legend.Font.Size = 9;
            SignalChart1.Legend.Font.SizeFloat = 9F;
            SignalChart1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Legend.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Legend.ImageBevel.Brush.Solid = true;
            SignalChart1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Legend.Shadow.Brush.Color = Color.FromArgb(0, 0, 0);
            SignalChart1.Legend.Shadow.Brush.Solid = true;
            SignalChart1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Legend.Symbol.Shadow.Brush.Solid = true;
            SignalChart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Legend.Title.Brush.Color = Color.White;
            SignalChart1.Legend.Title.Brush.Solid = true;
            SignalChart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            SignalChart1.Legend.Title.Font.Brush.Color = Color.Black;
            SignalChart1.Legend.Title.Font.Brush.Solid = true;
            SignalChart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            SignalChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            SignalChart1.Legend.Title.Font.Size = 8;
            SignalChart1.Legend.Title.Font.SizeFloat = 8F;
            SignalChart1.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Legend.Title.ImageBevel.Brush.Solid = true;
            SignalChart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Legend.Title.Shadow.Brush.Solid = true;
            SignalChart1.Legend.Title.Shadow.Brush.Visible = true;
            SignalChart1.Legend.Visible = false;
            SignalChart1.Location = new Point(0, 270);
            SignalChart1.Name = "SignalChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            // 
            // 
            // 
            SignalChart1.Panel.Brush.Color = Color.FromArgb(192, 192, 192);
            SignalChart1.Panel.Brush.Solid = true;
            SignalChart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Panel.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Panel.ImageBevel.Brush.Solid = true;
            SignalChart1.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Panel.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Panel.Shadow.Brush.Solid = true;
            SignalChart1.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            SignalChart1.Printer.Margins = margins1;
            SignalChart1.Series.Add(SignalSeries);
            SignalChart1.Size = new Size(1166, 462);
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.SubFooter.Brush.Color = Color.Silver;
            SignalChart1.SubFooter.Brush.Solid = true;
            SignalChart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.SubFooter.Font.Brush.Color = Color.Red;
            SignalChart1.SubFooter.Font.Brush.Solid = true;
            SignalChart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.SubFooter.Font.Shadow.Brush.Solid = true;
            SignalChart1.SubFooter.Font.Shadow.Brush.Visible = true;
            SignalChart1.SubFooter.Font.Size = 8;
            SignalChart1.SubFooter.Font.SizeFloat = 8F;
            SignalChart1.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.SubFooter.ImageBevel.Brush.Solid = true;
            SignalChart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.SubFooter.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.SubFooter.Shadow.Brush.Solid = true;
            SignalChart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.SubHeader.Brush.Color = Color.FromArgb(192, 192, 192);
            SignalChart1.SubHeader.Brush.Solid = true;
            SignalChart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.SubHeader.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SignalChart1.SubHeader.Font.Brush.Solid = true;
            SignalChart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.SubHeader.Font.Shadow.Brush.Solid = true;
            SignalChart1.SubHeader.Font.Shadow.Brush.Visible = true;
            SignalChart1.SubHeader.Font.Size = 12;
            SignalChart1.SubHeader.Font.SizeFloat = 12F;
            SignalChart1.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.SubHeader.ImageBevel.Brush.Solid = true;
            SignalChart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.SubHeader.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            SignalChart1.SubHeader.Shadow.Brush.Solid = true;
            SignalChart1.SubHeader.Shadow.Brush.Visible = true;
            SignalChart1.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Walls.Back.Brush.Color = Color.Silver;
            SignalChart1.Walls.Back.Brush.Solid = true;
            SignalChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Walls.Back.ImageBevel.Brush.Solid = true;
            SignalChart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Walls.Back.Shadow.Brush.Solid = true;
            SignalChart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Walls.Bottom.Brush.Color = Color.White;
            SignalChart1.Walls.Bottom.Brush.Solid = true;
            SignalChart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            SignalChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Walls.Bottom.Shadow.Brush.Solid = true;
            SignalChart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Walls.Left.Brush.Color = Color.LightYellow;
            SignalChart1.Walls.Left.Brush.Solid = true;
            SignalChart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Walls.Left.ImageBevel.Brush.Solid = true;
            SignalChart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Walls.Left.Shadow.Brush.Solid = true;
            SignalChart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Walls.Right.Brush.Color = Color.LightYellow;
            SignalChart1.Walls.Right.Brush.Solid = true;
            SignalChart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Walls.Right.ImageBevel.Brush.Solid = true;
            SignalChart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Walls.Right.Shadow.Brush.Solid = true;
            SignalChart1.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Zoom.Animated = true;
            // 
            // 
            // 
            SignalChart1.Zoom.Brush.Color = Color.FromArgb(51, 173, 216, 230);
            // 
            // 
            // 
            SignalChart1.Zoom.Brush.Gradient.Transparency = 80;
            SignalChart1.Zoom.Brush.Solid = true;
            SignalChart1.Zoom.Brush.Visible = true;
            // 
            // SignalSeries
            // 
            // 
            // 
            // 
            SignalSeries.Brush.Color = Color.Empty;
            SignalSeries.Brush.Solid = true;
            SignalSeries.Brush.Visible = true;
            SignalSeries.Color = Color.FromArgb(68, 102, 163);
            SignalSeries.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalSeries.Legend.Brush.Color = Color.White;
            SignalSeries.Legend.Brush.Solid = true;
            SignalSeries.Legend.Brush.Visible = true;
            // 
            // 
            // 
            SignalSeries.Legend.Font.Bold = false;
            // 
            // 
            // 
            SignalSeries.Legend.Font.Brush.Color = Color.Black;
            SignalSeries.Legend.Font.Brush.Solid = true;
            SignalSeries.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalSeries.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalSeries.Legend.Font.Shadow.Brush.Solid = true;
            SignalSeries.Legend.Font.Shadow.Brush.Visible = true;
            SignalSeries.Legend.Font.Size = 8;
            SignalSeries.Legend.Font.SizeFloat = 8F;
            SignalSeries.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalSeries.Legend.ImageBevel.Brush.Color = Color.LightGray;
            SignalSeries.Legend.ImageBevel.Brush.Solid = true;
            SignalSeries.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalSeries.Legend.Shadow.Brush.Color = Color.DarkGray;
            SignalSeries.Legend.Shadow.Brush.Solid = true;
            SignalSeries.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalSeries.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            SignalSeries.Marks.Brush.Solid = true;
            SignalSeries.Marks.Brush.Visible = true;
            // 
            // 
            // 
            SignalSeries.Marks.Font.Bold = false;
            // 
            // 
            // 
            SignalSeries.Marks.Font.Brush.Color = Color.Black;
            SignalSeries.Marks.Font.Brush.Solid = true;
            SignalSeries.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalSeries.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalSeries.Marks.Font.Shadow.Brush.Solid = true;
            SignalSeries.Marks.Font.Shadow.Brush.Visible = true;
            SignalSeries.Marks.Font.Size = 8;
            SignalSeries.Marks.Font.SizeFloat = 8F;
            SignalSeries.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalSeries.Marks.ImageBevel.Brush.Color = Color.LightGray;
            SignalSeries.Marks.ImageBevel.Brush.Solid = true;
            SignalSeries.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalSeries.Marks.Shadow.Brush.Color = Color.Gray;
            SignalSeries.Marks.Shadow.Brush.Solid = true;
            SignalSeries.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalSeries.Marks.Symbol.Brush.Color = Color.White;
            SignalSeries.Marks.Symbol.Brush.Solid = true;
            SignalSeries.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalSeries.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            SignalSeries.Marks.Symbol.ImageBevel.Brush.Solid = true;
            SignalSeries.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalSeries.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            SignalSeries.Marks.Symbol.Shadow.Brush.Solid = true;
            SignalSeries.Marks.Symbol.Shadow.Brush.Visible = true;
            SignalSeries.Title = "fastLine1";
            SignalSeries.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            // 
            // 
            // 
            SignalSeries.XValues.DataMember = "X";
            SignalSeries.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            SignalSeries.XValues.Value = new double[]
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
            SignalSeries.YValues.DataMember = "Y";
            SignalSeries.YValues.Value = new double[]
    {
    189D,
    148D,
    207D,
    180D,
    270D,
    277D,
    196D,
    207D,
    286D,
    323D,
    212D,
    239D,
    290D,
    177D,
    227D,
    208D,
    197D,
    74D,
    107D,
    122D,
    174D,
    153D,
    239D,
    347D,
    466D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // splitter1
            // 
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 266);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(1166, 4);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
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
            SpectrumChart1.Axes.Bottom.MaximumOffset = 4;
            SpectrumChart1.Axes.Bottom.MinimumOffset = 4;
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
            SpectrumChart1.Axes.Left.MaximumOffset = 4;
            SpectrumChart1.Axes.Left.MinimumOffset = 4;
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
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.AxisPen.Visible = true;
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
            SpectrumChart1.Color = Color.FromArgb(192, 192, 192);
            SpectrumChart1.Dock = DockStyle.Top;
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
            SpectrumChart1.Location = new Point(0, 0);
            SpectrumChart1.Name = "SpectrumChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            // 
            // 
            // 
            SpectrumChart1.Panel.Brush.Color = Color.FromArgb(192, 192, 192);
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
            margins2.Bottom = 100;
            margins2.Left = 100;
            margins2.Right = 100;
            margins2.Top = 100;
            SpectrumChart1.Printer.Margins = margins2;
            SpectrumChart1.Series.Add(Series1);
            SpectrumChart1.Series.Add(MarkSeries1);
            SpectrumChart1.Size = new Size(1166, 266);
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
            SpectrumChart1.TabIndex = 0;
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
            SpectrumChart1.Zoom.Brush.Color = Color.FromArgb(51, 173, 216, 230);
            // 
            // 
            // 
            SpectrumChart1.Zoom.Brush.Gradient.Transparency = 80;
            SpectrumChart1.Zoom.Brush.Solid = true;
            SpectrumChart1.Zoom.Brush.Visible = true;
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
    658D,
    763D,
    810D,
    886D,
    848D,
    930D,
    908D,
    826D,
    846D,
    741D,
    851D,
    748D,
    797D,
    721D,
    798D,
    856D,
    830D,
    931D,
    954D,
    935D,
    839D,
    859D,
    767D,
    847D,
    738D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // MarkSeries1
            // 
            // 
            // 
            // 
            MarkSeries1.Brush.Color = Color.Empty;
            MarkSeries1.Brush.Solid = true;
            MarkSeries1.Brush.Visible = true;
            MarkSeries1.Color = Color.Red;
            MarkSeries1.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            MarkSeries1.Legend.Brush.Color = Color.White;
            MarkSeries1.Legend.Brush.Solid = true;
            MarkSeries1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            MarkSeries1.Legend.Font.Bold = false;
            // 
            // 
            // 
            MarkSeries1.Legend.Font.Brush.Color = Color.Black;
            MarkSeries1.Legend.Font.Brush.Solid = true;
            MarkSeries1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            MarkSeries1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            MarkSeries1.Legend.Font.Shadow.Brush.Solid = true;
            MarkSeries1.Legend.Font.Shadow.Brush.Visible = true;
            MarkSeries1.Legend.Font.Size = 8;
            MarkSeries1.Legend.Font.SizeFloat = 8F;
            MarkSeries1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            MarkSeries1.Legend.ImageBevel.Brush.Color = Color.LightGray;
            MarkSeries1.Legend.ImageBevel.Brush.Solid = true;
            MarkSeries1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            MarkSeries1.Legend.Shadow.Brush.Color = Color.DarkGray;
            MarkSeries1.Legend.Shadow.Brush.Solid = true;
            MarkSeries1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            MarkSeries1.Marks.Arrow.Visible = false;
            MarkSeries1.Marks.ArrowLength = 10;
            // 
            // 
            // 
            MarkSeries1.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            MarkSeries1.Marks.Brush.Solid = true;
            MarkSeries1.Marks.Brush.Visible = false;
            // 
            // 
            // 
            MarkSeries1.Marks.Font.Bold = false;
            // 
            // 
            // 
            MarkSeries1.Marks.Font.Brush.Color = Color.Black;
            MarkSeries1.Marks.Font.Brush.Solid = true;
            MarkSeries1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            MarkSeries1.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            MarkSeries1.Marks.Font.Shadow.Brush.Solid = true;
            MarkSeries1.Marks.Font.Shadow.Brush.Visible = true;
            MarkSeries1.Marks.Font.Size = 8;
            MarkSeries1.Marks.Font.SizeFloat = 8F;
            MarkSeries1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            MarkSeries1.Marks.ImageBevel.Brush.Color = Color.LightGray;
            MarkSeries1.Marks.ImageBevel.Brush.Solid = true;
            MarkSeries1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            MarkSeries1.Marks.Shadow.Brush.Color = Color.Gray;
            MarkSeries1.Marks.Shadow.Brush.Solid = true;
            MarkSeries1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            MarkSeries1.Marks.Symbol.Brush.Color = Color.White;
            MarkSeries1.Marks.Symbol.Brush.Solid = true;
            MarkSeries1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            MarkSeries1.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            MarkSeries1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            MarkSeries1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            MarkSeries1.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            MarkSeries1.Marks.Symbol.Shadow.Brush.Solid = true;
            MarkSeries1.Marks.Symbol.Shadow.Brush.Visible = true;
            MarkSeries1.Marks.Transparent = true;
            MarkSeries1.Marks.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            MarkSeries1.Pointer.Brush.Color = Color.Red;
            MarkSeries1.Pointer.Brush.Solid = true;
            MarkSeries1.Pointer.Brush.Visible = true;
            MarkSeries1.Pointer.HorizSize = 3;
            // 
            // 
            // 
            MarkSeries1.Pointer.Pen.Color = Color.FromArgb(254, 0, 0, 0);
            MarkSeries1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            MarkSeries1.Pointer.VertSize = 3;
            MarkSeries1.Title = "point1";
            // 
            // 
            // 
            MarkSeries1.XValues.DataMember = "X";
            MarkSeries1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            MarkSeries1.XValues.Value = new double[]
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
            MarkSeries1.YValues.DataMember = "Y";
            MarkSeries1.YValues.Value = new double[]
    {
    960D,
    992D,
    991D,
    975D,
    1002D,
    1038D,
    1052D,
    1049D,
    1035D,
    1004D,
    983D,
    949D,
    977D,
    1001D,
    970D,
    952D,
    975D,
    996D,
    1004D,
    1018D,
    1046D,
    1024D,
    1047D,
    1026D,
    1034D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // SpectrumAnalyzer1
            // 
            SpectrumAnalyzer1.ArOrder = 100;
            SpectrumAnalyzer1.Bands.TemplateIndex = -1;
            SpectrumAnalyzer1.Bands.TemplatesSerialization = "AAAAAA==";
            SpectrumAnalyzer1.Complex = false;
            SpectrumAnalyzer1.FloatPrecision = TMtxFloatPrecision.mvDouble;
            SpectrumAnalyzer1.FloatPrecisionLock = false;
            SpectrumAnalyzer1.Harmonics = 10;
            SpectrumAnalyzer1.Input = SignalGenerator1;
            SpectrumAnalyzer1.IsDouble = true;
            SpectrumAnalyzer1.Length = 64;
            SpectrumAnalyzer1.LogBase = 0D;
            SpectrumAnalyzer1.LogScale = 0D;
            SpectrumAnalyzer1.MainlobeWidth = 8;
            SpectrumAnalyzer1.Peaks.HarmonicsCount = 10;
            SpectrumAnalyzer1.Peaks.Interpolation.RecursiveHarmonics = TRecursiveHarmonics.rhNone;
            SpectrumAnalyzer1.Peaks.LargestCount = 1;
            SpectrumAnalyzer1.Peaks.LargestRatio = 1E+15D;
            SpectrumAnalyzer1.Peaks.NormalizedAmplt.PeakNumber = 1;
            SpectrumAnalyzer1.Peaks.NormalizedFreq.PeakNumber = 1;
            SpectrumAnalyzer1.Peaks.TraceMethod = TPeakTraceMethod.ptLargest;
            SpectrumAnalyzer1.Report.AmplitudeFormat = null;
            SpectrumAnalyzer1.Report.FrequencyFormat = null;
            SpectrumAnalyzer1.Report.PhaseFormat = null;
            SpectrumAnalyzer1.Report.UseTab = false;
            SpectrumAnalyzer1.Rotation = 0;
            SpectrumAnalyzer1.SidelobeAtt = 60D;
            SpectrumAnalyzer1.Stats.Averaged = 0;
            SpectrumAnalyzer1.Stats.Averages = 30;
            SpectrumAnalyzer1.Stats.ExpDecay = 5;
            SpectrumAnalyzer1.Window = TSignalWindowType.wtKaiser;
            SpectrumAnalyzer1.ZeroPadding = 1;
            // 
            // SignalGenerator1
            // 
            SignalGenerator1.ChannelCount = 1;
            SignalGenerator1.Complex = false;
            SignalGenerator1.DataSerialization = "AAAAAAAAQEEAAAAAAACAPwAAAAAAgB9EAAAAQQAAAAAAE3pHAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            SignalGenerator1.FloatPrecision = TMtxFloatPrecision.mvDouble;
            SignalGenerator1.FloatPrecisionLock = false;
            SignalGenerator1.IsDouble = true;
            SignalGenerator1.Length = 12;
            SignalGenerator1.SamplingFrequency = 128D;
            SignalGenerator1.Sounds.TemplateIndex = 1;
            SignalGenerator1.Sounds.TemplatesSerialization = resources.GetString("resource.TemplatesSerialization");
            SignalGenerator1.OnParameterUpdateEvent += SignalGenerator1_OnParameterUpdate;
            // 
            // SignalGeneratorDialog1
            // 
            SignalGeneratorDialog1.Docking = false;
            SignalGeneratorDialog1.FormCaption = null;
            SignalGeneratorDialog1.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            SignalGeneratorDialog1.ShowLive = true;
            SignalGeneratorDialog1.Source = SignalGenerator1;
            SignalGeneratorDialog1.SourceListIndex = 0;
            // 
            // SignalWrite1
            // 
            SignalWrite1.AuthorInfo = "Unknown";
            SignalWrite1.ChannelCount = 1;
            SignalWrite1.Complex = false;
            SignalWrite1.DataSerialization = "AAAAAAAAQEEAAAAAAACAPwAAAAAAgB9EAAAAQQAAAAAAE3pHAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            SignalWrite1.FloatPrecision = TMtxFloatPrecision.mvDouble;
            SignalWrite1.FloatPrecisionLock = false;
            SignalWrite1.ImFormat = null;
            SignalWrite1.Input = SignalGenerator1;
            SignalWrite1.IsDouble = true;
            SignalWrite1.Length = 12;
            SignalWrite1.RecordNumber = 0;
            SignalWrite1.ReFormat = null;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Title = "Save signal";
            // 
            // SpectrumChartEditor
            // 
            SpectrumChartEditor.AlwaysShowFuncSrc = false;
            SpectrumChartEditor.Chart = SpectrumChart1;
            SpectrumChartEditor.HighLightTabs = false;
            SpectrumChartEditor.Location = new Point(0, 0);
            SpectrumChartEditor.Name = "SpectrumChartEditor";
            SpectrumChartEditor.Options = null;
            SpectrumChartEditor.TabIndex = 0;
            // 
            // SignalChartEditor
            // 
            SignalChartEditor.AlwaysShowFuncSrc = false;
            SignalChartEditor.Chart = SignalChart1;
            SignalChartEditor.HighLightTabs = false;
            SignalChartEditor.Location = new Point(0, 0);
            SignalChartEditor.Name = "SignalChartEditor";
            SignalChartEditor.Options = null;
            SignalChartEditor.TabIndex = 0;
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
            // GeneratorDemoForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(1166, 890);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Name = "GeneratorDemoForm";
            Text = "GeneratorDemoForm";
            Load += GeneratorDemoForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((ISupportInitialize)SignalChart1).EndInit();
            ((ISupportInitialize)SpectrumChart1).EndInit();
            ResumeLayout(false);

        }
        #endregion

        private void button1_Click(object sender, System.EventArgs e) {
			SignalGeneratorDialog1.ExecuteModal();
		}

		private void SignalGenerator1_OnParameterUpdate(object Sender) {
			SignalGenerator1.Update();
			SpectrumAnalyzer1.Pull();
		}

		private void button2_Click(object sender, System.EventArgs e) {
			saveFileDialog1.Filter = FileSignal.SignalDialogFilter;
			if (saveFileDialog1.ShowDialog(this)==DialogResult.OK) {
				SignalWrite1.FileName = saveFileDialog1.FileName;
				int n = int.Parse(InputBox.Show("Define file length", "Samples count", "100000"));
				SignalGenerator1.Sounds.Template[0].Continuous = true;
				for (int i=0;i<(n/SignalGenerator1.Length);i++) SignalWrite1.Pull();
         SignalGenerator1.Update();
         SignalGenerator1.Data.Resize(n % SignalGenerator1.Length, true);
         SignalWrite1.Update();
         SignalWrite1.CloseFile();
         SignalGenerator1.Data.Length = 1024;
			}
		}

        protected void Add(String s) 
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void GeneratorDemoForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("Vectorized signal generator allows generatation of "
            + "very complex signals in real time and needs only a "
            + "small fraction of time required by the best function "
            + "evaluators. The generator uses postfix notation. (HP style). "
            + "It has a wide range of built-in functions and it is easy to "
            + "connect them to form processing chains. Press on the Generator "
            + "button to get to know the editor. For the start just select "
            + "different functions from the template menu.");
        }

        private void SpectrumButton_Click(object sender, EventArgs e)
        {
            SpectrumAnalyzerDialog.ExecuteModal();
        }

        private void SpectrumChartButton_Click(object sender, EventArgs e)
        {
            SpectrumChartEditor.ShowModal();
        }

        private void SignalChartButton_Click(object sender, EventArgs e)
        {
            SignalChartEditor.ShowModal();
        }
	}
}
