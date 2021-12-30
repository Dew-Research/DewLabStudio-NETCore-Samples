using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Tee;

namespace DSPDemo {
	public partial class LissajousScopeForm : Form {
		public LissajousScopeForm() {
			InitializeComponent();
		}

		private void LissajousScopeForm_Load(object sender, EventArgs e) {
			Signal1.Data.Size(1000);  //defines how much data to copy and consequently also frequency resolution
			Signal1.Data.SetZero();
			Signal1.UsesInputs = false;
			Signal2.Data.Size(1000);  //defines how much data to copy and consequently also frequency resolution
			Signal2.Data.SetZero();
			Signal2.UsesInputs = false;
			samplesBox.SelectedIndex = 1;

			richTextBox1.Text = "This example shows the angle of the Left versus Right channel, if Left is on the Y and Right " +
					"is on the X axis. The coordinates are rotated by 45 degrees counterclockwise. " +
					"This type of a phase scope is also refered to as Lissajou. " +
					"if there will be more low frequencies the scope will start showing lines." +
					"If there will be more high frequencies the dots will be scattered around." +
					"Vertical line indicates a mono signal. " +
					"Horizontal line indicates that left and right channel are 180 degrees out of phase " +
					"(cancelation). ";

		}

		private void SignalTimer1_OnTimer(object Sender, EventArgs e) {

			Vector a = new Vector(), Re = new Vector(), Im = new Vector();
			Re.Size(0);
			Im.Size(0);

			if (!SignalIn1.Active) SignalIn1.Start();
			SignalIn1.MonitorData(Signal1, Signal2);
			a.RealToCplx(Signal2.Data, Signal1.Data);
			a.CartToPolar(Re, Im);
			Im = Im * (180 / Math.PI) + 45; //from radians to degrees //add 45 degrees
			Re = Re / Re.Max();  //normalize to 1
			MtxVecTee.DrawValues(Im, Re, phaseChart.Series[0], false); //angle is x

		}

		private void samplesBox_SelectedIndexChanged(object sender, EventArgs e) {
			Signal1.Data.Length = int.Parse(samplesBox.Text);
			Signal2.Data.Length = int.Parse(samplesBox.Text);
		}

		private void button1_Click(object sender, EventArgs e) {
            chartEditor.ShowModal();
		}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
	}
}
