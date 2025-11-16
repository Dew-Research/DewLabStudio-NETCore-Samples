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
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Size = new Size(912, 419);
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 557);
            panel3.Size = new Size(912, 59);
            // 
            // richTextBox1
            // 
            richTextBox1.DetectUrls = false;
            richTextBox1.Size = new Size(912, 138);
            // 
            // button2
            // 
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(19, 82);
            button2.Name = "button2";
            button2.Size = new Size(163, 46);
            button2.TabIndex = 1;
            button2.Text = "Paste from Word";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.Click += button2_Click;
            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;
            // 
            // button1
            // 
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(19, 30);
            button1.Name = "button1";
            button1.Size = new Size(163, 45);
            button1.TabIndex = 0;
            button1.Text = "Copy to Excel";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.ControlDark;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(210, 30);
            label1.Name = "label1";
            label1.Size = new Size(687, 282);
            label1.TabIndex = 2;
            // 
            // ClipboardMSOfficeForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(912, 616);
            Name = "ClipboardMSOfficeForm";
            Load += ClipboardMSOfficeForm_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);

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

