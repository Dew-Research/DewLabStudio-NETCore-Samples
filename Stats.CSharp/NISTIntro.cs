using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StatsMasterDemo
{
    public class NISTIntro : StatsMasterDemo.BasicForm3
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
            this.richTextBox1.Size = new System.Drawing.Size(504, 383);
            // 
            // NISTIntro
            // 
            this.ClientSize = new System.Drawing.Size(504, 383);
            this.Name = "NISTIntro";
            this.Load += new System.EventHandler(this.NISTIntro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        
        public NISTIntro()
        {
            InitializeComponent();
        }

        private void NISTIntro_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Add("Taken from NIST introduction (http://www.itl.nist.gov/div898/strd/index.html)\n");
            Add("\"In response to industrial concerns about the numerical accuracy of computations from "
                + "statistical software, the Statistical Engineering and Mathematical and Computational "
                + "Sciences Divisions of NISTs Information Technology Laboratory are providing datasets "
                + "with certified values for a variety of statistical methods.");
            Add("Currently datasets and certified values are provided for assessing the accuracy of "
                + "software for univariate statistics, linear regression, nonlinear regression, and analysis "
                + "of variance. The collection includes both generated and \"real-world\" data of "
                + "varying levels of difficulty. Generated datasets are designed to challenge  specific "
                + "computations. Certified values are \"best-available\" solutions.");
            Add("Datasets are ordered by level of difficulty (lower, average, and higher). Strictly speaking "
                + "the level of difficulty of a dataset depends on the algorithm. These levels are merely "
                + "provided as rough guidance for the user. Producing correct results on all datasets of "
                + "higher difficulty does not imply that your software will pass all datasets of average "
                + "or even lower difficulty. Similarly, producing correct results for all datasets in this "
                + "collection does not imply that your software will do the same for your particular "
                + "dataset. It will, however, provide some degree of assurance, in the sense that your "
                + "package provides correct results for datasets known to yield incorrect results for "
                + "some software.");
        }
    }
}

