using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StatsMasterDemo
{
    public class ShowPCAWizard : Form
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
            // ShowPCAWizard
            // 
            this.ClientSize = new System.Drawing.Size(593, 502);
            this.Name = "ShowPCAWizard";
            this.Load += new System.EventHandler(this.ShowPCAWizard_Load);
            this.ResumeLayout(false);

        }

        #endregion
        
        public ShowPCAWizard()
        {
            InitializeComponent();
        }

        private void ShowPCAWizard_Load(object sender, EventArgs e)
        {
            PCAWizard wiz = new PCAWizard();
            wiz.Dock = DockStyle.Fill;
            wiz.TopLevel = false;
            wiz.Parent = this;
            wiz.FormBorderStyle = FormBorderStyle.None;
            // load some prepared data
            try
            {
                wiz.Data.LoadFromFile(Utils.ReadDemoPath() + @"Data\PCA_Data.mtx");
            }
            catch
            {
                wiz.Data.Size(8,6);
                wiz.Data.RandGauss();
            }
            wiz.Show();
        }
    }
}

