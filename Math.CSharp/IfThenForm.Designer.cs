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
            Margins margins1 = new Margins();
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IfThenForm));
            Memo1 = new RichTextBox();
            MaskThreadButton = new Button();
            Chart = new TChart();
            barSeries = new Bar();
            PlainBox = new CheckBox();
            VecBox = new CheckBox();
            FindIndexBlockBox = new CheckBox();
            MaskBlockThreadBox = new CheckBox();
            PlainThreadBox = new CheckBox();
            MaskBlockBox = new CheckBox();
            DataLenBox = new ComboBox();
            Label1 = new Label();
            GranBox = new ComboBox();
            Label2 = new Label();
            SuspendLayout();
            // 
            // Memo1
            // 
            Memo1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Memo1.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Memo1.Location = new Point(12, 8);
            Memo1.Name = "Memo1";
            Memo1.Size = new Size(925, 151);
            Memo1.TabIndex = 0;
            Memo1.Text = "Memo1";
            // 
            // MaskThreadButton
            // 
            MaskThreadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MaskThreadButton.Location = new Point(12, 563);
            MaskThreadButton.Name = "MaskThreadButton";
            MaskThreadButton.Size = new Size(112, 25);
            MaskThreadButton.TabIndex = 1;
            MaskThreadButton.Text = "Run";
            MaskThreadButton.UseVisualStyleBackColor = true;
            MaskThreadButton.Click += MaskThreadButtonClick;
            // 
            // Chart
            // 
            Chart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            Chart.Axes.Bottom.Labels.Brush.Color = Color.White;
            Chart.Axes.Bottom.Labels.Brush.Solid = true;
            Chart.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            Chart.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart.Axes.Bottom.Labels.Font.Brush.Solid = true;
            Chart.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Bottom.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            Chart.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            Chart.Axes.Bottom.Labels.Font.Size = 9;
            Chart.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            Chart.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Bottom.Labels.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            Chart.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Bottom.Labels.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            Chart.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Bottom.Title.Brush.Color = Color.Silver;
            Chart.Axes.Bottom.Title.Brush.Solid = true;
            Chart.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            Chart.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart.Axes.Bottom.Title.Font.Brush.Solid = true;
            Chart.Axes.Bottom.Title.Font.Brush.Visible = true;
            Chart.Axes.Bottom.Title.Font.Name = "Arial";
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Bottom.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            Chart.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            Chart.Axes.Bottom.Title.Font.Size = 12;
            Chart.Axes.Bottom.Title.Font.SizeFloat = 12F;
            Chart.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Bottom.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            Chart.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Bottom.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            Chart.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Depth.Labels.Brush.Color = Color.White;
            Chart.Axes.Depth.Labels.Brush.Solid = true;
            Chart.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            Chart.Axes.Depth.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart.Axes.Depth.Labels.Font.Brush.Solid = true;
            Chart.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Depth.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            Chart.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            Chart.Axes.Depth.Labels.Font.Size = 9;
            Chart.Axes.Depth.Labels.Font.SizeFloat = 9F;
            Chart.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Depth.Labels.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            Chart.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Depth.Labels.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            Chart.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Depth.Title.Brush.Color = Color.Silver;
            Chart.Axes.Depth.Title.Brush.Solid = true;
            Chart.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            Chart.Axes.Depth.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart.Axes.Depth.Title.Font.Brush.Solid = true;
            Chart.Axes.Depth.Title.Font.Brush.Visible = true;
            Chart.Axes.Depth.Title.Font.Name = "Arial";
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Depth.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            Chart.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            Chart.Axes.Depth.Title.Font.Size = 12;
            Chart.Axes.Depth.Title.Font.SizeFloat = 12F;
            Chart.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Depth.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            Chart.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Depth.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Depth.Title.Shadow.Brush.Solid = true;
            Chart.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.DepthTop.Labels.Brush.Color = Color.White;
            Chart.Axes.DepthTop.Labels.Brush.Solid = true;
            Chart.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            Chart.Axes.DepthTop.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            Chart.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            Chart.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            Chart.Axes.DepthTop.Labels.Font.Size = 9;
            Chart.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            Chart.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.DepthTop.Labels.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            Chart.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.DepthTop.Labels.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            Chart.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.DepthTop.Title.Brush.Color = Color.Silver;
            Chart.Axes.DepthTop.Title.Brush.Solid = true;
            Chart.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            Chart.Axes.DepthTop.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart.Axes.DepthTop.Title.Font.Brush.Solid = true;
            Chart.Axes.DepthTop.Title.Font.Brush.Visible = true;
            Chart.Axes.DepthTop.Title.Font.Name = "Arial";
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.DepthTop.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            Chart.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            Chart.Axes.DepthTop.Title.Font.Size = 12;
            Chart.Axes.DepthTop.Title.Font.SizeFloat = 12F;
            Chart.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.DepthTop.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            Chart.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.DepthTop.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            Chart.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Left.Labels.Brush.Color = Color.White;
            Chart.Axes.Left.Labels.Brush.Solid = true;
            Chart.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            Chart.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart.Axes.Left.Labels.Font.Brush.Solid = true;
            Chart.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Left.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            Chart.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            Chart.Axes.Left.Labels.Font.Size = 9;
            Chart.Axes.Left.Labels.Font.SizeFloat = 9F;
            Chart.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Left.Labels.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            Chart.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Left.Labels.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Left.Labels.Shadow.Brush.Solid = true;
            Chart.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Left.Title.Brush.Color = Color.Silver;
            Chart.Axes.Left.Title.Brush.Solid = true;
            Chart.Axes.Left.Title.Brush.Visible = true;
            Chart.Axes.Left.Title.Caption = "Time [ms]";
            // 
            // 
            // 
            Chart.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            Chart.Axes.Left.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart.Axes.Left.Title.Font.Brush.Solid = true;
            Chart.Axes.Left.Title.Font.Brush.Visible = true;
            Chart.Axes.Left.Title.Font.Name = "Arial";
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Left.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            Chart.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            Chart.Axes.Left.Title.Font.Size = 12;
            Chart.Axes.Left.Title.Font.SizeFloat = 12F;
            Chart.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Left.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            Chart.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            Chart.Axes.Left.Title.Lines = new string[]
    {
    "Time [ms]"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Left.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Left.Title.Shadow.Brush.Solid = true;
            Chart.Axes.Left.Title.Shadow.Brush.Visible = true;
            Chart.Axes.Left.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Right.Labels.Brush.Color = Color.White;
            Chart.Axes.Right.Labels.Brush.Solid = true;
            Chart.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            Chart.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart.Axes.Right.Labels.Font.Brush.Solid = true;
            Chart.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Right.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            Chart.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            Chart.Axes.Right.Labels.Font.Size = 9;
            Chart.Axes.Right.Labels.Font.SizeFloat = 9F;
            Chart.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Right.Labels.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            Chart.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Right.Labels.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Right.Labels.Shadow.Brush.Solid = true;
            Chart.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Right.Title.Brush.Color = Color.Silver;
            Chart.Axes.Right.Title.Brush.Solid = true;
            Chart.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            Chart.Axes.Right.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart.Axes.Right.Title.Font.Brush.Solid = true;
            Chart.Axes.Right.Title.Font.Brush.Visible = true;
            Chart.Axes.Right.Title.Font.Name = "Arial";
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Right.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            Chart.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            Chart.Axes.Right.Title.Font.Size = 12;
            Chart.Axes.Right.Title.Font.SizeFloat = 12F;
            Chart.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Right.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            Chart.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Right.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Right.Title.Shadow.Brush.Solid = true;
            Chart.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Top.Labels.Brush.Color = Color.White;
            Chart.Axes.Top.Labels.Brush.Solid = true;
            Chart.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            Chart.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart.Axes.Top.Labels.Font.Brush.Solid = true;
            Chart.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Top.Labels.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            Chart.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            Chart.Axes.Top.Labels.Font.Size = 9;
            Chart.Axes.Top.Labels.Font.SizeFloat = 9F;
            Chart.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Top.Labels.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            Chart.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Top.Labels.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Top.Labels.Shadow.Brush.Solid = true;
            Chart.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Top.Title.Brush.Color = Color.Silver;
            Chart.Axes.Top.Title.Brush.Solid = true;
            Chart.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            Chart.Axes.Top.Title.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart.Axes.Top.Title.Font.Brush.Solid = true;
            Chart.Axes.Top.Title.Font.Brush.Visible = true;
            Chart.Axes.Top.Title.Font.Name = "Arial";
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Top.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            Chart.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            Chart.Axes.Top.Title.Font.Size = 12;
            Chart.Axes.Top.Title.Font.SizeFloat = 12F;
            Chart.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Top.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            Chart.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Axes.Top.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart.Axes.Top.Title.Shadow.Brush.Solid = true;
            Chart.Axes.Top.Title.Shadow.Brush.Visible = true;
            Chart.BackColor = Color.White;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Footer.Brush.Color = Color.Silver;
            Chart.Footer.Brush.Solid = true;
            Chart.Footer.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Footer.Font.Bold = false;
            // 
            // 
            // 
            Chart.Footer.Font.Brush.Color = Color.Red;
            Chart.Footer.Font.Brush.Solid = true;
            Chart.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Footer.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Footer.Font.Shadow.Brush.Solid = true;
            Chart.Footer.Font.Shadow.Brush.Visible = true;
            Chart.Footer.Font.Size = 8;
            Chart.Footer.Font.SizeFloat = 8F;
            Chart.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Footer.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Footer.ImageBevel.Brush.Solid = true;
            Chart.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Footer.Shadow.Brush.Color = Color.DarkGray;
            Chart.Footer.Shadow.Brush.Solid = true;
            Chart.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Header.Brush.Color = Color.FromArgb(192, 192, 192);
            Chart.Header.Brush.Solid = true;
            Chart.Header.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Header.Font.Bold = false;
            // 
            // 
            // 
            Chart.Header.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart.Header.Font.Brush.Solid = true;
            Chart.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Header.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Header.Font.Shadow.Brush.Solid = true;
            Chart.Header.Font.Shadow.Brush.Visible = true;
            Chart.Header.Font.Size = 12;
            Chart.Header.Font.SizeFloat = 12F;
            Chart.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Header.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Header.ImageBevel.Brush.Solid = true;
            Chart.Header.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Header.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            Chart.Header.Shadow.Brush.Solid = true;
            Chart.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Legend.Brush.Color = Color.White;
            Chart.Legend.Brush.Solid = true;
            Chart.Legend.Brush.Visible = true;
            Chart.Legend.CheckBoxes = false;
            // 
            // 
            // 
            Chart.Legend.Font.Bold = false;
            // 
            // 
            // 
            Chart.Legend.Font.Brush.Color = Color.FromArgb(64, 64, 64);
            Chart.Legend.Font.Brush.Solid = true;
            Chart.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Legend.Font.Shadow.Brush.Solid = true;
            Chart.Legend.Font.Shadow.Brush.Visible = true;
            Chart.Legend.Font.Size = 11;
            Chart.Legend.Font.SizeFloat = 11F;
            Chart.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Legend.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Legend.ImageBevel.Brush.Solid = true;
            Chart.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Legend.Shadow.Brush.Color = Color.FromArgb(0, 0, 0);
            Chart.Legend.Shadow.Brush.Solid = true;
            Chart.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Legend.Symbol.Shadow.Brush.Color = Color.DarkGray;
            Chart.Legend.Symbol.Shadow.Brush.Solid = true;
            Chart.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Legend.Title.Brush.Color = Color.White;
            Chart.Legend.Title.Brush.Solid = true;
            Chart.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            Chart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            Chart.Legend.Title.Font.Brush.Color = Color.Black;
            Chart.Legend.Title.Font.Brush.Solid = true;
            Chart.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Legend.Title.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.Legend.Title.Font.Shadow.Brush.Solid = true;
            Chart.Legend.Title.Font.Shadow.Brush.Visible = true;
            Chart.Legend.Title.Font.Size = 8;
            Chart.Legend.Title.Font.SizeFloat = 8F;
            Chart.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Legend.Title.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Legend.Title.ImageBevel.Brush.Solid = true;
            Chart.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Legend.Title.Shadow.Brush.Color = Color.DarkGray;
            Chart.Legend.Title.Shadow.Brush.Solid = true;
            Chart.Legend.Title.Shadow.Brush.Visible = true;
            Chart.Legend.Visible = false;
            Chart.Location = new Point(12, 167);
            Chart.Name = "Chart";
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Panel.Brush.Color = Color.FromArgb(255, 255, 255);
            Chart.Panel.Brush.Solid = true;
            Chart.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Panel.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Panel.ImageBevel.Brush.Solid = true;
            Chart.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Panel.Shadow.Brush.Color = Color.DarkGray;
            Chart.Panel.Shadow.Brush.Solid = true;
            Chart.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            Chart.Printer.Margins = margins1;
            Chart.Series.Add(barSeries);
            Chart.Size = new Size(925, 384);
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.SubFooter.Brush.Color = Color.Silver;
            Chart.SubFooter.Brush.Solid = true;
            Chart.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            Chart.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            Chart.SubFooter.Font.Brush.Color = Color.Red;
            Chart.SubFooter.Font.Brush.Solid = true;
            Chart.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.SubFooter.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.SubFooter.Font.Shadow.Brush.Solid = true;
            Chart.SubFooter.Font.Shadow.Brush.Visible = true;
            Chart.SubFooter.Font.Size = 8;
            Chart.SubFooter.Font.SizeFloat = 8F;
            Chart.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.SubFooter.ImageBevel.Brush.Color = Color.LightGray;
            Chart.SubFooter.ImageBevel.Brush.Solid = true;
            Chart.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.SubFooter.Shadow.Brush.Color = Color.DarkGray;
            Chart.SubFooter.Shadow.Brush.Solid = true;
            Chart.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.SubHeader.Brush.Color = Color.FromArgb(192, 192, 192);
            Chart.SubHeader.Brush.Solid = true;
            Chart.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            Chart.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            Chart.SubHeader.Font.Brush.Color = Color.FromArgb(128, 128, 128);
            Chart.SubHeader.Font.Brush.Solid = true;
            Chart.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.SubHeader.Font.Shadow.Brush.Color = Color.DarkGray;
            Chart.SubHeader.Font.Shadow.Brush.Solid = true;
            Chart.SubHeader.Font.Shadow.Brush.Visible = true;
            Chart.SubHeader.Font.Size = 12;
            Chart.SubHeader.Font.SizeFloat = 12F;
            Chart.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.SubHeader.ImageBevel.Brush.Color = Color.LightGray;
            Chart.SubHeader.ImageBevel.Brush.Solid = true;
            Chart.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.SubHeader.Shadow.Brush.Color = Color.FromArgb(169, 169, 169);
            Chart.SubHeader.Shadow.Brush.Solid = true;
            Chart.SubHeader.Shadow.Brush.Visible = true;
            Chart.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Walls.Back.Brush.Color = Color.Silver;
            Chart.Walls.Back.Brush.Solid = true;
            Chart.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Walls.Back.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Walls.Back.ImageBevel.Brush.Solid = true;
            Chart.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Walls.Back.Shadow.Brush.Color = Color.DarkGray;
            Chart.Walls.Back.Shadow.Brush.Solid = true;
            Chart.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Walls.Bottom.Brush.Color = Color.White;
            Chart.Walls.Bottom.Brush.Solid = true;
            Chart.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Walls.Bottom.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Walls.Bottom.ImageBevel.Brush.Solid = true;
            Chart.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Walls.Bottom.Shadow.Brush.Color = Color.DarkGray;
            Chart.Walls.Bottom.Shadow.Brush.Solid = true;
            Chart.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Walls.Left.Brush.Color = Color.LightYellow;
            Chart.Walls.Left.Brush.Solid = true;
            Chart.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Walls.Left.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Walls.Left.ImageBevel.Brush.Solid = true;
            Chart.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Walls.Left.Shadow.Brush.Color = Color.DarkGray;
            Chart.Walls.Left.Shadow.Brush.Solid = true;
            Chart.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Walls.Right.Brush.Color = Color.LightYellow;
            Chart.Walls.Right.Brush.Solid = true;
            Chart.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Walls.Right.ImageBevel.Brush.Color = Color.LightGray;
            Chart.Walls.Right.ImageBevel.Brush.Solid = true;
            Chart.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Walls.Right.Shadow.Brush.Color = Color.DarkGray;
            Chart.Walls.Right.Shadow.Brush.Solid = true;
            Chart.Walls.Right.Shadow.Brush.Visible = true;
            Chart.Walls.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            Chart.Zoom.Brush.Color = Color.FromArgb(127, 0, 0, 255);
            Chart.Zoom.Brush.Solid = true;
            Chart.Zoom.Brush.Visible = true;
            // 
            // barSeries
            // 
            barSeries.BarRound = BarRounding.AtValue;
            // 
            // 
            // 
            barSeries.Brush.Color = Color.FromArgb(119, 153, 214);
            barSeries.Brush.Solid = true;
            barSeries.Brush.Visible = true;
            barSeries.Color = Color.FromArgb(119, 153, 214);
            barSeries.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            barSeries.Legend.Brush.Color = Color.White;
            barSeries.Legend.Brush.Solid = true;
            barSeries.Legend.Brush.Visible = true;
            // 
            // 
            // 
            barSeries.Legend.Font.Bold = false;
            // 
            // 
            // 
            barSeries.Legend.Font.Brush.Color = Color.Black;
            barSeries.Legend.Font.Brush.Solid = true;
            barSeries.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            barSeries.Legend.Font.Shadow.Brush.Color = Color.DarkGray;
            barSeries.Legend.Font.Shadow.Brush.Solid = true;
            barSeries.Legend.Font.Shadow.Brush.Visible = true;
            barSeries.Legend.Font.Size = 8;
            barSeries.Legend.Font.SizeFloat = 8F;
            barSeries.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            barSeries.Legend.ImageBevel.Brush.Color = Color.LightGray;
            barSeries.Legend.ImageBevel.Brush.Solid = true;
            barSeries.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            barSeries.Legend.Shadow.Brush.Color = Color.DarkGray;
            barSeries.Legend.Shadow.Brush.Solid = true;
            barSeries.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            barSeries.Marks.Brush.Color = Color.FromArgb(255, 255, 255);
            barSeries.Marks.Brush.Solid = true;
            barSeries.Marks.Brush.Visible = true;
            // 
            // 
            // 
            barSeries.Marks.Font.Bold = false;
            // 
            // 
            // 
            barSeries.Marks.Font.Brush.Color = Color.Black;
            barSeries.Marks.Font.Brush.Solid = true;
            barSeries.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            barSeries.Marks.Font.Shadow.Brush.Color = Color.DarkGray;
            barSeries.Marks.Font.Shadow.Brush.Solid = true;
            barSeries.Marks.Font.Shadow.Brush.Visible = true;
            barSeries.Marks.Font.Size = 10;
            barSeries.Marks.Font.SizeFloat = 10F;
            barSeries.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            barSeries.Marks.ImageBevel.Brush.Color = Color.LightGray;
            barSeries.Marks.ImageBevel.Brush.Solid = true;
            barSeries.Marks.ImageBevel.Brush.Visible = true;
            barSeries.Marks.OnTop = true;
            // 
            // 
            // 
            // 
            // 
            // 
            barSeries.Marks.Shadow.Brush.Color = Color.Gray;
            barSeries.Marks.Shadow.Brush.Solid = true;
            barSeries.Marks.Shadow.Brush.Visible = true;
            barSeries.Marks.Style = MarksStyles.Value;
            // 
            // 
            // 
            // 
            // 
            // 
            barSeries.Marks.Symbol.Brush.Color = Color.White;
            barSeries.Marks.Symbol.Brush.Solid = true;
            barSeries.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            barSeries.Marks.Symbol.ImageBevel.Brush.Color = Color.LightGray;
            barSeries.Marks.Symbol.ImageBevel.Brush.Solid = true;
            barSeries.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            barSeries.Marks.Symbol.Shadow.Brush.Color = Color.DarkGray;
            barSeries.Marks.Symbol.Shadow.Brush.Solid = true;
            barSeries.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            barSeries.Shadow.Brush.Color = Color.DarkGray;
            barSeries.Shadow.Brush.Solid = true;
            barSeries.Shadow.Brush.Visible = true;
            barSeries.Title = "BarSeries";
            // 
            // 
            // 
            barSeries.XValues.Order = ValueListOrder.Ascending;
            barSeries.XValues.Value = new double[]
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
            // 
            // 
            barSeries.YValues.Value = new double[]
    {
    707D,
    714D,
    716D,
    594D,
    637D,
    564D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
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
            // PlainBox
            // 
            PlainBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PlainBox.Checked = true;
            PlainBox.CheckState = CheckState.Checked;
            PlainBox.Location = new Point(141, 567);
            PlainBox.Name = "PlainBox";
            PlainBox.Size = new Size(97, 17);
            PlainBox.TabIndex = 3;
            PlainBox.Text = "Plain";
            // 
            // VecBox
            // 
            VecBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            VecBox.Checked = true;
            VecBox.CheckState = CheckState.Checked;
            VecBox.Location = new Point(264, 567);
            VecBox.Name = "VecBox";
            VecBox.Size = new Size(97, 17);
            VecBox.TabIndex = 4;
            VecBox.Text = "Vectorized";
            // 
            // FindIndexBlockBox
            // 
            FindIndexBlockBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            FindIndexBlockBox.Checked = true;
            FindIndexBlockBox.CheckState = CheckState.Checked;
            FindIndexBlockBox.Location = new Point(384, 567);
            FindIndexBlockBox.Name = "FindIndexBlockBox";
            FindIndexBlockBox.Size = new Size(97, 17);
            FindIndexBlockBox.TabIndex = 5;
            FindIndexBlockBox.Text = "FindIndexes";
            // 
            // MaskBlockThreadBox
            // 
            MaskBlockThreadBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MaskBlockThreadBox.Checked = true;
            MaskBlockThreadBox.CheckState = CheckState.Checked;
            MaskBlockThreadBox.Location = new Point(630, 567);
            MaskBlockThreadBox.Name = "MaskBlockThreadBox";
            MaskBlockThreadBox.Size = new Size(112, 17);
            MaskBlockThreadBox.TabIndex = 6;
            MaskBlockThreadBox.Text = "Masked&&Thread";
            // 
            // PlainThreadBox
            // 
            PlainThreadBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PlainThreadBox.Checked = true;
            PlainThreadBox.CheckState = CheckState.Checked;
            PlainThreadBox.Location = new Point(759, 567);
            PlainThreadBox.Name = "PlainThreadBox";
            PlainThreadBox.Size = new Size(97, 17);
            PlainThreadBox.TabIndex = 7;
            PlainThreadBox.Text = "Plain&&Thread";
            // 
            // MaskBlockBox
            // 
            MaskBlockBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MaskBlockBox.Checked = true;
            MaskBlockBox.CheckState = CheckState.Checked;
            MaskBlockBox.Location = new Point(504, 567);
            MaskBlockBox.Name = "MaskBlockBox";
            MaskBlockBox.Size = new Size(97, 17);
            MaskBlockBox.TabIndex = 8;
            MaskBlockBox.Text = "Masked&&Blocked";
            // 
            // DataLenBox
            // 
            DataLenBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DataLenBox.Items.AddRange(new object[] { "800KB", "8MB", "80MB", "800MB" });
            DataLenBox.Location = new Point(141, 596);
            DataLenBox.Name = "DataLenBox";
            DataLenBox.Size = new Size(145, 21);
            DataLenBox.TabIndex = 9;
            DataLenBox.Text = "10MB";
            DataLenBox.SelectedIndexChanged += DataLenBox_SelectedIndexChanged;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Label1.Location = new Point(64, 599);
            Label1.Name = "Label1";
            Label1.Size = new Size(60, 13);
            Label1.TabIndex = 10;
            Label1.Text = "Data length:";
            // 
            // GranBox
            // 
            GranBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            GranBox.Items.AddRange(new object[] { "1", "2", "4" });
            GranBox.Location = new Point(504, 596);
            GranBox.Name = "GranBox";
            GranBox.Size = new Size(145, 21);
            GranBox.TabIndex = 11;
            GranBox.Text = "1";
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Label2.Location = new Point(426, 599);
            Label2.Name = "Label2";
            Label2.Size = new Size(72, 17);
            Label2.TabIndex = 12;
            Label2.Text = "Granularity:";
            // 
            // IfThenForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 625);
            Controls.Add(Memo1);
            Controls.Add(MaskThreadButton);
            Controls.Add(Chart);
            Controls.Add(PlainBox);
            Controls.Add(VecBox);
            Controls.Add(FindIndexBlockBox);
            Controls.Add(MaskBlockThreadBox);
            Controls.Add(PlainThreadBox);
            Controls.Add(MaskBlockBox);
            Controls.Add(DataLenBox);
            Controls.Add(Label1);
            Controls.Add(GranBox);
            Controls.Add(Label2);
            Font = new Font("Tahoma", 8.25F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "IfThenForm";
            Text = "IfThenForm";
            ResumeLayout(false);

        }

        #endregion
    }
}