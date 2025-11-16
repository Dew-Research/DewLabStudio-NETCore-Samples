using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Dew.Signal;
using Dew.Signal.Units;
using Dew.Math;
using Dew.Math.Units;
using Dew.Signal.Tee;
using Dew.Signal.Editors;
using Dew.Math.Controls;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for PeakInterpolateForm.
	/// </summary>
	public class PeakInterpolateForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Splitter splitter1;
		private SpectrumChart SpectrumChart1;
		private SignalChart SignalChart1;
		private Dew.Signal.TSignal Signal1;
		private Dew.Signal.TSpectrumAnalyzer SpectrumAnalyzer1;
		private System.Windows.Forms.Label label1;
		private FloatEdit FreqEdit;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private FloatEdit PhaseEdit;
		private FloatEdit AmpltEdit;
		private Steema.TeeChart.Styles.FastLine SpectrumSeries;
		private Steema.TeeChart.Styles.Points SpectrumMarkSeries;
		private Steema.TeeChart.Styles.FastLine SignalSeries;
        private SpectrumAnalyzerDialog SpectrumAnalyzerDialog;
        private Steema.TeeChart.Editor SpectrumChartEditor;
        private Steema.TeeChart.Editor SignalChartEditor;
        private Button SignalChartButton;
        private Button SpectrumChartButton;
        private Button SpectrumButton;
		private System.ComponentModel.IContainer components;

		public PeakInterpolateForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			SignalChart1.Signals.Add();
			SignalChart1.Signals[0].Series = SignalSeries;
			SignalChart1.Signals[0].Input = Signal1;

			SpectrumChart1.Spectrums.Add();
			SpectrumChart1.Spectrums[0].Series = SpectrumSeries;
			SpectrumChart1.Spectrums[0].Input = SpectrumAnalyzer1;


			SpectrumMarkTool markTool = new SpectrumMarkTool(SpectrumChart1.Chart);
			markTool.MarkSeries = SpectrumMarkSeries;
			markTool.Series = SpectrumSeries;
			markTool.CursorActive = false;
			markTool.MarkMode = SpectrumMarkMode.mmSingle;
			markTool.MarkType = SpectrumMarkType.mtAmpltPhase;
			markTool.AmpltFormat = "0.0000";
			markTool.PhaseFormat = "0.0000";
			markTool.FreqFormat = "0.0000";
			markTool.LabelHeaders = true;
			markTool.PeakZoomBand = false;
			markTool.DoubleClickClear = true;
			markTool.PeakFilterMode = false;
			SpectrumChart1.Tools.Add(markTool);

            SpectrumSeries.Color = Color.Navy;
            SignalSeries.Color = Color.Navy;

			Signal1.UsesInputs = false;
			SpectrumAnalyzer1.PhaseMode = TPhaseMode.pm360;
			SpectrumAnalyzer1.Pull();
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
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(PeakInterpolateForm));
            Steema.TeeChart.Margins margins2 = new Steema.TeeChart.Margins();
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            SignalChartButton = new Button();
            SpectrumChartButton = new Button();
            SpectrumButton = new Button();
            label1 = new Label();
            FreqEdit = new FloatEdit();
            label2 = new Label();
            PhaseEdit = new FloatEdit();
            AmpltEdit = new FloatEdit();
            label3 = new Label();
            panel2 = new Panel();
            SignalChart1 = new SignalChart();
            SignalSeries = new Steema.TeeChart.Styles.FastLine();
            splitter1 = new Splitter();
            SpectrumChart1 = new SpectrumChart();
            SpectrumSeries = new Steema.TeeChart.Styles.FastLine();
            SpectrumMarkSeries = new Steema.TeeChart.Styles.Points();
            Signal1 = new TSignal(components);
            SpectrumAnalyzer1 = new TSpectrumAnalyzer(components);
            SpectrumAnalyzerDialog = new SpectrumAnalyzerDialog(components);
            SpectrumChartEditor = new Steema.TeeChart.Editor(components);
            SignalChartEditor = new Steema.TeeChart.Editor(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((ISupportInitialize)SignalChart1).BeginInit();
            ((ISupportInitialize)SpectrumChart1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Top;
            richTextBox1.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1089, 118);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(SignalChartButton);
            panel1.Controls.Add(SpectrumChartButton);
            panel1.Controls.Add(SpectrumButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(FreqEdit);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(PhaseEdit);
            panel1.Controls.Add(AmpltEdit);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 814);
            panel1.Name = "panel1";
            panel1.Size = new Size(1089, 40);
            panel1.TabIndex = 1;
            // 
            // SignalChartButton
            // 
            SignalChartButton.Location = new Point(254, 7);
            SignalChartButton.Name = "SignalChartButton";
            SignalChartButton.Size = new Size(119, 29);
            SignalChartButton.TabIndex = 4;
            SignalChartButton.Text = "Signal chart";
            SignalChartButton.UseVisualStyleBackColor = true;
            SignalChartButton.Click += SignalChartButton_Click;
            // 
            // SpectrumChartButton
            // 
            SpectrumChartButton.Location = new Point(133, 7);
            SpectrumChartButton.Name = "SpectrumChartButton";
            SpectrumChartButton.Size = new Size(114, 29);
            SpectrumChartButton.TabIndex = 3;
            SpectrumChartButton.Text = "Spectrum chart";
            SpectrumChartButton.UseVisualStyleBackColor = true;
            SpectrumChartButton.Click += SpectrumChartButton_Click;
            // 
            // SpectrumButton
            // 
            SpectrumButton.Location = new Point(14, 7);
            SpectrumButton.Name = "SpectrumButton";
            SpectrumButton.Size = new Size(112, 29);
            SpectrumButton.TabIndex = 2;
            SpectrumButton.Text = "Spectrum...";
            SpectrumButton.UseVisualStyleBackColor = true;
            SpectrumButton.Click += SpectrumButton_Click;
            // 
            // label1
            // 
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(413, 4);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 1;
            label1.Text = "Frequency";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FreqEdit
            // 
            FreqEdit.Increment = "0.0002";
            FreqEdit.Location = new Point(497, 7);
            FreqEdit.Name = "FreqEdit";
            FreqEdit.ReFormat = "0.0000#;-0.0000#";
            FreqEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            FreqEdit.Scientific = false;
            FreqEdit.Size = new Size(86, 23);
            FreqEdit.TabIndex = 0;
            FreqEdit.Value = "0.0100";
            FreqEdit.TextChanged += AmpltEdit_TextChanged;
            // 
            // label2
            // 
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(575, 4);
            label2.Name = "label2";
            label2.Size = new Size(57, 28);
            label2.TabIndex = 1;
            label2.Text = "Phase";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PhaseEdit
            // 
            PhaseEdit.Increment = "1";
            PhaseEdit.Location = new Point(640, 7);
            PhaseEdit.Name = "PhaseEdit";
            PhaseEdit.ReFormat = "0";
            PhaseEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            PhaseEdit.Scientific = false;
            PhaseEdit.Size = new Size(55, 23);
            PhaseEdit.TabIndex = 0;
            PhaseEdit.TextChanged += AmpltEdit_TextChanged;
            // 
            // AmpltEdit
            // 
            AmpltEdit.Increment = "0.100000001490116";
            AmpltEdit.Location = new Point(754, 7);
            AmpltEdit.Name = "AmpltEdit";
            AmpltEdit.ReFormat = "0.0";
            AmpltEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            AmpltEdit.Scientific = false;
            AmpltEdit.Size = new Size(58, 23);
            AmpltEdit.TabIndex = 0;
            AmpltEdit.Value = "1.0";
            AmpltEdit.TextChanged += AmpltEdit_TextChanged;
            // 
            // label3
            // 
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(689, 4);
            label3.Name = "label3";
            label3.Size = new Size(57, 28);
            label3.TabIndex = 1;
            label3.Text = "Amplt";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.Controls.Add(SignalChart1);
            panel2.Controls.Add(splitter1);
            panel2.Controls.Add(SpectrumChart1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(1089, 696);
            panel2.TabIndex = 2;
            panel2.SizeChanged += panel2_SizeChanged;
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
            SignalChart1.Color = Color.Silver;
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
    "Signal"
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
            SignalChart1.Location = new Point(0, 230);
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
            SignalChart1.Panel.Brush.Color = Color.Silver;
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
            SignalChart1.Series.Add(SignalSeries);
            SignalChart1.Size = new Size(1089, 466);
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
            SignalChart1.TabIndex = 2;
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
            // 
            // 
            // 
            SignalChart1.Zoom.Pen.Visible = true;
            // 
            // SignalSeries
            // 
            // 
            // 
            // 
            SignalSeries.Brush.Color = Color.Empty;
            SignalSeries.Brush.Solid = true;
            SignalSeries.Brush.Visible = true;
            SignalSeries.Color = Color.FromArgb(119, 153, 214);
            SignalSeries.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalSeries.Legend.Brush.Color = Color.White;
            SignalSeries.Legend.Brush.Solid = true;
            SignalSeries.Legend.Brush.Visible = true;
            // 
            // 
            // 
            SignalSeries.Legend.Font.Bold = false;
            // 
            // 
            // 
            SignalSeries.Legend.Font.Brush.Color = Color.Black;
            SignalSeries.Legend.Font.Brush.Solid = true;
            SignalSeries.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalSeries.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalSeries.Legend.Font.Shadow.Brush.Solid = true;
            SignalSeries.Legend.Font.Shadow.Brush.Visible = true;
            SignalSeries.Legend.Font.Size = 8;
            SignalSeries.Legend.Font.SizeFloat = 8F;
            SignalSeries.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalSeries.Legend.ImageBevel.Brush.Color = Color.LightGray;
            SignalSeries.Legend.ImageBevel.Brush.Solid = true;
            SignalSeries.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalSeries.Legend.Shadow.Brush.Color = Color.DarkGray;
            SignalSeries.Legend.Shadow.Brush.Solid = true;
            SignalSeries.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalSeries.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            SignalSeries.Marks.Brush.Solid = true;
            SignalSeries.Marks.Brush.Visible = true;
            // 
            // 
            // 
            SignalSeries.Marks.Font.Bold = false;
            // 
            // 
            // 
            SignalSeries.Marks.Font.Brush.Color = Color.Black;
            SignalSeries.Marks.Font.Brush.Solid = true;
            SignalSeries.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalSeries.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            SignalSeries.Marks.Font.Shadow.Brush.Solid = true;
            SignalSeries.Marks.Font.Shadow.Brush.Visible = true;
            SignalSeries.Marks.Font.Size = 8;
            SignalSeries.Marks.Font.SizeFloat = 8F;
            SignalSeries.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalSeries.Marks.ImageBevel.Brush.Color = Color.LightGray;
            SignalSeries.Marks.ImageBevel.Brush.Solid = true;
            SignalSeries.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalSeries.Marks.Shadow.Brush.Color = Color.Gray;
            SignalSeries.Marks.Shadow.Brush.Solid = true;
            SignalSeries.Marks.Shadow.Brush.Visible = true;
            SignalSeries.Marks.Shadow.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalSeries.Marks.Symbol.Brush.Color = Color.White;
            SignalSeries.Marks.Symbol.Brush.Solid = true;
            SignalSeries.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalSeries.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            SignalSeries.Marks.Symbol.ImageBevel.Brush.Solid = true;
            SignalSeries.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SignalSeries.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            SignalSeries.Marks.Symbol.Shadow.Brush.Solid = true;
            SignalSeries.Marks.Symbol.Shadow.Brush.Visible = true;
            SignalSeries.Title = "fastLine1";
            SignalSeries.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            // 
            // 
            // 
            SignalSeries.XValues.DataMember = "X";
            SignalSeries.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            SignalSeries.XValues.Value = new double[]
    {
    0D,
    1D,
    2D,
    3D,
    4D,
    5D,
    6D,
    7D,
    8D,
    9D,
    10D,
    11D,
    12D,
    13D,
    14D,
    15D,
    16D,
    17D,
    18D,
    19D,
    20D,
    21D,
    22D,
    23D,
    24D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            SignalSeries.YValues.DataMember = "Y";
            SignalSeries.YValues.Value = new double[]
    {
    70D,
    182D,
    230D,
    246D,
    228D,
    344D,
    353D,
    326D,
    375D,
    458D,
    425D,
    459D,
    475D,
    468D,
    386D,
    386D,
    448D,
    390D,
    372D,
    412D,
    382D,
    375D,
    498D,
    378D,
    255D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // splitter1
            // 
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 226);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(1089, 4);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
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
            SpectrumChart1.Axes.Bottom.Grid.DrawEvery = 1;
            SpectrumChart1.Axes.Bottom.Grid.Visible = true;
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
            SpectrumChart1.Axes.Bottom.Title.Caption = "Freqency [Hz]";
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
    "Freqency [Hz]"
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
            SpectrumChart1.Axes.Left.AxisPen.Visible = true;
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
            SpectrumChart1.Color = Color.Silver;
            SpectrumChart1.Dock = DockStyle.Top;
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
            SpectrumChart1.Header.Font.Brush.Color = Color.FromArgb(128, 128, 128);
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
    "Frequency spectrum"
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
            SpectrumChart1.Legend.CheckBoxes = false;
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
            SpectrumChart1.Legend.Shadow.Visible = true;
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
            SpectrumChart1.Legend.Visible = false;
            SpectrumChart1.Location = new Point(0, 0);
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
            SpectrumChart1.Panel.Brush.Color = Color.Silver;
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
            margins2.Bottom = 100;
            margins2.Left = 100;
            margins2.Right = 100;
            margins2.Top = 100;
            SpectrumChart1.Printer.Margins = margins2;
            SpectrumChart1.Series.Add(SpectrumSeries);
            SpectrumChart1.Series.Add(SpectrumMarkSeries);
            SpectrumChart1.Size = new Size(1089, 226);
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
            SpectrumChart1.TabIndex = 0;
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
            SpectrumChart1.Zoom.Animated = true;
            // 
            // 
            // 
            SpectrumChart1.Zoom.Brush.Color = Color.LightBlue;
            SpectrumChart1.Zoom.Brush.Solid = true;
            SpectrumChart1.Zoom.Brush.Visible = false;
            SpectrumChart1.Zoom.History = true;
            // 
            // 
            // 
            SpectrumChart1.Zoom.Pen.Visible = true;
            // 
            // SpectrumSeries
            // 
            // 
            // 
            // 
            SpectrumSeries.Brush.Color = Color.Empty;
            SpectrumSeries.Brush.Solid = true;
            SpectrumSeries.Brush.Visible = true;
            SpectrumSeries.Color = Color.FromArgb(119, 153, 214);
            SpectrumSeries.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumSeries.Legend.Brush.Color = Color.White;
            SpectrumSeries.Legend.Brush.Solid = true;
            SpectrumSeries.Legend.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumSeries.Legend.Font.Bold = false;
            // 
            // 
            // 
            SpectrumSeries.Legend.Font.Brush.Color = Color.Black;
            SpectrumSeries.Legend.Font.Brush.Solid = true;
            SpectrumSeries.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumSeries.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumSeries.Legend.Font.Shadow.Brush.Solid = true;
            SpectrumSeries.Legend.Font.Shadow.Brush.Visible = true;
            SpectrumSeries.Legend.Font.Size = 8;
            SpectrumSeries.Legend.Font.SizeFloat = 8F;
            SpectrumSeries.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumSeries.Legend.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumSeries.Legend.ImageBevel.Brush.Solid = true;
            SpectrumSeries.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumSeries.Legend.Shadow.Brush.Color = Color.DarkGray;
            SpectrumSeries.Legend.Shadow.Brush.Solid = true;
            SpectrumSeries.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumSeries.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            SpectrumSeries.Marks.Brush.Solid = true;
            SpectrumSeries.Marks.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumSeries.Marks.Font.Bold = false;
            // 
            // 
            // 
            SpectrumSeries.Marks.Font.Brush.Color = Color.Black;
            SpectrumSeries.Marks.Font.Brush.Solid = true;
            SpectrumSeries.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumSeries.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumSeries.Marks.Font.Shadow.Brush.Solid = true;
            SpectrumSeries.Marks.Font.Shadow.Brush.Visible = true;
            SpectrumSeries.Marks.Font.Size = 8;
            SpectrumSeries.Marks.Font.SizeFloat = 8F;
            SpectrumSeries.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumSeries.Marks.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumSeries.Marks.ImageBevel.Brush.Solid = true;
            SpectrumSeries.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumSeries.Marks.Shadow.Brush.Color = Color.Gray;
            SpectrumSeries.Marks.Shadow.Brush.Solid = true;
            SpectrumSeries.Marks.Shadow.Brush.Visible = true;
            SpectrumSeries.Marks.Shadow.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumSeries.Marks.Symbol.Brush.Color = Color.White;
            SpectrumSeries.Marks.Symbol.Brush.Solid = true;
            SpectrumSeries.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumSeries.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumSeries.Marks.Symbol.ImageBevel.Brush.Solid = true;
            SpectrumSeries.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumSeries.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            SpectrumSeries.Marks.Symbol.Shadow.Brush.Solid = true;
            SpectrumSeries.Marks.Symbol.Shadow.Brush.Visible = true;
            SpectrumSeries.Title = "fastLine1";
            SpectrumSeries.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            // 
            // 
            // 
            SpectrumSeries.XValues.DataMember = "X";
            SpectrumSeries.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            SpectrumSeries.XValues.Value = new double[]
    {
    0D,
    1D,
    2D,
    3D,
    4D,
    5D,
    6D,
    7D,
    8D,
    9D,
    10D,
    11D,
    12D,
    13D,
    14D,
    15D,
    16D,
    17D,
    18D,
    19D,
    20D,
    21D,
    22D,
    23D,
    24D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            SpectrumSeries.YValues.DataMember = "Y";
            SpectrumSeries.YValues.Value = new double[]
    {
    732D,
    855D,
    800D,
    849D,
    771D,
    816D,
    807D,
    871D,
    799D,
    848D,
    757D,
    776D,
    872D,
    839D,
    726D,
    784D,
    845D,
    730D,
    773D,
    711D,
    742D,
    688D,
    782D,
    659D,
    541D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // SpectrumMarkSeries
            // 
            // 
            // 
            // 
            SpectrumMarkSeries.Brush.Color = Color.Empty;
            SpectrumMarkSeries.Brush.Solid = true;
            SpectrumMarkSeries.Brush.Visible = true;
            SpectrumMarkSeries.Color = Color.Red;
            SpectrumMarkSeries.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumMarkSeries.Legend.Brush.Color = Color.White;
            SpectrumMarkSeries.Legend.Brush.Solid = true;
            SpectrumMarkSeries.Legend.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumMarkSeries.Legend.Font.Bold = false;
            // 
            // 
            // 
            SpectrumMarkSeries.Legend.Font.Brush.Color = Color.Black;
            SpectrumMarkSeries.Legend.Font.Brush.Solid = true;
            SpectrumMarkSeries.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumMarkSeries.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumMarkSeries.Legend.Font.Shadow.Brush.Solid = true;
            SpectrumMarkSeries.Legend.Font.Shadow.Brush.Visible = true;
            SpectrumMarkSeries.Legend.Font.Size = 8;
            SpectrumMarkSeries.Legend.Font.SizeFloat = 8F;
            SpectrumMarkSeries.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumMarkSeries.Legend.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumMarkSeries.Legend.ImageBevel.Brush.Solid = true;
            SpectrumMarkSeries.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumMarkSeries.Legend.Shadow.Brush.Color = Color.DarkGray;
            SpectrumMarkSeries.Legend.Shadow.Brush.Solid = true;
            SpectrumMarkSeries.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumMarkSeries.Marks.Arrow.Visible = false;
            SpectrumMarkSeries.Marks.ArrowLength = 10;
            // 
            // 
            // 
            SpectrumMarkSeries.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            SpectrumMarkSeries.Marks.Brush.Solid = true;
            SpectrumMarkSeries.Marks.Brush.Visible = false;
            // 
            // 
            // 
            SpectrumMarkSeries.Marks.Font.Bold = false;
            // 
            // 
            // 
            SpectrumMarkSeries.Marks.Font.Brush.Color = Color.Black;
            SpectrumMarkSeries.Marks.Font.Brush.Solid = true;
            SpectrumMarkSeries.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumMarkSeries.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumMarkSeries.Marks.Font.Shadow.Brush.Solid = true;
            SpectrumMarkSeries.Marks.Font.Shadow.Brush.Visible = true;
            SpectrumMarkSeries.Marks.Font.Size = 8;
            SpectrumMarkSeries.Marks.Font.SizeFloat = 8F;
            SpectrumMarkSeries.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumMarkSeries.Marks.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumMarkSeries.Marks.ImageBevel.Brush.Solid = true;
            SpectrumMarkSeries.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumMarkSeries.Marks.Shadow.Brush.Color = Color.Gray;
            SpectrumMarkSeries.Marks.Shadow.Brush.Solid = true;
            SpectrumMarkSeries.Marks.Shadow.Brush.Visible = true;
            SpectrumMarkSeries.Marks.Shadow.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumMarkSeries.Marks.Symbol.Brush.Color = Color.White;
            SpectrumMarkSeries.Marks.Symbol.Brush.Solid = true;
            SpectrumMarkSeries.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumMarkSeries.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumMarkSeries.Marks.Symbol.ImageBevel.Brush.Solid = true;
            SpectrumMarkSeries.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumMarkSeries.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            SpectrumMarkSeries.Marks.Symbol.Shadow.Brush.Solid = true;
            SpectrumMarkSeries.Marks.Symbol.Shadow.Brush.Visible = true;
            SpectrumMarkSeries.Marks.Transparent = true;
            SpectrumMarkSeries.Marks.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumMarkSeries.Pointer.Brush.Color = Color.Red;
            SpectrumMarkSeries.Pointer.Brush.Solid = true;
            SpectrumMarkSeries.Pointer.Brush.Visible = true;
            SpectrumMarkSeries.Pointer.HorizSize = 3;
            // 
            // 
            // 
            SpectrumMarkSeries.Pointer.Pen.Color = Color.FromArgb(254, 0, 0, 0);
            SpectrumMarkSeries.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            SpectrumMarkSeries.Pointer.VertSize = 3;
            SpectrumMarkSeries.Title = "point1";
            // 
            // 
            // 
            SpectrumMarkSeries.XValues.DataMember = "X";
            SpectrumMarkSeries.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            SpectrumMarkSeries.XValues.Value = new double[]
    {
    0D,
    1D,
    2D,
    3D,
    4D,
    5D,
    6D,
    7D,
    8D,
    9D,
    10D,
    11D,
    12D,
    13D,
    14D,
    15D,
    16D,
    17D,
    18D,
    19D,
    20D,
    21D,
    22D,
    23D,
    24D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            SpectrumMarkSeries.YValues.DataMember = "Y";
            SpectrumMarkSeries.YValues.Value = new double[]
    {
    688D,
    716D,
    708D,
    721D,
    716D,
    701D,
    717D,
    691D,
    712D,
    712D,
    741D,
    723D,
    703D,
    706D,
    713D,
    682D,
    665D,
    695D,
    695D,
    657D,
    646D,
    674D,
    642D,
    667D,
    655D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // Signal1
            // 
            Signal1.ChannelCount = 1;
            Signal1.Complex = false;
            Signal1.DataSerialization = resources.GetString("Signal1.DataSerialization");
            Signal1.FloatPrecision = TMtxFloatPrecision.mvDouble;
            Signal1.FloatPrecisionLock = false;
            Signal1.IsDouble = true;
            Signal1.Length = 512;
            Signal1.OnAfterUpdateEvent += Signal1_OnAfterUpdate;
            // 
            // SpectrumAnalyzer1
            // 
            SpectrumAnalyzer1.ArOrder = 100;
            SpectrumAnalyzer1.Bands.TemplateIndex = -1;
            SpectrumAnalyzer1.Bands.TemplatesSerialization = "AAAAAA==";
            SpectrumAnalyzer1.Complex = false;
            SpectrumAnalyzer1.FloatPrecision = TMtxFloatPrecision.mvDouble;
            SpectrumAnalyzer1.FloatPrecisionLock = false;
            SpectrumAnalyzer1.Harmonics = 10;
            SpectrumAnalyzer1.Input = Signal1;
            SpectrumAnalyzer1.IsDouble = true;
            SpectrumAnalyzer1.Length = 64;
            SpectrumAnalyzer1.LogBase = 0D;
            SpectrumAnalyzer1.LogScale = 0D;
            SpectrumAnalyzer1.MainlobeWidth = 8;
            SpectrumAnalyzer1.Peaks.HarmonicsCount = 10;
            SpectrumAnalyzer1.Peaks.Interpolation.RecursiveHarmonics = TRecursiveHarmonics.rhNone;
            SpectrumAnalyzer1.Peaks.LargestCount = 1;
            SpectrumAnalyzer1.Peaks.LargestRatio = 1E+15D;
            SpectrumAnalyzer1.Peaks.NormalizedAmplt.PeakNumber = 1;
            SpectrumAnalyzer1.Peaks.NormalizedFreq.PeakNumber = 1;
            SpectrumAnalyzer1.Peaks.TraceMethod = TPeakTraceMethod.ptLargest;
            SpectrumAnalyzer1.Report.AmplitudeFormat = null;
            SpectrumAnalyzer1.Report.FrequencyFormat = null;
            SpectrumAnalyzer1.Report.PhaseFormat = null;
            SpectrumAnalyzer1.Report.UseTab = false;
            SpectrumAnalyzer1.Rotation = 0;
            SpectrumAnalyzer1.Stats.Averaged = 0;
            SpectrumAnalyzer1.Stats.Averages = 30;
            SpectrumAnalyzer1.Stats.ExpDecay = 5;
            SpectrumAnalyzer1.Window = TSignalWindowType.wtKaiser;
            SpectrumAnalyzer1.ZeroPadding = 1;
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
            // SpectrumChartEditor
            // 
            SpectrumChartEditor.AlwaysShowFuncSrc = false;
            SpectrumChartEditor.Chart = SpectrumChart1;
            SpectrumChartEditor.HighLightTabs = false;
            SpectrumChartEditor.Location = new Point(0, 0);
            SpectrumChartEditor.Name = "SpectrumChartEditor";
            SpectrumChartEditor.Options = null;
            SpectrumChartEditor.TabIndex = 0;
            // 
            // SignalChartEditor
            // 
            SignalChartEditor.AlwaysShowFuncSrc = false;
            SignalChartEditor.Chart = SignalChart1;
            SignalChartEditor.HighLightTabs = false;
            SignalChartEditor.Location = new Point(0, 0);
            SignalChartEditor.Name = "SignalChartEditor";
            SignalChartEditor.Options = null;
            SignalChartEditor.TabIndex = 0;
            // 
            // PeakInterpolateForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(1089, 854);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Name = "PeakInterpolateForm";
            Text = "PeakInterpolateForm";
            Load += PeakInterpolateForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((ISupportInitialize)SignalChart1).EndInit();
            ((ISupportInitialize)SpectrumChart1).EndInit();
            ResumeLayout(false);

        }
        #endregion

        private void panel2_SizeChanged(object sender, System.EventArgs e) {
			SpectrumChart1.Height = (int)(panel2.Height / 1.8);
		}

		private void Signal1_OnAfterUpdate(object Sender) {
			TToneState toneState = new TToneState();
			SignalUtils.ToneInit(FreqEdit.Position, Math387.DegToRad(PhaseEdit.Position),AmpltEdit.Position,ref toneState, false);
			SignalUtils.Tone(Signal1.Data,ref toneState);
		}

		private void AmpltEdit_TextChanged(object sender, System.EventArgs e) {
			SpectrumAnalyzer1.Pull();
		}

        protected void Add(String s)
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void PeakInterpolateForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            Add("Numeric peak interpolation works with any window and any "
            + "zero padding setting. Change the value of frequency, amplitude "
            + "and phase and compare value measured on the marked peak with the "
            + "actual sine parameter. Notice also that marked peak follows the "
            + "frequency. This feature is called peak tracing. In the example "
            + "below, peak tracking is set to always find and mark the largest peak.");
        }

        private void SpectrumButton_Click(object sender, EventArgs e)
        {
            SpectrumAnalyzerDialog.ExecuteModal();
        }

        private void SpectrumChartButton_Click(object sender, EventArgs e)
        {
            SpectrumChartEditor.ShowModal();
        }

        private void SignalChartButton_Click(object sender, EventArgs e)
        {
            SignalChartEditor.ShowModal();
        }

	}
}

