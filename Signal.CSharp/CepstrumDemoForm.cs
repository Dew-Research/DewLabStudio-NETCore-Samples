using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Dew.Math;
using Dew.Signal;
using Dew.Signal.Units;
using Dew.Signal.Tee;
using Dew.Signal.Editors;
using Dew.Demo;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for CepstrumDemoForm.
	/// </summary>
	public class CepstrumDemoForm : System.Windows.Forms.Form
	{

		private TVec data;

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private Dew.Signal.TSignal Signal1;
		private Dew.Signal.TSignalRead SignalRead1;
		private Dew.Signal.TSpectrumAnalyzer SpectrumAnalyzer1;
		private System.Windows.Forms.ComboBox cepstrumComboBox;
		private System.Windows.Forms.Splitter splitter1;
        private SpectrumChart SpectrumChart1;
		private Steema.TeeChart.Styles.FastLine SpectrumSeries;
        private Steema.TeeChart.Styles.Points SpectrumMarks;
        private Button CepstrumChartButton;
        private Button SpectrumChartButton;
        private Button button1;
        private Label label1;
        private Steema.TeeChart.Editor ChartEditor;
        private SpectrumAnalyzerDialog SpectrumAnalyzerDialog;
        private SignalChart signalChart1;
        private Steema.TeeChart.Styles.FastLine CepstrumSeries;
        private Steema.TeeChart.Styles.Points CepstrumMarks;
        private Steema.TeeChart.Editor CepstrumChartEditor;
        private CheckBox MarkCursorBox;
		private System.ComponentModel.IContainer components;
        private SpectrumMarkTool smt;
        private SignalMarkTool signalMarkTool;

		public CepstrumDemoForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			SpectrumChart1.Spectrums.Add();
			SpectrumChart1.Spectrums[0].Input = SpectrumAnalyzer1;
			SpectrumChart1.Spectrums[0].Series = SpectrumSeries;

			smt = new SpectrumMarkTool(SpectrumChart1.Chart);
			smt.CursorActive = true;
			smt.DoubleClickClear = true;
			smt.PeakFilterMode = false;
			smt.MarkMode = SpectrumMarkMode.mmSingle;
			smt.MarkType = SpectrumMarkType.mtAmplt;
			smt.MarkSeries = SpectrumChart1.Series[1];
			smt.Series =  SpectrumChart1.Series[0];
			smt.AmpltFormat = "0.00#";
			smt.PhaseFormat = "0.00#";
			smt.FreqFormat = "0.00#";
			smt.LabelHeaders = true;
			smt.PeakZoomBand = false;
			SpectrumChart1.Tools.Add(smt);

			signalChart1.Signals.Add();
			signalChart1.Signals[0].Input = Signal1;
			signalChart1.Signals[0].Series = CepstrumSeries;

			signalMarkTool = new SignalMarkTool(signalChart1.Chart);
            signalMarkTool.CursorActive = true;
            signalMarkTool.DoubleClickClear = true;
            signalMarkTool.MarkSeries = signalChart1.Series[1];
            signalMarkTool.Series = signalChart1.Series[0];
            signalMarkTool.AmpltFormat = "0.00#";
            signalMarkTool.TimeFormat = "0.00#";
            signalMarkTool.MarkMode = SignalMarkMode.tmMaximum;

			signalChart1.Tools.Add(signalMarkTool);

			SignalRead1.Length = 4096;
            SignalRead1.FileName = Utils.SourcePath() + @"\Data\bz.dat";
			SignalRead1.OverlappingPercent = 50;
			SignalRead1.OpenFile();
			data = new TVec();
			cepstrumComboBox.SelectedIndex = 0;
			
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(CepstrumDemoForm));
            Steema.TeeChart.Margins margins2 = new Steema.TeeChart.Margins();
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            MarkCursorBox = new CheckBox();
            CepstrumChartButton = new Button();
            SpectrumChartButton = new Button();
            button1 = new Button();
            label1 = new Label();
            cepstrumComboBox = new ComboBox();
            panel2 = new Panel();
            signalChart1 = new SignalChart();
            CepstrumSeries = new Steema.TeeChart.Styles.FastLine();
            CepstrumMarks = new Steema.TeeChart.Styles.Points();
            splitter1 = new Splitter();
            SpectrumChart1 = new SpectrumChart();
            SpectrumSeries = new Steema.TeeChart.Styles.FastLine();
            SpectrumMarks = new Steema.TeeChart.Styles.Points();
            Signal1 = new TSignal(components);
            SignalRead1 = new TSignalRead(components);
            SpectrumAnalyzer1 = new TSpectrumAnalyzer(components);
            ChartEditor = new Steema.TeeChart.Editor(components);
            SpectrumAnalyzerDialog = new SpectrumAnalyzerDialog(components);
            CepstrumChartEditor = new Steema.TeeChart.Editor(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((ISupportInitialize)signalChart1).BeginInit();
            ((ISupportInitialize)SpectrumChart1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Top;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1149, 118);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            panel1.Controls.Add(MarkCursorBox);
            panel1.Controls.Add(CepstrumChartButton);
            panel1.Controls.Add(SpectrumChartButton);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cepstrumComboBox);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 805);
            panel1.Name = "panel1";
            panel1.Size = new Size(1149, 44);
            panel1.TabIndex = 1;
            // 
            // MarkCursorBox
            // 
            MarkCursorBox.AutoSize = true;
            MarkCursorBox.Checked = true;
            MarkCursorBox.CheckState = CheckState.Checked;
            MarkCursorBox.Location = new Point(684, 14);
            MarkCursorBox.Name = "MarkCursorBox";
            MarkCursorBox.Size = new Size(89, 19);
            MarkCursorBox.TabIndex = 5;
            MarkCursorBox.Text = "Mark cursor";
            MarkCursorBox.UseVisualStyleBackColor = true;
            MarkCursorBox.CheckedChanged += MarkCursorBox_CheckedChanged;
            // 
            // CepstrumChartButton
            // 
            CepstrumChartButton.Location = new Point(284, 7);
            CepstrumChartButton.Name = "CepstrumChartButton";
            CepstrumChartButton.Size = new Size(124, 29);
            CepstrumChartButton.TabIndex = 4;
            CepstrumChartButton.Text = "Cepstrum chart";
            CepstrumChartButton.UseVisualStyleBackColor = true;
            CepstrumChartButton.Click += button3_Click;
            // 
            // SpectrumChartButton
            // 
            SpectrumChartButton.Location = new Point(142, 7);
            SpectrumChartButton.Name = "SpectrumChartButton";
            SpectrumChartButton.Size = new Size(124, 29);
            SpectrumChartButton.TabIndex = 3;
            SpectrumChartButton.Text = "Spectrum chart";
            SpectrumChartButton.UseVisualStyleBackColor = true;
            SpectrumChartButton.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(14, 7);
            button1.Name = "button1";
            button1.Size = new Size(90, 29);
            button1.TabIndex = 2;
            button1.Text = "Spectrum";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(437, 14);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Cepstrum";
            // 
            // cepstrumComboBox
            // 
            cepstrumComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cepstrumComboBox.Items.AddRange(new object[] { "Real", "Complex" });
            cepstrumComboBox.Location = new Point(505, 10);
            cepstrumComboBox.Name = "cepstrumComboBox";
            cepstrumComboBox.Size = new Size(145, 23);
            cepstrumComboBox.TabIndex = 0;
            cepstrumComboBox.SelectedIndexChanged += cepstrumComboBox_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(signalChart1);
            panel2.Controls.Add(splitter1);
            panel2.Controls.Add(SpectrumChart1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(1149, 687);
            panel2.TabIndex = 2;
            panel2.SizeChanged += panel2_SizeChanged;
            // 
            // signalChart1
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
            signalChart1.Axes.Bottom.Grid.DrawEvery = 1;
            signalChart1.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Labels.Brush.Color = Color.White;
            signalChart1.Axes.Bottom.Labels.Brush.Solid = true;
            signalChart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            signalChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            signalChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Bottom.Labels.Font.Size = 9;
            signalChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            signalChart1.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
            signalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            signalChart1.Axes.Bottom.Labels.Separation = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            signalChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            signalChart1.Axes.Bottom.MaximumOffset = 4;
            signalChart1.Axes.Bottom.MinimumOffset = 4;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Title.Brush.Color = Color.Silver;
            signalChart1.Axes.Bottom.Title.Brush.Solid = true;
            signalChart1.Axes.Bottom.Title.Brush.Visible = true;
            signalChart1.Axes.Bottom.Title.Caption = "Spectral frequency (quefrency) [Hz]";
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            signalChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            signalChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Bottom.Title.Font.Size = 11;
            signalChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            signalChart1.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
            signalChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            signalChart1.Axes.Bottom.Title.Lines = new string[]
    {
    "Spectral frequency (quefrency) [Hz]"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            signalChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Depth.Labels.Brush.Color = Color.White;
            signalChart1.Axes.Depth.Labels.Brush.Solid = true;
            signalChart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            signalChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            signalChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Depth.Labels.Font.Size = 9;
            signalChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            signalChart1.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
            signalChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            signalChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Depth.Title.Brush.Color = Color.Silver;
            signalChart1.Axes.Depth.Title.Brush.Solid = true;
            signalChart1.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            signalChart1.Axes.Depth.Title.Font.Brush.Solid = true;
            signalChart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Depth.Title.Font.Size = 11;
            signalChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            signalChart1.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
            signalChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            signalChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Labels.Brush.Color = Color.White;
            signalChart1.Axes.DepthTop.Labels.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            signalChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.DepthTop.Labels.Font.Size = 9;
            signalChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            signalChart1.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
            signalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Title.Brush.Color = Color.Silver;
            signalChart1.Axes.DepthTop.Title.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            signalChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.DepthTop.Title.Font.Size = 11;
            signalChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            signalChart1.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
            signalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.Labels.Brush.Color = Color.White;
            signalChart1.Axes.Left.Labels.Brush.Solid = true;
            signalChart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            signalChart1.Axes.Left.Labels.Font.Brush.Solid = true;
            signalChart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Left.Labels.Font.Size = 9;
            signalChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            signalChart1.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
            signalChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            signalChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            signalChart1.Axes.Left.MaximumOffset = 4;
            signalChart1.Axes.Left.MinimumOffset = 4;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.Title.Brush.Color = Color.Silver;
            signalChart1.Axes.Left.Title.Brush.Solid = true;
            signalChart1.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Left.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            signalChart1.Axes.Left.Title.Font.Brush.Solid = true;
            signalChart1.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Left.Title.Font.Size = 11;
            signalChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            signalChart1.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
            signalChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            signalChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.Labels.Brush.Color = Color.White;
            signalChart1.Axes.Right.Labels.Brush.Solid = true;
            signalChart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            signalChart1.Axes.Right.Labels.Font.Brush.Solid = true;
            signalChart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Right.Labels.Font.Size = 9;
            signalChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            signalChart1.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
            signalChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            signalChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.Title.Brush.Color = Color.Silver;
            signalChart1.Axes.Right.Title.Brush.Solid = true;
            signalChart1.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Right.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            signalChart1.Axes.Right.Title.Font.Brush.Solid = true;
            signalChart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Right.Title.Font.Size = 11;
            signalChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            signalChart1.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
            signalChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            signalChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Top.Labels.Brush.Color = Color.White;
            signalChart1.Axes.Top.Labels.Brush.Solid = true;
            signalChart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            signalChart1.Axes.Top.Labels.Font.Brush.Solid = true;
            signalChart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Top.Labels.Font.Size = 9;
            signalChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            signalChart1.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
            signalChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            signalChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Top.Title.Brush.Color = Color.Silver;
            signalChart1.Axes.Top.Title.Brush.Solid = true;
            signalChart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Top.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            signalChart1.Axes.Top.Title.Font.Brush.Solid = true;
            signalChart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Top.Title.Font.Size = 11;
            signalChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            signalChart1.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
            signalChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            signalChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            signalChart1.Color = Color.Silver;
            signalChart1.Dock = DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Footer.Brush.Color = Color.Silver;
            signalChart1.Footer.Brush.Solid = true;
            signalChart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Footer.Font.Brush.Color = Color.Red;
            signalChart1.Footer.Font.Brush.Solid = true;
            signalChart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Footer.Font.Shadow.Brush.Solid = true;
            signalChart1.Footer.Font.Shadow.Brush.Visible = true;
            signalChart1.Footer.Font.Size = 8;
            signalChart1.Footer.Font.SizeFloat = 8F;
            signalChart1.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Footer.ImageBevel.Brush.Color = Color.LightGray;
            signalChart1.Footer.ImageBevel.Brush.Solid = true;
            signalChart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Footer.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Footer.Shadow.Brush.Solid = true;
            signalChart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Header.Brush.Color = Color.FromArgb(192, 192, 192);
            signalChart1.Header.Brush.Solid = true;
            signalChart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Header.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Header.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            signalChart1.Header.Font.Brush.Solid = true;
            signalChart1.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Header.Font.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Header.Font.Shadow.Brush.Solid = true;
            signalChart1.Header.Font.Shadow.Brush.Visible = true;
            signalChart1.Header.Font.Size = 12;
            signalChart1.Header.Font.SizeFloat = 12F;
            signalChart1.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Header.ImageBevel.Brush.Color = Color.LightGray;
            signalChart1.Header.ImageBevel.Brush.Solid = true;
            signalChart1.Header.ImageBevel.Brush.Visible = true;
            signalChart1.Header.Lines = new string[]
    {
    "Cepstrum"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Header.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            signalChart1.Header.Shadow.Brush.Solid = true;
            signalChart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.Brush.Color = Color.White;
            signalChart1.Legend.Brush.Solid = true;
            signalChart1.Legend.Brush.Visible = true;
            signalChart1.Legend.CheckBoxes = false;
            // 
            // 
            // 
            signalChart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Legend.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            signalChart1.Legend.Font.Brush.Solid = true;
            signalChart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Legend.Font.Shadow.Brush.Solid = true;
            signalChart1.Legend.Font.Shadow.Brush.Visible = true;
            signalChart1.Legend.Font.Size = 9;
            signalChart1.Legend.Font.SizeFloat = 9F;
            signalChart1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.ImageBevel.Brush.Color = Color.LightGray;
            signalChart1.Legend.ImageBevel.Brush.Solid = true;
            signalChart1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.Shadow.Brush.Color = Color.FromArgb(0, 0, 0);
            signalChart1.Legend.Shadow.Brush.Solid = true;
            signalChart1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Legend.Symbol.Shadow.Brush.Solid = true;
            signalChart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.Title.Brush.Color = Color.White;
            signalChart1.Legend.Title.Brush.Solid = true;
            signalChart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            signalChart1.Legend.Title.Font.Brush.Color = Color.Black;
            signalChart1.Legend.Title.Font.Brush.Solid = true;
            signalChart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            signalChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            signalChart1.Legend.Title.Font.Size = 8;
            signalChart1.Legend.Title.Font.SizeFloat = 8F;
            signalChart1.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
            signalChart1.Legend.Title.ImageBevel.Brush.Solid = true;
            signalChart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Legend.Title.Shadow.Brush.Solid = true;
            signalChart1.Legend.Title.Shadow.Brush.Visible = true;
            signalChart1.Legend.Visible = false;
            signalChart1.Location = new Point(0, 250);
            signalChart1.Name = "signalChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            // 
            // 
            // 
            signalChart1.Panel.Brush.Color = Color.Silver;
            signalChart1.Panel.Brush.Solid = true;
            signalChart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Panel.ImageBevel.Brush.Color = Color.LightGray;
            signalChart1.Panel.ImageBevel.Brush.Solid = true;
            signalChart1.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Panel.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Panel.Shadow.Brush.Solid = true;
            signalChart1.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            signalChart1.Printer.Margins = margins1;
            signalChart1.Series.Add(CepstrumSeries);
            signalChart1.Series.Add(CepstrumMarks);
            signalChart1.Size = new Size(1149, 437);
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.SubFooter.Brush.Color = Color.Silver;
            signalChart1.SubFooter.Brush.Solid = true;
            signalChart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.SubFooter.Font.Brush.Color = Color.Red;
            signalChart1.SubFooter.Font.Brush.Solid = true;
            signalChart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.SubFooter.Font.Shadow.Brush.Solid = true;
            signalChart1.SubFooter.Font.Shadow.Brush.Visible = true;
            signalChart1.SubFooter.Font.Size = 8;
            signalChart1.SubFooter.Font.SizeFloat = 8F;
            signalChart1.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
            signalChart1.SubFooter.ImageBevel.Brush.Solid = true;
            signalChart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.SubFooter.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.SubFooter.Shadow.Brush.Solid = true;
            signalChart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.SubHeader.Brush.Color = Color.FromArgb(192, 192, 192);
            signalChart1.SubHeader.Brush.Solid = true;
            signalChart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.SubHeader.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            signalChart1.SubHeader.Font.Brush.Solid = true;
            signalChart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.SubHeader.Font.Shadow.Brush.Solid = true;
            signalChart1.SubHeader.Font.Shadow.Brush.Visible = true;
            signalChart1.SubHeader.Font.Size = 12;
            signalChart1.SubHeader.Font.SizeFloat = 12F;
            signalChart1.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
            signalChart1.SubHeader.ImageBevel.Brush.Solid = true;
            signalChart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.SubHeader.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            signalChart1.SubHeader.Shadow.Brush.Solid = true;
            signalChart1.SubHeader.Shadow.Brush.Visible = true;
            signalChart1.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Back.Brush.Color = Color.Silver;
            signalChart1.Walls.Back.Brush.Solid = true;
            signalChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
            signalChart1.Walls.Back.ImageBevel.Brush.Solid = true;
            signalChart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Walls.Back.Shadow.Brush.Solid = true;
            signalChart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Bottom.Brush.Color = Color.White;
            signalChart1.Walls.Bottom.Brush.Solid = true;
            signalChart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
            signalChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            signalChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Walls.Bottom.Shadow.Brush.Solid = true;
            signalChart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Left.Brush.Color = Color.LightYellow;
            signalChart1.Walls.Left.Brush.Solid = true;
            signalChart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
            signalChart1.Walls.Left.ImageBevel.Brush.Solid = true;
            signalChart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Walls.Left.Shadow.Brush.Solid = true;
            signalChart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Right.Brush.Color = Color.LightYellow;
            signalChart1.Walls.Right.Brush.Solid = true;
            signalChart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
            signalChart1.Walls.Right.ImageBevel.Brush.Solid = true;
            signalChart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
            signalChart1.Walls.Right.Shadow.Brush.Solid = true;
            signalChart1.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Zoom.Animated = true;
            // 
            // 
            // 
            signalChart1.Zoom.Brush.Color = Color.LightBlue;
            signalChart1.Zoom.Brush.Solid = true;
            signalChart1.Zoom.Brush.Visible = false;
            signalChart1.Zoom.History = true;
            // 
            // 
            // 
            signalChart1.Zoom.Pen.Visible = true;
            signalChart1.Click += signalChart1_Click_1;
            // 
            // CepstrumSeries
            // 
            // 
            // 
            // 
            CepstrumSeries.Brush.Color = Color.Empty;
            CepstrumSeries.Brush.Solid = true;
            CepstrumSeries.Brush.Visible = true;
            CepstrumSeries.Color = Color.FromArgb(68, 102, 163);
            CepstrumSeries.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            CepstrumSeries.Legend.Brush.Color = Color.White;
            CepstrumSeries.Legend.Brush.Solid = true;
            CepstrumSeries.Legend.Brush.Visible = true;
            // 
            // 
            // 
            CepstrumSeries.Legend.Font.Bold = false;
            // 
            // 
            // 
            CepstrumSeries.Legend.Font.Brush.Color = Color.Black;
            CepstrumSeries.Legend.Font.Brush.Solid = true;
            CepstrumSeries.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            CepstrumSeries.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            CepstrumSeries.Legend.Font.Shadow.Brush.Solid = true;
            CepstrumSeries.Legend.Font.Shadow.Brush.Visible = true;
            CepstrumSeries.Legend.Font.Size = 8;
            CepstrumSeries.Legend.Font.SizeFloat = 8F;
            CepstrumSeries.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            CepstrumSeries.Legend.ImageBevel.Brush.Color = Color.LightGray;
            CepstrumSeries.Legend.ImageBevel.Brush.Solid = true;
            CepstrumSeries.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            CepstrumSeries.Legend.Shadow.Brush.Color = Color.DarkGray;
            CepstrumSeries.Legend.Shadow.Brush.Solid = true;
            CepstrumSeries.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            CepstrumSeries.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            CepstrumSeries.Marks.Brush.Solid = true;
            CepstrumSeries.Marks.Brush.Visible = true;
            // 
            // 
            // 
            CepstrumSeries.Marks.Font.Bold = false;
            // 
            // 
            // 
            CepstrumSeries.Marks.Font.Brush.Color = Color.Black;
            CepstrumSeries.Marks.Font.Brush.Solid = true;
            CepstrumSeries.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            CepstrumSeries.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            CepstrumSeries.Marks.Font.Shadow.Brush.Solid = true;
            CepstrumSeries.Marks.Font.Shadow.Brush.Visible = true;
            CepstrumSeries.Marks.Font.Size = 8;
            CepstrumSeries.Marks.Font.SizeFloat = 8F;
            CepstrumSeries.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            CepstrumSeries.Marks.ImageBevel.Brush.Color = Color.LightGray;
            CepstrumSeries.Marks.ImageBevel.Brush.Solid = true;
            CepstrumSeries.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            CepstrumSeries.Marks.Shadow.Brush.Color = Color.Gray;
            CepstrumSeries.Marks.Shadow.Brush.Solid = true;
            CepstrumSeries.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            CepstrumSeries.Marks.Symbol.Brush.Color = Color.White;
            CepstrumSeries.Marks.Symbol.Brush.Solid = true;
            CepstrumSeries.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            CepstrumSeries.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            CepstrumSeries.Marks.Symbol.ImageBevel.Brush.Solid = true;
            CepstrumSeries.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            CepstrumSeries.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            CepstrumSeries.Marks.Symbol.Shadow.Brush.Solid = true;
            CepstrumSeries.Marks.Symbol.Shadow.Brush.Visible = true;
            CepstrumSeries.Title = "fastLine1";
            CepstrumSeries.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            // 
            // 
            // 
            CepstrumSeries.XValues.DataMember = "X";
            CepstrumSeries.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            CepstrumSeries.XValues.Value = new double[]
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
            CepstrumSeries.YValues.DataMember = "Y";
            CepstrumSeries.YValues.Value = new double[]
    {
    573D,
    527D,
    416D,
    409D,
    319D,
    363D,
    320D,
    246D,
    201D,
    180D,
    259D,
    351D,
    265D,
    258D,
    231D,
    258D,
    350D,
    433D,
    312D,
    350D,
    284D,
    343D,
    333D,
    354D,
    325D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // CepstrumMarks
            // 
            // 
            // 
            // 
            CepstrumMarks.Brush.Color = Color.Empty;
            CepstrumMarks.Brush.Solid = true;
            CepstrumMarks.Brush.Visible = true;
            CepstrumMarks.Color = Color.FromArgb(255, 0, 0);
            CepstrumMarks.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            CepstrumMarks.Legend.Brush.Color = Color.White;
            CepstrumMarks.Legend.Brush.Solid = true;
            CepstrumMarks.Legend.Brush.Visible = true;
            // 
            // 
            // 
            CepstrumMarks.Legend.Font.Bold = false;
            // 
            // 
            // 
            CepstrumMarks.Legend.Font.Brush.Color = Color.Black;
            CepstrumMarks.Legend.Font.Brush.Solid = true;
            CepstrumMarks.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            CepstrumMarks.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            CepstrumMarks.Legend.Font.Shadow.Brush.Solid = true;
            CepstrumMarks.Legend.Font.Shadow.Brush.Visible = true;
            CepstrumMarks.Legend.Font.Size = 8;
            CepstrumMarks.Legend.Font.SizeFloat = 8F;
            CepstrumMarks.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            CepstrumMarks.Legend.ImageBevel.Brush.Color = Color.LightGray;
            CepstrumMarks.Legend.ImageBevel.Brush.Solid = true;
            CepstrumMarks.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            CepstrumMarks.Legend.Shadow.Brush.Color = Color.DarkGray;
            CepstrumMarks.Legend.Shadow.Brush.Solid = true;
            CepstrumMarks.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            CepstrumMarks.Marks.Arrow.Visible = false;
            CepstrumMarks.Marks.ArrowLength = 8;
            // 
            // 
            // 
            CepstrumMarks.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            CepstrumMarks.Marks.Brush.Solid = true;
            CepstrumMarks.Marks.Brush.Visible = false;
            // 
            // 
            // 
            CepstrumMarks.Marks.Font.Bold = false;
            // 
            // 
            // 
            CepstrumMarks.Marks.Font.Brush.Color = Color.Black;
            CepstrumMarks.Marks.Font.Brush.Solid = true;
            CepstrumMarks.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            CepstrumMarks.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            CepstrumMarks.Marks.Font.Shadow.Brush.Solid = true;
            CepstrumMarks.Marks.Font.Shadow.Brush.Visible = true;
            CepstrumMarks.Marks.Font.Size = 8;
            CepstrumMarks.Marks.Font.SizeFloat = 8F;
            CepstrumMarks.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            CepstrumMarks.Marks.ImageBevel.Brush.Color = Color.LightGray;
            CepstrumMarks.Marks.ImageBevel.Brush.Solid = true;
            CepstrumMarks.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            CepstrumMarks.Marks.Shadow.Brush.Color = Color.Gray;
            CepstrumMarks.Marks.Shadow.Brush.Solid = true;
            CepstrumMarks.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            CepstrumMarks.Marks.Symbol.Brush.Color = Color.White;
            CepstrumMarks.Marks.Symbol.Brush.Solid = true;
            CepstrumMarks.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            CepstrumMarks.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            CepstrumMarks.Marks.Symbol.ImageBevel.Brush.Solid = true;
            CepstrumMarks.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            CepstrumMarks.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            CepstrumMarks.Marks.Symbol.Shadow.Brush.Solid = true;
            CepstrumMarks.Marks.Symbol.Shadow.Brush.Visible = true;
            CepstrumMarks.Marks.Transparent = true;
            CepstrumMarks.Marks.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            CepstrumMarks.Pointer.Brush.Color = Color.FromArgb(255, 0, 0);
            CepstrumMarks.Pointer.Brush.Solid = true;
            CepstrumMarks.Pointer.Brush.Visible = true;
            CepstrumMarks.Pointer.HorizSize = 3;
            // 
            // 
            // 
            CepstrumMarks.Pointer.Pen.Color = Color.FromArgb(153, 0, 0);
            CepstrumMarks.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            CepstrumMarks.Pointer.VertSize = 3;
            CepstrumMarks.Title = "points1";
            // 
            // 
            // 
            CepstrumMarks.XValues.DataMember = "X";
            CepstrumMarks.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            CepstrumMarks.XValues.Value = new double[]
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
            CepstrumMarks.YValues.DataMember = "Y";
            CepstrumMarks.YValues.Value = new double[]
    {
    311D,
    336D,
    340D,
    356D,
    379D,
    380D,
    388D,
    355D,
    331D,
    301D,
    298D,
    272D,
    281D,
    272D,
    320D,
    286D,
    273D,
    254D,
    243D,
    290D,
    280D,
    267D,
    243D,
    209D,
    218D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            splitter1.Location = new Point(0, 246);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(1149, 4);
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
            SpectrumChart1.Series.Add(SpectrumSeries);
            SpectrumChart1.Series.Add(SpectrumMarks);
            SpectrumChart1.Size = new Size(1149, 246);
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
            // SpectrumSeries
            // 
            // 
            // 
            // 
            SpectrumSeries.Brush.Color = Color.Empty;
            SpectrumSeries.Brush.Solid = true;
            SpectrumSeries.Brush.Visible = true;
            SpectrumSeries.Color = Color.FromArgb(68, 102, 163);
            SpectrumSeries.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumSeries.Legend.Brush.Color = Color.White;
            SpectrumSeries.Legend.Brush.Solid = true;
            SpectrumSeries.Legend.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumSeries.Legend.Font.Bold = false;
            // 
            // 
            // 
            SpectrumSeries.Legend.Font.Brush.Color = Color.Black;
            SpectrumSeries.Legend.Font.Brush.Solid = true;
            SpectrumSeries.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumSeries.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumSeries.Legend.Font.Shadow.Brush.Solid = true;
            SpectrumSeries.Legend.Font.Shadow.Brush.Visible = true;
            SpectrumSeries.Legend.Font.Size = 8;
            SpectrumSeries.Legend.Font.SizeFloat = 8F;
            SpectrumSeries.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumSeries.Legend.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumSeries.Legend.ImageBevel.Brush.Solid = true;
            SpectrumSeries.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumSeries.Legend.Shadow.Brush.Color = Color.DarkGray;
            SpectrumSeries.Legend.Shadow.Brush.Solid = true;
            SpectrumSeries.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumSeries.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            SpectrumSeries.Marks.Brush.Solid = true;
            SpectrumSeries.Marks.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumSeries.Marks.Font.Bold = false;
            // 
            // 
            // 
            SpectrumSeries.Marks.Font.Brush.Color = Color.Black;
            SpectrumSeries.Marks.Font.Brush.Solid = true;
            SpectrumSeries.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumSeries.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumSeries.Marks.Font.Shadow.Brush.Solid = true;
            SpectrumSeries.Marks.Font.Shadow.Brush.Visible = true;
            SpectrumSeries.Marks.Font.Size = 8;
            SpectrumSeries.Marks.Font.SizeFloat = 8F;
            SpectrumSeries.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumSeries.Marks.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumSeries.Marks.ImageBevel.Brush.Solid = true;
            SpectrumSeries.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumSeries.Marks.Shadow.Brush.Color = Color.Gray;
            SpectrumSeries.Marks.Shadow.Brush.Solid = true;
            SpectrumSeries.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumSeries.Marks.Symbol.Brush.Color = Color.White;
            SpectrumSeries.Marks.Symbol.Brush.Solid = true;
            SpectrumSeries.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumSeries.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumSeries.Marks.Symbol.ImageBevel.Brush.Solid = true;
            SpectrumSeries.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumSeries.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            SpectrumSeries.Marks.Symbol.Shadow.Brush.Solid = true;
            SpectrumSeries.Marks.Symbol.Shadow.Brush.Visible = true;
            SpectrumSeries.Title = "Spectrum";
            SpectrumSeries.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            // 
            // 
            // 
            SpectrumSeries.XValues.DataMember = "X";
            SpectrumSeries.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            SpectrumSeries.XValues.Value = new double[]
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
            SpectrumSeries.YValues.DataMember = "Y";
            SpectrumSeries.YValues.Value = new double[]
    {
    14D,
    68D,
    176D,
    218D,
    199D,
    291D,
    175D,
    127D,
    69D,
    133D,
    139D,
    250D,
    270D,
    338D,
    363D,
    335D,
    428D,
    511D,
    455D,
    479D,
    506D,
    423D,
    440D,
    319D,
    233D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // SpectrumMarks
            // 
            // 
            // 
            // 
            SpectrumMarks.Brush.Color = Color.Empty;
            SpectrumMarks.Brush.Solid = true;
            SpectrumMarks.Brush.Visible = true;
            SpectrumMarks.Color = Color.OrangeRed;
            SpectrumMarks.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumMarks.Legend.Brush.Color = Color.White;
            SpectrumMarks.Legend.Brush.Solid = true;
            SpectrumMarks.Legend.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumMarks.Legend.Font.Bold = false;
            // 
            // 
            // 
            SpectrumMarks.Legend.Font.Brush.Color = Color.Black;
            SpectrumMarks.Legend.Font.Brush.Solid = true;
            SpectrumMarks.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumMarks.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumMarks.Legend.Font.Shadow.Brush.Solid = true;
            SpectrumMarks.Legend.Font.Shadow.Brush.Visible = true;
            SpectrumMarks.Legend.Font.Size = 8;
            SpectrumMarks.Legend.Font.SizeFloat = 8F;
            SpectrumMarks.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumMarks.Legend.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumMarks.Legend.ImageBevel.Brush.Solid = true;
            SpectrumMarks.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumMarks.Legend.Shadow.Brush.Color = Color.DarkGray;
            SpectrumMarks.Legend.Shadow.Brush.Solid = true;
            SpectrumMarks.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumMarks.Marks.Arrow.Visible = false;
            SpectrumMarks.Marks.ArrowLength = 10;
            // 
            // 
            // 
            SpectrumMarks.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            SpectrumMarks.Marks.Brush.Solid = true;
            SpectrumMarks.Marks.Brush.Visible = false;
            // 
            // 
            // 
            SpectrumMarks.Marks.Font.Bold = false;
            // 
            // 
            // 
            SpectrumMarks.Marks.Font.Brush.Color = Color.Black;
            SpectrumMarks.Marks.Font.Brush.Solid = true;
            SpectrumMarks.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumMarks.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumMarks.Marks.Font.Shadow.Brush.Solid = true;
            SpectrumMarks.Marks.Font.Shadow.Brush.Visible = true;
            SpectrumMarks.Marks.Font.Size = 8;
            SpectrumMarks.Marks.Font.SizeFloat = 8F;
            SpectrumMarks.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumMarks.Marks.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumMarks.Marks.ImageBevel.Brush.Solid = true;
            SpectrumMarks.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumMarks.Marks.Shadow.Brush.Color = Color.Gray;
            SpectrumMarks.Marks.Shadow.Brush.Solid = true;
            SpectrumMarks.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumMarks.Marks.Symbol.Brush.Color = Color.White;
            SpectrumMarks.Marks.Symbol.Brush.Solid = true;
            SpectrumMarks.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumMarks.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumMarks.Marks.Symbol.ImageBevel.Brush.Solid = true;
            SpectrumMarks.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumMarks.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            SpectrumMarks.Marks.Symbol.Shadow.Brush.Solid = true;
            SpectrumMarks.Marks.Symbol.Shadow.Brush.Visible = true;
            SpectrumMarks.Marks.Transparent = true;
            SpectrumMarks.Marks.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumMarks.Pointer.Brush.Color = Color.OrangeRed;
            SpectrumMarks.Pointer.Brush.Solid = true;
            SpectrumMarks.Pointer.Brush.Visible = true;
            SpectrumMarks.Pointer.HorizSize = 3;
            // 
            // 
            // 
            SpectrumMarks.Pointer.Pen.Color = Color.FromArgb(153, 41, 0);
            SpectrumMarks.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            SpectrumMarks.Pointer.VertSize = 3;
            SpectrumMarks.Title = "SpectrumMarks";
            // 
            // 
            // 
            SpectrumMarks.XValues.DataMember = "X";
            SpectrumMarks.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            SpectrumMarks.XValues.Value = new double[]
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
            SpectrumMarks.YValues.DataMember = "Y";
            SpectrumMarks.YValues.Value = new double[]
    {
    314D,
    358D,
    364D,
    374D,
    315D,
    337D,
    303D,
    325D,
    275D,
    219D,
    195D,
    222D,
    262D,
    269D,
    310D,
    249D,
    292D,
    353D,
    316D,
    312D,
    354D,
    390D,
    363D,
    417D,
    355D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // Signal1
            // 
            Signal1.ChannelCount = 1;
            Signal1.Complex = false;
            Signal1.DataSerialization = "AAAAAAAAQEEAAAAAAACAPwAAAAAAgB9EAAAAQQAAAAAAE3pHAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            Signal1.FloatPrecision = TMtxFloatPrecision.mvDouble;
            Signal1.FloatPrecisionLock = false;
            Signal1.IsDouble = true;
            Signal1.Length = 12;
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
            SpectrumAnalyzer1.Peaks.Interpolation.Method = TInterpolationMethod.imNone;
            SpectrumAnalyzer1.Peaks.Interpolation.RecursiveHarmonics = TRecursiveHarmonics.rhNone;
            SpectrumAnalyzer1.Peaks.LargestCount = 1;
            SpectrumAnalyzer1.Peaks.LargestRatio = 1E+15D;
            SpectrumAnalyzer1.Peaks.NormalizedAmplt.PeakNumber = 1;
            SpectrumAnalyzer1.Peaks.NormalizedFreq.PeakNumber = 1;
            SpectrumAnalyzer1.Report.UseTab = false;
            SpectrumAnalyzer1.Rotation = 0;
            SpectrumAnalyzer1.SamplingFrequency = 8192D;
            SpectrumAnalyzer1.Stats.Averaged = 0;
            SpectrumAnalyzer1.Stats.Averages = 30;
            SpectrumAnalyzer1.Stats.ExpDecay = 5;
            SpectrumAnalyzer1.ZeroPadding = 2;
            SpectrumAnalyzer1.OnAfterUpdateEvent += SpectrumAnalyzer1_OnAfterUpdate;
            SpectrumAnalyzer1.OnParameterUpdateEvent += SpectrumAnalyzer1_OnParameterUpdate;
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
            // SpectrumAnalyzerDialog
            // 
            SpectrumAnalyzerDialog.Docking = false;
            SpectrumAnalyzerDialog.FormCaption = null;
            SpectrumAnalyzerDialog.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            SpectrumAnalyzerDialog.ShowLive = false;
            SpectrumAnalyzerDialog.Source = SpectrumAnalyzer1;
            SpectrumAnalyzerDialog.SourceListIndex = 0;
            // 
            // CepstrumChartEditor
            // 
            CepstrumChartEditor.AlwaysShowFuncSrc = false;
            CepstrumChartEditor.Chart = signalChart1;
            CepstrumChartEditor.HighLightTabs = false;
            CepstrumChartEditor.Location = new Point(0, 0);
            CepstrumChartEditor.Name = "ChartEditor";
            CepstrumChartEditor.Options = null;
            CepstrumChartEditor.TabIndex = 0;
            // 
            // CepstrumDemoForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(1149, 849);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Name = "CepstrumDemoForm";
            Text = "CepstrumDemoForm";
            Load += CepstrumDemoForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((ISupportInitialize)signalChart1).EndInit();
            ((ISupportInitialize)SpectrumChart1).EndInit();
            ResumeLayout(false);

        }
        #endregion

        private void SpectrumAnalyzer1_OnAfterUpdate(object Sender) {
			switch (cepstrumComboBox.SelectedIndex) {
				case 0:SignalUtils.RealCepstrum(SignalRead1.Data,data,true,TSignalWindowType.wtHanning,true);break;
				case 1:SignalUtils.CplxCepstrum(SignalRead1.Data,data,16);break;
			}
                Signal1.Data[0] = 0; //set DC to zero
                SignalUtils.RunningAverage(Signal1.Data, data, (int)SignalRead1.FrameNumber,0);

		}

		private void SpectrumAnalyzer1_OnParameterUpdate(object Sender) {

            SpectrumAnalyzer1.Update();
		}

		private void cepstrumComboBox_SelectedIndexChanged(object sender, System.EventArgs e) {
			SignalRead1.RecordPosition = 0;
			SpectrumAnalyzer1.ResetAveraging();
			SpectrumAnalyzer1.PullUntilEnd();
			SpectrumAnalyzer1.UpdateNotify(); 
			Signal1.SamplingTime = Signal1.Length;
			Signal1.UpdateNotify();  //update connected chart.
		}

		private void panel2_SizeChanged(object sender, System.EventArgs e) {
			//signalChart1.Height = SpectrumChart1.Height = (panel2.Height - splitter1.Height) / 2;
		}

        private void SpectrumChart1_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            CepstrumChartEditor.ShowModal();
        }

        protected void Add(String s)
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void CepstrumDemoForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("Complex cepstrum can be used to measure echo " +
                "delays and for homomorphic filtering. Real cepstrum " +
                "can detect periodicities in the frequency spectrum. ");
        }

        private void signalChart1_Click_1(object sender, EventArgs e)
        {

        }

        private void MarkCursorBox_CheckedChanged(object sender, EventArgs e)
        {            
            signalMarkTool.CursorActive =  MarkCursorBox.Checked;
            smt.CursorActive = MarkCursorBox.Checked;            
        }
	}
}
