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
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ProbCalculator));
            panel2 = new Panel();
            treeViewDist = new TreeView();
            panel3 = new Panel();
            groupBox3 = new GroupBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            richTextBox1 = new RichTextBox();
            tabPage2 = new TabPage();
            tChart1 = new Steema.TeeChart.TChart();
            area1 = new Steema.TeeChart.Styles.Area();
            area2 = new Steema.TeeChart.Styles.Area();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            ((ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(treeViewDist);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(192, 617);
            panel2.TabIndex = 6;
            // 
            // treeViewDist
            // 
            treeViewDist.BackColor = Color.White;
            treeViewDist.Dock = DockStyle.Fill;
            treeViewDist.FullRowSelect = true;
            treeViewDist.HotTracking = true;
            treeViewDist.Location = new Point(0, 0);
            treeViewDist.Name = "treeViewDist";
            treeViewDist.Size = new Size(190, 615);
            treeViewDist.TabIndex = 6;
            treeViewDist.TabStop = false;
            treeViewDist.AfterSelect += treeViewDist_AfterSelect;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(groupBox3);
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(192, 513);
            panel3.Name = "panel3";
            panel3.Size = new Size(843, 104);
            panel3.TabIndex = 8;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(numericUpDown1);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Location = new Point(383, 7);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(283, 82);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Range settings";
            groupBox3.Visible = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(198, 41);
            button1.Name = "button1";
            button1.Size = new Size(78, 28);
            button1.TabIndex = 5;
            button1.Text = "&Recalc";
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(119, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(57, 23);
            textBox2.TabIndex = 4;
            textBox2.Text = "1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(58, 23);
            textBox1.TabIndex = 3;
            textBox1.Text = "0";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Location = new Point(119, 22);
            numericUpDown1.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(59, 23);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 53);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Limits";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 25);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Number of points";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Location = new Point(181, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(195, 82);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mode of calculation";
            // 
            // radioButton4
            // 
            radioButton4.FlatStyle = FlatStyle.System;
            radioButton4.Location = new Point(7, 50);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(151, 19);
            radioButton4.TabIndex = 1;
            radioButton4.Text = "Range (x or p)";
            radioButton4.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.Checked = true;
            radioButton3.FlatStyle = FlatStyle.System;
            radioButton3.Location = new Point(7, 23);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(167, 21);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "Single point (x or p)";
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(7, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(167, 83);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculation";
            // 
            // radioButton2
            // 
            radioButton2.FlatStyle = FlatStyle.System;
            radioButton2.Location = new Point(7, 52);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(60, 21);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "p -> x";
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.Checked = true;
            radioButton1.FlatStyle = FlatStyle.System;
            radioButton1.Location = new Point(7, 23);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(107, 21);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "x -> PDF,CDF";
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(192, 175);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(843, 323);
            tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(835, 295);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Results";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.White;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(835, 295);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tChart1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(815, 289);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Chart";
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
            tChart1.Axes.Bottom.Labels.Brush.Color = Color.White;
            tChart1.Axes.Bottom.Labels.Brush.Solid = true;
            tChart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            tChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.Bottom.Labels.Font.Size = 9;
            tChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            tChart1.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            tChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            tChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Bottom.Title.Brush.Color = Color.Silver;
            tChart1.Axes.Bottom.Title.Brush.Solid = true;
            tChart1.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            tChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.Bottom.Title.Font.Size = 11;
            tChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            tChart1.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            tChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            tChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Depth.Labels.Brush.Color = Color.White;
            tChart1.Axes.Depth.Labels.Brush.Solid = true;
            tChart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            tChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.Depth.Labels.Font.Size = 9;
            tChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            tChart1.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            tChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            tChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Depth.Title.Brush.Color = Color.Silver;
            tChart1.Axes.Depth.Title.Brush.Solid = true;
            tChart1.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChart1.Axes.Depth.Title.Font.Brush.Solid = true;
            tChart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.Depth.Title.Font.Size = 11;
            tChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            tChart1.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            tChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            tChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Labels.Brush.Color = Color.White;
            tChart1.Axes.DepthTop.Labels.Brush.Solid = true;
            tChart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            tChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.DepthTop.Labels.Font.Size = 9;
            tChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            tChart1.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            tChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            tChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Title.Brush.Color = Color.Silver;
            tChart1.Axes.DepthTop.Title.Brush.Solid = true;
            tChart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            tChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.DepthTop.Title.Font.Size = 11;
            tChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            tChart1.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            tChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            tChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Left.Labels.Brush.Color = Color.White;
            tChart1.Axes.Left.Labels.Brush.Solid = true;
            tChart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart1.Axes.Left.Labels.Font.Brush.Solid = true;
            tChart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.Left.Labels.Font.Size = 9;
            tChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            tChart1.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            tChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            tChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Left.Title.Brush.Color = Color.Silver;
            tChart1.Axes.Left.Title.Brush.Solid = true;
            tChart1.Axes.Left.Title.Brush.Visible = true;
            tChart1.Axes.Left.Title.Caption = "PDF";
            // 
            // 
            // 
            tChart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Left.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChart1.Axes.Left.Title.Font.Brush.Solid = true;
            tChart1.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.Left.Title.Font.Size = 11;
            tChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            tChart1.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            tChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            tChart1.Axes.Left.Title.Lines = new string[]
    {
    "PDF"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            tChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Right.Grid.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Right.Labels.Brush.Color = Color.White;
            tChart1.Axes.Right.Labels.Brush.Solid = true;
            tChart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart1.Axes.Right.Labels.Font.Brush.Solid = true;
            tChart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.Right.Labels.Font.Size = 9;
            tChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            tChart1.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            tChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            tChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Right.Title.Brush.Color = Color.Silver;
            tChart1.Axes.Right.Title.Brush.Solid = true;
            tChart1.Axes.Right.Title.Brush.Visible = true;
            tChart1.Axes.Right.Title.Caption = "CDF";
            // 
            // 
            // 
            tChart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Right.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChart1.Axes.Right.Title.Font.Brush.Solid = true;
            tChart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.Right.Title.Font.Size = 11;
            tChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            tChart1.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            tChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            tChart1.Axes.Right.Title.Lines = new string[]
    {
    "CDF"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            tChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Top.Labels.Brush.Color = Color.White;
            tChart1.Axes.Top.Labels.Brush.Solid = true;
            tChart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart1.Axes.Top.Labels.Font.Brush.Solid = true;
            tChart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.Top.Labels.Font.Size = 9;
            tChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            tChart1.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            tChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            tChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Top.Title.Brush.Color = Color.Silver;
            tChart1.Axes.Top.Title.Brush.Solid = true;
            tChart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Axes.Top.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChart1.Axes.Top.Title.Font.Brush.Solid = true;
            tChart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            tChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            tChart1.Axes.Top.Title.Font.Size = 11;
            tChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            tChart1.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            tChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            tChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            tChart1.BackColor = Color.Transparent;
            tChart1.Dock = DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Footer.Brush.Color = Color.Silver;
            tChart1.Footer.Brush.Solid = true;
            tChart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Footer.Font.Brush.Color = Color.Red;
            tChart1.Footer.Font.Brush.Solid = true;
            tChart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Footer.Font.Shadow.Brush.Solid = true;
            tChart1.Footer.Font.Shadow.Brush.Visible = true;
            tChart1.Footer.Font.Size = 8;
            tChart1.Footer.Font.SizeFloat = 8F;
            tChart1.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Footer.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Footer.ImageBevel.Brush.Solid = true;
            tChart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Footer.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Footer.Shadow.Brush.Solid = true;
            tChart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Header.Brush.Color = Color.FromArgb(192, 192, 192);
            tChart1.Header.Brush.Solid = true;
            tChart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Header.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Header.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart1.Header.Font.Brush.Solid = true;
            tChart1.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Header.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Header.Font.Shadow.Brush.Solid = true;
            tChart1.Header.Font.Shadow.Brush.Visible = true;
            tChart1.Header.Font.Size = 12;
            tChart1.Header.Font.SizeFloat = 12F;
            tChart1.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Header.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Header.ImageBevel.Brush.Solid = true;
            tChart1.Header.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Header.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            tChart1.Header.Shadow.Brush.Solid = true;
            tChart1.Header.Shadow.Brush.Visible = true;
            tChart1.Header.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Legend.Brush.Color = Color.White;
            tChart1.Legend.Brush.Solid = true;
            tChart1.Legend.Brush.Visible = true;
            tChart1.Legend.CheckBoxes = false;
            // 
            // 
            // 
            tChart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            tChart1.Legend.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            tChart1.Legend.Font.Brush.Solid = true;
            tChart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Legend.Font.Shadow.Brush.Solid = true;
            tChart1.Legend.Font.Shadow.Brush.Visible = true;
            tChart1.Legend.Font.Size = 9;
            tChart1.Legend.Font.SizeFloat = 9F;
            tChart1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Legend.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Legend.ImageBevel.Brush.Solid = true;
            tChart1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Legend.Shadow.Brush.Color = Color.FromArgb(0, 0, 0);
            tChart1.Legend.Shadow.Brush.Solid = true;
            tChart1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Legend.Symbol.Shadow.Brush.Solid = true;
            tChart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Legend.Title.Brush.Color = Color.White;
            tChart1.Legend.Title.Brush.Solid = true;
            tChart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            tChart1.Legend.Title.Font.Brush.Color = Color.Black;
            tChart1.Legend.Title.Font.Brush.Solid = true;
            tChart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            tChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            tChart1.Legend.Title.Font.Size = 8;
            tChart1.Legend.Title.Font.SizeFloat = 8F;
            tChart1.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Legend.Title.ImageBevel.Brush.Solid = true;
            tChart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Legend.Title.Shadow.Brush.Solid = true;
            tChart1.Legend.Title.Shadow.Brush.Visible = true;
            tChart1.Location = new Point(0, 0);
            tChart1.Name = "tChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Panel.Brush.Color = Color.FromArgb(0, 255, 255, 255);
            // 
            // 
            // 
            tChart1.Panel.Brush.Gradient.MiddleColor = Color.FromArgb(255, 255, 255);
            tChart1.Panel.Brush.Gradient.StartColor = Color.FromArgb(128, 128, 255);
            tChart1.Panel.Brush.Gradient.Visible = true;
            tChart1.Panel.Brush.Solid = true;
            tChart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Panel.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Panel.ImageBevel.Brush.Solid = true;
            tChart1.Panel.ImageBevel.Brush.Visible = true;
            tChart1.Panel.ImageBevel.Width = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Panel.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Panel.Shadow.Brush.Solid = true;
            tChart1.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            tChart1.Printer.Margins = margins1;
            tChart1.Series.Add(area1);
            tChart1.Series.Add(area2);
            tChart1.Size = new Size(815, 289);
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.SubFooter.Brush.Color = Color.Silver;
            tChart1.SubFooter.Brush.Solid = true;
            tChart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            tChart1.SubFooter.Font.Brush.Color = Color.Red;
            tChart1.SubFooter.Font.Brush.Solid = true;
            tChart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.SubFooter.Font.Shadow.Brush.Solid = true;
            tChart1.SubFooter.Font.Shadow.Brush.Visible = true;
            tChart1.SubFooter.Font.Size = 8;
            tChart1.SubFooter.Font.SizeFloat = 8F;
            tChart1.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.SubFooter.ImageBevel.Brush.Solid = true;
            tChart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.SubFooter.Shadow.Brush.Color = Color.DarkGray;
            tChart1.SubFooter.Shadow.Brush.Solid = true;
            tChart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.SubHeader.Brush.Color = Color.FromArgb(192, 192, 192);
            tChart1.SubHeader.Brush.Solid = true;
            tChart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            tChart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            tChart1.SubHeader.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            tChart1.SubHeader.Font.Brush.Solid = true;
            tChart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
            tChart1.SubHeader.Font.Shadow.Brush.Solid = true;
            tChart1.SubHeader.Font.Shadow.Brush.Visible = true;
            tChart1.SubHeader.Font.Size = 12;
            tChart1.SubHeader.Font.SizeFloat = 12F;
            tChart1.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.SubHeader.ImageBevel.Brush.Solid = true;
            tChart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.SubHeader.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            tChart1.SubHeader.Shadow.Brush.Solid = true;
            tChart1.SubHeader.Shadow.Brush.Visible = true;
            tChart1.TabIndex = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Back.Brush.Color = Color.Silver;
            tChart1.Walls.Back.Brush.Solid = true;
            tChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Walls.Back.ImageBevel.Brush.Solid = true;
            tChart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Walls.Back.Shadow.Brush.Solid = true;
            tChart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Bottom.Brush.Color = Color.White;
            tChart1.Walls.Bottom.Brush.Solid = true;
            tChart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            tChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Walls.Bottom.Shadow.Brush.Solid = true;
            tChart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Left.Brush.Color = Color.LightYellow;
            tChart1.Walls.Left.Brush.Solid = true;
            tChart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Walls.Left.ImageBevel.Brush.Solid = true;
            tChart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Walls.Left.Shadow.Brush.Solid = true;
            tChart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Right.Brush.Color = Color.LightYellow;
            tChart1.Walls.Right.Brush.Solid = true;
            tChart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
            tChart1.Walls.Right.ImageBevel.Brush.Solid = true;
            tChart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
            tChart1.Walls.Right.Shadow.Brush.Solid = true;
            tChart1.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Zoom.Brush.Color = Color.FromArgb(127, 0, 0, 255);
            tChart1.Zoom.Brush.Solid = true;
            tChart1.Zoom.Brush.Visible = true;
            // 
            // area1
            // 
            // 
            // 
            // 
            area1.AreaBrush.Color = Color.FromArgb(119, 153, 214);
            area1.AreaBrush.Solid = true;
            area1.AreaBrush.Visible = false;
            // 
            // 
            // 
            area1.AreaLines.Color = Color.FromArgb(71, 92, 128);
            // 
            // 
            // 
            area1.Brush.Color = Color.FromArgb(119, 153, 214);
            area1.Brush.Solid = true;
            area1.Brush.Visible = true;
            area1.Color = Color.FromArgb(119, 153, 214);
            area1.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            area1.Legend.Brush.Color = Color.White;
            area1.Legend.Brush.Solid = true;
            area1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            area1.Legend.Font.Bold = false;
            // 
            // 
            // 
            area1.Legend.Font.Brush.Color = Color.Black;
            area1.Legend.Font.Brush.Solid = true;
            area1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            area1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            area1.Legend.Font.Shadow.Brush.Solid = true;
            area1.Legend.Font.Shadow.Brush.Visible = true;
            area1.Legend.Font.Size = 8;
            area1.Legend.Font.SizeFloat = 8F;
            area1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            area1.Legend.ImageBevel.Brush.Color = Color.LightGray;
            area1.Legend.ImageBevel.Brush.Solid = true;
            area1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            area1.Legend.Shadow.Brush.Color = Color.DarkGray;
            area1.Legend.Shadow.Brush.Solid = true;
            area1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            area1.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            area1.Marks.Brush.Solid = true;
            area1.Marks.Brush.Visible = true;
            // 
            // 
            // 
            area1.Marks.Font.Bold = false;
            // 
            // 
            // 
            area1.Marks.Font.Brush.Color = Color.Black;
            area1.Marks.Font.Brush.Solid = true;
            area1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            area1.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            area1.Marks.Font.Shadow.Brush.Solid = true;
            area1.Marks.Font.Shadow.Brush.Visible = true;
            area1.Marks.Font.Size = 8;
            area1.Marks.Font.SizeFloat = 8F;
            area1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            area1.Marks.ImageBevel.Brush.Color = Color.LightGray;
            area1.Marks.ImageBevel.Brush.Solid = true;
            area1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            area1.Marks.Shadow.Brush.Color = Color.Gray;
            area1.Marks.Shadow.Brush.Solid = true;
            area1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            area1.Marks.Symbol.Brush.Color = Color.White;
            area1.Marks.Symbol.Brush.Solid = true;
            area1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            area1.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            area1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            area1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            area1.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            area1.Marks.Symbol.Shadow.Brush.Solid = true;
            area1.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            area1.Pointer.Brush.Color = Color.FromArgb(255, 128, 0);
            area1.Pointer.Brush.Solid = true;
            area1.Pointer.Brush.Visible = true;
            area1.Title = "PDF";
            area1.UseOrigin = true;
            // 
            // 
            // 
            area1.XValues.DataMember = "X";
            area1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            area1.XValues.Value = new double[]
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
            area1.YValues.DataMember = "Y";
            area1.YValues.Value = new double[]
    {
    115D,
    101D,
    206D,
    81D,
    184D,
    124D,
    224D,
    216D,
    190D,
    151D,
    110D,
    6D,
    71D,
    93D,
    80D,
    195D,
    118D,
    139D,
    199D,
    259D,
    213D,
    207D,
    316D,
    346D,
    450D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // area2
            // 
            // 
            // 
            // 
            area2.AreaBrush.Color = Color.FromArgb(255, 207, 104);
            // 
            // 
            // 
            area2.Gradient.Transparency = 70;
            area2.AreaBrush.Solid = true;
            area2.AreaBrush.Visible = false;
            // 
            // 
            // 
            area2.AreaLines.Color = Color.FromArgb(153, 124, 62);
            // 
            // 
            // 
            area2.Brush.Color = Color.FromArgb(255, 207, 104);
            area2.Brush.Solid = true;
            area2.Brush.Visible = true;
            area2.Color = Color.FromArgb(255, 207, 104);
            area2.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            area2.Legend.Brush.Color = Color.White;
            area2.Legend.Brush.Solid = true;
            area2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            area2.Legend.Font.Bold = false;
            // 
            // 
            // 
            area2.Legend.Font.Brush.Color = Color.Black;
            area2.Legend.Font.Brush.Solid = true;
            area2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            area2.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            area2.Legend.Font.Shadow.Brush.Solid = true;
            area2.Legend.Font.Shadow.Brush.Visible = true;
            area2.Legend.Font.Size = 8;
            area2.Legend.Font.SizeFloat = 8F;
            area2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            area2.Legend.ImageBevel.Brush.Color = Color.LightGray;
            area2.Legend.ImageBevel.Brush.Solid = true;
            area2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            area2.Legend.Shadow.Brush.Color = Color.DarkGray;
            area2.Legend.Shadow.Brush.Solid = true;
            area2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            area2.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            area2.Marks.Brush.Solid = true;
            area2.Marks.Brush.Visible = true;
            // 
            // 
            // 
            area2.Marks.Font.Bold = false;
            // 
            // 
            // 
            area2.Marks.Font.Brush.Color = Color.Black;
            area2.Marks.Font.Brush.Solid = true;
            area2.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            area2.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            area2.Marks.Font.Shadow.Brush.Solid = true;
            area2.Marks.Font.Shadow.Brush.Visible = true;
            area2.Marks.Font.Size = 8;
            area2.Marks.Font.SizeFloat = 8F;
            area2.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            area2.Marks.ImageBevel.Brush.Color = Color.LightGray;
            area2.Marks.ImageBevel.Brush.Solid = true;
            area2.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            area2.Marks.Shadow.Brush.Color = Color.Gray;
            area2.Marks.Shadow.Brush.Solid = true;
            area2.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            area2.Marks.Symbol.Brush.Color = Color.White;
            area2.Marks.Symbol.Brush.Solid = true;
            area2.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            area2.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            area2.Marks.Symbol.ImageBevel.Brush.Solid = true;
            area2.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            area2.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            area2.Marks.Symbol.Shadow.Brush.Solid = true;
            area2.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            area2.Pointer.Brush.Color = Color.FromArgb(0, 0, 192);
            area2.Pointer.Brush.Solid = true;
            area2.Pointer.Brush.Visible = true;
            area2.Title = "CDF";
            area2.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right;
            // 
            // 
            // 
            area2.XValues.DataMember = "X";
            area2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            area2.XValues.Value = new double[]
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
            area2.YValues.DataMember = "Y";
            area2.YValues.Value = new double[]
    {
    908D,
    996D,
    1107D,
    1220D,
    1158D,
    1278D,
    1398D,
    1478D,
    1444D,
    1321D,
    1365D,
    1372D,
    1310D,
    1248D,
    1275D,
    1185D,
    1239D,
    1148D,
    1037D,
    948D,
    1058D,
    1054D,
    1015D,
    1033D,
    1126D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(192, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 167);
            panel1.TabIndex = 11;
            // 
            // ProbCalculator
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(1035, 617);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProbCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dew Research: Probabilities";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);

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