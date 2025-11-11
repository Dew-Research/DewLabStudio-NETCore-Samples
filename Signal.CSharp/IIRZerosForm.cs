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
            this.components = new System.ComponentModel.Container();
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
            this.richTextBox1.Size = new System.Drawing.Size(680, 96);
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
            this.panel1.Location = new System.Drawing.Point(0, 506);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 43);
            this.panel1.TabIndex = 1;
            // 
            // ChartButton
            // 
            this.ChartButton.Location = new System.Drawing.Point(12, 12);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(75, 23);
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
            this.filterComboBox.Location = new System.Drawing.Point(193, 13);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(121, 21);
            this.filterComboBox.TabIndex = 7;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(145, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filter:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderEdit
            // 
            this.orderEdit.Increment = "1";
            this.orderEdit.Location = new System.Drawing.Point(373, 13);
            this.orderEdit.Name = "orderEdit";
            this.orderEdit.ReFormat = "#";
            this.orderEdit.Scientific = false;
            this.orderEdit.Size = new System.Drawing.Size(72, 20);
            this.orderEdit.TabIndex = 4;
            this.orderEdit.Text = "5";
            this.orderEdit.Value = "5";
            this.orderEdit.TextChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(329, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // attEdit
            // 
            this.attEdit.Increment = "1";
            this.attEdit.Location = new System.Drawing.Point(549, 13);
            this.attEdit.Name = "attEdit";
            this.attEdit.ReFormat = "0#;-0#";
            this.attEdit.Scientific = false;
            this.attEdit.Size = new System.Drawing.Size(72, 20);
            this.attEdit.TabIndex = 5;
            this.attEdit.Text = "40";
            this.attEdit.Value = "40";
            this.attEdit.TextChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(453, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
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
            this.tChart1.Aspect.ElevationFloat = 315;
            this.tChart1.Aspect.Orthogonal = false;
            this.tChart1.Aspect.Perspective = 0;
            this.tChart1.Aspect.Rotation = 360;
            this.tChart1.Aspect.RotationFloat = 360;
            this.tChart1.Aspect.View3D = false;
            this.tChart1.Aspect.ZOffset = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Automatic = false;
            this.tChart1.Axes.Bottom.AutomaticMaximum = false;
            this.tChart1.Axes.Bottom.AutomaticMinimum = false;
            this.tChart1.Axes.Bottom.Increment = 15;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.OnAxis = false;
            this.tChart1.Axes.Bottom.Maximum = 1;
            this.tChart1.Axes.Bottom.Minimum = 0;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Automatic = false;
            this.tChart1.Axes.Depth.AutomaticMaximum = false;
            this.tChart1.Axes.Depth.AutomaticMinimum = false;
            this.tChart1.Axes.Depth.Increment = 0.2;
            this.tChart1.Axes.Depth.Maximum = 1;
            this.tChart1.Axes.Depth.Minimum = 0;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Automatic = false;
            this.tChart1.Axes.DepthTop.AutomaticMaximum = false;
            this.tChart1.Axes.DepthTop.AutomaticMinimum = false;
            this.tChart1.Axes.DepthTop.Increment = 0.2;
            this.tChart1.Axes.DepthTop.Maximum = 1;
            this.tChart1.Axes.DepthTop.Minimum = 0;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Automatic = false;
            this.tChart1.Axes.Left.AutomaticMaximum = false;
            this.tChart1.Axes.Left.AutomaticMinimum = false;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Grid.Visible = false;
            this.tChart1.Axes.Left.Increment = 0.2;
            this.tChart1.Axes.Left.Maximum = 1.05;
            this.tChart1.Axes.Left.Minimum = 0;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Ticks.Length = 5;
            this.tChart1.Axes.Left.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Automatic = false;
            this.tChart1.Axes.Right.AutomaticMaximum = false;
            this.tChart1.Axes.Right.AutomaticMinimum = false;
            this.tChart1.Axes.Right.Increment = 0.2;
            this.tChart1.Axes.Right.Maximum = 1;
            this.tChart1.Axes.Right.Minimum = 0;
            this.tChart1.Axes.Right.Visible = false;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Automatic = false;
            this.tChart1.Axes.Top.AutomaticMaximum = false;
            this.tChart1.Axes.Top.AutomaticMinimum = false;
            this.tChart1.Axes.Top.Increment = 0.2;
            this.tChart1.Axes.Top.Maximum = 1;
            this.tChart1.Axes.Top.Minimum = 0;
            this.tChart1.Axes.Top.Visible = false;
             
            this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Header.Lines = new string[] {
        "Pole-zero plot"};
            this.tChart1.Location = new System.Drawing.Point(0, 96);
            this.tChart1.Name = "tChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChart1.Series.Add(this.polar1);
            this.tChart1.Series.Add(this.polar2);
            this.tChart1.Size = new System.Drawing.Size(680, 410);
            this.tChart1.TabIndex = 2;
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
             
            this.polar1.Brush.Visible = false;
            this.polar1.Circled = true;
            this.polar1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.polar1.ColorEach = false;
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
            this.polar1.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.polar1.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.polar1.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.polar1.Marks.Callout.Distance = 0;
            this.polar1.Marks.Callout.Draw3D = false;
            this.polar1.Marks.Callout.Length = 10;
            this.polar1.Marks.Callout.Series = this.polar1;
            this.polar1.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.polar1.Marks.Callout.Visible = false;
            this.polar1.Marks.Series = this.polar1;
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
            this.polar1.Pointer.Dark3D = false;
            this.polar1.Pointer.Draw3D = false;
            this.polar1.Pointer.HorizSize = 3;
            this.polar1.Pointer.InflateMargins = false;
            // 
            // 
            // 
            this.polar1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.polar1.Pointer.Pen.Visible = false;
            this.polar1.Pointer.Series = this.polar1;
            this.polar1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Diamond;
            this.polar1.Pointer.VertSize = 3;
            this.polar1.Title = "Zeroes";
            // 
            // 
            // 
            this.polar1.XValues.DataMember = "Angle";
            this.polar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.polar1.YValues.DataMember = "Y";
            // 
            // polar2
            // 
            // 
            // 
            // 
            this.polar2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.polar2.Brush.Visible = false;
            this.polar2.CircleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.polar2.Circled = true;
            this.polar2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.polar2.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Marks.Callout.ArrowHead = Steema.TeeChart.Styles.ArrowHeadStyles.None;
            this.polar2.Marks.Callout.ArrowHeadSize = 8;
            // 
            // 
            // 
            this.polar2.Marks.Callout.Brush.Color = System.Drawing.Color.Black;
            this.polar2.Marks.Callout.Distance = 0;
            this.polar2.Marks.Callout.Draw3D = false;
            this.polar2.Marks.Callout.Length = 10;
            this.polar2.Marks.Callout.Series = this.polar2;
            this.polar2.Marks.Callout.Style = Steema.TeeChart.Styles.PointerStyles.Rectangle;
            this.polar2.Marks.Callout.Visible = false;
            this.polar2.Marks.Series = this.polar2;
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
            this.polar2.Pointer.HorizSize = 3;
            this.polar2.Pointer.Series = this.polar2;
            this.polar2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.polar2.Pointer.VertSize = 3;
            this.polar2.Title = "Poles";
            // 
            // 
            // 
            this.polar2.XValues.DataMember = "Angle";
            this.polar2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.polar2.YValues.DataMember = "Y";
            // 
            // ChartEditor
            // 
            this.ChartEditor.Chart = this.tChart1;
            this.ChartEditor.HighLightTabs = false;
            this.ChartEditor.Location = new System.Drawing.Point(0, 0);
            this.ChartEditor.Name = "ChartEditor";
            this.ChartEditor.Options = null;
            this.ChartEditor.TabIndex = 0;
            // 
            // IIRZerosForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(680, 549);
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
