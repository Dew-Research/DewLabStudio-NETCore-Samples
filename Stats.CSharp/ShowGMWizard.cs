using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace StatsMasterDemo
{
	/// <summary>
	/// Summary description for ShowGMWizard.
	/// </summary>
	public class ShowGMWizard : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ShowGMWizard()
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
            this.SuspendLayout();
            // 
            // ShowGMWizard
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(416, 337);
            this.Name = "ShowGMWizard";
            this.Text = "ShowGMWizard";
            this.Load += new System.EventHandler(this.ShowGMWizard_Load);
            this.ResumeLayout(false);

		}
		#endregion

		private void ShowGMWizard_Load(object sender, System.EventArgs e)
		{
			// include Growth models wizar
			GrowthModelWizard wiz = new GrowthModelWizard();
			wiz.Dock = DockStyle.Fill;
			wiz.TopLevel = false;
			wiz.Parent = this;
			wiz.FormBorderStyle = FormBorderStyle.None;
			// setup wizard properties...
            wiz.X.LoadFromFile(Utils.ReadDemoPath() + @"Data\Growth_X.vec");
            wiz.Y.LoadFromFile(Utils.ReadDemoPath() + @"Data\Growth_Y.vec");
			wiz.Show();
		}
	}
}
