using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs6
{
    public partial class Form1 : Form
    {
        Firma firma;
        public Form1()
        {
            InitializeComponent();
            firma = new Firma();

            firma.event_modificare += Firma_event_modificare; //incarcam event-ul din firma cu functia care vrem sa fie apelata cand event-ul este realizat
        }

        private void Firma_event_modificare(object sender, EventArgs e)
        {
            Firma f = sender as Firma;

            dgv.Rows.Clear(); //stergem toate randurile deja existente deoarece le vom adauga pe toate cu noul salariat introdus
            foreach (Salariat s in f.Salariati)
            {
                dgv.Rows.Add(s.Marca, s.Nume);
            }

            dgv.Rows[f.Salariati.Count - 1].Selected = true; //selectam automat ultimul rand

            
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            string nume_op = item.Text; //dam cast la sender in ToolStripMenuItem (clasa butonului de meniu) si preluam textul sau
            Form_AM dialog = new Form_AM(); //creem un nou form de tipul Form_AM
            dialog.Text = nume_op + " salariat"; //schimbam numele ferestrei in "(Adauga/Modifica) salariat" depinzand de ce am ales

            dialog.button_confirma.Text = nume_op; //schimbam textul de pe buton in (Adauga/Modifica)
            //a fost nevoie sa schimbam butoanele din Private in Public (proprietatea Modifiers)

            //daca am ales sa modificam, introducem in textbox-urile din dialog valorile de pe randul selectat in datagridview
            if (item.Tag.ToString() == "tag_modifica")
            {
                int k = dgv.SelectedRows[0].Index; //preluam indexul randului selectat

                dialog.tb_marca.Text = firma.Salariati[k].Marca.ToString();
                dialog.tb_nume.Text = firma.Salariati[k].Nume;
            }

            //comparam butonul apasat cu "OK" sau "Cancel"
            //probabil poate fi facut cu un switch-case
            if (DialogResult.OK == dialog.ShowDialog()) 
            {
                //presupunem ca datele introduse sunt valide
                //nu avem timp sa verificam

                firma.Adauga(new Salariat() { Marca = int.Parse(dialog.tb_marca.Text) , Nume = dialog.tb_nume.Text }); //ambele textbox-uri trebuie sa fie facute public ca butoanele
            }
            
        }
    }
}
