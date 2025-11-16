using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Units;
using System.Runtime.InteropServices;

namespace MtxVecDemo
{
   
    public class BlockProcessingForm : MtxVecDemo.BasicForm1
	{
		private System.ComponentModel.IContainer components = null;
		private Vector x,res,tmp, refRes;
		private double [] xArray, resArray;
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Styles.Line line1;
		private Steema.TeeChart.Styles.Line line2;
		private Steema.TeeChart.Styles.Line line3;
        private Steema.TeeChart.Styles.Line line4;
		private System.Windows.Forms.Label label1;
        private CheckBox GCBox;
        private bool GCTest = false;


		public BlockProcessingForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
            x = new Vector(0);
            res = new Vector(0);
            tmp = new Vector(0);
            refRes = new Vector(0);
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(BlockProcessingForm));
            button1 = new Button();
            label1 = new Label();
            line1 = new Steema.TeeChart.Styles.Line();
            line2 = new Steema.TeeChart.Styles.Line();
            line3 = new Steema.TeeChart.Styles.Line();
            line4 = new Steema.TeeChart.Styles.Line();
            GCBox = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Size = new Size(1004, 123);
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(GCBox);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 604);
            panel2.Size = new Size(1004, 49);
            panel2.Controls.SetChildIndex(button1, 0);
            panel2.Controls.SetChildIndex(GCBox, 0);
            panel2.Controls.SetChildIndex(label1, 0);
            panel2.Controls.SetChildIndex(checkBoxDownsample, 0);
            // 
            // richTextBox1
            // 
            richTextBox1.Size = new Size(1004, 123);
            // 
            // checkBoxDownsample
            // 
            checkBoxDownsample.Location = new Point(23, 12);
            checkBoxDownsample.Size = new Size(150, 25);
            checkBoxDownsample.Visible = false;
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
            tChart1.Axes.Bottom.Title.Caption = "Vector length";
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
    "Vector length"
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
            tChart1.Axes.Left.Title.Caption = "Time [ms]";
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
    "Time [ms]"
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
    "Block vectorization"
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
            tChart1.Legend.LegendStyle = Steema.TeeChart.LegendStyles.Series;
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
            tChart1.Legend.TextStyle = Steema.TeeChart.LegendTextStyles.Value;
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
            tChart1.Location = new Point(0, 123);
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
            tChart1.Series.Add(line1);
            tChart1.Series.Add(line2);
            tChart1.Series.Add(line3);
            tChart1.Series.Add(line4);
            tChart1.Size = new Size(1004, 481);
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
            tChart1.Click += tChart1_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(163, 10);
            button1.Name = "button1";
            button1.Size = new Size(90, 28);
            button1.TabIndex = 1;
            button1.Text = "Run test";
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(269, 10);
            label1.Name = "label1";
            label1.Size = new Size(163, 29);
            label1.TabIndex = 2;
            label1.Text = "Progress : ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // line1
            // 
            // 
            // 
            // 
            line1.AreaBrush.Color = Color.White;
            line1.AreaBrush.Solid = true;
            line1.AreaBrush.Visible = false;
            // 
            // 
            // 
            line1.Brush.Color = Color.FromArgb(119, 153, 214);
            line1.Brush.Solid = true;
            line1.Brush.Visible = true;
            line1.Color = Color.FromArgb(119, 153, 214);
            line1.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            line1.Legend.Brush.Color = Color.White;
            line1.Legend.Brush.Solid = true;
            line1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            line1.Legend.Font.Bold = false;
            // 
            // 
            // 
            line1.Legend.Font.Brush.Color = Color.Black;
            line1.Legend.Font.Brush.Solid = true;
            line1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            line1.Legend.Font.Shadow.Brush.Solid = true;
            line1.Legend.Font.Shadow.Brush.Visible = true;
            line1.Legend.Font.Size = 8;
            line1.Legend.Font.SizeFloat = 8F;
            line1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            line1.Legend.ImageBevel.Brush.Color = Color.LightGray;
            line1.Legend.ImageBevel.Brush.Solid = true;
            line1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line1.Legend.Shadow.Brush.Color = Color.DarkGray;
            line1.Legend.Shadow.Brush.Solid = true;
            line1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line1.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            line1.Marks.Brush.Solid = true;
            line1.Marks.Brush.Visible = true;
            // 
            // 
            // 
            line1.Marks.Font.Bold = false;
            // 
            // 
            // 
            line1.Marks.Font.Brush.Color = Color.Black;
            line1.Marks.Font.Brush.Solid = true;
            line1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line1.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            line1.Marks.Font.Shadow.Brush.Solid = true;
            line1.Marks.Font.Shadow.Brush.Visible = true;
            line1.Marks.Font.Size = 8;
            line1.Marks.Font.SizeFloat = 8F;
            line1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            line1.Marks.ImageBevel.Brush.Color = Color.LightGray;
            line1.Marks.ImageBevel.Brush.Solid = true;
            line1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line1.Marks.Shadow.Brush.Color = Color.Gray;
            line1.Marks.Shadow.Brush.Solid = true;
            line1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line1.Marks.Symbol.Brush.Color = Color.White;
            line1.Marks.Symbol.Brush.Solid = true;
            line1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line1.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            line1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            line1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line1.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            line1.Marks.Symbol.Shadow.Brush.Solid = true;
            line1.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line1.Pointer.Brush.Color = Color.Red;
            line1.Pointer.Brush.Solid = true;
            line1.Pointer.Brush.Visible = true;
            line1.Pointer.Dark3D = false;
            line1.Pointer.Draw3D = false;
            line1.Pointer.HorizSize = 3;
            line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Triangle;
            line1.Pointer.VertSize = 3;
            line1.Pointer.Visible = true;
            line1.Title = "Plain function";
            // 
            // 
            // 
            line1.XValues.DataMember = "X";
            line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            line1.XValues.Value = new double[]
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
            line1.YValues.DataMember = "Y";
            line1.YValues.Value = new double[]
    {
    79D,
    35D,
    50D,
    158D,
    202D,
    79D,
    6D,
    114D,
    85D,
    112D,
    79D,
    43D,
    132D,
    198D,
    155D,
    123D,
    42D,
    164D,
    70D,
    99D,
    63D,
    126D,
    54D,
    8D,
    72D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // line2
            // 
            // 
            // 
            // 
            line2.AreaBrush.Color = Color.White;
            line2.AreaBrush.Solid = true;
            line2.AreaBrush.Visible = false;
            // 
            // 
            // 
            line2.Brush.Color = Color.FromArgb(255, 207, 104);
            line2.Brush.Solid = true;
            line2.Brush.Visible = true;
            line2.Color = Color.FromArgb(255, 207, 104);
            line2.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            line2.Legend.Brush.Color = Color.White;
            line2.Legend.Brush.Solid = true;
            line2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            line2.Legend.Font.Bold = false;
            // 
            // 
            // 
            line2.Legend.Font.Brush.Color = Color.Black;
            line2.Legend.Font.Brush.Solid = true;
            line2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line2.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            line2.Legend.Font.Shadow.Brush.Solid = true;
            line2.Legend.Font.Shadow.Brush.Visible = true;
            line2.Legend.Font.Size = 8;
            line2.Legend.Font.SizeFloat = 8F;
            line2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            line2.Legend.ImageBevel.Brush.Color = Color.LightGray;
            line2.Legend.ImageBevel.Brush.Solid = true;
            line2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line2.Legend.Shadow.Brush.Color = Color.DarkGray;
            line2.Legend.Shadow.Brush.Solid = true;
            line2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line2.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            line2.Marks.Brush.Solid = true;
            line2.Marks.Brush.Visible = true;
            // 
            // 
            // 
            line2.Marks.Font.Bold = false;
            // 
            // 
            // 
            line2.Marks.Font.Brush.Color = Color.Black;
            line2.Marks.Font.Brush.Solid = true;
            line2.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line2.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            line2.Marks.Font.Shadow.Brush.Solid = true;
            line2.Marks.Font.Shadow.Brush.Visible = true;
            line2.Marks.Font.Size = 8;
            line2.Marks.Font.SizeFloat = 8F;
            line2.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            line2.Marks.ImageBevel.Brush.Color = Color.LightGray;
            line2.Marks.ImageBevel.Brush.Solid = true;
            line2.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line2.Marks.Shadow.Brush.Color = Color.Gray;
            line2.Marks.Shadow.Brush.Solid = true;
            line2.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line2.Marks.Symbol.Brush.Color = Color.White;
            line2.Marks.Symbol.Brush.Solid = true;
            line2.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line2.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            line2.Marks.Symbol.ImageBevel.Brush.Solid = true;
            line2.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line2.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            line2.Marks.Symbol.Shadow.Brush.Solid = true;
            line2.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line2.Pointer.Brush.Color = Color.RoyalBlue;
            line2.Pointer.Brush.Solid = true;
            line2.Pointer.Brush.Visible = true;
            line2.Pointer.Dark3D = false;
            line2.Pointer.Draw3D = false;
            line2.Pointer.HorizSize = 3;
            line2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.DownTriangle;
            line2.Pointer.VertSize = 3;
            line2.Pointer.Visible = true;
            line2.Title = "Vectorized";
            // 
            // 
            // 
            line2.XValues.DataMember = "X";
            line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            line2.XValues.Value = new double[]
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
            line2.YValues.DataMember = "Y";
            line2.YValues.Value = new double[]
    {
    83D,
    86D,
    74D,
    89D,
    76D,
    67D,
    86D,
    110D,
    130D,
    144D,
    130D,
    114D,
    99D,
    84D,
    76D,
    101D,
    90D,
    109D,
    104D,
    83D,
    104D,
    91D,
    109D,
    128D,
    150D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // line3
            // 
            // 
            // 
            // 
            line3.AreaBrush.Color = Color.White;
            line3.AreaBrush.Solid = true;
            line3.AreaBrush.Visible = false;
            // 
            // 
            // 
            line3.Brush.Color = Color.FromArgb(255, 127, 71);
            line3.Brush.Solid = true;
            line3.Brush.Visible = true;
            line3.Color = Color.FromArgb(255, 127, 71);
            line3.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            line3.Legend.Brush.Color = Color.White;
            line3.Legend.Brush.Solid = true;
            line3.Legend.Brush.Visible = true;
            // 
            // 
            // 
            line3.Legend.Font.Bold = false;
            // 
            // 
            // 
            line3.Legend.Font.Brush.Color = Color.Black;
            line3.Legend.Font.Brush.Solid = true;
            line3.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line3.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            line3.Legend.Font.Shadow.Brush.Solid = true;
            line3.Legend.Font.Shadow.Brush.Visible = true;
            line3.Legend.Font.Size = 8;
            line3.Legend.Font.SizeFloat = 8F;
            line3.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            line3.Legend.ImageBevel.Brush.Color = Color.LightGray;
            line3.Legend.ImageBevel.Brush.Solid = true;
            line3.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line3.Legend.Shadow.Brush.Color = Color.DarkGray;
            line3.Legend.Shadow.Brush.Solid = true;
            line3.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line3.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            line3.Marks.Brush.Solid = true;
            line3.Marks.Brush.Visible = true;
            // 
            // 
            // 
            line3.Marks.Font.Bold = false;
            // 
            // 
            // 
            line3.Marks.Font.Brush.Color = Color.Black;
            line3.Marks.Font.Brush.Solid = true;
            line3.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line3.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            line3.Marks.Font.Shadow.Brush.Solid = true;
            line3.Marks.Font.Shadow.Brush.Visible = true;
            line3.Marks.Font.Size = 8;
            line3.Marks.Font.SizeFloat = 8F;
            line3.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            line3.Marks.ImageBevel.Brush.Color = Color.LightGray;
            line3.Marks.ImageBevel.Brush.Solid = true;
            line3.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line3.Marks.Shadow.Brush.Color = Color.Gray;
            line3.Marks.Shadow.Brush.Solid = true;
            line3.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line3.Marks.Symbol.Brush.Color = Color.White;
            line3.Marks.Symbol.Brush.Solid = true;
            line3.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line3.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            line3.Marks.Symbol.ImageBevel.Brush.Solid = true;
            line3.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line3.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            line3.Marks.Symbol.Shadow.Brush.Solid = true;
            line3.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line3.Pointer.Brush.Color = Color.Magenta;
            line3.Pointer.Brush.Solid = true;
            line3.Pointer.Brush.Visible = true;
            line3.Pointer.Dark3D = false;
            line3.Pointer.Draw3D = false;
            line3.Pointer.HorizSize = 3;
            line3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Diamond;
            line3.Pointer.VertSize = 3;
            line3.Pointer.Visible = true;
            line3.Title = "Block vectorized";
            // 
            // 
            // 
            line3.XValues.DataMember = "X";
            line3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            line3.XValues.Value = new double[]
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
            line3.YValues.DataMember = "Y";
            line3.YValues.Value = new double[]
    {
    66D,
    73D,
    88D,
    87D,
    104D,
    92D,
    105D,
    95D,
    96D,
    102D,
    116D,
    121D,
    115D,
    94D,
    93D,
    112D,
    130D,
    133D,
    117D,
    93D,
    109D,
    131D,
    121D,
    115D,
    115D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // line4
            // 
            // 
            // 
            // 
            line4.AreaBrush.Color = Color.White;
            line4.AreaBrush.Solid = true;
            line4.AreaBrush.Visible = false;
            // 
            // 
            // 
            line4.Brush.Color = Color.FromArgb(129, 202, 219);
            line4.Brush.Solid = true;
            line4.Brush.Visible = true;
            line4.Color = Color.FromArgb(129, 202, 219);
            line4.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            line4.Legend.Brush.Color = Color.White;
            line4.Legend.Brush.Solid = true;
            line4.Legend.Brush.Visible = true;
            // 
            // 
            // 
            line4.Legend.Font.Bold = false;
            // 
            // 
            // 
            line4.Legend.Font.Brush.Color = Color.Black;
            line4.Legend.Font.Brush.Solid = true;
            line4.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line4.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            line4.Legend.Font.Shadow.Brush.Solid = true;
            line4.Legend.Font.Shadow.Brush.Visible = true;
            line4.Legend.Font.Size = 8;
            line4.Legend.Font.SizeFloat = 8F;
            line4.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            line4.Legend.ImageBevel.Brush.Color = Color.LightGray;
            line4.Legend.ImageBevel.Brush.Solid = true;
            line4.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line4.Legend.Shadow.Brush.Color = Color.DarkGray;
            line4.Legend.Shadow.Brush.Solid = true;
            line4.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line4.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            line4.Marks.Brush.Solid = true;
            line4.Marks.Brush.Visible = true;
            // 
            // 
            // 
            line4.Marks.Font.Bold = false;
            // 
            // 
            // 
            line4.Marks.Font.Brush.Color = Color.Black;
            line4.Marks.Font.Brush.Solid = true;
            line4.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line4.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            line4.Marks.Font.Shadow.Brush.Solid = true;
            line4.Marks.Font.Shadow.Brush.Visible = true;
            line4.Marks.Font.Size = 8;
            line4.Marks.Font.SizeFloat = 8F;
            line4.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            line4.Marks.ImageBevel.Brush.Color = Color.LightGray;
            line4.Marks.ImageBevel.Brush.Solid = true;
            line4.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line4.Marks.Shadow.Brush.Color = Color.Gray;
            line4.Marks.Shadow.Brush.Solid = true;
            line4.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line4.Marks.Symbol.Brush.Color = Color.White;
            line4.Marks.Symbol.Brush.Solid = true;
            line4.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line4.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            line4.Marks.Symbol.ImageBevel.Brush.Solid = true;
            line4.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line4.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            line4.Marks.Symbol.Shadow.Brush.Solid = true;
            line4.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            line4.Pointer.Brush.Color = Color.Green;
            line4.Pointer.Brush.Solid = true;
            line4.Pointer.Brush.Visible = true;
            line4.Pointer.HorizSize = 2;
            line4.Pointer.VertSize = 2;
            line4.Pointer.Visible = true;
            line4.Title = "Expression";
            // 
            // 
            // 
            line4.XValues.DataMember = "X";
            line4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            line4.XValues.Value = new double[]
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
            line4.YValues.DataMember = "Y";
            line4.YValues.Value = new double[]
    {
    91D,
    73D,
    72D,
    62D,
    73D,
    66D,
    84D,
    103D,
    80D,
    69D,
    54D,
    52D,
    75D,
    98D,
    94D,
    113D,
    122D,
    133D,
    119D,
    128D,
    129D,
    121D,
    126D,
    104D,
    97D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // GCBox
            // 
            GCBox.AutoSize = true;
            GCBox.Location = new Point(496, 14);
            GCBox.Name = "GCBox";
            GCBox.Size = new Size(141, 19);
            GCBox.TabIndex = 3;
            GCBox.Text = "Garbage collector test";
            GCBox.UseVisualStyleBackColor = true;
            GCBox.CheckedChanged += GCBox_CheckedChanged;
            // 
            // BlockProcessingForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(1004, 653);
            Name = "BlockProcessingForm";
            Load += BlockProcessingForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }
        #endregion

        private void BlockProcessingForm_Load(object sender, System.EventArgs e) 
		{
			Add("Block processing enables you to adapt the length "
				+ "of the memory being accessed by your algorithm to "
				+ "approximately match the size of the CPU cache. If "
				+ "the memory at the same memory location is accessed "
				+ "more than once, the second access will about 3-6 "
				+ "times faster. The trick is to break long vectors "
				+ "down in to a series of short ones and process each "
				+ "block separately, thus always holding the entire memory "
				+ "block in the CPU cache and radically reducing the number"
				+ "of CPU cache misses. Block processing is demonstrated by "
				+ "timing three versions of the same function. The function "
				+ "being benchmarked is Maxwell PDF.");
			Add("");
			Add("Block length (size of the sub vector) is automatically set "
				+ "by MtxVec to match the CPU cache size and so is the number "
				+ "iterations required to process the entire vector length.");		
		}

		private double MaxwellFunction(int Iterations) 
		{
			double a = 1;
            double[] testArray;
            Math387.StartTimer();
            if (Iterations == 0) throw new Exception("Iterations == 0");
			for (int i=0;i<Iterations;i++) 
			{
				for (int j=0;j<x.Length; j++) resArray[j] = MaxwellPdf3(xArray[j],a);

                //because xArray is not pinned, we should see degradation in performance
                if (GCTest)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        testArray = new double[resArray.Length];
                        testArray[k] = resArray[1];
                    }
                }
			}
			double result = Math387.StopTimer()*1000;
            res.CopyFromArray(resArray);
            return result;
		}

        public double MaxwellPdf3(double x, double a) 
        { 
	        double xx;

	        xx = x*x;
	        return  Math.Sqrt(4*a*Math387.INVTWOPI)*a*xx*Math.Exp(-0.5*a*xx);
          }

private void MaxwellPdf2(TVec X, double a, TVec Res)
{
    TVec res1;
    MtxVec.CreateIt(out res1);
    try
    {
        Res.Size(X);
        X.BlockInit();
        res.BlockInit();
        while (!X.BlockEnd)
        {
            tmp.Sqr(X);
            res.Copy(tmp);
            res.Mul(-0.5 * a);
            res.Exp();
            res.Mul(tmp);
            res.Mul(Math.Sqrt(4 * a * Math387.INVTWOPI) * a);
            res.BlockNext();
            X.BlockNext();
        }
    }
    finally
    {
        MtxVec.FreeIt(ref res1);
    }
}


private void MaxwellPdf1(TVec X, double a, TVec Res) 
{
    TVec res1;
    MtxVec.CreateIt(out res1);
    try
    {
        res1.Sqr(X);
        res.Mul(res1, -0.5 * a);
        res.Exp();
        res.Mul(res1);
        res.Mul(Math.Sqrt(4 * Math387.INVTWOPI * a) * a);
    }
    finally
    {
        MtxVec.FreeIt(ref res1);
    }
}

		private double MaxwellNoBlock(int Iterations) { 
			double a = 1;
            double[] testArray;
            Math387.StartTimer();
			for (int i=0;i<Iterations;i++) {
				tmp.Sqr(x);              
                res.Mul(tmp,-0.5*a);
                res.Exp();
                res.Mul(tmp);
                res.Mul(Math.Sqrt(4*Math387.INVTWOPI*a)*a);

          //xArray is not pinned, we should still not see degradation in performance
                if (GCTest)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        testArray = new double[res.Length];
                        testArray[k] = resArray[1];
                    }
                }
			}
            return Math387.StopTimer()*1000;
		}

        private double MaxwellArray(int Iterations)
        {
            double a = 1;
            double xx;
            Math387.StartTimer();

            for (int j = 0; j < Iterations; j++)
            {
                for (int i = 0; i < xArray.Length; i++)
                {
                    xx = xArray[i] * xArray[i];
                    resArray[i] = Math.Sqrt(4 * a * Math387.INVTWOPI) * a * xx * Math.Exp(-0.5 * a * xx);
                }
            }
            return Math387.StopTimer();
        }


        public Vector MaxwellPDFx(Vector x, Vector a)
        {
            Vector xx = x * x;
            Vector res = MtxExpr.Sqrt(4 * Math387.INVTWOPI * a) * a * xx * MtxExpr.Exp(-0.5 * a * xx);
            return res;
        }

        private double MaxwellExpression(int Iterations)
        {
            double a = 1;
            Vector xx;
            Math387.StartTimer();
            for (int i = 0; i < Iterations; i++)
            {
				xx = x*x;
                res = Math.Sqrt(4 * Math387.INVTWOPI * a) * a *  xx * MtxExpr.Exp(-0.5 * a * xx);
            }
            return Math387.StopTimer()*1000;
        }

        private double MaxwellBlock(int Iterations) { 
			double a = 1;

            Math387.StartTimer();

			for (int i=0;i<Iterations;i++) {
				res.BlockInit();
				x.BlockInit();
				while (!x.BlockEnd) {
					tmp.Sqr(x);
					res.Mul(tmp,-0.5*a);
					res.Exp();
					res.Mul(tmp);
					res.Mul(Math.Sqrt(4*Math387.INVTWOPI)*a);
					res.BlockNext();
					x.BlockNext();
				}
			}
			return Math387.StopTimer()*1000;

		}
		private double FindMax(double[] a) {
			double result = Math387.MINNUM;
			foreach(double val in a) {
				if (val > result) result = val;
			}
			return result;
		}

		private void button1_Click(object sender, System.EventArgs e) {

			this.Cursor = Cursors.WaitCursor;
			try {

                int InitialSize = 10;
				x.Size(InitialSize,false);
				x.SetVal(2);
				res.Size(x);
                refRes.Size(x);
				x.CopyToArray(ref xArray);
				res.SizeToArray(ref resArray);
                int IterStep = 2;
                int InitialIters = 200000/(InitialSize/10);
				int iters = InitialIters;
                int Range = 17;
				double[] a1 = new double[Range];
				double[] a2 = new double[Range];
				double[] a3 = new double[Range];
                double[] a4 = new double[Range];
                for (int i = 0; i < Range; i++)
                { 
                    for (int j = 0; j < x.Length; j++) refRes.Values[j] = Probabilities.MaxwellPDF(xArray[j], 1);
                    res.SetZero();
                    a1[i] = MaxwellFunction(iters);
                    label1.Text = "Progress : " + ((int)(((double)i + 0.2) / Range * 100)).ToString() + " %";
                    if (!(refRes.IsEqual(res, 1E-10, TCompare.cmpAbsolute))) throw new Exception("Not equal!");
                    Refresh();

                    System.GC.Collect();
                    //System.Threading.Thread.Sleep(200); //allow GC to catch up

                    res.SetZero();
                    a2[i] = MaxwellNoBlock(iters);
                    label1.Text = "Progress : " + ((int)(((double)i + 0.4) / Range * 100)).ToString() + " %";
                    if (!(refRes.IsEqual(res, 1E-10, TCompare.cmpAbsolute))) throw new Exception("Not equal!");
                    Refresh();

                    System.GC.Collect();
                    //System.Threading.Thread.Sleep(200); //allow GC to catch up

                    res.SetZero();
                    a3[i] = MaxwellBlock(iters);
                    label1.Text = "Progress : " + ((int)(((double)i + 0.6) / Range * 100)).ToString() + " %";
                    if (!(refRes.IsEqual(res, 1E-10, TCompare.cmpAbsolute))) throw new Exception("Not equal!");
                    Refresh();

                    //System.Threading.Thread.Sleep(200); //allow GC to catch up
                    System.GC.Collect();

                    res.SetZero();
                    a4[i] = MaxwellExpression(iters);
                    label1.Text = "Progress : " + ((int)(((double)i + 0.8) / Range * 100)).ToString() + " %";
                    if (!(refRes.IsEqual(res, 1E-10, TCompare.cmpAbsolute))) throw new Exception("Not equal!");

                    //System.Threading.Thread.Sleep(200); //allow GC to catch up
                    System.GC.Collect();

                    Refresh();
                    iters /= IterStep;
                    x.Length *= IterStep;
                    res.Size(x);
                    x.SetVal(2);                    
                    x.CopyToArray(ref xArray);                    
                    res.SizeToArray(ref resArray);
                    refRes.Size(x);
                }
				label1.Text = "Progress : 100 %";
				tChart1.Axes.Left.Automatic = false;
				foreach (Steema.TeeChart.Styles.Series s in tChart1.Series) s.Clear();
                for (int i = 0; i < a1.Length; i++)
                {
                    if (a1[i] == 0) tChart1.Series[0].Add();
                    else tChart1.Series[0].Add(a1[i], (10 * Math.Pow(IterStep, i)).ToString());
                }
                for (int i = 0; i < a2.Length; i++)
                {
                    if (a2[i] == 0) tChart1.Series[1].Add();
                    else tChart1.Series[1].Add(a2[i], (10 * Math.Pow(IterStep, i)).ToString());
                }
                for (int i = 0; i < a3.Length; i++)
                {
                    if (a3[i] == 0) tChart1.Series[2].Add();
                    else tChart1.Series[2].Add(a3[i], (10 * Math.Pow(IterStep, i)).ToString());
                }                
                for (int i = 0; i < a4.Length; i++)
                {
//                    if (a4[i] == 0) tChart1.Series[3].Add();
                    //else 
                    tChart1.Series[3].Add(a4[i], (10 * Math.Pow(IterStep, i)).ToString());
                }
				tChart1.Axes.Left.SetMinMax(0,1.1*Math.Max(Math.Max(Math.Max(FindMax(a1),FindMax(a2)),FindMax(a3)),FindMax(a4)));
			} finally {
				this.Cursor = Cursors.Default;
			}
		}

        private void tChart1_Click(object sender, EventArgs e)
        {

        }

        private void GCBox_CheckedChanged(object sender, EventArgs e)
        {
            GCTest = GCBox.Checked;
        }
    }
}

