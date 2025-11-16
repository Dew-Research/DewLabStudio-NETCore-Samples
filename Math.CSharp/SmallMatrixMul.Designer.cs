using Dew.Math;
using Dew.Math.Units;
using System.Drawing;
using System;
using System.Windows.Forms;
using Steema.TeeChart;
using Steema.TeeChart.Styles;

namespace MtxVecDemo
{
    partial class SmallMatrixForm
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
        private System.Windows.Forms.Panel Panel2;
        private Button Button1;
        private Label jitLabel;
        private CheckBox ComplexBox;
        private RichTextBox RichEdit1;
        private TChart Chart1;
        private TSmallMatrixMultiply jit;
        private ToolTip toolTip;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Margins margins1 = new Margins();
            Panel1 = new System.Windows.Forms.Panel();
            RichEdit1 = new RichTextBox();
            Panel2 = new System.Windows.Forms.Panel();
            Button1 = new Button();
            jitLabel = new Label();
            ComplexBox = new CheckBox();
            Chart1 = new TChart();
            toolTip = new ToolTip(components);
            Panel1.SuspendLayout();
            Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.Controls.Add(RichEdit1);
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(1032, 250);
            Panel1.TabIndex = 0;
            // 
            // RichEdit1
            // 
            RichEdit1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RichEdit1.Font = new Font("Tahoma", 8F);
            RichEdit1.Location = new Point(3, 3);
            RichEdit1.Name = "RichEdit1";
            RichEdit1.ReadOnly = true;
            RichEdit1.Size = new Size(1026, 244);
            RichEdit1.TabIndex = 0;
            RichEdit1.Text = "";
            // 
            // Panel2
            // 
            Panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel2.Controls.Add(Button1);
            Panel2.Controls.Add(jitLabel);
            Panel2.Controls.Add(ComplexBox);
            Panel2.Location = new Point(3, 640);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1026, 50);
            Panel2.TabIndex = 1;
            // 
            // Button1
            // 
            Button1.Location = new Point(29, 9);
            Button1.Name = "Button1";
            Button1.Size = new Size(110, 26);
            Button1.TabIndex = 1;
            Button1.Text = "Run test";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1Click;
            // 
            // jitLabel
            // 
            jitLabel.Location = new Point(341, 21);
            jitLabel.Name = "jitLabel";
            jitLabel.Size = new Size(92, 14);
            jitLabel.TabIndex = 2;
            jitLabel.Text = "Coverage:";
            // 
            // ComplexBox
            // 
            ComplexBox.Location = new Point(162, 18);
            ComplexBox.Name = "ComplexBox";
            ComplexBox.Size = new Size(124, 17);
            ComplexBox.TabIndex = 3;
            ComplexBox.Text = "Complex";
            toolTip.SetToolTip(ComplexBox, "Does complex number math, if checked");
            ComplexBox.CheckedChanged += ComplexBox_CheckedChanged;
            // 
            // Chart1
            // 
            Chart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            Chart1.Axes.Bottom.Labels.Brush.Color = Color.White;
            Chart1.Axes.Bottom.Labels.Brush.Solid = true;
            Chart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            Chart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            Chart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            Chart1.Axes.Bottom.Labels.Font.Size = 9;
            Chart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            Chart1.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            Chart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            Chart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            Chart1.Axes.Bottom.MaximumOffset = 4;
            Chart1.Axes.Bottom.MinimumOffset = 4;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Bottom.Title.Brush.Color = Color.Silver;
            Chart1.Axes.Bottom.Title.Brush.Solid = true;
            Chart1.Axes.Bottom.Title.Brush.Visible = true;
            Chart1.Axes.Bottom.Title.Caption = "Matrix size";
            // 
            // 
            // 
            Chart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            Chart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            Chart1.Axes.Bottom.Title.Font.Name = "Tahoma";
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            Chart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            Chart1.Axes.Bottom.Title.Font.Size = 11;
            Chart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            Chart1.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            Chart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            Chart1.Axes.Bottom.Title.Lines = new string[]
    {
    "Matrix size"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            Chart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Depth.Labels.Brush.Color = Color.White;
            Chart1.Axes.Depth.Labels.Brush.Solid = true;
            Chart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            Chart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            Chart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            Chart1.Axes.Depth.Labels.Font.Size = 9;
            Chart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            Chart1.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            Chart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            Chart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Depth.Title.Brush.Color = Color.Silver;
            Chart1.Axes.Depth.Title.Brush.Solid = true;
            Chart1.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart1.Axes.Depth.Title.Font.Brush.Solid = true;
            Chart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            Chart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            Chart1.Axes.Depth.Title.Font.Size = 11;
            Chart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            Chart1.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            Chart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            Chart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.DepthTop.Labels.Brush.Color = Color.White;
            Chart1.Axes.DepthTop.Labels.Brush.Solid = true;
            Chart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            Chart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            Chart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            Chart1.Axes.DepthTop.Labels.Font.Size = 9;
            Chart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            Chart1.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            Chart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            Chart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.DepthTop.Title.Brush.Color = Color.Silver;
            Chart1.Axes.DepthTop.Title.Brush.Solid = true;
            Chart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            Chart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            Chart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            Chart1.Axes.DepthTop.Title.Font.Size = 11;
            Chart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            Chart1.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            Chart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            Chart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Left.Labels.Brush.Color = Color.White;
            Chart1.Axes.Left.Labels.Brush.Solid = true;
            Chart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart1.Axes.Left.Labels.Font.Brush.Solid = true;
            Chart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            Chart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            Chart1.Axes.Left.Labels.Font.Size = 9;
            Chart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            Chart1.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            Chart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            Chart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            Chart1.Axes.Left.Labels.ValueFormat = "0.###";
            Chart1.Axes.Left.MaximumOffset = 4;
            Chart1.Axes.Left.MinimumOffset = 4;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Left.Title.Brush.Color = Color.Silver;
            Chart1.Axes.Left.Title.Brush.Solid = true;
            Chart1.Axes.Left.Title.Brush.Visible = true;
            Chart1.Axes.Left.Title.Caption = "Time [ms]";
            // 
            // 
            // 
            Chart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Axes.Left.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart1.Axes.Left.Title.Font.Brush.Solid = true;
            Chart1.Axes.Left.Title.Font.Brush.Visible = true;
            Chart1.Axes.Left.Title.Font.Name = "Tahoma";
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            Chart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            Chart1.Axes.Left.Title.Font.Size = 11;
            Chart1.Axes.Left.Title.Font.SizeFloat = 11F;
            Chart1.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            Chart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            Chart1.Axes.Left.Title.Lines = new string[]
    {
    "Time [ms]"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            Chart1.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Right.Labels.Brush.Color = Color.White;
            Chart1.Axes.Right.Labels.Brush.Solid = true;
            Chart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart1.Axes.Right.Labels.Font.Brush.Solid = true;
            Chart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            Chart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            Chart1.Axes.Right.Labels.Font.Size = 9;
            Chart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            Chart1.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            Chart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            Chart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Right.Title.Brush.Color = Color.Silver;
            Chart1.Axes.Right.Title.Brush.Solid = true;
            Chart1.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Axes.Right.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart1.Axes.Right.Title.Font.Brush.Solid = true;
            Chart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            Chart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            Chart1.Axes.Right.Title.Font.Size = 11;
            Chart1.Axes.Right.Title.Font.SizeFloat = 11F;
            Chart1.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            Chart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            Chart1.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Top.Labels.Brush.Color = Color.White;
            Chart1.Axes.Top.Labels.Brush.Solid = true;
            Chart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart1.Axes.Top.Labels.Font.Brush.Solid = true;
            Chart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            Chart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            Chart1.Axes.Top.Labels.Font.Size = 9;
            Chart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            Chart1.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            Chart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            Chart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Top.Title.Brush.Color = Color.Silver;
            Chart1.Axes.Top.Title.Brush.Solid = true;
            Chart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Axes.Top.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart1.Axes.Top.Title.Font.Brush.Solid = true;
            Chart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            Chart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            Chart1.Axes.Top.Title.Font.Size = 11;
            Chart1.Axes.Top.Title.Font.SizeFloat = 11F;
            Chart1.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            Chart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            Chart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            Chart1.BackColor = Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Footer.Brush.Color = Color.Silver;
            Chart1.Footer.Brush.Solid = true;
            Chart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Footer.Font.Brush.Color = Color.Red;
            Chart1.Footer.Font.Brush.Solid = true;
            Chart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Footer.Font.Shadow.Brush.Solid = true;
            Chart1.Footer.Font.Shadow.Brush.Visible = true;
            Chart1.Footer.Font.Size = 8;
            Chart1.Footer.Font.SizeFloat = 8F;
            Chart1.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Footer.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Footer.ImageBevel.Brush.Solid = true;
            Chart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Footer.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Footer.Shadow.Brush.Solid = true;
            Chart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Header.Brush.Color = Color.FromArgb(192, 192, 192);
            Chart1.Header.Brush.Solid = true;
            Chart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Header.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Header.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart1.Header.Font.Brush.Solid = true;
            Chart1.Header.Font.Brush.Visible = true;
            Chart1.Header.Font.Name = "Tahoma";
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Header.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Header.Font.Shadow.Brush.Solid = true;
            Chart1.Header.Font.Shadow.Brush.Visible = true;
            Chart1.Header.Font.Size = 8;
            Chart1.Header.Font.SizeFloat = 8F;
            Chart1.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Header.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Header.ImageBevel.Brush.Solid = true;
            Chart1.Header.ImageBevel.Brush.Visible = true;
            Chart1.Header.Lines = new string[]
    {
    "Small Matrix Multiply"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Header.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            Chart1.Header.Shadow.Brush.Solid = true;
            Chart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Legend.Brush.Color = Color.White;
            Chart1.Legend.Brush.Solid = true;
            Chart1.Legend.Brush.Visible = true;
            Chart1.Legend.CheckBoxes = false;
            // 
            // 
            // 
            Chart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            Chart1.Legend.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart1.Legend.Font.Brush.Solid = true;
            Chart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Legend.Font.Shadow.Brush.Solid = true;
            Chart1.Legend.Font.Shadow.Brush.Visible = true;
            Chart1.Legend.Font.Size = 9;
            Chart1.Legend.Font.SizeFloat = 9F;
            Chart1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Legend.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Legend.ImageBevel.Brush.Solid = true;
            Chart1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Legend.Shadow.Brush.Color = Color.FromArgb(0, 0, 0);
            Chart1.Legend.Shadow.Brush.Solid = true;
            Chart1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Legend.Symbol.Shadow.Brush.Solid = true;
            Chart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Legend.Title.Brush.Color = Color.White;
            Chart1.Legend.Title.Brush.Solid = true;
            Chart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            Chart1.Legend.Title.Font.Brush.Color = Color.Black;
            Chart1.Legend.Title.Font.Brush.Solid = true;
            Chart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            Chart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            Chart1.Legend.Title.Font.Size = 8;
            Chart1.Legend.Title.Font.SizeFloat = 8F;
            Chart1.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Legend.Title.ImageBevel.Brush.Solid = true;
            Chart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Legend.Title.Shadow.Brush.Solid = true;
            Chart1.Legend.Title.Shadow.Brush.Visible = true;
            Chart1.Location = new Point(3, 256);
            Chart1.Name = "Chart1";
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Panel.Brush.Color = Color.FromArgb(255, 255, 255);
            Chart1.Panel.Brush.Solid = true;
            Chart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Panel.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Panel.ImageBevel.Brush.Solid = true;
            Chart1.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Panel.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Panel.Shadow.Brush.Solid = true;
            Chart1.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            Chart1.Printer.Margins = margins1;
            Chart1.Size = new Size(1029, 378);
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.SubFooter.Brush.Color = Color.Silver;
            Chart1.SubFooter.Brush.Solid = true;
            Chart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            Chart1.SubFooter.Font.Brush.Color = Color.Red;
            Chart1.SubFooter.Font.Brush.Solid = true;
            Chart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.SubFooter.Font.Shadow.Brush.Solid = true;
            Chart1.SubFooter.Font.Shadow.Brush.Visible = true;
            Chart1.SubFooter.Font.Size = 8;
            Chart1.SubFooter.Font.SizeFloat = 8F;
            Chart1.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.SubFooter.ImageBevel.Brush.Solid = true;
            Chart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.SubFooter.Shadow.Brush.Color = Color.DarkGray;
            Chart1.SubFooter.Shadow.Brush.Solid = true;
            Chart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.SubHeader.Brush.Color = Color.FromArgb(192, 192, 192);
            Chart1.SubHeader.Brush.Solid = true;
            Chart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            Chart1.SubHeader.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart1.SubHeader.Font.Brush.Solid = true;
            Chart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart1.SubHeader.Font.Shadow.Brush.Solid = true;
            Chart1.SubHeader.Font.Shadow.Brush.Visible = true;
            Chart1.SubHeader.Font.Size = 12;
            Chart1.SubHeader.Font.SizeFloat = 12F;
            Chart1.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.SubHeader.ImageBevel.Brush.Solid = true;
            Chart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.SubHeader.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            Chart1.SubHeader.Shadow.Brush.Solid = true;
            Chart1.SubHeader.Shadow.Brush.Visible = true;
            Chart1.TabIndex = 4;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Walls.Back.Brush.Color = Color.Silver;
            Chart1.Walls.Back.Brush.Solid = true;
            Chart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Walls.Back.ImageBevel.Brush.Solid = true;
            Chart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Walls.Back.Shadow.Brush.Solid = true;
            Chart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Walls.Bottom.Brush.Color = Color.White;
            Chart1.Walls.Bottom.Brush.Solid = true;
            Chart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            Chart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Walls.Bottom.Shadow.Brush.Solid = true;
            Chart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Walls.Left.Brush.Color = Color.LightYellow;
            Chart1.Walls.Left.Brush.Solid = true;
            Chart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Walls.Left.ImageBevel.Brush.Solid = true;
            Chart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Walls.Left.Shadow.Brush.Solid = true;
            Chart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Walls.Right.Brush.Color = Color.LightYellow;
            Chart1.Walls.Right.Brush.Solid = true;
            Chart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
            Chart1.Walls.Right.ImageBevel.Brush.Solid = true;
            Chart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart1.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
            Chart1.Walls.Right.Shadow.Brush.Solid = true;
            Chart1.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            Chart1.Zoom.Animated = true;
            // 
            // 
            // 
            Chart1.Zoom.Brush.Color = Color.FromArgb(127, 0, 0, 255);
            Chart1.Zoom.Brush.Solid = true;
            Chart1.Zoom.Brush.Visible = true;
            // 
            // SmallMatrixForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1031, 692);
            Controls.Add(Chart1);
            Controls.Add(Panel2);
            Controls.Add(Panel1);
            Font = new Font("Tahoma", 8F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SmallMatrixForm";
            ShowInTaskbar = false;
            Text = "SmallMatrixForm";
            FormClosing += FormDestroy;
            Panel1.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
    }
}