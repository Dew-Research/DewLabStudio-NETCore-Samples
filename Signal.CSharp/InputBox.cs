using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace DSPDemo
{
	/// <summary>
	/// Summary description for InputBox.
	/// </summary>
	public class InputBox : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public InputBox()
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

		public static String Show(string caption, string title, string initialValue) {
			InputBox box = new InputBox();
			box.textBox1.Text = initialValue;
			box.Text = caption;
			box.label1.Text = title;
			box.ShowDialog();
			string result = box.textBox1.Text;
			box.Dispose();
			return result;
		}

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "textBox1";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(192, 69);
            button1.Name = "button1";
            button1.Size = new Size(90, 28);
            button1.TabIndex = 2;
            button1.Text = "OK";
            // 
            // InputBox
            // 
            AcceptButton = button1;
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(311, 109);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "InputBox";
            StartPosition = FormStartPosition.CenterParent;
            Text = "InputBox";
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
    }
}
