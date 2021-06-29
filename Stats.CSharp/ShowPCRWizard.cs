using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StatsMasterDemo
{
    public class ShowPCRWizard : Form
    {
        public ShowPCRWizard()
        {
            InitializeComponent();
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
            this.SuspendLayout();
            // 
            // ShowPCRWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 427);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ShowPCRWizard";
            this.Text = "ShowPCRWizard";
            this.Load += new System.EventHandler(this.ShowPCRWizard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private void ShowPCRWizard_Load(object sender, EventArgs e)
        {
            PCRWizard wiz = new PCRWizard();
            // setup with default values
            wiz.A.SetIt(18, 3, false, new double[] {1,	2,	1,
                          2,	4,	2,
                          3,	6,	4,
                          4,	7,	3,
                          5, 7,	2,
                          6,	7,	1,
                          7,	8,	1,
                          8,	10,	2,
                          9,	12,	4,
                          10,	13,	3,
                          11,	13,	2,
                          12,	13,	1,
                          13,	14,	1,
                          14,	16,	2,
                          15,	18,	4,
                          16,	19,	3,
                          17,	19,	2,
                          18,	19,	1});
            wiz.Y.SetIt(false, new double[] { 3, 9, 11, 15, 13, 13, 17, 21, 25, 27, 25, 27, 29, 33, 35, 37, 37, 39 });
            wiz.NumOmmit = 1; // Ommit one variable

            wiz.Dock = DockStyle.Fill;
            wiz.TopLevel = false;
            wiz.FormBorderStyle = FormBorderStyle.None;
            wiz.Parent = this;
            wiz.Show();
        }

    }
}