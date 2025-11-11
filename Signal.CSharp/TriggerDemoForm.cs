using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Signal;
using Dew.Signal.Audio;
using Dew.Signal.Tee;

namespace DSPDemo {
	public partial class TriggerDemoForm : Form {
		public TriggerDemoForm() {
			InitializeComponent();


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

		private void button1_Click(object sender, EventArgs e) {
			SpectrumAnalyzerDialog1.Execute();
		}

		private void button2_Click(object sender, EventArgs e) {
			SignalIn1.ResetTriggers();
		}

		private void SpectrumAnalyzer1_OnParameterUpdate(object Sender) {
			SpectrumAnalyzer1.Update();
		}

		private void panel2_Resize(object sender, EventArgs e) {
			spectrumChart1.Height = panel2.Height / 2;
		}

        private void SignalTimer1_OnTimer(object Sender, EventArgs e)
        {
            if (!SignalIn1.Active) SignalIn1.Start();
            SignalIn1.TriggerChannel = (TChannel)(channelBox.SelectedIndex);
            SignalIn1.TriggerAbove = aboveEdit.Position;
            SignalIn1.TriggerBelow = double.NegativeInfinity;
            SignalIn1.TriggerDelay = 0;
            SignalIn1.TriggerPosition = (TriggerPosition)(positionEdit.SelectedIndex);
            SignalIn1.TriggerMode = TriggerMode.trAboveBelow;
            SignalIn1.Triggering = TriggerType.trSingle;
            if (SignalIn1.Trigger(Signal1,null)) 
            {
                SpectrumAnalyzer1.Pull();  //calls update on Signal1 and Self
                signalChart1.Header.Text = "Signal just after the sample, which triggered (Catch ups =" +
                                   SignalIn1.TriggerCatchUps[channelBox.SelectedIndex] + ")";
                countLabel.Text = "Count = " + SignalIn1.TriggerCount[channelBox.SelectedIndex];
            }

		}

		private void TriggerDemoForm_Load(object sender, EventArgs e) {
			Signal1.Data.Size(4096);  //defines how much data to copy
			Signal1.Data.SetZero();
			Signal1.UsesInputs = false;

			channelBox.SelectedIndex = 0;
			positionEdit.SelectedIndex = 0;
			Signal1.SamplingFrequency = SignalIn1.SamplingFrequency;
			richTextBox1.Text = "The recording is setup for 11025 kHz stereo. The channel displayed is always " +
					"Left, but the channel on which the trigger condition is searched for can be altered. " +
					"The best way to test this demo is to " +
					"speak in to the microphone. You can select the trigger channel, trigger " +
					"condition and which part of the signal to view relative to the trigger found. " +
					"The trigger has to be reset manually by pressing the Reset button. " +
					"The trigger can also be set to trigger automatically each time a trigger " +
					"condition is found. The trigger condition can be searched for on a different channel " +
					"from the one from which the data will be fetched. Catch-ups displayed in the title of the time signal " +
					"show how many times the samples had to be skipped (see help for more info). " +
					"There are many other options available.";
		}
	}
}
