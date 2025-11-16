using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Units;
using Dew.Math.Tee;

namespace MtxVecDemo
{
    public class MtxFastlineDemo : BasicForm2
    {
        MtxFastLine mtxfl;
        Steema.TeeChart.Styles.FastLine fl;
        private Button buttonCompare;
        private Panel panel4;
        private NumericUpDown numericUpDown1;
        private Label label1;
        Vector data;
        
        public MtxFastlineDemo()
        {
            InitializeComponent();
            tChart1.Series.Clear();
            tChart2.Series.Clear();

            tChart1.Series.Add(mtxfl = new MtxFastLine());
            mtxfl.Chart = tChart1.Chart;
            mtxfl.PixelDownSample = true;

            tChart2.Series.Add(fl = new Steema.TeeChart.Styles.FastLine());
            fl.Chart = tChart2.Chart;

            data = new Vector();
        }

        private SplitContainer splitContainer1;
        private Steema.TeeChart.TChart tChart1;
        private Splitter splitter1;
        private Steema.TeeChart.TChart tChart2;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
            Steema.TeeChart.Margins margins2 = new Steema.TeeChart.Margins();
            splitContainer1 = new SplitContainer();
            panel4 = new Panel();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            buttonCompare = new Button();
            tChart2 = new Steema.TeeChart.TChart();
            splitter1 = new Splitter();
            tChart1 = new Steema.TeeChart.TChart();
            panel2.SuspendLayout();
            ((ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel4.SuspendLayout();
            ((ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(splitContainer1);
            panel2.Size = new Size(1079, 446);
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 584);
            panel3.Size = new Size(1079, 48);
            // 
            // richTextBox1
            // 
            richTextBox1.Size = new Size(1079, 138);
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tChart2);
            splitContainer1.Panel2.Controls.Add(splitter1);
            splitContainer1.Panel2.Controls.Add(tChart1);
            splitContainer1.Panel2.Resize += splitContainer1_Panel2_Resize;
            splitContainer1.Size = new Size(1079, 446);
            splitContainer1.SplitterDistance = 317;
            splitContainer1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(numericUpDown1);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(buttonCompare);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(317, 73);
            panel4.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 50000, 0, 0, 0 });
            numericUpDown1.Location = new Point(83, 22);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(73, 23);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 6);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "Sample size";
            // 
            // buttonCompare
            // 
            buttonCompare.Location = new Point(3, 6);
            buttonCompare.Name = "buttonCompare";
            buttonCompare.Size = new Size(66, 23);
            buttonCompare.TabIndex = 0;
            buttonCompare.Text = "Populate";
            buttonCompare.UseVisualStyleBackColor = true;
            buttonCompare.Click += buttonCompare_Click;
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
            tChart2.Axes.Bottom.Grid.Style = Steema.TeeChart.Drawing.DashStyle.Dash;
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
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Axes.Depth.Grid.Style = Steema.TeeChart.Drawing.DashStyle.Dash;
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
            tChart2.Axes.DepthTop.Grid.Style = Steema.TeeChart.Drawing.DashStyle.Dash;
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
            tChart2.Axes.Left.Grid.Style = Steema.TeeChart.Drawing.DashStyle.Dash;
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
            tChart2.Axes.Right.Grid.Style = Steema.TeeChart.Drawing.DashStyle.Dash;
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
            tChart2.Axes.Top.Grid.Style = Steema.TeeChart.Drawing.DashStyle.Dash;
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
            tChart2.Header.Lines = new string[]
    {
    "Fastline"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            tChart2.Header.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            tChart2.Header.Shadow.Brush.Solid = true;
            tChart2.Header.Shadow.Brush.Visible = true;
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
            tChart2.Location = new Point(0, 129);
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
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            tChart2.Printer.Margins = margins1;
            tChart2.Size = new Size(758, 317);
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
            tChart2.TabIndex = 2;
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
            tChart2.Zoom.Animated = true;
            // 
            // 
            // 
            tChart2.Zoom.Brush.Color = Color.FromArgb(127, 0, 0, 255);
            tChart2.Zoom.Brush.Solid = true;
            tChart2.Zoom.Brush.Visible = true;
            tChart2.Scroll += tChart2_Scroll;
            tChart2.Zoomed += tChart2_Zoomed;
            tChart2.UndoneZoom += tChart2_UndoneZoom;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 126);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(758, 3);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
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
            tChart1.Axes.Bottom.Grid.Style = Steema.TeeChart.Drawing.DashStyle.Dash;
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
            tChart1.Axes.Depth.Grid.Style = Steema.TeeChart.Drawing.DashStyle.Dash;
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
            tChart1.Axes.DepthTop.Grid.Style = Steema.TeeChart.Drawing.DashStyle.Dash;
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
            tChart1.Axes.Left.Grid.Style = Steema.TeeChart.Drawing.DashStyle.Dash;
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
            tChart1.Axes.Right.Grid.Style = Steema.TeeChart.Drawing.DashStyle.Dash;
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
            tChart1.Axes.Top.Grid.Style = Steema.TeeChart.Drawing.DashStyle.Dash;
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
            tChart1.Dock = DockStyle.Top;
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
    "MtxFastline"
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
            tChart1.Legend.Visible = false;
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
            tChart1.Panel.ImageBevel.Width = 1;
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
            margins2.Bottom = 100;
            margins2.Left = 100;
            margins2.Right = 100;
            margins2.Top = 100;
            tChart1.Printer.Margins = margins2;
            tChart1.Size = new Size(758, 126);
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
            tChart1.TabIndex = 0;
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
            tChart1.Zoom.Animated = true;
            // 
            // 
            // 
            tChart1.Zoom.Brush.Color = Color.FromArgb(127, 0, 0, 255);
            tChart1.Zoom.Brush.Solid = true;
            tChart1.Zoom.Brush.Visible = true;
            // 
            // MtxFastlineDemo
            // 
            ClientSize = new Size(1079, 632);
            Name = "MtxFastlineDemo";
            Load += MtxFastlineDemo_Load;
            panel2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private void splitContainer1_Panel2_Resize(object sender, EventArgs e)
        {
            tChart1.Height = tChart1.Parent.Height / 2 - 5;
        }

