using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs7_legare
{
    public partial class Form2 : Form
    {
        BindingSource bds;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(BindingSource fbds)
        {
            InitializeComponent();
            bds = fbds;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button_confirma_Click(object sender, EventArgs e)
        {
            BindingContext[bds].Position -= 1;
        }

        private void button_anuleaza_Click(object sender, EventArgs e)
        {
            BindingContext[bds].Position += 1;
        }
    }
}
