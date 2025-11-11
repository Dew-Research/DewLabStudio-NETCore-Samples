using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Dew.Signal;
using Dew.Math;
using Dew.Signal.Tee;
using Dew.Signal.Units;
using Dew.Signal.Editors;
using Dew.Math.Units;
using Steema.TeeChart.Styles;
using Dew.Math.Controls;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for IIRFilteringForm.
	/// </summary>
	public class IIRFilteringForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private SpectrumChart SpectrumChart1;
		private FloatEdit orderEdit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private FloatEdit attEdit;
		private System.Windows.Forms.Label label3;
		private FloatEdit freqEdit;
		private Dew.Signal.TSpectrumAnalyzer SpectrumAnalyzer1;
        private Steema.TeeChart.Editor ChartEditor;
        private SpectrumAnalyzerDialog SpectrumAnalyzerDialog;
        private Button ChartButton;
        private Button SpectrumButton;
		private System.ComponentModel.IContainer components;

		public IIRFilteringForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			SpectrumChart1.Spectrums.Add();
			SpectrumChart1.Spectrums[0].Input = SpectrumAnalyzer1;

			for (int i=0;i<4;i++) SpectrumChart1.Series.Add(new FastLine());
			orderEdit_TextChanged(this, EventArgs.Empty);
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

		private void FillSeries(int order, int att, double freq) {
			TVec num, den,h;
			MtxVec.CreateIt(out num, out den, out h);
			try {
				for (int i=0;i<4;i++) {
					SpectrumChart1.Spectrums[0].Series = SpectrumChart1.Series[i];
          SpectrumChart1.Series[i].Title = IIRFilters.IirFilterMethodToString((TIirFilterMethod)i);
					switch ((TIirFilterMethod)i) {
						case TIirFilterMethod.fimButter:
							IIRFilters.ButterFilter(order, new double[]{freq},TFilterType.ftLowpass, false, num, den, TIirFrequencyTransform.ftStateSpaceAnalog);
							break;
						case TIirFilterMethod.fimChebyshevI:
							IIRFilters.ChebyshevIFilter(order, 0.1, new double[]{freq},TFilterType.ftLowpass, false, num, den, TIirFrequencyTransform.ftStateSpaceAnalog);
							break;
						case TIirFilterMethod.fimChebyshevII:
							IIRFilters.ChebyshevIIFilter(order, att, new double[]{freq},TFilterType.ftLowpass, false, num, den, TIirFrequencyTransform.ftStateSpaceAnalog);
							break;
						case TIirFilterMethod.fimElliptic:
							IIRFilters.EllipticFilter(order, 0.1, att, new double[]{freq},TFilterType.ftLowpass, false, num, den, TIirFrequencyTransform.ftStateSpaceAnalog);
							break;
					}
					SpectrumAnalyzer1.Process(num, den, null, null, 2);
					SpectrumAnalyzer1.Update();
				}
			} finally {
				MtxVec.FreeIt(ref num, ref den, ref h);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IIRFilteringForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChartButton = new System.Windows.Forms.Button();
            this.SpectrumButton = new System.Windows.Forms.Button();
            this.orderEdit = new Dew.Math.Controls.FloatEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.attEdit = new Dew.Math.Controls.FloatEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.freqEdit = new Dew.Math.Controls.FloatEdit();
            this.SpectrumChart1 = new Dew.Signal.Tee.SpectrumChart();
            this.SpectrumAnalyzer1 = new Dew.Signal.TSpectrumAnalyzer(this.components);
            this.ChartEditor = new Steema.TeeChart.Editor(this.components);
            this.SpectrumAnalyzerDialog = new Dew.Signal.Editors.SpectrumAnalyzerDialog(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(720, 80);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChartButton);
            this.panel1.Controls.Add(this.SpectrumButton);
            this.panel1.Controls.Add(this.orderEdit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.attEdit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.freqEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 35);
            this.panel1.TabIndex = 1;
            // 
            // ChartButton
            // 
            this.ChartButton.Location = new System.Drawing.Point(107, 6);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(75, 23);
            this.ChartButton.TabIndex = 5;
            this.ChartButton.Text = "Chart...";
            this.ChartButton.UseVisualStyleBackColor = true;
            this.ChartButton.Click += new System.EventHandler(this.ChartButton_Click);
            // 
            // SpectrumButton
            // 
            this.SpectrumButton.Location = new System.Drawing.Point(12, 6);
            this.SpectrumButton.Name = "SpectrumButton";
            this.SpectrumButton.Size = new System.Drawing.Size(75, 23);
            this.SpectrumButton.TabIndex = 4;
            this.SpectrumButton.Text = "Spectrum...";
            this.SpectrumButton.UseVisualStyleBackColor = true;
            this.SpectrumButton.Click += new System.EventHandler(this.SpectrumButton_Click);
            // 
            // orderEdit
            // 
            this.orderEdit.Increment = "1";
            this.orderEdit.Location = new System.Drawing.Point(273, 6);
            this.orderEdit.MaxValue = "64";
            this.orderEdit.MinValue = "1";
            this.orderEdit.Name = "orderEdit";
            this.orderEdit.ReFormat = "0;-0";
            this.orderEdit.Scientific = false;
            this.orderEdit.Size = new System.Drawing.Size(72, 20);
            this.orderEdit.TabIndex = 3;
            this.orderEdit.Text = "5";
            this.orderEdit.Value = "5";
            this.orderEdit.TextChanged += new System.EventHandler(this.orderEdit_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(217, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(361, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Att [dB]:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // attEdit
            // 
            this.attEdit.Increment = "1";
            this.attEdit.Location = new System.Drawing.Point(417, 6);
            this.attEdit.MaxValue = "100";
            this.attEdit.MinValue = "1";
            this.attEdit.Name = "attEdit";
            this.attEdit.ReFormat = "0;-0";
            this.attEdit.Scientific = false;
            this.attEdit.Size = new System.Drawing.Size(72, 20);
            this.attEdit.TabIndex = 3;
            this.attEdit.Text = "40";
            this.attEdit.Value = "40";
            this.attEdit.TextChanged += new System.EventHandler(this.orderEdit_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(505, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Freq:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // freqEdit
            // 
            this.freqEdit.Increment = "0.01";
            this.freqEdit.Location = new System.Drawing.Point(561, 6);
            this.freqEdit.Name = "freqEdit";
            this.freqEdit.ReFormat = "0.00#;-0.00#";
            this.freqEdit.Scientific = false;
            this.freqEdit.Size = new System.Drawing.Size(72, 20);
            this.freqEdit.TabIndex = 3;
            this.freqEdit.Text = "0.10";
            this.freqEdit.Value = "0.10";
            this.freqEdit.TextChanged += new System.EventHandler(this.orderEdit_TextChanged);
            // 
            // SpectrumChart1
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Aspect.View3D = false;
            this.SpectrumChart1.Aspect.ZOffset = 0;
            this.SpectrumChart1.AutoAnalysisUpdate = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Bottom.Title.Caption = "Frequency [Hz]";
            this.SpectrumChart1.Axes.Bottom.Title.Lines = new string[] {
        "Frequency [Hz]"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart1.Axes.Left.Title.Caption = "Amplitude [dB]";
            this.SpectrumChart1.Axes.Left.Title.Lines = new string[] {
        "Amplitude [dB]"};
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
        "Frequency response"};
            // 
            // 
            // 
            this.SpectrumChart1.Legend.ActiveStyle = Steema.TeeChart.LegendActiveStyles.CheckBox;
            this.SpectrumChart1.Location = new System.Drawing.Point(0, 80);
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
            this.SpectrumChart1.Size = new System.Drawing.Size(720, 402);
            this.SpectrumChart1.SpectrumPart = Dew.Signal.Tee.SpectrumPart.sppAmplt;
            this.SpectrumChart1.TabIndex = 2;
            // 
            // SpectrumAnalyzer1
            // 
            this.SpectrumAnalyzer1.Bands.TemplateIndex = -1;
            this.SpectrumAnalyzer1.Bands.Templates = new Dew.Signal.TStringStreamList(System.Convert.FromBase64String("AAAAAA=="));
            this.SpectrumAnalyzer1.BlockAssign = false;
            this.SpectrumAnalyzer1.DCDump = false;
            this.SpectrumAnalyzer1.Input = null;
            this.SpectrumAnalyzer1.Logarithmic = true;
            this.SpectrumAnalyzer1.LogSpan = Dew.Signal.TLogSpan.ls200;
            this.SpectrumAnalyzer1.Name = "";
            this.SpectrumAnalyzer1.Peaks.Interpolation.Method = Dew.Signal.TInterpolationMethod.imNone;
            this.SpectrumAnalyzer1.SamplingFrequency = 16384;
            this.SpectrumAnalyzer1.ZeroPadding = 128;
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
            // SpectrumAnalyzerDialog
            // 
            this.SpectrumAnalyzerDialog.BlockAssign = false;
            this.SpectrumAnalyzerDialog.FormCaption = null;
            this.SpectrumAnalyzerDialog.Name = null;
            this.SpectrumAnalyzerDialog.Source = this.SpectrumAnalyzer1;
            this.SpectrumAnalyzerDialog.SourceList = null;
            this.SpectrumAnalyzerDialog.SourceListIndex = 0;
            // 
            // IIRFilteringForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(720, 517);
            this.Controls.Add(this.SpectrumChart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "IIRFilteringForm";
            this.Text = "IIRFilteringForm";
            this.Load += new System.EventHandler(this.IIRFilteringForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void orderEdit_TextChanged(object sender, System.EventArgs e) {
			FillSeries(orderEdit.IntPosition,attEdit.IntPosition,freqEdit.Position);
		}

        protected void Add(String s)
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void IIRFilteringForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("DSP Master features 4 different filter design "
            + "methods for infinite impulse response filters: Butterworth, "
            + "Chebyshev type I and type II and elliptic filters. Change the "
            + "order and attenuation in the stop band of a low-pass IIR filter "
            + "designed with all 4 methods.");
        }

        private void SpectrumButton_Click(object sender, EventArgs e)
        {
            SpectrumAnalyzerDialog.ExecuteModal();
        }

        private void ChartButton_Click(object sender, EventArgs e)
        {
            ChartEditor.ShowModal();
        }
	}
}
