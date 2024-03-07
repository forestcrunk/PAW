using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs3_demo_interfata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persoana p = new Persoana();
            p.Nume = "Vasile";
            p.Numar_ore = 5;
            p.Salariul_orar = 1.5F;
            Console.WriteLine(p.Nume + " are salariul " + p.getSalariu());
        }
    }
}
