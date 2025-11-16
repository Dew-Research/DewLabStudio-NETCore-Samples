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
            Margins margins1 = new Margins();
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompoundExpressionsForm));
            Panel1 = new System.Windows.Forms.Panel();
            RunButton = new Button();
            PrecisionGroup = new GroupBox();
            DoublePrecisionRadio = new RadioButton();
            ComplexPrecisionRadio = new RadioButton();
            IntegerPrecisionRadio = new RadioButton();
            SmallIntPrecisionRadio = new RadioButton();
            BytePrecisionRadio = new RadioButton();
            Chart = new TChart();
            Series1 = new Bar();
            Series2 = new Bar();
            Memo = new RichTextBox();
            Panel1.SuspendLayout();
            PrecisionGroup.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Panel1.Controls.Add(RunButton);
            Panel1.Controls.Add(PrecisionGroup);
            Panel1.Location = new Point(0, 548);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1051, 72);
            Panel1.TabIndex = 0;
            // 
            // RunButton
            // 
            RunButton.Location = new Point(23, 21);
            RunButton.Name = "RunButton";
            RunButton.Size = new Size(107, 25);
            RunButton.TabIndex = 0;
            RunButton.Text = "Run";
            RunButton.UseVisualStyleBackColor = true;
            RunButton.Click += RunButtonClick;
            // 
            // PrecisionGroup
            // 
            PrecisionGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PrecisionGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PrecisionGroup.Controls.Add(DoublePrecisionRadio);
            PrecisionGroup.Controls.Add(ComplexPrecisionRadio);
            PrecisionGroup.Controls.Add(IntegerPrecisionRadio);
            PrecisionGroup.Controls.Add(SmallIntPrecisionRadio);
            PrecisionGroup.Controls.Add(BytePrecisionRadio);
            PrecisionGroup.Location = new Point(172, 3);
            PrecisionGroup.Name = "PrecisionGroup";
            PrecisionGroup.Size = new Size(861, 62);
            PrecisionGroup.TabIndex = 1;
            PrecisionGroup.TabStop = false;
            PrecisionGroup.Text = "Math selection";
            // 
            // DoublePrecisionRadio
            // 
            DoublePrecisionRadio.Checked = true;
            DoublePrecisionRadio.Location = new Point(41, 23);
            DoublePrecisionRadio.Name = "DoublePrecisionRadio";
            DoublePrecisionRadio.Size = new Size(150, 20);
            DoublePrecisionRadio.TabIndex = 0;
            DoublePrecisionRadio.TabStop = true;
            DoublePrecisionRadio.Text = "Double Floating point";
            DoublePrecisionRadio.CheckedChanged += PrecisionGroupClick;
            // 
            // ComplexPrecisionRadio
            // 
            ComplexPrecisionRadio.Location = new Point(211, 23);
            ComplexPrecisionRadio.Name = "ComplexPrecisionRadio";
            ComplexPrecisionRadio.Size = new Size(150, 20);
            ComplexPrecisionRadio.TabIndex = 1;
            ComplexPrecisionRadio.Text = "Complex Floating point";
            ComplexPrecisionRadio.CheckedChanged += PrecisionGroupClick;
            // 
            // IntegerPrecisionRadio
            // 
            IntegerPrecisionRadio.Location = new Point(381, 23);
            IntegerPrecisionRadio.Name = "IntegerPrecisionRadio";
            IntegerPrecisionRadio.Size = new Size(150, 20);
            IntegerPrecisionRadio.TabIndex = 2;
            IntegerPrecisionRadio.Text = "Saturated Integer";
            IntegerPrecisionRadio.CheckedChanged += PrecisionGroupClick;
            // 
            // SmallIntPrecisionRadio
            // 
            SmallIntPrecisionRadio.Location = new Point(551, 23);
            SmallIntPrecisionRadio.Name = "SmallIntPrecisionRadio";
            SmallIntPrecisionRadio.Size = new Size(150, 20);
            SmallIntPrecisionRadio.TabIndex = 3;
            SmallIntPrecisionRadio.Text = "Saturated SmallInt";
            SmallIntPrecisionRadio.CheckedChanged += PrecisionGroupClick;
            // 
            // BytePrecisionRadio
            // 
            BytePrecisionRadio.Location = new Point(721, 23);
            BytePrecisionRadio.Name = "BytePrecisionRadio";
            BytePrecisionRadio.Size = new Size(150, 20);
            BytePrecisionRadio.TabIndex = 4;
            BytePrecisionRadio.Text = "Saturated Byte";
            BytePrecisionRadio.CheckedChanged += PrecisionGroupClick;
            // 
            // Chart
            // 
            Chart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            Chart.Axes.Bottom.Labels.Brush.Color = Color.White;
            Chart.Axes.Bottom.Labels.Brush.Solid = true;
            Chart.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            Chart.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart.Axes.Bottom.Labels.Font.Brush.Solid = true;
            Chart.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            Chart.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            Chart.Axes.Bottom.Labels.Font.Size = 9;
            Chart.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            Chart.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            Chart.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            Chart.Axes.Bottom.Labels.MultiLine = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            Chart.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Bottom.Title.Brush.Color = Color.Silver;
            Chart.Axes.Bottom.Title.Brush.Solid = true;
            Chart.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            Chart.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart.Axes.Bottom.Title.Font.Brush.Solid = true;
            Chart.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            Chart.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            Chart.Axes.Bottom.Title.Font.Size = 11;
            Chart.Axes.Bottom.Title.Font.SizeFloat = 11F;
            Chart.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            Chart.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            Chart.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Depth.Labels.Brush.Color = Color.White;
            Chart.Axes.Depth.Labels.Brush.Solid = true;
            Chart.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            Chart.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart.Axes.Depth.Labels.Font.Brush.Solid = true;
            Chart.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            Chart.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            Chart.Axes.Depth.Labels.Font.Size = 9;
            Chart.Axes.Depth.Labels.Font.SizeFloat = 9F;
            Chart.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            Chart.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            Chart.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Depth.Title.Brush.Color = Color.Silver;
            Chart.Axes.Depth.Title.Brush.Solid = true;
            Chart.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            Chart.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart.Axes.Depth.Title.Font.Brush.Solid = true;
            Chart.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            Chart.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            Chart.Axes.Depth.Title.Font.Size = 11;
            Chart.Axes.Depth.Title.Font.SizeFloat = 11F;
            Chart.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            Chart.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Depth.Title.Shadow.Brush.Solid = true;
            Chart.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.DepthTop.Labels.Brush.Color = Color.White;
            Chart.Axes.DepthTop.Labels.Brush.Solid = true;
            Chart.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            Chart.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            Chart.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            Chart.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            Chart.Axes.DepthTop.Labels.Font.Size = 9;
            Chart.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            Chart.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            Chart.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            Chart.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.DepthTop.Title.Brush.Color = Color.Silver;
            Chart.Axes.DepthTop.Title.Brush.Solid = true;
            Chart.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            Chart.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart.Axes.DepthTop.Title.Font.Brush.Solid = true;
            Chart.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            Chart.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            Chart.Axes.DepthTop.Title.Font.Size = 11;
            Chart.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            Chart.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            Chart.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            Chart.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Left.Labels.Brush.Color = Color.White;
            Chart.Axes.Left.Labels.Brush.Solid = true;
            Chart.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            Chart.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart.Axes.Left.Labels.Font.Brush.Solid = true;
            Chart.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            Chart.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            Chart.Axes.Left.Labels.Font.Size = 9;
            Chart.Axes.Left.Labels.Font.SizeFloat = 9F;
            Chart.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            Chart.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Left.Labels.Shadow.Brush.Solid = true;
            Chart.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Left.Title.Brush.Color = Color.Silver;
            Chart.Axes.Left.Title.Brush.Solid = true;
            Chart.Axes.Left.Title.Brush.Visible = true;
            Chart.Axes.Left.Title.Caption = "Time [ms]";
            // 
            // 
            // 
            Chart.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            Chart.Axes.Left.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart.Axes.Left.Title.Font.Brush.Solid = true;
            Chart.Axes.Left.Title.Font.Brush.Visible = true;
            Chart.Axes.Left.Title.Font.Name = "Tahoma";
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            Chart.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            Chart.Axes.Left.Title.Font.Size = 11;
            Chart.Axes.Left.Title.Font.SizeFloat = 11F;
            Chart.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            Chart.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            Chart.Axes.Left.Title.Lines = new string[]
    {
    "Time [ms]"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Left.Title.Shadow.Brush.Solid = true;
            Chart.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Right.Labels.Brush.Color = Color.White;
            Chart.Axes.Right.Labels.Brush.Solid = true;
            Chart.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            Chart.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart.Axes.Right.Labels.Font.Brush.Solid = true;
            Chart.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            Chart.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            Chart.Axes.Right.Labels.Font.Size = 9;
            Chart.Axes.Right.Labels.Font.SizeFloat = 9F;
            Chart.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            Chart.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Right.Labels.Shadow.Brush.Solid = true;
            Chart.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Right.Title.Brush.Color = Color.Silver;
            Chart.Axes.Right.Title.Brush.Solid = true;
            Chart.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            Chart.Axes.Right.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart.Axes.Right.Title.Font.Brush.Solid = true;
            Chart.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            Chart.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            Chart.Axes.Right.Title.Font.Size = 11;
            Chart.Axes.Right.Title.Font.SizeFloat = 11F;
            Chart.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            Chart.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Right.Title.Shadow.Brush.Solid = true;
            Chart.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Top.Labels.Brush.Color = Color.White;
            Chart.Axes.Top.Labels.Brush.Solid = true;
            Chart.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            Chart.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart.Axes.Top.Labels.Font.Brush.Solid = true;
            Chart.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            Chart.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            Chart.Axes.Top.Labels.Font.Size = 9;
            Chart.Axes.Top.Labels.Font.SizeFloat = 9F;
            Chart.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            Chart.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Top.Labels.Shadow.Brush.Solid = true;
            Chart.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Top.Title.Brush.Color = Color.Silver;
            Chart.Axes.Top.Title.Brush.Solid = true;
            Chart.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            Chart.Axes.Top.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart.Axes.Top.Title.Font.Brush.Solid = true;
            Chart.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            Chart.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            Chart.Axes.Top.Title.Font.Size = 11;
            Chart.Axes.Top.Title.Font.SizeFloat = 11F;
            Chart.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            Chart.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Top.Title.Shadow.Brush.Solid = true;
            Chart.Axes.Top.Title.Shadow.Brush.Visible = true;
            Chart.BackColor = Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Footer.Brush.Color = Color.Silver;
            Chart.Footer.Brush.Solid = true;
            Chart.Footer.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Footer.Font.Bold = false;
            // 
            // 
            // 
            Chart.Footer.Font.Brush.Color = Color.Red;
            Chart.Footer.Font.Brush.Solid = true;
            Chart.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Footer.Font.Shadow.Brush.Solid = true;
            Chart.Footer.Font.Shadow.Brush.Visible = true;
            Chart.Footer.Font.Size = 8;
            Chart.Footer.Font.SizeFloat = 8F;
            Chart.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Footer.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Footer.ImageBevel.Brush.Solid = true;
            Chart.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Footer.Shadow.Brush.Color = Color.DarkGray;
            Chart.Footer.Shadow.Brush.Solid = true;
            Chart.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Header.Brush.Color = Color.FromArgb(192, 192, 192);
            Chart.Header.Brush.Solid = true;
            Chart.Header.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Header.Font.Bold = false;
            // 
            // 
            // 
            Chart.Header.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart.Header.Font.Brush.Solid = true;
            Chart.Header.Font.Brush.Visible = true;
            Chart.Header.Font.Name = "Tahoma";
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Header.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Header.Font.Shadow.Brush.Solid = true;
            Chart.Header.Font.Shadow.Brush.Visible = true;
            Chart.Header.Font.Size = 12;
            Chart.Header.Font.SizeFloat = 12F;
            Chart.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Header.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Header.ImageBevel.Brush.Solid = true;
            Chart.Header.ImageBevel.Brush.Visible = true;
            Chart.Header.Lines = new string[]
    {
    "Comparing compound and sequenced expressions"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Header.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            Chart.Header.Shadow.Brush.Solid = true;
            Chart.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Legend.Brush.Color = Color.White;
            Chart.Legend.Brush.Solid = true;
            Chart.Legend.Brush.Visible = true;
            Chart.Legend.CheckBoxes = false;
            // 
            // 
            // 
            Chart.Legend.Font.Bold = false;
            // 
            // 
            // 
            Chart.Legend.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart.Legend.Font.Brush.Solid = true;
            Chart.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Legend.Font.Shadow.Brush.Solid = true;
            Chart.Legend.Font.Shadow.Brush.Visible = true;
            Chart.Legend.Font.Size = 9;
            Chart.Legend.Font.SizeFloat = 9F;
            Chart.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Legend.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Legend.ImageBevel.Brush.Solid = true;
            Chart.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Legend.Shadow.Brush.Color = Color.FromArgb(0, 0, 0);
            Chart.Legend.Shadow.Brush.Solid = true;
            Chart.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
            Chart.Legend.Symbol.Shadow.Brush.Solid = true;
            Chart.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Legend.Title.Brush.Color = Color.White;
            Chart.Legend.Title.Brush.Solid = true;
            Chart.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            Chart.Legend.Title.Font.Brush.Color = Color.Black;
            Chart.Legend.Title.Font.Brush.Solid = true;
            Chart.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Legend.Title.Font.Shadow.Brush.Solid = true;
            Chart.Legend.Title.Font.Shadow.Brush.Visible = true;
            Chart.Legend.Title.Font.Size = 8;
            Chart.Legend.Title.Font.SizeFloat = 8F;
            Chart.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Legend.Title.ImageBevel.Brush.Solid = true;
            Chart.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart.Legend.Title.Shadow.Brush.Solid = true;
            Chart.Legend.Title.Shadow.Brush.Visible = true;
            Chart.Location = new Point(11, 95);
            Chart.Name = "Chart";
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Panel.Brush.Color = Color.FromArgb(255, 255, 255);
            Chart.Panel.Brush.Solid = true;
            Chart.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Panel.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Panel.ImageBevel.Brush.Solid = true;
            Chart.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Panel.Shadow.Brush.Color = Color.DarkGray;
            Chart.Panel.Shadow.Brush.Solid = true;
            Chart.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            Chart.Printer.Margins = margins1;
            Chart.Series.Add(Series1);
            Chart.Series.Add(Series2);
            Chart.Size = new Size(1040, 447);
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.SubFooter.Brush.Color = Color.Silver;
            Chart.SubFooter.Brush.Solid = true;
            Chart.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            Chart.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            Chart.SubFooter.Font.Brush.Color = Color.Red;
            Chart.SubFooter.Font.Brush.Solid = true;
            Chart.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.SubFooter.Font.Shadow.Brush.Solid = true;
            Chart.SubFooter.Font.Shadow.Brush.Visible = true;
            Chart.SubFooter.Font.Size = 8;
            Chart.SubFooter.Font.SizeFloat = 8F;
            Chart.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
            Chart.SubFooter.ImageBevel.Brush.Solid = true;
            Chart.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.SubFooter.Shadow.Brush.Color = Color.DarkGray;
            Chart.SubFooter.Shadow.Brush.Solid = true;
            Chart.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.SubHeader.Brush.Color = Color.FromArgb(192, 192, 192);
            Chart.SubHeader.Brush.Solid = true;
            Chart.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            Chart.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            Chart.SubHeader.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart.SubHeader.Font.Brush.Solid = true;
            Chart.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.SubHeader.Font.Shadow.Brush.Solid = true;
            Chart.SubHeader.Font.Shadow.Brush.Visible = true;
            Chart.SubHeader.Font.Size = 12;
            Chart.SubHeader.Font.SizeFloat = 12F;
            Chart.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
            Chart.SubHeader.ImageBevel.Brush.Solid = true;
            Chart.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.SubHeader.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            Chart.SubHeader.Shadow.Brush.Solid = true;
            Chart.SubHeader.Shadow.Brush.Visible = true;
            Chart.TabIndex = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Walls.Back.Brush.Color = Color.Silver;
            Chart.Walls.Back.Brush.Solid = true;
            Chart.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Walls.Back.ImageBevel.Brush.Solid = true;
            Chart.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
            Chart.Walls.Back.Shadow.Brush.Solid = true;
            Chart.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Walls.Bottom.Brush.Color = Color.White;
            Chart.Walls.Bottom.Brush.Solid = true;
            Chart.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Walls.Bottom.ImageBevel.Brush.Solid = true;
            Chart.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
            Chart.Walls.Bottom.Shadow.Brush.Solid = true;
            Chart.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Walls.Left.Brush.Color = Color.LightYellow;
            Chart.Walls.Left.Brush.Solid = true;
            Chart.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Walls.Left.ImageBevel.Brush.Solid = true;
            Chart.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
            Chart.Walls.Left.Shadow.Brush.Solid = true;
            Chart.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Walls.Right.Brush.Color = Color.LightYellow;
            Chart.Walls.Right.Brush.Solid = true;
            Chart.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Walls.Right.ImageBevel.Brush.Solid = true;
            Chart.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
            Chart.Walls.Right.Shadow.Brush.Solid = true;
            Chart.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Zoom.Animated = true;
            // 
            // 
            // 
            Chart.Zoom.Brush.Color = Color.FromArgb(127, 0, 0, 255);
            Chart.Zoom.Brush.Solid = true;
            Chart.Zoom.Brush.Visible = true;
            Chart.Click += Chart_Click;
            // 
            // Series1
            // 
            Series1.BarRound = BarRounding.AtValue;
            // 
            // 
            // 
            Series1.Brush.Color = Color.Blue;
            Series1.Brush.Solid = true;
            Series1.Brush.Visible = true;
            Series1.Color = Color.Blue;
            Series1.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            Series1.Legend.Brush.Color = Color.White;
            Series1.Legend.Brush.Solid = true;
            Series1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            Series1.Legend.Font.Bold = false;
            // 
            // 
            // 
            Series1.Legend.Font.Brush.Color = Color.Black;
            Series1.Legend.Font.Brush.Solid = true;
            Series1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            Series1.Legend.Font.Shadow.Brush.Solid = true;
            Series1.Legend.Font.Shadow.Brush.Visible = true;
            Series1.Legend.Font.Size = 8;
            Series1.Legend.Font.SizeFloat = 8F;
            Series1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Series1.Legend.ImageBevel.Brush.Color = Color.LightGray;
            Series1.Legend.ImageBevel.Brush.Solid = true;
            Series1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series1.Legend.Shadow.Brush.Color = Color.DarkGray;
            Series1.Legend.Shadow.Brush.Solid = true;
            Series1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series1.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            Series1.Marks.Brush.Solid = true;
            Series1.Marks.Brush.Visible = true;
            // 
            // 
            // 
            Series1.Marks.Font.Bold = false;
            // 
            // 
            // 
            Series1.Marks.Font.Brush.Color = Color.Black;
            Series1.Marks.Font.Brush.Solid = true;
            Series1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series1.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            Series1.Marks.Font.Shadow.Brush.Solid = true;
            Series1.Marks.Font.Shadow.Brush.Visible = true;
            Series1.Marks.Font.Size = 8;
            Series1.Marks.Font.SizeFloat = 8F;
            Series1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Series1.Marks.ImageBevel.Brush.Color = Color.LightGray;
            Series1.Marks.ImageBevel.Brush.Solid = true;
            Series1.Marks.ImageBevel.Brush.Visible = true;
            Series1.Marks.OnTop = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series1.Marks.Shadow.Brush.Color = Color.Gray;
            Series1.Marks.Shadow.Brush.Solid = true;
            Series1.Marks.Shadow.Brush.Visible = true;
            Series1.Marks.Style = MarksStyles.Value;
            // 
            // 
            // 
            // 
            // 
            // 
            Series1.Marks.Symbol.Brush.Color = Color.White;
            Series1.Marks.Symbol.Brush.Solid = true;
            Series1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series1.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            Series1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            Series1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series1.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            Series1.Marks.Symbol.Shadow.Brush.Solid = true;
            Series1.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series1.Shadow.Brush.Color = Color.DarkGray;
            Series1.Shadow.Brush.Solid = true;
            Series1.Shadow.Brush.Visible = true;
            Series1.Title = "Compound";
            // 
            // 
            // 
            Series1.XValues.Order = ValueListOrder.Ascending;
            Series1.XValues.Value = new double[]
    {
    0D,
    1D,
    2D,
    3D,
    4D,
    5D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            Series1.YValues.Value = new double[]
    {
    492D,
    493D,
    376D,
    304D,
    351D,
    330D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // Series2
            // 
            Series2.BarRound = BarRounding.AtValue;
            // 
            // 
            // 
            Series2.Brush.Color = Color.Red;
            Series2.Brush.Solid = true;
            Series2.Brush.Visible = true;
            Series2.Color = Color.Red;
            Series2.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            Series2.Legend.Brush.Color = Color.White;
            Series2.Legend.Brush.Solid = true;
            Series2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            Series2.Legend.Font.Bold = false;
            // 
            // 
            // 
            Series2.Legend.Font.Brush.Color = Color.Black;
            Series2.Legend.Font.Brush.Solid = true;
            Series2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series2.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            Series2.Legend.Font.Shadow.Brush.Solid = true;
            Series2.Legend.Font.Shadow.Brush.Visible = true;
            Series2.Legend.Font.Size = 8;
            Series2.Legend.Font.SizeFloat = 8F;
            Series2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Series2.Legend.ImageBevel.Brush.Color = Color.LightGray;
            Series2.Legend.ImageBevel.Brush.Solid = true;
            Series2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series2.Legend.Shadow.Brush.Color = Color.DarkGray;
            Series2.Legend.Shadow.Brush.Solid = true;
            Series2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series2.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            Series2.Marks.Brush.Solid = true;
            Series2.Marks.Brush.Visible = true;
            // 
            // 
            // 
            Series2.Marks.Font.Bold = false;
            // 
            // 
            // 
            Series2.Marks.Font.Brush.Color = Color.Black;
            Series2.Marks.Font.Brush.Solid = true;
            Series2.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series2.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            Series2.Marks.Font.Shadow.Brush.Solid = true;
            Series2.Marks.Font.Shadow.Brush.Visible = true;
            Series2.Marks.Font.Size = 8;
            Series2.Marks.Font.SizeFloat = 8F;
            Series2.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Series2.Marks.ImageBevel.Brush.Color = Color.LightGray;
            Series2.Marks.ImageBevel.Brush.Solid = true;
            Series2.Marks.ImageBevel.Brush.Visible = true;
            Series2.Marks.OnTop = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series2.Marks.Shadow.Brush.Color = Color.Gray;
            Series2.Marks.Shadow.Brush.Solid = true;
            Series2.Marks.Shadow.Brush.Visible = true;
            Series2.Marks.Style = MarksStyles.Value;
            // 
            // 
            // 
            // 
            // 
            // 
            Series2.Marks.Symbol.Brush.Color = Color.White;
            Series2.Marks.Symbol.Brush.Solid = true;
            Series2.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series2.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            Series2.Marks.Symbol.ImageBevel.Brush.Solid = true;
            Series2.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series2.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            Series2.Marks.Symbol.Shadow.Brush.Solid = true;
            Series2.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Series2.Shadow.Brush.Color = Color.DarkGray;
            Series2.Shadow.Brush.Solid = true;
            Series2.Shadow.Brush.Visible = true;
            Series2.Title = "Sequenced";
            // 
            // 
            // 
            Series2.XValues.Order = ValueListOrder.Ascending;
            Series2.XValues.Value = new double[]
    {
    0D,
    1D,
    2D,
    3D,
    4D,
    5D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            Series2.YValues.Value = new double[]
    {
    363D,
    342D,
    368D,
    421D,
    453D,
    448D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // Memo
            // 
            Memo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Memo.Font = new Font("Tahoma", 8F);
            Memo.Location = new Point(0, 0);
            Memo.Name = "Memo";
            Memo.ReadOnly = true;
            Memo.Size = new Size(1377, 89);
            Memo.TabIndex = 2;
            Memo.Text = "";
            // 
            // CompoundExpressionsForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1063, 621);
            Controls.Add(Memo);
            Controls.Add(Chart);
            Controls.Add(Panel1);
            Font = new Font("Tahoma", 8F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CompoundExpressionsForm";
            Tag = "";
            Text = "CompoundExpressionsForm";
            Load += CompoundExpressionsForm_Load;
            Panel1.ResumeLayout(false);
            PrecisionGroup.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
    }
}