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
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(YuleLevinsonForm));
            groupBox1 = new GroupBox();
            radioButton16x = new RadioButton();
            radioButton8x = new RadioButton();
            radioButton4x = new RadioButton();
            radioButton2x = new RadioButton();
            radioButton1x = new RadioButton();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            label1 = new Label();
            labelCorrLength = new Label();
            label3 = new Label();
            labelLPCCoef = new Label();
            button1 = new Button();
            labelTimeLYW = new Label();
            labelTimeFFT = new Label();
            series1 = new Steema.TeeChart.Styles.FastLine();
            series2 = new Steema.TeeChart.Styles.FastLine();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)trackBar1).BeginInit();
            ((ISupportInitialize)trackBar2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Size = new Size(952, 123);
            // 
            // panel2
            // 
            panel2.Controls.Add(labelTimeFFT);
            panel2.Controls.Add(labelTimeLYW);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 536);
            panel2.Size = new Size(952, 59);
            panel2.Controls.SetChildIndex(button1, 0);
            panel2.Controls.SetChildIndex(labelTimeLYW, 0);
            panel2.Controls.SetChildIndex(labelTimeFFT, 0);
            panel2.Controls.SetChildIndex(checkBoxDownsample, 0);
            // 
            // richTextBox1
            // 
            richTextBox1.Size = new Size(952, 123);
            // 
            // checkBoxDownsample
            // 
            checkBoxDownsample.Location = new Point(19, 20);
            checkBoxDownsample.Size = new Size(150, 24);
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
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Header.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            tChart1.Header.Shadow.Brush.Solid = true;
            tChart1.Header.Shadow.Brush.Visible = true;
            tChart1.Header.Visible = false;
            // 
            // 
            // 
            tChart1.Legend.Alignment = Steema.TeeChart.LegendAlignments.Top;
            // 
            // 
            // 
            tChart1.Legend.Brush.Color = Color.White;
            tChart1.Legend.Brush.Solid = true;
            tChart1.Legend.Brush.Visible = true;
            tChart1.Legend.CheckBoxes = false;
            tChart1.Legend.ClipText = false;
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
            tChart1.Location = new Point(230, 128);
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
            tChart1.Series.Add(series1);
            tChart1.Series.Add(series2);
            tChart1.Size = new Size(686, 391);
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
            tChart1.Zoom.Brush.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton16x);
            groupBox1.Controls.Add(radioButton8x);
            groupBox1.Controls.Add(radioButton4x);
            groupBox1.Controls.Add(radioButton2x);
            groupBox1.Controls.Add(radioButton1x);
            groupBox1.Location = new Point(10, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(182, 118);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Zero padding";
            // 
            // radioButton16x
            // 
            radioButton16x.FlatStyle = FlatStyle.System;
            radioButton16x.Location = new Point(106, 49);
            radioButton16x.Name = "radioButton16x";
            radioButton16x.Size = new Size(67, 30);
            radioButton16x.TabIndex = 4;
            radioButton16x.Text = "16x";
            radioButton16x.Click += radioButton8x_Click;
            // 
            // radioButton8x
            // 
            radioButton8x.FlatStyle = FlatStyle.System;
            radioButton8x.Location = new Point(106, 20);
            radioButton8x.Name = "radioButton8x";
            radioButton8x.Size = new Size(67, 29);
            radioButton8x.TabIndex = 3;
            radioButton8x.Text = "8x";
            radioButton8x.Click += radioButton8x_Click;
            // 
            // radioButton4x
            // 
            radioButton4x.Checked = true;
            radioButton4x.FlatStyle = FlatStyle.System;
            radioButton4x.Location = new Point(10, 79);
            radioButton4x.Name = "radioButton4x";
            radioButton4x.Size = new Size(67, 29);
            radioButton4x.TabIndex = 2;
            radioButton4x.TabStop = true;
            radioButton4x.Text = "4x";
            radioButton4x.Click += radioButton8x_Click;
            // 
            // radioButton2x
            // 
            radioButton2x.FlatStyle = FlatStyle.System;
            radioButton2x.Location = new Point(10, 49);
            radioButton2x.Name = "radioButton2x";
            radioButton2x.Size = new Size(67, 30);
            radioButton2x.TabIndex = 1;
            radioButton2x.Text = "2x";
            radioButton2x.Click += radioButton8x_Click;
            // 
            // radioButton1x
            // 
            radioButton1x.FlatStyle = FlatStyle.System;
            radioButton1x.Location = new Point(10, 20);
            radioButton1x.Name = "radioButton1x";
            radioButton1x.Size = new Size(67, 29);
            radioButton1x.TabIndex = 0;
            radioButton1x.Text = "1x";
            radioButton1x.Click += radioButton8x_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(10, 276);
            trackBar1.Maximum = 8000;
            trackBar1.Minimum = 50;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(182, 45);
            trackBar1.TabIndex = 4;
            trackBar1.TickFrequency = 500;
            trackBar1.TickStyle = TickStyle.TopLeft;
            trackBar1.Value = 2000;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(10, 374);
            trackBar2.Maximum = 8000;
            trackBar2.Minimum = 1;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(182, 45);
            trackBar2.TabIndex = 5;
            trackBar2.TickFrequency = 500;
            trackBar2.TickStyle = TickStyle.TopLeft;
            trackBar2.Value = 2000;
            trackBar2.ValueChanged += trackBar2_ValueChanged;
            // 
            // label1
            // 
            label1.Location = new Point(10, 256);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 6;
            label1.Text = "CorrLength :";
            // 
            // labelCorrLength
            // 
            labelCorrLength.Location = new Point(134, 256);
            labelCorrLength.Name = "labelCorrLength";
            labelCorrLength.Size = new Size(68, 20);
            labelCorrLength.TabIndex = 7;
            labelCorrLength.Text = "labelCorrLength";
            // 
            // label3
            // 
            label3.Location = new Point(10, 354);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 8;
            label3.Text = "LPCCoef :";
            // 
            // labelLPCCoef
            // 
            labelLPCCoef.Location = new Point(134, 354);
            labelLPCCoef.Name = "labelLPCCoef";
            labelLPCCoef.Size = new Size(68, 20);
            labelLPCCoef.TabIndex = 9;
            labelLPCCoef.Text = "labelLPCCoef";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(163, 20);
            button1.Name = "button1";
            button1.Size = new Size(135, 28);
            button1.TabIndex = 1;
            button1.Text = "Calculate spectrum";
            button1.Click += button1_Click;
            // 
            // labelTimeLYW
            // 
            labelTimeLYW.AutoSize = true;
            labelTimeLYW.Location = new Point(326, 10);
            labelTimeLYW.Name = "labelTimeLYW";
            labelTimeLYW.Size = new Size(173, 15);
            labelTimeLYW.TabIndex = 2;
            labelTimeLYW.Text = "Time needed for Levinson YW : ";
            // 
            // labelTimeFFT
            // 
            labelTimeFFT.AutoSize = true;
            labelTimeFFT.Location = new Point(326, 30);
            labelTimeFFT.Name = "labelTimeFFT";
            labelTimeFFT.Size = new Size(119, 15);
            labelTimeFFT.TabIndex = 3;
            labelTimeFFT.Text = "Time needed to FFT : ";
            // 
            // series1
            // 
            // 
            // 
            // 
            series1.Brush.Color = Color.Empty;
            series1.Brush.Solid = true;
            series1.Brush.Visible = true;
            series1.Color = Color.FromArgb(119, 153, 214);
            series1.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            series1.Legend.Brush.Color = Color.White;
            series1.Legend.Brush.Solid = true;
            series1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            series1.Legend.Font.Bold = false;
            // 
            // 
            // 
            series1.Legend.Font.Brush.Color = Color.Black;
            series1.Legend.Font.Brush.Solid = true;
            series1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            series1.Legend.Font.Shadow.Brush.Solid = true;
            series1.Legend.Font.Shadow.Brush.Visible = true;
            series1.Legend.Font.Size = 8;
            series1.Legend.Font.SizeFloat = 8F;
            series1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            series1.Legend.ImageBevel.Brush.Color = Color.LightGray;
            series1.Legend.ImageBevel.Brush.Solid = true;
            series1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series1.Legend.Shadow.Brush.Color = Color.DarkGray;
            series1.Legend.Shadow.Brush.Solid = true;
            series1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series1.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            series1.Marks.Brush.Solid = true;
            series1.Marks.Brush.Visible = true;
            // 
            // 
            // 
            series1.Marks.Font.Bold = false;
            // 
            // 
            // 
            series1.Marks.Font.Brush.Color = Color.Black;
            series1.Marks.Font.Brush.Solid = true;
            series1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series1.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            series1.Marks.Font.Shadow.Brush.Solid = true;
            series1.Marks.Font.Shadow.Brush.Visible = true;
            series1.Marks.Font.Size = 8;
            series1.Marks.Font.SizeFloat = 8F;
            series1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            series1.Marks.ImageBevel.Brush.Color = Color.LightGray;
            series1.Marks.ImageBevel.Brush.Solid = true;
            series1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series1.Marks.Shadow.Brush.Color = Color.Gray;
            series1.Marks.Shadow.Brush.Solid = true;
            series1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series1.Marks.Symbol.Brush.Color = Color.White;
            series1.Marks.Symbol.Brush.Solid = true;
            series1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series1.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            series1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            series1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series1.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            series1.Marks.Symbol.Shadow.Brush.Solid = true;
            series1.Marks.Symbol.Shadow.Brush.Visible = true;
            series1.Title = "Yule Walker AR";
            series1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            // 
            // 
            // 
            series1.XValues.DataMember = "X";
            series1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            series1.XValues.Value = new double[]
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
            series1.YValues.DataMember = "Y";
            series1.YValues.Value = new double[]
    {
    507D,
    617D,
    496D,
    544D,
    574D,
    567D,
    671D,
    763D,
    697D,
    655D,
    555D,
    662D,
    714D,
    648D,
    562D,
    613D,
    562D,
    663D,
    625D,
    524D,
    633D,
    597D,
    656D,
    711D,
    791D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // series2
            // 
            // 
            // 
            // 
            series2.Brush.Color = Color.Empty;
            series2.Brush.Solid = true;
            series2.Brush.Visible = true;
            series2.Color = Color.FromArgb(255, 207, 104);
            series2.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            series2.Legend.Brush.Color = Color.White;
            series2.Legend.Brush.Solid = true;
            series2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            series2.Legend.Font.Bold = false;
            // 
            // 
            // 
            series2.Legend.Font.Brush.Color = Color.Black;
            series2.Legend.Font.Brush.Solid = true;
            series2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series2.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            series2.Legend.Font.Shadow.Brush.Solid = true;
            series2.Legend.Font.Shadow.Brush.Visible = true;
            series2.Legend.Font.Size = 8;
            series2.Legend.Font.SizeFloat = 8F;
            series2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            series2.Legend.ImageBevel.Brush.Color = Color.LightGray;
            series2.Legend.ImageBevel.Brush.Solid = true;
            series2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series2.Legend.Shadow.Brush.Color = Color.DarkGray;
            series2.Legend.Shadow.Brush.Solid = true;
            series2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series2.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            series2.Marks.Brush.Solid = true;
            series2.Marks.Brush.Visible = true;
            // 
            // 
            // 
            series2.Marks.Font.Bold = false;
            // 
            // 
            // 
            series2.Marks.Font.Brush.Color = Color.Black;
            series2.Marks.Font.Brush.Solid = true;
            series2.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series2.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            series2.Marks.Font.Shadow.Brush.Solid = true;
            series2.Marks.Font.Shadow.Brush.Visible = true;
            series2.Marks.Font.Size = 8;
            series2.Marks.Font.SizeFloat = 8F;
            series2.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            series2.Marks.ImageBevel.Brush.Color = Color.LightGray;
            series2.Marks.ImageBevel.Brush.Solid = true;
            series2.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series2.Marks.Shadow.Brush.Color = Color.Gray;
            series2.Marks.Shadow.Brush.Solid = true;
            series2.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series2.Marks.Symbol.Brush.Color = Color.White;
            series2.Marks.Symbol.Brush.Solid = true;
            series2.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series2.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            series2.Marks.Symbol.ImageBevel.Brush.Solid = true;
            series2.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series2.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            series2.Marks.Symbol.Shadow.Brush.Solid = true;
            series2.Marks.Symbol.Shadow.Brush.Visible = true;
            series2.Title = "FFT";
            series2.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            // 
            // 
            // 
            series2.XValues.DataMember = "X";
            series2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            series2.XValues.Value = new double[]
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
            series2.YValues.DataMember = "Y";
            series2.YValues.Value = new double[]
    {
    647D,
    642D,
    678D,
    688D,
    692D,
    685D,
    699D,
    672D,
    636D,
    624D,
    606D,
    593D,
    594D,
    603D,
    620D,
    601D,
    614D,
    631D,
    663D,
    682D,
    667D,
    693D,
    722D,
    746D,
    747D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // YuleLevinsonForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(952, 595);
            Controls.Add(labelLPCCoef);
            Controls.Add(label3);
            Controls.Add(labelCorrLength);
            Controls.Add(label1);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(groupBox1);
            Name = "YuleLevinsonForm";
            Load += YuleLevinsonForm_Load;
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(trackBar1, 0);
            Controls.SetChildIndex(trackBar2, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(labelCorrLength, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(labelLPCCoef, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(tChart1, 0);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((ISupportInitialize)trackBar1).EndInit();
            ((ISupportInitialize)trackBar2).EndInit();
            ResumeLayout(false);
            PerformLayout();

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

