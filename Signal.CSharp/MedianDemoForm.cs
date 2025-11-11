using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Dew.Signal;
using Dew.Math;
using Dew.Math.Controls;
using Dew.Signal.Units;
using Dew.Math.Units;
using Dew.Signal.Tee;
using static Dew.Math.Tee.MtxVecTee;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for MedianDemoForm.
	/// </summary>
	public class MedianDemoForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox filterComboBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private FloatEdit maskSizeEdit;
		private Steema.TeeChart.Styles.FastLine OriginalSeries;
		private Steema.TeeChart.Styles.FastLine FilteredSeries;
        private SignalChart SignalChart1;
        private Button ChartButton;
        private Steema.TeeChart.Editor ChartEditor;
        private IContainer components;

		public MedianDemoForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            OriginalSeries.Color = Color.Navy;
            FilteredSeries.Color = Color.Red;

			filterComboBox.SelectedIndex = 0;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedianDemoForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChartButton = new System.Windows.Forms.Button();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskSizeEdit = new Dew.Math.Controls.FloatEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.SignalChart1 = new Dew.Signal.Tee.SignalChart();
            this.OriginalSeries = new Steema.TeeChart.Styles.FastLine();
            this.FilteredSeries = new Steema.TeeChart.Styles.FastLine();
            this.ChartEditor = new Steema.TeeChart.Editor(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignalChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(704, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChartButton);
            this.panel1.Controls.Add(this.filterComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.maskSizeEdit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 546);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 35);
            this.panel1.TabIndex = 1;
            // 
            // ChartButton
            // 
            this.ChartButton.Location = new System.Drawing.Point(12, 5);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(75, 23);
            this.ChartButton.TabIndex = 12;
            this.ChartButton.Text = "Chart...";
            this.ChartButton.UseVisualStyleBackColor = true;
            this.ChartButton.Click += new System.EventHandler(this.ChartButton_Click);
            // 
            // filterComboBox
            // 
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.Items.AddRange(new object[] {
            "Median",
            "Delay"});
            this.filterComboBox.Location = new System.Drawing.Point(250, 6);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(121, 21);
            this.filterComboBox.TabIndex = 11;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(202, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Filter:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maskSizeEdit
            // 
            this.maskSizeEdit.Increment = "1";
            this.maskSizeEdit.Location = new System.Drawing.Point(456, 6);
            this.maskSizeEdit.Name = "maskSizeEdit";
            this.maskSizeEdit.ReFormat = "#";
            this.maskSizeEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.maskSizeEdit.Scientific = false;
            this.maskSizeEdit.Size = new System.Drawing.Size(72, 20);
            this.maskSizeEdit.TabIndex = 9;
            this.maskSizeEdit.Value = "10";
            this.maskSizeEdit.TextChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(384, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mask size:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SignalChart1
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
            this.SignalChart1.Axes.Bottom.Grid.DrawEvery = 1;
             
            this.SignalChart1.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Axes.Bottom.Labels.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SignalChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Bottom.Labels.Font.Size = 9;
            this.SignalChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.Axes.Bottom.Title.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Title.Brush.Visible = true;
            this.SignalChart1.Axes.Bottom.Title.Caption = "Time [s]";
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignalChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Bottom.Title.Font.Size = 11;
            this.SignalChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            this.SignalChart1.Axes.Bottom.Title.Lines = new string[] {
        "Time [s]"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
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
            this.SignalChart1.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Axes.Depth.Labels.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SignalChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Depth.Labels.Font.Size = 9;
            this.SignalChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.Axes.Depth.Title.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignalChart1.Axes.Depth.Title.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Depth.Title.Font.Size = 11;
            this.SignalChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
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
            this.SignalChart1.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Axes.DepthTop.Labels.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SignalChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.DepthTop.Labels.Font.Size = 9;
            this.SignalChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.Axes.DepthTop.Title.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignalChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.DepthTop.Title.Font.Size = 11;
            this.SignalChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
             
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Axes.Left.Labels.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SignalChart1.Axes.Left.Labels.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Left.Labels.Font.Size = 9;
            this.SignalChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.Axes.Left.Title.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignalChart1.Axes.Left.Title.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Left.Title.Font.Size = 11;
            this.SignalChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
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
            this.SignalChart1.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Axes.Right.Labels.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SignalChart1.Axes.Right.Labels.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Right.Labels.Font.Size = 9;
            this.SignalChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.Axes.Right.Title.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignalChart1.Axes.Right.Title.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Right.Title.Font.Size = 11;
            this.SignalChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
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
            this.SignalChart1.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Axes.Top.Labels.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SignalChart1.Axes.Top.Labels.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Top.Labels.Font.Size = 9;
            this.SignalChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.Axes.Top.Title.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignalChart1.Axes.Top.Title.Font.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Axes.Top.Title.Font.Size = 11;
            this.SignalChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.SignalChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.SignalChart1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
             
            this.SignalChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.Footer.Brush.Solid = true;
            this.SignalChart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.SignalChart1.Footer.Font.Brush.Solid = true;
            this.SignalChart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Footer.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Footer.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Footer.Font.Size = 8;
            this.SignalChart1.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Footer.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Footer.Shadow.Brush.Solid = true;
            this.SignalChart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SignalChart1.Header.Brush.Solid = true;
            this.SignalChart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Header.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SignalChart1.Header.Font.Brush.Solid = true;
            this.SignalChart1.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Header.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Header.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Header.Font.Size = 12;
            this.SignalChart1.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Header.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Header.ImageBevel.Brush.Visible = true;
            this.SignalChart1.Header.Lines = new string[] {
        "Time signal"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignalChart1.Header.Shadow.Brush.Solid = true;
            this.SignalChart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Legend.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Legend.Brush.Solid = true;
            this.SignalChart1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignalChart1.Legend.Font.Brush.Solid = true;
            this.SignalChart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Legend.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Legend.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Legend.Font.Size = 9;
            this.SignalChart1.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Legend.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SignalChart1.Legend.Shadow.Brush.Solid = true;
            this.SignalChart1.Legend.Shadow.Brush.Visible = true;
            this.SignalChart1.Legend.Shadow.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Legend.Symbol.Shadow.Brush.Solid = true;
            this.SignalChart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Legend.Title.Brush.Solid = true;
            this.SignalChart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.SignalChart1.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.SignalChart1.Legend.Title.Font.Brush.Solid = true;
            this.SignalChart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.Legend.Title.Font.Size = 8;
            this.SignalChart1.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Legend.Title.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Legend.Title.Shadow.Brush.Solid = true;
            this.SignalChart1.Legend.Title.Shadow.Brush.Visible = true;
            this.SignalChart1.Location = new System.Drawing.Point(0, 96);
            this.SignalChart1.Name = "SignalChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            this.SignalChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SignalChart1.Panel.Brush.Solid = true;
            this.SignalChart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Panel.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Panel.Shadow.Brush.Solid = true;
            this.SignalChart1.Panel.Shadow.Brush.Visible = true;
            this.SignalChart1.Series.Add(this.OriginalSeries);
            this.SignalChart1.Series.Add(this.FilteredSeries);
            this.SignalChart1.Size = new System.Drawing.Size(704, 450);
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.SubFooter.Brush.Solid = true;
            this.SignalChart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.SignalChart1.SubFooter.Font.Brush.Solid = true;
            this.SignalChart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.SubFooter.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.SubFooter.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.SubFooter.Font.Size = 8;
            this.SignalChart1.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.SubFooter.ImageBevel.Brush.Solid = true;
            this.SignalChart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.SubFooter.Shadow.Brush.Solid = true;
            this.SignalChart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SignalChart1.SubHeader.Brush.Solid = true;
            this.SignalChart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.SignalChart1.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SignalChart1.SubHeader.Font.Brush.Solid = true;
            this.SignalChart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.SubHeader.Font.Shadow.Brush.Solid = true;
            this.SignalChart1.SubHeader.Font.Shadow.Brush.Visible = true;
            this.SignalChart1.SubHeader.Font.Size = 12;
            this.SignalChart1.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.SubHeader.ImageBevel.Brush.Solid = true;
            this.SignalChart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignalChart1.SubHeader.Shadow.Brush.Solid = true;
            this.SignalChart1.SubHeader.Shadow.Brush.Visible = true;
            this.SignalChart1.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.SignalChart1.Walls.Back.Brush.Solid = true;
            this.SignalChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Walls.Back.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Walls.Back.Shadow.Brush.Solid = true;
            this.SignalChart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.SignalChart1.Walls.Bottom.Brush.Solid = true;
            this.SignalChart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Walls.Bottom.Shadow.Brush.Solid = true;
            this.SignalChart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.SignalChart1.Walls.Left.Brush.Solid = true;
            this.SignalChart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Walls.Left.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Walls.Left.Shadow.Brush.Solid = true;
            this.SignalChart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SignalChart1.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.SignalChart1.Walls.Right.Brush.Solid = true;
            this.SignalChart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SignalChart1.Walls.Right.ImageBevel.Brush.Solid = true;
            this.SignalChart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SignalChart1.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SignalChart1.Walls.Right.Shadow.Brush.Solid = true;
            this.SignalChart1.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SignalChart1.Zoom.Animated = true;
            // 
            // 
            // 
            this.SignalChart1.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.SignalChart1.Zoom.Brush.Solid = true;
            this.SignalChart1.Zoom.Brush.Visible = false;
            this.SignalChart1.Zoom.History = true;
            this.SignalChart1.Zoom.FullRepaint = true;
            this.SignalChart1.Zoom.Pen.Visible = true;
            // 
            // OriginalSeries
            // 
            this.OriginalSeries.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.OriginalSeries.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.OriginalSeries.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.OriginalSeries.Legend.Brush.Color = System.Drawing.Color.White;
            this.OriginalSeries.Legend.Brush.Solid = true;
            this.OriginalSeries.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.OriginalSeries.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.OriginalSeries.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.OriginalSeries.Legend.Font.Brush.Solid = true;
            this.OriginalSeries.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.OriginalSeries.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.OriginalSeries.Legend.Font.Shadow.Brush.Solid = true;
            this.OriginalSeries.Legend.Font.Shadow.Brush.Visible = true;
            this.OriginalSeries.Legend.Font.Size = 8;
            this.OriginalSeries.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.OriginalSeries.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.OriginalSeries.Legend.ImageBevel.Brush.Solid = true;
            this.OriginalSeries.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.OriginalSeries.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.OriginalSeries.Legend.Shadow.Brush.Solid = true;
            this.OriginalSeries.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.OriginalSeries.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.OriginalSeries.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.OriginalSeries.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OriginalSeries.Marks.Brush.Solid = true;
            this.OriginalSeries.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.OriginalSeries.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.OriginalSeries.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.OriginalSeries.Marks.Font.Brush.Solid = true;
            this.OriginalSeries.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.OriginalSeries.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.OriginalSeries.Marks.Font.Shadow.Brush.Solid = true;
            this.OriginalSeries.Marks.Font.Shadow.Brush.Visible = true;
            this.OriginalSeries.Marks.Font.Size = 8;
            this.OriginalSeries.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.OriginalSeries.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.OriginalSeries.Marks.ImageBevel.Brush.Solid = true;
            this.OriginalSeries.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.OriginalSeries.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.OriginalSeries.Marks.Shadow.Brush.Solid = true;
            this.OriginalSeries.Marks.Shadow.Brush.Visible = true;
            this.OriginalSeries.Marks.Shadow.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.OriginalSeries.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.OriginalSeries.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.OriginalSeries.Marks.Symbol.Brush.Solid = true;
            this.OriginalSeries.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.OriginalSeries.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.OriginalSeries.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.OriginalSeries.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.OriginalSeries.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.OriginalSeries.Marks.Symbol.Shadow.Brush.Solid = true;
            this.OriginalSeries.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.OriginalSeries.Marks.TailParams.Margin = 0F;
            this.OriginalSeries.Marks.TailParams.PointerHeight = 8D;
            this.OriginalSeries.Marks.TailParams.PointerWidth = 8D;
            this.OriginalSeries.OriginalCursor = Steema.TeeChart.Drawing.Cursor.Current;
            this.OriginalSeries.Title = "Original";
            this.OriginalSeries.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.OriginalSeries.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.OriginalSeries.XValues.DataMember = "X";
            this.OriginalSeries.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.OriginalSeries.YValues.DataMember = "Y";
            // 
            // FilteredSeries
            // 
            this.FilteredSeries.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(104)))));
            this.FilteredSeries.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.FilteredSeries.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.FilteredSeries.Legend.Brush.Color = System.Drawing.Color.White;
            this.FilteredSeries.Legend.Brush.Solid = true;
            this.FilteredSeries.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.FilteredSeries.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.FilteredSeries.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.FilteredSeries.Legend.Font.Brush.Solid = true;
            this.FilteredSeries.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.FilteredSeries.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.FilteredSeries.Legend.Font.Shadow.Brush.Solid = true;
            this.FilteredSeries.Legend.Font.Shadow.Brush.Visible = true;
            this.FilteredSeries.Legend.Font.Size = 8;
            this.FilteredSeries.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.FilteredSeries.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.FilteredSeries.Legend.ImageBevel.Brush.Solid = true;
            this.FilteredSeries.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.FilteredSeries.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.FilteredSeries.Legend.Shadow.Brush.Solid = true;
            this.FilteredSeries.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.FilteredSeries.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(104)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.FilteredSeries.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.FilteredSeries.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FilteredSeries.Marks.Brush.Solid = true;
            this.FilteredSeries.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.FilteredSeries.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.FilteredSeries.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.FilteredSeries.Marks.Font.Brush.Solid = true;
            this.FilteredSeries.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.FilteredSeries.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.FilteredSeries.Marks.Font.Shadow.Brush.Solid = true;
            this.FilteredSeries.Marks.Font.Shadow.Brush.Visible = true;
            this.FilteredSeries.Marks.Font.Size = 8;
            this.FilteredSeries.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.FilteredSeries.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.FilteredSeries.Marks.ImageBevel.Brush.Solid = true;
            this.FilteredSeries.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.FilteredSeries.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.FilteredSeries.Marks.Shadow.Brush.Solid = true;
            this.FilteredSeries.Marks.Shadow.Brush.Visible = true;
            this.FilteredSeries.Marks.Shadow.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.FilteredSeries.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.FilteredSeries.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.FilteredSeries.Marks.Symbol.Brush.Solid = true;
            this.FilteredSeries.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.FilteredSeries.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.FilteredSeries.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.FilteredSeries.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.FilteredSeries.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.FilteredSeries.Marks.Symbol.Shadow.Brush.Solid = true;
            this.FilteredSeries.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.FilteredSeries.Marks.TailParams.Margin = 0F;
            this.FilteredSeries.Marks.TailParams.PointerHeight = 8D;
            this.FilteredSeries.Marks.TailParams.PointerWidth = 8D;
            this.FilteredSeries.OriginalCursor = Steema.TeeChart.Drawing.Cursor.Current;
            this.FilteredSeries.Title = "Filtered";
            this.FilteredSeries.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.FilteredSeries.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.FilteredSeries.XValues.DataMember = "X";
            this.FilteredSeries.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.FilteredSeries.YValues.DataMember = "Y";
            // 
            // ChartEditor
            // 
            this.ChartEditor.Chart = this.SignalChart1;
            this.ChartEditor.HighLightTabs = false;
            this.ChartEditor.Location = new System.Drawing.Point(0, 0);
            this.ChartEditor.Name = "ChartEditor";
            this.ChartEditor.Options = null;
            this.ChartEditor.TabIndex = 0;
            this.ChartEditor.Text = "Chart...";
            // 
            // MedianDemoForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(704, 581);
            this.Controls.Add(this.SignalChart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "MedianDemoForm";
            this.Text = "MedianDemoForm";
            this.Load += new System.EventHandler(this.MedianDemoForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SignalChart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private TMedianState medianState;
        private TDelayFilterState delayState;

		private void UpdateMedian() {
			TVec a,b;
			MtxVec.CreateIt(out a, out b);
			int maskSize = maskSizeEdit.IntPosition;
            int BlockCount;
			SignalUtils.MedianInit(maskSize, ref medianState, a.FloatPrecision);
			try {
				a.Size(1000,false);
				b.Size(a);
				a.Ramp();
				int blockLength = 10;
                BlockCount = a.Length / blockLength;
				for (int i=0; i < BlockCount;i++) {
					a.SetSubRange(i*blockLength,blockLength);
					b.SetSubRange(i*blockLength,blockLength);
					SignalUtils.MedianFilter(a,b,medianState);
				}
				a.SetFullRange();
				b.SetFullRange();
				DrawValues(a,OriginalSeries, 0, 1, false);
				DrawValues(b,FilteredSeries, 0, 1, false);
			} finally {
				SignalUtils.MedianFree(ref medianState);
				MtxVec.FreeIt(ref a, ref b);
			}
		}

		private void UpdateDelay() {
			TVec a,b;
			MtxVec.CreateIt(out a, out b);
			int delayLength = maskSizeEdit.IntPosition;
            int BlockCount;
            int blockLength;
			SignalUtils.DelayInit(delayLength,ref delayState,a.FloatPrecision);
			try {
				a.Size(1000,false);
				b.Size(a);
				a.Ramp();
				blockLength = 10;
                BlockCount = a.Length / blockLength;
				for (int i=0; i < BlockCount;i++) {
					a.SetSubRange(i*blockLength,blockLength);
					b.SetSubRange(i*blockLength,blockLength);
					SignalUtils.DelayFilter(a,b,delayState);
				}
				a.SetFullRange();
				b.SetFullRange();
				DrawValues(a,OriginalSeries, 0, 1, false);
				DrawValues(b,FilteredSeries, 0, 1, false);
			} finally {
				SignalUtils.DelayFree(ref delayState);
				MtxVec.FreeIt(ref a, ref b);
			}
		}

		private void filterComboBox_SelectedIndexChanged(object sender, System.EventArgs e) {
			switch (filterComboBox.SelectedIndex) {
				case 0:
					UpdateMedian();
					break;
				case 1:
					UpdateDelay();
					break;
			}
		}

        protected void Add(String s)
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void MedianDemoForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("The chart shows a ramp filtered through a median "
            + "or an integer delay filter. Median and delay filter "
            + "are both streaming filters. The size of the block is set "
            + "to 10 and the mask size can be varied. Change the mask size "
            + "to test both filters. If the filter work Ok, increasing the "
            + "mask size will shift the ramp to the right.");
        }

        private void ChartButton_Click(object sender, EventArgs e)
        {
            ChartEditor.ShowModal();
        }
	}
}
