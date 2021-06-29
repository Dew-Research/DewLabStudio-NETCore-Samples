using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math.Controls;
using Dew.Math.Units;

namespace StatsMasterDemo
{
    public class BinaryTestWizard : StatsMasterDemo.BaseStatWizard
    {
        public BinaryTestWizard()
        {
            InitializeComponent();
            // Manually reposition Data wizard page after the Welcome page
            wizard.Pages.Remove(wizardPageData);
            wizard.Pages.Insert(1, wizardPageData);
            // remove format page as it is not needed
            wizard.Pages.Remove(wizardPageFormat);
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BinaryTestWizard));
            this.wizardPageData = new Dew.Math.Controls.WizardPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxHypAlpha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCIAlpha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxT2 = new System.Windows.Forms.GroupBox();
            this.labeln2 = new System.Windows.Forms.Label();
            this.labeln20 = new System.Windows.Forms.Label();
            this.labeln21 = new System.Windows.Forms.Label();
            this.labelm20 = new System.Windows.Forms.Label();
            this.labelm21 = new System.Windows.Forms.Label();
            this.textBoxF20 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxT20 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxF21 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxT21 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBoxT1 = new System.Windows.Forms.GroupBox();
            this.labeln = new System.Windows.Forms.Label();
            this.labeln0 = new System.Windows.Forms.Label();
            this.labeln1 = new System.Windows.Forms.Label();
            this.labelm0 = new System.Windows.Forms.Label();
            this.labelm1 = new System.Windows.Forms.Label();
            this.textBoxF0 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxT0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxF1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxT1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bintest = new Dew.Stats.TMtxBinaryTest(this.components);
            this.wizard.SuspendLayout();
            this.wizardPageReport.SuspendLayout();
            this.wizardPageFormat.SuspendLayout();
            this.wizardPageData.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxT2.SuspendLayout();
            this.groupBoxT1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wizard
            // 
            this.wizard.Controls.Add(this.wizardPageData);
            this.wizard.Pages.AddRange(new Dew.Math.Controls.WizardPage[] {
            this.wizardPageData});
            this.wizard.Size = new System.Drawing.Size(577, 423);
            this.wizard.AfterSwitchPages += new Dew.Math.Controls.Wizard.AfterSwitchPagesEventHandler(this.wizard_AfterSwitchPages);
            this.wizard.Controls.SetChildIndex(this.wizardPageWelcome, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageFormat, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageReport, 0);
            this.wizard.Controls.SetChildIndex(this.wizardPageData, 0);
            // 
            // wizardPageReport
            // 
            this.wizardPageReport.Size = new System.Drawing.Size(527, 353);
            this.wizardPageReport.Title = "Binary Test: Report";
            // 
            // richTextBox
            // 
            this.richTextBox.Size = new System.Drawing.Size(500, 214);
            // 
            // progressBar
            // 
            this.progressBar.Size = new System.Drawing.Size(446, 13);
            // 
            // wizardPageFormat
            // 
            this.wizardPageFormat.Size = new System.Drawing.Size(527, 353);
            // 
            // wizardPageWelcome
            // 
            this.wizardPageWelcome.Description = resources.GetString("wizardPageWelcome.Description");
            this.wizardPageWelcome.Size = new System.Drawing.Size(527, 353);
            this.wizardPageWelcome.Title = "Binary Test";
            // 
            // wizardPageData
            // 
            this.wizardPageData.Controls.Add(this.groupBox2);
            this.wizardPageData.Controls.Add(this.groupBoxT2);
            this.wizardPageData.Controls.Add(this.groupBoxT1);
            this.wizardPageData.Controls.Add(this.comboBox1);
            this.wizardPageData.Controls.Add(this.label10);
            this.wizardPageData.Description = "Define type of binary test";
            this.wizardPageData.Location = new System.Drawing.Point(0, 0);
            this.wizardPageData.Name = "wizardPageData";
            this.wizardPageData.Size = new System.Drawing.Size(577, 375);
            this.wizardPageData.TabIndex = 13;
            this.wizardPageData.Title = "Step 1: Define binary test parameters";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxHypAlpha);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxCIAlpha);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 88);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional settings";
            // 
            // textBoxHypAlpha
            // 
            this.textBoxHypAlpha.Location = new System.Drawing.Point(144, 56);
            this.textBoxHypAlpha.Name = "textBoxHypAlpha";
            this.textBoxHypAlpha.Size = new System.Drawing.Size(80, 23);
            this.textBoxHypAlpha.TabIndex = 3;
            this.textBoxHypAlpha.TextChanged += new System.EventHandler(this.textBoxHypAlpha_TextChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(16, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Hypothesis test signif.";
            // 
            // textBoxCIAlpha
            // 
            this.textBoxCIAlpha.Location = new System.Drawing.Point(144, 24);
            this.textBoxCIAlpha.Name = "textBoxCIAlpha";
            this.textBoxCIAlpha.Size = new System.Drawing.Size(80, 23);
            this.textBoxCIAlpha.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Se and Sp significance";
            // 
            // groupBoxT2
            // 
            this.groupBoxT2.Controls.Add(this.labeln2);
            this.groupBoxT2.Controls.Add(this.labeln20);
            this.groupBoxT2.Controls.Add(this.labeln21);
            this.groupBoxT2.Controls.Add(this.labelm20);
            this.groupBoxT2.Controls.Add(this.labelm21);
            this.groupBoxT2.Controls.Add(this.textBoxF20);
            this.groupBoxT2.Controls.Add(this.label11);
            this.groupBoxT2.Controls.Add(this.textBoxT20);
            this.groupBoxT2.Controls.Add(this.label12);
            this.groupBoxT2.Controls.Add(this.textBoxF21);
            this.groupBoxT2.Controls.Add(this.label13);
            this.groupBoxT2.Controls.Add(this.textBoxT21);
            this.groupBoxT2.Controls.Add(this.label14);
            this.groupBoxT2.Location = new System.Drawing.Point(268, 130);
            this.groupBoxT2.Name = "groupBoxT2";
            this.groupBoxT2.Size = new System.Drawing.Size(240, 112);
            this.groupBoxT2.TabIndex = 8;
            this.groupBoxT2.TabStop = false;
            this.groupBoxT2.Text = "Test 2 table";
            this.groupBoxT2.Visible = false;
            // 
            // labeln2
            // 
            this.labeln2.Location = new System.Drawing.Point(192, 88);
            this.labeln2.Name = "labeln2";
            this.labeln2.Size = new System.Drawing.Size(32, 16);
            this.labeln2.TabIndex = 12;
            this.labeln2.Text = "n";
            // 
            // labeln20
            // 
            this.labeln20.Location = new System.Drawing.Point(192, 56);
            this.labeln20.Name = "labeln20";
            this.labeln20.Size = new System.Drawing.Size(32, 16);
            this.labeln20.TabIndex = 11;
            this.labeln20.Text = "n0";
            // 
            // labeln21
            // 
            this.labeln21.Location = new System.Drawing.Point(192, 32);
            this.labeln21.Name = "labeln21";
            this.labeln21.Size = new System.Drawing.Size(32, 16);
            this.labeln21.TabIndex = 10;
            this.labeln21.Text = "n1";
            // 
            // labelm20
            // 
            this.labelm20.Location = new System.Drawing.Point(144, 88);
            this.labelm20.Name = "labelm20";
            this.labelm20.Size = new System.Drawing.Size(32, 16);
            this.labelm20.TabIndex = 9;
            this.labelm20.Text = "m0";
            // 
            // labelm21
            // 
            this.labelm21.Location = new System.Drawing.Point(56, 88);
            this.labelm21.Name = "labelm21";
            this.labelm21.Size = new System.Drawing.Size(32, 16);
            this.labelm21.TabIndex = 8;
            this.labelm21.Text = "m1";
            // 
            // textBoxF20
            // 
            this.textBoxF20.Location = new System.Drawing.Point(136, 56);
            this.textBoxF20.Name = "textBoxF20";
            this.textBoxF20.Size = new System.Drawing.Size(48, 23);
            this.textBoxF20.TabIndex = 7;
            this.textBoxF20.TextChanged += new System.EventHandler(this.textBoxF20_TextChanged);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(104, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "F20";
            // 
            // textBoxT20
            // 
            this.textBoxT20.Location = new System.Drawing.Point(136, 32);
            this.textBoxT20.Name = "textBoxT20";
            this.textBoxT20.Size = new System.Drawing.Size(48, 23);
            this.textBoxT20.TabIndex = 5;
            this.textBoxT20.TextChanged += new System.EventHandler(this.textBoxT20_TextChanged);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(104, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "T20";
            // 
            // textBoxF21
            // 
            this.textBoxF21.Location = new System.Drawing.Point(48, 56);
            this.textBoxF21.Name = "textBoxF21";
            this.textBoxF21.Size = new System.Drawing.Size(48, 23);
            this.textBoxF21.TabIndex = 3;
            this.textBoxF21.TextChanged += new System.EventHandler(this.textBoxF21_TextChanged);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(16, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "F21";
            // 
            // textBoxT21
            // 
            this.textBoxT21.Location = new System.Drawing.Point(48, 32);
            this.textBoxT21.Name = "textBoxT21";
            this.textBoxT21.Size = new System.Drawing.Size(48, 23);
            this.textBoxT21.TabIndex = 1;
            this.textBoxT21.TextChanged += new System.EventHandler(this.textBoxT21_TextChanged);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(16, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "T21";
            // 
            // groupBoxT1
            // 
            this.groupBoxT1.Controls.Add(this.labeln);
            this.groupBoxT1.Controls.Add(this.labeln0);
            this.groupBoxT1.Controls.Add(this.labeln1);
            this.groupBoxT1.Controls.Add(this.labelm0);
            this.groupBoxT1.Controls.Add(this.labelm1);
            this.groupBoxT1.Controls.Add(this.textBoxF0);
            this.groupBoxT1.Controls.Add(this.label5);
            this.groupBoxT1.Controls.Add(this.textBoxT0);
            this.groupBoxT1.Controls.Add(this.label4);
            this.groupBoxT1.Controls.Add(this.textBoxF1);
            this.groupBoxT1.Controls.Add(this.label8);
            this.groupBoxT1.Controls.Add(this.textBoxT1);
            this.groupBoxT1.Controls.Add(this.label9);
            this.groupBoxT1.Location = new System.Drawing.Point(12, 130);
            this.groupBoxT1.Name = "groupBoxT1";
            this.groupBoxT1.Size = new System.Drawing.Size(240, 112);
            this.groupBoxT1.TabIndex = 7;
            this.groupBoxT1.TabStop = false;
            this.groupBoxT1.Text = "TestTable1";
            // 
            // labeln
            // 
            this.labeln.Location = new System.Drawing.Point(192, 88);
            this.labeln.Name = "labeln";
            this.labeln.Size = new System.Drawing.Size(32, 16);
            this.labeln.TabIndex = 12;
            this.labeln.Text = "n";
            // 
            // labeln0
            // 
            this.labeln0.Location = new System.Drawing.Point(192, 56);
            this.labeln0.Name = "labeln0";
            this.labeln0.Size = new System.Drawing.Size(32, 16);
            this.labeln0.TabIndex = 11;
            this.labeln0.Text = "n0";
            // 
            // labeln1
            // 
            this.labeln1.Location = new System.Drawing.Point(192, 32);
            this.labeln1.Name = "labeln1";
            this.labeln1.Size = new System.Drawing.Size(32, 16);
            this.labeln1.TabIndex = 10;
            this.labeln1.Text = "n1";
            // 
            // labelm0
            // 
            this.labelm0.Location = new System.Drawing.Point(144, 88);
            this.labelm0.Name = "labelm0";
            this.labelm0.Size = new System.Drawing.Size(32, 16);
            this.labelm0.TabIndex = 9;
            this.labelm0.Text = "m0";
            // 
            // labelm1
            // 
            this.labelm1.Location = new System.Drawing.Point(56, 88);
            this.labelm1.Name = "labelm1";
            this.labelm1.Size = new System.Drawing.Size(32, 16);
            this.labelm1.TabIndex = 8;
            this.labelm1.Text = "m1";
            // 
            // textBoxF0
            // 
            this.textBoxF0.Location = new System.Drawing.Point(136, 56);
            this.textBoxF0.Name = "textBoxF0";
            this.textBoxF0.Size = new System.Drawing.Size(48, 23);
            this.textBoxF0.TabIndex = 7;
            this.textBoxF0.TextChanged += new System.EventHandler(this.textBoxF0_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(104, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "F0";
            // 
            // textBoxT0
            // 
            this.textBoxT0.Location = new System.Drawing.Point(136, 32);
            this.textBoxT0.Name = "textBoxT0";
            this.textBoxT0.Size = new System.Drawing.Size(48, 23);
            this.textBoxT0.TabIndex = 5;
            this.textBoxT0.TextChanged += new System.EventHandler(this.textBoxT0_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(104, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "T0";
            // 
            // textBoxF1
            // 
            this.textBoxF1.Location = new System.Drawing.Point(48, 56);
            this.textBoxF1.Name = "textBoxF1";
            this.textBoxF1.Size = new System.Drawing.Size(48, 23);
            this.textBoxF1.TabIndex = 3;
            this.textBoxF1.TextChanged += new System.EventHandler(this.textBoxF1_TextChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(16, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "F1";
            // 
            // textBoxT1
            // 
            this.textBoxT1.Location = new System.Drawing.Point(48, 32);
            this.textBoxT1.Name = "textBoxT1";
            this.textBoxT1.Size = new System.Drawing.Size(48, 23);
            this.textBoxT1.TabIndex = 1;
            this.textBoxT1.TextChanged += new System.EventHandler(this.textBoxT1_TextChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(16, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "T1";
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "One-test",
            "Two-test unpaired",
            "Two-test paired"});
            this.comboBox1.Location = new System.Drawing.Point(12, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 23);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(12, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 23);
            this.label10.TabIndex = 5;
            this.label10.Text = "Binary design test type";
            // 
            // bintest
            // 
            this.bintest.BlockAssign = false;
            this.bintest.Dirty = false;
            this.bintest.Name = "";
            this.bintest.Test1Table.F0 = 0;
            this.bintest.Test1Table.F1 = 0;
            this.bintest.Test1Table.T0 = 0;
            this.bintest.Test1Table.T1 = 0;
            this.bintest.Test2Table.F0 = 0;
            this.bintest.Test2Table.F1 = 0;
            this.bintest.Test2Table.T0 = 0;
            this.bintest.Test2Table.T1 = 0;
            // 
            // BinaryTestWizard
            // 
            this.ClientSize = new System.Drawing.Size(577, 423);
            this.Name = "BinaryTestWizard";
            this.Load += new System.EventHandler(this.BinaryTestWizard_Load);
            this.wizard.ResumeLayout(false);
            this.wizardPageReport.ResumeLayout(false);
            this.wizardPageReport.PerformLayout();
            this.wizardPageFormat.ResumeLayout(false);
            this.wizardPageFormat.PerformLayout();
            this.wizardPageData.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxT2.ResumeLayout(false);
            this.groupBoxT2.PerformLayout();
            this.groupBoxT1.ResumeLayout(false);
            this.groupBoxT1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Dew.Math.Controls.WizardPage wizardPageData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxHypAlpha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCIAlpha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxT2;
        private System.Windows.Forms.Label labeln2;
        private System.Windows.Forms.Label labeln20;
        private System.Windows.Forms.Label labeln21;
        private System.Windows.Forms.Label labelm20;
        private System.Windows.Forms.Label labelm21;
        private System.Windows.Forms.TextBox textBoxF20;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxT20;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxF21;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxT21;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBoxT1;
        private System.Windows.Forms.Label labeln;
        private System.Windows.Forms.Label labeln0;
        private System.Windows.Forms.Label labeln1;
        private System.Windows.Forms.Label labelm0;
        private System.Windows.Forms.Label labelm1;
        private System.Windows.Forms.TextBox textBoxF0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxT0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxF1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxT1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        public Dew.Stats.TMtxBinaryTest bintest;

        private void RefreshControls()
        {
            groupBoxT2.Visible = comboBox1.SelectedIndex == 1;

            labeln1.Text = bintest.Test1Table. N1.ToString();
            labeln0.Text = bintest.Test1Table.N0.ToString();
            labeln.Text = bintest.Test1Table.N.ToString();
            labelm1.Text = bintest.Test1Table.M1.ToString();
            labelm0.Text = bintest.Test1Table.M0.ToString();
            labeln.Text = bintest.Test1Table.N.ToString();


            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        groupBoxT1.Text = "Test 1 table";
                        label9.Text = "T1";
                        label8.Text = "F1";
                        label4.Text = "T0";
                        label5.Text = "F0";
                        bintest.Paired = false;

                    }; break;
                case 1:
                    {
                        bintest.Paired = false;
                        groupBoxT1.Text = "Test 1 table";
                        label9.Text = "T11";
                        label8.Text = "F11";
                        label4.Text = "T10";
                        label5.Text = "F10";
                        labeln21.Text = bintest.Test2Table.N1.ToString();
                        labeln20.Text = bintest.Test2Table.N0.ToString();
                        labelm21.Text = bintest.Test2Table.M1.ToString();
                        labelm20.Text = bintest.Test2Table.M0.ToString();
                        labeln2.Text = bintest.Test2Table.N.ToString();

                    }; break;
                case 2:
                    {
                        bintest.Paired = true;
                        groupBoxT1.Text = "Paired test table";
                        label9.Text = "X11";
                        label8.Text = "X01";
                        label4.Text = "X10";
                        label5.Text = "X00";
                    }; break;
            }
        }

        private void TextReport()
        {
            wizard.BackEnabled = false;
            wizard.NextEnabled = false;
            
            richTextBox.Clear();
            progressBar.Value = 0;

            // Sensitivity and specificity
            Sensitivity();
            progressBar.Value = 60;

            if (comboBox1.SelectedIndex == 1) HypTestEquivalence();
            progressBar.Value = 80;

            // Likelihood ratio
            if (comboBox1.SelectedIndex != 2) LikelihoodRatio();

            progressBar.Value = 100;
            wizard.BackEnabled = true;
        }

        #region Reports

        private void Sensitivity()
        {
            double signpct = 100 * (1.0 - bintest.CIAlpha);
            double lci, uci;

            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Sensitivity and specificity\n\n";

            switch (comboBox1.SelectedIndex)
            {
                case 0: // one sample
                    {
                        richTextBox.SelectionColor = Color.Blue;
                        SetupTabs(richTextBox, 7);
                        richTextBox.SelectedText = "\t\tLower " + signpct.ToString("0.0") + "%\tUpper " + signpct.ToString("0.0") + "%\tNumber\tNumber\n"
                            + "Measure\tValue\tCI\tCI\tMatches\tDifferent\tTotal\n";
                        // Sensitivity for 1-test
                        bintest.Test1Table.GetSe1CI(out lci, out uci);
                        richTextBox.SelectedText = "Sensitivity\t" + Math387.FormatSample("0.0000", bintest.Test1Table.Se1) + "\t"
                            + Math387.FormatSample("0.0000", lci) + "\t" + Math387.FormatSample("0.0000", uci) + "\t"
                            + bintest.Test1Table.T1.ToString() + "\t" + bintest.Test1Table.T0.ToString() + "\t" + bintest.Test1Table.N1.ToString() + "\n";
                        // Specificity for 1-test
                        bintest.Test1Table.GetSp1CI(out lci, out uci);
                        richTextBox.SelectedText = "Specificity\t" + Math387.FormatSample("0.0000", bintest.Test1Table.Sp1) + "\t"
                            + Math387.FormatSample("0.0000", lci) + "\t" + Math387.FormatSample("0.0000", uci) + "\t"
                            + bintest.Test1Table.F0.ToString() + "\t" + bintest.Test1Table.F1.ToString() + "\t" + bintest.Test1Table.N0.ToString() + "\n\n";
                    }; break;
                case 1: // two sample unpaired
                    {
                        richTextBox.SelectionColor = Color.Blue;
                        SetupTabs(richTextBox, 5);
                        richTextBox.SelectedText = "\t\t\tLower " + signpct.ToString("0.0") + "%\tUpper " + signpct.ToString("0.0") + "%\n"
                            + "Statistics\tTest\tValue\tCI\tCI\n";
                        // Sensitivity for 1-test
                        bintest.Test1Table.GetSe1CI(out lci, out uci);
                        richTextBox.SelectedText = "Sens. (Se1)\t1\t" + Math387.FormatSample("0.0000", bintest.Test1Table.Se1) + "\t"
                            + Math387.FormatSample("0.0000", lci) + "\t" + Math387.FormatSample("0.0000", uci) + "\n";
                        // Sensitivity for 2-test
                        bintest.Test2Table.GetSe1CI(out lci, out uci);
                        richTextBox.SelectedText = "Sens. (Se2)\t2\t" + Math387.FormatSample("0.0000", bintest.Test2Table.Se1) + "\t"
                            + Math387.FormatSample("0.0000", lci) + "\t" + Math387.FormatSample("0.0000", uci) + "\n";
                        // Difference
                        richTextBox.SelectedText = "Se2-Se1\t\t" + Math387.FormatSample("0.0000", bintest.Test2Table.Se1 - bintest.Test1Table.Se1) + "\n";
                        // Ratio
                        richTextBox.SelectedText = "Se2/Se1\t\t" + Math387.FormatSample("0.0000", bintest.Test2Table.Se1 / bintest.Test1Table.Se1) + "\n\n";

                        // Specificity for 1-test
                        bintest.Test1Table.GetSp1CI(out lci, out uci);
                        richTextBox.SelectedText = "Spec. (Sp1)\t1\t" + Math387.FormatSample("0.0000", bintest.Test1Table.Sp1) + "\t"
                            + Math387.FormatSample("0.0000", lci) + "\t" + Math387.FormatSample("0.0000", uci) + "\n";
                        // Specificity for 2-test
                        bintest.Test2Table.GetSp1CI(out lci, out uci);
                        richTextBox.SelectedText = "Spec. (Sp2)\t2\t" + Math387.FormatSample("0.0000", bintest.Test2Table.Sp1) + "\t"
                            + Math387.FormatSample("0.0000", lci) + "\t" + Math387.FormatSample("0.0000", uci) + "\n";
                        // Difference
                        richTextBox.SelectedText = "Sp2-Sp1\t\t" + Math387.FormatSample("0.0000", bintest.Test2Table.Sp1 - bintest.Test1Table.Sp1) + "\n";
                        // Ratio
                        richTextBox.SelectedText = "Sp2/Sp1\t\t" + Math387.FormatSample("0.0000", bintest.Test2Table.Sp1 / bintest.Test1Table.Sp1) + "\n\n";
                    }; break;

                case 2: // two sample paired
                    {
                        richTextBox.SelectionColor = Color.Blue;
                        SetupTabs(richTextBox, 5);
                        richTextBox.SelectedText = "\t\t\tLower " + signpct.ToString("0.0") + "%\tUpper " + signpct.ToString("0.0") + "%\n"
                            + "Statistics\tTest\tValue\tCI\tCI\n";
                        // Sensitivity Se1
                        bintest.Test1Table.GetSe1CI(out lci, out uci);
                        richTextBox.SelectedText = "Sens. (Se1)\t1\t" + Math387.FormatSample("0.0000", bintest.Test1Table.Se1) + "\t"
                            + Math387.FormatSample("0.0000", lci) + "\t" + Math387.FormatSample("0.0000", uci) + "\n";
                        // Sensitivity Se2
                        bintest.Test1Table.GetSe2CI(out lci, out uci);
                        richTextBox.SelectedText = "Sens. (Se2)\t2\t" + Math387.FormatSample("0.0000", bintest.Test1Table. Se2) + "\t"
                            + Math387.FormatSample("0.0000", lci) + "\t" + Math387.FormatSample("0.0000", uci) + "\n";
                        // Difference
                        richTextBox.SelectedText = "Se1-Se2\t\t" + Math387.FormatSample("0.0000", bintest.Test1Table.Se1 - bintest.Test1Table.Se2) + "\n";
                        // Ratio
                        richTextBox.SelectedText = "Se1/Se2\t\t" + Math387.FormatSample("0.0000", bintest.Test1Table.Se1 / bintest.Test1Table.Se2) + "\n\n";
                    }; break;
            }

        }

        private void LikelihoodRatio()
        {
            double lrplus, lrminus;
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Likelihood ratio\n\n";
            switch (comboBox1.SelectedIndex)
            {
                case 0: // one test
                    {
                        lrplus = bintest.Test1Table.Se1 / (1.0 - bintest.Test1Table.Sp1);
                        lrminus = (1.0 - bintest.Test1Table.Se1) / bintest.Test1Table.Sp1;
                        SetupTabs(richTextBox, 2);
                        richTextBox.SelectionColor = Color.Blue;
                        richTextBox.SelectedText = "Measure\tValue\n";
                        richTextBox.SelectedText = "LR(+)\t" + Math387.FormatSample("0.0000", lrplus) + "\n"
                            + "LR(-)\t" + Math387.FormatSample("0.0000", lrminus) + "\n\n";
                    }; break;
                case 1: // two test unpaired
                    {
                        SetupTabs(richTextBox, 3);
                        richTextBox.SelectionColor = Color.Blue;
                        richTextBox.SelectedText = "Measure\tTest\tValue\n";
                        // LR+
                        lrplus = bintest.Test1Table.Se1 / (1.0 - bintest.Test1Table.Sp1);
                        lrminus = bintest.Test2Table.Se1 / (1.0 - bintest.Test2Table.Sp1);
                        richTextBox.SelectedText = "LR(+)\t1\t" + Math387.FormatSample("0.0000", lrplus) + "\n"
                            + "LR(+)\t2\t" + Math387.FormatSample("0.0000", lrminus) + "\n\n";
                        // LR-
                        lrminus = (1.0 - bintest.Test1Table.Se1) / bintest.Test1Table.Sp1;
                        lrplus = (1.0 - bintest.Test2Table.Se1) / bintest.Test2Table.Sp1;
                        richTextBox.SelectedText = "LR(-)\t1\t" + Math387.FormatSample("0.0000", lrminus) + "\n"
                            + "LR(-)\t2\t" + Math387.FormatSample("0.0000", lrplus) + "\n\n";

                    }; break;
            }
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 7);
            richTextBox.SelectedText = "Note: LR(+) means LR(Test=Positive) and LR(-) means LR(Test=Negative).";
        }

        private void HypTestEquivalence()
        {
            double signpct = 100 * (1.0 - Alpha);
            double spdiff = bintest.Test1Table.Sp1 - bintest.Test2Table.Sp1;
            richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox.SelectedText = "Sensitivity & Specificity Hypothesis Test\n\n";

            double sediff = bintest.Test1Table.Se1 - bintest.Test2Table.Se1;

            SetupTabs(richTextBox, 5);
            richTextBox.SelectionColor = Color.Blue;
            richTextBox.SelectedText = "Hypothesis\tValue\tChi-square\tProb. level\tHyp. result\n";
            richTextBox.SelectedText = "Se1 = Se2\t" + Math387.FormatSample("0.0000", sediff) + "\t";

        }


        #endregion

        private void BinaryTestWizard_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            try
            {
                textBoxCIAlpha.Text = bintest.CIAlpha.ToString();
                textBoxT1.Text = bintest.Test1Table.T1.ToString();
                textBoxT0.Text = bintest.Test1Table.T0.ToString();
                textBoxF1.Text = bintest.Test1Table.F1.ToString();
                textBoxF0.Text = bintest.Test1Table.F0.ToString();
                textBoxHypAlpha.Text = Alpha.ToString("0.00");

                comboBox1.SelectedIndex = bintest.Paired ? 2 : 0;
            }
            finally
            {
                this.ResumeLayout();
            }
        }

        private void wizard_AfterSwitchPages(object sender, Dew.Math.Controls.Wizard.AfterSwitchPagesEventArgs e)
        {
            WizardPage newpage = wizard.Pages[e.NewIndex];
            if (newpage == wizardPageReport)
            {
                TextReport();
                wizard.CancelEnabled = false;
            }
            else wizard.CancelEnabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshControls();
        }

        private void textBoxT1_TextChanged(object sender, EventArgs e)
        {
            bintest.Test1Table.T1 = Convert.ToInt16(textBoxT1.Text);
            RefreshControls();
        }

        private void textBoxT0_TextChanged(object sender, EventArgs e)
        {
            bintest.Test1Table.T0 = Convert.ToInt16(textBoxT0.Text);
            RefreshControls();
        }

        private void textBoxF1_TextChanged(object sender, EventArgs e)
        {
            bintest.Test1Table.F1 = Convert.ToInt16(textBoxF1.Text);
            RefreshControls();
        }

        private void textBoxF0_TextChanged(object sender, EventArgs e)
        {
            bintest.Test1Table.F0 = Convert.ToInt16(textBoxF0.Text);
            RefreshControls();
        }

        private void textBoxT21_TextChanged(object sender, EventArgs e)
        {
            bintest.Test2Table.T1 = Convert.ToInt16(textBoxT21.Text);
            RefreshControls();
        }

        private void textBoxT20_TextChanged(object sender, EventArgs e)
        {
            bintest.Test2Table.T0 = Convert.ToInt16(textBoxT20.Text);
            RefreshControls();
        }

        private void textBoxF21_TextChanged(object sender, EventArgs e)
        {
            bintest.Test2Table.F1 = Convert.ToInt16(textBoxF21.Text);
            RefreshControls();
        }

        private void textBoxF20_TextChanged(object sender, EventArgs e)
        {
            bintest.Test2Table.F0 = Convert.ToInt16(textBoxF20.Text);
            RefreshControls();
        }

        private void textBoxHypAlpha_TextChanged(object sender, EventArgs e)
        {
            Alpha = Convert.ToDouble(textBoxHypAlpha.Text);
        }
    }
}

