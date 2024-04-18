using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs9
{
    public partial class Form1 : Form
    {

        List<int> lobs;
        public Form1()
        {

            InitializeComponent();
            lobs = new List<int>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lobs.Add(50);
            lobs.Add(23);
            lobs.Add(70);
            lobs.Add(34);
            fer_gr.Observatii = lobs;
        }
    }
}
