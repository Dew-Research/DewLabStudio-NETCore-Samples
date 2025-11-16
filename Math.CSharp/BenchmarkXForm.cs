using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MtxVecDemo
{
	public class BenchmarkXForm : MtxVecDemo.BasicForm2
	{
		private System.Windows.Forms.Panel panel4;
		private Steema.TeeChart.TChart tChart1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Label label3;
		private Steema.TeeChart.Styles.HorizBar bar1;
		private Steema.TeeChart.Styles.HorizBar bar2;
		private Steema.TeeChart.Styles.HorizBar bar3;
		private Steema.TeeChart.Styles.HorizBar bar4;
		private System.Windows.Forms.ContextMenuStrip contextMenu1;
		private System.Windows.Forms.ToolStripMenuItem menuItem1;
		private System.Windows.Forms.ToolStripMenuItem menuItem2;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
        private System.ComponentModel.IContainer components = null;

		public BenchmarkXForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			benchmarkFramework = new BenchmarkFramework();
			benchmarkResults = new BenchmarkResults();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			benchmarkFramework.Dispose();
			base.Dispose( disposing );
		}

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(BenchmarkXForm));
            panel4 = new Panel();
            checkedListBox1 = new CheckedListBox();
            label1 = new Label();
            tChart1 = new Steema.TeeChart.TChart();
            contextMenu1 = new ContextMenuStrip(components);
            menuItem1 = new ToolStripMenuItem();
            menuItem2 = new ToolStripMenuItem();
            bar2 = new Steema.TeeChart.Styles.HorizBar();
            bar4 = new Steema.TeeChart.Styles.HorizBar();
            bar3 = new Steema.TeeChart.Styles.HorizBar();
            bar1 = new Steema.TeeChart.Styles.HorizBar();
            button1 = new Button();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            button2 = new Button();
            button3 = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            contextMenu1.SuspendLayout();
            ((ISupportInitialize)numericUpDown1).BeginInit();
            ((ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(tChart1);
            panel2.Controls.Add(panel4);
            panel2.Size = new Size(1051, 337);
            // 
            // panel3
            // 
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(numericUpDown1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(numericUpDown2);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(0, 475);
            panel3.Size = new Size(1051, 59);
            // 
            // richTextBox1
            // 
            richTextBox1.Size = new Size(1051, 138);
            // 
            // panel4
            // 
            panel4.Controls.Add(checkedListBox1);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(163, 337);
            panel4.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Location = new Point(10, 30);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(144, 292);
            checkedListBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 0;
            label1.Text = "Functions";
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
            tChart1.Axes.Bottom.Title.Caption = "Time needed [ms]";
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
            tChart1.Axes.Bottom.Title.Lines = new string[]
    {
    "Time needed [ms]"
    };
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
            tChart1.ContextMenuStrip = contextMenu1;
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
            tChart1.Location = new Point(163, 0);
            tChart1.Name = "tChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            tChart1.Panel.Brush.Color = Color.FromArgb(255, 255, 255);
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
            tChart1.Series.Add(bar2);
            tChart1.Series.Add(bar4);
            tChart1.Series.Add(bar3);
            tChart1.Series.Add(bar1);
            tChart1.Size = new Size(888, 337);
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
            tChart1.TabIndex = 1;
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
            tChart1.Walls.Bottom.Visible = false;
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
            tChart1.Walls.Left.Visible = false;
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
            tChart1.Zoom.Brush.Color = Color.FromArgb(150, 173, 216, 230);
            tChart1.Zoom.Brush.Solid = true;
            tChart1.Zoom.Brush.Visible = true;
            tChart1.Click += tChart1_Click;
            // 
            // contextMenu1
            // 
            contextMenu1.Items.AddRange(new ToolStripItem[] { menuItem1, menuItem2 });
            contextMenu1.Name = "contextMenu1";
            contextMenu1.Size = new Size(149, 48);
            // 
            // menuItem1
            // 
            menuItem1.Name = "menuItem1";
            menuItem1.Size = new Size(148, 22);
            menuItem1.Text = "Load from file";
            menuItem1.Click += menuItem1_Click;
            // 
            // menuItem2
            // 
            menuItem2.Name = "menuItem2";
            menuItem2.Size = new Size(148, 22);
            menuItem2.Text = "Save to file";
            menuItem2.Click += menuItem2_Click;
            // 
            // bar2
            // 
            bar2.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
            // 
            // 
            // 
            bar2.Brush.Color = Color.LightCoral;
            // 
            // 
            // 
            bar2.Brush.Gradient.Transparency = 100;
            bar2.Brush.Solid = true;
            bar2.Brush.Visible = true;
            bar2.Color = Color.LightCoral;
            bar2.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            bar2.Legend.Brush.Color = Color.White;
            bar2.Legend.Brush.Solid = true;
            bar2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            bar2.Legend.Font.Bold = false;
            // 
            // 
            // 
            bar2.Legend.Font.Brush.Color = Color.Black;
            bar2.Legend.Font.Brush.Solid = true;
            bar2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar2.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            bar2.Legend.Font.Shadow.Brush.Solid = true;
            bar2.Legend.Font.Shadow.Brush.Visible = true;
            bar2.Legend.Font.Size = 8;
            bar2.Legend.Font.SizeFloat = 8F;
            bar2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bar2.Legend.ImageBevel.Brush.Color = Color.LightGray;
            bar2.Legend.ImageBevel.Brush.Solid = true;
            bar2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar2.Legend.Shadow.Brush.Color = Color.DarkGray;
            bar2.Legend.Shadow.Brush.Solid = true;
            bar2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            bar2.Marks.ArrowLength = 20;
            // 
            // 
            // 
            bar2.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            bar2.Marks.Brush.Solid = true;
            bar2.Marks.Brush.Visible = true;
            // 
            // 
            // 
            bar2.Marks.Font.Bold = false;
            // 
            // 
            // 
            bar2.Marks.Font.Brush.Color = Color.Black;
            bar2.Marks.Font.Brush.Solid = true;
            bar2.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar2.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            bar2.Marks.Font.Shadow.Brush.Solid = true;
            bar2.Marks.Font.Shadow.Brush.Visible = true;
            bar2.Marks.Font.Size = 8;
            bar2.Marks.Font.SizeFloat = 8F;
            bar2.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bar2.Marks.ImageBevel.Brush.Color = Color.LightGray;
            bar2.Marks.ImageBevel.Brush.Solid = true;
            bar2.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar2.Marks.Shadow.Brush.Color = Color.Gray;
            bar2.Marks.Shadow.Brush.Solid = true;
            bar2.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar2.Marks.Symbol.Brush.Color = Color.White;
            bar2.Marks.Symbol.Brush.Solid = true;
            bar2.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar2.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            bar2.Marks.Symbol.ImageBevel.Brush.Solid = true;
            bar2.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar2.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            bar2.Marks.Symbol.Shadow.Brush.Solid = true;
            bar2.Marks.Symbol.Shadow.Brush.Visible = true;
            bar2.Marks.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            bar2.Shadow.Brush.Color = Color.DarkGray;
            bar2.Shadow.Brush.Solid = true;
            bar2.Shadow.Brush.Visible = true;
            bar2.Title = "Complex Math387";
            // 
            // 
            // 
            bar2.XValues.DataMember = "X";
            bar2.XValues.Value = new double[]
    {
    26D,
    13D,
    8D,
    54D,
    162D,
    128D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            bar2.YValues.DataMember = "Bar";
            bar2.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            bar2.YValues.Value = new double[]
    {
    0D,
    1D,
    2D,
    3D,
    4D,
    5D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // bar4
            // 
            bar4.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
            // 
            // 
            // 
            bar4.Brush.Color = Color.LightSteelBlue;
            // 
            // 
            // 
            bar4.Brush.Gradient.Transparency = 100;
            bar4.Brush.Solid = true;
            bar4.Brush.Visible = true;
            bar4.Color = Color.LightSteelBlue;
            bar4.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            bar4.Legend.Brush.Color = Color.White;
            bar4.Legend.Brush.Solid = true;
            bar4.Legend.Brush.Visible = true;
            // 
            // 
            // 
            bar4.Legend.Font.Bold = false;
            // 
            // 
            // 
            bar4.Legend.Font.Brush.Color = Color.Black;
            bar4.Legend.Font.Brush.Solid = true;
            bar4.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar4.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            bar4.Legend.Font.Shadow.Brush.Solid = true;
            bar4.Legend.Font.Shadow.Brush.Visible = true;
            bar4.Legend.Font.Size = 8;
            bar4.Legend.Font.SizeFloat = 8F;
            bar4.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bar4.Legend.ImageBevel.Brush.Color = Color.LightGray;
            bar4.Legend.ImageBevel.Brush.Solid = true;
            bar4.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar4.Legend.Shadow.Brush.Color = Color.DarkGray;
            bar4.Legend.Shadow.Brush.Solid = true;
            bar4.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            bar4.Marks.ArrowLength = 20;
            // 
            // 
            // 
            bar4.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            bar4.Marks.Brush.Solid = true;
            bar4.Marks.Brush.Visible = true;
            // 
            // 
            // 
            bar4.Marks.Font.Bold = false;
            // 
            // 
            // 
            bar4.Marks.Font.Brush.Color = Color.Black;
            bar4.Marks.Font.Brush.Solid = true;
            bar4.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar4.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            bar4.Marks.Font.Shadow.Brush.Solid = true;
            bar4.Marks.Font.Shadow.Brush.Visible = true;
            bar4.Marks.Font.Size = 8;
            bar4.Marks.Font.SizeFloat = 8F;
            bar4.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bar4.Marks.ImageBevel.Brush.Color = Color.LightGray;
            bar4.Marks.ImageBevel.Brush.Solid = true;
            bar4.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar4.Marks.Shadow.Brush.Color = Color.Gray;
            bar4.Marks.Shadow.Brush.Solid = true;
            bar4.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar4.Marks.Symbol.Brush.Color = Color.White;
            bar4.Marks.Symbol.Brush.Solid = true;
            bar4.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar4.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            bar4.Marks.Symbol.ImageBevel.Brush.Solid = true;
            bar4.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar4.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            bar4.Marks.Symbol.Shadow.Brush.Solid = true;
            bar4.Marks.Symbol.Shadow.Brush.Visible = true;
            bar4.Marks.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            bar4.Shadow.Brush.Color = Color.DarkGray;
            bar4.Shadow.Brush.Solid = true;
            bar4.Shadow.Brush.Visible = true;
            bar4.Title = "Complex MtxVec";
            // 
            // 
            // 
            bar4.XValues.DataMember = "X";
            bar4.XValues.Value = new double[]
    {
    32D,
    50D,
    32D,
    17D,
    6D,
    10D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            bar4.YValues.DataMember = "Bar";
            bar4.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            bar4.YValues.Value = new double[]
    {
    0D,
    1D,
    2D,
    3D,
    4D,
    5D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // bar3
            // 
            bar3.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
            // 
            // 
            // 
            bar3.Brush.Color = Color.Blue;
            // 
            // 
            // 
            bar3.Brush.Gradient.Transparency = 100;
            bar3.Brush.Solid = true;
            bar3.Brush.Visible = true;
            bar3.Color = Color.Blue;
            bar3.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            bar3.Legend.Brush.Color = Color.White;
            bar3.Legend.Brush.Solid = true;
            bar3.Legend.Brush.Visible = true;
            // 
            // 
            // 
            bar3.Legend.Font.Bold = false;
            // 
            // 
            // 
            bar3.Legend.Font.Brush.Color = Color.Black;
            bar3.Legend.Font.Brush.Solid = true;
            bar3.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar3.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            bar3.Legend.Font.Shadow.Brush.Solid = true;
            bar3.Legend.Font.Shadow.Brush.Visible = true;
            bar3.Legend.Font.Size = 8;
            bar3.Legend.Font.SizeFloat = 8F;
            bar3.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bar3.Legend.ImageBevel.Brush.Color = Color.LightGray;
            bar3.Legend.ImageBevel.Brush.Solid = true;
            bar3.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar3.Legend.Shadow.Brush.Color = Color.DarkGray;
            bar3.Legend.Shadow.Brush.Solid = true;
            bar3.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            bar3.Marks.ArrowLength = 20;
            // 
            // 
            // 
            bar3.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            bar3.Marks.Brush.Solid = true;
            bar3.Marks.Brush.Visible = true;
            // 
            // 
            // 
            bar3.Marks.Font.Bold = false;
            // 
            // 
            // 
            bar3.Marks.Font.Brush.Color = Color.Black;
            bar3.Marks.Font.Brush.Solid = true;
            bar3.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar3.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            bar3.Marks.Font.Shadow.Brush.Solid = true;
            bar3.Marks.Font.Shadow.Brush.Visible = true;
            bar3.Marks.Font.Size = 8;
            bar3.Marks.Font.SizeFloat = 8F;
            bar3.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bar3.Marks.ImageBevel.Brush.Color = Color.LightGray;
            bar3.Marks.ImageBevel.Brush.Solid = true;
            bar3.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar3.Marks.Shadow.Brush.Color = Color.Gray;
            bar3.Marks.Shadow.Brush.Solid = true;
            bar3.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar3.Marks.Symbol.Brush.Color = Color.White;
            bar3.Marks.Symbol.Brush.Solid = true;
            bar3.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar3.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            bar3.Marks.Symbol.ImageBevel.Brush.Solid = true;
            bar3.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar3.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            bar3.Marks.Symbol.Shadow.Brush.Solid = true;
            bar3.Marks.Symbol.Shadow.Brush.Visible = true;
            bar3.Marks.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            bar3.Shadow.Brush.Color = Color.DarkGray;
            bar3.Shadow.Brush.Solid = true;
            bar3.Shadow.Brush.Visible = true;
            bar3.Title = "Sample Math387";
            // 
            // 
            // 
            bar3.XValues.DataMember = "X";
            bar3.XValues.Value = new double[]
    {
    86D,
    94D,
    92D,
    95D,
    79D,
    71D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            bar3.YValues.DataMember = "Bar";
            bar3.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            bar3.YValues.Value = new double[]
    {
    0D,
    1D,
    2D,
    3D,
    4D,
    5D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // bar1
            // 
            bar1.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
            // 
            // 
            // 
            bar1.Brush.Color = Color.Red;
            // 
            // 
            // 
            bar1.Brush.Gradient.Transparency = 100;
            bar1.Brush.Solid = true;
            bar1.Brush.Visible = true;
            bar1.Color = Color.Red;
            bar1.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            bar1.Legend.Brush.Color = Color.White;
            bar1.Legend.Brush.Solid = true;
            bar1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            bar1.Legend.Font.Bold = false;
            // 
            // 
            // 
            bar1.Legend.Font.Brush.Color = Color.Black;
            bar1.Legend.Font.Brush.Solid = true;
            bar1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar1.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            bar1.Legend.Font.Shadow.Brush.Solid = true;
            bar1.Legend.Font.Shadow.Brush.Visible = true;
            bar1.Legend.Font.Size = 8;
            bar1.Legend.Font.SizeFloat = 8F;
            bar1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bar1.Legend.ImageBevel.Brush.Color = Color.LightGray;
            bar1.Legend.ImageBevel.Brush.Solid = true;
            bar1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar1.Legend.Shadow.Brush.Color = Color.DarkGray;
            bar1.Legend.Shadow.Brush.Solid = true;
            bar1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            bar1.Marks.ArrowLength = 20;
            // 
            // 
            // 
            bar1.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            bar1.Marks.Brush.Solid = true;
            bar1.Marks.Brush.Visible = true;
            // 
            // 
            // 
            bar1.Marks.Font.Bold = false;
            // 
            // 
            // 
            bar1.Marks.Font.Brush.Color = Color.Black;
            bar1.Marks.Font.Brush.Solid = true;
            bar1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar1.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            bar1.Marks.Font.Shadow.Brush.Solid = true;
            bar1.Marks.Font.Shadow.Brush.Visible = true;
            bar1.Marks.Font.Size = 8;
            bar1.Marks.Font.SizeFloat = 8F;
            bar1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            bar1.Marks.ImageBevel.Brush.Color = Color.LightGray;
            bar1.Marks.ImageBevel.Brush.Solid = true;
            bar1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar1.Marks.Shadow.Brush.Color = Color.Gray;
            bar1.Marks.Shadow.Brush.Solid = true;
            bar1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar1.Marks.Symbol.Brush.Color = Color.White;
            bar1.Marks.Symbol.Brush.Solid = true;
            bar1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar1.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            bar1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            bar1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            bar1.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            bar1.Marks.Symbol.Shadow.Brush.Solid = true;
            bar1.Marks.Symbol.Shadow.Brush.Visible = true;
            bar1.Marks.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            bar1.Shadow.Brush.Color = Color.DarkGray;
            bar1.Shadow.Brush.Solid = true;
            bar1.Shadow.Brush.Visible = true;
            bar1.Title = "Sample MtxVec";
            // 
            // 
            // 
            bar1.XValues.DataMember = "X";
            bar1.XValues.Value = new double[]
    {
    134D,
    140D,
    148D,
    128D,
    145D,
    130D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            bar1.YValues.DataMember = "Bar";
            bar1.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            bar1.YValues.Value = new double[]
    {
    0D,
    1D,
    2D,
    3D,
    4D,
    5D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(10, 10);
            button1.Name = "button1";
            button1.Size = new Size(90, 28);
            button1.TabIndex = 0;
            button1.Text = "Run";
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(341, 10);
            label2.Name = "label2";
            label2.Size = new Size(91, 24);
            label2.TabIndex = 1;
            label2.Text = "Vector length";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(443, 12);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(86, 23);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(684, 12);
            numericUpDown2.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(87, 23);
            numericUpDown2.TabIndex = 2;
            numericUpDown2.Value = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            numericUpDown2.DoubleClick += numericUpDown2_DoubleClick;
            // 
            // label3
            // 
            label3.Location = new Point(546, 12);
            label3.Name = "label3";
            label3.Size = new Size(134, 24);
            label3.TabIndex = 1;
            label3.Text = "Iterations (DblClick)";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "dat";
            openFileDialog1.Filter = "Benchmark files(*.dat)|*.dat|All files(*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Save benchmark results";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "dat";
            saveFileDialog1.Filter = "Benchmark files(*.dat)|*.dat|All files(*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Save benchmark results";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(110, 10);
            button2.Name = "button2";
            button2.Size = new Size(90, 28);
            button2.TabIndex = 3;
            button2.Text = "Open";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.FlatStyle = FlatStyle.System;
            button3.Location = new Point(211, 10);
            button3.Name = "button3";
            button3.Size = new Size(90, 28);
            button3.TabIndex = 4;
            button3.Text = "Save";
            button3.Click += button3_Click;
            // 
            // BenchmarkXForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(1051, 534);
            Name = "BenchmarkXForm";
            Load += BenchmarkXForm_Load;
            Controls.SetChildIndex(panel3, 0);
            Controls.SetChildIndex(panel2, 0);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            contextMenu1.ResumeLayout(false);
            ((ISupportInitialize)numericUpDown1).EndInit();
            ((ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);

        }
        #endregion
        BenchmarkFramework benchmarkFramework;
		BenchmarkResults benchmarkResults;

		private void BenchmarkXForm_Load(object sender, System.EventArgs e) {
			Add("These benchmarks compare vectorized and not vectorized " +
				"versions of real and complex versions of basic math functions. " +
				"The vectorized versions are labeled with MtxVec and the non-vectorized "+
				"versions are labeled with Math387.");
			Add("");
			Add("The non-vectorized real and complex versions " +
				"are written in assembler for maximum performance. "+
				"Despite this, the vectorized versions are substantially faster. "+
				"Before running the tests double click on the iterations combobox. " +
				"That will compute the number of iterations that have to be performed " +
				"to get sufficiently long timings. The resolution of the timings is " +
				"about 15ms.");

			loadFuncListBox();
			numericUpDown1_ValueChanged(null,null);
			numericUpDown2_ValueChanged(null,null);
		}

		private void loadFuncListBox() {
			checkedListBox1.BeginUpdate();
			try {
				checkedListBox1.Items.Clear();
				for (int i=0;i<benchmarkFramework.FuncCount;i++) {
					checkedListBox1.Items.Add(benchmarkFramework.GetFuncName(i),true);
				}
			} finally {
				checkedListBox1.EndUpdate();
			}
		}

		private void numericUpDown2_DoubleClick(object sender, System.EventArgs e) {
			this.Cursor = Cursors.WaitCursor;
			try {
				numericUpDown2.Value = benchmarkFramework.RecalcIterationCount();
			} finally {
				this.Cursor = Cursors.Default;
			}
		}

		private void numericUpDown2_ValueChanged(object sender, System.EventArgs e) {
			benchmarkFramework.IterationCount = (int)numericUpDown2.Value;
		}

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e) {
			benchmarkFramework.VectorLength = (int)numericUpDown1.Value;
		}

		private void button1_Click(object sender, System.EventArgs e) {
			this.Cursor = Cursors.WaitCursor;
			try {
				benchmarkResults.Clear();
				foreach (String s in checkedListBox1.CheckedItems) {
					benchmarkFramework.Run(s,benchmarkResults);
				}
				benchmarkResults.Title = String.Format(".NET: Length:{0} Count: {1}",
					benchmarkFramework.VectorLength,benchmarkFramework.IterationCount);
				showResults(benchmarkResults);
			} finally {
				this.Cursor = Cursors.Default;
			}
		}
		
		private void showResults(BenchmarkResults results) {
			bar1.Clear();
			bar2.Clear();
			bar3.Clear();
			bar4.Clear();
			tChart1.Header.Text = results.Title;
			tChart1.Header.Visible = true;
			for (int i=results.Count-1;i>=0;i--) {
				bar1.Add(results[i].SmplVecTicks,results[i].FuncName);
				bar4.Add(results[i].CplxVecTicks,results[i].FuncName);
				bar3.Add(results[i].SmplFuncTicks,results[i].FuncName);
				bar2.Add(results[i].CplxFuncTicks,results[i].FuncName);
			}
			tChart1.Update();

		}
		private void loadFile() {
			if (openFileDialog1.ShowDialog()==DialogResult.OK) {
				BenchmarkResults results = BenchmarkResults.LoadFromFile(openFileDialog1.FileName);
				showResults(results);
			}
		}

		private void saveFile()
		{
			if (saveFileDialog1.ShowDialog()==DialogResult.OK) 
			{
			}
		}

		private void menuItem1_Click(object sender, System.EventArgs e) {
			loadFile();
		}

		private void menuItem2_Click(object sender, System.EventArgs e) {
			if (saveFileDialog1.ShowDialog()==DialogResult.OK) {
				benchmarkResults.SaveToFile(saveFileDialog1.FileName);
			}
		}

		private void button2_Click(object sender, System.EventArgs e) {
			loadFile();
		}

		private void tChart1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
		
		}

        private void tChart2_Click(object sender, EventArgs e)
        {

        }
    }
}

