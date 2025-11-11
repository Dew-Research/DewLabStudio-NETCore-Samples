using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Units;
using Dew.Math.Editors;

namespace MtxVecDemo
{
	public class ClipboardMSOfficeForm : MtxVecDemo.BasicForm2
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
        private Label label1;
		private System.ComponentModel.IContainer components = null;

		public ClipboardMSOfficeForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

            aMtx = new Matrix(0, 0);
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.DetectUrls = false;
            // 
            // button2
            // 
            //this.button2.Image = global::MtxVecDemo.Properties.Resources.Word24x24;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(16, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Paste from Word";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // button1
            // 
            //this.button1.Image = global::MtxVecDemo.Properties.Resources.Excel24x24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(16, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Copy to Excel";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(175, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 174);
            this.label1.TabIndex = 2;
            // 
            // ClipboardMSOfficeForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(472, 445);
            this.Name = "ClipboardMSOfficeForm";
            this.Load += new System.EventHandler(this.ClipboardMSOfficeForm_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private Matrix aMtx;

		private void ClipboardMSOfficeForm_Load(object sender, System.EventArgs e) {
			Add("MtxVecEdit form allows you to export/import TVec "
				+ "or TMtx values to MSOffice (Excel, Word) programs.");
		}

		private void button1_Click(object sender, System.EventArgs e) {
			aMtx.Size(5,4,false);
			aMtx.RandGauss(3,1);
			MtxVecEdit.ViewValues(aMtx, "Exporting to Excel",true,false,true);
		}

		private void button2_Click(object sender, System.EventArgs e) {
			aMtx.SetZero();
			MtxVecEdit.ViewValues(aMtx, "Importing from word",true,false,true);
		}

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Copying values to Excel (Word):\n\n"
            + "1)     Click on the \"Copy to Excel\" button\n"
            + "2)     Select \"Copy\" from the \"Edit\" menu\n"
            + "3)     Go to Excel and select \"Edit->Paste\" menu item.\n";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Pasting values from Word::\n\n"
            + "1)     Go to Word and create 2x2 table,\n"
            + "2)     Enter values:'+1+2i, 0+2i, 3+1i, 2+0i'\n"
            + "3)     Select table and copy it to clipboard\n"
            + "4)     Click on the \"Paste from Word\" button\n"
            + "5)     Select  \"Edit->Paste\" menu. As you can see, complex values are copied to Matrix.\n";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
        }
	}
}

