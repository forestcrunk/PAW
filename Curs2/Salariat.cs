using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs2
{
    internal class Salariat
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
}
