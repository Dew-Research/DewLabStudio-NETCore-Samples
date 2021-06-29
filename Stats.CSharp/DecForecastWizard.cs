using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math.Units;
using Dew.Math;
using Dew.Stats.Units;
using Dew.Math.Tee;

namespace StatsMasterDemo
{
    public class DecForecastWizard : StatsMasterDemo.BaseStatWizard
    {
        public DecForecastWizard()
        {
            InitializeComponent();
            // Initialize all necessary vectors
            timeseries = new Vector(0);
            data = new Vector(0);
            yv = new Vector(0);
            mv = new Vector(0);
            tv = new Vector(0);
            cv = new Vector(0);
            kv = new Vector(0);
            sv = new Vector(0);
            rv = new Vector(0);
            forecasts = new Vector(0);
            residuals = new Vector(0);

            openFileDialog1.Filter = "Vector files (*.vec)|*.vec";
            openFileDialog1.FilterIndex = 1;

            // Manually reposition Data wizard page after the Welcome page
            wizard.Pages.Remove(wizardPageData);
            wizard.Pages.Insert(1, wizardPageData);

        }

        private Steema.TeeChart.TChart tChartData;
        private Steema.TeeChart.Styles.Line line1;
        private Steema.TeeChart.Styles.Line line2;
        private Steema.TeeChart.Styles.Line line3;
        private NumericUpDown numericUpDownForNum;
        private Label label5;
        private GroupBox groupBox3;
        private NumericUpDown numericUpDownSeasons;
        private Label label6;
        private TextBox textBoxForCycle;
        private Label labelForecastCycle;
        private CheckBox checkBoxCycle;
        private Button button1;
        private OpenFileDialog openFileDialog1;
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecForecastWizard));
            this.wizardPageData = new Dew.Math.Controls.WizardPage();
            this.tChartData = new Steema.TeeChart.TChart();
            this.line1 = new Steema.TeeChart.Styles.Line();
            this.line2 = new Steema.TeeChart.Styles.Line();
            this.line3 = new Steema.TeeChart.Styles.Line();
            this.numericUpDownForNum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownSeasons = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxForCycle = new System.Windows.Forms.TextBox();
            this.labelForecastCycle = new System.Windows.Forms.Label();
            this.checkBoxCycle = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.wizard.SuspendLayout();
            this.wizardPageReport.SuspendLayout();
            this.wizardPageFormat.SuspendLayout();
            this.wizardPageData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForNum)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeasons)).BeginInit();
            this.SuspendLayout();
            // 
            // wizard
            // 
            this.wizard.Controls.Add(this.wizardPageData);
            this.wizard.Pages.AddRange(new Dew.Math.Controls.WizardPage[] {
            this.wizardPageData});
            this.wizard.Size = new System.Drawing.Size(988, 500);
            this.wizard.AfterSwitchPages += new Dew.Math.Controls.Wizard.AfterSwitchPagesEventHandler(this.wizard_AfterSwitchPages);
            this.wizard.Controls.SetChildIndex(this.wizardPageData, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageReport, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageFormat, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageWelcome, 0);
            // 
            // wizardPageReport
            // 
            this.wizardPageReport.Size = new System.Drawing.Size(591, 272);
            this.wizardPageReport.Title = "Decomposition Forecasting: Report";
            // 
            // richTextBox
            // 
            this.richTextBox.Size = new System.Drawing.Size(564, 133);
            // 
            // progressBar
            // 
            this.progressBar.Size = new System.Drawing.Size(510, 13);
            // 
            // wizardPageFormat
            // 
            this.wizardPageFormat.Size = new System.Drawing.Size(237, 429);
            this.wizardPageFormat.Title = "Step 2: Report options";
            // 
            // wizardPageWelcome
            // 
            this.wizardPageWelcome.Size = new System.Drawing.Size(591, 272);
            this.wizardPageWelcome.Title = "Decomposition Forecasting";
            // 
            // wizardPageData
            // 
            this.wizardPageData.Controls.Add(this.tChartData);
            this.wizardPageData.Controls.Add(this.numericUpDownForNum);
            this.wizardPageData.Controls.Add(this.label5);
            this.wizardPageData.Controls.Add(this.groupBox3);
            this.wizardPageData.Controls.Add(this.button1);
            this.wizardPageData.Description = "Define decomposition model parameters";
            this.wizardPageData.Location = new System.Drawing.Point(0, 0);
            this.wizardPageData.Name = "wizardPageData";
            this.wizardPageData.Size = new System.Drawing.Size(988, 452);
            this.wizardPageData.TabIndex = 13;
            this.wizardPageData.Title = "Step 1: Define model";
            // 
            // tChartData
            // 
            this.tChartData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tChartData.BackColor = System.Drawing.Color.Transparent;
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
        "Transformations"};
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
            this.tChartData.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
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
            this.tChartData.Location = new System.Drawing.Point(248, 75);
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
            this.tChartData.Series.Add(this.line1);
            this.tChartData.Series.Add(this.line2);
            this.tChartData.Series.Add(this.line3);
            this.tChartData.Size = new System.Drawing.Size(737, 364);
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
            this.tChartData.TabIndex = 11;
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
            this.line1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.line1.ColorEach = false;
            cursor1.CursorType = Steema.TeeChart.Drawing.CursorType.Default;
            this.line1.Cursor = cursor1;
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
            this.line1.OriginalCursor = cursor1;
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
            this.line1.Title = "Zero";
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
            // line2
            // 
            // 
            // 
            // 
            this.line2.AreaBrush.Color = System.Drawing.Color.White;
            this.line2.AreaBrush.Solid = true;
            this.line2.AreaBrush.Visible = false;
            // 
            // 
            // 
            this.line2.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(104)))));
            this.line2.Brush.Solid = true;
            this.line2.Brush.Visible = true;
            this.line2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(104)))));
            this.line2.ColorEach = false;
            this.line2.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Legend.Brush.Color = System.Drawing.Color.White;
            this.line2.Legend.Brush.Solid = true;
            this.line2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.line2.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.line2.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.line2.Legend.Font.Brush.Solid = true;
            this.line2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line2.Legend.Font.Shadow.Brush.Solid = true;
            this.line2.Legend.Font.Shadow.Brush.Visible = true;
            this.line2.Legend.Font.Size = 8;
            this.line2.Legend.Font.SizeFloat = 8F;
            this.line2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.line2.Legend.ImageBevel.Brush.Solid = true;
            this.line2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line2.Legend.Shadow.Brush.Solid = true;
            this.line2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line2.Marks.Brush.Solid = true;
            this.line2.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.line2.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.line2.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.line2.Marks.Font.Brush.Solid = true;
            this.line2.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line2.Marks.Font.Shadow.Brush.Solid = true;
            this.line2.Marks.Font.Shadow.Brush.Visible = true;
            this.line2.Marks.Font.Size = 8;
            this.line2.Marks.Font.SizeFloat = 8F;
            this.line2.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.line2.Marks.ImageBevel.Brush.Solid = true;
            this.line2.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.line2.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.line2.Marks.Shadow.Brush.Solid = true;
            this.line2.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.line2.Marks.Symbol.Brush.Solid = true;
            this.line2.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.line2.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.line2.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line2.Marks.Symbol.Shadow.Brush.Solid = true;
            this.line2.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.line2.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
            this.line2.Marks.TailParams.Margin = 0F;
            this.line2.Marks.TailParams.PointerHeight = 8D;
            this.line2.Marks.TailParams.PointerWidth = 8D;
            this.line2.OriginalCursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line2.Pointer.Brush.Color = System.Drawing.Color.Green;
            this.line2.Pointer.Brush.Solid = true;
            this.line2.Pointer.Brush.Visible = true;
            this.line2.Pointer.SizeDouble = 0D;
            this.line2.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.line2.RandomData = true;
            this.line2.Title = "Mov. ave.";
            this.line2.Type = "Steema.TeeChart.Styles.Line";
            this.line2.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.line2.XValues.DataMember = "X";
            this.line2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.line2.XValues.Series = this.line2;
            // 
            // 
            // 
            this.line2.YValues.DataMember = "Y";
            this.line2.YValues.Series = this.line2;
            // 
            // line3
            // 
            // 
            // 
            // 
            this.line3.AreaBrush.Color = System.Drawing.Color.White;
            this.line3.AreaBrush.Solid = true;
            this.line3.AreaBrush.Visible = false;
            // 
            // 
            // 
            this.line3.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(71)))));
            this.line3.Brush.Solid = true;
            this.line3.Brush.Visible = true;
            this.line3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(71)))));
            this.line3.ColorEach = false;
            this.line3.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Legend.Brush.Color = System.Drawing.Color.White;
            this.line3.Legend.Brush.Solid = true;
            this.line3.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.line3.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.line3.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.line3.Legend.Font.Brush.Solid = true;
            this.line3.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line3.Legend.Font.Shadow.Brush.Solid = true;
            this.line3.Legend.Font.Shadow.Brush.Visible = true;
            this.line3.Legend.Font.Size = 8;
            this.line3.Legend.Font.SizeFloat = 8F;
            this.line3.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.line3.Legend.ImageBevel.Brush.Solid = true;
            this.line3.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line3.Legend.Shadow.Brush.Solid = true;
            this.line3.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.line3.Marks.Brush.Solid = true;
            this.line3.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.line3.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.line3.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.line3.Marks.Font.Brush.Solid = true;
            this.line3.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line3.Marks.Font.Shadow.Brush.Solid = true;
            this.line3.Marks.Font.Shadow.Brush.Visible = true;
            this.line3.Marks.Font.Size = 8;
            this.line3.Marks.Font.SizeFloat = 8F;
            this.line3.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.line3.Marks.ImageBevel.Brush.Solid = true;
            this.line3.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.line3.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(114)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.line3.Marks.Shadow.Brush.Solid = true;
            this.line3.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.line3.Marks.Symbol.Brush.Solid = true;
            this.line3.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.line3.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.line3.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.line3.Marks.Symbol.Shadow.Brush.Solid = true;
            this.line3.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.line3.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos2")));
            this.line3.Marks.TailParams.Margin = 0F;
            this.line3.Marks.TailParams.PointerHeight = 8D;
            this.line3.Marks.TailParams.PointerWidth = 8D;
            this.line3.OriginalCursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.line3.Pointer.Brush.Color = System.Drawing.Color.Yellow;
            this.line3.Pointer.Brush.Solid = true;
            this.line3.Pointer.Brush.Visible = true;
            this.line3.Pointer.SizeDouble = 0D;
            this.line3.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.line3.RandomData = true;
            this.line3.Title = "Trend";
            this.line3.Type = "Steema.TeeChart.Styles.Line";
            this.line3.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.line3.XValues.DataMember = "X";
            this.line3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            this.line3.XValues.Series = this.line3;
            // 
            // 
            // 
            this.line3.YValues.DataMember = "Y";
            this.line3.YValues.Series = this.line3;
            // 
            // numericUpDownForNum
            // 
            this.numericUpDownForNum.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownForNum.Location = new System.Drawing.Point(91, 239);
            this.numericUpDownForNum.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownForNum.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownForNum.Name = "numericUpDownForNum";
            this.numericUpDownForNum.Size = new System.Drawing.Size(62, 23);
            this.numericUpDownForNum.TabIndex = 9;
            this.numericUpDownForNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "# of forecasts";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDownSeasons);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxForCycle);
            this.groupBox3.Controls.Add(this.labelForecastCycle);
            this.groupBox3.Controls.Add(this.checkBoxCycle);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(13, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(156, 93);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Decomposition parameters";
            // 
            // numericUpDownSeasons
            // 
            this.numericUpDownSeasons.Location = new System.Drawing.Point(88, 65);
            this.numericUpDownSeasons.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSeasons.Name = "numericUpDownSeasons";
            this.numericUpDownSeasons.Size = new System.Drawing.Size(62, 23);
            this.numericUpDownSeasons.TabIndex = 4;
            this.numericUpDownSeasons.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSeasons.ValueChanged += new System.EventHandler(this.numericUpDownSeasons_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Seasons";
            // 
            // textBoxForCycle
            // 
            this.textBoxForCycle.Enabled = false;
            this.textBoxForCycle.Location = new System.Drawing.Point(88, 36);
            this.textBoxForCycle.Name = "textBoxForCycle";
            this.textBoxForCycle.Size = new System.Drawing.Size(62, 23);
            this.textBoxForCycle.TabIndex = 2;
            this.textBoxForCycle.Text = "1";
            // 
            // labelForecastCycle
            // 
            this.labelForecastCycle.AutoSize = true;
            this.labelForecastCycle.Enabled = false;
            this.labelForecastCycle.Location = new System.Drawing.Point(6, 39);
            this.labelForecastCycle.Name = "labelForecastCycle";
            this.labelForecastCycle.Size = new System.Drawing.Size(81, 15);
            this.labelForecastCycle.TabIndex = 1;
            this.labelForecastCycle.Text = "Forecast cycle";
            // 
            // checkBoxCycle
            // 
            this.checkBoxCycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxCycle.Location = new System.Drawing.Point(9, 19);
            this.checkBoxCycle.Name = "checkBoxCycle";
            this.checkBoxCycle.Size = new System.Drawing.Size(70, 17);
            this.checkBoxCycle.TabIndex = 0;
            this.checkBoxCycle.Text = "Use cycle";
            this.checkBoxCycle.CheckedChanged += new System.EventHandler(this.checkBoxCycle_CheckedChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Load data";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DecForecastWizard
            // 
            this.ClientSize = new System.Drawing.Size(988, 500);
            this.Name = "DecForecastWizard";
            this.Load += new System.EventHandler(this.DecForecastWizard_Load);
            this.wizard.ResumeLayout(false);
            this.wizardPageReport.ResumeLayout(false);
            this.wizardPageReport.PerformLayout();
            this.wizardPageFormat.ResumeLayout(false);
            this.wizardPageFormat.PerformLayout();
            this.wizardPageData.ResumeLayout(false);
            this.wizardPageData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownForNum)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeasons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Dew.Math.Controls.WizardPage wizardPageData;
        private Vector timeseries;
        private Vector data, yv, mv, tv;
        private Vector cv, kv, sv, rv;
        private Vector forecasts, residuals;
        private double a, b, dmean; // trend parameters
        private int l, l2, fornum; // ma period

        public TVec TimeSeries
        {
            get { return (TVec)timeseries; }
        }


        #region Calculations

        /// <summary>
        /// Performs all necessary calculations and updates charts
        /// </summary>
        private void DoCalc()
        {
            if (timeseries.Length > 0)
            {
                // read parameters
                l = (int)numericUpDownSeasons.Value;
                l2 = (l - 1) / 2; //l/2 period end index
                fornum = (int)numericUpDownForNum.Value;
                // no transformation ...
                data.Copy(timeseries);

                // #1 : Remove mean
                dmean = data.Mean();
                yv.Copy(data);
                yv *= 1.0 / dmean;
                TeeChart.DrawValues(yv, tChartData.Series[0], 0, 1, false);

                // #2 : Moving average
                MovAve();
                TeeChart.DrawValues(mv, tChartData.Series[1], 0, 1, false);

                // #3 : Trend on M
                Trend();
                TeeChart.DrawValues(tv, tChartData.Series[2], 0, 1, false);

                // #4 : Cycle
                cv = mv / tv;

                // #5 :  Seasonality
                Seasonality();

                // #6 : Randomness
                Randomness();
            }
        }
        /// <summary>
        /// Forecasts values (must be called affter the DoCalc call).
        /// </summary>
        private void DoForecasts()
        {
            Vector xv = new Vector(0);
            forecasts.Size(data.Length + fornum);
            // Mean
            forecasts.SetVal(dmean);

            // Trend component
            xv.Size(forecasts);
            xv.Ramp();
            RegModels.LineEval(new double[] { a, b }, xv, tv);
            forecasts *= tv;

            // Seasonality
            sv.Resize(forecasts.Length, false);
            for (int i = l; i < sv.Length; i++)
                sv.Values[i] = sv.Values[i % l];
            forecasts *= sv;

            // add cycle factor, if specified
            if (checkBoxCycle.Checked)
            {
                cv.Resize(forecasts.Length, false);
                cv.SetVal(Convert.ToDouble(textBoxForCycle.Text), data.Length, fornum);
                forecasts *= tv;
            }
            // define R factor as 1.0 for forecasts
            rv.Resize(forecasts.Length, false);
            rv.SetVal(1.0, data.Length, fornum);

            // calculate residuals
            residuals.Size(data);
            residuals.Sub(data, forecasts, 0, 0, 0, data.Length);
        }
        
        /// <summary>
        /// Moving average on zero mean time series
        /// </summary>
        private void MovAve()
        {
            Vector v1 = new Vector(0);
            int mind;
            if (l <= 2) StatTimeSerAnalysis.MovingAverage(yv, l, mv, out mind, true);
            else
            {
                int eind = (yv.Length - 1) + l2 + 1;
                v1.Length = yv.Length + l2 * 2;
                v1.Copy(yv, 0, l2 + 1, yv.Length);
                for (int i = 0; i <= l2; i++)
                {
                    v1.Values[i] = v1.Values[i + l];
                    v1.Values[i + eind - 1] = v1.Values[eind - l + i];
                }
                StatTimeSerAnalysis.MovingAverage(v1, l, mv, out mind, true);
            }
        }

        /// <summary>
        /// Trend on moving average
        /// </summary>
        private void Trend()
        {
            Vector bv = new Vector(0);
            Vector x = new Vector(0);
            x.Size(mv);
            x.Ramp();
            // perform fit on truncated MA because first l2+1 and last l2+1  problem (see NIST pages)
            x.SetSubRange(l2, x.Length - 2 * l2);
            mv.SetSubRange(l2, mv.Length - 2 * l2);
            RegModels.LineFit(bv, x, mv, null);
            // but evaluate on whole interval
            x.SetSubRange();
            mv.SetSubRange();
            // trend parameters
            a = bv.Values[0];
            b = bv.Values[1];
            RegModels.LineEval(bv, x, tv);
        }

        private void Seasonality()
        {
            kv = yv / mv;
            sv.Size(l);
            double sum;
            int j, n;
            for (int i = 0; i < l; i++)
            {
                sum = 0.0;
                j = n = 0;
                while (j + i < kv.Length)
                {
                    sum += kv.Values[j + i];
                    j += l;
                    n++;
                }
                if (n > 1) sv.Values[i] = sum / (double)n; else sv.Values[i] = 0.0;
            }
        }

        private void Randomness()
        {
            int plen = sv.Length;
            rv.Size(kv);
            for (int i = 0; i < rv.Length; i++)
                rv.Values[i] = kv.Values[i] / sv.Values[i % plen];
        }

        #endregion

        /// <summary>
        /// Textual report
        /// </summary>
        private void TextReport()
        {
            richTextBox.SuspendLayout();
            wizard.BackEnabled = false;
            wizard.NextEnabled = false;
            try
            {
                richTextBox.Clear();
                progressBar.Value = 0; 
                DoCalc();
                progressBar.Value = 40;
                DoForecasts();
                progressBar.Value = 60;
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
                richTextBox.SelectedText = "Forecast summary\n\n";
                richTextBox.SelectedText = "Model:\tMean x Trend x ";
                if (checkBoxCycle.Checked) richTextBox.SelectedText += "Cycle x ";
                richTextBox.SelectedText += "Season\n";
                richTextBox.SelectedText += "Rows:\t" + data.Length.ToString() + "\n";
                richTextBox.SelectedText += "Mean:\t" + Math387.FormatSample(FmtString, timeseries.Mean()) + "\n";
                richTextBox.SelectedText += "Residuals RMS:\t" + Math387.FormatSample(FmtString, residuals.RMS()) + "\n";
                richTextBox.SelectedText += "Trend\t(" + Math387.FormatSample(FmtString, a) + ") + (" + Math387.FormatSample(FmtString, b) + ") x Time\n";
                richTextBox.SelectedText += "Seasons\t" + l.ToString() + "\n";
                richTextBox.SelectedText += "Seasonal component ratio:\n#\tratio\n";
                for (int i = 0; i < l; i++) richTextBox.SelectedText += (i + 1) + "\t" + Math387.FormatSample(FmtString, sv.Values[i]) + "\n";
                richTextBox.SelectedText = "\n";

                // forecasts section
                richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
                richTextBox.SelectedText = "Forecast\n\n";
                richTextBox.SelectionColor = Color.Blue;
                SetupTabs(richTextBox, 7);
                richTextBox.SelectedText = "Time\tForecast\tActual\tResidual\tTrend factor\tCycle\tSeason\tRandomness\n";

                string st = "";
                for (int i = 0; i < forecasts.Length; i++)
                {
                    st += i + 1 + "\t" + Math387.FormatSample(FmtString, forecasts.Values[i]) + "\t";
                    if (i < timeseries.Length) st += Math387.FormatSample(FmtString, data.Values[i]) + "\t" + Math387.FormatSample(FmtString, residuals.Values[i]) + "\t";
                    else st += "\t\t";
                    st += Math387.FormatSample(FmtString, tv.Values[i]) + "\t";
                    if (checkBoxCycle.Checked) st += Math387.FormatSample(FmtString, cv.Values[i]) + "\t"; else st += "\t";
                    st += Math387.FormatSample(FmtString, sv.Values[i]) + "\t";
                    st += Math387.FormatSample(FmtString, rv.Values[i]) + "\t\n";
                }
                richTextBox.SelectedText = st;
                if (checkBoxCharts.Checked)
                {
                    // Charts
                    // #1: Forecasts
                    progressBar.Value = 70;
                    Chart.Aspect.View3D = false;
                    Chart.Legend.Alignment = Steema.TeeChart.LegendAlignments.Bottom;
                    Chart.Legend.Visible = true;
                    Chart.Header.Text = "Forecasts";
                    Steema.TeeChart.Styles.Points pser;
                    Chart.Series.Add(pser = new Steema.TeeChart.Styles.Points());
                    Chart.Series.Add(new Steema.TeeChart.Styles.Line());
                    pser.Title = "Time Series";
                    pser.Pointer.VertSize = 2;
                    pser.Pointer.HorizSize = 2;
                    Chart.Series[1].Title = "Forecasts";
                    TeeChart.DrawValues(timeseries, Chart.Series[0], 0, 1, false);
                    TeeChart.DrawValues(forecasts, Chart.Series[1], 0, 1, false);
                    CopyToRichBox(richTextBox);
                    richTextBox.SelectedText = "\n";

                    // #2: Residuals
                    progressBar.Value = 75;
                    Chart.Legend.Visible = false;
                    Chart.Series.Clear();
                    Chart.Header.Text = "Residuals";
                    Chart.Series.Add(new Steema.TeeChart.Styles.Line());
                    TeeChart.DrawValues(residuals, Chart.Series[0], 0, 1, false);
                    CopyToRichBox(richTextBox);
                    richTextBox.SelectedText = "\n";

                    // #3: Trend factor
                    progressBar.Value = 80;
                    Chart.Legend.Visible = false;
                    Chart.Series.Clear();
                    Chart.Header.Text = "Trend factor";
                    Steema.TeeChart.Styles.Bar bseries;
                    Chart.Series.Add(bseries = new Steema.TeeChart.Styles.Bar());
                    bseries.Marks.Visible = false;
                    bseries.UseOrigin = true;
                    bseries.Origin = 1.0;
                    TeeChart.DrawValues(tv, Chart.Series[0], 0, 1, false);
                    CopyToRichBox(richTextBox);
                    richTextBox.SelectedText = "\n";

                    // #4: Cycle
                    progressBar.Value = 85;
                    Chart.Series.Clear();
                    Chart.Legend.Visible = false;
                    Chart.Header.Text = "Cycle factor";
                    Chart.Series.Add(bseries = new Steema.TeeChart.Styles.Bar());
                    bseries.Marks.Visible = false;
                    bseries.UseOrigin = true;
                    bseries.Origin = 1.0;
                    TeeChart.DrawValues(cv, Chart.Series[0], 0, 1, false);
                    CopyToRichBox(richTextBox);
                    richTextBox.SelectedText = "\n";

                    // #5: Seasonality
                    progressBar.Value = 90;
                    Chart.Series.Clear();
                    Chart.Legend.Visible = false;
                    Chart.Header.Text = "Season factor";
                    Chart.Series.Add(bseries = new Steema.TeeChart.Styles.Bar());
                    bseries.Marks.Visible = false;
                    bseries.UseOrigin = true;
                    bseries.Origin = 1.0;
                    TeeChart.DrawValues(sv, Chart.Series[0], 0, 1, false);
                    CopyToRichBox(richTextBox);
                    richTextBox.SelectedText = "\n";

                    // #6: Randomness
                    progressBar.Value = 95;
                    Chart.Series.Clear();
                    Chart.Legend.Visible = false;
                    Chart.Header.Text = "Randomness";
                    Chart.Series.Add(new Steema.TeeChart.Styles.Line());
                    TeeChart.DrawValues(rv, Chart.Series[0], 0, 1, false);
                    CopyToRichBox(richTextBox);
                    richTextBox.SelectedText = "\n";
                }
                
                progressBar.Value = 100;
            }
            finally
            {
                richTextBox.SelectionStart = 0;
                richTextBox.ResumeLayout();
                wizard.BackEnabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                timeseries.LoadFromFile(openFileDialog1.FileName);
                numericUpDownSeasons.Maximum = timeseries.Length - 4;
                DoCalc();
                if (wizard.SelectedPage == wizardPageData) wizard.NextEnabled = timeseries.Length > 0;
            }
        }

        private void numericUpDownSeasons_ValueChanged(object sender, EventArgs e)
        {
            DoCalc();
        }

        private void checkBoxCycle_CheckedChanged(object sender, EventArgs e)
        {
            labelForecastCycle.Enabled = checkBoxCycle.Checked;
            textBoxForCycle.Enabled = checkBoxCycle.Checked;
        }

        private void wizard_AfterSwitchPages(object sender, Dew.Math.Controls.Wizard.AfterSwitchPagesEventArgs e)
        {
            Dew.Math.Controls.WizardPage newpage = wizard.Pages[e.NewIndex];
            if (newpage == wizardPageReport)
            {
                TextReport();
                wizard.CancelEnabled = false;
            }
            else if (newpage == wizardPageData)
            {
                wizard.NextEnabled = timeseries.Length > 0;
            }
            else wizard.CancelEnabled = true;

        }

        private void DecForecastWizard_Load(object sender, EventArgs e)
        {
            wizardPageWelcome.Description = "Classical time series decomposition separates a time series into "
                + "five components: mean, long-range trend, seasonality, cycle, and randomness. "
                + "The decomposition model is:\n\n"
                + "Value = (Mean) x (Trend) x (Seasonality) x (Cycle) x (Random).\n\n"
                + "Note that this model is multiplicative rather than additive. Although "
                + "additive models are more popular in other areas of statistics, forecasters "
                + "have found that the multiplicative model fits a wider range of forecasting "
                + "situations.\n"
                + "Decomposition is popular among forecasters because it is easy to understand (and explain to others). "
                + "While complex ARIMA models are often popular among statisticians, they are not as well accepted among "
                + "forecasting practitioners. For seasonal (monthly, weekly, or quarterly) data, decomposition methods "
                + "are often as accurate as the ARIMA methods and they provide additional information about the trend and "
                + "cycle which may not be available in ARIMA methods.\n"
                + "Decomposition has one disadvantage: the cycle component must be input by the forecaster since it is not "
                + "estimated by the algorithm. You can get around this by ignoring the cycle, or by assuming a constant value. "
                + "Some forecasters consider this a strength because it allows the forecaster to enter information "
                + "about the current business cycle into the forecast.";

            DoCalc();
        }


    }
}

