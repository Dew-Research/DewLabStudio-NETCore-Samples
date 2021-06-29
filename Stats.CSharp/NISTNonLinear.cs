using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Units;
using Dew.Math.Tee;

namespace StatsMasterDemo
{
    public class NISTNonLinear : StatsMasterDemo.BasicForm1
    {
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
            this.components = new System.ComponentModel.Container();
            Steema.TeeChart.Drawing.Cursor cursor2 = new Steema.TeeChart.Drawing.Cursor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NISTNonLinear));
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tMtxNonLinReg1 = new Dew.Stats.TMtxNonLinReg(this.components);
            this.points1 = new Steema.TeeChart.Styles.Points();
            this.line1 = new Steema.TeeChart.Styles.Line();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(756, 79);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(756, 79);
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
            this.tChart1.Header.Lines = new string[] {
        "Non-linear regression"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChart1.Header.Shadow.Brush.Solid = true;
            this.tChart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
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
            this.tChart1.Location = new System.Drawing.Point(282, 248);
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
            this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
            this.tChart1.Panel.Brush.Gradient.Visible = true;
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
            this.tChart1.Panel.ImageBevel.Width = 1;
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
            this.tChart1.Series.Add(this.points1);
            this.tChart1.Series.Add(this.line1);
            this.tChart1.Size = new System.Drawing.Size(462, 312);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Regression test";
            // 
            // listBox1
            // 
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Eckerle4 (high difficulty)",
            "Thurber (high difficulty)",
            "Rat42 (average difficulty)",
            "Misra1c (average difficulty)",
            "MGH09 (high difficulty)",
            "Chwirut2 (low difficulty)",
            "MGH10 (high difficulty)",
            "Roszman1(average difficulty)",
            "Rat43 (high difficulty)"});
            this.listBox1.Location = new System.Drawing.Point(15, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 49);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Optimization method";
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "Simplex",
            "Marquardt",
            "Quasi-Newton (BFGS)",
            "Quasi-Newton (DFP)",
            "Conjugate Grad (Fletcher)",
            "Conjugate Grad (Polak)"});
            this.comboBox1.Location = new System.Drawing.Point(15, 186);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 23);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Maximum number of iterations";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(15, 235);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 23);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(15, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 96);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional settings";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(66, 23);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "1E-5";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 23);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "1E-6";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "2E-8";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Numerical grad step size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Convergence tolerance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "||Grad||C tolerance";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(15, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calculate";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox2.Location = new System.Drawing.Point(282, 85);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox2.Size = new System.Drawing.Size(462, 162);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "";
            // 
            // tMtxNonLinReg1
            // 
            this.tMtxNonLinReg1.BlockAssign = false;
            this.tMtxNonLinReg1.DeriveProcedure = null;
            this.tMtxNonLinReg1.Dirty = true;
            this.tMtxNonLinReg1.GradTolerance = 2E-08D;
            this.tMtxNonLinReg1.MaxIteration = 1500;
            this.tMtxNonLinReg1.Name = "";
            this.tMtxNonLinReg1.RegressFunction = null;
            this.tMtxNonLinReg1.Tolerance = 1E-06D;
            this.tMtxNonLinReg1.Verbose = null;
            // 
            // points1
            // 
            // 
            // 
            // 
            this.points1.Brush.Color = System.Drawing.Color.Empty;
            this.points1.Brush.Solid = true;
            this.points1.Brush.Visible = true;
            this.points1.Color = System.Drawing.Color.Red;
            this.points1.ColorEach = false;
            cursor2.CursorType = Steema.TeeChart.Drawing.CursorType.Default;
            this.points1.Cursor = cursor2;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Legend.Brush.Color = System.Drawing.Color.White;
            this.points1.Legend.Brush.Solid = true;
            this.points1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.points1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.points1.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.points1.Legend.Font.Brush.Solid = true;
            this.points1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.points1.Legend.Font.Shadow.Brush.Solid = true;
            this.points1.Legend.Font.Shadow.Brush.Visible = true;
            this.points1.Legend.Font.Size = 8;
            this.points1.Legend.Font.SizeFloat = 8F;
            this.points1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.points1.Legend.ImageBevel.Brush.Solid = true;
            this.points1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.points1.Legend.Shadow.Brush.Solid = true;
            this.points1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.points1.Marks.Brush.Solid = true;
            this.points1.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.points1.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.points1.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.points1.Marks.Font.Brush.Solid = true;
            this.points1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.points1.Marks.Font.Shadow.Brush.Solid = true;
            this.points1.Marks.Font.Shadow.Brush.Visible = true;
            this.points1.Marks.Font.Size = 8;
            this.points1.Marks.Font.SizeFloat = 8F;
            this.points1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.points1.Marks.ImageBevel.Brush.Solid = true;
            this.points1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.points1.Marks.Shadow.Brush.Solid = true;
            this.points1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.points1.Marks.Symbol.Brush.Solid = true;
            this.points1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.points1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.points1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.points1.Marks.Symbol.Shadow.Brush.Solid = true;
            this.points1.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.points1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
            this.points1.Marks.TailParams.Margin = 0F;
            this.points1.Marks.TailParams.PointerHeight = 8D;
            this.points1.Marks.TailParams.PointerWidth = 8D;
            this.points1.OriginalCursor = cursor2;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Pointer.Brush.Color = System.Drawing.Color.Red;
            this.points1.Pointer.Brush.Solid = true;
            this.points1.Pointer.Brush.Visible = true;
            this.points1.Pointer.HorizSize = 3;
            // 
            // 
            // 
            this.points1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.points1.Pointer.SizeDouble = 0D;
            this.points1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.points1.Pointer.VertSize = 3;
            this.points1.RandomData = true;
            this.points1.Title = "Data";
            this.points1.Type = "Steema.TeeChart.Styles.Points";
            this.points1.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.points1.XValues.DataMember = "X";
            this.points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.points1.XValues.Series = this.points1;
            // 
            // 
            // 
            this.points1.YValues.DataMember = "Y";
            this.points1.YValues.Series = this.points1;
            // 
            // line1
            // 
            // 
            // 
            // 
            this.line1.AreaBrush.Color = System.Drawing.Color.White;
            this.line1.AreaBrush.Solid = true;
            this.line1.AreaBrush.Visible = false;
            // 
            // 
            // 
            this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.line1.Brush.Solid = true;
            this.line1.Brush.Visible = true;
            this.line1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.line1.ColorEach = false;
            this.line1.Cursor = cursor2;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Legend.Brush.Color = System.Drawing.Color.White;
            this.line1.Legend.Brush.Solid = true;
            this.line1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.line1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.line1.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.line1.Legend.Font.Brush.Solid = true;
            this.line1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line1.Legend.Font.Shadow.Brush.Solid = true;
            this.line1.Legend.Font.Shadow.Brush.Visible = true;
            this.line1.Legend.Font.Size = 8;
            this.line1.Legend.Font.SizeFloat = 8F;
            this.line1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.line1.Legend.ImageBevel.Brush.Solid = true;
            this.line1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line1.Legend.Shadow.Brush.Solid = true;
            this.line1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line1.Marks.Brush.Solid = true;
            this.line1.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.line1.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.line1.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.line1.Marks.Font.Brush.Solid = true;
            this.line1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line1.Marks.Font.Shadow.Brush.Solid = true;
            this.line1.Marks.Font.Shadow.Brush.Visible = true;
            this.line1.Marks.Font.Size = 8;
            this.line1.Marks.Font.SizeFloat = 8F;
            this.line1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.line1.Marks.ImageBevel.Brush.Solid = true;
            this.line1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.line1.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.line1.Marks.Shadow.Brush.Solid = true;
            this.line1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.line1.Marks.Symbol.Brush.Solid = true;
            this.line1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.line1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.line1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line1.Marks.Symbol.Shadow.Brush.Solid = true;
            this.line1.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.line1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
            this.line1.Marks.TailParams.Margin = 0F;
            this.line1.Marks.TailParams.PointerHeight = 8D;
            this.line1.Marks.TailParams.PointerWidth = 8D;
            this.line1.OriginalCursor = cursor2;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Pointer.Brush.Color = System.Drawing.Color.Green;
            this.line1.Pointer.Brush.Solid = true;
            this.line1.Pointer.Brush.Visible = true;
            this.line1.Pointer.SizeDouble = 0D;
            this.line1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.line1.RandomData = true;
            this.line1.Title = "Fitted";
            this.line1.Type = "Steema.TeeChart.Styles.Line";
            this.line1.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.line1.XValues.DataMember = "X";
            this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.line1.XValues.Series = this.line1;
            // 
            // 
            // 
            this.line1.YValues.DataMember = "Y";
            this.line1.YValues.Series = this.line1;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox3.Location = new System.Drawing.Point(15, 405);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(261, 155);
            this.richTextBox3.TabIndex = 13;
            this.richTextBox3.Text = "";
            this.richTextBox3.WordWrap = false;
            // 
            // NISTNonLinear
            // 
            this.ClientSize = new System.Drawing.Size(756, 572);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Name = "NISTNonLinear";
            this.Load += new System.EventHandler(this.NISTNonLinear_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.tChart1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.numericUpDown1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.richTextBox2, 0);
            this.Controls.SetChildIndex(this.richTextBox3, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private Dew.Stats.TMtxNonLinReg tMtxNonLinReg1;
        private Steema.TeeChart.Styles.Points points1;
        private Steema.TeeChart.Styles.Line line1;
        private System.Windows.Forms.RichTextBox richTextBox3;

        
        public NISTNonLinear()
        {
            InitializeComponent();
        }

        // all non-linear functions in the examples listed below
        double Eckerle(TVec B, double x)
        {
            return B[0] / B[1] * Math.Exp(-0.5 * Math387.IntPower((x - B[2]) / B[1], 2));
        }
        double Thurber(TVec B, double x)
        {
            return (B[0] + B[1]*x +B[2]*x*x +B[3]*Math387.IntPower(x,3))/
                (1.0 + B[4]*x + B[5]*x*x + B[6]*Math387.IntPower(x,3));
        }
        double Rat42(TVec B, double x)
        {
            return B[0] / (1.0 + Math.Exp(B[1] - B[2] * x));
        }
        double Rat43(TVec B, double x)
        {
            return B[0] / Math387.Power((1.0 + Math.Exp(B[1] - B[2] * x)), 1.0 / B[3]);
        }
        double Misra1c(TVec B, double x)
        {
            return B[0]*(1.0-Math387.Power(1+2*B[1]*x,-0.5));
        }
        double MGH09(TVec B, double x)
        {
            return B[0]*(x*x + x*B[1])/(x*x + x*B[2]+B[3]);
        }
        double Chwirut2(TVec B, double x)
        {
            return Math.Exp(-B[0]*x)/(B[1]+B[2]*x);
        }
        double MGH10(TVec B, double x)
        {
            return B[0]*Math.Exp(B[1]/(x+B[2]));
        }
        double Roszman1(TVec B, double x)
        {
            return B[0] - B[1] * x - Math.Atan(B[2] / (x - B[3])) / Math387.PI;
        }

        private void NISTNonLinear_Load(object sender, EventArgs e)
        {
            Add("NIST non-linear regression tests:\n");
            Add("Eckerle4: These data are the result of a NIST study involving circular interference "
                + "transmittance. The response variable is transmittance, and the predictor variable "
                + "is wavelength (Higher level of difficulty).\n");
            Add("Thurber: These data are the result of a NIST study involving semiconductor electron "
                + "mobility. The response variable is a measure of electron mobility, and the "
                + "predictor variable is the natural log of the density (Higher level of diffuculty).\n");
            Add("Rat42: This model and data are an example of fitting sigmoidal growth curves taken "
                + "from Ratkowsky (1983). The response variable is pasture yield, and the predictor "
                + "variable is growing time (Average level of difficulty).\n");
            Add("Misra1C: These data are the result of a NIST study regarding dental research in "
                + "monomolecular adsorption. The response variable is volume, and the predictor "
                + "variable is pressure (Average level of difficulty).\n");
            Add("MHG09: This problem was found to be difficult for some very good algorithms. There "
                + "is a local minimum at (+inf,-14.07..., -inf, -inf) with final sum of squares "
                + "0.00102734... (Higher level of difficulty).\n");
            Add("Chiwrut2: These data are the result of a NIST study involving ultrasonic calibration. "
                + "The response variable is ultrasonic response, and the predictor variable is metal distance.\n");
            Add("MHG10: This problem was found to be difficult for some very good algorithms.\n");
            Add("Roszman1: These data are the result of a NIST study involving quantum defects in iodine "
                + "atoms. The response variable is the number of quantum defects, and the predictor "
                + "variable is the excited energy state.\n");
            
            listBox1.SelectedIndex = 1; // Thurber
            comboBox1.SelectedIndex = 1; // Marquardt method
        }

        // display info associated with specific test
        private void DisplayInfo(int index)
        {
            richTextBox2.Clear();
            switch (index)
            {
                case 0: // Eckerle42
                    {
                        richTextBox2.Text="Description:\n";
                        richTextBox2.Text += "These data are the result of a NIST study involving circular interference "
                            + "transmittance. The response variable is transmittance, and the predictor variable is "
                            + "wavelength.\n\n";
                        richTextBox2.Text += "Data:\n";
                        richTextBox2.Text += "\t 1 Response Variable  (y = transmittance)\n";
                        richTextBox2.Text += "\t 1 Predictor Variable (x = wavelength)\n";
                        richTextBox2.Text += "\t 35 Observations\n";
                        richTextBox2.Text += "\t Higher Level of Difficulty\n\n";
                        richTextBox2.Text += "Model:\n";
                        richTextBox2.Text += "\t Exponential class\n";
                        richTextBox2.Text += "\t 3 Parameters (b[0] to b[2])\n";
                        richTextBox2.Text += "\t Y = B[0]/B[1] * Exp(-0.5*Sqr((X-B[2])/B[1]))\n\n";
                        richTextBox2.Text += "Certified values:\n";
                        richTextBox2.Text += "\t b[0] = 1.5543827178\n";
                        richTextBox2.Text += "\t b[1] = 4.0888321754\n";
                        richTextBox2.Text += "\t b[2] = 451.54121844\n";

                    }; break;
                case 1: // 
                    {
                        richTextBox2.Text = "Description:\n";
                        richTextBox2.Text += "hese data are the result of a NIST study involving semiconductor "
                            + "electron mobility.  The response variable is a measure of electron mobility, "
                            + "and the predictor variable is the natural log of the density.\n\n";
                        richTextBox2.Text += "Data:\n";
                        richTextBox2.Text += "\t 1 Response Variable  (y = electron mobility)\n";
                        richTextBox2.Text += "\t 1 Predictor Variable (x = ln[density])\n";
                        richTextBox2.Text += "\t 37 Observations\n";
                        richTextBox2.Text += "\t Higher Level of Difficulty\n\n";
                        richTextBox2.Text += "Model:\n";
                        richTextBox2.Text += "\t Rational Class (cubic/cubic)\n";
                        richTextBox2.Text += "\t 7 Parameters (b[0] to b[6])\n";
                        richTextBox2.Text += "\t Y = (B[0] + B[1]*X + B[2]*Sqr(X) + B[3]*IntPower(X,3)) /\n";
                        richTextBox2.Text += "\t    (1.0 + B[4]*X + B[5]*Sqr(X) + B[6]*IntPower(X,3))\n\n";
                        richTextBox2.Text += "Certified values:\n";
                        richTextBox2.Text += "\t b[0] = 1288.1396800\n";
                        richTextBox2.Text += "\t b[1] = 1491.0792535\n";
                        richTextBox2.Text += "\t b[2] = 583.23836877\n";
                        richTextBox2.Text += "\t b[3] = 75.416644291\n";
                        richTextBox2.Text += "\t b[4] = 0.96629502864\n";
                        richTextBox2.Text += "\t b[5] = 0.39797285797\n";
                        richTextBox2.Text += "\t b[6] = 0.049727297349\n";
                    }; break;
                case 2: // 
                    {
                        richTextBox2.Text = "Description:\n";
                        richTextBox2.Text += "This model and data are an example of fitting sigmoidal growth curves taken from Ratkowsky (1983)."
                            + "The response variable is pasture yield, and the predictor variable is growing time.\n\n";
                        richTextBox2.Text += "Data:\n";
                        richTextBox2.Text += "\t 1 Response Variable  (y = pasture yield)\n";
                        richTextBox2.Text += "\t 1 Predictor Variable (x = growing time)\n";
                        richTextBox2.Text += "\t 9 Observations\n";
                        richTextBox2.Text += "\t Higher Level of Difficulty\n\n";
                        richTextBox2.Text += "Model:\n";
                        richTextBox2.Text += "\t Rational Class (cubic/cubic)\n";
                        richTextBox2.Text += "\t 3 Parameters (b[0] to b[2])\n";
                        richTextBox2.Text += "\t Y = B[0] / (1.0 + Exp(B[1]-B[2]*X))\n\n";
                        richTextBox2.Text += "Certified values:\n";
                        richTextBox2.Text += "\t b[0] = 72.462237576\n";
                        richTextBox2.Text += "\t b[1] = 2.6180768402\n";
                        richTextBox2.Text += "\t b[2] = 0.067359200066\n";
                    }; break;
                case 3: // 
                    {
                        richTextBox2.Text = "Description:\n";
                        richTextBox2.Text += "These data are the result of a NIST study regarding dental research in monomolecular adsorption. "
                            + "The response variable is volume, and the predictor variable is pressure\n\n";
                        richTextBox2.Text += "Data:\n";
                        richTextBox2.Text += "\t 1 Response Variable  (y = volume)\n";
                        richTextBox2.Text += "\t 1 Predictor Variable (x = pressure)\n";
                        richTextBox2.Text += "\t 14 Observations\n";
                        richTextBox2.Text += "\t Average Level of Difficulty\n\n";
                        richTextBox2.Text += "Model:\n";
                        richTextBox2.Text += "\t Miscellaneous Class\n";
                        richTextBox2.Text += "\t 2 Parameters (b[0] and b[1])\n";
                        richTextBox2.Text += "\t Y = B[0]*(1-Power(1+2*B[1]*X,-0.5))\n\n";
                        richTextBox2.Text += "Certified values:\n";
                        richTextBox2.Text += "\t b[0] = 636.42725809\n";
                        richTextBox2.Text += "\t b[1] = 0.00020813627256\n";
                    }; break;
                case 4: // 
                    {
                        richTextBox2.Text = "Description:\n";
                        richTextBox2.Text += "This problem was found to be difficult for some very good algorithms. There "
                            + "is a local minimum at (+inf,-14.07..., -inf, -inf) with final sum of squares 0.00102734....\n\n";
                        richTextBox2.Text += "Data:\n";
                        richTextBox2.Text += "\t 1 Response Variable  (y)\n";
                        richTextBox2.Text += "\t 1 Predictor Variable (x)\n";
                        richTextBox2.Text += "\t 11 Observations\n";
                        richTextBox2.Text += "\t Generated data\n";
                        richTextBox2.Text += "\t Higher Level of Difficulty\n\n";
                        richTextBox2.Text += "Model:\n";
                        richTextBox2.Text += "\t Rational Class (linear/quadratic)\n";
                        richTextBox2.Text += "\t 4 Parameters (b[0] to b[3])\n";
                        richTextBox2.Text += "\t Y = B[0]*(Sqr(X) + X*B[1]) / (Sqr(X) + X*B[2]+B[3])\n\n";
                        richTextBox2.Text += "Certified values:\n";
                        richTextBox2.Text += "\t b[0] = 0.19280693458\n";
                        richTextBox2.Text += "\t b[1] = 0.19128232873\n";
                        richTextBox2.Text += "\t b[2] = 0.12305650693\n";
                        richTextBox2.Text += "\t b[3] = 0.13606233068\n";
                    }; break;
                case 5: // 
                    {
                        richTextBox2.Text = "Description:\n";
                        richTextBox2.Text += "These data are the result of a NIST study involving ultrasonic calibration. "
                            + "The response variable is ultrasonic response, and the predictor variable is metal distance.\n\n";
                        richTextBox2.Text += "Data:\n";
                        richTextBox2.Text += "\t 1 Response Variable  (y = ultrasonic response)\n";
                        richTextBox2.Text += "\t 1 Predictor Variable (x = metal distance)\n";
                        richTextBox2.Text += "\t 54 Observations, Observed Data\n";
                        richTextBox2.Text += "\t Lower Level of Difficulty\n\n";
                        richTextBox2.Text += "Model:\n";
                        richTextBox2.Text += "\t Exponential Class\n";
                        richTextBox2.Text += "\t 3 Parameters (b[0] to b[2])\n";
                        richTextBox2.Text += "\t Y = Exp(-B[0]*X)/(B[1]) + X*B[2])\n\n";
                        richTextBox2.Text += "Certified values:\n";
                        richTextBox2.Text += "\t b[0] = 0.16657666537\n";
                        richTextBox2.Text += "\t b[1] = 0.0051653291286\n";
                        richTextBox2.Text += "\t b[2] = 0.012150007096\n";
                    }; break;
                case 6: // 
                    {
                        richTextBox2.Text = "Description:\n";
                        richTextBox2.Text += "This problem was found to be difficult for some very good algorithms.\n\n";
                        richTextBox2.Text += "Data:\n";
                        richTextBox2.Text += "\t 1 Response Variable  (y)\n";
                        richTextBox2.Text += "\t 1 Predictor Variable (x)\n";
                        richTextBox2.Text += "\t 16 Observations, Generated Data\n";
                        richTextBox2.Text += "\t Higher Level of Difficulty\n\n";
                        richTextBox2.Text += "Model:\n";
                        richTextBox2.Text += "\t Exponential Class\n";
                        richTextBox2.Text += "\t 3 Parameters (b[0] to b[2])\n";
                        richTextBox2.Text += "\t Y = B[0]*Exp(B[1]/(B[2]+X))\n\n";
                        richTextBox2.Text += "Certified values:\n";
                        richTextBox2.Text += "\t b[0] = 0.0056096364710\n";
                        richTextBox2.Text += "\t b[1] = 6181.3463463\n";
                        richTextBox2.Text += "\t b[2] = 345.22363462\n";
                    }; break;
                case 7: // 
                    {
                        richTextBox2.Text = "Description:\n";
                        richTextBox2.Text += "These data are the result of a NIST study involving quantum defects "
                            + "in iodine atoms. The response variable is the number of quantum defects, and the "
                            + "predictor variable is the excited energy state. The argument to the ArcTan" 
                            + "function is in radians.\n\n";
                        richTextBox2.Text += "Data:\n";
                        richTextBox2.Text += "\t 1 Response  (y = quantum defect)\n";
                        richTextBox2.Text += "\t 1 Predictor (x = excited state energy)\n";
                        richTextBox2.Text += "\t 25 Observations, Observed data\n";
                        richTextBox2.Text += "\t Average Level of Difficulty\n\n";
                        richTextBox2.Text += "Model:\n";
                        richTextBox2.Text += "\t Miscellaneous Class\n";
                        richTextBox2.Text += "\t 4 Parameters (b[0] to b[3])\n";
                        richTextBox2.Text += "\t Y =  B[0]-B[1]*X - ArcTan(B[2]/(X-B[3]))/PI\n\n";
                        richTextBox2.Text += "Certified values:\n";
                        richTextBox2.Text += "\t b[0] = 0.20196866396\n";
                        richTextBox2.Text += "\t b[1] = -6.1953516256E-06\n";
                        richTextBox2.Text += "\t b[2] = 1204.4556708\n";
                        richTextBox2.Text += "\t b[3] = -181.34269537\n";
                    }; break;
                case 8: // 
                    {
                        richTextBox2.Text = "Description:\n";
                        richTextBox2.Text += "This model and data are an example of fitting "
                            + "sigmoidal growth curves taken from Ratkowsky (1983). The response variable is "
                            + "the dry weight of onion bulbs and tops, and the predictor variable is growing time.\n\n";
                        richTextBox2.Text += "Data:\n";
                        richTextBox2.Text += "\t 1 Response  (y = onion bulb dry weight)\n";
                        richTextBox2.Text += "\t 1 Predictor (x = growing time)\n";
                        richTextBox2.Text += "\t 15 Observations\n";
                        richTextBox2.Text += "\t Observed Data, Higher Level of Difficulty\n\n";
                        richTextBox2.Text += "Model:\n";
                        richTextBox2.Text += "\t Exponential Class\n";
                        richTextBox2.Text += "\t 4 Parameters (b[0] to b[3])\n";
                        richTextBox2.Text += "\t Y =  B[0] / Power((1.0 + Exp(B[1]-B[2]*X)),1/B[3])\n\n";
                        richTextBox2.Text += "Certified values:\n";
                        richTextBox2.Text += "\t b[0] = 699.6415127\n";
                        richTextBox2.Text += "\t b[1] = 5.2771253025\n";
                        richTextBox2.Text += "\t b[2] = 0.75962938329\n";
                        richTextBox2.Text += "\t b[3] = 1.2792483859\n";
                    }; break;     
            }
        }
        
        // Defines data for test, as defined at NIST
        private void FillData(int index)
        {
            switch (index)
            {
                case 0: // Eckerle
                    {
                        tMtxNonLinReg1.X.SetIt(new double[]{400.0, 405.0, 410.0, 415.0,
                            420.0, 425.0, 430.0, 435.0, 436.5, 438.0, 439.5, 441.0,
                            442.5, 444.0, 445.5, 447.0, 448.5, 450.0, 451.5, 453.0,
                            454.5, 456.0, 457.5, 459.0, 460.5, 462.0, 463.5, 465.0,
                            470.0, 475.0, 480.0, 485.0, 490.0, 495.0, 500.0});

                        tMtxNonLinReg1.Y.SetIt(new double[]{0.0001575, 0.0001699, 0.0002350, 0.0003102,
                            0.0004917, 0.0008710, 0.0017418, 0.0046400, 0.0065895, 0.0097302, 0.0149002, 0.0237310,
                            0.0401683, 0.0712559, 0.1264458, 0.2073413, 0.2902366, 0.3445623, 0.3698049, 0.3668534,
                            0.3106727, 0.2078154, 0.1164354, 0.0616764, 0.0337200, 0.0194023, 0.0117831, 0.0074357,
                            0.0022732, 0.0008800, 0.0004579, 0.0002345, 0.0001586, 0.0001143, 0.0000710});
                    }; break;
                case 1: // Thurber
                    {
                        tMtxNonLinReg1.X.SetIt(new double[]{-3.067, -2.981, -2.921, -2.912,
                                -2.840, -2.797, -2.702, -2.699, -2.633, -2.481, -2.363, -2.322,
                                -1.501, -1.460, -1.274, -1.212, -1.100, -1.046, -0.915, -0.714,
                                -0.566, -0.545, -0.400, -0.309, -0.109, -0.103, 0.010, 0.119,
                                0.377, 0.790, 0.963, 1.006, 1.115, 1.572, 1.841, 2.047, 2.200});
                        tMtxNonLinReg1.Y.SetIt(new double[]{80.574, 84.248, 87.264, 87.195,
                                89.076, 89.608, 89.868, 90.101, 92.405, 95.854, 100.696, 101.060,
                                401.672, 390.724, 567.534, 635.316, 733.054, 759.087, 894.206, 990.785,
                                1090.109, 1080.914, 1122.643, 1178.351, 1260.531, 1273.514, 1288.339, 
                                1327.543, 1353.863, 1414.509, 1425.208, 1421.384, 1442.962, 1464.350,
                                1468.705, 1447.894, 1457.628});
                    }; break;
                case 2: // Rat42
                    {
                        tMtxNonLinReg1.X.SetIt(new double[]{9.000, 14.000, 21.000, 28.000,
                                42.000, 57.000, 63.000, 70.000, 79.000});
                        tMtxNonLinReg1.Y.SetIt(new double[]{8.930, 10.800, 18.590, 22.330,
                                39.350, 56.110, 61.730, 64.620, 67.080});
                    }; break;
                case 3: // Misra1c
                    {
                        tMtxNonLinReg1.X.SetIt(new double[]{77.6, 114.9, 141.1, 190.8, 239.9,
                                289.0, 332.8, 378.4, 434.8, 477.3, 536.8, 593.1, 689.1, 760.0});
                        tMtxNonLinReg1.Y.SetIt(new double[]{10.07, 14.73, 17.94, 23.93, 29.61,
                                35.18, 40.02, 44.82, 50.76, 55.05, 61.01, 66.40, 75.47, 81.78});

                    }; break;
                case 4: // MGH09
                    {
                        tMtxNonLinReg1.X.SetIt(new double[]{4.000000E+00, 2.000000E+00, 1.000000E+00,
                                5.000000E-01, 2.500000E-01, 1.670000E-01, 1.250000E-01, 1.000000E-01, 
                                8.330000E-02, 7.140000E-02, 6.250000E-02});
                        tMtxNonLinReg1.Y.SetIt(new double[]{1.957000E-01, 1.947000E-01, 1.735000E-01,
                                1.600000E-01, 8.440000E-02, 6.270000E-02, 4.560000E-02, 3.420000E-02, 
                                3.230000E-02, 2.350000E-02, 2.460000E-02});
                    }; break;
                case 5: // Chiwrut2
                    {
                        tMtxNonLinReg1.X.SetIt(new double[]{0.50, 1.00, 1.75, 3.75, 5.75, 0.875, 2.25,
                                3.25, 5.25, 0.75, 1.75, 2.75, 4.75, 0.625, 1.25, 2.25, 4.25, 0.50, 3.00, 0.75, 3.00,
                                1.50, 6.00, 3.00, 6.00, 1.50, 3.00, 0.50, 2.00, 4.00, 0.75, 2.00, 5.00, 0.75, 2.25,
                                3.75, 5.75, 3.00, 0.75, 2.50, 4.00, 0.75, 2.50, 4.00, 0.75, 2.50, 4.00, 0.50, 6.00,
                                3.00, 0.50, 2.75, 0.50, 1.75});
                        tMtxNonLinReg1.Y.SetIt(new double[]{92.90,57.1, 31.05, 11.5875, 8.025, 63.6,
                                21.40, 14.25, 8.475, 63.80, 26.8, 16.4625, 7.125, 67.30, 41.00, 21.15, 8.175, 81.50, 13.12,
                                59.90, 14.62, 32.90, 5.44, 12.56, 5.44, 32.00, 13.95, 75.80, 20.00, 10.42, 59.50, 21.67,
                                8.55, 62.00, 20.20, 7.76, 3.75, 11.81, 54.70, 23.70, 11.55, 61.30, 17.70, 8.74, 59.20, 16.30,
                                8.62, 81.00, 4.87, 14.62, 81.70, 17.17, 81.30, 28.90});
                    }; break;
                case 6: // MGH10
                    {
                        tMtxNonLinReg1.X.Size(16);
                        tMtxNonLinReg1.X.Ramp(50, 5);
                        tMtxNonLinReg1.Y.SetIt(new double[]{3.478000E+04, 2.861000E+04, 2.365000E+04, 1.963000E+04,
                                1.637000E+04, 1.372000E+04, 1.154000E+04, 9.744000E+03,
                                8.261000E+03, 7.030000E+03, 6.005000E+03, 5.147000E+03,
                                4.427000E+03, 3.820000E+03, 3.307000E+03, 2.872000E+03});

                    }; break;
                case 7: // Roszman1
                    {
                        tMtxNonLinReg1.X.SetIt(new double[]{-4868.68,-4868.09,-4867.41,-3375.19,-3373.14,-3372.03,
                                -2473.74,-2472.35,-2469.45,-1894.65,-1893.40,-1497.24,
                                -1495.85,-1493.41,-1208.68,-1206.18,-1206.04,-997.92,
                                -996.61,-996.31,-834.94,-834.66,-710.03,-530.16,-464.17});

                        tMtxNonLinReg1.Y.SetIt(new double[]{0.252429,0.252141,0.251809,0.297989,0.296257,0.295319,
                                0.339603,0.337731,0.333820,0.389510,0.386998,0.438864,
                                0.434887,0.427893,0.471568,0.461699,0.461144,0.513532,
                                0.506641,0.505062,0.535648,0.533726,0.568064,0.612886,0.624169});
                    }; break;
                case 8: // Rat43
                    {
                        tMtxNonLinReg1.X.Size(15);
                        tMtxNonLinReg1.X.Ramp(1, 1);


                        tMtxNonLinReg1.Y.SetIt(new double[]{16.08,33.83,65.80,97.20,191.55,
                                326.20,386.87,520.53,590.03,651.92,724.93,699.56,689.96,637.56,717.41});
                    }; break;
            }
        }

        // Initial estimates for parameters, as defined at NIST
        private void InitEstimates(int index)
        {
            switch (index)
            {
                case 0: // Eckerle
                    tMtxNonLinReg1.B.SetIt(new double[]{1.0, 10.0, 500.0}); break;
                case 1: // Thurber 
                    tMtxNonLinReg1.B.SetIt(new double[]{1000, 1000, 400, 40, 0.7, 0.3, 0.03}); break;
                case 2: // Rat42
                    tMtxNonLinReg1.B.SetIt(new double[]{100.0, 1.0, 0.1}); break;
                case 3: // Misra1c
                    tMtxNonLinReg1.B.SetIt(new double[]{500.0, 0.0001}); break;
                case 4: // MGH09
                    tMtxNonLinReg1.B.SetIt(new double[]{25.0, 39.0, 41.5, 39}); break;
                case 5: // Chiwrut2
                    tMtxNonLinReg1.B.SetIt(new double[]{0.1, 0.01, 0.02 }); break;
                case 6: // MGH10
                    tMtxNonLinReg1.B.SetIt(new double[]{2, 400000, 25000}); break;
                case 7: // Roszman1
                    tMtxNonLinReg1.B.SetIt(new double[]{0.1, -0.00001, 1000, -100}); break;
                case 8: // Rat43
                    tMtxNonLinReg1.B.SetIt(new double[]{100,10,1,1});break;
            }
        }

        private string WriteToLog(int elapsed, int index, Dew.Stats.TMtxNonLinReg  nlr)
        {
            string result = "Problem:\t";
            int iter = nlr.Iterations;
            switch (index)
            {
                case 0: result += "Eckerle4"; break;
                case 1: result += "Thurber"; break;
                case 2: result += "Rat42"; break;
                case 3: result += "Misra1"; break;
                case 4: result += "MGH9"; break;
                case 5: result += "Chiwrut2"; break;
                case 6: result += "MGH10"; break;
                case 7: result += "Roszman1"; break;
                case 8: result += "Rat43"; break;
            }
            result += "\nMethod:\t";
            switch (nlr.OptMethod)
            {
                case TOptMethod.optSimplex: result += "Simplex"; break;
                case TOptMethod.optMarquardt: result += "Marquardt"; break;
                case TOptMethod.optBFGS: result += "Quasi-Newton (BFGS)"; break;
                case TOptMethod.optDFP: result += "Quasi-Newton (DFP)"; break;
                case TOptMethod.optConjGradPR: result += "Conjugate Gradient (Polak)"; break;
                case TOptMethod.optConjGradFR: result += "Conjugate Gradient (Fletcher)"; break;
            }
            result += " - "+ iter.ToString()+" iterations\n";
            result += "Additional parameters:\n";
            result += "Tol\t MaxIter\t GradTol\t GradStepSize\n";
            result += nlr.Tolerance.ToString("0.00E+00") + "\t" + nlr.MaxIteration.ToString() + "\t" + nlr.GradTolerance.ToString("0.00E+00") + "\t" + Math387.GradStepSize.ToString("0.00E+00") + "\n";
            result += "Elapsed time:\t" + elapsed.ToString() + " ms\n";
            result += "Stop reason:\t";
            switch (nlr.StopReason)
            {
                case TOptStopReason.OptResNotFound: result += "Failed to converge"; break;
                case TOptStopReason.OptResMaxIter: result += "Iterations > Max. iterations"; break;
                case TOptStopReason.OptResSmallGrad: result += "Too small gradient"; break;
                case TOptStopReason.OptResSingular: result += "Singular Hessian matrix"; break;
                case TOptStopReason.OptResBigLambda: result += "Marquardt : Big lambda"; break;
                case TOptStopReason.OptResZeroStep: result += "Zero x step"; break;
                case TOptStopReason.OptResSmallStep: result += "Small x step"; break;
                case TOptStopReason.OptResConverged: result += "Converged"; break;
            }
            result += "\nCalculated values:\n";
            for (int i = 0; i < nlr.B.Length; i++)
            {
                result += "b[" + i.ToString() + "]=\t" + nlr.B.Values[i].ToString("0.00000000") + "\n";
            }
    
            return result;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tMtxNonLinReg1.OptMethod = (Dew.Math.TOptMethod)comboBox1.SelectedIndex;
            button1.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0: tMtxNonLinReg1.RegressFunction += new Dew.Stats.TRegressFun(Eckerle);break;
                case 1: tMtxNonLinReg1.RegressFunction += new Dew.Stats.TRegressFun(Thurber);break;
                case 2: tMtxNonLinReg1.RegressFunction += new Dew.Stats.TRegressFun(Rat42);break;
                case 3: tMtxNonLinReg1.RegressFunction += new Dew.Stats.TRegressFun(Misra1c); break;
                case 4: tMtxNonLinReg1.RegressFunction += new Dew.Stats.TRegressFun(MGH09); break;
                case 5: tMtxNonLinReg1.RegressFunction += new Dew.Stats.TRegressFun(Chwirut2); break;
                case 6: tMtxNonLinReg1.RegressFunction += new Dew.Stats.TRegressFun(MGH10); break;
                case 7: tMtxNonLinReg1.RegressFunction += new Dew.Stats.TRegressFun(Roszman1); break;
                case 8: tMtxNonLinReg1.RegressFunction += new Dew.Stats.TRegressFun(Rat43); break;
            }
            line1.Clear();
            button1.Enabled = true;
            // Read parameters ...
            tMtxNonLinReg1.MaxIteration = (int)numericUpDown1.Value;
            tMtxNonLinReg1.GradTolerance = Convert.ToDouble(textBox1.Text);
            Math387.GradStepSize = Convert.ToDouble(textBox3.Text);
            tMtxNonLinReg1.Tolerance = Convert.ToDouble(textBox2.Text);

            DisplayInfo(listBox1.SelectedIndex);
            FillData(listBox1.SelectedIndex);
            TeeChart.DrawValues(tMtxNonLinReg1.X, tMtxNonLinReg1.Y, points1, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                InitEstimates(listBox1.SelectedIndex);
                // Main calculation
                int timeCheck = Environment.TickCount;
                tMtxNonLinReg1.Recalc();
                timeCheck = Environment.TickCount - timeCheck;
                // Update results
                TeeChart.DrawValues(tMtxNonLinReg1.X, tMtxNonLinReg1.YCalc, line1, false);
                richTextBox3.Text = WriteToLog(timeCheck, listBox1.SelectedIndex, tMtxNonLinReg1);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tMtxNonLinReg1.GradTolerance = Convert.ToDouble(textBox1.Text);
            button1.Enabled = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            tMtxNonLinReg1.MaxIteration = (int)numericUpDown1.Value;
            button1.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            tMtxNonLinReg1.Tolerance = Convert.ToDouble(textBox2.Text);
            button1.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Math387.GradStepSize = Convert.ToDouble(textBox3.Text);
            button1.Enabled = true;
        }
    }
}

