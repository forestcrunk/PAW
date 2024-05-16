using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar11_AccessBD
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'dataset_mdb.Produse' table. You can move, or remove it, as needed.
            this.produseTableAdapter1.Fill(this.ds.Produse);

        }

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			this.produseTableAdapter1.Update(this.ds.Produse);
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			int sum = 0;
			string cmds = "select sum(cantitate * pret_unitar) from Produse";
			OleDbConnection con = new OleDbConnection(produseTableAdapter1.Connection.ToString());
			OleDbCommand cmd = new OleDbCommand(cmds);
			sum = (int)cmd.ExecuteScalar();

			textBox1.Text = sum.ToString();
		}
	}
}
