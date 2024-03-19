using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar4
{
    public partial class Form1 : Form
    {
        Ec_gr2 ec;
        public Form1()
        {
            InitializeComponent();
            ec = new Ec_gr2();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {   
                ec.coef_x2 = Int32.Parse(tb_in_x2.Text);
                ec.coef_x = Int32.Parse(tb_in_x1.Text);
                ec.coef_tl = Int32.Parse(tb_in_tl.Text);

                tb_out_rad1.Text = ec.radacina1.ToString();
                tb_out_rad2.Text = ec.radacina2.ToString();
            }
            catch(FormatException fex) //int32.parse
            {
                MessageBox.Show(fex.Message, "Eroare format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(DeltaException dex) //delta < 0
            {
                MessageBox.Show(dex.Message, "Eroare delta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullCoefficientException ncex) //a*x^2 , a=0
            {
                MessageBox.Show(ncex.Message, "Eroare coeficient x^2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_in_x2.Text = ec.coef_x2.ToString();
            tb_in_x1.Text = ec.coef_x.ToString();
            tb_in_tl.Text = ec.coef_tl.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
