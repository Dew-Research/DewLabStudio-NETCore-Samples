namespace DSPDemo {
	partial class CircularBufferForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CircularBufferForm));
            Steema.TeeChart.Drawing.Cursor cursor1 = new Steema.TeeChart.Drawing.Cursor();
            Steema.TeeChart.Margins margins1 = new Steema.TeeChart.Margins();
            Dew.Signal.Tee.SpectrumTeeItem spectrumTeeItem1 = new Dew.Signal.Tee.SpectrumTeeItem();
            Steema.TeeChart.Margins margins2 = new Steema.TeeChart.Margins();
            Dew.Signal.Tee.SignalTeeItem signalTeeItem1 = new Dew.Signal.Tee.SignalTeeItem();
            Steema.TeeChart.Margins margins3 = new Steema.TeeChart.Margins();
            Dew.Signal.Tee.SignalTeeItem signalTeeItem2 = new Dew.Signal.Tee.SignalTeeItem();
            spectrumAnalyzer1 = new Dew.Signal.TSpectrumAnalyzer(components);
            signalStoreBuffer1 = new Dew.Signal.TSignalStoreBuffer(components);
            signalBuffer1 = new Dew.Signal.TSignalBuffer(components);
            signalGenerator1 = new Dew.Signal.TSignalGenerator(components);
            fastLine1 = new Steema.TeeChart.Styles.FastLine();
            fastLine3 = new Steema.TeeChart.Styles.FastLine();
            fastLine2 = new Steema.TeeChart.Styles.FastLine();
            spectrumChart1 = new Dew.Signal.Tee.SpectrumChart();
            panel1 = new System.Windows.Forms.Panel();
            resetButton = new System.Windows.Forms.Button();
            updateButton = new System.Windows.Forms.Button();
            signalUpdateLabel = new System.Windows.Forms.Label();
            storeBufferLabel = new System.Windows.Forms.Label();
            writeCursorLabel = new System.Windows.Forms.Label();
            unreadBufferDataLabel = new System.Windows.Forms.Label();
            readCursorLabel = new System.Windows.Forms.Label();
            inputBufferSizeLabel = new System.Windows.Forms.Label();
            dataReadLabel = new System.Windows.Forms.Label();
            bufferSizeLabel = new System.Windows.Forms.Label();
            bufferSizeEdit = new Dew.Math.Controls.FloatEdit();
            label2 = new System.Windows.Forms.Label();
            inputBufferEdit = new Dew.Math.Controls.FloatEdit();
            label1 = new System.Windows.Forms.Label();
            splitter1 = new System.Windows.Forms.Splitter();
            panel2 = new System.Windows.Forms.Panel();
            splitter2 = new System.Windows.Forms.Splitter();
            signalChart2 = new Dew.Signal.Tee.SignalChart();
            signalChart1 = new Dew.Signal.Tee.SignalChart();
            ((System.ComponentModel.ISupportInitialize)spectrumChart1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signalChart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)signalChart1).BeginInit();
            SuspendLayout();
            // 
            // spectrumAnalyzer1
            // 
            spectrumAnalyzer1.ArOrder = 100;
            spectrumAnalyzer1.Bands.TemplateIndex = -1;
            spectrumAnalyzer1.Bands.TemplatesSerialization = "AAAAAA==";
            spectrumAnalyzer1.Complex = false;
            spectrumAnalyzer1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            spectrumAnalyzer1.FloatPrecisionLock = false;
            spectrumAnalyzer1.Harmonics = 10;
            spectrumAnalyzer1.Input = signalStoreBuffer1;
            spectrumAnalyzer1.IsDouble = true;
            spectrumAnalyzer1.Length = 64;
            spectrumAnalyzer1.Logarithmic = true;
            spectrumAnalyzer1.LogBase = 0D;
            spectrumAnalyzer1.LogScale = 0D;
            spectrumAnalyzer1.LogSpan = Dew.Signal.TLogSpan.ls200;
            spectrumAnalyzer1.MainlobeWidth = 8;
            spectrumAnalyzer1.Peaks.HarmonicsCount = 10;
            spectrumAnalyzer1.Peaks.Interpolation.RecursiveHarmonics = Dew.Signal.TRecursiveHarmonics.rhNone;
            spectrumAnalyzer1.Peaks.LargestCount = 1;
            spectrumAnalyzer1.Peaks.LargestRatio = 1E+15D;
            spectrumAnalyzer1.Peaks.NormalizedAmplt.PeakNumber = 1;
            spectrumAnalyzer1.Peaks.NormalizedFreq.PeakNumber = 1;
            spectrumAnalyzer1.Report.AmplitudeFormat = null;
            spectrumAnalyzer1.Report.FrequencyFormat = null;
            spectrumAnalyzer1.Report.PhaseFormat = null;
            spectrumAnalyzer1.Report.UseTab = false;
            spectrumAnalyzer1.Rotation = 0;
            spectrumAnalyzer1.SidelobeAtt = 90D;
            spectrumAnalyzer1.Stats.Averaged = 0;
            spectrumAnalyzer1.Stats.Averages = 30;
            spectrumAnalyzer1.Stats.ExpDecay = 5;
            spectrumAnalyzer1.Window = Dew.Signal.TSignalWindowType.wtKaiser;
            spectrumAnalyzer1.ZeroPadding = 16;
            // 
            // signalStoreBuffer1
            // 
            signalStoreBuffer1.ActualBufferSize = 0;
            signalStoreBuffer1.ChannelCount = 1;
            signalStoreBuffer1.Complex = false;
            signalStoreBuffer1.DataSerialization = "AAAAAAAAAAAAAAAAAACAPwAAAAAAgB9EAAAAQQAAAAAAE3pHAAAAAAAAAAAAAAAA";
            signalStoreBuffer1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            signalStoreBuffer1.FloatPrecisionLock = false;
            signalStoreBuffer1.InitialBufferSize = 16;
            signalStoreBuffer1.Input = signalBuffer1;
            signalStoreBuffer1.IsDouble = true;
            signalStoreBuffer1.Length = 0;
            signalStoreBuffer1.MaxBufferLength = -1;
            // 
            // signalBuffer1
            // 
            signalBuffer1.BufferSizeLimit = 2000000;
            signalBuffer1.ChannelCount = 1;
            signalBuffer1.Complex = false;
            signalBuffer1.DataSerialization = resources.GetString("signalBuffer1.DataSerialization");
            signalBuffer1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            signalBuffer1.FloatPrecisionLock = false;
            signalBuffer1.IncrementStep = 1D;
            signalBuffer1.Input = signalGenerator1;
            signalBuffer1.IsDouble = true;
            signalBuffer1.Length = 500;
            signalBuffer1.StrideLength = 0;
            signalBuffer1.OnAfterUpdateEvent += signalBuffer1_OnAfterUpdate;
            signalBuffer1.OnBeforeUpdateEvent += signalBuffer1_OnBeforeUpdate;
            // 
            // signalGenerator1
            // 
            signalGenerator1.ChannelCount = 1;
            signalGenerator1.Complex = false;
            signalGenerator1.DataSerialization = resources.GetString("signalGenerator1.DataSerialization");
            signalGenerator1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            signalGenerator1.FloatPrecisionLock = false;
            signalGenerator1.IsDouble = true;
            signalGenerator1.Length = 900;
            signalGenerator1.SamplingFrequency = 1000D;
            signalGenerator1.Sounds.TemplateIndex = 0;
            signalGenerator1.Sounds.TemplatesSerialization = resources.GetString("resource.TemplatesSerialization");
            signalGenerator1.OnAfterUpdateEvent += signalGenerator1_OnAfterUpdate;
            // 
            // fastLine1
            // 
            // 
            // 
            // 
            fastLine1.Brush.Color = System.Drawing.Color.Empty;
            fastLine1.Brush.Solid = true;
            fastLine1.Brush.Visible = true;
            fastLine1.Color = System.Drawing.Color.FromArgb(255, 0, 0);
            fastLine1.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine1.Legend.Brush.Color = System.Drawing.Color.White;
            fastLine1.Legend.Brush.Solid = true;
            fastLine1.Legend.Brush.Visible = true;
            // 
            // 
            // 
            fastLine1.Legend.Font.Bold = false;
            // 
            // 
            // 
            fastLine1.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            fastLine1.Legend.Font.Brush.Solid = true;
            fastLine1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            fastLine1.Legend.Font.Shadow.Brush.Solid = true;
            fastLine1.Legend.Font.Shadow.Brush.Visible = true;
            fastLine1.Legend.Font.Size = 8;
            fastLine1.Legend.Font.SizeFloat = 8F;
            fastLine1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            fastLine1.Legend.ImageBevel.Brush.Solid = true;
            fastLine1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine1.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            fastLine1.Legend.Shadow.Brush.Solid = true;
            fastLine1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine1.Marks.Brush.Color = System.Drawing.Color.FromArgb(255, 255, 255);
            fastLine1.Marks.Brush.Solid = true;
            fastLine1.Marks.Brush.Visible = true;
            // 
            // 
            // 
            fastLine1.Marks.Font.Bold = false;
            // 
            // 
            // 
            fastLine1.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            fastLine1.Marks.Font.Brush.Solid = true;
            fastLine1.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine1.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            fastLine1.Marks.Font.Shadow.Brush.Solid = true;
            fastLine1.Marks.Font.Shadow.Brush.Visible = true;
            fastLine1.Marks.Font.Size = 8;
            fastLine1.Marks.Font.SizeFloat = 8F;
            fastLine1.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine1.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            fastLine1.Marks.ImageBevel.Brush.Solid = true;
            fastLine1.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine1.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            fastLine1.Marks.Shadow.Brush.Solid = true;
            fastLine1.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine1.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            fastLine1.Marks.Symbol.Brush.Solid = true;
            fastLine1.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine1.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            fastLine1.Marks.Symbol.ImageBevel.Brush.Solid = true;
            fastLine1.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine1.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            fastLine1.Marks.Symbol.Shadow.Brush.Solid = true;
            fastLine1.Marks.Symbol.Shadow.Brush.Visible = true;
            fastLine1.Title = "fastLine1";
            fastLine1.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            // 
            // 
            // 
            fastLine1.XValues.DataMember = "X";
            fastLine1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            fastLine1.XValues.Value = new double[]
    {
    0D,
    1D,
    2D,
    3D,
    4D,
    5D,
    6D,
    7D,
    8D,
    9D,
    10D,
    11D,
    12D,
    13D,
    14D,
    15D,
    16D,
    17D,
    18D,
    19D,
    20D,
    21D,
    22D,
    23D,
    24D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D
    };
            // 
            // 
            // 
            fastLine1.YValues.DataMember = "Y";
            fastLine1.YValues.Value = new double[]
    {
    352D,
    430D,
    493D,
    593D,
    542D,
    537D,
    521D,
    587D,
    665D,
    675D,
    583D,
    497D,
    566D,
    508D,
    590D,
    686D,
    659D,
    773D,
    789D,
    869D,
    840D,
    751D,
    756D,
    637D,
    716D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D
    };
            // 
            // fastLine3
            // 
            // 
            // 
            // 
            fastLine3.Brush.Color = System.Drawing.Color.Empty;
            fastLine3.Brush.Solid = true;
            fastLine3.Brush.Visible = true;
            fastLine3.Color = System.Drawing.Color.FromArgb(255, 0, 0);
            fastLine3.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine3.Legend.Brush.Color = System.Drawing.Color.White;
            fastLine3.Legend.Brush.Solid = true;
            fastLine3.Legend.Brush.Visible = true;
            // 
            // 
            // 
            fastLine3.Legend.Font.Bold = false;
            // 
            // 
            // 
            fastLine3.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            fastLine3.Legend.Font.Brush.Solid = true;
            fastLine3.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine3.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            fastLine3.Legend.Font.Shadow.Brush.Solid = true;
            fastLine3.Legend.Font.Shadow.Brush.Visible = true;
            fastLine3.Legend.Font.Size = 8;
            fastLine3.Legend.Font.SizeFloat = 8F;
            fastLine3.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine3.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            fastLine3.Legend.ImageBevel.Brush.Solid = true;
            fastLine3.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine3.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            fastLine3.Legend.Shadow.Brush.Solid = true;
            fastLine3.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine3.Marks.Brush.Color = System.Drawing.Color.FromArgb(255, 255, 255);
            fastLine3.Marks.Brush.Solid = true;
            fastLine3.Marks.Brush.Visible = true;
            // 
            // 
            // 
            fastLine3.Marks.Font.Bold = false;
            // 
            // 
            // 
            fastLine3.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            fastLine3.Marks.Font.Brush.Solid = true;
            fastLine3.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine3.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            fastLine3.Marks.Font.Shadow.Brush.Solid = true;
            fastLine3.Marks.Font.Shadow.Brush.Visible = true;
            fastLine3.Marks.Font.Size = 8;
            fastLine3.Marks.Font.SizeFloat = 8F;
            fastLine3.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine3.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            fastLine3.Marks.ImageBevel.Brush.Solid = true;
            fastLine3.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine3.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            fastLine3.Marks.Shadow.Brush.Solid = true;
            fastLine3.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine3.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            fastLine3.Marks.Symbol.Brush.Solid = true;
            fastLine3.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine3.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            fastLine3.Marks.Symbol.ImageBevel.Brush.Solid = true;
            fastLine3.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine3.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            fastLine3.Marks.Symbol.Shadow.Brush.Solid = true;
            fastLine3.Marks.Symbol.Shadow.Brush.Visible = true;
            fastLine3.Title = "fastLine1";
            fastLine3.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            // 
            // 
            // 
            fastLine3.XValues.DataMember = "X";
            fastLine3.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            fastLine3.XValues.Value = new double[]
    {
    0D,
    1D,
    2D,
    3D,
    4D,
    5D,
    6D,
    7D,
    8D,
    9D,
    10D,
    11D,
    12D,
    13D,
    14D,
    15D,
    16D,
    17D,
    18D,
    19D,
    20D,
    21D,
    22D,
    23D,
    24D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D
    };
            // 
            // 
            // 
            fastLine3.YValues.DataMember = "Y";
            fastLine3.YValues.Value = new double[]
    {
    535D,
    493D,
    380D,
    270D,
    334D,
    227D,
    226D,
    223D,
    223D,
    133D,
    107D,
    127D,
    137D,
    75D,
    104D,
    117D,
    147D,
    45D,
    125D,
    0D,
    10D,
    74D,
    69D,
    169D,
    224D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D
    };
            // 
            // fastLine2
            // 
            // 
            // 
            // 
            fastLine2.Brush.Color = System.Drawing.Color.Empty;
            fastLine2.Brush.Solid = true;
            fastLine2.Brush.Visible = true;
            fastLine2.Color = System.Drawing.Color.FromArgb(255, 0, 0);
            fastLine2.Cursor = cursor1;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine2.Legend.Brush.Color = System.Drawing.Color.White;
            fastLine2.Legend.Brush.Solid = true;
            fastLine2.Legend.Brush.Visible = true;
            // 
            // 
            // 
            fastLine2.Legend.Font.Bold = false;
            // 
            // 
            // 
            fastLine2.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            fastLine2.Legend.Font.Brush.Solid = true;
            fastLine2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            fastLine2.Legend.Font.Shadow.Brush.Solid = true;
            fastLine2.Legend.Font.Shadow.Brush.Visible = true;
            fastLine2.Legend.Font.Size = 8;
            fastLine2.Legend.Font.SizeFloat = 8F;
            fastLine2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            fastLine2.Legend.ImageBevel.Brush.Solid = true;
            fastLine2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine2.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            fastLine2.Legend.Shadow.Brush.Solid = true;
            fastLine2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine2.Marks.Brush.Color = System.Drawing.Color.FromArgb(255, 255, 255);
            fastLine2.Marks.Brush.Solid = true;
            fastLine2.Marks.Brush.Visible = true;
            // 
            // 
            // 
            fastLine2.Marks.Font.Bold = false;
            // 
            // 
            // 
            fastLine2.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            fastLine2.Marks.Font.Brush.Solid = true;
            fastLine2.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine2.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            fastLine2.Marks.Font.Shadow.Brush.Solid = true;
            fastLine2.Marks.Font.Shadow.Brush.Visible = true;
            fastLine2.Marks.Font.Size = 8;
            fastLine2.Marks.Font.SizeFloat = 8F;
            fastLine2.Marks.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine2.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            fastLine2.Marks.ImageBevel.Brush.Solid = true;
            fastLine2.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine2.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            fastLine2.Marks.Shadow.Brush.Solid = true;
            fastLine2.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine2.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            fastLine2.Marks.Symbol.Brush.Solid = true;
            fastLine2.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine2.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            fastLine2.Marks.Symbol.ImageBevel.Brush.Solid = true;
            fastLine2.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            fastLine2.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            fastLine2.Marks.Symbol.Shadow.Brush.Solid = true;
            fastLine2.Marks.Symbol.Shadow.Brush.Visible = true;
            fastLine2.Title = "fastLine2";
            fastLine2.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            // 
            // 
            // 
            fastLine2.XValues.DataMember = "X";
            fastLine2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            fastLine2.XValues.Value = new double[]
    {
    0D,
    1D,
    2D,
    3D,
    4D,
    5D,
    6D,
    7D,
    8D,
    9D,
    10D,
    11D,
    12D,
    13D,
    14D,
    15D,
    16D,
    17D,
    18D,
    19D,
    20D,
    21D,
    22D,
    23D,
    24D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D
    };
            // 
            // 
            // 
            fastLine2.YValues.DataMember = "Y";
            fastLine2.YValues.Value = new double[]
    {
    567D,
    521D,
    618D,
    659D,
    607D,
    665D,
    561D,
    600D,
    575D,
    475D,
    529D,
    592D,
    663D,
    553D,
    593D,
    540D,
    607D,
    654D,
    650D,
    728D,
    707D,
    660D,
    586D,
    669D,
    676D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D,
    0D
    };
            // 
            // spectrumChart1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Bottom.Grid.DrawEvery = 1;
            spectrumChart1.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            spectrumChart1.Axes.Bottom.Labels.Brush.Solid = true;
            spectrumChart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            spectrumChart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            spectrumChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            spectrumChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            spectrumChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            spectrumChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            spectrumChart1.Axes.Bottom.Labels.Font.Size = 9;
            spectrumChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            spectrumChart1.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            spectrumChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            spectrumChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            spectrumChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            spectrumChart1.Axes.Bottom.Title.Brush.Solid = true;
            spectrumChart1.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            spectrumChart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            spectrumChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            spectrumChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            spectrumChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            spectrumChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            spectrumChart1.Axes.Bottom.Title.Font.Size = 11;
            spectrumChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            spectrumChart1.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            spectrumChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            spectrumChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            spectrumChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            spectrumChart1.Axes.Depth.Labels.Brush.Solid = true;
            spectrumChart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            spectrumChart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            spectrumChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            spectrumChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            spectrumChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            spectrumChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            spectrumChart1.Axes.Depth.Labels.Font.Size = 9;
            spectrumChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            spectrumChart1.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            spectrumChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            spectrumChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            spectrumChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            spectrumChart1.Axes.Depth.Title.Brush.Solid = true;
            spectrumChart1.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            spectrumChart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            spectrumChart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            spectrumChart1.Axes.Depth.Title.Font.Brush.Solid = true;
            spectrumChart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            spectrumChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            spectrumChart1.Axes.Depth.Title.Font.Size = 11;
            spectrumChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            spectrumChart1.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            spectrumChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            spectrumChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            spectrumChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            spectrumChart1.Axes.DepthTop.Labels.Brush.Solid = true;
            spectrumChart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            spectrumChart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            spectrumChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            spectrumChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            spectrumChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            spectrumChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            spectrumChart1.Axes.DepthTop.Labels.Font.Size = 9;
            spectrumChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            spectrumChart1.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            spectrumChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            spectrumChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            spectrumChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            spectrumChart1.Axes.DepthTop.Title.Brush.Solid = true;
            spectrumChart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            spectrumChart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            spectrumChart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            spectrumChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            spectrumChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            spectrumChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            spectrumChart1.Axes.DepthTop.Title.Font.Size = 11;
            spectrumChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            spectrumChart1.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            spectrumChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            spectrumChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            spectrumChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            spectrumChart1.Axes.Left.Labels.Brush.Solid = true;
            spectrumChart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            spectrumChart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            spectrumChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            spectrumChart1.Axes.Left.Labels.Font.Brush.Solid = true;
            spectrumChart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            spectrumChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            spectrumChart1.Axes.Left.Labels.Font.Size = 9;
            spectrumChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            spectrumChart1.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            spectrumChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            spectrumChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            spectrumChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            spectrumChart1.Axes.Left.Title.Brush.Solid = true;
            spectrumChart1.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            spectrumChart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            spectrumChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            spectrumChart1.Axes.Left.Title.Font.Brush.Solid = true;
            spectrumChart1.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            spectrumChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            spectrumChart1.Axes.Left.Title.Font.Size = 11;
            spectrumChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            spectrumChart1.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            spectrumChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            spectrumChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            spectrumChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Right.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            spectrumChart1.Axes.Right.Labels.Brush.Solid = true;
            spectrumChart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            spectrumChart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            spectrumChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            spectrumChart1.Axes.Right.Labels.Font.Brush.Solid = true;
            spectrumChart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            spectrumChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            spectrumChart1.Axes.Right.Labels.Font.Size = 9;
            spectrumChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            spectrumChart1.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            spectrumChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            spectrumChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            spectrumChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            spectrumChart1.Axes.Right.Title.Brush.Solid = true;
            spectrumChart1.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            spectrumChart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            spectrumChart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            spectrumChart1.Axes.Right.Title.Font.Brush.Solid = true;
            spectrumChart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            spectrumChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            spectrumChart1.Axes.Right.Title.Font.Size = 11;
            spectrumChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            spectrumChart1.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            spectrumChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            spectrumChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            spectrumChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            spectrumChart1.Axes.Top.Labels.Brush.Solid = true;
            spectrumChart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            spectrumChart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            spectrumChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            spectrumChart1.Axes.Top.Labels.Font.Brush.Solid = true;
            spectrumChart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            spectrumChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            spectrumChart1.Axes.Top.Labels.Font.Size = 9;
            spectrumChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            spectrumChart1.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            spectrumChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            spectrumChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            spectrumChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            spectrumChart1.Axes.Top.Title.Brush.Solid = true;
            spectrumChart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            spectrumChart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            spectrumChart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            spectrumChart1.Axes.Top.Title.Font.Brush.Solid = true;
            spectrumChart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            spectrumChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            spectrumChart1.Axes.Top.Title.Font.Size = 11;
            spectrumChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            spectrumChart1.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            spectrumChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            spectrumChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            spectrumChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            spectrumChart1.Color = System.Drawing.Color.White;
            spectrumChart1.Dock = System.Windows.Forms.DockStyle.Top;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Footer.Brush.Color = System.Drawing.Color.Silver;
            spectrumChart1.Footer.Brush.Solid = true;
            spectrumChart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            spectrumChart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            spectrumChart1.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            spectrumChart1.Footer.Font.Brush.Solid = true;
            spectrumChart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Footer.Font.Shadow.Brush.Solid = true;
            spectrumChart1.Footer.Font.Shadow.Brush.Visible = true;
            spectrumChart1.Footer.Font.Size = 8;
            spectrumChart1.Footer.Font.SizeFloat = 8F;
            spectrumChart1.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            spectrumChart1.Footer.ImageBevel.Brush.Solid = true;
            spectrumChart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Footer.Shadow.Brush.Solid = true;
            spectrumChart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(192, 192, 192);
            spectrumChart1.Header.Brush.Solid = true;
            spectrumChart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            spectrumChart1.Header.Font.Bold = false;
            // 
            // 
            // 
            spectrumChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            spectrumChart1.Header.Font.Brush.Solid = true;
            spectrumChart1.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Header.Font.Shadow.Brush.Solid = true;
            spectrumChart1.Header.Font.Shadow.Brush.Visible = true;
            spectrumChart1.Header.Font.Size = 12;
            spectrumChart1.Header.Font.SizeFloat = 12F;
            spectrumChart1.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            spectrumChart1.Header.ImageBevel.Brush.Solid = true;
            spectrumChart1.Header.ImageBevel.Brush.Visible = true;
            spectrumChart1.Header.Lines = new string[]
    {
    "Spectrum"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(169, 169, 169);
            spectrumChart1.Header.Shadow.Brush.Solid = true;
            spectrumChart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Legend.Brush.Color = System.Drawing.Color.White;
            spectrumChart1.Legend.Brush.Solid = true;
            spectrumChart1.Legend.Brush.Visible = true;
            spectrumChart1.Legend.CheckBoxes = false;
            // 
            // 
            // 
            spectrumChart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            spectrumChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            spectrumChart1.Legend.Font.Brush.Solid = true;
            spectrumChart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Legend.Font.Shadow.Brush.Solid = true;
            spectrumChart1.Legend.Font.Shadow.Brush.Visible = true;
            spectrumChart1.Legend.Font.Size = 9;
            spectrumChart1.Legend.Font.SizeFloat = 9F;
            spectrumChart1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            spectrumChart1.Legend.ImageBevel.Brush.Solid = true;
            spectrumChart1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(0, 0, 0);
            spectrumChart1.Legend.Shadow.Brush.Solid = true;
            spectrumChart1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Legend.Symbol.Shadow.Brush.Solid = true;
            spectrumChart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Legend.Title.Brush.Color = System.Drawing.Color.White;
            spectrumChart1.Legend.Title.Brush.Solid = true;
            spectrumChart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            spectrumChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            spectrumChart1.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            spectrumChart1.Legend.Title.Font.Brush.Solid = true;
            spectrumChart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            spectrumChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            spectrumChart1.Legend.Title.Font.Size = 8;
            spectrumChart1.Legend.Title.Font.SizeFloat = 8F;
            spectrumChart1.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            spectrumChart1.Legend.Title.ImageBevel.Brush.Solid = true;
            spectrumChart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Legend.Title.Shadow.Brush.Solid = true;
            spectrumChart1.Legend.Title.Shadow.Brush.Visible = true;
            spectrumChart1.Legend.Visible = false;
            spectrumChart1.Location = new System.Drawing.Point(0, 0);
            spectrumChart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            spectrumChart1.Name = "spectrumChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Panel.Brush.Color = System.Drawing.Color.White;
            spectrumChart1.Panel.Brush.Solid = true;
            spectrumChart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            spectrumChart1.Panel.ImageBevel.Brush.Solid = true;
            spectrumChart1.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Panel.Shadow.Brush.Solid = true;
            spectrumChart1.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins1.Bottom = 100;
            margins1.Left = 100;
            margins1.Right = 100;
            margins1.Top = 100;
            spectrumChart1.Printer.Margins = margins1;
            spectrumChart1.Series.Add(fastLine1);
            spectrumChart1.Size = new System.Drawing.Size(1168, 175);
            spectrumChart1.SpectrumPart = Dew.Signal.Tee.SpectrumPart.sppAmplt;
            spectrumTeeItem1.Caption = null;
            spectrumTeeItem1.Input = spectrumAnalyzer1;
            spectrumTeeItem1.Inputs = null;
            spectrumTeeItem1.InputsItemIndex = 0;
            spectrumTeeItem1.Series = fastLine1;
            spectrumTeeItem1.SeriesName = "fastLine1";
            spectrumChart1.Spectrums.Add(spectrumTeeItem1);
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            spectrumChart1.SubFooter.Brush.Solid = true;
            spectrumChart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            spectrumChart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            spectrumChart1.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            spectrumChart1.SubFooter.Font.Brush.Solid = true;
            spectrumChart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.SubFooter.Font.Shadow.Brush.Solid = true;
            spectrumChart1.SubFooter.Font.Shadow.Brush.Visible = true;
            spectrumChart1.SubFooter.Font.Size = 8;
            spectrumChart1.SubFooter.Font.SizeFloat = 8F;
            spectrumChart1.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            spectrumChart1.SubFooter.ImageBevel.Brush.Solid = true;
            spectrumChart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.SubFooter.Shadow.Brush.Solid = true;
            spectrumChart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(192, 192, 192);
            spectrumChart1.SubHeader.Brush.Solid = true;
            spectrumChart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            spectrumChart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            spectrumChart1.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            spectrumChart1.SubHeader.Font.Brush.Solid = true;
            spectrumChart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.SubHeader.Font.Shadow.Brush.Solid = true;
            spectrumChart1.SubHeader.Font.Shadow.Brush.Visible = true;
            spectrumChart1.SubHeader.Font.Size = 12;
            spectrumChart1.SubHeader.Font.SizeFloat = 12F;
            spectrumChart1.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            spectrumChart1.SubHeader.ImageBevel.Brush.Solid = true;
            spectrumChart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(169, 169, 169);
            spectrumChart1.SubHeader.Shadow.Brush.Solid = true;
            spectrumChart1.SubHeader.Shadow.Brush.Visible = true;
            spectrumChart1.TabIndex = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            spectrumChart1.Walls.Back.Brush.Solid = true;
            spectrumChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            spectrumChart1.Walls.Back.ImageBevel.Brush.Solid = true;
            spectrumChart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Walls.Back.Shadow.Brush.Solid = true;
            spectrumChart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            spectrumChart1.Walls.Bottom.Brush.Solid = true;
            spectrumChart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            spectrumChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            spectrumChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Walls.Bottom.Shadow.Brush.Solid = true;
            spectrumChart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            spectrumChart1.Walls.Left.Brush.Solid = true;
            spectrumChart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            spectrumChart1.Walls.Left.ImageBevel.Brush.Solid = true;
            spectrumChart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Walls.Left.Shadow.Brush.Solid = true;
            spectrumChart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            spectrumChart1.Walls.Right.Brush.Solid = true;
            spectrumChart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            spectrumChart1.Walls.Right.ImageBevel.Brush.Solid = true;
            spectrumChart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            spectrumChart1.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            spectrumChart1.Walls.Right.Shadow.Brush.Solid = true;
            spectrumChart1.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            spectrumChart1.Zoom.Animated = true;
            // 
            // 
            // 
            spectrumChart1.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            spectrumChart1.Zoom.Brush.Solid = true;
            spectrumChart1.Zoom.Brush.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(resetButton);
            panel1.Controls.Add(updateButton);
            panel1.Controls.Add(signalUpdateLabel);
            panel1.Controls.Add(storeBufferLabel);
            panel1.Controls.Add(writeCursorLabel);
            panel1.Controls.Add(unreadBufferDataLabel);
            panel1.Controls.Add(readCursorLabel);
            panel1.Controls.Add(inputBufferSizeLabel);
            panel1.Controls.Add(dataReadLabel);
            panel1.Controls.Add(bufferSizeLabel);
            panel1.Controls.Add(bufferSizeEdit);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(inputBufferEdit);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 697);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1168, 145);
            panel1.TabIndex = 1;
            // 
            // resetButton
            // 
            resetButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            resetButton.Location = new System.Drawing.Point(972, 105);
            resetButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            resetButton.Name = "resetButton";
            resetButton.Size = new System.Drawing.Size(88, 27);
            resetButton.TabIndex = 7;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // updateButton
            // 
            updateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            updateButton.Location = new System.Drawing.Point(1066, 105);
            updateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            updateButton.Name = "updateButton";
            updateButton.Size = new System.Drawing.Size(88, 27);
            updateButton.TabIndex = 6;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // signalUpdateLabel
            // 
            signalUpdateLabel.AutoSize = true;
            signalUpdateLabel.Location = new System.Drawing.Point(525, 9);
            signalUpdateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            signalUpdateLabel.Name = "signalUpdateLabel";
            signalUpdateLabel.Size = new System.Drawing.Size(190, 15);
            signalUpdateLabel.TabIndex = 5;
            signalUpdateLabel.Text = "Signal generator has been updated";
            // 
            // storeBufferLabel
            // 
            storeBufferLabel.AutoSize = true;
            storeBufferLabel.Location = new System.Drawing.Point(14, 98);
            storeBufferLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            storeBufferLabel.Name = "storeBufferLabel";
            storeBufferLabel.Size = new System.Drawing.Size(72, 15);
            storeBufferLabel.TabIndex = 4;
            storeBufferLabel.Text = "Store buffer:";
            // 
            // writeCursorLabel
            // 
            writeCursorLabel.AutoSize = true;
            writeCursorLabel.Location = new System.Drawing.Point(200, 78);
            writeCursorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            writeCursorLabel.Name = "writeCursorLabel";
            writeCursorLabel.Size = new System.Drawing.Size(74, 15);
            writeCursorLabel.TabIndex = 3;
            writeCursorLabel.Text = "Write cursor:";
            // 
            // unreadBufferDataLabel
            // 
            unreadBufferDataLabel.AutoSize = true;
            unreadBufferDataLabel.Location = new System.Drawing.Point(14, 78);
            unreadBufferDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            unreadBufferDataLabel.Name = "unreadBufferDataLabel";
            unreadBufferDataLabel.Size = new System.Drawing.Size(83, 15);
            unreadBufferDataLabel.TabIndex = 3;
            unreadBufferDataLabel.Text = "Unread Buffer:";
            // 
            // readCursorLabel
            // 
            readCursorLabel.AutoSize = true;
            readCursorLabel.Location = new System.Drawing.Point(200, 59);
            readCursorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            readCursorLabel.Name = "readCursorLabel";
            readCursorLabel.Size = new System.Drawing.Size(72, 15);
            readCursorLabel.TabIndex = 3;
            readCursorLabel.Text = "Read cursor:";
            // 
            // inputBufferSizeLabel
            // 
            inputBufferSizeLabel.AutoSize = true;
            inputBufferSizeLabel.Location = new System.Drawing.Point(14, 59);
            inputBufferSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            inputBufferSizeLabel.Name = "inputBufferSizeLabel";
            inputBufferSizeLabel.Size = new System.Drawing.Size(95, 15);
            inputBufferSizeLabel.TabIndex = 3;
            inputBufferSizeLabel.Text = "Input buffer size:";
            // 
            // dataReadLabel
            // 
            dataReadLabel.AutoSize = true;
            dataReadLabel.Location = new System.Drawing.Point(200, 39);
            dataReadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataReadLabel.Name = "dataReadLabel";
            dataReadLabel.Size = new System.Drawing.Size(66, 15);
            dataReadLabel.TabIndex = 2;
            dataReadLabel.Text = "Stream OK:";
            // 
            // bufferSizeLabel
            // 
            bufferSizeLabel.AutoSize = true;
            bufferSizeLabel.Location = new System.Drawing.Point(14, 39);
            bufferSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bufferSizeLabel.Name = "bufferSizeLabel";
            bufferSizeLabel.Size = new System.Drawing.Size(64, 15);
            bufferSizeLabel.TabIndex = 2;
            bufferSizeLabel.Text = "Buffer size:";
            // 
            // bufferSizeEdit
            // 
            bufferSizeEdit.Increment = "1";
            bufferSizeEdit.Location = new System.Drawing.Point(315, 7);
            bufferSizeEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bufferSizeEdit.Name = "bufferSizeEdit";
            bufferSizeEdit.ReFormat = "0";
            bufferSizeEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            bufferSizeEdit.Scientific = false;
            bufferSizeEdit.Size = new System.Drawing.Size(70, 23);
            bufferSizeEdit.TabIndex = 1;
            bufferSizeEdit.Value = "500";
            bufferSizeEdit.Click += bufferSizeEdit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(200, 9);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(105, 15);
            label2.TabIndex = 0;
            label2.Text = "Output buffer size:";
            // 
            // inputBufferEdit
            // 
            inputBufferEdit.Increment = "1";
            inputBufferEdit.Location = new System.Drawing.Point(120, 7);
            inputBufferEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            inputBufferEdit.Name = "inputBufferEdit";
            inputBufferEdit.ReFormat = "0";
            inputBufferEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            inputBufferEdit.Scientific = false;
            inputBufferEdit.Size = new System.Drawing.Size(70, 23);
            inputBufferEdit.TabIndex = 1;
            inputBufferEdit.Value = "500";
            inputBufferEdit.Click += inputBufferEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 9);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Input buffer size:";
            // 
            // splitter1
            // 
            splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            splitter1.Location = new System.Drawing.Point(0, 175);
            splitter1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new System.Drawing.Size(1168, 3);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(splitter2);
            panel2.Controls.Add(signalChart2);
            panel2.Controls.Add(signalChart1);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 178);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1168, 519);
            panel2.TabIndex = 3;
            // 
            // splitter2
            // 
            splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            splitter2.Location = new System.Drawing.Point(0, 135);
            splitter2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            splitter2.Name = "splitter2";
            splitter2.Size = new System.Drawing.Size(1168, 3);
            splitter2.TabIndex = 5;
            splitter2.TabStop = false;
            // 
            // signalChart2
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Bottom.Grid.DrawEvery = 1;
            signalChart2.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            signalChart2.Axes.Bottom.Labels.Brush.Solid = true;
            signalChart2.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            signalChart2.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            signalChart2.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            signalChart2.Axes.Bottom.Labels.Font.Brush.Solid = true;
            signalChart2.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            signalChart2.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            signalChart2.Axes.Bottom.Labels.Font.Size = 9;
            signalChart2.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            signalChart2.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart2.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            signalChart2.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            signalChart2.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            signalChart2.Axes.Bottom.Title.Brush.Solid = true;
            signalChart2.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart2.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            signalChart2.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            signalChart2.Axes.Bottom.Title.Font.Brush.Solid = true;
            signalChart2.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            signalChart2.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            signalChart2.Axes.Bottom.Title.Font.Size = 11;
            signalChart2.Axes.Bottom.Title.Font.SizeFloat = 11F;
            signalChart2.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart2.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            signalChart2.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            signalChart2.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            signalChart2.Axes.Depth.Labels.Brush.Solid = true;
            signalChart2.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            signalChart2.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            signalChart2.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            signalChart2.Axes.Depth.Labels.Font.Brush.Solid = true;
            signalChart2.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            signalChart2.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            signalChart2.Axes.Depth.Labels.Font.Size = 9;
            signalChart2.Axes.Depth.Labels.Font.SizeFloat = 9F;
            signalChart2.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart2.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            signalChart2.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            signalChart2.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            signalChart2.Axes.Depth.Title.Brush.Solid = true;
            signalChart2.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart2.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            signalChart2.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            signalChart2.Axes.Depth.Title.Font.Brush.Solid = true;
            signalChart2.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            signalChart2.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            signalChart2.Axes.Depth.Title.Font.Size = 11;
            signalChart2.Axes.Depth.Title.Font.SizeFloat = 11F;
            signalChart2.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart2.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            signalChart2.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Axes.Depth.Title.Shadow.Brush.Solid = true;
            signalChart2.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            signalChart2.Axes.DepthTop.Labels.Brush.Solid = true;
            signalChart2.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            signalChart2.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            signalChart2.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            signalChart2.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            signalChart2.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            signalChart2.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            signalChart2.Axes.DepthTop.Labels.Font.Size = 9;
            signalChart2.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            signalChart2.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            signalChart2.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            signalChart2.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            signalChart2.Axes.DepthTop.Title.Brush.Solid = true;
            signalChart2.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart2.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            signalChart2.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            signalChart2.Axes.DepthTop.Title.Font.Brush.Solid = true;
            signalChart2.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            signalChart2.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            signalChart2.Axes.DepthTop.Title.Font.Size = 11;
            signalChart2.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            signalChart2.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart2.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            signalChart2.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            signalChart2.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            signalChart2.Axes.Left.Labels.Brush.Solid = true;
            signalChart2.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            signalChart2.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            signalChart2.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            signalChart2.Axes.Left.Labels.Font.Brush.Solid = true;
            signalChart2.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            signalChart2.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            signalChart2.Axes.Left.Labels.Font.Size = 9;
            signalChart2.Axes.Left.Labels.Font.SizeFloat = 9F;
            signalChart2.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart2.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            signalChart2.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Axes.Left.Labels.Shadow.Brush.Solid = true;
            signalChart2.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            signalChart2.Axes.Left.Title.Brush.Solid = true;
            signalChart2.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart2.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            signalChart2.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            signalChart2.Axes.Left.Title.Font.Brush.Solid = true;
            signalChart2.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            signalChart2.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            signalChart2.Axes.Left.Title.Font.Size = 11;
            signalChart2.Axes.Left.Title.Font.SizeFloat = 11F;
            signalChart2.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart2.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            signalChart2.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Axes.Left.Title.Shadow.Brush.Solid = true;
            signalChart2.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            signalChart2.Axes.Right.Labels.Brush.Solid = true;
            signalChart2.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            signalChart2.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            signalChart2.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            signalChart2.Axes.Right.Labels.Font.Brush.Solid = true;
            signalChart2.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            signalChart2.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            signalChart2.Axes.Right.Labels.Font.Size = 9;
            signalChart2.Axes.Right.Labels.Font.SizeFloat = 9F;
            signalChart2.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart2.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            signalChart2.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Axes.Right.Labels.Shadow.Brush.Solid = true;
            signalChart2.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            signalChart2.Axes.Right.Title.Brush.Solid = true;
            signalChart2.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart2.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            signalChart2.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            signalChart2.Axes.Right.Title.Font.Brush.Solid = true;
            signalChart2.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            signalChart2.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            signalChart2.Axes.Right.Title.Font.Size = 11;
            signalChart2.Axes.Right.Title.Font.SizeFloat = 11F;
            signalChart2.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart2.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            signalChart2.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Axes.Right.Title.Shadow.Brush.Solid = true;
            signalChart2.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            signalChart2.Axes.Top.Labels.Brush.Solid = true;
            signalChart2.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            signalChart2.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            signalChart2.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            signalChart2.Axes.Top.Labels.Font.Brush.Solid = true;
            signalChart2.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            signalChart2.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            signalChart2.Axes.Top.Labels.Font.Size = 9;
            signalChart2.Axes.Top.Labels.Font.SizeFloat = 9F;
            signalChart2.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart2.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            signalChart2.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Axes.Top.Labels.Shadow.Brush.Solid = true;
            signalChart2.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            signalChart2.Axes.Top.Title.Brush.Solid = true;
            signalChart2.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart2.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            signalChart2.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            signalChart2.Axes.Top.Title.Font.Brush.Solid = true;
            signalChart2.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            signalChart2.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            signalChart2.Axes.Top.Title.Font.Size = 11;
            signalChart2.Axes.Top.Title.Font.SizeFloat = 11F;
            signalChart2.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart2.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            signalChart2.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Axes.Top.Title.Shadow.Brush.Solid = true;
            signalChart2.Axes.Top.Title.Shadow.Brush.Visible = true;
            signalChart2.Color = System.Drawing.Color.White;
            signalChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Footer.Brush.Color = System.Drawing.Color.Silver;
            signalChart2.Footer.Brush.Solid = true;
            signalChart2.Footer.Brush.Visible = true;
            // 
            // 
            // 
            signalChart2.Footer.Font.Bold = false;
            // 
            // 
            // 
            signalChart2.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            signalChart2.Footer.Font.Brush.Solid = true;
            signalChart2.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Footer.Font.Shadow.Brush.Solid = true;
            signalChart2.Footer.Font.Shadow.Brush.Visible = true;
            signalChart2.Footer.Font.Size = 8;
            signalChart2.Footer.Font.SizeFloat = 8F;
            signalChart2.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart2.Footer.ImageBevel.Brush.Solid = true;
            signalChart2.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Footer.Shadow.Brush.Solid = true;
            signalChart2.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Header.Brush.Color = System.Drawing.Color.FromArgb(192, 192, 192);
            signalChart2.Header.Brush.Solid = true;
            signalChart2.Header.Brush.Visible = true;
            // 
            // 
            // 
            signalChart2.Header.Font.Bold = false;
            // 
            // 
            // 
            signalChart2.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            signalChart2.Header.Font.Brush.Solid = true;
            signalChart2.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Header.Font.Shadow.Brush.Solid = true;
            signalChart2.Header.Font.Shadow.Brush.Visible = true;
            signalChart2.Header.Font.Size = 12;
            signalChart2.Header.Font.SizeFloat = 12F;
            signalChart2.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart2.Header.ImageBevel.Brush.Solid = true;
            signalChart2.Header.ImageBevel.Brush.Visible = true;
            signalChart2.Header.Lines = new string[]
    {
    "Signal buffer chart"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(169, 169, 169);
            signalChart2.Header.Shadow.Brush.Solid = true;
            signalChart2.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Legend.Brush.Color = System.Drawing.Color.White;
            signalChart2.Legend.Brush.Solid = true;
            signalChart2.Legend.Brush.Visible = true;
            signalChart2.Legend.CheckBoxes = false;
            // 
            // 
            // 
            signalChart2.Legend.Font.Bold = false;
            // 
            // 
            // 
            signalChart2.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            signalChart2.Legend.Font.Brush.Solid = true;
            signalChart2.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Legend.Font.Shadow.Brush.Solid = true;
            signalChart2.Legend.Font.Shadow.Brush.Visible = true;
            signalChart2.Legend.Font.Size = 9;
            signalChart2.Legend.Font.SizeFloat = 9F;
            signalChart2.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart2.Legend.ImageBevel.Brush.Solid = true;
            signalChart2.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(0, 0, 0);
            signalChart2.Legend.Shadow.Brush.Solid = true;
            signalChart2.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Legend.Symbol.Shadow.Brush.Solid = true;
            signalChart2.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Legend.Title.Brush.Color = System.Drawing.Color.White;
            signalChart2.Legend.Title.Brush.Solid = true;
            signalChart2.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart2.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            signalChart2.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            signalChart2.Legend.Title.Font.Brush.Solid = true;
            signalChart2.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Legend.Title.Font.Shadow.Brush.Solid = true;
            signalChart2.Legend.Title.Font.Shadow.Brush.Visible = true;
            signalChart2.Legend.Title.Font.Size = 8;
            signalChart2.Legend.Title.Font.SizeFloat = 8F;
            signalChart2.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart2.Legend.Title.ImageBevel.Brush.Solid = true;
            signalChart2.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Legend.Title.Shadow.Brush.Solid = true;
            signalChart2.Legend.Title.Shadow.Brush.Visible = true;
            signalChart2.Legend.Visible = false;
            signalChart2.Location = new System.Drawing.Point(0, 135);
            signalChart2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            signalChart2.Name = "signalChart2";
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Panel.Brush.Color = System.Drawing.Color.White;
            signalChart2.Panel.Brush.Solid = true;
            signalChart2.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart2.Panel.ImageBevel.Brush.Solid = true;
            signalChart2.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Panel.Shadow.Brush.Solid = true;
            signalChart2.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins2.Bottom = 100;
            margins2.Left = 100;
            margins2.Right = 100;
            margins2.Top = 100;
            signalChart2.Printer.Margins = margins2;
            signalChart2.Series.Add(fastLine3);
            signalTeeItem1.Caption = null;
            signalTeeItem1.Input = signalStoreBuffer1;
            signalTeeItem1.Inputs = null;
            signalTeeItem1.InputsItemIndex = 0;
            signalTeeItem1.Series = fastLine3;
            signalTeeItem1.SeriesName = "fastLine1";
            signalChart2.Signals.Add(signalTeeItem1);
            signalChart2.Size = new System.Drawing.Size(1168, 384);
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            signalChart2.SubFooter.Brush.Solid = true;
            signalChart2.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            signalChart2.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            signalChart2.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            signalChart2.SubFooter.Font.Brush.Solid = true;
            signalChart2.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.SubFooter.Font.Shadow.Brush.Solid = true;
            signalChart2.SubFooter.Font.Shadow.Brush.Visible = true;
            signalChart2.SubFooter.Font.Size = 8;
            signalChart2.SubFooter.Font.SizeFloat = 8F;
            signalChart2.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart2.SubFooter.ImageBevel.Brush.Solid = true;
            signalChart2.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.SubFooter.Shadow.Brush.Solid = true;
            signalChart2.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(192, 192, 192);
            signalChart2.SubHeader.Brush.Solid = true;
            signalChart2.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            signalChart2.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            signalChart2.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            signalChart2.SubHeader.Font.Brush.Solid = true;
            signalChart2.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.SubHeader.Font.Shadow.Brush.Solid = true;
            signalChart2.SubHeader.Font.Shadow.Brush.Visible = true;
            signalChart2.SubHeader.Font.Size = 12;
            signalChart2.SubHeader.Font.SizeFloat = 12F;
            signalChart2.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart2.SubHeader.ImageBevel.Brush.Solid = true;
            signalChart2.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(169, 169, 169);
            signalChart2.SubHeader.Shadow.Brush.Solid = true;
            signalChart2.SubHeader.Shadow.Brush.Visible = true;
            signalChart2.TabIndex = 4;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            signalChart2.Walls.Back.Brush.Solid = true;
            signalChart2.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart2.Walls.Back.ImageBevel.Brush.Solid = true;
            signalChart2.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Walls.Back.Shadow.Brush.Solid = true;
            signalChart2.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            signalChart2.Walls.Bottom.Brush.Solid = true;
            signalChart2.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart2.Walls.Bottom.ImageBevel.Brush.Solid = true;
            signalChart2.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Walls.Bottom.Shadow.Brush.Solid = true;
            signalChart2.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            signalChart2.Walls.Left.Brush.Solid = true;
            signalChart2.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart2.Walls.Left.ImageBevel.Brush.Solid = true;
            signalChart2.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Walls.Left.Shadow.Brush.Solid = true;
            signalChart2.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            signalChart2.Walls.Right.Brush.Solid = true;
            signalChart2.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart2.Walls.Right.ImageBevel.Brush.Solid = true;
            signalChart2.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart2.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart2.Walls.Right.Shadow.Brush.Solid = true;
            signalChart2.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            signalChart2.Zoom.Animated = true;
            // 
            // 
            // 
            signalChart2.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            signalChart2.Zoom.Brush.Solid = true;
            signalChart2.Zoom.Brush.Visible = false;
            signalChart2.Zoom.History = true;
            // 
            // signalChart1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Grid.DrawEvery = 1;
            signalChart1.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            signalChart1.Axes.Bottom.Labels.Brush.Solid = true;
            signalChart1.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            signalChart1.Axes.Bottom.Labels.Font.Brush.Solid = true;
            signalChart1.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Bottom.Labels.Font.Size = 9;
            signalChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            signalChart1.Axes.Bottom.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            signalChart1.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            signalChart1.Axes.Bottom.Title.Brush.Solid = true;
            signalChart1.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            signalChart1.Axes.Bottom.Title.Font.Brush.Solid = true;
            signalChart1.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Bottom.Title.Font.Size = 11;
            signalChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            signalChart1.Axes.Bottom.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            signalChart1.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            signalChart1.Axes.Depth.Labels.Brush.Solid = true;
            signalChart1.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            signalChart1.Axes.Depth.Labels.Font.Brush.Solid = true;
            signalChart1.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Depth.Labels.Font.Size = 9;
            signalChart1.Axes.Depth.Labels.Font.SizeFloat = 9F;
            signalChart1.Axes.Depth.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            signalChart1.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            signalChart1.Axes.Depth.Title.Brush.Solid = true;
            signalChart1.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            signalChart1.Axes.Depth.Title.Font.Brush.Solid = true;
            signalChart1.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Depth.Title.Font.Size = 11;
            signalChart1.Axes.Depth.Title.Font.SizeFloat = 11F;
            signalChart1.Axes.Depth.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Depth.Title.Shadow.Brush.Solid = true;
            signalChart1.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            signalChart1.Axes.DepthTop.Labels.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            signalChart1.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.DepthTop.Labels.Font.Size = 9;
            signalChart1.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            signalChart1.Axes.DepthTop.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            signalChart1.Axes.DepthTop.Title.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            signalChart1.Axes.DepthTop.Title.Font.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.DepthTop.Title.Font.Size = 11;
            signalChart1.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            signalChart1.Axes.DepthTop.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            signalChart1.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            signalChart1.Axes.Left.Labels.Brush.Solid = true;
            signalChart1.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            signalChart1.Axes.Left.Labels.Font.Brush.Solid = true;
            signalChart1.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Left.Labels.Font.Size = 9;
            signalChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            signalChart1.Axes.Left.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Left.Labels.Shadow.Brush.Solid = true;
            signalChart1.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            signalChart1.Axes.Left.Title.Brush.Solid = true;
            signalChart1.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            signalChart1.Axes.Left.Title.Font.Brush.Solid = true;
            signalChart1.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Left.Title.Font.Size = 11;
            signalChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            signalChart1.Axes.Left.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Left.Title.Shadow.Brush.Solid = true;
            signalChart1.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            signalChart1.Axes.Right.Labels.Brush.Solid = true;
            signalChart1.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            signalChart1.Axes.Right.Labels.Font.Brush.Solid = true;
            signalChart1.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Right.Labels.Font.Size = 9;
            signalChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            signalChart1.Axes.Right.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Right.Labels.Shadow.Brush.Solid = true;
            signalChart1.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            signalChart1.Axes.Right.Title.Brush.Solid = true;
            signalChart1.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            signalChart1.Axes.Right.Title.Font.Brush.Solid = true;
            signalChart1.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Right.Title.Font.Size = 11;
            signalChart1.Axes.Right.Title.Font.SizeFloat = 11F;
            signalChart1.Axes.Right.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Right.Title.Shadow.Brush.Solid = true;
            signalChart1.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            signalChart1.Axes.Top.Labels.Brush.Solid = true;
            signalChart1.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            signalChart1.Axes.Top.Labels.Font.Brush.Solid = true;
            signalChart1.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Top.Labels.Font.Size = 9;
            signalChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            signalChart1.Axes.Top.Labels.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Top.Labels.Shadow.Brush.Solid = true;
            signalChart1.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            signalChart1.Axes.Top.Title.Brush.Solid = true;
            signalChart1.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            signalChart1.Axes.Top.Title.Font.Brush.Solid = true;
            signalChart1.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            signalChart1.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            signalChart1.Axes.Top.Title.Font.Size = 11;
            signalChart1.Axes.Top.Title.Font.SizeFloat = 11F;
            signalChart1.Axes.Top.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            signalChart1.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Axes.Top.Title.Shadow.Brush.Solid = true;
            signalChart1.Axes.Top.Title.Shadow.Brush.Visible = true;
            signalChart1.Color = System.Drawing.Color.White;
            signalChart1.Dock = System.Windows.Forms.DockStyle.Top;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Footer.Brush.Color = System.Drawing.Color.Silver;
            signalChart1.Footer.Brush.Solid = true;
            signalChart1.Footer.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Footer.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            signalChart1.Footer.Font.Brush.Solid = true;
            signalChart1.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Footer.Font.Shadow.Brush.Solid = true;
            signalChart1.Footer.Font.Shadow.Brush.Visible = true;
            signalChart1.Footer.Font.Size = 8;
            signalChart1.Footer.Font.SizeFloat = 8F;
            signalChart1.Footer.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Footer.ImageBevel.Brush.Solid = true;
            signalChart1.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Footer.Shadow.Brush.Solid = true;
            signalChart1.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Header.Brush.Color = System.Drawing.Color.FromArgb(192, 192, 192);
            signalChart1.Header.Brush.Solid = true;
            signalChart1.Header.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Header.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            signalChart1.Header.Font.Brush.Solid = true;
            signalChart1.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Header.Font.Shadow.Brush.Solid = true;
            signalChart1.Header.Font.Shadow.Brush.Visible = true;
            signalChart1.Header.Font.Size = 12;
            signalChart1.Header.Font.SizeFloat = 12F;
            signalChart1.Header.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Header.ImageBevel.Brush.Solid = true;
            signalChart1.Header.ImageBevel.Brush.Visible = true;
            signalChart1.Header.Lines = new string[]
    {
    "Signal generator chart"
    };
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(169, 169, 169);
            signalChart1.Header.Shadow.Brush.Solid = true;
            signalChart1.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.Brush.Color = System.Drawing.Color.White;
            signalChart1.Legend.Brush.Solid = true;
            signalChart1.Legend.Brush.Visible = true;
            signalChart1.Legend.CheckBoxes = false;
            // 
            // 
            // 
            signalChart1.Legend.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(64, 64, 64);
            signalChart1.Legend.Font.Brush.Solid = true;
            signalChart1.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Legend.Font.Shadow.Brush.Solid = true;
            signalChart1.Legend.Font.Shadow.Brush.Visible = true;
            signalChart1.Legend.Font.Size = 9;
            signalChart1.Legend.Font.SizeFloat = 9F;
            signalChart1.Legend.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Legend.ImageBevel.Brush.Solid = true;
            signalChart1.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(0, 0, 0);
            signalChart1.Legend.Shadow.Brush.Solid = true;
            signalChart1.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Legend.Symbol.Shadow.Brush.Solid = true;
            signalChart1.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.Title.Brush.Color = System.Drawing.Color.White;
            signalChart1.Legend.Title.Brush.Solid = true;
            signalChart1.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            signalChart1.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            signalChart1.Legend.Title.Font.Brush.Solid = true;
            signalChart1.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Legend.Title.Font.Shadow.Brush.Solid = true;
            signalChart1.Legend.Title.Font.Shadow.Brush.Visible = true;
            signalChart1.Legend.Title.Font.Size = 8;
            signalChart1.Legend.Title.Font.SizeFloat = 8F;
            signalChart1.Legend.Title.Font.Style = Steema.TeeChart.Drawing.FontStyle.Bold;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Legend.Title.ImageBevel.Brush.Solid = true;
            signalChart1.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Legend.Title.Shadow.Brush.Solid = true;
            signalChart1.Legend.Title.Shadow.Brush.Visible = true;
            signalChart1.Legend.Visible = false;
            signalChart1.Location = new System.Drawing.Point(0, 0);
            signalChart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            signalChart1.Name = "signalChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Panel.Brush.Color = System.Drawing.Color.White;
            signalChart1.Panel.Brush.Solid = true;
            signalChart1.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Panel.ImageBevel.Brush.Solid = true;
            signalChart1.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Panel.Shadow.Brush.Solid = true;
            signalChart1.Panel.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            margins3.Bottom = 100;
            margins3.Left = 100;
            margins3.Right = 100;
            margins3.Top = 100;
            signalChart1.Printer.Margins = margins3;
            signalChart1.Series.Add(fastLine2);
            signalTeeItem2.Caption = null;
            signalTeeItem2.Input = signalGenerator1;
            signalTeeItem2.Inputs = null;
            signalTeeItem2.InputsItemIndex = 0;
            signalTeeItem2.Series = fastLine2;
            signalTeeItem2.SeriesName = "fastLine2";
            signalChart1.Signals.Add(signalTeeItem2);
            signalChart1.Size = new System.Drawing.Size(1168, 135);
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            signalChart1.SubFooter.Brush.Solid = true;
            signalChart1.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            signalChart1.SubFooter.Font.Brush.Solid = true;
            signalChart1.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.SubFooter.Font.Shadow.Brush.Solid = true;
            signalChart1.SubFooter.Font.Shadow.Brush.Visible = true;
            signalChart1.SubFooter.Font.Size = 8;
            signalChart1.SubFooter.Font.SizeFloat = 8F;
            signalChart1.SubFooter.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.SubFooter.ImageBevel.Brush.Solid = true;
            signalChart1.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.SubFooter.Shadow.Brush.Solid = true;
            signalChart1.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(192, 192, 192);
            signalChart1.SubHeader.Brush.Solid = true;
            signalChart1.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            signalChart1.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(128, 128, 128);
            signalChart1.SubHeader.Font.Brush.Solid = true;
            signalChart1.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.SubHeader.Font.Shadow.Brush.Solid = true;
            signalChart1.SubHeader.Font.Shadow.Brush.Visible = true;
            signalChart1.SubHeader.Font.Size = 12;
            signalChart1.SubHeader.Font.SizeFloat = 12F;
            signalChart1.SubHeader.Font.Style = Steema.TeeChart.Drawing.FontStyle.Regular;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.SubHeader.ImageBevel.Brush.Solid = true;
            signalChart1.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(169, 169, 169);
            signalChart1.SubHeader.Shadow.Brush.Solid = true;
            signalChart1.SubHeader.Shadow.Brush.Visible = true;
            signalChart1.TabIndex = 3;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            signalChart1.Walls.Back.Brush.Solid = true;
            signalChart1.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Walls.Back.ImageBevel.Brush.Solid = true;
            signalChart1.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Walls.Back.Shadow.Brush.Solid = true;
            signalChart1.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            signalChart1.Walls.Bottom.Brush.Solid = true;
            signalChart1.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Walls.Bottom.ImageBevel.Brush.Solid = true;
            signalChart1.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Walls.Bottom.Shadow.Brush.Solid = true;
            signalChart1.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            signalChart1.Walls.Left.Brush.Solid = true;
            signalChart1.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Walls.Left.ImageBevel.Brush.Solid = true;
            signalChart1.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Walls.Left.Shadow.Brush.Solid = true;
            signalChart1.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            signalChart1.Walls.Right.Brush.Solid = true;
            signalChart1.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            signalChart1.Walls.Right.ImageBevel.Brush.Solid = true;
            signalChart1.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            signalChart1.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            signalChart1.Walls.Right.Shadow.Brush.Solid = true;
            signalChart1.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            signalChart1.Zoom.Animated = true;
            // 
            // 
            // 
            signalChart1.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            signalChart1.Zoom.Brush.Solid = true;
            signalChart1.Zoom.Brush.Visible = false;
            signalChart1.Zoom.History = true;
            // 
            // CircularBufferForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1168, 842);
            Controls.Add(panel2);
            Controls.Add(splitter1);
            Controls.Add(panel1);
            Controls.Add(spectrumChart1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "CircularBufferForm";
            Text = "CircularBufferForm";
            Load += CircularBufferForm_Load;
            ((System.ComponentModel.ISupportInitialize)spectrumChart1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)signalChart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)signalChart1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Dew.Signal.Tee.SpectrumChart spectrumChart1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel2;
		private Dew.Signal.TSignalGenerator signalGenerator1;
		private Dew.Signal.TSignalBuffer signalBuffer1;
		private Dew.Signal.TSignalStoreBuffer signalStoreBuffer1;
		private Dew.Signal.TSpectrumAnalyzer spectrumAnalyzer1;
		private Steema.TeeChart.Styles.FastLine fastLine1;
		private System.Windows.Forms.Splitter splitter2;
		private Dew.Signal.Tee.SignalChart signalChart2;
		private Dew.Signal.Tee.SignalChart signalChart1;
		private Steema.TeeChart.Styles.FastLine fastLine2;
		private Steema.TeeChart.Styles.FastLine fastLine3;
		private System.Windows.Forms.Label storeBufferLabel;
		private System.Windows.Forms.Label unreadBufferDataLabel;
		private System.Windows.Forms.Label inputBufferSizeLabel;
		private System.Windows.Forms.Label bufferSizeLabel;
		private Dew.Math.Controls.FloatEdit bufferSizeEdit;
		private System.Windows.Forms.Label label2;
		private Dew.Math.Controls.FloatEdit inputBufferEdit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Label signalUpdateLabel;
		private System.Windows.Forms.Label writeCursorLabel;
		private System.Windows.Forms.Label readCursorLabel;
		private System.Windows.Forms.Label dataReadLabel;
	}
}