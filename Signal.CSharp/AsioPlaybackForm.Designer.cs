namespace DSPDemo
{
	partial class AsioPlaybackForm
	{
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

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsioPlaybackForm));
            Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
            Dew.Signal.Tee.SignalTeeItem signalTeeItem1 = new Dew.Signal.Tee.SignalTeeItem();
            Steema.TeeChart.Margins margins2 = new Steema.TeeChart.Margins();
            Dew.Signal.Tee.SignalTeeItem signalTeeItem2 = new Dew.Signal.Tee.SignalTeeItem();
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            signalList = new Dew.Signal.TSignalList(components);
            signalDemuxList = new Dew.Signal.TSignalDemuxList(components);
            signalRead = new Dew.Signal.TSignalRead(components);
            signalRateConverterList = new Dew.Signal.TSignalRateConverterList(components);
            splitter1 = new System.Windows.Forms.Splitter();
            panel1 = new System.Windows.Forms.Panel();
            volumeTrackBar = new System.Windows.Forms.TrackBar();
            statusLabel = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            startButton = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            clockSourcesBox = new System.Windows.Forms.ListBox();
            outputChBox = new System.Windows.Forms.ListBox();
            FSListBox = new System.Windows.Forms.ListBox();
            driverNameListBox = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            signalAsio1 = new Dew.Signal.Audio.SignalAsio(components);
            bottomChart = new Dew.Signal.Tee.SignalChart();
            axisScaleTool2 = new Dew.Signal.Tee.AxisScaleTool();
            topChart = new Dew.Signal.Tee.SignalChart();
            axisScaleTool1 = new Dew.Signal.Tee.AxisScaleTool();
            mtxFastLine1 = new Dew.Math.Tee.MtxFastLine();
            mtxFastLine2 = new Dew.Math.Tee.MtxFastLine();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)volumeTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bottomChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)topChart).BeginInit();
            SuspendLayout();
            // 
            // signalList
            // 
            signalList.Count = 2;
            signalList.EditIndex = -1;
            signalList.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            signalList.FloatPrecisionLock = false;
            signalList.PropagateTemplate = false;
            // 
            // signalDemuxList
            // 
            signalDemuxList.Count = 2;
            signalDemuxList.EditIndex = -1;
            signalDemuxList.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            signalDemuxList.FloatPrecisionLock = false;
            signalDemuxList.Input = signalRead;
            signalDemuxList.Inputs = null;
            signalDemuxList.PropagateTemplate = false;
            // 
            // signalRead
            // 
            signalRead.ChannelCount = 1;
            signalRead.Complex = false;
            signalRead.DataSerialization = resources.GetString("signalRead.DataSerialization");
            signalRead.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            signalRead.FloatPrecisionLock = false;
            signalRead.FramesPerSecond = 0.0009765625D;
            signalRead.IsDouble = true;
            signalRead.Length = 1024;
            signalRead.OverlappingSamples = 0;
            signalRead.PostBufferSamples = 0;
            signalRead.RecordNumber = 0;
            // 
            // signalRateConverterList
            // 
            signalRateConverterList.Count = 2;
            signalRateConverterList.EditIndex = -1;
            signalRateConverterList.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            signalRateConverterList.FloatPrecisionLock = false;
            signalRateConverterList.Inputs = signalDemuxList;
            signalRateConverterList.PropagateTemplate = false;
            signalRateConverterList.OnBeforeUpdateEvent += signalRateConverterList_OnBeforeUpdate;
            // 
            // splitter1
            // 
            splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            splitter1.Location = new System.Drawing.Point(0, 213);
            splitter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new System.Drawing.Size(1185, 3);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(volumeTrackBar);
            panel1.Controls.Add(statusLabel);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(startButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(clockSourcesBox);
            panel1.Controls.Add(outputChBox);
            panel1.Controls.Add(FSListBox);
            panel1.Controls.Add(driverNameListBox);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 480);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1185, 250);
            panel1.TabIndex = 2;
            // 
            // volumeTrackBar
            // 
            volumeTrackBar.Location = new System.Drawing.Point(464, 164);
            volumeTrackBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            volumeTrackBar.Name = "volumeTrackBar";
            volumeTrackBar.Size = new System.Drawing.Size(175, 45);
            volumeTrackBar.TabIndex = 5;
            volumeTrackBar.Value = 10;
            volumeTrackBar.Scroll += volumeTrackBar_Scroll;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(14, 225);
            statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(42, 15);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "Status:";
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(206, 164);
            button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(103, 27);
            button3.TabIndex = 3;
            button3.Text = "Control panel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(112, 164);
            button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(88, 27);
            button2.TabIndex = 3;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // startButton
            // 
            startButton.Location = new System.Drawing.Point(18, 164);
            startButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            startButton.Name = "startButton";
            startButton.Size = new System.Drawing.Size(88, 27);
            startButton.TabIndex = 3;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(643, 14);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(83, 15);
            label4.TabIndex = 2;
            label4.Text = "Clock sources:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(461, 14);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(98, 15);
            label3.TabIndex = 2;
            label3.Text = "Output channels:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(196, 14);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(105, 15);
            label2.TabIndex = 2;
            label2.Text = "Supported FS [Hz]:";
            // 
            // clockSourcesBox
            // 
            clockSourcesBox.FormattingEnabled = true;
            clockSourcesBox.Location = new System.Drawing.Point(646, 32);
            clockSourcesBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            clockSourcesBox.Name = "clockSourcesBox";
            clockSourcesBox.Size = new System.Drawing.Size(174, 124);
            clockSourcesBox.TabIndex = 1;
            // 
            // outputChBox
            // 
            outputChBox.FormattingEnabled = true;
            outputChBox.Location = new System.Drawing.Point(464, 32);
            outputChBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            outputChBox.Name = "outputChBox";
            outputChBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            outputChBox.Size = new System.Drawing.Size(174, 124);
            outputChBox.TabIndex = 1;
            // 
            // FSListBox
            // 
            FSListBox.FormattingEnabled = true;
            FSListBox.Location = new System.Drawing.Point(200, 32);
            FSListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            FSListBox.Name = "FSListBox";
            FSListBox.Size = new System.Drawing.Size(174, 124);
            FSListBox.TabIndex = 1;
            // 
            // driverNameListBox
            // 
            driverNameListBox.FormattingEnabled = true;
            driverNameListBox.Location = new System.Drawing.Point(18, 32);
            driverNameListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            driverNameListBox.Name = "driverNameListBox";
            driverNameListBox.Size = new System.Drawing.Size(174, 124);
            driverNameListBox.TabIndex = 1;
            driverNameListBox.SelectedIndexChanged += driverNameListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 14);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Drivers:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Uncompressed WAV files.|*.wav";
            openFileDialog1.Title = "Select uncompressed wav file";
            // 
            // signalAsio1
            // 
            signalAsio1.Active = false;
            signalAsio1.Continuous = false;
            signalAsio1.Count = 0;
            signalAsio1.EditIndex = -1;
            signalAsio1.ExtendedBufferTime = 500;
            signalAsio1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            signalAsio1.FloatPrecisionLock = false;
            signalAsio1.InputPrecision = Dew.Math.TPrecision.prDouble;
            signalAsio1.Inputs = signalRateConverterList;
            signalAsio1.OutputPrecision = Dew.Math.TPrecision.prSmallInt;
            signalAsio1.PropagateTemplate = false;
            signalAsio1.SamplingFrequency = 48000D;
            signalAsio1.ProcessRealTime += signalAsio1_ProcessRealTime;
            // 
            // bottomChart
            // 
            // 
            // 
            // 
            bottomChart.Axes.Automatic = false;
            // 
            // 
            // 
            bottomChart.Axes.Bottom.Automatic = false;
            bottomChart.Axes.Bottom.AutomaticMaximum = false;
            bottomChart.Axes.Bottom.AutomaticMinimum = false;
            // 
            // 
            // 
            bottomChart.Axes.Bottom.Grid.DrawEvery = 1;
            bottomChart.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            bottomChart.Axes.Bottom.Labels.Brush.Solid = true;
            bottomChart.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            bottomChart.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            bottomChart.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            bottomChart.Axes.Bottom.Labels.Font.Brush.Solid = true;
            bottomChart.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            bottomChart.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            bottomChart.Axes.Bottom.Labels.Font.Size = 9;
            bottomChart.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            bottomChart.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            bottomChart.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            bottomChart.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            bottomChart.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            bottomChart.Axes.Bottom.Maximum = 0D;
            bottomChart.Axes.Bottom.MaximumOffset = 1;
            bottomChart.Axes.Bottom.Minimum = 0D;
            bottomChart.Axes.Bottom.MinimumOffset = 1;
            // 
            // 
            // 
            bottomChart.Axes.Bottom.MinorTicks.Color = System.Drawing.Color.FromArgb(255, 0, 0);
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            bottomChart.Axes.Bottom.Title.Brush.Solid = true;
            bottomChart.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            bottomChart.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            bottomChart.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            bottomChart.Axes.Bottom.Title.Font.Brush.Solid = true;
            bottomChart.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            bottomChart.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            bottomChart.Axes.Bottom.Title.Font.Size = 11;
            bottomChart.Axes.Bottom.Title.Font.SizeFloat = 11F;
            bottomChart.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            bottomChart.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            bottomChart.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            bottomChart.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            bottomChart.Axes.Depth.Automatic = false;
            bottomChart.Axes.Depth.AutomaticMaximum = false;
            bottomChart.Axes.Depth.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            bottomChart.Axes.Depth.Labels.Brush.Solid = true;
            bottomChart.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            bottomChart.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            bottomChart.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            bottomChart.Axes.Depth.Labels.Font.Brush.Solid = true;
            bottomChart.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            bottomChart.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            bottomChart.Axes.Depth.Labels.Font.Size = 9;
            bottomChart.Axes.Depth.Labels.Font.SizeFloat = 9F;
            bottomChart.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            bottomChart.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            bottomChart.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            bottomChart.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            bottomChart.Axes.Depth.Maximum = 0D;
            bottomChart.Axes.Depth.Minimum = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            bottomChart.Axes.Depth.Title.Brush.Solid = true;
            bottomChart.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            bottomChart.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            bottomChart.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            bottomChart.Axes.Depth.Title.Font.Brush.Solid = true;
            bottomChart.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            bottomChart.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            bottomChart.Axes.Depth.Title.Font.Size = 11;
            bottomChart.Axes.Depth.Title.Font.SizeFloat = 11F;
            bottomChart.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            bottomChart.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            bottomChart.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Axes.Depth.Title.Shadow.Brush.Solid = true;
            bottomChart.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            bottomChart.Axes.DepthTop.Automatic = false;
            bottomChart.Axes.DepthTop.AutomaticMaximum = false;
            bottomChart.Axes.DepthTop.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            bottomChart.Axes.DepthTop.Labels.Brush.Solid = true;
            bottomChart.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            bottomChart.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            bottomChart.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            bottomChart.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            bottomChart.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            bottomChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            bottomChart.Axes.DepthTop.Labels.Font.Size = 9;
            bottomChart.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            bottomChart.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            bottomChart.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            bottomChart.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            bottomChart.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            bottomChart.Axes.DepthTop.Maximum = 0D;
            bottomChart.Axes.DepthTop.Minimum = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            bottomChart.Axes.DepthTop.Title.Brush.Solid = true;
            bottomChart.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            bottomChart.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            bottomChart.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            bottomChart.Axes.DepthTop.Title.Font.Brush.Solid = true;
            bottomChart.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            bottomChart.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            bottomChart.Axes.DepthTop.Title.Font.Size = 11;
            bottomChart.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            bottomChart.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            bottomChart.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            bottomChart.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            bottomChart.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            bottomChart.Axes.Left.Automatic = false;
            bottomChart.Axes.Left.AutomaticMaximum = false;
            bottomChart.Axes.Left.AutomaticMinimum = false;
            // 
            // 
            // 
            bottomChart.Axes.Left.AxisPen.Visible = true;
            bottomChart.Axes.Left.AxisPen.Width = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            bottomChart.Axes.Left.Labels.Brush.Solid = true;
            bottomChart.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            bottomChart.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            bottomChart.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            bottomChart.Axes.Left.Labels.Font.Brush.Solid = true;
            bottomChart.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            bottomChart.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            bottomChart.Axes.Left.Labels.Font.Size = 9;
            bottomChart.Axes.Left.Labels.Font.SizeFloat = 9F;
            bottomChart.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            bottomChart.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            bottomChart.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Axes.Left.Labels.Shadow.Brush.Solid = true;
            bottomChart.Axes.Left.Labels.Shadow.Brush.Visible = true;
            bottomChart.Axes.Left.Maximum = 469D;
            bottomChart.Axes.Left.MaximumOffset = 1;
            bottomChart.Axes.Left.Minimum = -0.1D;
            bottomChart.Axes.Left.MinimumOffset = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            bottomChart.Axes.Left.Title.Brush.Solid = true;
            bottomChart.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            bottomChart.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            bottomChart.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            bottomChart.Axes.Left.Title.Font.Brush.Solid = true;
            bottomChart.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            bottomChart.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            bottomChart.Axes.Left.Title.Font.Size = 11;
            bottomChart.Axes.Left.Title.Font.SizeFloat = 11F;
            bottomChart.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            bottomChart.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            bottomChart.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Axes.Left.Title.Shadow.Brush.Solid = true;
            bottomChart.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            bottomChart.Axes.Right.Automatic = false;
            bottomChart.Axes.Right.AutomaticMaximum = false;
            bottomChart.Axes.Right.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            bottomChart.Axes.Right.Labels.Brush.Solid = true;
            bottomChart.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            bottomChart.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            bottomChart.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            bottomChart.Axes.Right.Labels.Font.Brush.Solid = true;
            bottomChart.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            bottomChart.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            bottomChart.Axes.Right.Labels.Font.Size = 9;
            bottomChart.Axes.Right.Labels.Font.SizeFloat = 9F;
            bottomChart.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            bottomChart.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            bottomChart.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Axes.Right.Labels.Shadow.Brush.Solid = true;
            bottomChart.Axes.Right.Labels.Shadow.Brush.Visible = true;
            bottomChart.Axes.Right.Maximum = 0D;
            bottomChart.Axes.Right.Minimum = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            bottomChart.Axes.Right.Title.Brush.Solid = true;
            bottomChart.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            bottomChart.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            bottomChart.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            bottomChart.Axes.Right.Title.Font.Brush.Solid = true;
            bottomChart.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            bottomChart.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            bottomChart.Axes.Right.Title.Font.Size = 11;
            bottomChart.Axes.Right.Title.Font.SizeFloat = 11F;
            bottomChart.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            bottomChart.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            bottomChart.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Axes.Right.Title.Shadow.Brush.Solid = true;
            bottomChart.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            bottomChart.Axes.Top.Automatic = false;
            bottomChart.Axes.Top.AutomaticMaximum = false;
            bottomChart.Axes.Top.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            bottomChart.Axes.Top.Labels.Brush.Solid = true;
            bottomChart.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            bottomChart.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            bottomChart.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            bottomChart.Axes.Top.Labels.Font.Brush.Solid = true;
            bottomChart.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            bottomChart.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            bottomChart.Axes.Top.Labels.Font.Size = 9;
            bottomChart.Axes.Top.Labels.Font.SizeFloat = 9F;
            bottomChart.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            bottomChart.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            bottomChart.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Axes.Top.Labels.Shadow.Brush.Solid = true;
            bottomChart.Axes.Top.Labels.Shadow.Brush.Visible = true;
            bottomChart.Axes.Top.Maximum = 0D;
            bottomChart.Axes.Top.Minimum = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            bottomChart.Axes.Top.Title.Brush.Solid = true;
            bottomChart.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            bottomChart.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            bottomChart.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            bottomChart.Axes.Top.Title.Font.Brush.Solid = true;
            bottomChart.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            bottomChart.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            bottomChart.Axes.Top.Title.Font.Size = 11;
            bottomChart.Axes.Top.Title.Font.SizeFloat = 11F;
            bottomChart.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            bottomChart.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            bottomChart.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Axes.Top.Title.Shadow.Brush.Solid = true;
            bottomChart.Axes.Top.Title.Shadow.Brush.Visible = true;
            bottomChart.Color = System.Drawing.Color.White;
            bottomChart.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Footer.Brush.Color = System.Drawing.Color.Silver;
            bottomChart.Footer.Brush.Solid = true;
            bottomChart.Footer.Brush.Visible = true;
            // 
            // 
            // 
            bottomChart.Footer.Font.Bold = false;
            // 
            // 
            // 
            bottomChart.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            bottomChart.Footer.Font.Brush.Solid = true;
            bottomChart.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Footer.Font.Shadow.Brush.Solid = true;
            bottomChart.Footer.Font.Shadow.Brush.Visible = true;
            bottomChart.Footer.Font.Size = 8;
            bottomChart.Footer.Font.SizeFloat = 8F;
            bottomChart.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            bottomChart.Footer.ImageBevel.Brush.Solid = true;
            bottomChart.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Footer.Shadow.Brush.Solid = true;
            bottomChart.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Header.Brush.Color = System.Drawing.Color.FromArgb(192, 192, 192);
            bottomChart.Header.Brush.Solid = true;
            bottomChart.Header.Brush.Visible = true;
            // 
            // 
            // 
            bottomChart.Header.Font.Bold = false;
            // 
            // 
            // 
            bottomChart.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            bottomChart.Header.Font.Brush.Solid = true;
            bottomChart.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Header.Font.Shadow.Brush.Solid = true;
            bottomChart.Header.Font.Shadow.Brush.Visible = true;
            bottomChart.Header.Font.Size = 12;
            bottomChart.Header.Font.SizeFloat = 12F;
            bottomChart.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            bottomChart.Header.ImageBevel.Brush.Solid = true;
            bottomChart.Header.ImageBevel.Brush.Visible = true;
            bottomChart.Header.Lines = new string[]
    {
    "Channel 1"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(169, 169, 169);
            bottomChart.Header.Shadow.Brush.Solid = true;
            bottomChart.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Legend.Brush.Color = System.Drawing.Color.White;
            bottomChart.Legend.Brush.Solid = true;
            bottomChart.Legend.Brush.Visible = true;
            bottomChart.Legend.CheckBoxes = false;
            // 
            // 
            // 
            bottomChart.Legend.Font.Bold = false;
            // 
            // 
            // 
            bottomChart.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            bottomChart.Legend.Font.Brush.Solid = true;
            bottomChart.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Legend.Font.Shadow.Brush.Solid = true;
            bottomChart.Legend.Font.Shadow.Brush.Visible = true;
            bottomChart.Legend.Font.Size = 9;
            bottomChart.Legend.Font.SizeFloat = 9F;
            bottomChart.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            bottomChart.Legend.ImageBevel.Brush.Solid = true;
            bottomChart.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(0, 0, 0);
            bottomChart.Legend.Shadow.Brush.Solid = true;
            bottomChart.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Legend.Symbol.Shadow.Brush.Solid = true;
            bottomChart.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Legend.Title.Brush.Color = System.Drawing.Color.White;
            bottomChart.Legend.Title.Brush.Solid = true;
            bottomChart.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            bottomChart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            bottomChart.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            bottomChart.Legend.Title.Font.Brush.Solid = true;
            bottomChart.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Legend.Title.Font.Shadow.Brush.Solid = true;
            bottomChart.Legend.Title.Font.Shadow.Brush.Visible = true;
            bottomChart.Legend.Title.Font.Size = 8;
            bottomChart.Legend.Title.Font.SizeFloat = 8F;
            bottomChart.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            bottomChart.Legend.Title.ImageBevel.Brush.Solid = true;
            bottomChart.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Legend.Title.Shadow.Brush.Solid = true;
            bottomChart.Legend.Title.Shadow.Brush.Visible = true;
            bottomChart.Legend.Visible = false;
            bottomChart.Location = new System.Drawing.Point(0, 216);
            bottomChart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bottomChart.Name = "bottomChart";
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Panel.Brush.Color = System.Drawing.Color.White;
            bottomChart.Panel.Brush.Solid = true;
            bottomChart.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            bottomChart.Panel.ImageBevel.Brush.Solid = true;
            bottomChart.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Panel.Shadow.Brush.Solid = true;
            bottomChart.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            bottomChart.Printer.Margins = margins1;
            bottomChart.Series.Add(mtxFastLine2);
            signalTeeItem1.Caption = null;
            signalTeeItem1.Input = null;
            signalTeeItem1.Inputs = signalList;
            signalTeeItem1.InputsItemIndex = 1;
            signalTeeItem1.Series = null;
            signalTeeItem1.SeriesName = "mtxFastLine2";
            bottomChart.Signals.Add(signalTeeItem1);
            bottomChart.Size = new System.Drawing.Size(1185, 264);
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            bottomChart.SubFooter.Brush.Solid = true;
            bottomChart.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            bottomChart.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            bottomChart.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            bottomChart.SubFooter.Font.Brush.Solid = true;
            bottomChart.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.SubFooter.Font.Shadow.Brush.Solid = true;
            bottomChart.SubFooter.Font.Shadow.Brush.Visible = true;
            bottomChart.SubFooter.Font.Size = 8;
            bottomChart.SubFooter.Font.SizeFloat = 8F;
            bottomChart.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            bottomChart.SubFooter.ImageBevel.Brush.Solid = true;
            bottomChart.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.SubFooter.Shadow.Brush.Solid = true;
            bottomChart.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(192, 192, 192);
            bottomChart.SubHeader.Brush.Solid = true;
            bottomChart.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            bottomChart.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            bottomChart.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            bottomChart.SubHeader.Font.Brush.Solid = true;
            bottomChart.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.SubHeader.Font.Shadow.Brush.Solid = true;
            bottomChart.SubHeader.Font.Shadow.Brush.Visible = true;
            bottomChart.SubHeader.Font.Size = 12;
            bottomChart.SubHeader.Font.SizeFloat = 12F;
            bottomChart.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            bottomChart.SubHeader.ImageBevel.Brush.Solid = true;
            bottomChart.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(169, 169, 169);
            bottomChart.SubHeader.Shadow.Brush.Solid = true;
            bottomChart.SubHeader.Shadow.Brush.Visible = true;
            bottomChart.TabIndex = 3;
            bottomChart.Tools.Add(axisScaleTool2);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            bottomChart.Walls.Back.Brush.Solid = true;
            bottomChart.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            bottomChart.Walls.Back.ImageBevel.Brush.Solid = true;
            bottomChart.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Walls.Back.Shadow.Brush.Solid = true;
            bottomChart.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            bottomChart.Walls.Bottom.Brush.Solid = true;
            bottomChart.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            bottomChart.Walls.Bottom.ImageBevel.Brush.Solid = true;
            bottomChart.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Walls.Bottom.Shadow.Brush.Solid = true;
            bottomChart.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            bottomChart.Walls.Left.Brush.Solid = true;
            bottomChart.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            bottomChart.Walls.Left.ImageBevel.Brush.Solid = true;
            bottomChart.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Walls.Left.Shadow.Brush.Solid = true;
            bottomChart.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            bottomChart.Walls.Right.Brush.Solid = true;
            bottomChart.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            bottomChart.Walls.Right.ImageBevel.Brush.Solid = true;
            bottomChart.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bottomChart.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            bottomChart.Walls.Right.Shadow.Brush.Solid = true;
            bottomChart.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            bottomChart.Zoom.Animated = true;
            // 
            // 
            // 
            bottomChart.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            bottomChart.Zoom.Brush.Solid = true;
            bottomChart.Zoom.Brush.Visible = false;
            bottomChart.Click += bottomChart_Click;
            // 
            // axisScaleTool2
            // 
            axisScaleTool2.Axis = bottomChart.Axes.Left;
            axisScaleTool2.AxisIndex = -1;
            axisScaleTool2.AxisScaleMode = Dew.Signal.Tee.AxisScaleMode.amPeakHold;
            axisScaleTool2.DataIsSpectrum = false;
            axisScaleTool2.LowerMargin = 10;
            axisScaleTool2.UpperMargin = 10;
            // 
            // topChart
            // 
            // 
            // 
            // 
            topChart.Axes.Automatic = false;
            // 
            // 
            // 
            topChart.Axes.Bottom.Automatic = false;
            topChart.Axes.Bottom.AutomaticMaximum = false;
            topChart.Axes.Bottom.AutomaticMinimum = false;
            // 
            // 
            // 
            topChart.Axes.Bottom.Grid.DrawEvery = 1;
            topChart.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            topChart.Axes.Bottom.Labels.Brush.Solid = true;
            topChart.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            topChart.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            topChart.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            topChart.Axes.Bottom.Labels.Font.Brush.Solid = true;
            topChart.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            topChart.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            topChart.Axes.Bottom.Labels.Font.Size = 9;
            topChart.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            topChart.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            topChart.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            topChart.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            topChart.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            topChart.Axes.Bottom.Maximum = 0D;
            topChart.Axes.Bottom.MaximumOffset = 1;
            topChart.Axes.Bottom.Minimum = 0D;
            topChart.Axes.Bottom.MinimumOffset = 1;
            // 
            // 
            // 
            topChart.Axes.Bottom.MinorTicks.Color = System.Drawing.Color.FromArgb(0, 128, 0);
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            topChart.Axes.Bottom.Title.Brush.Solid = true;
            topChart.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            topChart.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            topChart.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            topChart.Axes.Bottom.Title.Font.Brush.Solid = true;
            topChart.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            topChart.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            topChart.Axes.Bottom.Title.Font.Size = 11;
            topChart.Axes.Bottom.Title.Font.SizeFloat = 11F;
            topChart.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            topChart.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            topChart.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            topChart.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            topChart.Axes.Depth.Automatic = false;
            topChart.Axes.Depth.AutomaticMaximum = false;
            topChart.Axes.Depth.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            topChart.Axes.Depth.Labels.Brush.Solid = true;
            topChart.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            topChart.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            topChart.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            topChart.Axes.Depth.Labels.Font.Brush.Solid = true;
            topChart.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            topChart.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            topChart.Axes.Depth.Labels.Font.Size = 9;
            topChart.Axes.Depth.Labels.Font.SizeFloat = 9F;
            topChart.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            topChart.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            topChart.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            topChart.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            topChart.Axes.Depth.Maximum = 0D;
            topChart.Axes.Depth.Minimum = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            topChart.Axes.Depth.Title.Brush.Solid = true;
            topChart.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            topChart.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            topChart.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            topChart.Axes.Depth.Title.Font.Brush.Solid = true;
            topChart.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            topChart.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            topChart.Axes.Depth.Title.Font.Size = 11;
            topChart.Axes.Depth.Title.Font.SizeFloat = 11F;
            topChart.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            topChart.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            topChart.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Axes.Depth.Title.Shadow.Brush.Solid = true;
            topChart.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            topChart.Axes.DepthTop.Automatic = false;
            topChart.Axes.DepthTop.AutomaticMaximum = false;
            topChart.Axes.DepthTop.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            topChart.Axes.DepthTop.Labels.Brush.Solid = true;
            topChart.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            topChart.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            topChart.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            topChart.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            topChart.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            topChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            topChart.Axes.DepthTop.Labels.Font.Size = 9;
            topChart.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            topChart.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            topChart.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            topChart.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            topChart.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            topChart.Axes.DepthTop.Maximum = 0D;
            topChart.Axes.DepthTop.Minimum = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            topChart.Axes.DepthTop.Title.Brush.Solid = true;
            topChart.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            topChart.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            topChart.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            topChart.Axes.DepthTop.Title.Font.Brush.Solid = true;
            topChart.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            topChart.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            topChart.Axes.DepthTop.Title.Font.Size = 11;
            topChart.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            topChart.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            topChart.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            topChart.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            topChart.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            topChart.Axes.Left.Automatic = false;
            topChart.Axes.Left.AutomaticMaximum = false;
            topChart.Axes.Left.AutomaticMinimum = false;
            // 
            // 
            // 
            topChart.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            topChart.Axes.Left.Labels.Brush.Solid = true;
            topChart.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            topChart.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            topChart.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            topChart.Axes.Left.Labels.Font.Brush.Solid = true;
            topChart.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            topChart.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            topChart.Axes.Left.Labels.Font.Size = 9;
            topChart.Axes.Left.Labels.Font.SizeFloat = 9F;
            topChart.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            topChart.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            topChart.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Axes.Left.Labels.Shadow.Brush.Solid = true;
            topChart.Axes.Left.Labels.Shadow.Brush.Visible = true;
            topChart.Axes.Left.Maximum = 824.7D;
            topChart.Axes.Left.MaximumOffset = 1;
            topChart.Axes.Left.Minimum = -0.1D;
            topChart.Axes.Left.MinimumOffset = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            topChart.Axes.Left.Title.Brush.Solid = true;
            topChart.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            topChart.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            topChart.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            topChart.Axes.Left.Title.Font.Brush.Solid = true;
            topChart.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            topChart.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            topChart.Axes.Left.Title.Font.Size = 11;
            topChart.Axes.Left.Title.Font.SizeFloat = 11F;
            topChart.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            topChart.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            topChart.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Axes.Left.Title.Shadow.Brush.Solid = true;
            topChart.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            topChart.Axes.Right.Automatic = false;
            topChart.Axes.Right.AutomaticMaximum = false;
            topChart.Axes.Right.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            topChart.Axes.Right.Labels.Brush.Solid = true;
            topChart.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            topChart.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            topChart.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            topChart.Axes.Right.Labels.Font.Brush.Solid = true;
            topChart.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            topChart.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            topChart.Axes.Right.Labels.Font.Size = 9;
            topChart.Axes.Right.Labels.Font.SizeFloat = 9F;
            topChart.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            topChart.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            topChart.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Axes.Right.Labels.Shadow.Brush.Solid = true;
            topChart.Axes.Right.Labels.Shadow.Brush.Visible = true;
            topChart.Axes.Right.Maximum = 0D;
            topChart.Axes.Right.Minimum = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            topChart.Axes.Right.Title.Brush.Solid = true;
            topChart.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            topChart.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            topChart.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            topChart.Axes.Right.Title.Font.Brush.Solid = true;
            topChart.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            topChart.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            topChart.Axes.Right.Title.Font.Size = 11;
            topChart.Axes.Right.Title.Font.SizeFloat = 11F;
            topChart.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            topChart.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            topChart.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Axes.Right.Title.Shadow.Brush.Solid = true;
            topChart.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            topChart.Axes.Top.Automatic = false;
            topChart.Axes.Top.AutomaticMaximum = false;
            topChart.Axes.Top.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            topChart.Axes.Top.Labels.Brush.Solid = true;
            topChart.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            topChart.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            topChart.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            topChart.Axes.Top.Labels.Font.Brush.Solid = true;
            topChart.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            topChart.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            topChart.Axes.Top.Labels.Font.Size = 9;
            topChart.Axes.Top.Labels.Font.SizeFloat = 9F;
            topChart.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            topChart.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            topChart.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Axes.Top.Labels.Shadow.Brush.Solid = true;
            topChart.Axes.Top.Labels.Shadow.Brush.Visible = true;
            topChart.Axes.Top.Maximum = 0D;
            topChart.Axes.Top.Minimum = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            topChart.Axes.Top.Title.Brush.Solid = true;
            topChart.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            topChart.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            topChart.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            topChart.Axes.Top.Title.Font.Brush.Solid = true;
            topChart.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            topChart.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            topChart.Axes.Top.Title.Font.Size = 11;
            topChart.Axes.Top.Title.Font.SizeFloat = 11F;
            topChart.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            topChart.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            topChart.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Axes.Top.Title.Shadow.Brush.Solid = true;
            topChart.Axes.Top.Title.Shadow.Brush.Visible = true;
            topChart.Color = System.Drawing.Color.White;
            topChart.Dock = System.Windows.Forms.DockStyle.Top;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Footer.Brush.Color = System.Drawing.Color.Silver;
            topChart.Footer.Brush.Solid = true;
            topChart.Footer.Brush.Visible = true;
            // 
            // 
            // 
            topChart.Footer.Font.Bold = false;
            // 
            // 
            // 
            topChart.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            topChart.Footer.Font.Brush.Solid = true;
            topChart.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Footer.Font.Shadow.Brush.Solid = true;
            topChart.Footer.Font.Shadow.Brush.Visible = true;
            topChart.Footer.Font.Size = 8;
            topChart.Footer.Font.SizeFloat = 8F;
            topChart.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            topChart.Footer.ImageBevel.Brush.Solid = true;
            topChart.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Footer.Shadow.Brush.Solid = true;
            topChart.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Header.Brush.Color = System.Drawing.Color.FromArgb(192, 192, 192);
            topChart.Header.Brush.Solid = true;
            topChart.Header.Brush.Visible = true;
            // 
            // 
            // 
            topChart.Header.Font.Bold = false;
            // 
            // 
            // 
            topChart.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            topChart.Header.Font.Brush.Solid = true;
            topChart.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Header.Font.Shadow.Brush.Solid = true;
            topChart.Header.Font.Shadow.Brush.Visible = true;
            topChart.Header.Font.Size = 12;
            topChart.Header.Font.SizeFloat = 12F;
            topChart.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            topChart.Header.ImageBevel.Brush.Solid = true;
            topChart.Header.ImageBevel.Brush.Visible = true;
            topChart.Header.Lines = new string[]
    {
    "Channel 0"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(169, 169, 169);
            topChart.Header.Shadow.Brush.Solid = true;
            topChart.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Legend.Brush.Color = System.Drawing.Color.White;
            topChart.Legend.Brush.Solid = true;
            topChart.Legend.Brush.Visible = true;
            topChart.Legend.CheckBoxes = false;
            // 
            // 
            // 
            topChart.Legend.Font.Bold = false;
            // 
            // 
            // 
            topChart.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            topChart.Legend.Font.Brush.Solid = true;
            topChart.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Legend.Font.Shadow.Brush.Solid = true;
            topChart.Legend.Font.Shadow.Brush.Visible = true;
            topChart.Legend.Font.Size = 9;
            topChart.Legend.Font.SizeFloat = 9F;
            topChart.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            topChart.Legend.ImageBevel.Brush.Solid = true;
            topChart.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(0, 0, 0);
            topChart.Legend.Shadow.Brush.Solid = true;
            topChart.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Legend.Symbol.Shadow.Brush.Solid = true;
            topChart.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Legend.Title.Brush.Color = System.Drawing.Color.White;
            topChart.Legend.Title.Brush.Solid = true;
            topChart.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            topChart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            topChart.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            topChart.Legend.Title.Font.Brush.Solid = true;
            topChart.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Legend.Title.Font.Shadow.Brush.Solid = true;
            topChart.Legend.Title.Font.Shadow.Brush.Visible = true;
            topChart.Legend.Title.Font.Size = 8;
            topChart.Legend.Title.Font.SizeFloat = 8F;
            topChart.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            topChart.Legend.Title.ImageBevel.Brush.Solid = true;
            topChart.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Legend.Title.Shadow.Brush.Solid = true;
            topChart.Legend.Title.Shadow.Brush.Visible = true;
            topChart.Legend.Visible = false;
            topChart.Location = new System.Drawing.Point(0, 0);
            topChart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            topChart.Name = "topChart";
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Panel.Brush.Color = System.Drawing.Color.White;
            topChart.Panel.Brush.Solid = true;
            topChart.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            topChart.Panel.ImageBevel.Brush.Solid = true;
            topChart.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Panel.Shadow.Brush.Solid = true;
            topChart.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins2.Bottom = 100;
            margins2.Left = 100;
            margins2.Right = 100;
            margins2.Top = 100;
            topChart.Printer.Margins = margins2;
            topChart.Series.Add(mtxFastLine1);
            signalTeeItem2.Caption = null;
            signalTeeItem2.Input = null;
            signalTeeItem2.Inputs = signalList;
            signalTeeItem2.InputsItemIndex = 0;
            signalTeeItem2.Series = null;
            signalTeeItem2.SeriesName = "mtxFastLine1";
            topChart.Signals.Add(signalTeeItem2);
            topChart.Size = new System.Drawing.Size(1185, 213);
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            topChart.SubFooter.Brush.Solid = true;
            topChart.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            topChart.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            topChart.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            topChart.SubFooter.Font.Brush.Solid = true;
            topChart.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.SubFooter.Font.Shadow.Brush.Solid = true;
            topChart.SubFooter.Font.Shadow.Brush.Visible = true;
            topChart.SubFooter.Font.Size = 8;
            topChart.SubFooter.Font.SizeFloat = 8F;
            topChart.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            topChart.SubFooter.ImageBevel.Brush.Solid = true;
            topChart.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.SubFooter.Shadow.Brush.Solid = true;
            topChart.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(192, 192, 192);
            topChart.SubHeader.Brush.Solid = true;
            topChart.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            topChart.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            topChart.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            topChart.SubHeader.Font.Brush.Solid = true;
            topChart.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.SubHeader.Font.Shadow.Brush.Solid = true;
            topChart.SubHeader.Font.Shadow.Brush.Visible = true;
            topChart.SubHeader.Font.Size = 12;
            topChart.SubHeader.Font.SizeFloat = 12F;
            topChart.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            topChart.SubHeader.ImageBevel.Brush.Solid = true;
            topChart.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(169, 169, 169);
            topChart.SubHeader.Shadow.Brush.Solid = true;
            topChart.SubHeader.Shadow.Brush.Visible = true;
            topChart.TabIndex = 0;
            topChart.Tools.Add(axisScaleTool1);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            topChart.Walls.Back.Brush.Solid = true;
            topChart.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            topChart.Walls.Back.ImageBevel.Brush.Solid = true;
            topChart.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Walls.Back.Shadow.Brush.Solid = true;
            topChart.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            topChart.Walls.Bottom.Brush.Solid = true;
            topChart.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            topChart.Walls.Bottom.ImageBevel.Brush.Solid = true;
            topChart.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Walls.Bottom.Shadow.Brush.Solid = true;
            topChart.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            topChart.Walls.Left.Brush.Solid = true;
            topChart.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            topChart.Walls.Left.ImageBevel.Brush.Solid = true;
            topChart.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Walls.Left.Shadow.Brush.Solid = true;
            topChart.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            topChart.Walls.Right.Brush.Solid = true;
            topChart.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            topChart.Walls.Right.ImageBevel.Brush.Solid = true;
            topChart.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            topChart.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            topChart.Walls.Right.Shadow.Brush.Solid = true;
            topChart.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            topChart.Zoom.Animated = true;
            // 
            // 
            // 
            topChart.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            topChart.Zoom.Brush.Solid = true;
            topChart.Zoom.Brush.Visible = false;
            topChart.Click += topChart_Click;
            // 
            // axisScaleTool1
            // 
            axisScaleTool1.Axis = topChart.Axes.Left;
            axisScaleTool1.AxisIndex = -1;
            axisScaleTool1.AxisScaleMode = Dew.Signal.Tee.AxisScaleMode.amPeakHold;
            axisScaleTool1.DataIsSpectrum = false;
            axisScaleTool1.LowerMargin = 10;
            axisScaleTool1.UpperMargin = 10;
            // 
            // mtxFastLine1
            // 
            // 
            // 
            // 
            mtxFastLine1.Brush.Color = System.Drawing.Color.FromArgb(119, 153, 214);
            mtxFastLine1.Brush.Solid = true;
            mtxFastLine1.Brush.Visible = true;
            mtxFastLine1.Color = System.Drawing.Color.FromArgb(119, 153, 214);
            mtxFastLine1.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine1.Legend.Brush.Color = System.Drawing.Color.White;
            mtxFastLine1.Legend.Brush.Solid = true;
            mtxFastLine1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            mtxFastLine1.Legend.Font.Bold = false;
            // 
            // 
            // 
            mtxFastLine1.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            mtxFastLine1.Legend.Font.Brush.Solid = true;
            mtxFastLine1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
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
            mtxFastLine1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            mtxFastLine1.Legend.ImageBevel.Brush.Solid = true;
            mtxFastLine1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            mtxFastLine1.Legend.Shadow.Brush.Solid = true;
            mtxFastLine1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine1.Marks.Brush.Color = System.Drawing.Color.FromArgb(255, 255, 255);
            mtxFastLine1.Marks.Brush.Solid = true;
            mtxFastLine1.Marks.Brush.Visible = true;
            // 
            // 
            // 
            mtxFastLine1.Marks.Font.Bold = false;
            // 
            // 
            // 
            mtxFastLine1.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            mtxFastLine1.Marks.Font.Brush.Solid = true;
            mtxFastLine1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine1.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
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
            mtxFastLine1.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            mtxFastLine1.Marks.ImageBevel.Brush.Solid = true;
            mtxFastLine1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine1.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            mtxFastLine1.Marks.Shadow.Brush.Solid = true;
            mtxFastLine1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine1.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            mtxFastLine1.Marks.Symbol.Brush.Solid = true;
            mtxFastLine1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine1.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            mtxFastLine1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            mtxFastLine1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine1.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            mtxFastLine1.Marks.Symbol.Shadow.Brush.Solid = true;
            mtxFastLine1.Marks.Symbol.Shadow.Brush.Visible = true;
            mtxFastLine1.Title = "mtxFastLine1";
            mtxFastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            // 
            // 
            // 
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
            mtxFastLine1.YValues.Value = new double[]
    {
    589D,
    632D,
    756D,
    706D,
    597D,
    588D,
    584D,
    513D,
    406D,
    339D,
    252D,
    239D,
    227D,
    107D,
    79D,
    158D,
    84D,
    187D,
    69D,
    71D,
    187D,
    310D,
    189D,
    227D,
    172D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // mtxFastLine2
            // 
            // 
            // 
            // 
            mtxFastLine2.Brush.Color = System.Drawing.Color.FromArgb(119, 153, 214);
            mtxFastLine2.Brush.Solid = true;
            mtxFastLine2.Brush.Visible = true;
            mtxFastLine2.Color = System.Drawing.Color.FromArgb(119, 153, 214);
            mtxFastLine2.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine2.Legend.Brush.Color = System.Drawing.Color.White;
            mtxFastLine2.Legend.Brush.Solid = true;
            mtxFastLine2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            mtxFastLine2.Legend.Font.Bold = false;
            // 
            // 
            // 
            mtxFastLine2.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            mtxFastLine2.Legend.Font.Brush.Solid = true;
            mtxFastLine2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            mtxFastLine2.Legend.Font.Shadow.Brush.Solid = true;
            mtxFastLine2.Legend.Font.Shadow.Brush.Visible = true;
            mtxFastLine2.Legend.Font.Size = 8;
            mtxFastLine2.Legend.Font.SizeFloat = 8F;
            mtxFastLine2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            mtxFastLine2.Legend.ImageBevel.Brush.Solid = true;
            mtxFastLine2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine2.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            mtxFastLine2.Legend.Shadow.Brush.Solid = true;
            mtxFastLine2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine2.Marks.Brush.Color = System.Drawing.Color.FromArgb(255, 255, 255);
            mtxFastLine2.Marks.Brush.Solid = true;
            mtxFastLine2.Marks.Brush.Visible = true;
            // 
            // 
            // 
            mtxFastLine2.Marks.Font.Bold = false;
            // 
            // 
            // 
            mtxFastLine2.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            mtxFastLine2.Marks.Font.Brush.Solid = true;
            mtxFastLine2.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine2.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            mtxFastLine2.Marks.Font.Shadow.Brush.Solid = true;
            mtxFastLine2.Marks.Font.Shadow.Brush.Visible = true;
            mtxFastLine2.Marks.Font.Size = 8;
            mtxFastLine2.Marks.Font.SizeFloat = 8F;
            mtxFastLine2.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine2.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            mtxFastLine2.Marks.ImageBevel.Brush.Solid = true;
            mtxFastLine2.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine2.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            mtxFastLine2.Marks.Shadow.Brush.Solid = true;
            mtxFastLine2.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine2.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            mtxFastLine2.Marks.Symbol.Brush.Solid = true;
            mtxFastLine2.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine2.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            mtxFastLine2.Marks.Symbol.ImageBevel.Brush.Solid = true;
            mtxFastLine2.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            mtxFastLine2.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            mtxFastLine2.Marks.Symbol.Shadow.Brush.Solid = true;
            mtxFastLine2.Marks.Symbol.Shadow.Brush.Visible = true;
            mtxFastLine2.Title = "mtxFastLine1";
            mtxFastLine2.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            // 
            // 
            // 
            mtxFastLine2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            mtxFastLine2.XValues.Value = new double[]
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
            mtxFastLine2.YValues.Value = new double[]
    {
    128D,
    157D,
    179D,
    281D,
    246D,
    310D,
    382D,
    287D,
    188D,
    216D,
    250D,
    268D,
    347D,
    438D,
    373D,
    342D,
    365D,
    406D,
    301D,
    309D,
    433D,
    348D,
    343D,
    234D,
    147D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // AsioPlaybackForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1185, 730);
            Controls.Add(bottomChart);
            Controls.Add(panel1);
            Controls.Add(splitter1);
            Controls.Add(topChart);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "AsioPlaybackForm";
            Text = "AsioPlaybackForm";
            FormClosing += AsioPlaybackForm_FormClosing;
            FormClosed += AsioPlaybackForm_FormClosed;
            Load += AsioPlaybackForm_Load;
            Resize += AsioPlaybackForm_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)volumeTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)bottomChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)topChart).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Dew.Signal.Tee.SignalChart topChart;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel1;
		private Dew.Signal.Tee.SignalChart bottomChart;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox clockSourcesBox;
		private System.Windows.Forms.ListBox outputChBox;
		private System.Windows.Forms.ListBox FSListBox;
		private System.Windows.Forms.ListBox driverNameListBox;
		private System.Windows.Forms.Label label1;
		private Dew.Signal.TSignalRead signalRead;
		private Dew.Signal.TSignalDemuxList signalDemuxList;
		private Dew.Signal.TSignalRateConverterList signalRateConverterList;
		private Dew.Signal.TSignalList signalList;
		private System.Windows.Forms.Timer timer1;
		private Dew.Signal.Audio.SignalAsio signalAsio1;
		private System.Windows.Forms.TrackBar volumeTrackBar;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Dew.Signal.Tee.AxisScaleTool axisScaleTool1;
        private Dew.Signal.Tee.AxisScaleTool axisScaleTool2;
        private Dew.Math.Tee.MtxFastLine mtxFastLine1;
        private Dew.Math.Tee.MtxFastLine mtxFastLine2;
    }
}