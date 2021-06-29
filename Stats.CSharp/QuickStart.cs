using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StatsMasterDemo
{
    public class QuickStart : StatsMasterDemo.BasicForm3
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
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(461, 358);
            // 
            // QuickStart
            // 
            this.ClientSize = new System.Drawing.Size(461, 358);
            this.Name = "QuickStart";
            this.Load += new System.EventHandler(this.QuickStart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public QuickStart()
        {
            InitializeComponent();
        }

        private void QuickStart_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);
            Add("Quick start: Multiple linear regression");
            Add("");
            Add("With Dew Stats Master it's not difficult to do complex tasks. Doing multiple linear regression is a peace of cake:\n");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Add Dew.Math.Units, Dew.Math.Editors to the using section.");
            Add("Drop tMtxMulLinReg component and the Button on the form.");
            Add("Bring up the TMtxMulLinReg design time editor by double  clicking  on MtxMulLinReg1.");
            Add("Define if constant term or weights will be used (this can also be done at runtime via code). "
                + "Close TMtxMulLinReg editor.");
            Add("Double click on Button1 and add the following code:");
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionFont = new Font("Courier", 10, FontStyle.Regular);
            Add("\ntMtxMulLinReg1.Y.LoadFromFile(\"c:\\\\temp\\\\yvals.vec\");\ntMtxMulLinReg1.A.LoadFromFile(\"c:\\\\temp\\\\system.mtx\");\n"
                +"tMtxMulLinReg1.Recalculate();\nMtxVecEdit.ViewValues(tMtxMulLinReg1.RegressResult.B,\"Regression coefficients\",true,false,false);\n");
            richTextBox1.SelectionIndent = 0;
            Add("Other things to try:\n");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Access RegressResult properties (YCalc, Residuals). Draw these  values by using Dew.Math.DrawValues method ");
            Add("Load Y,A data from ASCII file (demonstrated in demo). Repeat  procedure.");
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionIndent = 0;



        }
    }
}

