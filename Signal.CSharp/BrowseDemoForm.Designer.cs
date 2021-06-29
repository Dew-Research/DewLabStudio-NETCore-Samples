namespace DSPDemo {
	partial class BrowseDemoForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseDemoForm));
            Dew.Signal.Tee.SignalTeeItem signalTeeItem1 = new Dew.Signal.Tee.SignalTeeItem();
            this.signal1 = new Dew.Signal.TSignal(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.threadedBox = new System.Windows.Forms.CheckBox();
            this.positionPanel1 = new Dew.Math.Controls.PositionPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.channelBox = new System.Windows.Forms.ComboBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.signalBrowse1 = new Dew.Signal.TSignalBrowse(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.signalChart1 = new Dew.Signal.Tee.SignalChart();
            this.ChartEditor = new Steema.TeeChart.Editor(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signalChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // signal1
            // 
            this.signal1.BandwidthL = 0D;
            this.signal1.BlockAssign = false;
            this.signal1.ChannelCount = 1;
            this.signal1.Complex = false;
            this.signal1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.signal1.FloatPrecisionLock = false;
            this.signal1.Input = null;
            this.signal1.IsDouble = true;
            this.signal1.Length = 128;
            this.signal1.Name = null;
            this.signal1.OnAfterUpdate = null;
            this.signal1.OnBeforeUpdate = null;
            this.signal1.OnDisplayUpdate = null;
            this.signal1.OnGetInput = null;
            this.signal1.OnNotifyUpdate = null;
            this.signal1.OnParameterUpdate = null;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(934, 110);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.threadedBox);
            this.panel1.Controls.Add(this.positionPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.channelBox);
            this.panel1.Controls.Add(this.openFileButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 537);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 66);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Chart...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // threadedBox
            // 
            this.threadedBox.AutoSize = true;
            this.threadedBox.Location = new System.Drawing.Point(803, 30);
            this.threadedBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.threadedBox.Name = "threadedBox";
            this.threadedBox.Size = new System.Drawing.Size(75, 19);
            this.threadedBox.TabIndex = 4;
            this.threadedBox.Text = "Threaded";
            this.threadedBox.UseVisualStyleBackColor = true;
            // 
            // positionPanel1
            // 
            this.positionPanel1.Location = new System.Drawing.Point(547, 31);
            this.positionPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.positionPanel1.Name = "positionPanel1";
            this.positionPanel1.Size = new System.Drawing.Size(233, 21);
            this.positionPanel1.SliderColor = System.Drawing.Color.Navy;
            this.positionPanel1.SliderMax = 100D;
            this.positionPanel1.SliderMin = 0D;
            this.positionPanel1.SliderPosition = 0D;
            this.positionPanel1.SliderSpan = 100D;
            this.positionPanel1.SliderSpanMin = 0;
            this.positionPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Channel:";
            // 
            // channelBox
            // 
            this.channelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.channelBox.FormattingEnabled = true;
            this.channelBox.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.channelBox.Location = new System.Drawing.Point(396, 28);
            this.channelBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.channelBox.Name = "channelBox";
            this.channelBox.Size = new System.Drawing.Size(92, 23);
            this.channelBox.TabIndex = 1;
            this.channelBox.SelectedIndexChanged += new System.EventHandler(this.channelBox_SelectedIndexChanged);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(111, 25);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(88, 27);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Open...";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // signalBrowse1
            // 
            this.signalBrowse1.BlockAssign = false;
            this.signalBrowse1.Complex = false;
            this.signalBrowse1.Data = ((Dew.Math.TVec)(resources.GetObject("signalBrowse1.Data")));
            this.signalBrowse1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.signalBrowse1.FloatPrecisionLock = false;
            this.signalBrowse1.Increment = 20;
            this.signalBrowse1.Input = null;
            this.signalBrowse1.IsDouble = true;
            this.signalBrowse1.Name = null;
            this.signalBrowse1.OnAfterUpdate = null;
            this.signalBrowse1.OnBeforeUpdate = null;
            this.signalBrowse1.OnDisplayUpdate = null; 
            this.signalBrowse1.OnGetInput = null;
            this.signalBrowse1.OnNotifyUpdate = null;
            this.signalBrowse1.OnParameterUpdate = null;
            this.signalBrowse1.OnProgressUpdate = null;
            this.signalBrowse1.OverviewRepositoryPath = null;
            this.signalBrowse1.RecordNumber = 0;
            this.signalBrowse1.RecordPosition = 0;
            this.signalBrowse1.RecordTimePosition = 0D;
            this.signalBrowse1.SpanLength = ((long)(16384));
            this.signalBrowse1.SpanLimit = ((long)(8192));
            this.signalBrowse1.Threaded = false;
            this.signalBrowse1.UpdateInProgress = false;
            this.signalBrowse1.OnProgressUpdateEvent += new Dew.Math.Controls.UpdateEventHandler(this.signalBrowse1_OnProgressUpdateEvent);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.wav";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Uncompressed PCM wav file (*.wav)|*.wav";
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
            this.signalChart1.Axes.Bottom.Grid.DrawEvery = 1;
            this.signalChart1.Axes.Bottom.Grid.Visible = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Labels.Axis = this.signalChart1.Axes.Bottom;
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
            this.signalChart1.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.signalChart1.Axes.Bottom.MinorTicks.Length = 2;
            this.signalChart1.Axes.Bottom.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.Ticks.Length = 4;
            this.signalChart1.Axes.Bottom.Ticks.Visible = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Bottom.TicksInner.Length = 0;
            this.signalChart1.Axes.Bottom.TicksInner.Visible = false;
            // 
            // 
            // 
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
            this.signalChart1.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.signalChart1.Axes.Depth.AxisPen.Visible = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Labels.Axis = this.signalChart1.Axes.Depth;
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
            this.signalChart1.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.signalChart1.Axes.Depth.MinorTicks.Length = 2;
            this.signalChart1.Axes.Depth.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.Ticks.Length = 4;
            this.signalChart1.Axes.Depth.Ticks.Visible = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Depth.TicksInner.Length = 0;
            this.signalChart1.Axes.Depth.TicksInner.Visible = false;
            // 
            // 
            // 
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
            this.signalChart1.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.signalChart1.Axes.DepthTop.AxisPen.Visible = false;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Labels.Axis = this.signalChart1.Axes.DepthTop;
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
            this.signalChart1.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.signalChart1.Axes.DepthTop.MinorTicks.Length = 2;
            this.signalChart1.Axes.DepthTop.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.Ticks.Length = 4;
            this.signalChart1.Axes.DepthTop.Ticks.Visible = false;
            // 
            // 
            // 
            this.signalChart1.Axes.DepthTop.TicksInner.Length = 0;
            this.signalChart1.Axes.DepthTop.TicksInner.Visible = false;
            // 
            // 
            // 
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
            this.signalChart1.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.signalChart1.Axes.Left.AxisPen.Visible = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Labels.Axis = this.signalChart1.Axes.Left;
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
            this.signalChart1.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.signalChart1.Axes.Left.MinorTicks.Length = 2;
            this.signalChart1.Axes.Left.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.Ticks.Length = 4;
            this.signalChart1.Axes.Left.Ticks.Visible = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Left.TicksInner.Length = 0;
            this.signalChart1.Axes.Left.TicksInner.Visible = false;
            // 
            // 
            // 
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
            this.signalChart1.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.signalChart1.Axes.Right.AxisPen.Visible = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Labels.Axis = this.signalChart1.Axes.Right;
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
            this.signalChart1.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.signalChart1.Axes.Right.MinorTicks.Length = 2;
            this.signalChart1.Axes.Right.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.Ticks.Length = 4;
            this.signalChart1.Axes.Right.Ticks.Visible = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Right.TicksInner.Length = 0;
            this.signalChart1.Axes.Right.TicksInner.Visible = false;
            // 
            // 
            // 
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
            this.signalChart1.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.signalChart1.Axes.Top.Labels.Axis = this.signalChart1.Axes.Top;
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
            this.signalChart1.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.signalChart1.Axes.Top.MinorTicks.Length = 2;
            this.signalChart1.Axes.Top.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.Ticks.Length = 4;
            this.signalChart1.Axes.Top.Ticks.Visible = false;
            // 
            // 
            // 
            this.signalChart1.Axes.Top.TicksInner.Length = 0;
            this.signalChart1.Axes.Top.TicksInner.Visible = false;
            // 
            // 
            // 
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
            this.signalChart1.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.signalChart1.BackColor = System.Drawing.Color.Transparent;
            this.signalChart1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.signalChart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.signalChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
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
            this.signalChart1.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.signalChart1.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
        "Time signal"};
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
            this.signalChart1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.signalChart1.Legend.Pen.Visible = false;
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
            this.signalChart1.Legend.Symbol.Legend = this.signalChart1.Legend;
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
            this.signalChart1.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
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
            this.signalChart1.Legend.Title.Pen.Visible = false;
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
            this.signalChart1.Location = new System.Drawing.Point(0, 110);
            this.signalChart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.signalChart1.Name = "signalChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            // 
            // 
            // 
            this.signalChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.signalChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.signalChart1.Panel.Brush.Gradient.Style.Visible = true;
            this.signalChart1.Panel.Brush.Gradient.UseMiddle = true;
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
            this.signalChart1.Panel.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart1.Panel.Shadow.Brush.Solid = true;
            this.signalChart1.Panel.Shadow.Brush.Visible = true;
            signalTeeItem1.Caption = null;
            signalTeeItem1.Input = null;
            signalTeeItem1.Inputs = null;
            signalTeeItem1.InputsItemIndex = 0;
            signalTeeItem1.Series = null;
            signalTeeItem1.SeriesName = "high-Low1";
            this.signalChart1.Signals.Add(signalTeeItem1);
            this.signalChart1.Size = new System.Drawing.Size(934, 427);
            // 
            // 
            // 
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
            this.signalChart1.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.signalChart1.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.signalChart1.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
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
            this.signalChart1.Walls.Visible = false;
            // 
            // 
            // 
            this.signalChart1.Zoom.Animated = true;
            // 
            // 
            // 
            this.signalChart1.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.signalChart1.Zoom.Brush.Solid = true;
            this.signalChart1.Zoom.Brush.Visible = false;
            this.signalChart1.Zoom.FullRepaint = true;
            this.signalChart1.Zoom.History = true;
            // 
            // 
            // 
            this.signalChart1.Zoom.Pen.Visible = true;
            this.signalChart1.Scroll += new System.EventHandler(this.signalChart1_Scroll);
            this.signalChart1.Zoomed += new System.EventHandler(this.signalChart1_Zoomed);
            this.signalChart1.UndoneZoom += new System.EventHandler(this.signalChart1_UndoneZoom);
            this.signalChart1.Click += new System.EventHandler(this.signalChart1_Click);
            // 
            // ChartEditor
            // 
            this.ChartEditor.AlwaysShowFuncSrc = false;
            this.ChartEditor.Chart = this.signalChart1;
            this.ChartEditor.HighLightTabs = false;
            this.ChartEditor.Location = new System.Drawing.Point(0, 0);
            this.ChartEditor.Name = "ChartEditor";
            this.ChartEditor.Options = null;
            this.ChartEditor.TabIndex = 0;
            // 
            // BrowseDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 603);
            this.Controls.Add(this.signalChart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BrowseDemoForm";
            this.Text = "BrowseDemoForm";
            this.Load += new System.EventHandler(this.BrowseDemoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signalChart1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private Dew.Signal.Tee.SignalChart signalChart1;
		private Dew.Signal.TSignal signal1;
		private Dew.Signal.TSignalBrowse signalBrowse1;
		private System.Windows.Forms.Button openFileButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ComboBox channelBox;
		private System.Windows.Forms.CheckBox threadedBox;
		private Dew.Math.Controls.PositionPanel positionPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Editor ChartEditor;
	}
}