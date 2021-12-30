using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Units;
using Dew.Math.Tee;

namespace MtxVecDemo
{
	public class MatrixSeriesForm : MtxVecDemo.BasicForm2
	{
		private System.Windows.Forms.CheckBox checkBoxAnimate;
		private System.Windows.Forms.CheckBox checkBoxValue;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
		private System.ComponentModel.IContainer components = null;


		private TMtx a;
		private TVec v1,v2;
		private TSparseMtx sparseA;
		private System.Timers.Timer timer1;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private TrackBar trackBar1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label2;
        private Steema.TeeChart.TChart tChart1;
        private CheckBox checkBox3;
		private Dew.Math.Tee.MtxGridSeries gridSeries, legendSeries;
        private SplitContainer splitContainer1;
        private Steema.TeeChart.TChart tChart2;
        private Panel panel4;

		public MatrixSeriesForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			tChart1.Axes.Left.Title.Text = "Index";

            gridSeries = new MtxGridSeries();
		    gridSeries.ValueFormat = "0.00";
			gridSeries.ColorPalette.BottomColor = Color.White;
            gridSeries.ColorPalette.TopColor = Color.FromArgb(74, 127, 186);
            gridSeries.ColorPalette.PaletteSteps = 32;
            // Setup axes
            gridSeries.HorizAxis = Steema.TeeChart.Styles.HorizontalAxis.Top;
            gridSeries.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Left;
            gridSeries.ColorPalette.ColorBalance = 0.18;
            gridSeries.Chart = tChart1.Chart;
            gridSeries.GetHorizAxis.Increment = 1.0;
            gridSeries.GetHorizAxis.Labels.RoundFirstLabel = false;
            gridSeries.GetVertAxis.Increment = 1.0;
            gridSeries.GetVertAxis.Labels.RoundFirstLabel = false;


            legendSeries = new MtxGridSeries();
            legendSeries.Chart = tChart2.Chart;
			
