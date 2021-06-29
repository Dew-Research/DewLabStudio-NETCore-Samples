using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Dew.Signal;
using Dew.Math.Units;
using Dew.Demo;

namespace DSPDemo {
	public partial class ModulatorForm : Form {
		public ModulatorForm() {
			InitializeComponent();
		}

		private void ModulatorForm_Load(object sender, EventArgs e) {
			signalRead1.FileName = Utils.SourcePath() + @"\Data\bz.sfs";
			richTextBox1.Text = "TSignalModulator component moves the selected bandwidth from 0Hz to any " +
						"user defined frequency. It is the reverse procedure to the zoom-spectrum " +
						"or demodulation. The linear phase modulator features exceptional performance " +
						"and accuracy with up to 160dB SNR speed exceeding standard multi-rate implementations " +
						"by multiple times. The carrier frequency can be specified as a multiple of the " +
						"sampling frequency of the original signal. The Factor parameter is used to specify " +
						"the final sampling frequency.";
			signalModulator1.Factor = floatEdit2.Position;
			signalModulator1.CarrierFrequency = floatEdit1.Position;
			signalRead1.OpenFile();
			signalRead1.RecordPosition = 0;
			signalBuffer1.Reset();
			spectrumAnalyzer2.Update();
			while (signalBuffer1.Pull() != TPipeState.pipeOK) {
			  if (signalBuffer1.PipeState == TPipeState.pipeEnd) break;
			}
			spectrumAnalyzer1.Update();
			filterDelayLabel.Text = "Delay: " + signalModulator1.FilterDelay.ToString("0.#");
			attBox.SelectedIndex = 0;
		}

		private void ModulatorForm_Resize(object sender, EventArgs e) {
			spectrumChart1.Height = panel2.Height / 2;
		}

		private void button1_Click(object sender, EventArgs e) {
			spectrumAnalyzerDialog1.Execute(); 
		}

		private void button2_Click(object sender, EventArgs e) {
			editor1.Show();
		}

        private void floatEdit1_TextChanged(object sender, EventArgs e)
        {
            signalModulator1.Factor = floatEdit2.Position;
            signalModulator1.CarrierFrequency = floatEdit1.Position;
            signalModulator1.Ripple = Math387.Exp10(Math387.StrToInt(attBox.Text) / -20);
            signalRead1.RecordPosition = 0;
            signalBuffer1.Length = Math387.LargestExp2((int)Math.Round(1024 * signalModulator1.Factor));
            signalBuffer1.Reset();
            spectrumAnalyzer2.Update();
            while (signalBuffer1.Pull() != TPipeState.pipeOK)
            {
                if (signalBuffer1.PipeState == TPipeState.pipeEnd) break;
            }
            spectrumAnalyzer1.Update();
            filterDelayLabel.Text = "Delay: " + signalModulator1.FilterDelay.ToString("0.#");
        }

        private void spectrumAnalyzer2_OnParameterUpdateEvent(object Sender)
        {
			spectrumAnalyzer1.Update();
			spectrumAnalyzer2.Update();
		}

        private void spectrumAnalyzer1_OnParameterUpdateEvent(object Sender)
        {
			spectrumAnalyzer1.Update();
			spectrumAnalyzer2.Update();
		}
    }
}
