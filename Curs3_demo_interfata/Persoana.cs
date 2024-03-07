using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs3_demo_interfata
{
    interface ISalariat
    {
        int Numar_ore
        {
            get;
            set;
        }

        float Salariul_orar
        {
            get;
            set;
        }

        float getSalariu();
    }

    internal class Persoana : ISalariat
    {
        string nume;

        public Persoana()
        {
            nume = "Anonim";
        }

        public string Nume
        {
            get => nume;
            set => nume = value;
        }
        public int Numar_ore 
        { 
            get; 
            set; 
        }
        public float Salariul_orar 
        { 
            get;
            set;
        }

        public float getSalariu()
        {
            return Numar_ore * Salariul_orar;
        }
    }
}
