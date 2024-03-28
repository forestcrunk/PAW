using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Seminar6
{
    class Salariat : ICloneable
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

        public object Clone()
        {
            return new Salariat()
            {
                Nume = this.Nume,
                Numar_ore = this.Numar_ore,
                Salariul_orar = this.Salariul_orar
            };
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

        public static Salariat operator +(Salariat s1, Salariat s2)
        {
            return new Salariat()
            {
                Nume = s1.Nume + s2.Nume,
                Numar_ore = s1.Numar_ore + s2.Numar_ore,
                Salariul_orar = s1.Salariul_orar + s2.Salariul_orar
            };
        }
    }

    class Firma
    {
        public event EventHandler event_modificare;
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
            if (event_modificare != null)
            {
                event_modificare(this, null);
            }
        }

        public int Numar_salariati => ls.Count;

        public string Denumire
        {
            get => denf;
            set => denf = value;
        }

        public Salariat this[int k]
        {

            get => (k < 0 || k >= ls.Count) ? throw new IndexOutOfRangeException("ERR: Pozitie invalida.") : ls[k];

            set
            {
                if (ls[k] != value) //verificam daca a fost introdus un salariat nou
                {
                    ls[k] = value;
                    if (event_modificare != null)
                    {
                        event_modificare(this, null);
                    }
                }
            }
        }

        public float Fond_salarii => ls.Sum(sal => sal.Salariul);

        public static Firma operator +(Firma f, Salariat s)
        {
            Salariat temp = s.Clone() as Salariat;
            f.adaugaSalariat(temp);
            return f;
        }

        public List<Salariat> Salariati => ls;
    }
}