			sparseA = new TSparseMtx();
			a = new TMtx();
			v1 = new TVec();
			v2 = new TVec();
			sparseA.Size(1000,1000,100000,false);
            sparseA.RandomSparse(v1,v2,false,1,100000);
			TPixelDownSample mode = TPixelDownSample.pdsPattern;
			if (radioButton1.Checked) mode = TPixelDownSample.pdsPattern;
			else if (radioButton2.Checked) mode = TPixelDownSample.pdsPeak;
			else if (radioButton3.Checked) mode = TPixelDownSample.pdsAverage;
            sparseA.PixelDownSample(a,200,mode);
            MtxVecTee.DrawValues(a, gridSeries);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.checkBoxAnimate = new System.Windows.Forms.CheckBox();
            this.checkBoxValue = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Timers.Timer();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tChart1 = new Steema.TeeChart.TChart();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tChart2 = new Steema.TeeChart.TChart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(0, 170);
            this.panel2.Size = new System.Drawing.Size(911, 455);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 625);
            this.panel3.Size = new System.Drawing.Size(911, 48);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(911, 170);
            // 
            // checkBoxAnimate
            // 
            this.checkBoxAnimate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxAnimate.Location = new System.Drawing.Point(18, 14);
            this.checkBoxAnimate.Name = "checkBoxAnimate";
            this.checkBoxAnimate.Size = new System.Drawing.Size(125, 19);
            this.checkBoxAnimate.TabIndex = 0;
            this.checkBoxAnimate.Text = "Animate";
            this.checkBoxAnimate.CheckedChanged += new System.EventHandler(this.checkBoxAnimate_CheckedChanged);
            // 
            // checkBoxValue
            // 
            this.checkBoxValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxValue.Location = new System.Drawing.Point(18, 41);
            this.checkBoxValue.Name = "checkBoxValue";
            this.checkBoxValue.Size = new System.Drawing.Size(163, 19);
            this.checkBoxValue.TabIndex = 1;
            this.checkBoxValue.Text = "Matrix value at cursor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(18, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 166);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DownSample method";
            // 
            // radioButton5
            // 
            this.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton5.Location = new System.Drawing.Point(10, 128);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(136, 20);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "Peak magnitude";
            this.radioButton5.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton4.Location = new System.Drawing.Point(10, 101);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(105, 20);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Peak";
            this.radioButton4.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton3.Location = new System.Drawing.Point(10, 74);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(144, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Average magnitude";
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton2.Location = new System.Drawing.Point(10, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Average";
            this.radioButton2.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Location = new System.Drawing.Point(10, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(136, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Non-zero pattern";
            this.radioButton1.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 250D;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(18, 290);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Tree colors";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox2.Location = new System.Drawing.Point(18, 320);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(108, 20);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Sharp contrast";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(24, 377);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(142, 46);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 18;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Color balance";
            // 
            // tChart1
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
            this.tChart1.Axes.Bottom.Grid.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Axis = this.tChart1.Axes.Bottom;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart1.Axes.Bottom.Labels.Brush.Solid = true;
            this.tChart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.tChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart1.Axes.Bottom.Labels.Font.Size = 9;
            this.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            this.tChart1.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.tChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.MinorTicks.Length = 2;
            this.tChart1.Axes.Bottom.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Ticks.Length = 4;
            this.tChart1.Axes.Bottom.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.TicksInner.Length = 0;
            this.tChart1.Axes.Bottom.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart1.Axes.Bottom.Title.Brush.Solid = true;
            this.tChart1.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.tChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.tChart1.Axes.Bottom.Title.Font.Size = 11;
            this.tChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            this.tChart1.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.tChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.AxisPen.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Axis = this.tChart1.Axes.Depth;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart1.Axes.Depth.Labels.Brush.Solid = true;
            this.tChart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.tChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart1.Axes.Depth.Labels.Font.Size = 9;
            this.tChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            this.tChart1.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.tChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.MinorTicks.Length = 2;
            this.tChart1.Axes.Depth.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Ticks.Length = 4;
            this.tChart1.Axes.Depth.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.TicksInner.Length = 0;
            this.tChart1.Axes.Depth.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart1.Axes.Depth.Title.Brush.Solid = true;
            this.tChart1.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Axes.Depth.Title.Font.Brush.Solid = true;
            this.tChart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.tChart1.Axes.Depth.Title.Font.Size = 11;
            this.tChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            this.tChart1.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.tChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.AxisPen.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Axis = this.tChart1.Axes.DepthTop;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart1.Axes.DepthTop.Labels.Brush.Solid = true;
            this.tChart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.tChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart1.Axes.DepthTop.Labels.Font.Size = 9;
            this.tChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            this.tChart1.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.tChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.tChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.MinorTicks.Length = 2;
            this.tChart1.Axes.DepthTop.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Ticks.Length = 4;
            this.tChart1.Axes.DepthTop.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.TicksInner.Length = 0;
            this.tChart1.Axes.DepthTop.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart1.Axes.DepthTop.Title.Brush.Solid = true;
            this.tChart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.tChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.tChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.tChart1.Axes.DepthTop.Title.Font.Size = 11;
            this.tChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            this.tChart1.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.tChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.tChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.AxisPen.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Axis = this.tChart1.Axes.Left;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart1.Axes.Left.Labels.Brush.Solid = true;
            this.tChart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Axes.Left.Labels.Font.Brush.Solid = true;
            this.tChart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart1.Axes.Left.Labels.Font.Size = 9;
            this.tChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            this.tChart1.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.tChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            this.tChart1.Axes.Left.Labels.RoundFirstLabel = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Left.MinorTicks.Length = 2;
            this.tChart1.Axes.Left.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Ticks.Length = 4;
            this.tChart1.Axes.Left.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.TicksInner.Length = 0;
            this.tChart1.Axes.Left.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart1.Axes.Left.Title.Brush.Solid = true;
            this.tChart1.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Axes.Left.Title.Font.Brush.Solid = true;
            this.tChart1.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.tChart1.Axes.Left.Title.Font.Size = 11;
            this.tChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            this.tChart1.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.tChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.AxisPen.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Axis = this.tChart1.Axes.Right;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart1.Axes.Right.Labels.Brush.Solid = true;
            this.tChart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Axes.Right.Labels.Font.Brush.Solid = true;
            this.tChart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart1.Axes.Right.Labels.Font.Size = 9;
            this.tChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            this.tChart1.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.tChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Right.MinorTicks.Length = 2;
            this.tChart1.Axes.Right.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Ticks.Length = 4;
            this.tChart1.Axes.Right.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.TicksInner.Length = 0;
            this.tChart1.Axes.Right.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart1.Axes.Right.Title.Brush.Solid = true;
            this.tChart1.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Axes.Right.Title.Font.Brush.Solid = true;
            this.tChart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.tChart1.Axes.Right.Title.Font.Size = 11;
            this.tChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            this.tChart1.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.tChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Axis = this.tChart1.Axes.Top;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart1.Axes.Top.Labels.Brush.Solid = true;
            this.tChart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Axes.Top.Labels.Font.Brush.Solid = true;
            this.tChart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart1.Axes.Top.Labels.Font.Size = 9;
            this.tChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            this.tChart1.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.tChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            this.tChart1.Axes.Top.Labels.RoundFirstLabel = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Top.MinorTicks.Length = 2;
            this.tChart1.Axes.Top.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Ticks.Length = 4;
            this.tChart1.Axes.Top.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Top.TicksInner.Length = 0;
            this.tChart1.Axes.Top.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart1.Axes.Top.Title.Brush.Solid = true;
            this.tChart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Axes.Top.Title.Font.Brush.Solid = true;
            this.tChart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.tChart1.Axes.Top.Title.Font.Size = 11;
            this.tChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            this.tChart1.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.tChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.tChart1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.tChart1.Footer.Brush.Solid = true;
            this.tChart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.tChart1.Footer.Font.Brush.Solid = true;
            this.tChart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Footer.Font.Shadow.Brush.Solid = true;
            this.tChart1.Footer.Font.Shadow.Brush.Visible = true;
            this.tChart1.Footer.Font.Size = 8;
            this.tChart1.Footer.Font.SizeFloat = 8F;
            this.tChart1.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Footer.ImageBevel.Brush.Solid = true;
            this.tChart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Footer.Shadow.Brush.Solid = true;
            this.tChart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChart1.Header.Brush.Solid = true;
            this.tChart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Header.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Header.Font.Brush.Solid = true;
            this.tChart1.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Header.Font.Shadow.Brush.Solid = true;
            this.tChart1.Header.Font.Shadow.Brush.Visible = true;
            this.tChart1.Header.Font.Size = 12;
            this.tChart1.Header.Font.SizeFloat = 12F;
            this.tChart1.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Header.ImageBevel.Brush.Solid = true;
            this.tChart1.Header.ImageBevel.Brush.Visible = true;
            this.tChart1.Header.Lines = new string[] {
        "Matrix values"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChart1.Header.Shadow.Brush.Solid = true;
            this.tChart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Brush.Color = System.Drawing.Color.White;
            this.tChart1.Legend.Brush.Solid = true;
            this.tChart1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Legend.Font.Brush.Solid = true;
            this.tChart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Legend.Font.Shadow.Brush.Solid = true;
            this.tChart1.Legend.Font.Shadow.Brush.Visible = true;
            this.tChart1.Legend.Font.Size = 9;
            this.tChart1.Legend.Font.SizeFloat = 9F;
            this.tChart1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Legend.ImageBevel.Brush.Solid = true;
            this.tChart1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Legend.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Legend.Shadow.Brush.Solid = true;
            this.tChart1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Legend.Symbol.Legend = this.tChart1.Legend;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Legend.Symbol.Shadow.Brush.Solid = true;
            this.tChart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.tChart1.Legend.Title.Brush.Solid = true;
            this.tChart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.tChart1.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.tChart1.Legend.Title.Font.Brush.Solid = true;
            this.tChart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.tChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.tChart1.Legend.Title.Font.Size = 8;
            this.tChart1.Legend.Title.Font.SizeFloat = 8F;
            this.tChart1.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Legend.Title.ImageBevel.Brush.Solid = true;
            this.tChart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Legend.Title.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Legend.Title.Shadow.Brush.Solid = true;
            this.tChart1.Legend.Title.Shadow.Brush.Visible = true;
            this.tChart1.Location = new System.Drawing.Point(0, 0);
            this.tChart1.Name = "tChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
            this.tChart1.Panel.Brush.Solid = true;
            this.tChart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Panel.ImageBevel.Brush.Solid = true;
            this.tChart1.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.Panel.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Panel.Shadow.Brush.Solid = true;
            this.tChart1.Panel.Shadow.Brush.Visible = true;
            this.tChart1.Size = new System.Drawing.Size(712, 455);
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.tChart1.SubFooter.Brush.Solid = true;
            this.tChart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.tChart1.SubFooter.Font.Brush.Solid = true;
            this.tChart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.SubFooter.Font.Shadow.Brush.Solid = true;
            this.tChart1.SubFooter.Font.Shadow.Brush.Visible = true;
            this.tChart1.SubFooter.Font.Size = 8;
            this.tChart1.SubFooter.Font.SizeFloat = 8F;
            this.tChart1.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.SubFooter.ImageBevel.Brush.Solid = true;
            this.tChart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.SubFooter.Shadow.Brush.Solid = true;
            this.tChart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChart1.SubHeader.Brush.Solid = true;
            this.tChart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.tChart1.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.SubHeader.Font.Brush.Solid = true;
            this.tChart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.SubHeader.Font.Shadow.Brush.Solid = true;
            this.tChart1.SubHeader.Font.Shadow.Brush.Visible = true;
            this.tChart1.SubHeader.Font.Size = 12;
            this.tChart1.SubHeader.Font.SizeFloat = 12F;
            this.tChart1.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.SubHeader.ImageBevel.Brush.Solid = true;
            this.tChart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChart1.SubHeader.Shadow.Brush.Solid = true;
            this.tChart1.SubHeader.Shadow.Brush.Visible = true;
            this.tChart1.TabIndex = 10;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.tChart1.Walls.Back.Brush.Solid = true;
            this.tChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Walls.Back.ImageBevel.Brush.Solid = true;
            this.tChart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Walls.Back.Shadow.Brush.Solid = true;
            this.tChart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.tChart1.Walls.Bottom.Brush.Solid = true;
            this.tChart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.tChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Walls.Bottom.Shadow.Brush.Solid = true;
            this.tChart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.tChart1.Walls.Left.Brush.Solid = true;
            this.tChart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Walls.Left.ImageBevel.Brush.Solid = true;
            this.tChart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Walls.Left.Shadow.Brush.Solid = true;
            this.tChart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.tChart1.Walls.Right.Brush.Solid = true;
            this.tChart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Walls.Right.ImageBevel.Brush.Solid = true;
            this.tChart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Walls.Right.Shadow.Brush.Solid = true;
            this.tChart1.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Zoom.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.tChart1.Zoom.Brush.Solid = true;
            this.tChart1.Zoom.Brush.Visible = true;
            this.tChart1.AfterDraw += new Steema.TeeChart.PaintChartEventHandler(this.tChart1_AfterDraw);
            this.tChart1.GetAxisLabel += new Steema.TeeChart.GetAxisLabelEventHandler(this.tChart1_GetAxisLabel);
            this.tChart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tChart1_MouseMove);
            // 
            // checkBox3
            // 
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox3.Location = new System.Drawing.Point(18, 68);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(163, 19);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "Pixel resample";
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(199, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tChart1);
            this.splitContainer1.Panel1MinSize = 40;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tChart2);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Panel2MinSize = 40;
            this.splitContainer1.Size = new System.Drawing.Size(712, 455);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.TabIndex = 12;
            // 
            // tChart2
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
            this.tChart2.Axes.Bottom.Grid.Visible = false;
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Labels.Axis = this.tChart2.Axes.Bottom;
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart2.Axes.Bottom.Labels.Brush.Solid = true;
            this.tChart2.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart2.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.tChart2.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart2.Axes.Bottom.Labels.Font.Size = 9;
            this.tChart2.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            this.tChart2.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.tChart2.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.MinorTicks.Length = 2;
            this.tChart2.Axes.Bottom.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Ticks.Length = 4;
            this.tChart2.Axes.Bottom.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.TicksInner.Length = 0;
            this.tChart2.Axes.Bottom.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart2.Axes.Bottom.Title.Brush.Solid = true;
            this.tChart2.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart2.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.tChart2.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.tChart2.Axes.Bottom.Title.Font.Size = 11;
            this.tChart2.Axes.Bottom.Title.Font.SizeFloat = 11F;
            this.tChart2.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.tChart2.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            this.tChart2.Axes.Bottom.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Depth.AxisPen.Visible = false;
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Labels.Axis = this.tChart2.Axes.Depth;
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart2.Axes.Depth.Labels.Brush.Solid = true;
            this.tChart2.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart2.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.tChart2.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart2.Axes.Depth.Labels.Font.Size = 9;
            this.tChart2.Axes.Depth.Labels.Font.SizeFloat = 9F;
            this.tChart2.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.tChart2.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Depth.MinorTicks.Length = 2;
            this.tChart2.Axes.Depth.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Ticks.Length = 4;
            this.tChart2.Axes.Depth.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChart2.Axes.Depth.TicksInner.Length = 0;
            this.tChart2.Axes.Depth.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart2.Axes.Depth.Title.Brush.Solid = true;
            this.tChart2.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart2.Axes.Depth.Title.Font.Brush.Solid = true;
            this.tChart2.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.tChart2.Axes.Depth.Title.Font.Size = 11;
            this.tChart2.Axes.Depth.Title.Font.SizeFloat = 11F;
            this.tChart2.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.tChart2.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.AxisPen.Visible = false;
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Labels.Axis = this.tChart2.Axes.DepthTop;
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart2.Axes.DepthTop.Labels.Brush.Solid = true;
            this.tChart2.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart2.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.tChart2.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart2.Axes.DepthTop.Labels.Font.Size = 9;
            this.tChart2.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            this.tChart2.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.tChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.tChart2.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.MinorTicks.Length = 2;
            this.tChart2.Axes.DepthTop.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Ticks.Length = 4;
            this.tChart2.Axes.DepthTop.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.TicksInner.Length = 0;
            this.tChart2.Axes.DepthTop.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart2.Axes.DepthTop.Title.Brush.Solid = true;
            this.tChart2.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart2.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.tChart2.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.tChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.tChart2.Axes.DepthTop.Title.Font.Size = 11;
            this.tChart2.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            this.tChart2.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.tChart2.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.tChart2.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Left.AxisPen.Visible = false;
            // 
            // 
            // 
            this.tChart2.Axes.Left.Labels.Axis = this.tChart2.Axes.Left;
            // 
            // 
            // 
            this.tChart2.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart2.Axes.Left.Labels.Brush.Solid = true;
            this.tChart2.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart2.Axes.Left.Labels.Font.Brush.Solid = true;
            this.tChart2.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart2.Axes.Left.Labels.Font.Size = 9;
            this.tChart2.Axes.Left.Labels.Font.SizeFloat = 9F;
            this.tChart2.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.tChart2.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Left.MinorTicks.Length = 2;
            this.tChart2.Axes.Left.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart2.Axes.Left.Ticks.Length = 4;
            this.tChart2.Axes.Left.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChart2.Axes.Left.TicksInner.Length = 0;
            this.tChart2.Axes.Left.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart2.Axes.Left.Title.Brush.Solid = true;
            this.tChart2.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart2.Axes.Left.Title.Font.Brush.Solid = true;
            this.tChart2.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.tChart2.Axes.Left.Title.Font.Size = 11;
            this.tChart2.Axes.Left.Title.Font.SizeFloat = 11F;
            this.tChart2.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.tChart2.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Right.AxisPen.Visible = false;
            // 
            // 
            // 
            this.tChart2.Axes.Right.Labels.Axis = this.tChart2.Axes.Right;
            // 
            // 
            // 
            this.tChart2.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart2.Axes.Right.Labels.Brush.Solid = true;
            this.tChart2.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart2.Axes.Right.Labels.Font.Brush.Solid = true;
            this.tChart2.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart2.Axes.Right.Labels.Font.Size = 9;
            this.tChart2.Axes.Right.Labels.Font.SizeFloat = 9F;
            this.tChart2.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.tChart2.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Right.MinorTicks.Length = 2;
            this.tChart2.Axes.Right.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart2.Axes.Right.Ticks.Length = 4;
            this.tChart2.Axes.Right.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChart2.Axes.Right.TicksInner.Length = 0;
            this.tChart2.Axes.Right.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart2.Axes.Right.Title.Brush.Solid = true;
            this.tChart2.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart2.Axes.Right.Title.Font.Brush.Solid = true;
            this.tChart2.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.tChart2.Axes.Right.Title.Font.Size = 11;
            this.tChart2.Axes.Right.Title.Font.SizeFloat = 11F;
            this.tChart2.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.tChart2.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Top.Labels.Axis = this.tChart2.Axes.Top;
            // 
            // 
            // 
            this.tChart2.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChart2.Axes.Top.Labels.Brush.Solid = true;
            this.tChart2.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart2.Axes.Top.Labels.Font.Brush.Solid = true;
            this.tChart2.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.tChart2.Axes.Top.Labels.Font.Size = 9;
            this.tChart2.Axes.Top.Labels.Font.SizeFloat = 9F;
            this.tChart2.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.tChart2.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Top.MinorTicks.Length = 2;
            this.tChart2.Axes.Top.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart2.Axes.Top.Ticks.Length = 4;
            this.tChart2.Axes.Top.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChart2.Axes.Top.TicksInner.Length = 0;
            this.tChart2.Axes.Top.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart2.Axes.Top.Title.Brush.Solid = true;
            this.tChart2.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart2.Axes.Top.Title.Font.Brush.Solid = true;
            this.tChart2.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.tChart2.Axes.Top.Title.Font.Size = 11;
            this.tChart2.Axes.Top.Title.Font.SizeFloat = 11F;
            this.tChart2.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.tChart2.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.tChart2.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.tChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.tChart2.Footer.Brush.Solid = true;
            this.tChart2.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.tChart2.Footer.Font.Brush.Solid = true;
            this.tChart2.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Footer.Font.Shadow.Brush.Solid = true;
            this.tChart2.Footer.Font.Shadow.Brush.Visible = true;
            this.tChart2.Footer.Font.Size = 8;
            this.tChart2.Footer.Font.SizeFloat = 8F;
            this.tChart2.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Footer.ImageBevel.Brush.Solid = true;
            this.tChart2.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Footer.Shadow.Brush.Solid = true;
            this.tChart2.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChart2.Header.Brush.Solid = true;
            this.tChart2.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Header.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart2.Header.Font.Brush.Solid = true;
            this.tChart2.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Header.Font.Shadow.Brush.Solid = true;
            this.tChart2.Header.Font.Shadow.Brush.Visible = true;
            this.tChart2.Header.Font.Size = 12;
            this.tChart2.Header.Font.SizeFloat = 12F;
            this.tChart2.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Header.ImageBevel.Brush.Solid = true;
            this.tChart2.Header.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChart2.Header.Shadow.Brush.Solid = true;
            this.tChart2.Header.Shadow.Brush.Visible = true;
            this.tChart2.Header.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Legend.Brush.Color = System.Drawing.Color.White;
            this.tChart2.Legend.Brush.Solid = true;
            this.tChart2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart2.Legend.Font.Brush.Solid = true;
            this.tChart2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Legend.Font.Shadow.Brush.Solid = true;
            this.tChart2.Legend.Font.Shadow.Brush.Visible = true;
            this.tChart2.Legend.Font.Size = 9;
            this.tChart2.Legend.Font.SizeFloat = 9F;
            this.tChart2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Legend.ImageBevel.Brush.Solid = true;
            this.tChart2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Legend.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart2.Legend.Shadow.Brush.Solid = true;
            this.tChart2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Legend.Symbol.Legend = this.tChart2.Legend;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Legend.Symbol.Shadow.Brush.Solid = true;
            this.tChart2.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.tChart2.Legend.Title.Brush.Solid = true;
            this.tChart2.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.tChart2.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.tChart2.Legend.Title.Font.Brush.Solid = true;
            this.tChart2.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.tChart2.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.tChart2.Legend.Title.Font.Size = 8;
            this.tChart2.Legend.Title.Font.SizeFloat = 8F;
            this.tChart2.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Legend.Title.ImageBevel.Brush.Solid = true;
            this.tChart2.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Legend.Title.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Legend.Title.Shadow.Brush.Solid = true;
            this.tChart2.Legend.Title.Shadow.Brush.Visible = true;
            this.tChart2.Legend.Visible = false;
            this.tChart2.Location = new System.Drawing.Point(0, 0);
            this.tChart2.Name = "tChart2";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart2.Panel.Brush.Gradient.UseMiddle = true;
            this.tChart2.Panel.Brush.Solid = true;
            this.tChart2.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Panel.ImageBevel.Brush.Solid = true;
            this.tChart2.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.Panel.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Panel.Shadow.Brush.Solid = true;
            this.tChart2.Panel.Shadow.Brush.Visible = true;
            this.tChart2.Size = new System.Drawing.Size(115, 123);
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.tChart2.SubFooter.Brush.Solid = true;
            this.tChart2.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.tChart2.SubFooter.Font.Brush.Solid = true;
            this.tChart2.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.SubFooter.Font.Shadow.Brush.Solid = true;
            this.tChart2.SubFooter.Font.Shadow.Brush.Visible = true;
            this.tChart2.SubFooter.Font.Size = 8;
            this.tChart2.SubFooter.Font.SizeFloat = 8F;
            this.tChart2.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.SubFooter.ImageBevel.Brush.Solid = true;
            this.tChart2.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.SubFooter.Shadow.Brush.Solid = true;
            this.tChart2.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChart2.SubHeader.Brush.Solid = true;
            this.tChart2.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.tChart2.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.tChart2.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart2.SubHeader.Font.Brush.Solid = true;
            this.tChart2.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.SubHeader.Font.Shadow.Brush.Solid = true;
            this.tChart2.SubHeader.Font.Shadow.Brush.Visible = true;
            this.tChart2.SubHeader.Font.Size = 12;
            this.tChart2.SubHeader.Font.SizeFloat = 12F;
            this.tChart2.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.SubHeader.ImageBevel.Brush.Solid = true;
            this.tChart2.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChart2.SubHeader.Shadow.Brush.Solid = true;
            this.tChart2.SubHeader.Shadow.Brush.Visible = true;
            this.tChart2.TabIndex = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.tChart2.Walls.Back.Brush.Solid = true;
            this.tChart2.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Walls.Back.ImageBevel.Brush.Solid = true;
            this.tChart2.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Walls.Back.Shadow.Brush.Solid = true;
            this.tChart2.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.tChart2.Walls.Bottom.Brush.Solid = true;
            this.tChart2.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.tChart2.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Walls.Bottom.Shadow.Brush.Solid = true;
            this.tChart2.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.tChart2.Walls.Left.Brush.Solid = true;
            this.tChart2.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Walls.Left.ImageBevel.Brush.Solid = true;
            this.tChart2.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Walls.Left.Shadow.Brush.Solid = true;
            this.tChart2.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.tChart2.Walls.Right.Brush.Solid = true;
            this.tChart2.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart2.Walls.Right.ImageBevel.Brush.Solid = true;
            this.tChart2.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart2.Walls.Right.Shadow.Brush.Solid = true;
            this.tChart2.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart2.Zoom.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.tChart2.Zoom.Brush.Solid = true;
            this.tChart2.Zoom.Brush.Visible = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.checkBoxAnimate);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.checkBox3);
            this.panel4.Controls.Add(this.checkBoxValue);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.trackBar1);
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.Controls.Add(this.checkBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 455);
            this.panel4.TabIndex = 13;
            // 
            // MatrixSeriesForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(911, 673);
            this.Name = "MatrixSeriesForm";
            this.Load += new System.EventHandler(this.MatrixSeriesForm_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void radioButton3_Click(object sender, System.EventArgs e) {
            TPixelDownSample mode = TPixelDownSample.pdsPattern;
            if (radioButton1.Checked) mode = TPixelDownSample.pdsPattern;
            else if (radioButton2.Checked) mode = TPixelDownSample.pdsAverage;
            else if (radioButton3.Checked) mode = TPixelDownSample.pdsAverageMagnitude;
            else if (radioButton4.Checked) mode = TPixelDownSample.pdsPeak;
            else if (radioButton5.Checked) mode = TPixelDownSample.pdsPeakMagnitude;
			sparseA.PixelDownSample(a,200,mode);
            UpdateCharts();
		}

		private void tChart1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) 
        {
			if (checkBoxValue.Checked) {
				tChart1.Header.Text = "";
				int index = gridSeries.Clicked(e.X,e.Y);
				if (index != -1) {
					tChart1.Header.Text = "Value at cursor : " + 
						a.Values1D[index].ToString("0.00");
				}
			}
		}

