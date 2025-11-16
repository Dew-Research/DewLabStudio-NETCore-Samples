using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Dew.Signal.Tee;
using Dew.Math;


namespace DSPDemo
{
	/// <summary>
	/// Summary description for PeakMarkingBasicForm.
	/// </summary>
	public class PeakMarkingBasicForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
		private Dew.Signal.TSignalRead SignalRead1;
		private Dew.Signal.TSpectrumAnalyzer SpectrumAnalyzer1;
		private SpectrumChart SpectrumChart;
		private System.Windows.Forms.CheckBox phaseBox;
        private Steema.TeeChart.Editor ChartEditor;
        private Dew.Signal.Editors.SpectrumAnalyzerDialog SpectrumAnalyzerDialog;
        private Dew.Math.Tee.MtxFastLine mtxFastLine1;
        private AxisScaleTool axisScaleTool1;
        private Steema.TeeChart.Styles.Points points1;
		private System.ComponentModel.IContainer components;

		public PeakMarkingBasicForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			SpectrumChart.Spectrums.Add();
			SpectrumChart.Spectrums[0].Series = mtxFastLine1;
			SpectrumChart.Spectrums[0].Input = SpectrumAnalyzer1;

			SpectrumMarkTool smt = new SpectrumMarkTool(SpectrumChart.Chart);
			smt.CursorActive = true;
			smt.DoubleClickClear = true;
			smt.PeakFilterMode = false;
			smt.MarkMode = SpectrumMarkMode.mmSingle;
			smt.MarkType = SpectrumMarkType.mtAmplt;
			smt.MarkSeries = points1;
            smt.Series = mtxFastLine1;
			smt.AmpltFormat = "0.00#";
			smt.PhaseFormat = "0.00#";
			smt.FreqFormat = "0.00#";
			smt.LabelHeaders = true;
			smt.PeakZoomBand = false;
			SpectrumChart.Tools.Add(smt);

            //Series1.Color = Color.Navy;

