using Dew.Math.Units;
using Dew.Math;

namespace MtxVecDemo
{
    partial class clMultiDeviceForm
    {
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
            //ClMtxVec.clPlatform().Free();
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
            components = new System.ComponentModel.Container();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            platformListBox = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            TimingsLabel = new System.Windows.Forms.Label();
            deviceListLabel = new System.Windows.Forms.Label();
            deviceListBox = new System.Windows.Forms.ListBox();
            label2 = new System.Windows.Forms.Label();
            functionBox = new System.Windows.Forms.ListBox();
            button1 = new System.Windows.Forms.Button();
            vectorLengthBox = new System.Windows.Forms.ComboBox();
            vectorLengthLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            floatPrecisionBox = new System.Windows.Forms.ComboBox();
            cpuFloatPrecisionLabel = new System.Windows.Forms.Label();
            complexBox = new System.Windows.Forms.CheckBox();
            maximumJobCountEdit = new System.Windows.Forms.ComboBox();
            currentJobCountLabel = new System.Windows.Forms.Label();
            TotalRunningTimeLabel = new System.Windows.Forms.Label();
            errorsLabel = new System.Windows.Forms.Label();
            schedulerTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            richTextBox1.Location = new System.Drawing.Point(2, 2);
            richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(986, 119);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // platformListBox
            // 
            platformListBox.FormattingEnabled = true;
            platformListBox.Location = new System.Drawing.Point(14, 145);
            platformListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            platformListBox.Name = "platformListBox";
            platformListBox.Size = new System.Drawing.Size(422, 79);
            platformListBox.TabIndex = 1;
            platformListBox.SelectedIndexChanged += platformListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 126);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 15);
            label1.TabIndex = 2;
            label1.Text = "Platform list:";
            // 
            // TimingsLabel
            // 
            TimingsLabel.AutoSize = true;
            TimingsLabel.Location = new System.Drawing.Point(461, 145);
            TimingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            TimingsLabel.Name = "TimingsLabel";
            TimingsLabel.Size = new System.Drawing.Size(119, 15);
            TimingsLabel.TabIndex = 3;
            TimingsLabel.Text = "Maximum job count:";
            // 
            // deviceListLabel
            // 
            deviceListLabel.AutoSize = true;
            deviceListLabel.Location = new System.Drawing.Point(14, 235);
            deviceListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            deviceListLabel.Name = "deviceListLabel";
            deviceListLabel.Size = new System.Drawing.Size(63, 15);
            deviceListLabel.TabIndex = 6;
            deviceListLabel.Text = "Device list:";
            // 
            // deviceListBox
            // 
            deviceListBox.FormattingEnabled = true;
            deviceListBox.Location = new System.Drawing.Point(14, 255);
            deviceListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            deviceListBox.Name = "deviceListBox";
            deviceListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            deviceListBox.Size = new System.Drawing.Size(422, 79);
            deviceListBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 353);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 15);
            label2.TabIndex = 6;
            label2.Text = "Test function list:";
            // 
            // functionBox
            // 
            functionBox.FormattingEnabled = true;
            functionBox.Items.AddRange(new object[] { "c = c * b", "a = sin(a)  + sinc(c)", "c = sqrt(4 * a * INVTWOPI) * a * sqr(x) * Exp(-0.5 * a * sqr(x))", "a = Mean(c)" });
            functionBox.Location = new System.Drawing.Point(14, 372);
            functionBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            functionBox.Name = "functionBox";
            functionBox.Size = new System.Drawing.Size(422, 154);
            functionBox.TabIndex = 7;
            functionBox.SelectedIndexChanged += functionBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(742, 537);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(103, 30);
            button1.TabIndex = 9;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // vectorLengthBox
            // 
            vectorLengthBox.FormattingEnabled = true;
            vectorLengthBox.Items.AddRange(new object[] { "4096", "16384", "32768", "131072", "262144", "524288", "1048576" });
            vectorLengthBox.Location = new System.Drawing.Point(178, 535);
            vectorLengthBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            vectorLengthBox.Name = "vectorLengthBox";
            vectorLengthBox.Size = new System.Drawing.Size(208, 23);
            vectorLengthBox.TabIndex = 10;
            // 
            // vectorLengthLabel
            // 
            vectorLengthLabel.AutoSize = true;
            vectorLengthLabel.Location = new System.Drawing.Point(14, 537);
            vectorLengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            vectorLengthLabel.Name = "vectorLengthLabel";
            vectorLengthLabel.Size = new System.Drawing.Size(80, 15);
            vectorLengthLabel.TabIndex = 11;
            vectorLengthLabel.Text = "Vector length:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(14, 570);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(134, 15);
            label3.TabIndex = 12;
            label3.Text = "Open CL float precision:";
            // 
            // floatPrecisionBox
            // 
            floatPrecisionBox.FormattingEnabled = true;
            floatPrecisionBox.Items.AddRange(new object[] { "32bit single precision", "64bit double precision" });
            floatPrecisionBox.Location = new System.Drawing.Point(178, 567);
            floatPrecisionBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            floatPrecisionBox.Name = "floatPrecisionBox";
            floatPrecisionBox.Size = new System.Drawing.Size(208, 23);
            floatPrecisionBox.TabIndex = 13;
            floatPrecisionBox.SelectedIndexChanged += floatPrecisionBox_SelectedIndexChanged;
            // 
            // cpuFloatPrecisionLabel
            // 
            cpuFloatPrecisionLabel.AutoSize = true;
            cpuFloatPrecisionLabel.Location = new System.Drawing.Point(14, 601);
            cpuFloatPrecisionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cpuFloatPrecisionLabel.Name = "cpuFloatPrecisionLabel";
            cpuFloatPrecisionLabel.Size = new System.Drawing.Size(190, 15);
            cpuFloatPrecisionLabel.TabIndex = 14;
            cpuFloatPrecisionLabel.Text = "CPU (MtxVec) float precision: 64bit";
            // 
            // complexBox
            // 
            complexBox.AutoSize = true;
            complexBox.Location = new System.Drawing.Point(394, 538);
            complexBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            complexBox.Name = "complexBox";
            complexBox.Size = new System.Drawing.Size(74, 19);
            complexBox.TabIndex = 15;
            complexBox.Text = "Complex";
            complexBox.UseVisualStyleBackColor = true;
            complexBox.CheckedChanged += complexBox_CheckedChanged;
            // 
            // maximumJobCountEdit
            // 
            maximumJobCountEdit.FormattingEnabled = true;
            maximumJobCountEdit.Items.AddRange(new object[] { "2", "4", "6", "8", "16", "32", "64", "128", "256", "512", "1024", "2048", "4096", "8192", "16384" });
            maximumJobCountEdit.Location = new System.Drawing.Point(586, 142);
            maximumJobCountEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            maximumJobCountEdit.MaxDropDownItems = 12;
            maximumJobCountEdit.Name = "maximumJobCountEdit";
            maximumJobCountEdit.Size = new System.Drawing.Size(179, 23);
            maximumJobCountEdit.TabIndex = 16;
            // 
            // currentJobCountLabel
            // 
            currentJobCountLabel.AutoSize = true;
            currentJobCountLabel.Location = new System.Drawing.Point(461, 185);
            currentJobCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            currentJobCountLabel.Name = "currentJobCountLabel";
            currentJobCountLabel.Size = new System.Drawing.Size(104, 15);
            currentJobCountLabel.TabIndex = 17;
            currentJobCountLabel.Text = "Current job count:";
            // 
            // TotalRunningTimeLabel
            // 
            TotalRunningTimeLabel.AutoSize = true;
            TotalRunningTimeLabel.Location = new System.Drawing.Point(461, 225);
            TotalRunningTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            TotalRunningTimeLabel.Name = "TotalRunningTimeLabel";
            TotalRunningTimeLabel.Size = new System.Drawing.Size(107, 15);
            TotalRunningTimeLabel.TabIndex = 18;
            TotalRunningTimeLabel.Text = "Total running time:";
            // 
            // errorsLabel
            // 
            errorsLabel.AutoSize = true;
            errorsLabel.Location = new System.Drawing.Point(461, 255);
            errorsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            errorsLabel.Name = "errorsLabel";
            errorsLabel.Size = new System.Drawing.Size(70, 15);
            errorsLabel.TabIndex = 19;
            errorsLabel.Text = "Errors: none";
            // 
            // schedulerTimer
            // 
            schedulerTimer.Tick += SchedulerTimer_Tick;
            // 
            // clMultiDeviceForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(991, 643);
            Controls.Add(errorsLabel);
            Controls.Add(TotalRunningTimeLabel);
            Controls.Add(currentJobCountLabel);
            Controls.Add(maximumJobCountEdit);
            Controls.Add(complexBox);
            Controls.Add(cpuFloatPrecisionLabel);
            Controls.Add(floatPrecisionBox);
            Controls.Add(label3);
            Controls.Add(vectorLengthLabel);
            Controls.Add(vectorLengthBox);
            Controls.Add(button1);
            Controls.Add(functionBox);
            Controls.Add(label2);
            Controls.Add(deviceListLabel);
            Controls.Add(deviceListBox);
            Controls.Add(TimingsLabel);
            Controls.Add(label1);
            Controls.Add(platformListBox);
            Controls.Add(richTextBox1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "clMultiDeviceForm";
            Text = "Multi-device benchmark";
            Load += clBenchmarkForm_Load;
            Shown += clMultiDeviceForm_Shown;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox platformListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimingsLabel;
        private System.Windows.Forms.Label deviceListLabel;
        private System.Windows.Forms.ListBox deviceListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox functionBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox vectorLengthBox;
        private System.Windows.Forms.Label vectorLengthLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox floatPrecisionBox;
        private System.Windows.Forms.Label cpuFloatPrecisionLabel;
        private System.Windows.Forms.CheckBox complexBox;
        private System.Windows.Forms.ComboBox maximumJobCountEdit;
        private System.Windows.Forms.Label currentJobCountLabel;
        private System.Windows.Forms.Label TotalRunningTimeLabel;
        private System.Windows.Forms.Label errorsLabel;
        private System.Windows.Forms.Timer schedulerTimer;
    }
}