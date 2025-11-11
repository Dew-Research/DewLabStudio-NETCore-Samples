using System;
using System.Drawing;
using System.Windows.Forms;
using Steema.TeeChart;
using Steema.TeeChart.Styles;

namespace MtxVecDemo
{
    public partial class CompoundExpressionsForm: Form
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

        private System.Windows.Forms.Panel Panel1;
        private Button RunButton;
        private TChart Chart;
        private RichTextBox Memo;
        private Bar Series1;
        private Bar Series2;
        private GroupBox PrecisionGroup;
        private RadioButton DoublePrecisionRadio;
        private RadioButton ComplexPrecisionRadio;
        private RadioButton IntegerPrecisionRadio;
        private RadioButton SmallIntPrecisionRadio;
        private RadioButton BytePrecisionRadio;
        public CompoundExpressionsForm()
        {
            InitializeComponent();
            FormCreate();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompoundExpressionsForm));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.RunButton = new System.Windows.Forms.Button();
            this.PrecisionGroup = new System.Windows.Forms.GroupBox();
            this.DoublePrecisionRadio = new System.Windows.Forms.RadioButton();
            this.ComplexPrecisionRadio = new System.Windows.Forms.RadioButton();
            this.IntegerPrecisionRadio = new System.Windows.Forms.RadioButton();
            this.SmallIntPrecisionRadio = new System.Windows.Forms.RadioButton();
            this.BytePrecisionRadio = new System.Windows.Forms.RadioButton();
            this.Chart = new Steema.TeeChart.TChart();
            this.Series1 = new Steema.TeeChart.Styles.Bar();
            this.Series2 = new Steema.TeeChart.Styles.Bar();
            this.Memo = new System.Windows.Forms.RichTextBox();
            this.Panel1.SuspendLayout();
            this.PrecisionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel1.Controls.Add(this.RunButton);
            this.Panel1.Controls.Add(this.PrecisionGroup);
            this.Panel1.Location = new System.Drawing.Point(0, 728);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1088, 72);
            this.Panel1.TabIndex = 0;
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(23, 21);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(107, 25);
            this.RunButton.TabIndex = 0;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButtonClick);
            // 
            // PrecisionGroup
            // 
            this.PrecisionGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrecisionGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PrecisionGroup.Controls.Add(this.DoublePrecisionRadio);
            this.PrecisionGroup.Controls.Add(this.ComplexPrecisionRadio);
            this.PrecisionGroup.Controls.Add(this.IntegerPrecisionRadio);
            this.PrecisionGroup.Controls.Add(this.SmallIntPrecisionRadio);
            this.PrecisionGroup.Controls.Add(this.BytePrecisionRadio);
            this.PrecisionGroup.Location = new System.Drawing.Point(172, 3);
            this.PrecisionGroup.Name = "PrecisionGroup";
            this.PrecisionGroup.Size = new System.Drawing.Size(898, 62);
            this.PrecisionGroup.TabIndex = 1;
            this.PrecisionGroup.TabStop = false;
            this.PrecisionGroup.Text = "Math selection";
            // 
            // DoublePrecisionRadio
            // 
            this.DoublePrecisionRadio.Checked = true;
            this.DoublePrecisionRadio.Location = new System.Drawing.Point(41, 23);
            this.DoublePrecisionRadio.Name = "DoublePrecisionRadio";
            this.DoublePrecisionRadio.Size = new System.Drawing.Size(150, 20);
            this.DoublePrecisionRadio.TabIndex = 0;
            this.DoublePrecisionRadio.TabStop = true;
            this.DoublePrecisionRadio.Text = "Double Floating point";
            this.DoublePrecisionRadio.CheckedChanged += new System.EventHandler(this.PrecisionGroupClick);
            // 
            // ComplexPrecisionRadio
            // 
            this.ComplexPrecisionRadio.Location = new System.Drawing.Point(211, 23);
            this.ComplexPrecisionRadio.Name = "ComplexPrecisionRadio";
            this.ComplexPrecisionRadio.Size = new System.Drawing.Size(150, 20);
            this.ComplexPrecisionRadio.TabIndex = 1;
            this.ComplexPrecisionRadio.Text = "Complex Floating point";
            this.ComplexPrecisionRadio.CheckedChanged += new System.EventHandler(this.PrecisionGroupClick);
            // 
            // IntegerPrecisionRadio
            // 
            this.IntegerPrecisionRadio.Location = new System.Drawing.Point(381, 23);
            this.IntegerPrecisionRadio.Name = "IntegerPrecisionRadio";
            this.IntegerPrecisionRadio.Size = new System.Drawing.Size(150, 20);
            this.IntegerPrecisionRadio.TabIndex = 2;
            this.IntegerPrecisionRadio.Text = "Saturated Integer";
            this.IntegerPrecisionRadio.CheckedChanged += new System.EventHandler(this.PrecisionGroupClick);
            // 
            // SmallIntPrecisionRadio
            // 
            this.SmallIntPrecisionRadio.Location = new System.Drawing.Point(551, 23);
            this.SmallIntPrecisionRadio.Name = "SmallIntPrecisionRadio";
            this.SmallIntPrecisionRadio.Size = new System.Drawing.Size(150, 20);
            this.SmallIntPrecisionRadio.TabIndex = 3;
            this.SmallIntPrecisionRadio.Text = "Saturated SmallInt";
            this.SmallIntPrecisionRadio.CheckedChanged += new System.EventHandler(this.PrecisionGroupClick);
            // 
            // BytePrecisionRadio
            // 
            this.BytePrecisionRadio.Location = new System.Drawing.Point(721, 23);
            this.BytePrecisionRadio.Name = "BytePrecisionRadio";
            this.BytePrecisionRadio.Size = new System.Drawing.Size(150, 20);
            this.BytePrecisionRadio.TabIndex = 4;
            this.BytePrecisionRadio.Text = "Saturated Byte";
            this.BytePrecisionRadio.CheckedChanged += new System.EventHandler(this.PrecisionGroupClick);
            // 
            // Chart
            // 
            this.Chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
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
            this.Chart.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.Bottom.Labels.Font.Size = 9;
            this.Chart.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart.Axes.Bottom.Labels.MultiLine = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.Bottom.Title.Font.Size = 11;
            this.Chart.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.Depth.Labels.Font.Size = 9;
            this.Chart.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.Chart.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.Chart.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.Depth.Title.Font.Size = 11;
            this.Chart.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.DepthTop.Labels.Font.Size = 9;
            this.Chart.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.DepthTop.Title.Font.Size = 11;
            this.Chart.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.Left.Labels.Font.Size = 9;
            this.Chart.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.Chart.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.Chart.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.Chart.Axes.Left.Title.Caption = "Time [ms]";
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Chart.Axes.Left.Title.Font.Name = "Tahoma";
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.Left.Title.Font.Size = 11;
            this.Chart.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart.Axes.Left.Title.Lines = new string[] {
        "Time [ms]"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.Right.Labels.Font.Size = 9;
            this.Chart.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.Chart.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.Chart.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.Right.Title.Font.Size = 11;
            this.Chart.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.Top.Labels.Font.Size = 9;
            this.Chart.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.Chart.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.Chart.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.Top.Title.Font.Size = 11;
            this.Chart.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Footer.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Footer.Font.Size = 8;
            this.Chart.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Chart.Header.Font.Name = "Tahoma";
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Header.Font.Size = 12;
            this.Chart.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart.Header.Lines = new string[] {
        "Comparing compound and sequenced expressions"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Legend.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Legend.Font.Size = 9;
            this.Chart.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Legend.Title.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Legend.Title.Font.Size = 8;
            this.Chart.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Location = new System.Drawing.Point(11, 95);
            this.Chart.Name = "Chart";
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            this.Chart.Printer.Margins = margins1;
            this.Chart.Series.Add(this.Series1);
            this.Chart.Series.Add(this.Series2);
            this.Chart.Size = new System.Drawing.Size(1077, 627);
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.SubFooter.Font.Size = 8;
            this.Chart.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.SubHeader.Font.Size = 12;
            this.Chart.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Chart.TabIndex = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.Chart.Zoom.Animated = true;
            // 
            // 
            // 
            this.Chart.Zoom.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.Chart.Click += new System.EventHandler(this.Chart_Click);
            // 
            // Series1
            // 
            this.Series1.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
            // 
            // 
            // 
            this.Series1.Brush.Color = System.Drawing.Color.Blue;
            this.Series1.Color = System.Drawing.Color.Blue;
            this.Series1.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Series1.Legend.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Series1.Legend.Font.Size = 8;
            this.Series1.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Series1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Series1.Marks.Font.Size = 8;
            this.Series1.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Series1.Marks.OnTop = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.Series1.Marks.Style = Steema.TeeChart.Styles.MarksStyles.Value;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Series1.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.Series1.OriginalCursor = null;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series1.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Series1.Title = "Compound";
            this.Series1.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.Series1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // Series2
            // 
            this.Series2.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
            // 
            // 
            // 
            this.Series2.Brush.Color = System.Drawing.Color.Red;
            this.Series2.Color = System.Drawing.Color.Red;
            this.Series2.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Series2.Legend.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Series2.Legend.Font.Size = 8;
            this.Series2.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Series2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Series2.Marks.Font.Size = 8;
            this.Series2.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Series2.Marks.OnTop = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.Series2.Marks.Style = Steema.TeeChart.Styles.MarksStyles.Value;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Series2.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.Series2.OriginalCursor = null;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Series2.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Series2.Title = "Sequenced";
            this.Series2.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.Series2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // Memo
            // 
            this.Memo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Memo.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Memo.Location = new System.Drawing.Point(0, 0);
            this.Memo.Name = "Memo";
            this.Memo.ReadOnly = true;
            this.Memo.Size = new System.Drawing.Size(1414, 89);
            this.Memo.TabIndex = 2;
            this.Memo.Text = "";
            // 
            // CompoundExpressionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1100, 801);
            this.Controls.Add(this.Memo);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CompoundExpressionsForm";
            this.Text = "CompoundExpressionsForm";
            this.Load += new System.EventHandler(this.CompoundExpressionsForm_Load);
            this.Panel1.ResumeLayout(false);
            this.PrecisionGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}