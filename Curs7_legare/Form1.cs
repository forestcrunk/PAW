using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs7_legare
{
    public partial class Form1 : Form
    {
        Firma firma;
        BindingSource bds;
        public Form1()
        {
            InitializeComponent();
            firma = new Firma();
            bds = new BindingSource(firma.Salariati, null);

            //firma.event_modificare += Firma_event_modificare;
        }

        private void Firma_event_modificare(object sender, EventArgs e)
        {
            Firma f = sender as Firma;
            Firma_Ev_args fe = e as Firma_Ev_args;

            dgv.Rows.Clear(); //stergem toate randurile deja existente deoarece le vom adauga pe toate cu noul salariat introdus
            foreach (Salariat s in f.Salariati)
            {
                dgv.Rows.Add(s.Marca, s.Nume);
            }

            dgv.Rows[fe.Index].Selected = true; //selectam automat ultimul rand
            sb.Items[1].Text = f.Salariati.Count.ToString(); //updatam labelul de jos cu Nr Salariati
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            int k=-1;

            string nume_op = item.Text;
            Form_AM dialog = new Form_AM();
            dialog.Text = nume_op + " salariat";

            dialog.button_confirma.Text = nume_op;

            if (DialogResult.OK == dialog.ShowDialog()) 
            {
                Salariat temp = new Salariat() { Marca = int.Parse(dialog.tb_marca.Text), Nume = dialog.tb_nume.Text };
                if (item.Tag.ToString() == "A")
                {
                    bds.Add(temp);
                    BindingContext[bds].Position = firma.Salariati.Count - 1;
                }
            }

        }
        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fmod = new Form2(bds);
            fmod.TopMost = true;
            fmod.tb_marca.DataBindings.Add("Text", bds, "Marca");
            fmod.tb_nume.DataBindings.Add("Text", bds, "Nume");
            fmod.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv.DataSource = bds;
        }

        private void deschideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.InitialDirectory = @""; //se duce in Documents
            fd.Filter = "Date |*.dat|Toate fisierele|*.*";
            fd.FilterIndex = 1;
            fd.Multiselect = false;
            if(DialogResult.OK == fd.ShowDialog())
            {
                firma.Deserializare(fd.FileName);
            }
        }

        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.InitialDirectory = @""; //in Documents
            fd.Filter = "Date |*.dat|Toate fisierele|*.*";
            fd.FilterIndex = 1;
            if (DialogResult.OK == fd.ShowDialog())
            {
                firma.Serializare(fd.FileName);
            }
        }

        
    }
}
