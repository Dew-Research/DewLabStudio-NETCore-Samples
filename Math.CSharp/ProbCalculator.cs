using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Xml;
using System.Reflection;
using Dew.Math.Units;
using Dew.Examples;


namespace MtxVecDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
  public class ProbCalculator : System.Windows.Forms.Form
  {
#if Probabilities
      private string filename = @".\ProbXMLData.xml";
#else
      private string filename = @".\Data\ProbXMLData.xml";
#endif
      private Distribution distribution;
      private object[] callpars;
      private ParameterInfo[] pars;

      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.TreeView treeViewDist;
      private System.Windows.Forms.Panel panel3;
      private TabControl tabControl1;
      private TabPage tabPage1;
      private RichTextBox richTextBox1;
      private GroupBox groupBox1;
      private RadioButton radioButton2;
      private RadioButton radioButton1;
      private GroupBox groupBox2;
      private RadioButton radioButton4;
      private RadioButton radioButton3;
      private GroupBox groupBox3;
      private Label label1;
      private Label label2;
      private TextBox textBox2;
      private TextBox textBox1;
      private NumericUpDown numericUpDown1;
      private TabPage tabPage2;
      private Steema.TeeChart.TChart tChart1;
      private Button button1;
      private Steema.TeeChart.Styles.Area area1;
      private Steema.TeeChart.Styles.Area area2;
  	private System.Windows.Forms.Panel panel1;
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      public ProbCalculator()
      {
          //
          // Required for Windows Form Designer support
          //
          InitializeComponent();

          // Read assembly 
          distribution = new Distribution();

      }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
      protected override void Dispose(bool disposing)
      {
          if (disposing)
          {
              if (components != null)
              {
                  components.Dispose();
              }
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
            Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProbCalculator));
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeViewDist = new System.Windows.Forms.TreeView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tChart1 = new Steema.TeeChart.TChart();
            this.area1 = new Steema.TeeChart.Styles.Area();
            this.area2 = new Steema.TeeChart.Styles.Area();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.treeViewDist);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 616);
            this.panel2.TabIndex = 6;
            // 
            // treeViewDist
            // 
            this.treeViewDist.BackColor = System.Drawing.Color.White;
            this.treeViewDist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewDist.FullRowSelect = true;
            this.treeViewDist.HotTracking = true;
            this.treeViewDist.Location = new System.Drawing.Point(0, 0);
            this.treeViewDist.Name = "treeViewDist";
            this.treeViewDist.Size = new System.Drawing.Size(158, 614);
            this.treeViewDist.TabIndex = 6;
            this.treeViewDist.TabStop = false;
            this.treeViewDist.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewDist_AfterSelect);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(160, 531);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(836, 85);
            this.panel3.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(319, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 66);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Range settings";
            this.groupBox3.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(165, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Recalc";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(48, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "0";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(99, 18);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Limits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of points";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(151, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mode of calculation";
            // 
            // radioButton4
            // 
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton4.Location = new System.Drawing.Point(6, 41);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(126, 15);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.Text = "Range (x or p)";
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Checked = true;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton3.Location = new System.Drawing.Point(6, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(139, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Single point (x or p)";
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculation";
            // 
            // radioButton2
            // 
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "p -> x";
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "x -> PDF,CDF";
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(160, 142);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(836, 377);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(828, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Results";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(828, 351);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tChart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(578, 230);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chart";
            // 
            // tChart1
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
            this.tChart1.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Bottom.Labels.Font.Size = 9;
            this.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Bottom.Title.Font.Size = 11;
            this.tChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Depth.Labels.Font.Size = 9;
            this.tChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Depth.Title.Font.Size = 11;
            this.tChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.DepthTop.Labels.Font.Size = 9;
            this.tChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.DepthTop.Title.Font.Size = 11;
            this.tChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Left.Labels.Font.Size = 9;
            this.tChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart1.Axes.Left.Title.Caption = "PDF";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Left.Title.Font.Size = 11;
            this.tChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.Left.Title.Lines = new string[] {
        "PDF"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Grid.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Right.Labels.Font.Size = 9;
            this.tChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChart1.Axes.Right.Title.Caption = "CDF";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Right.Title.Font.Size = 11;
            this.tChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Axes.Right.Title.Lines = new string[] {
        "CDF"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Top.Labels.Font.Size = 9;
            this.tChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Axes.Top.Title.Font.Size = 11;
            this.tChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.BackColor = System.Drawing.Color.Transparent;
            this.tChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Footer.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Footer.Font.Size = 8;
            this.tChart1.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Header.Font.Size = 12;
            this.tChart1.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChart1.Header.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Legend.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Legend.Font.Size = 9;
            this.tChart1.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Legend.Title.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.tChart1.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Legend.Title.Font.Size = 8;
            this.tChart1.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.Location = new System.Drawing.Point(0, 0);
            this.tChart1.Name = "tChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tChart1.Panel.Brush.Gradient.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChart1.Panel.ImageBevel.Width = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            this.tChart1.Printer.Margins = margins1;
            this.tChart1.Series.Add(this.area1);
            this.tChart1.Series.Add(this.area2);
            this.tChart1.Size = new System.Drawing.Size(578, 230);
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.SubFooter.Font.Size = 8;
            this.tChart1.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChart1.SubHeader.Font.Size = 12;
            this.tChart1.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChart1.TabIndex = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Zoom.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // area1
            // 
            // 
            // 
            // 
            this.area1.AreaBrush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            // 
            // 
            // 
            this.area1.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            // 
            // 
            // 
            this.area1.AreaLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.area1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.area1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.area1.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.area1.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.area1.Legend.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.area1.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.area1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.area1.Legend.Font.Size = 8;
            this.area1.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.area1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.area1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.area1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.area1.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.area1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.area1.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.area1.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.area1.Marks.Font.Size = 8;
            this.area1.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.area1.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.area1.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.area1.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.area1.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.area1.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.area1.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.area1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
            this.area1.OriginalCursor = null;
            // 
            // 
            // 
            // 
            // 
            // 
            this.area1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.area1.Pointer.SizeDouble = 0D;
            this.area1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.area1.Title = "PDF";
            this.area1.UseExtendedNumRange = false;
            this.area1.UseOrigin = true;
            // 
            // 
            // 
            this.area1.XValues.DataMember = "X";
            this.area1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.area1.YValues.DataMember = "Y";
            // 
            // area2
            // 
            // 
            // 
            // 
            this.area2.AreaBrush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(104)))));
            // 
            // 
            // 
            this.area2.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(104)))));
            this.area2.Gradient.Transparency = 70;
            // 
            // 
            // 
            this.area2.AreaLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(124)))), ((int)(((byte)(62)))));
            // 
            // 
            // 
            this.area2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(104)))));
            this.area2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(104)))));
            this.area2.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.area2.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.area2.Legend.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.area2.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.area2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.area2.Legend.Font.Size = 8;
            this.area2.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.area2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.area2.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.area2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(124)))), ((int)(((byte)(62)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.area2.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.area2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.area2.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.area2.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.area2.Marks.Font.Size = 8;
            this.area2.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.area2.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.area2.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.area2.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.area2.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.area2.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.area2.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.area2.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
            this.area2.OriginalCursor = null;
            // 
            // 
            // 
            // 
            // 
            // 
            this.area2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.area2.Pointer.SizeDouble = 0D;
            this.area2.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.area2.Title = "CDF";
            this.area2.UseExtendedNumRange = false;
            this.area2.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right;
            // 
            // 
            // 
            this.area2.XValues.DataMember = "X";
            this.area2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.area2.YValues.DataMember = "Y";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(160, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 136);
            this.panel1.TabIndex = 11;
            // 
            // ProbCalculator
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(996, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProbCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dew Research: Probabilities";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

	}
    #endregion

      /// <summary>
      /// Populate tree with distribution list (distribution -> node)
      /// </summary>
      private void PopulateTree()
      {
          treeViewDist.Nodes.Clear();
          XmlTextReader reader = null;
          try
          {

              // Load the reader with the data file and ignore all white space nodes.         
#if Probabilities
              reader = new XmlTextReader(filename);
#else
              reader = new XmlTextReader(Utils.SourcePath() + filename);
#endif
              reader.WhitespaceHandling = WhitespaceHandling.None;
              reader.MoveToContent();
              // Parse the file and display each of the nodes.
              while (reader.Read())
              {
                  XmlNodeType nType = reader.NodeType;
				  System.Windows.Forms.TreeNode node;
                  if (nType == XmlNodeType.Element && reader.Name == "dist")
                  {
                      node = new TreeNode(reader.GetAttribute("title"));
					  node.Tag = reader.GetAttribute("name");
					  treeViewDist.Nodes.Add(node);
                  }
              }
          }

          finally
          {
              if (reader != null)
                  reader.Close();
          }
      }

      private void Form1_Load(object sender, System.EventArgs e)
      {
          PopulateTree();
          treeViewDist.ExpandAll();
          treeViewDist.Select();
          treeViewDist.SelectedNode = treeViewDist.TopNode;
      }

      private void treeViewDist_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
      {
          distribution.FindDistribution((string)e.Node.Tag);
          ConstructGUI();
      }

      /// <summary>
      /// Create labels and text boxes for parameters.
      /// </summary>
      private void ConstructGUI()
      {
          if (radioButton1.Checked) distribution.DType = Distribution.DistType.dtPDF;
          else distribution.DType = Distribution.DistType.dtCDFInv;

          pars = distribution.GetParameterInfo();
          callpars = null;

          this.SuspendLayout();
          try
          {
              panel1.Controls.Clear();

			  Label lbl0 = new Label();
			  lbl0.Location = new Point(10,10);
              lbl0.Size = new Size(40, 16);
			  lbl0.Text = "Name";
			  panel1.Controls.Add(lbl0);
              Label lbl1 = new Label();
              lbl1.Location = new Point(60, 10);
              lbl1.Size = new Size(40, 16);
              lbl1.Text = "Value";
              panel1.Controls.Add(lbl1);

			  if (pars != null)
              {
                  callpars = new object[pars.Length];
				  for (int i=0; i<pars.Length; i++)
				  {
					  Label lbl = new Label();
					  lbl.Location = new Point(10,30+24*i);
					  lbl.Size = new Size(50,16);
					  lbl.Text = pars[i].Name+":";
					  TextBox box = new TextBox();
					  box.Location = new Point(65,30+24*i);
					  box.Size = new Size(100,16);
					  box.Tag = i;
					  box.Name = "txtBoxPar"+i.ToString();
					  box.TextChanged += new EventHandler(box_TextChanged);
					                        
					  panel1.Controls.Add(lbl);
					  panel1.Controls.Add(box);

                  }
              }
          }
          finally
          {
              this.ResumeLayout();
          }
      }

	  /// <summary>
	  /// Executed when paramter text box is changed
	  /// </summary>
	  /// <param name="sender"></param>
	  /// <param name="e"></param>
      private void box_TextChanged(object sender, System.EventArgs e)
	  {
		  TextBox tbox = sender as TextBox;
		  int pind = (int)tbox.Tag;
		  System.Type tp = pars[pind].ParameterType;

		  if (tp.Equals(new double().GetType())) callpars[pind] = Convert.ToDouble(tbox.Text);
		  else if (tp.Equals(new int().GetType())) callpars[pind] = Convert.ToInt32(tbox.Text);

		  Recalc();
	  }

      /// <summary>
      /// Calculate pdf and cdf for single x parameter value.
      /// </summary>
      /// <param name="pdf">Returns pdf.</param>
      /// <param name="cdf">Returns cdf.</param>
      /// <returns>Formatted string containing pdf and cdf.</returns>
      private string ReportPDFCDF(out double pdf, out double cdf)
      {
          pdf = distribution.CalcPDF(callpars);
          cdf = distribution.CalcCDF(callpars);
          string x = (callpars[0] != null) ? callpars[0].ToString() : "NAN";
          string result = x + "\t" + Math387.FormatSample(pdf, "0.000000") + "\t";
          result += Math387.FormatSample(cdf, "0.000000") + "\n";
          return result;
      }

      /// <summary>
      /// Calculate inverse cdf for single p value.
      /// </summary>
      /// <returns>x at which cdf(x)=p.</returns>
      private string ReportCDFInv()
      {
          string p = (callpars[0] != null) ? callpars[0].ToString() : "NAN";
          string result = p + "\t" + Math387.FormatSample(distribution.CalcCDFInv(callpars), "0.000000") + "\n";
          return result;
      }

      /// <summary>
      /// Recalculate pdf,cdf or inverse cdf.
      /// </summary>
      private void Recalc()
      {
          double lb = Convert.ToDouble(textBox1.Text);
          double ub = Convert.ToDouble(textBox2.Text);
          int num = (int)numericUpDown1.Value;
          double step = (ub - lb) / (double)num;
          double pdf, cdf;
          area1.Clear();
          area2.Clear();

          richTextBox1.Clear();
          richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 10, FontStyle.Underline);
          richTextBox1.SelectedText = distribution.Title + " distribution\n\n";
          richTextBox1.SelectionTabs = new int[3] {0,100,200};
          richTextBox1.SelectionColor = Color.RoyalBlue;
          richTextBox1.SelectedText = "Name\tValue\n---------------------------------------\n";
          for (int i = 0; i < pars.Length; i++)
              richTextBox1.SelectedText = pars[i].Name + "\t" + callpars[i] + "\n";
          richTextBox1.SelectionColor = Color.RoyalBlue;
          richTextBox1.SelectedText = "---------------------------------------\n\n";

          if (radioButton1.Checked)
          {
              richTextBox1.SelectionColor = Color.RoyalBlue;
              richTextBox1.SelectedText = "x\tPDF\tCDF\n---------------------------------------\n";
              // calculate pdf, cdf
              if (radioButton4.Checked)
              {
                  tChart1.AutoRepaint = false;
                  try
                  {
                      for (int i = 0; i <= num; i++)
                      {
                          if (pars[0].ParameterType == typeof(Int32)) callpars[0] = (int)Math.Round(lb + i * step);
                          else callpars[0] = lb + i * step;
                          
                          richTextBox1.SelectedText = ReportPDFCDF(out pdf, out cdf);
                          if (pars[0].ParameterType == typeof(Int32))
                          {
                              if (!Math387.IsNanInf(pdf)) area1.Add((int)callpars[0], pdf);
                              if (!Math387.IsNanInf(cdf)) area2.Add((int)callpars[0], cdf);
                          }
                          else
                          {
                              if (!Math387.IsNanInf(pdf)) area1.Add((double)callpars[0], pdf);
                              if (!Math387.IsNanInf(cdf)) area2.Add((double)callpars[0], cdf);
                          }
                      }
                  }
                  finally
                  {
                      tChart1.AutoRepaint = true;
                  }
                  tChart1.Refresh();
              }
              else
              {
				richTextBox1.SelectedText = ReportPDFCDF(out pdf, out cdf);
              }

              richTextBox1.SelectionColor = Color.RoyalBlue;
              richTextBox1.SelectedText = "---------------------------------------\n";
          }
          else
          {
              richTextBox1.SelectionColor = Color.RoyalBlue;
              richTextBox1.SelectedText = "p\tx\n-----------------------------\n";
              // calculate inverse cdf
              if (radioButton4.Checked)
              {
                  for (int i = 0; i <= num; i++)
                  {
                      callpars[0] = lb + i * step;
                      richTextBox1.SelectedText = ReportCDFInv();
                  }
              }
              else
              {
				richTextBox1.SelectedText = ReportCDFInv();
			  }

              richTextBox1.SelectionColor = Color.RoyalBlue;
              richTextBox1.SelectedText = "-----------------------------\n";
          }
      }

      private void radioButton1_CheckedChanged(object sender, EventArgs e)
      {
          ConstructGUI();
          richTextBox1.Clear();
      }

      private void radioButton2_CheckedChanged(object sender, EventArgs e)
      {
          ConstructGUI();
          richTextBox1.Clear();
      }

      private void radioButton3_CheckedChanged(object sender, EventArgs e)
      {
          groupBox3.Visible = radioButton4.Checked;
          Recalc();
      }

      private void button1_Click(object sender, EventArgs e)
      {
          Recalc();
      }

      private void numericUpDown1_ValueChanged(object sender, EventArgs e)
      {
          Recalc();
      }


  }
}