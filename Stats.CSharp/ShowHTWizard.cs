using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StatsMasterDemo
{
    public class ShowHTWizard : Form
    {
        public ShowHTWizard()
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
            // ShowHTWizard
            // 
            this.ClientSize = new System.Drawing.Size(585, 486);
            this.Name = "ShowHTWizard";
            this.Load += new System.EventHandler(this.ShowHTWizard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private void ShowHTWizard_Load(object sender, EventArgs e)
        {
            // include H2 Test wizard
            HypTestWizard wiz = new HypTestWizard();
            wiz.Dock = DockStyle.Fill;
            wiz.TopLevel = false;
            wiz.Parent = this;
            wiz.FormBorderStyle = FormBorderStyle.None;
            // setup wizard properties...
            wiz.Data1.LoadFromFile(Utils.ReadDemoPath()+@".\Data\Growth_Y.vec");
            wiz.Data1.Caption = "First dataset";
            wiz.Data2.Caption = "Second dataset";
            wiz.NumDataSets = 1;
            wiz.Show();
        }

    }
}

