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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataTable2 = new System.Data.DataTable();
            this.dataColumn2 = new System.Data.DataColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.mtxGridView1 = new Dew.Math.Controls.MtxGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxDataset1 = new Dew.Math.Controls.MtxDataset();
            this.vecColumnBinary = new Dew.Math.Controls.VecColumn();
            this.mtxDataset2 = new Dew.Math.Controls.MtxDataset();
            this.vecColumnValues = new Dew.Math.Controls.VecColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.mtxGridView1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Size = new System.Drawing.Size(528, 285);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(528, 48);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(528, 112);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1,
            this.dataTable2});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn4});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Values";
            this.dataColumn1.ColumnName = "BinVec";
            this.dataColumn1.DataType = typeof(byte[]);
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "DateTime stamp";
            this.dataColumn4.ColumnName = "Stamp";
            this.dataColumn4.DataType = typeof(System.DateTime);
            // 
            // dataTable2
            // 
            this.dataTable2.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn2});
            this.dataTable2.TableName = "Table2";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Values";
            this.dataColumn2.DataType = typeof(double);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(16, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save (binary)";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(16, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Save (numeric)";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mtxGridView1
            // 
            this.mtxGridView1.AllowUserToAddRows = false;
            this.mtxGridView1.AllowUserToDeleteRows = false;
            this.mtxGridView1.AllowUserToResizeColumns = false;
            this.mtxGridView1.AllowUserToResizeRows = false;
            this.mtxGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.mtxGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "0.0000";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtxGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.mtxGridView1.Location = new System.Drawing.Point(327, 38);
            this.mtxGridView1.MultiSelect = false;
            this.mtxGridView1.Name = "mtxGridView1";
            this.mtxGridView1.ObjectInfoText = "";
            this.mtxGridView1.ReadOnly = true;
            this.mtxGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.mtxGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mtxGridView1.ShowObjectInfo = true;
            this.mtxGridView1.Size = new System.Drawing.Size(189, 247);
            this.mtxGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selected vector values";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.dataSet1;
            this.dataGridView1.Location = new System.Drawing.Point(140, 38);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(168, 247);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Saved stream of values";
            // 
            // mtxDataset1
            // 
            this.mtxDataset1.Columns.Add(this.vecColumnBinary);
            this.mtxDataset1.DataTable = this.dataTable1;
            this.mtxDataset1.ReadWriteMode = Dew.Math.Controls.ReadWriteMode.wmRecord;
            // 
            // vecColumnBinary
            // 
            this.vecColumnBinary.ColumnName = "BinVec";
            this.vecColumnBinary.ReadWriteMode = Dew.Math.Controls.ReadWriteMode.wmRecord;
            // 
            // mtxDataset2
            // 
            this.mtxDataset2.Columns.Add(this.vecColumnValues);
            this.mtxDataset2.DataTable = this.dataTable2;
            this.mtxDataset2.ReadWriteMode = Dew.Math.Controls.ReadWriteMode.wmColumn;
            // 
            // vecColumnValues
            // 
            this.vecColumnValues.ColumnName = "Values";
            // 
            // DataSetDemo
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(528, 445);
            this.Name = "DataSetDemo";
            this.Load += new System.EventHandler(this.DataSetDemo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

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

