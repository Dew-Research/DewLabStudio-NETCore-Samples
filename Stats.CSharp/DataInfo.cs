using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Dew.Math.Tee;
using Dew.Math;
using Dew.Math.Units;
using Dew.Stats.Units;

namespace StatsMasterDemo
{
    public class DataInfo : UserControl
    {
        private TVec data = null;
        private TVec xdata = null;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainerCharts;
        public Steema.TeeChart.TChart tChartData;
        public Steema.TeeChart.TChart tChartHistogram;
        private RichTextBox richTextBoxReport;
        private Steema.TeeChart.Styles.Line line1;
        private Steema.TeeChart.Styles.HorizBar horizBar1;
        private string stringformat = "0.0000";

        public string StringFormat
        {
            get { return stringformat; }
            set { stringformat = value; Update(); }
        }

        [DefaultValue(false)]
        public bool SettingsPanelVisible
        {
            get { return panelSettings.Visible; }
            set { panelSettings.Visible = value; }
        }

        public new void  Update()
        {
            if (data != null)
            {
                if (xdata != null && xdata.Length == data.Length) TeeChart.DrawValues(xdata, data, tChartData[0], false);
                else TeeChart.DrawValues(data, tChartData[0], 0, 1, false);

                // Histogram, need only Y values
                TVec hist, bins;
                MtxVec.CreateIt(out hist, out bins);
                try
                {
                    Statistics.Histogram(data, 20, hist, bins, true);
                    TeeChart.DrawValues(hist,bins, tChartHistogram[0], false);
                }
                finally
                {
                    MtxVec.FreeIt(ref hist, ref bins);
                }
                // Calculate Y values statistics
                double amean = Data.Mean();
                double astd = data.StdDev(amean);
                richTextBoxReport.Text = "Count:\t" + data.Length.ToString() + "\n"
                    + "Mean:\t" + amean.ToString(stringformat) + "\n"
                    + "Median:\t" + data.Median().ToString(stringformat) + "\n"
                    + "Std.dev:\t" + astd.ToString(stringformat) + "\n"
                    + "Skewness:\t" + data.Skewness(amean, astd).ToString(stringformat) + "\n"
                    + "Kurtosis:\t" + data.Kurtosis(amean, astd).ToString(stringformat) + "\n";
            }
        }

        private void SetupChart(Steema.TeeChart.TChart chart)
        {
            chart.Aspect.View3D = false;
            chart.Header.Visible = false;
        }
        
