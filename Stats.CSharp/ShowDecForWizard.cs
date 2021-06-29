using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StatsMasterDemo
{
    public class ShowDecForWizard : StatsMasterDemo.BasicForm2
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
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(593, 342);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(593, 138);
            // 
            // ShowDecForWizard
            // 
            this.ClientSize = new System.Drawing.Size(593, 480);
            this.Name = "ShowDecForWizard";
            this.Load += new System.EventHandler(this.ShowDecForWizard_Load);
            this.ResumeLayout(false);

        }

        #endregion
        
        public ShowDecForWizard()
        {
            InitializeComponent();
        }

        private void ShowDecForWizard_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("Decomposition forecasting\n");
            Add("Classical time series decomposition separates a time series into five components: "
                + "mean, long-range trend, seasonality, cycle, and randomness. This example demonstrates "
                + "using basic Stats Master routines to perform complex tasks.");
            Add("In this example monthly air passenger data with one year period (12 months) is analyzed "
                + "with decomposition forecasting.\n Things to try:");

            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Set the season length to 12 (one year).");
            Add("Try including/excluding the \"cycle\" part in forecasting.");
            Add("Change the \"forecast cycle\" value.");
            Add("Change the season length to 6 or 24 (six months or two years).");
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionIndent = 0;
            // include decomposition forecasting wizard
            DecForecastWizard wiz = new DecForecastWizard();
            wiz.Dock = DockStyle.Fill;
            wiz.TopLevel = false;
            wiz.Parent = this.panel2;
            wiz.FormBorderStyle = FormBorderStyle.None;
            // load some prepared data
            try
            {
                wiz.TimeSeries.LoadFromFile(Utils.ReadDemoPath() + @"Data\airpass.vec");
            }
            catch
            {
                wiz.TimeSeries.Length = 50;
                wiz.TimeSeries.RandGauss();
            }
            wiz.Show();
          
        }
    }
}

