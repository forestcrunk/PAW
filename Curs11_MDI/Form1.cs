using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs11_MDI
{
	public partial class Form1 : Form
	{
		int nr_docs;
		public Form1()
		{
			InitializeComponent();
			nr_docs = 1;
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2 fereastra = new Form2();
			fereastra.Text = "Document " + nr_docs.ToString();
			nr_docs++;
			fereastra.MdiParent = this;
			fereastra.Show();
		}

		private void inchideFerestreToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foreach(var item in this.MdiChildren)
			{
				item.Close();
				item.Dispose();
				nr_docs = 1;
			}
		}
	}
}
