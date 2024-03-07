using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Firma firma1 = new Firma("firma1");
            firma1.adaugaSalariat(new Salariat() { Nume = "Mihai", Numar_ore = 5, Salariul_orar = 3.5F });
            firma1.adaugaSalariat(new Salariat() { Nume = "Alex", Numar_ore = 4, Salariul_orar = 7.2F });
            firma1.adaugaSalariat(new Salariat() { Nume = "Dan", Numar_ore = 8, Salariul_orar = 4.3F });

            Salariat s1 = new Salariat() { Nume = "Andrei", Numar_ore = 7, Salariul_orar = 3.3F };

            firma1 += s1; //echivalent cu firma1=firma1+s1

            Salariat s2 = new Salariat() { Nume = "Carlos", Numar_ore = 5, Salariul_orar = 6.3F };
            Salariat s3 = new Salariat() { Nume = "Max", Numar_ore = 12, Salariul_orar = 3.7F };

            firma1 += s2 += s3; //LINIA ASTA


            for (int i = 0; i < firma1.Numar_salariati; i++)
            {
                Console.WriteLine(firma1[i]);
            }

            Console.WriteLine(s2); //linia "LINIA ASTA" a suprascris s2 din initializarea initiala
            
            
        }
    }
}
