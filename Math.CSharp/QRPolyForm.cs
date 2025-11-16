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
            Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(QRPolyForm));
            series1 = new Steema.TeeChart.Styles.Points();
            series2 = new Steema.TeeChart.Styles.Line();
            series3 = new Steema.TeeChart.Styles.Line();
            series4 = new Steema.TeeChart.Styles.Line();
            label1 = new Label();
            label2 = new Label();
            labelTimeNeeded = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((ISupportInitialize)numericUpDown1).BeginInit();
            ((ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Size = new Size(979, 123);
            // 
            // panel2
            // 
            panel2.Controls.Add(numericUpDown2);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(labelTimeNeeded);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 461);
            panel2.Size = new Size(979, 107);
            panel2.Controls.SetChildIndex(label1, 0);
            panel2.Controls.SetChildIndex(checkBoxDownsample, 0);
            panel2.Controls.SetChildIndex(label2, 0);
            panel2.Controls.SetChildIndex(labelTimeNeeded, 0);
            panel2.Controls.SetChildIndex(button1, 0);
            panel2.Controls.SetChildIndex(button2, 0);
            panel2.Controls.SetChildIndex(button3, 0);
            panel2.Controls.SetChildIndex(numericUpDown1, 0);
            panel2.Controls.SetChildIndex(numericUpDown2, 0);
            // 
            // richTextBox1
            // 
            richTextBox1.Size = new Size(979, 123);
            // 
            // checkBoxDownsample
            // 
            checkBoxDownsample.Location = new Point(23, 12);
            checkBoxDownsample.Size = new Size(150, 25);
            checkBoxDownsample.CheckedChanged += checkBoxDownsample_CheckedChanged;
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
            tChart1.CausesValidation = false;
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
            tChart1.Legend.TextStyle = Steema.TeeChart.LegendTextStyles.Plain;
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
            tChart1.Series.Add(series1);
            tChart1.Series.Add(series2);
            tChart1.Series.Add(series3);
            tChart1.Series.Add(series4);
            tChart1.Size = new Size(979, 338);
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
            // series1
            // 
            // 
            // 
            // 
            series1.Brush.Color = Color.Empty;
            series1.Brush.Solid = true;
            series1.Brush.Visible = true;
            series1.Color = Color.Red;
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
            // 
            // 
            // 
            // 
            // 
            // 
            series1.Pointer.Brush.Color = Color.Red;
            series1.Pointer.Brush.Solid = true;
            series1.Pointer.Brush.Visible = true;
            series1.Pointer.Dark3D = false;
            series1.Pointer.Draw3D = false;
            series1.Pointer.HorizSize = 2;
            // 
            // 
            // 
            series1.Pointer.Pen.Visible = false;
            series1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.DownTriangle;
            series1.Pointer.VertSize = 2;
            series1.Title = "Original data";
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
    374D,
    415D,
    290D,
    395D,
    407D,
    398D,
    371D,
    343D,
    219D,
    275D,
    176D,
    245D,
    135D,
    92D,
    121D,
    166D,
    98D,
    26D,
    62D,
    170D,
    204D,
    185D,
    301D,
    177D,
    176D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            series2.AreaBrush.Color = Color.White;
            series2.AreaBrush.Solid = true;
            series2.AreaBrush.Visible = false;
            // 
            // 
            // 
            series2.Brush.Color = Color.FromArgb(119, 153, 214);
            series2.Brush.Solid = true;
            series2.Brush.Visible = true;
            series2.Color = Color.FromArgb(119, 153, 214);
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
            // 
            // 
            // 
            // 
            // 
            // 
            series2.Pointer.Brush.Color = Color.RoyalBlue;
            series2.Pointer.Brush.Solid = true;
            series2.Pointer.Brush.Visible = true;
            series2.Title = "Fitted polynomial";
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
    92D,
    86D,
    93D,
    73D,
    90D,
    67D,
    84D,
    77D,
    101D,
    79D,
    71D,
    63D,
    88D,
    128D,
    143D,
    189D,
    226D,
    194D,
    196D,
    229D,
    216D,
    225D,
    192D,
    203D,
    231D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // series3
            // 
            // 
            // 
            // 
            series3.AreaBrush.Color = Color.White;
            series3.AreaBrush.Solid = true;
            series3.AreaBrush.Visible = false;
            // 
            // 
            // 
            series3.Brush.Color = Color.FromArgb(255, 207, 104);
            series3.Brush.Solid = true;
            series3.Brush.Visible = true;
            series3.Color = Color.FromArgb(255, 207, 104);
            series3.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            series3.Legend.Brush.Color = Color.White;
            series3.Legend.Brush.Solid = true;
            series3.Legend.Brush.Visible = true;
            // 
            // 
            // 
            series3.Legend.Font.Bold = false;
            // 
            // 
            // 
            series3.Legend.Font.Brush.Color = Color.Black;
            series3.Legend.Font.Brush.Solid = true;
            series3.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series3.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            series3.Legend.Font.Shadow.Brush.Solid = true;
            series3.Legend.Font.Shadow.Brush.Visible = true;
            series3.Legend.Font.Size = 8;
            series3.Legend.Font.SizeFloat = 8F;
            series3.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            series3.Legend.ImageBevel.Brush.Color = Color.LightGray;
            series3.Legend.ImageBevel.Brush.Solid = true;
            series3.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series3.Legend.Shadow.Brush.Color = Color.DarkGray;
            series3.Legend.Shadow.Brush.Solid = true;
            series3.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            series3.LinePen.Style = Steema.TeeChart.Drawing.DashStyle.Dash;
            // 
            // 
            // 
            // 
            // 
            // 
            series3.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            series3.Marks.Brush.Solid = true;
            series3.Marks.Brush.Visible = true;
            // 
            // 
            // 
            series3.Marks.Font.Bold = false;
            // 
            // 
            // 
            series3.Marks.Font.Brush.Color = Color.Black;
            series3.Marks.Font.Brush.Solid = true;
            series3.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series3.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            series3.Marks.Font.Shadow.Brush.Solid = true;
            series3.Marks.Font.Shadow.Brush.Visible = true;
            series3.Marks.Font.Size = 8;
            series3.Marks.Font.SizeFloat = 8F;
            series3.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            series3.Marks.ImageBevel.Brush.Color = Color.LightGray;
            series3.Marks.ImageBevel.Brush.Solid = true;
            series3.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series3.Marks.Shadow.Brush.Color = Color.Gray;
            series3.Marks.Shadow.Brush.Solid = true;
            series3.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series3.Marks.Symbol.Brush.Color = Color.White;
            series3.Marks.Symbol.Brush.Solid = true;
            series3.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series3.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            series3.Marks.Symbol.ImageBevel.Brush.Solid = true;
            series3.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series3.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            series3.Marks.Symbol.Shadow.Brush.Solid = true;
            series3.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series3.Pointer.Brush.Color = Color.Black;
            series3.Pointer.Brush.Solid = true;
            series3.Pointer.Brush.Visible = true;
            series3.Title = "YCalc + Delta";
            // 
            // 
            // 
            series3.XValues.DataMember = "X";
            series3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            series3.XValues.Value = new double[]
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
            series3.YValues.DataMember = "Y";
            series3.YValues.Value = new double[]
    {
    140D,
    123D,
    153D,
    183D,
    203D,
    252D,
    245D,
    227D,
    201D,
    246D,
    277D,
    299D,
    256D,
    290D,
    252D,
    265D,
    273D,
    258D,
    236D,
    267D,
    263D,
    238D,
    217D,
    234D,
    239D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // series4
            // 
            // 
            // 
            // 
            series4.AreaBrush.Color = Color.White;
            series4.AreaBrush.Solid = true;
            series4.AreaBrush.Visible = false;
            // 
            // 
            // 
            series4.Brush.Color = Color.FromArgb(255, 127, 71);
            series4.Brush.Solid = true;
            series4.Brush.Visible = true;
            series4.Color = Color.FromArgb(255, 127, 71);
            series4.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            series4.Legend.Brush.Color = Color.White;
            series4.Legend.Brush.Solid = true;
            series4.Legend.Brush.Visible = true;
            // 
            // 
            // 
            series4.Legend.Font.Bold = false;
            // 
            // 
            // 
            series4.Legend.Font.Brush.Color = Color.Black;
            series4.Legend.Font.Brush.Solid = true;
            series4.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series4.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            series4.Legend.Font.Shadow.Brush.Solid = true;
            series4.Legend.Font.Shadow.Brush.Visible = true;
            series4.Legend.Font.Size = 8;
            series4.Legend.Font.SizeFloat = 8F;
            series4.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            series4.Legend.ImageBevel.Brush.Color = Color.LightGray;
            series4.Legend.ImageBevel.Brush.Solid = true;
            series4.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series4.Legend.Shadow.Brush.Color = Color.DarkGray;
            series4.Legend.Shadow.Brush.Solid = true;
            series4.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            series4.LinePen.Style = Steema.TeeChart.Drawing.DashStyle.Dash;
            // 
            // 
            // 
            // 
            // 
            // 
            series4.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            series4.Marks.Brush.Solid = true;
            series4.Marks.Brush.Visible = true;
            // 
            // 
            // 
            series4.Marks.Font.Bold = false;
            // 
            // 
            // 
            series4.Marks.Font.Brush.Color = Color.Black;
            series4.Marks.Font.Brush.Solid = true;
            series4.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series4.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            series4.Marks.Font.Shadow.Brush.Solid = true;
            series4.Marks.Font.Shadow.Brush.Visible = true;
            series4.Marks.Font.Size = 8;
            series4.Marks.Font.SizeFloat = 8F;
            series4.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            series4.Marks.ImageBevel.Brush.Color = Color.LightGray;
            series4.Marks.ImageBevel.Brush.Solid = true;
            series4.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series4.Marks.Shadow.Brush.Color = Color.Gray;
            series4.Marks.Shadow.Brush.Solid = true;
            series4.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series4.Marks.Symbol.Brush.Color = Color.White;
            series4.Marks.Symbol.Brush.Solid = true;
            series4.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series4.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            series4.Marks.Symbol.ImageBevel.Brush.Solid = true;
            series4.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series4.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            series4.Marks.Symbol.Shadow.Brush.Solid = true;
            series4.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            series4.Pointer.Brush.Color = Color.Black;
            series4.Pointer.Brush.Solid = true;
            series4.Pointer.Brush.Visible = true;
            series4.Title = "YCalc - Delta";
            // 
            // 
            // 
            series4.XValues.DataMember = "X";
            series4.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            series4.XValues.Value = new double[]
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
            series4.YValues.DataMember = "Y";
            series4.YValues.Value = new double[]
    {
    336D,
    352D,
    389D,
    404D,
    383D,
    429D,
    430D,
    420D,
    443D,
    430D,
    442D,
    485D,
    492D,
    484D,
    532D,
    527D,
    545D,
    564D,
    530D,
    498D,
    461D,
    478D,
    501D,
    523D,
    475D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // label1
            // 
            label1.Location = new Point(4, 39);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 1;
            label1.Text = "Polynomial order";
            // 
            // label2
            // 
            label2.Location = new Point(55, 74);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "Factor";
            // 
            // labelTimeNeeded
            // 
            labelTimeNeeded.Location = new Point(192, 10);
            labelTimeNeeded.Name = "labelTimeNeeded";
            labelTimeNeeded.Size = new Size(240, 20);
            labelTimeNeeded.TabIndex = 5;
            labelTimeNeeded.Text = "Time needed :";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(230, 49);
            button1.Name = "button1";
            button1.Size = new Size(77, 30);
            button1.TabIndex = 6;
            button1.Text = "Fit";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(317, 49);
            button2.Name = "button2";
            button2.Size = new Size(125, 29);
            button2.TabIndex = 7;
            button2.Text = "View coefficients";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.FlatStyle = FlatStyle.System;
            button3.Location = new Point(451, 49);
            button3.Name = "button3";
            button3.Size = new Size(90, 29);
            button3.TabIndex = 8;
            button3.Text = "Delta";
            button3.Click += button3_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(126, 37);
            numericUpDown1.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(62, 23);
            numericUpDown1.TabIndex = 10;
            numericUpDown1.Value = new decimal(new int[] { 6, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(126, 69);
            numericUpDown2.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(62, 23);
            numericUpDown2.TabIndex = 11;
            numericUpDown2.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // QRPolyForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(979, 568);
            Name = "QRPolyForm";
            Load += QRPoly_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((ISupportInitialize)numericUpDown1).EndInit();
            ((ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);

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

