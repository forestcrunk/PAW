using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs10_incomplet
{
	public partial class Form1 : Form
	{
		string cs = null;
		public Form1()
		{
			InitializeComponent();
			cs = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = demo_bdpaw; Integrated Security = SSPI;";
		}

		void Vizualizare()
		{
			string cmds = "select * from Persoane";
			SqlConnection con = new SqlConnection(cs);
			con.Open();
			SqlCommand cmd = new SqlCommand(cmds, con);
			SqlDataReader dr = cmd.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Load(dr);
			dgv.DataSource = dt;

			con.Close();
			// ?
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Vizualizare();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string cmds = "insert into Persoane(marca,nume) values(@marca,@nume)";
			SqlConnection con = new SqlConnection(cs);
			con.Open();
			SqlCommand cmd = new SqlCommand(cmds, con);
			cmd.Parameters.Add("@marca", SqlDbType.Int).Value = int.Parse(textBox1.Text);
			cmd.Parameters.Add("@nume", SqlDbType.NVarChar).Value = textBox2.Text;
			cmd.ExecuteNonQuery();
			con.Close();
			Vizualizare();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string cmds = "delete from Persoane where marca  = @marca";
			SqlConnection con = new SqlConnection(cs);
			con.Open();
			SqlCommand cmd = new SqlCommand(cmds, con);
			cmd.Parameters.Add("@marca", SqlDbType.Int).Value = int.Parse(textBox1.Text);
			int k = cmd.ExecuteNonQuery();
			con.Close();
			Vizualizare();
		}
	}
}
