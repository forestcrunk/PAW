using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar7
{
    public partial class Form1 : Form
    {
        Firma firma;
        public Form1()
        {
            InitializeComponent();
            firma = new Firma("Firma1");

            firma.event_modificare += Firma_event_modificare;
        }

        private void Firma_event_modificare(object sender, EventArgs e)
        {
            Firma f = (Firma)sender;

            dgv.Rows.Clear();

            for (int i = 0; i<f.Numar_salariati; i++)
            {
                dgv.Rows.Add(
                    f[i].Nume,
                    f[i].Numar_ore.ToString(),
                    f[i].Salariul_orar.ToString(),
                    f[i].Salariul.ToString()
                );
                dgv.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }

            dgv.Rows[f.Numar_salariati - 1].Selected = true;

            sb_label2.Text = f.Fond_salarii.ToString(); //am adaugat fondul de salarii in status label-ul de jos
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if(firma.Numar_salariati == 0)
            //{
            //    modificaToolStripMenuItem.Enabled = false;
            //}
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            Form2 dialog = new Form2();
            dialog.Text = item.Text + " salariat";
            dialog.button_confirma.Text = item.Text;

            if(item.Tag.ToString() == "M")
            {
                int index = dgv.SelectedRows[0].Index;

                dialog.tbox_no.Text = firma[index].Numar_ore.ToString();
                dialog.tbox_so.Text = firma[index].Salariul_orar.ToString();
                dialog.tbox_nume.Text = firma[index].Nume;
            }

            Salariat s = new Salariat()
            {
                Nume = dialog.tbox_nume.Text,
                Numar_ore = int.Parse(dialog.tbox_no.Text),
                Salariul_orar = float.Parse(dialog.tbox_so.Text)
            };

            if (DialogResult.OK == dialog.ShowDialog())
            {
                if (item.Tag.ToString() == "A")
                {
                    firma.adaugaSalariat(s);
                    
                }

                if(item.Tag.ToString() == "M")
                {
                    int index = dgv.SelectedRows[0].Index;

                    firma[index] = s;
                }
            }
        }
    }
}
