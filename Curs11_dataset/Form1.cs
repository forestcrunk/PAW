using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs11_dataset
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'demo_bdpawDataSet.Persoane' table. You can move, or remove it, as needed.
            this.persoaneTableAdapter.Fill(this.demo_bdpawDataSet.Persoane);

        }

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			this.persoaneTableAdapter.Update(this.demo_bdpawDataSet.Persoane);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("marca_p", typeof(int));
			dt.Columns.Add("marca_c", typeof(int));
			dt.Columns.Add("nume_c", typeof(string));
			demo_bdpawDataSet.Tables.Add(dt);
			dt.Rows.Add(100, 10, "Silvia");
			dt.Rows.Add(100, 15, "Ionut");
			dgv_copil.DataSource = dt;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show(demo_bdpawDataSet.Tables.Count.ToString());
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (dgv_parinte.SelectedRows.Count!=0)
			{
				DataTable dt = demo_bdpawDataSet.Tables[1]; //selecteaza baza de date copil
				string marca_parinte = dgv_parinte.SelectedRows[0].Cells[0].Value.ToString();
				var col_copii = from rand in dt.AsEnumerable() where rand["marca_p"].ToString() == marca_parinte select rand["nume_c"];
				foreach(var item in col_copii)
				{
					MessageBox.Show(item.ToString());
				}
			}
		}
	}
}
