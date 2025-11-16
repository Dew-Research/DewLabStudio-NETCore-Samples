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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
            Dew.Signal.Tee.SignalTeeItem signalTeeItem1 = new Dew.Signal.Tee.SignalTeeItem();
            signal1 = new Dew.Signal.TSignal(components);
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            panel1 = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            threadedBox = new System.Windows.Forms.CheckBox();
            positionPanel1 = new Dew.Math.Controls.PositionPanel();
            label1 = new System.Windows.Forms.Label();
            channelBox = new System.Windows.Forms.ComboBox();
            openFileButton = new System.Windows.Forms.Button();
            signalBrowse1 = new Dew.Signal.TSignalBrowse(components);
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            signalChart1 = new Dew.Signal.Tee.SignalChart();
            ChartEditor = new Steema.TeeChart.Editor(components);
            progressDialog = new Dew.Math.Controls.TMtxProgressDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signalChart1).BeginInit();
            SuspendLayout();
            // 
            // signal1
            // 
            signal1.ChannelCount = 1;
            signal1.Complex = false;
            signal1.DataSerialization = "AAAAAAAAQEEAAAAAAACAPwAAAAAAgB9EAAAAQQAAAAAAE3pHAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            signal1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            signal1.FloatPrecisionLock = false;
            signal1.IsDouble = true;
            signal1.Length = 12;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            richTextBox1.Location = new System.Drawing.Point(0, 0);
            richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(1154, 110);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(threadedBox);
            panel1.Controls.Add(positionPanel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(channelBox);
            panel1.Controls.Add(openFileButton);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 751);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1154, 66);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(16, 25);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(88, 27);
            button1.TabIndex = 5;
            button1.Text = "Chart...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // threadedBox
            // 
            threadedBox.AutoSize = true;
            threadedBox.Location = new System.Drawing.Point(803, 30);
            threadedBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            threadedBox.Name = "threadedBox";
            threadedBox.Size = new System.Drawing.Size(75, 19);
            threadedBox.TabIndex = 4;
            threadedBox.Text = "Threaded";
            threadedBox.UseVisualStyleBackColor = true;
            // 
            // positionPanel1
            // 
            positionPanel1.Location = new System.Drawing.Point(547, 31);
            positionPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            positionPanel1.Name = "positionPanel1";
            positionPanel1.Size = new System.Drawing.Size(233, 21);
            positionPanel1.SliderColor = System.Drawing.Color.Navy;
            positionPanel1.SliderMax = 100D;
            positionPanel1.SliderMin = 0D;
            positionPanel1.SliderPosition = 0D;
            positionPanel1.SliderSpan = 100D;
            positionPanel1.SliderSpanMin = 0;
            positionPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(331, 31);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Channel:";
            // 
            // channelBox
            // 
            channelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            channelBox.FormattingEnabled = true;
            channelBox.Items.AddRange(new object[] { "Left", "Right" });
            channelBox.Location = new System.Drawing.Point(396, 28);
            channelBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            channelBox.Name = "channelBox";
            channelBox.Size = new System.Drawing.Size(92, 23);
            channelBox.TabIndex = 1;
            channelBox.SelectedIndexChanged += channelBox_SelectedIndexChanged;
            // 
            // openFileButton
            // 
            openFileButton.Location = new System.Drawing.Point(111, 25);
            openFileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new System.Drawing.Size(88, 27);
            openFileButton.TabIndex = 0;
            openFileButton.Text = "Open...";
            openFileButton.UseVisualStyleBackColor = true;
            openFileButton.Click += openFileButton_Click;
            // 
            // signalBrowse1
            // 
            signalBrowse1.Complex = false;
            signalBrowse1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            signalBrowse1.FloatPrecisionLock = false;
            signalBrowse1.Increment = 20;
            signalBrowse1.IsDouble = true;
            signalBrowse1.OverviewRepositoryPath = null;
            signalBrowse1.RecordNumber = 0;
            signalBrowse1.SpanLength = 16384L;
            signalBrowse1.SpanLimit = 8192L;
            signalBrowse1.Threaded = false;
            signalBrowse1.OnProgressUpdateEvent += signalBrowse1_OnProgressUpdate;
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "*.wav";
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Uncompressed PCM wav file (*.wav)|*.wav";
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
            signalChart1.Axes.Bottom.Grid.DrawEvery = 1;
            signalChart1.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            signalChart1.Axes.Bottom.Labels.Brush.Solid = true;
            signalChart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            signalChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            signalChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Bottom.Labels.Font.Size = 9;
            signalChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            signalChart1.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            signalChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            signalChart1.Axes.Bottom.Title.Brush.Solid = true;
            signalChart1.Axes.Bottom.Title.Brush.Visible = true;
            signalChart1.Axes.Bottom.Title.Caption = "Time [s]";
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            signalChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            signalChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Bottom.Title.Font.Size = 11;
            signalChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            signalChart1.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            signalChart1.Axes.Bottom.Title.Lines = new string[]
    {
    "Time [s]"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            signalChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            signalChart1.Axes.Depth.Labels.Brush.Solid = true;
            signalChart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            signalChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            signalChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Depth.Labels.Font.Size = 9;
            signalChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            signalChart1.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            signalChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            signalChart1.Axes.Depth.Title.Brush.Solid = true;
            signalChart1.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            signalChart1.Axes.Depth.Title.Font.Brush.Solid = true;
            signalChart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Depth.Title.Font.Size = 11;
            signalChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            signalChart1.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            signalChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            signalChart1.Axes.DepthTop.Labels.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            signalChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.DepthTop.Labels.Font.Size = 9;
            signalChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            signalChart1.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            signalChart1.Axes.DepthTop.Title.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            signalChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.DepthTop.Title.Font.Size = 11;
            signalChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            signalChart1.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            signalChart1.Axes.Left.Labels.Brush.Solid = true;
            signalChart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            signalChart1.Axes.Left.Labels.Font.Brush.Solid = true;
            signalChart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Left.Labels.Font.Size = 9;
            signalChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            signalChart1.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            signalChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            signalChart1.Axes.Left.Title.Brush.Solid = true;
            signalChart1.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            signalChart1.Axes.Left.Title.Font.Brush.Solid = true;
            signalChart1.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Left.Title.Font.Size = 11;
            signalChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            signalChart1.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            signalChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            signalChart1.Axes.Right.Labels.Brush.Solid = true;
            signalChart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            signalChart1.Axes.Right.Labels.Font.Brush.Solid = true;
            signalChart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Right.Labels.Font.Size = 9;
            signalChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            signalChart1.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            signalChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            signalChart1.Axes.Right.Title.Brush.Solid = true;
            signalChart1.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            signalChart1.Axes.Right.Title.Font.Brush.Solid = true;
            signalChart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Right.Title.Font.Size = 11;
            signalChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            signalChart1.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            signalChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            signalChart1.Axes.Top.Labels.Brush.Solid = true;
            signalChart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            signalChart1.Axes.Top.Labels.Font.Brush.Solid = true;
            signalChart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Top.Labels.Font.Size = 9;
            signalChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            signalChart1.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            signalChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            signalChart1.Axes.Top.Title.Brush.Solid = true;
            signalChart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            signalChart1.Axes.Top.Title.Font.Brush.Solid = true;
            signalChart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Top.Title.Font.Size = 11;
            signalChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            signalChart1.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            signalChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            signalChart1.BackColor = System.Drawing.Color.Transparent;
            signalChart1.Color = System.Drawing.Color.FromArgb(0, 240, 240, 240);
            signalChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Footer.Brush.Color = System.Drawing.Color.Silver;
            signalChart1.Footer.Brush.Solid = true;
            signalChart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            signalChart1.Footer.Font.Brush.Solid = true;
            signalChart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Footer.Font.Shadow.Brush.Solid = true;
            signalChart1.Footer.Font.Shadow.Brush.Visible = true;
            signalChart1.Footer.Font.Size = 8;
            signalChart1.Footer.Font.SizeFloat = 8F;
            signalChart1.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Footer.ImageBevel.Brush.Solid = true;
            signalChart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Footer.Shadow.Brush.Solid = true;
            signalChart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(192, 192, 192);
            signalChart1.Header.Brush.Solid = true;
            signalChart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Header.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            signalChart1.Header.Font.Brush.Solid = true;
            signalChart1.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Header.Font.Shadow.Brush.Solid = true;
            signalChart1.Header.Font.Shadow.Brush.Visible = true;
            signalChart1.Header.Font.Size = 12;
            signalChart1.Header.Font.SizeFloat = 12F;
            signalChart1.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Header.ImageBevel.Brush.Solid = true;
            signalChart1.Header.ImageBevel.Brush.Visible = true;
            signalChart1.Header.Lines = new string[]
    {
    "Time signal"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(169, 169, 169);
            signalChart1.Header.Shadow.Brush.Solid = true;
            signalChart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.Brush.Color = System.Drawing.Color.White;
            signalChart1.Legend.Brush.Solid = true;
            signalChart1.Legend.Brush.Visible = true;
            signalChart1.Legend.CheckBoxes = false;
            // 
            // 
            // 
            signalChart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            signalChart1.Legend.Font.Brush.Solid = true;
            signalChart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Legend.Font.Shadow.Brush.Solid = true;
            signalChart1.Legend.Font.Shadow.Brush.Visible = true;
            signalChart1.Legend.Font.Size = 9;
            signalChart1.Legend.Font.SizeFloat = 9F;
            signalChart1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Legend.ImageBevel.Brush.Solid = true;
            signalChart1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(0, 0, 0);
            signalChart1.Legend.Shadow.Brush.Solid = true;
            signalChart1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Legend.Symbol.Shadow.Brush.Solid = true;
            signalChart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.Title.Brush.Color = System.Drawing.Color.White;
            signalChart1.Legend.Title.Brush.Solid = true;
            signalChart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            signalChart1.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            signalChart1.Legend.Title.Font.Brush.Solid = true;
            signalChart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            signalChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            signalChart1.Legend.Title.Font.Size = 8;
            signalChart1.Legend.Title.Font.SizeFloat = 8F;
            signalChart1.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Legend.Title.ImageBevel.Brush.Solid = true;
            signalChart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Legend.Title.Shadow.Brush.Solid = true;
            signalChart1.Legend.Title.Shadow.Brush.Visible = true;
            signalChart1.Legend.Visible = false;
            signalChart1.Location = new System.Drawing.Point(0, 110);
            signalChart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            signalChart1.Name = "signalChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(0, 240, 240, 240);
            // 
            // 
            // 
            signalChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(128, 128, 255);
            signalChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(255, 255, 255);
            // 
            // 
            // 
            signalChart1.Panel.Brush.Gradient.Style.Visible = true;
            signalChart1.Panel.Brush.Gradient.UseMiddle = false;
            signalChart1.Panel.Brush.Solid = true;
            signalChart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Panel.ImageBevel.Brush.Solid = true;
            signalChart1.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Panel.Shadow.Brush.Solid = true;
            signalChart1.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            signalChart1.Printer.Margins = margins1;
            signalTeeItem1.Caption = null;
            signalTeeItem1.Input = null;
            signalTeeItem1.Inputs = null;
            signalTeeItem1.InputsItemIndex = 0;
            signalTeeItem1.Series = null;
            signalTeeItem1.SeriesName = "high-Low1";
            signalChart1.Signals.Add(signalTeeItem1);
            signalChart1.Size = new System.Drawing.Size(1154, 641);
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            signalChart1.SubFooter.Brush.Solid = true;
            signalChart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            signalChart1.SubFooter.Font.Brush.Solid = true;
            signalChart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.SubFooter.Font.Shadow.Brush.Solid = true;
            signalChart1.SubFooter.Font.Shadow.Brush.Visible = true;
            signalChart1.SubFooter.Font.Size = 8;
            signalChart1.SubFooter.Font.SizeFloat = 8F;
            signalChart1.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.SubFooter.ImageBevel.Brush.Solid = true;
            signalChart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.SubFooter.Shadow.Brush.Solid = true;
            signalChart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(192, 192, 192);
            signalChart1.SubHeader.Brush.Solid = true;
            signalChart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            signalChart1.SubHeader.Font.Brush.Solid = true;
            signalChart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.SubHeader.Font.Shadow.Brush.Solid = true;
            signalChart1.SubHeader.Font.Shadow.Brush.Visible = true;
            signalChart1.SubHeader.Font.Size = 12;
            signalChart1.SubHeader.Font.SizeFloat = 12F;
            signalChart1.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.SubHeader.ImageBevel.Brush.Solid = true;
            signalChart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(169, 169, 169);
            signalChart1.SubHeader.Shadow.Brush.Solid = true;
            signalChart1.SubHeader.Shadow.Brush.Visible = true;
            signalChart1.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            signalChart1.Walls.Back.Brush.Solid = true;
            signalChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Walls.Back.ImageBevel.Brush.Solid = true;
            signalChart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Walls.Back.Shadow.Brush.Solid = true;
            signalChart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            signalChart1.Walls.Bottom.Brush.Solid = true;
            signalChart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            signalChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Walls.Bottom.Shadow.Brush.Solid = true;
            signalChart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            signalChart1.Walls.Left.Brush.Solid = true;
            signalChart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Walls.Left.ImageBevel.Brush.Solid = true;
            signalChart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Walls.Left.Shadow.Brush.Solid = true;
            signalChart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            signalChart1.Walls.Right.Brush.Solid = true;
            signalChart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Walls.Right.ImageBevel.Brush.Solid = true;
            signalChart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Walls.Right.Shadow.Brush.Solid = true;
            signalChart1.Walls.Right.Shadow.Brush.Visible = true;
            signalChart1.Walls.Visible = false;
            // 
            // 
            // 
            signalChart1.Zoom.Animated = true;
            // 
            // 
            // 
            signalChart1.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            signalChart1.Zoom.Brush.Solid = true;
            signalChart1.Zoom.Brush.Visible = false;
            signalChart1.Zoom.History = true;
            signalChart1.Scroll += signalChart1_Scroll;
            signalChart1.Zoomed += signalChart1_Zoomed;
            signalChart1.UndoneZoom += signalChart1_UndoneZoom;
            signalChart1.Click += signalChart1_Click;
            // 
            // ChartEditor
            // 
            ChartEditor.AlwaysShowFuncSrc = false;
            ChartEditor.Chart = signalChart1;
            ChartEditor.HighLightTabs = false;
            ChartEditor.Location = new System.Drawing.Point(0, 0);
            ChartEditor.Name = "ChartEditor";
            ChartEditor.Options = null;
            ChartEditor.TabIndex = 0;
            // 
            // progressDialog
            // 
            progressDialog.UpdateInterval = 40;
            // 
            // BrowseDemoForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1154, 817);
            Controls.Add(signalChart1);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "BrowseDemoForm";
            Text = "BrowseDemoForm";
            Load += BrowseDemoForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)signalChart1).EndInit();
            ResumeLayout(false);

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
        private Dew.Math.Controls.TMtxProgressDialog progressDialog;
    }
}