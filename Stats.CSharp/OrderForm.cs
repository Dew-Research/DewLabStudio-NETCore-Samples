using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StatsMasterDemo
{
    public class OrderForm : StatsMasterDemo.BasicForm3
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
            this.richTextBox1.Size = new System.Drawing.Size(381, 329);
            // 
            // OrderForm
            // 
            this.ClientSize = new System.Drawing.Size(381, 329);
            this.Name = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);
            Add("Ordering Dew Stats Master");
            Add("");
            Add("You may use Dew Stats Master trial version without any costs for the period of one month. "
                + "Applications which include Dew Stats Master Trial version will allways start with a nag "
                + "screen reminding you are using Trial version. If you wish to keep on using it after one "
                + "month, you have to register it with the Dew Research and pay a registration fee. Dew Stats "
                + "Master will still function even if you don't register after one month. If the trial "
                + "version is used for educational purposes, it can be used for a longer period, but you "
                + "have to register it's use by sending an email to info@dewresearch.com.");
            Add("");
            Add("Once you have registered, you will receive fully functional assemblies and links to our "
                + "file repository by email. CDs are also available, but only through Regsoft registration "
                + "service. When new versions of Dew Stats Master are released, you will be able to download "
                + "them from www.dewresearch.com.");
            Add("");
            Add("Your Dew Stats Master license will be valid for your license period. Tech support is fee "
                + "free with 48h response.");
            Add("");
            Add("");
            Add("NOTE: Dew Stats Master is build on top of the latest Dew Math library and therefore requres "
                + "it. For Dew Math and Dew Stats Master pricing info and offline and online ordering "
                + "methods, please visit http://www.dewresearch.com/order.htm where you will find all the "
                + "information that you need. If you would still have any questions, send an email to "
                + "sales@dewresearch.com.");
        }
    }
}

