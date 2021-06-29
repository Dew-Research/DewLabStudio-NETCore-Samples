namespace DSPDemo {
	partial class LissajousScopeForm {
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
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LissajousScopeForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.samplesBox = new System.Windows.Forms.ComboBox();
            this.phaseChart = new Steema.TeeChart.TChart();
            this.polar1 = new Steema.TeeChart.Styles.Polar();
            this.SignalIn1 = new Dew.Signal.SignalIn(this.components);
            this.Signal1 = new Dew.Signal.TSignal(this.components);
            this.Signal2 = new Dew.Signal.TSignal(this.components);
            this.SignalTimer1 = new Dew.Signal.SignalTimer(this.components);
            this.chartEditor = new Steema.TeeChart.Editor(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(775, 110);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.samplesBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 480);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 63);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Chart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Samples:";
            // 
            // samplesBox
            // 
            this.samplesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.samplesBox.FormattingEnabled = true;
            this.samplesBox.Items.AddRange(new object[] {
            "500",
            "1000",
            "2000",
            "3000",
            "4000",
            "8000",
            "16000"});
            this.samplesBox.Location = new System.Drawing.Point(204, 25);
            this.samplesBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.samplesBox.Name = "samplesBox";
            this.samplesBox.Size = new System.Drawing.Size(140, 23);
            this.samplesBox.TabIndex = 0;
            this.samplesBox.SelectedIndexChanged += new System.EventHandler(this.samplesBox_SelectedIndexChanged);
            // 
            // phaseChart
            // 
            // 
            // 
            // 
            this.phaseChart.Aspect.Elevation = 315;
            this.phaseChart.Aspect.ElevationFloat = 315D;
            this.phaseChart.Aspect.Orthogonal = false;
            this.phaseChart.Aspect.Perspective = 0;
            this.phaseChart.Aspect.Rotation = 360;
            this.phaseChart.Aspect.RotationFloat = 360D;
            // 
            // 
            // 
            this.phaseChart.Axes.Automatic = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Bottom.Automatic = false;
            this.phaseChart.Axes.Bottom.AutomaticMaximum = false;
            this.phaseChart.Axes.Bottom.AutomaticMinimum = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Bottom.Grid.Visible = false;
            this.phaseChart.Axes.Bottom.Increment = 45D;
            // 
            // 
            // 
            this.phaseChart.Axes.Bottom.Labels.Axis = this.phaseChart.Axes.Bottom;
            // 
            // 
            // 
            this.phaseChart.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.phaseChart.Axes.Bottom.Labels.Brush.Solid = true;
            this.phaseChart.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.phaseChart.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.phaseChart.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.phaseChart.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.phaseChart.Axes.Bottom.Labels.Font.Size = 9;
            this.phaseChart.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            this.phaseChart.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.phaseChart.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.phaseChart.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.phaseChart.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            this.phaseChart.Axes.Bottom.Labels.Visible = false;
            this.phaseChart.Axes.Bottom.Maximum = 360D;
            this.phaseChart.Axes.Bottom.Minimum = 0D;
            // 
            // 
            // 
            this.phaseChart.Axes.Bottom.MinorTicks.Length = 2;
            this.phaseChart.Axes.Bottom.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Bottom.Ticks.Length = 4;
            this.phaseChart.Axes.Bottom.Ticks.Visible = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Bottom.TicksInner.Length = 0;
            this.phaseChart.Axes.Bottom.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.phaseChart.Axes.Bottom.Title.Brush.Solid = true;
            this.phaseChart.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phaseChart.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.phaseChart.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.phaseChart.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.phaseChart.Axes.Bottom.Title.Font.Size = 11;
            this.phaseChart.Axes.Bottom.Title.Font.SizeFloat = 11F;
            this.phaseChart.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.phaseChart.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.phaseChart.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.phaseChart.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Axes.Depth.Automatic = false;
            this.phaseChart.Axes.Depth.AutomaticMaximum = false;
            this.phaseChart.Axes.Depth.AutomaticMinimum = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Depth.AxisPen.Visible = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Depth.Labels.Axis = this.phaseChart.Axes.Depth;
            // 
            // 
            // 
            this.phaseChart.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.phaseChart.Axes.Depth.Labels.Brush.Solid = true;
            this.phaseChart.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.phaseChart.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.phaseChart.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.phaseChart.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.phaseChart.Axes.Depth.Labels.Font.Size = 9;
            this.phaseChart.Axes.Depth.Labels.Font.SizeFloat = 9F;
            this.phaseChart.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.phaseChart.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.phaseChart.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.phaseChart.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            this.phaseChart.Axes.Depth.Maximum = 0D;
            this.phaseChart.Axes.Depth.Minimum = 0D;
            // 
            // 
            // 
            this.phaseChart.Axes.Depth.MinorTicks.Length = 2;
            this.phaseChart.Axes.Depth.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Depth.Ticks.Length = 4;
            this.phaseChart.Axes.Depth.Ticks.Visible = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Depth.TicksInner.Length = 0;
            this.phaseChart.Axes.Depth.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.phaseChart.Axes.Depth.Title.Brush.Solid = true;
            this.phaseChart.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phaseChart.Axes.Depth.Title.Font.Brush.Solid = true;
            this.phaseChart.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.phaseChart.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.phaseChart.Axes.Depth.Title.Font.Size = 11;
            this.phaseChart.Axes.Depth.Title.Font.SizeFloat = 11F;
            this.phaseChart.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.phaseChart.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.phaseChart.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.phaseChart.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Axes.DepthTop.Automatic = false;
            this.phaseChart.Axes.DepthTop.AutomaticMaximum = false;
            this.phaseChart.Axes.DepthTop.AutomaticMinimum = false;
            // 
            // 
            // 
            this.phaseChart.Axes.DepthTop.AxisPen.Visible = false;
            // 
            // 
            // 
            this.phaseChart.Axes.DepthTop.Labels.Axis = this.phaseChart.Axes.DepthTop;
            // 
            // 
            // 
            this.phaseChart.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.phaseChart.Axes.DepthTop.Labels.Brush.Solid = true;
            this.phaseChart.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.phaseChart.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.phaseChart.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.phaseChart.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.phaseChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.phaseChart.Axes.DepthTop.Labels.Font.Size = 9;
            this.phaseChart.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            this.phaseChart.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.phaseChart.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.phaseChart.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.phaseChart.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            this.phaseChart.Axes.DepthTop.Maximum = 0D;
            this.phaseChart.Axes.DepthTop.Minimum = 0D;
            // 
            // 
            // 
            this.phaseChart.Axes.DepthTop.MinorTicks.Length = 2;
            this.phaseChart.Axes.DepthTop.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.phaseChart.Axes.DepthTop.Ticks.Length = 4;
            this.phaseChart.Axes.DepthTop.Ticks.Visible = false;
            // 
            // 
            // 
            this.phaseChart.Axes.DepthTop.TicksInner.Length = 0;
            this.phaseChart.Axes.DepthTop.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.phaseChart.Axes.DepthTop.Title.Brush.Solid = true;
            this.phaseChart.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.phaseChart.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phaseChart.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.phaseChart.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.phaseChart.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.phaseChart.Axes.DepthTop.Title.Font.Size = 11;
            this.phaseChart.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            this.phaseChart.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.phaseChart.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.phaseChart.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.phaseChart.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Axes.Left.Automatic = false;
            this.phaseChart.Axes.Left.AutomaticMaximum = false;
            this.phaseChart.Axes.Left.AutomaticMinimum = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Left.Labels.Axis = this.phaseChart.Axes.Left;
            // 
            // 
            // 
            this.phaseChart.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.phaseChart.Axes.Left.Labels.Brush.Solid = true;
            this.phaseChart.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.phaseChart.Axes.Left.Labels.Font.Brush.Solid = true;
            this.phaseChart.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.phaseChart.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.phaseChart.Axes.Left.Labels.Font.Size = 9;
            this.phaseChart.Axes.Left.Labels.Font.SizeFloat = 9F;
            this.phaseChart.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.phaseChart.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.phaseChart.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.phaseChart.Axes.Left.Labels.Shadow.Brush.Visible = true;
            this.phaseChart.Axes.Left.Labels.Visible = false;
            this.phaseChart.Axes.Left.Maximum = 1D;
            this.phaseChart.Axes.Left.Minimum = 0D;
            // 
            // 
            // 
            this.phaseChart.Axes.Left.MinorTicks.Length = 2;
            this.phaseChart.Axes.Left.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Left.Ticks.Length = 4;
            this.phaseChart.Axes.Left.Ticks.Visible = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Left.TicksInner.Length = 0;
            this.phaseChart.Axes.Left.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.phaseChart.Axes.Left.Title.Brush.Solid = true;
            this.phaseChart.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phaseChart.Axes.Left.Title.Font.Brush.Solid = true;
            this.phaseChart.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.phaseChart.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.phaseChart.Axes.Left.Title.Font.Size = 11;
            this.phaseChart.Axes.Left.Title.Font.SizeFloat = 11F;
            this.phaseChart.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.phaseChart.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.phaseChart.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.phaseChart.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Axes.Right.Automatic = false;
            this.phaseChart.Axes.Right.AutomaticMaximum = false;
            this.phaseChart.Axes.Right.AutomaticMinimum = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Right.Labels.Axis = this.phaseChart.Axes.Right;
            // 
            // 
            // 
            this.phaseChart.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.phaseChart.Axes.Right.Labels.Brush.Solid = true;
            this.phaseChart.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.phaseChart.Axes.Right.Labels.Font.Brush.Solid = true;
            this.phaseChart.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.phaseChart.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.phaseChart.Axes.Right.Labels.Font.Size = 9;
            this.phaseChart.Axes.Right.Labels.Font.SizeFloat = 9F;
            this.phaseChart.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.phaseChart.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.phaseChart.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.phaseChart.Axes.Right.Labels.Shadow.Brush.Visible = true;
            this.phaseChart.Axes.Right.Labels.Visible = false;
            this.phaseChart.Axes.Right.Maximum = 0D;
            this.phaseChart.Axes.Right.Minimum = 0D;
            // 
            // 
            // 
            this.phaseChart.Axes.Right.MinorTicks.Length = 2;
            this.phaseChart.Axes.Right.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Right.Ticks.Length = 4;
            this.phaseChart.Axes.Right.Ticks.Visible = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Right.TicksInner.Length = 0;
            this.phaseChart.Axes.Right.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.phaseChart.Axes.Right.Title.Brush.Solid = true;
            this.phaseChart.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phaseChart.Axes.Right.Title.Font.Brush.Solid = true;
            this.phaseChart.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.phaseChart.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.phaseChart.Axes.Right.Title.Font.Size = 11;
            this.phaseChart.Axes.Right.Title.Font.SizeFloat = 11F;
            this.phaseChart.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.phaseChart.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.phaseChart.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.phaseChart.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Axes.Top.Automatic = false;
            this.phaseChart.Axes.Top.AutomaticMaximum = false;
            this.phaseChart.Axes.Top.AutomaticMinimum = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Top.Labels.Axis = this.phaseChart.Axes.Top;
            // 
            // 
            // 
            this.phaseChart.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.phaseChart.Axes.Top.Labels.Brush.Solid = true;
            this.phaseChart.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.phaseChart.Axes.Top.Labels.Font.Brush.Solid = true;
            this.phaseChart.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.phaseChart.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.phaseChart.Axes.Top.Labels.Font.Size = 9;
            this.phaseChart.Axes.Top.Labels.Font.SizeFloat = 9F;
            this.phaseChart.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.phaseChart.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.phaseChart.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.phaseChart.Axes.Top.Labels.Shadow.Brush.Visible = true;
            this.phaseChart.Axes.Top.Labels.Visible = false;
            this.phaseChart.Axes.Top.Maximum = 0D;
            this.phaseChart.Axes.Top.Minimum = 0D;
            // 
            // 
            // 
            this.phaseChart.Axes.Top.MinorTicks.Length = 2;
            this.phaseChart.Axes.Top.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Top.Ticks.Length = 4;
            this.phaseChart.Axes.Top.Ticks.Visible = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Top.TicksInner.Length = 0;
            this.phaseChart.Axes.Top.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.phaseChart.Axes.Top.Title.Brush.Solid = true;
            this.phaseChart.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.phaseChart.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phaseChart.Axes.Top.Title.Font.Brush.Solid = true;
            this.phaseChart.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.phaseChart.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.phaseChart.Axes.Top.Title.Font.Size = 11;
            this.phaseChart.Axes.Top.Title.Font.SizeFloat = 11F;
            this.phaseChart.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.phaseChart.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.phaseChart.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.phaseChart.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.phaseChart.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.phaseChart.Footer.Brush.Solid = true;
            this.phaseChart.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.phaseChart.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.phaseChart.Footer.Font.Brush.Solid = true;
            this.phaseChart.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Footer.Font.Shadow.Brush.Solid = true;
            this.phaseChart.Footer.Font.Shadow.Brush.Visible = true;
            this.phaseChart.Footer.Font.Size = 8;
            this.phaseChart.Footer.Font.SizeFloat = 8F;
            this.phaseChart.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.phaseChart.Footer.ImageBevel.Brush.Solid = true;
            this.phaseChart.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Footer.Shadow.Brush.Solid = true;
            this.phaseChart.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.phaseChart.Header.Brush.Solid = true;
            this.phaseChart.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Header.Font.Bold = false;
            // 
            // 
            // 
            this.phaseChart.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.phaseChart.Header.Font.Brush.Solid = true;
            this.phaseChart.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Header.Font.Shadow.Brush.Solid = true;
            this.phaseChart.Header.Font.Shadow.Brush.Visible = true;
            this.phaseChart.Header.Font.Size = 12;
            this.phaseChart.Header.Font.SizeFloat = 12F;
            this.phaseChart.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.phaseChart.Header.ImageBevel.Brush.Solid = true;
            this.phaseChart.Header.ImageBevel.Brush.Visible = true;
            this.phaseChart.Header.Lines = new string[] {
        "Lissajous"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.phaseChart.Header.Shadow.Brush.Solid = true;
            this.phaseChart.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Legend.Brush.Color = System.Drawing.Color.White;
            this.phaseChart.Legend.Brush.Solid = true;
            this.phaseChart.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.phaseChart.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phaseChart.Legend.Font.Brush.Solid = true;
            this.phaseChart.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Legend.Font.Shadow.Brush.Solid = true;
            this.phaseChart.Legend.Font.Shadow.Brush.Visible = true;
            this.phaseChart.Legend.Font.Size = 9;
            this.phaseChart.Legend.Font.SizeFloat = 9F;
            this.phaseChart.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.phaseChart.Legend.ImageBevel.Brush.Solid = true;
            this.phaseChart.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Legend.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.phaseChart.Legend.Shadow.Brush.Solid = true;
            this.phaseChart.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Legend.Symbol.Legend = this.phaseChart.Legend;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Legend.Symbol.Shadow.Brush.Solid = true;
            this.phaseChart.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.phaseChart.Legend.Title.Brush.Solid = true;
            this.phaseChart.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.phaseChart.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.phaseChart.Legend.Title.Font.Brush.Solid = true;
            this.phaseChart.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.phaseChart.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.phaseChart.Legend.Title.Font.Size = 8;
            this.phaseChart.Legend.Title.Font.SizeFloat = 8F;
            this.phaseChart.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.phaseChart.Legend.Title.ImageBevel.Brush.Solid = true;
            this.phaseChart.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Legend.Title.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Legend.Title.Shadow.Brush.Solid = true;
            this.phaseChart.Legend.Title.Shadow.Brush.Visible = true;
            this.phaseChart.Legend.Visible = false;
            this.phaseChart.Location = new System.Drawing.Point(0, 110);
            this.phaseChart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phaseChart.Name = "phaseChart";
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.phaseChart.Panel.Brush.Gradient.UseMiddle = true;
            this.phaseChart.Panel.Brush.Solid = true;
            this.phaseChart.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.phaseChart.Panel.ImageBevel.Brush.Solid = true;
            this.phaseChart.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.Panel.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Panel.Shadow.Brush.Solid = true;
            this.phaseChart.Panel.Shadow.Brush.Visible = true;
            this.phaseChart.Series.Add(this.polar1);
            this.phaseChart.Size = new System.Drawing.Size(775, 370);
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.phaseChart.SubFooter.Brush.Solid = true;
            this.phaseChart.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.phaseChart.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.phaseChart.SubFooter.Font.Brush.Solid = true;
            this.phaseChart.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.SubFooter.Font.Shadow.Brush.Solid = true;
            this.phaseChart.SubFooter.Font.Shadow.Brush.Visible = true;
            this.phaseChart.SubFooter.Font.Size = 8;
            this.phaseChart.SubFooter.Font.SizeFloat = 8F;
            this.phaseChart.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.phaseChart.SubFooter.ImageBevel.Brush.Solid = true;
            this.phaseChart.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.SubFooter.Shadow.Brush.Solid = true;
            this.phaseChart.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.phaseChart.SubHeader.Brush.Solid = true;
            this.phaseChart.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.phaseChart.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.phaseChart.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.phaseChart.SubHeader.Font.Brush.Solid = true;
            this.phaseChart.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.SubHeader.Font.Shadow.Brush.Solid = true;
            this.phaseChart.SubHeader.Font.Shadow.Brush.Visible = true;
            this.phaseChart.SubHeader.Font.Size = 12;
            this.phaseChart.SubHeader.Font.SizeFloat = 12F;
            this.phaseChart.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.phaseChart.SubHeader.ImageBevel.Brush.Solid = true;
            this.phaseChart.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.phaseChart.SubHeader.Shadow.Brush.Solid = true;
            this.phaseChart.SubHeader.Shadow.Brush.Visible = true;
            this.phaseChart.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.phaseChart.Walls.Back.Brush.Solid = true;
            this.phaseChart.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.phaseChart.Walls.Back.ImageBevel.Brush.Solid = true;
            this.phaseChart.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Walls.Back.Shadow.Brush.Solid = true;
            this.phaseChart.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.phaseChart.Walls.Bottom.Brush.Solid = true;
            this.phaseChart.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.phaseChart.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.phaseChart.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Walls.Bottom.Shadow.Brush.Solid = true;
            this.phaseChart.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.phaseChart.Walls.Left.Brush.Solid = true;
            this.phaseChart.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.phaseChart.Walls.Left.ImageBevel.Brush.Solid = true;
            this.phaseChart.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Walls.Left.Shadow.Brush.Solid = true;
            this.phaseChart.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.phaseChart.Walls.Right.Brush.Solid = true;
            this.phaseChart.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.phaseChart.Walls.Right.ImageBevel.Brush.Solid = true;
            this.phaseChart.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.phaseChart.Walls.Right.Shadow.Brush.Solid = true;
            this.phaseChart.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.phaseChart.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.phaseChart.Zoom.Brush.Solid = true;
            this.phaseChart.Zoom.Brush.Visible = false;
            this.phaseChart.Zoom.FullRepaint = true;
            // 
            // 
            // 
            this.phaseChart.Zoom.Pen.Visible = true;
            // 
            // polar1
            // 
            // 
            // 
            // 
            this.polar1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.polar1.CircleLabelsFont.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            this.polar1.CirclePen.Visible = false;
            this.polar1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.polar1.ColorEach = false;
            cursor1.CursorType = Steema.TeeChart.Drawing.CursorType.Default;
            this.polar1.Cursor = cursor1;
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
            this.polar1.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            // 
            // 
            // 
            this.polar1.Frame.MiddleBand.Gradient.UseMiddle = true;
            this.polar1.Frame.MiddleBand.Gradient.Visible = true;
            this.polar1.Frame.MiddleBand.Solid = true;
            this.polar1.Frame.MiddleBand.Visible = true;
            // 
            // 
            // 
            this.polar1.Frame.OuterBand.Color = System.Drawing.Color.Gray;
            // 
            // 
            // 
            this.polar1.Frame.OuterBand.Gradient.Visible = true;
            this.polar1.Frame.OuterBand.Solid = true;
            this.polar1.Frame.OuterBand.Visible = true;
            // 
            // 
            // 
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
            this.polar1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.polar1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
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
            this.polar1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
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
            this.polar1.Pointer.HorizSize = 2;
            this.polar1.Pointer.SizeDouble = 0D;
            this.polar1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.polar1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.SmallDot;
            this.polar1.Pointer.VertSize = 2;
            this.polar1.RandomData = true;
            this.polar1.Title = "polar1";
            this.polar1.Type = "Steema.TeeChart.Styles.Polar";
            this.polar1.UniqueCustomRadius = true;
            this.polar1.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.polar1.XValues.DataMember = "Angle";
            this.polar1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.polar1.XValues.Series = this.polar1;
            // 
            // 
            // 
            this.polar1.YValues.DataMember = "Y";
            this.polar1.YValues.Series = this.polar1;
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
            this.SignalIn1.Length = 128;
            this.SignalIn1.Name = null;
            this.SignalIn1.OnAfterUpdate = null;
            this.SignalIn1.OnBeforeUpdate = null;
            this.SignalIn1.OnDisplayUpdate = null;
            this.SignalIn1.OnGetInput = null;
            this.SignalIn1.OnNotifyUpdate = null;
            this.SignalIn1.OnParameterUpdate = null;
            this.SignalIn1.Quantization = ((ushort)(16));
            this.SignalIn1.SamplingFrequency = 44100D;
            this.SignalIn1.TriggerAbove = 0D;
            this.SignalIn1.TriggerBelow = 0D;
            this.SignalIn1.TriggerChannel = Dew.Signal.TChannel.chLeft;
            this.SignalIn1.TriggerDelay = 0;
            this.SignalIn1.Triggering = Dew.Signal.TriggerType.trNone;
            this.SignalIn1.TriggerMode = Dew.Signal.TriggerMode.trCrossing;
            this.SignalIn1.TriggerPosition = Dew.Signal.TriggerPosition.tpAfter;
            // 
            // Signal1
            // 
            this.Signal1.BandwidthL = 0D;
            this.Signal1.BlockAssign = false;
            this.Signal1.ChannelCount = 1;
            this.Signal1.Complex = false;
            this.Signal1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.Signal1.FloatPrecisionLock = false;
            this.Signal1.Input = null;
            this.Signal1.IsDouble = true;
            this.Signal1.Length = 128;
            this.Signal1.Name = null;
            this.Signal1.OnAfterUpdate = null;
            this.Signal1.OnBeforeUpdate = null;
            this.Signal1.OnDisplayUpdate = null;
            this.Signal1.OnGetInput = null;
            this.Signal1.OnNotifyUpdate = null;
            this.Signal1.OnParameterUpdate = null;
            // 
            // Signal2
            // 
            this.Signal2.BandwidthL = 0D;
            this.Signal2.BlockAssign = false;
            this.Signal2.ChannelCount = 1;
            this.Signal2.Complex = false;
            this.Signal2.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.Signal2.FloatPrecisionLock = false;
            this.Signal2.Input = null;
            this.Signal2.IsDouble = true;
            this.Signal2.Length = 128;
            this.Signal2.Name = null;
            this.Signal2.OnAfterUpdate = null;
            this.Signal2.OnBeforeUpdate = null;
            this.Signal2.OnDisplayUpdate = null;
            this.Signal2.OnGetInput = null;
            this.Signal2.OnNotifyUpdate = null;
            this.Signal2.OnParameterUpdate = null;
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
            // chartEditor
            // 
            this.chartEditor.AlwaysShowFuncSrc = false;
            this.chartEditor.Chart = this.phaseChart;
            this.chartEditor.HighLightTabs = false;
            this.chartEditor.Location = new System.Drawing.Point(0, 0);
            this.chartEditor.Name = "chartEditor";
            this.chartEditor.Options = null;
            this.chartEditor.TabIndex = 0;
            // 
            // LissajousScopeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 543);
            this.Controls.Add(this.phaseChart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LissajousScopeForm";
            this.Text = "LissajousScopeForm";
            this.Load += new System.EventHandler(this.LissajousScopeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private Steema.TeeChart.TChart phaseChart;
		private Dew.Signal.SignalIn SignalIn1;
		private Dew.Signal.TSignal Signal1;
		private Dew.Signal.TSignal Signal2;
		private Dew.Signal.SignalTimer SignalTimer1;
		private System.Windows.Forms.ComboBox samplesBox;
		private Steema.TeeChart.Styles.Polar polar1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private Steema.TeeChart.Editor chartEditor;
	}
}