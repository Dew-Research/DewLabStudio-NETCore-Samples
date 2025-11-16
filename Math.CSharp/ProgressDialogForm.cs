using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Units;

namespace MtxVecDemo
{
	public class ProgressDialogForm : MtxVecDemo.BasicForm2
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton InternalLoopButton;
		private System.Windows.Forms.RadioButton ExternalLoopButton;
		private System.Windows.Forms.RadioButton InProcedureButton;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton ForLoopButton;
		private System.Windows.Forms.RadioButton WhileLoopButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
        private Dew.Math.Controls.TMtxProgressDialog progressDialog1;
		private System.ComponentModel.IContainer components = null;

		public ProgressDialogForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			progressDialog1.DefineLoop(0,1500);
            progressDialog1.InfiniteLoop = true;
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
            if (progressDialog1 != null) progressDialog1.Stop();
			base.Dispose( disposing );
		}

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            InternalLoopButton = new RadioButton();
            ExternalLoopButton = new RadioButton();
            InProcedureButton = new RadioButton();
            groupBox2 = new GroupBox();
            ForLoopButton = new RadioButton();
            WhileLoopButton = new RadioButton();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            checkBox1 = new CheckBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            groupBox3 = new GroupBox();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            progressDialog1 = new Dew.Math.Controls.TMtxProgressDialog();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((ISupportInitialize)numericUpDown1).BeginInit();
            groupBox3.SuspendLayout();
            ((ISupportInitialize)numericUpDown3).BeginInit();
            ((ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(progressBar1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Size = new Size(998, 416);
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 554);
            panel3.Size = new Size(998, 59);
            // 
            // richTextBox1
            // 
            richTextBox1.Size = new Size(998, 138);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(InternalLoopButton);
            groupBox1.Controls.Add(ExternalLoopButton);
            groupBox1.Controls.Add(InProcedureButton);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Location = new Point(14, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(144, 102);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Iterator control";
            // 
            // InternalLoopButton
            // 
            InternalLoopButton.Checked = true;
            InternalLoopButton.FlatStyle = FlatStyle.System;
            InternalLoopButton.Location = new Point(10, 20);
            InternalLoopButton.Name = "InternalLoopButton";
            InternalLoopButton.Size = new Size(124, 19);
            InternalLoopButton.TabIndex = 0;
            InternalLoopButton.TabStop = true;
            InternalLoopButton.Text = "Internal loop";
            InternalLoopButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // ExternalLoopButton
            // 
            ExternalLoopButton.FlatStyle = FlatStyle.System;
            ExternalLoopButton.Location = new Point(10, 47);
            ExternalLoopButton.Name = "ExternalLoopButton";
            ExternalLoopButton.Size = new Size(124, 19);
            ExternalLoopButton.TabIndex = 0;
            ExternalLoopButton.Text = "External loop";
            ExternalLoopButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // InProcedureButton
            // 
            InProcedureButton.FlatStyle = FlatStyle.System;
            InProcedureButton.Location = new Point(10, 75);
            InProcedureButton.Name = "InProcedureButton";
            InProcedureButton.Size = new Size(124, 20);
            InProcedureButton.TabIndex = 0;
            InProcedureButton.Text = "InProcedure";
            InProcedureButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ForLoopButton);
            groupBox2.Controls.Add(WhileLoopButton);
            groupBox2.FlatStyle = FlatStyle.System;
            groupBox2.Location = new Point(178, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(144, 81);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Loop type";
            // 
            // ForLoopButton
            // 
            ForLoopButton.FlatStyle = FlatStyle.System;
            ForLoopButton.Location = new Point(12, 23);
            ForLoopButton.Name = "ForLoopButton";
            ForLoopButton.Size = new Size(125, 20);
            ForLoopButton.TabIndex = 0;
            ForLoopButton.Text = "For loop";
            ForLoopButton.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // WhileLoopButton
            // 
            WhileLoopButton.Checked = true;
            WhileLoopButton.FlatStyle = FlatStyle.System;
            WhileLoopButton.Location = new Point(12, 50);
            WhileLoopButton.Name = "WhileLoopButton";
            WhileLoopButton.Size = new Size(125, 20);
            WhileLoopButton.TabIndex = 0;
            WhileLoopButton.TabStop = true;
            WhileLoopButton.Text = "While loop";
            WhileLoopButton.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // label1
            // 
            label1.Location = new Point(359, 6);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 1;
            label1.Text = "Progress indicator";
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.ForeColor = Color.Lime;
            progressBar1.Location = new Point(362, 30);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(575, 33);
            progressBar1.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.FlatStyle = FlatStyle.System;
            checkBox1.Location = new Point(24, 129);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(240, 30);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Show progress form";
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.Location = new Point(20, 199);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 4;
            label2.Text = "Thread priority";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Items.AddRange(new object[] { "Lowest", "Below normal", "Normal", "Above normal", "Highest" });
            comboBox1.Location = new Point(234, 199);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Location = new Point(17, 251);
            label3.Name = "label3";
            label3.Size = new Size(211, 20);
            label3.TabIndex = 4;
            label3.Text = "Progress indicator update  interval";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(235, 246);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(144, 23);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.Value = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label4
            // 
            label4.Location = new Point(400, 249);
            label4.Name = "label4";
            label4.Size = new Size(48, 19);
            label4.TabIndex = 4;
            label4.Text = "ms";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(numericUpDown3);
            groupBox3.Controls.Add(numericUpDown2);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(24, 329);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(355, 88);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Loop range";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(238, 34);
            numericUpDown3.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(67, 23);
            numericUpDown3.TabIndex = 2;
            numericUpDown3.Value = new decimal(new int[] { 1500, 0, 0, 0 });
            numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(67, 37);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(67, 23);
            numericUpDown2.TabIndex = 1;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label5
            // 
            label5.Location = new Point(19, 42);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 0;
            label5.Text = "From";
            // 
            // label6
            // 
            label6.Location = new Point(187, 39);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 0;
            label6.Text = "To";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(424, 350);
            button1.Name = "button1";
            button1.Size = new Size(127, 38);
            button1.TabIndex = 8;
            button1.Text = "Start";
            button1.Click += button1_Click;
            // 
            // progressDialog1
            // 
            progressDialog1.ShowDialog = false;
            progressDialog1.ThreadName = "Test thread";
            progressDialog1.UpdateInterval = 40;
            progressDialog1.Compute += progressDialog1_Compute;
            progressDialog1.ProgressUpdate += progressDialog1_ProgressUpdate;
            // 
            // ProgressDialogForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(998, 613);
            Name = "ProgressDialogForm";
            Load += ProgressDialogForm_Load;
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((ISupportInitialize)numericUpDown1).EndInit();
            groupBox3.ResumeLayout(false);
            ((ISupportInitialize)numericUpDown3).EndInit();
            ((ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);

        }
        #endregion

        private TMtx a,b,c;

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e) 
        {
			progressDialog1.ShowDialog = checkBox1.Checked;
		}

		private void radioButton4_CheckedChanged(object sender, System.EventArgs e) 
        {
            progressDialog1.InfiniteLoop = !ForLoopButton.Checked;
		}

        private void button1_Click(object sender, System.EventArgs e) 
        {
			if (button1.Text.Equals("Start")) 
            {
				button1.Text = "Stop";
				progressDialog1.Start();
			} 
            else 
            {
                progressDialog1.Stop();
				button1.Text = "Start";
			}
			// Sequence of calls:
			//   1. Calls  MtxThread OnProgressUpdate event with peInit (non threaded)
			//   2. Calls  OnCompute once or more times depending of InternalLoop (threaded)
			//   3. Calls  MtxThread OnProgressUpdate event with peCycle in
			//      regular intervals to advance progress indicators. (non threaded)
			//   4. Calls MtxThread OnProgressUpdate event with peCleanUp to
			//      continue with the further processing of the processed data,
			//      once the the thread has finished. (non threaded)
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e) 
        {
            progressDialog1.Priority = (System.Threading.ThreadPriority)comboBox1.SelectedIndex;
		}

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e) {
			progressDialog1.UpdateInterval = (int)numericUpDown1.Value;
		}

		private void numericUpDown2_ValueChanged(object sender, System.EventArgs e) 
        {
		    progressDialog1.Min = (int)numericUpDown2.Value;
		}

		private void numericUpDown3_ValueChanged(object sender, System.EventArgs e) 
        {
			progressDialog1.Max = (int)numericUpDown3.Value;
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e) {
            progressDialog1.InternalLoop = InternalLoopButton.Checked;
		}

        private void ProgressDialogForm_Load(object sender, System.EventArgs e) {
			Add("MtxVec 1.5 introduces new ProgressDialog control. "
				+ "The ProgressDialog control greatly simplifies "
				+ "the threading of numerical algorithms and offers "
				+ "built-in support to cancel the execution of algorithms "
				+ "running in it's thread, provide information about the "
				+ "progress of the executing numerical algorithm and even "
				+ "display progress dialog showing progress indications "
				+ "updated with user defined update frequency. Control "
				+ "design does not use the Synchronize procedure to update "
				+ "progress indicators and makes the most out of the "
				+ "available CPU power.");
            comboBox1.SelectedIndex = 2;
        }

        private void whileLoopInProcedure() 
        {
            while (!(progressDialog1.Max == progressDialog1.Counter) | progressDialog1.InfiniteLoop)
            {
                if (progressDialog1.Cancel) break;
				c.Mul(a,b);
				progressDialog1.Counter++;
			}
		}

        private void progressDialog1_Compute(object sender)
        {
            if (InternalLoopButton.Checked) { c.Mul(a, b); }
            else if (ExternalLoopButton.Checked)
            {
                if (progressDialog1.InfiniteLoop)
                {
                    int i = progressDialog1.Min;
                    while (true)
                    {
                        progressDialog1.Counter = i;
                        if (progressDialog1.Cancel) break;
                        c.Mul(a, b);
                        i++;
                    }
                }
                else
                {
                    for (int i = progressDialog1.Min; i <= progressDialog1.Max; i++)
                    {
                        progressDialog1.Counter = i;
                        if (progressDialog1.Cancel) break;
                        c.Mul(a, b);
                    }
                }
            }
            else if (InProcedureButton.Checked)
            {
                whileLoopInProcedure();
            }
        }

        private void progressDialog1_ProgressUpdate(object sender, Dew.Math.TMtxProgressEvent e)
        {
            switch (e)
            {
                case Dew.Math.TMtxProgressEvent.peInit :
                    {
                        progressDialog1.DefineProgressBar(progressBar1);
                        MtxVec.CreateIt(out a, out b, out c);
                        a.Size(300, 300);
                        a.RandGauss();
                        b.Copy(a);
                    };
                    break;
                case Dew.Math.TMtxProgressEvent.peCycle:
                    {
                        progressBar1.Value = (progressDialog1.Counter - progressDialog1.Min) % (progressDialog1.Max - progressDialog1.Min);
                        label1.Text = "Progress indicator : " +
                        (progressDialog1.Counter * 100 / progressDialog1.Max).ToString() + " %";
                    }; 
                    break;
                case Dew.Math.TMtxProgressEvent.peCleanUp:
                    {
                        if (!progressDialog1.Cancel)
                        {
                            progressBar1.Value = progressDialog1.Max;
                            label1.Text = "Progress indicator : 100 %";
                        }
                        MtxVec.FreeIt(ref a, ref b, ref c);
                        button1.Text = "Start";                      
                    };
                    break;
                
            }
        }
	}
}


