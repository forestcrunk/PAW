using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs12_dragNdrop
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void textBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (textBox1.Text != string.Empty)
			{
				textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy);
			}
		}

		private void listBox1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		private void listBox1_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text))
			{
				listBox1.Items.Add(e.Data.GetData(DataFormats.Text).ToString());
				textBox1.Text = string.Empty;
			}
			
		}
	}
}
