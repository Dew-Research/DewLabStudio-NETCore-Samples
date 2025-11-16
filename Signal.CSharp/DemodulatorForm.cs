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
using Dew.Signal.Editors;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for DemodulatorForm.
	/// </summary>
	public class DemodulatorForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private SpectrumChart SpectrumChart1;
		private System.Windows.Forms.Splitter splitter1;
		private SpectrumChart SpectrumChart2;
		private Steema.TeeChart.Styles.FastLine Series1;
		private Steema.TeeChart.Styles.Points MarkSeries1;
		private Steema.TeeChart.Styles.FastLine Series2;
		private FloatEdit freqEdit;
		private System.Windows.Forms.Label label1;
		private FloatEdit bwEdit;
		private System.Windows.Forms.Label label2;
		private Dew.Signal.TSignalRead SignalRead1;
		private Dew.Signal.TSignalDemodulator SignalDemodulator1;
		private Dew.Signal.TSpectrumAnalyzer SpectrumAnalyzer1;
		private Dew.Signal.TSpectrumAnalyzer SpectrumAnalyzer2;
		private Steema.TeeChart.Styles.Points MarkSeries2;
        private Button SpectrumChartButton;
        private Button SpectrumButton;
        private SpectrumAnalyzerDialog SpectrumAnalyzerDialog;
        private Steema.TeeChart.Editor ChartEditor;
		private System.ComponentModel.IContainer components;

		public DemodulatorForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

