using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Controls;
using Dew.Math.Editors;

namespace MtxVecDemo
{
	public class DataSetDemo : MtxVecDemo.BasicForm2
	{
		private System.Data.DataSet dataSet1;
		private System.Data.DataTable dataTable1;
		private System.Data.DataColumn dataColumn1;
		private System.Data.DataTable dataTable2;
		private System.Data.DataColumn dataColumn2;
		private System.Windows.Forms.Button button1;
        private System.Data.DataColumn dataColumn4;
        private System.Windows.Forms.Button button3;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private MtxGridView mtxGridView1;
        private MtxDataset mtxDataset1;
        private MtxDataset mtxDataset2;
        private VecColumn vecColumnBinary;
        private VecColumn vecColumnValues;
		private System.ComponentModel.IContainer components = null;

		public DataSetDemo()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataSet1 = new System.Data.DataSet();
            dataTable1 = new System.Data.DataTable();
            dataColumn1 = new System.Data.DataColumn();
            dataColumn4 = new System.Data.DataColumn();
            dataTable2 = new System.Data.DataTable();
            dataColumn2 = new System.Data.DataColumn();
            button1 = new Button();
            button3 = new Button();
            mtxGridView1 = new MtxGridView();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            mtxDataset1 = new MtxDataset();
            vecColumnBinary = new VecColumn();
            mtxDataset2 = new MtxDataset();
            vecColumnValues = new VecColumn();
            panel2.SuspendLayout();
            ((ISupportInitialize)dataSet1).BeginInit();
            ((ISupportInitialize)dataTable1).BeginInit();
            ((ISupportInitialize)dataTable2).BeginInit();
            ((ISupportInitialize)mtxGridView1).BeginInit();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(mtxGridView1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Size = new Size(965, 389);
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 527);
            panel3.Size = new Size(965, 59);
            // 
            // richTextBox1
            // 
            richTextBox1.Size = new Size(965, 138);
            // 
            // dataSet1
            // 
            dataSet1.DataSetName = "NewDataSet";
            dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            dataSet1.Tables.AddRange(new System.Data.DataTable[] { dataTable1, dataTable2 });
            // 
            // dataTable1
            // 
            dataTable1.Columns.AddRange(new System.Data.DataColumn[] { dataColumn1, dataColumn4 });
            dataTable1.Namespace = "";
            dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            dataColumn1.Caption = "Values";
            dataColumn1.ColumnName = "BinVec";
            dataColumn1.DataType = typeof(byte);
            dataColumn1.Namespace = "";
            // 
            // dataColumn4
            // 
            dataColumn4.Caption = "DateTime stamp";
            dataColumn4.ColumnName = "Stamp";
            dataColumn4.DataType = typeof(DateTime);
            dataColumn4.Namespace = "";
            // 
            // dataTable2
            // 
            dataTable2.Columns.AddRange(new System.Data.DataColumn[] { dataColumn2 });
            dataTable2.Namespace = "";
            dataTable2.TableName = "Table2";
            // 
            // dataColumn2
            // 
            dataColumn2.Caption = "Values";
            dataColumn2.ColumnName = "Values";
            dataColumn2.DataType = typeof(double);
            dataColumn2.Namespace = "";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(19, 20);
            button1.Name = "button1";
            button1.Size = new Size(125, 28);
            button1.TabIndex = 0;
            button1.Text = "Save (binary)";
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.System;
            button3.Location = new Point(19, 55);
            button3.Name = "button3";
            button3.Size = new Size(125, 29);
            button3.TabIndex = 4;
            button3.Text = "Save (numeric)";
            button3.Click += button3_Click;
            // 
            // mtxGridView1
            // 
            mtxGridView1.AllowUserToAddRows = false;
            mtxGridView1.AllowUserToDeleteRows = false;
            mtxGridView1.AllowUserToResizeColumns = false;
            mtxGridView1.AllowUserToResizeRows = false;
            mtxGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            mtxGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            mtxGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            mtxGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "0.0000";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            mtxGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            mtxGridView1.Location = new Point(724, 47);
            mtxGridView1.MultiSelect = false;
            mtxGridView1.Name = "mtxGridView1";
            mtxGridView1.numberFormat = "0.0000";
            mtxGridView1.ObjectInfoText = "";
            mtxGridView1.ReadOnly = true;
            mtxGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            mtxGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            mtxGridView1.ShowObjectInfo = true;
            mtxGridView1.Size = new Size(227, 342);
            mtxGridView1.TabIndex = 5;
            mtxGridView1.VirtualMode = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(720, 20);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 6;
            label1.Text = "Selected vector values";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = dataSet1;
            dataGridView1.Location = new Point(168, 47);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(533, 342);
            dataGridView1.TabIndex = 7;
            dataGridView1.RowEnter += dataGridView1_RowEnter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 20);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 8;
            label2.Text = "Saved stream of values";
            // 
            // mtxDataset1
            // 
            mtxDataset1.Columns.Add(vecColumnBinary);
            mtxDataset1.DataTable = dataTable1;
            mtxDataset1.ReadWriteMode = ReadWriteMode.wmRecord;
            // 
            // vecColumnBinary
            // 
            vecColumnBinary.ColumnName = "BinVec";
            vecColumnBinary.ReadWriteMode = ReadWriteMode.wmRecord;
            // 
            // mtxDataset2
            // 
            mtxDataset2.Columns.Add(vecColumnValues);
            mtxDataset2.DataTable = dataTable2;
            mtxDataset2.ReadWriteMode = ReadWriteMode.wmColumn;
            // 
            // vecColumnValues
            // 
            vecColumnValues.ColumnName = "Values";
            // 
            // DataSetDemo
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(965, 586);
            Name = "DataSetDemo";
            Load += DataSetDemo_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((ISupportInitialize)dataSet1).EndInit();
            ((ISupportInitialize)dataTable1).EndInit();
            ((ISupportInitialize)dataTable2).EndInit();
            ((ISupportInitialize)mtxGridView1).EndInit();
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }
        #endregion

        private void SetupBinary()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("BinVec","Stream");
            dataGridView1.Columns.Add("Stamp","Datetime");
            dataGridView1.Columns[1].DataPropertyName = "Stamp";
            dataGridView1.Columns[1].DefaultCellStyle.Format = "dd-mm-yyyy hh:mm:ss";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView1.DataMember = "Table1";
        }

        private void SetupNumeric()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Columns.Clear();
            dataGridView1.DataMember = "Table2";
        }

		private void button1_Click(object sender, System.EventArgs e)
		{
            mtxDataset1.Columns[0].Vector.Size(100);
            mtxDataset1.Columns[0].Vector.RandGauss();

			// create new row in Table1
            System.Data.DataRow r = dataSet1.Tables["Table1"].NewRow();
			// Write Vector to byte[] column
            mtxDataset1.Columns[0].WriteDataRow(r);
            // Add datetime stamp
            r["Stamp"] = DateTime.Now;

            // add row to Table1
			dataSet1.Tables["Table1"].Rows.Add(r);

            SetupBinary();
		}


		private void button3_Click(object sender, System.EventArgs e)
		{
			mtxDataset2.Columns[0].Vector.Size(50);
			mtxDataset2.Columns[0].Vector.RandGauss();

			// Write values to Table2
			mtxDataset2.Columns[0].WriteDataRow(null);

            SetupNumeric();

            // Connect to MtxGridView1
            mtxGridView1.DataObject = mtxDataset2.Columns[0].Vector;
        }

		private void DataSetDemo_Load(object sender, System.EventArgs e)
		{
			richTextBox1.Clear();
			Add("The MtxDataset control allows easy save/load operations on any DataTable. " 
				+	"Using this control you can either save/load vector/matrix object directly to/from binary "
				+	"column (byte[]) or save/load only vector/matrix values to/from ordinary numeric column.\n");
			Add("This example demonstrates saving/loading operation in both modes (binary stream or values only). Press "
				+	" \"Save (binary)\" button to save vector to byte[] column. Press \"Save (numeric)\" button to save "
                +   "ONLY vector values to numeric column. To view saved binary values, select row in the \"Saved stream or values "
                +   "DataGridView.");
		}

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Read the latest values from binary stream
            if (e.RowIndex >= 0 && dataGridView1.DataMember == "Table1")
            {
                mtxDataset1.Columns[0].ReadDataRow(dataSet1.Tables[0].Rows[e.RowIndex]);
                mtxGridView1.DataObject = mtxDataset1.Columns[0].Vector;
                mtxGridView1.UpdateGrid();
            }

        }

	}
}

