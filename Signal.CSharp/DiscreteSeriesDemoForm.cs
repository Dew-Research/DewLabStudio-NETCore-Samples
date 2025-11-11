using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Dew.Signal.Tee;
using Dew.Signal.Units;
using Dew.Math;
using Dew.Math.Units;
using static Dew.Math.Tee.MtxVecTee;
using Steema.TeeChart.Styles;
using Dew.Math.Controls;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for DiscreteSeriesDemoForm.
	/// </summary>
	public class DiscreteSeriesDemoForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private SignalChart SignalChart1;
		private FloatEdit mtxFloatEdit1;
        private System.Windows.Forms.Label label1;
        private Button ChartButton;
        private Steema.TeeChart.Editor ChartEditor;
        private IContainer components;

		public DiscreteSeriesDemoForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			SignalDiscreteSeries series = new SignalDiscreteSeries(SignalChart1.Chart);
			series.UseYOrigin = true;
		    series.Pointer.Style = PointerStyles.Circle;
			SignalChart1.Series.Add(series);
			mtxFloatEdit1_TextChanged(null, EventArgs.Empty);
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxFloatEdit1 = new Dew.Math.Controls.FloatEdit();
            this.SignalChart1 = new Dew.Signal.Tee.SignalChart();
            this.ChartEditor = new Steema.TeeChart.Editor(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignalChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(696, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChartButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mtxFloatEdit1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 592);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 37);
            this.panel1.TabIndex = 1;
            // 
            // ChartButton
            // 
            this.ChartButton.Location = new System.Drawing.Point(12, 7);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(75, 23);
            this.ChartButton.TabIndex = 2;
            this.ChartButton.Text = "Chart";
            this.ChartButton.UseVisualStyleBackColor = true;
            this.ChartButton.Click += new System.EventHandler(this.ChartButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(202, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Step";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtxFloatEdit1
            // 
            this.mtxFloatEdit1.Increment = "0.100000001490116";
            this.mtxFloatEdit1.Location = new System.Drawing.Point(264, 10);
            this.mtxFloatEdit1.MaxValue = "1";
            this.mtxFloatEdit1.MinValue = "0.1";
            this.mtxFloatEdit1.Name = "mtxFloatEdit1";
            this.mtxFloatEdit1.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.mtxFloatEdit1.Size = new System.Drawing.Size(120, 20);
            this.mtxFloatEdit1.TabIndex = 0;
            this.mtxFloatEdit1.Value = "0.5";
            this.mtxFloatEdit1.TextChanged += new System.EventHandler(this.mtxFloatEdit1_TextChanged);
            // 
            // SignalChart1
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
            this.SignalChart1.Axes.Bottom.Grid.DrawEvery = 1;
             
            this.SignalChart1.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Axes.Bottom.Labels.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SignalChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Bottom.Labels.Font.Size = 9;
            this.SignalChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.Axes.Bottom.Title.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignalChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Bottom.Title.Font.Size = 11;
            this.SignalChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
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
            this.SignalChart1.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Axes.Depth.Labels.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SignalChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Depth.Labels.Font.Size = 9;
            this.SignalChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.Axes.Depth.Title.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignalChart1.Axes.Depth.Title.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Depth.Title.Font.Size = 11;
            this.SignalChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
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
            this.SignalChart1.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Axes.DepthTop.Labels.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SignalChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.DepthTop.Labels.Font.Size = 9;
            this.SignalChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.Axes.DepthTop.Title.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignalChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.DepthTop.Title.Font.Size = 11;
            this.SignalChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
             
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Axes.Left.Labels.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SignalChart1.Axes.Left.Labels.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Left.Labels.Font.Size = 9;
            this.SignalChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.Axes.Left.Title.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignalChart1.Axes.Left.Title.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Left.Title.Font.Size = 11;
            this.SignalChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.AxisPen.Visible = true;
            // 
            // 
            // 
             
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Axes.Right.Labels.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SignalChart1.Axes.Right.Labels.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Right.Labels.Font.Size = 9;
            this.SignalChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.Axes.Right.Title.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignalChart1.Axes.Right.Title.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Right.Title.Font.Size = 11;
            this.SignalChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
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
            this.SignalChart1.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Axes.Top.Labels.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SignalChart1.Axes.Top.Labels.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Top.Labels.Font.Size = 9;
            this.SignalChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.Axes.Top.Title.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignalChart1.Axes.Top.Title.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Top.Title.Font.Size = 11;
            this.SignalChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.SignalChart1.BackColor = System.Drawing.Color.LightGray;
            this.SignalChart1.Color = System.Drawing.Color.LightGray;
             
            this.SignalChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.Footer.Brush.Solid = true;
            this.SignalChart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.SignalChart1.Footer.Font.Brush.Solid = true;
            this.SignalChart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Footer.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Footer.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Footer.Font.Size = 8;
            this.SignalChart1.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Footer.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Footer.Shadow.Brush.Solid = true;
            this.SignalChart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SignalChart1.Header.Brush.Solid = true;
            this.SignalChart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Header.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SignalChart1.Header.Font.Brush.Solid = true;
            this.SignalChart1.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Header.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Header.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Header.Font.Size = 12;
            this.SignalChart1.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Header.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Header.ImageBevel.Brush.Visible = true;
            this.SignalChart1.Header.Lines = new string[] {
        "Time signal"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignalChart1.Header.Shadow.Brush.Solid = true;
            this.SignalChart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Legend.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Legend.Brush.Solid = true;
            this.SignalChart1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignalChart1.Legend.Font.Brush.Solid = true;
            this.SignalChart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Legend.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Legend.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Legend.Font.Size = 9;
            this.SignalChart1.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Legend.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SignalChart1.Legend.Shadow.Brush.Solid = true;
            this.SignalChart1.Legend.Shadow.Brush.Visible = true;
            this.SignalChart1.Legend.Shadow.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Legend.Symbol.Shadow.Brush.Solid = true;
            this.SignalChart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Legend.Title.Brush.Solid = true;
            this.SignalChart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.SignalChart1.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.SignalChart1.Legend.Title.Font.Brush.Solid = true;
            this.SignalChart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Legend.Title.Font.Size = 8;
            this.SignalChart1.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Legend.Title.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Legend.Title.Shadow.Brush.Solid = true;
            this.SignalChart1.Legend.Title.Shadow.Brush.Visible = true;
            this.SignalChart1.Legend.Visible = false;
            this.SignalChart1.Location = new System.Drawing.Point(0, 96);
            this.SignalChart1.Name = "SignalChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            this.SignalChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Panel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Panel.Brush.Solid = true;
            this.SignalChart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Panel.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Panel.Shadow.Brush.Solid = true;
            this.SignalChart1.Panel.Shadow.Brush.Visible = true;
            this.SignalChart1.Size = new System.Drawing.Size(696, 496);
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.SubFooter.Brush.Solid = true;
            this.SignalChart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.SignalChart1.SubFooter.Font.Brush.Solid = true;
            this.SignalChart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.SubFooter.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.SubFooter.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.SubFooter.Font.Size = 8;
            this.SignalChart1.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.SubFooter.ImageBevel.Brush.Solid = true;
            this.SignalChart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.SubFooter.Shadow.Brush.Solid = true;
            this.SignalChart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SignalChart1.SubHeader.Brush.Solid = true;
            this.SignalChart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SignalChart1.SubHeader.Font.Brush.Solid = true;
            this.SignalChart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.SubHeader.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.SubHeader.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.SubHeader.Font.Size = 12;
            this.SignalChart1.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.SubHeader.ImageBevel.Brush.Solid = true;
            this.SignalChart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignalChart1.SubHeader.Shadow.Brush.Solid = true;
            this.SignalChart1.SubHeader.Shadow.Brush.Visible = true;
            this.SignalChart1.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.Walls.Back.Brush.Solid = true;
            this.SignalChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Walls.Back.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Walls.Back.Shadow.Brush.Solid = true;
            this.SignalChart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Walls.Bottom.Brush.Solid = true;
            this.SignalChart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Walls.Bottom.Shadow.Brush.Solid = true;
            this.SignalChart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.SignalChart1.Walls.Left.Brush.Solid = true;
            this.SignalChart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Walls.Left.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Walls.Left.Shadow.Brush.Solid = true;
            this.SignalChart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.SignalChart1.Walls.Right.Brush.Solid = true;
            this.SignalChart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Walls.Right.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Walls.Right.Shadow.Brush.Solid = true;
            this.SignalChart1.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Zoom.Animated = true;
            // 
            // 
            // 
            this.SignalChart1.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.SignalChart1.Zoom.Brush.Solid = true;
            this.SignalChart1.Zoom.Brush.Visible = false;
            this.SignalChart1.Zoom.FullRepaint = true;
            this.SignalChart1.Zoom.Pen.Visible = true;
            // 
            // ChartEditor
            // 
            this.ChartEditor.Chart = this.SignalChart1;
            this.ChartEditor.HighLightTabs = false;
            this.ChartEditor.Location = new System.Drawing.Point(0, 0);
            this.ChartEditor.Name = "ChartEditor";
            this.ChartEditor.Options = null;
            this.ChartEditor.TabIndex = 0;
            // 
            // DiscreteSeriesDemoForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(696, 629);
            this.Controls.Add(this.SignalChart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "DiscreteSeriesDemoForm";
            this.Text = "DiscreteSeriesDemoForm";
            this.Load += new System.EventHandler(this.DiscreteSeriesDemoForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SignalChart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void mtxFloatEdit1_TextChanged(object sender, System.EventArgs e) {
			Vector h = new Vector(0);
			double step;
			
			step = mtxFloatEdit1.Position;
			SignalUtils.FractionalFirImpulse(30,h,new double[]{0.2,0.25},0,step,
				Dew.Signal.TFilterType.ftLowpass,1);

			SignalChart1.Series[0].Clear();
			DrawValues(h,SignalChart1.Series[0],0,step,false);
			//DrawValues(H,SignalChart1.Series[0],0,Step);
		}

        private void ChartButton_Click(object sender, EventArgs e)
        {
            ChartEditor.ShowModal();
        }

        protected void Add(String s)
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void DiscreteSeriesDemoForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("A new chart series for drawing discrete signals. The example "
            + "below shows an oversampled FIR filter.");
        }
	}
}
