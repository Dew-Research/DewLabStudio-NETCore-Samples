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
	public partial class NarrowBandpassForm : Form {
		public NarrowBandpassForm() {
			InitializeComponent();
		}

		private void NarrowBandpassForm_Load(object sender, EventArgs e) {
			signalRead1.FileName = Utils.SourcePath() + @"\Data\bz.sfs";
			richTextBox1.Text = "TSignalBandpass applies a linear phase bandpass filter. " +
						"It features exceptional performance " +
						"and accuracy with up to 160dB SNR speed exceeding standard multi-rate implementations " +
						"by multiple times. The bandpass filter is specified by its left edge and bandpass width. " +
						"Both have a valid range from 0 to 0.5, but their sum may not exceed 0.5. This is a multi-rate " +
						"implementation of a bandpass filter and is most suitable for \"narrow\" bandpass filters. " +
						"Narrow bandpass filters are those whose bandpass width is much smaller than the signal bandwidth.";
			signalBandpass.SubBandWidth = floatEdit2.Position;
			signalBandpass.SubBandFrequency = floatEdit1.Position;
			signalRead1.OpenFile();
			signalRead1.RecordPosition = 0;
			signalBuffer.Reset();
			spectrumAnalyzer2.Update();

			signalBuffer.Pull();
			signalBuffer.Pull();
			signalBuffer.Pull();

			while (signalBuffer.Pull() != TPipeState.pipeEnd && signalRead1.RecordPosition < signalBandpass.FilterDelay * 2) {
				if (signalBuffer.PipeState == TPipeState.pipeEnd) break;
			}

			attBox.SelectedIndex = 0;

			positionLabel.Text = "Position: " + signalRead1.RecordPosition;
			spectrumAnalyzer1.Update();
		}

		private void NarrowBandpassForm_Resize(object sender, EventArgs e) {
			spectrumChart1.Height = panel2.Height / 2;
		}

		private void attBox_SelectedIndexChanged(object sender, EventArgs e) {
			floatEdit1_TextChanged(sender, e);
		}

		private void spectrumButton_Click(object sender, EventArgs e) {
			spectrumAnalyzerDialog1.Execute();
		}

		private void spectrumChartButton_Click(object sender, EventArgs e) {
			editor1.Show();
		}

        private void floatEdit1_TextChanged(object sender, EventArgs e)
        {
            signalBandpass.SubBandWidth = floatEdit2.Position;
            signalBandpass.SubBandFrequency = floatEdit1.Position;
            signalBandpass.Ripple = Math387.Exp10(int.Parse(attBox.Text) / -20);
            signalRead1.RecordPosition = 0;
            signalBuffer.Length = 1024;
            signalBuffer.Reset();
            spectrumAnalyzer2.Update();

            signalBuffer.Pull();
            signalBuffer.Pull();
            signalBuffer.Pull(); //this is to compensate for the delay of the signal, so that that the frequency spectrum
            //is not executed on partially zeroed out signal.
            while (signalBuffer.Pull() != TPipeState.pipeEnd && signalRead1.RecordPosition < signalBandpass.FilterDelay * 2)
            {
                if (signalBuffer.PipeState == TPipeState.pipeEnd) break;
            }

            positionLabel.Text = "Position: " + signalRead1.RecordPosition;
            filterDelayLabel.Text = "Delay: " + signalBandpass.FilterDelay.ToString("0.#");

            spectrumAnalyzer1.Update();
        }

        private void spectrumAnalyzer1_OnParameterUpdateEvent(object Sender)
        {
			spectrumAnalyzer1.Update();
			spectrumAnalyzer2.Update();
		}
    }
}
