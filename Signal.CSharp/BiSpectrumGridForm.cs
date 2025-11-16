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
using Dew.Math.Controls;
using Dew.Math.Tee; 
using static Dew.Math.Tee.MtxVecTee;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for BiSpectrumGridForm.
	/// </summary>
	public class BiSpectrumGridForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private Dew.Signal.TSignalRead SignalRead1;
		private Dew.Signal.TBiSpectrumAnalyzer BiSpectrumAnalyzer1;
		private System.Windows.Forms.Label labelProgress;
		private System.Windows.Forms.CheckBox checkBoxSingleLines;
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.TChart Chart1;
        private Button ChartButton;
        private Steema.TeeChart.Editor ChartEditor;
		private System.ComponentModel.IContainer components;

		public BiSpectrumGridForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			Series1 = new MtxGridSeries(Chart1.Chart);
			Series1.ColorPalette.TopColor = Color.White;
			Series1.ColorPalette.BottomColor = Color.Navy;
			Series1.XStep = 1;
			Series1.YStep = 1;

            SignalRead1.FileName = Dew.Demo.Utils.SourcePath() + @"\Data\bz.dat";
			bMtx = new TMtx();
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
			bMtx.Destroy();
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(BiSpectrumGridForm));
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            ChartButton = new Button();
            button1 = new Button();
            labelProgress = new Label();
            checkBoxSingleLines = new CheckBox();
            Chart1 = new Steema.TeeChart.TChart();
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
            richTextBox1.Size = new Size(1146, 118);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(ChartButton);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(labelProgress);
            panel1.Controls.Add(checkBoxSingleLines);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 822);
            panel1.Name = "panel1";
            panel1.Size = new Size(1146, 43);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // ChartButton
            // 
            ChartButton.Location = new Point(14, 9);
            ChartButton.Name = "ChartButton";
            ChartButton.Size = new Size(90, 28);
            ChartButton.TabIndex = 7;
            ChartButton.Text = "Chart...";
            ChartButton.Click += ChartButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(126, 9);
            button1.Name = "button1";
            button1.Size = new Size(90, 28);
            button1.TabIndex = 6;
            button1.Text = "Recalculate";
            button1.Click += button1_Click;
            // 
            // labelProgress
            // 
            labelProgress.Location = new Point(433, 7);
            labelProgress.Name = "labelProgress";
            labelProgress.Size = new Size(120, 30);
            labelProgress.TabIndex = 5;
            labelProgress.Text = "Progress: 0 [%]";
            labelProgress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxSingleLines
            // 
            checkBoxSingleLines.Checked = true;
            checkBoxSingleLines.CheckState = CheckState.Checked;
            checkBoxSingleLines.Location = new Point(292, 7);
            checkBoxSingleLines.Name = "checkBoxSingleLines";
            checkBoxSingleLines.Size = new Size(134, 30);
            checkBoxSingleLines.TabIndex = 4;
            checkBoxSingleLines.Text = "Only a few lines";
            checkBoxSingleLines.CheckedChanged += checkBoxSingleLines_CheckedChanged;
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
            Chart1.Dock = DockStyle.Fill;
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
            Chart1.Location = new Point(0, 118);
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
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            Chart1.Printer.Margins = margins1;
            Chart1.Size = new Size(1146, 704);
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
            Chart1.TabIndex = 2;
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
            Chart1.Zoom.Animated = true;
            // 
            // 
            // 
            Chart1.Zoom.Brush.Color = Color.LightBlue;
            Chart1.Zoom.Brush.Solid = true;
            Chart1.Zoom.Brush.Visible = false;
            Chart1.Zoom.History = true;
            // 
            // 
            // 
            Chart1.Zoom.Pen.Visible = true;
            // 
            // SignalRead1
            // 
            SignalRead1.ChannelCount = 1;
            SignalRead1.Complex = false;
            SignalRead1.DataSerialization = resources.GetString("SignalRead1.DataSerialization");
            SignalRead1.FloatPrecision = TMtxFloatPrecision.mvDouble;
            SignalRead1.FloatPrecisionLock = false;
            SignalRead1.FramesPerSecond = 0.00048828125D;
            SignalRead1.IsDouble = true;
            SignalRead1.Length = 2048;
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
            ChartEditor.Chart = Chart1;
            ChartEditor.HighLightTabs = false;
            ChartEditor.Location = new Point(0, 0);
            ChartEditor.Name = "ChartEditor";
            ChartEditor.Options = null;
            ChartEditor.TabIndex = 0;
            // 
            // BiSpectrumGridForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(1146, 865);
            Controls.Add(Chart1);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Name = "BiSpectrumGridForm";
            Text = "BiSpectrumGridForm";
            Load += BiSpectrumGridForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);

        }
        #endregion

        private MtxGridSeries Series1;
		private TMtx bMtx;

		private void button1_Click(object sender, System.EventArgs e) {
		  TMtx aMtx;
			TVec av;
			MtxVec.CreateIt(out aMtx);
			MtxVec.CreateIt(out av);
			try {
				this.Cursor = Cursors.WaitCursor;
				SignalRead1.RecordPosition = 0;
        SignalRead1.OverlappingPercent = 50;
				if (checkBoxSingleLines.Checked) {
					BiSpectrumAnalyzer1.BiAnalyzer.SingleLinesOnly = true;
					BiSpectrumAnalyzer1.BiAnalyzer.Lines.Length = 128; //compute only 256 lines
					BiSpectrumAnalyzer1.BiAnalyzer.Lines.Ramp(64*SignalRead1.HzRes,SignalRead1.HzRes);
				} else {
					BiSpectrumAnalyzer1.BiAnalyzer.SingleLinesOnly = false;
				}
				BiSpectrumAnalyzer1.ResetAveraging();
				while (BiSpectrumAnalyzer1.Pull() != TPipeState.pipeEnd) {
					labelProgress.Text = "Progress: " + 
						(SignalRead1.FrameNumber*100/SignalRead1.MaxFrames).ToString()+ " [%]";
					this.Update();
				}
				BiSpectrumAnalyzer1.BiAnalyzer.Update(); //compute bicoherence
				BiSpectrumAnalyzer1.BiAnalyzer.GetFullSpectrum(bMtx, true);

				Series1.Clear();
                Series1.ColorPalette.TopColor = Color.Blue;
                Series1.ColorPalette.BottomColor = Color.White;
                Series1.Matrix = bMtx; //must be set...
//                Series1.ColorPalette.CreateDefaultPalette();
                Series1.Repaint();

			} finally {
				this.Cursor = Cursors.Default;
				MtxVec.FreeIt(ref aMtx);
				MtxVec.FreeIt(ref av);
			}
		}

		private void checkBoxSingleLines_CheckedChanged(object sender, System.EventArgs e) {
			button1_Click(sender, e);
		}

        protected void Add(String s)
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void BiSpectrumGridForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            Add("Bicoherence shows dark blue dots where the frequency "
            +   "pair is related to a third frequency component defined "
            +   "as e^jw1 * e^jw2 = e^j(w1+w2). Bicoherence  will be 1 "
            +   "for a frequency pair (w1,w2) which has a product of itself "
            +   "(e^jw1*e^jw2) in the frequency spectrum. You can also "
            +   "compute only preselected frequency lines by checking "
            +   "the Only a few lines box.");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChartButton_Click(object sender, EventArgs e)
        {
            ChartEditor.ShowModal();
        }
	}
}
