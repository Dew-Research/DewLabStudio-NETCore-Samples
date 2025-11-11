namespace DSPDemo {
	partial class OnlineBicoherenceForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlineBicoherenceForm));
            Dew.Signal.Tee.SpectrumTeeItem spectrumTeeItem1 = new Dew.Signal.Tee.SpectrumTeeItem();
            Dew.Signal.Tee.SpectrumTeeItem spectrumTeeItem2 = new Dew.Signal.Tee.SpectrumTeeItem();
            this.SpectrumAnalyzer1 = new Dew.Signal.TSpectrumAnalyzer(this.components);
            this.Signal1 = new Dew.Signal.TSignal(this.components);
            this.fastLine2 = new Steema.TeeChart.Styles.FastLine();
            this.BiSpectrumAnalyzer1 = new Dew.Signal.TBiSpectrumAnalyzer(this.components);
            this.fastLine1 = new Steema.TeeChart.Styles.FastLine();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.channelBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.freqEdit = new Dew.Math.Controls.FloatEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.spectrumChart2 = new Dew.Signal.Tee.SpectrumChart();
            this.points2 = new Steema.TeeChart.Styles.Points();
            this.colorLine1 = new Steema.TeeChart.Tools.ColorLine();
            this.spectrumChart1 = new Dew.Signal.Tee.SpectrumChart();
            this.points1 = new Steema.TeeChart.Styles.Points();
            this.SignalIn1 = new Dew.Signal.Audio.SignalIn(this.components);
            this.SignalTimer1 = new Dew.Signal.Audio.SignalTimer(this.components);
            this.SpectrumAnalyzerDialog1 = new Dew.Signal.Editors.SpectrumAnalyzerDialog(this.components);
            this.BiSpectrumAnalyzerDialog1 = new Dew.Signal.Editors.BiSpectrumAnalyzerDialog(this.components);
            this.chartEditor = new Steema.TeeChart.Editor(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumChart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // SpectrumAnalyzer1
            // 
            this.SpectrumAnalyzer1.Bands.TemplateIndex = -1;
            this.SpectrumAnalyzer1.Bands.Templates = new Dew.Signal.TStringStreamList(System.Convert.FromBase64String("AAAAAA=="));
            this.SpectrumAnalyzer1.BlockAssign = false;
            this.SpectrumAnalyzer1.Complex = false;
            this.SpectrumAnalyzer1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.SpectrumAnalyzer1.FloatPrecisionLock = false;
            this.SpectrumAnalyzer1.Input = this.Signal1;
            this.SpectrumAnalyzer1.IsDouble = true;
            this.SpectrumAnalyzer1.Logarithmic = true;
            this.SpectrumAnalyzer1.LogBase = 0D;
            this.SpectrumAnalyzer1.LogScale = 0D;
            this.SpectrumAnalyzer1.Name = null;
            this.SpectrumAnalyzer1.Output = null;
            this.SpectrumAnalyzer1.Peaks.Interpolation.RecursiveHarmonics = Dew.Signal.TRecursiveHarmonics.rhNone;
            this.SpectrumAnalyzer1.Report.AmplitudeFormat = null;
            this.SpectrumAnalyzer1.Report.FrequencyFormat = null;
            this.SpectrumAnalyzer1.Report.PhaseFormat = null;
            this.SpectrumAnalyzer1.Report.UseTab = false;
            this.SpectrumAnalyzer1.SamplingFrequency = 2D;
            this.SpectrumAnalyzer1.SpectrumScale = 0D;
            this.SpectrumAnalyzer1.Window = Dew.Signal.TSignalWindowType.wtHanning;
            this.SpectrumAnalyzer1.ZeroPadding = 2;
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
            // fastLine2
            // 
            this.fastLine2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.fastLine2.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.fastLine2.Legend.Brush.Color = System.Drawing.Color.White;
            this.fastLine2.Legend.Brush.Solid = true;
            this.fastLine2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.fastLine2.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.fastLine2.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.fastLine2.Legend.Font.Brush.Solid = true;
            this.fastLine2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.fastLine2.Legend.Font.Shadow.Brush.Solid = true;
            this.fastLine2.Legend.Font.Shadow.Brush.Visible = true;
            this.fastLine2.Legend.Font.Size = 8;
            this.fastLine2.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.fastLine2.Legend.ImageBevel.Brush.Solid = true;
            this.fastLine2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.fastLine2.Legend.Shadow.Brush.Solid = true;
            this.fastLine2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.fastLine2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.fastLine2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fastLine2.Marks.Brush.Solid = true;
            this.fastLine2.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.fastLine2.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.fastLine2.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.fastLine2.Marks.Font.Brush.Solid = true;
            this.fastLine2.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.fastLine2.Marks.Font.Shadow.Brush.Solid = true;
            this.fastLine2.Marks.Font.Shadow.Brush.Visible = true;
            this.fastLine2.Marks.Font.Size = 8;
            this.fastLine2.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.fastLine2.Marks.ImageBevel.Brush.Solid = true;
            this.fastLine2.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.fastLine2.Marks.Shadow.Brush.Solid = true;
            this.fastLine2.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.fastLine2.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.fastLine2.Marks.Symbol.Brush.Solid = true;
            this.fastLine2.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.fastLine2.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.fastLine2.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.fastLine2.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.fastLine2.Marks.Symbol.Shadow.Brush.Solid = true;
            this.fastLine2.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.fastLine2.Marks.TailParams.Margin = 0F;
            this.fastLine2.Marks.TailParams.PointerHeight = 8D;
            this.fastLine2.Marks.TailParams.PointerWidth = 8D;
            this.fastLine2.OriginalCursor = Steema.TeeChart.Drawing.Cursor.Current;
            this.fastLine2.Title = "fastLine1";
            this.fastLine2.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.fastLine2.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.fastLine2.XValues.DataMember = "X";
            this.fastLine2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.fastLine2.YValues.DataMember = "Y";
            // 
            // BiSpectrumAnalyzer1
            // 
            this.BiSpectrumAnalyzer1.Bands.TemplateIndex = -1;
            this.BiSpectrumAnalyzer1.Bands.Templates = new Dew.Signal.TStringStreamList(System.Convert.FromBase64String("AAAAAA=="));
            this.BiSpectrumAnalyzer1.BlockAssign = false;
            this.BiSpectrumAnalyzer1.Complex = false;
            this.BiSpectrumAnalyzer1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.BiSpectrumAnalyzer1.FloatPrecisionLock = false;
            this.BiSpectrumAnalyzer1.Input = this.Signal1;
            this.BiSpectrumAnalyzer1.IsDouble = true;
            this.BiSpectrumAnalyzer1.LogBase = 0D;
            this.BiSpectrumAnalyzer1.LogScale = 0D;
            this.BiSpectrumAnalyzer1.Name = null;
            this.BiSpectrumAnalyzer1.Output = null;
            this.BiSpectrumAnalyzer1.Peaks.Interpolation.RecursiveHarmonics = Dew.Signal.TRecursiveHarmonics.rhNone;
            this.BiSpectrumAnalyzer1.Report.UseTab = false;
            this.BiSpectrumAnalyzer1.SpectrumScale = 0D;
            this.BiSpectrumAnalyzer1.Stats.Averaging = Dew.Signal.TAveraging.avLinearInf;
            this.BiSpectrumAnalyzer1.Window = Dew.Signal.TSignalWindowType.wtHanning;
            // 
            // fastLine1
            // 
            this.fastLine1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
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
            this.fastLine1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
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
            this.richTextBox1.Size = new System.Drawing.Size(657, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.channelBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.freqEdit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 456);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 55);
            this.panel1.TabIndex = 1;
            // 
            // channelBox
            // 
            this.channelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.channelBox.FormattingEnabled = true;
            this.channelBox.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.channelBox.Location = new System.Drawing.Point(486, 22);
            this.channelBox.Name = "channelBox";
            this.channelBox.Size = new System.Drawing.Size(68, 21);
            this.channelBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Channel:";
            // 
            // freqEdit
            // 
            this.freqEdit.Increment = "10";
            this.freqEdit.Location = new System.Drawing.Point(346, 23);
            this.freqEdit.Name = "freqEdit";
            this.freqEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.freqEdit.Scientific = false;
            this.freqEdit.Size = new System.Drawing.Size(57, 20);
            this.freqEdit.TabIndex = 4;
            this.freqEdit.Value = "20.00";
            this.freqEdit.Click += new System.EventHandler(this.freqEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Frequency:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Chart";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Bispectrum";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Spectrum";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.spectrumChart2);
            this.panel2.Controls.Add(this.spectrumChart1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 360);
            this.panel2.TabIndex = 2;
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 164);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(657, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // spectrumChart2
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
            this.spectrumChart2.Axes.Bottom.Grid.DrawEvery = 1;
            this.spectrumChart2.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart2.Axes.Bottom.Labels.Brush.Solid = true;
            this.spectrumChart2.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart2.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.spectrumChart2.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.spectrumChart2.Axes.Bottom.Labels.Font.Size = 9;
            this.spectrumChart2.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart2.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.spectrumChart2.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            this.spectrumChart2.Axes.Bottom.Labels.Separation = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            this.spectrumChart2.Axes.Bottom.MaximumOffset = 4;
            this.spectrumChart2.Axes.Bottom.MinimumOffset = 4;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart2.Axes.Bottom.Title.Brush.Solid = true;
            this.spectrumChart2.Axes.Bottom.Title.Brush.Visible = true;
            this.spectrumChart2.Axes.Bottom.Title.Caption = "Frequency [Hz]";
            // 
            // 
            // 
            this.spectrumChart2.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart2.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.spectrumChart2.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart2.Axes.Bottom.Title.Font.Size = 11;
            this.spectrumChart2.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart2.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart2.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            this.spectrumChart2.Axes.Bottom.Title.Lines = new string[] {
        "Frequency [Hz]"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Depth.Automatic = false;
            this.spectrumChart2.Axes.Depth.AutomaticMaximum = false;
            this.spectrumChart2.Axes.Depth.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart2.Axes.Depth.Labels.Brush.Solid = true;
            this.spectrumChart2.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart2.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.spectrumChart2.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.spectrumChart2.Axes.Depth.Labels.Font.Size = 9;
            this.spectrumChart2.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart2.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.spectrumChart2.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            this.spectrumChart2.Axes.Depth.Maximum = 0D;
            this.spectrumChart2.Axes.Depth.Minimum = 0D;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart2.Axes.Depth.Title.Brush.Solid = true;
            this.spectrumChart2.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart2.Axes.Depth.Title.Font.Brush.Solid = true;
            this.spectrumChart2.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart2.Axes.Depth.Title.Font.Size = 11;
            this.spectrumChart2.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart2.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart2.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart2.Axes.DepthTop.Automatic = false;
            this.spectrumChart2.Axes.DepthTop.AutomaticMaximum = false;
            this.spectrumChart2.Axes.DepthTop.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart2.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart2.Axes.DepthTop.Labels.Brush.Solid = true;
            this.spectrumChart2.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart2.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart2.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart2.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.spectrumChart2.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.spectrumChart2.Axes.DepthTop.Labels.Font.Size = 9;
            this.spectrumChart2.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.spectrumChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            this.spectrumChart2.Axes.DepthTop.Maximum = 0D;
            this.spectrumChart2.Axes.DepthTop.Minimum = 0D;
            // 
            // 
            // 
            this.spectrumChart2.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.spectrumChart2.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart2.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart2.Axes.DepthTop.Title.Brush.Solid = true;
            this.spectrumChart2.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart2.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart2.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart2.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.spectrumChart2.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart2.Axes.DepthTop.Title.Font.Size = 11;
            this.spectrumChart2.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart2.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart2.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart2.Axes.Left.Labels.Brush.Solid = true;
            this.spectrumChart2.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart2.Axes.Left.Labels.Font.Brush.Solid = true;
            this.spectrumChart2.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.spectrumChart2.Axes.Left.Labels.Font.Size = 9;
            this.spectrumChart2.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart2.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.spectrumChart2.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart2.Axes.Left.Title.Brush.Solid = true;
            this.spectrumChart2.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart2.Axes.Left.Title.Font.Brush.Solid = true;
            this.spectrumChart2.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart2.Axes.Left.Title.Font.Size = 11;
            this.spectrumChart2.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart2.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart2.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Right.Automatic = false;
            this.spectrumChart2.Axes.Right.AutomaticMaximum = false;
            this.spectrumChart2.Axes.Right.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart2.Axes.Right.Labels.Brush.Solid = true;
            this.spectrumChart2.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart2.Axes.Right.Labels.Font.Brush.Solid = true;
            this.spectrumChart2.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.spectrumChart2.Axes.Right.Labels.Font.Size = 9;
            this.spectrumChart2.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart2.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.spectrumChart2.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.Right.Labels.Shadow.Brush.Visible = true;
            this.spectrumChart2.Axes.Right.Maximum = 0D;
            this.spectrumChart2.Axes.Right.Minimum = 0D;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart2.Axes.Right.Title.Brush.Solid = true;
            this.spectrumChart2.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart2.Axes.Right.Title.Font.Brush.Solid = true;
            this.spectrumChart2.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart2.Axes.Right.Title.Font.Size = 11;
            this.spectrumChart2.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart2.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart2.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Top.Automatic = false;
            this.spectrumChart2.Axes.Top.AutomaticMaximum = false;
            this.spectrumChart2.Axes.Top.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart2.Axes.Top.Labels.Brush.Solid = true;
            this.spectrumChart2.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart2.Axes.Top.Labels.Font.Brush.Solid = true;
            this.spectrumChart2.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.spectrumChart2.Axes.Top.Labels.Font.Size = 9;
            this.spectrumChart2.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart2.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.spectrumChart2.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.Top.Labels.Shadow.Brush.Visible = true;
            this.spectrumChart2.Axes.Top.Maximum = 0D;
            this.spectrumChart2.Axes.Top.Minimum = 0D;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart2.Axes.Top.Title.Brush.Solid = true;
            this.spectrumChart2.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart2.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart2.Axes.Top.Title.Font.Brush.Solid = true;
            this.spectrumChart2.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart2.Axes.Top.Title.Font.Size = 11;
            this.spectrumChart2.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart2.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart2.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.spectrumChart2.Color = System.Drawing.Color.White;
             
            this.spectrumChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart2.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart2.Footer.Brush.Solid = true;
            this.spectrumChart2.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart2.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart2.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.spectrumChart2.Footer.Font.Brush.Solid = true;
            this.spectrumChart2.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Footer.Font.Shadow.Brush.Solid = true;
            this.spectrumChart2.Footer.Font.Shadow.Brush.Visible = true;
            this.spectrumChart2.Footer.Font.Size = 8;
            this.spectrumChart2.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart2.Footer.ImageBevel.Brush.Solid = true;
            this.spectrumChart2.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Footer.Shadow.Brush.Solid = true;
            this.spectrumChart2.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart2.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.spectrumChart2.Header.Brush.Solid = true;
            this.spectrumChart2.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart2.Header.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart2.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart2.Header.Font.Brush.Solid = true;
            this.spectrumChart2.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Header.Font.Shadow.Brush.Solid = true;
            this.spectrumChart2.Header.Font.Shadow.Brush.Visible = true;
            this.spectrumChart2.Header.Font.Size = 12;
            this.spectrumChart2.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart2.Header.ImageBevel.Brush.Solid = true;
            this.spectrumChart2.Header.ImageBevel.Brush.Visible = true;
            this.spectrumChart2.Header.Lines = new string[] {
        "Frequency spectrum"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.spectrumChart2.Header.Shadow.Brush.Solid = true;
            this.spectrumChart2.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart2.Legend.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart2.Legend.Brush.Solid = true;
            this.spectrumChart2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart2.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart2.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart2.Legend.Font.Brush.Solid = true;
            this.spectrumChart2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Legend.Font.Shadow.Brush.Solid = true;
            this.spectrumChart2.Legend.Font.Shadow.Brush.Visible = true;
            this.spectrumChart2.Legend.Font.Size = 9;
            this.spectrumChart2.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart2.Legend.ImageBevel.Brush.Solid = true;
            this.spectrumChart2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.spectrumChart2.Legend.Shadow.Brush.Solid = true;
            this.spectrumChart2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Legend.Symbol.Shadow.Brush.Solid = true;
            this.spectrumChart2.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart2.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart2.Legend.Title.Brush.Solid = true;
            this.spectrumChart2.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart2.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.spectrumChart2.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.spectrumChart2.Legend.Title.Font.Brush.Solid = true;
            this.spectrumChart2.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart2.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart2.Legend.Title.Font.Size = 8;
            this.spectrumChart2.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart2.Legend.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart2.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Legend.Title.Shadow.Brush.Solid = true;
            this.spectrumChart2.Legend.Title.Shadow.Brush.Visible = true;
            this.spectrumChart2.Legend.Visible = false;
            this.spectrumChart2.Location = new System.Drawing.Point(0, 164);
            this.spectrumChart2.Name = "spectrumChart2";
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart2.Panel.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart2.Panel.Brush.Solid = true;
            this.spectrumChart2.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart2.Panel.ImageBevel.Brush.Solid = true;
            this.spectrumChart2.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Panel.Shadow.Brush.Solid = true;
            this.spectrumChart2.Panel.Shadow.Brush.Visible = true;
            this.spectrumChart2.Series.Add(this.fastLine2);
            this.spectrumChart2.Series.Add(this.points2);
            this.spectrumChart2.Size = new System.Drawing.Size(657, 196);
            this.spectrumChart2.SpectrumPart = Dew.Signal.Tee.SpectrumPart.sppAmplt;
            spectrumTeeItem1.Caption = null;
            spectrumTeeItem1.Input = this.SpectrumAnalyzer1;
            spectrumTeeItem1.Inputs = null;
            spectrumTeeItem1.InputsItemIndex = 0;
            spectrumTeeItem1.Series = this.fastLine2;
            spectrumTeeItem1.SeriesName = "fastLine1";
            this.spectrumChart2.Spectrums.Add(spectrumTeeItem1);
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart2.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart2.SubFooter.Brush.Solid = true;
            this.spectrumChart2.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart2.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart2.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.spectrumChart2.SubFooter.Font.Brush.Solid = true;
            this.spectrumChart2.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.SubFooter.Font.Shadow.Brush.Solid = true;
            this.spectrumChart2.SubFooter.Font.Shadow.Brush.Visible = true;
            this.spectrumChart2.SubFooter.Font.Size = 8;
            this.spectrumChart2.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart2.SubFooter.ImageBevel.Brush.Solid = true;
            this.spectrumChart2.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.SubFooter.Shadow.Brush.Solid = true;
            this.spectrumChart2.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart2.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.spectrumChart2.SubHeader.Brush.Solid = true;
            this.spectrumChart2.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart2.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart2.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart2.SubHeader.Font.Brush.Solid = true;
            this.spectrumChart2.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.SubHeader.Font.Shadow.Brush.Solid = true;
            this.spectrumChart2.SubHeader.Font.Shadow.Brush.Visible = true;
            this.spectrumChart2.SubHeader.Font.Size = 12;
            this.spectrumChart2.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart2.SubHeader.ImageBevel.Brush.Solid = true;
            this.spectrumChart2.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.spectrumChart2.SubHeader.Shadow.Brush.Solid = true;
            this.spectrumChart2.SubHeader.Shadow.Brush.Visible = true;
            this.spectrumChart2.TabIndex = 1;
            this.spectrumChart2.Tools.Add(this.colorLine1);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart2.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart2.Walls.Back.Brush.Solid = true;
            this.spectrumChart2.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart2.Walls.Back.ImageBevel.Brush.Solid = true;
            this.spectrumChart2.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Walls.Back.Shadow.Brush.Solid = true;
            this.spectrumChart2.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart2.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart2.Walls.Bottom.Brush.Solid = true;
            this.spectrumChart2.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart2.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.spectrumChart2.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Walls.Bottom.Shadow.Brush.Solid = true;
            this.spectrumChart2.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart2.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.spectrumChart2.Walls.Left.Brush.Solid = true;
            this.spectrumChart2.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart2.Walls.Left.ImageBevel.Brush.Solid = true;
            this.spectrumChart2.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Walls.Left.Shadow.Brush.Solid = true;
            this.spectrumChart2.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart2.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.spectrumChart2.Walls.Right.Brush.Solid = true;
            this.spectrumChart2.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart2.Walls.Right.ImageBevel.Brush.Solid = true;
            this.spectrumChart2.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Walls.Right.Shadow.Brush.Solid = true;
            this.spectrumChart2.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart2.Zoom.Animated = true;
            // 
            // 
            // 
            this.spectrumChart2.Zoom.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.spectrumChart2.Zoom.Brush.Solid = true;
            this.spectrumChart2.Zoom.Brush.Visible = true;
            this.spectrumChart2.Zoom.FullRepaint = true;
            this.spectrumChart2.Zoom.History = true;
            // 
            // 
            // 
            this.spectrumChart2.Zoom.Pen.Visible = true;
            // 
            // points2
            // 
            this.points2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.points2.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points2.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.points2.Legend.Brush.Color = System.Drawing.Color.White;
            this.points2.Legend.Brush.Solid = true;
            this.points2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.points2.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.points2.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.points2.Legend.Font.Brush.Solid = true;
            this.points2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.points2.Legend.Font.Shadow.Brush.Solid = true;
            this.points2.Legend.Font.Shadow.Brush.Visible = true;
            this.points2.Legend.Font.Size = 8;
            this.points2.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.points2.Legend.ImageBevel.Brush.Solid = true;
            this.points2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points2.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.points2.Legend.Shadow.Brush.Solid = true;
            this.points2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.points2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.points2.Marks.Arrow.Visible = false;
            this.points2.Marks.ArrowLength = 10;
            // 
            // 
            // 
            this.points2.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.points2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.points2.Marks.Brush.Solid = true;
            this.points2.Marks.Brush.Visible = false;
            // 
            // 
            // 
            this.points2.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.points2.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.points2.Marks.Font.Brush.Solid = true;
            this.points2.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points2.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.points2.Marks.Font.Shadow.Brush.Solid = true;
            this.points2.Marks.Font.Shadow.Brush.Visible = true;
            this.points2.Marks.Font.Size = 8;
            this.points2.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points2.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.points2.Marks.ImageBevel.Brush.Solid = true;
            this.points2.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points2.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.points2.Marks.Shadow.Brush.Solid = true;
            this.points2.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points2.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.points2.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.points2.Marks.Symbol.Brush.Solid = true;
            this.points2.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points2.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.points2.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.points2.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points2.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.points2.Marks.Symbol.Shadow.Brush.Solid = true;
            this.points2.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.points2.Marks.TailParams.Margin = 0F;
            this.points2.Marks.TailParams.PointerHeight = 8D;
            this.points2.Marks.TailParams.PointerWidth = 8D;
            this.points2.Marks.Transparent = true;
            this.points2.Marks.Visible = true;
            this.points2.OriginalCursor = Steema.TeeChart.Drawing.Cursor.Current;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.points2.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.points2.Pointer.Brush.Solid = true;
            this.points2.Pointer.Brush.Visible = true;
            this.points2.Pointer.HorizSize = 3;
            // 
            // 
            // 
            this.points2.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.points2.Pointer.SizeDouble = 0D;
            this.points2.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.points2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Circle;
            this.points2.Pointer.VertSize = 3;
            this.points2.Title = "points1";
            this.points2.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.points2.XValues.DataMember = "X";
            this.points2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.points2.YValues.DataMember = "Y";
            // 
            // colorLine1
            // 
            this.colorLine1.Axis = this.spectrumChart2.Axes.Bottom;
            this.colorLine1.OriginalCursor = Steema.TeeChart.Drawing.Cursor.Current;
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
            this.spectrumChart1.Axes.Depth.Automatic = false;
            this.spectrumChart1.Axes.Depth.AutomaticMaximum = false;
            this.spectrumChart1.Axes.Depth.AutomaticMinimum = false;
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
            this.spectrumChart1.Axes.Depth.Maximum = 0D;
            this.spectrumChart1.Axes.Depth.Minimum = 0D;
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
            this.spectrumChart1.Axes.DepthTop.Automatic = false;
            this.spectrumChart1.Axes.DepthTop.AutomaticMaximum = false;
            this.spectrumChart1.Axes.DepthTop.AutomaticMinimum = false;
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
            this.spectrumChart1.Axes.DepthTop.Maximum = 0D;
            this.spectrumChart1.Axes.DepthTop.Minimum = 0D;
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
            this.spectrumChart1.Axes.Right.Automatic = false;
            this.spectrumChart1.Axes.Right.AutomaticMaximum = false;
            this.spectrumChart1.Axes.Right.AutomaticMinimum = false;
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
            this.spectrumChart1.Axes.Right.Maximum = 0D;
            this.spectrumChart1.Axes.Right.Minimum = 0D;
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
            this.spectrumChart1.Axes.Top.Automatic = false;
            this.spectrumChart1.Axes.Top.AutomaticMaximum = false;
            this.spectrumChart1.Axes.Top.AutomaticMinimum = false;
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
            this.spectrumChart1.Axes.Top.Maximum = 0D;
            this.spectrumChart1.Axes.Top.Minimum = 0D;
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
             
            this.spectrumChart1.Dock = System.Windows.Forms.DockStyle.Top;
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
        "Bicoherence"};
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
            this.spectrumChart1.Location = new System.Drawing.Point(0, 0);
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
            this.spectrumChart1.Size = new System.Drawing.Size(657, 164);
            this.spectrumChart1.SpectrumPart = Dew.Signal.Tee.SpectrumPart.sppAmplt;
            spectrumTeeItem2.Caption = null;
            spectrumTeeItem2.Input = this.BiSpectrumAnalyzer1;
            spectrumTeeItem2.Inputs = null;
            spectrumTeeItem2.InputsItemIndex = 0;
            spectrumTeeItem2.Series = this.fastLine1;
            spectrumTeeItem2.SeriesName = "fastLine1";
            this.spectrumChart1.Spectrums.Add(spectrumTeeItem2);
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
            this.spectrumChart1.TabIndex = 0;
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
            this.spectrumChart1.Zoom.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.spectrumChart1.Zoom.Brush.Solid = true;
            this.spectrumChart1.Zoom.Brush.Visible = true;
            this.spectrumChart1.Zoom.FullRepaint = true;
            this.spectrumChart1.Zoom.History = true;
            // 
            // 
            // 
            this.spectrumChart1.Zoom.Pen.Visible = true;
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
            this.points1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
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
            this.points1.Marks.Symbol.Transparent = true;
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
            this.points1.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.points1.Pointer.Brush.Solid = true;
            this.points1.Pointer.Brush.Visible = true;
            this.points1.Pointer.HorizSize = 3;
            // 
            // 
            // 
            this.points1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
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
            this.SignalTimer1.Frequency = 10D;
            this.SignalTimer1.Interval = ((uint)(100u));
            this.SignalTimer1.Name = null;
            this.SignalTimer1.Resolution = ((uint)(10u));
            this.SignalTimer1.OnTimer += new System.EventHandler(this.SignalTimer1_OnTimer);
            // 
            // SpectrumAnalyzerDialog1
            // 
            this.SpectrumAnalyzerDialog1.BlockAssign = false;
            this.SpectrumAnalyzerDialog1.Docking = false;
            this.SpectrumAnalyzerDialog1.FormCaption = null;
            this.SpectrumAnalyzerDialog1.Name = null;
            this.SpectrumAnalyzerDialog1.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.SpectrumAnalyzerDialog1.ShowLive = false;
            this.SpectrumAnalyzerDialog1.Source = this.SpectrumAnalyzer1;
            this.SpectrumAnalyzerDialog1.SourceListIndex = 0;
            // 
            // BiSpectrumAnalyzerDialog1
            // 
            this.BiSpectrumAnalyzerDialog1.BlockAssign = false;
            this.BiSpectrumAnalyzerDialog1.Docking = false;
            this.BiSpectrumAnalyzerDialog1.FormCaption = null;
            this.BiSpectrumAnalyzerDialog1.Name = null;
            this.BiSpectrumAnalyzerDialog1.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.BiSpectrumAnalyzerDialog1.ShowLive = false;
            this.BiSpectrumAnalyzerDialog1.Source = this.BiSpectrumAnalyzer1;
            this.BiSpectrumAnalyzerDialog1.SourceListIndex = 0;
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
            // OnlineBicoherenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "OnlineBicoherenceForm";
            this.Text = "OnlineBicoherenceForm";
            this.Load += new System.EventHandler(this.OnlineBicoherenceForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spectrumChart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumChart1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Splitter splitter1;
		private Dew.Signal.Tee.SpectrumChart spectrumChart2;
		private Dew.Signal.Tee.SpectrumChart spectrumChart1;
		private Dew.Signal.Audio.SignalIn SignalIn1;
		private Dew.Signal.TSignal Signal1;
		private Dew.Signal.Audio.SignalTimer SignalTimer1;
		private Dew.Signal.TSpectrumAnalyzer SpectrumAnalyzer1;
		private Dew.Signal.Editors.SpectrumAnalyzerDialog SpectrumAnalyzerDialog1;
		private Dew.Signal.TBiSpectrumAnalyzer BiSpectrumAnalyzer1;
		private Dew.Signal.Editors.BiSpectrumAnalyzerDialog BiSpectrumAnalyzerDialog1;
		private Steema.TeeChart.Styles.FastLine fastLine1;
		private Steema.TeeChart.Styles.Points points1;
		private Steema.TeeChart.Styles.FastLine fastLine2;
		private Steema.TeeChart.Styles.Points points2;
		private System.Windows.Forms.ComboBox channelBox;
		private System.Windows.Forms.Label label2;
		private Dew.Math.Controls.FloatEdit freqEdit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Editor chartEditor;
		private Steema.TeeChart.Tools.ColorLine colorLine1;
	}
}