        public DataInfo()
        {
            InitializeComponent();
            panelSettings.Visible = false;
            SetupChart(tChartData);
            SetupChart(tChartHistogram);
            tChartHistogram.Axes.Bottom.Title.Text = "Count";
        }

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Steema.TeeChart.Drawing.Cursor cursor2 = new Steema.TeeChart.Drawing.Cursor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataInfo));
            this.panelSettings = new System.Windows.Forms.Panel();
            this.checkBoxStat = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxHistogram = new System.Windows.Forms.CheckBox();
            this.checkBoxData = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainerCharts = new System.Windows.Forms.SplitContainer();
            this.tChartData = new Steema.TeeChart.TChart();
            this.line1 = new Steema.TeeChart.Styles.Line();
            this.tChartHistogram = new Steema.TeeChart.TChart();
            this.horizBar1 = new Steema.TeeChart.Styles.HorizBar();
            this.richTextBoxReport = new System.Windows.Forms.RichTextBox();
            this.panelSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCharts)).BeginInit();
            this.splitContainerCharts.Panel1.SuspendLayout();
            this.splitContainerCharts.Panel2.SuspendLayout();
            this.splitContainerCharts.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.checkBoxStat);
            this.panelSettings.Controls.Add(this.groupBox1);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSettings.Location = new System.Drawing.Point(0, 0);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(121, 507);
            this.panelSettings.TabIndex = 0;
            this.panelSettings.Visible = false;
            // 
            // checkBoxStat
            // 
            this.checkBoxStat.Checked = true;
            this.checkBoxStat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxStat.Location = new System.Drawing.Point(9, 94);
            this.checkBoxStat.Name = "checkBoxStat";
            this.checkBoxStat.Size = new System.Drawing.Size(101, 18);
            this.checkBoxStat.TabIndex = 1;
            this.checkBoxStat.Text = "Basic statistics";
            this.checkBoxStat.CheckedChanged += new System.EventHandler(this.checkBoxStat_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxHistogram);
            this.groupBox1.Controls.Add(this.checkBoxData);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show";
            // 
            // checkBoxHistogram
            // 
            this.checkBoxHistogram.Checked = true;
            this.checkBoxHistogram.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHistogram.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxHistogram.Location = new System.Drawing.Point(6, 42);
            this.checkBoxHistogram.Name = "checkBoxHistogram";
            this.checkBoxHistogram.Size = new System.Drawing.Size(79, 18);
            this.checkBoxHistogram.TabIndex = 1;
            this.checkBoxHistogram.Text = "Histogram";
            this.checkBoxHistogram.CheckedChanged += new System.EventHandler(this.checkBoxHistogram_CheckedChanged);
            // 
            // checkBoxData
            // 
            this.checkBoxData.Checked = true;
            this.checkBoxData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxData.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxData.Location = new System.Drawing.Point(6, 19);
            this.checkBoxData.Name = "checkBoxData";
            this.checkBoxData.Size = new System.Drawing.Size(55, 18);
            this.checkBoxData.TabIndex = 0;
            this.checkBoxData.Text = "Data";
            this.checkBoxData.CheckedChanged += new System.EventHandler(this.checkBoxData_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(121, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainerCharts);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxReport);
            this.splitContainer1.Size = new System.Drawing.Size(817, 507);
            this.splitContainer1.SplitterDistance = 435;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainerCharts
            // 
            this.splitContainerCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerCharts.Location = new System.Drawing.Point(0, 0);
            this.splitContainerCharts.Name = "splitContainerCharts";
            // 
            // splitContainerCharts.Panel1
            // 
            this.splitContainerCharts.Panel1.Controls.Add(this.tChartData);
            // 
            // splitContainerCharts.Panel2
            // 
            this.splitContainerCharts.Panel2.Controls.Add(this.tChartHistogram);
            this.splitContainerCharts.Size = new System.Drawing.Size(817, 435);
            this.splitContainerCharts.SplitterDistance = 429;
            this.splitContainerCharts.SplitterWidth = 2;
            this.splitContainerCharts.TabIndex = 0;
            // 
            // tChartData
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
            this.tChartData.Axes.Bottom.Grid.Visible = false;
            // 
            // 
            // 
            this.tChartData.Axes.Bottom.Labels.Axis = this.tChartData.Axes.Bottom;
            // 
            // 
            // 
            this.tChartData.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartData.Axes.Bottom.Labels.Brush.Solid = true;
            this.tChartData.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartData.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartData.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.tChartData.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartData.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartData.Axes.Bottom.Labels.Font.Size = 9;
            this.tChartData.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            this.tChartData.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartData.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.tChartData.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.tChartData.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Axes.Bottom.MinorTicks.Length = 2;
            this.tChartData.Axes.Bottom.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChartData.Axes.Bottom.Ticks.Length = 4;
            this.tChartData.Axes.Bottom.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChartData.Axes.Bottom.TicksInner.Length = 0;
            this.tChartData.Axes.Bottom.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartData.Axes.Bottom.Title.Brush.Solid = true;
            this.tChartData.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartData.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartData.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.tChartData.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.tChartData.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.tChartData.Axes.Bottom.Title.Font.Size = 11;
            this.tChartData.Axes.Bottom.Title.Font.SizeFloat = 11F;
            this.tChartData.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartData.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.tChartData.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.tChartData.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Depth.AxisPen.Visible = false;
            // 
            // 
            // 
            this.tChartData.Axes.Depth.Labels.Axis = this.tChartData.Axes.Depth;
            // 
            // 
            // 
            this.tChartData.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartData.Axes.Depth.Labels.Brush.Solid = true;
            this.tChartData.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartData.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartData.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.tChartData.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartData.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartData.Axes.Depth.Labels.Font.Size = 9;
            this.tChartData.Axes.Depth.Labels.Font.SizeFloat = 9F;
            this.tChartData.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartData.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.tChartData.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.tChartData.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Axes.Depth.MinorTicks.Length = 2;
            this.tChartData.Axes.Depth.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChartData.Axes.Depth.Ticks.Length = 4;
            this.tChartData.Axes.Depth.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChartData.Axes.Depth.TicksInner.Length = 0;
            this.tChartData.Axes.Depth.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartData.Axes.Depth.Title.Brush.Solid = true;
            this.tChartData.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartData.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartData.Axes.Depth.Title.Font.Brush.Solid = true;
            this.tChartData.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.tChartData.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.tChartData.Axes.Depth.Title.Font.Size = 11;
            this.tChartData.Axes.Depth.Title.Font.SizeFloat = 11F;
            this.tChartData.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartData.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.tChartData.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.tChartData.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.DepthTop.AxisPen.Visible = false;
            // 
            // 
            // 
            this.tChartData.Axes.DepthTop.Labels.Axis = this.tChartData.Axes.DepthTop;
            // 
            // 
            // 
            this.tChartData.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartData.Axes.DepthTop.Labels.Brush.Solid = true;
            this.tChartData.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartData.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartData.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.tChartData.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartData.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartData.Axes.DepthTop.Labels.Font.Size = 9;
            this.tChartData.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            this.tChartData.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartData.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.tChartData.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.tChartData.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Axes.DepthTop.MinorTicks.Length = 2;
            this.tChartData.Axes.DepthTop.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChartData.Axes.DepthTop.Ticks.Length = 4;
            this.tChartData.Axes.DepthTop.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChartData.Axes.DepthTop.TicksInner.Length = 0;
            this.tChartData.Axes.DepthTop.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartData.Axes.DepthTop.Title.Brush.Solid = true;
            this.tChartData.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartData.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartData.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.tChartData.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.tChartData.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.tChartData.Axes.DepthTop.Title.Font.Size = 11;
            this.tChartData.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            this.tChartData.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartData.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.tChartData.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.tChartData.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Left.AxisPen.Visible = false;
            // 
            // 
            // 
            this.tChartData.Axes.Left.Labels.Axis = this.tChartData.Axes.Left;
            // 
            // 
            // 
            this.tChartData.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartData.Axes.Left.Labels.Brush.Solid = true;
            this.tChartData.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartData.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartData.Axes.Left.Labels.Font.Brush.Solid = true;
            this.tChartData.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartData.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartData.Axes.Left.Labels.Font.Size = 9;
            this.tChartData.Axes.Left.Labels.Font.SizeFloat = 9F;
            this.tChartData.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartData.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.tChartData.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.tChartData.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Axes.Left.MinorTicks.Length = 2;
            this.tChartData.Axes.Left.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChartData.Axes.Left.Ticks.Length = 4;
            this.tChartData.Axes.Left.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChartData.Axes.Left.TicksInner.Length = 0;
            this.tChartData.Axes.Left.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartData.Axes.Left.Title.Brush.Solid = true;
            this.tChartData.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartData.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartData.Axes.Left.Title.Font.Brush.Solid = true;
            this.tChartData.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.tChartData.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.tChartData.Axes.Left.Title.Font.Size = 11;
            this.tChartData.Axes.Left.Title.Font.SizeFloat = 11F;
            this.tChartData.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartData.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.tChartData.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.tChartData.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Right.AxisPen.Visible = false;
            // 
            // 
            // 
            this.tChartData.Axes.Right.Labels.Axis = this.tChartData.Axes.Right;
            // 
            // 
            // 
            this.tChartData.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartData.Axes.Right.Labels.Brush.Solid = true;
            this.tChartData.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartData.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartData.Axes.Right.Labels.Font.Brush.Solid = true;
            this.tChartData.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartData.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartData.Axes.Right.Labels.Font.Size = 9;
            this.tChartData.Axes.Right.Labels.Font.SizeFloat = 9F;
            this.tChartData.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartData.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.tChartData.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.tChartData.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Axes.Right.MinorTicks.Length = 2;
            this.tChartData.Axes.Right.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChartData.Axes.Right.Ticks.Length = 4;
            this.tChartData.Axes.Right.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChartData.Axes.Right.TicksInner.Length = 0;
            this.tChartData.Axes.Right.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartData.Axes.Right.Title.Brush.Solid = true;
            this.tChartData.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartData.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartData.Axes.Right.Title.Font.Brush.Solid = true;
            this.tChartData.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.tChartData.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.tChartData.Axes.Right.Title.Font.Size = 11;
            this.tChartData.Axes.Right.Title.Font.SizeFloat = 11F;
            this.tChartData.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartData.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.tChartData.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.tChartData.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Top.Labels.Axis = this.tChartData.Axes.Top;
            // 
            // 
            // 
            this.tChartData.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartData.Axes.Top.Labels.Brush.Solid = true;
            this.tChartData.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartData.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartData.Axes.Top.Labels.Font.Brush.Solid = true;
            this.tChartData.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartData.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartData.Axes.Top.Labels.Font.Size = 9;
            this.tChartData.Axes.Top.Labels.Font.SizeFloat = 9F;
            this.tChartData.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartData.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.tChartData.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.tChartData.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Axes.Top.MinorTicks.Length = 2;
            this.tChartData.Axes.Top.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChartData.Axes.Top.Ticks.Length = 4;
            this.tChartData.Axes.Top.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChartData.Axes.Top.TicksInner.Length = 0;
            this.tChartData.Axes.Top.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartData.Axes.Top.Title.Brush.Solid = true;
            this.tChartData.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartData.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartData.Axes.Top.Title.Font.Brush.Solid = true;
            this.tChartData.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.tChartData.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.tChartData.Axes.Top.Title.Font.Size = 11;
            this.tChartData.Axes.Top.Title.Font.SizeFloat = 11F;
            this.tChartData.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartData.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.tChartData.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.tChartData.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.tChartData.Cursor = System.Windows.Forms.Cursors.Default;
            this.tChartData.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.tChartData.Footer.Brush.Solid = true;
            this.tChartData.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.tChartData.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.tChartData.Footer.Font.Brush.Solid = true;
            this.tChartData.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Footer.Font.Shadow.Brush.Solid = true;
            this.tChartData.Footer.Font.Shadow.Brush.Visible = true;
            this.tChartData.Footer.Font.Size = 8;
            this.tChartData.Footer.Font.SizeFloat = 8F;
            this.tChartData.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartData.Footer.ImageBevel.Brush.Solid = true;
            this.tChartData.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Footer.Shadow.Brush.Solid = true;
            this.tChartData.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChartData.Header.Brush.Solid = true;
            this.tChartData.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Header.Font.Bold = false;
            // 
            // 
            // 
            this.tChartData.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartData.Header.Font.Brush.Solid = true;
            this.tChartData.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Header.Font.Shadow.Brush.Solid = true;
            this.tChartData.Header.Font.Shadow.Brush.Visible = true;
            this.tChartData.Header.Font.Size = 12;
            this.tChartData.Header.Font.SizeFloat = 12F;
            this.tChartData.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartData.Header.ImageBevel.Brush.Solid = true;
            this.tChartData.Header.ImageBevel.Brush.Visible = true;
            this.tChartData.Header.Lines = new string[] {
        "Data"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChartData.Header.Shadow.Brush.Solid = true;
            this.tChartData.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Legend.Brush.Color = System.Drawing.Color.White;
            this.tChartData.Legend.Brush.Solid = true;
            this.tChartData.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.tChartData.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartData.Legend.Font.Brush.Solid = true;
            this.tChartData.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Legend.Font.Shadow.Brush.Solid = true;
            this.tChartData.Legend.Font.Shadow.Brush.Visible = true;
            this.tChartData.Legend.Font.Size = 9;
            this.tChartData.Legend.Font.SizeFloat = 9F;
            this.tChartData.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartData.Legend.ImageBevel.Brush.Solid = true;
            this.tChartData.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Legend.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChartData.Legend.Shadow.Brush.Solid = true;
            this.tChartData.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Legend.Symbol.Legend = this.tChartData.Legend;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Legend.Symbol.Shadow.Brush.Solid = true;
            this.tChartData.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.tChartData.Legend.Title.Brush.Solid = true;
            this.tChartData.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.tChartData.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.tChartData.Legend.Title.Font.Brush.Solid = true;
            this.tChartData.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.tChartData.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.tChartData.Legend.Title.Font.Size = 8;
            this.tChartData.Legend.Title.Font.SizeFloat = 8F;
            this.tChartData.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartData.Legend.Title.ImageBevel.Brush.Solid = true;
            this.tChartData.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Legend.Title.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Legend.Title.Shadow.Brush.Solid = true;
            this.tChartData.Legend.Title.Shadow.Brush.Visible = true;
            this.tChartData.Legend.Visible = false;
            this.tChartData.Location = new System.Drawing.Point(0, 0);
            this.tChartData.Name = "tChartData";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChartData.Panel.Brush.Gradient.UseMiddle = true;
            this.tChartData.Panel.Brush.Solid = true;
            this.tChartData.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartData.Panel.ImageBevel.Brush.Solid = true;
            this.tChartData.Panel.ImageBevel.Brush.Visible = true;
            this.tChartData.Panel.ImageBevel.Width = 1;
            // 
            // 
            // 
            this.tChartData.Panel.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Panel.Shadow.Brush.Solid = true;
            this.tChartData.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Panning.Allow = Steema.TeeChart.ScrollModes.None;
            this.tChartData.Series.Add(this.line1);
            this.tChartData.Size = new System.Drawing.Size(429, 435);
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.tChartData.SubFooter.Brush.Solid = true;
            this.tChartData.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.tChartData.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.tChartData.SubFooter.Font.Brush.Solid = true;
            this.tChartData.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.SubFooter.Font.Shadow.Brush.Solid = true;
            this.tChartData.SubFooter.Font.Shadow.Brush.Visible = true;
            this.tChartData.SubFooter.Font.Size = 8;
            this.tChartData.SubFooter.Font.SizeFloat = 8F;
            this.tChartData.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartData.SubFooter.ImageBevel.Brush.Solid = true;
            this.tChartData.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.SubFooter.Shadow.Brush.Solid = true;
            this.tChartData.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChartData.SubHeader.Brush.Solid = true;
            this.tChartData.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.tChartData.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartData.SubHeader.Font.Brush.Solid = true;
            this.tChartData.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.SubHeader.Font.Shadow.Brush.Solid = true;
            this.tChartData.SubHeader.Font.Shadow.Brush.Visible = true;
            this.tChartData.SubHeader.Font.Size = 12;
            this.tChartData.SubHeader.Font.SizeFloat = 12F;
            this.tChartData.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartData.SubHeader.ImageBevel.Brush.Solid = true;
            this.tChartData.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChartData.SubHeader.Shadow.Brush.Solid = true;
            this.tChartData.SubHeader.Shadow.Brush.Visible = true;
            this.tChartData.TabIndex = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.tChartData.Walls.Back.Brush.Solid = true;
            this.tChartData.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartData.Walls.Back.ImageBevel.Brush.Solid = true;
            this.tChartData.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Walls.Back.Shadow.Brush.Solid = true;
            this.tChartData.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.tChartData.Walls.Bottom.Brush.Solid = true;
            this.tChartData.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartData.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.tChartData.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Walls.Bottom.Shadow.Brush.Solid = true;
            this.tChartData.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.tChartData.Walls.Left.Brush.Solid = true;
            this.tChartData.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartData.Walls.Left.ImageBevel.Brush.Solid = true;
            this.tChartData.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Walls.Left.Shadow.Brush.Solid = true;
            this.tChartData.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.tChartData.Walls.Right.Brush.Solid = true;
            this.tChartData.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartData.Walls.Right.ImageBevel.Brush.Solid = true;
            this.tChartData.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartData.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartData.Walls.Right.Shadow.Brush.Solid = true;
            this.tChartData.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartData.Zoom.Animated = true;
            // 
            // 
            // 
            this.tChartData.Zoom.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.tChartData.Zoom.Brush.Solid = true;
            this.tChartData.Zoom.Brush.Visible = true;
            // 
            // line1
            // 
            // 
            // 
            // 
            this.line1.AreaBrush.Color = System.Drawing.Color.White;
            this.line1.AreaBrush.Solid = true;
            this.line1.AreaBrush.Visible = false;
            // 
            // 
            // 
            this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.line1.Brush.Solid = true;
            this.line1.Brush.Visible = true;
            this.line1.ClickableLine = false;
            this.line1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.line1.ColorEach = false;
            this.line1.ColorEachLine = false;
            cursor2.CursorType = Steema.TeeChart.Drawing.CursorType.Default;
            this.line1.Cursor = cursor2;
            this.line1.Dark3D = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Legend.Brush.Color = System.Drawing.Color.White;
            this.line1.Legend.Brush.Solid = true;
            this.line1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.line1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.line1.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.line1.Legend.Font.Brush.Solid = true;
            this.line1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line1.Legend.Font.Shadow.Brush.Solid = true;
            this.line1.Legend.Font.Shadow.Brush.Visible = true;
            this.line1.Legend.Font.Size = 8;
            this.line1.Legend.Font.SizeFloat = 8F;
            this.line1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.line1.Legend.ImageBevel.Brush.Solid = true;
            this.line1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line1.Legend.Shadow.Brush.Solid = true;
            this.line1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line1.Marks.Brush.Solid = true;
            this.line1.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.line1.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.line1.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.line1.Marks.Font.Brush.Solid = true;
            this.line1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line1.Marks.Font.Shadow.Brush.Solid = true;
            this.line1.Marks.Font.Shadow.Brush.Visible = true;
            this.line1.Marks.Font.Size = 8;
            this.line1.Marks.Font.SizeFloat = 8F;
            this.line1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.line1.Marks.ImageBevel.Brush.Solid = true;
            this.line1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.line1.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.line1.Marks.Shadow.Brush.Solid = true;
            this.line1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.line1.Marks.Symbol.Brush.Solid = true;
            this.line1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.line1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.line1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line1.Marks.Symbol.Shadow.Brush.Solid = true;
            this.line1.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.line1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
            this.line1.Marks.TailParams.Margin = 0F;
            this.line1.Marks.TailParams.PointerHeight = 8D;
            this.line1.Marks.TailParams.PointerWidth = 8D;
            this.line1.OriginalCursor = cursor2;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Pointer.Brush.Color = System.Drawing.Color.Red;
            this.line1.Pointer.Brush.Solid = true;
            this.line1.Pointer.Brush.Visible = true;
            this.line1.Pointer.SizeDouble = 0D;
            this.line1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.line1.RandomData = true;
            this.line1.Title = "line1";
            this.line1.Type = "Steema.TeeChart.Styles.Line";
            this.line1.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.line1.XValues.DataMember = "X";
            this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.line1.XValues.Series = this.line1;
            // 
            // 
            // 
            this.line1.YValues.DataMember = "Y";
            this.line1.YValues.Series = this.line1;
            // 
            // tChartHistogram
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
            this.tChartHistogram.Axes.Bottom.Grid.Visible = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Bottom.Labels.Axis = this.tChartHistogram.Axes.Bottom;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartHistogram.Axes.Bottom.Labels.Brush.Solid = true;
            this.tChartHistogram.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartHistogram.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.tChartHistogram.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartHistogram.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartHistogram.Axes.Bottom.Labels.Font.Size = 9;
            this.tChartHistogram.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            this.tChartHistogram.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartHistogram.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.tChartHistogram.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.tChartHistogram.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Bottom.MinorTicks.Length = 2;
            this.tChartHistogram.Axes.Bottom.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Bottom.Ticks.Length = 4;
            this.tChartHistogram.Axes.Bottom.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Bottom.TicksInner.Length = 0;
            this.tChartHistogram.Axes.Bottom.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartHistogram.Axes.Bottom.Title.Brush.Solid = true;
            this.tChartHistogram.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartHistogram.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.tChartHistogram.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.tChartHistogram.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.tChartHistogram.Axes.Bottom.Title.Font.Size = 11;
            this.tChartHistogram.Axes.Bottom.Title.Font.SizeFloat = 11F;
            this.tChartHistogram.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartHistogram.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.tChartHistogram.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.tChartHistogram.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Depth.AxisPen.Visible = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Depth.Labels.Axis = this.tChartHistogram.Axes.Depth;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartHistogram.Axes.Depth.Labels.Brush.Solid = true;
            this.tChartHistogram.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartHistogram.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.tChartHistogram.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartHistogram.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartHistogram.Axes.Depth.Labels.Font.Size = 9;
            this.tChartHistogram.Axes.Depth.Labels.Font.SizeFloat = 9F;
            this.tChartHistogram.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartHistogram.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.tChartHistogram.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.tChartHistogram.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Depth.MinorTicks.Length = 2;
            this.tChartHistogram.Axes.Depth.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Depth.Ticks.Length = 4;
            this.tChartHistogram.Axes.Depth.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Depth.TicksInner.Length = 0;
            this.tChartHistogram.Axes.Depth.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartHistogram.Axes.Depth.Title.Brush.Solid = true;
            this.tChartHistogram.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartHistogram.Axes.Depth.Title.Font.Brush.Solid = true;
            this.tChartHistogram.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.tChartHistogram.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.tChartHistogram.Axes.Depth.Title.Font.Size = 11;
            this.tChartHistogram.Axes.Depth.Title.Font.SizeFloat = 11F;
            this.tChartHistogram.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartHistogram.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.tChartHistogram.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.tChartHistogram.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.DepthTop.AxisPen.Visible = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.DepthTop.Labels.Axis = this.tChartHistogram.Axes.DepthTop;
            // 
            // 
            // 
            this.tChartHistogram.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartHistogram.Axes.DepthTop.Labels.Brush.Solid = true;
            this.tChartHistogram.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartHistogram.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.tChartHistogram.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartHistogram.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartHistogram.Axes.DepthTop.Labels.Font.Size = 9;
            this.tChartHistogram.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            this.tChartHistogram.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartHistogram.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.tChartHistogram.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.tChartHistogram.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Axes.DepthTop.MinorTicks.Length = 2;
            this.tChartHistogram.Axes.DepthTop.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.DepthTop.Ticks.Length = 4;
            this.tChartHistogram.Axes.DepthTop.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.DepthTop.TicksInner.Length = 0;
            this.tChartHistogram.Axes.DepthTop.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartHistogram.Axes.DepthTop.Title.Brush.Solid = true;
            this.tChartHistogram.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartHistogram.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.tChartHistogram.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.tChartHistogram.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.tChartHistogram.Axes.DepthTop.Title.Font.Size = 11;
            this.tChartHistogram.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            this.tChartHistogram.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartHistogram.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.tChartHistogram.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.tChartHistogram.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Left.AxisPen.Visible = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Left.Labels.Axis = this.tChartHistogram.Axes.Left;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartHistogram.Axes.Left.Labels.Brush.Solid = true;
            this.tChartHistogram.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartHistogram.Axes.Left.Labels.Font.Brush.Solid = true;
            this.tChartHistogram.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartHistogram.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartHistogram.Axes.Left.Labels.Font.Size = 9;
            this.tChartHistogram.Axes.Left.Labels.Font.SizeFloat = 9F;
            this.tChartHistogram.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartHistogram.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.tChartHistogram.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.tChartHistogram.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Left.MinorTicks.Length = 2;
            this.tChartHistogram.Axes.Left.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Left.Ticks.Length = 4;
            this.tChartHistogram.Axes.Left.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Left.TicksInner.Length = 0;
            this.tChartHistogram.Axes.Left.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartHistogram.Axes.Left.Title.Brush.Solid = true;
            this.tChartHistogram.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartHistogram.Axes.Left.Title.Font.Brush.Solid = true;
            this.tChartHistogram.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.tChartHistogram.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.tChartHistogram.Axes.Left.Title.Font.Size = 11;
            this.tChartHistogram.Axes.Left.Title.Font.SizeFloat = 11F;
            this.tChartHistogram.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartHistogram.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.tChartHistogram.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.tChartHistogram.Axes.Left.Title.Shadow.Brush.Visible = true;
            this.tChartHistogram.Axes.Left.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Right.AxisPen.Visible = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Right.Labels.Axis = this.tChartHistogram.Axes.Right;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartHistogram.Axes.Right.Labels.Brush.Solid = true;
            this.tChartHistogram.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartHistogram.Axes.Right.Labels.Font.Brush.Solid = true;
            this.tChartHistogram.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartHistogram.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartHistogram.Axes.Right.Labels.Font.Size = 9;
            this.tChartHistogram.Axes.Right.Labels.Font.SizeFloat = 9F;
            this.tChartHistogram.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartHistogram.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.tChartHistogram.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.tChartHistogram.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Right.MinorTicks.Length = 2;
            this.tChartHistogram.Axes.Right.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Right.Ticks.Length = 4;
            this.tChartHistogram.Axes.Right.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Right.TicksInner.Length = 0;
            this.tChartHistogram.Axes.Right.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartHistogram.Axes.Right.Title.Brush.Solid = true;
            this.tChartHistogram.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartHistogram.Axes.Right.Title.Font.Brush.Solid = true;
            this.tChartHistogram.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.tChartHistogram.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.tChartHistogram.Axes.Right.Title.Font.Size = 11;
            this.tChartHistogram.Axes.Right.Title.Font.SizeFloat = 11F;
            this.tChartHistogram.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartHistogram.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.tChartHistogram.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.tChartHistogram.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Top.Labels.Axis = this.tChartHistogram.Axes.Top;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.tChartHistogram.Axes.Top.Labels.Brush.Solid = true;
            this.tChartHistogram.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartHistogram.Axes.Top.Labels.Font.Brush.Solid = true;
            this.tChartHistogram.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.tChartHistogram.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.tChartHistogram.Axes.Top.Labels.Font.Size = 9;
            this.tChartHistogram.Axes.Top.Labels.Font.SizeFloat = 9F;
            this.tChartHistogram.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartHistogram.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.tChartHistogram.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.tChartHistogram.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Top.MinorTicks.Length = 2;
            this.tChartHistogram.Axes.Top.MinorTicks.Visible = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Top.Ticks.Length = 4;
            this.tChartHistogram.Axes.Top.Ticks.Visible = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Top.TicksInner.Length = 0;
            this.tChartHistogram.Axes.Top.TicksInner.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.tChartHistogram.Axes.Top.Title.Brush.Solid = true;
            this.tChartHistogram.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.tChartHistogram.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartHistogram.Axes.Top.Title.Font.Brush.Solid = true;
            this.tChartHistogram.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.tChartHistogram.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.tChartHistogram.Axes.Top.Title.Font.Size = 11;
            this.tChartHistogram.Axes.Top.Title.Font.SizeFloat = 11F;
            this.tChartHistogram.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartHistogram.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.tChartHistogram.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.tChartHistogram.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.tChartHistogram.Cursor = System.Windows.Forms.Cursors.Default;
            this.tChartHistogram.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.tChartHistogram.Footer.Brush.Solid = true;
            this.tChartHistogram.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.tChartHistogram.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.tChartHistogram.Footer.Font.Brush.Solid = true;
            this.tChartHistogram.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Footer.Font.Shadow.Brush.Solid = true;
            this.tChartHistogram.Footer.Font.Shadow.Brush.Visible = true;
            this.tChartHistogram.Footer.Font.Size = 8;
            this.tChartHistogram.Footer.Font.SizeFloat = 8F;
            this.tChartHistogram.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartHistogram.Footer.ImageBevel.Brush.Solid = true;
            this.tChartHistogram.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Footer.Shadow.Brush.Solid = true;
            this.tChartHistogram.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChartHistogram.Header.Brush.Solid = true;
            this.tChartHistogram.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Header.Font.Bold = false;
            // 
            // 
            // 
            this.tChartHistogram.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartHistogram.Header.Font.Brush.Solid = true;
            this.tChartHistogram.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Header.Font.Shadow.Brush.Solid = true;
            this.tChartHistogram.Header.Font.Shadow.Brush.Visible = true;
            this.tChartHistogram.Header.Font.Size = 12;
            this.tChartHistogram.Header.Font.SizeFloat = 12F;
            this.tChartHistogram.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartHistogram.Header.ImageBevel.Brush.Solid = true;
            this.tChartHistogram.Header.ImageBevel.Brush.Visible = true;
            this.tChartHistogram.Header.Lines = new string[] {
        "Histogram"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChartHistogram.Header.Shadow.Brush.Solid = true;
            this.tChartHistogram.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Legend.Brush.Color = System.Drawing.Color.White;
            this.tChartHistogram.Legend.Brush.Solid = true;
            this.tChartHistogram.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.tChartHistogram.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChartHistogram.Legend.Font.Brush.Solid = true;
            this.tChartHistogram.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Legend.Font.Shadow.Brush.Solid = true;
            this.tChartHistogram.Legend.Font.Shadow.Brush.Visible = true;
            this.tChartHistogram.Legend.Font.Size = 9;
            this.tChartHistogram.Legend.Font.SizeFloat = 9F;
            this.tChartHistogram.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartHistogram.Legend.ImageBevel.Brush.Solid = true;
            this.tChartHistogram.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Legend.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChartHistogram.Legend.Shadow.Brush.Solid = true;
            this.tChartHistogram.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Legend.Symbol.Legend = this.tChartHistogram.Legend;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Legend.Symbol.Shadow.Brush.Solid = true;
            this.tChartHistogram.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.tChartHistogram.Legend.Title.Brush.Solid = true;
            this.tChartHistogram.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.tChartHistogram.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.tChartHistogram.Legend.Title.Font.Brush.Solid = true;
            this.tChartHistogram.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.tChartHistogram.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.tChartHistogram.Legend.Title.Font.Size = 8;
            this.tChartHistogram.Legend.Title.Font.SizeFloat = 8F;
            this.tChartHistogram.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartHistogram.Legend.Title.ImageBevel.Brush.Solid = true;
            this.tChartHistogram.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Legend.Title.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Legend.Title.Shadow.Brush.Solid = true;
            this.tChartHistogram.Legend.Title.Shadow.Brush.Visible = true;
            this.tChartHistogram.Legend.Visible = false;
            this.tChartHistogram.Location = new System.Drawing.Point(0, 0);
            this.tChartHistogram.Name = "tChartHistogram";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChartHistogram.Panel.Brush.Gradient.UseMiddle = true;
            this.tChartHistogram.Panel.Brush.Solid = true;
            this.tChartHistogram.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartHistogram.Panel.ImageBevel.Brush.Solid = true;
            this.tChartHistogram.Panel.ImageBevel.Brush.Visible = true;
            this.tChartHistogram.Panel.ImageBevel.Width = 1;
            // 
            // 
            // 
            this.tChartHistogram.Panel.Pen.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Panel.Shadow.Brush.Solid = true;
            this.tChartHistogram.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Panning.Allow = Steema.TeeChart.ScrollModes.None;
            this.tChartHistogram.Series.Add(this.horizBar1);
            this.tChartHistogram.Size = new System.Drawing.Size(386, 435);
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.tChartHistogram.SubFooter.Brush.Solid = true;
            this.tChartHistogram.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.tChartHistogram.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.tChartHistogram.SubFooter.Font.Brush.Solid = true;
            this.tChartHistogram.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.SubFooter.Font.Shadow.Brush.Solid = true;
            this.tChartHistogram.SubFooter.Font.Shadow.Brush.Visible = true;
            this.tChartHistogram.SubFooter.Font.Size = 8;
            this.tChartHistogram.SubFooter.Font.SizeFloat = 8F;
            this.tChartHistogram.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartHistogram.SubFooter.ImageBevel.Brush.Solid = true;
            this.tChartHistogram.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.SubFooter.Shadow.Brush.Solid = true;
            this.tChartHistogram.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tChartHistogram.SubHeader.Brush.Solid = true;
            this.tChartHistogram.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.tChartHistogram.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChartHistogram.SubHeader.Font.Brush.Solid = true;
            this.tChartHistogram.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.SubHeader.Font.Shadow.Brush.Solid = true;
            this.tChartHistogram.SubHeader.Font.Shadow.Brush.Visible = true;
            this.tChartHistogram.SubHeader.Font.Size = 12;
            this.tChartHistogram.SubHeader.Font.SizeFloat = 12F;
            this.tChartHistogram.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartHistogram.SubHeader.ImageBevel.Brush.Solid = true;
            this.tChartHistogram.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChartHistogram.SubHeader.Shadow.Brush.Solid = true;
            this.tChartHistogram.SubHeader.Shadow.Brush.Visible = true;
            this.tChartHistogram.TabIndex = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.tChartHistogram.Walls.Back.Brush.Solid = true;
            this.tChartHistogram.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartHistogram.Walls.Back.ImageBevel.Brush.Solid = true;
            this.tChartHistogram.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Walls.Back.Shadow.Brush.Solid = true;
            this.tChartHistogram.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.tChartHistogram.Walls.Bottom.Brush.Solid = true;
            this.tChartHistogram.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartHistogram.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.tChartHistogram.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Walls.Bottom.Shadow.Brush.Solid = true;
            this.tChartHistogram.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.tChartHistogram.Walls.Left.Brush.Solid = true;
            this.tChartHistogram.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartHistogram.Walls.Left.ImageBevel.Brush.Solid = true;
            this.tChartHistogram.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Walls.Left.Shadow.Brush.Solid = true;
            this.tChartHistogram.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.tChartHistogram.Walls.Right.Brush.Solid = true;
            this.tChartHistogram.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.tChartHistogram.Walls.Right.ImageBevel.Brush.Solid = true;
            this.tChartHistogram.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChartHistogram.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.tChartHistogram.Walls.Right.Shadow.Brush.Solid = true;
            this.tChartHistogram.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.tChartHistogram.Zoom.Animated = true;
            // 
            // 
            // 
            this.tChartHistogram.Zoom.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(173)))), ((int)(((byte)(216)))), ((int)(((byte)(230)))));
            this.tChartHistogram.Zoom.Brush.Solid = true;
            this.tChartHistogram.Zoom.Brush.Visible = true;
            // 
            // horizBar1
            // 
            this.horizBar1.BarHeightPercent = 100;
            this.horizBar1.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
            this.horizBar1.BarWidthPercent = 100;
            // 
            // 
            // 
            this.horizBar1.Brush.Color = System.Drawing.Color.Red;
            this.horizBar1.Brush.Solid = true;
            this.horizBar1.Brush.Visible = true;
            this.horizBar1.Color = System.Drawing.Color.Red;
            this.horizBar1.ColorEach = false;
            this.horizBar1.Cursor = cursor2;
            // 
            // 
            // 
            // 
            // 
            // 
            this.horizBar1.Legend.Brush.Color = System.Drawing.Color.White;
            this.horizBar1.Legend.Brush.Solid = true;
            this.horizBar1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.horizBar1.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.horizBar1.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.horizBar1.Legend.Font.Brush.Solid = true;
            this.horizBar1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.horizBar1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.horizBar1.Legend.Font.Shadow.Brush.Solid = true;
            this.horizBar1.Legend.Font.Shadow.Brush.Visible = true;
            this.horizBar1.Legend.Font.Size = 8;
            this.horizBar1.Legend.Font.SizeFloat = 8F;
            this.horizBar1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.horizBar1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.horizBar1.Legend.ImageBevel.Brush.Solid = true;
            this.horizBar1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.horizBar1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.horizBar1.Legend.Shadow.Brush.Solid = true;
            this.horizBar1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.horizBar1.Marks.ArrowLength = 20;
            this.horizBar1.Marks.AutoPosition = false;
            // 
            // 
            // 
            this.horizBar1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.horizBar1.Marks.Brush.Solid = true;
            this.horizBar1.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.horizBar1.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.horizBar1.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.horizBar1.Marks.Font.Brush.Solid = true;
            this.horizBar1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.horizBar1.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.horizBar1.Marks.Font.Shadow.Brush.Solid = true;
            this.horizBar1.Marks.Font.Shadow.Brush.Visible = true;
            this.horizBar1.Marks.Font.Size = 8;
            this.horizBar1.Marks.Font.SizeFloat = 8F;
            this.horizBar1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.horizBar1.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.horizBar1.Marks.ImageBevel.Brush.Solid = true;
            this.horizBar1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.horizBar1.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.horizBar1.Marks.Shadow.Brush.Solid = true;
            this.horizBar1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.horizBar1.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.horizBar1.Marks.Symbol.Brush.Solid = true;
            this.horizBar1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.horizBar1.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.horizBar1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.horizBar1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.horizBar1.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.horizBar1.Marks.Symbol.Shadow.Brush.Solid = true;
            this.horizBar1.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.horizBar1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
            this.horizBar1.Marks.TailParams.Margin = 0F;
            this.horizBar1.Marks.TailParams.PointerHeight = 8D;
            this.horizBar1.Marks.TailParams.PointerWidth = 8D;
            this.horizBar1.Marks.Visible = false;
            this.horizBar1.MultiBar = Steema.TeeChart.Styles.MultiBars.None;
            this.horizBar1.OriginalCursor = cursor2;
            this.horizBar1.RandomData = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.horizBar1.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.horizBar1.Shadow.Brush.Solid = true;
            this.horizBar1.Shadow.Brush.Visible = true;
            this.horizBar1.SideMargins = false;
            this.horizBar1.Title = "horizBar1";
            this.horizBar1.Type = "Steema.TeeChart.Styles.HorizBar";
            this.horizBar1.UseExtendedNumRange = false;
            this.horizBar1.VertAxis = Steema.TeeChart.Styles.VerticalAxis.Right;
            // 
            // 
            // 
            this.horizBar1.XValues.DataMember = "X";
            this.horizBar1.XValues.Series = this.horizBar1;
            // 
            // 
            // 
            this.horizBar1.YValues.DataMember = "Bar";
            this.horizBar1.YValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.horizBar1.YValues.Series = this.horizBar1;
            // 
            // richTextBoxReport
            // 
            this.richTextBoxReport.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxReport.DetectUrls = false;
            this.richTextBoxReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxReport.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxReport.Name = "richTextBoxReport";
            this.richTextBoxReport.ReadOnly = true;
            this.richTextBoxReport.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxReport.Size = new System.Drawing.Size(817, 71);
            this.richTextBoxReport.TabIndex = 0;
            this.richTextBoxReport.Text = "";
            // 
            // DataInfo
            // 
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelSettings);
            this.Name = "DataInfo";
            this.Size = new System.Drawing.Size(938, 507);
            this.panelSettings.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainerCharts.Panel1.ResumeLayout(false);
            this.splitContainerCharts.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCharts)).EndInit();
            this.splitContainerCharts.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxHistogram;
        private System.Windows.Forms.CheckBox checkBoxData;
        private System.Windows.Forms.CheckBox checkBoxStat;


        /// <summary>
        /// Y Values
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),
        Browsable(false)]
		public TVec Data
        {
            get { return data; }
            set
            {
                data = value;
                Update();
            }
        }

		/// <summary>
		/// X values.
		/// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),
        Browsable(false)]
        public TVec xData
		{
			get { return xdata;}
			set
			{
				xdata = value;
				Update();
			}
		}

		public bool ShowStat
		{
			get { return this.checkBoxStat.Checked;}
			set { checkBoxStat.Checked = value;}
		}

		public bool ShowHistogram
		{
			get{ return checkBoxHistogram.Checked; }
			set { checkBoxHistogram.Checked = value; }
		}

		public bool ShowData
		{
			get { return checkBoxData.Checked;}
			set { checkBoxData.Checked = value;}

		}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Update();
        }

        private void checkBoxData_CheckedChanged(object sender, EventArgs e)
        {
            splitContainerCharts.Panel1Collapsed = !checkBoxData.Checked;
        }

        private void checkBoxHistogram_CheckedChanged(object sender, EventArgs e)
        {
            splitContainerCharts.Panel2Collapsed = !checkBoxHistogram.Checked;
        }

        private void checkBoxStat_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !checkBoxStat.Checked;
        }
    }
}
