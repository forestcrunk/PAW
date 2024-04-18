using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Seminar9
{
    [Serializable]
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

    class Firma_Ev_args : EventArgs
    {
        int idx;
        public Firma_Ev_args(int fidx)
        {
            idx = fidx;
        }
        public int Index => idx;
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
                event_modificare(this, new Firma_Ev_args(ls.Count - 1));
            }
        }

        public void stergeSalariat(int index)
        {



            if (Numar_salariati == 0)
            {
                throw new Exception("Nu exista salariati!");
            }

            if (index < 0 || index >= Numar_salariati)
            {
                throw new IndexOutOfRangeException("Numar de salariati invalid!");
            }


            ls.RemoveAt(index);

            if(index == Numar_salariati && Numar_salariati != 0)
            {
                index--;
            }
            if (event_modificare != null)
            {

                event_modificare(this, new Firma_Ev_args(index));
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
                        event_modificare(this, new Firma_Ev_args(k));
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

        public void Serializare(string nf)
        {
            FileStream fs = new FileStream(nf, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, ls);
            fs.Close();
        }

        public void Deserializare(string nf)
        {
            FileStream fs = new FileStream(nf, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            ls = bf.Deserialize(fs) as List<Salariat>;
            fs.Close();
            if (event_modificare != null)
            {
                event_modificare(this, new Firma_Ev_args(ls.Count - 1));
            }

        }
    }
}
