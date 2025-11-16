using System;
#if VS2005
using System.Collections.Generic;
#else
using System.Collections;
#endif
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MtxVecDemo
{
    public class CalculatorPad : UserControl
    {

        private TextBox tbox = null;
        
        public CalculatorPad()
        {
            InitializeComponent();
        }

        private Button button19;
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "7";
#if VS2005
            this.button1.UseVisualStyleBackColor = true;
#endif
            this.button1.Click += new System.EventHandler(this.button17_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(39, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "8";
#if VS2005
            this.button2.UseVisualStyleBackColor = true;
#endif
            this.button2.Click += new System.EventHandler(this.button17_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(75, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "9";
#if VS2005
            this.button3.UseVisualStyleBackColor = true;
#endif
            this.button3.Click += new System.EventHandler(this.button17_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(111, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "-";
#if VS2005
            this.button4.UseVisualStyleBackColor = true;
#endif
            this.button4.Click += new System.EventHandler(this.button17_Click);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Blue;
            this.button5.Location = new System.Drawing.Point(3, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "4";
#if VS2005
			this.button5.UseVisualStyleBackColor = true;
#endif 
            this.button5.Click += new System.EventHandler(this.button17_Click);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.Blue;
            this.button6.Location = new System.Drawing.Point(39, 32);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "5";
#if VS2005
			this.button6.UseVisualStyleBackColor = true;
#endif
			this.button6.Click += new System.EventHandler(this.button17_Click);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.Color.Blue;
            this.button7.Location = new System.Drawing.Point(75, 32);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(30, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "6";
#if VS2005
            this.button7.UseVisualStyleBackColor = true;
#endif
            this.button7.Click += new System.EventHandler(this.button17_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.ForeColor = System.Drawing.Color.Red;
            this.button8.Location = new System.Drawing.Point(111, 32);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "+";
#if VS2005
            this.button8.UseVisualStyleBackColor = true;
#endif
            this.button8.Click += new System.EventHandler(this.button17_Click);
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.Color.Blue;
            this.button9.Location = new System.Drawing.Point(3, 61);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(30, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "1";
#if VS2005
            this.button9.UseVisualStyleBackColor = true;
#endif
            this.button9.Click += new System.EventHandler(this.button17_Click);
            // 
            // button10
            // 
            this.button10.ForeColor = System.Drawing.Color.Blue;
            this.button10.Location = new System.Drawing.Point(39, 61);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(30, 23);
            this.button10.TabIndex = 9;
            this.button10.Text = "2";
#if VS2005
            this.button10.UseVisualStyleBackColor = true;
#endif
            this.button10.Click += new System.EventHandler(this.button17_Click);
            // 
            // button11
            // 
            this.button11.ForeColor = System.Drawing.Color.Blue;
            this.button11.Location = new System.Drawing.Point(75, 61);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(30, 23);
            this.button11.TabIndex = 10;
            this.button11.Text = "3";
#if VS2005
            this.button11.UseVisualStyleBackColor = true;
#endif
            this.button11.Click += new System.EventHandler(this.button17_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button12.ForeColor = System.Drawing.Color.Red;
            this.button12.Location = new System.Drawing.Point(111, 61);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(30, 23);
            this.button12.TabIndex = 11;
            this.button12.Text = "*";
#if VS2005
            this.button12.UseVisualStyleBackColor = true;
#endif
            this.button12.Click += new System.EventHandler(this.button17_Click);
            // 
            // button13
            // 
            this.button13.ForeColor = System.Drawing.Color.Blue;
            this.button13.Location = new System.Drawing.Point(3, 90);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(30, 23);
            this.button13.TabIndex = 12;
            this.button13.Text = "i";
#if VS2005
            this.button13.UseVisualStyleBackColor = true;
#endif
            this.button13.Click += new System.EventHandler(this.button17_Click);
            // 
            // button14
            // 
            this.button14.ForeColor = System.Drawing.Color.Blue;
            this.button14.Location = new System.Drawing.Point(39, 90);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(30, 23);
            this.button14.TabIndex = 13;
            this.button14.Text = "0";
#if VS2005
            this.button14.UseVisualStyleBackColor = true;
#endif
            this.button14.Click += new System.EventHandler(this.button17_Click);
            // 
            // button15
            // 
            this.button15.ForeColor = System.Drawing.Color.Blue;
            this.button15.Location = new System.Drawing.Point(75, 90);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(30, 23);
            this.button15.TabIndex = 14;
            this.button15.Text = ".";
#if VS2005
            this.button15.UseVisualStyleBackColor = true;
#endif
            this.button15.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button16.ForeColor = System.Drawing.Color.Red;
            this.button16.Location = new System.Drawing.Point(111, 90);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(30, 23);
            this.button16.TabIndex = 15;
            this.button16.Text = "/";
#if VS2005
            this.button16.UseVisualStyleBackColor = true;
#endif
            this.button16.Click += new System.EventHandler(this.button17_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button17.ForeColor = System.Drawing.Color.Blue;
            this.button17.Location = new System.Drawing.Point(39, 119);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(30, 23);
            this.button17.TabIndex = 16;
            this.button17.Text = "(";
#if VS2005
            this.button17.UseVisualStyleBackColor = true;
#endif
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button18.ForeColor = System.Drawing.Color.Blue;
            this.button18.Location = new System.Drawing.Point(75, 119);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(30, 23);
            this.button18.TabIndex = 17;
            this.button18.Text = ")";
#if VS2005
            this.button18.UseVisualStyleBackColor = true;
#endif
            this.button18.Click += new System.EventHandler(this.button17_Click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button19.ForeColor = System.Drawing.Color.Red;
            this.button19.Location = new System.Drawing.Point(111, 120);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(30, 23);
            this.button19.TabIndex = 18;
            this.button19.Text = "C";
#if VS2005
            this.button19.UseVisualStyleBackColor = true;
#endif
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // CalculatorPad
            // 
#if VS2005
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
#endif
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "CalculatorPad";
            this.Size = new System.Drawing.Size(145, 146);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public TextBox TextBox
        {
            get { return tbox; }
            set
            {
                tbox = value;
            }
        }

         

        private void button17_Click(object sender, EventArgs e)
        {
            string text = (sender as Button).Text;
            if (TextBox != null)
            {
                int caretpos = TextBox.SelectionStart;
                text = " " + text + " ";
                TextBox.Text = TextBox.Text.Insert(caretpos,text);
                TextBox.SelectionStart = caretpos + text.Length;
                if (TextBox.CanFocus) TextBox.Focus();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (TextBox != null)
            {

                if (MessageBox.Show("Delete expression ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    TextBox.Clear();
            }
        }
    }
}