//            Series1.Color = Color.White;
//            Series2.Color = Color.White;

			SpectrumChart1.Spectrums.Add();
			SpectrumChart1.Spectrums[0].Input = SpectrumAnalyzer1;
			SpectrumChart1.Spectrums[0].Series = Series1;

			SpectrumChart2.Spectrums.Add();
			SpectrumChart2.Spectrums[0].Input = SpectrumAnalyzer2;
			SpectrumChart2.Spectrums[0].Series = Series2;

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

			smt = new SpectrumMarkTool(SpectrumChart2.Chart);
			smt.CursorActive = true;
			smt.DoubleClickClear = true;
			smt.PeakFilterMode = false;
			smt.MarkMode = SpectrumMarkMode.mmSingle;
			smt.MarkType = SpectrumMarkType.mtAmplt;
			smt.MarkSeries = MarkSeries2;
			smt.Series = Series2;
			smt.AmpltFormat = "0.00#";
			smt.PhaseFormat = "0.00#";
			smt.FreqFormat = "0.00#";
			smt.LabelHeaders = true;
			smt.PeakZoomBand = false;
			SpectrumChart2.Tools.Add(smt);

			AxisScaleTool tool = new AxisScaleTool(SpectrumChart1.Chart);
			tool.UpperMargin = 5;
			tool.LowerMargin = 5;
			tool.AxisScaleMode = AxisScaleMode.amAuto;
			tool.DataIsSpectrum = true;
			tool.Axis = SpectrumChart1.Axes.Left;
			SpectrumChart1.Tools.Add(tool);
            SpectrumChart1.Axes.Left.Automatic = true;

			tool = new AxisScaleTool(SpectrumChart2.Chart);
			tool.UpperMargin = 5;
			tool.LowerMargin = 5;
			tool.AxisScaleMode = AxisScaleMode.amAuto;
			tool.DataIsSpectrum = true;
			tool.Axis = SpectrumChart2.Axes.Left;
			SpectrumChart2.Tools.Add(tool);
            SpectrumChart2.Axes.Left.Automatic = true;

            SignalRead1.FileName = Dew.Demo.Utils.SourcePath() + @"\Data\bz.dat";
			bwEdit_TextChanged(this, EventArgs.Empty);
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(DemodulatorForm));
            Steema.TeeChart.Margins margins2 = new Steema.TeeChart.Margins();
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            SpectrumChartButton = new Button();
            SpectrumButton = new Button();
            freqEdit = new FloatEdit();
            label1 = new Label();
            bwEdit = new FloatEdit();
            label2 = new Label();
            panel2 = new Panel();
            SpectrumChart2 = new SpectrumChart();
            Series2 = new Steema.TeeChart.Styles.FastLine();
            MarkSeries2 = new Steema.TeeChart.Styles.Points();
            splitter1 = new Splitter();
            SpectrumChart1 = new SpectrumChart();
            Series1 = new Steema.TeeChart.Styles.FastLine();
            MarkSeries1 = new Steema.TeeChart.Styles.Points();
            SignalRead1 = new TSignalRead(components);
            SignalDemodulator1 = new TSignalDemodulator(components);
            SpectrumAnalyzer1 = new TSpectrumAnalyzer(components);
            SpectrumAnalyzer2 = new TSpectrumAnalyzer(components);
            SpectrumAnalyzerDialog = new SpectrumAnalyzerDialog(components);
            ChartEditor = new Steema.TeeChart.Editor(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((ISupportInitialize)SpectrumChart2).BeginInit();
            ((ISupportInitialize)SpectrumChart1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Top;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1137, 118);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            panel1.Controls.Add(SpectrumChartButton);
            panel1.Controls.Add(SpectrumButton);
            panel1.Controls.Add(freqEdit);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(bwEdit);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 746);
            panel1.Name = "panel1";
            panel1.Size = new Size(1137, 43);
            panel1.TabIndex = 1;
            // 
            // SpectrumChartButton
            // 
            SpectrumChartButton.AutoSize = true;
            SpectrumChartButton.Location = new Point(124, 7);
            SpectrumChartButton.Name = "SpectrumChartButton";
            SpectrumChartButton.Size = new Size(128, 31);
            SpectrumChartButton.TabIndex = 15;
            SpectrumChartButton.Text = "Spectrum chart...";
            SpectrumChartButton.UseVisualStyleBackColor = true;
            SpectrumChartButton.Click += SpectrumChartButton_Click;
            // 
            // SpectrumButton
            // 
            SpectrumButton.Location = new Point(14, 7);
            SpectrumButton.Name = "SpectrumButton";
            SpectrumButton.Size = new Size(90, 29);
            SpectrumButton.TabIndex = 14;
            SpectrumButton.Text = "Spectrum...";
            SpectrumButton.UseVisualStyleBackColor = true;
            SpectrumButton.Click += SpectrumButton_Click;
            // 
            // freqEdit
            // 
            freqEdit.Increment = "0.001";
            freqEdit.Location = new Point(398, 11);
            freqEdit.Name = "freqEdit";
            freqEdit.ReFormat = "0.00#";
            freqEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            freqEdit.Scientific = false;
            freqEdit.Size = new Size(87, 23);
            freqEdit.TabIndex = 12;
            freqEdit.Value = "0.25";
            freqEdit.TextChanged += bwEdit_TextChanged;
            // 
            // label1
            // 
            label1.Location = new Point(310, 11);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 11;
            label1.Text = "Frequency:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // bwEdit
            // 
            bwEdit.Increment = "0.001";
            bwEdit.Location = new Point(610, 11);
            bwEdit.Name = "bwEdit";
            bwEdit.ReFormat = "0.00#";
            bwEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            bwEdit.Size = new Size(86, 23);
            bwEdit.TabIndex = 13;
            bwEdit.Value = "0.125";
            bwEdit.TextChanged += bwEdit_TextChanged;
            // 
            // label2
            // 
            label2.Location = new Point(494, 11);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 10;
            label2.Text = "Bandwidth:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.Controls.Add(SpectrumChart2);
            panel2.Controls.Add(splitter1);
            panel2.Controls.Add(SpectrumChart1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(1137, 628);
            panel2.TabIndex = 2;
            panel2.SizeChanged += panel2_SizeChanged;
            // 
            // SpectrumChart2
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
            SpectrumChart2.Axes.Bottom.Grid.DrawEvery = 1;
            SpectrumChart2.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Bottom.Labels.Brush.Color = Color.White;
            SpectrumChart2.Axes.Bottom.Labels.Brush.Solid = true;
            SpectrumChart2.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart2.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart2.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart2.Axes.Bottom.Labels.Font.Brush.Solid = true;
            SpectrumChart2.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart2.Axes.Bottom.Labels.Font.Size = 9;
            SpectrumChart2.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            SpectrumChart2.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart2.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart2.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            SpectrumChart2.Axes.Bottom.Labels.Separation = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            SpectrumChart2.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            SpectrumChart2.Axes.Bottom.MaximumOffset = 4;
            SpectrumChart2.Axes.Bottom.MinimumOffset = 4;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Bottom.Title.Brush.Color = Color.Silver;
            SpectrumChart2.Axes.Bottom.Title.Brush.Solid = true;
            SpectrumChart2.Axes.Bottom.Title.Brush.Visible = true;
            SpectrumChart2.Axes.Bottom.Title.Caption = "Frequency [Hz]";
            // 
            // 
            // 
            SpectrumChart2.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart2.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart2.Axes.Bottom.Title.Font.Brush.Solid = true;
            SpectrumChart2.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart2.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart2.Axes.Bottom.Title.Font.Size = 11;
            SpectrumChart2.Axes.Bottom.Title.Font.SizeFloat = 11F;
            SpectrumChart2.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart2.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart2.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            SpectrumChart2.Axes.Bottom.Title.Lines = new string[]
    {
    "Frequency [Hz]"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            SpectrumChart2.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Depth.Labels.Brush.Color = Color.White;
            SpectrumChart2.Axes.Depth.Labels.Brush.Solid = true;
            SpectrumChart2.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart2.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart2.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart2.Axes.Depth.Labels.Font.Brush.Solid = true;
            SpectrumChart2.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart2.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart2.Axes.Depth.Labels.Font.Size = 9;
            SpectrumChart2.Axes.Depth.Labels.Font.SizeFloat = 9F;
            SpectrumChart2.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart2.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart2.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            SpectrumChart2.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Depth.Title.Brush.Color = Color.Silver;
            SpectrumChart2.Axes.Depth.Title.Brush.Solid = true;
            SpectrumChart2.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart2.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart2.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart2.Axes.Depth.Title.Font.Brush.Solid = true;
            SpectrumChart2.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart2.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart2.Axes.Depth.Title.Font.Size = 11;
            SpectrumChart2.Axes.Depth.Title.Font.SizeFloat = 11F;
            SpectrumChart2.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart2.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart2.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Axes.Depth.Title.Shadow.Brush.Solid = true;
            SpectrumChart2.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.DepthTop.Labels.Brush.Color = Color.White;
            SpectrumChart2.Axes.DepthTop.Labels.Brush.Solid = true;
            SpectrumChart2.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart2.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart2.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart2.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            SpectrumChart2.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart2.Axes.DepthTop.Labels.Font.Size = 9;
            SpectrumChart2.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            SpectrumChart2.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            SpectrumChart2.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.DepthTop.Title.Brush.Color = Color.Silver;
            SpectrumChart2.Axes.DepthTop.Title.Brush.Solid = true;
            SpectrumChart2.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart2.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart2.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart2.Axes.DepthTop.Title.Font.Brush.Solid = true;
            SpectrumChart2.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart2.Axes.DepthTop.Title.Font.Size = 11;
            SpectrumChart2.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            SpectrumChart2.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart2.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart2.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            SpectrumChart2.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Left.Labels.Brush.Color = Color.White;
            SpectrumChart2.Axes.Left.Labels.Brush.Solid = true;
            SpectrumChart2.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart2.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart2.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart2.Axes.Left.Labels.Font.Brush.Solid = true;
            SpectrumChart2.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart2.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart2.Axes.Left.Labels.Font.Size = 9;
            SpectrumChart2.Axes.Left.Labels.Font.SizeFloat = 9F;
            SpectrumChart2.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart2.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart2.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Axes.Left.Labels.Shadow.Brush.Solid = true;
            SpectrumChart2.Axes.Left.Labels.Shadow.Brush.Visible = true;
            SpectrumChart2.Axes.Left.MaximumOffset = 4;
            SpectrumChart2.Axes.Left.MinimumOffset = 4;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Left.Title.Brush.Color = Color.Silver;
            SpectrumChart2.Axes.Left.Title.Brush.Solid = true;
            SpectrumChart2.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart2.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart2.Axes.Left.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart2.Axes.Left.Title.Font.Brush.Solid = true;
            SpectrumChart2.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart2.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart2.Axes.Left.Title.Font.Size = 11;
            SpectrumChart2.Axes.Left.Title.Font.SizeFloat = 11F;
            SpectrumChart2.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart2.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart2.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Axes.Left.Title.Shadow.Brush.Solid = true;
            SpectrumChart2.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Right.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Right.Labels.Brush.Color = Color.White;
            SpectrumChart2.Axes.Right.Labels.Brush.Solid = true;
            SpectrumChart2.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart2.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart2.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart2.Axes.Right.Labels.Font.Brush.Solid = true;
            SpectrumChart2.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart2.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart2.Axes.Right.Labels.Font.Size = 9;
            SpectrumChart2.Axes.Right.Labels.Font.SizeFloat = 9F;
            SpectrumChart2.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart2.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart2.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Axes.Right.Labels.Shadow.Brush.Solid = true;
            SpectrumChart2.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Right.Title.Brush.Color = Color.Silver;
            SpectrumChart2.Axes.Right.Title.Brush.Solid = true;
            SpectrumChart2.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart2.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart2.Axes.Right.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart2.Axes.Right.Title.Font.Brush.Solid = true;
            SpectrumChart2.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart2.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart2.Axes.Right.Title.Font.Size = 11;
            SpectrumChart2.Axes.Right.Title.Font.SizeFloat = 11F;
            SpectrumChart2.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart2.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart2.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Axes.Right.Title.Shadow.Brush.Solid = true;
            SpectrumChart2.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Top.Labels.Brush.Color = Color.White;
            SpectrumChart2.Axes.Top.Labels.Brush.Solid = true;
            SpectrumChart2.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart2.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart2.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart2.Axes.Top.Labels.Font.Brush.Solid = true;
            SpectrumChart2.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart2.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart2.Axes.Top.Labels.Font.Size = 9;
            SpectrumChart2.Axes.Top.Labels.Font.SizeFloat = 9F;
            SpectrumChart2.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart2.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart2.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Axes.Top.Labels.Shadow.Brush.Solid = true;
            SpectrumChart2.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Top.Title.Brush.Color = Color.Silver;
            SpectrumChart2.Axes.Top.Title.Brush.Solid = true;
            SpectrumChart2.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart2.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart2.Axes.Top.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart2.Axes.Top.Title.Font.Brush.Solid = true;
            SpectrumChart2.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart2.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart2.Axes.Top.Title.Font.Size = 11;
            SpectrumChart2.Axes.Top.Title.Font.SizeFloat = 11F;
            SpectrumChart2.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart2.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart2.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Axes.Top.Title.Shadow.Brush.Solid = true;
            SpectrumChart2.Axes.Top.Title.Shadow.Brush.Visible = true;
            SpectrumChart2.Color = Color.FromArgb(192, 192, 192);
            SpectrumChart2.Dock = DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Footer.Brush.Color = Color.Silver;
            SpectrumChart2.Footer.Brush.Solid = true;
            SpectrumChart2.Footer.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart2.Footer.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart2.Footer.Font.Brush.Color = Color.Red;
            SpectrumChart2.Footer.Font.Brush.Solid = true;
            SpectrumChart2.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Footer.Font.Shadow.Brush.Solid = true;
            SpectrumChart2.Footer.Font.Shadow.Brush.Visible = true;
            SpectrumChart2.Footer.Font.Size = 8;
            SpectrumChart2.Footer.Font.SizeFloat = 8F;
            SpectrumChart2.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Footer.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart2.Footer.ImageBevel.Brush.Solid = true;
            SpectrumChart2.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Footer.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Footer.Shadow.Brush.Solid = true;
            SpectrumChart2.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Header.Brush.Color = Color.FromArgb(192, 192, 192);
            SpectrumChart2.Header.Brush.Solid = true;
            SpectrumChart2.Header.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart2.Header.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart2.Header.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart2.Header.Font.Brush.Solid = true;
            SpectrumChart2.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Header.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Header.Font.Shadow.Brush.Solid = true;
            SpectrumChart2.Header.Font.Shadow.Brush.Visible = true;
            SpectrumChart2.Header.Font.Size = 12;
            SpectrumChart2.Header.Font.SizeFloat = 12F;
            SpectrumChart2.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Header.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart2.Header.ImageBevel.Brush.Solid = true;
            SpectrumChart2.Header.ImageBevel.Brush.Visible = true;
            SpectrumChart2.Header.Lines = new string[]
    {
    "Original spectrum"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Header.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            SpectrumChart2.Header.Shadow.Brush.Solid = true;
            SpectrumChart2.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Legend.Brush.Color = Color.White;
            SpectrumChart2.Legend.Brush.Solid = true;
            SpectrumChart2.Legend.Brush.Visible = true;
            SpectrumChart2.Legend.CheckBoxes = false;
            // 
            // 
            // 
            SpectrumChart2.Legend.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart2.Legend.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart2.Legend.Font.Brush.Solid = true;
            SpectrumChart2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Legend.Font.Shadow.Brush.Solid = true;
            SpectrumChart2.Legend.Font.Shadow.Brush.Visible = true;
            SpectrumChart2.Legend.Font.Size = 9;
            SpectrumChart2.Legend.Font.SizeFloat = 9F;
            SpectrumChart2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Legend.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart2.Legend.ImageBevel.Brush.Solid = true;
            SpectrumChart2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Legend.Shadow.Brush.Color = Color.FromArgb(0, 0, 0);
            SpectrumChart2.Legend.Shadow.Brush.Solid = true;
            SpectrumChart2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Legend.Symbol.Shadow.Brush.Solid = true;
            SpectrumChart2.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Legend.Title.Brush.Color = Color.White;
            SpectrumChart2.Legend.Title.Brush.Solid = true;
            SpectrumChart2.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart2.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            SpectrumChart2.Legend.Title.Font.Brush.Color = Color.Black;
            SpectrumChart2.Legend.Title.Font.Brush.Solid = true;
            SpectrumChart2.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Legend.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart2.Legend.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart2.Legend.Title.Font.Size = 8;
            SpectrumChart2.Legend.Title.Font.SizeFloat = 8F;
            SpectrumChart2.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart2.Legend.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart2.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Legend.Title.Shadow.Brush.Solid = true;
            SpectrumChart2.Legend.Title.Shadow.Brush.Visible = true;
            SpectrumChart2.Legend.Visible = false;
            SpectrumChart2.Location = new Point(0, 201);
            SpectrumChart2.Name = "SpectrumChart2";
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            // 
            // 
            // 
            SpectrumChart2.Panel.Brush.Color = Color.FromArgb(192, 192, 192);
            SpectrumChart2.Panel.Brush.Solid = true;
            SpectrumChart2.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Panel.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart2.Panel.ImageBevel.Brush.Solid = true;
            SpectrumChart2.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Panel.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Panel.Shadow.Brush.Solid = true;
            SpectrumChart2.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            SpectrumChart2.Printer.Margins = margins1;
            SpectrumChart2.Series.Add(Series2);
            SpectrumChart2.Series.Add(MarkSeries2);
            SpectrumChart2.Size = new Size(1137, 427);
            SpectrumChart2.SpectrumPart = SpectrumPart.sppAmplt;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.SubFooter.Brush.Color = Color.Silver;
            SpectrumChart2.SubFooter.Brush.Solid = true;
            SpectrumChart2.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart2.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart2.SubFooter.Font.Brush.Color = Color.Red;
            SpectrumChart2.SubFooter.Font.Brush.Solid = true;
            SpectrumChart2.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.SubFooter.Font.Shadow.Brush.Solid = true;
            SpectrumChart2.SubFooter.Font.Shadow.Brush.Visible = true;
            SpectrumChart2.SubFooter.Font.Size = 8;
            SpectrumChart2.SubFooter.Font.SizeFloat = 8F;
            SpectrumChart2.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart2.SubFooter.ImageBevel.Brush.Solid = true;
            SpectrumChart2.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.SubFooter.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.SubFooter.Shadow.Brush.Solid = true;
            SpectrumChart2.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.SubHeader.Brush.Color = Color.FromArgb(192, 192, 192);
            SpectrumChart2.SubHeader.Brush.Solid = true;
            SpectrumChart2.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart2.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart2.SubHeader.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart2.SubHeader.Font.Brush.Solid = true;
            SpectrumChart2.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.SubHeader.Font.Shadow.Brush.Solid = true;
            SpectrumChart2.SubHeader.Font.Shadow.Brush.Visible = true;
            SpectrumChart2.SubHeader.Font.Size = 12;
            SpectrumChart2.SubHeader.Font.SizeFloat = 12F;
            SpectrumChart2.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart2.SubHeader.ImageBevel.Brush.Solid = true;
            SpectrumChart2.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.SubHeader.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            SpectrumChart2.SubHeader.Shadow.Brush.Solid = true;
            SpectrumChart2.SubHeader.Shadow.Brush.Visible = true;
            SpectrumChart2.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Walls.Back.Brush.Color = Color.Silver;
            SpectrumChart2.Walls.Back.Brush.Solid = true;
            SpectrumChart2.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart2.Walls.Back.ImageBevel.Brush.Solid = true;
            SpectrumChart2.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Walls.Back.Shadow.Brush.Solid = true;
            SpectrumChart2.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Walls.Bottom.Brush.Color = Color.White;
            SpectrumChart2.Walls.Bottom.Brush.Solid = true;
            SpectrumChart2.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart2.Walls.Bottom.ImageBevel.Brush.Solid = true;
            SpectrumChart2.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Walls.Bottom.Shadow.Brush.Solid = true;
            SpectrumChart2.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Walls.Left.Brush.Color = Color.LightYellow;
            SpectrumChart2.Walls.Left.Brush.Solid = true;
            SpectrumChart2.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart2.Walls.Left.ImageBevel.Brush.Solid = true;
            SpectrumChart2.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Walls.Left.Shadow.Brush.Solid = true;
            SpectrumChart2.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Walls.Right.Brush.Color = Color.LightYellow;
            SpectrumChart2.Walls.Right.Brush.Solid = true;
            SpectrumChart2.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart2.Walls.Right.ImageBevel.Brush.Solid = true;
            SpectrumChart2.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart2.Walls.Right.Shadow.Brush.Solid = true;
            SpectrumChart2.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart2.Zoom.Animated = true;
            // 
            // 
            // 
            SpectrumChart2.Zoom.Brush.Color = Color.LightBlue;
            SpectrumChart2.Zoom.Brush.Solid = true;
            SpectrumChart2.Zoom.Brush.Visible = false;
            // 
            // 
            // 
            SpectrumChart2.Zoom.Pen.Visible = true;
            // 
            // Series2
            // 
            // 
            // 
            // 
            Series2.Brush.Color = Color.Empty;
            Series2.Brush.Solid = true;
            Series2.Brush.Visible = true;
            Series2.Color = Color.FromArgb(68, 102, 163);
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
            Series2.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
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
            Series2.Title = "fastLine1";
            Series2.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
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
    332D,
    398D,
    397D,
    421D,
    298D,
    253D,
    312D,
    292D,
    207D,
    148D,
    98D,
    35D,
    49D,
    3D,
    65D,
    120D,
    238D,
    133D,
    227D,
    247D,
    242D,
    132D,
    83D,
    178D,
    195D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // MarkSeries2
            // 
            // 
            // 
            // 
            MarkSeries2.Brush.Color = Color.Empty;
            MarkSeries2.Brush.Solid = true;
            MarkSeries2.Brush.Visible = true;
            MarkSeries2.Color = Color.Orange;
            MarkSeries2.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            MarkSeries2.Legend.Brush.Color = Color.White;
            MarkSeries2.Legend.Brush.Solid = true;
            MarkSeries2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            MarkSeries2.Legend.Font.Bold = false;
            // 
            // 
            // 
            MarkSeries2.Legend.Font.Brush.Color = Color.Black;
            MarkSeries2.Legend.Font.Brush.Solid = true;
            MarkSeries2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            MarkSeries2.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            MarkSeries2.Legend.Font.Shadow.Brush.Solid = true;
            MarkSeries2.Legend.Font.Shadow.Brush.Visible = true;
            MarkSeries2.Legend.Font.Size = 8;
            MarkSeries2.Legend.Font.SizeFloat = 8F;
            MarkSeries2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            MarkSeries2.Legend.ImageBevel.Brush.Color = Color.LightGray;
            MarkSeries2.Legend.ImageBevel.Brush.Solid = true;
            MarkSeries2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            MarkSeries2.Legend.Shadow.Brush.Color = Color.DarkGray;
            MarkSeries2.Legend.Shadow.Brush.Solid = true;
            MarkSeries2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            MarkSeries2.Marks.Arrow.Visible = false;
            MarkSeries2.Marks.ArrowLength = 10;
            // 
            // 
            // 
            MarkSeries2.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            MarkSeries2.Marks.Brush.Solid = true;
            MarkSeries2.Marks.Brush.Visible = false;
            // 
            // 
            // 
            MarkSeries2.Marks.Font.Bold = false;
            // 
            // 
            // 
            MarkSeries2.Marks.Font.Brush.Color = Color.Black;
            MarkSeries2.Marks.Font.Brush.Solid = true;
            MarkSeries2.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            MarkSeries2.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            MarkSeries2.Marks.Font.Shadow.Brush.Solid = true;
            MarkSeries2.Marks.Font.Shadow.Brush.Visible = true;
            MarkSeries2.Marks.Font.Size = 8;
            MarkSeries2.Marks.Font.SizeFloat = 8F;
            MarkSeries2.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            MarkSeries2.Marks.ImageBevel.Brush.Color = Color.LightGray;
            MarkSeries2.Marks.ImageBevel.Brush.Solid = true;
            MarkSeries2.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            MarkSeries2.Marks.Shadow.Brush.Color = Color.Gray;
            MarkSeries2.Marks.Shadow.Brush.Solid = true;
            MarkSeries2.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            MarkSeries2.Marks.Symbol.Brush.Color = Color.White;
            MarkSeries2.Marks.Symbol.Brush.Solid = true;
            MarkSeries2.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            MarkSeries2.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            MarkSeries2.Marks.Symbol.ImageBevel.Brush.Solid = true;
            MarkSeries2.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            MarkSeries2.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            MarkSeries2.Marks.Symbol.Shadow.Brush.Solid = true;
            MarkSeries2.Marks.Symbol.Shadow.Brush.Visible = true;
            MarkSeries2.Marks.Transparent = true;
            MarkSeries2.Marks.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            MarkSeries2.Pointer.Brush.Color = Color.Orange;
            MarkSeries2.Pointer.Brush.Solid = true;
            MarkSeries2.Pointer.Brush.Visible = true;
            MarkSeries2.Pointer.HorizSize = 3;
            // 
            // 
            // 
            MarkSeries2.Pointer.Pen.Color = Color.FromArgb(254, 0, 0, 0);
            MarkSeries2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            MarkSeries2.Pointer.VertSize = 3;
            MarkSeries2.Title = "point1";
            // 
            // 
            // 
            MarkSeries2.XValues.DataMember = "X";
            MarkSeries2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            MarkSeries2.XValues.Value = new double[]
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
            MarkSeries2.YValues.DataMember = "Y";
            MarkSeries2.YValues.Value = new double[]
    {
    53D,
    40D,
    14D,
    33D,
    24D,
    51D,
    27D,
    49D,
    97D,
    138D,
    179D,
    224D,
    194D,
    195D,
    215D,
    237D,
    241D,
    246D,
    208D,
    195D,
    231D,
    283D,
    315D,
    339D,
    368D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            splitter1.Location = new Point(0, 197);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(1137, 4);
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
            SpectrumChart1.Axes.Right.Visible = false;
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
    "Zoomed spectrum"
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
            SpectrumChart1.Size = new Size(1137, 197);
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
            SpectrumChart1.Zoom.Brush.Color = Color.LightBlue;
            SpectrumChart1.Zoom.Brush.Solid = true;
            SpectrumChart1.Zoom.Brush.Visible = false;
            SpectrumChart1.Zoom.History = true;
            // 
            // 
            // 
            SpectrumChart1.Zoom.Pen.Visible = true;
            SpectrumChart1.Click += SpectrumChart1_Click;
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
    29D,
    134D,
    256D,
    318D,
    371D,
    355D,
    274D,
    261D,
    330D,
    372D,
    276D,
    188D,
    201D,
    164D,
    184D,
    306D,
    227D,
    119D,
    79D,
    4D,
    75D,
    154D,
    268D,
    370D,
    281D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            MarkSeries1.Color = Color.Orange;
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
            MarkSeries1.Pointer.Brush.Color = Color.Orange;
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
    176D,
    170D,
    201D,
    242D,
    245D,
    205D,
    176D,
    147D,
    115D,
    149D,
    144D,
    167D,
    156D,
    154D,
    121D,
    147D,
    175D,
    141D,
    166D,
    211D,
    218D,
    224D,
    184D,
    209D,
    244D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            SignalRead1.SamplingFrequency = 4666.66666666667D;
            // 
            // SignalDemodulator1
            // 
            SignalDemodulator1.AudioSignal = false;
            SignalDemodulator1.ChannelCount = 1;
            SignalDemodulator1.Complex = false;
            SignalDemodulator1.DataSerialization = "AAAAAAAAQEEAAAAAAACAPwAAAAAAgB9EAAAAQQAAAAAAE3pHAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            SignalDemodulator1.FloatPrecision = TMtxFloatPrecision.mvDouble;
            SignalDemodulator1.FloatPrecisionLock = false;
            SignalDemodulator1.Input = SignalRead1;
            SignalDemodulator1.IsDouble = true;
            SignalDemodulator1.Length = 12;
            SignalDemodulator1.Ripple = 0.0001D;
            SignalDemodulator1.SubBandFrequency = 0.25D;
            SignalDemodulator1.SubBandWidth = 0.125D;
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
            SpectrumAnalyzer1.Input = SignalDemodulator1;
            SpectrumAnalyzer1.IsDouble = true;
            SpectrumAnalyzer1.Length = 64;
            SpectrumAnalyzer1.LogBase = 0D;
            SpectrumAnalyzer1.LogScale = 0D;
            SpectrumAnalyzer1.MainlobeWidth = 8;
            SpectrumAnalyzer1.Peaks.HarmonicsCount = 10;
            SpectrumAnalyzer1.Peaks.Interpolation.Method = TInterpolationMethod.imNone;
            SpectrumAnalyzer1.Peaks.Interpolation.RecursiveHarmonics = TRecursiveHarmonics.rhNone;
            SpectrumAnalyzer1.Peaks.LargestCount = 1;
            SpectrumAnalyzer1.Peaks.LargestRatio = 1E+15D;
            SpectrumAnalyzer1.Peaks.NormalizedAmplt.PeakNumber = 1;
            SpectrumAnalyzer1.Peaks.NormalizedFreq.PeakNumber = 1;
            SpectrumAnalyzer1.Report.AmplitudeFormat = null;
            SpectrumAnalyzer1.Report.FrequencyFormat = null;
            SpectrumAnalyzer1.Report.PhaseFormat = null;
            SpectrumAnalyzer1.Report.UseTab = false;
            SpectrumAnalyzer1.Rotation = 0;
            SpectrumAnalyzer1.SamplingFrequency = 1024D;
            SpectrumAnalyzer1.Stats.Averaged = 0;
            SpectrumAnalyzer1.Stats.Averages = 30;
            SpectrumAnalyzer1.Stats.ExpDecay = 5;
            SpectrumAnalyzer1.Window = TSignalWindowType.wtHanning;
            SpectrumAnalyzer1.ZeroPadding = 4;
            // 
            // SpectrumAnalyzer2
            // 
            SpectrumAnalyzer2.ArOrder = 100;
            SpectrumAnalyzer2.Bands.TemplateIndex = -1;
            SpectrumAnalyzer2.Bands.TemplatesSerialization = "AAAAAA==";
            SpectrumAnalyzer2.Complex = false;
            SpectrumAnalyzer2.FloatPrecision = TMtxFloatPrecision.mvDouble;
            SpectrumAnalyzer2.FloatPrecisionLock = false;
            SpectrumAnalyzer2.Harmonics = 10;
            SpectrumAnalyzer2.Input = SignalRead1;
            SpectrumAnalyzer2.IsDouble = true;
            SpectrumAnalyzer2.Length = 64;
            SpectrumAnalyzer2.LogBase = 0D;
            SpectrumAnalyzer2.LogScale = 0D;
            SpectrumAnalyzer2.MainlobeWidth = 8;
            SpectrumAnalyzer2.Peaks.HarmonicsCount = 10;
            SpectrumAnalyzer2.Peaks.Interpolation.Method = TInterpolationMethod.imNone;
            SpectrumAnalyzer2.Peaks.Interpolation.RecursiveHarmonics = TRecursiveHarmonics.rhNone;
            SpectrumAnalyzer2.Peaks.LargestCount = 1;
            SpectrumAnalyzer2.Peaks.LargestRatio = 1E+15D;
            SpectrumAnalyzer2.Peaks.NormalizedAmplt.PeakNumber = 1;
            SpectrumAnalyzer2.Peaks.NormalizedFreq.PeakNumber = 1;
            SpectrumAnalyzer2.Report.AmplitudeFormat = null;
            SpectrumAnalyzer2.Report.FrequencyFormat = null;
            SpectrumAnalyzer2.Report.PhaseFormat = null;
            SpectrumAnalyzer2.Report.UseTab = false;
            SpectrumAnalyzer2.Rotation = 0;
            SpectrumAnalyzer2.SamplingFrequency = 1024D;
            SpectrumAnalyzer2.Stats.Averaged = 0;
            SpectrumAnalyzer2.Stats.Averages = 30;
            SpectrumAnalyzer2.Stats.ExpDecay = 5;
            SpectrumAnalyzer2.Window = TSignalWindowType.wtHanning;
            SpectrumAnalyzer2.ZeroPadding = 4;
            // 
            // SpectrumAnalyzerDialog
            // 
            SpectrumAnalyzerDialog.Docking = false;
            SpectrumAnalyzerDialog.FormCaption = null;
            SpectrumAnalyzerDialog.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            SpectrumAnalyzerDialog.ShowLive = false;
            SpectrumAnalyzerDialog.Source = SpectrumAnalyzer2;
            SpectrumAnalyzerDialog.SourceListIndex = 0;
            // 
            // ChartEditor
            // 
            ChartEditor.AlwaysShowFuncSrc = false;
            ChartEditor.Chart = SpectrumChart2;
            ChartEditor.HighLightTabs = false;
            ChartEditor.Location = new Point(0, 0);
            ChartEditor.Name = "ChartEditor";
            ChartEditor.Options = null;
            ChartEditor.TabIndex = 0;
            // 
            // DemodulatorForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(1137, 789);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Name = "DemodulatorForm";
            Text = "DemodulatorForm";
            Load += DemodulatorForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((ISupportInitialize)SpectrumChart2).EndInit();
            ((ISupportInitialize)SpectrumChart1).EndInit();
            ResumeLayout(false);

        }
        #endregion

        private void bwEdit_TextChanged(object sender, System.EventArgs e) {
			SignalDemodulator1.SubBandWidth = bwEdit.Position; // If this is not executed - everything is O.K.
			SignalDemodulator1.SubBandFrequency = freqEdit.Position;
			SignalRead1.RecordPosition = 0;
			SpectrumAnalyzer1.Pull();
			SpectrumAnalyzer1.Pull();
			SpectrumAnalyzer2.Update();
		}

		private void panel2_SizeChanged(object sender, System.EventArgs e) {
			SpectrumChart1.Height = panel2.Height / 2;
		}

        protected void Add(String s)
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void DemodulatorForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("TSignalDemodulator component moves the selected bandwidth down to 0Hz. "
            + "The component features multi-rate, multi-stage decimation which "
            + "allows demodulation of very narrow frequency bands (less then "
            + "0.01% of original bandwidth is not a problem). In the example "
            + "below you can change the Frequency and Bandwidth parameters. "
            + "Bandwidth change will have effect only when the change made will "
            + "result in sampling frequency reduction/increase by 2x. Both "
            + "frequency and bandwidth are defined in radians and must range "
            + "between 0 and 0.5 and frequency + bandwidth may not be bigger "
            + "then 0.5. The component also allows you to sample with sampling "
            + "frequency of 44.1Khz directly from the sound card and have a real "
            + "time frequency spectrum display of bandwidth between 20 and 20.1 Khz"
            + "with frequency resolution of 1 mHz (for example).");
        }

        private void SpectrumButton_Click(object sender, EventArgs e)
        {
            SpectrumAnalyzerDialog.ExecuteModal();
        }

        private void SpectrumChartButton_Click(object sender, EventArgs e)
        {
            ChartEditor.ShowModal();
        }

        private void SpectrumChart1_Click(object sender, EventArgs e)
        {

        }
	}
}
