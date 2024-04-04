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
            Firma f = sender as Firma;
            Firma_Ev_args fe = e as Firma_Ev_args;

            if (f.Numar_salariati == 0)
            {
                modificaToolStripMenuItem.Enabled = stergeToolStripMenuItem.Enabled =  false;
            }
            else
            {
                modificaToolStripMenuItem.Enabled = stergeToolStripMenuItem.Enabled = true;
            }

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

            dgv.Rows[fe.Index].Selected = true;

            
            sb_label2.Text = f.Fond_salarii.ToString(); //am adaugat fondul de salarii in status label-ul de jos
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            int index = -1;
            if (item.Tag.ToString() == "S")
            {
                if (firma.Numar_salariati > 0)
                {
                    if (DialogResult.Yes == MessageBox.Show(
                        "Sunteti sigur ca doriti sa stergeti acest salariat?",
                        "Stergere salariat",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question)
                    )
                    {
                        int index1 = dgv.SelectedRows[0].Index;
                        firma.stergeSalariat(index1);
                    }
                }
                
                return;//iesim din functie devreme
            }

            Form2 dialog = new Form2();
            dialog.Text = item.Text + " salariat";
            dialog.button_confirma.Text = item.Text;
            

            if(item.Tag.ToString() == "M")
            {
                index = dgv.SelectedRows[0].Index;

                dialog.tbox_no.Text = firma[index].Numar_ore.ToString();
                dialog.tbox_so.Text = firma[index].Salariul_orar.ToString();
                dialog.tbox_nume.Text = firma[index].Nume;
            }


            if (DialogResult.OK == dialog.ShowDialog())
            {

                Salariat s = new Salariat()
                {
                    Nume = dialog.tbox_nume.Text,
                    Numar_ore = int.Parse(dialog.tbox_no.Text),
                    Salariul_orar = float.Parse(dialog.tbox_so.Text)
                };

                if (item.Tag.ToString() == "A")
                {
                    firma.adaugaSalariat(s);
                    
                }

                if(item.Tag.ToString() == "M")
                {
                    firma[index] = s;
                }

                
            }
        }
    }
}
