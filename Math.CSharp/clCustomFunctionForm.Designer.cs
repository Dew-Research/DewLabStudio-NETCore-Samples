namespace MtxVecDemo
{
    partial class clCustomFunctionForm
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
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            platformListBox = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            deviceListLabel = new System.Windows.Forms.Label();
            deviceListBox = new System.Windows.Forms.ListBox();
            AutoDeviceButton = new System.Windows.Forms.Button();
            vectorLengthBox = new System.Windows.Forms.ComboBox();
            vectorLengthLabel = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            richTextBox1.Location = new System.Drawing.Point(2, 2);
            richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(898, 119);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // platformListBox
            // 
            platformListBox.FormattingEnabled = true;
            platformListBox.Location = new System.Drawing.Point(14, 145);
            platformListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            platformListBox.Name = "platformListBox";
            platformListBox.Size = new System.Drawing.Size(507, 79);
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
            deviceListBox.Size = new System.Drawing.Size(507, 79);
            deviceListBox.TabIndex = 5;
            // 
            // AutoDeviceButton
            // 
            AutoDeviceButton.Location = new System.Drawing.Point(544, 255);
            AutoDeviceButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            AutoDeviceButton.Name = "AutoDeviceButton";
            AutoDeviceButton.Size = new System.Drawing.Size(103, 30);
            AutoDeviceButton.TabIndex = 9;
            AutoDeviceButton.Text = "Auto select";
            AutoDeviceButton.UseVisualStyleBackColor = true;
            AutoDeviceButton.Click += AutoDeviceButton_Click;
            // 
            // vectorLengthBox
            // 
            vectorLengthBox.FormattingEnabled = true;
            vectorLengthBox.Items.AddRange(new object[] { "4096", "16384", "32768", "131072", "262144", "524288", "1048576" });
            vectorLengthBox.Location = new System.Drawing.Point(181, 363);
            vectorLengthBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            vectorLengthBox.Name = "vectorLengthBox";
            vectorLengthBox.Size = new System.Drawing.Size(176, 23);
            vectorLengthBox.TabIndex = 10;
            // 
            // vectorLengthLabel
            // 
            vectorLengthLabel.AutoSize = true;
            vectorLengthLabel.Location = new System.Drawing.Point(14, 367);
            vectorLengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            vectorLengthLabel.Name = "vectorLengthLabel";
            vectorLengthLabel.Size = new System.Drawing.Size(80, 15);
            vectorLengthLabel.TabIndex = 11;
            vectorLengthLabel.Text = "Vector length:";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(374, 358);
            button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(103, 30);
            button2.TabIndex = 12;
            button2.Text = "Run";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // clCustomFunctionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(904, 648);
            Controls.Add(button2);
            Controls.Add(vectorLengthLabel);
            Controls.Add(vectorLengthBox);
            Controls.Add(AutoDeviceButton);
            Controls.Add(deviceListLabel);
            Controls.Add(deviceListBox);
            Controls.Add(label1);
            Controls.Add(platformListBox);
            Controls.Add(richTextBox1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "clCustomFunctionForm";
            Text = "Benchmarks";
            Load += clCustomFunctionForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox platformListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label deviceListLabel;
        private System.Windows.Forms.ListBox deviceListBox;
        private System.Windows.Forms.Button AutoDeviceButton;
        private System.Windows.Forms.ComboBox vectorLengthBox;
        private System.Windows.Forms.Label vectorLengthLabel;
        private System.Windows.Forms.Button button2;
    }
}