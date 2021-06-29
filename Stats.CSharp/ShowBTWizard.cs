using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace StatsMasterDemo
{
	public class ShowBTWizard : Form
	{
		private System.ComponentModel.IContainer components = null;

		public ShowBTWizard()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.SuspendLayout();
            // 
            // ShowBTWizard
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(567, 473);
            this.Name = "ShowBTWizard";
            this.Load += new System.EventHandler(this.ShowBTWizard_Load);
            this.ResumeLayout(false);

		}
		#endregion

		private void ShowBTWizard_Load(object sender, System.EventArgs e)
		{
            // include binary test wizard
			BinaryTestWizard wiz = new BinaryTestWizard();
			wiz.Dock = DockStyle.Fill;
			wiz.TopLevel = false;
            wiz.Parent = this;
			wiz.FormBorderStyle = FormBorderStyle.None;
            wiz.bintest.Paired = true;
            wiz.bintest.Test1Table.T1 = 31;
            wiz.bintest.Test1Table.T0 = 5;
            wiz.bintest.Test1Table.F1 = 4;
            wiz.bintest.Test1Table.F0 = 10;
            wiz.Show();		
		}
	}
}