		private void checkBoxAnimate_CheckedChanged(object sender, System.EventArgs e) {
			timer1.Enabled = checkBoxAnimate.Checked;
			groupBox1.Enabled = !timer1.Enabled;
			checkBoxValue.Enabled = !timer1.Enabled;
		}

        private void UpdateData()
        {
            sparseA.Size(1000,1000,100000,false);
            sparseA.RandomSparse(v1,v2,false,1,100000);
            TPixelDownSample mode = TPixelDownSample.pdsPattern;
            if (radioButton1.Checked) mode = TPixelDownSample.pdsPattern;
            else if (radioButton2.Checked) mode = TPixelDownSample.pdsAverage;
            else if (radioButton3.Checked) mode = TPixelDownSample.pdsAverageMagnitude;
            else if (radioButton4.Checked) mode = TPixelDownSample.pdsPeak;
            else if (radioButton5.Checked) mode = TPixelDownSample.pdsPeakMagnitude;

            sparseA.PixelDownSample(a, 200, mode);
            gridSeries.PixelResampleMethod = mode;

            UpdateCharts();
        }

        private void UpdateCharts()
        {
            splitContainer1.Panel2Collapsed = !checkBox3.Checked;
            splitContainer1.Panel1.Refresh();
            MtxVecTee.DrawValues(a, gridSeries);
        }

