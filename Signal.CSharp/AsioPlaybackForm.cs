using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math.Units;
using Dew.Math;
using Dew.Signal;
using Steema.TeeChart;
using Steema.TeeChart.Drawing;
using Steema.TeeChart.Styles;

namespace DSPDemo
{
	public partial class AsioPlaybackForm : Form
	{
		public AsioPlaybackForm() {
			InitializeComponent();
			// FIXME: switch to and back to get notify registered
			topChart.Signals[0].InputsItemIndex = 1;
			topChart.Signals[0].InputsItemIndex = 0;
		}

		private void AsioPlaybackForm_Load(object sender, EventArgs e) {
			driverNameListBox.Items.AddRange(signalAsio1.GetDriverList());
		}

		private void driverNameListBox_SelectedIndexChanged(object sender, EventArgs e) {
			signalAsio1.DriverIndex = driverNameListBox.SelectedIndex;
			FSListBox.Items.Clear();
			FSListBox.Items.AddRange(signalAsio1.GetSupportedSamplingFrequencies());
			clockSourcesBox.Items.Clear();
			clockSourcesBox.Items.AddRange(signalAsio1.GetClockSources());
			outputChBox.Items.Clear();
			outputChBox.Items.AddRange(signalAsio1.GetOutputChannels());
			if (FSListBox.Items.Count > 0) {
				FSListBox.SelectedIndex = 0;
				signalAsio1.SamplingFrequency = Math387.StrToSample(FSListBox.Items[0].ToString());
			} else {
				MessageBox.Show("Supported sampling frequency not found!");
			}
		}

		private void AsioPlaybackForm_Resize(object sender, EventArgs e) {
			topChart.Height = (ClientSize.Height - panel1.Height) / 2;
		}

		private void button3_Click(object sender, EventArgs e) {
			signalAsio1.ShowControlPanel();
		}

		private void startButton_Click(object sender, EventArgs e) {
			if (driverNameListBox.SelectedItems.Count < 1) Math387.ERaise("Please select a valid ASIO driver first!");
			signalAsio1.Stop();
			for (int i = 0; i < outputChBox.Items.Count; i++) {
				signalAsio1.OutputsSelected[i] = outputChBox.SelectedIndices.Contains(i);
			}
			signalRead.CloseFile();
			if (openFileDialog1.ShowDialog() == DialogResult.OK) {
				signalRead.FileName = openFileDialog1.FileName; // 'C:\TestTone20.wav';
				signalRead.OpenFile();
				if (FSListBox.SelectedItems.Count > 0) signalAsio1.SamplingFrequency = Math387.StrToSample(FSListBox.SelectedItem.ToString());
				signalAsio1.InputPrecision = TPrecision.prInteger;
				signalAsio1.OutputPrecision = signalRead.Precision;
				////////////  - Added as an example how to play more channels than stored in the file
				signalDemuxList.Input = null;
				signalDemuxList.Count = signalAsio1.OutputChannelCount;
				for (int i = 0; i < signalDemuxList.Count; i++) {
					signalDemuxList[i].Input = signalRead;
					signalDemuxList[i].Channel = i % signalRead.ChannelCount; //just take same channels more than once
				}
				////////////
				signalAsio1.Start();
				timer1.Enabled = true;

				//TAxisScaleTool(TopChart.Tools[0]).Reset;
				//TAxisScaleTool(BottomChart.Tools[0]).Reset;
			}

		}

		private void signalRateConverterList_OnBeforeUpdate(object Sender) {
			((TSignalRateConverter)Sender).Factor = signalAsio1.SamplingFrequency / signalRead.SamplingFrequency;
		}

		private void timer1_Tick(object sender, EventArgs e) {
			try {
				int bSamples = 0;
				int bSize = 0;

				if (signalAsio1.OutputChannelCount > 0) {
					signalAsio1.MonitorOutput(signalList, 1024);
					signalAsio1.OutputBufferStats(ref bSize, ref bSamples);
				}

				if (signalAsio1.DriverIndex >= 0) {
					double inL, outL;
					signalAsio1.GetDriverLatencies(out inL, out outL);
					statusLabel.Text = String.Format("ASIO Version = {0}, BufferSize = {1}, BufferedSamples = {2}, " +
														"InLatency = {3:0.000} [ms], OutLatency = {4:0.000} [ms], ActualLatency = {5:0.000} [ms], Elapsed time = {6:0.000}",
														signalAsio1.DriverVersion, bSize, bSamples,
														inL, outL, signalAsio1.ActualLatency(), signalAsio1.ElapsedTime()) + ",ProcessingTime = " + signalAsio1.ProcessingTime.ToString("0.000") + " [ms]";

					signalList.UpdateNotify();
				}
			} catch {
				timer1.Enabled = false;
			}

		}

		double volumeGain = 1;

		private void signalAsio1_ProcessRealTime(object sender, EventArgs e) {
			//put real time processing code here
			// for playback take data from OutputBuffers, process and put and back in.
			// for real time recording/playback, take data from InputBuffers, process them and put them to OutputBuffers

			// THIS EVENT RUNS IN DRIVERS THREAD. DO NOT PERORM OPERATIONS ON THE SAME VARS
			// FROM MORE THAN ONE THREAD.
			// Only InputBuffers and OutputBuffers can be read/written with processing in between

			//real time volume control, could also be echo, reverb etc..
			for (int i = 0; i < signalAsio1.OutputBuffers.Count; i++) {
				signalAsio1.OutputBuffers[i].Scale(volumeGain);
			}

		}

		private void volumeTrackBar_Scroll(object sender, EventArgs e) {
			volumeGain = (double)volumeTrackBar.Value / (double)volumeTrackBar.Maximum;
		}

		private void button2_Click(object sender, EventArgs e) {
			signalAsio1.Stop();
			timer1.Enabled = false;
		}

        private void AsioPlaybackForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            signalAsio1.Stop();
        }

        private void AsioPlaybackForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            signalAsio1.Stop();
        }

        private void topChart_Click(object sender, EventArgs e)
        {

        }

        private void bottomChart_Click(object sender, EventArgs e)
        {

        }
	}
}
