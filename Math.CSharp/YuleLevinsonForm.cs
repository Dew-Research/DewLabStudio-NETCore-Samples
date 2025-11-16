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
	public class YuleLevinsonForm : MtxVecDemo.BasicForm1
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1x;
		private System.Windows.Forms.RadioButton radioButton2x;
		private System.Windows.Forms.RadioButton radioButton4x;
		private System.Windows.Forms.RadioButton radioButton8x;
		private System.Windows.Forms.RadioButton radioButton16x;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.TrackBar trackBar2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelCorrLength;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelLPCCoef;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label labelTimeLYW;
		private Steema.TeeChart.Styles.FastLine series1;
        private Steema.TeeChart.Styles.FastLine series2;
		private System.Windows.Forms.Label labelTimeFFT;
		private System.ComponentModel.IContainer components = null;

		public YuleLevinsonForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			x = new Vector(0);
			y = new Vector(0);
			spec = new Vector(0);
			corr = new Vector(0);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YuleLevinsonForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton16x = new System.Windows.Forms.RadioButton();
            this.radioButton8x = new System.Windows.Forms.RadioButton();
            this.radioButton4x = new System.Windows.Forms.RadioButton();
            this.radioButton2x = new System.Windows.Forms.RadioButton();
            this.radioButton1x = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCorrLength = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLPCCoef = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTimeLYW = new System.Windows.Forms.Label();
            this.labelTimeFFT = new System.Windows.Forms.Label();
            this.series1 = new Steema.TeeChart.Styles.FastLine();
            this.series2 = new Steema.TeeChart.Styles.FastLine();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(964, 100);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelTimeFFT);
            this.panel2.Controls.Add(this.labelTimeLYW);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 533);
            this.panel2.Size = new System.Drawing.Size(964, 48);
            this.panel2.Controls.SetChildIndex(this.button1, 0);
            this.panel2.Controls.SetChildIndex(this.labelTimeLYW, 0);
            this.panel2.Controls.SetChildIndex(this.labelTimeFFT, 0);
            this.panel2.Controls.SetChildIndex(this.checkBoxDownsample, 0);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(964, 100);
            // 
            // checkBoxDownsample
            // 
            this.checkBoxDownsample.Location = new System.Drawing.Point(16, 16);
            // 
            // tChart1
            // 
            this.tChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tChart1.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Bottom.Labels.Font.Size = 9;
            this.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Bottom.Title.Font.Size = 11;
            this.tChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Depth.Labels.Font.Size = 9;
            this.tChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Depth.Title.Font.Size = 11;
            this.tChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.DepthTop.Labels.Font.Size = 9;
            this.tChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.DepthTop.Title.Font.Size = 11;
            this.tChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Left.Labels.Font.Size = 9;
            this.tChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Left.Title.Font.Size = 11;
            this.tChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Right.Labels.Font.Size = 9;
            this.tChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Right.Title.Font.Size = 11;
            this.tChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Top.Labels.Font.Size = 9;
            this.tChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Top.Title.Font.Size = 11;
            this.tChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Footer.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Footer.Font.Size = 8;
            this.tChart1.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Header.Font.Size = 12;
            this.tChart1.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChart1.Header.Visible = false;
            // 
            // 
            // 
            this.tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Top;
            // 
            // 
            // 
            this.tChart1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Legend.Brush.Color = System.Drawing.Color.White;
            this.tChart1.Legend.ClipText = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Legend.Font.Size = 9;
            this.tChart1.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Legend.Title.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.tChart1.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Legend.Title.Font.Size = 8;
            this.tChart1.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Location = new System.Drawing.Point(192, 104);
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            this.tChart1.Printer.Margins = margins1;
            this.tChart1.Series.Add(this.series1);
            this.tChart1.Series.Add(this.series2);
            this.tChart1.Size = new System.Drawing.Size(764, 424);
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.SubFooter.Font.Size = 8;
            this.tChart1.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.SubHeader.Font.Size = 12;
            this.tChart1.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.tChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Zoom.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.tChart1.Zoom.Brush.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton16x);
            this.groupBox1.Controls.Add(this.radioButton8x);
            this.groupBox1.Controls.Add(this.radioButton4x);
            this.groupBox1.Controls.Add(this.radioButton2x);
            this.groupBox1.Controls.Add(this.radioButton1x);
            this.groupBox1.Location = new System.Drawing.Point(8, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 96);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zero padding";
            // 
            // radioButton16x
            // 
            this.radioButton16x.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton16x.Location = new System.Drawing.Point(88, 40);
            this.radioButton16x.Name = "radioButton16x";
            this.radioButton16x.Size = new System.Drawing.Size(56, 24);
            this.radioButton16x.TabIndex = 4;
            this.radioButton16x.Text = "16x";
            this.radioButton16x.Click += new System.EventHandler(this.radioButton8x_Click);
            // 
            // radioButton8x
            // 
            this.radioButton8x.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton8x.Location = new System.Drawing.Point(88, 16);
            this.radioButton8x.Name = "radioButton8x";
            this.radioButton8x.Size = new System.Drawing.Size(56, 24);
            this.radioButton8x.TabIndex = 3;
            this.radioButton8x.Text = "8x";
            this.radioButton8x.Click += new System.EventHandler(this.radioButton8x_Click);
            // 
            // radioButton4x
            // 
            this.radioButton4x.Checked = true;
            this.radioButton4x.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton4x.Location = new System.Drawing.Point(8, 64);
            this.radioButton4x.Name = "radioButton4x";
            this.radioButton4x.Size = new System.Drawing.Size(56, 24);
            this.radioButton4x.TabIndex = 2;
            this.radioButton4x.TabStop = true;
            this.radioButton4x.Text = "4x";
            this.radioButton4x.Click += new System.EventHandler(this.radioButton8x_Click);
            // 
            // radioButton2x
            // 
            this.radioButton2x.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton2x.Location = new System.Drawing.Point(8, 40);
            this.radioButton2x.Name = "radioButton2x";
            this.radioButton2x.Size = new System.Drawing.Size(56, 24);
            this.radioButton2x.TabIndex = 1;
            this.radioButton2x.Text = "2x";
            this.radioButton2x.Click += new System.EventHandler(this.radioButton8x_Click);
            // 
            // radioButton1x
            // 
            this.radioButton1x.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1x.Location = new System.Drawing.Point(8, 16);
            this.radioButton1x.Name = "radioButton1x";
            this.radioButton1x.Size = new System.Drawing.Size(56, 24);
            this.radioButton1x.TabIndex = 0;
            this.radioButton1x.Text = "1x";
            this.radioButton1x.Click += new System.EventHandler(this.radioButton8x_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(8, 224);
            this.trackBar1.Maximum = 8000;
            this.trackBar1.Minimum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(152, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickFrequency = 500;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 2000;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(8, 304);
            this.trackBar2.Maximum = 8000;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(152, 45);
            this.trackBar2.TabIndex = 5;
            this.trackBar2.TickFrequency = 500;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar2.Value = 2000;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "CorrLength :";
            // 
            // labelCorrLength
            // 
            this.labelCorrLength.Location = new System.Drawing.Point(112, 208);
            this.labelCorrLength.Name = "labelCorrLength";
            this.labelCorrLength.Size = new System.Drawing.Size(56, 16);
            this.labelCorrLength.TabIndex = 7;
            this.labelCorrLength.Text = "labelCorrLength";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "LPCCoef :";
            // 
            // labelLPCCoef
            // 
            this.labelLPCCoef.Location = new System.Drawing.Point(112, 288);
            this.labelLPCCoef.Name = "labelLPCCoef";
            this.labelLPCCoef.Size = new System.Drawing.Size(56, 16);
            this.labelLPCCoef.TabIndex = 9;
            this.labelLPCCoef.Text = "labelLPCCoef";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(136, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate spectrum";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTimeLYW
            // 
            this.labelTimeLYW.AutoSize = true;
            this.labelTimeLYW.Location = new System.Drawing.Point(272, 8);
            this.labelTimeLYW.Name = "labelTimeLYW";
            this.labelTimeLYW.Size = new System.Drawing.Size(160, 13);
            this.labelTimeLYW.TabIndex = 2;
            this.labelTimeLYW.Text = "Time needed for Levinson YW : ";
            // 
            // labelTimeFFT
            // 
            this.labelTimeFFT.AutoSize = true;
            this.labelTimeFFT.Location = new System.Drawing.Point(272, 24);
            this.labelTimeFFT.Name = "labelTimeFFT";
            this.labelTimeFFT.Size = new System.Drawing.Size(112, 13);
            this.labelTimeFFT.TabIndex = 3;
            this.labelTimeFFT.Text = "Time needed to FFT : ";
            // 
            // series1
            // 
            this.series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.series1.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.series1.Legend.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.series1.Legend.Font.Size = 8;
            this.series1.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.series1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.series1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.series1.Marks.Font.Size = 8;
            this.series1.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.series1.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series1.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.series1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
            this.series1.OriginalCursor = null;
            this.series1.Title = "Yule Walker AR";
            this.series1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.series1.UseExtendedNumRange = false;
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
            this.series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(104)))));
            this.series2.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.series2.Legend.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.series2.Legend.Font.Size = 8;
            this.series2.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.series2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(104)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.series2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.series2.Marks.Font.Size = 8;
            this.series2.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.series2.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.series2.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.series2.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
            this.series2.OriginalCursor = null;
            this.series2.Title = "FFT";
            this.series2.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.series2.UseExtendedNumRange = false;
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
            // YuleLevinsonForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(964, 581);
            this.Controls.Add(this.labelLPCCoef);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCorrLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox1);
            this.Name = "YuleLevinsonForm";
            this.Load += new System.EventHandler(this.YuleLevinsonForm_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.trackBar1, 0);
            this.Controls.SetChildIndex(this.trackBar2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.labelCorrLength, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.labelLPCCoef, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.tChart1, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
	
		private int zeroPadding;
		private int corrLength, LPCCoef;
		private Vector x,y,spec,corr;

		private void radioButton8x_Click(object sender, System.EventArgs e) {
			if (radioButton1x.Checked) zeroPadding = 1;
			else if (radioButton2x.Checked) zeroPadding = 2;
			else if (radioButton4x.Checked) zeroPadding = 4;
			else if (radioButton8x.Checked) zeroPadding = 8;
			else if (radioButton16x.Checked) zeroPadding = 16;
		}

		private void YuleLevinsonForm_Load(object sender, System.EventArgs e) {
			Add("YuleWalker autoregressive spectra uses Levinson "
				+ "Durbin recursion to solve a toeplitz systems of "
				+ "linear equations taking only O(n2) operations "
				+ "instead of O(n3) as required by LUSolve. The chart "
				+ "compares FFT and YuleWalker AR. The corrLen defines "
				+ "the number of samples on which the Autocorrelation "
				+ "is performed and LPCCoef defines the number of "
				+ "computed autocorrelation coefficients. The method "
				+ "uses biased autocorrelation. FFT uses only LPCoef "
				+ "parameter to determine the number of sample to "
				+ "include. It then rounds LPCCoef to the nearest "
				+ "power of two. FFT uses no windowing.");
			Add("Zoom in on a chart (left-click and drag mouse "
				+ "over the chart) to see differences. Please note "
				+ "that it takes less then 10ms to compute a 32000 "
				+ "point FFT on P366.");

			radioButton8x_Click(null,null);
			trackBar1_ValueChanged(trackBar1,null);
		}

		private void trackBar1_ValueChanged(object sender, System.EventArgs e) {
			corrLength = (sender as TrackBar).Value;
			labelCorrLength.Text = corrLength.ToString();
			trackBar2.Maximum = corrLength;
			trackBar2.TickFrequency = corrLength / 20;
			trackBar2.Value = corrLength / 2;
			trackBar2_ValueChanged(trackBar2, null);
		}

		private void trackBar2_ValueChanged(object sender, System.EventArgs e) {
			LPCCoef = (sender as TrackBar).Value;
			labelLPCCoef.Text = LPCCoef.ToString();
		}

		private void button1_Click(object sender, System.EventArgs e) {
			this.Cursor = Cursors.WaitCursor;
			try {
				series1.Clear();
				series2.Clear();
                Math387.StartTimer();				
				y.LoadFromFile(Utils.SourcePath()+@".\Data\FFTData.vec");
				y.Resize(corrLength, true);
				corr.AutoCorrBiased(y,LPCCoef);
				Toeplitz.Levinson(corr, y);
				y.Resize(Math387.LargestExp2(y.Length*zeroPadding),true);
				x.FFT(y, false); // ???
				spec.Mag(x);
				spec.Inv(Math387.EPS);
				spec.Log10();
				double timeElapsed = Math387.StopTimer()*1000;
				labelTimeLYW.Text = "Time needed for Levinson YW : "+ timeElapsed.ToString("0.0")+" ms";
				if (DownSize) {
                    Vector downY = new Vector(0);
					downY.PixelDownSample(tChart1.Width, spec,null,null,TEquidistantSample.eqsXEquidistant); 
					double step = ((double)spec.Length / (double)downY.Length);
                    MtxVecTee.DrawValues(downY, series1, 0, step, false);
				} else {
                    MtxVecTee.DrawValues(spec, series1, 0, 1, false);
				}

                Math387.StartTimer();
                y.LoadFromFile(Utils.SourcePath() + @".\Data\FFTData.vec");
                y.Resize(LPCCoef, false);
				y.Resize(Math387.LargestExp2(LPCCoef)*zeroPadding, true);
				x.FFT(y,false); 
				spec.Mag(x);
				spec.ThreshBottom(0.00001); // -100dB
				spec.Log10();

                timeElapsed = Math387.StopTimer()*1000;
				labelTimeFFT.Text = "Time needed for FFT : "+ timeElapsed.ToString("0.0")+" ms";

				if (DownSize) {
                    Vector downY = new Vector(0);
    				downY.PixelDownSample(tChart1.Width, spec,null,null,TEquidistantSample.eqsXEquidistant); 
					double step = ((double)spec.Length / (double)downY.Length);
                    MtxVecTee.DrawValues(downY, series2, 0, step, false);
				} else {
                    MtxVecTee.DrawValues(spec, series2, 0, 1, false); // Default parameter values doesn"t work...
				}
				tChart1.Refresh();
			} finally {
				this.Cursor = Cursors.Default;
			}
		}
	
	}
}

