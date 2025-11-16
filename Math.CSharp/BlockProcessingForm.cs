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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlockProcessingForm));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.line1 = new Steema.TeeChart.Styles.Line();
            this.line2 = new Steema.TeeChart.Styles.Line();
            this.line3 = new Steema.TeeChart.Styles.Line();
            this.line4 = new Steema.TeeChart.Styles.Line();
            this.GCBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(943, 100);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.GCBox);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 567);
            this.panel2.Size = new System.Drawing.Size(943, 40);
            this.panel2.Controls.SetChildIndex(this.button1, 0);
            this.panel2.Controls.SetChildIndex(this.GCBox, 0);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.checkBoxDownsample, 0);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(943, 100);
            // 
            // checkBoxDownsample
            // 
            this.checkBoxDownsample.Visible = false;
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
            this.tChart1.Axes.Bottom.Title.Caption = "Vector length";
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
            this.tChart1.Axes.Bottom.Title.Lines = new string[] {
        "Vector length"};
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
            this.tChart1.Axes.Left.Title.Caption = "Time [ms]";
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
            this.tChart1.Axes.Left.Title.Lines = new string[] {
        "Time [ms]"};
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
            this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.tChart1.Header.Lines = new string[] {
        "Block vectorization"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            // 
            // 
            // 
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
            this.tChart1.Legend.LegendStyle = Steema.TeeChart.LegendStyles.Series;
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
            this.tChart1.Legend.TextStyle = Steema.TeeChart.LegendTextStyles.Value;
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
            this.tChart1.Location = new System.Drawing.Point(0, 100);
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
            this.tChart1.Series.Add(this.line1);
            this.tChart1.Series.Add(this.line2);
            this.tChart1.Series.Add(this.line3);
            this.tChart1.Series.Add(this.line4);
            this.tChart1.Size = new System.Drawing.Size(943, 467);
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
            this.tChart1.Click += new System.EventHandler(this.tChart1_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(136, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Run test";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(224, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Progress : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // line1
            // 
            // 
            // 
            // 
            this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.line1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.line1.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.line1.Legend.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line1.Legend.Font.Size = 8;
            this.line1.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.line1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line1.Marks.Font.Size = 8;
            this.line1.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.line1.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.line1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
            this.line1.OriginalCursor = null;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Pointer.Brush.Color = System.Drawing.Color.Red;
            this.line1.Pointer.Dark3D = false;
            this.line1.Pointer.Draw3D = false;
            this.line1.Pointer.HorizSize = 3;
            this.line1.Pointer.SizeDouble = 0D;
            this.line1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.line1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Triangle;
            this.line1.Pointer.VertSize = 3;
            this.line1.Pointer.Visible = true;
            this.line1.Title = "Plain function";
            this.line1.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.line1.XValues.DataMember = "X";
            this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.line1.YValues.DataMember = "Y";
            // 
            // line2
            // 
            // 
            // 
            // 
            this.line2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(104)))));
            this.line2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(104)))));
            this.line2.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.line2.Legend.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line2.Legend.Font.Size = 8;
            this.line2.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.line2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(124)))), ((int)(((byte)(62)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.line2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line2.Marks.Font.Size = 8;
            this.line2.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.line2.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.line2.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
            this.line2.OriginalCursor = null;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Pointer.Brush.Color = System.Drawing.Color.RoyalBlue;
            this.line2.Pointer.Dark3D = false;
            this.line2.Pointer.Draw3D = false;
            this.line2.Pointer.HorizSize = 3;
            this.line2.Pointer.SizeDouble = 0D;
            this.line2.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.line2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.DownTriangle;
            this.line2.Pointer.VertSize = 3;
            this.line2.Pointer.Visible = true;
            this.line2.Title = "Vectorized";
            this.line2.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.line2.XValues.DataMember = "X";
            this.line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.line2.YValues.DataMember = "Y";
            // 
            // line3
            // 
            // 
            // 
            // 
            this.line3.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(71)))));
            this.line3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(71)))));
            this.line3.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.line3.Legend.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line3.Legend.Font.Size = 8;
            this.line3.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.line3.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(76)))), ((int)(((byte)(43)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.line3.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line3.Marks.Font.Size = 8;
            this.line3.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.line3.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.line3.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos2")));
            this.line3.OriginalCursor = null;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Pointer.Brush.Color = System.Drawing.Color.Magenta;
            this.line3.Pointer.Dark3D = false;
            this.line3.Pointer.Draw3D = false;
            this.line3.Pointer.HorizSize = 3;
            this.line3.Pointer.SizeDouble = 0D;
            this.line3.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.line3.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Diamond;
            this.line3.Pointer.VertSize = 3;
            this.line3.Pointer.Visible = true;
            this.line3.Title = "Block vectorized";
            this.line3.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.line3.XValues.DataMember = "X";
            this.line3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.line3.YValues.DataMember = "Y";
            // 
            // line4
            // 
            // 
            // 
            // 
            this.line4.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(202)))), ((int)(((byte)(219)))));
            this.line4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(202)))), ((int)(((byte)(219)))));
            this.line4.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line4.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.line4.Legend.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line4.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line4.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line4.Legend.Font.Size = 8;
            this.line4.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line4.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line4.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.line4.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(121)))), ((int)(((byte)(131)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line4.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.line4.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line4.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line4.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line4.Marks.Font.Size = 8;
            this.line4.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line4.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line4.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line4.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.line4.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line4.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line4.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.line4.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos3")));
            this.line4.OriginalCursor = null;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line4.Pointer.Brush.Color = System.Drawing.Color.Green;
            this.line4.Pointer.HorizSize = 2;
            this.line4.Pointer.SizeDouble = 0D;
            this.line4.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.line4.Pointer.VertSize = 2;
            this.line4.Pointer.Visible = true;
            this.line4.Title = "Expression";
            this.line4.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.line4.XValues.DataMember = "X";
            this.line4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.line4.YValues.DataMember = "Y";
            // 
            // GCBox
            // 
            this.GCBox.AutoSize = true;
            this.GCBox.Location = new System.Drawing.Point(413, 11);
            this.GCBox.Name = "GCBox";
            this.GCBox.Size = new System.Drawing.Size(130, 17);
            this.GCBox.TabIndex = 3;
            this.GCBox.Text = "Garbage collector test";
            this.GCBox.UseVisualStyleBackColor = true;
            this.GCBox.CheckedChanged += new System.EventHandler(this.GCBox_CheckedChanged);
            // 
            // BlockProcessingForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(943, 607);
            this.Name = "BlockProcessingForm";
            this.Load += new System.EventHandler(this.BlockProcessingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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

