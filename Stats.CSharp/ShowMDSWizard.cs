using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StatsMasterDemo
{
    public class ShowMDSWizard : Form
    {
        public ShowMDSWizard()
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
            // ShowMDSWizard
            // 
            this.ClientSize = new System.Drawing.Size(576, 471);
            this.Name = "ShowMDSWizard";
            this.Load += new System.EventHandler(this.ShowMDSWizard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private void ShowMDSWizard_Load(object sender, EventArgs e)
        {
            MDSWizard wiz = new MDSWizard();
            // load some prepared data
            // Distance matrix
            wiz.tMtxMDScaling1.Data.SetIt(6, 6, false, new double[] {
                    0,2,3,4,5,5,
                    2,0,3,5,6,5,
                    3,3,0,5,4,6,
                    4,5,5,0,4,3,
                    5,6,4,4,0,2,
                    5,5,6,3,2,0});
            wiz.tMtxMDScaling1.DataFormat = Dew.Stats.TMDDataFormat.mdFormatDissimilarities;
            wiz.tMtxMDScaling1.Dimensions = 2;
            wiz.Dock = DockStyle.Fill;
            wiz.TopLevel = false;
            wiz.FormBorderStyle = FormBorderStyle.None;
            wiz.Parent = this;
            wiz.Show();
        }
    }
}

