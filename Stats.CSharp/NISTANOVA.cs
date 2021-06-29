using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Units;
using Dew.Stats.Units;
using Dew.Stats;

namespace StatsMasterDemo
{
    public class NISTANOVA : StatsMasterDemo.BasicForm2
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
            if (anova != null) anova.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxAnova = new System.Windows.Forms.RichTextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBoxAnova);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Size = new System.Drawing.Size(662, 364);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(662, 138);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test";
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "SmLs01 (lower difficulty)",
            "AtmWtAg (medium difficulty)",
            "SmLs07 (higher difficulty)"});
            this.comboBox1.Location = new System.Drawing.Point(15, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox2.Location = new System.Drawing.Point(174, 16);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox2.Size = new System.Drawing.Size(473, 236);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "one way ANOVA results";
            // 
            // richTextBoxAnova
            // 
            this.richTextBoxAnova.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxAnova.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxAnova.Location = new System.Drawing.Point(0, 264);
            this.richTextBoxAnova.Name = "richTextBoxAnova";
            this.richTextBoxAnova.Size = new System.Drawing.Size(662, 100);
            this.richTextBoxAnova.TabIndex = 5;
            this.richTextBoxAnova.Text = "";
            // 
            // NISTANOVA
            // 
            this.ClientSize = new System.Drawing.Size(662, 502);
            this.Name = "NISTANOVA";
            this.Load += new System.EventHandler(this.NISTANOVA_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private RichTextBox richTextBoxAnova;
        private System.Windows.Forms.Label label2;


        
        public NISTANOVA()
        {
            InitializeComponent();
            anova = new TMtxAnova();
        }

        private TMtxAnova anova;

        private void DisplayInfo(int index)
        {
            switch (index)
            {
                case 0:
                    {
                        richTextBox2.Text = "Reference:\nSimon, Stephen D. and Lesage, James P. (1989).\"Assessing "
                            + "the Accuracy of ANOVA Calculations in Statistical Software\". Computational Statistics "
                            + "& Data Analysis, 8, pp. 325-332.\n\n";
                        richTextBox2.Text += "Data:\n";
                        richTextBox2.Text += "1 Factor\n";
                        richTextBox2.Text += "9 Treatments\n";
                        richTextBox2.Text += "21 Replicates/Cell\n";
                        richTextBox2.Text += "189 Observations\n";
                        richTextBox2.Text += "1 Constant Leading Digits\n";
                        richTextBox2.Text += "Lower Level of Difficulty\n";
                        richTextBox2.Text += "Generated Data\n\n";
                        richTextBox2.Text += "Model:\n";
                        richTextBox2.Text += "10 Parameters (mu, tau_1, ..., tau_9)\n";
                        richTextBox2.Text += "y_{ij} = mu + tau_i + epsilon_{ij}\n\n";
                        richTextBox2.Text += "Certified values:\n";
                        richTextBox2.Text += "Source of\tSum of\t\tMean\t\n";
                        richTextBox2.Text += "variation\tsquares\tdf\tsquares\tF statistics\n";
                        richTextBox2.Text += "Between\t1.68\t8\t2.1E-01\t2.1E+01\n";
                        richTextBox2.Text += "Within\t1.8\t180\t1.0E-02\n";
                    }; break;

                case 1:
                    {
                        richTextBox2.Text = "Reference:\nPowell, L.J., Murphy, T.J. and Gramlich, "
                            + "J.W. (1982).\"The Absolute Isotopic Abundance & Atomic Weight of a Reference "
                            + "Sample of Silver\". NBS Journal of Research, 87, pp. 9-19.\n\n";
                        richTextBox2.Text += "Data:\n";
                        richTextBox2.Text += "1 Factor\n";
                        richTextBox2.Text += "2 Treatments\n";
                        richTextBox2.Text += "24 Replicates/Cell\n";
                        richTextBox2.Text += "48 Observations\n";
                        richTextBox2.Text += "7 Constant Leading Digits\n";
                        richTextBox2.Text += "Average Level of Difficulty\n";
                        richTextBox2.Text += "Observed Data\n\n";
                        richTextBox2.Text += "Model:\n";
                        richTextBox2.Text += "3 Parameters (mu, tau_1, tau_2))\n";
                        richTextBox2.Text += "y_{ij} = mu + tau_i + epsilon_{ij}\n\n";
                        richTextBox2.Text += "Certified values:\n";
                        richTextBox2.Text += "Source of\t\tSum of\t\t\tMean\t\n";
                        richTextBox2.Text += "variation\t\tsquares\t\tdf\tsquares\t\t\tF statistics\n";
                        richTextBox2.Text += "Between\t3.63834187500000E-09\t1\t3.63834187500000E-09\t1.59467335677930E+01\n";
                        richTextBox2.Text += "Within\t1.04951729166667E-08\t46\t2.28155932971014E-10\n";
                    }; break;

                case 2:
                    {
                        richTextBox2.Text = "Reference:\nSimon, Stephen D. and Lesage, James P. (1989).\"Assessing "
                            + "the Accuracy of ANOVA Calculations in Statistical Software\". Computational Statistics "
                            + "& Data Analysis, 8, pp. 325-332.\n\n";
                        richTextBox2.Text += "Data:\n";
                        richTextBox2.Text += "1 Factor\n";
                        richTextBox2.Text += "9 Treatments\n";
                        richTextBox2.Text += "21 Replicates/Cell\n";
                        richTextBox2.Text += "189 Observations\n";
                        richTextBox2.Text += "13 Constant Leading Digits\n";
                        richTextBox2.Text += "Higher Level of Difficulty\n";
                        richTextBox2.Text += "Generated Data\n\n";
                        richTextBox2.Text += "Model:\n";
                        richTextBox2.Text += "10 Parameters (mu, tau_1, ..., tau_9)\n";
                        richTextBox2.Text += "y_{ij} = mu + tau_i + epsilon_{ij}\n\n";
                        richTextBox2.Text += "Certified values:\n";
                        richTextBox2.Text += "Source of\tSum of\t\tMean\t\n";
                        richTextBox2.Text += "variation\tsquares\tdf\tsquares\tF statistics\n";
                        richTextBox2.Text += "Between\t1.68\t8\t2.1E-01\t2.1E+01\n";
                        richTextBox2.Text += "Within\t1.8\t180\t1.0E-02\n";
                    }; break;
            }
        }

        private void FillData(int index)
        {
            switch (index)
            {
                case 0: // SmLs01
                    {
                        anova.FmtString = "0.000000E+00";
                        anova.Data.SetIt(21, 9, false, new double[]{1.4, 1.3, 1.5, 1.3, 1.5, 1.3, 1.5, 1.3, 1.5,
                                    1.3, 1.2, 1.4, 1.2, 1.4, 1.2, 1.4, 1.2, 1.4,
                                    1.5, 1.4, 1.6, 1.4, 1.6, 1.4, 1.6, 1.4, 1.6,
                                    1.3, 1.2, 1.4, 1.2, 1.4, 1.2, 1.4, 1.2, 1.4,
                                    1.5, 1.4, 1.6, 1.4, 1.6, 1.4, 1.6, 1.4, 1.6,
                                    1.3, 1.2, 1.4, 1.2, 1.4, 1.2, 1.4, 1.2, 1.4,
                                    1.5, 1.4, 1.6, 1.4, 1.6, 1.4, 1.6, 1.4, 1.6,
                                    1.3, 1.2, 1.4, 1.2, 1.4, 1.2, 1.4, 1.2, 1.4,
                                    1.5, 1.4, 1.6, 1.4, 1.6, 1.4, 1.6, 1.4, 1.6,
                                    1.3, 1.2, 1.4, 1.2, 1.4, 1.2, 1.4, 1.2, 1.4,
                                    1.5, 1.4, 1.6, 1.4, 1.6, 1.4, 1.6, 1.4, 1.6,
                                    1.3, 1.2, 1.4, 1.2, 1.4, 1.2, 1.4, 1.2, 1.4,
                                    1.5, 1.4, 1.6, 1.4, 1.6, 1.4, 1.6, 1.4, 1.6,
                                    1.3, 1.2, 1.4, 1.2, 1.4, 1.2, 1.4, 1.2, 1.4,
                                    1.5, 1.4, 1.6, 1.4, 1.6, 1.4, 1.6, 1.4, 1.6,
                                    1.3, 1.2, 1.4, 1.2, 1.4, 1.2, 1.4, 1.2, 1.4,
                                    1.5, 1.4, 1.6, 1.4, 1.6, 1.4, 1.6, 1.4, 1.6,
                                    1.3, 1.2, 1.4, 1.2, 1.4, 1.2, 1.4, 1.2, 1.4,
                                    1.5, 1.4, 1.6, 1.4, 1.6, 1.4, 1.6, 1.4, 1.6,
                                    1.3, 1.2, 1.4, 1.2, 1.4, 1.2, 1.4, 1.2, 1.4,
                                    1.5, 1.4, 1.6, 1.4, 1.6, 1.4, 1.6, 1.4, 1.6});
                    }; break;
                case 1: // AtmWtAg
                    {
                        anova.FmtString = "0.000000E+00";
                        anova.Data.SetIt(24, 2, false, new double[]{107.8681568, 107.8681079,
                                   107.8681465, 107.8681344,
                                   107.8681572, 107.8681513,
                                   107.8681785, 107.8681197,
                                   107.8681446, 107.8681604,
                                   107.8681903, 107.8681385,
                                   107.8681526, 107.8681642,
                                   107.8681494, 107.8681365,
                                   107.8681616, 107.8681151,
                                   107.8681587, 107.8681082,
                                   107.8681519, 107.8681517,
                                   107.8681486, 107.8681448,
                                   107.8681419, 107.8681198,
                                   107.8681569, 107.8681482,
                                   107.8681508, 107.8681334,
                                   107.8681672, 107.8681609,
                                   107.8681385, 107.8681101,
                                   107.8681518, 107.8681512,
                                   107.8681662, 107.8681469,
                                   107.8681424, 107.8681360,
                                   107.8681360, 107.8681254,
                                   107.8681333, 107.8681261,
                                   107.8681610, 107.8681450,
                                   107.8681477, 107.8681368});

                    }; break;
                case 2: // SmLs07
                    {
                        anova.FmtString = "0.000000E+00";
                        anova.Data.SetIt(21, 9, false, new double[]{1000000000000.4, 1000000000000.3, 1000000000000.5, 1000000000000.3, 1000000000000.5, 1000000000000.3, 1000000000000.5, 1000000000000.3, 1000000000000.5,
                                    1000000000000.3, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4,
                                    1000000000000.5, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6,
                                    1000000000000.3, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4,
                                    1000000000000.5, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6,
                                    1000000000000.3, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4,
                                    1000000000000.5, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6,
                                    1000000000000.3, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4,
                                    1000000000000.5, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6,
                                    1000000000000.3, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4,
                                    1000000000000.5, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6,
                                    1000000000000.3, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4,
                                    1000000000000.5, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6,
                                    1000000000000.3, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4,
                                    1000000000000.5, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6,
                                    1000000000000.3, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4,
                                    1000000000000.5, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6,
                                    1000000000000.3, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4,
                                    1000000000000.5, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6,
                                    1000000000000.3, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4, 1000000000000.2, 1000000000000.4,
                                    1000000000000.5, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6, 1000000000000.4, 1000000000000.6});

                    }; break;
            }
        }

        private void DoAnova()
        {
            anova.Recalc();
            FormatGrid();
        }

        /// <summary>
        /// Outputs ANOVA results to rich text box
        /// </summary>
        private void FormatGrid()
        {
            TANOVA1Result ares = anova.Anova1Res;
            string fst = anova.FmtString;
            richTextBoxAnova.Clear();
            richTextBoxAnova.SelectionTabs = new int[]{100,200,300,400,500,600,700};
            richTextBoxAnova.SelectionColor = Color.Blue;
            richTextBoxAnova.SelectedText ="Source\tSum sqr.\tDeg.f.\tMean sqr.\tProbability\tF-ratio\tF-critical\n";
            string st = "Between grp.\t" + Math387.FormatSample(ares.SS1, fst) + "\t" + Math387.FormatSample(ares.Deg1, "#")+"\t";
            st += Math387.FormatSample(ares.MS1, fst) + "\t" + Math387.FormatSample(anova.P, fst) + "\t";
            st += Math387.FormatSample(ares.FCrit, fst) + "\n";
            st += "Within grp.\t" + Math387.FormatSample(ares.SS2, fst) + "\t" + Math387.FormatSample(ares.Deg2, "#") + "\t";
            st += Math387.FormatSample(ares.MS2, fst) + "\n";
            st += "Total\t" + Math387.FormatSample(ares.SSTotal, fst) + "\t" + Math387.FormatSample(ares.DegTotal, "#") + "\n";

            richTextBoxAnova.SelectedText = st;
        }


        private void NISTANOVA_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("NIST ANOVA tests: \n");
            Add("SmLs01: Simon, Stephen D. and Lesage, James P. (1989). \"Assessing "
                + "the Accuracy of ANOVA Calculations in Statistical Software\". "
                + "Computational Statistics & Data Analysis, 8, pp. 325-332. "
                + "(Lower level of difficulty)\n");
            Add("AtmWtAg : Powell, L.J., Murphy, T.J. and Gramlich, J.W. (1982). "
                +"\"The Absolute Isotopic Abundance & Atomic Weight of a Reference Sample of "
                +"Silver\". NBS Journal of Research, 87, pp. 9-19. (Average level of difficulty)\n");
            Add("SmLs07 : Simon, Stephen D. and Lesage, James P. (1989). \"Assessing the Accuracy "
                + "of ANOVA Calculations in Statistical Software\". Computational Statistics & "
                + "Data Analysis, 8, pp. 325-332. (Higher level of difficulty");

            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayInfo(comboBox1.SelectedIndex);
            FillData(comboBox1.SelectedIndex);
            DoAnova();
        }

    }
}

