using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3_element
{
    internal class Persoana
    {
        string nume;

        public Persoana()
        {
            nume = "Anonim";
        }

        public Persoana(string fnume)
        {
            nume = fnume;
        }

        public string Nume
        {
            get => nume;
            set => nume = value;
        }

        public override string ToString()
        {
            return nume + "  ";
        }
    }

    internal class Salariat : Persoana
    {
        int no;
        float so;

        public Salariat()
        {
            no = 0;
            so = 0;
        }

        public Salariat(string fnume, int fno, float fso) : base(fnume)
        {
            no = fno;
            so = fso;
        }

        public int Numar_ore
        {
            get => no;
            set => no = value;
        }
        public float Salariul_orar
        {
            get => so;
            set => so = value;
        }

        public float getSalariu()
        {
            return Numar_ore * Salariul_orar;
        }

        public override string ToString()
        {
            return base.ToString() + Numar_ore + "   " + Salariul_orar + "   " + getSalariu();
        }
    }
}
