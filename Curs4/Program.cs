using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //necesar pt Form
using System.Drawing; //nu e neaparat necesar pentru System.Drawing.Point dar e util

namespace Curs4
{
    class F_mea : Form
    {
        Button btn;

        public F_mea()
        {
            this.Text = "Aplicatie WF"; //titlul ferestrei

            this.btn = new Button();
            btn.Text = "gk3"; //text-ul de pe buton
            btn.Location = new System.Drawing.Point(10,10); //pozitia relativa fata de coltul stanga-sus

            btn.Click += Btn_Click; //adaugare eveniment in delegat

            this.Controls.Add(btn); //adauga butonul in fereastra
            
            
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; //referinta la butonul apasat

            MessageBox.Show($"Butonul {button.Text} a fost apasat."); //popup cu mesaj dupa ce butonul este apasat

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new F_mea()); //ruleaza forma creata
        }
    }
}
