using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DSPDemo
{
	public class WhatIsNewForm : DSPDemo.BasicForm3
	{
		private System.ComponentModel.IContainer components = null;

		public WhatIsNewForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 10, FontStyle.Bold);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
            richTextBox1.SelectionColor = Color.FromArgb(51, 51, 153);
			Add("New features in v6.2");
			Add("");			
            richTextBox1.SelectionBullet = true;
            richTextBox1.BulletIndent = 10;
			Add("Support for Visual Studio 2022 v17.9.3");
			Add("Support for .NET Core 7.0 and 8.0");
			Add("Support for TeeChart v 2024.15.3");
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionIndent = 0;
            Add("");			
			
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 10, FontStyle.Bold);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
            richTextBox1.SelectionColor = Color.FromArgb(51, 51, 153);
            Add("New features in v6");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.BulletIndent = 10;
            Add("Rewritten in C# with support for .NET Core 5.");
            Add("All the functions/components can work either with double and/or single precision.");
            Add("Added FloatPrecision property to TSignal/TSignalList and TSpectrum/TSpectrumList and descendants.");
            Add("FloatPrecision is selectable also at run-time.");
            richTextBox1.SelectionBullet = false;
            richTextBox1.BulletIndent = 10;
            Add("");						

            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 10, FontStyle.Bold);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
            richTextBox1.SelectionColor = Color.FromArgb(51, 51, 153);
            Add("New features in v5");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.BulletIndent = 10;
            Add("IIR Filtering based on second order sections now allows filtering with much more extreem filter designs and stability up to order of 50.");
            Add("Added new overload for ButterFilter, ChebyshevIFilter, ChebyshevIIFilter and  EllipticFilter to more expose bi-quad (second order section) capabilities.");
            Add("Fixed TSIgnalFilter IIR filtering.");
            Add("New functions SignalUtils.IirInitBQ and LinearSystems.ZeroPoleToSOS.");
            Add("Long 64bit record length for files in TSignalWrite.");
            Add("TSignalFilter has been updated to make use second order sections for IIR filtering.");
            Add("Standard and Extended Kalman filtering algorithms.");
            richTextBox1.SelectionBullet = false;
            richTextBox1.BulletIndent = 10;
            Add("");

            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 10, FontStyle.Bold);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
            richTextBox1.SelectionColor = Color.FromArgb(51, 51, 153);
            Add("New features in version 4");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.BulletIndent = 10;
            Add("New inverse FFT based FIR filter designer.");
            Add("Standard and extended Kalman filter implementation.");
            Add("Steinberg ASIO interface for real time audio effects.");
            Add("New pink, gray and violate noise generators.");
            Add("Support for Intel AVX instruction set.");           
            Add("Support for VS.NET 2010 and .NET framework v4");
            Add("Support for TeeChart 2010.NET");
            Add("Fixed bug for triangular signal generator.");
            Add("TSignalRead bug fix for Windows 7.");
            Add("Bug fix for AxisTool auto scaling.");
            Add("Fixed the component editor for TSpectrumAnalyzer.");
            Add("Enabled ability to store settings for filters, signal generator and bands defined at design time.");
            Add("Substantial improvements to the design-time experience.");
            Add("Added sound recording and playback examples to the demo.");
            richTextBox1.SelectionBullet = false;
            richTextBox1.BulletIndent = 10;
            Add("");
            
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
            richTextBox1.SelectionColor = Color.FromArgb(51, 51, 153);
            Add("New features in version 3");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.BulletIndent = 10;

            Add("Updated to support Visual Studio 2008 and latest .NET libraries");
            Add("Support for TeeChart.NET v3");
            Add("Substantially increased number of native C# components");
            Add("Reduced distribution size.");
            Add("Support for updated Intel IPP v5.2 and consequently Core 2 Duo optimized.");
            Add("HtmlHelp 2 format support added. Now F1 finally works again from code and components in VS.IDE.");
            Add("All code examples now also have C# examples.");
            Add("All code examples in the help have been recreated with support for Vector/Matrix expressions.");
            Add("Demo updated with Vector/Matrix syntax.");
            Add("New set (hundreds) of true color 24x24 and 16x16 icons for components to support newer IDE tool palette.");           
            Add("Superfast arbitrary factor rate converter component.");
            Add("TSignalBuffer component had some bugs fixed.");
            Add("TSignal.Pull methods are completely rewritten. It is now possible to build much more complex processing pipes with much less code.");
            Add("Fixed a bug in Complex Cepstrum.");
            Add("SignalChart and SpectrumChart now accept multiple inputs. Same component can be connected to the same chart more than once or to multiple charts at the same time with centralized redraw control.");
            Add("TSignalRead.RecordPositon now calls TSignal.Update.");
            Add("Fixed a bug with TSignalIn for mono signal recordings.");
            Add("Fixed onStart and OnStop events for the TSignalIn and TSignalOut.");
            Add("Fixed the Report generation for TSpectrumAnalyzer and others.");
            Add("Fixed Logarithmic property for TSpectrumAnalyzer. It is now possible to toggle between logarithmic and linear scale for averaged spectrums without the need to perform the averaging again.");
            Add("Fixed a bug for TSignalGeneratorDialog where it did not store the changes made.");
            Add("TAnalysisList now has a Continuous property.");
            Add("Reset method has been added to all filtering components, and allows delay lines to be reset to zero.");
            richTextBox1.SelectionBullet = false;
            richTextBox1.BulletIndent = 10;
            Add("");

//			richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 10, FontStyle.Bold);
			richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
			richTextBox1.SelectionColor = Color.FromArgb(51,51,153);
			Add("New features in version 2");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.BulletIndent = 10;
			Add("Arbitrary FFT length for 1D and 2D transforms.");
			Add("Support for SSE3 instruction set.");
			Add("Intel SPL interface replaced with support for IPP library.");
			Add("Substantial increase in number of optimized primitive functions " +
				"and methods via MtxVec v2.");
			Add("Many new \"multi-channel\" list components.");
			Add("Improved TSignalFile with several new properties.");
			Add("Support for .NET");
			Add("New TSignalStoreBuffer component.");
			Add("New TSignalEnvelopeDetector component.");
			Add("New connection mechanism for SpectrumChart and SignalChart.");
			Add("TSignalRead component editor.");
			Add("Minor bug fixes.");
			Add("Improved piping mechanism for data streaming.");
			Add("Substantially improved range checking and programmer safety.");
			richTextBox1.SelectionBullet = false;
			richTextBox1.BulletIndent = 10;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.Size = new System.Drawing.Size(429, 362);
            // 
            // WhatIsNewForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(429, 362);
            this.Name = "WhatIsNewForm";
            this.Load += new System.EventHandler(this.WhatIsNewForm_Load);
            this.ResumeLayout(false);

		}
		#endregion

        private void WhatIsNewForm_Load(object sender, EventArgs e)
        {

        }
	}
}

