using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Units;
using Dew.Math.Editors;
using System.Globalization;


namespace MtxVecDemo
{
	public class MtxOptimForm : MtxVecDemo.BasicForm2
	{
		private System.Windows.Forms.CheckBox checkBoxLog;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TrackBar trackBarIter;
		private System.Windows.Forms.Label labelIter;
		private System.Windows.Forms.Label labelTol;
		private System.Windows.Forms.TrackBar trackBarTol;
		private System.Windows.Forms.TrackBar trackBarGradTol;
		private System.Windows.Forms.Label labelGradTol;
		private System.Windows.Forms.TrackBar trackBarInitLambda;
		private System.Windows.Forms.Label labelInitLambda;
		private System.Windows.Forms.Label labelGradStep;
		private System.Windows.Forms.TrackBar trackBarGradStep;
		private System.Windows.Forms.TrackBar trackBarA;
		private System.Windows.Forms.Label labelA;
		private System.Windows.Forms.Label labelB;
		private System.Windows.Forms.TrackBar trackBarB;
		private System.Windows.Forms.CheckBox checkBoxDeriv;
		private System.ComponentModel.IContainer components = null;

		public MtxOptimForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

            mtxOptimization = new TMtxOptimization() ;

            log = new Dew.Math.TStringList();
			gradBananaDelegate = new TGrad(gradBanana);
			gradHessBananaDelegate = new TGradHess(gradHessBanana);
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
            if (mtxOptimization!=null) mtxOptimization.Dispose();
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.checkBoxLog = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarIter = new System.Windows.Forms.TrackBar();
            this.labelIter = new System.Windows.Forms.Label();
            this.labelTol = new System.Windows.Forms.Label();
            this.trackBarTol = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarGradTol = new System.Windows.Forms.TrackBar();
            this.labelGradTol = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBarInitLambda = new System.Windows.Forms.TrackBar();
            this.labelInitLambda = new System.Windows.Forms.Label();
            this.labelGradStep = new System.Windows.Forms.Label();
            this.trackBarGradStep = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.trackBarA = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.checkBoxDeriv = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGradTol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInitLambda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGradStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.checkBoxDeriv);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.labelA);
            this.panel2.Controls.Add(this.labelIter);
            this.panel2.Controls.Add(this.trackBarIter);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.checkBoxLog);
            this.panel2.Controls.Add(this.labelTol);
            this.panel2.Controls.Add(this.trackBarTol);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.trackBarGradTol);
            this.panel2.Controls.Add(this.labelGradTol);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.trackBarInitLambda);
            this.panel2.Controls.Add(this.labelInitLambda);
            this.panel2.Controls.Add(this.labelGradStep);
            this.panel2.Controls.Add(this.trackBarGradStep);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.trackBarA);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.labelB);
            this.panel2.Controls.Add(this.trackBarB);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Size = new System.Drawing.Size(797, 449);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(0, 561);
            this.panel3.Size = new System.Drawing.Size(797, 48);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(797, 112);
            // 
            // checkBoxLog
            // 
            this.checkBoxLog.Checked = true;
            this.checkBoxLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLog.Location = new System.Drawing.Point(8, 8);
            this.checkBoxLog.Name = "checkBoxLog";
            this.checkBoxLog.Size = new System.Drawing.Size(104, 16);
            this.checkBoxLog.TabIndex = 0;
            this.checkBoxLog.Text = "Log";
            this.checkBoxLog.CheckedChanged += new System.EventHandler(this.checkBoxLog_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Max number of iterations";
            // 
            // trackBarIter
            // 
            this.trackBarIter.AutoSize = false;
            this.trackBarIter.Location = new System.Drawing.Point(8, 48);
            this.trackBarIter.Maximum = 10000;
            this.trackBarIter.Minimum = 50;
            this.trackBarIter.Name = "trackBarIter";
            this.trackBarIter.Size = new System.Drawing.Size(120, 16);
            this.trackBarIter.TabIndex = 2;
            this.trackBarIter.TickFrequency = 1000;
            this.trackBarIter.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarIter.Value = 400;
            this.trackBarIter.ValueChanged += new System.EventHandler(this.trackBarIter_Scroll);
            // 
            // labelIter
            // 
            this.labelIter.Location = new System.Drawing.Point(136, 48);
            this.labelIter.Name = "labelIter";
            this.labelIter.Size = new System.Drawing.Size(40, 16);
            this.labelIter.TabIndex = 3;
            this.labelIter.Text = "0";
            // 
            // labelTol
            // 
            this.labelTol.Location = new System.Drawing.Point(136, 88);
            this.labelTol.Name = "labelTol";
            this.labelTol.Size = new System.Drawing.Size(40, 16);
            this.labelTol.TabIndex = 3;
            this.labelTol.Text = "0";
            // 
            // trackBarTol
            // 
            this.trackBarTol.AutoSize = false;
            this.trackBarTol.Location = new System.Drawing.Point(8, 88);
            this.trackBarTol.Maximum = 16;
            this.trackBarTol.Minimum = 1;
            this.trackBarTol.Name = "trackBarTol";
            this.trackBarTol.Size = new System.Drawing.Size(120, 16);
            this.trackBarTol.TabIndex = 2;
            this.trackBarTol.TickFrequency = 2;
            this.trackBarTol.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarTol.Value = 6;
            this.trackBarTol.ValueChanged += new System.EventHandler(this.trackBarTol_ValueChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tolerance";
            // 
            // trackBarGradTol
            // 
            this.trackBarGradTol.AutoSize = false;
            this.trackBarGradTol.Location = new System.Drawing.Point(8, 152);
            this.trackBarGradTol.Maximum = 16;
            this.trackBarGradTol.Minimum = 1;
            this.trackBarGradTol.Name = "trackBarGradTol";
            this.trackBarGradTol.Size = new System.Drawing.Size(120, 16);
            this.trackBarGradTol.TabIndex = 2;
            this.trackBarGradTol.TickFrequency = 2;
            this.trackBarGradTol.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarGradTol.Value = 10;
            this.trackBarGradTol.ValueChanged += new System.EventHandler(this.trackBarGradTol_ValueChanged);
            // 
            // labelGradTol
            // 
            this.labelGradTol.Location = new System.Drawing.Point(136, 152);
            this.labelGradTol.Name = "labelGradTol";
            this.labelGradTol.Size = new System.Drawing.Size(40, 16);
            this.labelGradTol.TabIndex = 3;
            this.labelGradTol.Text = "0";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Gradient tolerance";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Initial lambda";
            // 
            // trackBarInitLambda
            // 
            this.trackBarInitLambda.AutoSize = false;
            this.trackBarInitLambda.Location = new System.Drawing.Point(8, 192);
            this.trackBarInitLambda.Maximum = 9;
            this.trackBarInitLambda.Minimum = 1;
            this.trackBarInitLambda.Name = "trackBarInitLambda";
            this.trackBarInitLambda.Size = new System.Drawing.Size(120, 16);
            this.trackBarInitLambda.TabIndex = 2;
            this.trackBarInitLambda.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarInitLambda.Value = 5;
            this.trackBarInitLambda.ValueChanged += new System.EventHandler(this.trackBarInitLambda_ValueChanged);
            // 
            // labelInitLambda
            // 
            this.labelInitLambda.Location = new System.Drawing.Point(136, 192);
            this.labelInitLambda.Name = "labelInitLambda";
            this.labelInitLambda.Size = new System.Drawing.Size(40, 16);
            this.labelInitLambda.TabIndex = 3;
            this.labelInitLambda.Text = "0";
            // 
            // labelGradStep
            // 
            this.labelGradStep.Location = new System.Drawing.Point(136, 232);
            this.labelGradStep.Name = "labelGradStep";
            this.labelGradStep.Size = new System.Drawing.Size(40, 16);
            this.labelGradStep.TabIndex = 3;
            this.labelGradStep.Text = "0";
            // 
            // trackBarGradStep
            // 
            this.trackBarGradStep.AutoSize = false;
            this.trackBarGradStep.Location = new System.Drawing.Point(8, 232);
            this.trackBarGradStep.Maximum = 16;
            this.trackBarGradStep.Minimum = 1;
            this.trackBarGradStep.Name = "trackBarGradStep";
            this.trackBarGradStep.Size = new System.Drawing.Size(120, 16);
            this.trackBarGradStep.TabIndex = 2;
            this.trackBarGradStep.TickFrequency = 2;
            this.trackBarGradStep.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarGradStep.Value = 4;
            this.trackBarGradStep.ValueChanged += new System.EventHandler(this.trackBarGradStep_ValueChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(8, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Gradient step size";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(208, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Parameters - initial values";
            // 
            // trackBarA
            // 
            this.trackBarA.AutoSize = false;
            this.trackBarA.Location = new System.Drawing.Point(200, 40);
            this.trackBarA.Maximum = 100;
            this.trackBarA.Minimum = -100;
            this.trackBarA.Name = "trackBarA";
            this.trackBarA.Size = new System.Drawing.Size(120, 16);
            this.trackBarA.TabIndex = 2;
            this.trackBarA.TickFrequency = 10;
            this.trackBarA.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarA.ValueChanged += new System.EventHandler(this.trackBarA_ValueChanged);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(184, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "a";
            // 
            // labelA
            // 
            this.labelA.Location = new System.Drawing.Point(320, 48);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(56, 16);
            this.labelA.TabIndex = 4;
            this.labelA.Text = "0,00";
            // 
            // labelB
            // 
            this.labelB.Location = new System.Drawing.Point(320, 72);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(56, 16);
            this.labelB.TabIndex = 4;
            this.labelB.Text = "0,00";
            // 
            // trackBarB
            // 
            this.trackBarB.AutoSize = false;
            this.trackBarB.Location = new System.Drawing.Point(200, 64);
            this.trackBarB.Maximum = 100;
            this.trackBarB.Minimum = -100;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(120, 16);
            this.trackBarB.TabIndex = 2;
            this.trackBarB.TickFrequency = 10;
            this.trackBarB.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarB.ValueChanged += new System.EventHandler(this.trackBarB_ValueChanged);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(184, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "b";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Location = new System.Drawing.Point(376, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 120);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Method";
            // 
            // radioButton1
            // 
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Location = new System.Drawing.Point(8, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(152, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Nelder-Mead (Simplex)";
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.Checked = true;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton2.Location = new System.Drawing.Point(8, 32);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(152, 16);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Levenberg-Marquardt";
            this.radioButton2.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton3.Location = new System.Drawing.Point(8, 48);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(152, 16);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.Text = "Quasi-Newton (BFGS)";
            this.radioButton3.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton4.Location = new System.Drawing.Point(8, 64);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(152, 16);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.Text = "Quasi-Newton (DFP)";
            this.radioButton4.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton5.Location = new System.Drawing.Point(8, 80);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(176, 16);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.Text = "Conjugate Gradient (Fletcher)";
            this.radioButton5.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton6.Location = new System.Drawing.Point(8, 96);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(168, 16);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.Text = "Conjugate Gradient (Polak)";
            this.radioButton6.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // checkBoxDeriv
            // 
            this.checkBoxDeriv.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxDeriv.Location = new System.Drawing.Point(200, 134);
            this.checkBoxDeriv.Name = "checkBoxDeriv";
            this.checkBoxDeriv.Size = new System.Drawing.Size(273, 16);
            this.checkBoxDeriv.TabIndex = 6;
            this.checkBoxDeriv.Text = "Numerical approximation for grad and Hess";
            this.checkBoxDeriv.CheckedChanged += new System.EventHandler(this.checkBoxDeriv_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(184, 160);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(605, 284);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(16, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Find minimum";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(120, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show Hessian mtx";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MtxOptimForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(797, 609);
            this.Name = "MtxOptimForm";
            this.Load += new System.EventHandler(this.MtxOptimForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGradTol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInitLambda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGradStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion


		private TMtxOptimization mtxOptimization;
        private Dew.Math.TStringList log;

		private double banana(TVec Parameters, TVec Constants, params object[] ObjConst) 

		{
		      return 100 * Math.Pow(Parameters[1] - Math.Pow(Parameters[0], 2), 2) + Math.Pow(1 - Parameters[0], 2);
		}

		private void MtxOptimForm_Load(object sender, System.EventArgs e) 
		{
			Add("Optimization unit offers you several algorithms for "
				+ "finding the minimum of a function of several variables. "
				+ "TMtxOptimization component offers the same functionality as Optimization " 
				+ "routines but simplifies the user interface. "
				+ "In this example the algorithms are tested against the "
				+ "\"banana\" function:");
			Add("");
			richTextBox1.SelectionFont = new Font(
				richTextBox1.SelectionFont.Name,
				richTextBox1.SelectionFont.Size,
				FontStyle.Italic);
			Add("f(a,b) = 100*Sqr(b-Sqr(a)) + Sqr(1-a)");
			Add("");
			richTextBox1.SelectionFont = new Font(
				richTextBox1.SelectionFont.Name,
				richTextBox1.SelectionFont.Size,
				FontStyle.Underline);
			Add("Parameters in this demo:");
			Add("Method:\toptimization method used");
			Add("Log:\twrite every optimization step to log");
			Add("Numerical derivative:\tuse numerical approximation of grad and Hess");
			Add("Max. number of iter.:\tmaximum number of iterations");
			Add("GradTolerance:\tminimum gradient C-Norm");
			Add("Initial lambda:\tinitial lambda used in Marquardt method");
			Add("a,b:\tinitial values for \"banana\" function parameters");
			Add("");
			Add("The Quasi-Newton (BFGS, DFP), Marquardt and Conjugate Gradient "
				+ "(Fletcher and Polak algorithm) require exact or numerical "
				+ "gradient/Hessian matrix. On the other hand, Simplex "
				+ "algorithm does not require gradient nor Hessian matrix.");

			mtxOptimization.RealFunction += new TRealFunction(banana);
			mtxOptimization.VariableParameters.Length = 2;
			radioButton1_Click(null,null);
			trackBarIter_Scroll(null,null);
			trackBarTol_ValueChanged(null,null);
			trackBarGradTol_ValueChanged(null,null);
			trackBarInitLambda_ValueChanged(null,null);
			trackBarGradStep_ValueChanged(null,null);
			trackBarA_ValueChanged(null,null);
			trackBarB_ValueChanged(null,null);
			checkBoxLog_CheckedChanged(null,null);
			checkBoxDeriv_CheckedChanged(null,null);
		}

		private void checkBoxLog_CheckedChanged(object sender, System.EventArgs e) 
		{
			if (checkBoxLog.Checked) mtxOptimization.Verbose = log;
			else mtxOptimization.Verbose = null;
		}

		private void radioButton1_Click(object sender, System.EventArgs e) 
		{
			if (radioButton1.Checked) mtxOptimization.OptimizationMethod = TOptMethod.optSimplex;
			else if (radioButton2.Checked) mtxOptimization.OptimizationMethod = TOptMethod.optMarquardt;
			else if (radioButton3.Checked) mtxOptimization.OptimizationMethod = TOptMethod.optBFGS;
			else if (radioButton4.Checked) mtxOptimization.OptimizationMethod = TOptMethod.optDFP;
			else if (radioButton5.Checked) mtxOptimization.OptimizationMethod = TOptMethod.optConjGradFR;
			else if (radioButton6.Checked) mtxOptimization.OptimizationMethod = TOptMethod.optConjGradPR;
		}

		private void trackBarIter_Scroll(object sender, System.EventArgs e) 
		{
			mtxOptimization.MaxIterations = trackBarIter.Value;
			labelIter.Text = mtxOptimization.MaxIterations.ToString();
		}

		private void trackBarTol_ValueChanged(object sender, System.EventArgs e) 
		{
			mtxOptimization.Tolerance = Math387.IntPower(10,-trackBarTol.Value);
			labelTol.Text = mtxOptimization.Tolerance.ToString("0E+00");
		}

		private void trackBarGradTol_ValueChanged(object sender, System.EventArgs e) 
		{
			mtxOptimization.GradTolerance = Math387.IntPower(10,-trackBarGradTol.Value);
			labelGradTol.Text = mtxOptimization.GradTolerance.ToString("0E+00");
		}

		private void trackBarInitLambda_ValueChanged(object sender, System.EventArgs e) 
		{
			mtxOptimization.Lambda0 = Math387.IntPower(10,-trackBarInitLambda.Value);
			labelInitLambda.Text = mtxOptimization.Lambda0.ToString("0E+00");
		}

		private void trackBarGradStep_ValueChanged(object sender, System.EventArgs e) 
		{
			Math387.GradStepSize = Math387.IntPower(10,-trackBarGradStep.Value);
            labelGradStep.Text = Math387.GradStepSize.ToString("0E+00");
		}

		private void trackBarA_ValueChanged(object sender, System.EventArgs e) 
		{
			mtxOptimization.VariableParameters[0] = trackBarA.Value * 0.02;
			labelA.Text = mtxOptimization.VariableParameters[0].ToString("0.00");
		}

		private void trackBarB_ValueChanged(object sender, System.EventArgs e) 
		{
			mtxOptimization.VariableParameters[1] = trackBarB.Value * 0.02;
			labelB.Text = mtxOptimization.VariableParameters[1].ToString("0.00");
		}

		TGrad gradBananaDelegate;
		TGradHess gradHessBananaDelegate;

		private void checkBoxDeriv_CheckedChanged(object sender, System.EventArgs e) 
		{
			mtxOptimization.SoftSearch = checkBoxDeriv.Checked;
			if (checkBoxDeriv.Checked)
			{
			
				mtxOptimization.GradProcedure -= gradBananaDelegate;
				mtxOptimization.GradHessProcedure -= gradHessBananaDelegate;
			} 
			else 
			{
				mtxOptimization.GradProcedure += gradBananaDelegate;
				mtxOptimization.GradHessProcedure +=gradHessBananaDelegate;
			}
		}

	        private void gradBanana(TRealFunction Fun, TVec Pars, TVec Consts, object[] PConsts, TVec Grad) 
		{
			Grad.Values[0] = -400*(Pars[1]-Pars[0]*Pars[0])*Pars[0]-2*(1-Pars[0]);
			Grad.Values[1] = 200*(Pars[1]-Pars[0]*Pars[0]);
		}

		private void gradHessBanana(TRealFunction Fun, TVec Pars, TVec Consts, object[] ObjConst, TVec Grad, TMtx Hess) 
		{
			Grad.Values[0] = -400*(Pars[1]-Pars[0]*Pars[0])*Pars[0]-2*(1-Pars[0]);
			Grad.Values[1] = 200*(Pars[1]-Pars[0]*Pars[0]);
			Hess.Values[0,0] = -400*Pars[1]+1200*Pars[0]*Pars[0]+2;
			Hess.Values[0,1] = -400*Pars[0];
			Hess.Values[1,0] = -400*Pars[0];
			Hess.Values[1,1] = 200;
		}


        private void button1_Click(object sender, System.EventArgs e)
        {
            trackBarA_ValueChanged(null, null);
            trackBarB_ValueChanged(null, null);
            log.Clear();
            mtxOptimization.Recalculate();
            log.Add("----------------------------");
            NumberFormatInfo format = (NumberFormatInfo)CultureInfo.CurrentCulture.NumberFormat.Clone();
            format.NumberDecimalDigits = trackBarTol.Value;
            log.Add("a = " + mtxOptimization.VariableParameters[0].ToString("F", format));
            log.Add("b = " + mtxOptimization.VariableParameters[1].ToString("F", format));
            double min = mtxOptimization.MinValue;
            log.Add("F(min) = " + min.ToString("F", format));
            String tmpStr = "Stop reason : ";
            switch (mtxOptimization.StopReason)
            {
                case TOptStopReason.OptResConverged: tmpStr += "Converged"; break;
                case TOptStopReason.OptResMaxIter: tmpStr += "Iterations > Max. Iterations"; break;
                case TOptStopReason.OptResSmallStep: tmpStr += "X step < Tolerance"; break;
                case TOptStopReason.OptResZeroStep: tmpStr += "Zero x step"; break;
                case TOptStopReason.OptResSmallGrad: tmpStr += "C Norm(Grad) < gradient tolerance"; break;
                case TOptStopReason.OptResBigLambda: tmpStr += "Big Lambda"; break;
            }
            log.Add(tmpStr);
            textBox1.Text = log.Text;
        }

		private void button2_Click(object sender, System.EventArgs e) {
			MtxVecEdit.ViewValues(mtxOptimization.InverseHess,"mtxOptimization.InverseHess",true,false,false);
		}
	}
}

