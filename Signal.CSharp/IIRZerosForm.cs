using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Dew.Signal;
using Dew.Math;
using Dew.Signal.Units;
using Dew.Math.Units;
using Dew.Signal.Tee;
using Dew.Math.Controls;
using Dew.Math.Tee;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for IIRZerosForm.
	/// </summary>
	public class IIRZerosForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private Steema.TeeChart.TChart tChart1;
		private Steema.TeeChart.Styles.Polar polar1;
		private Steema.TeeChart.Styles.Polar polar2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private FloatEdit orderEdit;
		private FloatEdit attEdit;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox filterComboBox;
        private Button ChartButton;
        private Steema.TeeChart.Editor ChartEditor;
        private IContainer components;

		public IIRZerosForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            tChart1.Axes.Left.Grid.Visible = true;
            tChart1.Axes.Bottom.Grid.Visible = true;
            //tChart1.Axes.Top.Grid.Visible = false;
            //tChart1.Axes.Right.Grid.Visible = false;

			filterComboBox.SelectedIndex = 0;
			FillSeries(5,40);
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

		private void FillSeries(int order, int att) {
			TVec z,p,r,phi;
			double k = 0;
			MtxVec.CreateIt(out z, out p, out r, out phi);
			try {
				switch ((TIirFilterMethod)filterComboBox.SelectedIndex) {
					case TIirFilterMethod.fimButter:
						IIRFilters.ButterFilter(order, new double[]{0.2},TFilterType.ftLowpass, false, z, p, out k, TIirFrequencyTransform.ftStateSpaceAnalog);
						break;
					case TIirFilterMethod.fimChebyshevI:
						IIRFilters.ChebyshevIFilter(order, 0.1, new double[]{0.2},TFilterType.ftLowpass, false, z, p, out k, TIirFrequencyTransform.ftStateSpaceAnalog);
						break;
					case TIirFilterMethod.fimChebyshevII:
						IIRFilters.ChebyshevIIFilter(order, att, new double[]{0.2},TFilterType.ftLowpass, false, z, p, out k, TIirFrequencyTransform.ftStateSpaceAnalog);
						break;
					case TIirFilterMethod.fimElliptic:
						IIRFilters.EllipticFilter(order, 0.1, att, new double[]{0.2},TFilterType.ftLowpass, false, z, p, ref k, TIirFrequencyTransform.ftStateSpaceAnalog);
						break;
				}
				if (!z.Complex) z.ExtendToComplex(true);
				z.CartToPolar(r, phi);
				phi.Scale(180.0 / Math.PI);
				MtxVecTee.DrawValues(phi, r, tChart1.Series[0], false);
				if (!p.Complex) p.ExtendToComplex(true);
				p.CartToPolar(r, phi);
				phi.Scale(180.0 / Math.PI);
				MtxVecTee.DrawValues(phi, r, tChart1.Series[1], false);
			} finally {
				MtxVec.FreeIt(ref z, ref p, ref r, ref phi);
			}
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IIRZerosForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChartButton = new System.Windows.Forms.Button();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.orderEdit = new Dew.Math.Controls.FloatEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.attEdit = new Dew.Math.Controls.FloatEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.tChart1 = new Steema.TeeChart.TChart();
            this.polar1 = new Steema.TeeChart.Styles.Polar();
            this.polar2 = new Steema.TeeChart.Styles.Polar();
            this.ChartEditor = new Steema.TeeChart.Editor(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(787, 118);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChartButton);
            this.panel1.Controls.Add(this.filterComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.orderEdit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.attEdit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 496);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 53);
            this.panel1.TabIndex = 1;
            // 
            // ChartButton
            // 
            this.ChartButton.Location = new System.Drawing.Point(14, 15);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(90, 28);
            this.ChartButton.TabIndex = 8;
            this.ChartButton.Text = "Chart...";
            this.ChartButton.UseVisualStyleBackColor = true;
            this.ChartButton.Click += new System.EventHandler(this.ChartButton_Click);
            // 
            // filterComboBox
            // 
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.Items.AddRange(new object[] {
            "Butterworth",
            "Chebyshev I",
            "Chebyshev II",
            "Elliptic"});
            this.filterComboBox.Location = new System.Drawing.Point(232, 16);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(145, 23);
            this.filterComboBox.TabIndex = 7;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(174, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filter:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderEdit
            // 
            this.orderEdit.Increment = "1";
            this.orderEdit.Location = new System.Drawing.Point(448, 16);
            this.orderEdit.Name = "orderEdit";
            this.orderEdit.ReFormat = "#";
            this.orderEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.orderEdit.Scientific = false;
            this.orderEdit.Size = new System.Drawing.Size(86, 23);
            this.orderEdit.TabIndex = 4;
            this.orderEdit.Value = "5";
            this.orderEdit.TextChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(395, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // attEdit
            // 
            this.attEdit.Increment = "1";
            this.attEdit.Location = new System.Drawing.Point(659, 16);
            this.attEdit.Name = "attEdit";
            this.attEdit.ReFormat = "0#;-0#";
            this.attEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.attEdit.Scientific = false;
            this.attEdit.Size = new System.Drawing.Size(86, 23);
            this.attEdit.TabIndex = 5;
            this.attEdit.Value = "40";
            this.attEdit.TextChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(544, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Attenuation [dB]:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.Elevation = 315;
            this.tChart1.Aspect.ElevationFloat = 315D;
            this.tChart1.Aspect.Orthogonal = false;
            this.tChart1.Aspect.Perspective = 0;
            this.tChart1.Aspect.Rotation = 360;
            this.tChart1.Aspect.RotationFloat = 360D;
            // 
            // 
            // 
            this.tChart1.Axes.Automatic = false;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Automatic = false;
            this.tChart1.Axes.Bottom.AutomaticMaximum = false;
            this.tChart1.Axes.Bottom.AutomaticMinimum = false;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Grid.Visible = false;
            this.tChart1.Axes.Bottom.Increment = 15D;
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
            this.tChart1.Axes.Bottom.Labels.OnAxis = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.tChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            this.tChart1.Axes.Bottom.Maximum = 1D;
            this.tChart1.Axes.Bottom.Minimum = 0D;
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
            this.tChart1.Axes.Depth.Automatic = false;
            this.tChart1.Axes.Depth.AutomaticMaximum = false;
            this.tChart1.Axes.Depth.AutomaticMinimum = false;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.AxisPen.Visible = false;
            this.tChart1.Axes.Depth.Increment = 0.2D;
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
            this.tChart1.Axes.Depth.Maximum = 1D;
            this.tChart1.Axes.Depth.Minimum = 0D;
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
            this.tChart1.Axes.DepthTop.Automatic = false;
            this.tChart1.Axes.DepthTop.AutomaticMaximum = false;
            this.tChart1.Axes.DepthTop.AutomaticMinimum = false;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.AxisPen.Visible = false;
            this.tChart1.Axes.DepthTop.Increment = 0.2D;
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
            this.tChart1.Axes.DepthTop.Maximum = 1D;
            this.tChart1.Axes.DepthTop.Minimum = 0D;
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
            this.tChart1.Axes.Left.Automatic = false;
            this.tChart1.Axes.Left.AutomaticMaximum = false;
            this.tChart1.Axes.Left.AutomaticMinimum = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.AxisPen.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Grid.Visible = false;
            this.tChart1.Axes.Left.Increment = 0.2D;
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
            this.tChart1.Axes.Left.Maximum = 1.05D;
            this.tChart1.Axes.Left.Minimum = 0D;
            // 
            // 
            // 
            this.tChart1.Axes.Left.MinorTicks.Length = 2;
            this.tChart1.Axes.Left.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Ticks.Length = 5;
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
            this.tChart1.Axes.Left.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Automatic = false;
            this.tChart1.Axes.Right.AutomaticMaximum = false;
            this.tChart1.Axes.Right.AutomaticMinimum = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.AxisPen.Visible = false;
            this.tChart1.Axes.Right.Increment = 0.2D;
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
            this.tChart1.Axes.Right.Maximum = 1D;
            this.tChart1.Axes.Right.Minimum = 0D;
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
            this.tChart1.Axes.Right.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Automatic = false;
            this.tChart1.Axes.Top.AutomaticMaximum = false;
            this.tChart1.Axes.Top.AutomaticMinimum = false;
            this.tChart1.Axes.Top.Increment = 0.2D;
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
            this.tChart1.Axes.Top.Maximum = 1D;
            this.tChart1.Axes.Top.Minimum = 0D;
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
            this.tChart1.Axes.Top.Visible = false;
            this.tChart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
        "Pole-zero plot"};
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
            this.tChart1.Location = new System.Drawing.Point(0, 118);
            this.tChart1.Name = "tChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Gradient.UseMiddle = true;
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
            this.tChart1.Series.Add(this.polar1);
            this.tChart1.Series.Add(this.polar2);
            this.tChart1.Size = new System.Drawing.Size(787, 378);
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
            this.tChart1.TabIndex = 2;
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
            this.tChart1.Click += new System.EventHandler(this.tChart1_Click);
            // 
            // polar1
            // 
            // 
            // 
            // 
            this.polar1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.polar1.Brush.ForegroundColor = System.Drawing.Color.Transparent;
            this.polar1.Brush.Solid = false;
            this.polar1.Brush.Style = Steema.TeeChart.Drawing.HatchStyle.Horizontal;
            this.polar1.Brush.Visible = false;
            this.polar1.Circled = true;
            // 
            // 
            // 
            this.polar1.CircleLabelsFont.Bold = false;
            // 
            // 
            // 
            this.polar1.CircleLabelsFont.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.polar1.CircleLabelsFont.Brush.Solid = true;
            this.polar1.CircleLabelsFont.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.CircleLabelsFont.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.polar1.CircleLabelsFont.Shadow.Brush.Solid = true;
            this.polar1.CircleLabelsFont.Shadow.Brush.Visible = true;
            this.polar1.CircleLabelsFont.Size = 8;
            this.polar1.CircleLabelsFont.SizeFloat = 8F;
            this.polar1.CircleLabelsFont.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            this.polar1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.polar1.ColorEach = false;
            cursor1.CursorType = Steema.TeeChart.Drawing.CursorType.Default;
            this.polar1.Cursor = cursor1;
            // 
            // 
            // 
            this.polar1.Font.Bold = false;
            // 
            // 
            // 
            this.polar1.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.polar1.Font.Brush.Solid = true;
            this.polar1.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.polar1.Font.Shadow.Brush.Solid = true;
            this.polar1.Font.Shadow.Brush.Visible = true;
            this.polar1.Font.Size = 8;
            this.polar1.Font.SizeFloat = 8F;
            this.polar1.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            this.polar1.Frame.Circled = true;
            this.polar1.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
            // 
            // 
            // 
            this.polar1.Frame.InnerBand.Color = System.Drawing.Color.Gray;
            this.polar1.Frame.InnerBand.Solid = true;
            this.polar1.Frame.InnerBand.Visible = true;
            // 
            // 
            // 
            this.polar1.Frame.MiddleBand.Color = System.Drawing.Color.Gray;
            // 
            // 
            // 
            this.polar1.Frame.MiddleBand.Gradient.UseMiddle = true;
            this.polar1.Frame.MiddleBand.Gradient.Visible = true;
            this.polar1.Frame.MiddleBand.Solid = true;
            this.polar1.Frame.MiddleBand.Visible = true;
            // 
            // 
            // 
            this.polar1.Frame.OuterBand.Color = System.Drawing.Color.Gray;
            // 
            // 
            // 
            this.polar1.Frame.OuterBand.Gradient.Visible = true;
            this.polar1.Frame.OuterBand.Solid = true;
            this.polar1.Frame.OuterBand.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Legend.Brush.Color = System.Drawing.Color.White;
            this.polar1.Legend.Brush.Solid = true;
            this.polar1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.polar1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.polar1.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.polar1.Legend.Font.Brush.Solid = true;
            this.polar1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.polar1.Legend.Font.Shadow.Brush.Solid = true;
            this.polar1.Legend.Font.Shadow.Brush.Visible = true;
            this.polar1.Legend.Font.Size = 8;
            this.polar1.Legend.Font.SizeFloat = 8F;
            this.polar1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.polar1.Legend.ImageBevel.Brush.Solid = true;
            this.polar1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.polar1.Legend.Shadow.Brush.Solid = true;
            this.polar1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Marks.Arrow.Visible = false;
            // 
            // 
            // 
            this.polar1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.polar1.Marks.Brush.Solid = true;
            this.polar1.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.polar1.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.polar1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.polar1.Marks.Font.Brush.Solid = true;
            this.polar1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.polar1.Marks.Font.Shadow.Brush.Solid = true;
            this.polar1.Marks.Font.Shadow.Brush.Visible = true;
            this.polar1.Marks.Font.Size = 8;
            this.polar1.Marks.Font.SizeFloat = 8F;
            this.polar1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.polar1.Marks.ImageBevel.Brush.Solid = true;
            this.polar1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Marks.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.polar1.Marks.Shadow.Brush.Solid = true;
            this.polar1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.polar1.Marks.Symbol.Brush.Solid = true;
            this.polar1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.polar1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.polar1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.polar1.Marks.Symbol.Shadow.Brush.Solid = true;
            this.polar1.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.polar1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
            this.polar1.Marks.TailParams.Margin = 0F;
            this.polar1.Marks.TailParams.PointerHeight = 8D;
            this.polar1.Marks.TailParams.PointerWidth = 8D;
            this.polar1.OriginalCursor = cursor1;
            // 
            // 
            // 
            this.polar1.Pen.Color = System.Drawing.Color.White;
            this.polar1.Pen.Visible = false;
            this.polar1.Pen.Width = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.polar1.Pointer.Brush.Solid = true;
            this.polar1.Pointer.Brush.Visible = true;
            this.polar1.Pointer.Dark3D = false;
            this.polar1.Pointer.Draw3D = false;
            this.polar1.Pointer.HorizSize = 3;
            this.polar1.Pointer.InflateMargins = false;
            // 
            // 
            // 
            this.polar1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.polar1.Pointer.Pen.Visible = false;
            this.polar1.Pointer.SizeDouble = 0D;
            this.polar1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.polar1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Diamond;
            this.polar1.Pointer.VertSize = 3;
            this.polar1.RandomData = true;
            this.polar1.Title = "Zeroes";
            this.polar1.Type = "Steema.TeeChart.Styles.Polar";
            this.polar1.UniqueCustomRadius = true;
            this.polar1.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.polar1.XValues.DataMember = "Angle";
            this.polar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.polar1.XValues.Series = this.polar1;
            // 
            // 
            // 
            this.polar1.YValues.DataMember = "Y";
            this.polar1.YValues.Series = this.polar1;
            // 
            // polar2
            // 
            // 
            // 
            // 
            this.polar2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.polar2.Brush.Solid = true;
            this.polar2.Brush.Visible = false;
            this.polar2.CircleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.polar2.Circled = true;
            // 
            // 
            // 
            this.polar2.CircleLabelsFont.Bold = false;
            // 
            // 
            // 
            this.polar2.CircleLabelsFont.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.polar2.CircleLabelsFont.Brush.Solid = true;
            this.polar2.CircleLabelsFont.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.CircleLabelsFont.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.polar2.CircleLabelsFont.Shadow.Brush.Solid = true;
            this.polar2.CircleLabelsFont.Shadow.Brush.Visible = true;
            this.polar2.CircleLabelsFont.Size = 8;
            this.polar2.CircleLabelsFont.SizeFloat = 8F;
            this.polar2.CircleLabelsFont.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            this.polar2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.polar2.ColorEach = false;
            this.polar2.Cursor = cursor1;
            // 
            // 
            // 
            this.polar2.Font.Bold = false;
            // 
            // 
            // 
            this.polar2.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.polar2.Font.Brush.Solid = true;
            this.polar2.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.polar2.Font.Shadow.Brush.Solid = true;
            this.polar2.Font.Shadow.Brush.Visible = true;
            this.polar2.Font.Size = 8;
            this.polar2.Font.SizeFloat = 8F;
            this.polar2.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            this.polar2.Frame.Circled = true;
            this.polar2.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
            // 
            // 
            // 
            this.polar2.Frame.InnerBand.Color = System.Drawing.Color.Gray;
            this.polar2.Frame.InnerBand.Solid = true;
            this.polar2.Frame.InnerBand.Visible = true;
            // 
            // 
            // 
            this.polar2.Frame.MiddleBand.Color = System.Drawing.Color.Gray;
            // 
            // 
            // 
            this.polar2.Frame.MiddleBand.Gradient.UseMiddle = true;
            this.polar2.Frame.MiddleBand.Gradient.Visible = true;
            this.polar2.Frame.MiddleBand.Solid = true;
            this.polar2.Frame.MiddleBand.Visible = true;
            // 
            // 
            // 
            this.polar2.Frame.OuterBand.Color = System.Drawing.Color.Gray;
            // 
            // 
            // 
            this.polar2.Frame.OuterBand.Gradient.Visible = true;
            this.polar2.Frame.OuterBand.Solid = true;
            this.polar2.Frame.OuterBand.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Legend.Brush.Color = System.Drawing.Color.White;
            this.polar2.Legend.Brush.Solid = true;
            this.polar2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.polar2.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.polar2.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.polar2.Legend.Font.Brush.Solid = true;
            this.polar2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.polar2.Legend.Font.Shadow.Brush.Solid = true;
            this.polar2.Legend.Font.Shadow.Brush.Visible = true;
            this.polar2.Legend.Font.Size = 8;
            this.polar2.Legend.Font.SizeFloat = 8F;
            this.polar2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.polar2.Legend.ImageBevel.Brush.Solid = true;
            this.polar2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.polar2.Legend.Shadow.Brush.Solid = true;
            this.polar2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.polar2.Marks.Brush.Solid = true;
            this.polar2.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.polar2.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.polar2.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.polar2.Marks.Font.Brush.Solid = true;
            this.polar2.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.polar2.Marks.Font.Shadow.Brush.Solid = true;
            this.polar2.Marks.Font.Shadow.Brush.Visible = true;
            this.polar2.Marks.Font.Size = 8;
            this.polar2.Marks.Font.SizeFloat = 8F;
            this.polar2.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.polar2.Marks.ImageBevel.Brush.Solid = true;
            this.polar2.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Marks.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.polar2.Marks.Shadow.Brush.Solid = true;
            this.polar2.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.polar2.Marks.Symbol.Brush.Solid = true;
            this.polar2.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.polar2.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.polar2.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.polar2.Marks.Symbol.Shadow.Brush.Solid = true;
            this.polar2.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.polar2.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
            this.polar2.Marks.TailParams.Margin = 0F;
            this.polar2.Marks.TailParams.PointerHeight = 8D;
            this.polar2.Marks.TailParams.PointerWidth = 8D;
            this.polar2.OriginalCursor = cursor1;
            // 
            // 
            // 
            this.polar2.Pen.Color = System.Drawing.Color.Yellow;
            this.polar2.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.polar2.Pointer.Brush.Solid = true;
            this.polar2.Pointer.Brush.Visible = true;
            this.polar2.Pointer.HorizSize = 3;
            this.polar2.Pointer.SizeDouble = 0D;
            this.polar2.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.polar2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.polar2.Pointer.VertSize = 3;
            this.polar2.RandomData = true;
            this.polar2.Title = "Poles";
            this.polar2.Type = "Steema.TeeChart.Styles.Polar";
            this.polar2.UniqueCustomRadius = true;
            this.polar2.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.polar2.XValues.DataMember = "Angle";
            this.polar2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.polar2.XValues.Series = this.polar2;
            // 
            // 
            // 
            this.polar2.YValues.DataMember = "Y";
            this.polar2.YValues.Series = this.polar2;
            // 
            // ChartEditor
            // 
            this.ChartEditor.AlwaysShowFuncSrc = false;
            this.ChartEditor.Chart = this.tChart1;
            this.ChartEditor.HighLightTabs = false;
            this.ChartEditor.Location = new System.Drawing.Point(0, 0);
            this.ChartEditor.Name = "ChartEditor";
            this.ChartEditor.Options = null;
            this.ChartEditor.TabIndex = 0;
            // 
            // IIRZerosForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(787, 549);
            this.Controls.Add(this.tChart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "IIRZerosForm";
            this.Text = "IIRZerosForm";
            this.Load += new System.EventHandler(this.IIRZerosForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void filterComboBox_SelectedIndexChanged(object sender, System.EventArgs e) {
			FillSeries(orderEdit.IntPosition,attEdit.IntPosition);
		}

        private void tChart1_Click(object sender, EventArgs e)
        {

        }

        private void ChartButton_Click(object sender, EventArgs e)
        {
            ChartEditor.ShowModal();
        }

        protected void Add(String s)
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void IIRZerosForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("DSP Master features 4 different filter design "
            + "methods for infinite impulse response filters: "
            + "Butterworth, Chebyshev type I and type II and elliptic filters. "
            + "Change the order and attenuation in the stop band of a low-pass "
            + "IIR filter designed with all 4 methods.");
        }
	}
}
