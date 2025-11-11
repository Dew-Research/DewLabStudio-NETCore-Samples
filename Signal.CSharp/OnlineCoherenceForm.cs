using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Signal;
using Dew.Signal.Units;
using Dew.Signal.Tee;

namespace DSPDemo {
	public partial class OnlineCoherenceForm : Form {
		public OnlineCoherenceForm() {
			InitializeComponent();
		}

		private void OnlineCoherenceForm_Load(object sender, EventArgs e) {
			Signal1.Data.Size(2048);  // defines how much data to copy and
			// consequently also frequency resolution
			Signal1.Data.SetZero();
			Signal1.UsesInputs = false;
			Signal1.SamplingFrequency = SignalIn1.SamplingFrequency;

			Signal2.Data.Size(2048);  // defines how much data to copy and
			Signal2.UsesInputs = false;
			Signal2.SamplingFrequency = SignalIn1.SamplingFrequency;

			spectrumsBox.SelectedIndex = 0;
			CrossSpectrumAnalyzer1.Stats.Averaging = TAveraging.avExponentInf;
			CrossSpectrumAnalyzer1.Stats.ExpDecay = 20;

            CrossSpectrumAnalyzer1.ResetAveraging();

			richTextBox1.Clear();
			richTextBox1.AppendText("The cross spectral analysis is usefull when trying to determine:" + Environment.NewLine);
			richTextBox1.AppendText(Environment.NewLine);
			richTextBox1.SelectionBullet = true;
			richTextBox1.SelectionIndent = 10;
			richTextBox1.AppendText("What is the transfer function of the system." + Environment.NewLine);
			richTextBox1.AppendText("Is the system linear or not. If it is not linear, at which frequencies " +
						"is the system non-linear." + Environment.NewLine);
			richTextBox1.SelectionBullet = false;
			richTextBox1.SelectionIndent = 0;
			richTextBox1.AppendText(Environment.NewLine);
			richTextBox1.AppendText("This example shows how you can run this tests in real time. You could " +
						"connect your test signal to the left channel and microphone input to the " +
						"right channel. If your test signal would be going to the speakers, the microphone " +
						"will be recording the sound comming from them and the transfer function " +
						"would show you what is the frequency response of your audio system: " +
						"amplifier + cables + speakers + room + microphone. " + Environment.NewLine);

			SpectrumMarkTool smt = new SpectrumMarkTool(spectrumChart1.Chart);
			smt.CursorActive = true;
			smt.DoubleClickClear = true;
			smt.PeakFilterMode = false;
			smt.MarkMode = SpectrumMarkMode.mmSingle;
			smt.MarkType = SpectrumMarkType.mtAmplt;
			smt.MarkSeries = points1;
			smt.Series = fastLine1;
			smt.AmpltFormat = "0.00#";
			smt.PhaseFormat = "0.00#";
			smt.FreqFormat = "0.00#";
			smt.LabelHeaders = true;
			smt.PeakZoomBand = false;
			spectrumChart1.Tools.Add(smt);

		}

		private void spectrumsBox_SelectedIndexChanged(object sender, EventArgs e) {
			CrossSpectrumAnalyzer1.CrossAnalyzer.Transform = (TCrossTransform)spectrumsBox.SelectedIndex;

			spectrumChart1.Header.Text = SignalAnalysis.CrossTransformToString(CrossSpectrumAnalyzer1.CrossAnalyzer.Transform);
			CrossSpectrumAnalyzer1.UpdateSpectrum(); //copy the correct TCrossTransfrom to CrossAnalyzer.Amplt
			//update bands, peaks and chart, but do not perform average
		}

        private void SignalTimer1_OnTimer(object Sender, EventArgs e)
        {
            if (!SignalIn1.Active)
            {
                SignalIn1.Start();
            }
			SignalIn1.MonitorData(Signal1, Signal2);
			CrossSpectrumAnalyzer1.Pull();
		}

		private void button2_Click(object sender, EventArgs e) {
			CrossSpectrumAnalyzerDialog1.Execute();
		}

		private void CrossSpectrumAnalyzer1_OnParameterUpdate(object Sender) {
			spectrumsBox.SelectedIndex = (byte)CrossSpectrumAnalyzer1.CrossAnalyzer.Transform;
			spectrumChart1.Header.Text = SignalAnalysis.CrossTransformToString(CrossSpectrumAnalyzer1.CrossAnalyzer.Transform);
			CrossSpectrumAnalyzer1.UpdateSpectrum(); //copy the correct TCrossTransfrom to CrossAnalyzer.Amplt
			//update bands, peaks and chart, but do not perform average

		}

        private void button1_Click(object sender, EventArgs e)
        {
            chartEditor.ShowModal();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CrossSpectrumAnalyzer1.ResetAveraging();
        }

        private void spectrumChart1_Click(object sender, EventArgs e)
        {

        }


	}
}
