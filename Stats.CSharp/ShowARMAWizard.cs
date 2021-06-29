using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StatsMasterDemo
{
    public class ShowARMAWizard : StatsMasterDemo.BasicForm2
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
            this.panel2.Size = new System.Drawing.Size(650, 390);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(650, 138);
            // 
            // ShowARMAWizard
            // 
            this.ClientSize = new System.Drawing.Size(650, 528);
            this.Name = "ShowARMAWizard";
            this.Load += new System.EventHandler(this.ShowARMAWizard_Load);
            this.ResumeLayout(false);

        }

        #endregion
        
        public ShowARMAWizard()
        {
            InitializeComponent();
        }

        private void ShowARMAWizard_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("ARMA/ARIMA time series models\n");
            Add("This example demonstrates how to use ARMA/ARIMA routines to model and forecast "
                + "time series. Wizard is pre-loaded with real-life time series. As it can be "
                + "seen from data, data acf and pacf plots, time series is not stationary.");
            Add("Things to try:");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Check series autocorrelation plot. It resemples typicall ARIMA model. Try "
                + "differencing time series to get \"near stationary\"time series.");
            Add("Try fitting the ARMA(2,1) model to differenced data by using Innovations algorithm. ");
            Add("Also, try fitting pure AR or MA model by using Yule-Walker, Burg or Innovations algorithm.");
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionIndent = 0;
            // include ARMA/ARIMA wizard
            ARMAWizard wiz = new ARMAWizard();
            wiz.Dock = DockStyle.Fill;
            wiz.TopLevel = false;
            wiz.Parent = this.panel2;
            wiz.FormBorderStyle = FormBorderStyle.None;
            // load some prepared data
            try
            {
                wiz.TimeSeries.LoadFromFile(Utils.ReadDemoPath() + @"Data\dowjones.vec");
            }
            catch
            {
                wiz.TimeSeries.Length = 100;
                wiz.TimeSeries.RandGauss();
            }
            wiz.Show();
        }
    }
}

