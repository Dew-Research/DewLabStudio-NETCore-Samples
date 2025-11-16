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
using Dew.Math.Controls;
using Dew.Math.Tee;
using Dew.Signal.Editors;
using static Dew.Math.Tee.MtxVecTee;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for BicoherenceTestForm.
	/// </summary>
	public class BicoherenceTestForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private Steema.TeeChart.TChart Chart1;
		private System.Windows.Forms.Splitter splitter1;
		private SpectrumChart SpectrumChart1;
        private System.Windows.Forms.Button ChartButton;
		private FloatEdit Freq1Edit;
		private FloatEdit Freq2Edit;
		private System.Windows.Forms.Label label2;
		private Dew.Signal.TSpectrumAnalyzer SpectrumAnalyzer1;
		private Dew.Signal.TBiSpectrumAnalyzer BiSpectrumAnalyzer1;
		private Steema.TeeChart.Styles.FastLine Series1;
		private Steema.TeeChart.Styles.Points Series2;
		private Dew.Signal.TSignal Signal1;
        private Label label3;
        private Button SpectrumButton;
        private Button button3;
        private Steema.TeeChart.Editor ChartEditor;
        private SpectrumAnalyzerDialog SpectrumAnalyzerDialog;
		private System.ComponentModel.IContainer components;

		public BicoherenceTestForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			SpectrumChart1.Spectrums.Add();
			SpectrumChart1.Spectrums[0].Input = SpectrumAnalyzer1;
			SpectrumChart1.Spectrums[0].Series = Series1;
			
			AxisScaleTool tool = new AxisScaleTool(SpectrumChart1.Chart);
			tool.UpperMargin = 30;
			tool.LowerMargin = 5;
			tool.AxisScaleMode = AxisScaleMode.amPeakHold;
			tool.DataIsSpectrum = true;
			tool.Axis = SpectrumChart1.Axes.Left;
			SpectrumChart1.Tools.Add(tool);

            SpectrumMarkTool smt = new SpectrumMarkTool(SpectrumChart1.Chart);
			smt.CursorActive = false;
			smt.DoubleClickClear = true;
			smt.PeakFilterMode = false;
			smt.MarkMode = SpectrumMarkMode.mmSingle;
			smt.MarkType = SpectrumMarkType.mtAmplt;
			smt.MarkSeries = Series2;
			smt.Series =  Series1;
			smt.AmpltFormat = "0.00#";
			smt.PhaseFormat = "0.00#";
			smt.FreqFormat = "0.00#";
			smt.LabelHeaders = true;
			smt.PeakZoomBand = false;
			SpectrumChart1.Tools.Add(smt);

			gridSeries = new MtxGridSeries(Chart1.Chart);
			gridSeries.ColorPalette.TopColor = Color.Blue;
			gridSeries.ColorPalette.BottomColor = Color.White;	 

			bMtx = new TMtx();
			Signal1.UsesInputs = false;
			BiSpectrumAnalyzer1.Amplt.SetZero();
			button1_Click(this, EventArgs.Empty);
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(BicoherenceTestForm));
            Steema.TeeChart.Margins margins2 = new Steema.TeeChart.Margins();
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            button3 = new Button();
            Freq2Edit = new FloatEdit();
            label2 = new Label();
            Freq1Edit = new FloatEdit();
            label3 = new Label();
            SpectrumButton = new Button();
            ChartButton = new Button();
            panel2 = new Panel();
            SpectrumChart1 = new SpectrumChart();
            Series1 = new Steema.TeeChart.Styles.FastLine();
            Series2 = new Steema.TeeChart.Styles.Points();
            splitter1 = new Splitter();
            Chart1 = new Steema.TeeChart.TChart();
            SpectrumAnalyzer1 = new TSpectrumAnalyzer(components);
            Signal1 = new TSignal(components);
            BiSpectrumAnalyzer1 = new TBiSpectrumAnalyzer(components);
            ChartEditor = new Steema.TeeChart.Editor(components);
            SpectrumAnalyzerDialog = new SpectrumAnalyzerDialog(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((ISupportInitialize)SpectrumChart1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Top;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1149, 89);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(Freq2Edit);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Freq1Edit);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(SpectrumButton);
            panel1.Controls.Add(ChartButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 820);
            panel1.Name = "panel1";
            panel1.Size = new Size(1149, 48);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(232, 11);
            button3.Name = "button3";
            button3.Size = new Size(90, 28);
            button3.TabIndex = 5;
            button3.Text = "Recalculate";
            // 
            // Freq2Edit
            // 
            Freq2Edit.Increment = "1";
            Freq2Edit.Location = new Point(568, 11);
            Freq2Edit.Name = "Freq2Edit";
            Freq2Edit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            Freq2Edit.Scientific = false;
            Freq2Edit.Size = new Size(76, 23);
            Freq2Edit.TabIndex = 4;
            Freq2Edit.Value = "80.00";
            Freq2Edit.TextChanged += Freq2Edit_TextChanged;
            // 
            // label2
            // 
            label2.Location = new Point(520, 11);
            label2.Name = "label2";
            label2.Size = new Size(48, 28);
            label2.TabIndex = 3;
            label2.Text = "Freq2:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Freq1Edit
            // 
            Freq1Edit.Increment = "1";
            Freq1Edit.Location = new Point(414, 11);
            Freq1Edit.Name = "Freq1Edit";
            Freq1Edit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            Freq1Edit.Scientific = false;
            Freq1Edit.Size = new Size(77, 23);
            Freq1Edit.TabIndex = 2;
            Freq1Edit.Value = "20.00";
            Freq1Edit.TextChanged += Freq1Edit_TextChanged;
            // 
            // label3
            // 
            label3.Location = new Point(328, 11);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 1;
            label3.Text = "Freq1:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SpectrumButton
            // 
            SpectrumButton.Location = new Point(14, 11);
            SpectrumButton.Name = "SpectrumButton";
            SpectrumButton.Size = new Size(90, 28);
            SpectrumButton.TabIndex = 0;
            SpectrumButton.Text = "Spectrum...";
            SpectrumButton.Click += SpectrumButton_Click;
            // 
            // ChartButton
            // 
            ChartButton.Location = new Point(124, 11);
            ChartButton.Name = "ChartButton";
            ChartButton.Size = new Size(90, 28);
            ChartButton.TabIndex = 0;
            ChartButton.Text = "Chart...";
            ChartButton.Click += ChartButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(SpectrumChart1);
            panel2.Controls.Add(splitter1);
            panel2.Controls.Add(Chart1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(1149, 731);
            panel2.TabIndex = 2;
            panel2.SizeChanged += panel2_SizeChanged;
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
            SpectrumChart1.Axes.Right.Automatic = false;
            SpectrumChart1.Axes.Right.AutomaticMaximum = false;
            SpectrumChart1.Axes.Right.AutomaticMinimum = false;
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
            SpectrumChart1.Color = Color.Silver;
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
            SpectrumChart1.Location = new Point(0, 240);
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
            SpectrumChart1.Panel.Brush.Color = Color.Silver;
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
            SpectrumChart1.Size = new Size(1149, 491);
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
            // 
            // 
            // 
            SpectrumChart1.Zoom.Brush.Color = Color.LightBlue;
            SpectrumChart1.Zoom.Brush.Solid = true;
            SpectrumChart1.Zoom.Brush.Visible = false;
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
    320D,
    382D,
    461D,
    443D,
    378D,
    267D,
    279D,
    338D,
    408D,
    495D,
    536D,
    598D,
    722D,
    796D,
    899D,
    999D,
    1074D,
    1032D,
    961D,
    948D,
    973D,
    877D,
    967D,
    966D,
    892D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            Series2.Marks.ArrowLength = 10;
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
    999D,
    965D,
    982D,
    964D,
    1012D,
    963D,
    973D,
    911D,
    838D,
    883D,
    944D,
    921D,
    975D,
    913D,
    874D,
    831D,
    895D,
    877D,
    892D,
    915D,
    905D,
    876D,
    892D,
    910D,
    964D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            splitter1.Location = new Point(0, 236);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(1149, 4);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // Chart1
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
            Chart1.Axes.Bottom.Grid.DrawEvery = 1;
            Chart1.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Bottom.Labels.Brush.Color = Color.White;
            Chart1.Axes.Bottom.Labels.Brush.Solid = true;
            Chart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            Chart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            Chart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            Chart1.Axes.Bottom.Labels.Font.Size = 9;
            Chart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            Chart1.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            Chart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            Chart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Bottom.Title.Brush.Color = Color.Silver;
            Chart1.Axes.Bottom.Title.Brush.Solid = true;
            Chart1.Axes.Bottom.Title.Brush.Visible = true;
            Chart1.Axes.Bottom.Title.Caption = "Frequency [Hz]";
            // 
            // 
            // 
            Chart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            Chart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            Chart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            Chart1.Axes.Bottom.Title.Font.Size = 11;
            Chart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            Chart1.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            Chart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            Chart1.Axes.Bottom.Title.Lines = new string[]
    {
    "Frequency [Hz]"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            Chart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Depth.Labels.Brush.Color = Color.White;
            Chart1.Axes.Depth.Labels.Brush.Solid = true;
            Chart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            Chart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            Chart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            Chart1.Axes.Depth.Labels.Font.Size = 9;
            Chart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            Chart1.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            Chart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            Chart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Depth.Title.Brush.Color = Color.Silver;
            Chart1.Axes.Depth.Title.Brush.Solid = true;
            Chart1.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart1.Axes.Depth.Title.Font.Brush.Solid = true;
            Chart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            Chart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            Chart1.Axes.Depth.Title.Font.Size = 11;
            Chart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            Chart1.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            Chart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            Chart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.DepthTop.Labels.Brush.Color = Color.White;
            Chart1.Axes.DepthTop.Labels.Brush.Solid = true;
            Chart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            Chart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            Chart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            Chart1.Axes.DepthTop.Labels.Font.Size = 9;
            Chart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            Chart1.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            Chart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            Chart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.DepthTop.Title.Brush.Color = Color.Silver;
            Chart1.Axes.DepthTop.Title.Brush.Solid = true;
            Chart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            Chart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            Chart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            Chart1.Axes.DepthTop.Title.Font.Size = 11;
            Chart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            Chart1.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            Chart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            Chart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Left.Labels.Brush.Color = Color.White;
            Chart1.Axes.Left.Labels.Brush.Solid = true;
            Chart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart1.Axes.Left.Labels.Font.Brush.Solid = true;
            Chart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            Chart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            Chart1.Axes.Left.Labels.Font.Size = 9;
            Chart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            Chart1.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            Chart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            Chart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Left.Title.Brush.Color = Color.Silver;
            Chart1.Axes.Left.Title.Brush.Solid = true;
            Chart1.Axes.Left.Title.Brush.Visible = true;
            Chart1.Axes.Left.Title.Caption = "Frequency [Hz]";
            // 
            // 
            // 
            Chart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Axes.Left.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart1.Axes.Left.Title.Font.Brush.Solid = true;
            Chart1.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            Chart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            Chart1.Axes.Left.Title.Font.Size = 11;
            Chart1.Axes.Left.Title.Font.SizeFloat = 11F;
            Chart1.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            Chart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            Chart1.Axes.Left.Title.Lines = new string[]
    {
    "Frequency [Hz]"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            Chart1.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Right.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Right.Labels.Brush.Color = Color.White;
            Chart1.Axes.Right.Labels.Brush.Solid = true;
            Chart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart1.Axes.Right.Labels.Font.Brush.Solid = true;
            Chart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            Chart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            Chart1.Axes.Right.Labels.Font.Size = 9;
            Chart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            Chart1.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            Chart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            Chart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Right.Title.Brush.Color = Color.Silver;
            Chart1.Axes.Right.Title.Brush.Solid = true;
            Chart1.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Axes.Right.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart1.Axes.Right.Title.Font.Brush.Solid = true;
            Chart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            Chart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            Chart1.Axes.Right.Title.Font.Size = 11;
            Chart1.Axes.Right.Title.Font.SizeFloat = 11F;
            Chart1.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            Chart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            Chart1.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Top.Labels.Brush.Color = Color.White;
            Chart1.Axes.Top.Labels.Brush.Solid = true;
            Chart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart1.Axes.Top.Labels.Font.Brush.Solid = true;
            Chart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            Chart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            Chart1.Axes.Top.Labels.Font.Size = 9;
            Chart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            Chart1.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            Chart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            Chart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Top.Title.Brush.Color = Color.Silver;
            Chart1.Axes.Top.Title.Brush.Solid = true;
            Chart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Axes.Top.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart1.Axes.Top.Title.Font.Brush.Solid = true;
            Chart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            Chart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            Chart1.Axes.Top.Title.Font.Size = 11;
            Chart1.Axes.Top.Title.Font.SizeFloat = 11F;
            Chart1.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            Chart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            Chart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            Chart1.Dock = DockStyle.Top;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Footer.Brush.Color = Color.Silver;
            Chart1.Footer.Brush.Solid = true;
            Chart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Footer.Font.Brush.Color = Color.Red;
            Chart1.Footer.Font.Brush.Solid = true;
            Chart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Footer.Font.Shadow.Brush.Solid = true;
            Chart1.Footer.Font.Shadow.Brush.Visible = true;
            Chart1.Footer.Font.Size = 8;
            Chart1.Footer.Font.SizeFloat = 8F;
            Chart1.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Footer.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Footer.ImageBevel.Brush.Solid = true;
            Chart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Footer.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Footer.Shadow.Brush.Solid = true;
            Chart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Header.Brush.Color = Color.FromArgb(192, 192, 192);
            Chart1.Header.Brush.Solid = true;
            Chart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Header.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Header.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart1.Header.Font.Brush.Solid = true;
            Chart1.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Header.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Header.Font.Shadow.Brush.Solid = true;
            Chart1.Header.Font.Shadow.Brush.Visible = true;
            Chart1.Header.Font.Size = 12;
            Chart1.Header.Font.SizeFloat = 12F;
            Chart1.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Header.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Header.ImageBevel.Brush.Solid = true;
            Chart1.Header.ImageBevel.Brush.Visible = true;
            Chart1.Header.Lines = new string[]
    {
    "Bicoherence"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Header.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            Chart1.Header.Shadow.Brush.Solid = true;
            Chart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Legend.Brush.Color = Color.White;
            Chart1.Legend.Brush.Solid = true;
            Chart1.Legend.Brush.Visible = true;
            Chart1.Legend.CheckBoxes = false;
            // 
            // 
            // 
            Chart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Legend.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart1.Legend.Font.Brush.Solid = true;
            Chart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Legend.Font.Shadow.Brush.Solid = true;
            Chart1.Legend.Font.Shadow.Brush.Visible = true;
            Chart1.Legend.Font.Size = 9;
            Chart1.Legend.Font.SizeFloat = 9F;
            Chart1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Legend.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Legend.ImageBevel.Brush.Solid = true;
            Chart1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Legend.Shadow.Brush.Color = Color.FromArgb(0, 0, 0);
            Chart1.Legend.Shadow.Brush.Solid = true;
            Chart1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Legend.Symbol.Shadow.Brush.Solid = true;
            Chart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Legend.Title.Brush.Color = Color.White;
            Chart1.Legend.Title.Brush.Solid = true;
            Chart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            Chart1.Legend.Title.Font.Brush.Color = Color.Black;
            Chart1.Legend.Title.Font.Brush.Solid = true;
            Chart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            Chart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            Chart1.Legend.Title.Font.Size = 8;
            Chart1.Legend.Title.Font.SizeFloat = 8F;
            Chart1.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Legend.Title.ImageBevel.Brush.Solid = true;
            Chart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Legend.Title.Shadow.Brush.Solid = true;
            Chart1.Legend.Title.Shadow.Brush.Visible = true;
            Chart1.Location = new Point(0, 0);
            Chart1.Name = "Chart1";
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            // 
            // 
            // 
            Chart1.Panel.Brush.Color = Color.Silver;
            Chart1.Panel.Brush.Solid = true;
            Chart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Panel.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Panel.ImageBevel.Brush.Solid = true;
            Chart1.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Panel.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Panel.Shadow.Brush.Solid = true;
            Chart1.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins2.Bottom = 100;
            margins2.Left = 100;
            margins2.Right = 100;
            margins2.Top = 100;
            Chart1.Printer.Margins = margins2;
            Chart1.Size = new Size(1149, 236);
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.SubFooter.Brush.Color = Color.Silver;
            Chart1.SubFooter.Brush.Solid = true;
            Chart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            Chart1.SubFooter.Font.Brush.Color = Color.Red;
            Chart1.SubFooter.Font.Brush.Solid = true;
            Chart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.SubFooter.Font.Shadow.Brush.Solid = true;
            Chart1.SubFooter.Font.Shadow.Brush.Visible = true;
            Chart1.SubFooter.Font.Size = 8;
            Chart1.SubFooter.Font.SizeFloat = 8F;
            Chart1.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.SubFooter.ImageBevel.Brush.Solid = true;
            Chart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.SubFooter.Shadow.Brush.Color = Color.DarkGray;
            Chart1.SubFooter.Shadow.Brush.Solid = true;
            Chart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.SubHeader.Brush.Color = Color.FromArgb(192, 192, 192);
            Chart1.SubHeader.Brush.Solid = true;
            Chart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            Chart1.SubHeader.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart1.SubHeader.Font.Brush.Solid = true;
            Chart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.SubHeader.Font.Shadow.Brush.Solid = true;
            Chart1.SubHeader.Font.Shadow.Brush.Visible = true;
            Chart1.SubHeader.Font.Size = 12;
            Chart1.SubHeader.Font.SizeFloat = 12F;
            Chart1.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.SubHeader.ImageBevel.Brush.Solid = true;
            Chart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.SubHeader.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            Chart1.SubHeader.Shadow.Brush.Solid = true;
            Chart1.SubHeader.Shadow.Brush.Visible = true;
            Chart1.TabIndex = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Walls.Back.Brush.Color = Color.Silver;
            Chart1.Walls.Back.Brush.Solid = true;
            Chart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Walls.Back.ImageBevel.Brush.Solid = true;
            Chart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Walls.Back.Shadow.Brush.Solid = true;
            Chart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Walls.Bottom.Brush.Color = Color.White;
            Chart1.Walls.Bottom.Brush.Solid = true;
            Chart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            Chart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Walls.Bottom.Shadow.Brush.Solid = true;
            Chart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Walls.Left.Brush.Color = Color.LightYellow;
            Chart1.Walls.Left.Brush.Solid = true;
            Chart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Walls.Left.ImageBevel.Brush.Solid = true;
            Chart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Walls.Left.Shadow.Brush.Solid = true;
            Chart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Walls.Right.Brush.Color = Color.LightYellow;
            Chart1.Walls.Right.Brush.Solid = true;
            Chart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Walls.Right.ImageBevel.Brush.Solid = true;
            Chart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Walls.Right.Shadow.Brush.Solid = true;
            Chart1.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Zoom.Brush.Color = Color.LightBlue;
            Chart1.Zoom.Brush.Solid = true;
            Chart1.Zoom.Brush.Visible = false;
            // 
            // 
            // 
            Chart1.Zoom.Pen.Visible = true;
            Chart1.Click += Chart1_Click;
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
            SpectrumAnalyzer1.Input = Signal1;
            SpectrumAnalyzer1.IsDouble = true;
            SpectrumAnalyzer1.Length = 64;
            SpectrumAnalyzer1.LogBase = 0D;
            SpectrumAnalyzer1.LogScale = 0D;
            SpectrumAnalyzer1.MainlobeWidth = 8;
            SpectrumAnalyzer1.Peaks.HarmonicsCount = 10;
            SpectrumAnalyzer1.Peaks.Interpolation.RecursiveHarmonics = TRecursiveHarmonics.rhNone;
            SpectrumAnalyzer1.Peaks.LargestCount = 4;
            SpectrumAnalyzer1.Peaks.LargestRatio = 1E+15D;
            SpectrumAnalyzer1.Peaks.NormalizedAmplt.PeakNumber = 1;
            SpectrumAnalyzer1.Peaks.NormalizedFreq.PeakNumber = 1;
            SpectrumAnalyzer1.Peaks.TraceMethod = TPeakTraceMethod.ptLargest;
            SpectrumAnalyzer1.Report.AmplitudeFormat = null;
            SpectrumAnalyzer1.Report.FrequencyFormat = null;
            SpectrumAnalyzer1.Report.PhaseFormat = null;
            SpectrumAnalyzer1.Report.UseTab = false;
            SpectrumAnalyzer1.Rotation = 0;
            SpectrumAnalyzer1.Stats.Averaged = 0;
            SpectrumAnalyzer1.Stats.Averages = 30;
            SpectrumAnalyzer1.Stats.ExpDecay = 5;
            SpectrumAnalyzer1.Window = TSignalWindowType.wtHanning;
            SpectrumAnalyzer1.ZeroPadding = 1;
            // 
            // Signal1
            // 
            Signal1.ChannelCount = 1;
            Signal1.Complex = false;
            Signal1.Continuous = false;
            Signal1.DataSerialization = resources.GetString("Signal1.DataSerialization");
            Signal1.FloatPrecision = TMtxFloatPrecision.mvDouble;
            Signal1.FloatPrecisionLock = false;
            Signal1.IsDouble = true;
            Signal1.Length = 256;
            Signal1.SamplingFrequency = 256D;
            Signal1.OnAfterUpdateEvent += Signal1_OnAfterUpdate;
            // 
            // BiSpectrumAnalyzer1
            // 
            BiSpectrumAnalyzer1.ArOrder = 100;
            BiSpectrumAnalyzer1.Bands.TemplateIndex = -1;
            BiSpectrumAnalyzer1.Bands.TemplatesSerialization = "AAAAAA==";
            BiSpectrumAnalyzer1.BiAnalyzer.LinesSerialization = "AAAAAAAAAAAAAAAAAACAPwAAAAAAgB9EAAAAQQAAAAAAE3pHAAAAAAAAAAAAAAAA";
            BiSpectrumAnalyzer1.BiAnalyzer.Recursive = false;
            BiSpectrumAnalyzer1.Complex = false;
            BiSpectrumAnalyzer1.FloatPrecision = TMtxFloatPrecision.mvDouble;
            BiSpectrumAnalyzer1.FloatPrecisionLock = false;
            BiSpectrumAnalyzer1.Harmonics = 10;
            BiSpectrumAnalyzer1.Input = Signal1;
            BiSpectrumAnalyzer1.IsDouble = true;
            BiSpectrumAnalyzer1.Length = 64;
            BiSpectrumAnalyzer1.LogBase = 0D;
            BiSpectrumAnalyzer1.LogScale = 0D;
            BiSpectrumAnalyzer1.MainlobeWidth = 8;
            BiSpectrumAnalyzer1.Peaks.HarmonicsCount = 10;
            BiSpectrumAnalyzer1.Peaks.Interpolation.Method = TInterpolationMethod.imNone;
            BiSpectrumAnalyzer1.Peaks.Interpolation.RecursiveHarmonics = TRecursiveHarmonics.rhNone;
            BiSpectrumAnalyzer1.Peaks.LargestCount = 1;
            BiSpectrumAnalyzer1.Peaks.LargestRatio = 1E+15D;
            BiSpectrumAnalyzer1.Peaks.NormalizedAmplt.PeakNumber = 1;
            BiSpectrumAnalyzer1.Peaks.NormalizedFreq.PeakNumber = 1;
            BiSpectrumAnalyzer1.Report.AmplitudeFormat = null;
            BiSpectrumAnalyzer1.Report.FrequencyFormat = null;
            BiSpectrumAnalyzer1.Report.PhaseFormat = null;
            BiSpectrumAnalyzer1.Report.UseTab = false;
            BiSpectrumAnalyzer1.Rotation = 0;
            BiSpectrumAnalyzer1.SidelobeAtt = 60D;
            BiSpectrumAnalyzer1.Stats.Averaged = 0;
            BiSpectrumAnalyzer1.Stats.Averages = 30;
            BiSpectrumAnalyzer1.Stats.Averaging = TAveraging.avLinearInf;
            BiSpectrumAnalyzer1.Stats.ExpDecay = 5;
            BiSpectrumAnalyzer1.Window = TSignalWindowType.wtKaiser;
            BiSpectrumAnalyzer1.ZeroPadding = 1;
            // 
            // ChartEditor
            // 
            ChartEditor.AlwaysShowFuncSrc = false;
            ChartEditor.Chart = Chart1;
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
            // BicoherenceTestForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(1149, 868);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Name = "BicoherenceTestForm";
            Text = "BicoherenceTestForm";
            Load += BicoherenceTestForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((ISupportInitialize)SpectrumChart1).EndInit();
            ResumeLayout(false);

        }
        #endregion

        private void button1_Click(object sender, System.EventArgs e) {
			SignalUtils.ToneInit(Freq1Edit.Position/Signal1.SamplingFrequency,0,1,ref toneState1, false);
			SignalUtils.ToneInit(Freq2Edit.Position/Signal1.SamplingFrequency,0,1,ref toneState2, false);
			BiSpectrumAnalyzer1.ResetAveraging();
      BiSpectrumAnalyzer1.Window = SpectrumAnalyzer1.Window;
			for (int i=0;i<25;i++) {
				BiSpectrumAnalyzer1.Pull();
			}
			BiSpectrumAnalyzer1.BiAnalyzer.Update(); //compute bicoherence
			BiSpectrumAnalyzer1.BiAnalyzer.GetFullSpectrum(bMtx, true);  //get result

			gridSeries.Clear();
			gridSeries.Matrix = bMtx;
			gridSeries.Repaint();

			SpectrumAnalyzer1.Update();
		}

		private TMtx bMtx;
		private TToneState toneState1, toneState2;
		private MtxGridSeries gridSeries;

		private void Signal1_OnAfterUpdate(object Sender) {
			TVec tone1, tone2;
			MtxVec.CreateIt(out tone1, out tone2);
			try {
				tone1.Size(Signal1.Data);
				tone2.Size(Signal1.Data);
				SignalUtils.Tone(tone1, ref toneState1);
				SignalUtils.Tone(tone2, ref toneState2);

				Signal1.Data.Copy(tone1);
				Signal1.Data.Add(tone2);
				tone2.Mul(tone1);
				tone1.RandGauss(0, 0.1);
				Signal1.Data.Add(tone2);
				Signal1.Data.Add(tone1);
			} finally {
				MtxVec.FreeIt(ref tone1, ref tone2);
			}
		}

		private void Freq1Edit_TextChanged(object sender, System.EventArgs e) {
			button1_Click(sender, e);
		}

		private void Freq2Edit_TextChanged(object sender, System.EventArgs e) {
			button1_Click(sender, e);
		}

		private void panel2_SizeChanged(object sender, System.EventArgs e) {
			Chart1.Height = (int)(panel2.Height * 0.66);
		}

        protected void Add(String s)
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void BicoherenceTestForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("This test feeds the bispectrum analyzer with "
                + "the following test signal: Sin(w1)+Sin(w2)+Sin(w1)*Sin(w1)+Some_Gaussian_Noise. "
                + "The result should be two dots. Sum and difference frequencies "
                + "in the bicoherence spectrum located at (w1,w2-w1) and (w2,w1)");
        }

        private void SpectrumButton_Click(object sender, EventArgs e)
        {
            SpectrumAnalyzerDialog.ExecuteModal();
        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }

        private void ChartButton_Click(object sender, EventArgs e)
        {
            ChartEditor.ShowModal();
        }
	}
}
