using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StatsMasterDemo
{
    public class TeeChartIntro : Form
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(635, 411);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // TeeChartIntro
            // 
            this.ClientSize = new System.Drawing.Size(635, 411);
            this.Controls.Add(this.richTextBox1);
            this.Name = "TeeChartIntro";
            this.Text = "TeeChartIntro";
            this.Load += new System.EventHandler(this.TeeChartIntro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;

        public TeeChartIntro()
        {
            InitializeComponent();
        }

        private void TeeChartIntro_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);
            richTextBox1.SelectedText = "TeeChart .NET - great addition to Dew Stats Master\n\n";
            richTextBox1.SelectedText = "This demo was compiled with the latest free TeeChart .NET Lite charting components."
                + "The free \"Lite\" version only includes basic charting types, like pie, 2d scatter plot, line plot, bar plot, ..., "
                + "but it's missing some advanced charting types used in statistics. The registered (payable) TeeChart .NET version includes "
                + "additional charting types:\n\n";
			richTextBox1.SelectionBullet = true;
			richTextBox1.SelectionIndent = 10;
            richTextBox1.SelectedText = "3d scatter plot\n";
            richTextBox1.SelectedText = "3d surface plot\n";
            richTextBox1.SelectedText = "2d/3d contour plot plot\n";
            richTextBox1.SelectedText = "volume plot\n";
            richTextBox1.SelectedText = "charting tools to allow user interaction with plots\n";
            richTextBox1.SelectedText = "several exporting formats, including gif,bmp,pdf,vml,xaml,...\n";
            richTextBox1.SelectedText = ".. and many more\n";
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionIndent = 0;
            richTextBox1.SelectedText = "\nVisit TeeChart .NET web site to learn more about these exciting features : http://www.steema.com\n\n";
            richTextBox1.SelectedText = "Dew Stats Master for VS.NET also includes some custom charting styles, which can be "
                + "used with TeeChart .NET Lite or full (registered) version. These are:\n\n";
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            richTextBox1.SelectedText = "Probabilty plot (Dew.Stats.Tee.ProbabilityPlot)\n";
            richTextBox1.SelectedText = "Variable and attribute quality control charts (Dew.Stats.Tee.QCSeries)\n";
            richTextBox1.SelectedText = "\"Dot\" plot (Dew.Stats.Tee.DotPlot)\n";
            richTextBox1.SelectedText = "Biplot (Dew.Stats.Tee.BiPlot)\n";
            richTextBox1.SelectedText = "Box Plot (Dew.Stats.Tee.BoxPlot and Dew.Stats.Tee.HorizBoxPlot)\n";
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionIndent = 0;

        }
    }
}