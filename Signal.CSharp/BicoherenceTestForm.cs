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
            this.components = new System.ComponentModel.Container();
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BicoherenceTestForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.Freq2Edit = new Dew.Math.Controls.FloatEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.Freq1Edit = new Dew.Math.Controls.FloatEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.SpectrumButton = new System.Windows.Forms.Button();
            this.ChartButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SpectrumChart1 = new Dew.Signal.Tee.SpectrumChart();
            this.Series1 = new Steema.TeeChart.Styles.FastLine();
            this.Series2 = new Steema.TeeChart.Styles.Points();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Chart1 = new Steema.TeeChart.TChart();
            this.SpectrumAnalyzer1 = new Dew.Signal.TSpectrumAnalyzer(this.components);
            this.Signal1 = new Dew.Signal.TSignal(this.components);
            this.BiSpectrumAnalyzer1 = new Dew.Signal.TBiSpectrumAnalyzer(this.components);
            this.ChartEditor = new Steema.TeeChart.Editor(this.components);
            this.SpectrumAnalyzerDialog = new Dew.Signal.SpectrumAnalyzerDialog(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpectrumChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(811, 89);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.Freq2Edit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Freq1Edit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SpectrumButton);
            this.panel1.Controls.Add(this.ChartButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 48);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "Recalculate";
            // 
            // Freq2Edit
            // 
            this.Freq2Edit.Increment = "1";
            this.Freq2Edit.Location = new System.Drawing.Point(568, 11);
            this.Freq2Edit.Name = "Freq2Edit";
            this.Freq2Edit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.Freq2Edit.Scientific = false;
            this.Freq2Edit.Size = new System.Drawing.Size(76, 23);
            this.Freq2Edit.TabIndex = 4;
            this.Freq2Edit.Value = "80.00";
            this.Freq2Edit.TextChanged += new System.EventHandler(this.Freq2Edit_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(520, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Freq2:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Freq1Edit
            // 
            this.Freq1Edit.Increment = "1";
            this.Freq1Edit.Location = new System.Drawing.Point(414, 11);
            this.Freq1Edit.Name = "Freq1Edit";
            this.Freq1Edit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.Freq1Edit.Scientific = false;
            this.Freq1Edit.Size = new System.Drawing.Size(77, 23);
            this.Freq1Edit.TabIndex = 2;
            this.Freq1Edit.Value = "20.00";
            this.Freq1Edit.TextChanged += new System.EventHandler(this.Freq1Edit_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(328, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Freq1:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SpectrumButton
            // 
            this.SpectrumButton.Location = new System.Drawing.Point(14, 11);
            this.SpectrumButton.Name = "SpectrumButton";
            this.SpectrumButton.Size = new System.Drawing.Size(90, 28);
            this.SpectrumButton.TabIndex = 0;
            this.SpectrumButton.Text = "Spectrum...";
            this.SpectrumButton.Click += new System.EventHandler(this.SpectrumButton_Click);
            // 
            // ChartButton
            // 
            this.ChartButton.Location = new System.Drawing.Point(124, 11);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(90, 28);
            this.ChartButton.TabIndex = 0;
            this.ChartButton.Text = "Chart...";
            this.ChartButton.Click += new System.EventHandler(this.ChartButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SpectrumChart1);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.Chart1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 388);
            this.panel2.TabIndex = 2;
            this.panel2.SizeChanged += new System.EventHandler(this.panel2_SizeChanged);
            // 
            // SpectrumChart1
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Automatic = false;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Automatic = true;
            this.SpectrumChart1.Axes.Bottom.AutomaticMaximum = true;
            this.SpectrumChart1.Axes.Bottom.AutomaticMinimum = true;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Grid.DrawEvery = 1;
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            this.SpectrumChart1.Axes.Bottom.Maximum = 0D;
            this.SpectrumChart1.Axes.Bottom.MaximumOffset = 4;
            this.SpectrumChart1.Axes.Bottom.Minimum = 0D;
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
            this.SpectrumChart1.Axes.Depth.Automatic = false;
            this.SpectrumChart1.Axes.Depth.AutomaticMaximum = false;
            this.SpectrumChart1.Axes.Depth.AutomaticMinimum = false;
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
            this.SpectrumChart1.Axes.Depth.Maximum = 0D;
            this.SpectrumChart1.Axes.Depth.Minimum = 0D;
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
            this.SpectrumChart1.Axes.DepthTop.Automatic = false;
            this.SpectrumChart1.Axes.DepthTop.AutomaticMaximum = false;
            this.SpectrumChart1.Axes.DepthTop.AutomaticMinimum = false;
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
            this.SpectrumChart1.Axes.DepthTop.Maximum = 0D;
            this.SpectrumChart1.Axes.DepthTop.Minimum = 0D;
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
            this.SpectrumChart1.Axes.Left.Automatic = false;
            this.SpectrumChart1.Axes.Left.AutomaticMaximum = false;
            this.SpectrumChart1.Axes.Left.AutomaticMinimum = false;
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
            this.SpectrumChart1.Axes.Left.Maximum = 0D;
            this.SpectrumChart1.Axes.Left.MaximumOffset = 4;
            this.SpectrumChart1.Axes.Left.Minimum = 0D;
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
            this.SpectrumChart1.Axes.Right.Automatic = false;
            this.SpectrumChart1.Axes.Right.AutomaticMaximum = false;
            this.SpectrumChart1.Axes.Right.AutomaticMinimum = false;
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
            this.SpectrumChart1.Axes.Right.Maximum = 0D;
            this.SpectrumChart1.Axes.Right.Minimum = 0D;
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
            this.SpectrumChart1.Axes.Top.Automatic = false;
            this.SpectrumChart1.Axes.Top.AutomaticMaximum = false;
            this.SpectrumChart1.Axes.Top.AutomaticMinimum = false;
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
            this.SpectrumChart1.Axes.Top.Maximum = 0D;
            this.SpectrumChart1.Axes.Top.Minimum = 0D;
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
            this.SpectrumChart1.Color = System.Drawing.Color.Silver;
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
            this.SpectrumChart1.Legend.Visible = false;
            this.SpectrumChart1.Location = new System.Drawing.Point(0, 240);
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
            this.SpectrumChart1.Panel.Brush.Color = System.Drawing.Color.Silver;
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
            this.SpectrumChart1.Series.Add(this.Series1);
            this.SpectrumChart1.Series.Add(this.Series2);
            this.SpectrumChart1.Size = new System.Drawing.Size(811, 148);
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
            this.SpectrumChart1.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.SpectrumChart1.Zoom.Brush.Solid = true;
            this.SpectrumChart1.Zoom.Brush.Visible = false;
            this.SpectrumChart1.Zoom.FullRepaint = true;
            // 
            // 
            // 
            this.SpectrumChart1.Zoom.Pen.Visible = true;
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
            this.Series1.OriginalCursor = null;
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
            // Series2
            // 
            // 
            // 
            // 
            this.Series2.Brush.Color = System.Drawing.Color.Empty;
            this.Series2.Brush.Solid = true;
            this.Series2.Brush.Visible = true;
            this.Series2.Color = System.Drawing.Color.Red;
            this.Series2.ColorEach = false;
            this.Series2.Cursor = cursor1;
            // 
            // 
            // 
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
            this.Series2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            // 
            // 
            // 
            this.Series2.Marks.Arrow.Visible = false;
            this.Series2.Marks.ArrowLength = 10;
            // 
            // 
            // 
            this.Series2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Series2.Marks.Brush.Solid = true;
            this.Series2.Marks.Brush.Visible = false;
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
            this.Series2.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.Series2.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
            this.Series2.Marks.TailParams.Margin = 0F;
            this.Series2.Marks.TailParams.PointerHeight = 8D;
            this.Series2.Marks.TailParams.PointerWidth = 8D;
            this.Series2.Marks.Transparent = true;
            this.Series2.Marks.Visible = true;
            this.Series2.OriginalCursor = null;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Pointer.Brush.Color = System.Drawing.Color.Red;
            this.Series2.Pointer.Brush.Solid = true;
            this.Series2.Pointer.Brush.Visible = true;
            this.Series2.Pointer.HorizSize = 3;
            // 
            // 
            // 
            this.Series2.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Series2.Pointer.SizeDouble = 0D;
            this.Series2.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.Series2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.Series2.Pointer.VertSize = 3;
            this.Series2.RandomData = true;
            this.Series2.Title = "point1";
            this.Series2.Type = "Steema.TeeChart.Styles.Points";
            this.Series2.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.Series2.XValues.DataMember = "X";
            this.Series2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.Series2.XValues.Series = this.Series2;
            // 
            // 
            // 
            this.Series2.YValues.DataMember = "Y";
            this.Series2.YValues.Series = this.Series2;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 236);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(811, 4);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
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
            this.Chart1.Axes.Bottom.Grid.DrawEvery = 1;
            this.Chart1.Axes.Bottom.Grid.Visible = false;
            // 
            // 
            // 
            this.Chart1.Axes.Bottom.Labels.Axis = this.Chart1.Axes.Bottom;
            // 
            // 
            // 
            this.Chart1.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.Chart1.Axes.Bottom.Labels.Brush.Solid = true;
            this.Chart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.Chart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Chart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.Chart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.Chart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.Chart1.Axes.Bottom.Labels.Font.Size = 9;
            this.Chart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            this.Chart1.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.Chart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.Chart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.Axes.Bottom.MinorTicks.Length = 2;
            this.Chart1.Axes.Bottom.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.Chart1.Axes.Bottom.Ticks.Length = 4;
            this.Chart1.Axes.Bottom.Ticks.Visible = false;
            // 
            // 
            // 
            this.Chart1.Axes.Bottom.TicksInner.Length = 0;
            this.Chart1.Axes.Bottom.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.Chart1.Axes.Bottom.Title.Brush.Solid = true;
            this.Chart1.Axes.Bottom.Title.Brush.Visible = true;
            this.Chart1.Axes.Bottom.Title.Caption = "Frequency [Hz]";
            // 
            // 
            // 
            this.Chart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.Chart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Chart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.Chart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.Chart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.Chart1.Axes.Bottom.Title.Font.Size = 11;
            this.Chart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            this.Chart1.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.Chart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            this.Chart1.Axes.Bottom.Title.Lines = new string[] {
        "Frequency [Hz]"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.Chart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Depth.AxisPen.Visible = false;
            // 
            // 
            // 
            this.Chart1.Axes.Depth.Labels.Axis = this.Chart1.Axes.Depth;
            // 
            // 
            // 
            this.Chart1.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.Chart1.Axes.Depth.Labels.Brush.Solid = true;
            this.Chart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.Chart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Chart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.Chart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.Chart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.Chart1.Axes.Depth.Labels.Font.Size = 9;
            this.Chart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            this.Chart1.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.Chart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.Chart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.Axes.Depth.MinorTicks.Length = 2;
            this.Chart1.Axes.Depth.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.Chart1.Axes.Depth.Ticks.Length = 4;
            this.Chart1.Axes.Depth.Ticks.Visible = false;
            // 
            // 
            // 
            this.Chart1.Axes.Depth.TicksInner.Length = 0;
            this.Chart1.Axes.Depth.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.Chart1.Axes.Depth.Title.Brush.Solid = true;
            this.Chart1.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.Chart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Chart1.Axes.Depth.Title.Font.Brush.Solid = true;
            this.Chart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.Chart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.Chart1.Axes.Depth.Title.Font.Size = 11;
            this.Chart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            this.Chart1.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.Chart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.Chart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.DepthTop.AxisPen.Visible = false;
            // 
            // 
            // 
            this.Chart1.Axes.DepthTop.Labels.Axis = this.Chart1.Axes.DepthTop;
            // 
            // 
            // 
            this.Chart1.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.Chart1.Axes.DepthTop.Labels.Brush.Solid = true;
            this.Chart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.Chart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Chart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.Chart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.Chart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.Chart1.Axes.DepthTop.Labels.Font.Size = 9;
            this.Chart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            this.Chart1.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.Chart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.Chart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.Axes.DepthTop.MinorTicks.Length = 2;
            this.Chart1.Axes.DepthTop.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.Chart1.Axes.DepthTop.Ticks.Length = 4;
            this.Chart1.Axes.DepthTop.Ticks.Visible = false;
            // 
            // 
            // 
            this.Chart1.Axes.DepthTop.TicksInner.Length = 0;
            this.Chart1.Axes.DepthTop.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.Chart1.Axes.DepthTop.Title.Brush.Solid = true;
            this.Chart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.Chart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Chart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.Chart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.Chart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.Chart1.Axes.DepthTop.Title.Font.Size = 11;
            this.Chart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            this.Chart1.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.Chart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.Chart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Left.AxisPen.Visible = false;
            // 
            // 
            // 
            this.Chart1.Axes.Left.Labels.Axis = this.Chart1.Axes.Left;
            // 
            // 
            // 
            this.Chart1.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.Chart1.Axes.Left.Labels.Brush.Solid = true;
            this.Chart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.Chart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Chart1.Axes.Left.Labels.Font.Brush.Solid = true;
            this.Chart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.Chart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.Chart1.Axes.Left.Labels.Font.Size = 9;
            this.Chart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            this.Chart1.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.Chart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.Chart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.Axes.Left.MinorTicks.Length = 2;
            this.Chart1.Axes.Left.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.Chart1.Axes.Left.Ticks.Length = 4;
            this.Chart1.Axes.Left.Ticks.Visible = false;
            // 
            // 
            // 
            this.Chart1.Axes.Left.TicksInner.Length = 0;
            this.Chart1.Axes.Left.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.Chart1.Axes.Left.Title.Brush.Solid = true;
            this.Chart1.Axes.Left.Title.Brush.Visible = true;
            this.Chart1.Axes.Left.Title.Caption = "Frequency [Hz]";
            // 
            // 
            // 
            this.Chart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.Chart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Chart1.Axes.Left.Title.Font.Brush.Solid = true;
            this.Chart1.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.Chart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.Chart1.Axes.Left.Title.Font.Size = 11;
            this.Chart1.Axes.Left.Title.Font.SizeFloat = 11F;
            this.Chart1.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.Chart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            this.Chart1.Axes.Left.Title.Lines = new string[] {
        "Frequency [Hz]"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.Chart1.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Right.AxisPen.Visible = false;
            // 
            // 
            // 
            this.Chart1.Axes.Right.Labels.Axis = this.Chart1.Axes.Right;
            // 
            // 
            // 
            this.Chart1.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.Chart1.Axes.Right.Labels.Brush.Solid = true;
            this.Chart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.Chart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Chart1.Axes.Right.Labels.Font.Brush.Solid = true;
            this.Chart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.Chart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.Chart1.Axes.Right.Labels.Font.Size = 9;
            this.Chart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            this.Chart1.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.Chart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.Chart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.Axes.Right.MinorTicks.Length = 2;
            this.Chart1.Axes.Right.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.Chart1.Axes.Right.Ticks.Length = 4;
            this.Chart1.Axes.Right.Ticks.Visible = false;
            // 
            // 
            // 
            this.Chart1.Axes.Right.TicksInner.Length = 0;
            this.Chart1.Axes.Right.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.Chart1.Axes.Right.Title.Brush.Solid = true;
            this.Chart1.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.Chart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Chart1.Axes.Right.Title.Font.Brush.Solid = true;
            this.Chart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.Chart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.Chart1.Axes.Right.Title.Font.Size = 11;
            this.Chart1.Axes.Right.Title.Font.SizeFloat = 11F;
            this.Chart1.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.Chart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.Chart1.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Top.Labels.Axis = this.Chart1.Axes.Top;
            // 
            // 
            // 
            this.Chart1.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.Chart1.Axes.Top.Labels.Brush.Solid = true;
            this.Chart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.Chart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Chart1.Axes.Top.Labels.Font.Brush.Solid = true;
            this.Chart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.Chart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.Chart1.Axes.Top.Labels.Font.Size = 9;
            this.Chart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            this.Chart1.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.Chart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.Chart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.Axes.Top.MinorTicks.Length = 2;
            this.Chart1.Axes.Top.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.Chart1.Axes.Top.Ticks.Length = 4;
            this.Chart1.Axes.Top.Ticks.Visible = false;
            // 
            // 
            // 
            this.Chart1.Axes.Top.TicksInner.Length = 0;
            this.Chart1.Axes.Top.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.Chart1.Axes.Top.Title.Brush.Solid = true;
            this.Chart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.Chart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Chart1.Axes.Top.Title.Font.Brush.Solid = true;
            this.Chart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.Chart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.Chart1.Axes.Top.Title.Font.Size = 11;
            this.Chart1.Axes.Top.Title.Font.SizeFloat = 11F;
            this.Chart1.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.Chart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.Chart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.Chart1.Dock = System.Windows.Forms.DockStyle.Top;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.Chart1.Footer.Brush.Solid = true;
            this.Chart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.Chart1.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.Chart1.Footer.Font.Brush.Solid = true;
            this.Chart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Footer.Font.Shadow.Brush.Solid = true;
            this.Chart1.Footer.Font.Shadow.Brush.Visible = true;
            this.Chart1.Footer.Font.Size = 8;
            this.Chart1.Footer.Font.SizeFloat = 8F;
            this.Chart1.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart1.Footer.ImageBevel.Brush.Solid = true;
            this.Chart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Footer.Shadow.Brush.Solid = true;
            this.Chart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Chart1.Header.Brush.Solid = true;
            this.Chart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.Header.Font.Bold = false;
            // 
            // 
            // 
            this.Chart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Chart1.Header.Font.Brush.Solid = true;
            this.Chart1.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Header.Font.Shadow.Brush.Solid = true;
            this.Chart1.Header.Font.Shadow.Brush.Visible = true;
            this.Chart1.Header.Font.Size = 12;
            this.Chart1.Header.Font.SizeFloat = 12F;
            this.Chart1.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart1.Header.ImageBevel.Brush.Solid = true;
            this.Chart1.Header.ImageBevel.Brush.Visible = true;
            this.Chart1.Header.Lines = new string[] {
        "Bicoherence"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Chart1.Header.Shadow.Brush.Solid = true;
            this.Chart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Legend.Brush.Color = System.Drawing.Color.White;
            this.Chart1.Legend.Brush.Solid = true;
            this.Chart1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.Chart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Chart1.Legend.Font.Brush.Solid = true;
            this.Chart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Legend.Font.Shadow.Brush.Solid = true;
            this.Chart1.Legend.Font.Shadow.Brush.Visible = true;
            this.Chart1.Legend.Font.Size = 9;
            this.Chart1.Legend.Font.SizeFloat = 9F;
            this.Chart1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart1.Legend.ImageBevel.Brush.Solid = true;
            this.Chart1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.Legend.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Chart1.Legend.Shadow.Brush.Solid = true;
            this.Chart1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.Legend.Symbol.Legend = this.Chart1.Legend;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Legend.Symbol.Shadow.Brush.Solid = true;
            this.Chart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.Chart1.Legend.Title.Brush.Solid = true;
            this.Chart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.Chart1.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.Chart1.Legend.Title.Font.Brush.Solid = true;
            this.Chart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.Chart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.Chart1.Legend.Title.Font.Size = 8;
            this.Chart1.Legend.Title.Font.SizeFloat = 8F;
            this.Chart1.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart1.Legend.Title.ImageBevel.Brush.Solid = true;
            this.Chart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.Legend.Title.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Legend.Title.Shadow.Brush.Solid = true;
            this.Chart1.Legend.Title.Shadow.Brush.Visible = true;
            this.Chart1.Location = new System.Drawing.Point(0, 0);
            this.Chart1.Name = "Chart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            // 
            // 
            // 
            this.Chart1.Panel.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.Chart1.Panel.Brush.Gradient.UseMiddle = true;
            this.Chart1.Panel.Brush.Solid = true;
            this.Chart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart1.Panel.ImageBevel.Brush.Solid = true;
            this.Chart1.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.Panel.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Panel.Shadow.Brush.Solid = true;
            this.Chart1.Panel.Shadow.Brush.Visible = true;
            this.Chart1.Size = new System.Drawing.Size(811, 236);
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.Chart1.SubFooter.Brush.Solid = true;
            this.Chart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.Chart1.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.Chart1.SubFooter.Font.Brush.Solid = true;
            this.Chart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.SubFooter.Font.Shadow.Brush.Solid = true;
            this.Chart1.SubFooter.Font.Shadow.Brush.Visible = true;
            this.Chart1.SubFooter.Font.Size = 8;
            this.Chart1.SubFooter.Font.SizeFloat = 8F;
            this.Chart1.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart1.SubFooter.ImageBevel.Brush.Solid = true;
            this.Chart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.SubFooter.Shadow.Brush.Solid = true;
            this.Chart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Chart1.SubHeader.Brush.Solid = true;
            this.Chart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.Chart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.Chart1.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Chart1.SubHeader.Font.Brush.Solid = true;
            this.Chart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.SubHeader.Font.Shadow.Brush.Solid = true;
            this.Chart1.SubHeader.Font.Shadow.Brush.Visible = true;
            this.Chart1.SubHeader.Font.Size = 12;
            this.Chart1.SubHeader.Font.SizeFloat = 12F;
            this.Chart1.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart1.SubHeader.ImageBevel.Brush.Solid = true;
            this.Chart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Chart1.SubHeader.Shadow.Brush.Solid = true;
            this.Chart1.SubHeader.Shadow.Brush.Visible = true;
            this.Chart1.TabIndex = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.Chart1.Walls.Back.Brush.Solid = true;
            this.Chart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart1.Walls.Back.ImageBevel.Brush.Solid = true;
            this.Chart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Walls.Back.Shadow.Brush.Solid = true;
            this.Chart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.Chart1.Walls.Bottom.Brush.Solid = true;
            this.Chart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.Chart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Walls.Bottom.Shadow.Brush.Solid = true;
            this.Chart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.Chart1.Walls.Left.Brush.Solid = true;
            this.Chart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart1.Walls.Left.ImageBevel.Brush.Solid = true;
            this.Chart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Walls.Left.Shadow.Brush.Solid = true;
            this.Chart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.Chart1.Walls.Right.Brush.Solid = true;
            this.Chart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart1.Walls.Right.ImageBevel.Brush.Solid = true;
            this.Chart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Walls.Right.Shadow.Brush.Solid = true;
            this.Chart1.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.Chart1.Zoom.Brush.Solid = true;
            this.Chart1.Zoom.Brush.Visible = false;
            this.Chart1.Zoom.FullRepaint = true;
            // 
            // 
            // 
            this.Chart1.Zoom.Pen.Visible = true;
            this.Chart1.Click += new System.EventHandler(this.Chart1_Click);
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
            this.SpectrumAnalyzer1.Input = this.Signal1;
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
            this.SpectrumAnalyzer1.Peaks.Interpolation.RecursiveHarmonics = Dew.Signal.TRecursiveHarmonics.rhNone;
            this.SpectrumAnalyzer1.Peaks.LargestCount = 4;
            this.SpectrumAnalyzer1.Peaks.TraceMethod = Dew.Signal.TPeakTraceMethod.ptLargest;
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
            // Signal1
            // 
            this.Signal1.BandwidthL = 0D;
            this.Signal1.BlockAssign = false;
            this.Signal1.ChannelCount = 1;
            this.Signal1.Complex = false;
            this.Signal1.Continuous = false;
            this.Signal1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.Signal1.FloatPrecisionLock = false;
            this.Signal1.Input = null;
            this.Signal1.IsDouble = true;
            this.Signal1.Length = 256;
            this.Signal1.Name = "";
            this.Signal1.OnAfterUpdate = null;
            this.Signal1.OnBeforeUpdate = null;
            this.Signal1.OnDisplayUpdate = null;
            this.Signal1.OnGetInput = null;
            this.Signal1.OnNotifyUpdate = null;
            this.Signal1.OnParameterUpdate = null;
            this.Signal1.SamplingFrequency = 256D;
            this.Signal1.OnAfterUpdateEvent += new Dew.Math.TNotifyEvent(this.Signal1_OnAfterUpdateEvent);
            // 
            // BiSpectrumAnalyzer1
            // 
            this.BiSpectrumAnalyzer1.ArOrder = 100;
            this.BiSpectrumAnalyzer1.Bands.TemplateIndex = -1;
            this.BiSpectrumAnalyzer1.Bands.Templates = ((Dew.Signal.TStringStreamList)(resources.GetObject("resource.Templates1")));
            this.BiSpectrumAnalyzer1.BiAnalyzer.Lines = ((Dew.Math.TVec)(resources.GetObject("resource.Lines")));
            this.BiSpectrumAnalyzer1.BiAnalyzer.Recursive = false;
            this.BiSpectrumAnalyzer1.BlockAssign = false;
            this.BiSpectrumAnalyzer1.Complex = false;
            this.BiSpectrumAnalyzer1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.BiSpectrumAnalyzer1.FloatPrecisionLock = false;
            this.BiSpectrumAnalyzer1.Harmonics = 10;
            this.BiSpectrumAnalyzer1.Input = this.Signal1;
            this.BiSpectrumAnalyzer1.IsDouble = true;
            this.BiSpectrumAnalyzer1.Length = 64;
            this.BiSpectrumAnalyzer1.LogBase = 0D;
            this.BiSpectrumAnalyzer1.LogScale = 0D;
            this.BiSpectrumAnalyzer1.MainlobeWidth = 8;
            this.BiSpectrumAnalyzer1.Name = "";
            this.BiSpectrumAnalyzer1.OnAfterAverage = null;
            this.BiSpectrumAnalyzer1.OnAfterComplexSpectrum = null;
            this.BiSpectrumAnalyzer1.OnAfterUpdate = null;
            this.BiSpectrumAnalyzer1.OnBandsUpdate = null;
            this.BiSpectrumAnalyzer1.OnBeforeAverage = null;
            this.BiSpectrumAnalyzer1.OnBeforeSpectrumType = null;
            this.BiSpectrumAnalyzer1.OnBeforeUpdate = null;
            this.BiSpectrumAnalyzer1.OnDisplayUpdate = null;
            this.BiSpectrumAnalyzer1.OnGetInput = null;
            this.BiSpectrumAnalyzer1.OnGetSpectrum = null;
            this.BiSpectrumAnalyzer1.OnNotifyUpdate = null;
            this.BiSpectrumAnalyzer1.OnParameterUpdate = null;
            this.BiSpectrumAnalyzer1.OnPeaksUpdate = null;
            this.BiSpectrumAnalyzer1.OnUpdateSpectrum = null;
            this.BiSpectrumAnalyzer1.Output = null;
            this.BiSpectrumAnalyzer1.Peaks.HarmonicsCount = 10;
            this.BiSpectrumAnalyzer1.Peaks.Interpolation.Method = Dew.Signal.TInterpolationMethod.imNone;
            this.BiSpectrumAnalyzer1.Peaks.Interpolation.RecursiveHarmonics = Dew.Signal.TRecursiveHarmonics.rhNone;
            this.BiSpectrumAnalyzer1.Peaks.LargestCount = 1;
            this.BiSpectrumAnalyzer1.Report.AmplitudeFormat = null;
            this.BiSpectrumAnalyzer1.Report.FrequencyFormat = null;
            this.BiSpectrumAnalyzer1.Report.PhaseFormat = null;
            this.BiSpectrumAnalyzer1.Report.UseTab = false;
            this.BiSpectrumAnalyzer1.Rotation = 0;
            this.BiSpectrumAnalyzer1.SidelobeAtt = 60D;
            this.BiSpectrumAnalyzer1.SpectrumScale = 0D;
            this.BiSpectrumAnalyzer1.Stats.Averaged = 0;
            this.BiSpectrumAnalyzer1.Stats.Averages = 30;
            this.BiSpectrumAnalyzer1.Stats.Averaging = Dew.Signal.TAveraging.avLinearInf;
            this.BiSpectrumAnalyzer1.Stats.ExpDecay = 5;
            this.BiSpectrumAnalyzer1.Window = Dew.Signal.TSignalWindowType.wtKaiser;
            this.BiSpectrumAnalyzer1.ZeroPadding = 1;
            // 
            // ChartEditor
            // 
            this.ChartEditor.AlwaysShowFuncSrc = false;
            this.ChartEditor.Chart = this.Chart1;
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
            this.SpectrumAnalyzerDialog.Source = this.SpectrumAnalyzer1;
            this.SpectrumAnalyzerDialog.SourceListIndex = 0;
            // 
            // BicoherenceTestForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(811, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "BicoherenceTestForm";
            this.Text = "BicoherenceTestForm";
            this.Load += new System.EventHandler(this.BicoherenceTestForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpectrumChart1)).EndInit();
            this.ResumeLayout(false);

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

        private void Signal1_OnAfterUpdateEvent(object Sender)
        {
            TVec tone1, tone2;
            MtxVec.CreateIt(out tone1, out tone2);
            try
            {
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
            }
            finally
            {
                MtxVec.FreeIt(ref tone1, ref tone2);
            }
        }

        private void ChartButton_Click(object sender, EventArgs e)
        {
            ChartEditor.ShowModal();
        }
	}
}
