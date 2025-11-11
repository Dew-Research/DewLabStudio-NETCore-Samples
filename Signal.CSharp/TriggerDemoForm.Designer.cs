namespace DSPDemo {
	partial class TriggerDemoForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriggerDemoForm));
            Dew.Signal.Tee.SignalTeeItem signalTeeItem1 = new Dew.Signal.Tee.SignalTeeItem();
            Dew.Signal.Tee.SpectrumTeeItem spectrumTeeItem1 = new Dew.Signal.Tee.SpectrumTeeItem();
            this.Signal1 = new Dew.Signal.TSignal(this.components);
            this.fastLine2 = new Steema.TeeChart.Styles.FastLine();
            this.SpectrumAnalyzer1 = new Dew.Signal.TSpectrumAnalyzer(this.components);
            this.fastLine1 = new Steema.TeeChart.Styles.FastLine();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.countLabel = new System.Windows.Forms.Label();
            this.positionEdit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aboveEdit = new Dew.Math.Controls.FloatEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.channelBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.signalChart1 = new Dew.Signal.Tee.SignalChart();
            this.spectrumChart1 = new Dew.Signal.Tee.SpectrumChart();
            this.points1 = new Steema.TeeChart.Styles.Points();
            this.SignalIn1 = new Dew.Signal.Audio.SignalIn(this.components);
            this.SignalTimer1 = new Dew.Signal.Audio.SignalTimer(this.components);
            this.SpectrumAnalyzerDialog1 = new Dew.Signal.Editors.SpectrumAnalyzerDialog(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signalChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumChart1)).BeginInit();
            this.SuspendLayout();
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
            this.fastLine2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
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
            this.fastLine2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
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
            this.fastLine2.OriginalCursor = null;
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
            this.SpectrumAnalyzer1.LogBase = 0D;
            this.SpectrumAnalyzer1.LogScale = 0D;
            this.SpectrumAnalyzer1.Name = null;
            this.SpectrumAnalyzer1.Output = null;
            this.SpectrumAnalyzer1.Peaks.Interpolation.RecursiveHarmonics = Dew.Signal.TRecursiveHarmonics.rhNone;
            this.SpectrumAnalyzer1.Report.AmplitudeFormat = null;
            this.SpectrumAnalyzer1.Report.FrequencyFormat = null;
            this.SpectrumAnalyzer1.Report.PhaseFormat = null;
            this.SpectrumAnalyzer1.Report.UseTab = false;
            this.SpectrumAnalyzer1.SpectrumScale = 0D;
            this.SpectrumAnalyzer1.Window = Dew.Signal.TSignalWindowType.wtHanning;
            this.SpectrumAnalyzer1.OnParameterUpdateEvent += new Dew.Math.TNotifyEvent(this.SpectrumAnalyzer1_OnParameterUpdate);
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
            this.richTextBox1.Size = new System.Drawing.Size(881, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.countLabel);
            this.panel1.Controls.Add(this.positionEdit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.aboveEdit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.channelBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 465);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 55);
            this.panel1.TabIndex = 1;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(753, 22);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(38, 13);
            this.countLabel.TabIndex = 8;
            this.countLabel.Text = "Count:";
            // 
            // positionEdit
            // 
            this.positionEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionEdit.FormattingEnabled = true;
            this.positionEdit.Items.AddRange(new object[] {
            "After",
            "Before",
            "Center"});
            this.positionEdit.Location = new System.Drawing.Point(621, 21);
            this.positionEdit.Name = "positionEdit";
            this.positionEdit.Size = new System.Drawing.Size(121, 21);
            this.positionEdit.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Frame position";
            // 
            // aboveEdit
            // 
            this.aboveEdit.Increment = "10";
            this.aboveEdit.Location = new System.Drawing.Point(438, 22);
            this.aboveEdit.MaxValue = "33000";
            this.aboveEdit.MinValue = "-10000";
            this.aboveEdit.Name = "aboveEdit";
            this.aboveEdit.ReFormat = "0";
            this.aboveEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.aboveEdit.Scientific = false;
            this.aboveEdit.Size = new System.Drawing.Size(89, 20);
            this.aboveEdit.TabIndex = 5;
            this.aboveEdit.Value = "15000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trigger, if >=";
            // 
            // channelBox
            // 
            this.channelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.channelBox.FormattingEnabled = true;
            this.channelBox.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.channelBox.Location = new System.Drawing.Point(232, 21);
            this.channelBox.Name = "channelBox";
            this.channelBox.Size = new System.Drawing.Size(121, 21);
            this.channelBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ch:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reset trigger";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Spectrum...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.signalChart1);
            this.panel2.Controls.Add(this.spectrumChart1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 369);
            this.panel2.TabIndex = 2;
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 159);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(881, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // signalChart1
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
            this.signalChart1.Axes.Bottom.Grid.DrawEvery = 1;
            this.signalChart1.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Axes.Bottom.Labels.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Bottom.Labels.Font.Size = 9;
            this.signalChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Axes.Bottom.Title.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Title.Brush.Visible = true;
            this.signalChart1.Axes.Bottom.Title.Caption = "Time [s]";
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Bottom.Title.Font.Size = 11;
            this.signalChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            this.signalChart1.Axes.Bottom.Title.Lines = new string[] {
        "Time [s]"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Axes.Depth.Labels.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Depth.Labels.Font.Size = 9;
            this.signalChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Axes.Depth.Title.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart1.Axes.Depth.Title.Font.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Depth.Title.Font.Size = 11;
            this.signalChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Axes.DepthTop.Labels.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.DepthTop.Labels.Font.Size = 9;
            this.signalChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Axes.DepthTop.Title.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.DepthTop.Title.Font.Size = 11;
            this.signalChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Grid.DrawEvery = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Axes.Left.Labels.Brush.Solid = true;
            this.signalChart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart1.Axes.Left.Labels.Font.Brush.Solid = true;
            this.signalChart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Left.Labels.Font.Size = 9;
            this.signalChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Axes.Left.Title.Brush.Solid = true;
            this.signalChart1.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart1.Axes.Left.Title.Font.Brush.Solid = true;
            this.signalChart1.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Left.Title.Font.Size = 11;
            this.signalChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Axes.Right.Labels.Brush.Solid = true;
            this.signalChart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart1.Axes.Right.Labels.Font.Brush.Solid = true;
            this.signalChart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Right.Labels.Font.Size = 9;
            this.signalChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Axes.Right.Title.Brush.Solid = true;
            this.signalChart1.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart1.Axes.Right.Title.Font.Brush.Solid = true;
            this.signalChart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Right.Title.Font.Size = 11;
            this.signalChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Axes.Top.Labels.Brush.Solid = true;
            this.signalChart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart1.Axes.Top.Labels.Font.Brush.Solid = true;
            this.signalChart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Top.Labels.Font.Size = 9;
            this.signalChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Axes.Top.Title.Brush.Solid = true;
            this.signalChart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart1.Axes.Top.Title.Font.Brush.Solid = true;
            this.signalChart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Axes.Top.Title.Font.Size = 11;
            this.signalChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.signalChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.signalChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.signalChart1.Color = System.Drawing.Color.White;
             
            this.signalChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Footer.Brush.Solid = true;
            this.signalChart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.signalChart1.Footer.Font.Brush.Solid = true;
            this.signalChart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Footer.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Footer.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Footer.Font.Size = 8;
            this.signalChart1.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Footer.ImageBevel.Brush.Solid = true;
            this.signalChart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Footer.Shadow.Brush.Solid = true;
            this.signalChart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.signalChart1.Header.Brush.Solid = true;
            this.signalChart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Header.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart1.Header.Font.Brush.Solid = true;
            this.signalChart1.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Header.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Header.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Header.Font.Size = 12;
            this.signalChart1.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Header.ImageBevel.Brush.Solid = true;
            this.signalChart1.Header.ImageBevel.Brush.Visible = true;
            this.signalChart1.Header.Lines = new string[] {
        "Time signal just after the sample, which triggered"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signalChart1.Header.Shadow.Brush.Solid = true;
            this.signalChart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Legend.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Legend.Brush.Solid = true;
            this.signalChart1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart1.Legend.Font.Brush.Solid = true;
            this.signalChart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Legend.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Legend.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Legend.Font.Size = 9;
            this.signalChart1.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Legend.ImageBevel.Brush.Solid = true;
            this.signalChart1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signalChart1.Legend.Shadow.Brush.Solid = true;
            this.signalChart1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Legend.Symbol.Shadow.Brush.Solid = true;
            this.signalChart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Legend.Title.Brush.Solid = true;
            this.signalChart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.signalChart1.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.signalChart1.Legend.Title.Font.Brush.Solid = true;
            this.signalChart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart1.Legend.Title.Font.Size = 8;
            this.signalChart1.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Legend.Title.ImageBevel.Brush.Solid = true;
            this.signalChart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Legend.Title.Shadow.Brush.Solid = true;
            this.signalChart1.Legend.Title.Shadow.Brush.Visible = true;
            this.signalChart1.Legend.Visible = false;
            this.signalChart1.Location = new System.Drawing.Point(0, 159);
            this.signalChart1.Name = "signalChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Panel.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Panel.Brush.Solid = true;
            this.signalChart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Panel.ImageBevel.Brush.Solid = true;
            this.signalChart1.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Panel.Shadow.Brush.Solid = true;
            this.signalChart1.Panel.Shadow.Brush.Visible = true;
            this.signalChart1.Series.Add(this.fastLine2);
            signalTeeItem1.Caption = null;
            signalTeeItem1.Input = this.Signal1;
            signalTeeItem1.Inputs = null;
            signalTeeItem1.InputsItemIndex = 0;
            signalTeeItem1.Series = this.fastLine2;
            signalTeeItem1.SeriesName = "fastLine1";
            this.signalChart1.Signals.Add(signalTeeItem1);
            this.signalChart1.Size = new System.Drawing.Size(881, 210);
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.SubFooter.Brush.Solid = true;
            this.signalChart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.signalChart1.SubFooter.Font.Brush.Solid = true;
            this.signalChart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.SubFooter.Font.Shadow.Brush.Solid = true;
            this.signalChart1.SubFooter.Font.Shadow.Brush.Visible = true;
            this.signalChart1.SubFooter.Font.Size = 8;
            this.signalChart1.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.SubFooter.ImageBevel.Brush.Solid = true;
            this.signalChart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.SubFooter.Shadow.Brush.Solid = true;
            this.signalChart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.signalChart1.SubHeader.Brush.Solid = true;
            this.signalChart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart1.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart1.SubHeader.Font.Brush.Solid = true;
            this.signalChart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.SubHeader.Font.Shadow.Brush.Solid = true;
            this.signalChart1.SubHeader.Font.Shadow.Brush.Visible = true;
            this.signalChart1.SubHeader.Font.Size = 12;
            this.signalChart1.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.SubHeader.ImageBevel.Brush.Solid = true;
            this.signalChart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signalChart1.SubHeader.Shadow.Brush.Solid = true;
            this.signalChart1.SubHeader.Shadow.Brush.Visible = true;
            this.signalChart1.TabIndex = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart1.Walls.Back.Brush.Solid = true;
            this.signalChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Walls.Back.ImageBevel.Brush.Solid = true;
            this.signalChart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Walls.Back.Shadow.Brush.Solid = true;
            this.signalChart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.signalChart1.Walls.Bottom.Brush.Solid = true;
            this.signalChart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.signalChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Walls.Bottom.Shadow.Brush.Solid = true;
            this.signalChart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.signalChart1.Walls.Left.Brush.Solid = true;
            this.signalChart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Walls.Left.ImageBevel.Brush.Solid = true;
            this.signalChart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Walls.Left.Shadow.Brush.Solid = true;
            this.signalChart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart1.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.signalChart1.Walls.Right.Brush.Solid = true;
            this.signalChart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart1.Walls.Right.ImageBevel.Brush.Solid = true;
            this.signalChart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Walls.Right.Shadow.Brush.Solid = true;
            this.signalChart1.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.signalChart1.Zoom.Brush.Solid = true;
            this.signalChart1.Zoom.Brush.Visible = false;
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
            this.spectrumChart1.Axes.Right.AxisPen.Visible = true;
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
            this.spectrumChart1.Size = new System.Drawing.Size(881, 159);
            this.spectrumChart1.SpectrumPart = Dew.Signal.Tee.SpectrumPart.sppAmplt;
            spectrumTeeItem1.Caption = null;
            spectrumTeeItem1.Input = this.SpectrumAnalyzer1;
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
            this.points1.Pointer.Dark3D = false;
            this.points1.Pointer.Draw3D = false;
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
            this.SignalIn1.BufferSize = 16000;
            this.SignalIn1.CalibrationTarget = 0;
            this.SignalIn1.ChannelCount = 2;
            this.SignalIn1.Complex = false;
            this.SignalIn1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.SignalIn1.FloatPrecisionLock = false;
            this.SignalIn1.Input = null;
            this.SignalIn1.IsDouble = true;
            this.SignalIn1.Name = null;
            this.SignalIn1.NumBuffers = 10;
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
            // TriggerDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "TriggerDemoForm";
            this.Text = "TriggerDemoForm";
            this.Load += new System.EventHandler(this.TriggerDemoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.signalChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumChart1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private Dew.Signal.TSignal Signal1;
		private Dew.Signal.TSpectrumAnalyzer SpectrumAnalyzer1;
		private Dew.Signal.Audio.SignalIn SignalIn1;
		private Dew.Signal.Audio.SignalTimer SignalTimer1;
		private Dew.Signal.Editors.SpectrumAnalyzerDialog SpectrumAnalyzerDialog1;
		private Dew.Signal.Tee.SpectrumChart spectrumChart1;
		private System.Windows.Forms.Splitter splitter1;
		private Dew.Signal.Tee.SignalChart signalChart1;
		private Dew.Math.Controls.FloatEdit aboveEdit;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox channelBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Styles.FastLine fastLine1;
		private System.Windows.Forms.Label countLabel;
		private System.Windows.Forms.ComboBox positionEdit;
		private System.Windows.Forms.Label label3;
		private Steema.TeeChart.Styles.FastLine fastLine2;
		private Steema.TeeChart.Styles.Points points1;
	}
}