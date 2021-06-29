using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Steema.TeeChart;

namespace StatsMasterDemo
{
    public class BaseStatWizard : Form
    {
        public BaseStatWizard()
        {
            InitializeComponent();
            double defalpha = 0.05;
            textBoxAlpha.Text = defalpha.ToString("0.00");
            textBoxFmt.Text = "0.0000";
        }

        protected internal Dew.Math.Controls.Wizard wizard;
        protected internal Dew.Math.Controls.WizardPage wizardPageReport;
        protected RichTextBox richTextBox;
        protected ProgressBar progressBar;
		private System.Windows.Forms.ContextMenuStrip contextMenuRTB;
		private System.Windows.Forms.ToolStripMenuItem menuItem1;
		private System.Windows.Forms.ToolStripMenuItem menuItemSelectAll;
		private System.Windows.Forms.ToolStripMenuItem menuItemCopyClpBrd;
		private System.Windows.Forms.ToolStripMenuItem menuItemSaveRTF;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        protected internal CheckBox checkBoxCharts;
        private TChart aChart = null;

        public TChart Chart
        {
            get
            {
                if (aChart == null)
                {
                    aChart = new TChart();
                    aChart.Width = 450;
                    aChart.Height = 250;
                    aChart.BackColor = Color.White;
                    aChart.AutoRepaint = false;
                    aChart.Panel.Transparent = true;
                }
                return aChart;
            }
            set
            {
                aChart = value;
            }
        }        
        public void CopyToRichBox(RichTextBox rtb)
        {
            rtb.ReadOnly = false;
            Chart.Export.Image.Bitmap.CopyToClipboard();
            rtb.Paste();                
		    rtb.ReadOnly = true;
        }

		public string HypResult(Dew.Stats.THypothesisResult value)
		{
			switch(value)
			{
				case Dew.Stats.THypothesisResult.hrReject : return "Reject";
				case Dew.Stats.THypothesisResult.hrNotReject : return "Accept";
				default : return "NAN";
			}
		}

        public string OptimStopReason(Dew.Math.TOptStopReason value)
        {
            switch (value)
            {
                case Dew.Math.TOptStopReason.OptResBigLambda: return "Big lambda";
                case Dew.Math.TOptStopReason.OptResMaxIter: return "Maximum number of iterations reached.";
                case Dew.Math.TOptStopReason.OptResNotFound: return "Minimum not found.";
                case Dew.Math.TOptStopReason.OptResSingular: return "Hessian matrix singular.";
                case Dew.Math.TOptStopReason.OptResSmallGrad: return "Too small gradient.";
                case Dew.Math.TOptStopReason.optResSmallJacobian: return "Too small Jacobian.";
                case Dew.Math.TOptStopReason.OptResSmallStep: return "Small function increment step.";
                case Dew.Math.TOptStopReason.OptResZeroStep: return "Zero step.";
                default: return "Converged within given tolerance.";
            }
        }

        public string HTextBar(double val, double max, int len)
        {
            double pct = val / max;
            int barcount = (int)Math.Ceiling(pct * len);
            string result = "";
            for (int i = 1; i <= barcount; i++)
                result += "|";
            for (int i = barcount + 1; i <= len; i++)
                result += ".";
            return result;
        }


        public string FmtString
        {
            get { return textBoxFmt.Text; }
            set { textBoxFmt.Text = value; }
        }

        public double Alpha
        {
            get { return Convert.ToDouble(textBoxAlpha.Text); }
            set { textBoxAlpha.Text = value.ToString("0.00"); }
        }

        public void SetupTabs(RichTextBox rb, int numtabs)
        {
            numtabs = System.Math.Min(numtabs, 24);

            int[] tabs = new int[numtabs];
            int tabw = DefTabWidth;
            for (int i = 0; i < numtabs; i++)
            {
                tabs[i] = (i + 1) * tabw;
            }
            rb.SelectionTabs = tabs;
        }

        private int DefTabWidth
        {
            get
            {
                return 90;
            }
        }
           

