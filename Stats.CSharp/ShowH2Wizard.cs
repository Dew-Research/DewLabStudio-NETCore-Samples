using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StatsMasterDemo
{
    public class ShowH2Wizard : Form
    {
        public ShowH2Wizard()
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
            // ShowH2Wizard
            // 
            this.ClientSize = new System.Drawing.Size(551, 445);
            this.Name = "ShowH2Wizard";
            this.Load += new System.EventHandler(this.ShowH2Wizard_Load);
            this.ResumeLayout(false);

        }

        #endregion


        private void ShowH2Wizard_Load(object sender, EventArgs e)
        {

            // include H2 Test wizard
            H2Wizard wiz = new H2Wizard();
            wiz.Dock = DockStyle.Fill;
            wiz.TopLevel = false;
            wiz.Parent = this;
            wiz.FormBorderStyle = FormBorderStyle.None;
            wiz.Data1.SetIt(20, 3, false, new double[] { 3.7, 48.5, 9.3, 5.7, 65.1, 8.0, 3.8, 47.2, 10.9, 3.2, 53.2, 12.0, 3.1, 55.5, 9.7, 4.6, 36.1, 7.9, 2.4, 24.8, 14.0, 7.2, 33.1, 7.6, 6.7, 47.4, 8.5, 5.4, 54.1, 11.3, 3.9, 36.9, 12.7, 4.5, 58.8, 12.3, 3.5, 27.8, 9.8, 4.5, 40.2, 8.4, 1.5, 13.5, 10.1, 8.5, 56.4, 7.1, 4.5, 71.6, 8.2, 6.5, 52.8, 10.9, 4.1, 44.1, 11.2, 5.5, 40.9, 9.4 });
            wiz.TestMeans.SetIt(new double[] { 4, 50, 10 });
            wiz.Show();
            
        }
    }
}

