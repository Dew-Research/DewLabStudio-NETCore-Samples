using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MtxVecDemo
{
    public class IntroParser : Form
    {
        public IntroParser()
        {
            InitializeComponent();
        }


        private void Add(String s)
        {
            richTextBox1.SelectedText = s + "\n";
        }

        private void IntroParser_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);
            Add("Math parser/function evaluator");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Support for real and complex numbers.");
            Add("Support for vectors and matrices.");
            Add("Many matrix operations are multithreaded¸.");
            Add("Most built-in vectorized functions are optimized for SSE2/SSE3.");
            Add("Performance of vectorized expression evaluation is 10 to 20x higher than classical expression parsers.");
            Add("It can solve systems of linear equations, do QR or LQ compositions.");
            Add("Operator support for per element and matrix/vector operations.");
            Add("Complete set of standard math routines (Log, Power, Sin,...)");
            Add("Very fast also when evaluating not vectorized expressions.");
            Add("Constant expressions evaluated during the parsing stage.");
            Add("You can add user defined variables, constants, functions and operators.");
            Add("Custom functions can be object methods.");
            Add("Functions can be overloaded allowing same name but different param count.");
            Add("Vectors and matrices can be accessed by elements a(i) or m(r,c).");
            Add("Function parameters and results can be string types.");
            Add("Colon operator allows selection of ranges of rows and colums m(:), m(1,:), v(2:3).");
            Add("Assign operator supports colon operator: m(2:3) = 4.");
            Add("Colon operator supports step <> 1 and allows: m(10:-1:3) = 4.");
            Add("Vectors and matrices can return elements from conditions: a = m(m > 4).");
            Add("Evaluation of a list of expressions.");
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionIndent = 0;
            Add("");
        }
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(852, 599);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // IntroParser
            // 
            this.ClientSize = new System.Drawing.Size(852, 599);
            this.Controls.Add(this.richTextBox1);
            this.Name = "IntroParser";
            this.Load += new System.EventHandler(this.IntroParser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}