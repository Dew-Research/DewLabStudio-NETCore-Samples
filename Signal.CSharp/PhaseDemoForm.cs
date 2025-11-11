using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Dew.Signal;
using Dew.Signal.Units;
using Dew.Math;
using Dew.Math.Units;
using Steema.TeeChart.Styles;
using Dew.Signal.Tee;
using Dew.Math.Controls;
using static Dew.Math.Tee.MtxVecTee;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for PhaseDemoForm.
	/// </summary>
	public class PhaseDemoForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private SignalChart SignalChart1;
		private FloatEdit zeroPadEdit;
		private System.Windows.Forms.Label label2;
		private FloatEdit firLengthEdit;
        private System.Windows.Forms.Label label1;
        private Button ChartButton;
        private Steema.TeeChart.Editor ChartEditor;
        private IContainer components;

		public PhaseDemoForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			SignalDiscreteSeries series = new SignalDiscreteSeries(SignalChart1.Chart);
			series.UseYOrigin = true;
			series.Pointer.Style = PointerStyles.Circle;
			SignalChart1.Series.Add(series);
			zeroPadEdit_TextChanged(this, EventArgs.Empty);
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
            components = new Container();
            Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            ChartButton = new Button();
            zeroPadEdit = new FloatEdit();
            label2 = new Label();
            firLengthEdit = new FloatEdit();
            label1 = new Label();
            panel2 = new Panel();
            SignalChart1 = new SignalChart();
            ChartEditor = new Steema.TeeChart.Editor(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((ISupportInitialize)SignalChart1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Top;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(895, 79);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            panel1.Controls.Add(ChartButton);
            panel1.Controls.Add(zeroPadEdit);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(firLengthEdit);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 502);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 41);
            panel1.TabIndex = 1;
            // 
            // ChartButton
            // 
            ChartButton.Location = new Point(14, 6);
            ChartButton.Name = "ChartButton";
            ChartButton.Size = new Size(90, 28);
            ChartButton.TabIndex = 18;
            ChartButton.Text = "Chart...";
            ChartButton.UseVisualStyleBackColor = true;
            ChartButton.Click += ChartButton_Click;
            // 
            // zeroPadEdit
            // 
            zeroPadEdit.Increment = "1";
            zeroPadEdit.Location = new Point(542, 10);
            zeroPadEdit.Name = "zeroPadEdit";
            zeroPadEdit.ReFormat = "0";
            zeroPadEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            zeroPadEdit.Scientific = false;
            zeroPadEdit.Size = new Size(58, 23);
            zeroPadEdit.TabIndex = 17;
            zeroPadEdit.Value = "4";
            zeroPadEdit.TextChanged += zeroPadEdit_TextChanged;
            // 
            // label2
            // 
            label2.Location = new Point(401, 7);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 16;
            label2.Text = "Zero padding power:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // firLengthEdit
            // 
            firLengthEdit.Increment = "1";
            firLengthEdit.Location = new Point(307, 10);
            firLengthEdit.Name = "firLengthEdit";
            firLengthEdit.ReFormat = "0";
            firLengthEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            firLengthEdit.Scientific = false;
            firLengthEdit.Size = new Size(87, 23);
            firLengthEdit.TabIndex = 15;
            firLengthEdit.Value = "60";
            firLengthEdit.TextChanged += zeroPadEdit_TextChanged;
            // 
            // label1
            // 
            label1.Location = new Point(180, 7);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 14;
            label1.Text = "Fir length:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.Controls.Add(SignalChart1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(895, 423);
            panel2.TabIndex = 2;
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
            SignalChart1.Axes.Bottom.Grid.DrawEvery = 1;
            SignalChart1.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Bottom.Labels.Brush.Color = Color.White;
            SignalChart1.Axes.Bottom.Labels.Brush.Solid = true;
            SignalChart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SignalChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            SignalChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            SignalChart1.Axes.Bottom.Labels.Font.Size = 9;
            SignalChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            SignalChart1.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            SignalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Bottom.Title.Brush.Color = Color.Silver;
            SignalChart1.Axes.Bottom.Title.Brush.Solid = true;
            SignalChart1.Axes.Bottom.Title.Brush.Visible = true;
            SignalChart1.Axes.Bottom.Title.Caption = "Frequency [Hz]";
            // 
            // 
            // 
            SignalChart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SignalChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            SignalChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            SignalChart1.Axes.Bottom.Title.Font.Size = 11;
            SignalChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            SignalChart1.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            SignalChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            SignalChart1.Axes.Bottom.Title.Lines = new string[]
    {
    "Frequency [Hz]"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Depth.Labels.Brush.Color = Color.White;
            SignalChart1.Axes.Depth.Labels.Brush.Solid = true;
            SignalChart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SignalChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            SignalChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            SignalChart1.Axes.Depth.Labels.Font.Size = 9;
            SignalChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            SignalChart1.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            SignalChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Depth.Title.Brush.Color = Color.Silver;
            SignalChart1.Axes.Depth.Title.Brush.Solid = true;
            SignalChart1.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SignalChart1.Axes.Depth.Title.Font.Brush.Solid = true;
            SignalChart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            SignalChart1.Axes.Depth.Title.Font.Size = 11;
            SignalChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            SignalChart1.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            SignalChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.DepthTop.Labels.Brush.Color = Color.White;
            SignalChart1.Axes.DepthTop.Labels.Brush.Solid = true;
            SignalChart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SignalChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            SignalChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            SignalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            SignalChart1.Axes.DepthTop.Labels.Font.Size = 9;
            SignalChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            SignalChart1.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            SignalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            SignalChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.DepthTop.Title.Brush.Color = Color.Silver;
            SignalChart1.Axes.DepthTop.Title.Brush.Solid = true;
            SignalChart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SignalChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            SignalChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            SignalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            SignalChart1.Axes.DepthTop.Title.Font.Size = 11;
            SignalChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            SignalChart1.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            SignalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            SignalChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Left.Labels.Brush.Color = Color.White;
            SignalChart1.Axes.Left.Labels.Brush.Solid = true;
            SignalChart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SignalChart1.Axes.Left.Labels.Font.Brush.Solid = true;
            SignalChart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            SignalChart1.Axes.Left.Labels.Font.Size = 9;
            SignalChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            SignalChart1.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            SignalChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Left.Title.Brush.Color = Color.Silver;
            SignalChart1.Axes.Left.Title.Brush.Solid = true;
            SignalChart1.Axes.Left.Title.Brush.Visible = true;
            SignalChart1.Axes.Left.Title.Caption = "Degrees";
            // 
            // 
            // 
            SignalChart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Axes.Left.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SignalChart1.Axes.Left.Title.Font.Brush.Solid = true;
            SignalChart1.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            SignalChart1.Axes.Left.Title.Font.Size = 11;
            SignalChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            SignalChart1.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            SignalChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            SignalChart1.Axes.Left.Title.Lines = new string[]
    {
    "Degrees"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Right.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Right.Labels.Brush.Color = Color.White;
            SignalChart1.Axes.Right.Labels.Brush.Solid = true;
            SignalChart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SignalChart1.Axes.Right.Labels.Font.Brush.Solid = true;
            SignalChart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            SignalChart1.Axes.Right.Labels.Font.Size = 9;
            SignalChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            SignalChart1.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            SignalChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Right.Title.Brush.Color = Color.Silver;
            SignalChart1.Axes.Right.Title.Brush.Solid = true;
            SignalChart1.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Axes.Right.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SignalChart1.Axes.Right.Title.Font.Brush.Solid = true;
            SignalChart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            SignalChart1.Axes.Right.Title.Font.Size = 11;
            SignalChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            SignalChart1.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            SignalChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Top.Labels.Brush.Color = Color.White;
            SignalChart1.Axes.Top.Labels.Brush.Solid = true;
            SignalChart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SignalChart1.Axes.Top.Labels.Font.Brush.Solid = true;
            SignalChart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            SignalChart1.Axes.Top.Labels.Font.Size = 9;
            SignalChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            SignalChart1.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            SignalChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Top.Title.Brush.Color = Color.Silver;
            SignalChart1.Axes.Top.Title.Brush.Solid = true;
            SignalChart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Axes.Top.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SignalChart1.Axes.Top.Title.Font.Brush.Solid = true;
            SignalChart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            SignalChart1.Axes.Top.Title.Font.Size = 11;
            SignalChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            SignalChart1.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            SignalChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            SignalChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            SignalChart1.Color = Color.FromArgb(192, 192, 192);
            SignalChart1.Dock = DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Footer.Brush.Color = Color.Silver;
            SignalChart1.Footer.Brush.Solid = true;
            SignalChart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Footer.Font.Brush.Color = Color.Red;
            SignalChart1.Footer.Font.Brush.Solid = true;
            SignalChart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Footer.Font.Shadow.Brush.Solid = true;
            SignalChart1.Footer.Font.Shadow.Brush.Visible = true;
            SignalChart1.Footer.Font.Size = 8;
            SignalChart1.Footer.Font.SizeFloat = 8F;
            SignalChart1.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Footer.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Footer.ImageBevel.Brush.Solid = true;
            SignalChart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Footer.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Footer.Shadow.Brush.Solid = true;
            SignalChart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Header.Brush.Color = Color.FromArgb(192, 192, 192);
            SignalChart1.Header.Brush.Solid = true;
            SignalChart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Header.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Header.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SignalChart1.Header.Font.Brush.Solid = true;
            SignalChart1.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Header.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Header.Font.Shadow.Brush.Solid = true;
            SignalChart1.Header.Font.Shadow.Brush.Visible = true;
            SignalChart1.Header.Font.Size = 12;
            SignalChart1.Header.Font.SizeFloat = 12F;
            SignalChart1.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Header.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Header.ImageBevel.Brush.Solid = true;
            SignalChart1.Header.ImageBevel.Brush.Visible = true;
            SignalChart1.Header.Lines = new string[]
    {
    "Phase spectrum"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Header.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            SignalChart1.Header.Shadow.Brush.Solid = true;
            SignalChart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Legend.Brush.Color = Color.White;
            SignalChart1.Legend.Brush.Solid = true;
            SignalChart1.Legend.Brush.Visible = true;
            SignalChart1.Legend.CheckBoxes = false;
            // 
            // 
            // 
            SignalChart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.Legend.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SignalChart1.Legend.Font.Brush.Solid = true;
            SignalChart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Legend.Font.Shadow.Brush.Solid = true;
            SignalChart1.Legend.Font.Shadow.Brush.Visible = true;
            SignalChart1.Legend.Font.Size = 9;
            SignalChart1.Legend.Font.SizeFloat = 9F;
            SignalChart1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Legend.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Legend.ImageBevel.Brush.Solid = true;
            SignalChart1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Legend.Shadow.Brush.Color = Color.FromArgb(0, 0, 0);
            SignalChart1.Legend.Shadow.Brush.Solid = true;
            SignalChart1.Legend.Shadow.Brush.Visible = true;
            SignalChart1.Legend.Shadow.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Legend.Symbol.Shadow.Brush.Solid = true;
            SignalChart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Legend.Title.Brush.Color = Color.White;
            SignalChart1.Legend.Title.Brush.Solid = true;
            SignalChart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            SignalChart1.Legend.Title.Font.Brush.Color = Color.Black;
            SignalChart1.Legend.Title.Font.Brush.Solid = true;
            SignalChart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            SignalChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            SignalChart1.Legend.Title.Font.Size = 8;
            SignalChart1.Legend.Title.Font.SizeFloat = 8F;
            SignalChart1.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Legend.Title.ImageBevel.Brush.Solid = true;
            SignalChart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Legend.Title.Shadow.Brush.Solid = true;
            SignalChart1.Legend.Title.Shadow.Brush.Visible = true;
            SignalChart1.Legend.Visible = false;
            SignalChart1.Location = new Point(0, 0);
            SignalChart1.Name = "SignalChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            // 
            // 
            // 
            SignalChart1.Panel.Brush.Color = Color.FromArgb(192, 192, 192);
            SignalChart1.Panel.Brush.Solid = true;
            SignalChart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Panel.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Panel.ImageBevel.Brush.Solid = true;
            SignalChart1.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Panel.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Panel.Shadow.Brush.Solid = true;
            SignalChart1.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            SignalChart1.Printer.Margins = margins1;
            SignalChart1.Size = new Size(895, 423);
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.SubFooter.Brush.Color = Color.Silver;
            SignalChart1.SubFooter.Brush.Solid = true;
            SignalChart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.SubFooter.Font.Brush.Color = Color.Red;
            SignalChart1.SubFooter.Font.Brush.Solid = true;
            SignalChart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.SubFooter.Font.Shadow.Brush.Solid = true;
            SignalChart1.SubFooter.Font.Shadow.Brush.Visible = true;
            SignalChart1.SubFooter.Font.Size = 8;
            SignalChart1.SubFooter.Font.SizeFloat = 8F;
            SignalChart1.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.SubFooter.ImageBevel.Brush.Solid = true;
            SignalChart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.SubFooter.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.SubFooter.Shadow.Brush.Solid = true;
            SignalChart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.SubHeader.Brush.Color = Color.FromArgb(192, 192, 192);
            SignalChart1.SubHeader.Brush.Solid = true;
            SignalChart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            SignalChart1.SubHeader.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SignalChart1.SubHeader.Font.Brush.Solid = true;
            SignalChart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.SubHeader.Font.Shadow.Brush.Solid = true;
            SignalChart1.SubHeader.Font.Shadow.Brush.Visible = true;
            SignalChart1.SubHeader.Font.Size = 12;
            SignalChart1.SubHeader.Font.SizeFloat = 12F;
            SignalChart1.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.SubHeader.ImageBevel.Brush.Solid = true;
            SignalChart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.SubHeader.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            SignalChart1.SubHeader.Shadow.Brush.Solid = true;
            SignalChart1.SubHeader.Shadow.Brush.Visible = true;
            SignalChart1.TabIndex = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Walls.Back.Brush.Color = Color.Silver;
            SignalChart1.Walls.Back.Brush.Solid = true;
            SignalChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Walls.Back.ImageBevel.Brush.Solid = true;
            SignalChart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Walls.Back.Shadow.Brush.Solid = true;
            SignalChart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Walls.Bottom.Brush.Color = Color.White;
            SignalChart1.Walls.Bottom.Brush.Solid = true;
            SignalChart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            SignalChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Walls.Bottom.Shadow.Brush.Solid = true;
            SignalChart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Walls.Left.Brush.Color = Color.LightYellow;
            SignalChart1.Walls.Left.Brush.Solid = true;
            SignalChart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Walls.Left.ImageBevel.Brush.Solid = true;
            SignalChart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Walls.Left.Shadow.Brush.Solid = true;
            SignalChart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Walls.Right.Brush.Color = Color.LightYellow;
            SignalChart1.Walls.Right.Brush.Solid = true;
            SignalChart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
            SignalChart1.Walls.Right.ImageBevel.Brush.Solid = true;
            SignalChart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalChart1.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
            SignalChart1.Walls.Right.Shadow.Brush.Solid = true;
            SignalChart1.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            SignalChart1.Zoom.Animated = true;
            // 
            // 
            // 
            SignalChart1.Zoom.Brush.Color = Color.LightBlue;
            SignalChart1.Zoom.Brush.Solid = true;
            SignalChart1.Zoom.Brush.Visible = false;
            SignalChart1.Zoom.History = true;
            // 
            // 
            // 
            SignalChart1.Zoom.Pen.Visible = true;
            // 
            // ChartEditor
            // 
            ChartEditor.AlwaysShowFuncSrc = false;
            ChartEditor.Chart = SignalChart1;
            ChartEditor.HighLightTabs = false;
            ChartEditor.Location = new Point(0, 0);
            ChartEditor.Name = "ChartEditor";
            ChartEditor.Options = null;
            ChartEditor.TabIndex = 0;
            // 
            // PhaseDemoForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(895, 543);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Name = "PhaseDemoForm";
            Text = "PhaseDemoForm";
            Load += PhaseDemoForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((ISupportInitialize)SignalChart1).EndInit();
            ResumeLayout(false);

        }
        #endregion

        private void zeroPadEdit_TextChanged(object sender, System.EventArgs e) {
			TVec h,resp,amplt,phase;
		   MtxVec.CreateIt(out h,out resp,out amplt, out phase);
			try {
				h.Length = firLengthEdit.IntPosition;
				SignalUtils.FirImpulse(h,new double[]{0.25,0.28},TFilterType.ftLowpass,2);
				double actualZeroPadding = SignalUtils.FrequencyResponse(h,null,resp,
					(int)(Math387.Exp2(zeroPadEdit.IntPosition)),false,TSignalWindowType.wtRectangular, 40);
				phase.PhaseSpectrum(resp);
				phase.Scale(180/Math.PI);
				SignalUtils.PhaseUnwrap(phase,amplt,TRunningPhase.rpConstPhase,actualZeroPadding*h.Length/(h.Length-1),false,180);
				SignalChart1.Series[0].Clear();
				DrawValues(amplt,SignalChart1.Series[0],0,1,false);
			} finally {
				MtxVec.FreeIt(ref h,ref resp,ref amplt,ref phase);
			}
		}

        private void ChartButton_Click(object sender, EventArgs e)
        {
            ChartEditor.ShowModal();
        }

        protected void Add(String s)
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void PhaseDemoForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("The package also provides phase unwrapping algorithm. "
                + "The example below shows the phase of a lowpass FIR filter. "
                + "In the passband, the linear phase is clearly visible. "
                + "The success of phase unwrapping stronly depends upon the level of zero padding.");
        }

	}
}
