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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiSpectrumGridForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChartButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelProgress = new System.Windows.Forms.Label();
            this.checkBoxSingleLines = new System.Windows.Forms.CheckBox();
            this.Chart1 = new Steema.TeeChart.TChart();
            this.SignalRead1 = new Dew.Signal.TSignalRead(this.components);
            this.BiSpectrumAnalyzer1 = new Dew.Signal.TBiSpectrumAnalyzer(this.components);
            this.ChartEditor = new Steema.TeeChart.Editor(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(640, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.ChartButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labelProgress);
            this.panel1.Controls.Add(this.checkBoxSingleLines);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 35);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ChartButton
            // 
            this.ChartButton.Location = new System.Drawing.Point(12, 7);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(75, 23);
            this.ChartButton.TabIndex = 7;
            this.ChartButton.Text = "Chart...";
            this.ChartButton.Click += new System.EventHandler(this.ChartButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Recalculate";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelProgress
            // 
            this.labelProgress.Location = new System.Drawing.Point(361, 6);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(100, 24);
            this.labelProgress.TabIndex = 5;
            this.labelProgress.Text = "Progress: 0 [%]";
            this.labelProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxSingleLines
            // 
            this.checkBoxSingleLines.Checked = true;
            this.checkBoxSingleLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSingleLines.Location = new System.Drawing.Point(243, 6);
            this.checkBoxSingleLines.Name = "checkBoxSingleLines";
            this.checkBoxSingleLines.Size = new System.Drawing.Size(112, 24);
            this.checkBoxSingleLines.TabIndex = 4;
            this.checkBoxSingleLines.Text = "Only a few lines";
            this.checkBoxSingleLines.CheckedChanged += new System.EventHandler(this.checkBoxSingleLines_CheckedChanged);
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
            this.Chart1.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.Chart1.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.Chart1.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            // 
            // 
            // 
            this.Chart1.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.Chart1.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.Chart1.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            // 
            // 
            // 
            this.Chart1.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.Chart1.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.Chart1.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.Chart1.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.Chart1.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.Chart1.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.Chart1.Axes.Right.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.Chart1.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.Chart1.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            // 
            // 
            // 
            this.Chart1.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.Chart1.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.Chart1.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            
            this.Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.Chart1.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.Chart1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            // 
            // 
            // 
            this.Chart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Chart1.Legend.Shadow.Brush.Solid = true;
            this.Chart1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
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
            this.Chart1.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            // 
            // 
            // 
            this.Chart1.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Legend.Title.Shadow.Brush.Solid = true;
            this.Chart1.Legend.Title.Shadow.Brush.Visible = true;
            this.Chart1.Location = new System.Drawing.Point(0, 96);
            this.Chart1.Name = "Chart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            this.Chart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart1.Panel.Brush.Color = System.Drawing.Color.Silver;
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
            // 
            // 
            // 
            this.Chart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart1.Panel.Shadow.Brush.Solid = true;
            this.Chart1.Panel.Shadow.Brush.Visible = true;
            this.Chart1.Size = new System.Drawing.Size(640, 346);
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.Chart1.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.Chart1.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart1.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.Chart1.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.Chart1.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.Chart1.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.Chart1.Zoom.Animated = true;
            // 
            // 
            // 
            this.Chart1.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.Chart1.Zoom.Brush.Solid = true;
            this.Chart1.Zoom.Brush.Visible = false;
            this.Chart1.Zoom.FullRepaint = true;
            this.Chart1.Zoom.History = true;
            // 
            // 
            // 
            this.Chart1.Zoom.Pen.Visible = true;
            // 
            // SignalRead1
            // 
            this.SignalRead1.BandwidthL = 0D;
            this.SignalRead1.BlockAssign = false;
            this.SignalRead1.Complex = false;
            this.SignalRead1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.SignalRead1.FloatPrecisionLock = false;
            this.SignalRead1.FramesPerSecond = 0.00048828125D;
            this.SignalRead1.Input = null;
            this.SignalRead1.IsDouble = true;
            this.SignalRead1.Length = 2048;
            this.SignalRead1.Name = "";
            this.SignalRead1.RecordPosition = ((long)(0));
            this.SignalRead1.SamplingFrequency = 4666.66666666667D;
            // 
            // BiSpectrumAnalyzer1
            // 
            this.BiSpectrumAnalyzer1.Bands.TemplateIndex = -1;
            this.BiSpectrumAnalyzer1.Bands.Templates = new Dew.Signal.TStringStreamList(System.Convert.FromBase64String("AAAAAA=="));
            this.BiSpectrumAnalyzer1.BiAnalyzer.Recursive = false;
            this.BiSpectrumAnalyzer1.BlockAssign = false;
            this.BiSpectrumAnalyzer1.Complex = false;
            this.BiSpectrumAnalyzer1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.BiSpectrumAnalyzer1.FloatPrecisionLock = false;
            this.BiSpectrumAnalyzer1.Input = this.SignalRead1;
            this.BiSpectrumAnalyzer1.IsDouble = true;
            this.BiSpectrumAnalyzer1.LogBase = 0D;
            this.BiSpectrumAnalyzer1.LogScale = 0D;
            this.BiSpectrumAnalyzer1.Name = "";
            this.BiSpectrumAnalyzer1.Output = null;
            this.BiSpectrumAnalyzer1.Peaks.Interpolation.Method = Dew.Signal.TInterpolationMethod.imNone;
            this.BiSpectrumAnalyzer1.Peaks.Interpolation.RecursiveHarmonics = Dew.Signal.TRecursiveHarmonics.rhNone;
            this.BiSpectrumAnalyzer1.Report.UseTab = false;
            this.BiSpectrumAnalyzer1.SpectrumScale = 0D;
            this.BiSpectrumAnalyzer1.Stats.Averaging = Dew.Signal.TAveraging.avLinearInf;
            this.BiSpectrumAnalyzer1.Window = Dew.Signal.TSignalWindowType.wtHanning;
            // 
            // ChartEditor
            // 
            this.ChartEditor.Chart = this.Chart1;
            this.ChartEditor.HighLightTabs = false;
            this.ChartEditor.Location = new System.Drawing.Point(0, 0);
            this.ChartEditor.Name = "ChartEditor";
            this.ChartEditor.Options = null;
            this.ChartEditor.TabIndex = 0;
            // 
            // BiSpectrumGridForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(640, 477);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "BiSpectrumGridForm";
            this.Text = "BiSpectrumGridForm";
            this.Load += new System.EventHandler(this.BiSpectrumGridForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