		private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e) 
        {
            timer1.Enabled = false;
            try
            {
                UpdateData();
            }
            finally
            {
                timer1.Enabled = true;
            }
		}

		private void MatrixSeriesForm_Load(object sender, System.EventArgs e) {
			Add("MtxGridSeries which can be used "
				+ "with all TeeChart versions (.NET v1, .NET v2, .NET v3 "
				+ "Using MtxGridSeries you can visualize matrix values. "
				+ "Key properties/methods are:");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.SelectionIndent = 10;
			Add("property PaletteSteps : Defines the number of palette steps for legend");
			Add("property BottomColor, TopColor : Defines color for lowest and highest value.");
			Add("property PaletteStyle : Default value is palRange meaning palette "
				+ "colors will be calculated from BottomColor, TopColor and PaletteSteps "
				+ "properties.  If you want to define custom palette levels, set "
				+ "PaletteStyle to palCustom and then define level and it's color by using "
				+ "AddPalette method.");
			Add("method AddPalette : adds new palette level (works only if PaletteStyle is palCustom).");
			Add("method CreateRangePalette : Recreates range palette values. Call this method if matrix "
				+ "maximum/minimum value changes.");
			Add("method ClearPalette : clears palette.");

			richTextBox1.SelectionBullet = false;
			richTextBox1.SelectionIndent = 0;
			Add("");
			Add("Some properties are accessible via the MtxGridSeries editor (click on \"Edit Grid Series\" button).");
		}

        private void button1_Click(object sender, EventArgs e)
        {
            // missing editor
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            gridSeries.ColorPalette.ColorBalance = (double)trackBar1.Value / 100.0;
            UpdateCharts();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) gridSeries.ColorPalette.MidColor = Color.Red;
            else gridSeries.ColorPalette.MidColor = Color.Transparent;

            checkBox2.Enabled = gridSeries.ColorPalette.UseMidColor;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            gridSeries.ColorPalette.SharpConstrast = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            gridSeries.PixelResample = checkBox3.Checked;
//            gridSeries.ShowInLegend = !checkBox3.Checked;
            UpdateCharts();
        }

        private void tChart1_AfterDraw(object sender, Steema.TeeChart.Drawing.IGraphics3D g)
        {
            legendSeries.SeriesToLegend(gridSeries, ColorScaleLegend.cslVertical);
        }

        private void tChart1_GetAxisLabel(object sender, Steema.TeeChart.GetAxisLabelEventArgs e)
        {
            if ((gridSeries.Matrix != null) && (sender == gridSeries.GetVertAxis))
            {
            } 
        }
	}
}

