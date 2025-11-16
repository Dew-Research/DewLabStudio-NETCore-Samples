using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MtxVecDemo
{
	/// <summary>
	/// Summary description for RegisterMtxVec.
	/// </summary>
	public class RegisterMtxVecForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox richTextBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public RegisterMtxVecForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(670, 507);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // RegisterMtxVecForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(670, 507);
            Controls.Add(richTextBox1);
            Name = "RegisterMtxVecForm";
            Text = "RegisterMtxVec";
            Load += RegisterMtxVecForm_Load;
            ResumeLayout(false);

        }
        #endregion

        private void Add(String s) {
			richTextBox1.SelectedText = s + "\n";
		}

		private void RegisterMtxVecForm_Load(object sender, System.EventArgs e) {
			Add("You may use MtxVec trial version without any costs for the period of one month. MtxVec trial version runs within IDE only. "
				+ "If you wish to keep on using it after one month, you have to register it with the DewResearch and pay a registration fee.");
			Add("");
			Add("MtxVec will still function even if you don't register after one month. If the trial version is used for educational "
				+ "purposes, it can be used for a longer period, but you have to register it's use by sending an email to support@dewresearch.com");
			Add("");
			Add("Once you have registered, you will receive fully functional packages and links to our dll repository by email. CDs are also "
				+ "available, but only through Regsoft registration service.");
			Add("");
			Add("When new versions of MtxVec are released, you will be able to download them from www.dewresearch.com.  Your MtxVec license "
				+ "will be valid for all future minor version upgrades of MtxVec. Tech support is fee free with 24h response.");
			Add("");
			Add("For MtxVec pricing info and offline and online ordering methods, please visit http://www.dewresearch.com/order.htm where "
				+ "you will find all the information that you need.  If you would still have any questions, send an email to sales@dewresearch.com.");
		}
	}
}
