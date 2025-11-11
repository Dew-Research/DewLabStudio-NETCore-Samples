using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math.Units;
using Dew.Signal;
using Dew.Math;

namespace DSPDemo
{
	public partial class AsioRecordForm : Form
	{
		public AsioRecordForm() {
			InitializeComponent();
			// FIXME: switch to and back to get notify registered
			topChart.Signals[0].InputsItemIndex = 1;
			topChart.Signals[0].InputsItemIndex = 0;
		}

		private void button3_Click(object sender, EventArgs e) {
			signalAsio1.ShowControlPanel();
		}

		private void button2_Click(object sender, EventArgs e) {
			signalAsio1.StopGracefully();
			timer1.Enabled = false;

		}

		private void signalAsio1_ProcessRealTime(object sender, EventArgs e) {
			if (timer1.Enabled) timer1.Enabled = true;
		}

		private void signalAsio1_OnStop(object sender, EventArgs e) {
			signalWrite1.CloseFile();
		}

		private void AsioRecordForm_Load(object sender, EventArgs e) {
			driverNameListBox.Items.AddRange(signalAsio1.GetDriverList());
			label5.Text = "Recording to :'" + Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\test.wav"+"'";
		}

		private void driverNameListBox_SelectedIndexChanged(object sender, EventArgs e) {
			signalAsio1.DriverIndex = driverNameListBox.SelectedIndex;
			FSListBox.Items.Clear();
			FSListBox.Items.AddRange(signalAsio1.GetSupportedSamplingFrequencies());
			outputChBox.Items.Clear();
			outputChBox.Items.AddRange(signalAsio1.GetOutputChannels());
			inputChBox.Items.Clear();
			inputChBox.Items.AddRange(signalAsio1.GetInputChannels());
			if (FSListBox.Items.Count > 0) {
				FSListBox.SelectedIndex = 0;
				signalAsio1.SamplingFrequency = Math387.StrToSample(FSListBox.Items[0].ToString());
			} else {
				MessageBox.Show("Supported sampling frequency not found!");
			}
		}

		private void AsioRecordForm_Resize(object sender, EventArgs e) {
			topChart.Height = (ClientSize.Height - panel1.Height) / 2;
		}

		private void signalRateConverterList_OnBeforeUpdate(object Sender) {
			((TSignalRateConverter)Sender).Factor = signalAsio1.SamplingFrequency / signalRead.SamplingFrequency;
		}

		private void signalAsio1_InputBufferReady(object sender, EventArgs e) {
			signalWrite1.Precision = signalAsio1.InputPrecision;
			signalWrite1.Pull();
		}

		private void startButton_Click(object sender, EventArgs e) {
			if (driverNameListBox.SelectedItems.Count < 1) Math387.ERaise("Please select a valid ASIO driver first!");
			signalAsio1.Stop();
			for (int i = 0; i < outputChBox.Items.Count; i++) {
				signalAsio1.OutputsSelected[i] = outputChBox.SelectedIndices.Contains(i);
			}
			for (int i = 0; i < inputChBox.Items.Count; i++) {
				signalAsio1.InputsSelected[i] = inputChBox.SelectedIndices.Contains(i);
			}			

			signalWrite1.FileName = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\test.wav"; 
			signalRead.CloseFile();
			if (openFileDialog1.ShowDialog() == DialogResult.OK) {
				signalRead.FileName = openFileDialog1.FileName; // 'C:\TestTone20.wav';
				signalRead.OpenFile();
				if (FSListBox.SelectedItems.Count > 0) signalAsio1.SamplingFrequency = Math387.StrToSample(FSListBox.SelectedItem.ToString());
				signalAsio1.InputPrecision = TPrecision.prSingle;
				signalAsio1.OutputPrecision = signalRead.Precision;
				signalAsio1.Start();
				timer1.Enabled = true;

                axisScaleTool1.Reset();
                axisScaleTool2.Reset();

				//TAxisScaleTool(TopChart.Tools[0]).Reset;
				//TAxisScaleTool(BottomChart.Tools[0]).Reset;
			}

		}

		private void timer1_Tick(object sender, EventArgs e) {
			try {
				int bSamples = 0;
				int bSize = 0;

				if (signalAsio1.InputChannelCount > 0) {
					signalAsio1.MonitorInput(signalList, 1024);
					signalAsio1.InputBufferStats(ref bSize, ref bSamples);
				} else if (signalAsio1.OutputChannelCount > 0) {
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

        private void topChart_Click(object sender, EventArgs e)
        {

        }
    }
}
