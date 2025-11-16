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
	public class InterpolationForm : MtxVecDemo.BasicForm1
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.TrackBar trackBar2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelDataPoints;
		private System.Windows.Forms.Label labelFactor;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label labelTimeNeeded;
		private Steema.TeeChart.Styles.Points series1;
		private Steema.TeeChart.Styles.FastLine series2;
		private System.ComponentModel.IContainer components = null;

		public InterpolationForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			comboBox1.SelectedIndex = 1;
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDataPoints = new System.Windows.Forms.Label();
            this.labelFactor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTimeNeeded = new System.Windows.Forms.Label();
            this.series1 = new Steema.TeeChart.Styles.Points();
            this.series2 = new Steema.TeeChart.Styles.FastLine();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelTimeNeeded);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.labelDataPoints);
            this.panel2.Controls.Add(this.trackBar2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelFactor);
            this.panel2.Location = new System.Drawing.Point(0, 317);
            this.panel2.Size = new System.Drawing.Size(672, 120);
            this.panel2.Controls.SetChildIndex(this.labelFactor, 0);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.comboBox1, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.trackBar1, 0);
            this.panel2.Controls.SetChildIndex(this.checkBoxDownsample, 0);
            this.panel2.Controls.SetChildIndex(this.label3, 0);
            this.panel2.Controls.SetChildIndex(this.trackBar2, 0);
            this.panel2.Controls.SetChildIndex(this.labelDataPoints, 0);
            this.panel2.Controls.SetChildIndex(this.button1, 0);
            this.panel2.Controls.SetChildIndex(this.labelTimeNeeded, 0);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.ElevationFloat = 345;
            this.tChart1.Aspect.RotationFloat = 345;
            this.tChart1.Aspect.View3D = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Automatic = true;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Automatic = true;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Automatic = true;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Automatic = true;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Automatic = true;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Automatic = true;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Grid.ZPosition = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Shadow.Visible = false;
            this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Footer.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Footer.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Font.Shadow.Visible = false;
            this.tChart1.Header.Lines = new string[] {
        "TeeChart"};
            // 
            // 
            // 
            this.tChart1.Header.Shadow.Visible = false;
            this.tChart1.Header.Visible = false;
            // 
            // 
            // 
            this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Top;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Font.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.tChart1.Legend.Title.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Legend.Title.Pen.Visible = false;
            // 
            // 
            // 
            this.tChart1.Legend.Title.Shadow.Visible = false;
            this.tChart1.Location = new System.Drawing.Point(0, 100);
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Shadow.Visible = false;
            this.tChart1.Series.Add(this.series1);
            this.tChart1.Series.Add(this.series2);
            this.tChart1.Size = new System.Drawing.Size(672, 217);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubFooter.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.SubFooter.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubHeader.Font.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.SubHeader.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.AutoHide = false;
            // 
            // 
            // 
            this.tChart1.Walls.Back.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.AutoHide = false;
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Walls.Left.AutoHide = false;
            // 
            // 
            // 
            this.tChart1.Walls.Left.Shadow.Visible = false;
            // 
            // 
            // 
            this.tChart1.Walls.Right.AutoHide = false;
            // 
            // 
            // 
            this.tChart1.Walls.Right.Shadow.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interpolation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Items.AddRange(new object[] {
            "Linear",
            "Cubic"});
            this.comboBox1.Location = new System.Drawing.Point(88, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data points";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(88, 64);
            this.trackBar1.Maximum = 100000;
            this.trackBar1.Minimum = 60;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(128, 16);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickFrequency = 5000;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 60;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.LargeChange = 1;
            this.trackBar2.Location = new System.Drawing.Point(88, 88);
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(128, 16);
            this.trackBar2.TabIndex = 6;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar2.Value = 8;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Factor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDataPoints
            // 
            this.labelDataPoints.Location = new System.Drawing.Point(216, 64);
            this.labelDataPoints.Name = "labelDataPoints";
            this.labelDataPoints.Size = new System.Drawing.Size(80, 24);
            this.labelDataPoints.TabIndex = 7;
            this.labelDataPoints.Text = "0";
            this.labelDataPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFactor
            // 
            this.labelFactor.Location = new System.Drawing.Point(216, 88);
            this.labelFactor.Name = "labelFactor";
            this.labelFactor.Size = new System.Drawing.Size(80, 24);
            this.labelFactor.TabIndex = 7;
            this.labelFactor.Text = "0";
            this.labelFactor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(320, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "Recreate";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTimeNeeded
            // 
            this.labelTimeNeeded.Location = new System.Drawing.Point(304, 40);
            this.labelTimeNeeded.Name = "labelTimeNeeded";
            this.labelTimeNeeded.Size = new System.Drawing.Size(144, 16);
            this.labelTimeNeeded.TabIndex = 9;
            this.labelTimeNeeded.Text = "Time needed :";
            // 
            // series1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.series1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.series1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.series1.Marks.Callout.Distance = 0;
            this.series1.Marks.Callout.Draw3D = false;
            this.series1.Marks.Callout.Length = 0;
            this.series1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Marks.Font.Shadow.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Pointer.Brush.Color = System.Drawing.Color.Red;
            this.series1.Pointer.Dark3D = false;
            this.series1.Pointer.Draw3D = false;
            this.series1.Pointer.HorizSize = 2;
            this.series1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.DiagCross;
            this.series1.Pointer.VertSize = 2;
            this.series1.Pointer.Visible = true;
            this.series1.Title = "Original data";
            // 
            // 
            // 
            this.series1.XValues.DataMember = "X";
            this.series1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.series1.YValues.DataMember = "Y";
            // 
            // series2
            // 
            // 
            // 
            // 
            this.series2.LinePen.Color = System.Drawing.Color.Green;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.series2.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.series2.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.series2.Marks.Callout.Distance = 0;
            this.series2.Marks.Callout.Draw3D = false;
            this.series2.Marks.Callout.Length = 10;
            this.series2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Marks.Font.Shadow.Visible = false;
            this.series2.Title = "Fitted values";
            // 
            // 
            // 
            this.series2.XValues.DataMember = "X";
            this.series2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.series2.YValues.DataMember = "Y";
            // 
            // InterpolationForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(672, 437);
            this.Name = "InterpolationForm";
            this.Load += new System.EventHandler(this.InterpolationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private int dataPoints, factor;
		private TInterpolationType intType;

		private void trackBar1_ValueChanged(object sender, System.EventArgs e) {
			dataPoints = (sender as TrackBar).Value;
			labelDataPoints.Text = dataPoints.ToString();
		}

		private void InterpolationForm_Load(object sender, System.EventArgs e) {
			Add("Polynoms unit introduces a very powerful method for "
				+ "interpolation. You can perform linear or cubic interpolation "
				+ "(using cubic splines). Everyhting gets done by calling just "
				+ "one  procedure:");
			Add("");
            richTextBox1.SelectionFont = new Font("Courier New", richTextBox1.SelectionFont.Size);
			Add("Interpolate(FunValues,intX,intY,interpolationMethod);");
			Add("");
			Add("Try changing the number of data points, number of "
				+ "interpolated points and interpolation method. The "
				+ "\"DownSample\" checkbox will use the PixelDownSample "
				+ "method to reduce the number of points to be displayed "
				+ "(BIG speed-up if you are charting interpolated values).");
			Add("");
			richTextBox1.SelectionFont = 
				new Font(richTextBox1.SelectionFont.Name,richTextBox1.SelectionFont.Size,
				FontStyle.Underline);
			Add("Parameters in this demo :");
			Add("Interpolation:\tinterpolation method used (linear, cubic)");
			Add("DataPoints:\tnumber of data points");
			Add("Factor:\t\tnumber of interpolated points between two data points");
			Add("Time needed:\ttime in miliseconds, needed to construct and evaluate (but not draw) piece-wise polynomial");


			trackBar1_ValueChanged(trackBar1,null);
			trackBar2_ValueChanged(trackBar2,null);
		}

		private void trackBar2_ValueChanged(object sender, System.EventArgs e) {
			factor = (sender as TrackBar).Value;
			labelFactor.Text = factor.ToString();
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e) {
			switch (comboBox1.SelectedIndex) {
				case 0 : intType = TInterpolationType.IntLinear; break;
				case 1 : intType = TInterpolationType.IntCubic; break;
			}
		}

		private void button1_Click(object sender, System.EventArgs e) {
			Vector x = new Vector(0);
            Vector y = new Vector(0);
            Vector pX = new Vector(0);
            Vector pY = new Vector(0);
			this.Cursor = Cursors.WaitCursor;
			try {
				x.Size(dataPoints);
				y.Size(dataPoints);
				x.Ramp();
				y.Values[0] = 1000;
				Random rnd = new Random();
				for (int i=0;i<x.Length - 1;i++) {
					y.Values[i+1] = y.Values[i] + 250 - rnd.Next(500);
				}
				MtxVecTee.DrawValues(y,series1,0,1, DownSize);
				int timeCheck = Environment.TickCount;
				pX.Size(dataPoints * factor);
				pX.Ramp(0, 1.0 /(double) factor);
				Polynoms.Interpolate(y,pX,pY,intType,true);
				int timeElapsed = Environment.TickCount - timeCheck;
				labelTimeNeeded.Text = "Time needed : " + timeElapsed.ToString() + " ms";
                MtxVecTee.DrawValues(pY, series2, 0, 1.0 /(double)factor, DownSize);
			} finally {
				this.Cursor = Cursors.Default;
			}
		}
	}
}

