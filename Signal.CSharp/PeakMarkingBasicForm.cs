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
        private Dew.Signal.SpectrumAnalyzerDialog SpectrumAnalyzerDialog;
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

            SignalRead1.FileName = Dew.Demo.Utils.SourcePath() + @"\Data\bz.sfs";
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
            this.components = new System.ComponentModel.Container();
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeakMarkingBasicForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.phaseBox = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SpectrumChart = new Dew.Signal.Tee.SpectrumChart();
            this.mtxFastLine1 = new Dew.Math.Tee.MtxFastLine();
            this.points1 = new Steema.TeeChart.Styles.Points();
            this.axisScaleTool1 = new Dew.Signal.Tee.AxisScaleTool();
            this.SignalRead1 = new Dew.Signal.TSignalRead(this.components);
            this.SpectrumAnalyzer1 = new Dew.Signal.TSpectrumAnalyzer(this.components);
            this.ChartEditor = new Steema.TeeChart.Editor(this.components);
            this.SpectrumAnalyzerDialog = new Dew.Signal.SpectrumAnalyzerDialog(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpectrumChart)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(629, 118);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "richTextBox1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.phaseBox);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 51);
            this.panel1.TabIndex = 1;
            // 
            // phaseBox
            // 
            this.phaseBox.Location = new System.Drawing.Point(506, 11);
            this.phaseBox.Name = "phaseBox";
            this.phaseBox.Size = new System.Drawing.Size(125, 30);
            this.phaseBox.TabIndex = 4;
            this.phaseBox.Text = "Phase";
            this.phaseBox.CheckedChanged += new System.EventHandler(this.phaseBox_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Single peak",
            "Harmonic series",
            "Sidebands 1",
            "Sidebands 2",
            "Free style"});
            this.comboBox1.Location = new System.Drawing.Point(353, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(228, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mark mode:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Chart";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Spectrum";
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.SpectrumChart.Axes.Bottom.Grid.DrawEvery = 1;
            this.SpectrumChart.Axes.Bottom.Grid.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Labels.Axis = this.SpectrumChart.Axes.Bottom;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart.Axes.Bottom.Labels.Brush.Solid = true;
            this.SpectrumChart.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.SpectrumChart.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.Bottom.Labels.Font.Size = 9;
            this.SpectrumChart.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            this.SpectrumChart.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            this.SpectrumChart.Axes.Bottom.Labels.Separation = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.Bottom.MaximumOffset = 4;
            this.SpectrumChart.Axes.Bottom.MinimumOffset = 4;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.MinorTicks.Length = 2;
            this.SpectrumChart.Axes.Bottom.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Ticks.Length = 4;
            this.SpectrumChart.Axes.Bottom.Ticks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SpectrumChart.Axes.Bottom.TicksInner.Length = 0;
            this.SpectrumChart.Axes.Bottom.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart.Axes.Bottom.Title.Brush.Solid = true;
            this.SpectrumChart.Axes.Bottom.Title.Brush.Visible = true;
            this.SpectrumChart.Axes.Bottom.Title.Caption = "Frequency [Hz]";
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.SpectrumChart.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.Bottom.Title.Font.Size = 11;
            this.SpectrumChart.Axes.Bottom.Title.Font.SizeFloat = 11F;
            this.SpectrumChart.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            this.SpectrumChart.Axes.Bottom.Title.Lines = new string[] {
        "Frequency [Hz]"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.AxisPen.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Labels.Axis = this.SpectrumChart.Axes.Depth;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart.Axes.Depth.Labels.Brush.Solid = true;
            this.SpectrumChart.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.SpectrumChart.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.Depth.Labels.Font.Size = 9;
            this.SpectrumChart.Axes.Depth.Labels.Font.SizeFloat = 9F;
            this.SpectrumChart.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.MinorTicks.Length = 2;
            this.SpectrumChart.Axes.Depth.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Ticks.Length = 4;
            this.SpectrumChart.Axes.Depth.Ticks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.TicksInner.Length = 0;
            this.SpectrumChart.Axes.Depth.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart.Axes.Depth.Title.Brush.Solid = true;
            this.SpectrumChart.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart.Axes.Depth.Title.Font.Brush.Solid = true;
            this.SpectrumChart.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.Depth.Title.Font.Size = 11;
            this.SpectrumChart.Axes.Depth.Title.Font.SizeFloat = 11F;
            this.SpectrumChart.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.AxisPen.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Labels.Axis = this.SpectrumChart.Axes.DepthTop;
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart.Axes.DepthTop.Labels.Brush.Solid = true;
            this.SpectrumChart.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.SpectrumChart.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.DepthTop.Labels.Font.Size = 9;
            this.SpectrumChart.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            this.SpectrumChart.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.MinorTicks.Length = 2;
            this.SpectrumChart.Axes.DepthTop.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Ticks.Length = 4;
            this.SpectrumChart.Axes.DepthTop.Ticks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.TicksInner.Length = 0;
            this.SpectrumChart.Axes.DepthTop.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart.Axes.DepthTop.Title.Brush.Solid = true;
            this.SpectrumChart.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.SpectrumChart.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.DepthTop.Title.Font.Size = 11;
            this.SpectrumChart.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            this.SpectrumChart.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.AxisPen.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Labels.Axis = this.SpectrumChart.Axes.Left;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart.Axes.Left.Labels.Brush.Solid = true;
            this.SpectrumChart.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart.Axes.Left.Labels.Font.Brush.Solid = true;
            this.SpectrumChart.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.Left.Labels.Font.Size = 9;
            this.SpectrumChart.Axes.Left.Labels.Font.SizeFloat = 9F;
            this.SpectrumChart.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Left.Labels.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.Left.MaximumOffset = 4;
            this.SpectrumChart.Axes.Left.MinimumOffset = 4;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.MinorTicks.Length = 2;
            this.SpectrumChart.Axes.Left.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Ticks.Length = 4;
            this.SpectrumChart.Axes.Left.Ticks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.TicksInner.Length = 0;
            this.SpectrumChart.Axes.Left.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart.Axes.Left.Title.Brush.Solid = true;
            this.SpectrumChart.Axes.Left.Title.Brush.Visible = true;
            this.SpectrumChart.Axes.Left.Title.Caption = "Amplitude";
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart.Axes.Left.Title.Font.Brush.Solid = true;
            this.SpectrumChart.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.Left.Title.Font.Size = 11;
            this.SpectrumChart.Axes.Left.Title.Font.SizeFloat = 11F;
            this.SpectrumChart.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            this.SpectrumChart.Axes.Left.Title.Lines = new string[] {
        "Amplitude"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.AxisPen.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Labels.Axis = this.SpectrumChart.Axes.Right;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart.Axes.Right.Labels.Brush.Solid = true;
            this.SpectrumChart.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart.Axes.Right.Labels.Font.Brush.Solid = true;
            this.SpectrumChart.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.Right.Labels.Font.Size = 9;
            this.SpectrumChart.Axes.Right.Labels.Font.SizeFloat = 9F;
            this.SpectrumChart.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.MinorTicks.Length = 2;
            this.SpectrumChart.Axes.Right.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Ticks.Length = 4;
            this.SpectrumChart.Axes.Right.Ticks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.TicksInner.Length = 0;
            this.SpectrumChart.Axes.Right.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart.Axes.Right.Title.Brush.Solid = true;
            this.SpectrumChart.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart.Axes.Right.Title.Font.Brush.Solid = true;
            this.SpectrumChart.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.Right.Title.Font.Size = 11;
            this.SpectrumChart.Axes.Right.Title.Font.SizeFloat = 11F;
            this.SpectrumChart.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Labels.Axis = this.SpectrumChart.Axes.Top;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart.Axes.Top.Labels.Brush.Solid = true;
            this.SpectrumChart.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart.Axes.Top.Labels.Font.Brush.Solid = true;
            this.SpectrumChart.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.Top.Labels.Font.Size = 9;
            this.SpectrumChart.Axes.Top.Labels.Font.SizeFloat = 9F;
            this.SpectrumChart.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.MinorTicks.Length = 2;
            this.SpectrumChart.Axes.Top.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Ticks.Length = 4;
            this.SpectrumChart.Axes.Top.Ticks.Visible = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.TicksInner.Length = 0;
            this.SpectrumChart.Axes.Top.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart.Axes.Top.Title.Brush.Solid = true;
            this.SpectrumChart.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart.Axes.Top.Title.Font.Brush.Solid = true;
            this.SpectrumChart.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Axes.Top.Title.Font.Size = 11;
            this.SpectrumChart.Axes.Top.Title.Font.SizeFloat = 11F;
            this.SpectrumChart.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.SpectrumChart.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SpectrumChart.Cursor = System.Windows.Forms.Cursors.Default;
            this.SpectrumChart.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart.Footer.Brush.Solid = true;
            this.SpectrumChart.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.SpectrumChart.Footer.Font.Brush.Solid = true;
            this.SpectrumChart.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Footer.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Footer.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Footer.Font.Size = 8;
            this.SpectrumChart.Footer.Font.SizeFloat = 8F;
            this.SpectrumChart.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Footer.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Footer.Shadow.Brush.Solid = true;
            this.SpectrumChart.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SpectrumChart.Header.Brush.Solid = true;
            this.SpectrumChart.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Header.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart.Header.Font.Brush.Solid = true;
            this.SpectrumChart.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Header.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Header.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Header.Font.Size = 12;
            this.SpectrumChart.Header.Font.SizeFloat = 12F;
            this.SpectrumChart.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Header.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Header.ImageBevel.Brush.Visible = true;
            this.SpectrumChart.Header.Lines = new string[] {
        "Frequency spectrum"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SpectrumChart.Header.Shadow.Brush.Solid = true;
            this.SpectrumChart.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Legend.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart.Legend.Brush.Solid = true;
            this.SpectrumChart.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SpectrumChart.Legend.Font.Brush.Solid = true;
            this.SpectrumChart.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Legend.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Legend.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Legend.Font.Size = 9;
            this.SpectrumChart.Legend.Font.SizeFloat = 9F;
            this.SpectrumChart.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Legend.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Legend.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SpectrumChart.Legend.Shadow.Brush.Solid = true;
            this.SpectrumChart.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Legend.Symbol.Legend = this.SpectrumChart.Legend;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Legend.Symbol.Shadow.Brush.Solid = true;
            this.SpectrumChart.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart.Legend.Title.Brush.Solid = true;
            this.SpectrumChart.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.SpectrumChart.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.SpectrumChart.Legend.Title.Font.Brush.Solid = true;
            this.SpectrumChart.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.Legend.Title.Font.Size = 8;
            this.SpectrumChart.Legend.Title.Font.SizeFloat = 8F;
            this.SpectrumChart.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Legend.Title.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Legend.Title.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Legend.Title.Shadow.Brush.Solid = true;
            this.SpectrumChart.Legend.Title.Shadow.Brush.Visible = true;
            this.SpectrumChart.Legend.Visible = false;
            this.SpectrumChart.Location = new System.Drawing.Point(0, 118);
            this.SpectrumChart.Name = "SpectrumChart";
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.Lowered;
            // 
            // 
            // 
            this.SpectrumChart.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.SpectrumChart.Panel.Brush.Gradient.UseMiddle = true;
            this.SpectrumChart.Panel.Brush.Solid = true;
            this.SpectrumChart.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Panel.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Panel.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Panel.Shadow.Brush.Solid = true;
            this.SpectrumChart.Panel.Shadow.Brush.Visible = true;
            this.SpectrumChart.Series.Add(this.mtxFastLine1);
            this.SpectrumChart.Series.Add(this.points1);
            this.SpectrumChart.Size = new System.Drawing.Size(629, 292);
            this.SpectrumChart.SpectrumPart = Dew.Signal.Tee.SpectrumPart.sppAmplt;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart.SubFooter.Brush.Solid = true;
            this.SpectrumChart.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.SpectrumChart.SubFooter.Font.Brush.Solid = true;
            this.SpectrumChart.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.SubFooter.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.SubFooter.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.SubFooter.Font.Size = 8;
            this.SpectrumChart.SubFooter.Font.SizeFloat = 8F;
            this.SpectrumChart.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.SubFooter.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.SubFooter.Shadow.Brush.Solid = true;
            this.SpectrumChart.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SpectrumChart.SubHeader.Brush.Solid = true;
            this.SpectrumChart.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.SpectrumChart.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SpectrumChart.SubHeader.Font.Brush.Solid = true;
            this.SpectrumChart.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.SubHeader.Font.Shadow.Brush.Solid = true;
            this.SpectrumChart.SubHeader.Font.Shadow.Brush.Visible = true;
            this.SpectrumChart.SubHeader.Font.Size = 12;
            this.SpectrumChart.SubHeader.Font.SizeFloat = 12F;
            this.SpectrumChart.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.SubHeader.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SpectrumChart.SubHeader.Shadow.Brush.Solid = true;
            this.SpectrumChart.SubHeader.Shadow.Brush.Visible = true;
            this.SpectrumChart.TabIndex = 2;
            this.SpectrumChart.Tools.Add(this.axisScaleTool1);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.SpectrumChart.Walls.Back.Brush.Solid = true;
            this.SpectrumChart.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Walls.Back.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Walls.Back.Shadow.Brush.Solid = true;
            this.SpectrumChart.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.SpectrumChart.Walls.Bottom.Brush.Solid = true;
            this.SpectrumChart.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Walls.Bottom.Shadow.Brush.Solid = true;
            this.SpectrumChart.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.SpectrumChart.Walls.Left.Brush.Solid = true;
            this.SpectrumChart.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Walls.Left.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Walls.Left.Shadow.Brush.Solid = true;
            this.SpectrumChart.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.SpectrumChart.Walls.Right.Brush.Solid = true;
            this.SpectrumChart.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.SpectrumChart.Walls.Right.ImageBevel.Brush.Solid = true;
            this.SpectrumChart.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.SpectrumChart.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.SpectrumChart.Walls.Right.Shadow.Brush.Solid = true;
            this.SpectrumChart.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.SpectrumChart.Zoom.Animated = true;
            // 
            // 
            // 
            this.SpectrumChart.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.SpectrumChart.Zoom.Brush.Solid = true;
            this.SpectrumChart.Zoom.Brush.Visible = false;
            this.SpectrumChart.Zoom.FullRepaint = true;
            this.SpectrumChart.Zoom.History = true;
            // 
            // 
            // 
            this.SpectrumChart.Zoom.Pen.Visible = true;
            this.SpectrumChart.Click += new System.EventHandler(this.SpectrumChart_Click);
            // 
            // mtxFastLine1
            // 
            // 
            // 
            // 
            this.mtxFastLine1.Brush.Color = System.Drawing.Color.Empty;
            this.mtxFastLine1.Brush.Solid = true;
            this.mtxFastLine1.Brush.Visible = true;
            this.mtxFastLine1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mtxFastLine1.ColorEach = false;
            cursor1.CursorType = Steema.TeeChart.Drawing.CursorType.Default;
            this.mtxFastLine1.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.mtxFastLine1.Legend.Brush.Color = System.Drawing.Color.White;
            this.mtxFastLine1.Legend.Brush.Solid = true;
            this.mtxFastLine1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.mtxFastLine1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.mtxFastLine1.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.mtxFastLine1.Legend.Font.Brush.Solid = true;
            this.mtxFastLine1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.mtxFastLine1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.mtxFastLine1.Legend.Font.Shadow.Brush.Solid = true;
            this.mtxFastLine1.Legend.Font.Shadow.Brush.Visible = true;
            this.mtxFastLine1.Legend.Font.Size = 8;
            this.mtxFastLine1.Legend.Font.SizeFloat = 8F;
            this.mtxFastLine1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.mtxFastLine1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.mtxFastLine1.Legend.ImageBevel.Brush.Solid = true;
            this.mtxFastLine1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.mtxFastLine1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.mtxFastLine1.Legend.Shadow.Brush.Solid = true;
            this.mtxFastLine1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.mtxFastLine1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mtxFastLine1.Marks.Brush.Solid = true;
            this.mtxFastLine1.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.mtxFastLine1.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.mtxFastLine1.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.mtxFastLine1.Marks.Font.Brush.Solid = true;
            this.mtxFastLine1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.mtxFastLine1.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.mtxFastLine1.Marks.Font.Shadow.Brush.Solid = true;
            this.mtxFastLine1.Marks.Font.Shadow.Brush.Visible = true;
            this.mtxFastLine1.Marks.Font.Size = 8;
            this.mtxFastLine1.Marks.Font.SizeFloat = 8F;
            this.mtxFastLine1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.mtxFastLine1.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.mtxFastLine1.Marks.ImageBevel.Brush.Solid = true;
            this.mtxFastLine1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.mtxFastLine1.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.mtxFastLine1.Marks.Shadow.Brush.Solid = true;
            this.mtxFastLine1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.mtxFastLine1.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.mtxFastLine1.Marks.Symbol.Brush.Solid = true;
            this.mtxFastLine1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.mtxFastLine1.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.mtxFastLine1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.mtxFastLine1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.mtxFastLine1.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.mtxFastLine1.Marks.Symbol.Shadow.Brush.Solid = true;
            this.mtxFastLine1.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.mtxFastLine1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
            this.mtxFastLine1.Marks.TailParams.Margin = 0F;
            this.mtxFastLine1.Marks.TailParams.PointerHeight = 8D;
            this.mtxFastLine1.Marks.TailParams.PointerWidth = 8D;
            this.mtxFastLine1.OriginalCursor = cursor1;
            this.mtxFastLine1.RandomData = true;
            this.mtxFastLine1.Title = "mtxFastLine1";
            this.mtxFastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.mtxFastLine1.Type = "Dew.Math.Tee.MtxFastLine";
            this.mtxFastLine1.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.mtxFastLine1.XValues.DataMember = "X";
            this.mtxFastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.mtxFastLine1.XValues.Series = this.mtxFastLine1;
            // 
            // 
            // 
            this.mtxFastLine1.YValues.DataMember = "Y";
            this.mtxFastLine1.YValues.Series = this.mtxFastLine1;
            // 
            // points1
            // 
            // 
            // 
            // 
            this.points1.Brush.Color = System.Drawing.Color.Empty;
            this.points1.Brush.Solid = true;
            this.points1.Brush.Visible = true;
            this.points1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.points1.ColorEach = false;
            this.points1.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Legend.Brush.Color = System.Drawing.Color.White;
            this.points1.Legend.Brush.Solid = true;
            this.points1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.points1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.points1.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.points1.Legend.Font.Brush.Solid = true;
            this.points1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.points1.Legend.Font.Shadow.Brush.Solid = true;
            this.points1.Legend.Font.Shadow.Brush.Visible = true;
            this.points1.Legend.Font.Size = 8;
            this.points1.Legend.Font.SizeFloat = 8F;
            this.points1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.points1.Legend.ImageBevel.Brush.Solid = true;
            this.points1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.points1.Legend.Shadow.Brush.Solid = true;
            this.points1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.points1.Marks.Brush.Solid = true;
            this.points1.Marks.Brush.Visible = false;
            // 
            // 
            // 
            this.points1.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.points1.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.points1.Marks.Font.Brush.Solid = true;
            this.points1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.points1.Marks.Font.Shadow.Brush.Solid = true;
            this.points1.Marks.Font.Shadow.Brush.Visible = true;
            this.points1.Marks.Font.Size = 8;
            this.points1.Marks.Font.SizeFloat = 8F;
            this.points1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.points1.Marks.ImageBevel.Brush.Solid = true;
            this.points1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.points1.Marks.Shadow.Brush.Solid = true;
            this.points1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.points1.Marks.Symbol.Brush.Solid = true;
            this.points1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.points1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.points1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.points1.Marks.Symbol.Shadow.Brush.Solid = true;
            this.points1.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.points1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
            this.points1.Marks.TailParams.Margin = 0F;
            this.points1.Marks.TailParams.PointerHeight = 8D;
            this.points1.Marks.TailParams.PointerWidth = 8D;
            this.points1.Marks.Transparent = true;
            this.points1.Marks.Visible = true;
            this.points1.OriginalCursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.points1.Pointer.Brush.Solid = true;
            this.points1.Pointer.Brush.Visible = true;
            this.points1.Pointer.HorizSize = 3;
            // 
            // 
            // 
            this.points1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.points1.Pointer.SizeDouble = 0D;
            this.points1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.points1.Pointer.VertSize = 3;
            this.points1.RandomData = true;
            this.points1.Title = "points1";
            this.points1.Type = "Steema.TeeChart.Styles.Points";
            this.points1.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.points1.XValues.DataMember = "X";
            this.points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.points1.XValues.Series = this.points1;
            // 
            // 
            // 
            this.points1.YValues.DataMember = "Y";
            this.points1.YValues.Series = this.points1;
            // 
            // axisScaleTool1
            // 
            this.axisScaleTool1.Axis = this.SpectrumChart.Axes.Left;
            this.axisScaleTool1.AxisIndex = -1;
            this.axisScaleTool1.AxisScaleMode = Dew.Signal.Tee.AxisScaleMode.amPeakHold;
            this.axisScaleTool1.DataIsSpectrum = true;
            this.axisScaleTool1.LowerMargin = 5;
            this.axisScaleTool1.Type = "Dew.Signal.Tee.AxisScaleTool";
            this.axisScaleTool1.UpperMargin = 20;
            // 
            // SignalRead1
            // 
            this.SignalRead1.BandwidthL = 0D;
            this.SignalRead1.BlockAssign = false;
            this.SignalRead1.ChannelCount = 1;
            this.SignalRead1.Complex = false;
            this.SignalRead1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.SignalRead1.FloatPrecisionLock = false;
            this.SignalRead1.FramesPerSecond = 0.0009765625D;
            this.SignalRead1.Input = null;
            this.SignalRead1.IsDouble = true;
            this.SignalRead1.Length = 1024;
            this.SignalRead1.Name = "";
            this.SignalRead1.OnAfterUpdate = null;
            this.SignalRead1.OnBeforeUpdate = null;
            this.SignalRead1.OnDisplayUpdate = null;
            this.SignalRead1.OnGetInput = null;
            this.SignalRead1.OnNotifyUpdate = null;
            this.SignalRead1.OnParameterUpdate = null;
            this.SignalRead1.OnProcessAll = null;
            this.SignalRead1.OnRecordPositionChange = null;
            this.SignalRead1.OverlappingSamples = 0;
            this.SignalRead1.PostBufferSamples = 0;
            this.SignalRead1.RecordNumber = 0;
            this.SignalRead1.RecordPosition = ((long)(0));
            // 
            // SpectrumAnalyzer1
            // 
            this.SpectrumAnalyzer1.ArOrder = 100;
            this.SpectrumAnalyzer1.Bands.TemplateIndex = -1;
            this.SpectrumAnalyzer1.Bands.Templates = ((Dew.Signal.TStringStreamList)(resources.GetObject("resource.Templates")));
            this.SpectrumAnalyzer1.BlockAssign = false;
            this.SpectrumAnalyzer1.Complex = false;
            this.SpectrumAnalyzer1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.SpectrumAnalyzer1.FloatPrecisionLock = false;
            this.SpectrumAnalyzer1.Harmonics = 10;
            this.SpectrumAnalyzer1.Input = this.SignalRead1;
            this.SpectrumAnalyzer1.IsDouble = true;
            this.SpectrumAnalyzer1.Length = 64;
            this.SpectrumAnalyzer1.LogBase = 0D;
            this.SpectrumAnalyzer1.LogScale = 0D;
            this.SpectrumAnalyzer1.MainlobeWidth = 8;
            this.SpectrumAnalyzer1.Name = "";
            this.SpectrumAnalyzer1.OnAfterAverage = null;
            this.SpectrumAnalyzer1.OnAfterComplexSpectrum = null;
            this.SpectrumAnalyzer1.OnAfterUpdate = null;
            this.SpectrumAnalyzer1.OnBandsUpdate = null;
            this.SpectrumAnalyzer1.OnBeforeAverage = null;
            this.SpectrumAnalyzer1.OnBeforeSpectrumType = null;
            this.SpectrumAnalyzer1.OnBeforeUpdate = null;
            this.SpectrumAnalyzer1.OnDisplayUpdate = null;
            this.SpectrumAnalyzer1.OnGetInput = null;
            this.SpectrumAnalyzer1.OnNotifyUpdate = null;
            this.SpectrumAnalyzer1.OnParameterUpdate = null;
            this.SpectrumAnalyzer1.OnPeaksUpdate = null;
            this.SpectrumAnalyzer1.Output = null;
            this.SpectrumAnalyzer1.Peaks.HarmonicsCount = 10;
            this.SpectrumAnalyzer1.Peaks.Interpolation.Method = Dew.Signal.TInterpolationMethod.imNone;
            this.SpectrumAnalyzer1.Peaks.Interpolation.RecursiveHarmonics = Dew.Signal.TRecursiveHarmonics.rhNone;
            this.SpectrumAnalyzer1.Peaks.LargestCount = 1;
            this.SpectrumAnalyzer1.Report.AmplitudeFormat = null;
            this.SpectrumAnalyzer1.Report.FrequencyFormat = null;
            this.SpectrumAnalyzer1.Report.PhaseFormat = null;
            this.SpectrumAnalyzer1.Report.UseTab = false;
            this.SpectrumAnalyzer1.Rotation = 0;
            this.SpectrumAnalyzer1.SamplingFrequency = 256D;
            this.SpectrumAnalyzer1.SpectrumScale = 0D;
            this.SpectrumAnalyzer1.Stats.Averaged = 0;
            this.SpectrumAnalyzer1.Stats.Averages = 30;
            this.SpectrumAnalyzer1.Stats.ExpDecay = 5;
            this.SpectrumAnalyzer1.Window = Dew.Signal.TSignalWindowType.wtHanning;
            this.SpectrumAnalyzer1.ZeroPadding = 16;
            this.SpectrumAnalyzer1.OnParameterUpdateEvent += new Dew.Math.TNotifyEvent(this.SpectrumAnalyzer1_OnParameterUpdateEvent);
            // 
            // ChartEditor
            // 
            this.ChartEditor.AlwaysShowFuncSrc = false;
            this.ChartEditor.Chart = this.SpectrumChart;
            this.ChartEditor.HighLightTabs = false;
            this.ChartEditor.Location = new System.Drawing.Point(0, 0);
            this.ChartEditor.Name = "ChartEditor";
            this.ChartEditor.Options = null;
            this.ChartEditor.TabIndex = 0;
            // 
            // SpectrumAnalyzerDialog
            // 
            this.SpectrumAnalyzerDialog.BlockAssign = false;
            this.SpectrumAnalyzerDialog.Docking = false;
            this.SpectrumAnalyzerDialog.FormCaption = null;
            this.SpectrumAnalyzerDialog.Name = null;
            this.SpectrumAnalyzerDialog.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.SpectrumAnalyzerDialog.ShowLive = false;
            this.SpectrumAnalyzerDialog.Source = this.SpectrumAnalyzer1;
            this.SpectrumAnalyzerDialog.SourceListIndex = 0;
            // 
            // PeakMarkingBasicForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(629, 461);
            this.Controls.Add(this.SpectrumChart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "PeakMarkingBasicForm";
            this.Text = "PeakMarkingBasicForm";
            this.Load += new System.EventHandler(this.PeakMarkingBasicForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpectrumChart)).EndInit();
            this.ResumeLayout(false);

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

        private void SpectrumChart_Click(object sender, EventArgs e)
        {

        }

        private void SpectrumAnalyzer1_OnParameterUpdateEvent(object Sender)
        {
            SpectrumAnalyzer1.Update();
        }
    }
}
