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
            checkBoxLog = new CheckBox();
            label1 = new Label();
            trackBarIter = new TrackBar();
            labelIter = new Label();
            labelTol = new Label();
            trackBarTol = new TrackBar();
            label4 = new Label();
            trackBarGradTol = new TrackBar();
            labelGradTol = new Label();
            label6 = new Label();
            label7 = new Label();
            trackBarInitLambda = new TrackBar();
            labelInitLambda = new Label();
            labelGradStep = new Label();
            trackBarGradStep = new TrackBar();
            label10 = new Label();
            label11 = new Label();
            trackBarA = new TrackBar();
            label12 = new Label();
            labelA = new Label();
            labelB = new Label();
            trackBarB = new TrackBar();
            label15 = new Label();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            checkBoxDeriv = new CheckBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((ISupportInitialize)trackBarIter).BeginInit();
            ((ISupportInitialize)trackBarTol).BeginInit();
            ((ISupportInitialize)trackBarGradTol).BeginInit();
            ((ISupportInitialize)trackBarInitLambda).BeginInit();
            ((ISupportInitialize)trackBarGradStep).BeginInit();
            ((ISupportInitialize)trackBarA).BeginInit();
            ((ISupportInitialize)trackBarB).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(checkBoxDeriv);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(labelA);
            panel2.Controls.Add(labelIter);
            panel2.Controls.Add(trackBarIter);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(checkBoxLog);
            panel2.Controls.Add(labelTol);
            panel2.Controls.Add(trackBarTol);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(trackBarGradTol);
            panel2.Controls.Add(labelGradTol);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(trackBarInitLambda);
            panel2.Controls.Add(labelInitLambda);
            panel2.Controls.Add(labelGradStep);
            panel2.Controls.Add(trackBarGradStep);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(trackBarA);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(labelB);
            panel2.Controls.Add(trackBarB);
            panel2.Controls.Add(label15);
            panel2.Size = new Size(880, 425);
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(0, 563);
            panel3.Size = new Size(880, 60);
            // 
            // richTextBox1
            // 
            richTextBox1.Size = new Size(880, 138);
            // 
            // checkBoxLog
            // 
            checkBoxLog.Checked = true;
            checkBoxLog.CheckState = CheckState.Checked;
            checkBoxLog.Location = new Point(10, 10);
            checkBoxLog.Name = "checkBoxLog";
            checkBoxLog.Size = new Size(124, 20);
            checkBoxLog.TabIndex = 0;
            checkBoxLog.Text = "Log";
            checkBoxLog.CheckedChanged += checkBoxLog_CheckedChanged;
            // 
            // label1
            // 
            label1.Location = new Point(10, 39);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 1;
            label1.Text = "Max number of iterations";
            // 
            // trackBarIter
            // 
            trackBarIter.AutoSize = false;
            trackBarIter.Location = new Point(10, 59);
            trackBarIter.Maximum = 10000;
            trackBarIter.Minimum = 50;
            trackBarIter.Name = "trackBarIter";
            trackBarIter.Size = new Size(144, 20);
            trackBarIter.TabIndex = 2;
            trackBarIter.TickFrequency = 1000;
            trackBarIter.TickStyle = TickStyle.TopLeft;
            trackBarIter.Value = 400;
            trackBarIter.ValueChanged += trackBarIter_Scroll;
            // 
            // labelIter
            // 
            labelIter.Location = new Point(163, 59);
            labelIter.Name = "labelIter";
            labelIter.Size = new Size(48, 20);
            labelIter.TabIndex = 3;
            labelIter.Text = "0";
            // 
            // labelTol
            // 
            labelTol.Location = new Point(163, 108);
            labelTol.Name = "labelTol";
            labelTol.Size = new Size(48, 20);
            labelTol.TabIndex = 3;
            labelTol.Text = "0";
            // 
            // trackBarTol
            // 
            trackBarTol.AutoSize = false;
            trackBarTol.Location = new Point(10, 108);
            trackBarTol.Maximum = 16;
            trackBarTol.Minimum = 1;
            trackBarTol.Name = "trackBarTol";
            trackBarTol.Size = new Size(144, 20);
            trackBarTol.TabIndex = 2;
            trackBarTol.TickFrequency = 2;
            trackBarTol.TickStyle = TickStyle.TopLeft;
            trackBarTol.Value = 6;
            trackBarTol.ValueChanged += trackBarTol_ValueChanged;
            // 
            // label4
            // 
            label4.Location = new Point(10, 89);
            label4.Name = "label4";
            label4.Size = new Size(163, 19);
            label4.TabIndex = 1;
            label4.Text = "Tolerance";
            // 
            // trackBarGradTol
            // 
            trackBarGradTol.AutoSize = false;
            trackBarGradTol.Location = new Point(10, 187);
            trackBarGradTol.Maximum = 16;
            trackBarGradTol.Minimum = 1;
            trackBarGradTol.Name = "trackBarGradTol";
            trackBarGradTol.Size = new Size(144, 20);
            trackBarGradTol.TabIndex = 2;
            trackBarGradTol.TickFrequency = 2;
            trackBarGradTol.TickStyle = TickStyle.TopLeft;
            trackBarGradTol.Value = 10;
            trackBarGradTol.ValueChanged += trackBarGradTol_ValueChanged;
            // 
            // labelGradTol
            // 
            labelGradTol.Location = new Point(163, 187);
            labelGradTol.Name = "labelGradTol";
            labelGradTol.Size = new Size(48, 20);
            labelGradTol.TabIndex = 3;
            labelGradTol.Text = "0";
            // 
            // label6
            // 
            label6.Location = new Point(10, 167);
            label6.Name = "label6";
            label6.Size = new Size(163, 20);
            label6.TabIndex = 1;
            label6.Text = "Gradient tolerance";
            // 
            // label7
            // 
            label7.Location = new Point(10, 217);
            label7.Name = "label7";
            label7.Size = new Size(163, 19);
            label7.TabIndex = 1;
            label7.Text = "Initial lambda";
            // 
            // trackBarInitLambda
            // 
            trackBarInitLambda.AutoSize = false;
            trackBarInitLambda.Location = new Point(10, 236);
            trackBarInitLambda.Maximum = 9;
            trackBarInitLambda.Minimum = 1;
            trackBarInitLambda.Name = "trackBarInitLambda";
            trackBarInitLambda.Size = new Size(144, 20);
            trackBarInitLambda.TabIndex = 2;
            trackBarInitLambda.TickStyle = TickStyle.TopLeft;
            trackBarInitLambda.Value = 5;
            trackBarInitLambda.ValueChanged += trackBarInitLambda_ValueChanged;
            // 
            // labelInitLambda
            // 
            labelInitLambda.Location = new Point(163, 236);
            labelInitLambda.Name = "labelInitLambda";
            labelInitLambda.Size = new Size(48, 20);
            labelInitLambda.TabIndex = 3;
            labelInitLambda.Text = "0";
            // 
            // labelGradStep
            // 
            labelGradStep.Location = new Point(163, 286);
            labelGradStep.Name = "labelGradStep";
            labelGradStep.Size = new Size(48, 19);
            labelGradStep.TabIndex = 3;
            labelGradStep.Text = "0";
            // 
            // trackBarGradStep
            // 
            trackBarGradStep.AutoSize = false;
            trackBarGradStep.Location = new Point(10, 286);
            trackBarGradStep.Maximum = 16;
            trackBarGradStep.Minimum = 1;
            trackBarGradStep.Name = "trackBarGradStep";
            trackBarGradStep.Size = new Size(144, 19);
            trackBarGradStep.TabIndex = 2;
            trackBarGradStep.TickFrequency = 2;
            trackBarGradStep.TickStyle = TickStyle.TopLeft;
            trackBarGradStep.Value = 4;
            trackBarGradStep.ValueChanged += trackBarGradStep_ValueChanged;
            // 
            // label10
            // 
            label10.Location = new Point(10, 266);
            label10.Name = "label10";
            label10.Size = new Size(163, 20);
            label10.TabIndex = 1;
            label10.Text = "Gradient step size";
            // 
            // label11
            // 
            label11.Location = new Point(250, 10);
            label11.Name = "label11";
            label11.Size = new Size(163, 20);
            label11.TabIndex = 1;
            label11.Text = "Parameters - initial values";
            // 
            // trackBarA
            // 
            trackBarA.AutoSize = false;
            trackBarA.Location = new Point(240, 49);
            trackBarA.Maximum = 100;
            trackBarA.Minimum = -100;
            trackBarA.Name = "trackBarA";
            trackBarA.Size = new Size(144, 20);
            trackBarA.TabIndex = 2;
            trackBarA.TickFrequency = 10;
            trackBarA.TickStyle = TickStyle.TopLeft;
            trackBarA.ValueChanged += trackBarA_ValueChanged;
            // 
            // label12
            // 
            label12.Location = new Point(221, 59);
            label12.Name = "label12";
            label12.Size = new Size(19, 20);
            label12.TabIndex = 3;
            label12.Text = "a";
            // 
            // labelA
            // 
            labelA.Location = new Point(384, 59);
            labelA.Name = "labelA";
            labelA.Size = new Size(67, 20);
            labelA.TabIndex = 4;
            labelA.Text = "0,00";
            // 
            // labelB
            // 
            labelB.Location = new Point(384, 89);
            labelB.Name = "labelB";
            labelB.Size = new Size(67, 19);
            labelB.TabIndex = 4;
            labelB.Text = "0,00";
            // 
            // trackBarB
            // 
            trackBarB.AutoSize = false;
            trackBarB.Location = new Point(240, 79);
            trackBarB.Maximum = 100;
            trackBarB.Minimum = -100;
            trackBarB.Name = "trackBarB";
            trackBarB.Size = new Size(144, 19);
            trackBarB.TabIndex = 2;
            trackBarB.TickFrequency = 10;
            trackBarB.TickStyle = TickStyle.TopLeft;
            trackBarB.ValueChanged += trackBarB_ValueChanged;
            // 
            // label15
            // 
            label15.Location = new Point(221, 89);
            label15.Name = "label15";
            label15.Size = new Size(19, 19);
            label15.TabIndex = 3;
            label15.Text = "b";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Location = new Point(451, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(231, 148);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Method";
            // 
            // radioButton1
            // 
            radioButton1.FlatStyle = FlatStyle.System;
            radioButton1.Location = new Point(10, 20);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(182, 19);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "Nelder-Mead (Simplex)";
            radioButton1.Click += radioButton1_Click;
            // 
            // radioButton2
            // 
            radioButton2.Checked = true;
            radioButton2.FlatStyle = FlatStyle.System;
            radioButton2.Location = new Point(10, 39);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(182, 20);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "Levenberg-Marquardt";
            radioButton2.Click += radioButton1_Click;
            // 
            // radioButton3
            // 
            radioButton3.FlatStyle = FlatStyle.System;
            radioButton3.Location = new Point(10, 59);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(182, 20);
            radioButton3.TabIndex = 0;
            radioButton3.Text = "Quasi-Newton (BFGS)";
            radioButton3.Click += radioButton1_Click;
            // 
            // radioButton4
            // 
            radioButton4.FlatStyle = FlatStyle.System;
            radioButton4.Location = new Point(10, 79);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(182, 19);
            radioButton4.TabIndex = 0;
            radioButton4.Text = "Quasi-Newton (DFP)";
            radioButton4.Click += radioButton1_Click;
            // 
            // radioButton5
            // 
            radioButton5.FlatStyle = FlatStyle.System;
            radioButton5.Location = new Point(10, 98);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(211, 20);
            radioButton5.TabIndex = 0;
            radioButton5.Text = "Conjugate Gradient (Fletcher)";
            radioButton5.Click += radioButton1_Click;
            // 
            // radioButton6
            // 
            radioButton6.FlatStyle = FlatStyle.System;
            radioButton6.Location = new Point(10, 118);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(201, 20);
            radioButton6.TabIndex = 0;
            radioButton6.Text = "Conjugate Gradient (Polak)";
            radioButton6.Click += radioButton1_Click;
            // 
            // checkBoxDeriv
            // 
            checkBoxDeriv.FlatStyle = FlatStyle.System;
            checkBoxDeriv.Location = new Point(240, 165);
            checkBoxDeriv.Name = "checkBoxDeriv";
            checkBoxDeriv.Size = new Size(328, 20);
            checkBoxDeriv.TabIndex = 6;
            checkBoxDeriv.Text = "Numerical approximation for grad and Hess";
            checkBoxDeriv.CheckedChanged += checkBoxDeriv_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(221, 197);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(650, 222);
            textBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(19, 20);
            button1.Name = "button1";
            button1.Size = new Size(106, 28);
            button1.TabIndex = 0;
            button1.Text = "Find minimum";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(144, 20);
            button2.Name = "button2";
            button2.Size = new Size(144, 28);
            button2.TabIndex = 1;
            button2.Text = "Show Hessian mtx";
            button2.Click += button2_Click;
            // 
            // MtxOptimForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(880, 623);
            Name = "MtxOptimForm";
            Load += MtxOptimForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((ISupportInitialize)trackBarIter).EndInit();
            ((ISupportInitialize)trackBarTol).EndInit();
            ((ISupportInitialize)trackBarGradTol).EndInit();
            ((ISupportInitialize)trackBarInitLambda).EndInit();
            ((ISupportInitialize)trackBarGradStep).EndInit();
            ((ISupportInitialize)trackBarA).EndInit();
            ((ISupportInitialize)trackBarB).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);

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

