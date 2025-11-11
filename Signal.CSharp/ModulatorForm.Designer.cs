namespace DSPDemo {
	partial class ModulatorForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModulatorForm));
            Dew.Signal.Tee.SpectrumTeeItem spectrumTeeItem1 = new Dew.Signal.Tee.SpectrumTeeItem();
            Dew.Signal.Tee.SpectrumTeeItem spectrumTeeItem2 = new Dew.Signal.Tee.SpectrumTeeItem();
            this.spectrumAnalyzer2 = new Dew.Signal.TSpectrumAnalyzer(this.components);
            this.signalRead1 = new Dew.Signal.TSignalRead(this.components);
            this.fastLine2 = new Steema.TeeChart.Styles.FastLine();
            this.spectrumAnalyzer1 = new Dew.Signal.TSpectrumAnalyzer(this.components);
            this.signalBuffer1 = new Dew.Signal.TSignalBuffer(this.components);
            this.signalModulator1 = new Dew.Signal.TSignalModulator(this.components);
            this.fastLine1 = new Steema.TeeChart.Styles.FastLine();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.attBox = new System.Windows.Forms.ComboBox();
            this.floatEdit2 = new Dew.Math.Controls.FloatEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.filterDelayLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.floatEdit1 = new Dew.Math.Controls.FloatEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.spectrumChart2 = new Dew.Signal.Tee.SpectrumChart();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.spectrumChart1 = new Dew.Signal.Tee.SpectrumChart();
            this.editor1 = new Steema.TeeChart.Editor(this.components);
            this.spectrumAnalyzerDialog1 = new Dew.Signal.Editors.SpectrumAnalyzerDialog(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumChart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // spectrumAnalyzer2
            // 
            this.spectrumAnalyzer2.Bands.TemplateIndex = -1;
            this.spectrumAnalyzer2.Bands.Templates = new Dew.Signal.TStringStreamList(System.Convert.FromBase64String("AAAAAA=="));
            this.spectrumAnalyzer2.BlockAssign = false;
            this.spectrumAnalyzer2.Complex = false;
            this.spectrumAnalyzer2.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.spectrumAnalyzer2.FloatPrecisionLock = false;
            this.spectrumAnalyzer2.Input = this.signalRead1;
            this.spectrumAnalyzer2.IsDouble = true;
            this.spectrumAnalyzer2.LogBase = 0D;
            this.spectrumAnalyzer2.LogScale = 0D;
            this.spectrumAnalyzer2.Name = null;
            this.spectrumAnalyzer2.Output = null;
            this.spectrumAnalyzer2.Peaks.Interpolation.RecursiveHarmonics = Dew.Signal.TRecursiveHarmonics.rhNone;
            this.spectrumAnalyzer2.Report.AmplitudeFormat = null;
            this.spectrumAnalyzer2.Report.FrequencyFormat = null;
            this.spectrumAnalyzer2.Report.PhaseFormat = null;
            this.spectrumAnalyzer2.Report.UseTab = false;
            this.spectrumAnalyzer2.SamplingFrequency = 4D;
            this.spectrumAnalyzer2.SpectrumScale = 0D;
            this.spectrumAnalyzer2.Stats.Averaged = 0;
            this.spectrumAnalyzer2.Stats.Averages = 30;
            this.spectrumAnalyzer2.ZeroPadding = 4;
            this.spectrumAnalyzer2.OnParameterUpdateEvent += new Dew.Math.TNotifyEvent(this.spectrumAnalyzer1_OnParameterUpdate);
            // 
            // signalRead1
            // 
            this.signalRead1.BandwidthL = 0D;
            this.signalRead1.BlockAssign = false;
            this.signalRead1.Complex = false;
            this.signalRead1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.signalRead1.FloatPrecisionLock = false;
            this.signalRead1.FramesPerSecond = 0.0009765625D;
            this.signalRead1.Input = null;
            this.signalRead1.IsDouble = true;
            this.signalRead1.LastFrameCheck = Dew.Signal.TLastFrameCheck.lfcZeroPadded;
            this.signalRead1.Length = 1024;
            this.signalRead1.Name = null;
            this.signalRead1.PostBufferSamples = 0;
            this.signalRead1.RecordPosition = ((long)(0));
            this.signalRead1.SamplingFrequency = 4666.66666666667D;
            // 
            // fastLine2
            // 
            this.fastLine2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
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
            this.fastLine2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
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
            // spectrumAnalyzer1
            // 
            this.spectrumAnalyzer1.Bands.TemplateIndex = -1;
            this.spectrumAnalyzer1.Bands.Templates = new Dew.Signal.TStringStreamList(System.Convert.FromBase64String("AAAAAA=="));
            this.spectrumAnalyzer1.BlockAssign = false;
            this.spectrumAnalyzer1.Complex = false;
            this.spectrumAnalyzer1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.spectrumAnalyzer1.FloatPrecisionLock = false;
            this.spectrumAnalyzer1.Input = this.signalBuffer1;
            this.spectrumAnalyzer1.IsDouble = true;
            this.spectrumAnalyzer1.LogBase = 0D;
            this.spectrumAnalyzer1.LogScale = 0D;
            this.spectrumAnalyzer1.Name = null;
            this.spectrumAnalyzer1.Output = null;
            this.spectrumAnalyzer1.Peaks.Interpolation.RecursiveHarmonics = Dew.Signal.TRecursiveHarmonics.rhNone;
            this.spectrumAnalyzer1.Report.AmplitudeFormat = null;
            this.spectrumAnalyzer1.Report.FrequencyFormat = null;
            this.spectrumAnalyzer1.Report.PhaseFormat = null;
            this.spectrumAnalyzer1.Report.UseTab = false;
            this.spectrumAnalyzer1.SamplingFrequency = 4D;
            this.spectrumAnalyzer1.SpectrumScale = 0D;
            this.spectrumAnalyzer1.Stats.Averaged = 0;
            this.spectrumAnalyzer1.Stats.Averages = 30;
            this.spectrumAnalyzer1.Window = Dew.Signal.TSignalWindowType.wtHanning;
            this.spectrumAnalyzer1.ZeroPadding = 4;
            this.spectrumAnalyzer1.OnParameterUpdateEvent += new Dew.Math.TNotifyEvent(this.spectrumAnalyzer1_OnParameterUpdate);
            // 
            // signalBuffer1
            // 
            this.signalBuffer1.BandwidthL = 0D;
            this.signalBuffer1.BlockAssign = false;
            this.signalBuffer1.Complex = false;
            this.signalBuffer1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.signalBuffer1.FloatPrecisionLock = false;
            this.signalBuffer1.IncrementStep = 2D;
            this.signalBuffer1.Input = this.signalModulator1;
            this.signalBuffer1.IsDouble = true;
            this.signalBuffer1.Length = 2048;
            this.signalBuffer1.Name = null;
            // 
            // signalModulator1
            // 
            this.signalModulator1.BandwidthL = 0D;
            this.signalModulator1.BlockAssign = false;
            this.signalModulator1.Complex = false;
            this.signalModulator1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.signalModulator1.FloatPrecisionLock = false;
            this.signalModulator1.HalfBand = false;
            this.signalModulator1.Input = this.signalRead1;
            this.signalModulator1.IsDouble = true;
            this.signalModulator1.Name = null;
            // 
            // fastLine1
            // 
            this.fastLine1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
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
            this.fastLine1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
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
            this.richTextBox1.Size = new System.Drawing.Size(895, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.attBox);
            this.panel1.Controls.Add(this.floatEdit2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.filterDelayLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.floatEdit1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 467);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 50);
            this.panel1.TabIndex = 1;
            // 
            // attBox
            // 
            this.attBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.attBox.FormattingEnabled = true;
            this.attBox.Items.AddRange(new object[] {
            "80",
            "120",
            "160"});
            this.attBox.Location = new System.Drawing.Point(781, 17);
            this.attBox.Name = "attBox";
            this.attBox.Size = new System.Drawing.Size(76, 21);
            this.attBox.TabIndex = 4;
            this.attBox.SelectedIndexChanged += new System.EventHandler(this.floatEdit1_TextChanged);
            // 
            // floatEdit2
            // 
            this.floatEdit2.Increment = "0.01";
            this.floatEdit2.Location = new System.Drawing.Point(517, 18);
            this.floatEdit2.MaxValue = "1000";
            this.floatEdit2.Name = "floatEdit2";
            this.floatEdit2.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.floatEdit2.Scientific = false;
            this.floatEdit2.Size = new System.Drawing.Size(76, 20);
            this.floatEdit2.TabIndex = 3;
            this.floatEdit2.Value = "2.00";
            this.floatEdit2.TextChanged += new System.EventHandler(this.floatEdit1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(711, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Attenuation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(863, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "[dB]";
            // 
            // filterDelayLabel
            // 
            this.filterDelayLabel.AutoSize = true;
            this.filterDelayLabel.Location = new System.Drawing.Point(612, 20);
            this.filterDelayLabel.Name = "filterDelayLabel";
            this.filterDelayLabel.Size = new System.Drawing.Size(37, 13);
            this.filterDelayLabel.TabIndex = 2;
            this.filterDelayLabel.Text = "Delay:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rate factor:";
            // 
            // floatEdit1
            // 
            this.floatEdit1.Increment = "0.01";
            this.floatEdit1.Location = new System.Drawing.Point(349, 18);
            this.floatEdit1.MaxValue = "500";
            this.floatEdit1.Name = "floatEdit1";
            this.floatEdit1.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.floatEdit1.Scientific = false;
            this.floatEdit1.Size = new System.Drawing.Size(76, 20);
            this.floatEdit1.TabIndex = 3;
            this.floatEdit1.Value = "0.00";
            this.floatEdit1.TextChanged += new System.EventHandler(this.floatEdit1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Carrier frequency:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Spectrum chart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Spectrum";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.spectrumChart2);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.spectrumChart1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 371);
            this.panel2.TabIndex = 2;
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart2.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart2.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart2.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
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
            // 
            // 
            // 
            this.spectrumChart2.Axes.Right.AxisPen.Visible = true;
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
        "Original spectrum"};
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
            this.spectrumChart2.Location = new System.Drawing.Point(0, 176);
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
            this.spectrumChart2.Size = new System.Drawing.Size(895, 195);
            this.spectrumChart2.SpectrumPart = Dew.Signal.Tee.SpectrumPart.sppAmplt;
            spectrumTeeItem1.Caption = null;
            spectrumTeeItem1.Input = this.spectrumAnalyzer2;
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
            this.spectrumChart2.TabIndex = 2;
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
            this.spectrumChart2.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.spectrumChart2.Zoom.Brush.Solid = true;
            this.spectrumChart2.Zoom.Brush.Visible = false;
            this.spectrumChart2.Zoom.FullRepaint = true;
            this.spectrumChart2.Zoom.History = true;
            // 
            // 
            // 
            this.spectrumChart2.Zoom.Pen.Visible = true;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 173);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(895, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
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
        "Frequency spectrum of the modulated signal"};
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
            this.spectrumChart1.Size = new System.Drawing.Size(895, 173);
            this.spectrumChart1.SpectrumPart = Dew.Signal.Tee.SpectrumPart.sppAmplt;
            spectrumTeeItem2.Caption = null;
            spectrumTeeItem2.Input = this.spectrumAnalyzer1;
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
            this.spectrumChart1.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.spectrumChart1.Zoom.Brush.Solid = true;
            this.spectrumChart1.Zoom.Brush.Visible = false;
            this.spectrumChart1.Zoom.FullRepaint = true;
            this.spectrumChart1.Zoom.History = true;
            // 
            // 
            // 
            this.spectrumChart1.Zoom.Pen.Visible = true;
            // 
            // editor1
            // 
            this.editor1.AlwaysShowFuncSrc = false;
            this.editor1.Chart = this.spectrumChart1;
            this.editor1.HighLightTabs = false;
            this.editor1.Location = new System.Drawing.Point(0, 0);
            this.editor1.Name = "editor1";
            this.editor1.Options = null;
            this.editor1.TabIndex = 0;
            // 
            // spectrumAnalyzerDialog1
            // 
            this.spectrumAnalyzerDialog1.BlockAssign = false;
            this.spectrumAnalyzerDialog1.Docking = false;
            this.spectrumAnalyzerDialog1.FormCaption = null;
            this.spectrumAnalyzerDialog1.Name = null;
            this.spectrumAnalyzerDialog1.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.spectrumAnalyzerDialog1.ShowLive = false;
            this.spectrumAnalyzerDialog1.Source = this.spectrumAnalyzer1;
            this.spectrumAnalyzerDialog1.SourceListIndex = 0;
            // 
            // ModulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 517);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "ModulatorForm";
            this.Text = "ModulatorForm";
            this.Load += new System.EventHandler(this.ModulatorForm_Load);
            this.Resize += new System.EventHandler(this.ModulatorForm_Resize);
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
		private Dew.Signal.Tee.SpectrumChart spectrumChart2;
		private System.Windows.Forms.Splitter splitter1;
		private Dew.Signal.Tee.SpectrumChart spectrumChart1;
		private Dew.Math.Controls.FloatEdit floatEdit2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label filterDelayLabel;
		private System.Windows.Forms.Label label2;
		private Dew.Math.Controls.FloatEdit floatEdit1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Styles.FastLine fastLine1;
		private Steema.TeeChart.Styles.FastLine fastLine2;
		private System.Windows.Forms.ComboBox attBox;
		private Dew.Signal.TSignalRead signalRead1;
		private Dew.Signal.TSignalModulator signalModulator1;
		private Dew.Signal.TSpectrumAnalyzer spectrumAnalyzer1;
		private Dew.Signal.TSpectrumAnalyzer spectrumAnalyzer2;
		private Steema.TeeChart.Editor editor1;
		private Dew.Signal.Editors.SpectrumAnalyzerDialog spectrumAnalyzerDialog1;
		private Dew.Signal.TSignalBuffer signalBuffer1;
	}
}