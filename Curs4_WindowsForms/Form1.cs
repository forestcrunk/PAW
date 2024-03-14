using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs4_WindowsForms
{
    public partial class Form1 : Form
    {
        CElement elem;
        
        public Form1()
        {
            InitializeComponent();
            elem = new CElement();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Butonul {button1.Text} a fost apasat.");
            elem.Element = Int32.Parse(tbox_in.Text);
            tbox_out.Text = elem.ElementSq.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbox_in.Text = elem.Element.ToString();
            
        }
    }
}
