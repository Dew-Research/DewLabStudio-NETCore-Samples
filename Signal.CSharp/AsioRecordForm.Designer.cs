namespace DSPDemo
{
	partial class AsioRecordForm
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
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsioRecordForm));
            Dew.Signal.TSignalItem tSignalItem1 = new Dew.Signal.TSignalItem();
            Dew.Signal.Tee.SignalTeeItem signalTeeItem1 = new Dew.Signal.Tee.SignalTeeItem();
            Dew.Signal.Tee.SignalTeeItem signalTeeItem2 = new Dew.Signal.Tee.SignalTeeItem();
            this.signalList = new Dew.Signal.TSignalList(this.components);
            this.mtxFastLine2 = new Dew.Math.Tee.MtxFastLine();
            this.mtxFastLine1 = new Dew.Math.Tee.MtxFastLine();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputChBox = new System.Windows.Forms.ListBox();
            this.outputChBox = new System.Windows.Forms.ListBox();
            this.FSListBox = new System.Windows.Forms.ListBox();
            this.driverNameListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.signalRead = new Dew.Signal.TSignalRead(this.components);
            this.signalDemuxList = new Dew.Signal.TSignalDemuxList(this.components);
            this.signalRateConverterList = new Dew.Signal.TSignalRateConverterList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.signalWrite1 = new Dew.Signal.TSignalWrite(this.components);
            this.signalMux = new Dew.Signal.TSignalMux(this.components);
            this.signalAsio1 = new Dew.Signal.SignalAsio(this.components);
            this.bottomChart = new Dew.Signal.Tee.SignalChart();
            this.axisScaleTool2 = new Dew.Signal.Tee.AxisScaleTool();
            this.topChart = new Dew.Signal.Tee.SignalChart();
            this.axisScaleTool1 = new Dew.Signal.Tee.AxisScaleTool();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topChart)).BeginInit();
            this.SuspendLayout();
            // 
            // signalList
            // 
            this.signalList.BlockAssign = false;
            this.signalList.Complex = false;
            this.signalList.Count = 2;
            this.signalList.EditIndex = -1;
            this.signalList.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.signalList.FloatPrecisionLock = false;
            this.signalList.IsDouble = true;
            this.signalList.Managed = true;
            this.signalList.Name = null;
            this.signalList.PropagateTemplate = false;
            // 
            // mtxFastLine2
            // 
            this.mtxFastLine2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.mtxFastLine2.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.mtxFastLine2.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.mtxFastLine2.Legend.Brush.Color = System.Drawing.Color.White;
            this.mtxFastLine2.Legend.Brush.Solid = true;
            this.mtxFastLine2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.mtxFastLine2.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.mtxFastLine2.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.mtxFastLine2.Legend.Font.Brush.Solid = true;
            this.mtxFastLine2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.mtxFastLine2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.mtxFastLine2.Legend.Font.Shadow.Brush.Solid = true;
            this.mtxFastLine2.Legend.Font.Shadow.Brush.Visible = true;
            this.mtxFastLine2.Legend.Font.Size = 8;
            this.mtxFastLine2.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.mtxFastLine2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.mtxFastLine2.Legend.ImageBevel.Brush.Solid = true;
            this.mtxFastLine2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.mtxFastLine2.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.mtxFastLine2.Legend.Shadow.Brush.Solid = true;
            this.mtxFastLine2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.mtxFastLine2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.mtxFastLine2.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.mtxFastLine2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mtxFastLine2.Marks.Brush.Solid = true;
            this.mtxFastLine2.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.mtxFastLine2.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.mtxFastLine2.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.mtxFastLine2.Marks.Font.Brush.Solid = true;
            this.mtxFastLine2.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.mtxFastLine2.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.mtxFastLine2.Marks.Font.Shadow.Brush.Solid = true;
            this.mtxFastLine2.Marks.Font.Shadow.Brush.Visible = true;
            this.mtxFastLine2.Marks.Font.Size = 8;
            this.mtxFastLine2.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.mtxFastLine2.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.mtxFastLine2.Marks.ImageBevel.Brush.Solid = true;
            this.mtxFastLine2.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.mtxFastLine2.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.mtxFastLine2.Marks.Shadow.Brush.Solid = true;
            this.mtxFastLine2.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.mtxFastLine2.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.mtxFastLine2.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.mtxFastLine2.Marks.Symbol.Brush.Solid = true;
            this.mtxFastLine2.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.mtxFastLine2.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.mtxFastLine2.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.mtxFastLine2.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.mtxFastLine2.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.mtxFastLine2.Marks.Symbol.Shadow.Brush.Solid = true;
            this.mtxFastLine2.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.mtxFastLine2.Marks.TailParams.Margin = 0F;
            this.mtxFastLine2.Marks.TailParams.PointerHeight = 8D;
            this.mtxFastLine2.Marks.TailParams.PointerWidth = 8D;
            this.mtxFastLine2.OriginalCursor = null;
            this.mtxFastLine2.Title = "mtxFastLine2";
            this.mtxFastLine2.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.mtxFastLine2.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.mtxFastLine2.XValues.DataMember = "X";
            this.mtxFastLine2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.mtxFastLine2.YValues.DataMember = "Y";
            // 
            // mtxFastLine1
            // 
            this.mtxFastLine1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.mtxFastLine1.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.mtxFastLine1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.mtxFastLine1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.mtxFastLine1.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.mtxFastLine1.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
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
            this.mtxFastLine1.Marks.TailParams.Margin = 0F;
            this.mtxFastLine1.Marks.TailParams.PointerHeight = 8D;
            this.mtxFastLine1.Marks.TailParams.PointerWidth = 8D;
            this.mtxFastLine1.OriginalCursor = Steema.TeeChart.Drawing.Cursors.Default;
            this.mtxFastLine1.Title = "mtxFastLine1";
            this.mtxFastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.mtxFastLine1.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.mtxFastLine1.XValues.DataMember = "X";
            this.mtxFastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.mtxFastLine1.YValues.DataMember = "Y";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.statusLabel);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.inputChBox);
            this.panel1.Controls.Add(this.outputChBox);
            this.panel1.Controls.Add(this.FSListBox);
            this.panel1.Controls.Add(this.driverNameListBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 217);
            this.panel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Recording to: \'C:\\Test.wav\'";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 195);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Status:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(177, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Control panel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(15, 142);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Input channels:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Output channels:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supported FS [Hz]:";
            // 
            // inputChBox
            // 
            this.inputChBox.FormattingEnabled = true;
            this.inputChBox.Location = new System.Drawing.Point(554, 28);
            this.inputChBox.Name = "inputChBox";
            this.inputChBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.inputChBox.Size = new System.Drawing.Size(150, 108);
            this.inputChBox.TabIndex = 1;
            // 
            // outputChBox
            // 
            this.outputChBox.FormattingEnabled = true;
            this.outputChBox.Location = new System.Drawing.Point(398, 28);
            this.outputChBox.Name = "outputChBox";
            this.outputChBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.outputChBox.Size = new System.Drawing.Size(150, 108);
            this.outputChBox.TabIndex = 1;
            // 
            // FSListBox
            // 
            this.FSListBox.FormattingEnabled = true;
            this.FSListBox.Location = new System.Drawing.Point(171, 28);
            this.FSListBox.Name = "FSListBox";
            this.FSListBox.Size = new System.Drawing.Size(150, 108);
            this.FSListBox.TabIndex = 1;
            // 
            // driverNameListBox
            // 
            this.driverNameListBox.FormattingEnabled = true;
            this.driverNameListBox.Location = new System.Drawing.Point(15, 28);
            this.driverNameListBox.Name = "driverNameListBox";
            this.driverNameListBox.Size = new System.Drawing.Size(150, 108);
            this.driverNameListBox.TabIndex = 1;
            this.driverNameListBox.SelectedIndexChanged += new System.EventHandler(this.driverNameListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drivers:";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 185);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(897, 3);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // signalRead
            // 
            this.signalRead.BandwidthL = 0D;
            this.signalRead.BlockAssign = false;
            this.signalRead.Complex = false;
            this.signalRead.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.signalRead.FloatPrecisionLock = false;
            this.signalRead.FramesPerSecond = 0.0078125D;
            this.signalRead.Input = null;
            this.signalRead.IsDouble = true;
            this.signalRead.Name = null;
            // 
            // signalDemuxList
            // 
            this.signalDemuxList.BlockAssign = false;
            this.signalDemuxList.Complex = false;
            this.signalDemuxList.Count = 0;
            this.signalDemuxList.EditIndex = -1;
            this.signalDemuxList.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.signalDemuxList.FloatPrecisionLock = false;
            this.signalDemuxList.Input = this.signalRead;
            this.signalDemuxList.Inputs = null;
            this.signalDemuxList.IsDouble = true;
            // ------>>
            // <<------
            this.signalDemuxList.Managed = true;
            this.signalDemuxList.Name = null;
            this.signalDemuxList.PropagateTemplate = false;
            // 
            // signalRateConverterList
            // 
            this.signalRateConverterList.BlockAssign = false;
            this.signalRateConverterList.Complex = false;
            this.signalRateConverterList.Count = 0;
            this.signalRateConverterList.EditIndex = -1;
            this.signalRateConverterList.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.signalRateConverterList.FloatPrecisionLock = false;
            this.signalRateConverterList.Inputs = this.signalDemuxList;
            this.signalRateConverterList.IsDouble = true;
            // ------>>
            // <<------
            this.signalRateConverterList.Managed = true;
            this.signalRateConverterList.Name = null;
            this.signalRateConverterList.PropagateTemplate = false;
            this.signalRateConverterList.OnBeforeUpdate += new Dew.Math.TNotifyEvent(this.signalRateConverterList_OnBeforeUpdate);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Uncompressed WAV files.|*.wav";
            this.openFileDialog1.Title = "Select uncompressed wav file";
            // 
            // signalWrite1
            // 
            this.signalWrite1.AuthorInfo = "Unknown";
            this.signalWrite1.BandwidthL = 0D;
            this.signalWrite1.BlockAssign = false;
            this.signalWrite1.Complex = false;
            this.signalWrite1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.signalWrite1.FloatPrecisionLock = false;
            this.signalWrite1.ImFormat = null;
            this.signalWrite1.Input = this.signalMux;
            this.signalWrite1.IsDouble = true;
            this.signalWrite1.Name = null;
            this.signalWrite1.ReFormat = null;
            // 
            // signalMux
            // 
            this.signalMux.BandwidthL = 0D;
            this.signalMux.BlockAssign = false;
            this.signalMux.Complex = false;
            this.signalMux.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.signalMux.FloatPrecisionLock = false;
            this.signalMux.InputList = this.signalAsio1;
            tSignalItem1.Input = null;
            this.signalMux.Inputs.Add(tSignalItem1);
            this.signalMux.IsDouble = true;
            this.signalMux.Name = null;
            // 
            // signalAsio1
            // 
            this.signalAsio1.Active = false;
            this.signalAsio1.BlockAssign = false;
            this.signalAsio1.Complex = false;
            this.signalAsio1.Continuous = false;
            this.signalAsio1.Count = 0;
            this.signalAsio1.EditIndex = -1;
            this.signalAsio1.ExtendedBufferTime = 500;
            this.signalAsio1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.signalAsio1.FloatPrecisionLock = false;
            this.signalAsio1.InputPrecision = Dew.Math.TPrecision.prDouble;
            this.signalAsio1.Inputs = this.signalRateConverterList;
            this.signalAsio1.IsDouble = true;
            this.signalAsio1.Managed = true;
            this.signalAsio1.Name = null;
            this.signalAsio1.OutputPrecision = Dew.Math.TPrecision.prSmallInt;
            this.signalAsio1.Paused = false;
            this.signalAsio1.PropagateTemplate = false;
            this.signalAsio1.SamplingFrequency = 48000D;
            this.signalAsio1.ProcessRealTime += new System.EventHandler(this.signalAsio1_ProcessRealTime);
            this.signalAsio1.InputBufferReady += new System.EventHandler(this.signalAsio1_InputBufferReady);
            this.signalAsio1.OnStop += new System.EventHandler(this.signalAsio1_OnStop);
            // 
            // bottomChart
            // 
            // 
            // 
            // 
            this.bottomChart.Graphics3D.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            this.bottomChart.Graphics3D.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // 
            // 
            this.bottomChart.Axes.Automatic = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.bottomChart.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.bottomChart.Axes.Bottom.Labels.Brush.Solid = true;
            this.bottomChart.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.bottomChart.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.bottomChart.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bottomChart.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.bottomChart.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.bottomChart.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.bottomChart.Axes.Bottom.Labels.Font.Size = 9;
            this.bottomChart.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.bottomChart.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.bottomChart.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.bottomChart.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            this.bottomChart.Axes.Bottom.MaximumOffset = 1;
            this.bottomChart.Axes.Bottom.MinimumOffset = 1;
            // 
            // 
            // 
            this.bottomChart.Axes.Bottom.MinorTicks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            // 
            // 
            // 
            this.bottomChart.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.bottomChart.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.bottomChart.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.bottomChart.Axes.Bottom.Title.Brush.Solid = true;
            this.bottomChart.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.bottomChart.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.bottomChart.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bottomChart.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.bottomChart.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.bottomChart.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.bottomChart.Axes.Bottom.Title.Font.Size = 11;
            this.bottomChart.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.bottomChart.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.bottomChart.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.bottomChart.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.bottomChart.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.bottomChart.Axes.Depth.Labels.Brush.Solid = true;
            this.bottomChart.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.bottomChart.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.bottomChart.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bottomChart.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.bottomChart.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.bottomChart.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.bottomChart.Axes.Depth.Labels.Font.Size = 9;
            this.bottomChart.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.bottomChart.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.bottomChart.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.bottomChart.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.bottomChart.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.bottomChart.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.bottomChart.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.bottomChart.Axes.Depth.Title.Brush.Solid = true;
            this.bottomChart.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.bottomChart.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.bottomChart.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bottomChart.Axes.Depth.Title.Font.Brush.Solid = true;
            this.bottomChart.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.bottomChart.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.bottomChart.Axes.Depth.Title.Font.Size = 11;
            this.bottomChart.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.bottomChart.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.bottomChart.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.bottomChart.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.bottomChart.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.bottomChart.Axes.DepthTop.Labels.Brush.Solid = true;
            this.bottomChart.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.bottomChart.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.bottomChart.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bottomChart.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.bottomChart.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.bottomChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.bottomChart.Axes.DepthTop.Labels.Font.Size = 9;
            this.bottomChart.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.bottomChart.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.bottomChart.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.bottomChart.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.bottomChart.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.bottomChart.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.bottomChart.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.bottomChart.Axes.DepthTop.Title.Brush.Solid = true;
            this.bottomChart.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.bottomChart.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.bottomChart.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bottomChart.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.bottomChart.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.bottomChart.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.bottomChart.Axes.DepthTop.Title.Font.Size = 11;
            this.bottomChart.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.bottomChart.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.bottomChart.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.bottomChart.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.bottomChart.Axes.Left.Automatic = false;
            this.bottomChart.Axes.Left.AutomaticMaximum = false;
            this.bottomChart.Axes.Left.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.bottomChart.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.bottomChart.Axes.Left.Labels.Brush.Solid = true;
            this.bottomChart.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.bottomChart.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.bottomChart.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bottomChart.Axes.Left.Labels.Font.Brush.Solid = true;
            this.bottomChart.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.bottomChart.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.bottomChart.Axes.Left.Labels.Font.Size = 9;
            this.bottomChart.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.bottomChart.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.bottomChart.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.bottomChart.Axes.Left.Labels.Shadow.Brush.Visible = true;
            this.bottomChart.Axes.Left.Labels.ValueFormat = "#,##0.####";
            this.bottomChart.Axes.Left.Maximum = 1012.3D;
            this.bottomChart.Axes.Left.MaximumOffset = 1;
            this.bottomChart.Axes.Left.Minimum = 420.7D;
            this.bottomChart.Axes.Left.MinimumOffset = 1;
            // 
            // 
            // 
            this.bottomChart.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.bottomChart.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.bottomChart.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.bottomChart.Axes.Left.Title.Brush.Solid = true;
            this.bottomChart.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.bottomChart.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.bottomChart.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bottomChart.Axes.Left.Title.Font.Brush.Solid = true;
            this.bottomChart.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.bottomChart.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.bottomChart.Axes.Left.Title.Font.Size = 11;
            this.bottomChart.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.bottomChart.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.bottomChart.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.bottomChart.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.bottomChart.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.bottomChart.Axes.Right.Labels.Brush.Solid = true;
            this.bottomChart.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.bottomChart.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.bottomChart.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bottomChart.Axes.Right.Labels.Font.Brush.Solid = true;
            this.bottomChart.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.bottomChart.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.bottomChart.Axes.Right.Labels.Font.Size = 9;
            this.bottomChart.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.bottomChart.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.bottomChart.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.bottomChart.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.bottomChart.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.bottomChart.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.bottomChart.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.bottomChart.Axes.Right.Title.Brush.Solid = true;
            this.bottomChart.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.bottomChart.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.bottomChart.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bottomChart.Axes.Right.Title.Font.Brush.Solid = true;
            this.bottomChart.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.bottomChart.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.bottomChart.Axes.Right.Title.Font.Size = 11;
            this.bottomChart.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.bottomChart.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.bottomChart.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.bottomChart.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.bottomChart.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.bottomChart.Axes.Top.Labels.Brush.Solid = true;
            this.bottomChart.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.bottomChart.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.bottomChart.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bottomChart.Axes.Top.Labels.Font.Brush.Solid = true;
            this.bottomChart.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.bottomChart.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.bottomChart.Axes.Top.Labels.Font.Size = 9;
            this.bottomChart.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.bottomChart.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.bottomChart.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.bottomChart.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.bottomChart.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.bottomChart.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.bottomChart.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.bottomChart.Axes.Top.Title.Brush.Solid = true;
            this.bottomChart.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.bottomChart.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.bottomChart.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bottomChart.Axes.Top.Title.Font.Brush.Solid = true;
            this.bottomChart.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.bottomChart.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.bottomChart.Axes.Top.Title.Font.Size = 11;
            this.bottomChart.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.bottomChart.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.bottomChart.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.bottomChart.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.bottomChart.Color = System.Drawing.Color.White;
            this.bottomChart.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.bottomChart.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.bottomChart.Footer.Brush.Solid = true;
            this.bottomChart.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.bottomChart.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.bottomChart.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.bottomChart.Footer.Font.Brush.Solid = true;
            this.bottomChart.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Footer.Font.Shadow.Brush.Solid = true;
            this.bottomChart.Footer.Font.Shadow.Brush.Visible = true;
            this.bottomChart.Footer.Font.Size = 8;
            this.bottomChart.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.bottomChart.Footer.ImageBevel.Brush.Solid = true;
            this.bottomChart.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Footer.Shadow.Brush.Solid = true;
            this.bottomChart.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.bottomChart.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bottomChart.Header.Brush.Solid = true;
            this.bottomChart.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.bottomChart.Header.Font.Bold = false;
            // 
            // 
            // 
            this.bottomChart.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bottomChart.Header.Font.Brush.Solid = true;
            this.bottomChart.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Header.Font.Shadow.Brush.Solid = true;
            this.bottomChart.Header.Font.Shadow.Brush.Visible = true;
            this.bottomChart.Header.Font.Size = 12;
            this.bottomChart.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.bottomChart.Header.ImageBevel.Brush.Solid = true;
            this.bottomChart.Header.ImageBevel.Brush.Visible = true;
            this.bottomChart.Header.Lines = new string[] {
        "Channel 1"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bottomChart.Header.Shadow.Brush.Solid = true;
            this.bottomChart.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.bottomChart.Legend.Brush.Color = System.Drawing.Color.White;
            this.bottomChart.Legend.Brush.Solid = true;
            this.bottomChart.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.bottomChart.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.bottomChart.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bottomChart.Legend.Font.Brush.Solid = true;
            this.bottomChart.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Legend.Font.Shadow.Brush.Solid = true;
            this.bottomChart.Legend.Font.Shadow.Brush.Visible = true;
            this.bottomChart.Legend.Font.Size = 9;
            this.bottomChart.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.bottomChart.Legend.ImageBevel.Brush.Solid = true;
            this.bottomChart.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bottomChart.Legend.Shadow.Brush.Solid = true;
            this.bottomChart.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Legend.Symbol.Shadow.Brush.Solid = true;
            this.bottomChart.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.bottomChart.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.bottomChart.Legend.Title.Brush.Solid = true;
            this.bottomChart.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.bottomChart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.bottomChart.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.bottomChart.Legend.Title.Font.Brush.Solid = true;
            this.bottomChart.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.bottomChart.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.bottomChart.Legend.Title.Font.Size = 8;
            this.bottomChart.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.bottomChart.Legend.Title.ImageBevel.Brush.Solid = true;
            this.bottomChart.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Legend.Title.Shadow.Brush.Solid = true;
            this.bottomChart.Legend.Title.Shadow.Brush.Visible = true;
            this.bottomChart.Legend.Visible = false;
            this.bottomChart.Location = new System.Drawing.Point(0, 185);
            this.bottomChart.Name = "bottomChart";
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.bottomChart.Panel.Brush.Color = System.Drawing.Color.White;
            this.bottomChart.Panel.Brush.Solid = true;
            this.bottomChart.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.bottomChart.Panel.ImageBevel.Brush.Solid = true;
            this.bottomChart.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Panel.Shadow.Brush.Solid = true;
            this.bottomChart.Panel.Shadow.Brush.Visible = true;
            this.bottomChart.Series.Add(this.mtxFastLine2);
            signalTeeItem1.Caption = null;
            signalTeeItem1.Input = null;
            signalTeeItem1.Inputs = this.signalList;
            signalTeeItem1.InputsItemIndex = 1;
            signalTeeItem1.Series = this.mtxFastLine2;
            signalTeeItem1.SeriesName = "mtxFastLine2";
            this.bottomChart.Signals.Add(signalTeeItem1);
            this.bottomChart.Size = new System.Drawing.Size(897, 166);
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.bottomChart.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.bottomChart.SubFooter.Brush.Solid = true;
            this.bottomChart.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.bottomChart.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.bottomChart.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.bottomChart.SubFooter.Font.Brush.Solid = true;
            this.bottomChart.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.SubFooter.Font.Shadow.Brush.Solid = true;
            this.bottomChart.SubFooter.Font.Shadow.Brush.Visible = true;
            this.bottomChart.SubFooter.Font.Size = 8;
            this.bottomChart.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.bottomChart.SubFooter.ImageBevel.Brush.Solid = true;
            this.bottomChart.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.SubFooter.Shadow.Brush.Solid = true;
            this.bottomChart.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.bottomChart.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bottomChart.SubHeader.Brush.Solid = true;
            this.bottomChart.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.bottomChart.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.bottomChart.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bottomChart.SubHeader.Font.Brush.Solid = true;
            this.bottomChart.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.SubHeader.Font.Shadow.Brush.Solid = true;
            this.bottomChart.SubHeader.Font.Shadow.Brush.Visible = true;
            this.bottomChart.SubHeader.Font.Size = 12;
            this.bottomChart.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.bottomChart.SubHeader.ImageBevel.Brush.Solid = true;
            this.bottomChart.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bottomChart.SubHeader.Shadow.Brush.Solid = true;
            this.bottomChart.SubHeader.Shadow.Brush.Visible = true;
            this.bottomChart.TabIndex = 6;
            this.bottomChart.Tools.Add(this.axisScaleTool2);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.bottomChart.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.bottomChart.Walls.Back.Brush.Solid = true;
            this.bottomChart.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.bottomChart.Walls.Back.ImageBevel.Brush.Solid = true;
            this.bottomChart.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Walls.Back.Shadow.Brush.Solid = true;
            this.bottomChart.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.bottomChart.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.bottomChart.Walls.Bottom.Brush.Solid = true;
            this.bottomChart.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.bottomChart.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.bottomChart.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Walls.Bottom.Shadow.Brush.Solid = true;
            this.bottomChart.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.bottomChart.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.bottomChart.Walls.Left.Brush.Solid = true;
            this.bottomChart.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.bottomChart.Walls.Left.ImageBevel.Brush.Solid = true;
            this.bottomChart.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Walls.Left.Shadow.Brush.Solid = true;
            this.bottomChart.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.bottomChart.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.bottomChart.Walls.Right.Brush.Solid = true;
            this.bottomChart.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.bottomChart.Walls.Right.ImageBevel.Brush.Solid = true;
            this.bottomChart.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.bottomChart.Walls.Right.Shadow.Brush.Solid = true;
            this.bottomChart.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.bottomChart.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.bottomChart.Zoom.Brush.Solid = true;
            this.bottomChart.Zoom.Brush.Visible = false;
            // 
            // axisScaleTool2
            // 
            this.axisScaleTool2.Axis = this.bottomChart.Axes.Left;
            this.axisScaleTool2.AxisScaleMode = Dew.Signal.Tee.AxisScaleMode.amPeakHold;
            this.axisScaleTool2.DataIsSpectrum = false;
            this.axisScaleTool2.LowerMargin = 10;
            this.axisScaleTool2.UpperMargin = 10;
            // 
            // topChart
            // 
            // 
            // 
            // 
            this.topChart.Graphics3D.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            this.topChart.Graphics3D.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // 
            // 
            this.topChart.Axes.Automatic = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Bottom.Grid.DrawEvery = 1;
            this.topChart.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.topChart.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.topChart.Axes.Bottom.Labels.Brush.Solid = true;
            this.topChart.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.topChart.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.topChart.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.topChart.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.topChart.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.topChart.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.topChart.Axes.Bottom.Labels.Font.Size = 9;
            this.topChart.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.topChart.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.topChart.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.topChart.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            this.topChart.Axes.Bottom.MaximumOffset = 1;
            this.topChart.Axes.Bottom.MinimumOffset = 1;
            // 
            // 
            // 
            this.topChart.Axes.Bottom.MinorTicks.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            // 
            // 
            // 
            this.topChart.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.topChart.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.topChart.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.topChart.Axes.Bottom.Title.Brush.Solid = true;
            this.topChart.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.topChart.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.topChart.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.topChart.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.topChart.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.topChart.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.topChart.Axes.Bottom.Title.Font.Size = 11;
            this.topChart.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.topChart.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.topChart.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.topChart.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.topChart.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.topChart.Axes.Depth.Labels.Brush.Solid = true;
            this.topChart.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.topChart.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.topChart.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.topChart.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.topChart.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.topChart.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.topChart.Axes.Depth.Labels.Font.Size = 9;
            this.topChart.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.topChart.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.topChart.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.topChart.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.topChart.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.topChart.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.topChart.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.topChart.Axes.Depth.Title.Brush.Solid = true;
            this.topChart.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.topChart.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.topChart.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.topChart.Axes.Depth.Title.Font.Brush.Solid = true;
            this.topChart.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.topChart.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.topChart.Axes.Depth.Title.Font.Size = 11;
            this.topChart.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.topChart.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.topChart.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.topChart.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.topChart.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.topChart.Axes.DepthTop.Labels.Brush.Solid = true;
            this.topChart.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.topChart.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.topChart.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.topChart.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.topChart.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.topChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.topChart.Axes.DepthTop.Labels.Font.Size = 9;
            this.topChart.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.topChart.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.topChart.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.topChart.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.topChart.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.topChart.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.topChart.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.topChart.Axes.DepthTop.Title.Brush.Solid = true;
            this.topChart.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.topChart.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.topChart.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.topChart.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.topChart.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.topChart.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.topChart.Axes.DepthTop.Title.Font.Size = 11;
            this.topChart.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.topChart.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.topChart.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.topChart.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.topChart.Axes.Left.Automatic = false;
            this.topChart.Axes.Left.AutomaticMaximum = false;
            this.topChart.Axes.Left.AutomaticMinimum = false;
            // 
            // 
            // 
            this.topChart.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.topChart.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.topChart.Axes.Left.Labels.Brush.Solid = true;
            this.topChart.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.topChart.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.topChart.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.topChart.Axes.Left.Labels.Font.Brush.Solid = true;
            this.topChart.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.topChart.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.topChart.Axes.Left.Labels.Font.Size = 9;
            this.topChart.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.topChart.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.topChart.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.topChart.Axes.Left.Labels.Shadow.Brush.Visible = true;
            this.topChart.Axes.Left.Labels.ValueFormat = "#,##0.####";
            this.topChart.Axes.Left.Maximum = 636.3D;
            this.topChart.Axes.Left.MaximumOffset = 1;
            this.topChart.Axes.Left.Minimum = 176.7D;
            this.topChart.Axes.Left.MinimumOffset = 1;
            // 
            // 
            // 
            this.topChart.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.topChart.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.topChart.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.topChart.Axes.Left.Title.Brush.Solid = true;
            this.topChart.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.topChart.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.topChart.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.topChart.Axes.Left.Title.Font.Brush.Solid = true;
            this.topChart.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.topChart.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.topChart.Axes.Left.Title.Font.Size = 11;
            this.topChart.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.topChart.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.topChart.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.topChart.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.topChart.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.topChart.Axes.Right.Labels.Brush.Solid = true;
            this.topChart.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.topChart.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.topChart.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.topChart.Axes.Right.Labels.Font.Brush.Solid = true;
            this.topChart.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.topChart.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.topChart.Axes.Right.Labels.Font.Size = 9;
            this.topChart.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.topChart.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.topChart.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.topChart.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.topChart.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.topChart.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.topChart.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.topChart.Axes.Right.Title.Brush.Solid = true;
            this.topChart.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.topChart.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.topChart.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.topChart.Axes.Right.Title.Font.Brush.Solid = true;
            this.topChart.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.topChart.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.topChart.Axes.Right.Title.Font.Size = 11;
            this.topChart.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.topChart.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.topChart.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.topChart.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.topChart.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.topChart.Axes.Top.Labels.Brush.Solid = true;
            this.topChart.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.topChart.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.topChart.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.topChart.Axes.Top.Labels.Font.Brush.Solid = true;
            this.topChart.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.topChart.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.topChart.Axes.Top.Labels.Font.Size = 9;
            this.topChart.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.topChart.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.topChart.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.topChart.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.topChart.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.topChart.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.topChart.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.topChart.Axes.Top.Title.Brush.Solid = true;
            this.topChart.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.topChart.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.topChart.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.topChart.Axes.Top.Title.Font.Brush.Solid = true;
            this.topChart.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.topChart.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.topChart.Axes.Top.Title.Font.Size = 11;
            this.topChart.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.topChart.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.topChart.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.topChart.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.topChart.Color = System.Drawing.Color.White;
            this.topChart.Cursor = System.Windows.Forms.Cursors.Default;
            this.topChart.Dock = System.Windows.Forms.DockStyle.Top;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.topChart.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.topChart.Footer.Brush.Solid = true;
            this.topChart.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.topChart.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.topChart.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.topChart.Footer.Font.Brush.Solid = true;
            this.topChart.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Footer.Font.Shadow.Brush.Solid = true;
            this.topChart.Footer.Font.Shadow.Brush.Visible = true;
            this.topChart.Footer.Font.Size = 8;
            this.topChart.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.topChart.Footer.ImageBevel.Brush.Solid = true;
            this.topChart.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Footer.Shadow.Brush.Solid = true;
            this.topChart.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.topChart.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.topChart.Header.Brush.Solid = true;
            this.topChart.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.topChart.Header.Font.Bold = false;
            // 
            // 
            // 
            this.topChart.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.topChart.Header.Font.Brush.Solid = true;
            this.topChart.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Header.Font.Shadow.Brush.Solid = true;
            this.topChart.Header.Font.Shadow.Brush.Visible = true;
            this.topChart.Header.Font.Size = 12;
            this.topChart.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.topChart.Header.ImageBevel.Brush.Solid = true;
            this.topChart.Header.ImageBevel.Brush.Visible = true;
            this.topChart.Header.Lines = new string[] {
        "Channel 0"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.topChart.Header.Shadow.Brush.Solid = true;
            this.topChart.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.topChart.Legend.Brush.Color = System.Drawing.Color.White;
            this.topChart.Legend.Brush.Solid = true;
            this.topChart.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.topChart.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.topChart.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.topChart.Legend.Font.Brush.Solid = true;
            this.topChart.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Legend.Font.Shadow.Brush.Solid = true;
            this.topChart.Legend.Font.Shadow.Brush.Visible = true;
            this.topChart.Legend.Font.Size = 9;
            this.topChart.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.topChart.Legend.ImageBevel.Brush.Solid = true;
            this.topChart.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.topChart.Legend.Shadow.Brush.Solid = true;
            this.topChart.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Legend.Symbol.Shadow.Brush.Solid = true;
            this.topChart.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.topChart.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.topChart.Legend.Title.Brush.Solid = true;
            this.topChart.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.topChart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.topChart.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.topChart.Legend.Title.Font.Brush.Solid = true;
            this.topChart.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.topChart.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.topChart.Legend.Title.Font.Size = 8;
            this.topChart.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.topChart.Legend.Title.ImageBevel.Brush.Solid = true;
            this.topChart.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Legend.Title.Shadow.Brush.Solid = true;
            this.topChart.Legend.Title.Shadow.Brush.Visible = true;
            this.topChart.Legend.Visible = false;
            this.topChart.Location = new System.Drawing.Point(0, 0);
            this.topChart.Name = "topChart";
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.topChart.Panel.Brush.Color = System.Drawing.Color.White;
            this.topChart.Panel.Brush.Solid = true;
            this.topChart.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.topChart.Panel.ImageBevel.Brush.Solid = true;
            this.topChart.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Panel.Shadow.Brush.Solid = true;
            this.topChart.Panel.Shadow.Brush.Visible = true;
            this.topChart.Series.Add(this.mtxFastLine1);
            signalTeeItem2.Caption = null;
            signalTeeItem2.Input = null;
            signalTeeItem2.Inputs = this.signalList;
            signalTeeItem2.InputsItemIndex = 0;
            signalTeeItem2.Series = this.mtxFastLine1;
            signalTeeItem2.SeriesName = "mtxFastLine1";
            this.topChart.Signals.Add(signalTeeItem2);
            this.topChart.Size = new System.Drawing.Size(897, 185);
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.topChart.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.topChart.SubFooter.Brush.Solid = true;
            this.topChart.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.topChart.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.topChart.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.topChart.SubFooter.Font.Brush.Solid = true;
            this.topChart.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.SubFooter.Font.Shadow.Brush.Solid = true;
            this.topChart.SubFooter.Font.Shadow.Brush.Visible = true;
            this.topChart.SubFooter.Font.Size = 8;
            this.topChart.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.topChart.SubFooter.ImageBevel.Brush.Solid = true;
            this.topChart.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.SubFooter.Shadow.Brush.Solid = true;
            this.topChart.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.topChart.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.topChart.SubHeader.Brush.Solid = true;
            this.topChart.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.topChart.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.topChart.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.topChart.SubHeader.Font.Brush.Solid = true;
            this.topChart.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.SubHeader.Font.Shadow.Brush.Solid = true;
            this.topChart.SubHeader.Font.Shadow.Brush.Visible = true;
            this.topChart.SubHeader.Font.Size = 12;
            this.topChart.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.topChart.SubHeader.ImageBevel.Brush.Solid = true;
            this.topChart.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.topChart.SubHeader.Shadow.Brush.Solid = true;
            this.topChart.SubHeader.Shadow.Brush.Visible = true;
            this.topChart.TabIndex = 4;
            this.topChart.Tools.Add(this.axisScaleTool1);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.topChart.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.topChart.Walls.Back.Brush.Solid = true;
            this.topChart.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.topChart.Walls.Back.ImageBevel.Brush.Solid = true;
            this.topChart.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Walls.Back.Shadow.Brush.Solid = true;
            this.topChart.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.topChart.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.topChart.Walls.Bottom.Brush.Solid = true;
            this.topChart.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.topChart.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.topChart.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Walls.Bottom.Shadow.Brush.Solid = true;
            this.topChart.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.topChart.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.topChart.Walls.Left.Brush.Solid = true;
            this.topChart.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.topChart.Walls.Left.ImageBevel.Brush.Solid = true;
            this.topChart.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Walls.Left.Shadow.Brush.Solid = true;
            this.topChart.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.topChart.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.topChart.Walls.Right.Brush.Solid = true;
            this.topChart.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.topChart.Walls.Right.ImageBevel.Brush.Solid = true;
            this.topChart.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.topChart.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.topChart.Walls.Right.Shadow.Brush.Solid = true;
            this.topChart.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.topChart.Zoom.Animated = true;
            // 
            // 
            // 
            this.topChart.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.topChart.Zoom.Brush.Solid = true;
            this.topChart.Zoom.Brush.Visible = false;
            this.topChart.Zoom.FullRepaint = true;
            this.topChart.Zoom.Pen.Visible = true;
            // 
            // axisScaleTool1
            // 
            this.axisScaleTool1.Axis = this.topChart.Axes.Left;
            this.axisScaleTool1.AxisScaleMode = Dew.Signal.Tee.AxisScaleMode.amPeakHold;
            this.axisScaleTool1.DataIsSpectrum = false;
            this.axisScaleTool1.LowerMargin = 10;
            this.axisScaleTool1.UpperMargin = 10;
            // 
            // AsioRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 568);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.bottomChart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topChart);
            this.Name = "AsioRecordForm";
            this.Text = "AsioRecordForm";
            this.Load += new System.EventHandler(this.AsioRecordForm_Load);
            this.Resize += new System.EventHandler(this.AsioRecordForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topChart)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Dew.Signal.Tee.SignalChart bottomChart;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox inputChBox;
		private System.Windows.Forms.ListBox outputChBox;
		private System.Windows.Forms.ListBox FSListBox;
		private System.Windows.Forms.ListBox driverNameListBox;
		private System.Windows.Forms.Label label1;
		private Dew.Signal.Tee.SignalChart topChart;
		private System.Windows.Forms.Splitter splitter1;
		private Dew.Signal.TSignalRead signalRead;
		private Dew.Signal.TSignalDemuxList signalDemuxList;
		private Dew.Signal.TSignalRateConverterList signalRateConverterList;
		private Dew.Signal.SignalAsio signalAsio1;
		private Dew.Signal.TSignalList signalList;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private Dew.Signal.TSignalWrite signalWrite1;
		private Dew.Signal.TSignalMux signalMux;
		private System.Windows.Forms.Label label5;
		private Dew.Math.Tee.MtxFastLine mtxFastLine2;
		private Dew.Math.Tee.MtxFastLine mtxFastLine1;
        private Dew.Signal.Tee.AxisScaleTool axisScaleTool2;
        private Dew.Signal.Tee.AxisScaleTool axisScaleTool1;
	}
}