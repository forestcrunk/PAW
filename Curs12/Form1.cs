using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs12
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Bine at iv enti");
			
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("www.example.com");
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if(keyData == (Keys.Control | Keys.C))
			{
				Rectangle r = new Rectangle { 
					X = 0,
					Y = 0,
					Width = this.Width,
					Height = this.Height
				};
				Bitmap img = new Bitmap(r.Width, r.Height);
				this.DrawToBitmap(img, r);
				Clipboard.SetImage(img);
			}

			if(keyData == (Keys.Control | Keys.V))
			{
				this.pictureBox1.Image = Clipboard.GetImage();
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}
	}
}
