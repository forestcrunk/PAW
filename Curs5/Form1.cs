using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Curs5
{
    public partial class Form1 : Form
    {
        CElement elem;

        public Form1()
        {
            InitializeComponent();
            elem = new CElement();

            elem.ev_change_val += Elem_ev_change_val; //incarcam event-ul (delegat) cu functia care vrem sa fie apelata
        }

        private void Elem_ev_change_val(int obj)
        {
            //obj este int-ul din elem (CElement)

            tbox_out.Text = elem.ElementSq.ToString(); // afisam patratul in textbox-ul de output
            string sir = obj.ToString() + "  ->  " + elem.ElementSq.ToString(); //cream un sir cu elementul introdus si patratul sau
            tbox_history.Text += sir + Environment.NewLine; //il adaugam in textbox-ul de istoric

            //listbox
            lbox.Items.Add(sir);

            //listview
            ListViewItem row = lview.Items.Add(obj.ToString());
            row.SubItems.Add(elem.ElementSq.ToString());

            //datagridview
            dgv.Rows.Add(obj.ToString(), elem.ElementSq.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //metoda simpla este in Curs4_WindowsForms

            //toata validarea este realizata la nivelul butonului in cazul asta

            //am adaugat tbox_in_Validating care realizeaza validarea
            //la nivelul textbox-ului de input mai jos

            //metoda cu event
            try
            {
                elem.Element = int.Parse(tbox_in.Text);
                //de aici se va apela Elem_ev_change_val
            }
            catch(FormatException fex) //daca nu introducem un numar in textbox
            {
                MessageBox.Show(fex.Message, "Eroare format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally //cod executat dupa try/catch, indiferent daca a fost o exceptie sau nu
            {
                //selectam textbox-ul de input automat si selectam tot textul din el
                tbox_in.Focus();
                tbox_in.SelectAll();
            }   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbox_in.Text = elem.Element.ToString();
        }

        private void tbox_in_Validating(object sender, CancelEventArgs e)
        {
            //validarea este realizata in textbox, inainte de button

            try
            {
                elem.Element = int.Parse(tbox_in.Text);
                //de aici se va apela Elem_ev_change_val
                //fiind facuta validarea in textbox, va afisa patratul inainte sa fie apasat butonul
            }
            catch (FormatException fex) //daca nu introducem un numar in textbox
            {
                MessageBox.Show(fex.Message, "Eroare format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true; //daca intra in exceptie, opreste toate evenimentele
                //nu mai poti nici macar sa inchizi form-ul pana nu schimbi input-ul
                //(cam stupid)

            }
        }

        private void tbox_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Return)
            {
                //Invoke foloseste delegat -> folosim EventHandler pt ca ala este folosit de button1_click
                this.Invoke(new EventHandler(button1_Click));
            }
        }
    }
}
