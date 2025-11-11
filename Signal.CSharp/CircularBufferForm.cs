using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Signal;

namespace DSPDemo {
	public partial class CircularBufferForm : Form {
		public CircularBufferForm() {
			InitializeComponent();
		}

		void DisplayUpdate() {
			bufferSizeLabel.Text = "Buffer size: " + signalBuffer1.BufferLength();
			writeCursorLabel.Text = "Write cursor: " + signalBuffer1.BufferWritePosition();
			unreadBufferDataLabel.Text = "Samples in buffer: " + signalBuffer1.BufferedSamplesCount();
			readCursorLabel.Text = "Read cursor: " + signalBuffer1.BufferReadPosition();
			inputBufferSizeLabel.Text = "Input buffer size: " + signalGenerator1.Length;
			storeBufferLabel.Text = "Store buffer size: " + signalStoreBuffer1.Length;
		}

		private void signalGenerator1_OnAfterUpdate(object Sender) {
			signalUpdateLabel.Text = "Signal gen was updated!";
		}

		private void updateButton_Click(object sender, EventArgs e) {
			signalUpdateLabel.Text = "Signal gen not updated";
			TPipeState a = spectrumAnalyzer1.Pull();
			switch (a) {
				case TPipeState.pipeOK: dataReadLabel.Text = "Stream state = pipeOK"; break;
				case TPipeState.pipeStream: dataReadLabel.Text = "Stream state = pipeStream"; break;
				case TPipeState.pipeBuffer: dataReadLabel.Text = "Stream state = pipeBuffer"; break;
			}
		}

		private void signalBuffer1_OnAfterUpdate(object Sender) {
			DisplayUpdate();
		}

		private void bufferSizeEdit_Click(object sender, EventArgs e) {
			signalBuffer1.Length = bufferSizeEdit.IntPosition;
			DisplayUpdate();
		}

		private void signalBuffer1_OnBeforeUpdate(object Sender) {
			signalChart2.Series[0].Clear();
		}

		private void CircularBufferForm_Load(object sender, EventArgs e) {
			bufferSizeEdit.IntPosition = signalBuffer1.Length;
			inputBufferEdit.IntPosition = signalGenerator1.Length;
			DisplayUpdate();
		}

		private void inputBufferEdit_Click(object sender, EventArgs e) {
			signalGenerator1.Length = inputBufferEdit.IntPosition;
			DisplayUpdate();
		}

		private void resetButton_Click(object sender, EventArgs e) {
			signalBuffer1.Reset();
			signalStoreBuffer1.Reset();
			DisplayUpdate();
		}
	}
}
