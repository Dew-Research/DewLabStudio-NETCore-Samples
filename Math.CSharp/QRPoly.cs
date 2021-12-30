using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Units;
using Dew.Math.Editors;
using Dew.Math.Tee;

namespace MtxVecDemo
{
	public class QRPolyForm : MtxVecDemo.BasicForm1
	{
		private Steema.TeeChart.Styles.Points series1;
		private Steema.TeeChart.Styles.Line series2;
		private Steema.TeeChart.Styles.Line series3;
		private Steema.TeeChart.Styles.Line series4;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelTimeNeeded;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
		private System.ComponentModel.IContainer components = null;

		public QRPolyForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			

            r = new Matrix(0, 0);
            x = new Vector(0);
            y = new Vector(0);
            coeff = new Vector(0);
            intX = new Vector(0);
            intY = new Vector(0);
            delta = new Vector(0);

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
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRPolyForm));
            this.series1 = new Steema.TeeChart.Styles.Points();
            this.series2 = new Steema.TeeChart.Styles.Line();
            this.series3 = new Steema.TeeChart.Styles.Line();
            this.series4 = new Steema.TeeChart.Styles.Line();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTimeNeeded = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(747, 151);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericUpDown2);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.labelTimeNeeded);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 537);
            this.panel2.Size = new System.Drawing.Size(747, 107);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.checkBoxDownsample, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.labelTimeNeeded, 0);
            this.panel2.Controls.SetChildIndex(this.button1, 0);
            this.panel2.Controls.SetChildIndex(this.button2, 0);
            this.panel2.Controls.SetChildIndex(this.button3, 0);
            this.panel2.Controls.SetChildIndex(this.numericUpDown1, 0);
            this.panel2.Controls.SetChildIndex(this.numericUpDown2, 0);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(747, 151);
            // 
            // checkBoxDownsample
            // 
            this.checkBoxDownsample.Location = new System.Drawing.Point(23, 12);
            this.checkBoxDownsample.Size = new System.Drawing.Size(150, 25);
            this.checkBoxDownsample.CheckedChanged += new System.EventHandler(this.checkBoxDownsample_CheckedChanged);
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
            this.tChart1.Axes.Bottom.AxisPen.Width = 2;
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
            this.tChart1.Axes.Depth.AxisPen.Width = 2;
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
            this.tChart1.Axes.DepthTop.AxisPen.Width = 2;
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
            this.tChart1.Axes.Left.AxisPen.Width = 2;
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
            this.tChart1.Axes.Right.AxisPen.Width = 2;
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
            this.tChart1.Axes.Top.AxisPen.Width = 2;
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
            this.tChart1.CausesValidation = false;
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChart1.Header.Shadow.Brush.Solid = true;
            this.tChart1.Header.Shadow.Brush.Visible = true;
            this.tChart1.Header.Visible = false;
            // 
            // 
            // 
            this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Top;
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
            this.tChart1.Legend.LegendStyle = Steema.TeeChart.LegendStyles.Series;
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
            this.tChart1.Legend.TextStyle = Steema.TeeChart.LegendTextStyles.Plain;
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
            this.tChart1.Location = new System.Drawing.Point(0, 151);
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
            this.tChart1.Series.Add(this.series1);
            this.tChart1.Series.Add(this.series2);
            this.tChart1.Series.Add(this.series3);
            this.tChart1.Series.Add(this.series4);
            this.tChart1.Size = new System.Drawing.Size(747, 386);
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
            this.tChart1.Zoom.FullRepaint = true;
            // 
            // series1
            // 
            // 
            // 
            // 
            this.series1.Brush.Color = System.Drawing.Color.Empty;
            this.series1.Brush.Solid = true;
            this.series1.Brush.Visible = true;
            this.series1.Color = System.Drawing.Color.Red;
            this.series1.ColorEach = false;
            cursor1.CursorType = Steema.TeeChart.Drawing.CursorType.Default;
            this.series1.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Legend.Brush.Color = System.Drawing.Color.White;
            this.series1.Legend.Brush.Solid = true;
            this.series1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.series1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.series1.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.series1.Legend.Font.Brush.Solid = true;
            this.series1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.series1.Legend.Font.Shadow.Brush.Solid = true;
            this.series1.Legend.Font.Shadow.Brush.Visible = true;
            this.series1.Legend.Font.Size = 8;
            this.series1.Legend.Font.SizeFloat = 8F;
            this.series1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.series1.Legend.ImageBevel.Brush.Solid = true;
            this.series1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.series1.Legend.Shadow.Brush.Solid = true;
            this.series1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.series1.Marks.Brush.Solid = true;
            this.series1.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.series1.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.series1.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.series1.Marks.Font.Brush.Solid = true;
            this.series1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.series1.Marks.Font.Shadow.Brush.Solid = true;
            this.series1.Marks.Font.Shadow.Brush.Visible = true;
            this.series1.Marks.Font.Size = 8;
            this.series1.Marks.Font.SizeFloat = 8F;
            this.series1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.series1.Marks.ImageBevel.Brush.Solid = true;
            this.series1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.series1.Marks.Shadow.Brush.Solid = true;
            this.series1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.series1.Marks.Symbol.Brush.Solid = true;
            this.series1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.series1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.series1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.series1.Marks.Symbol.Shadow.Brush.Solid = true;
            this.series1.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.series1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
            this.series1.Marks.TailParams.Margin = 0F;
            this.series1.Marks.TailParams.PointerHeight = 8D;
            this.series1.Marks.TailParams.PointerWidth = 8D;
            this.series1.OriginalCursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Pointer.Brush.Color = System.Drawing.Color.Red;
            this.series1.Pointer.Brush.Solid = true;
            this.series1.Pointer.Brush.Visible = true;
            this.series1.Pointer.Dark3D = false;
            this.series1.Pointer.Draw3D = false;
            this.series1.Pointer.HorizSize = 2;
            // 
            // 
            // 
            this.series1.Pointer.Pen.Visible = false;
            this.series1.Pointer.SizeDouble = 0D;
            this.series1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.series1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.DownTriangle;
            this.series1.Pointer.VertSize = 2;
            this.series1.RandomData = true;
            this.series1.Title = "Original data";
            this.series1.Type = "Steema.TeeChart.Styles.Points";
            this.series1.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.series1.XValues.DataMember = "X";
            this.series1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.series1.XValues.Series = this.series1;
            // 
            // 
            // 
            this.series1.YValues.DataMember = "Y";
            this.series1.YValues.Series = this.series1;
            // 
            // series2
            // 
            // 
            // 
            // 
            this.series2.AreaBrush.Color = System.Drawing.Color.White;
            this.series2.AreaBrush.Solid = true;
            this.series2.AreaBrush.Visible = false;
            // 
            // 
            // 
            this.series2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.series2.Brush.Solid = true;
            this.series2.Brush.Visible = true;
            this.series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.series2.ColorEach = false;
            this.series2.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Legend.Brush.Color = System.Drawing.Color.White;
            this.series2.Legend.Brush.Solid = true;
            this.series2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.series2.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.series2.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.series2.Legend.Font.Brush.Solid = true;
            this.series2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.series2.Legend.Font.Shadow.Brush.Solid = true;
            this.series2.Legend.Font.Shadow.Brush.Visible = true;
            this.series2.Legend.Font.Size = 8;
            this.series2.Legend.Font.SizeFloat = 8F;
            this.series2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.series2.Legend.ImageBevel.Brush.Solid = true;
            this.series2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.series2.Legend.Shadow.Brush.Solid = true;
            this.series2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.series2.Marks.Brush.Solid = true;
            this.series2.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.series2.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.series2.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.series2.Marks.Font.Brush.Solid = true;
            this.series2.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.series2.Marks.Font.Shadow.Brush.Solid = true;
            this.series2.Marks.Font.Shadow.Brush.Visible = true;
            this.series2.Marks.Font.Size = 8;
            this.series2.Marks.Font.SizeFloat = 8F;
            this.series2.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.series2.Marks.ImageBevel.Brush.Solid = true;
            this.series2.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.series2.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.series2.Marks.Shadow.Brush.Solid = true;
            this.series2.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.series2.Marks.Symbol.Brush.Solid = true;
            this.series2.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.series2.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.series2.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.series2.Marks.Symbol.Shadow.Brush.Solid = true;
            this.series2.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.series2.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
            this.series2.Marks.TailParams.Margin = 0F;
            this.series2.Marks.TailParams.PointerHeight = 8D;
            this.series2.Marks.TailParams.PointerWidth = 8D;
            this.series2.OriginalCursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Pointer.Brush.Color = System.Drawing.Color.RoyalBlue;
            this.series2.Pointer.Brush.Solid = true;
            this.series2.Pointer.Brush.Visible = true;
            this.series2.Pointer.SizeDouble = 0D;
            this.series2.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.series2.RandomData = true;
            this.series2.Title = "Fitted polynomial";
            this.series2.Type = "Steema.TeeChart.Styles.Line";
            this.series2.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.series2.XValues.DataMember = "X";
            this.series2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.series2.XValues.Series = this.series2;
            // 
            // 
            // 
            this.series2.YValues.DataMember = "Y";
            this.series2.YValues.Series = this.series2;
            // 
            // series3
            // 
            // 
            // 
            // 
            this.series3.AreaBrush.Color = System.Drawing.Color.White;
            this.series3.AreaBrush.Solid = true;
            this.series3.AreaBrush.Visible = false;
            // 
            // 
            // 
            this.series3.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(104)))));
            this.series3.Brush.Solid = true;
            this.series3.Brush.Visible = true;
            this.series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(104)))));
            this.series3.ColorEach = false;
            this.series3.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series3.Legend.Brush.Color = System.Drawing.Color.White;
            this.series3.Legend.Brush.Solid = true;
            this.series3.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.series3.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.series3.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.series3.Legend.Font.Brush.Solid = true;
            this.series3.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series3.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.series3.Legend.Font.Shadow.Brush.Solid = true;
            this.series3.Legend.Font.Shadow.Brush.Visible = true;
            this.series3.Legend.Font.Size = 8;
            this.series3.Legend.Font.SizeFloat = 8F;
            this.series3.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series3.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.series3.Legend.ImageBevel.Brush.Solid = true;
            this.series3.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series3.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.series3.Legend.Shadow.Brush.Solid = true;
            this.series3.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series3.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.series3.Marks.Brush.Solid = true;
            this.series3.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.series3.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.series3.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.series3.Marks.Font.Brush.Solid = true;
            this.series3.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series3.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.series3.Marks.Font.Shadow.Brush.Solid = true;
            this.series3.Marks.Font.Shadow.Brush.Visible = true;
            this.series3.Marks.Font.Size = 8;
            this.series3.Marks.Font.SizeFloat = 8F;
            this.series3.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series3.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.series3.Marks.ImageBevel.Brush.Solid = true;
            this.series3.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.series3.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.series3.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.series3.Marks.Shadow.Brush.Solid = true;
            this.series3.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series3.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.series3.Marks.Symbol.Brush.Solid = true;
            this.series3.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series3.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.series3.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.series3.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series3.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.series3.Marks.Symbol.Shadow.Brush.Solid = true;
            this.series3.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.series3.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos2")));
            this.series3.Marks.TailParams.Margin = 0F;
            this.series3.Marks.TailParams.PointerHeight = 8D;
            this.series3.Marks.TailParams.PointerWidth = 8D;
            this.series3.OriginalCursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series3.Pointer.Brush.Color = System.Drawing.Color.Black;
            this.series3.Pointer.Brush.Solid = true;
            this.series3.Pointer.Brush.Visible = true;
            this.series3.Pointer.SizeDouble = 0D;
            this.series3.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.series3.RandomData = true;
            this.series3.Title = "YCalc + Delta";
            this.series3.Type = "Steema.TeeChart.Styles.Line";
            this.series3.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.series3.XValues.DataMember = "X";
            this.series3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.series3.XValues.Series = this.series3;
            // 
            // 
            // 
            this.series3.YValues.DataMember = "Y";
            this.series3.YValues.Series = this.series3;
            // 
            // series4
            // 
            // 
            // 
            // 
            this.series4.AreaBrush.Color = System.Drawing.Color.White;
            this.series4.AreaBrush.Solid = true;
            this.series4.AreaBrush.Visible = false;
            // 
            // 
            // 
            this.series4.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(71)))));
            this.series4.Brush.Solid = true;
            this.series4.Brush.Visible = true;
            this.series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(71)))));
            this.series4.ColorEach = false;
            this.series4.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series4.Legend.Brush.Color = System.Drawing.Color.White;
            this.series4.Legend.Brush.Solid = true;
            this.series4.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.series4.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.series4.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.series4.Legend.Font.Brush.Solid = true;
            this.series4.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series4.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.series4.Legend.Font.Shadow.Brush.Solid = true;
            this.series4.Legend.Font.Shadow.Brush.Visible = true;
            this.series4.Legend.Font.Size = 8;
            this.series4.Legend.Font.SizeFloat = 8F;
            this.series4.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series4.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.series4.Legend.ImageBevel.Brush.Solid = true;
            this.series4.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series4.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.series4.Legend.Shadow.Brush.Solid = true;
            this.series4.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series4.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.series4.Marks.Brush.Solid = true;
            this.series4.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.series4.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.series4.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.series4.Marks.Font.Brush.Solid = true;
            this.series4.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series4.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.series4.Marks.Font.Shadow.Brush.Solid = true;
            this.series4.Marks.Font.Shadow.Brush.Visible = true;
            this.series4.Marks.Font.Size = 8;
            this.series4.Marks.Font.SizeFloat = 8F;
            this.series4.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series4.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.series4.Marks.ImageBevel.Brush.Solid = true;
            this.series4.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.series4.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(114)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.series4.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.series4.Marks.Shadow.Brush.Solid = true;
            this.series4.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series4.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.series4.Marks.Symbol.Brush.Solid = true;
            this.series4.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series4.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.series4.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.series4.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series4.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.series4.Marks.Symbol.Shadow.Brush.Solid = true;
            this.series4.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.series4.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos3")));
            this.series4.Marks.TailParams.Margin = 0F;
            this.series4.Marks.TailParams.PointerHeight = 8D;
            this.series4.Marks.TailParams.PointerWidth = 8D;
            this.series4.OriginalCursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series4.Pointer.Brush.Color = System.Drawing.Color.Black;
            this.series4.Pointer.Brush.Solid = true;
            this.series4.Pointer.Brush.Visible = true;
            this.series4.Pointer.SizeDouble = 0D;
            this.series4.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.series4.RandomData = true;
            this.series4.Title = "YCalc - Delta";
            this.series4.Type = "Steema.TeeChart.Styles.Line";
            this.series4.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.series4.XValues.DataMember = "X";
            this.series4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.series4.XValues.Series = this.series4;
            // 
            // 
            // 
            this.series4.YValues.DataMember = "Y";
            this.series4.YValues.Series = this.series4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Polynomial order";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(55, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Factor";
            // 
            // labelTimeNeeded
            // 
            this.labelTimeNeeded.Location = new System.Drawing.Point(192, 10);
            this.labelTimeNeeded.Name = "labelTimeNeeded";
            this.labelTimeNeeded.Size = new System.Drawing.Size(240, 20);
            this.labelTimeNeeded.TabIndex = 5;
            this.labelTimeNeeded.Text = "Time needed :";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(230, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Fit";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(317, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "View coefficients";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(451, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 29);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delta";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(126, 37);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 23);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(126, 69);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(62, 23);
            this.numericUpDown2.TabIndex = 11;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // QRPolyForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(747, 644);
            this.Name = "QRPolyForm";
            this.Load += new System.EventHandler(this.QRPoly_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private int polyOrder =6;
        private int factor = 5;
		private Vector  x,y,coeff, delta;
		private Matrix r;
		private Vector intX,intY;
		private double L2R;
		private int degF;


		private void QRPoly_Load(object sender, System.EventArgs e) {
			Add("Fitting a polynomial of high degree is a peace of "
				+ "cake. MtxVec offers you the ability to create "
				+ "Vandermonde matrix and then use it to find the desired "
				+ "polynomial coefficients via the LQR decomposition. ");

			x.Size(100);
			y.Size(x);
			Random rnd = new Random();
			double tmp = rnd.Next(100);
			x.Ramp();
			for (int i=0;i<y.Length;i++) {
				tmp += rnd.Next(100) - 50;
				y.Values[i] = tmp;
			}
            MtxVecTee.DrawValues(y, series1, 0, 1, false);
		}

		private void button1_Click(object sender, System.EventArgs e) {
			int timeCheck = Environment.TickCount;
			this.Cursor = Cursors.WaitCursor;
			try {
				Polynoms.PolyFit(x,y,polyOrder,coeff,r,out degF,out L2R, null);
				intX.Size(x.Length * factor);
                intX.Ramp(0, 1.0 / (double)factor);
				Polynoms.PolyEval(intX, coeff, r, degF, L2R, intY, delta);
				int timeElapsed = Environment.TickCount - timeCheck;
				labelTimeNeeded.Text = "Time needed : " + timeElapsed.ToString() + " ms";
                MtxVecTee.DrawValues(intY, series2, 0, 1.0 / (double)factor, DownSize);
				intY.Sub(delta);
                MtxVecTee.DrawValues(intY, series4, 0, 1.0 / (double)factor, DownSize);
				intY.AddScaled(delta, 2);
                MtxVecTee.DrawValues(intY, series3, 0, 1.0 / (double)factor, DownSize);
				
                button2.Enabled = true;
				button3.Enabled = true;
			} finally {
				this.Cursor = Cursors.Default;
			}
		}

		private void checkBoxDownsample_CheckedChanged(object sender, System.EventArgs e) {
			button2.Enabled = button3.Enabled = false;
		}

		private void button2_Click(object sender, System.EventArgs e) {
			MtxVecEdit.ViewValues(coeff, "Coefficients",true,false,false);
		}

		private void button3_Click(object sender, System.EventArgs e) {
			MtxVecEdit.ViewValues(delta, "Delta",true,false,false);
		}

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            polyOrder = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            factor = (int)numericUpDown2.Value;
        }
	}
}

