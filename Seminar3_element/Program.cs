using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~CLASS - Tip referentiat~");

            Element elem1 = new Element(5);
            Element elem2 = elem1++;
            Console.WriteLine(elem1);
            Console.WriteLine(elem2);

            Console.WriteLine("\n~STRUCT - Tip valoric~");

            structElement structelem1 = new structElement(5);
            structElement structelem2 = structelem1++;
            Console.WriteLine(structelem1);
            Console.WriteLine(structelem2);

            Console.WriteLine("\n~Persoana & Salariat - Derivare~");

            Persoana p1 = new Persoana();
            Console.WriteLine(p1);
            Salariat s1 = new Salariat("Alexandru", 13, 2.5F);
            Console.WriteLine(s1);
        }
    }
}
