using System.Drawing;
using System;
using System.Windows.Forms;
using Steema.TeeChart;
using Steema.TeeChart.Styles;
using Dew.Math.Units;

namespace MtxVecDemo
{
    partial class IfThenForm
    {
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
            if (MtxForLoop.mtxThreadPool != null)
            {
                MtxForLoop.mtxThreadPool.Destroy();
                MtxForLoop.mtxThreadPool = null;
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private RichTextBox Memo1;
        private Button MaskThreadButton;
        private TChart Chart;
        private Bar barSeries;
        private CheckBox PlainBox;
        private CheckBox VecBox;
        private CheckBox FindIndexBlockBox;
        private CheckBox MaskBlockThreadBox;
        private CheckBox PlainThreadBox;
        private CheckBox MaskBlockBox;
        private ComboBox DataLenBox;
        private Label Label1;
        private ComboBox GranBox;
        private Label Label2;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IfThenForm));
            this.Memo1 = new System.Windows.Forms.RichTextBox();
            this.MaskThreadButton = new System.Windows.Forms.Button();
            this.Chart = new Steema.TeeChart.TChart();
            this.barSeries = new Steema.TeeChart.Styles.Bar();
            this.PlainBox = new System.Windows.Forms.CheckBox();
            this.VecBox = new System.Windows.Forms.CheckBox();
            this.FindIndexBlockBox = new System.Windows.Forms.CheckBox();
            this.MaskBlockThreadBox = new System.Windows.Forms.CheckBox();
            this.PlainThreadBox = new System.Windows.Forms.CheckBox();
            this.MaskBlockBox = new System.Windows.Forms.CheckBox();
            this.DataLenBox = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GranBox = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Memo1
            // 
            this.Memo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Memo1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Memo1.Location = new System.Drawing.Point(12, 8);
            this.Memo1.Name = "Memo1";
            this.Memo1.Size = new System.Drawing.Size(942, 131);
            this.Memo1.TabIndex = 0;
            this.Memo1.Text = "Memo1";
            // 
            // MaskThreadButton
            // 
            this.MaskThreadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MaskThreadButton.Location = new System.Drawing.Point(12, 543);
            this.MaskThreadButton.Name = "MaskThreadButton";
            this.MaskThreadButton.Size = new System.Drawing.Size(112, 25);
            this.MaskThreadButton.TabIndex = 1;
            this.MaskThreadButton.Text = "Run";
            this.MaskThreadButton.UseVisualStyleBackColor = true;
            this.MaskThreadButton.Click += new System.EventHandler(this.MaskThreadButtonClick);
            // 
            // Chart
            // 
            this.Chart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
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
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.Bottom.Labels.Font.Size = 9;
            this.Chart.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Chart.Axes.Bottom.Title.Font.Name = "Arial";
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.Bottom.Title.Font.Size = 12;
            this.Chart.Axes.Bottom.Title.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.Depth.Labels.Font.Size = 9;
            this.Chart.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.Chart.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.Chart.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Chart.Axes.Depth.Title.Font.Name = "Arial";
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.Depth.Title.Font.Size = 12;
            this.Chart.Axes.Depth.Title.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.DepthTop.Labels.Font.Size = 9;
            this.Chart.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Chart.Axes.DepthTop.Title.Font.Name = "Arial";
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.DepthTop.Title.Font.Size = 12;
            this.Chart.Axes.DepthTop.Title.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.Left.Labels.Font.Size = 9;
            this.Chart.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.Chart.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.Chart.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.Chart.Axes.Left.Title.Caption = "Time [ms]";
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Chart.Axes.Left.Title.Font.Name = "Arial";
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.Left.Title.Font.Size = 12;
            this.Chart.Axes.Left.Title.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.Chart.Axes.Left.Title.Lines = new string[] {
        "Time [ms]"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.Left.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.Right.Labels.Font.Size = 9;
            this.Chart.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.Chart.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.Chart.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Chart.Axes.Right.Title.Font.Name = "Arial";
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.Right.Title.Font.Size = 12;
            this.Chart.Axes.Right.Title.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.Top.Labels.Font.Size = 9;
            this.Chart.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.Chart.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.Chart.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Chart.Axes.Top.Title.Font.Name = "Arial";
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Axes.Top.Title.Font.Size = 12;
            this.Chart.Axes.Top.Title.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Footer.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Footer.Font.Size = 8;
            this.Chart.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Header.Font.Size = 12;
            this.Chart.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Legend.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Legend.Font.Size = 11;
            this.Chart.Legend.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Legend.Title.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Legend.Title.Font.Size = 8;
            this.Chart.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Legend.Visible = false;
            this.Chart.Location = new System.Drawing.Point(12, 147);
            this.Chart.Name = "Chart";
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            this.Chart.Printer.Margins = margins1;
            this.Chart.Series.Add(this.barSeries);
            this.Chart.Size = new System.Drawing.Size(942, 384);
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.SubFooter.Font.Size = 8;
            this.Chart.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.SubHeader.Font.Size = 12;
            this.Chart.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Chart.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.Chart.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.Chart.Walls.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Chart.Zoom.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // barSeries
            // 
            this.barSeries.BarRound = Steema.TeeChart.Styles.BarRounding.AtValue;
            // 
            // 
            // 
            this.barSeries.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.barSeries.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.barSeries.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.barSeries.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.barSeries.Legend.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.barSeries.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.barSeries.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.barSeries.Legend.Font.Size = 8;
            this.barSeries.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.barSeries.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.barSeries.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.barSeries.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.barSeries.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.barSeries.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            // 
            // 
            // 
            // 
            // 
            // 
            this.barSeries.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.barSeries.Marks.Font.Size = 10;
            this.barSeries.Marks.Font.SizeFloat = 10F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.barSeries.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.barSeries.Marks.OnTop = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.barSeries.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.barSeries.Marks.Style = Steema.TeeChart.Styles.MarksStyles.Value;
            // 
            // 
            // 
            // 
            // 
            // 
            this.barSeries.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.barSeries.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            this.barSeries.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            // 
            // 
            // 
            this.barSeries.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            // 
            // 
            // 
            this.barSeries.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
            this.barSeries.OriginalCursor = null;
            // 
            // 
            // 
            this.barSeries.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.barSeries.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.barSeries.Title = "BarSeries";
            this.barSeries.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.barSeries.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // PlainBox
            // 
            this.PlainBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlainBox.Checked = true;
            this.PlainBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PlainBox.Location = new System.Drawing.Point(141, 547);
            this.PlainBox.Name = "PlainBox";
            this.PlainBox.Size = new System.Drawing.Size(97, 17);
            this.PlainBox.TabIndex = 3;
            this.PlainBox.Text = "Plain";
            // 
            // VecBox
            // 
            this.VecBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.VecBox.Checked = true;
            this.VecBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VecBox.Location = new System.Drawing.Point(264, 547);
            this.VecBox.Name = "VecBox";
            this.VecBox.Size = new System.Drawing.Size(97, 17);
            this.VecBox.TabIndex = 4;
            this.VecBox.Text = "Vectorized";
            // 
            // FindIndexBlockBox
            // 
            this.FindIndexBlockBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FindIndexBlockBox.Checked = true;
            this.FindIndexBlockBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FindIndexBlockBox.Location = new System.Drawing.Point(384, 547);
            this.FindIndexBlockBox.Name = "FindIndexBlockBox";
            this.FindIndexBlockBox.Size = new System.Drawing.Size(97, 17);
            this.FindIndexBlockBox.TabIndex = 5;
            this.FindIndexBlockBox.Text = "FindIndexes";
            // 
            // MaskBlockThreadBox
            // 
            this.MaskBlockThreadBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MaskBlockThreadBox.Checked = true;
            this.MaskBlockThreadBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MaskBlockThreadBox.Location = new System.Drawing.Point(630, 547);
            this.MaskBlockThreadBox.Name = "MaskBlockThreadBox";
            this.MaskBlockThreadBox.Size = new System.Drawing.Size(112, 17);
            this.MaskBlockThreadBox.TabIndex = 6;
            this.MaskBlockThreadBox.Text = "Masked&&Thread";
            // 
            // PlainThreadBox
            // 
            this.PlainThreadBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlainThreadBox.Checked = true;
            this.PlainThreadBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PlainThreadBox.Location = new System.Drawing.Point(759, 547);
            this.PlainThreadBox.Name = "PlainThreadBox";
            this.PlainThreadBox.Size = new System.Drawing.Size(97, 17);
            this.PlainThreadBox.TabIndex = 7;
            this.PlainThreadBox.Text = "Plain&&Thread";
            // 
            // MaskBlockBox
            // 
            this.MaskBlockBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MaskBlockBox.Checked = true;
            this.MaskBlockBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MaskBlockBox.Location = new System.Drawing.Point(504, 547);
            this.MaskBlockBox.Name = "MaskBlockBox";
            this.MaskBlockBox.Size = new System.Drawing.Size(97, 17);
            this.MaskBlockBox.TabIndex = 8;
            this.MaskBlockBox.Text = "Masked&&Blocked";
            // 
            // DataLenBox
            // 
            this.DataLenBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DataLenBox.Items.AddRange(new object[] {
            "800KB",
            "8MB",
            "80MB",
            "800MB"});
            this.DataLenBox.Location = new System.Drawing.Point(141, 576);
            this.DataLenBox.Name = "DataLenBox";
            this.DataLenBox.Size = new System.Drawing.Size(145, 21);
            this.DataLenBox.TabIndex = 9;
            this.DataLenBox.Text = "10MB";
            this.DataLenBox.SelectedIndexChanged += new System.EventHandler(this.DataLenBox_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label1.Location = new System.Drawing.Point(64, 579);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 13);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Data length:";
            // 
            // GranBox
            // 
            this.GranBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GranBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.GranBox.Items.AddRange(new object[] {
            "1",
            "2",
            "4"});
            this.GranBox.Location = new System.Drawing.Point(504, 576);
            this.GranBox.Name = "GranBox";
            this.GranBox.Size = new System.Drawing.Size(145, 21);
            this.GranBox.TabIndex = 11;
            this.GranBox.Text = "1";
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label2.Location = new System.Drawing.Point(426, 579);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 17);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Granularity:";
            // 
            // IfThenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 605);
            this.Controls.Add(this.Memo1);
            this.Controls.Add(this.MaskThreadButton);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.PlainBox);
            this.Controls.Add(this.VecBox);
            this.Controls.Add(this.FindIndexBlockBox);
            this.Controls.Add(this.MaskBlockThreadBox);
            this.Controls.Add(this.PlainThreadBox);
            this.Controls.Add(this.MaskBlockBox);
            this.Controls.Add(this.DataLenBox);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.GranBox);
            this.Controls.Add(this.Label2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IfThenForm";
            this.Text = "IfThenForm";
            this.ResumeLayout(false);

        }

        #endregion
    }
}