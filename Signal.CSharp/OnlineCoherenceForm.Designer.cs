namespace DSPDemo {
	partial class OnlineCoherenceForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlineCoherenceForm));
            Dew.Signal.Tee.SpectrumTeeItem spectrumTeeItem1 = new Dew.Signal.Tee.SpectrumTeeItem();
            this.CrossSpectrumAnalyzer1 = new Dew.Signal.TCrossSpectrumAnalyzer(this.components);
            this.Signal1 = new Dew.Signal.TSignal(this.components);
            this.Signal2 = new Dew.Signal.TSignal(this.components);
            this.fastLine1 = new Steema.TeeChart.Styles.FastLine();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.spectrumsBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.spectrumChart1 = new Dew.Signal.Tee.SpectrumChart();
            this.points1 = new Steema.TeeChart.Styles.Points();
            this.SignalIn1 = new Dew.Signal.Audio.SignalIn(this.components);
            this.SignalTimer1 = new Dew.Signal.Audio.SignalTimer(this.components);
            this.CrossSpectrumAnalyzerDialog1 = new Dew.Signal.Editors.CrossSpectrumAnalyzerDialog(this.components);
            this.chartEditor = new Steema.TeeChart.Editor(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // CrossSpectrumAnalyzer1
            // 
            this.CrossSpectrumAnalyzer1.Bands.TemplateIndex = -1;
            this.CrossSpectrumAnalyzer1.Bands.Templates = new Dew.Signal.TStringStreamList(System.Convert.FromBase64String("AAAAAA=="));
            this.CrossSpectrumAnalyzer1.BlockAssign = false;
            this.CrossSpectrumAnalyzer1.Complex = false;
            this.CrossSpectrumAnalyzer1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.CrossSpectrumAnalyzer1.FloatPrecisionLock = false;
            this.CrossSpectrumAnalyzer1.Input = this.Signal1;
            this.CrossSpectrumAnalyzer1.IsDouble = true;
            this.CrossSpectrumAnalyzer1.LogBase = 0D;
            this.CrossSpectrumAnalyzer1.LogScale = 0D;
            this.CrossSpectrumAnalyzer1.Name = null;
            this.CrossSpectrumAnalyzer1.Output = this.Signal2;
            this.CrossSpectrumAnalyzer1.Peaks.Interpolation.RecursiveHarmonics = Dew.Signal.TRecursiveHarmonics.rhNone;
            this.CrossSpectrumAnalyzer1.Report.UseTab = false;
            this.CrossSpectrumAnalyzer1.SpectrumScale = 0D;
            this.CrossSpectrumAnalyzer1.Stats.Averaging = Dew.Signal.TAveraging.avLinearInf;
            this.CrossSpectrumAnalyzer1.OnParameterUpdateEvent += new Dew.Math.TNotifyEvent(this.CrossSpectrumAnalyzer1_OnParameterUpdate);
            // 
            // Signal1
            // 
            this.Signal1.BandwidthL = 0D;
            this.Signal1.BlockAssign = false;
            this.Signal1.Complex = false;
            this.Signal1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.Signal1.FloatPrecisionLock = false;
            this.Signal1.Input = null;
            this.Signal1.IsDouble = true;
            this.Signal1.Name = null;
            // 
            // Signal2
            // 
            this.Signal2.BandwidthL = 0D;
            this.Signal2.BlockAssign = false;
            this.Signal2.Complex = false;
            this.Signal2.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.Signal2.FloatPrecisionLock = false;
            this.Signal2.Input = null;
            this.Signal2.IsDouble = true;
            this.Signal2.Name = null;
            // 
            // fastLine1
            // 
            this.fastLine1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.fastLine1.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.fastLine1.Legend.Brush.Color = System.Drawing.Color.White;
            this.fastLine1.Legend.Brush.Solid = true;
            this.fastLine1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.fastLine1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.fastLine1.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.fastLine1.Legend.Font.Brush.Solid = true;
            this.fastLine1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.fastLine1.Legend.Font.Shadow.Brush.Solid = true;
            this.fastLine1.Legend.Font.Shadow.Brush.Visible = true;
            this.fastLine1.Legend.Font.Size = 8;
            this.fastLine1.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.fastLine1.Legend.ImageBevel.Brush.Solid = true;
            this.fastLine1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.fastLine1.Legend.Shadow.Brush.Solid = true;
            this.fastLine1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.fastLine1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.fastLine1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fastLine1.Marks.Brush.Solid = true;
            this.fastLine1.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.fastLine1.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.fastLine1.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.fastLine1.Marks.Font.Brush.Solid = true;
            this.fastLine1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.fastLine1.Marks.Font.Shadow.Brush.Solid = true;
            this.fastLine1.Marks.Font.Shadow.Brush.Visible = true;
            this.fastLine1.Marks.Font.Size = 8;
            this.fastLine1.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.fastLine1.Marks.ImageBevel.Brush.Solid = true;
            this.fastLine1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.fastLine1.Marks.Shadow.Brush.Solid = true;
            this.fastLine1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.fastLine1.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.fastLine1.Marks.Symbol.Brush.Solid = true;
            this.fastLine1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.fastLine1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.fastLine1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine1.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.fastLine1.Marks.Symbol.Shadow.Brush.Solid = true;
            this.fastLine1.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.fastLine1.Marks.TailParams.Margin = 0F;
            this.fastLine1.Marks.TailParams.PointerHeight = 8D;
            this.fastLine1.Marks.TailParams.PointerWidth = 8D;
            this.fastLine1.OriginalCursor = Steema.TeeChart.Drawing.Cursor.Current;
            this.fastLine1.Title = "fastLine1";
            this.fastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.fastLine1.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.fastLine1.XValues.DataMember = "X";
            this.fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.fastLine1.YValues.DataMember = "Y";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(635, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.spectrumsBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 434);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 55);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // spectrumsBox
            // 
            this.spectrumsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spectrumsBox.FormattingEnabled = true;
            this.spectrumsBox.Items.AddRange(new object[] {
            "Input spectrum",
            "Output spectrum",
            "Cross spectrum",
            "Coherence",
            "TransferFunction"});
            this.spectrumsBox.Location = new System.Drawing.Point(343, 22);
            this.spectrumsBox.Name = "spectrumsBox";
            this.spectrumsBox.Size = new System.Drawing.Size(121, 21);
            this.spectrumsBox.TabIndex = 3;
            this.spectrumsBox.SelectedIndexChanged += new System.EventHandler(this.spectrumsBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Spectrum:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Spectrum";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Chart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // spectrumChart1
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
            this.spectrumChart1.Axes.Bottom.Grid.DrawEvery = 1;
            this.spectrumChart1.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart1.Axes.Bottom.Labels.Brush.Solid = true;
            this.spectrumChart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.spectrumChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.Bottom.Labels.Font.Size = 9;
            this.spectrumChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            this.spectrumChart1.Axes.Bottom.Labels.Separation = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.Bottom.MaximumOffset = 4;
            this.spectrumChart1.Axes.Bottom.MinimumOffset = 4;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart1.Axes.Bottom.Title.Brush.Solid = true;
            this.spectrumChart1.Axes.Bottom.Title.Brush.Visible = true;
            this.spectrumChart1.Axes.Bottom.Title.Caption = "Frequency [Hz]";
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.spectrumChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.Bottom.Title.Font.Size = 11;
            this.spectrumChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            this.spectrumChart1.Axes.Bottom.Title.Lines = new string[] {
        "Frequency [Hz]"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart1.Axes.Depth.Labels.Brush.Solid = true;
            this.spectrumChart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.spectrumChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.Depth.Labels.Font.Size = 9;
            this.spectrumChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart1.Axes.Depth.Title.Brush.Solid = true;
            this.spectrumChart1.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart1.Axes.Depth.Title.Font.Brush.Solid = true;
            this.spectrumChart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.Depth.Title.Font.Size = 11;
            this.spectrumChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart1.Axes.DepthTop.Labels.Brush.Solid = true;
            this.spectrumChart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.spectrumChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.DepthTop.Labels.Font.Size = 9;
            this.spectrumChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart1.Axes.DepthTop.Title.Brush.Solid = true;
            this.spectrumChart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.spectrumChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.DepthTop.Title.Font.Size = 11;
            this.spectrumChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Grid.DrawEvery = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart1.Axes.Left.Labels.Brush.Solid = true;
            this.spectrumChart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart1.Axes.Left.Labels.Font.Brush.Solid = true;
            this.spectrumChart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.Left.Labels.Font.Size = 9;
            this.spectrumChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.Left.MaximumOffset = 4;
            this.spectrumChart1.Axes.Left.MinimumOffset = 4;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart1.Axes.Left.Title.Brush.Solid = true;
            this.spectrumChart1.Axes.Left.Title.Brush.Visible = true;
            this.spectrumChart1.Axes.Left.Title.Caption = "Amplitude [dB]";
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart1.Axes.Left.Title.Font.Brush.Solid = true;
            this.spectrumChart1.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.Left.Title.Font.Size = 11;
            this.spectrumChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            this.spectrumChart1.Axes.Left.Title.Lines = new string[] {
        "Amplitude [dB]"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart1.Axes.Right.Labels.Brush.Solid = true;
            this.spectrumChart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart1.Axes.Right.Labels.Font.Brush.Solid = true;
            this.spectrumChart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.Right.Labels.Font.Size = 9;
            this.spectrumChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart1.Axes.Right.Title.Brush.Solid = true;
            this.spectrumChart1.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart1.Axes.Right.Title.Font.Brush.Solid = true;
            this.spectrumChart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.Right.Title.Font.Size = 11;
            this.spectrumChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart1.Axes.Top.Labels.Brush.Solid = true;
            this.spectrumChart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart1.Axes.Top.Labels.Font.Brush.Solid = true;
            this.spectrumChart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.Top.Labels.Font.Size = 9;
            this.spectrumChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart1.Axes.Top.Title.Brush.Solid = true;
            this.spectrumChart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart1.Axes.Top.Title.Font.Brush.Solid = true;
            this.spectrumChart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Axes.Top.Title.Font.Size = 11;
            this.spectrumChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.spectrumChart1.Color = System.Drawing.Color.White;
             
            this.spectrumChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart1.Footer.Brush.Solid = true;
            this.spectrumChart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.spectrumChart1.Footer.Font.Brush.Solid = true;
            this.spectrumChart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Footer.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Footer.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Footer.Font.Size = 8;
            this.spectrumChart1.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Footer.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Footer.Shadow.Brush.Solid = true;
            this.spectrumChart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.spectrumChart1.Header.Brush.Solid = true;
            this.spectrumChart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Header.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart1.Header.Font.Brush.Solid = true;
            this.spectrumChart1.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Header.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Header.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Header.Font.Size = 12;
            this.spectrumChart1.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Header.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Header.ImageBevel.Brush.Visible = true;
            this.spectrumChart1.Header.Lines = new string[] {
        "Frequency spectrum"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.spectrumChart1.Header.Shadow.Brush.Solid = true;
            this.spectrumChart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Legend.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart1.Legend.Brush.Solid = true;
            this.spectrumChart1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart1.Legend.Font.Brush.Solid = true;
            this.spectrumChart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Legend.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Legend.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Legend.Font.Size = 9;
            this.spectrumChart1.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Legend.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.spectrumChart1.Legend.Shadow.Brush.Solid = true;
            this.spectrumChart1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Legend.Symbol.Shadow.Brush.Solid = true;
            this.spectrumChart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart1.Legend.Title.Brush.Solid = true;
            this.spectrumChart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.spectrumChart1.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.spectrumChart1.Legend.Title.Font.Brush.Solid = true;
            this.spectrumChart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.Legend.Title.Font.Size = 8;
            this.spectrumChart1.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Legend.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Legend.Title.Shadow.Brush.Solid = true;
            this.spectrumChart1.Legend.Title.Shadow.Brush.Visible = true;
            this.spectrumChart1.Legend.Visible = false;
            this.spectrumChart1.Location = new System.Drawing.Point(0, 96);
            this.spectrumChart1.Name = "spectrumChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Panel.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart1.Panel.Brush.Solid = true;
            this.spectrumChart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Panel.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Panel.Shadow.Brush.Solid = true;
            this.spectrumChart1.Panel.Shadow.Brush.Visible = true;
            this.spectrumChart1.Series.Add(this.fastLine1);
            this.spectrumChart1.Series.Add(this.points1);
            this.spectrumChart1.Size = new System.Drawing.Size(635, 338);
            this.spectrumChart1.SpectrumPart = Dew.Signal.Tee.SpectrumPart.sppAmplt;
            spectrumTeeItem1.Caption = null;
            spectrumTeeItem1.Input = this.CrossSpectrumAnalyzer1;
            spectrumTeeItem1.Inputs = null;
            spectrumTeeItem1.InputsItemIndex = 0;
            spectrumTeeItem1.Series = this.fastLine1;
            spectrumTeeItem1.SeriesName = "fastLine1";
            this.spectrumChart1.Spectrums.Add(spectrumTeeItem1);
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart1.SubFooter.Brush.Solid = true;
            this.spectrumChart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.spectrumChart1.SubFooter.Font.Brush.Solid = true;
            this.spectrumChart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.SubFooter.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.SubFooter.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.SubFooter.Font.Size = 8;
            this.spectrumChart1.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.SubFooter.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.SubFooter.Shadow.Brush.Solid = true;
            this.spectrumChart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.spectrumChart1.SubHeader.Brush.Solid = true;
            this.spectrumChart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart1.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart1.SubHeader.Font.Brush.Solid = true;
            this.spectrumChart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.SubHeader.Font.Shadow.Brush.Solid = true;
            this.spectrumChart1.SubHeader.Font.Shadow.Brush.Visible = true;
            this.spectrumChart1.SubHeader.Font.Size = 12;
            this.spectrumChart1.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.SubHeader.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.spectrumChart1.SubHeader.Shadow.Brush.Solid = true;
            this.spectrumChart1.SubHeader.Shadow.Brush.Visible = true;
            this.spectrumChart1.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart1.Walls.Back.Brush.Solid = true;
            this.spectrumChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Walls.Back.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Walls.Back.Shadow.Brush.Solid = true;
            this.spectrumChart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart1.Walls.Bottom.Brush.Solid = true;
            this.spectrumChart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Walls.Bottom.Shadow.Brush.Solid = true;
            this.spectrumChart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.spectrumChart1.Walls.Left.Brush.Solid = true;
            this.spectrumChart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Walls.Left.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Walls.Left.Shadow.Brush.Solid = true;
            this.spectrumChart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart1.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.spectrumChart1.Walls.Right.Brush.Solid = true;
            this.spectrumChart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart1.Walls.Right.ImageBevel.Brush.Solid = true;
            this.spectrumChart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Walls.Right.Shadow.Brush.Solid = true;
            this.spectrumChart1.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart1.Zoom.Animated = true;
            // 
            // 
            // 
            this.spectrumChart1.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.spectrumChart1.Zoom.Brush.Solid = true;
            this.spectrumChart1.Zoom.Brush.Visible = false;
            this.spectrumChart1.Zoom.History = true;
            this.spectrumChart1.Zoom.FullRepaint = true;
            this.spectrumChart1.Zoom.Pen.Visible = true;
            this.spectrumChart1.Click += new System.EventHandler(this.spectrumChart1_Click);
            // 
            // points1
            // 
            this.points1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.points1.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.points1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Marks.Arrow.Visible = false;
            this.points1.Marks.ArrowLength = 10;
            // 
            // 
            // 
            this.points1.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.points1.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.points1.Marks.TailParams.Margin = 0F;
            this.points1.Marks.TailParams.PointerHeight = 8D;
            this.points1.Marks.TailParams.PointerWidth = 8D;
            this.points1.Marks.Transparent = true;
            this.points1.Marks.Visible = true;
            this.points1.OriginalCursor = Steema.TeeChart.Drawing.Cursor.Current;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.points1.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.points1.Pointer.Brush.Solid = true;
            this.points1.Pointer.Brush.Visible = true;
            this.points1.Pointer.HorizSize = 3;
            // 
            // 
            // 
            this.points1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.points1.Pointer.SizeDouble = 0D;
            this.points1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.points1.Pointer.VertSize = 3;
            this.points1.Title = "points1";
            this.points1.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.points1.XValues.DataMember = "X";
            this.points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.points1.YValues.DataMember = "Y";
            // 
            // SignalIn1
            // 
            this.SignalIn1.BandwidthL = 0D;
            this.SignalIn1.BlockAssign = false;
            this.SignalIn1.BufferSize = 32000;
            this.SignalIn1.CalibrationTarget = 0;
            this.SignalIn1.ChannelCount = 2;
            this.SignalIn1.Complex = false;
            this.SignalIn1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.SignalIn1.FloatPrecisionLock = false;
            this.SignalIn1.Input = null;
            this.SignalIn1.IsDouble = true;
            this.SignalIn1.Name = null;
            this.SignalIn1.Quantization = ((ushort)(16));
            this.SignalIn1.SamplingFrequency = 44100D;
            this.SignalIn1.TriggerAbove = 0D;
            this.SignalIn1.TriggerBelow = 0D;
            this.SignalIn1.TriggerChannel = Dew.Signal.TChannel.chLeft;
            this.SignalIn1.TriggerDelay = 0;
            this.SignalIn1.Triggering = Dew.Signal.Audio.TriggerType.trNone;
            this.SignalIn1.TriggerMode = Dew.Signal.Audio.TriggerMode.trCrossing;
            this.SignalIn1.TriggerPosition = Dew.Signal.Audio.TriggerPosition.tpAfter;
            // 
            // SignalTimer1
            // 
            this.SignalTimer1.BlockAssign = false;
            this.SignalTimer1.Enabled = true;
            this.SignalTimer1.Frequency = 20D;
            this.SignalTimer1.Interval = ((uint)(50u));
            this.SignalTimer1.Name = null;
            this.SignalTimer1.Resolution = ((uint)(10u));
            this.SignalTimer1.OnTimer += new System.EventHandler(this.SignalTimer1_OnTimer);
            // 
            // CrossSpectrumAnalyzerDialog1
            // 
            this.CrossSpectrumAnalyzerDialog1.BlockAssign = false;
            this.CrossSpectrumAnalyzerDialog1.Docking = false;
            this.CrossSpectrumAnalyzerDialog1.FormCaption = null;
            this.CrossSpectrumAnalyzerDialog1.Name = null;
            this.CrossSpectrumAnalyzerDialog1.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.CrossSpectrumAnalyzerDialog1.ShowLive = false;
            this.CrossSpectrumAnalyzerDialog1.Source = this.CrossSpectrumAnalyzer1;
            this.CrossSpectrumAnalyzerDialog1.SourceListIndex = 0;
            // 
            // chartEditor
            // 
            this.chartEditor.Chart = this.spectrumChart1;
            this.chartEditor.HighLightTabs = false;
            this.chartEditor.Location = new System.Drawing.Point(0, 0);
            this.chartEditor.Name = "chartEditor";
            this.chartEditor.Options = null;
            this.chartEditor.TabIndex = 0;
            // 
            // OnlineCoherenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 489);
            this.Controls.Add(this.spectrumChart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "OnlineCoherenceForm";
            this.Text = "OnlineCoherenceForm";
            this.Load += new System.EventHandler(this.OnlineCoherenceForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumChart1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private Dew.Signal.Tee.SpectrumChart spectrumChart1;
		private System.Windows.Forms.ComboBox spectrumsBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private Dew.Signal.Audio.SignalIn SignalIn1;
		private Dew.Signal.TSignal Signal1;
		private Dew.Signal.TSignal Signal2;
		private Dew.Signal.Audio.SignalTimer SignalTimer1;
		private Dew.Signal.TCrossSpectrumAnalyzer CrossSpectrumAnalyzer1;
		private Dew.Signal.Editors.CrossSpectrumAnalyzerDialog CrossSpectrumAnalyzerDialog1;
		private Steema.TeeChart.Editor chartEditor;
		private Steema.TeeChart.Styles.FastLine fastLine1;
		private Steema.TeeChart.Styles.Points points1;
        private System.Windows.Forms.Button button3;
	}
}