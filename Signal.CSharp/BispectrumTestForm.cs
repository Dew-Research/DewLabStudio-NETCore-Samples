using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Dew.Signal;
using Dew.Signal.Units;
using Dew.Math.Units;
using Dew.Signal.Tee;
using Dew.Signal.Editors;
using Dew.Math.Controls;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for BispectrumTestForm.
	/// </summary>
	public class BispectrumTestForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private SpectrumChart SpectrumChart1;
		private System.Windows.Forms.Splitter splitter1;
		private Dew.Signal.TSignalRead SignalRead1;
		private Dew.Signal.TSpectrumAnalyzer SpectrumAnalyzer1;
		private Dew.Signal.TBiSpectrumAnalyzer BiSpectrumAnalyzer1;
		private SpectrumChart SpectrumChart2;
		private Steema.TeeChart.Tools.ColorLine colorLine1;
		private Steema.TeeChart.Styles.FastLine Series1;
		private Steema.TeeChart.Styles.Points Series2;
		private Steema.TeeChart.Styles.FastLine Series3;
		private Steema.TeeChart.Styles.Points Series4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBoxSingleLines;
		private System.Windows.Forms.Label labelProgress;
		private System.Windows.Forms.Button button1;
		private FloatEdit freqEdit;
        private Button ChartButton;
        private Button SpectrumButton;
        private Steema.TeeChart.Editor ChartEditor;
        private SpectrumAnalyzerDialog SpectrumAnalyzerDialog;
		private System.ComponentModel.IContainer components;

		public BispectrumTestForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			BiSpectrumAnalyzer1.Amplt.SetZero();
			SpectrumChart2.Spectrums.Add();
			SpectrumChart2.Spectrums[0].Series = Series3;
			SpectrumChart2.Spectrums[0].Input = SpectrumAnalyzer1;

			SpectrumMarkTool markTool = new SpectrumMarkTool(SpectrumChart2.Chart);
			markTool.MarkSeries = Series4;
			markTool.Series = Series3;
			markTool.CursorActive = true;
			markTool.MarkMode = SpectrumMarkMode.mmSingle;
			markTool.MarkType = SpectrumMarkType.mtAmplt;
			markTool.AmpltFormat = "0.0000";
			markTool.PhaseFormat = "0.0000";
			markTool.FreqFormat = "0.0000";
			markTool.LabelHeaders = true;
			markTool.PeakZoomBand = false;
			markTool.DoubleClickClear = true;
			markTool.PeakFilterMode = false;
			SpectrumChart2.Tools.Add(markTool);

			SpectrumChart1.Spectrums.Add();
			SpectrumChart1.Spectrums[0].Series = Series1;
			SpectrumChart1.Spectrums[0].Input = BiSpectrumAnalyzer1;

			SpectrumMarkTool markTool2 = new SpectrumMarkTool(SpectrumChart1.Chart);
			markTool2.MarkSeries = Series2;
			markTool2.Series = Series1;
			markTool2.CursorActive = true;
			markTool2.MarkMode = SpectrumMarkMode.mmSingle;
			markTool2.MarkType = SpectrumMarkType.mtAmplt;
			markTool2.AmpltFormat = "0.0000";
			markTool2.PhaseFormat = "0.0000";
			markTool2.FreqFormat = "0.0000";
			markTool2.LabelHeaders = true;
			markTool2.PeakZoomBand = false;
			markTool2.DoubleClickClear = true;
			markTool2.PeakFilterMode = false;
			SpectrumChart1.Tools.Add(markTool2);

			AxisScaleTool scaleTool2 = new AxisScaleTool(SpectrumChart2.Chart);
			scaleTool2.Axis = SpectrumChart2.Axes.Left;
			scaleTool2.DataIsSpectrum = true;
			scaleTool2.AxisScaleMode = AxisScaleMode.amPeakHold;
			scaleTool2.UpperMargin = 20;
			scaleTool2.LowerMargin = 5;
			SpectrumChart2.Tools.Add(scaleTool2);

            Series1.Color = Color.Navy;
            Series3.Color = Color.Navy;

            SignalRead1.FileName = Dew.Demo.Utils.SourcePath() + @"\Data\bz.dat";
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(BispectrumTestForm));
            Steema.TeeChart.Margins margins2 = new Steema.TeeChart.Margins();
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            ChartButton = new Button();
            SpectrumButton = new Button();
            button1 = new Button();
            labelProgress = new Label();
            checkBoxSingleLines = new CheckBox();
            freqEdit = new FloatEdit();
            label1 = new Label();
            panel2 = new Panel();
            SpectrumChart2 = new SpectrumChart();
            Series3 = new Steema.TeeChart.Styles.FastLine();
            Series4 = new Steema.TeeChart.Styles.Points();
            colorLine1 = new Steema.TeeChart.Tools.ColorLine();
            splitter1 = new Splitter();
            SpectrumChart1 = new SpectrumChart();
            Series1 = new Steema.TeeChart.Styles.FastLine();
            Series2 = new Steema.TeeChart.Styles.Points();
            SignalRead1 = new TSignalRead(components);
            SpectrumAnalyzer1 = new TSpectrumAnalyzer(components);
            BiSpectrumAnalyzer1 = new TBiSpectrumAnalyzer(components);
            ChartEditor = new Steema.TeeChart.Editor(components);
            SpectrumAnalyzerDialog = new SpectrumAnalyzerDialog(components);
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
            richTextBox1.Size = new Size(1115, 118);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            panel1.Controls.Add(ChartButton);
            panel1.Controls.Add(SpectrumButton);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(labelProgress);
            panel1.Controls.Add(checkBoxSingleLines);
            panel1.Controls.Add(freqEdit);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 787);
            panel1.Name = "panel1";
            panel1.Size = new Size(1115, 47);
            panel1.TabIndex = 1;
            // 
            // ChartButton
            // 
            ChartButton.Location = new Point(118, 9);
            ChartButton.Name = "ChartButton";
            ChartButton.Size = new Size(130, 28);
            ChartButton.TabIndex = 6;
            ChartButton.Text = "Spectrum chart...";
            ChartButton.Click += ChartButton_Click;
            // 
            // SpectrumButton
            // 
            SpectrumButton.Location = new Point(14, 9);
            SpectrumButton.Name = "SpectrumButton";
            SpectrumButton.Size = new Size(96, 28);
            SpectrumButton.TabIndex = 5;
            SpectrumButton.Text = "Spectrum...";
            SpectrumButton.Click += SpectrumButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(256, 9);
            button1.Name = "button1";
            button1.Size = new Size(96, 28);
            button1.TabIndex = 4;
            button1.Text = "Recalculate";
            button1.Click += button1_Click;
            // 
            // labelProgress
            // 
            labelProgress.Location = new Point(724, 15);
            labelProgress.Name = "labelProgress";
            labelProgress.Size = new Size(120, 19);
            labelProgress.TabIndex = 3;
            labelProgress.Text = "Progress: 0 [%]";
            // 
            // checkBoxSingleLines
            // 
            checkBoxSingleLines.Checked = true;
            checkBoxSingleLines.CheckState = CheckState.Checked;
            checkBoxSingleLines.Location = new Point(505, 14);
            checkBoxSingleLines.Name = "checkBoxSingleLines";
            checkBoxSingleLines.Size = new Size(211, 19);
            checkBoxSingleLines.TabIndex = 2;
            checkBoxSingleLines.Text = "Single lines up to 145 Hz only";
            // 
            // freqEdit
            // 
            freqEdit.Increment = "0.5";
            freqEdit.Location = new Point(419, 12);
            freqEdit.MaxValue = "1024";
            freqEdit.Name = "freqEdit";
            freqEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            freqEdit.Scientific = false;
            freqEdit.Size = new Size(77, 23);
            freqEdit.TabIndex = 1;
            freqEdit.Value = "20.00";
            freqEdit.TextChanged += freqEdit_TextChanged;
            // 
            // label1
            // 
            label1.Location = new Point(361, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 0;
            label1.Text = "Freq:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.Controls.Add(SpectrumChart2);
            panel2.Controls.Add(splitter1);
            panel2.Controls.Add(SpectrumChart1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(1115, 669);
            panel2.TabIndex = 2;
            panel2.SizeChanged += panel2_SizeChanged;
            // 
            // SpectrumChart2
            // 
            // 
            // 
            // 
            SpectrumChart2.Axes.Automatic = false;
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
            SpectrumChart2.Axes.Depth.Automatic = false;
            SpectrumChart2.Axes.Depth.AutomaticMaximum = false;
            SpectrumChart2.Axes.Depth.AutomaticMinimum = false;
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
            SpectrumChart2.Axes.Depth.Maximum = 0D;
            SpectrumChart2.Axes.Depth.Minimum = 0D;
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
            SpectrumChart2.Axes.DepthTop.Automatic = false;
            SpectrumChart2.Axes.DepthTop.AutomaticMaximum = false;
            SpectrumChart2.Axes.DepthTop.AutomaticMinimum = false;
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
            SpectrumChart2.Axes.DepthTop.Maximum = 0D;
            SpectrumChart2.Axes.DepthTop.Minimum = 0D;
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
            SpectrumChart2.Axes.Right.Automatic = false;
            SpectrumChart2.Axes.Right.AutomaticMaximum = false;
            SpectrumChart2.Axes.Right.AutomaticMinimum = false;
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
            SpectrumChart2.Axes.Right.Maximum = 0D;
            SpectrumChart2.Axes.Right.Minimum = 0D;
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
            SpectrumChart2.Axes.Top.Automatic = false;
            SpectrumChart2.Axes.Top.AutomaticMaximum = false;
            SpectrumChart2.Axes.Top.AutomaticMinimum = false;
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
            SpectrumChart2.Axes.Top.Maximum = 0D;
            SpectrumChart2.Axes.Top.Minimum = 0D;
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
    "Frequency spectrum"
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
            SpectrumChart2.Location = new Point(0, 230);
            SpectrumChart2.Name = "SpectrumChart2";
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart2.Panel.Bevel.ColorOne = Color.FromArgb(255, 255, 255);
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
            SpectrumChart2.Series.Add(Series3);
            SpectrumChart2.Series.Add(Series4);
            SpectrumChart2.Size = new Size(1115, 439);
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
            SpectrumChart2.Tools.Add(colorLine1);
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
            // Series3
            // 
            // 
            // 
            // 
            Series3.Brush.Color = Color.Empty;
            Series3.Brush.Solid = true;
            Series3.Brush.Visible = true;
            Series3.Color = Color.FromArgb(68, 102, 163);
            Series3.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            Series3.Legend.Brush.Color = Color.White;
            Series3.Legend.Brush.Solid = true;
            Series3.Legend.Brush.Visible = true;
            // 
            // 
            // 
            Series3.Legend.Font.Bold = false;
            // 
            // 
            // 
            Series3.Legend.Font.Brush.Color = Color.Black;
            Series3.Legend.Font.Brush.Solid = true;
            Series3.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series3.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            Series3.Legend.Font.Shadow.Brush.Solid = true;
            Series3.Legend.Font.Shadow.Brush.Visible = true;
            Series3.Legend.Font.Size = 8;
            Series3.Legend.Font.SizeFloat = 8F;
            Series3.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Series3.Legend.ImageBevel.Brush.Color = Color.LightGray;
            Series3.Legend.ImageBevel.Brush.Solid = true;
            Series3.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series3.Legend.Shadow.Brush.Color = Color.DarkGray;
            Series3.Legend.Shadow.Brush.Solid = true;
            Series3.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series3.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            Series3.Marks.Brush.Solid = true;
            Series3.Marks.Brush.Visible = true;
            // 
            // 
            // 
            Series3.Marks.Font.Bold = false;
            // 
            // 
            // 
            Series3.Marks.Font.Brush.Color = Color.Black;
            Series3.Marks.Font.Brush.Solid = true;
            Series3.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series3.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            Series3.Marks.Font.Shadow.Brush.Solid = true;
            Series3.Marks.Font.Shadow.Brush.Visible = true;
            Series3.Marks.Font.Size = 8;
            Series3.Marks.Font.SizeFloat = 8F;
            Series3.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Series3.Marks.ImageBevel.Brush.Color = Color.LightGray;
            Series3.Marks.ImageBevel.Brush.Solid = true;
            Series3.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series3.Marks.Shadow.Brush.Color = Color.Gray;
            Series3.Marks.Shadow.Brush.Solid = true;
            Series3.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series3.Marks.Symbol.Brush.Color = Color.White;
            Series3.Marks.Symbol.Brush.Solid = true;
            Series3.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series3.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            Series3.Marks.Symbol.ImageBevel.Brush.Solid = true;
            Series3.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series3.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            Series3.Marks.Symbol.Shadow.Brush.Solid = true;
            Series3.Marks.Symbol.Shadow.Brush.Visible = true;
            Series3.Title = "fastLine1";
            Series3.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            // 
            // 
            // 
            Series3.XValues.DataMember = "X";
            Series3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            Series3.XValues.Value = new double[]
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
            Series3.YValues.DataMember = "Y";
            Series3.YValues.Value = new double[]
    {
    546D,
    627D,
    612D,
    548D,
    633D,
    722D,
    721D,
    819D,
    793D,
    855D,
    770D,
    848D,
    949D,
    1008D,
    1087D,
    1197D,
    1313D,
    1410D,
    1401D,
    1453D,
    1530D,
    1457D,
    1545D,
    1613D,
    1670D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // Series4
            // 
            // 
            // 
            // 
            Series4.Brush.Color = Color.Empty;
            Series4.Brush.Solid = true;
            Series4.Brush.Visible = true;
            Series4.Color = Color.Red;
            Series4.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            Series4.Legend.Brush.Color = Color.White;
            Series4.Legend.Brush.Solid = true;
            Series4.Legend.Brush.Visible = true;
            // 
            // 
            // 
            Series4.Legend.Font.Bold = false;
            // 
            // 
            // 
            Series4.Legend.Font.Brush.Color = Color.Black;
            Series4.Legend.Font.Brush.Solid = true;
            Series4.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series4.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            Series4.Legend.Font.Shadow.Brush.Solid = true;
            Series4.Legend.Font.Shadow.Brush.Visible = true;
            Series4.Legend.Font.Size = 8;
            Series4.Legend.Font.SizeFloat = 8F;
            Series4.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Series4.Legend.ImageBevel.Brush.Color = Color.LightGray;
            Series4.Legend.ImageBevel.Brush.Solid = true;
            Series4.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series4.Legend.Shadow.Brush.Color = Color.DarkGray;
            Series4.Legend.Shadow.Brush.Solid = true;
            Series4.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series4.Marks.Arrow.Visible = false;
            Series4.Marks.ArrowLength = 10;
            // 
            // 
            // 
            Series4.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            Series4.Marks.Brush.Solid = true;
            Series4.Marks.Brush.Visible = false;
            // 
            // 
            // 
            Series4.Marks.Font.Bold = false;
            // 
            // 
            // 
            Series4.Marks.Font.Brush.Color = Color.Black;
            Series4.Marks.Font.Brush.Solid = true;
            Series4.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series4.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            Series4.Marks.Font.Shadow.Brush.Solid = true;
            Series4.Marks.Font.Shadow.Brush.Visible = true;
            Series4.Marks.Font.Size = 8;
            Series4.Marks.Font.SizeFloat = 8F;
            Series4.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Series4.Marks.ImageBevel.Brush.Color = Color.LightGray;
            Series4.Marks.ImageBevel.Brush.Solid = true;
            Series4.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series4.Marks.Shadow.Brush.Color = Color.Gray;
            Series4.Marks.Shadow.Brush.Solid = true;
            Series4.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series4.Marks.Symbol.Brush.Color = Color.White;
            Series4.Marks.Symbol.Brush.Solid = true;
            Series4.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series4.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            Series4.Marks.Symbol.ImageBevel.Brush.Solid = true;
            Series4.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series4.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            Series4.Marks.Symbol.Shadow.Brush.Solid = true;
            Series4.Marks.Symbol.Shadow.Brush.Visible = true;
            Series4.Marks.Transparent = true;
            Series4.Marks.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series4.Pointer.Brush.Color = Color.Red;
            Series4.Pointer.Brush.Solid = true;
            Series4.Pointer.Brush.Visible = true;
            Series4.Pointer.HorizSize = 3;
            // 
            // 
            // 
            Series4.Pointer.Pen.Color = Color.FromArgb(254, 0, 0, 0);
            Series4.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            Series4.Pointer.VertSize = 3;
            Series4.Title = "point1";
            // 
            // 
            // 
            Series4.XValues.DataMember = "X";
            Series4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            Series4.XValues.Value = new double[]
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
            Series4.YValues.DataMember = "Y";
            Series4.YValues.Value = new double[]
    {
    826D,
    784D,
    794D,
    820D,
    957D,
    836D,
    926D,
    1042D,
    974D,
    925D,
    974D,
    1114D,
    1105D,
    1018D,
    891D,
    915D,
    1032D,
    898D,
    782D,
    853D,
    810D,
    679D,
    644D,
    654D,
    694D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // colorLine1
            // 
            colorLine1.Axis = SpectrumChart2.Axes.Bottom;
            colorLine1.AxisIndex = -1;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 226);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(1115, 4);
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
    "Bicoherence"
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
            SpectrumChart1.Series.Add(Series2);
            SpectrumChart1.Size = new Size(1115, 226);
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
    126D,
    188D,
    121D,
    47D,
    45D,
    37D,
    114D,
    48D,
    91D,
    176D,
    225D,
    214D,
    326D,
    351D,
    260D,
    160D,
    73D,
    190D,
    230D,
    198D,
    164D,
    99D,
    102D,
    159D,
    47D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
    217D,
    194D,
    227D,
    225D,
    245D,
    279D,
    253D,
    237D,
    227D,
    199D,
    183D,
    196D,
    176D,
    179D,
    142D,
    145D,
    162D,
    144D,
    180D,
    157D,
    121D,
    100D,
    115D,
    113D,
    152D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            SignalRead1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            SignalRead1.FloatPrecisionLock = false;
            SignalRead1.FramesPerSecond = 0.00048828125D;
            SignalRead1.IsDouble = true;
            SignalRead1.Length = 2048;
            SignalRead1.OverlappingSamples = 0;
            SignalRead1.PostBufferSamples = 0;
            SignalRead1.RecordNumber = 0;
            SignalRead1.RecordPosition = 0L;
            SignalRead1.SamplingFrequency = 4666.6666D;
            // 
            // SpectrumAnalyzer1
            // 
            SpectrumAnalyzer1.ArOrder = 100;
            SpectrumAnalyzer1.Bands.TemplateIndex = -1;
            SpectrumAnalyzer1.Bands.TemplatesSerialization = "AAAAAA==";
            SpectrumAnalyzer1.Complex = false;
            SpectrumAnalyzer1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            SpectrumAnalyzer1.FloatPrecisionLock = false;
            SpectrumAnalyzer1.Harmonics = 10;
            SpectrumAnalyzer1.Input = SignalRead1;
            SpectrumAnalyzer1.IsDouble = true;
            SpectrumAnalyzer1.Length = 64;
            SpectrumAnalyzer1.Logarithmic = true;
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
            SpectrumAnalyzer1.SamplingFrequency = 8D;
            SpectrumAnalyzer1.Stats.Averaged = 0;
            SpectrumAnalyzer1.Stats.Averages = 30;
            SpectrumAnalyzer1.Stats.ExpDecay = 5;
            SpectrumAnalyzer1.Window = TSignalWindowType.wtHanning;
            SpectrumAnalyzer1.ZeroPadding = 2;
            // 
            // BiSpectrumAnalyzer1
            // 
            BiSpectrumAnalyzer1.ArOrder = 100;
            BiSpectrumAnalyzer1.Bands.TemplateIndex = -1;
            BiSpectrumAnalyzer1.Bands.TemplatesSerialization = "AAAAAA==";
            BiSpectrumAnalyzer1.BiAnalyzer.LinesSerialization = "AAAAAAAAAAAAAAAAAACAPwAAAAAAgB9EAAAAQQAAAAAAE3pHAAAAAAAAAAAAAAAA";
            BiSpectrumAnalyzer1.BiAnalyzer.Recursive = false;
            BiSpectrumAnalyzer1.Complex = false;
            BiSpectrumAnalyzer1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            BiSpectrumAnalyzer1.FloatPrecisionLock = false;
            BiSpectrumAnalyzer1.Harmonics = 10;
            BiSpectrumAnalyzer1.Input = SignalRead1;
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
            BiSpectrumAnalyzer1.SamplingFrequency = 8D;
            BiSpectrumAnalyzer1.Stats.Averaged = 0;
            BiSpectrumAnalyzer1.Stats.Averages = 30;
            BiSpectrumAnalyzer1.Stats.Averaging = TAveraging.avLinearInf;
            BiSpectrumAnalyzer1.Stats.ExpDecay = 5;
            BiSpectrumAnalyzer1.Window = TSignalWindowType.wtHanning;
            BiSpectrumAnalyzer1.ZeroPadding = 2;
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
            ChartEditor.Click += editor1_Click;
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
            // BispectrumTestForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(1115, 834);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Name = "BispectrumTestForm";
            Text = "BispectrumTestForm";
            Load += BispectrumTestForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((ISupportInitialize)SpectrumChart2).EndInit();
            ((ISupportInitialize)SpectrumChart1).EndInit();
            ResumeLayout(false);

        }
        #endregion

        private void button1_Click(object sender, System.EventArgs e) {
			this.Cursor = Cursors.WaitCursor;
			SignalRead1.OpenFile();
			SignalRead1.RecordPosition = 0;
			SignalRead1.OverlappingPercent = 75;
			SpectrumAnalyzer1.Update();
			if (checkBoxSingleLines.Checked) {
				BiSpectrumAnalyzer1.BiAnalyzer.SingleLinesOnly = true;
				BiSpectrumAnalyzer1.BiAnalyzer.Lines.Length = 128;
				BiSpectrumAnalyzer1.BiAnalyzer.Lines.Ramp(0,SpectrumAnalyzer1.HzRes);
			} else {
				BiSpectrumAnalyzer1.BiAnalyzer.SingleLinesOnly = false;
			}
			BiSpectrumAnalyzer1.ResetAveraging();
			while (BiSpectrumAnalyzer1.Pull() != TPipeState.pipeEnd) {
				labelProgress.Text = "Progress: " + 
					(SignalRead1.FrameNumber*100/SignalRead1.MaxFrames).ToString()+ " [%]";
				this.Update();
			}
			BiSpectrumAnalyzer1.BiAnalyzer.Update();
			freqEdit.Increment = SpectrumAnalyzer1.HzRes.ToString();
			freqEdit_TextChanged(this, EventArgs.Empty);
			this.Cursor = Cursors.Default;
		}

		private void freqEdit_TextChanged(object sender, System.EventArgs e) {
			BiSpectrumAnalyzer1.BiAnalyzer.Frequency = freqEdit.Position;
      BiSpectrumAnalyzer1.UpdateSpectrum();
			colorLine1.Value = freqEdit.Position;
		}

		private void panel2_SizeChanged(object sender, System.EventArgs e) {
			SpectrumChart1.Height = (panel2.Height - splitter1.Height) / 2;
		}

        private void editor1_Click(object sender, EventArgs e)
        {

        }

        protected void Add(String s)
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void BispectrumTestForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("Bicoherence shows the frequencies related to the "
            + "selected frequency. Relation is defined as e^jw1 * e^jw2 = e^j(w1+w2). "
            + "Bicoherence  will be 1 for a frequency pair (w1,w2) which has a "
            + "product of itself (e^jw1*e^jw2) in the frequency spectrum. "
            + "Multiplication is also called modulation. Bicoherence will be 1, "
            + "if there is modulation present. Change the Frequency parameter "
            + "and observe the bicoherence to see, with which frequencies is "
            + "the Frequency multiplied with. Modulation is probably the most "
            + "often observed type of non-linearity in mechanical systems. "
            + "You can also compute only preselected frequency lines by checking "
            + "the Single lines only box. (see source code for more info)This "
            + "reduces the CPU and memory resources required considerably. "
            + "The bicoherence is calculated on a vibration signal coming from "
            + "a lathe machine, when there is chatter present. In the example "
            + "below you can see that, next to the main harmonic series, a "
            + "frequency of 20 Hz is the modulating frequency causing many "
            + "additional peaks.");

        }

        private void ChartButton_Click(object sender, EventArgs e)
        {
            ChartEditor.ShowModal();
        }

        private void SpectrumButton_Click(object sender, EventArgs e)
        {
            SpectrumAnalyzerDialog.ExecuteModal();
        }

        private void SpectrumChart1_Click(object sender, EventArgs e)
        {

        }
	}
}
