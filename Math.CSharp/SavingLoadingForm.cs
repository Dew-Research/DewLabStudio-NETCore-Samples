using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Units;
using Dew.Math.Editors;
using System.IO;
using System.Data.OleDb;
using System.Data;

namespace MtxVecDemo
{
	public class SavingLoadingForm : MtxVecDemo.BasicForm2
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.ComponentModel.IContainer components = null;

		public SavingLoadingForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
            aMtx = new Matrix(0, 0);
            aVec = new Vector(0);
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
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(checkBox1);
            panel2.Size = new Size(769, 362);
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 500);
            panel3.Size = new Size(769, 59);
            // 
            // richTextBox1
            // 
            richTextBox1.Size = new Size(769, 138);
            // 
            // checkBox1
            // 
            checkBox1.FlatStyle = FlatStyle.System;
            checkBox1.Location = new Point(19, 10);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(154, 20);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "View loaded values";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(192, 39);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(568, 317);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(192, 20);
            label1.Name = "label1";
            label1.Size = new Size(115, 19);
            label1.TabIndex = 2;
            label1.Text = "Code used:";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(10, 39);
            button1.Name = "button1";
            button1.Size = new Size(172, 30);
            button1.TabIndex = 3;
            button1.Text = "Streams : Read/Write";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(10, 79);
            button2.Name = "button2";
            button2.Size = new Size(172, 29);
            button2.TabIndex = 4;
            button2.Text = "Binary files : Read/Write";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.System;
            button3.Location = new Point(10, 118);
            button3.Name = "button3";
            button3.Size = new Size(172, 30);
            button3.TabIndex = 5;
            button3.Text = "BLOB fields : Read/Write";
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.System;
            button4.Location = new Point(10, 158);
            button4.Name = "button4";
            button4.Size = new Size(172, 29);
            button4.TabIndex = 6;
            button4.Text = "Text files : Read/Write";
            button4.Click += button4_Click;
            // 
            // SavingLoadingForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(769, 559);
            Name = "SavingLoadingForm";
            Load += SavingLoadingForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }
        #endregion

        private Matrix aMtx;
		private Vector aVec;
		
		private void Add2(String s) {
			textBox1.Text += s + "\r\n";
		}

		private void button1_Click(object sender, System.EventArgs e) {
			textBox1.Clear();
			Add2("aMtx.Size(10,10);");
			Add2("aMtx.RandGauss();");
			Add2("MemoryStream stream = new MemoryStream();");
			Add2("try {");
            Add2("\taMtx.SaveToStream((System.IO.Stream)stream);");
            Add2("\tMatrix tmpMtx = new Matrix(0,0);");
            Add2("\tstream.Seek(0,SeekOrigin.Begin);");
            Add2("\ttmpMtx.LoadFromStream((System.IO.Stream)stream);");
			Add2("} finally {");
            Add2("\tstream.Close();");
			Add2("}");

			aMtx.Size(10,10);
			aMtx.RandGauss();
			MemoryStream stream = new MemoryStream();
			try 
            {
				aMtx.SaveToStream((System.IO.Stream)stream);
                Matrix tmpMtx = new Matrix(0, 0);
    			stream.Seek(0,SeekOrigin.Begin);
				tmpMtx.LoadFromStream((System.IO.Stream)stream);
				if (checkBox1.Checked) MtxVecEdit.ViewValues(tmpMtx,"Memory stream",true,false,false);
			}	
            finally 
            {
				stream.Close();
			}
		}

		private void button2_Click(object sender, System.EventArgs e) {
			textBox1.Clear();
			Add2("// Save to binary file");
            Add2("aVec.Size(100);");
            Add2("aVec.RandUniform();");
            Add2("aVec.SaveToFile(\"TestVec1.vec\",false);\r\n");
            Add2("// Load from binary file");
            Add2("Vector tmpVec = new Vector(0);");
            Add2("tmpVec.LoadFromFile(\"TestVec1.vec\");");
            // Save
			aVec.Size(100);
			aVec.RandUniform();
			aVec.SaveToFile("TestVec1.vec",false);
			// Load
            Vector tmpVec = new Vector(0);
			tmpVec.LoadFromFile("TestVec1.vec");
			if (checkBox1.Checked) MtxVecEdit.ViewValues(tmpVec,"Binary file",true,false,false);
		}

		private void button3_Click(object sender, System.EventArgs e) {
			textBox1.Clear();
            Add2("DataTable table = new DataTable(\"Test Table\");");
            Add2("table.Columns.Add(\"id\",typeof(int));");
            Add2("table.Columns.Add(\"value\",typeof(byte[]));");
            Add2("table.PrimaryKey = new DataColumn[]{table.Columns[\"id\"]};\r\n");
            Add2("// Save to DataTable byte[] column");
            Add2("aVec.Size(100);");
            Add2("aVec.RandUniform();");
            Add2("using (MemoryStream stream = new MemoryStream())");
            Add2("{");
            Add2("\taVec.SaveToStream((Stream) stream);");
            Add2("\ttable.Rows.Add(new object[]{1,stream.ToArray()});");
            Add2("}\r\n");
            Add2("// Load from DataTable byte[] column");
            Add2("Vector tmpVec = new Vector(0);");
            Add2("using(MemoryStream streamRead = new MemoryStream((byte[])table.Rows[0][\"value\"]))");
            Add2("{");
            Add2("\ttmpVec.LoadFromStream((Stream)streamRead);");
            Add2("}");
            DataTable table = new DataTable("Test Table");
			table.Columns.Add("id",typeof(int));
			table.Columns.Add("value",typeof(byte[]));
			table.PrimaryKey = new DataColumn[]{table.Columns["id"]};

		    // Save to DataTable byte[] column
            aVec.Size(100);
			aVec.RandUniform();
			using (MemoryStream stream = new MemoryStream())
            {
			    aVec.SaveToStream((Stream) stream);
				table.Rows.Add(new object[]{1,stream.ToArray()});
            }
			
			// Load from DataTable byte[] column
            Vector tmpVec = new Vector(0);
            using(MemoryStream streamRead = new MemoryStream((byte[])table.Rows[0]["value"]))
            {
                tmpVec.LoadFromStream((Stream)streamRead);
			} 
            if (checkBox1.Checked) MtxVecEdit.ViewValues(tmpVec,"Database values",true,false,false);
		}

		private void button4_Click(object sender, System.EventArgs e) 
        {
            string txt;
            // Write to text file
            using (StreamWriter sw = new StreamWriter("TestOutput.txt"))
            {
                aMtx.Size(5, 3, true);
                aMtx.RandGauss(3, 1);
                txt = aMtx.ValuesToText("\t", " 0.#####;-0.#####", "+0.#####i;-0.#####i");
                sw.Write(txt);
            }
            textBox1.Clear();
            Add2("// Write to text file");
            Add2("string txt;");
            Add2("using (StreamWriter sw = new StreamWriter(\"TestOutput.txt\"))");
            Add2("{");
            Add2("\taMtx.Size(5, 3, true);");
            Add2("\taMtx.RandGauss(3, 1);");
            Add2("\ttxt=aMtx.ValuesToText(\"\\t\", \" 0.#####;-0.#####\", \"+0.#####i;-0.#####i\");");
            Add2("\tsw.Write(txt);");
            Add2("}\r\n");

            // read from text file
            using (StreamReader sr = new StreamReader("TestOutput.txt"))
            {
                txt = null;
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    txt += line+"\r\n"; 
                }
                Matrix tmpMtx = new Matrix(0, 0);
                tmpMtx.TextToValues(txt,"\t");
                if (checkBox1.Checked) MtxVecEdit.ViewValues(tmpMtx, "Text file",true,false,false);
            }
            Add2("// Read from text file");
            Add2("string txt = null;");
            Add2("string line = null;");
            Add2("while ((line = sr.ReadLine()) != null)");
            Add2("{");
            Add2("\tatxt += line+\"\\r\\n\"; \r\n}");
            Add2("Matrix tmpMtx = new Matrix(0, 0);");
            Add2("tmpMtx.TextToValues(txt,\"\\t\");");
        }

		private void SavingLoadingForm_Load(object sender, System.EventArgs e) {
			Add("Importing and exporting values is an important feature "
				+ "of MtxVec. MtxVec offers you the ability to save vector/"
				+ "matrix to memory stream, binary files, text files, BLOBs, Clipboard ...");
			Add("Click on buttons bellow to introduce yourself with various "
				+ "methods available. If \"View loaded values\" option is "
				+ "checked, you'll get a visual representation of loaded matrix/vector.");
		}
	}
}