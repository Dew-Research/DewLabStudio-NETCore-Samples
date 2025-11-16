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
using static Dew.Math.Tee.MtxVecTee;

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
				DrawValues(phi, r, tChart1.Series[0], false);
				if (!p.Complex) p.ExtendToComplex(true);
				p.CartToPolar(r, phi);
				phi.Scale(180.0 / Math.PI);
				DrawValues(phi, r, tChart1.Series[1], false);
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
            components = new Container();
            Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(IIRZerosForm));
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            ChartButton = new Button();
            filterComboBox = new ComboBox();
            label3 = new Label();
            orderEdit = new FloatEdit();
            label1 = new Label();
            attEdit = new FloatEdit();
            label2 = new Label();
            tChart1 = new Steema.TeeChart.TChart();
            polar1 = new Steema.TeeChart.Styles.Polar();
            polar2 = new Steema.TeeChart.Styles.Polar();
            ChartEditor = new Steema.TeeChart.Editor(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Top;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1139, 118);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            panel1.Controls.Add(ChartButton);
            panel1.Controls.Add(filterComboBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(orderEdit);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(attEdit);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 830);
            panel1.Name = "panel1";
            panel1.Size = new Size(1139, 53);
            panel1.TabIndex = 1;
            // 
            // ChartButton
            // 
            ChartButton.Location = new Point(14, 15);
            ChartButton.Name = "ChartButton";
            ChartButton.Size = new Size(90, 28);
            ChartButton.TabIndex = 8;
            ChartButton.Text = "Chart...";
            ChartButton.UseVisualStyleBackColor = true;
            ChartButton.Click += ChartButton_Click;
            // 
            // filterComboBox
            // 
            filterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            filterComboBox.Items.AddRange(new object[] { "Butterworth", "Chebyshev I", "Chebyshev II", "Elliptic" });
            filterComboBox.Location = new Point(232, 16);
            filterComboBox.Name = "filterComboBox";
            filterComboBox.Size = new Size(145, 23);
            filterComboBox.TabIndex = 7;
            filterComboBox.SelectedIndexChanged += filterComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Location = new Point(174, 16);
            label3.Name = "label3";
            label3.Size = new Size(48, 26);
            label3.TabIndex = 6;
            label3.Text = "Filter:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // orderEdit
            // 
            orderEdit.Increment = "1";
            orderEdit.Location = new Point(448, 16);
            orderEdit.Name = "orderEdit";
            orderEdit.ReFormat = "#";
            orderEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            orderEdit.Scientific = false;
            orderEdit.Size = new Size(86, 23);
            orderEdit.TabIndex = 4;
            orderEdit.Value = "5";
            orderEdit.TextChanged += filterComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Location = new Point(395, 16);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 3;
            label1.Text = "Order:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // attEdit
            // 
            attEdit.Increment = "1";
            attEdit.Location = new Point(659, 16);
            attEdit.Name = "attEdit";
            attEdit.ReFormat = "0#;-0#";
            attEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            attEdit.Scientific = false;
            attEdit.Size = new Size(86, 23);
            attEdit.TabIndex = 5;
            attEdit.Value = "40";
            attEdit.TextChanged += filterComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Location = new Point(544, 16);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 2;
            label2.Text = "Attenuation [dB]:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tChart1
            // 
            // 
            // 
            // 
            tChart1.Aspect.Elevation = 315;
            tChart1.Aspect.ElevationFloat = 315D;
            tChart1.Aspect.Orthogonal = false;
            tChart1.Aspect.Perspective = 0;
            tChart1.Aspect.Rotation = 360;
            tChart1.Aspect.RotationFloat = 360D;
            // 
            // 
            // 
            tChart1.Axes.Automatic = false;
            // 
            // 
            // 
            tChart1.Axes.Bottom.Automatic = false;
            tChart1.Axes.Bottom.AutomaticMaximum = false;
            tChart1.Axes.Bottom.AutomaticMinimum = false;
            tChart1.Axes.Bottom.Increment = 15D;
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
            tChart1.Axes.Bottom.Labels.OnAxis = false;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            tChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            tChart1.Axes.Bottom.Maximum = 1D;
            tChart1.Axes.Bottom.Minimum = 0D;
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
            tChart1.Axes.Depth.Automatic = false;
            tChart1.Axes.Depth.AutomaticMaximum = false;
            tChart1.Axes.Depth.AutomaticMinimum = false;
            tChart1.Axes.Depth.Increment = 0.2D;
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
            tChart1.Axes.Depth.Maximum = 1D;
            tChart1.Axes.Depth.Minimum = 0D;
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
            tChart1.Axes.DepthTop.Automatic = false;
            tChart1.Axes.DepthTop.AutomaticMaximum = false;
            tChart1.Axes.DepthTop.AutomaticMinimum = false;
            tChart1.Axes.DepthTop.Increment = 0.2D;
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
            tChart1.Axes.DepthTop.Maximum = 1D;
            tChart1.Axes.DepthTop.Minimum = 0D;
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
            tChart1.Axes.Left.Automatic = false;
            tChart1.Axes.Left.AutomaticMaximum = false;
            tChart1.Axes.Left.AutomaticMinimum = false;
            // 
            // 
            // 
            tChart1.Axes.Left.Grid.Visible = false;
            tChart1.Axes.Left.Increment = 0.2D;
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
            tChart1.Axes.Left.Maximum = 1.05D;
            tChart1.Axes.Left.Minimum = 0D;
            // 
            // 
            // 
            tChart1.Axes.Left.Ticks.Length = 5;
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
            tChart1.Axes.Left.Visible = false;
            // 
            // 
            // 
            tChart1.Axes.Right.Automatic = false;
            tChart1.Axes.Right.AutomaticMaximum = false;
            tChart1.Axes.Right.AutomaticMinimum = false;
            tChart1.Axes.Right.Increment = 0.2D;
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
            tChart1.Axes.Right.Maximum = 1D;
            tChart1.Axes.Right.Minimum = 0D;
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
            tChart1.Axes.Right.Visible = false;
            // 
            // 
            // 
            tChart1.Axes.Top.Automatic = false;
            tChart1.Axes.Top.AutomaticMaximum = false;
            tChart1.Axes.Top.AutomaticMinimum = false;
            tChart1.Axes.Top.Increment = 0.2D;
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
            tChart1.Axes.Top.Maximum = 1D;
            tChart1.Axes.Top.Minimum = 0D;
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
            tChart1.Axes.Top.Visible = false;
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
            tChart1.Header.Font.Brush.Color = Color.FromArgb(255, 255, 255);
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
    "Pole-zero plot"
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
            tChart1.Location = new Point(0, 118);
            tChart1.Name = "tChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            // 
            // 
            // 
            tChart1.Panel.Brush.Color = Color.FromArgb(192, 192, 192);
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
            tChart1.Series.Add(polar1);
            tChart1.Series.Add(polar2);
            tChart1.Size = new Size(1139, 712);
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
            tChart1.TabIndex = 2;
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
            tChart1.Zoom.Brush.Color = Color.FromArgb(150, 173, 216, 230);
            tChart1.Zoom.Brush.Solid = true;
            tChart1.Zoom.Brush.Visible = true;
            tChart1.Click += tChart1_Click;
            // 
            // polar1
            // 
            // 
            // 
            // 
            polar1.Brush.Color = Color.FromArgb(68, 102, 163);
            polar1.Brush.ForegroundColor = Color.Transparent;
            polar1.Brush.Solid = false;
            polar1.Brush.Visible = false;
            polar1.Circled = true;
            // 
            // 
            // 
            polar1.CircleLabelsFont.Bold = false;
            // 
            // 
            // 
            polar1.CircleLabelsFont.Brush.Color = Color.FromArgb(0, 0, 0);
            polar1.CircleLabelsFont.Brush.Solid = true;
            polar1.CircleLabelsFont.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.CircleLabelsFont.Shadow.Brush.Color = Color.DarkGray;
            polar1.CircleLabelsFont.Shadow.Brush.Solid = true;
            polar1.CircleLabelsFont.Shadow.Brush.Visible = true;
            polar1.CircleLabelsFont.Size = 8;
            polar1.CircleLabelsFont.SizeFloat = 8F;
            polar1.CircleLabelsFont.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            polar1.Color = Color.FromArgb(68, 102, 163);
            polar1.Cursor = cursor1;
            // 
            // 
            // 
            polar1.Font.Bold = false;
            // 
            // 
            // 
            polar1.Font.Brush.Color = Color.FromArgb(0, 0, 0);
            polar1.Font.Brush.Solid = true;
            polar1.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Font.Shadow.Brush.Color = Color.DarkGray;
            polar1.Font.Shadow.Brush.Solid = true;
            polar1.Font.Shadow.Brush.Visible = true;
            polar1.Font.Size = 8;
            polar1.Font.SizeFloat = 8F;
            polar1.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            polar1.Frame.Circled = true;
            polar1.Frame.FrameElementPercents = new double[]
    {
    25D,
    60D,
    15D
    };
            // 
            // 
            // 
            polar1.Frame.InnerBand.Color = Color.Gray;
            polar1.Frame.InnerBand.Solid = true;
            polar1.Frame.InnerBand.Visible = true;
            // 
            // 
            // 
            polar1.Frame.OuterBand.Color = Color.Gray;
            // 
            // 
            // 
            polar1.Frame.OuterBand.Gradient.Visible = true;
            polar1.Frame.OuterBand.Solid = true;
            polar1.Frame.OuterBand.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Legend.Brush.Color = Color.White;
            polar1.Legend.Brush.Solid = true;
            polar1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            polar1.Legend.Font.Bold = false;
            // 
            // 
            // 
            polar1.Legend.Font.Brush.Color = Color.Black;
            polar1.Legend.Font.Brush.Solid = true;
            polar1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            polar1.Legend.Font.Shadow.Brush.Solid = true;
            polar1.Legend.Font.Shadow.Brush.Visible = true;
            polar1.Legend.Font.Size = 8;
            polar1.Legend.Font.SizeFloat = 8F;
            polar1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Legend.ImageBevel.Brush.Color = Color.LightGray;
            polar1.Legend.ImageBevel.Brush.Solid = true;
            polar1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Legend.Shadow.Brush.Color = Color.DarkGray;
            polar1.Legend.Shadow.Brush.Solid = true;
            polar1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Marks.Arrow.Visible = false;
            // 
            // 
            // 
            polar1.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            polar1.Marks.Brush.Solid = true;
            polar1.Marks.Brush.Visible = true;
            // 
            // 
            // 
            polar1.Marks.Font.Bold = false;
            // 
            // 
            // 
            polar1.Marks.Font.Brush.Color = Color.FromArgb(0, 0, 0);
            polar1.Marks.Font.Brush.Solid = true;
            polar1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            polar1.Marks.Font.Shadow.Brush.Solid = true;
            polar1.Marks.Font.Shadow.Brush.Visible = true;
            polar1.Marks.Font.Size = 8;
            polar1.Marks.Font.SizeFloat = 8F;
            polar1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Marks.ImageBevel.Brush.Color = Color.LightGray;
            polar1.Marks.ImageBevel.Brush.Solid = true;
            polar1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Marks.Shadow.Brush.Color = Color.FromArgb(128, 128, 128);
            polar1.Marks.Shadow.Brush.Solid = true;
            polar1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Marks.Symbol.Brush.Color = Color.White;
            polar1.Marks.Symbol.Brush.Solid = true;
            polar1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            polar1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            polar1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            polar1.Marks.Symbol.Shadow.Brush.Solid = true;
            polar1.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            polar1.Pen.Color = Color.White;
            polar1.Pen.Visible = false;
            polar1.Pen.Width = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Pointer.Brush.Color = Color.FromArgb(254, 0, 0, 0);
            polar1.Pointer.Brush.Solid = true;
            polar1.Pointer.Brush.Visible = true;
            polar1.Pointer.Dark3D = false;
            polar1.Pointer.Draw3D = false;
            polar1.Pointer.HorizSize = 3;
            polar1.Pointer.InflateMargins = false;
            // 
            // 
            // 
            polar1.Pointer.Pen.Color = Color.FromArgb(254, 255, 0, 0);
            polar1.Pointer.Pen.Visible = false;
            polar1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Diamond;
            polar1.Pointer.VertSize = 3;
            polar1.Title = "Zeroes";
            polar1.UniqueCustomRadius = true;
            // 
            // 
            // 
            polar1.XValues.DataMember = "Angle";
            polar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            polar1.XValues.Value = new double[]
    {
    14.4D,
    28.8D,
    43.2D,
    57.6D,
    72D,
    86.4D,
    100.8D,
    115.2D,
    129.6D,
    144D,
    158.4D,
    172.8D,
    187.20000000000002D,
    201.6D,
    216D,
    230.4D,
    244.8D,
    259.2D,
    273.6D,
    288D,
    302.40000000000003D,
    316.8D,
    331.2D,
    345.6D,
    360D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            polar1.YValues.DataMember = "Y";
            polar1.YValues.Value = new double[]
    {
    111.74092570261142D,
    144.49384845397148D,
    202.77070945583785D,
    274.70823513423477D,
    152.22232826017884D,
    659.33305691291253D,
    986.71834340026521D,
    848.50124758458753D,
    311.82598693241641D,
    638.08418357981566D,
    285.39264990593892D,
    471.81602014173569D,
    752.53403205402844D,
    58.376786161855229D,
    236.52437137603962D,
    394.9597072982973D,
    400.070515483185D,
    771.3405375454297D,
    760.66677431001642D,
    16.472435399644279D,
    169.363746799698D,
    901.76318285463526D,
    685.31138744778525D,
    158.29531466834959D,
    80.209316093106438D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // polar2
            // 
            // 
            // 
            // 
            polar2.Brush.Color = Color.FromArgb(243, 156, 53);
            polar2.Brush.Solid = true;
            polar2.Brush.Visible = false;
            polar2.CircleBackColor = Color.FromArgb(0, 0, 0);
            polar2.Circled = true;
            // 
            // 
            // 
            polar2.CircleLabelsFont.Bold = false;
            // 
            // 
            // 
            polar2.CircleLabelsFont.Brush.Color = Color.FromArgb(0, 0, 0);
            polar2.CircleLabelsFont.Brush.Solid = true;
            polar2.CircleLabelsFont.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.CircleLabelsFont.Shadow.Brush.Color = Color.DarkGray;
            polar2.CircleLabelsFont.Shadow.Brush.Solid = true;
            polar2.CircleLabelsFont.Shadow.Brush.Visible = true;
            polar2.CircleLabelsFont.Size = 8;
            polar2.CircleLabelsFont.SizeFloat = 8F;
            polar2.CircleLabelsFont.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            polar2.Color = Color.FromArgb(243, 156, 53);
            polar2.Cursor = cursor1;
            // 
            // 
            // 
            polar2.Font.Bold = false;
            // 
            // 
            // 
            polar2.Font.Brush.Color = Color.FromArgb(0, 0, 0);
            polar2.Font.Brush.Solid = true;
            polar2.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Font.Shadow.Brush.Color = Color.DarkGray;
            polar2.Font.Shadow.Brush.Solid = true;
            polar2.Font.Shadow.Brush.Visible = true;
            polar2.Font.Size = 8;
            polar2.Font.SizeFloat = 8F;
            polar2.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            polar2.Frame.Circled = true;
            polar2.Frame.FrameElementPercents = new double[]
    {
    25D,
    60D,
    15D
    };
            // 
            // 
            // 
            polar2.Frame.InnerBand.Color = Color.Gray;
            polar2.Frame.InnerBand.Solid = true;
            polar2.Frame.InnerBand.Visible = true;
            // 
            // 
            // 
            polar2.Frame.OuterBand.Color = Color.Gray;
            // 
            // 
            // 
            polar2.Frame.OuterBand.Gradient.Visible = true;
            polar2.Frame.OuterBand.Solid = true;
            polar2.Frame.OuterBand.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Legend.Brush.Color = Color.White;
            polar2.Legend.Brush.Solid = true;
            polar2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            polar2.Legend.Font.Bold = false;
            // 
            // 
            // 
            polar2.Legend.Font.Brush.Color = Color.Black;
            polar2.Legend.Font.Brush.Solid = true;
            polar2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            polar2.Legend.Font.Shadow.Brush.Solid = true;
            polar2.Legend.Font.Shadow.Brush.Visible = true;
            polar2.Legend.Font.Size = 8;
            polar2.Legend.Font.SizeFloat = 8F;
            polar2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Legend.ImageBevel.Brush.Color = Color.LightGray;
            polar2.Legend.ImageBevel.Brush.Solid = true;
            polar2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Legend.Shadow.Brush.Color = Color.DarkGray;
            polar2.Legend.Shadow.Brush.Solid = true;
            polar2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            polar2.Marks.Brush.Solid = true;
            polar2.Marks.Brush.Visible = true;
            // 
            // 
            // 
            polar2.Marks.Font.Bold = false;
            // 
            // 
            // 
            polar2.Marks.Font.Brush.Color = Color.FromArgb(0, 0, 0);
            polar2.Marks.Font.Brush.Solid = true;
            polar2.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            polar2.Marks.Font.Shadow.Brush.Solid = true;
            polar2.Marks.Font.Shadow.Brush.Visible = true;
            polar2.Marks.Font.Size = 8;
            polar2.Marks.Font.SizeFloat = 8F;
            polar2.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Marks.ImageBevel.Brush.Color = Color.LightGray;
            polar2.Marks.ImageBevel.Brush.Solid = true;
            polar2.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Marks.Shadow.Brush.Color = Color.FromArgb(128, 128, 128);
            polar2.Marks.Shadow.Brush.Solid = true;
            polar2.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Marks.Symbol.Brush.Color = Color.White;
            polar2.Marks.Symbol.Brush.Solid = true;
            polar2.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            polar2.Marks.Symbol.ImageBevel.Brush.Solid = true;
            polar2.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            polar2.Marks.Symbol.Shadow.Brush.Solid = true;
            polar2.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            polar2.Pen.Color = Color.Yellow;
            polar2.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Pointer.Brush.Color = Color.FromArgb(255, 255, 0);
            polar2.Pointer.Brush.Solid = true;
            polar2.Pointer.Brush.Visible = true;
            polar2.Pointer.HorizSize = 3;
            polar2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            polar2.Pointer.VertSize = 3;
            polar2.Title = "Poles";
            polar2.UniqueCustomRadius = true;
            // 
            // 
            // 
            polar2.XValues.DataMember = "Angle";
            polar2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            polar2.XValues.Value = new double[]
    {
    14.4D,
    28.8D,
    43.2D,
    57.6D,
    72D,
    86.4D,
    100.8D,
    115.2D,
    129.6D,
    144D,
    158.4D,
    172.8D,
    187.20000000000002D,
    201.6D,
    216D,
    230.4D,
    244.8D,
    259.2D,
    273.6D,
    288D,
    302.40000000000003D,
    316.8D,
    331.2D,
    345.6D,
    360D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            polar2.YValues.DataMember = "Y";
            polar2.YValues.Value = new double[]
    {
    569.44436077794262D,
    317.24358860600904D,
    226.4745011336517D,
    478.86170545865866D,
    80.669922627354936D,
    644.59948767516744D,
    226.28865757644579D,
    878.454284521497D,
    277.20534146027887D,
    812.73171839291786D,
    835.9062836891535D,
    364.3763358757721D,
    10.223269768628883D,
    582.36484752472722D,
    323.78239416088087D,
    118.61943023540984D,
    259.69884726530819D,
    755.30955121028683D,
    572.536520296492D,
    686.87376628344589D,
    242.51404772024324D,
    473.77937478980954D,
    955.647611339878D,
    863.46977227855D,
    725.34867207163427D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // ChartEditor
            // 
            ChartEditor.AlwaysShowFuncSrc = false;
            ChartEditor.Chart = tChart1;
            ChartEditor.HighLightTabs = false;
            ChartEditor.Location = new Point(0, 0);
            ChartEditor.Name = "ChartEditor";
            ChartEditor.Options = null;
            ChartEditor.TabIndex = 0;
            // 
            // IIRZerosForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(1139, 883);
            Controls.Add(tChart1);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Name = "IIRZerosForm";
            Text = "IIRZerosForm";
            Load += IIRZerosForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);

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
