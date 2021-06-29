using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math.Units;
using Dew.Math.Editors;

namespace StatsMasterDemo
{
    public class LogistReg : StatsMasterDemo.BasicForm2
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
            this.components = new System.ComponentModel.Container();
            this.tMtxLogistReg1 = new Dew.Stats.TMtxLogistReg(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Size = new System.Drawing.Size(788, 372);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(788, 138);
            // 
            // tMtxLogistReg1
            // 
            this.tMtxLogistReg1.Alpha = 0D;
            this.tMtxLogistReg1.BlockAssign = false;
            this.tMtxLogistReg1.Dirty = false;
            this.tMtxLogistReg1.Name = "";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dependent variable (Y)";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Independent variables (A)";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(12, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Recalculate";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox2.Location = new System.Drawing.Point(168, 18);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(604, 336);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // LogistReg
            // 
            this.ClientSize = new System.Drawing.Size(788, 510);
            this.Name = "LogistReg";
            this.Load += new System.EventHandler(this.LogistReg_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Dew.Stats.TMtxLogistReg tMtxLogistReg1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox2;


        public LogistReg()
        {
            InitializeComponent();
            tMtxLogistReg1.A.SetIt(27,3,false,new double[]
               {0.8, 1.9, 0.996,
                0.9, 1.4, 0.992,
                0.8, 0.8, 0.982,
                1, 0.7, 0.986,
                0.9,   1.3, 0.98,
                1,   0.6, 0.982,
                0.95, 1, 0.992,
                0.95, 1.9, 1.02,
                1,  0.8,   0.999,
                0.95, 0.5, 1.038,
                0.85, 0.7, 0.988,
                0.7, 1.2, 0.982,
                0.8, 0.4, 1.006,
                0.2, 0.8, 0.99,
                1, 1.1, 0.99,
                1, 1.9, 1.02,
                0.65, 0.5, 1.014,
                1, 1, 1.004,
                0.5, 0.6, 0.99,
                1, 1.1, 0.986,
                1, 0.4, 1.01,
                0.9, 0.6, 1.02,
                1, 1, 1.002,
                0.95, 1.6, 0.988,
                1, 1.7, 0.99,
                1, 0.9, 0.986,
                1, 0.7, 0.986});
            tMtxLogistReg1.Y.SetIt(new double[] { 1, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 1, 1, 0 });
        }

        private void Recalculate()
        {
            int iter;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                tMtxLogistReg1.Recalc();
                iter = tMtxLogistReg1.Iterations;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

            string st = "";

            richTextBox2.Clear();
            richTextBox2.SelectionFont = new Font(richTextBox2.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox2.SelectedText = "Logistic regression report\n\n";
            richTextBox2.SelectedText += "Number of independent variables: " + tMtxLogistReg1.A.Cols.ToString() + "\n";
            richTextBox2.SelectedText += "----------------------------------------------------------------\n";
            richTextBox2.SelectedText += "Regression coefficients Theta (constant term):\n";
            richTextBox2.SelectionTabs = new int[] { 90 };
            richTextBox2.SelectionColor = Color.Blue;
            richTextBox2.SelectedText = "Theta\tTheta Std.Err\n";

            for (int i=0; i<tMtxLogistReg1.Theta.Length; i++)
            {
                st += Math387.FormatSample("0.0000",tMtxLogistReg1.Theta.Values[i])+"\t";
                st += Math387.FormatSample("0.0000",tMtxLogistReg1.TBStdErr.Values[i])+"\n";
            }
            richTextBox2.SelectedText = st;
            
            richTextBox2.SelectedText += "\nRegression coefficients B:\n";
            richTextBox2.SelectionColor = Color.Blue;
            richTextBox2.SelectedText = "B\tB Std.Err\n";
            st = "";
            for (int i=0; i<tMtxLogistReg1.B.Length; i++)
            {
                st += Math387.FormatSample("0.0000", tMtxLogistReg1.B.Values[i]) + "\t";
                st += Math387.FormatSample("0.0000", tMtxLogistReg1.TBStdErr.Values[tMtxLogistReg1.Theta.Length + i]) + "\n";
            }
            richTextBox2.SelectedText = st;

            richTextBox2.SelectedText += "----------------------------------------------------------------\n";
            richTextBox2.SelectedText += "\nAdditional parameters returned: \n";
            richTextBox2.SelectedText += "Log-likehood function, evaluated at minimum: " + Math387.FormatSample("0.0000", tMtxLogistReg1.FMin) + "\n";
            richTextBox2.SelectedText += "Number of iterations needed to converge: " + iter.ToString() + "\n";
        }

        private void LogistReg_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("Logistic regression is similar to regular multiple regression except that the dependent (Y) variable "
                + "is integer (can be binary, but it is not obligatory) instead of continuous. "
                + "Stats Master supports ordinary logistic regression (binary dependent variable) and ordinal "
                + "(dependent variables are integers) logistic regression. Example bellow is taken NCSS, another great statistical "
                + "package.\n");
            Add("Example: The data below is taken from first few rows of a set of data about leukemia patients published in Lee (1980). "
                + "The response variable is whether leukemia remission occurred. These values are passed to TMtxLogistReg.Y vector. "
                + "The independent variables are cellularity of the marrow clot section, smear differential percentage of blasts, percentage "
                + "of absolute marrow leukemia cell infiltrate, percentage labeling index of the bone marrow leukemia cells, absolute number "
                + "of blasts in the peripheral blood, and the highest temperature prior to start of treatment. "
                + "We will estimate only the relationship between remission, cellularity, index of leukemia cells and temperature. Each variable "
                + "is stored in separate column in tMtxLogistReg.A matrix.");
	    Recalculate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MtxVecEdit.ViewValues(tMtxLogistReg1.Y, "Y", true, false, true);
            Recalculate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MtxVecEdit.ViewValues(tMtxLogistReg1.A, "A", true, false, true);
            Recalculate();
        }
    }
}

