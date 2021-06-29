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
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhaseScopeForm));
            Dew.Signal.Tee.SignalTeeItem signalTeeItem1 = new Dew.Signal.Tee.SignalTeeItem();
            this.Signal1 = new Dew.Signal.TSignal(this.components);
            this.fastLine1 = new Steema.TeeChart.Styles.FastLine();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.channelBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rightPhaseChart = new Steema.TeeChart.TChart();
            this.polar2 = new Steema.TeeChart.Styles.Polar();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.leftPhaseChart = new Steema.TeeChart.TChart();
            this.polar1 = new Steema.TeeChart.Styles.Polar();
            this.signalChart1 = new Dew.Signal.Tee.SignalChart();
            this.chartEditor = new Steema.TeeChart.Editor(this.components);
            this.Signal2 = new Dew.Signal.TSignal(this.components);
            this.SignalIn1 = new Dew.Signal.SignalIn(this.components);
            this.SignalTimer1 = new Dew.Signal.SignalTimer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signalChart1)).BeginInit();
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
            this.fastLine1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
            this.fastLine1.Marks.TailParams.Margin = 0F;
            this.fastLine1.Marks.TailParams.PointerHeight = 8D;
            this.fastLine1.Marks.TailParams.PointerWidth = 8D;
            this.fastLine1.OriginalCursor = null;
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
            this.richTextBox1.Size = new System.Drawing.Size(633, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.channelBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 55);
            this.panel1.TabIndex = 1;
            // 
            // channelBox
            // 
            this.channelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.channelBox.FormattingEnabled = true;
            this.channelBox.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.channelBox.Location = new System.Drawing.Point(179, 22);
            this.channelBox.Name = "channelBox";
            this.channelBox.Size = new System.Drawing.Size(99, 21);
            this.channelBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Channel:";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.signalChart1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 297);
            this.panel2.TabIndex = 2;
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 133);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(633, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rightPhaseChart);
            this.panel3.Controls.Add(this.splitter2);
            this.panel3.Controls.Add(this.leftPhaseChart);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 136);
            this.panel3.TabIndex = 1;
            // 
            // rightPhaseChart
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Aspect.Elevation = 315;
            this.rightPhaseChart.Aspect.ElevationFloat = 315D;
            this.rightPhaseChart.Aspect.Orthogonal = false;
            this.rightPhaseChart.Aspect.Perspective = 0;
            this.rightPhaseChart.Aspect.Rotation = 360;
            this.rightPhaseChart.Aspect.RotationFloat = 360D;
            this.rightPhaseChart.Graphics3D.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            this.rightPhaseChart.Graphics3D.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Automatic = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.rightPhaseChart.Axes.Bottom.Labels.Brush.Solid = true;
            this.rightPhaseChart.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rightPhaseChart.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.rightPhaseChart.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.rightPhaseChart.Axes.Bottom.Labels.Font.Size = 9;
            this.rightPhaseChart.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.rightPhaseChart.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.rightPhaseChart.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.rightPhaseChart.Axes.Bottom.Title.Brush.Solid = true;
            this.rightPhaseChart.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rightPhaseChart.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.rightPhaseChart.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.rightPhaseChart.Axes.Bottom.Title.Font.Size = 11;
            this.rightPhaseChart.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.rightPhaseChart.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.rightPhaseChart.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.rightPhaseChart.Axes.Depth.Labels.Brush.Solid = true;
            this.rightPhaseChart.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rightPhaseChart.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.rightPhaseChart.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.rightPhaseChart.Axes.Depth.Labels.Font.Size = 9;
            this.rightPhaseChart.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.rightPhaseChart.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.rightPhaseChart.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.rightPhaseChart.Axes.Depth.Title.Brush.Solid = true;
            this.rightPhaseChart.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rightPhaseChart.Axes.Depth.Title.Font.Brush.Solid = true;
            this.rightPhaseChart.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.rightPhaseChart.Axes.Depth.Title.Font.Size = 11;
            this.rightPhaseChart.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.rightPhaseChart.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.rightPhaseChart.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.rightPhaseChart.Axes.DepthTop.Labels.Brush.Solid = true;
            this.rightPhaseChart.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rightPhaseChart.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.rightPhaseChart.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.rightPhaseChart.Axes.DepthTop.Labels.Font.Size = 9;
            this.rightPhaseChart.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.rightPhaseChart.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.rightPhaseChart.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.rightPhaseChart.Axes.DepthTop.Title.Brush.Solid = true;
            this.rightPhaseChart.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rightPhaseChart.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.rightPhaseChart.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.rightPhaseChart.Axes.DepthTop.Title.Font.Size = 11;
            this.rightPhaseChart.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.rightPhaseChart.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.rightPhaseChart.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Left.Automatic = false;
            this.rightPhaseChart.Axes.Left.AutomaticMaximum = false;
            this.rightPhaseChart.Axes.Left.AutomaticMinimum = false;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.rightPhaseChart.Axes.Left.Labels.Brush.Solid = true;
            this.rightPhaseChart.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rightPhaseChart.Axes.Left.Labels.Font.Brush.Solid = true;
            this.rightPhaseChart.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.rightPhaseChart.Axes.Left.Labels.Font.Size = 9;
            this.rightPhaseChart.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.rightPhaseChart.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.rightPhaseChart.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Axes.Left.Labels.Shadow.Brush.Visible = true;
            this.rightPhaseChart.Axes.Left.Maximum = 1D;
            this.rightPhaseChart.Axes.Left.Minimum = 0D;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.rightPhaseChart.Axes.Left.Title.Brush.Solid = true;
            this.rightPhaseChart.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rightPhaseChart.Axes.Left.Title.Font.Brush.Solid = true;
            this.rightPhaseChart.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.rightPhaseChart.Axes.Left.Title.Font.Size = 11;
            this.rightPhaseChart.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.rightPhaseChart.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.rightPhaseChart.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Right.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.rightPhaseChart.Axes.Right.Labels.Brush.Solid = true;
            this.rightPhaseChart.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rightPhaseChart.Axes.Right.Labels.Font.Brush.Solid = true;
            this.rightPhaseChart.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.rightPhaseChart.Axes.Right.Labels.Font.Size = 9;
            this.rightPhaseChart.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.rightPhaseChart.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.rightPhaseChart.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.rightPhaseChart.Axes.Right.Title.Brush.Solid = true;
            this.rightPhaseChart.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rightPhaseChart.Axes.Right.Title.Font.Brush.Solid = true;
            this.rightPhaseChart.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.rightPhaseChart.Axes.Right.Title.Font.Size = 11;
            this.rightPhaseChart.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.rightPhaseChart.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.rightPhaseChart.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.rightPhaseChart.Axes.Top.Labels.Brush.Solid = true;
            this.rightPhaseChart.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rightPhaseChart.Axes.Top.Labels.Font.Brush.Solid = true;
            this.rightPhaseChart.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.rightPhaseChart.Axes.Top.Labels.Font.Size = 9;
            this.rightPhaseChart.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.rightPhaseChart.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.rightPhaseChart.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.rightPhaseChart.Axes.Top.Title.Brush.Solid = true;
            this.rightPhaseChart.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rightPhaseChart.Axes.Top.Title.Font.Brush.Solid = true;
            this.rightPhaseChart.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.rightPhaseChart.Axes.Top.Title.Font.Size = 11;
            this.rightPhaseChart.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.rightPhaseChart.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.rightPhaseChart.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.rightPhaseChart.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.rightPhaseChart.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.rightPhaseChart.Footer.Brush.Solid = true;
            this.rightPhaseChart.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.rightPhaseChart.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.rightPhaseChart.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.rightPhaseChart.Footer.Font.Brush.Solid = true;
            this.rightPhaseChart.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Footer.Font.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Footer.Font.Shadow.Brush.Visible = true;
            this.rightPhaseChart.Footer.Font.Size = 8;
            this.rightPhaseChart.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.rightPhaseChart.Footer.ImageBevel.Brush.Solid = true;
            this.rightPhaseChart.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Footer.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.rightPhaseChart.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rightPhaseChart.Header.Brush.Solid = true;
            this.rightPhaseChart.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.rightPhaseChart.Header.Font.Bold = false;
            // 
            // 
            // 
            this.rightPhaseChart.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rightPhaseChart.Header.Font.Brush.Solid = true;
            this.rightPhaseChart.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Header.Font.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Header.Font.Shadow.Brush.Visible = true;
            this.rightPhaseChart.Header.Font.Size = 12;
            this.rightPhaseChart.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.rightPhaseChart.Header.ImageBevel.Brush.Solid = true;
            this.rightPhaseChart.Header.ImageBevel.Brush.Visible = true;
            this.rightPhaseChart.Header.Lines = new string[] {
        "Right channel"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rightPhaseChart.Header.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.rightPhaseChart.Legend.Brush.Color = System.Drawing.Color.White;
            this.rightPhaseChart.Legend.Brush.Solid = true;
            this.rightPhaseChart.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.rightPhaseChart.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.rightPhaseChart.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rightPhaseChart.Legend.Font.Brush.Solid = true;
            this.rightPhaseChart.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Legend.Font.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Legend.Font.Shadow.Brush.Visible = true;
            this.rightPhaseChart.Legend.Font.Size = 9;
            this.rightPhaseChart.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.rightPhaseChart.Legend.ImageBevel.Brush.Solid = true;
            this.rightPhaseChart.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rightPhaseChart.Legend.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Legend.Symbol.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.rightPhaseChart.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.rightPhaseChart.Legend.Title.Brush.Solid = true;
            this.rightPhaseChart.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.rightPhaseChart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.rightPhaseChart.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.rightPhaseChart.Legend.Title.Font.Brush.Solid = true;
            this.rightPhaseChart.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.rightPhaseChart.Legend.Title.Font.Size = 8;
            this.rightPhaseChart.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.rightPhaseChart.Legend.Title.ImageBevel.Brush.Solid = true;
            this.rightPhaseChart.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Legend.Title.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Legend.Title.Shadow.Brush.Visible = true;
            this.rightPhaseChart.Legend.Visible = false;
            this.rightPhaseChart.Location = new System.Drawing.Point(299, 0);
            this.rightPhaseChart.Name = "rightPhaseChart";
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.rightPhaseChart.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rightPhaseChart.Panel.Brush.Solid = true;
            this.rightPhaseChart.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.rightPhaseChart.Panel.ImageBevel.Brush.Solid = true;
            this.rightPhaseChart.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Panel.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Panel.Shadow.Brush.Visible = true;
            this.rightPhaseChart.Series.Add(this.polar2);
            this.rightPhaseChart.Size = new System.Drawing.Size(334, 136);
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.rightPhaseChart.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.rightPhaseChart.SubFooter.Brush.Solid = true;
            this.rightPhaseChart.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.rightPhaseChart.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.rightPhaseChart.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.rightPhaseChart.SubFooter.Font.Brush.Solid = true;
            this.rightPhaseChart.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.SubFooter.Font.Shadow.Brush.Solid = true;
            this.rightPhaseChart.SubFooter.Font.Shadow.Brush.Visible = true;
            this.rightPhaseChart.SubFooter.Font.Size = 8;
            this.rightPhaseChart.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.rightPhaseChart.SubFooter.ImageBevel.Brush.Solid = true;
            this.rightPhaseChart.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.SubFooter.Shadow.Brush.Solid = true;
            this.rightPhaseChart.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.rightPhaseChart.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rightPhaseChart.SubHeader.Brush.Solid = true;
            this.rightPhaseChart.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.rightPhaseChart.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.rightPhaseChart.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rightPhaseChart.SubHeader.Font.Brush.Solid = true;
            this.rightPhaseChart.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.SubHeader.Font.Shadow.Brush.Solid = true;
            this.rightPhaseChart.SubHeader.Font.Shadow.Brush.Visible = true;
            this.rightPhaseChart.SubHeader.Font.Size = 12;
            this.rightPhaseChart.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.rightPhaseChart.SubHeader.ImageBevel.Brush.Solid = true;
            this.rightPhaseChart.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.rightPhaseChart.SubHeader.Shadow.Brush.Solid = true;
            this.rightPhaseChart.SubHeader.Shadow.Brush.Visible = true;
            this.rightPhaseChart.TabIndex = 3;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.rightPhaseChart.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.rightPhaseChart.Walls.Back.Brush.Solid = true;
            this.rightPhaseChart.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.rightPhaseChart.Walls.Back.ImageBevel.Brush.Solid = true;
            this.rightPhaseChart.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Walls.Back.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.rightPhaseChart.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.rightPhaseChart.Walls.Bottom.Brush.Solid = true;
            this.rightPhaseChart.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.rightPhaseChart.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.rightPhaseChart.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Walls.Bottom.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.rightPhaseChart.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.rightPhaseChart.Walls.Left.Brush.Solid = true;
            this.rightPhaseChart.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.rightPhaseChart.Walls.Left.ImageBevel.Brush.Solid = true;
            this.rightPhaseChart.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Walls.Left.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.rightPhaseChart.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.rightPhaseChart.Walls.Right.Brush.Solid = true;
            this.rightPhaseChart.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.rightPhaseChart.Walls.Right.ImageBevel.Brush.Solid = true;
            this.rightPhaseChart.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.rightPhaseChart.Walls.Right.Shadow.Brush.Solid = true;
            this.rightPhaseChart.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.rightPhaseChart.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.rightPhaseChart.Zoom.Brush.Solid = true;
            this.rightPhaseChart.Zoom.Brush.Visible = false;
            // 
            // polar2
            // 
            // 
            // 
            // 
            this.polar2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.polar2.Brush.Solid = true;
            this.polar2.Brush.Visible = false;
            this.polar2.Circled = true;
            // 
            // 
            // 
            this.polar2.CircleLabelsFont.Bold = false;
            // 
            // 
            // 
            this.polar2.CircleLabelsFont.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.polar2.CircleLabelsFont.Brush.Solid = true;
            this.polar2.CircleLabelsFont.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.CircleLabelsFont.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.polar2.CircleLabelsFont.Shadow.Brush.Solid = true;
            this.polar2.CircleLabelsFont.Shadow.Brush.Visible = true;
            this.polar2.CircleLabelsFont.Size = 8;
            this.polar2.CircleLabelsFont.SizeFloat = 8F;
            this.polar2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.polar2.ColorEach = false;
            // 
            // 
            // 
            this.polar2.Font.Bold = false;
            // 
            // 
            // 
            this.polar2.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.polar2.Font.Brush.Solid = true;
            this.polar2.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.polar2.Font.Shadow.Brush.Solid = true;
            this.polar2.Font.Shadow.Brush.Visible = true;
            this.polar2.Font.Size = 8;
            this.polar2.Font.SizeFloat = 8F;
            // 
            // 
            // 
            this.polar2.Frame.Circled = true;
            this.polar2.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
            // 
            // 
            // 
            this.polar2.Frame.InnerBand.Color = System.Drawing.Color.Gray;
            this.polar2.Frame.InnerBand.Solid = true;
            this.polar2.Frame.InnerBand.Visible = true;
            // 
            // 
            // 
            this.polar2.Frame.MiddleBand.Color = System.Drawing.Color.Gray;
            this.polar2.Frame.MiddleBand.Solid = true;
            this.polar2.Frame.MiddleBand.Visible = true;
            // 
            // 
            // 
            this.polar2.Frame.OuterBand.Color = System.Drawing.Color.Gray;
            // 
            // 
            // 
            this.polar2.Frame.OuterBand.Gradient.UseMiddle = false;
            this.polar2.Frame.OuterBand.Solid = true;
            this.polar2.Frame.OuterBand.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.polar2.Legend.Brush.Color = System.Drawing.Color.White;
            this.polar2.Legend.Brush.Solid = true;
            this.polar2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.polar2.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.polar2.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.polar2.Legend.Font.Brush.Solid = true;
            this.polar2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.polar2.Legend.Font.Shadow.Brush.Solid = true;
            this.polar2.Legend.Font.Shadow.Brush.Visible = true;
            this.polar2.Legend.Font.Size = 8;
            this.polar2.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.polar2.Legend.ImageBevel.Brush.Solid = true;
            this.polar2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.polar2.Legend.Shadow.Brush.Solid = true;
            this.polar2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.polar2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.polar2.Marks.Brush.Solid = true;
            this.polar2.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.polar2.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.polar2.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.polar2.Marks.Font.Brush.Solid = true;
            this.polar2.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.polar2.Marks.Font.Shadow.Brush.Solid = true;
            this.polar2.Marks.Font.Shadow.Brush.Visible = true;
            this.polar2.Marks.Font.Size = 8;
            this.polar2.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.polar2.Marks.ImageBevel.Brush.Solid = true;
            this.polar2.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Marks.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.polar2.Marks.Shadow.Brush.Solid = true;
            this.polar2.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.polar2.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.polar2.Marks.Symbol.Brush.Solid = true;
            this.polar2.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.polar2.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.polar2.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.polar2.Marks.Symbol.Shadow.Brush.Solid = true;
            this.polar2.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.polar2.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
            this.polar2.Marks.TailParams.Margin = 0F;
            this.polar2.Marks.TailParams.PointerHeight = 8D;
            this.polar2.Marks.TailParams.PointerWidth = 8D;
            this.polar2.OriginalCursor = null;
            // 
            // 
            // 
            this.polar2.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.polar2.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar2.Pointer.Brush.Color = System.Drawing.Color.Empty;
            this.polar2.Pointer.Brush.Solid = true;
            this.polar2.Pointer.Brush.Visible = true;
            this.polar2.Pointer.HorizSize = 1;
            this.polar2.Pointer.SizeDouble = 0D;
            this.polar2.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.polar2.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.SmallDot;
            this.polar2.Pointer.VertSize = 1;
            this.polar2.Title = "polar1";
            this.polar2.UniqueCustomRadius = true;
            this.polar2.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.polar2.XValues.DataMember = "Angle";
            this.polar2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.polar2.YValues.DataMember = "Y";
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(296, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 136);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // leftPhaseChart
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Aspect.Elevation = 315;
            this.leftPhaseChart.Aspect.ElevationFloat = 315D;
            this.leftPhaseChart.Aspect.Orthogonal = false;
            this.leftPhaseChart.Aspect.Perspective = 0;
            this.leftPhaseChart.Aspect.Rotation = 360;
            this.leftPhaseChart.Aspect.RotationFloat = 360D;
            this.leftPhaseChart.Graphics3D.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            this.leftPhaseChart.Graphics3D.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Automatic = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.leftPhaseChart.Axes.Bottom.Labels.Brush.Solid = true;
            this.leftPhaseChart.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.leftPhaseChart.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.leftPhaseChart.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.leftPhaseChart.Axes.Bottom.Labels.Font.Size = 9;
            this.leftPhaseChart.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.leftPhaseChart.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.leftPhaseChart.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.leftPhaseChart.Axes.Bottom.Title.Brush.Solid = true;
            this.leftPhaseChart.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.leftPhaseChart.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.leftPhaseChart.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.leftPhaseChart.Axes.Bottom.Title.Font.Size = 11;
            this.leftPhaseChart.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.leftPhaseChart.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.leftPhaseChart.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.leftPhaseChart.Axes.Depth.Labels.Brush.Solid = true;
            this.leftPhaseChart.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.leftPhaseChart.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.leftPhaseChart.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.leftPhaseChart.Axes.Depth.Labels.Font.Size = 9;
            this.leftPhaseChart.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.leftPhaseChart.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.leftPhaseChart.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.leftPhaseChart.Axes.Depth.Title.Brush.Solid = true;
            this.leftPhaseChart.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.leftPhaseChart.Axes.Depth.Title.Font.Brush.Solid = true;
            this.leftPhaseChart.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.leftPhaseChart.Axes.Depth.Title.Font.Size = 11;
            this.leftPhaseChart.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.leftPhaseChart.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.leftPhaseChart.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.leftPhaseChart.Axes.DepthTop.Labels.Brush.Solid = true;
            this.leftPhaseChart.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.leftPhaseChart.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.leftPhaseChart.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.leftPhaseChart.Axes.DepthTop.Labels.Font.Size = 9;
            this.leftPhaseChart.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.leftPhaseChart.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.leftPhaseChart.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.leftPhaseChart.Axes.DepthTop.Title.Brush.Solid = true;
            this.leftPhaseChart.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.leftPhaseChart.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.leftPhaseChart.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.leftPhaseChart.Axes.DepthTop.Title.Font.Size = 11;
            this.leftPhaseChart.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.leftPhaseChart.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.leftPhaseChart.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Left.Automatic = false;
            this.leftPhaseChart.Axes.Left.AutomaticMaximum = false;
            this.leftPhaseChart.Axes.Left.AutomaticMinimum = false;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.leftPhaseChart.Axes.Left.Labels.Brush.Solid = true;
            this.leftPhaseChart.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.leftPhaseChart.Axes.Left.Labels.Font.Brush.Solid = true;
            this.leftPhaseChart.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.leftPhaseChart.Axes.Left.Labels.Font.Size = 9;
            this.leftPhaseChart.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.leftPhaseChart.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.leftPhaseChart.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Axes.Left.Labels.Shadow.Brush.Visible = true;
            this.leftPhaseChart.Axes.Left.Maximum = 1D;
            this.leftPhaseChart.Axes.Left.Minimum = 0D;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.leftPhaseChart.Axes.Left.Title.Brush.Solid = true;
            this.leftPhaseChart.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.leftPhaseChart.Axes.Left.Title.Font.Brush.Solid = true;
            this.leftPhaseChart.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.leftPhaseChart.Axes.Left.Title.Font.Size = 11;
            this.leftPhaseChart.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.leftPhaseChart.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.leftPhaseChart.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Right.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.leftPhaseChart.Axes.Right.Labels.Brush.Solid = true;
            this.leftPhaseChart.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.leftPhaseChart.Axes.Right.Labels.Font.Brush.Solid = true;
            this.leftPhaseChart.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.leftPhaseChart.Axes.Right.Labels.Font.Size = 9;
            this.leftPhaseChart.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.leftPhaseChart.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.leftPhaseChart.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.leftPhaseChart.Axes.Right.Title.Brush.Solid = true;
            this.leftPhaseChart.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.leftPhaseChart.Axes.Right.Title.Font.Brush.Solid = true;
            this.leftPhaseChart.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.leftPhaseChart.Axes.Right.Title.Font.Size = 11;
            this.leftPhaseChart.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.leftPhaseChart.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.leftPhaseChart.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.leftPhaseChart.Axes.Top.Labels.Brush.Solid = true;
            this.leftPhaseChart.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.leftPhaseChart.Axes.Top.Labels.Font.Brush.Solid = true;
            this.leftPhaseChart.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.leftPhaseChart.Axes.Top.Labels.Font.Size = 9;
            this.leftPhaseChart.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.leftPhaseChart.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.leftPhaseChart.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.leftPhaseChart.Axes.Top.Title.Brush.Solid = true;
            this.leftPhaseChart.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.leftPhaseChart.Axes.Top.Title.Font.Brush.Solid = true;
            this.leftPhaseChart.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.leftPhaseChart.Axes.Top.Title.Font.Size = 11;
            this.leftPhaseChart.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.leftPhaseChart.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.leftPhaseChart.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.leftPhaseChart.Dock = System.Windows.Forms.DockStyle.Left;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.leftPhaseChart.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.leftPhaseChart.Footer.Brush.Solid = true;
            this.leftPhaseChart.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.leftPhaseChart.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.leftPhaseChart.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.leftPhaseChart.Footer.Font.Brush.Solid = true;
            this.leftPhaseChart.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Footer.Font.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Footer.Font.Shadow.Brush.Visible = true;
            this.leftPhaseChart.Footer.Font.Size = 8;
            this.leftPhaseChart.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.leftPhaseChart.Footer.ImageBevel.Brush.Solid = true;
            this.leftPhaseChart.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Footer.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.leftPhaseChart.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.leftPhaseChart.Header.Brush.Solid = true;
            this.leftPhaseChart.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.leftPhaseChart.Header.Font.Bold = false;
            // 
            // 
            // 
            this.leftPhaseChart.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.leftPhaseChart.Header.Font.Brush.Solid = true;
            this.leftPhaseChart.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Header.Font.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Header.Font.Shadow.Brush.Visible = true;
            this.leftPhaseChart.Header.Font.Size = 12;
            this.leftPhaseChart.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.leftPhaseChart.Header.ImageBevel.Brush.Solid = true;
            this.leftPhaseChart.Header.ImageBevel.Brush.Visible = true;
            this.leftPhaseChart.Header.Lines = new string[] {
        "Left channel"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.leftPhaseChart.Header.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.leftPhaseChart.Legend.Brush.Color = System.Drawing.Color.White;
            this.leftPhaseChart.Legend.Brush.Solid = true;
            this.leftPhaseChart.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.leftPhaseChart.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.leftPhaseChart.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.leftPhaseChart.Legend.Font.Brush.Solid = true;
            this.leftPhaseChart.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Legend.Font.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Legend.Font.Shadow.Brush.Visible = true;
            this.leftPhaseChart.Legend.Font.Size = 9;
            this.leftPhaseChart.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.leftPhaseChart.Legend.ImageBevel.Brush.Solid = true;
            this.leftPhaseChart.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.leftPhaseChart.Legend.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Legend.Symbol.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.leftPhaseChart.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.leftPhaseChart.Legend.Title.Brush.Solid = true;
            this.leftPhaseChart.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.leftPhaseChart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.leftPhaseChart.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.leftPhaseChart.Legend.Title.Font.Brush.Solid = true;
            this.leftPhaseChart.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.leftPhaseChart.Legend.Title.Font.Size = 8;
            this.leftPhaseChart.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.leftPhaseChart.Legend.Title.ImageBevel.Brush.Solid = true;
            this.leftPhaseChart.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Legend.Title.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Legend.Title.Shadow.Brush.Visible = true;
            this.leftPhaseChart.Legend.Visible = false;
            this.leftPhaseChart.Location = new System.Drawing.Point(0, 0);
            this.leftPhaseChart.Name = "leftPhaseChart";
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.leftPhaseChart.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.leftPhaseChart.Panel.Brush.Solid = true;
            this.leftPhaseChart.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.leftPhaseChart.Panel.ImageBevel.Brush.Solid = true;
            this.leftPhaseChart.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Panel.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Panel.Shadow.Brush.Visible = true;
            this.leftPhaseChart.Series.Add(this.polar1);
            this.leftPhaseChart.Size = new System.Drawing.Size(296, 136);
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.leftPhaseChart.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.leftPhaseChart.SubFooter.Brush.Solid = true;
            this.leftPhaseChart.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.leftPhaseChart.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.leftPhaseChart.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.leftPhaseChart.SubFooter.Font.Brush.Solid = true;
            this.leftPhaseChart.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.SubFooter.Font.Shadow.Brush.Solid = true;
            this.leftPhaseChart.SubFooter.Font.Shadow.Brush.Visible = true;
            this.leftPhaseChart.SubFooter.Font.Size = 8;
            this.leftPhaseChart.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.leftPhaseChart.SubFooter.ImageBevel.Brush.Solid = true;
            this.leftPhaseChart.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.SubFooter.Shadow.Brush.Solid = true;
            this.leftPhaseChart.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.leftPhaseChart.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.leftPhaseChart.SubHeader.Brush.Solid = true;
            this.leftPhaseChart.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.leftPhaseChart.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.leftPhaseChart.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.leftPhaseChart.SubHeader.Font.Brush.Solid = true;
            this.leftPhaseChart.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.SubHeader.Font.Shadow.Brush.Solid = true;
            this.leftPhaseChart.SubHeader.Font.Shadow.Brush.Visible = true;
            this.leftPhaseChart.SubHeader.Font.Size = 12;
            this.leftPhaseChart.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.leftPhaseChart.SubHeader.ImageBevel.Brush.Solid = true;
            this.leftPhaseChart.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.leftPhaseChart.SubHeader.Shadow.Brush.Solid = true;
            this.leftPhaseChart.SubHeader.Shadow.Brush.Visible = true;
            this.leftPhaseChart.TabIndex = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.leftPhaseChart.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.leftPhaseChart.Walls.Back.Brush.Solid = true;
            this.leftPhaseChart.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.leftPhaseChart.Walls.Back.ImageBevel.Brush.Solid = true;
            this.leftPhaseChart.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Walls.Back.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.leftPhaseChart.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.leftPhaseChart.Walls.Bottom.Brush.Solid = true;
            this.leftPhaseChart.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.leftPhaseChart.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.leftPhaseChart.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Walls.Bottom.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.leftPhaseChart.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.leftPhaseChart.Walls.Left.Brush.Solid = true;
            this.leftPhaseChart.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.leftPhaseChart.Walls.Left.ImageBevel.Brush.Solid = true;
            this.leftPhaseChart.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Walls.Left.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.leftPhaseChart.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.leftPhaseChart.Walls.Right.Brush.Solid = true;
            this.leftPhaseChart.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.leftPhaseChart.Walls.Right.ImageBevel.Brush.Solid = true;
            this.leftPhaseChart.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.leftPhaseChart.Walls.Right.Shadow.Brush.Solid = true;
            this.leftPhaseChart.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.leftPhaseChart.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.leftPhaseChart.Zoom.Brush.Solid = true;
            this.leftPhaseChart.Zoom.Brush.Visible = false;
            // 
            // polar1
            // 
            // 
            // 
            // 
            this.polar1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.polar1.Brush.Solid = true;
            this.polar1.Brush.Visible = false;
            this.polar1.Circled = true;
            // 
            // 
            // 
            this.polar1.CircleLabelsFont.Bold = false;
            // 
            // 
            // 
            this.polar1.CircleLabelsFont.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.polar1.CircleLabelsFont.Brush.Solid = true;
            this.polar1.CircleLabelsFont.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.CircleLabelsFont.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.polar1.CircleLabelsFont.Shadow.Brush.Solid = true;
            this.polar1.CircleLabelsFont.Shadow.Brush.Visible = true;
            this.polar1.CircleLabelsFont.Size = 8;
            this.polar1.CircleLabelsFont.SizeFloat = 8F;
            // 
            // 
            // 
            this.polar1.CirclePen.Visible = false;
            this.polar1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.polar1.ColorEach = false;
            // 
            // 
            // 
            this.polar1.Font.Bold = false;
            // 
            // 
            // 
            this.polar1.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.polar1.Font.Brush.Solid = true;
            this.polar1.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.polar1.Font.Shadow.Brush.Solid = true;
            this.polar1.Font.Shadow.Brush.Visible = true;
            this.polar1.Font.Size = 8;
            this.polar1.Font.SizeFloat = 8F;
            // 
            // 
            // 
            this.polar1.Frame.Circled = true;
            this.polar1.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
            // 
            // 
            // 
            this.polar1.Frame.InnerBand.Color = System.Drawing.Color.Gray;
            this.polar1.Frame.InnerBand.Solid = true;
            this.polar1.Frame.InnerBand.Visible = true;
            // 
            // 
            // 
            this.polar1.Frame.MiddleBand.Color = System.Drawing.Color.Gray;
            this.polar1.Frame.MiddleBand.Solid = true;
            this.polar1.Frame.MiddleBand.Visible = true;
            // 
            // 
            // 
            this.polar1.Frame.OuterBand.Color = System.Drawing.Color.Gray;
            // 
            // 
            // 
            this.polar1.Frame.OuterBand.Gradient.UseMiddle = false;
            this.polar1.Frame.OuterBand.Solid = true;
            this.polar1.Frame.OuterBand.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.polar1.Legend.Brush.Color = System.Drawing.Color.White;
            this.polar1.Legend.Brush.Solid = true;
            this.polar1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.polar1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.polar1.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.polar1.Legend.Font.Brush.Solid = true;
            this.polar1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.polar1.Legend.Font.Shadow.Brush.Solid = true;
            this.polar1.Legend.Font.Shadow.Brush.Visible = true;
            this.polar1.Legend.Font.Size = 8;
            this.polar1.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.polar1.Legend.ImageBevel.Brush.Solid = true;
            this.polar1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.polar1.Legend.Shadow.Brush.Solid = true;
            this.polar1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.polar1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.polar1.Marks.Brush.Solid = true;
            this.polar1.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.polar1.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.polar1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.polar1.Marks.Font.Brush.Solid = true;
            this.polar1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.polar1.Marks.Font.Shadow.Brush.Solid = true;
            this.polar1.Marks.Font.Shadow.Brush.Visible = true;
            this.polar1.Marks.Font.Size = 8;
            this.polar1.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.polar1.Marks.ImageBevel.Brush.Solid = true;
            this.polar1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Marks.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.polar1.Marks.Shadow.Brush.Solid = true;
            this.polar1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.polar1.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.polar1.Marks.Symbol.Brush.Solid = true;
            this.polar1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.polar1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.polar1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.polar1.Marks.Symbol.Shadow.Brush.Solid = true;
            this.polar1.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.polar1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos2")));
            this.polar1.Marks.TailParams.Margin = 0F;
            this.polar1.Marks.TailParams.PointerHeight = 8D;
            this.polar1.Marks.TailParams.PointerWidth = 8D;
            this.polar1.OriginalCursor = null;
            // 
            // 
            // 
            this.polar1.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.polar1.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.polar1.Pointer.Brush.Color = System.Drawing.Color.Empty;
            this.polar1.Pointer.Brush.Solid = true;
            this.polar1.Pointer.Brush.Visible = true;
            this.polar1.Pointer.Dark3D = false;
            this.polar1.Pointer.Draw3D = false;
            this.polar1.Pointer.HorizSize = 1;
            this.polar1.Pointer.SizeDouble = 0D;
            this.polar1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.polar1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.SmallDot;
            this.polar1.Pointer.VertSize = 1;
            this.polar1.Title = "polar1";
            this.polar1.UniqueCustomRadius = true;
            this.polar1.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.polar1.XValues.DataMember = "Angle";
            this.polar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.polar1.YValues.DataMember = "Y";
            // 
            // signalChart1
            // 
            // 
            // 
            // 
            this.signalChart1.Graphics3D.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
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
            this.signalChart1.Axes.Bottom.Title.Caption = "Time[s]";
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
        "Time[s]"};
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
            this.signalChart1.Axes.Right.AxisPen.Visible = true;
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
            this.signalChart1.Axes.Right.Visible = false;
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
            this.signalChart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.signalChart1.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            this.signalChart1.Location = new System.Drawing.Point(0, 136);
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
            this.signalChart1.Series.Add(this.fastLine1);
            signalTeeItem1.Caption = null;
            signalTeeItem1.Input = this.Signal1;
            signalTeeItem1.Inputs = null;
            signalTeeItem1.InputsItemIndex = 0;
            signalTeeItem1.Series = this.fastLine1;
            signalTeeItem1.SeriesName = "fastLine1";
            this.signalChart1.Signals.Add(signalTeeItem1);
            this.signalChart1.Size = new System.Drawing.Size(633, 161);
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
            this.signalChart1.TabIndex = 0;
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
            // chartEditor
            // 
            this.chartEditor.Chart = this.signalChart1;
            this.chartEditor.HighLightTabs = false;
            this.chartEditor.Location = new System.Drawing.Point(0, 0);
            this.chartEditor.Name = "chartEditor";
            this.chartEditor.Options = null;
            this.chartEditor.TabIndex = 0;
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
            // SignalIn1
            // 
            this.SignalIn1.BandwidthL = 0D;
            this.SignalIn1.BlockAssign = false;
            this.SignalIn1.CalibrationTarget = 0;
            this.SignalIn1.ChannelCount = 2;
            this.SignalIn1.Complex = false;
            this.SignalIn1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.SignalIn1.FloatPrecisionLock = false;
            this.SignalIn1.Input = null;
            this.SignalIn1.IsDouble = true;
            this.SignalIn1.Name = null;
            this.SignalIn1.Quantization = ((ushort)(16));
            this.SignalIn1.SamplingFrequency = 11025D;
            this.SignalIn1.TriggerAbove = 0D;
            this.SignalIn1.TriggerBelow = 0D;
            this.SignalIn1.TriggerChannel = Dew.Signal.TChannel.chLeft;
            this.SignalIn1.TriggerDelay = 0;
            this.SignalIn1.Triggering = Dew.Signal.TriggerType.trNone;
            this.SignalIn1.TriggerMode = Dew.Signal.TriggerMode.trCrossing;
            this.SignalIn1.TriggerPosition = Dew.Signal.TriggerPosition.tpAfter;
            // 
            // SignalTimer1
            // 
            this.SignalTimer1.BlockAssign = false;
            this.SignalTimer1.Frequency = 5D;
            this.SignalTimer1.Interval = ((uint)(200u));
            this.SignalTimer1.Name = null;
            this.SignalTimer1.Resolution = ((uint)(10u));
            this.SignalTimer1.OnTimer += new System.EventHandler(this.SignalTimer1_OnTimer);
            // 
            // PhaseScopeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 448);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "PhaseScopeForm";
            this.Text = "PhaseScopeForm";
            this.Load += new System.EventHandler(this.PhaseScopeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.signalChart1)).EndInit();
            this.ResumeLayout(false);

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
		private Dew.Signal.SignalIn SignalIn1;
		private Dew.Signal.SignalTimer SignalTimer1;
		private Steema.TeeChart.TChart rightPhaseChart;
		private Steema.TeeChart.Styles.Polar polar2;
		private Steema.TeeChart.Styles.FastLine fastLine1;
	}
}