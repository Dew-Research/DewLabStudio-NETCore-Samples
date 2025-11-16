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
            Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
            Steema.TeeChart.Margins margins2 = new Steema.TeeChart.Margins();
            checkBoxAnimate = new CheckBox();
            checkBoxValue = new CheckBox();
            groupBox1 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            timer1 = new System.Timers.Timer();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            trackBar1 = new TrackBar();
            label2 = new Label();
            tChart1 = new Steema.TeeChart.TChart();
            checkBox3 = new CheckBox();
            splitContainer1 = new SplitContainer();
            tChart2 = new Steema.TeeChart.TChart();
            panel4 = new Panel();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)timer1).BeginInit();
            ((ISupportInitialize)trackBar1).BeginInit();
            ((ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(splitContainer1);
            panel2.Controls.Add(panel4);
            panel2.Size = new Size(1025, 433);
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 571);
            panel3.Size = new Size(1025, 48);
            // 
            // richTextBox1
            // 
            richTextBox1.Size = new Size(1025, 138);
            // 
            // checkBoxAnimate
            // 
            checkBoxAnimate.FlatStyle = FlatStyle.System;
            checkBoxAnimate.Location = new Point(18, 14);
            checkBoxAnimate.Name = "checkBoxAnimate";
            checkBoxAnimate.Size = new Size(125, 19);
            checkBoxAnimate.TabIndex = 0;
            checkBoxAnimate.Text = "Animate";
            checkBoxAnimate.CheckedChanged += checkBoxAnimate_CheckedChanged;
            // 
            // checkBoxValue
            // 
            checkBoxValue.FlatStyle = FlatStyle.System;
            checkBoxValue.Location = new Point(18, 41);
            checkBoxValue.Name = "checkBoxValue";
            checkBoxValue.Size = new Size(163, 19);
            checkBoxValue.TabIndex = 1;
            checkBoxValue.Text = "Matrix value at cursor";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(18, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(161, 166);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "DownSample method";
            // 
            // radioButton5
            // 
            radioButton5.FlatStyle = FlatStyle.System;
            radioButton5.Location = new Point(10, 128);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(136, 20);
            radioButton5.TabIndex = 4;
            radioButton5.Text = "Peak magnitude";
            radioButton5.Click += radioButton3_Click;
            // 
            // radioButton4
            // 
            radioButton4.FlatStyle = FlatStyle.System;
            radioButton4.Location = new Point(10, 101);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(105, 20);
            radioButton4.TabIndex = 3;
            radioButton4.Text = "Peak";
            radioButton4.Click += radioButton3_Click;
            // 
            // radioButton3
            // 
            radioButton3.FlatStyle = FlatStyle.System;
            radioButton3.Location = new Point(10, 74);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(144, 20);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "Average magnitude";
            radioButton3.Click += radioButton3_Click;
            // 
            // radioButton2
            // 
            radioButton2.FlatStyle = FlatStyle.System;
            radioButton2.Location = new Point(10, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(105, 19);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Average";
            radioButton2.Click += radioButton3_Click;
            // 
            // radioButton1
            // 
            radioButton1.Checked = true;
            radioButton1.FlatStyle = FlatStyle.System;
            radioButton1.Location = new Point(10, 20);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(136, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Non-zero pattern";
            radioButton1.Click += radioButton3_Click;
            // 
            // timer1
            // 
            timer1.Interval = 250D;
            timer1.SynchronizingObject = this;
            timer1.Elapsed += timer1_Elapsed;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.FlatStyle = FlatStyle.System;
            checkBox1.Location = new Point(18, 290);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(88, 20);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Tree colors";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Enabled = false;
            checkBox2.FlatStyle = FlatStyle.System;
            checkBox2.Location = new Point(18, 320);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(108, 20);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Sharp contrast";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // trackBar1
            // 
            trackBar1.AutoSize = false;
            trackBar1.LargeChange = 10;
            trackBar1.Location = new Point(24, 377);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(142, 46);
            trackBar1.TabIndex = 8;
            trackBar1.TickFrequency = 10;
            trackBar1.Value = 18;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 357);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 9;
            label2.Text = "Color balance";
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
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            tChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
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
            tChart1.Axes.Left.Labels.RoundFirstLabel = false;
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
            tChart1.Axes.Top.Labels.RoundFirstLabel = false;
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
            tChart1.Cursor = Cursors.Cross;
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
    "Matrix values"
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
            tChart1.Location = new Point(0, 0);
            tChart1.Name = "tChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Panel.Brush.Color = Color.FromArgb(255, 255, 255);
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
            tChart1.Size = new Size(826, 433);
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
            tChart1.TabIndex = 10;
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
            // 
            // 
            // 
            tChart1.Zoom.Brush.Color = Color.FromArgb(127, 0, 0, 255);
            tChart1.Zoom.Brush.Solid = true;
            tChart1.Zoom.Brush.Visible = true;
            tChart1.AfterDraw += tChart1_AfterDraw;
            tChart1.GetAxisLabel += tChart1_GetAxisLabel;
            tChart1.MouseMove += tChart1_MouseMove;
            // 
            // checkBox3
            // 
            checkBox3.FlatStyle = FlatStyle.System;
            checkBox3.Location = new Point(18, 68);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(163, 19);
            checkBox3.TabIndex = 11;
            checkBox3.Text = "Pixel resample";
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(199, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tChart1);
            splitContainer1.Panel1MinSize = 40;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tChart2);
            splitContainer1.Panel2Collapsed = true;
            splitContainer1.Panel2MinSize = 40;
            splitContainer1.Size = new Size(826, 433);
            splitContainer1.SplitterDistance = 40;
            splitContainer1.TabIndex = 12;
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
            // 
            // 
            // 
            tChart2.Axes.Bottom.Labels.Brush.Color = Color.White;
            tChart2.Axes.Bottom.Labels.Brush.Solid = true;
            tChart2.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            tChart2.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            tChart2.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart2.Axes.Bottom.Labels.Font.Brush.Solid = true;
            tChart2.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            tChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            tChart2.Axes.Bottom.Labels.Font.Size = 9;
            tChart2.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            tChart2.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
            tChart2.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            tChart2.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            tChart2.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Bottom.Title.Brush.Color = Color.Silver;
            tChart2.Axes.Bottom.Title.Brush.Solid = true;
            tChart2.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            tChart2.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart2.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChart2.Axes.Bottom.Title.Font.Brush.Solid = true;
            tChart2.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            tChart2.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            tChart2.Axes.Bottom.Title.Font.Size = 11;
            tChart2.Axes.Bottom.Title.Font.SizeFloat = 11F;
            tChart2.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChart2.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            tChart2.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            tChart2.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            tChart2.Axes.Bottom.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Depth.Labels.Brush.Color = Color.White;
            tChart2.Axes.Depth.Labels.Brush.Solid = true;
            tChart2.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            tChart2.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            tChart2.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart2.Axes.Depth.Labels.Font.Brush.Solid = true;
            tChart2.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            tChart2.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            tChart2.Axes.Depth.Labels.Font.Size = 9;
            tChart2.Axes.Depth.Labels.Font.SizeFloat = 9F;
            tChart2.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
            tChart2.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            tChart2.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            tChart2.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Depth.Title.Brush.Color = Color.Silver;
            tChart2.Axes.Depth.Title.Brush.Solid = true;
            tChart2.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            tChart2.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart2.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChart2.Axes.Depth.Title.Font.Brush.Solid = true;
            tChart2.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            tChart2.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            tChart2.Axes.Depth.Title.Font.Size = 11;
            tChart2.Axes.Depth.Title.Font.SizeFloat = 11F;
            tChart2.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChart2.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            tChart2.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Axes.Depth.Title.Shadow.Brush.Solid = true;
            tChart2.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.DepthTop.Labels.Brush.Color = Color.White;
            tChart2.Axes.DepthTop.Labels.Brush.Solid = true;
            tChart2.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            tChart2.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            tChart2.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart2.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            tChart2.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            tChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            tChart2.Axes.DepthTop.Labels.Font.Size = 9;
            tChart2.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            tChart2.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
            tChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            tChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            tChart2.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.DepthTop.Title.Brush.Color = Color.Silver;
            tChart2.Axes.DepthTop.Title.Brush.Solid = true;
            tChart2.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            tChart2.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart2.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChart2.Axes.DepthTop.Title.Font.Brush.Solid = true;
            tChart2.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            tChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            tChart2.Axes.DepthTop.Title.Font.Size = 11;
            tChart2.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            tChart2.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChart2.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            tChart2.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            tChart2.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Left.Labels.Brush.Color = Color.White;
            tChart2.Axes.Left.Labels.Brush.Solid = true;
            tChart2.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            tChart2.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            tChart2.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart2.Axes.Left.Labels.Font.Brush.Solid = true;
            tChart2.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            tChart2.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            tChart2.Axes.Left.Labels.Font.Size = 9;
            tChart2.Axes.Left.Labels.Font.SizeFloat = 9F;
            tChart2.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
            tChart2.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            tChart2.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Axes.Left.Labels.Shadow.Brush.Solid = true;
            tChart2.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Left.Title.Brush.Color = Color.Silver;
            tChart2.Axes.Left.Title.Brush.Solid = true;
            tChart2.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            tChart2.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart2.Axes.Left.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChart2.Axes.Left.Title.Font.Brush.Solid = true;
            tChart2.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            tChart2.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            tChart2.Axes.Left.Title.Font.Size = 11;
            tChart2.Axes.Left.Title.Font.SizeFloat = 11F;
            tChart2.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChart2.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            tChart2.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Axes.Left.Title.Shadow.Brush.Solid = true;
            tChart2.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Right.Labels.Brush.Color = Color.White;
            tChart2.Axes.Right.Labels.Brush.Solid = true;
            tChart2.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            tChart2.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            tChart2.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart2.Axes.Right.Labels.Font.Brush.Solid = true;
            tChart2.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            tChart2.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            tChart2.Axes.Right.Labels.Font.Size = 9;
            tChart2.Axes.Right.Labels.Font.SizeFloat = 9F;
            tChart2.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
            tChart2.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            tChart2.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Axes.Right.Labels.Shadow.Brush.Solid = true;
            tChart2.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Right.Title.Brush.Color = Color.Silver;
            tChart2.Axes.Right.Title.Brush.Solid = true;
            tChart2.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            tChart2.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart2.Axes.Right.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChart2.Axes.Right.Title.Font.Brush.Solid = true;
            tChart2.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            tChart2.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            tChart2.Axes.Right.Title.Font.Size = 11;
            tChart2.Axes.Right.Title.Font.SizeFloat = 11F;
            tChart2.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChart2.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            tChart2.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Axes.Right.Title.Shadow.Brush.Solid = true;
            tChart2.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Top.Labels.Brush.Color = Color.White;
            tChart2.Axes.Top.Labels.Brush.Solid = true;
            tChart2.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            tChart2.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            tChart2.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart2.Axes.Top.Labels.Font.Brush.Solid = true;
            tChart2.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            tChart2.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            tChart2.Axes.Top.Labels.Font.Size = 9;
            tChart2.Axes.Top.Labels.Font.SizeFloat = 9F;
            tChart2.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
            tChart2.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            tChart2.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Axes.Top.Labels.Shadow.Brush.Solid = true;
            tChart2.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Top.Title.Brush.Color = Color.Silver;
            tChart2.Axes.Top.Title.Brush.Solid = true;
            tChart2.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            tChart2.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart2.Axes.Top.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChart2.Axes.Top.Title.Font.Brush.Solid = true;
            tChart2.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            tChart2.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            tChart2.Axes.Top.Title.Font.Size = 11;
            tChart2.Axes.Top.Title.Font.SizeFloat = 11F;
            tChart2.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChart2.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            tChart2.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Axes.Top.Title.Shadow.Brush.Solid = true;
            tChart2.Axes.Top.Title.Shadow.Brush.Visible = true;
            tChart2.Dock = DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Footer.Brush.Color = Color.Silver;
            tChart2.Footer.Brush.Solid = true;
            tChart2.Footer.Brush.Visible = true;
            // 
            // 
            // 
            tChart2.Footer.Font.Bold = false;
            // 
            // 
            // 
            tChart2.Footer.Font.Brush.Color = Color.Red;
            tChart2.Footer.Font.Brush.Solid = true;
            tChart2.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Footer.Font.Shadow.Brush.Solid = true;
            tChart2.Footer.Font.Shadow.Brush.Visible = true;
            tChart2.Footer.Font.Size = 8;
            tChart2.Footer.Font.SizeFloat = 8F;
            tChart2.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Footer.ImageBevel.Brush.Color = Color.LightGray;
            tChart2.Footer.ImageBevel.Brush.Solid = true;
            tChart2.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Footer.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Footer.Shadow.Brush.Solid = true;
            tChart2.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Header.Brush.Color = Color.FromArgb(192, 192, 192);
            tChart2.Header.Brush.Solid = true;
            tChart2.Header.Brush.Visible = true;
            // 
            // 
            // 
            tChart2.Header.Font.Bold = false;
            // 
            // 
            // 
            tChart2.Header.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart2.Header.Font.Brush.Solid = true;
            tChart2.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Header.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Header.Font.Shadow.Brush.Solid = true;
            tChart2.Header.Font.Shadow.Brush.Visible = true;
            tChart2.Header.Font.Size = 12;
            tChart2.Header.Font.SizeFloat = 12F;
            tChart2.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Header.ImageBevel.Brush.Color = Color.LightGray;
            tChart2.Header.ImageBevel.Brush.Solid = true;
            tChart2.Header.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Header.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            tChart2.Header.Shadow.Brush.Solid = true;
            tChart2.Header.Shadow.Brush.Visible = true;
            tChart2.Header.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Legend.Brush.Color = Color.White;
            tChart2.Legend.Brush.Solid = true;
            tChart2.Legend.Brush.Visible = true;
            tChart2.Legend.CheckBoxes = false;
            // 
            // 
            // 
            tChart2.Legend.Font.Bold = false;
            // 
            // 
            // 
            tChart2.Legend.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChart2.Legend.Font.Brush.Solid = true;
            tChart2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Legend.Font.Shadow.Brush.Solid = true;
            tChart2.Legend.Font.Shadow.Brush.Visible = true;
            tChart2.Legend.Font.Size = 9;
            tChart2.Legend.Font.SizeFloat = 9F;
            tChart2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Legend.ImageBevel.Brush.Color = Color.LightGray;
            tChart2.Legend.ImageBevel.Brush.Solid = true;
            tChart2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Legend.Shadow.Brush.Color = Color.FromArgb(0, 0, 0);
            tChart2.Legend.Shadow.Brush.Solid = true;
            tChart2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Legend.Symbol.Shadow.Brush.Solid = true;
            tChart2.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Legend.Title.Brush.Color = Color.White;
            tChart2.Legend.Title.Brush.Solid = true;
            tChart2.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            tChart2.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            tChart2.Legend.Title.Font.Brush.Color = Color.Black;
            tChart2.Legend.Title.Font.Brush.Solid = true;
            tChart2.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Legend.Title.Font.Shadow.Brush.Solid = true;
            tChart2.Legend.Title.Font.Shadow.Brush.Visible = true;
            tChart2.Legend.Title.Font.Size = 8;
            tChart2.Legend.Title.Font.SizeFloat = 8F;
            tChart2.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChart2.Legend.Title.ImageBevel.Brush.Solid = true;
            tChart2.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Legend.Title.Shadow.Brush.Solid = true;
            tChart2.Legend.Title.Shadow.Brush.Visible = true;
            tChart2.Legend.Visible = false;
            tChart2.Location = new Point(0, 0);
            tChart2.Name = "tChart2";
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Panel.Brush.Color = Color.FromArgb(255, 255, 255);
            tChart2.Panel.Brush.Solid = true;
            tChart2.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Panel.ImageBevel.Brush.Color = Color.LightGray;
            tChart2.Panel.ImageBevel.Brush.Solid = true;
            tChart2.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Panel.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Panel.Shadow.Brush.Solid = true;
            tChart2.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins2.Bottom = 100;
            margins2.Left = 100;
            margins2.Right = 100;
            margins2.Top = 100;
            tChart2.Printer.Margins = margins2;
            tChart2.Size = new Size(96, 100);
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.SubFooter.Brush.Color = Color.Silver;
            tChart2.SubFooter.Brush.Solid = true;
            tChart2.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            tChart2.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            tChart2.SubFooter.Font.Brush.Color = Color.Red;
            tChart2.SubFooter.Font.Brush.Solid = true;
            tChart2.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart2.SubFooter.Font.Shadow.Brush.Solid = true;
            tChart2.SubFooter.Font.Shadow.Brush.Visible = true;
            tChart2.SubFooter.Font.Size = 8;
            tChart2.SubFooter.Font.SizeFloat = 8F;
            tChart2.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
            tChart2.SubFooter.ImageBevel.Brush.Solid = true;
            tChart2.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.SubFooter.Shadow.Brush.Color = Color.DarkGray;
            tChart2.SubFooter.Shadow.Brush.Solid = true;
            tChart2.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.SubHeader.Brush.Color = Color.FromArgb(192, 192, 192);
            tChart2.SubHeader.Brush.Solid = true;
            tChart2.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            tChart2.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            tChart2.SubHeader.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart2.SubHeader.Font.Brush.Solid = true;
            tChart2.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart2.SubHeader.Font.Shadow.Brush.Solid = true;
            tChart2.SubHeader.Font.Shadow.Brush.Visible = true;
            tChart2.SubHeader.Font.Size = 12;
            tChart2.SubHeader.Font.SizeFloat = 12F;
            tChart2.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
            tChart2.SubHeader.ImageBevel.Brush.Solid = true;
            tChart2.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.SubHeader.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            tChart2.SubHeader.Shadow.Brush.Solid = true;
            tChart2.SubHeader.Shadow.Brush.Visible = true;
            tChart2.TabIndex = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Walls.Back.Brush.Color = Color.Silver;
            tChart2.Walls.Back.Brush.Solid = true;
            tChart2.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
            tChart2.Walls.Back.ImageBevel.Brush.Solid = true;
            tChart2.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Walls.Back.Shadow.Brush.Solid = true;
            tChart2.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Walls.Bottom.Brush.Color = Color.White;
            tChart2.Walls.Bottom.Brush.Solid = true;
            tChart2.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
            tChart2.Walls.Bottom.ImageBevel.Brush.Solid = true;
            tChart2.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Walls.Bottom.Shadow.Brush.Solid = true;
            tChart2.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Walls.Left.Brush.Color = Color.LightYellow;
            tChart2.Walls.Left.Brush.Solid = true;
            tChart2.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
            tChart2.Walls.Left.ImageBevel.Brush.Solid = true;
            tChart2.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Walls.Left.Shadow.Brush.Solid = true;
            tChart2.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Walls.Right.Brush.Color = Color.LightYellow;
            tChart2.Walls.Right.Brush.Solid = true;
            tChart2.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
            tChart2.Walls.Right.ImageBevel.Brush.Solid = true;
            tChart2.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
            tChart2.Walls.Right.Shadow.Brush.Solid = true;
            tChart2.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Zoom.Brush.Color = Color.FromArgb(127, 0, 0, 255);
            tChart2.Zoom.Brush.Solid = true;
            tChart2.Zoom.Brush.Visible = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(checkBoxAnimate);
            panel4.Controls.Add(groupBox1);
            panel4.Controls.Add(checkBox3);
            panel4.Controls.Add(checkBoxValue);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(trackBar1);
            panel4.Controls.Add(checkBox1);
            panel4.Controls.Add(checkBox2);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(199, 433);
            panel4.TabIndex = 13;
            // 
            // MatrixSeriesForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(1025, 619);
            Name = "MatrixSeriesForm";
            Load += MatrixSeriesForm_Load;
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((ISupportInitialize)timer1).EndInit();
            ((ISupportInitialize)trackBar1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);

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
            gridSeries.Legend.Visible = !checkBox3.Checked;
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

