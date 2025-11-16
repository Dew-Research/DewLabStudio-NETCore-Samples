using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Dew.Signal;
using Dew.Math;
using Dew.Signal.Units;
using Dew.Math.Units;
using Dew.Signal.Tee;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for BispectrumSurface.
	/// </summary>
	public class BispectrumSurface : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private Steema.TeeChart.TChart tChart1;
		private Dew.Signal.TSignalRead SignalRead1;
		private Dew.Signal.TBiSpectrumAnalyzer BiSpectrumAnalyzer1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox fewLinesCheckBox;
		private System.Windows.Forms.Label progressLabel;
		private Steema.TeeChart.Styles.Surface Series1;
        private Button ChartButton;
        private Steema.TeeChart.Editor ChartEditor;
		private System.ComponentModel.IContainer components;

		public BispectrumSurface()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            SignalRead1.FileName = Dew.Demo.Utils.SourcePath() + @"\Data\bz.dat";
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(BispectrumSurface));
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            ChartButton = new Button();
            progressLabel = new Label();
            fewLinesCheckBox = new CheckBox();
            button1 = new Button();
            tChart1 = new Steema.TeeChart.TChart();
            Series1 = new Steema.TeeChart.Styles.Surface();
            SignalRead1 = new TSignalRead(components);
            BiSpectrumAnalyzer1 = new TBiSpectrumAnalyzer(components);
            ChartEditor = new Steema.TeeChart.Editor(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Top;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1112, 79);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            panel1.Controls.Add(ChartButton);
            panel1.Controls.Add(progressLabel);
            panel1.Controls.Add(fewLinesCheckBox);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 735);
            panel1.Name = "panel1";
            panel1.Size = new Size(1112, 45);
            panel1.TabIndex = 1;
            // 
            // ChartButton
            // 
            ChartButton.Location = new Point(14, 9);
            ChartButton.Name = "ChartButton";
            ChartButton.Size = new Size(90, 28);
            ChartButton.TabIndex = 3;
            ChartButton.Text = "Chart...";
            ChartButton.Click += ChartButton_Click;
            // 
            // progressLabel
            // 
            progressLabel.Location = new Point(448, 7);
            progressLabel.Name = "progressLabel";
            progressLabel.Size = new Size(120, 29);
            progressLabel.TabIndex = 2;
            progressLabel.Text = "Progress: 0 [%]";
            progressLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fewLinesCheckBox
            // 
            fewLinesCheckBox.Location = new Point(294, 7);
            fewLinesCheckBox.Name = "fewLinesCheckBox";
            fewLinesCheckBox.Size = new Size(125, 30);
            fewLinesCheckBox.TabIndex = 1;
            fewLinesCheckBox.Text = "Only a few lines";
            fewLinesCheckBox.CheckedChanged += fewLinesCheckBox_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(179, 7);
            button1.Name = "button1";
            button1.Size = new Size(90, 29);
            button1.TabIndex = 0;
            button1.Text = "Recalculate";
            button1.Click += button1_Click;
            // 
            // tChart1
            // 
            // 
            // 
            // 
            tChart1.Aspect.Chart3DPercent = 65;
            tChart1.Aspect.OrthoAngle = 60;
            tChart1.Aspect.View3D = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Bottom.Grid.DrawEvery = 1;
            tChart1.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Bottom.Labels.Brush.Color = Color.White;
            tChart1.Axes.Bottom.Labels.Brush.Solid = true;
            tChart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            tChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.Bottom.Labels.Font.Size = 9;
            tChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            tChart1.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            tChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            tChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Bottom.Title.Brush.Color = Color.Silver;
            tChart1.Axes.Bottom.Title.Brush.Solid = true;
            tChart1.Axes.Bottom.Title.Brush.Visible = true;
            tChart1.Axes.Bottom.Title.Caption = "Freqency [Hz]";
            // 
            // 
            // 
            tChart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            tChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.Bottom.Title.Font.Size = 11;
            tChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            tChart1.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            tChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            tChart1.Axes.Bottom.Title.Lines = new string[]
    {
    "Freqency [Hz]"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            tChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Depth.Grid.DrawEvery = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Depth.Labels.Brush.Color = Color.White;
            tChart1.Axes.Depth.Labels.Brush.Solid = true;
            tChart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            tChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.Depth.Labels.Font.Size = 9;
            tChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            tChart1.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            tChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            tChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Depth.Title.Brush.Color = Color.Silver;
            tChart1.Axes.Depth.Title.Brush.Solid = true;
            tChart1.Axes.Depth.Title.Brush.Visible = true;
            tChart1.Axes.Depth.Title.Caption = "Freqency [Hz]";
            // 
            // 
            // 
            tChart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChart1.Axes.Depth.Title.Font.Brush.Solid = true;
            tChart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.Depth.Title.Font.Size = 11;
            tChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            tChart1.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            tChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            tChart1.Axes.Depth.Title.Lines = new string[]
    {
    "Freqency [Hz]"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            tChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
            tChart1.Axes.Depth.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.DepthTop.AxisPen.Visible = true;
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Grid.DrawEvery = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Labels.Brush.Color = Color.White;
            tChart1.Axes.DepthTop.Labels.Brush.Solid = true;
            tChart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            tChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.DepthTop.Labels.Font.Size = 9;
            tChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            tChart1.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            tChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            tChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Title.Brush.Color = Color.Silver;
            tChart1.Axes.DepthTop.Title.Brush.Solid = true;
            tChart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            tChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.DepthTop.Title.Font.Size = 11;
            tChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            tChart1.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            tChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            tChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Left.Labels.Brush.Color = Color.White;
            tChart1.Axes.Left.Labels.Brush.Solid = true;
            tChart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart1.Axes.Left.Labels.Font.Brush.Solid = true;
            tChart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.Left.Labels.Font.Size = 9;
            tChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            tChart1.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            tChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            tChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Left.Title.Brush.Color = Color.Silver;
            tChart1.Axes.Left.Title.Brush.Solid = true;
            tChart1.Axes.Left.Title.Brush.Visible = true;
            tChart1.Axes.Left.Title.Caption = "Bicoherence";
            // 
            // 
            // 
            tChart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Left.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChart1.Axes.Left.Title.Font.Brush.Solid = true;
            tChart1.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.Left.Title.Font.Size = 11;
            tChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            tChart1.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            tChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            tChart1.Axes.Left.Title.Lines = new string[]
    {
    "Bicoherence"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            tChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Right.Labels.Brush.Color = Color.White;
            tChart1.Axes.Right.Labels.Brush.Solid = true;
            tChart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart1.Axes.Right.Labels.Font.Brush.Solid = true;
            tChart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.Right.Labels.Font.Size = 9;
            tChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            tChart1.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            tChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            tChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Right.Title.Brush.Color = Color.Silver;
            tChart1.Axes.Right.Title.Brush.Solid = true;
            tChart1.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Right.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChart1.Axes.Right.Title.Font.Brush.Solid = true;
            tChart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.Right.Title.Font.Size = 11;
            tChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            tChart1.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            tChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            tChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Top.Labels.Brush.Color = Color.White;
            tChart1.Axes.Top.Labels.Brush.Solid = true;
            tChart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart1.Axes.Top.Labels.Font.Brush.Solid = true;
            tChart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.Top.Labels.Font.Size = 9;
            tChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            tChart1.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            tChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            tChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Top.Title.Brush.Color = Color.Silver;
            tChart1.Axes.Top.Title.Brush.Solid = true;
            tChart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Top.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChart1.Axes.Top.Title.Font.Brush.Solid = true;
            tChart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.Top.Title.Font.Size = 11;
            tChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            tChart1.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            tChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            tChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            tChart1.Dock = DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Footer.Brush.Color = Color.Silver;
            tChart1.Footer.Brush.Solid = true;
            tChart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Footer.Font.Brush.Color = Color.Red;
            tChart1.Footer.Font.Brush.Solid = true;
            tChart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Footer.Font.Shadow.Brush.Solid = true;
            tChart1.Footer.Font.Shadow.Brush.Visible = true;
            tChart1.Footer.Font.Size = 8;
            tChart1.Footer.Font.SizeFloat = 8F;
            tChart1.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Footer.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Footer.ImageBevel.Brush.Solid = true;
            tChart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Footer.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Footer.Shadow.Brush.Solid = true;
            tChart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Header.Brush.Color = Color.FromArgb(192, 192, 192);
            tChart1.Header.Brush.Solid = true;
            tChart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Header.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Header.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart1.Header.Font.Brush.Solid = true;
            tChart1.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Header.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Header.Font.Shadow.Brush.Solid = true;
            tChart1.Header.Font.Shadow.Brush.Visible = true;
            tChart1.Header.Font.Size = 12;
            tChart1.Header.Font.SizeFloat = 12F;
            tChart1.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Header.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Header.ImageBevel.Brush.Solid = true;
            tChart1.Header.ImageBevel.Brush.Visible = true;
            tChart1.Header.Lines = new string[]
    {
    "Bicoherence"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Header.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            tChart1.Header.Shadow.Brush.Solid = true;
            tChart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Legend.Brush.Color = Color.White;
            tChart1.Legend.Brush.Solid = true;
            tChart1.Legend.Brush.Visible = true;
            tChart1.Legend.CheckBoxes = false;
            // 
            // 
            // 
            tChart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Legend.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChart1.Legend.Font.Brush.Solid = true;
            tChart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Legend.Font.Shadow.Brush.Solid = true;
            tChart1.Legend.Font.Shadow.Brush.Visible = true;
            tChart1.Legend.Font.Size = 9;
            tChart1.Legend.Font.SizeFloat = 9F;
            tChart1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Legend.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Legend.ImageBevel.Brush.Solid = true;
            tChart1.Legend.ImageBevel.Brush.Visible = true;
            tChart1.Legend.MaxNumRows = 8;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Legend.Shadow.Brush.Color = Color.FromArgb(0, 0, 0);
            tChart1.Legend.Shadow.Brush.Solid = true;
            tChart1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Legend.Symbol.Shadow.Brush.Solid = true;
            tChart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Legend.Title.Brush.Color = Color.White;
            tChart1.Legend.Title.Brush.Solid = true;
            tChart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            tChart1.Legend.Title.Font.Brush.Color = Color.Black;
            tChart1.Legend.Title.Font.Brush.Solid = true;
            tChart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            tChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            tChart1.Legend.Title.Font.Size = 8;
            tChart1.Legend.Title.Font.SizeFloat = 8F;
            tChart1.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Legend.Title.ImageBevel.Brush.Solid = true;
            tChart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Legend.Title.Shadow.Brush.Solid = true;
            tChart1.Legend.Title.Shadow.Brush.Visible = true;
            tChart1.Legend.Visible = false;
            tChart1.Location = new Point(0, 79);
            tChart1.Name = "tChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            // 
            // 
            // 
            tChart1.Panel.Brush.Color = Color.Silver;
            tChart1.Panel.Brush.Solid = true;
            tChart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Panel.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Panel.ImageBevel.Brush.Solid = true;
            tChart1.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Panel.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Panel.Shadow.Brush.Solid = true;
            tChart1.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            tChart1.Printer.Margins = margins1;
            tChart1.Series.Add(Series1);
            tChart1.Size = new Size(1112, 656);
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.SubFooter.Brush.Color = Color.Silver;
            tChart1.SubFooter.Brush.Solid = true;
            tChart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            tChart1.SubFooter.Font.Brush.Color = Color.Red;
            tChart1.SubFooter.Font.Brush.Solid = true;
            tChart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.SubFooter.Font.Shadow.Brush.Solid = true;
            tChart1.SubFooter.Font.Shadow.Brush.Visible = true;
            tChart1.SubFooter.Font.Size = 8;
            tChart1.SubFooter.Font.SizeFloat = 8F;
            tChart1.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.SubFooter.ImageBevel.Brush.Solid = true;
            tChart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.SubFooter.Shadow.Brush.Color = Color.DarkGray;
            tChart1.SubFooter.Shadow.Brush.Solid = true;
            tChart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.SubHeader.Brush.Color = Color.FromArgb(192, 192, 192);
            tChart1.SubHeader.Brush.Solid = true;
            tChart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            tChart1.SubHeader.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart1.SubHeader.Font.Brush.Solid = true;
            tChart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.SubHeader.Font.Shadow.Brush.Solid = true;
            tChart1.SubHeader.Font.Shadow.Brush.Visible = true;
            tChart1.SubHeader.Font.Size = 12;
            tChart1.SubHeader.Font.SizeFloat = 12F;
            tChart1.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.SubHeader.ImageBevel.Brush.Solid = true;
            tChart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.SubHeader.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            tChart1.SubHeader.Shadow.Brush.Solid = true;
            tChart1.SubHeader.Shadow.Brush.Visible = true;
            tChart1.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Back.Brush.Color = Color.Silver;
            tChart1.Walls.Back.Brush.Solid = true;
            tChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Walls.Back.ImageBevel.Brush.Solid = true;
            tChart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Walls.Back.Shadow.Brush.Solid = true;
            tChart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Bottom.Brush.Color = Color.White;
            tChart1.Walls.Bottom.Brush.Solid = true;
            tChart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            tChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Walls.Bottom.Shadow.Brush.Solid = true;
            tChart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Left.Brush.Color = Color.LightYellow;
            tChart1.Walls.Left.Brush.Solid = true;
            tChart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Walls.Left.ImageBevel.Brush.Solid = true;
            tChart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Walls.Left.Shadow.Brush.Solid = true;
            tChart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Right.Brush.Color = Color.LightYellow;
            tChart1.Walls.Right.Brush.Solid = true;
            tChart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Walls.Right.ImageBevel.Brush.Solid = true;
            tChart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Walls.Right.Shadow.Brush.Solid = true;
            tChart1.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Zoom.Animated = true;
            // 
            // 
            // 
            tChart1.Zoom.Brush.Color = Color.LightBlue;
            tChart1.Zoom.Brush.Solid = true;
            tChart1.Zoom.Brush.Visible = false;
            tChart1.Zoom.History = true;
            // 
            // 
            // 
            tChart1.Zoom.Pen.Visible = true;
            // 
            // Series1
            // 
            // 
            // 
            // 
            Series1.Brush.Color = Color.FromArgb(68, 102, 163);
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
            Series1.PaletteMin = 0D;
            Series1.PaletteStep = 0D;
            Series1.PaletteStyle = Steema.TeeChart.Styles.PaletteStyles.Pale;
            // 
            // 
            // 
            Series1.SideBrush.Color = Color.Black;
            Series1.SideBrush.Solid = true;
            Series1.SideBrush.Visible = false;
            Series1.Title = "surface1";
            // 
            // 
            // 
            Series1.XValues.DataMember = "X";
            Series1.XValues.Value = new double[]
    {
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
    0D
    };
            // 
            // 
            // 
            Series1.YValues.DataMember = "Y";
            Series1.YValues.Value = new double[]
    {
    0.17516015155986309D,
    -0.063952134043957276D,
    -0.20741354905728315D,
    -0.1233263301230747D,
    0.11100012145863469D,
    0.28012714675541983D,
    0.22856013867865443D,
    0.0037095666406748995D,
    -0.187697990378341D,
    -0.16968330717628488D,
    -0.24405883580942134D,
    -0.48317112141324181D,
    -0.62663253642656758D,
    -0.54254531749235912D,
    -0.30821886591064973D,
    -0.13909184061386481D,
    -0.19065884869063D,
    -0.41550942072860964D,
    -0.60691697774762554D,
    -0.5889022945455693D,
    -0.43525628674286609D,
    -0.67436857234668657D,
    -0.81782998736001244D,
    -0.733742768425804D,
    -0.49941631684409449D,
    -0.33028929154730957D,
    -0.38185629962407486D,
    -0.60670687166205439D,
    -0.7981144286810703D,
    -0.78009974547901417D,
    -0.13845294331193636D,
    -0.37756522891575689D,
    -0.52102664392908271D,
    -0.43693942499487431D,
    -0.20261297341316475D,
    -0.033485948116379838D,
    -0.085052956193145124D,
    -0.30990352823112466D,
    -0.50131108525014056D,
    -0.48329640204808444D,
    0.48660436333050816D,
    0.2474920777266878D,
    0.10403066271336192D,
    0.18811788164757037D,
    0.42244433322927988D,
    0.59157135852606491D,
    0.54000435044929951D,
    0.31515377841132D,
    0.12374622139230407D,
    0.14176090459436019D,
    1.0028029653155441D,
    0.76369067971172377D,
    0.6202292646983979D,
    0.70431648363260635D,
    0.93864293521431574D,
    1.1077699605111009D,
    1.0562029524343355D,
    0.83135238039635584D,
    0.63994482337734016D,
    0.65795950657939617D,
    1.0920595607384465D,
    0.85294727513462576D,
    0.70948586012129988D,
    0.79357307905550833D,
    1.0278995306372181D,
    1.1970265559340028D,
    1.1454595478572376D,
    0.920608975819258D,
    0.729201418800242D,
    0.74721610200229815D,
    0.84152508186401709D,
    0.60241279626019661D,
    0.45895138124687074D,
    0.54303860018107919D,
    0.77736505176278869D,
    0.94649207705957361D,
    0.89492506898280832D,
    0.67007449694482879D,
    0.47866693992581283D,
    0.49668162312786895D,
    0.65671254021778358D,
    0.41760025461396305D,
    0.27413883960063723D,
    0.35822605853484563D,
    0.59255251011655519D,
    0.7616795354133401D,
    0.71011252733657471D,
    0.48526195529859523D,
    0.29385439827957938D,
    0.3118690814816355D,
    0.88168664847595113D,
    0.64257436287213054D,
    0.49911294785880478D,
    0.58320016679301323D,
    0.81752661837472274D,
    0.98665364367150765D,
    0.93508663559474225D,
    0.71023606355676283D,
    0.51882850653774693D,
    0.536843189739803D,
    0D
    };
            // 
            // 
            // 
            Series1.ZValues.DataMember = "Z";
            Series1.ZValues.Value = new double[]
    {
    1D,
    1D,
    1D,
    1D,
    1D,
    1D,
    1D,
    1D,
    1D,
    1D,
    2D,
    2D,
    2D,
    2D,
    2D,
    2D,
    2D,
    2D,
    2D,
    2D,
    3D,
    3D,
    3D,
    3D,
    3D,
    3D,
    3D,
    3D,
    3D,
    3D,
    4D,
    4D,
    4D,
    4D,
    4D,
    4D,
    4D,
    4D,
    4D,
    4D,
    5D,
    5D,
    5D,
    5D,
    5D,
    5D,
    5D,
    5D,
    5D,
    5D,
    6D,
    6D,
    6D,
    6D,
    6D,
    6D,
    6D,
    6D,
    6D,
    6D,
    7D,
    7D,
    7D,
    7D,
    7D,
    7D,
    7D,
    7D,
    7D,
    7D,
    8D,
    8D,
    8D,
    8D,
    8D,
    8D,
    8D,
    8D,
    8D,
    8D,
    9D,
    9D,
    9D,
    9D,
    9D,
    9D,
    9D,
    9D,
    9D,
    9D,
    10D,
    10D,
    10D,
    10D,
    10D,
    10D,
    10D,
    10D,
    10D,
    10D,
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
            SignalRead1.FramesPerSecond = 0.00390625D;
            SignalRead1.IsDouble = true;
            SignalRead1.Length = 256;
            SignalRead1.OverlappingSamples = 0;
            SignalRead1.PostBufferSamples = 0;
            SignalRead1.RecordNumber = 0;
            SignalRead1.RecordPosition = 0L;
            SignalRead1.SamplingFrequency = 4666.66666666667D;
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
            BiSpectrumAnalyzer1.Report.UseTab = false;
            BiSpectrumAnalyzer1.Rotation = 0;
            BiSpectrumAnalyzer1.Stats.Averaged = 0;
            BiSpectrumAnalyzer1.Stats.Averages = 30;
            BiSpectrumAnalyzer1.Stats.Averaging = TAveraging.avLinearInf;
            BiSpectrumAnalyzer1.Stats.ExpDecay = 5;
            BiSpectrumAnalyzer1.Window = TSignalWindowType.wtHanning;
            BiSpectrumAnalyzer1.ZeroPadding = 1;
            // 
            // ChartEditor
            // 
            ChartEditor.AlwaysShowFuncSrc = false;
            ChartEditor.Chart = tChart1;
            ChartEditor.HighLightTabs = false;
            ChartEditor.Location = new Point(0, 0);
            ChartEditor.Name = "ChartEditor";
            ChartEditor.Options = null;
            ChartEditor.TabIndex = 0;
            // 
            // BispectrumSurface
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(1112, 780);
            Controls.Add(tChart1);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Name = "BispectrumSurface";
            Text = "BispectrumSurface";
            Load += BispectrumSurface_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);

        }
        #endregion

        private void button1_Click(object sender, System.EventArgs e) {
			TVec av, bv;
			MtxVec.CreateIt(out av, out bv);
			TMtx aMtx;
			MtxVec.CreateIt(out aMtx);
			try {
				SignalRead1.RecordPosition = 0;
                SignalRead1.OverlappingPercent = 50;
                this.Cursor = Cursors.WaitCursor;
				if (fewLinesCheckBox.Checked) {
					BiSpectrumAnalyzer1.BiAnalyzer.SingleLinesOnly = true;
					BiSpectrumAnalyzer1.BiAnalyzer.Lines.Length = 32; //compute only 32 lines
					BiSpectrumAnalyzer1.BiAnalyzer.Lines.Ramp(16*SignalRead1.HzRes,SignalRead1.HzRes);
				} else {
					BiSpectrumAnalyzer1.BiAnalyzer.SingleLinesOnly = false;
				}
				BiSpectrumAnalyzer1.ResetAveraging();
				while (BiSpectrumAnalyzer1.Pull() != TPipeState.pipeEnd) {
					progressLabel.Text = "Progress: " + 
						(SignalRead1.FrameNumber*100/SignalRead1.MaxFrames).ToString() + " [%]";
					this.Update();
				}
                BiSpectrumAnalyzer1.BiAnalyzer.Update(); //compute bicoherence
				Series1.Clear();
                Series1.IrregularGrid = true;
				for (int i=0;i<BiSpectrumAnalyzer1.Length / 2;i++) {
					BiSpectrumAnalyzer1.BiAnalyzer.Frequency = i*BiSpectrumAnalyzer1.HzRes;
					if (!fewLinesCheckBox.Checked) {
						BiSpectrumAnalyzer1.BiAnalyzer.DecodeBispectrumMatrix(av);
					} else {
						BiSpectrumAnalyzer1.BiAnalyzer.DecodeSingleLineMatrix(av);
					}
					for (int j=0;j<BiSpectrumAnalyzer1.Length;j++) {
						if (av[j]!=0) {
							Series1.Add(j*BiSpectrumAnalyzer1.HzRes,av[j],i*BiSpectrumAnalyzer1.HzRes);
						}
					}
				}
			} finally {
				this.Cursor = Cursors.Default;
				MtxVec.FreeIt(ref av, ref bv);
				MtxVec.FreeIt(ref aMtx);
			}
		}

		private void fewLinesCheckBox_CheckedChanged(object sender, System.EventArgs e) {
			button1_Click(sender, e);
		}

        private void ChartButton_Click(object sender, EventArgs e)
        {
            ChartEditor.ShowModal();
        }

        protected void Add(String s)
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void BispectrumSurface_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear(); ;
            Add("Bicoherence shows peaks where the frequency pair is "
            + "related to a third frequency component defined as "
            + "e^jw1 * e^jw2 = e^j(w1+w2). Bicoherence  will be 1 "
            + "for a frequency pair (w1,w2) which has a product of "
            + "itself (e^jw1*e^jw2) in the frequency spectrum. You "
            + "can also compute only preselected frequency lines by "
            + "checking the Single lines only box.");
        }
	}
}
