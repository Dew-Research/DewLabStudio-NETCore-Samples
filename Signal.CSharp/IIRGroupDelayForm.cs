using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Dew.Signal;
using Dew.Math;
using Dew.Signal.Units;
using Dew.Math.Units;
using Steema.TeeChart.Styles;
using Dew.Signal.Tee;
using Dew.Math.Controls;
using static Dew.Math.Tee.MtxVecTee;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for IIRGroupDelayForm.
	/// </summary>
	public class IIRGroupDelayForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private SpectrumChart SpectrumChart1;
		private FloatEdit orderEdit;
		private System.Windows.Forms.Label label1;
		private FloatEdit attEdit;
        private System.Windows.Forms.Label label2;
        private Button ChartButton;
        private Steema.TeeChart.Editor ChartEditor;
        private IContainer components;

		public IIRGroupDelayForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			for (int i=0;i<4;i++)
				SpectrumChart1.Series.Add(new FastLine());
			orderEdit_TextChanged(this, EventArgs.Empty);
		}

		private void FillSeries(int order, int att) {
			TVec num, den,h;
			MtxVec.CreateIt(out num, out den, out h);
			try {
				for (int i=0;i<4;i++) {
					Series s = SpectrumChart1.Series[i];
					s.Title = IIRFilters.IirFilterMethodToString((TIirFilterMethod)i);
					switch ((TIirFilterMethod)i) {
						case TIirFilterMethod.fimButter:
							IIRFilters.ButterFilter(order, new double[]{0.2},TFilterType.ftLowpass, false, num, den, TIirFrequencyTransform.ftStateSpaceAnalog);
							break;
						case TIirFilterMethod.fimChebyshevI:
							IIRFilters.ChebyshevIFilter(order, 0.1, new double[]{0.2},TFilterType.ftLowpass, false, num, den, TIirFrequencyTransform.ftStateSpaceAnalog);
							break;
						case TIirFilterMethod.fimChebyshevII:
							IIRFilters.ChebyshevIIFilter(order, att, new double[]{0.2},TFilterType.ftLowpass, false, num, den, TIirFrequencyTransform.ftStateSpaceAnalog);
							break;
						case TIirFilterMethod.fimElliptic:
							IIRFilters.EllipticFilter(order, 0.1, att, new double[]{0.2},TFilterType.ftLowpass, false, num, den, TIirFrequencyTransform.ftStateSpaceAnalog);
							break;
					}
					SignalUtils.GroupDelay(h, num, den, 128);
					h.SetSubRange(0,(int)(0.95 * h.Length));
					DrawValues(h, s, 0, 0.95*0.5 / h.Length, false);
					h.SetFullRange();
				}
			} finally {
				MtxVec.FreeIt(ref num, ref den, ref h);
			}		
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderEdit = new Dew.Math.Controls.FloatEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.attEdit = new Dew.Math.Controls.FloatEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.SpectrumChart1 = new Dew.Signal.Tee.SpectrumChart(this);
            this.ChartButton = new System.Windows.Forms.Button();
            this.ChartEditor = new Steema.TeeChart.Editor(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(536, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChartButton);
            this.panel1.Controls.Add(this.orderEdit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.attEdit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 453);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 40);
            this.panel1.TabIndex = 1;
            // 
            // orderEdit
            // 
            this.orderEdit.Increment = "1";
            this.orderEdit.Location = new System.Drawing.Point(185, 11);
            this.orderEdit.Name = "orderEdit";
            this.orderEdit.ReFormat = "#";
            this.orderEdit.Scientific = false;
            this.orderEdit.Size = new System.Drawing.Size(72, 20);
            this.orderEdit.TabIndex = 8;
            this.orderEdit.Text = "5";
            this.orderEdit.Value = "5";
            this.orderEdit.TextChanged += new System.EventHandler(this.orderEdit_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(141, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Order:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // attEdit
            // 
            this.attEdit.Increment = "1";
            this.attEdit.Location = new System.Drawing.Point(361, 11);
            this.attEdit.Name = "attEdit";
            this.attEdit.ReFormat = "0#;-0#";
            this.attEdit.Scientific = false;
            this.attEdit.Size = new System.Drawing.Size(72, 20);
            this.attEdit.TabIndex = 9;
            this.attEdit.Text = "40";
            this.attEdit.Value = "40";
            this.attEdit.TextChanged += new System.EventHandler(this.orderEdit_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(265, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Attenuation [dB]:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SpectrumChart1
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Aspect.ElevationFloat = 345;
            this.SpectrumChart1.Aspect.RotationFloat = 345;
            this.SpectrumChart1.Aspect.View3D = false;
            this.SpectrumChart1.AutoAnalysisUpdate = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Automatic = true;
            // 
            // 
            // 
             
            this.SpectrumChart1.Axes.Bottom.Grid.ZPosition = 0;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Title.Caption = "Frequency [Hz]";
            this.SpectrumChart1.Axes.Bottom.Title.Lines = new string[] {
        "Frequency [Hz]"};
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Depth.Automatic = true;
            // 
            // 
            // 
             
            this.SpectrumChart1.Axes.Depth.Grid.ZPosition = 0;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.DepthTop.Automatic = true;
            // 
            // 
            // 
             
            this.SpectrumChart1.Axes.DepthTop.Grid.ZPosition = 0;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Automatic = true;
            // 
            // 
            // 
             
            this.SpectrumChart1.Axes.Left.Grid.ZPosition = 0;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Title.Caption = "Group delay [samples]";
            this.SpectrumChart1.Axes.Left.Title.Lines = new string[] {
        "Group delay [samples]"};
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Right.Automatic = true;
            // 
            // 
            // 
             
            this.SpectrumChart1.Axes.Right.Grid.ZPosition = 0;
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Top.Automatic = true;
            // 
            // 
            // 
             
            this.SpectrumChart1.Axes.Top.Grid.ZPosition = 0;
            this.SpectrumChart1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
             
            this.SpectrumChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SpectrumChart1.Header.Lines = new string[] {
        "Group delay"};
            // 
            // 
            // 
            this.SpectrumChart1.Legend.ActiveStyle = Steema.TeeChart.LegendActiveStyles.CheckBox;
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Shadow.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.SpectrumChart1.Legend.Title.Pen.Visible = false;
            this.SpectrumChart1.Location = new System.Drawing.Point(0, 96);
            this.SpectrumChart1.Name = "SpectrumChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            this.SpectrumChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.SpectrumChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SpectrumChart1.PixelDownSample = false;
            this.SpectrumChart1.Size = new System.Drawing.Size(536, 357);
            this.SpectrumChart1.SpectrumPart = Dew.Signal.Tee.SpectrumPart.sppAmplt;
            this.SpectrumChart1.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Back.AutoHide = false;
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Bottom.AutoHide = false;
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Left.AutoHide = false;
            // 
            // 
            // 
            this.SpectrumChart1.Walls.Right.AutoHide = false;
            // 
            // ChartButton
            // 
            this.ChartButton.Location = new System.Drawing.Point(12, 8);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(75, 23);
            this.ChartButton.TabIndex = 10;
            this.ChartButton.Text = "Chart...";
            this.ChartButton.UseVisualStyleBackColor = true;
            this.ChartButton.Click += new System.EventHandler(this.ChartButton_Click);
            // 
            // ChartEditor
            // 
            this.ChartEditor.Chart = this.SpectrumChart1;
            this.ChartEditor.HighLightTabs = false;
            this.ChartEditor.Location = new System.Drawing.Point(0, 0);
            this.ChartEditor.Name = "ChartEditor";
            this.ChartEditor.Options = null;
            this.ChartEditor.TabIndex = 0;
            // 
            // IIRGroupDelayForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(536, 493);
            this.Controls.Add(this.SpectrumChart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "IIRGroupDelayForm";
            this.Text = "IIRGroupDelayForm";
            this.Load += new System.EventHandler(this.IIRGroupDelayForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void orderEdit_TextChanged(object sender, System.EventArgs e) {
			FillSeries(orderEdit.IntPosition,attEdit.IntPosition);
		}

        private void ChartButton_Click(object sender, EventArgs e)
        {
            ChartEditor.ShowModal();
        }

        protected void Add(String s)
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void IIRGroupDelayForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("Group delay of IIR filters. Group delay is the first "
            + "derivate of the continuous phase. Change the filter "
            + "parameters and observer what happens to the group delay!");

        }
	}
}
