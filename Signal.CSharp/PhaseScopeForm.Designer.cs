namespace DSPDemo {
	partial class PhaseScopeForm {
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
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhaseScopeForm));
            Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
            Steema.TeeChart.Margins margins2 = new Steema.TeeChart.Margins();
            Steema.TeeChart.Margins margins3 = new Steema.TeeChart.Margins();
            Dew.Signal.Tee.SignalTeeItem signalTeeItem1 = new Dew.Signal.Tee.SignalTeeItem();
            Signal1 = new Dew.Signal.TSignal(components);
            fastLine1 = new Steema.TeeChart.Styles.FastLine();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            panel1 = new System.Windows.Forms.Panel();
            channelBox = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            splitter1 = new System.Windows.Forms.Splitter();
            panel3 = new System.Windows.Forms.Panel();
            rightPhaseChart = new Steema.TeeChart.TChart();
            polar2 = new Steema.TeeChart.Styles.Polar();
            splitter2 = new System.Windows.Forms.Splitter();
            leftPhaseChart = new Steema.TeeChart.TChart();
            polar1 = new Steema.TeeChart.Styles.Polar();
            signalChart1 = new Dew.Signal.Tee.SignalChart();
            chartEditor = new Steema.TeeChart.Editor(components);
            Signal2 = new Dew.Signal.TSignal(components);
            SignalIn1 = new Dew.Signal.Audio.SignalIn(components);
            SignalTimer1 = new Dew.Signal.Audio.SignalTimer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signalChart1).BeginInit();
            SuspendLayout();
            // 
            // Signal1
            // 
            Signal1.ChannelCount = 1;
            Signal1.Complex = false;
            Signal1.DataSerialization = "AAAAAAAAQEEAAAAAAACAPwAAAAAAgB9EAAAAQQAAAAAAE3pHAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            Signal1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            Signal1.FloatPrecisionLock = false;
            Signal1.IsDouble = true;
            Signal1.Length = 12;
            // 
            // fastLine1
            // 
            // 
            // 
            // 
            fastLine1.Brush.Color = System.Drawing.Color.Empty;
            fastLine1.Brush.Solid = true;
            fastLine1.Brush.Visible = true;
            fastLine1.Color = System.Drawing.Color.FromArgb(68, 102, 163);
            fastLine1.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine1.Legend.Brush.Color = System.Drawing.Color.White;
            fastLine1.Legend.Brush.Solid = true;
            fastLine1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            fastLine1.Legend.Font.Bold = false;
            // 
            // 
            // 
            fastLine1.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            fastLine1.Legend.Font.Brush.Solid = true;
            fastLine1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            fastLine1.Legend.Font.Shadow.Brush.Solid = true;
            fastLine1.Legend.Font.Shadow.Brush.Visible = true;
            fastLine1.Legend.Font.Size = 8;
            fastLine1.Legend.Font.SizeFloat = 8F;
            fastLine1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            fastLine1.Legend.ImageBevel.Brush.Solid = true;
            fastLine1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            fastLine1.Legend.Shadow.Brush.Solid = true;
            fastLine1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine1.Marks.Brush.Color = System.Drawing.Color.FromArgb(255, 255, 255);
            fastLine1.Marks.Brush.Solid = true;
            fastLine1.Marks.Brush.Visible = true;
            // 
            // 
            // 
            fastLine1.Marks.Font.Bold = false;
            // 
            // 
            // 
            fastLine1.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            fastLine1.Marks.Font.Brush.Solid = true;
            fastLine1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine1.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            fastLine1.Marks.Font.Shadow.Brush.Solid = true;
            fastLine1.Marks.Font.Shadow.Brush.Visible = true;
            fastLine1.Marks.Font.Size = 8;
            fastLine1.Marks.Font.SizeFloat = 8F;
            fastLine1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine1.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            fastLine1.Marks.ImageBevel.Brush.Solid = true;
            fastLine1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine1.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            fastLine1.Marks.Shadow.Brush.Solid = true;
            fastLine1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine1.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            fastLine1.Marks.Symbol.Brush.Solid = true;
            fastLine1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine1.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            fastLine1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            fastLine1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine1.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            fastLine1.Marks.Symbol.Shadow.Brush.Solid = true;
            fastLine1.Marks.Symbol.Shadow.Brush.Visible = true;
            fastLine1.Title = "fastLine1";
            fastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            // 
            // 
            // 
            fastLine1.XValues.DataMember = "X";
            fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            fastLine1.XValues.Value = new double[]
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
            fastLine1.YValues.DataMember = "Y";
            fastLine1.YValues.Value = new double[]
    {
    473D,
    467D,
    548D,
    456D,
    489D,
    519D,
    446D,
    545D,
    434D,
    470D,
    557D,
    635D,
    738D,
    705D,
    638D,
    693D,
    618D,
    500D,
    540D,
    417D,
    494D,
    408D,
    363D,
    342D,
    260D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // richTextBox1
            // 
            richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            richTextBox1.Location = new System.Drawing.Point(0, 0);
            richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(1131, 110);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(channelBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 737);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1131, 63);
            panel1.TabIndex = 1;
            // 
            // channelBox
            // 
            channelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            channelBox.FormattingEnabled = true;
            channelBox.Items.AddRange(new object[] { "Left", "Right" });
            channelBox.Location = new System.Drawing.Point(209, 25);
            channelBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            channelBox.Name = "channelBox";
            channelBox.Size = new System.Drawing.Size(115, 23);
            channelBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(145, 29);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Channel:";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(14, 23);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(88, 27);
            button1.TabIndex = 0;
            button1.Text = "Chart";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(splitter1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(signalChart1);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 110);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1131, 627);
            panel2.TabIndex = 2;
            panel2.Resize += panel2_Resize;
            // 
            // splitter1
            // 
            splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            splitter1.Location = new System.Drawing.Point(0, 438);
            splitter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new System.Drawing.Size(1131, 3);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(rightPhaseChart);
            panel3.Controls.Add(splitter2);
            panel3.Controls.Add(leftPhaseChart);
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(0, 0);
            panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1131, 441);
            panel3.TabIndex = 1;
            // 
            // rightPhaseChart
            // 
            // 
            // 
            // 
            rightPhaseChart.Aspect.Elevation = 315;
            rightPhaseChart.Aspect.ElevationFloat = 315D;
            rightPhaseChart.Aspect.Orthogonal = false;
            rightPhaseChart.Aspect.Perspective = 0;
            rightPhaseChart.Aspect.Rotation = 360;
            rightPhaseChart.Aspect.RotationFloat = 360D;
            // 
            // 
            // 
            rightPhaseChart.Axes.Automatic = false;
            // 
            // 
            // 
            rightPhaseChart.Axes.Bottom.Automatic = false;
            rightPhaseChart.Axes.Bottom.AutomaticMaximum = false;
            rightPhaseChart.Axes.Bottom.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            rightPhaseChart.Axes.Bottom.Labels.Brush.Solid = true;
            rightPhaseChart.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            rightPhaseChart.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            rightPhaseChart.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            rightPhaseChart.Axes.Bottom.Labels.Font.Brush.Solid = true;
            rightPhaseChart.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            rightPhaseChart.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            rightPhaseChart.Axes.Bottom.Labels.Font.Size = 9;
            rightPhaseChart.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            rightPhaseChart.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            rightPhaseChart.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            rightPhaseChart.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            rightPhaseChart.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            rightPhaseChart.Axes.Bottom.Maximum = 0D;
            rightPhaseChart.Axes.Bottom.Minimum = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            rightPhaseChart.Axes.Bottom.Title.Brush.Solid = true;
            rightPhaseChart.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            rightPhaseChart.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            rightPhaseChart.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            rightPhaseChart.Axes.Bottom.Title.Font.Brush.Solid = true;
            rightPhaseChart.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            rightPhaseChart.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            rightPhaseChart.Axes.Bottom.Title.Font.Size = 11;
            rightPhaseChart.Axes.Bottom.Title.Font.SizeFloat = 11F;
            rightPhaseChart.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            rightPhaseChart.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            rightPhaseChart.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            rightPhaseChart.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            rightPhaseChart.Axes.Depth.Automatic = false;
            rightPhaseChart.Axes.Depth.AutomaticMaximum = false;
            rightPhaseChart.Axes.Depth.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            rightPhaseChart.Axes.Depth.Labels.Brush.Solid = true;
            rightPhaseChart.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            rightPhaseChart.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            rightPhaseChart.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            rightPhaseChart.Axes.Depth.Labels.Font.Brush.Solid = true;
            rightPhaseChart.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            rightPhaseChart.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            rightPhaseChart.Axes.Depth.Labels.Font.Size = 9;
            rightPhaseChart.Axes.Depth.Labels.Font.SizeFloat = 9F;
            rightPhaseChart.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            rightPhaseChart.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            rightPhaseChart.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            rightPhaseChart.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            rightPhaseChart.Axes.Depth.Maximum = 0D;
            rightPhaseChart.Axes.Depth.Minimum = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            rightPhaseChart.Axes.Depth.Title.Brush.Solid = true;
            rightPhaseChart.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            rightPhaseChart.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            rightPhaseChart.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            rightPhaseChart.Axes.Depth.Title.Font.Brush.Solid = true;
            rightPhaseChart.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            rightPhaseChart.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            rightPhaseChart.Axes.Depth.Title.Font.Size = 11;
            rightPhaseChart.Axes.Depth.Title.Font.SizeFloat = 11F;
            rightPhaseChart.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            rightPhaseChart.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            rightPhaseChart.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Axes.Depth.Title.Shadow.Brush.Solid = true;
            rightPhaseChart.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            rightPhaseChart.Axes.DepthTop.Automatic = false;
            rightPhaseChart.Axes.DepthTop.AutomaticMaximum = false;
            rightPhaseChart.Axes.DepthTop.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            rightPhaseChart.Axes.DepthTop.Labels.Brush.Solid = true;
            rightPhaseChart.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            rightPhaseChart.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            rightPhaseChart.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            rightPhaseChart.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            rightPhaseChart.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            rightPhaseChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            rightPhaseChart.Axes.DepthTop.Labels.Font.Size = 9;
            rightPhaseChart.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            rightPhaseChart.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            rightPhaseChart.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            rightPhaseChart.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            rightPhaseChart.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            rightPhaseChart.Axes.DepthTop.Maximum = 0D;
            rightPhaseChart.Axes.DepthTop.Minimum = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            rightPhaseChart.Axes.DepthTop.Title.Brush.Solid = true;
            rightPhaseChart.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            rightPhaseChart.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            rightPhaseChart.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            rightPhaseChart.Axes.DepthTop.Title.Font.Brush.Solid = true;
            rightPhaseChart.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            rightPhaseChart.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            rightPhaseChart.Axes.DepthTop.Title.Font.Size = 11;
            rightPhaseChart.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            rightPhaseChart.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            rightPhaseChart.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            rightPhaseChart.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            rightPhaseChart.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            rightPhaseChart.Axes.Left.Automatic = false;
            rightPhaseChart.Axes.Left.AutomaticMaximum = false;
            rightPhaseChart.Axes.Left.AutomaticMinimum = false;
            // 
            // 
            // 
            rightPhaseChart.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            rightPhaseChart.Axes.Left.Labels.Brush.Solid = true;
            rightPhaseChart.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            rightPhaseChart.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            rightPhaseChart.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            rightPhaseChart.Axes.Left.Labels.Font.Brush.Solid = true;
            rightPhaseChart.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            rightPhaseChart.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            rightPhaseChart.Axes.Left.Labels.Font.Size = 9;
            rightPhaseChart.Axes.Left.Labels.Font.SizeFloat = 9F;
            rightPhaseChart.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            rightPhaseChart.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            rightPhaseChart.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Axes.Left.Labels.Shadow.Brush.Solid = true;
            rightPhaseChart.Axes.Left.Labels.Shadow.Brush.Visible = true;
            rightPhaseChart.Axes.Left.Maximum = 1D;
            rightPhaseChart.Axes.Left.Minimum = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            rightPhaseChart.Axes.Left.Title.Brush.Solid = true;
            rightPhaseChart.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            rightPhaseChart.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            rightPhaseChart.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            rightPhaseChart.Axes.Left.Title.Font.Brush.Solid = true;
            rightPhaseChart.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            rightPhaseChart.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            rightPhaseChart.Axes.Left.Title.Font.Size = 11;
            rightPhaseChart.Axes.Left.Title.Font.SizeFloat = 11F;
            rightPhaseChart.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            rightPhaseChart.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            rightPhaseChart.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Axes.Left.Title.Shadow.Brush.Solid = true;
            rightPhaseChart.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            rightPhaseChart.Axes.Right.Automatic = false;
            rightPhaseChart.Axes.Right.AutomaticMaximum = false;
            rightPhaseChart.Axes.Right.AutomaticMinimum = false;
            // 
            // 
            // 
            rightPhaseChart.Axes.Right.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            rightPhaseChart.Axes.Right.Labels.Brush.Solid = true;
            rightPhaseChart.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            rightPhaseChart.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            rightPhaseChart.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            rightPhaseChart.Axes.Right.Labels.Font.Brush.Solid = true;
            rightPhaseChart.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            rightPhaseChart.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            rightPhaseChart.Axes.Right.Labels.Font.Size = 9;
            rightPhaseChart.Axes.Right.Labels.Font.SizeFloat = 9F;
            rightPhaseChart.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            rightPhaseChart.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            rightPhaseChart.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Axes.Right.Labels.Shadow.Brush.Solid = true;
            rightPhaseChart.Axes.Right.Labels.Shadow.Brush.Visible = true;
            rightPhaseChart.Axes.Right.Maximum = 0D;
            rightPhaseChart.Axes.Right.Minimum = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            rightPhaseChart.Axes.Right.Title.Brush.Solid = true;
            rightPhaseChart.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            rightPhaseChart.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            rightPhaseChart.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            rightPhaseChart.Axes.Right.Title.Font.Brush.Solid = true;
            rightPhaseChart.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            rightPhaseChart.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            rightPhaseChart.Axes.Right.Title.Font.Size = 11;
            rightPhaseChart.Axes.Right.Title.Font.SizeFloat = 11F;
            rightPhaseChart.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            rightPhaseChart.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            rightPhaseChart.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Axes.Right.Title.Shadow.Brush.Solid = true;
            rightPhaseChart.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            rightPhaseChart.Axes.Top.Automatic = false;
            rightPhaseChart.Axes.Top.AutomaticMaximum = false;
            rightPhaseChart.Axes.Top.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            rightPhaseChart.Axes.Top.Labels.Brush.Solid = true;
            rightPhaseChart.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            rightPhaseChart.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            rightPhaseChart.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            rightPhaseChart.Axes.Top.Labels.Font.Brush.Solid = true;
            rightPhaseChart.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            rightPhaseChart.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            rightPhaseChart.Axes.Top.Labels.Font.Size = 9;
            rightPhaseChart.Axes.Top.Labels.Font.SizeFloat = 9F;
            rightPhaseChart.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            rightPhaseChart.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            rightPhaseChart.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Axes.Top.Labels.Shadow.Brush.Solid = true;
            rightPhaseChart.Axes.Top.Labels.Shadow.Brush.Visible = true;
            rightPhaseChart.Axes.Top.Maximum = 0D;
            rightPhaseChart.Axes.Top.Minimum = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            rightPhaseChart.Axes.Top.Title.Brush.Solid = true;
            rightPhaseChart.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            rightPhaseChart.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            rightPhaseChart.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            rightPhaseChart.Axes.Top.Title.Font.Brush.Solid = true;
            rightPhaseChart.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            rightPhaseChart.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            rightPhaseChart.Axes.Top.Title.Font.Size = 11;
            rightPhaseChart.Axes.Top.Title.Font.SizeFloat = 11F;
            rightPhaseChart.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            rightPhaseChart.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            rightPhaseChart.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Axes.Top.Title.Shadow.Brush.Solid = true;
            rightPhaseChart.Axes.Top.Title.Shadow.Brush.Visible = true;
            rightPhaseChart.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Footer.Brush.Color = System.Drawing.Color.Silver;
            rightPhaseChart.Footer.Brush.Solid = true;
            rightPhaseChart.Footer.Brush.Visible = true;
            // 
            // 
            // 
            rightPhaseChart.Footer.Font.Bold = false;
            // 
            // 
            // 
            rightPhaseChart.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            rightPhaseChart.Footer.Font.Brush.Solid = true;
            rightPhaseChart.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Footer.Font.Shadow.Brush.Solid = true;
            rightPhaseChart.Footer.Font.Shadow.Brush.Visible = true;
            rightPhaseChart.Footer.Font.Size = 8;
            rightPhaseChart.Footer.Font.SizeFloat = 8F;
            rightPhaseChart.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            rightPhaseChart.Footer.ImageBevel.Brush.Solid = true;
            rightPhaseChart.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Footer.Shadow.Brush.Solid = true;
            rightPhaseChart.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Header.Brush.Color = System.Drawing.Color.FromArgb(192, 192, 192);
            rightPhaseChart.Header.Brush.Solid = true;
            rightPhaseChart.Header.Brush.Visible = true;
            // 
            // 
            // 
            rightPhaseChart.Header.Font.Bold = false;
            // 
            // 
            // 
            rightPhaseChart.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            rightPhaseChart.Header.Font.Brush.Solid = true;
            rightPhaseChart.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Header.Font.Shadow.Brush.Solid = true;
            rightPhaseChart.Header.Font.Shadow.Brush.Visible = true;
            rightPhaseChart.Header.Font.Size = 12;
            rightPhaseChart.Header.Font.SizeFloat = 12F;
            rightPhaseChart.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            rightPhaseChart.Header.ImageBevel.Brush.Solid = true;
            rightPhaseChart.Header.ImageBevel.Brush.Visible = true;
            rightPhaseChart.Header.Lines = new string[]
    {
    "Right channel"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(169, 169, 169);
            rightPhaseChart.Header.Shadow.Brush.Solid = true;
            rightPhaseChart.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Legend.Brush.Color = System.Drawing.Color.White;
            rightPhaseChart.Legend.Brush.Solid = true;
            rightPhaseChart.Legend.Brush.Visible = true;
            rightPhaseChart.Legend.CheckBoxes = false;
            // 
            // 
            // 
            rightPhaseChart.Legend.Font.Bold = false;
            // 
            // 
            // 
            rightPhaseChart.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            rightPhaseChart.Legend.Font.Brush.Solid = true;
            rightPhaseChart.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Legend.Font.Shadow.Brush.Solid = true;
            rightPhaseChart.Legend.Font.Shadow.Brush.Visible = true;
            rightPhaseChart.Legend.Font.Size = 9;
            rightPhaseChart.Legend.Font.SizeFloat = 9F;
            rightPhaseChart.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            rightPhaseChart.Legend.ImageBevel.Brush.Solid = true;
            rightPhaseChart.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(0, 0, 0);
            rightPhaseChart.Legend.Shadow.Brush.Solid = true;
            rightPhaseChart.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Legend.Symbol.Shadow.Brush.Solid = true;
            rightPhaseChart.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Legend.Title.Brush.Color = System.Drawing.Color.White;
            rightPhaseChart.Legend.Title.Brush.Solid = true;
            rightPhaseChart.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            rightPhaseChart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            rightPhaseChart.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            rightPhaseChart.Legend.Title.Font.Brush.Solid = true;
            rightPhaseChart.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Legend.Title.Font.Shadow.Brush.Solid = true;
            rightPhaseChart.Legend.Title.Font.Shadow.Brush.Visible = true;
            rightPhaseChart.Legend.Title.Font.Size = 8;
            rightPhaseChart.Legend.Title.Font.SizeFloat = 8F;
            rightPhaseChart.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            rightPhaseChart.Legend.Title.ImageBevel.Brush.Solid = true;
            rightPhaseChart.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Legend.Title.Shadow.Brush.Solid = true;
            rightPhaseChart.Legend.Title.Shadow.Brush.Visible = true;
            rightPhaseChart.Legend.Visible = false;
            rightPhaseChart.Location = new System.Drawing.Point(349, 0);
            rightPhaseChart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rightPhaseChart.Name = "rightPhaseChart";
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Panel.Brush.Color = System.Drawing.Color.FromArgb(255, 255, 255);
            rightPhaseChart.Panel.Brush.Solid = true;
            rightPhaseChart.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            rightPhaseChart.Panel.ImageBevel.Brush.Solid = true;
            rightPhaseChart.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Panel.Shadow.Brush.Solid = true;
            rightPhaseChart.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            rightPhaseChart.Printer.Margins = margins1;
            rightPhaseChart.Series.Add(polar2);
            rightPhaseChart.Size = new System.Drawing.Size(782, 441);
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            rightPhaseChart.SubFooter.Brush.Solid = true;
            rightPhaseChart.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            rightPhaseChart.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            rightPhaseChart.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            rightPhaseChart.SubFooter.Font.Brush.Solid = true;
            rightPhaseChart.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.SubFooter.Font.Shadow.Brush.Solid = true;
            rightPhaseChart.SubFooter.Font.Shadow.Brush.Visible = true;
            rightPhaseChart.SubFooter.Font.Size = 8;
            rightPhaseChart.SubFooter.Font.SizeFloat = 8F;
            rightPhaseChart.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            rightPhaseChart.SubFooter.ImageBevel.Brush.Solid = true;
            rightPhaseChart.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.SubFooter.Shadow.Brush.Solid = true;
            rightPhaseChart.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(192, 192, 192);
            rightPhaseChart.SubHeader.Brush.Solid = true;
            rightPhaseChart.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            rightPhaseChart.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            rightPhaseChart.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            rightPhaseChart.SubHeader.Font.Brush.Solid = true;
            rightPhaseChart.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.SubHeader.Font.Shadow.Brush.Solid = true;
            rightPhaseChart.SubHeader.Font.Shadow.Brush.Visible = true;
            rightPhaseChart.SubHeader.Font.Size = 12;
            rightPhaseChart.SubHeader.Font.SizeFloat = 12F;
            rightPhaseChart.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            rightPhaseChart.SubHeader.ImageBevel.Brush.Solid = true;
            rightPhaseChart.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(169, 169, 169);
            rightPhaseChart.SubHeader.Shadow.Brush.Solid = true;
            rightPhaseChart.SubHeader.Shadow.Brush.Visible = true;
            rightPhaseChart.TabIndex = 3;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            rightPhaseChart.Walls.Back.Brush.Solid = true;
            rightPhaseChart.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            rightPhaseChart.Walls.Back.ImageBevel.Brush.Solid = true;
            rightPhaseChart.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Walls.Back.Shadow.Brush.Solid = true;
            rightPhaseChart.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            rightPhaseChart.Walls.Bottom.Brush.Solid = true;
            rightPhaseChart.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            rightPhaseChart.Walls.Bottom.ImageBevel.Brush.Solid = true;
            rightPhaseChart.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Walls.Bottom.Shadow.Brush.Solid = true;
            rightPhaseChart.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            rightPhaseChart.Walls.Left.Brush.Solid = true;
            rightPhaseChart.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            rightPhaseChart.Walls.Left.ImageBevel.Brush.Solid = true;
            rightPhaseChart.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Walls.Left.Shadow.Brush.Solid = true;
            rightPhaseChart.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            rightPhaseChart.Walls.Right.Brush.Solid = true;
            rightPhaseChart.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            rightPhaseChart.Walls.Right.ImageBevel.Brush.Solid = true;
            rightPhaseChart.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            rightPhaseChart.Walls.Right.Shadow.Brush.Solid = true;
            rightPhaseChart.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            rightPhaseChart.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            rightPhaseChart.Zoom.Brush.Solid = true;
            rightPhaseChart.Zoom.Brush.Visible = false;
            // 
            // polar2
            // 
            // 
            // 
            // 
            polar2.Brush.Color = System.Drawing.Color.FromArgb(68, 102, 163);
            polar2.Brush.Solid = true;
            polar2.Brush.Visible = false;
            polar2.Circled = true;
            // 
            // 
            // 
            polar2.CircleLabelsFont.Bold = false;
            // 
            // 
            // 
            polar2.CircleLabelsFont.Brush.Color = System.Drawing.Color.FromArgb(0, 0, 0);
            polar2.CircleLabelsFont.Brush.Solid = true;
            polar2.CircleLabelsFont.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.CircleLabelsFont.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            polar2.CircleLabelsFont.Shadow.Brush.Solid = true;
            polar2.CircleLabelsFont.Shadow.Brush.Visible = true;
            polar2.CircleLabelsFont.Size = 8;
            polar2.CircleLabelsFont.SizeFloat = 8F;
            polar2.CircleLabelsFont.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            polar2.Color = System.Drawing.Color.FromArgb(255, 0, 0);
            polar2.Cursor = cursor1;
            // 
            // 
            // 
            polar2.Font.Bold = false;
            // 
            // 
            // 
            polar2.Font.Brush.Color = System.Drawing.Color.FromArgb(0, 0, 0);
            polar2.Font.Brush.Solid = true;
            polar2.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            polar2.Font.Shadow.Brush.Solid = true;
            polar2.Font.Shadow.Brush.Visible = true;
            polar2.Font.Size = 8;
            polar2.Font.SizeFloat = 8F;
            polar2.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            polar2.Frame.Circled = true;
            polar2.Frame.FrameElementPercents = new double[]
    {
    25D,
    60D,
    15D
    };
            // 
            // 
            // 
            polar2.Frame.InnerBand.Color = System.Drawing.Color.Gray;
            polar2.Frame.InnerBand.Solid = true;
            polar2.Frame.InnerBand.Visible = true;
            // 
            // 
            // 
            polar2.Frame.OuterBand.Color = System.Drawing.Color.Gray;
            // 
            // 
            // 
            polar2.Frame.OuterBand.Gradient.Visible = true;
            polar2.Frame.OuterBand.Solid = true;
            polar2.Frame.OuterBand.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Legend.Brush.Color = System.Drawing.Color.White;
            polar2.Legend.Brush.Solid = true;
            polar2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            polar2.Legend.Font.Bold = false;
            // 
            // 
            // 
            polar2.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            polar2.Legend.Font.Brush.Solid = true;
            polar2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            polar2.Legend.Font.Shadow.Brush.Solid = true;
            polar2.Legend.Font.Shadow.Brush.Visible = true;
            polar2.Legend.Font.Size = 8;
            polar2.Legend.Font.SizeFloat = 8F;
            polar2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            polar2.Legend.ImageBevel.Brush.Solid = true;
            polar2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            polar2.Legend.Shadow.Brush.Solid = true;
            polar2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Marks.Brush.Color = System.Drawing.Color.FromArgb(255, 255, 255);
            polar2.Marks.Brush.Solid = true;
            polar2.Marks.Brush.Visible = true;
            // 
            // 
            // 
            polar2.Marks.Font.Bold = false;
            // 
            // 
            // 
            polar2.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(0, 0, 0);
            polar2.Marks.Font.Brush.Solid = true;
            polar2.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            polar2.Marks.Font.Shadow.Brush.Solid = true;
            polar2.Marks.Font.Shadow.Brush.Visible = true;
            polar2.Marks.Font.Size = 8;
            polar2.Marks.Font.SizeFloat = 8F;
            polar2.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            polar2.Marks.ImageBevel.Brush.Solid = true;
            polar2.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Marks.Shadow.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            polar2.Marks.Shadow.Brush.Solid = true;
            polar2.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            polar2.Marks.Symbol.Brush.Solid = true;
            polar2.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            polar2.Marks.Symbol.ImageBevel.Brush.Solid = true;
            polar2.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            polar2.Marks.Symbol.Shadow.Brush.Solid = true;
            polar2.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            polar2.Pen.Color = System.Drawing.Color.FromArgb(68, 102, 163);
            polar2.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            polar2.Pointer.Brush.Color = System.Drawing.Color.Empty;
            polar2.Pointer.Brush.Solid = true;
            polar2.Pointer.Brush.Visible = true;
            polar2.Pointer.HorizSize = 1;
            polar2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.SmallDot;
            polar2.Pointer.VertSize = 1;
            polar2.Title = "polar1";
            polar2.UniqueCustomRadius = true;
            // 
            // 
            // 
            polar2.XValues.DataMember = "Angle";
            polar2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            polar2.XValues.Value = new double[]
    {
    14.4D,
    28.8D,
    43.2D,
    57.6D,
    72D,
    86.4D,
    100.8D,
    115.2D,
    129.6D,
    144D,
    158.4D,
    172.8D,
    187.20000000000002D,
    201.6D,
    216D,
    230.4D,
    244.8D,
    259.2D,
    273.6D,
    288D,
    302.40000000000003D,
    316.8D,
    331.2D,
    345.6D,
    360D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            polar2.YValues.DataMember = "Y";
            polar2.YValues.Value = new double[]
    {
    987.65065597121168D,
    181.25906392385207D,
    382.24977395927988D,
    636.01481229207241D,
    645.96547619112084D,
    567.86065977758756D,
    524.534947784401D,
    205.43930719254504D,
    633.43035675605313D,
    201.79423217139868D,
    518.20856526736566D,
    973.53297081800781D,
    259.18156137046475D,
    882.5211173526576D,
    500.53867751152194D,
    698.19707579221438D,
    131.97619085152456D,
    915.50359947723507D,
    281.40588334221667D,
    586.58553484528591D,
    193.8936276551772D,
    984.85287634276449D,
    836.60049712453065D,
    273.58038766336648D,
    293.75292404589845D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // splitter2
            // 
            splitter2.Location = new System.Drawing.Point(345, 0);
            splitter2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitter2.Name = "splitter2";
            splitter2.Size = new System.Drawing.Size(4, 441);
            splitter2.TabIndex = 2;
            splitter2.TabStop = false;
            // 
            // leftPhaseChart
            // 
            // 
            // 
            // 
            leftPhaseChart.Aspect.Elevation = 315;
            leftPhaseChart.Aspect.ElevationFloat = 315D;
            leftPhaseChart.Aspect.Orthogonal = false;
            leftPhaseChart.Aspect.Perspective = 0;
            leftPhaseChart.Aspect.Rotation = 360;
            leftPhaseChart.Aspect.RotationFloat = 360D;
            // 
            // 
            // 
            leftPhaseChart.Axes.Automatic = false;
            // 
            // 
            // 
            leftPhaseChart.Axes.Bottom.Automatic = false;
            leftPhaseChart.Axes.Bottom.AutomaticMaximum = false;
            leftPhaseChart.Axes.Bottom.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            leftPhaseChart.Axes.Bottom.Labels.Brush.Solid = true;
            leftPhaseChart.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            leftPhaseChart.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            leftPhaseChart.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            leftPhaseChart.Axes.Bottom.Labels.Font.Brush.Solid = true;
            leftPhaseChart.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            leftPhaseChart.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            leftPhaseChart.Axes.Bottom.Labels.Font.Size = 9;
            leftPhaseChart.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            leftPhaseChart.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            leftPhaseChart.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            leftPhaseChart.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            leftPhaseChart.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            leftPhaseChart.Axes.Bottom.Maximum = 0D;
            leftPhaseChart.Axes.Bottom.Minimum = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            leftPhaseChart.Axes.Bottom.Title.Brush.Solid = true;
            leftPhaseChart.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            leftPhaseChart.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            leftPhaseChart.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            leftPhaseChart.Axes.Bottom.Title.Font.Brush.Solid = true;
            leftPhaseChart.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            leftPhaseChart.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            leftPhaseChart.Axes.Bottom.Title.Font.Size = 11;
            leftPhaseChart.Axes.Bottom.Title.Font.SizeFloat = 11F;
            leftPhaseChart.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            leftPhaseChart.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            leftPhaseChart.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            leftPhaseChart.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            leftPhaseChart.Axes.Depth.Automatic = false;
            leftPhaseChart.Axes.Depth.AutomaticMaximum = false;
            leftPhaseChart.Axes.Depth.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            leftPhaseChart.Axes.Depth.Labels.Brush.Solid = true;
            leftPhaseChart.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            leftPhaseChart.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            leftPhaseChart.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            leftPhaseChart.Axes.Depth.Labels.Font.Brush.Solid = true;
            leftPhaseChart.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            leftPhaseChart.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            leftPhaseChart.Axes.Depth.Labels.Font.Size = 9;
            leftPhaseChart.Axes.Depth.Labels.Font.SizeFloat = 9F;
            leftPhaseChart.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            leftPhaseChart.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            leftPhaseChart.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            leftPhaseChart.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            leftPhaseChart.Axes.Depth.Maximum = 0D;
            leftPhaseChart.Axes.Depth.Minimum = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            leftPhaseChart.Axes.Depth.Title.Brush.Solid = true;
            leftPhaseChart.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            leftPhaseChart.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            leftPhaseChart.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            leftPhaseChart.Axes.Depth.Title.Font.Brush.Solid = true;
            leftPhaseChart.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            leftPhaseChart.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            leftPhaseChart.Axes.Depth.Title.Font.Size = 11;
            leftPhaseChart.Axes.Depth.Title.Font.SizeFloat = 11F;
            leftPhaseChart.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            leftPhaseChart.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            leftPhaseChart.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Axes.Depth.Title.Shadow.Brush.Solid = true;
            leftPhaseChart.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            leftPhaseChart.Axes.DepthTop.Automatic = false;
            leftPhaseChart.Axes.DepthTop.AutomaticMaximum = false;
            leftPhaseChart.Axes.DepthTop.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            leftPhaseChart.Axes.DepthTop.Labels.Brush.Solid = true;
            leftPhaseChart.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            leftPhaseChart.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            leftPhaseChart.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            leftPhaseChart.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            leftPhaseChart.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            leftPhaseChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            leftPhaseChart.Axes.DepthTop.Labels.Font.Size = 9;
            leftPhaseChart.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            leftPhaseChart.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            leftPhaseChart.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            leftPhaseChart.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            leftPhaseChart.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            leftPhaseChart.Axes.DepthTop.Maximum = 0D;
            leftPhaseChart.Axes.DepthTop.Minimum = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            leftPhaseChart.Axes.DepthTop.Title.Brush.Solid = true;
            leftPhaseChart.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            leftPhaseChart.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            leftPhaseChart.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            leftPhaseChart.Axes.DepthTop.Title.Font.Brush.Solid = true;
            leftPhaseChart.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            leftPhaseChart.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            leftPhaseChart.Axes.DepthTop.Title.Font.Size = 11;
            leftPhaseChart.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            leftPhaseChart.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            leftPhaseChart.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            leftPhaseChart.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            leftPhaseChart.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            leftPhaseChart.Axes.Left.Automatic = false;
            leftPhaseChart.Axes.Left.AutomaticMaximum = false;
            leftPhaseChart.Axes.Left.AutomaticMinimum = false;
            // 
            // 
            // 
            leftPhaseChart.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            leftPhaseChart.Axes.Left.Labels.Brush.Solid = true;
            leftPhaseChart.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            leftPhaseChart.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            leftPhaseChart.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            leftPhaseChart.Axes.Left.Labels.Font.Brush.Solid = true;
            leftPhaseChart.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            leftPhaseChart.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            leftPhaseChart.Axes.Left.Labels.Font.Size = 9;
            leftPhaseChart.Axes.Left.Labels.Font.SizeFloat = 9F;
            leftPhaseChart.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            leftPhaseChart.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            leftPhaseChart.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Axes.Left.Labels.Shadow.Brush.Solid = true;
            leftPhaseChart.Axes.Left.Labels.Shadow.Brush.Visible = true;
            leftPhaseChart.Axes.Left.Maximum = 1D;
            leftPhaseChart.Axes.Left.Minimum = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            leftPhaseChart.Axes.Left.Title.Brush.Solid = true;
            leftPhaseChart.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            leftPhaseChart.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            leftPhaseChart.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            leftPhaseChart.Axes.Left.Title.Font.Brush.Solid = true;
            leftPhaseChart.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            leftPhaseChart.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            leftPhaseChart.Axes.Left.Title.Font.Size = 11;
            leftPhaseChart.Axes.Left.Title.Font.SizeFloat = 11F;
            leftPhaseChart.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            leftPhaseChart.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            leftPhaseChart.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Axes.Left.Title.Shadow.Brush.Solid = true;
            leftPhaseChart.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            leftPhaseChart.Axes.Right.Automatic = false;
            leftPhaseChart.Axes.Right.AutomaticMaximum = false;
            leftPhaseChart.Axes.Right.AutomaticMinimum = false;
            // 
            // 
            // 
            leftPhaseChart.Axes.Right.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            leftPhaseChart.Axes.Right.Labels.Brush.Solid = true;
            leftPhaseChart.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            leftPhaseChart.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            leftPhaseChart.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            leftPhaseChart.Axes.Right.Labels.Font.Brush.Solid = true;
            leftPhaseChart.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            leftPhaseChart.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            leftPhaseChart.Axes.Right.Labels.Font.Size = 9;
            leftPhaseChart.Axes.Right.Labels.Font.SizeFloat = 9F;
            leftPhaseChart.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            leftPhaseChart.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            leftPhaseChart.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Axes.Right.Labels.Shadow.Brush.Solid = true;
            leftPhaseChart.Axes.Right.Labels.Shadow.Brush.Visible = true;
            leftPhaseChart.Axes.Right.Maximum = 0D;
            leftPhaseChart.Axes.Right.Minimum = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            leftPhaseChart.Axes.Right.Title.Brush.Solid = true;
            leftPhaseChart.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            leftPhaseChart.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            leftPhaseChart.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            leftPhaseChart.Axes.Right.Title.Font.Brush.Solid = true;
            leftPhaseChart.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            leftPhaseChart.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            leftPhaseChart.Axes.Right.Title.Font.Size = 11;
            leftPhaseChart.Axes.Right.Title.Font.SizeFloat = 11F;
            leftPhaseChart.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            leftPhaseChart.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            leftPhaseChart.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Axes.Right.Title.Shadow.Brush.Solid = true;
            leftPhaseChart.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            leftPhaseChart.Axes.Top.Automatic = false;
            leftPhaseChart.Axes.Top.AutomaticMaximum = false;
            leftPhaseChart.Axes.Top.AutomaticMinimum = false;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            leftPhaseChart.Axes.Top.Labels.Brush.Solid = true;
            leftPhaseChart.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            leftPhaseChart.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            leftPhaseChart.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            leftPhaseChart.Axes.Top.Labels.Font.Brush.Solid = true;
            leftPhaseChart.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            leftPhaseChart.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            leftPhaseChart.Axes.Top.Labels.Font.Size = 9;
            leftPhaseChart.Axes.Top.Labels.Font.SizeFloat = 9F;
            leftPhaseChart.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            leftPhaseChart.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            leftPhaseChart.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Axes.Top.Labels.Shadow.Brush.Solid = true;
            leftPhaseChart.Axes.Top.Labels.Shadow.Brush.Visible = true;
            leftPhaseChart.Axes.Top.Maximum = 0D;
            leftPhaseChart.Axes.Top.Minimum = 0D;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            leftPhaseChart.Axes.Top.Title.Brush.Solid = true;
            leftPhaseChart.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            leftPhaseChart.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            leftPhaseChart.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            leftPhaseChart.Axes.Top.Title.Font.Brush.Solid = true;
            leftPhaseChart.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            leftPhaseChart.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            leftPhaseChart.Axes.Top.Title.Font.Size = 11;
            leftPhaseChart.Axes.Top.Title.Font.SizeFloat = 11F;
            leftPhaseChart.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            leftPhaseChart.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            leftPhaseChart.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Axes.Top.Title.Shadow.Brush.Solid = true;
            leftPhaseChart.Axes.Top.Title.Shadow.Brush.Visible = true;
            leftPhaseChart.Dock = System.Windows.Forms.DockStyle.Left;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Footer.Brush.Color = System.Drawing.Color.Silver;
            leftPhaseChart.Footer.Brush.Solid = true;
            leftPhaseChart.Footer.Brush.Visible = true;
            // 
            // 
            // 
            leftPhaseChart.Footer.Font.Bold = false;
            // 
            // 
            // 
            leftPhaseChart.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            leftPhaseChart.Footer.Font.Brush.Solid = true;
            leftPhaseChart.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Footer.Font.Shadow.Brush.Solid = true;
            leftPhaseChart.Footer.Font.Shadow.Brush.Visible = true;
            leftPhaseChart.Footer.Font.Size = 8;
            leftPhaseChart.Footer.Font.SizeFloat = 8F;
            leftPhaseChart.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            leftPhaseChart.Footer.ImageBevel.Brush.Solid = true;
            leftPhaseChart.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Footer.Shadow.Brush.Solid = true;
            leftPhaseChart.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Header.Brush.Color = System.Drawing.Color.FromArgb(192, 192, 192);
            leftPhaseChart.Header.Brush.Solid = true;
            leftPhaseChart.Header.Brush.Visible = true;
            // 
            // 
            // 
            leftPhaseChart.Header.Font.Bold = false;
            // 
            // 
            // 
            leftPhaseChart.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            leftPhaseChart.Header.Font.Brush.Solid = true;
            leftPhaseChart.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Header.Font.Shadow.Brush.Solid = true;
            leftPhaseChart.Header.Font.Shadow.Brush.Visible = true;
            leftPhaseChart.Header.Font.Size = 12;
            leftPhaseChart.Header.Font.SizeFloat = 12F;
            leftPhaseChart.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            leftPhaseChart.Header.ImageBevel.Brush.Solid = true;
            leftPhaseChart.Header.ImageBevel.Brush.Visible = true;
            leftPhaseChart.Header.Lines = new string[]
    {
    "Left channel"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(169, 169, 169);
            leftPhaseChart.Header.Shadow.Brush.Solid = true;
            leftPhaseChart.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Legend.Brush.Color = System.Drawing.Color.White;
            leftPhaseChart.Legend.Brush.Solid = true;
            leftPhaseChart.Legend.Brush.Visible = true;
            leftPhaseChart.Legend.CheckBoxes = false;
            // 
            // 
            // 
            leftPhaseChart.Legend.Font.Bold = false;
            // 
            // 
            // 
            leftPhaseChart.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            leftPhaseChart.Legend.Font.Brush.Solid = true;
            leftPhaseChart.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Legend.Font.Shadow.Brush.Solid = true;
            leftPhaseChart.Legend.Font.Shadow.Brush.Visible = true;
            leftPhaseChart.Legend.Font.Size = 9;
            leftPhaseChart.Legend.Font.SizeFloat = 9F;
            leftPhaseChart.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            leftPhaseChart.Legend.ImageBevel.Brush.Solid = true;
            leftPhaseChart.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(0, 0, 0);
            leftPhaseChart.Legend.Shadow.Brush.Solid = true;
            leftPhaseChart.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Legend.Symbol.Shadow.Brush.Solid = true;
            leftPhaseChart.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Legend.Title.Brush.Color = System.Drawing.Color.White;
            leftPhaseChart.Legend.Title.Brush.Solid = true;
            leftPhaseChart.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            leftPhaseChart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            leftPhaseChart.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            leftPhaseChart.Legend.Title.Font.Brush.Solid = true;
            leftPhaseChart.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Legend.Title.Font.Shadow.Brush.Solid = true;
            leftPhaseChart.Legend.Title.Font.Shadow.Brush.Visible = true;
            leftPhaseChart.Legend.Title.Font.Size = 8;
            leftPhaseChart.Legend.Title.Font.SizeFloat = 8F;
            leftPhaseChart.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            leftPhaseChart.Legend.Title.ImageBevel.Brush.Solid = true;
            leftPhaseChart.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Legend.Title.Shadow.Brush.Solid = true;
            leftPhaseChart.Legend.Title.Shadow.Brush.Visible = true;
            leftPhaseChart.Legend.Visible = false;
            leftPhaseChart.Location = new System.Drawing.Point(0, 0);
            leftPhaseChart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            leftPhaseChart.Name = "leftPhaseChart";
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Panel.Brush.Color = System.Drawing.Color.FromArgb(255, 255, 255);
            leftPhaseChart.Panel.Brush.Solid = true;
            leftPhaseChart.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            leftPhaseChart.Panel.ImageBevel.Brush.Solid = true;
            leftPhaseChart.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Panel.Shadow.Brush.Solid = true;
            leftPhaseChart.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins2.Bottom = 100;
            margins2.Left = 100;
            margins2.Right = 100;
            margins2.Top = 100;
            leftPhaseChart.Printer.Margins = margins2;
            leftPhaseChart.Series.Add(polar1);
            leftPhaseChart.Size = new System.Drawing.Size(345, 441);
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            leftPhaseChart.SubFooter.Brush.Solid = true;
            leftPhaseChart.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            leftPhaseChart.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            leftPhaseChart.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            leftPhaseChart.SubFooter.Font.Brush.Solid = true;
            leftPhaseChart.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.SubFooter.Font.Shadow.Brush.Solid = true;
            leftPhaseChart.SubFooter.Font.Shadow.Brush.Visible = true;
            leftPhaseChart.SubFooter.Font.Size = 8;
            leftPhaseChart.SubFooter.Font.SizeFloat = 8F;
            leftPhaseChart.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            leftPhaseChart.SubFooter.ImageBevel.Brush.Solid = true;
            leftPhaseChart.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.SubFooter.Shadow.Brush.Solid = true;
            leftPhaseChart.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(192, 192, 192);
            leftPhaseChart.SubHeader.Brush.Solid = true;
            leftPhaseChart.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            leftPhaseChart.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            leftPhaseChart.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            leftPhaseChart.SubHeader.Font.Brush.Solid = true;
            leftPhaseChart.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.SubHeader.Font.Shadow.Brush.Solid = true;
            leftPhaseChart.SubHeader.Font.Shadow.Brush.Visible = true;
            leftPhaseChart.SubHeader.Font.Size = 12;
            leftPhaseChart.SubHeader.Font.SizeFloat = 12F;
            leftPhaseChart.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            leftPhaseChart.SubHeader.ImageBevel.Brush.Solid = true;
            leftPhaseChart.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(169, 169, 169);
            leftPhaseChart.SubHeader.Shadow.Brush.Solid = true;
            leftPhaseChart.SubHeader.Shadow.Brush.Visible = true;
            leftPhaseChart.TabIndex = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            leftPhaseChart.Walls.Back.Brush.Solid = true;
            leftPhaseChart.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            leftPhaseChart.Walls.Back.ImageBevel.Brush.Solid = true;
            leftPhaseChart.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Walls.Back.Shadow.Brush.Solid = true;
            leftPhaseChart.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            leftPhaseChart.Walls.Bottom.Brush.Solid = true;
            leftPhaseChart.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            leftPhaseChart.Walls.Bottom.ImageBevel.Brush.Solid = true;
            leftPhaseChart.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Walls.Bottom.Shadow.Brush.Solid = true;
            leftPhaseChart.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            leftPhaseChart.Walls.Left.Brush.Solid = true;
            leftPhaseChart.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            leftPhaseChart.Walls.Left.ImageBevel.Brush.Solid = true;
            leftPhaseChart.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Walls.Left.Shadow.Brush.Solid = true;
            leftPhaseChart.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            leftPhaseChart.Walls.Right.Brush.Solid = true;
            leftPhaseChart.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            leftPhaseChart.Walls.Right.ImageBevel.Brush.Solid = true;
            leftPhaseChart.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            leftPhaseChart.Walls.Right.Shadow.Brush.Solid = true;
            leftPhaseChart.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            leftPhaseChart.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            leftPhaseChart.Zoom.Brush.Solid = true;
            leftPhaseChart.Zoom.Brush.Visible = false;
            // 
            // polar1
            // 
            // 
            // 
            // 
            polar1.Brush.Color = System.Drawing.Color.FromArgb(68, 102, 163);
            polar1.Brush.Solid = true;
            polar1.Brush.Visible = false;
            polar1.Circled = true;
            // 
            // 
            // 
            polar1.CircleLabelsFont.Bold = false;
            // 
            // 
            // 
            polar1.CircleLabelsFont.Brush.Color = System.Drawing.Color.FromArgb(0, 0, 0);
            polar1.CircleLabelsFont.Brush.Solid = true;
            polar1.CircleLabelsFont.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.CircleLabelsFont.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            polar1.CircleLabelsFont.Shadow.Brush.Solid = true;
            polar1.CircleLabelsFont.Shadow.Brush.Visible = true;
            polar1.CircleLabelsFont.Size = 8;
            polar1.CircleLabelsFont.SizeFloat = 8F;
            polar1.CircleLabelsFont.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            polar1.CirclePen.Visible = false;
            polar1.Color = System.Drawing.Color.FromArgb(255, 0, 0);
            polar1.Cursor = cursor1;
            // 
            // 
            // 
            polar1.Font.Bold = false;
            // 
            // 
            // 
            polar1.Font.Brush.Color = System.Drawing.Color.FromArgb(0, 0, 0);
            polar1.Font.Brush.Solid = true;
            polar1.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            polar1.Font.Shadow.Brush.Solid = true;
            polar1.Font.Shadow.Brush.Visible = true;
            polar1.Font.Size = 8;
            polar1.Font.SizeFloat = 8F;
            polar1.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            polar1.Frame.Circled = true;
            polar1.Frame.FrameElementPercents = new double[]
    {
    25D,
    60D,
    15D
    };
            // 
            // 
            // 
            polar1.Frame.InnerBand.Color = System.Drawing.Color.Gray;
            polar1.Frame.InnerBand.Solid = true;
            polar1.Frame.InnerBand.Visible = true;
            // 
            // 
            // 
            polar1.Frame.OuterBand.Color = System.Drawing.Color.Gray;
            // 
            // 
            // 
            polar1.Frame.OuterBand.Gradient.Visible = true;
            polar1.Frame.OuterBand.Solid = true;
            polar1.Frame.OuterBand.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Legend.Brush.Color = System.Drawing.Color.White;
            polar1.Legend.Brush.Solid = true;
            polar1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            polar1.Legend.Font.Bold = false;
            // 
            // 
            // 
            polar1.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            polar1.Legend.Font.Brush.Solid = true;
            polar1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            polar1.Legend.Font.Shadow.Brush.Solid = true;
            polar1.Legend.Font.Shadow.Brush.Visible = true;
            polar1.Legend.Font.Size = 8;
            polar1.Legend.Font.SizeFloat = 8F;
            polar1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            polar1.Legend.ImageBevel.Brush.Solid = true;
            polar1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            polar1.Legend.Shadow.Brush.Solid = true;
            polar1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Marks.Brush.Color = System.Drawing.Color.FromArgb(255, 255, 255);
            polar1.Marks.Brush.Solid = true;
            polar1.Marks.Brush.Visible = true;
            // 
            // 
            // 
            polar1.Marks.Font.Bold = false;
            // 
            // 
            // 
            polar1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(0, 0, 0);
            polar1.Marks.Font.Brush.Solid = true;
            polar1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            polar1.Marks.Font.Shadow.Brush.Solid = true;
            polar1.Marks.Font.Shadow.Brush.Visible = true;
            polar1.Marks.Font.Size = 8;
            polar1.Marks.Font.SizeFloat = 8F;
            polar1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            polar1.Marks.ImageBevel.Brush.Solid = true;
            polar1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Marks.Shadow.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            polar1.Marks.Shadow.Brush.Solid = true;
            polar1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            polar1.Marks.Symbol.Brush.Solid = true;
            polar1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            polar1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            polar1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            polar1.Marks.Symbol.Shadow.Brush.Solid = true;
            polar1.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            polar1.Pen.Color = System.Drawing.Color.FromArgb(68, 102, 163);
            polar1.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            polar1.Pointer.Brush.Color = System.Drawing.Color.Empty;
            polar1.Pointer.Brush.Solid = true;
            polar1.Pointer.Brush.Visible = true;
            polar1.Pointer.Dark3D = false;
            polar1.Pointer.Draw3D = false;
            polar1.Pointer.HorizSize = 1;
            polar1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.SmallDot;
            polar1.Pointer.VertSize = 1;
            polar1.Title = "polar1";
            polar1.UniqueCustomRadius = true;
            // 
            // 
            // 
            polar1.XValues.DataMember = "Angle";
            polar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            polar1.XValues.Value = new double[]
    {
    14.4D,
    28.8D,
    43.2D,
    57.6D,
    72D,
    86.4D,
    100.8D,
    115.2D,
    129.6D,
    144D,
    158.4D,
    172.8D,
    187.20000000000002D,
    201.6D,
    216D,
    230.4D,
    244.8D,
    259.2D,
    273.6D,
    288D,
    302.40000000000003D,
    316.8D,
    331.2D,
    345.6D,
    360D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            polar1.YValues.DataMember = "Y";
            polar1.YValues.Value = new double[]
    {
    266.8315334775632D,
    915.878538770079D,
    740.598931623436D,
    776.846056070107D,
    33.747752514084681D,
    795.58817643792747D,
    448.01332433475807D,
    826.28053867876554D,
    311.97737527963579D,
    231.79281450751836D,
    454.16215253116667D,
    373.54324386480414D,
    162.15385254898754D,
    503.18226411481493D,
    147.69604233777898D,
    521.22788185636887D,
    81.145534165271343D,
    504.95064451915704D,
    642.03397849995361D,
    904.17400074711713D,
    428.70886906781647D,
    851.04445298111273D,
    271.19226796468359D,
    904.02362474753693D,
    365.78599596991484D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            signalChart1.Axes.Bottom.Title.Caption = "Time[s]";
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
    "Time[s]"
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
            signalChart1.Axes.Right.Visible = false;
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
            signalChart1.Color = System.Drawing.Color.White;
            signalChart1.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            signalChart1.Location = new System.Drawing.Point(0, 441);
            signalChart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            signalChart1.Name = "signalChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Panel.Brush.Color = System.Drawing.Color.White;
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
            margins3.Bottom = 100;
            margins3.Left = 100;
            margins3.Right = 100;
            margins3.Top = 100;
            signalChart1.Printer.Margins = margins3;
            signalChart1.Series.Add(fastLine1);
            signalTeeItem1.Caption = null;
            signalTeeItem1.Input = Signal1;
            signalTeeItem1.Inputs = null;
            signalTeeItem1.InputsItemIndex = 0;
            signalTeeItem1.Series = fastLine1;
            signalTeeItem1.SeriesName = "fastLine1";
            signalChart1.Signals.Add(signalTeeItem1);
            signalChart1.Size = new System.Drawing.Size(1131, 186);
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
            signalChart1.TabIndex = 0;
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
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            signalChart1.Zoom.Brush.Solid = true;
            signalChart1.Zoom.Brush.Visible = false;
            // 
            // chartEditor
            // 
            chartEditor.AlwaysShowFuncSrc = false;
            chartEditor.Chart = signalChart1;
            chartEditor.HighLightTabs = false;
            chartEditor.Location = new System.Drawing.Point(0, 0);
            chartEditor.Name = "chartEditor";
            chartEditor.Options = null;
            chartEditor.TabIndex = 0;
            // 
            // Signal2
            // 
            Signal2.ChannelCount = 1;
            Signal2.Complex = false;
            Signal2.DataSerialization = "AAAAAAAAQEEAAAAAAACAPwAAAAAAgB9EAAAAQQAAAAAAE3pHAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            Signal2.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            Signal2.FloatPrecisionLock = false;
            Signal2.IsDouble = true;
            Signal2.Length = 12;
            // 
            // SignalIn1
            // 
            SignalIn1.ChannelCount = 2;
            SignalIn1.Complex = false;
            SignalIn1.DataSerialization = "AAAAAAAAQEEAAAAAAACAPwAAAAAAgB9EAAAAQQAAAAAAE3pHAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            SignalIn1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            SignalIn1.FloatPrecisionLock = false;
            SignalIn1.Input = null;
            SignalIn1.IsDouble = true;
            SignalIn1.Length = 12;
            SignalIn1.Quantization = (ushort)16;
            SignalIn1.SamplingFrequency = 11025D;
            SignalIn1.TriggerAbove = 0D;
            SignalIn1.TriggerBelow = 0D;
            SignalIn1.TriggerChannel = Dew.Signal.TChannel.chLeft;
            SignalIn1.TriggerDelay = 0;
            SignalIn1.Triggering = Dew.Signal.Audio.TriggerType.trNone;
            SignalIn1.TriggerMode = Dew.Signal.Audio.TriggerMode.trCrossing;
            SignalIn1.TriggerPosition = Dew.Signal.Audio.TriggerPosition.tpAfter;
            // 
            // SignalTimer1
            // 
            SignalTimer1.Frequency = 5D;
            SignalTimer1.Interval = 200U;
            SignalTimer1.Resolution = 10U;
            SignalTimer1.OnTimer += SignalTimer1_OnTimer;
            // 
            // PhaseScopeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1131, 800);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "PhaseScopeForm";
            Text = "PhaseScopeForm";
            Load += PhaseScopeForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)signalChart1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Splitter splitter2;
		private Steema.TeeChart.TChart leftPhaseChart;
		private Dew.Signal.Tee.SignalChart signalChart1;
		private System.Windows.Forms.Button button1;
		private Steema.TeeChart.Editor chartEditor;
		private System.Windows.Forms.ComboBox channelBox;
		private System.Windows.Forms.Label label1;
		private Steema.TeeChart.Styles.Polar polar1;
		private Dew.Signal.TSignal Signal1;
		private Dew.Signal.TSignal Signal2;
		private Dew.Signal.Audio.SignalIn SignalIn1;
		private Dew.Signal.Audio.SignalTimer SignalTimer1;
		private Steema.TeeChart.TChart rightPhaseChart;
		private Steema.TeeChart.Styles.Polar polar2;
		private Steema.TeeChart.Styles.FastLine fastLine1;
	}
}