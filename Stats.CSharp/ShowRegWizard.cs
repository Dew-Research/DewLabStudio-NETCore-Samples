using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StatsMasterDemo
{
    public class ShowRegWizard : Form
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
            // ShowRegWizard
            // 
            this.ClientSize = new System.Drawing.Size(608, 487);
            this.Name = "ShowRegWizard";
            this.Load += new System.EventHandler(this.ShowRegWizard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public ShowRegWizard()
        {
            InitializeComponent();
        }

        private void ShowRegWizard_Load(object sender, EventArgs e)
        {

            MulRegWizard wiz = new MulRegWizard();
            wiz.Dock = DockStyle.Fill;
            wiz.TopLevel = false;
            wiz.Parent = this;
            wiz.FormBorderStyle = FormBorderStyle.None;
            // load some prepared data
            try
            {
                wiz.Y.LoadFromFile(Utils.ReadDemoPath() + @"Data\MulLinReg_Y.vec");
                wiz.A.LoadFromFile(Utils.ReadDemoPath() + @"Data\MulLinReg_A.mtx");
            }
            catch
            {
                wiz.Y.Length = 5;
                wiz.Y.RandGauss();
                wiz.A.Size(5, 3);
                wiz.A.RandGauss();
            }
            wiz.Show();
        }
    }
}

