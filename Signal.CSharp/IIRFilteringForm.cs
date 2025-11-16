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
            components = new Container();
            Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            ChartButton = new Button();
            SpectrumButton = new Button();
            orderEdit = new FloatEdit();
            label1 = new Label();
            label2 = new Label();
            attEdit = new FloatEdit();
            label3 = new Label();
            freqEdit = new FloatEdit();
            SpectrumChart1 = new SpectrumChart();
            SpectrumAnalyzer1 = new TSpectrumAnalyzer(components);
            ChartEditor = new Steema.TeeChart.Editor(components);
            SpectrumAnalyzerDialog = new SpectrumAnalyzerDialog(components);
            panel1.SuspendLayout();
            ((ISupportInitialize)SpectrumChart1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Top;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1134, 98);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            panel1.Controls.Add(ChartButton);
            panel1.Controls.Add(SpectrumButton);
            panel1.Controls.Add(orderEdit);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(attEdit);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(freqEdit);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 817);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 43);
            panel1.TabIndex = 1;
            // 
            // ChartButton
            // 
            ChartButton.Location = new Point(128, 7);
            ChartButton.Name = "ChartButton";
            ChartButton.Size = new Size(90, 29);
            ChartButton.TabIndex = 5;
            ChartButton.Text = "Chart...";
            ChartButton.UseVisualStyleBackColor = true;
            ChartButton.Click += ChartButton_Click;
            // 
            // SpectrumButton
            // 
            SpectrumButton.Location = new Point(14, 7);
            SpectrumButton.Name = "SpectrumButton";
            SpectrumButton.Size = new Size(90, 29);
            SpectrumButton.TabIndex = 4;
            SpectrumButton.Text = "Spectrum...";
            SpectrumButton.UseVisualStyleBackColor = true;
            SpectrumButton.Click += SpectrumButton_Click;
            // 
            // orderEdit
            // 
            orderEdit.Increment = "1";
            orderEdit.Location = new Point(328, 7);
            orderEdit.MaxValue = "64";
            orderEdit.MinValue = "1";
            orderEdit.Name = "orderEdit";
            orderEdit.ReFormat = "0;-0";
            orderEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            orderEdit.Scientific = false;
            orderEdit.Size = new Size(86, 23);
            orderEdit.TabIndex = 3;
            orderEdit.Value = "5";
            orderEdit.TextChanged += orderEdit_TextChanged;
            // 
            // label1
            // 
            label1.Location = new Point(260, 7);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 2;
            label1.Text = "Order:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(433, 7);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 2;
            label2.Text = "Att [dB]:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // attEdit
            // 
            attEdit.Increment = "1";
            attEdit.Location = new Point(500, 7);
            attEdit.MaxValue = "100";
            attEdit.MinValue = "1";
            attEdit.Name = "attEdit";
            attEdit.ReFormat = "0;-0";
            attEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            attEdit.Scientific = false;
            attEdit.Size = new Size(87, 23);
            attEdit.TabIndex = 3;
            attEdit.Value = "40";
            attEdit.TextChanged += orderEdit_TextChanged;
            // 
            // label3
            // 
            label3.Location = new Point(606, 7);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 2;
            label3.Text = "Freq:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // freqEdit
            // 
            freqEdit.Increment = "0.01";
            freqEdit.Location = new Point(673, 7);
            freqEdit.Name = "freqEdit";
            freqEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            freqEdit.Scientific = false;
            freqEdit.Size = new Size(87, 23);
            freqEdit.TabIndex = 3;
            freqEdit.Value = "0.10";
            freqEdit.TextChanged += orderEdit_TextChanged;
            // 
            // SpectrumChart1
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
            // 
            SpectrumChart1.Axes.Bottom.Labels.Brush.Color = Color.White;
            SpectrumChart1.Axes.Bottom.Labels.Brush.Solid = true;
            SpectrumChart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            SpectrumChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Bottom.Labels.Font.Size = 9;
            SpectrumChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            SpectrumChart1.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Title.Brush.Color = Color.Silver;
            SpectrumChart1.Axes.Bottom.Title.Brush.Solid = true;
            SpectrumChart1.Axes.Bottom.Title.Brush.Visible = true;
            SpectrumChart1.Axes.Bottom.Title.Caption = "Frequency [Hz]";
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            SpectrumChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Bottom.Title.Font.Size = 11;
            SpectrumChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            SpectrumChart1.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            SpectrumChart1.Axes.Bottom.Title.Lines = new string[]
    {
    "Frequency [Hz]"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Labels.Brush.Color = Color.White;
            SpectrumChart1.Axes.Depth.Labels.Brush.Solid = true;
            SpectrumChart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            SpectrumChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Depth.Labels.Font.Size = 9;
            SpectrumChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            SpectrumChart1.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Title.Brush.Color = Color.Silver;
            SpectrumChart1.Axes.Depth.Title.Brush.Solid = true;
            SpectrumChart1.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart1.Axes.Depth.Title.Font.Brush.Solid = true;
            SpectrumChart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Depth.Title.Font.Size = 11;
            SpectrumChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            SpectrumChart1.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Labels.Brush.Color = Color.White;
            SpectrumChart1.Axes.DepthTop.Labels.Brush.Solid = true;
            SpectrumChart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            SpectrumChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.DepthTop.Labels.Font.Size = 9;
            SpectrumChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            SpectrumChart1.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Title.Brush.Color = Color.Silver;
            SpectrumChart1.Axes.DepthTop.Title.Brush.Solid = true;
            SpectrumChart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            SpectrumChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.DepthTop.Title.Font.Size = 11;
            SpectrumChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            SpectrumChart1.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Labels.Brush.Color = Color.White;
            SpectrumChart1.Axes.Left.Labels.Brush.Solid = true;
            SpectrumChart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart1.Axes.Left.Labels.Font.Brush.Solid = true;
            SpectrumChart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Left.Labels.Font.Size = 9;
            SpectrumChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            SpectrumChart1.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Title.Brush.Color = Color.Silver;
            SpectrumChart1.Axes.Left.Title.Brush.Solid = true;
            SpectrumChart1.Axes.Left.Title.Brush.Visible = true;
            SpectrumChart1.Axes.Left.Title.Caption = "Amplitude [dB]";
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart1.Axes.Left.Title.Font.Brush.Solid = true;
            SpectrumChart1.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Left.Title.Font.Size = 11;
            SpectrumChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            SpectrumChart1.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            SpectrumChart1.Axes.Left.Title.Lines = new string[]
    {
    "Amplitude [dB]"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Labels.Brush.Color = Color.White;
            SpectrumChart1.Axes.Right.Labels.Brush.Solid = true;
            SpectrumChart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart1.Axes.Right.Labels.Font.Brush.Solid = true;
            SpectrumChart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Right.Labels.Font.Size = 9;
            SpectrumChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            SpectrumChart1.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Title.Brush.Color = Color.Silver;
            SpectrumChart1.Axes.Right.Title.Brush.Solid = true;
            SpectrumChart1.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart1.Axes.Right.Title.Font.Brush.Solid = true;
            SpectrumChart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Right.Title.Font.Size = 11;
            SpectrumChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            SpectrumChart1.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Labels.Brush.Color = Color.White;
            SpectrumChart1.Axes.Top.Labels.Brush.Solid = true;
            SpectrumChart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart1.Axes.Top.Labels.Font.Brush.Solid = true;
            SpectrumChart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Top.Labels.Font.Size = 9;
            SpectrumChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            SpectrumChart1.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Title.Brush.Color = Color.Silver;
            SpectrumChart1.Axes.Top.Title.Brush.Solid = true;
            SpectrumChart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart1.Axes.Top.Title.Font.Brush.Solid = true;
            SpectrumChart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Axes.Top.Title.Font.Size = 11;
            SpectrumChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            SpectrumChart1.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            SpectrumChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            SpectrumChart1.Color = Color.FromArgb(192, 192, 192);
            SpectrumChart1.Dock = DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Footer.Brush.Color = Color.Silver;
            SpectrumChart1.Footer.Brush.Solid = true;
            SpectrumChart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Footer.Font.Brush.Color = Color.Red;
            SpectrumChart1.Footer.Font.Brush.Solid = true;
            SpectrumChart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Footer.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Footer.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Footer.Font.Size = 8;
            SpectrumChart1.Footer.Font.SizeFloat = 8F;
            SpectrumChart1.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Footer.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Footer.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Footer.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Footer.Shadow.Brush.Solid = true;
            SpectrumChart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Header.Brush.Color = Color.FromArgb(192, 192, 192);
            SpectrumChart1.Header.Brush.Solid = true;
            SpectrumChart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Header.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Header.Font.Brush.Color = Color.FromArgb(255, 255, 255);
            SpectrumChart1.Header.Font.Brush.Solid = true;
            SpectrumChart1.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Header.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Header.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Header.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Header.Font.Size = 12;
            SpectrumChart1.Header.Font.SizeFloat = 12F;
            SpectrumChart1.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Header.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Header.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Header.ImageBevel.Brush.Visible = true;
            SpectrumChart1.Header.Lines = new string[]
    {
    "Frequency response"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Header.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            SpectrumChart1.Header.Shadow.Brush.Solid = true;
            SpectrumChart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Legend.Brush.Color = Color.White;
            SpectrumChart1.Legend.Brush.Solid = true;
            SpectrumChart1.Legend.Brush.Visible = true;
            SpectrumChart1.Legend.CheckBoxes = true;
            // 
            // 
            // 
            SpectrumChart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.Legend.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart1.Legend.Font.Brush.Solid = true;
            SpectrumChart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Legend.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Legend.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Legend.Font.Size = 9;
            SpectrumChart1.Legend.Font.SizeFloat = 9F;
            SpectrumChart1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Legend.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Legend.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Legend.Shadow.Brush.Color = Color.FromArgb(0, 0, 0);
            SpectrumChart1.Legend.Shadow.Brush.Solid = true;
            SpectrumChart1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Legend.Symbol.Shadow.Brush.Solid = true;
            SpectrumChart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Legend.Title.Brush.Color = Color.White;
            SpectrumChart1.Legend.Title.Brush.Solid = true;
            SpectrumChart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            SpectrumChart1.Legend.Title.Font.Brush.Color = Color.Black;
            SpectrumChart1.Legend.Title.Font.Brush.Solid = true;
            SpectrumChart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.Legend.Title.Font.Size = 8;
            SpectrumChart1.Legend.Title.Font.SizeFloat = 8F;
            SpectrumChart1.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Legend.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Legend.Title.Shadow.Brush.Solid = true;
            SpectrumChart1.Legend.Title.Shadow.Brush.Visible = true;
            SpectrumChart1.Location = new Point(0, 98);
            SpectrumChart1.Name = "SpectrumChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            // 
            // 
            // 
            SpectrumChart1.Panel.Brush.Color = Color.FromArgb(192, 192, 192);
            SpectrumChart1.Panel.Brush.Solid = true;
            SpectrumChart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Panel.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Panel.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Panel.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Panel.Shadow.Brush.Solid = true;
            SpectrumChart1.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            SpectrumChart1.Printer.Margins = margins1;
            SpectrumChart1.Size = new Size(1134, 719);
            SpectrumChart1.SpectrumPart = SpectrumPart.sppAmplt;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.SubFooter.Brush.Color = Color.Silver;
            SpectrumChart1.SubFooter.Brush.Solid = true;
            SpectrumChart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.SubFooter.Font.Brush.Color = Color.Red;
            SpectrumChart1.SubFooter.Font.Brush.Solid = true;
            SpectrumChart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.SubFooter.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.SubFooter.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.SubFooter.Font.Size = 8;
            SpectrumChart1.SubFooter.Font.SizeFloat = 8F;
            SpectrumChart1.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.SubFooter.ImageBevel.Brush.Solid = true;
            SpectrumChart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.SubFooter.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.SubFooter.Shadow.Brush.Solid = true;
            SpectrumChart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.SubHeader.Brush.Color = Color.FromArgb(192, 192, 192);
            SpectrumChart1.SubHeader.Brush.Solid = true;
            SpectrumChart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart1.SubHeader.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart1.SubHeader.Font.Brush.Solid = true;
            SpectrumChart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.SubHeader.Font.Shadow.Brush.Solid = true;
            SpectrumChart1.SubHeader.Font.Shadow.Brush.Visible = true;
            SpectrumChart1.SubHeader.Font.Size = 12;
            SpectrumChart1.SubHeader.Font.SizeFloat = 12F;
            SpectrumChart1.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.SubHeader.ImageBevel.Brush.Solid = true;
            SpectrumChart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.SubHeader.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            SpectrumChart1.SubHeader.Shadow.Brush.Solid = true;
            SpectrumChart1.SubHeader.Shadow.Brush.Visible = true;
            SpectrumChart1.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Walls.Back.Brush.Color = Color.Silver;
            SpectrumChart1.Walls.Back.Brush.Solid = true;
            SpectrumChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Walls.Back.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Walls.Back.Shadow.Brush.Solid = true;
            SpectrumChart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Walls.Bottom.Brush.Color = Color.White;
            SpectrumChart1.Walls.Bottom.Brush.Solid = true;
            SpectrumChart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Walls.Bottom.Shadow.Brush.Solid = true;
            SpectrumChart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Walls.Left.Brush.Color = Color.LightYellow;
            SpectrumChart1.Walls.Left.Brush.Solid = true;
            SpectrumChart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Walls.Left.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Walls.Left.Shadow.Brush.Solid = true;
            SpectrumChart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Walls.Right.Brush.Color = Color.LightYellow;
            SpectrumChart1.Walls.Right.Brush.Solid = true;
            SpectrumChart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart1.Walls.Right.ImageBevel.Brush.Solid = true;
            SpectrumChart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart1.Walls.Right.Shadow.Brush.Solid = true;
            SpectrumChart1.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart1.Zoom.Brush.Color = Color.FromArgb(150, 173, 216, 230);
            SpectrumChart1.Zoom.Brush.Solid = true;
            SpectrumChart1.Zoom.Brush.Visible = true;
            // 
            // SpectrumAnalyzer1
            // 
            SpectrumAnalyzer1.ArOrder = 100;
            SpectrumAnalyzer1.Bands.TemplateIndex = -1;
            SpectrumAnalyzer1.Bands.TemplatesSerialization = "AAAAAA==";
            SpectrumAnalyzer1.Complex = false;
            SpectrumAnalyzer1.DCDump = false;
            SpectrumAnalyzer1.FloatPrecision = TMtxFloatPrecision.mvDouble;
            SpectrumAnalyzer1.FloatPrecisionLock = false;
            SpectrumAnalyzer1.Harmonics = 10;
            SpectrumAnalyzer1.Input = null;
            SpectrumAnalyzer1.IsDouble = true;
            SpectrumAnalyzer1.Length = 64;
            SpectrumAnalyzer1.Logarithmic = true;
            SpectrumAnalyzer1.LogBase = 0D;
            SpectrumAnalyzer1.LogScale = 0D;
            SpectrumAnalyzer1.LogSpan = TLogSpan.ls200;
            SpectrumAnalyzer1.MainlobeWidth = 8;
            SpectrumAnalyzer1.Peaks.HarmonicsCount = 10;
            SpectrumAnalyzer1.Peaks.Interpolation.Method = TInterpolationMethod.imNone;
            SpectrumAnalyzer1.Peaks.Interpolation.RecursiveHarmonics = TRecursiveHarmonics.rhNone;
            SpectrumAnalyzer1.Peaks.LargestCount = 1;
            SpectrumAnalyzer1.Peaks.LargestRatio = 1E+15D;
            SpectrumAnalyzer1.Peaks.NormalizedAmplt.PeakNumber = 1;
            SpectrumAnalyzer1.Peaks.NormalizedFreq.PeakNumber = 1;
            SpectrumAnalyzer1.Report.UseTab = false;
            SpectrumAnalyzer1.Rotation = 0;
            SpectrumAnalyzer1.SamplingFrequency = 16384D;
            SpectrumAnalyzer1.Stats.Averaged = 0;
            SpectrumAnalyzer1.Stats.Averages = 30;
            SpectrumAnalyzer1.Stats.ExpDecay = 5;
            SpectrumAnalyzer1.ZeroPadding = 128;
            // 
            // ChartEditor
            // 
            ChartEditor.AlwaysShowFuncSrc = false;
            ChartEditor.Chart = SpectrumChart1;
            ChartEditor.HighLightTabs = false;
            ChartEditor.Location = new Point(0, 0);
            ChartEditor.Name = "ChartEditor";
            ChartEditor.Options = null;
            ChartEditor.TabIndex = 0;
            // 
            // SpectrumAnalyzerDialog
            // 
            SpectrumAnalyzerDialog.Docking = false;
            SpectrumAnalyzerDialog.FormCaption = null;
            SpectrumAnalyzerDialog.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            SpectrumAnalyzerDialog.ShowLive = false;
            SpectrumAnalyzerDialog.Source = SpectrumAnalyzer1;
            SpectrumAnalyzerDialog.SourceListIndex = 0;
            // 
            // IIRFilteringForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(1134, 860);
            Controls.Add(SpectrumChart1);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Name = "IIRFilteringForm";
            Text = "IIRFilteringForm";
            Load += IIRFilteringForm_Load;
            panel1.ResumeLayout(false);
            ((ISupportInitialize)SpectrumChart1).EndInit();
            ResumeLayout(false);

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
