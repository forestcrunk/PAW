using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    class Salariat
    {
        string nume;
        int no;
        float so;

        public Salariat() //constructor implicit
        {
            nume = "Anonim";
            no = 0;
            so = 0;
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public float Salariul => no * so;

        public int Numar_ore
        {
            get => no;
            set
            {
                if (value < 0) throw new Exception("ERR: Nr ore negativ");
                else no = value;
            }
        }

        public float Salariul_orar
        {
            get => so;
            set => so = value;
        }

        public override string ToString() => $"Salariatul {Nume} are salariul {Salariul}.";

        /*public override string ToString()
        {
            return "Nume: " + Nume 
                + "\nNumar de ore: " + Numar_ore 
                + "\nSalariu pe ora: " + Salariul_orar 
                + " \nSalariu total: " + Salariul 
                + '\n';
        }*/
    }

    class Firma
    {
        List<Salariat> ls;
        string denf; //denumire

        public Firma(string fn)
        {
            ls = new List<Salariat>();
            denf = fn;
        } //constructor

        public void adaugaSalariat(Salariat sal)
        {
            ls.Add(sal);
        }

        public string Denumire
        {
            get => denf;
            set => denf = value;
        }

        public Salariat this[int k]
        {
            /*
            get
            {
                if (k < 0 || k >= ls.Count) throw new IndexOutOfRangeException("ERR: Pozitie invalida.");
                return ls[k];
            } 
            */

            get => (k < 0 || k >= ls.Count) ? throw new IndexOutOfRangeException("ERR: Pozitie invalida.") : ls[k];

            set => ls[k] = value;
        }

        /*
        public float Fond_salarii
        {
            get
            {
                float sal = 0 ;
                foreach (Salariat i in ls)
                {
                    sal += i.Salariul;
                }
                return sal;
            }
        } */

        public float Fond_salarii => ls.Sum(sal => sal.Salariul);
    }
}
