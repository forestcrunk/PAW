using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Firma firma1 = new Firma("firma1");
            firma1.adaugaSalariat(new Salariat() { Nume = "Mihai", Numar_ore = 5, Salariul_orar = 3.5F });
            firma1.adaugaSalariat(new Salariat() { Nume = "Alex", Numar_ore = 4, Salariul_orar = 7.2F });
            firma1.adaugaSalariat(new Salariat() { Nume = "Dan", Numar_ore = 8, Salariul_orar = 4.3F });

            //Salariat s1 = new Salariat() { Nume = "Andrei", Numar_ore = 7, Salariul_orar = 3.3F };

            try
            {
                Console.WriteLine(firma1[1]);
                //firma[1].Nume = "Alexandru";
                firma1[1] = new Salariat() { Nume = "Andrei", Numar_ore = 7, Salariul_orar = 3.3F } ;
                
                Console.WriteLine(firma1[1]);
            }
            catch (IndexOutOfRangeException iex)
            {
                Console.WriteLine(iex.Message);
            }

            Console.WriteLine("Fondul de salarii: " + firma1.Fond_salarii);
        }
    }
}