            SignalRead1.FileName = Dew.Demo.Utils.SourcePath() + @"\Data\bz.dat";
			SignalRead1.OpenFile();
			comboBox1.SelectedIndex = 0;
			SpectrumAnalyzer1.Pull();
		}

		private SpectrumMarkTool GetMarkTool() {
			foreach (object tool in SpectrumChart.Tools) {
				if (tool is SpectrumMarkTool) return tool as SpectrumMarkTool;
			}
			throw new Exception("Spectrum mark tool not found!");
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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(PeakMarkingBasicForm));
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            phaseBox = new CheckBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            SpectrumChart = new SpectrumChart();
            mtxFastLine1 = new Dew.Math.Tee.MtxFastLine();
            points1 = new Steema.TeeChart.Styles.Points();
            axisScaleTool1 = new AxisScaleTool();
            SignalRead1 = new Dew.Signal.TSignalRead(components);
            SpectrumAnalyzer1 = new Dew.Signal.TSpectrumAnalyzer(components);
            ChartEditor = new Steema.TeeChart.Editor(components);
            SpectrumAnalyzerDialog = new Dew.Signal.Editors.SpectrumAnalyzerDialog(components);
            panel1.SuspendLayout();
            ((ISupportInitialize)SpectrumChart).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Top;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1159, 118);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            panel1.Controls.Add(phaseBox);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 792);
            panel1.Name = "panel1";
            panel1.Size = new Size(1159, 51);
            panel1.TabIndex = 1;
            // 
            // phaseBox
            // 
            phaseBox.Location = new Point(506, 11);
            phaseBox.Name = "phaseBox";
            phaseBox.Size = new Size(125, 30);
            phaseBox.TabIndex = 4;
            phaseBox.Text = "Phase";
            phaseBox.CheckedChanged += phaseBox_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "Single peak", "Harmonic series", "Sidebands 1", "Sidebands 2", "Free style" });
            comboBox1.Location = new Point(353, 11);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Location = new Point(228, 11);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 2;
            label1.Text = "Mark mode:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            button2.Location = new Point(122, 11);
            button2.Name = "button2";
            button2.Size = new Size(90, 28);
            button2.TabIndex = 1;
            button2.Text = "Chart";
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(17, 11);
            button1.Name = "button1";
            button1.Size = new Size(90, 28);
            button1.TabIndex = 0;
            button1.Text = "Spectrum";
            button1.Click += button1_Click;
            // 
            // SpectrumChart
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
            SpectrumChart.Axes.Bottom.Grid.DrawEvery = 1;
            SpectrumChart.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.Labels.Brush.Color = Color.White;
            SpectrumChart.Axes.Bottom.Labels.Brush.Solid = true;
            SpectrumChart.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart.Axes.Bottom.Labels.Font.Brush.Solid = true;
            SpectrumChart.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.Bottom.Labels.Font.Size = 9;
            SpectrumChart.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            SpectrumChart.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            SpectrumChart.Axes.Bottom.Labels.Separation = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.Bottom.MaximumOffset = 4;
            SpectrumChart.Axes.Bottom.MinimumOffset = 4;
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.TicksInner.Color = Color.FromArgb(0, 0, 192);
            SpectrumChart.Axes.Bottom.TicksInner.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.Title.Brush.Color = Color.Silver;
            SpectrumChart.Axes.Bottom.Title.Brush.Solid = true;
            SpectrumChart.Axes.Bottom.Title.Brush.Visible = true;
            SpectrumChart.Axes.Bottom.Title.Caption = "Frequency [Hz]";
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart.Axes.Bottom.Title.Font.Brush.Solid = true;
            SpectrumChart.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.Bottom.Title.Font.Size = 11;
            SpectrumChart.Axes.Bottom.Title.Font.SizeFloat = 11F;
            SpectrumChart.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            SpectrumChart.Axes.Bottom.Title.Lines = new string[]
    {
    "Frequency [Hz]"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Depth.Labels.Brush.Color = Color.White;
            SpectrumChart.Axes.Depth.Labels.Brush.Solid = true;
            SpectrumChart.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart.Axes.Depth.Labels.Font.Brush.Solid = true;
            SpectrumChart.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.Depth.Labels.Font.Size = 9;
            SpectrumChart.Axes.Depth.Labels.Font.SizeFloat = 9F;
            SpectrumChart.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Depth.Title.Brush.Color = Color.Silver;
            SpectrumChart.Axes.Depth.Title.Brush.Solid = true;
            SpectrumChart.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart.Axes.Depth.Title.Font.Brush.Solid = true;
            SpectrumChart.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.Depth.Title.Font.Size = 11;
            SpectrumChart.Axes.Depth.Title.Font.SizeFloat = 11F;
            SpectrumChart.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Depth.Title.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.DepthTop.Labels.Brush.Color = Color.White;
            SpectrumChart.Axes.DepthTop.Labels.Brush.Solid = true;
            SpectrumChart.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            SpectrumChart.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.DepthTop.Labels.Font.Size = 9;
            SpectrumChart.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            SpectrumChart.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.DepthTop.Title.Brush.Color = Color.Silver;
            SpectrumChart.Axes.DepthTop.Title.Brush.Solid = true;
            SpectrumChart.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart.Axes.DepthTop.Title.Font.Brush.Solid = true;
            SpectrumChart.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.DepthTop.Title.Font.Size = 11;
            SpectrumChart.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            SpectrumChart.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Labels.Brush.Color = Color.White;
            SpectrumChart.Axes.Left.Labels.Brush.Solid = true;
            SpectrumChart.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart.Axes.Left.Labels.Font.Brush.Solid = true;
            SpectrumChart.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.Left.Labels.Font.Size = 9;
            SpectrumChart.Axes.Left.Labels.Font.SizeFloat = 9F;
            SpectrumChart.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Left.Labels.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Left.Labels.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.Left.MaximumOffset = 4;
            SpectrumChart.Axes.Left.MinimumOffset = 4;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Title.Brush.Color = Color.Silver;
            SpectrumChart.Axes.Left.Title.Brush.Solid = true;
            SpectrumChart.Axes.Left.Title.Brush.Visible = true;
            SpectrumChart.Axes.Left.Title.Caption = "Amplitude";
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart.Axes.Left.Title.Font.Brush.Solid = true;
            SpectrumChart.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.Left.Title.Font.Size = 11;
            SpectrumChart.Axes.Left.Title.Font.SizeFloat = 11F;
            SpectrumChart.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            SpectrumChart.Axes.Left.Title.Lines = new string[]
    {
    "Amplitude"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Left.Title.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Right.Labels.Brush.Color = Color.White;
            SpectrumChart.Axes.Right.Labels.Brush.Solid = true;
            SpectrumChart.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart.Axes.Right.Labels.Font.Brush.Solid = true;
            SpectrumChart.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.Right.Labels.Font.Size = 9;
            SpectrumChart.Axes.Right.Labels.Font.SizeFloat = 9F;
            SpectrumChart.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Right.Labels.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Right.Title.Brush.Color = Color.Silver;
            SpectrumChart.Axes.Right.Title.Brush.Solid = true;
            SpectrumChart.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Axes.Right.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart.Axes.Right.Title.Font.Brush.Solid = true;
            SpectrumChart.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.Right.Title.Font.Size = 11;
            SpectrumChart.Axes.Right.Title.Font.SizeFloat = 11F;
            SpectrumChart.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Right.Title.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Top.Labels.Brush.Color = Color.White;
            SpectrumChart.Axes.Top.Labels.Brush.Solid = true;
            SpectrumChart.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart.Axes.Top.Labels.Font.Brush.Solid = true;
            SpectrumChart.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.Top.Labels.Font.Size = 9;
            SpectrumChart.Axes.Top.Labels.Font.SizeFloat = 9F;
            SpectrumChart.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            SpectrumChart.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Top.Labels.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Top.Title.Brush.Color = Color.Silver;
            SpectrumChart.Axes.Top.Title.Brush.Solid = true;
            SpectrumChart.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Axes.Top.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart.Axes.Top.Title.Font.Brush.Solid = true;
            SpectrumChart.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Axes.Top.Title.Font.Size = 11;
            SpectrumChart.Axes.Top.Title.Font.SizeFloat = 11F;
            SpectrumChart.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Axes.Top.Title.Shadow.Brush.Solid = true;
            SpectrumChart.Axes.Top.Title.Shadow.Brush.Visible = true;
            SpectrumChart.Color = Color.FromArgb(192, 192, 192);
            SpectrumChart.Dock = DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Footer.Brush.Color = Color.Silver;
            SpectrumChart.Footer.Brush.Solid = true;
            SpectrumChart.Footer.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Footer.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Footer.Font.Brush.Color = Color.Red;
            SpectrumChart.Footer.Font.Brush.Solid = true;
            SpectrumChart.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Footer.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Footer.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Footer.Font.Size = 8;
            SpectrumChart.Footer.Font.SizeFloat = 8F;
            SpectrumChart.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Footer.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Footer.ImageBevel.Brush.Solid = true;
            SpectrumChart.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Footer.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Footer.Shadow.Brush.Solid = true;
            SpectrumChart.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Header.Brush.Color = Color.FromArgb(192, 192, 192);
            SpectrumChart.Header.Brush.Solid = true;
            SpectrumChart.Header.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Header.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Header.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart.Header.Font.Brush.Solid = true;
            SpectrumChart.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Header.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Header.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Header.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Header.Font.Size = 12;
            SpectrumChart.Header.Font.SizeFloat = 12F;
            SpectrumChart.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Header.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Header.ImageBevel.Brush.Solid = true;
            SpectrumChart.Header.ImageBevel.Brush.Visible = true;
            SpectrumChart.Header.Lines = new string[]
    {
    "Frequency spectrum"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Header.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            SpectrumChart.Header.Shadow.Brush.Solid = true;
            SpectrumChart.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Legend.Brush.Color = Color.White;
            SpectrumChart.Legend.Brush.Solid = true;
            SpectrumChart.Legend.Brush.Visible = true;
            SpectrumChart.Legend.CheckBoxes = false;
            // 
            // 
            // 
            SpectrumChart.Legend.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.Legend.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            SpectrumChart.Legend.Font.Brush.Solid = true;
            SpectrumChart.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Legend.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Legend.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Legend.Font.Size = 9;
            SpectrumChart.Legend.Font.SizeFloat = 9F;
            SpectrumChart.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Legend.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Legend.ImageBevel.Brush.Solid = true;
            SpectrumChart.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Legend.Shadow.Brush.Color = Color.FromArgb(0, 0, 0);
            SpectrumChart.Legend.Shadow.Brush.Solid = true;
            SpectrumChart.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Legend.Symbol.Shadow.Brush.Solid = true;
            SpectrumChart.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Legend.Title.Brush.Color = Color.White;
            SpectrumChart.Legend.Title.Brush.Solid = true;
            SpectrumChart.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            SpectrumChart.Legend.Title.Font.Brush.Color = Color.Black;
            SpectrumChart.Legend.Title.Font.Brush.Solid = true;
            SpectrumChart.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Legend.Title.Font.Shadow.Brush.Solid = true;
            SpectrumChart.Legend.Title.Font.Shadow.Brush.Visible = true;
            SpectrumChart.Legend.Title.Font.Size = 8;
            SpectrumChart.Legend.Title.Font.SizeFloat = 8F;
            SpectrumChart.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Legend.Title.ImageBevel.Brush.Solid = true;
            SpectrumChart.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Legend.Title.Shadow.Brush.Solid = true;
            SpectrumChart.Legend.Title.Shadow.Brush.Visible = true;
            SpectrumChart.Legend.Visible = false;
            SpectrumChart.Location = new Point(0, 118);
            SpectrumChart.Name = "SpectrumChart";
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            // 
            // 
            // 
            SpectrumChart.Panel.Brush.Color = Color.FromArgb(192, 192, 192);
            SpectrumChart.Panel.Brush.Solid = true;
            SpectrumChart.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Panel.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Panel.ImageBevel.Brush.Solid = true;
            SpectrumChart.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Panel.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Panel.Shadow.Brush.Solid = true;
            SpectrumChart.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            SpectrumChart.Printer.Margins = margins1;
            SpectrumChart.Series.Add(mtxFastLine1);
            SpectrumChart.Series.Add(points1);
            SpectrumChart.Size = new Size(1159, 674);
            SpectrumChart.SpectrumPart = SpectrumPart.sppAmplt;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.SubFooter.Brush.Color = Color.Silver;
            SpectrumChart.SubFooter.Brush.Solid = true;
            SpectrumChart.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.SubFooter.Font.Brush.Color = Color.Red;
            SpectrumChart.SubFooter.Font.Brush.Solid = true;
            SpectrumChart.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.SubFooter.Font.Shadow.Brush.Solid = true;
            SpectrumChart.SubFooter.Font.Shadow.Brush.Visible = true;
            SpectrumChart.SubFooter.Font.Size = 8;
            SpectrumChart.SubFooter.Font.SizeFloat = 8F;
            SpectrumChart.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.SubFooter.ImageBevel.Brush.Solid = true;
            SpectrumChart.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.SubFooter.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.SubFooter.Shadow.Brush.Solid = true;
            SpectrumChart.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.SubHeader.Brush.Color = Color.FromArgb(192, 192, 192);
            SpectrumChart.SubHeader.Brush.Solid = true;
            SpectrumChart.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            SpectrumChart.SubHeader.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            SpectrumChart.SubHeader.Font.Brush.Solid = true;
            SpectrumChart.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.SubHeader.Font.Shadow.Brush.Solid = true;
            SpectrumChart.SubHeader.Font.Shadow.Brush.Visible = true;
            SpectrumChart.SubHeader.Font.Size = 12;
            SpectrumChart.SubHeader.Font.SizeFloat = 12F;
            SpectrumChart.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.SubHeader.ImageBevel.Brush.Solid = true;
            SpectrumChart.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.SubHeader.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            SpectrumChart.SubHeader.Shadow.Brush.Solid = true;
            SpectrumChart.SubHeader.Shadow.Brush.Visible = true;
            SpectrumChart.TabIndex = 2;
            SpectrumChart.Tools.Add(axisScaleTool1);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Walls.Back.Brush.Color = Color.Silver;
            SpectrumChart.Walls.Back.Brush.Solid = true;
            SpectrumChart.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Walls.Back.ImageBevel.Brush.Solid = true;
            SpectrumChart.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Walls.Back.Shadow.Brush.Solid = true;
            SpectrumChart.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Walls.Bottom.Brush.Color = Color.White;
            SpectrumChart.Walls.Bottom.Brush.Solid = true;
            SpectrumChart.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Walls.Bottom.ImageBevel.Brush.Solid = true;
            SpectrumChart.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Walls.Bottom.Shadow.Brush.Solid = true;
            SpectrumChart.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Walls.Left.Brush.Color = Color.LightYellow;
            SpectrumChart.Walls.Left.Brush.Solid = true;
            SpectrumChart.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Walls.Left.ImageBevel.Brush.Solid = true;
            SpectrumChart.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Walls.Left.Shadow.Brush.Solid = true;
            SpectrumChart.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Walls.Right.Brush.Color = Color.LightYellow;
            SpectrumChart.Walls.Right.Brush.Solid = true;
            SpectrumChart.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
            SpectrumChart.Walls.Right.ImageBevel.Brush.Solid = true;
            SpectrumChart.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            SpectrumChart.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
            SpectrumChart.Walls.Right.Shadow.Brush.Solid = true;
            SpectrumChart.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            SpectrumChart.Zoom.Animated = true;
            // 
            // 
            // 
            SpectrumChart.Zoom.Brush.Color = Color.LightBlue;
            SpectrumChart.Zoom.Brush.Solid = true;
            SpectrumChart.Zoom.Brush.Visible = false;
            SpectrumChart.Zoom.History = true;
            // 
            // 
            // 
            SpectrumChart.Zoom.Pen.Visible = true;
            SpectrumChart.Click += SpectrumChart_Click;
            // 
            // mtxFastLine1
            // 
            // 
            // 
            // 
            mtxFastLine1.Brush.Color = Color.Empty;
            mtxFastLine1.Brush.Solid = true;
            mtxFastLine1.Brush.Visible = true;
            mtxFastLine1.Color = Color.FromArgb(0, 0, 192);
            mtxFastLine1.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine1.Legend.Brush.Color = Color.White;
            mtxFastLine1.Legend.Brush.Solid = true;
            mtxFastLine1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            mtxFastLine1.Legend.Font.Bold = false;
            // 
            // 
            // 
            mtxFastLine1.Legend.Font.Brush.Color = Color.Black;
            mtxFastLine1.Legend.Font.Brush.Solid = true;
            mtxFastLine1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            mtxFastLine1.Legend.Font.Shadow.Brush.Solid = true;
            mtxFastLine1.Legend.Font.Shadow.Brush.Visible = true;
            mtxFastLine1.Legend.Font.Size = 8;
            mtxFastLine1.Legend.Font.SizeFloat = 8F;
            mtxFastLine1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine1.Legend.ImageBevel.Brush.Color = Color.LightGray;
            mtxFastLine1.Legend.ImageBevel.Brush.Solid = true;
            mtxFastLine1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine1.Legend.Shadow.Brush.Color = Color.DarkGray;
            mtxFastLine1.Legend.Shadow.Brush.Solid = true;
            mtxFastLine1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine1.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            mtxFastLine1.Marks.Brush.Solid = true;
            mtxFastLine1.Marks.Brush.Visible = true;
            // 
            // 
            // 
            mtxFastLine1.Marks.Font.Bold = false;
            // 
            // 
            // 
            mtxFastLine1.Marks.Font.Brush.Color = Color.Black;
            mtxFastLine1.Marks.Font.Brush.Solid = true;
            mtxFastLine1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine1.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            mtxFastLine1.Marks.Font.Shadow.Brush.Solid = true;
            mtxFastLine1.Marks.Font.Shadow.Brush.Visible = true;
            mtxFastLine1.Marks.Font.Size = 8;
            mtxFastLine1.Marks.Font.SizeFloat = 8F;
            mtxFastLine1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine1.Marks.ImageBevel.Brush.Color = Color.LightGray;
            mtxFastLine1.Marks.ImageBevel.Brush.Solid = true;
            mtxFastLine1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine1.Marks.Shadow.Brush.Color = Color.Gray;
            mtxFastLine1.Marks.Shadow.Brush.Solid = true;
            mtxFastLine1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine1.Marks.Symbol.Brush.Color = Color.White;
            mtxFastLine1.Marks.Symbol.Brush.Solid = true;
            mtxFastLine1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine1.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            mtxFastLine1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            mtxFastLine1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine1.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            mtxFastLine1.Marks.Symbol.Shadow.Brush.Solid = true;
            mtxFastLine1.Marks.Symbol.Shadow.Brush.Visible = true;
            mtxFastLine1.Title = "mtxFastLine1";
            mtxFastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            // 
            // 
            // 
            mtxFastLine1.XValues.DataMember = "X";
            mtxFastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            mtxFastLine1.XValues.Value = new double[]
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
            mtxFastLine1.YValues.DataMember = "Y";
            mtxFastLine1.YValues.Value = new double[]
    {
    667D,
    627D,
    545D,
    565D,
    454D,
    419D,
    532D,
    560D,
    561D,
    675D,
    656D,
    745D,
    645D,
    523D,
    471D,
    398D,
    370D,
    255D,
    289D,
    235D,
    156D,
    133D,
    236D,
    223D,
    287D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // points1
            // 
            // 
            // 
            // 
            points1.Brush.Color = Color.Empty;
            points1.Brush.Solid = true;
            points1.Brush.Visible = true;
            points1.Color = Color.FromArgb(255, 0, 0);
            points1.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            points1.Legend.Brush.Color = Color.White;
            points1.Legend.Brush.Solid = true;
            points1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            points1.Legend.Font.Bold = false;
            // 
            // 
            // 
            points1.Legend.Font.Brush.Color = Color.Black;
            points1.Legend.Font.Brush.Solid = true;
            points1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            points1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            points1.Legend.Font.Shadow.Brush.Solid = true;
            points1.Legend.Font.Shadow.Brush.Visible = true;
            points1.Legend.Font.Size = 8;
            points1.Legend.Font.SizeFloat = 8F;
            points1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            points1.Legend.ImageBevel.Brush.Color = Color.LightGray;
            points1.Legend.ImageBevel.Brush.Solid = true;
            points1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            points1.Legend.Shadow.Brush.Color = Color.DarkGray;
            points1.Legend.Shadow.Brush.Solid = true;
            points1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            points1.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            points1.Marks.Brush.Solid = true;
            points1.Marks.Brush.Visible = false;
            // 
            // 
            // 
            points1.Marks.Font.Bold = false;
            // 
            // 
            // 
            points1.Marks.Font.Brush.Color = Color.Black;
            points1.Marks.Font.Brush.Solid = true;
            points1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            points1.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            points1.Marks.Font.Shadow.Brush.Solid = true;
            points1.Marks.Font.Shadow.Brush.Visible = true;
            points1.Marks.Font.Size = 8;
            points1.Marks.Font.SizeFloat = 8F;
            points1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            points1.Marks.ImageBevel.Brush.Color = Color.LightGray;
            points1.Marks.ImageBevel.Brush.Solid = true;
            points1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            points1.Marks.Shadow.Brush.Color = Color.Gray;
            points1.Marks.Shadow.Brush.Solid = true;
            points1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            points1.Marks.Symbol.Brush.Color = Color.White;
            points1.Marks.Symbol.Brush.Solid = true;
            points1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            points1.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            points1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            points1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            points1.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            points1.Marks.Symbol.Shadow.Brush.Solid = true;
            points1.Marks.Symbol.Shadow.Brush.Visible = true;
            points1.Marks.Transparent = true;
            points1.Marks.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            points1.Pointer.Brush.Color = Color.FromArgb(255, 0, 0);
            points1.Pointer.Brush.Solid = true;
            points1.Pointer.Brush.Visible = true;
            points1.Pointer.HorizSize = 3;
            // 
            // 
            // 
            points1.Pointer.Pen.Color = Color.FromArgb(255, 0, 0);
            points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            points1.Pointer.VertSize = 3;
            points1.Title = "points1";
            // 
            // 
            // 
            points1.XValues.DataMember = "X";
            points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            points1.XValues.Value = new double[]
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
            points1.YValues.DataMember = "Y";
            points1.YValues.Value = new double[]
    {
    116D,
    42D,
    97D,
    166D,
    190D,
    208D,
    233D,
    248D,
    180D,
    129D,
    58D,
    88D,
    59D,
    77D,
    24D,
    94D,
    147D,
    164D,
    232D,
    197D,
    136D,
    72D,
    105D,
    146D,
    195D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // axisScaleTool1
            // 
            axisScaleTool1.Axis = SpectrumChart.Axes.Left;
            axisScaleTool1.AxisIndex = -1;
            axisScaleTool1.AxisScaleMode = AxisScaleMode.amPeakHold;
            axisScaleTool1.DataIsSpectrum = true;
            axisScaleTool1.LowerMargin = 5;
            axisScaleTool1.UpperMargin = 20;
            // 
            // SignalRead1
            // 
            SignalRead1.ChannelCount = 1;
            SignalRead1.Complex = false;
            SignalRead1.DataSerialization = resources.GetString("SignalRead1.DataSerialization");
            SignalRead1.FloatPrecision = TMtxFloatPrecision.mvDouble;
            SignalRead1.FloatPrecisionLock = false;
            SignalRead1.FramesPerSecond = 0.0009765625D;
            SignalRead1.IsDouble = true;
            SignalRead1.Length = 1024;
            SignalRead1.OverlappingSamples = 0;
            SignalRead1.PostBufferSamples = 0;
            SignalRead1.RecordNumber = 0;
            SignalRead1.RecordPosition = 0L;
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
            SpectrumAnalyzer1.Input = SignalRead1;
            SpectrumAnalyzer1.IsDouble = true;
            SpectrumAnalyzer1.Length = 64;
            SpectrumAnalyzer1.LogBase = 0D;
            SpectrumAnalyzer1.LogScale = 0D;
            SpectrumAnalyzer1.MainlobeWidth = 8;
            SpectrumAnalyzer1.Peaks.HarmonicsCount = 10;
            SpectrumAnalyzer1.Peaks.Interpolation.Method = Dew.Signal.TInterpolationMethod.imNone;
            SpectrumAnalyzer1.Peaks.Interpolation.RecursiveHarmonics = Dew.Signal.TRecursiveHarmonics.rhNone;
            SpectrumAnalyzer1.Peaks.LargestCount = 1;
            SpectrumAnalyzer1.Peaks.LargestRatio = 1E+15D;
            SpectrumAnalyzer1.Peaks.NormalizedAmplt.PeakNumber = 1;
            SpectrumAnalyzer1.Peaks.NormalizedFreq.PeakNumber = 1;
            SpectrumAnalyzer1.Report.AmplitudeFormat = null;
            SpectrumAnalyzer1.Report.FrequencyFormat = null;
            SpectrumAnalyzer1.Report.PhaseFormat = null;
            SpectrumAnalyzer1.Report.UseTab = false;
            SpectrumAnalyzer1.Rotation = 0;
            SpectrumAnalyzer1.SamplingFrequency = 256D;
            SpectrumAnalyzer1.Stats.Averaged = 0;
            SpectrumAnalyzer1.Stats.Averages = 30;
            SpectrumAnalyzer1.Stats.ExpDecay = 5;
            SpectrumAnalyzer1.Window = Dew.Signal.TSignalWindowType.wtHanning;
            SpectrumAnalyzer1.ZeroPadding = 16;
            SpectrumAnalyzer1.OnParameterUpdateEvent += SpectrumAnalyzer1_OnParameterUpdate;
            // 
            // ChartEditor
            // 
            ChartEditor.AlwaysShowFuncSrc = false;
            ChartEditor.Chart = SpectrumChart;
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
            // PeakMarkingBasicForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(1159, 843);
            Controls.Add(SpectrumChart);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Name = "PeakMarkingBasicForm";
            Text = "PeakMarkingBasicForm";
            Load += PeakMarkingBasicForm_Load;
            panel1.ResumeLayout(false);
            ((ISupportInitialize)SpectrumChart).EndInit();
            ResumeLayout(false);

        }
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e) {
		  GetMarkTool().MarkMode = (SpectrumMarkMode) comboBox1.SelectedIndex;
		}

		private void phaseBox_CheckedChanged(object sender, System.EventArgs e) {
			SpectrumChart.SpectrumPart = (phaseBox.Checked?SpectrumPart.sppPhase:SpectrumPart.sppAmplt);
			switch (SpectrumChart.SpectrumPart) {
				case SpectrumPart.sppPhase: SpectrumChart.Axes.Left.Title.Text = "Amplitude" ;break;
				case SpectrumPart.sppAmplt: SpectrumChart.Axes.Left.Title.Text = "Phase [degrees]" ;break;
			}
		}

        protected void Add(String s)
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpectrumAnalyzerDialog.ExecuteModal();
        }

        private void PeakMarkingBasicForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("Test peak marking features:");
            Add("");
            Add(" - Move the mouse and click the left mouse button to mark a peak.");
            Add(" - Click with the left mouse button already marked peak once more to delete the mark.");
            Add(" - Double click with left mouse button to clear all marked peaks.");
            Add(" - Zoom-in the frequency spectrum by dragging a rectangle with the left mouse button.");
            Add(" - Pan the frequency spectrum by dragging with the right mouse button.");
            Add(" - Change the Mark mode edit box on the bottom of the the chart to Harmonics and move the mouse.");
            Add(" - Change the Mark mode edit box on the bottom of the the chart to Sidebands and mark two peaks. Modulation sidebands will be marked.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChartEditor.ShowModal();
        }

        private void SpectrumAnalyzer1_OnParameterUpdate(object Sender)
        {
            SpectrumAnalyzer1.Update();
        }

        private void SpectrumChart_Click(object sender, EventArgs e)
        {

        }
	}
}