        private void MtxFastlineDemo_Load(object sender, EventArgs e)
        {

            Add("New Dew.Math.Tee.MMtxFastLine draws many times faster than Steema.TeeChart.Styles.FastLine."
                + " It allows zoom-in and zoom-out with pixeldownsamle enabled. MtxFastLine can be used"
                + " with all TeeChart versions. Further optimization is applied, if X axis has equidistantly spaced samples.\n");
            Add("First press on the \"Populate\" button, then try different data sizes and zooming/panning bottom chart."
                + "Zoom by drawing a rectangle, zoom-out by drawing up and left, pan by dragging with right mouse button.");
        }

        private void Recreate()
        {
            data.Size((int)numericUpDown1.Value);
            data.RandGauss(5, 3.2);

            tChart1.Series[0].GetHorizAxis.Automatic = false;
            tChart1.Series[0].GetHorizAxis.SetMinMax(0, data.Length - 1);
            tChart2.Series[0].GetHorizAxis.Automatic = false;
            tChart2.Series[0].GetHorizAxis.SetMinMax(0, data.Length - 1);
            tChart1.Zoom.Animated = true;
            tChart2.Zoom.Animated = true;

            Math387.StartTimer();
            MtxVecTee.DrawValues(data, tChart1.Series[0], 0, 1, false);
            double timeElapsed = Math387.StopTimer()*1000;
            tChart1.Header.Text = "MtxFastLine\nDrawing " + data.Length.ToString() + " points:" + timeElapsed.ToString("0.0") + " ms\n";

            Math387.StartTimer();
            MtxVecTee.DrawValues(data, tChart2.Series[0], 0, 1, false);
            timeElapsed = Math387.StopTimer() * 1000;
            tChart2.Header.Text = "FastLine\nDrawing " + data.Length.ToString() + " points:" + timeElapsed.ToString("0.0") + " ms\n";
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            Recreate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tChart1.Series[0].GetHorizAxis.Automatic = false;
            tChart1.Series[0].GetHorizAxis.SetMinMax(0, data.Length - 1);
            tChart1.Series[0].GetVertAxis.Automatic = true;
            tChart1.Zoom.Animated = true;
            
            tChart2.Series[0].GetHorizAxis.Automatic = false;
            tChart2.Series[0].GetHorizAxis.SetMinMax(0, data.Length - 1);
            tChart2.Series[0].GetVertAxis.Automatic = true;
            tChart2.Zoom.Animated = true;            
        }

        private void tChart2_UndoneZoom(object sender, EventArgs e)
        {
       //     tChart1.Series[0].GetVertAxis.Automatic = true;
       //     tChart1.Series[0].GetHorizAxis.SetMinMax(tChart2.Series[0].GetHorizAxis.Minimum, tChart2.Series[0].GetHorizAxis.Maximum);
       //     button1.Enabled = false;
        }

        private void tChart2_Zoomed(object sender, EventArgs e)
        {
       //     tChart1.Series[0].GetHorizAxis.SetMinMax(tChart2.Series[0].GetHorizAxis.Minimum, tChart2.Series[0].GetHorizAxis.Maximum);
       //     tChart1.Series[0].GetVertAxis.SetMinMax(tChart2.Series[0].GetVertAxis.Minimum, tChart2.Series[0].GetVertAxis.Maximum);
       //     button1.Enabled = true;
        }

        private void tChart2_Scroll(object sender, EventArgs e)
        {
        //    tChart1.Series[0].GetHorizAxis.SetMinMax(tChart2.Series[0].GetHorizAxis.Minimum, tChart2.Series[0].GetHorizAxis.Maximum);
        //    tChart1.Series[0].GetVertAxis.SetMinMax(tChart2.Series[0].GetVertAxis.Minimum, tChart2.Series[0].GetVertAxis.Maximum);
        //    button1.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Recreate();
        }
    }
}