        private Label label1;
        protected internal Dew.Math.Controls.WizardPage wizardPageFormat;
        protected internal Dew.Math.Controls.WizardPage wizardPageWelcome;
        private GroupBox groupBox1;
        protected internal TextBox textBoxAlpha;
        private TextBox textBoxFmt;
        private Label label3;
        private Label label2;
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
            this.components = new System.ComponentModel.Container();
            this.wizard = new Dew.Math.Controls.Wizard();
            this.wizardPageWelcome = new Dew.Math.Controls.WizardPage();
            this.wizardPageReport = new Dew.Math.Controls.WizardPage();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuRTB = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemCopyClpBrd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveRTF = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.wizardPageFormat = new Dew.Math.Controls.WizardPage();
            this.checkBoxCharts = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxAlpha = new System.Windows.Forms.TextBox();
            this.textBoxFmt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.wizard.SuspendLayout();
            this.wizardPageReport.SuspendLayout();
            this.contextMenuRTB.SuspendLayout();
            this.wizardPageFormat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizard
            // 
            this.wizard.Controls.Add(this.wizardPageWelcome);
            this.wizard.Controls.Add(this.wizardPageReport);
            this.wizard.Controls.Add(this.wizardPageFormat);
            this.wizard.Location = new System.Drawing.Point(0, 0);
            this.wizard.Name = "wizard";
            this.wizard.Pages.AddRange(new Dew.Math.Controls.WizardPage[] {
            this.wizardPageWelcome,
            this.wizardPageFormat,
            this.wizardPageReport});
            this.wizard.Size = new System.Drawing.Size(540, 345);
            this.wizard.TabIndex = 0;
            // 
            // wizardPageWelcome
            // 
            this.wizardPageWelcome.Location = new System.Drawing.Point(0, 0);
            this.wizardPageWelcome.Name = "wizardPageWelcome";
            this.wizardPageWelcome.Size = new System.Drawing.Size(540, 297);
            this.wizardPageWelcome.Style = Dew.Math.Controls.WizardPageStyle.Welcome;
            this.wizardPageWelcome.TabIndex = 10;
            // 
            // wizardPageReport
            // 
            this.wizardPageReport.Controls.Add(this.richTextBox);
            this.wizardPageReport.Controls.Add(this.progressBar);
            this.wizardPageReport.Controls.Add(this.label1);
            this.wizardPageReport.Location = new System.Drawing.Point(0, 0);
            this.wizardPageReport.Name = "wizardPageReport";
            this.wizardPageReport.Size = new System.Drawing.Size(521, 297);
            this.wizardPageReport.TabIndex = 12;
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox.CausesValidation = false;
            this.richTextBox.ContextMenuStrip = this.contextMenuRTB;
            this.richTextBox.DetectUrls = false;
            this.richTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox.HideSelection = false;
            this.richTextBox.Location = new System.Drawing.Point(18, 144);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.ShortcutsEnabled = false;
            this.richTextBox.Size = new System.Drawing.Size(488, 113);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            this.richTextBox.SelectionChanged += new System.EventHandler(this.richTextBox_SelectionChanged);
            // 
            // contextMenuRTB
            // 
            this.contextMenuRTB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCopyClpBrd,
            this.menuItemSaveRTF,
            this.menuItem1,
            this.menuItemSelectAll});
            this.contextMenuRTB.Name = "contextMenuRTB";
            this.contextMenuRTB.Size = new System.Drawing.Size(170, 92);
            // 
            // menuItemCopyClpBrd
            // 
            this.menuItemCopyClpBrd.Enabled = false;
            this.menuItemCopyClpBrd.MergeIndex = 0;
            this.menuItemCopyClpBrd.Name = "menuItemCopyClpBrd";
            this.menuItemCopyClpBrd.Size = new System.Drawing.Size(169, 22);
            this.menuItemCopyClpBrd.Text = "Copy to clipboard";
            this.menuItemCopyClpBrd.Click += new System.EventHandler(this.menuItemCopyClpBrd_Click);
            // 
            // menuItemSaveRTF
            // 
            this.menuItemSaveRTF.MergeIndex = 1;
            this.menuItemSaveRTF.Name = "menuItemSaveRTF";
            this.menuItemSaveRTF.Size = new System.Drawing.Size(169, 22);
            this.menuItemSaveRTF.Text = "Save to RTF file";
            this.menuItemSaveRTF.Click += new System.EventHandler(this.menuItemSaveRTF_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.MergeIndex = 2;
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Size = new System.Drawing.Size(169, 22);
            this.menuItem1.Text = "-";
            // 
            // menuItemSelectAll
            // 
            this.menuItemSelectAll.MergeIndex = 3;
            this.menuItemSelectAll.Name = "menuItemSelectAll";
            this.menuItemSelectAll.Size = new System.Drawing.Size(169, 22);
            this.menuItemSelectAll.Text = "Select All";
            this.menuItemSelectAll.Click += new System.EventHandler(this.menuItemSelectAll_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(83, 95);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(423, 16);
            this.progressBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Progress:";
            // 
            // wizardPageFormat
            // 
            this.wizardPageFormat.Controls.Add(this.checkBoxCharts);
            this.wizardPageFormat.Controls.Add(this.groupBox1);
            this.wizardPageFormat.Location = new System.Drawing.Point(0, 0);
            this.wizardPageFormat.Name = "wizardPageFormat";
            this.wizardPageFormat.Size = new System.Drawing.Size(428, 208);
            this.wizardPageFormat.TabIndex = 11;
            // 
            // checkBoxCharts
            // 
            this.checkBoxCharts.AutoSize = true;
            this.checkBoxCharts.Checked = true;
            this.checkBoxCharts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCharts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxCharts.Location = new System.Drawing.Point(64, 245);
            this.checkBoxCharts.Name = "checkBoxCharts";
            this.checkBoxCharts.Size = new System.Drawing.Size(154, 20);
            this.checkBoxCharts.TabIndex = 1;
            this.checkBoxCharts.Text = "Include charts in report";
            this.checkBoxCharts.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxAlpha);
            this.groupBox1.Controls.Add(this.textBoxFmt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report format";
            // 
            // textBoxAlpha
            // 
            this.textBoxAlpha.Location = new System.Drawing.Point(98, 74);
            this.textBoxAlpha.Name = "textBoxAlpha";
            this.textBoxAlpha.Size = new System.Drawing.Size(102, 23);
            this.textBoxAlpha.TabIndex = 3;
            // 
            // textBoxFmt
            // 
            this.textBoxFmt.Location = new System.Drawing.Point(98, 38);
            this.textBoxFmt.Name = "textBoxFmt";
            this.textBoxFmt.Size = new System.Drawing.Size(102, 23);
            this.textBoxFmt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Alpha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Format string:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "RTF";
            this.saveFileDialog1.Filter = "Rich Text Format|*.rtf";
            // 
            // BaseStatWizard
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(540, 345);
            this.Controls.Add(this.wizard);
            this.Name = "BaseStatWizard";
            this.Text = "BaseStatWizard";
            this.wizard.ResumeLayout(false);
            this.wizardPageReport.ResumeLayout(false);
            this.wizardPageReport.PerformLayout();
            this.contextMenuRTB.ResumeLayout(false);
            this.wizardPageFormat.ResumeLayout(false);
            this.wizardPageFormat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

		private void menuItemSaveRTF_Click(object sender, System.EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				richTextBox.SaveFile(saveFileDialog1.FileName);
			}
		}

		private void menuItemCopyClpBrd_Click(object sender, System.EventArgs e)
		{
			richTextBox.Copy();
		}

		private void richTextBox_SelectionChanged(object sender, System.EventArgs e)
		{
			menuItemSelectAll.Enabled = richTextBox.SelectionLength != richTextBox.Text.Length;
			menuItemCopyClpBrd.Enabled = richTextBox.SelectionLength > 0;
		}

		private void menuItemSelectAll_Click(object sender, System.EventArgs e)
		{
				richTextBox.SelectAll();
		}
    }
}