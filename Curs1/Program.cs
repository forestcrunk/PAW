using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs1
{
    internal class Program
    {
        
        static float medie(int[] v, int n)
        {
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                s += v[i];
            }

            return s / (float)n;
        }

        static void Main(string[] args)
        {




            int ne;
            int[] ve = new int[100];

            //List<int> ve = new List<int>();
            string aux;

            Console.Write("Dati nr elem: ");
            aux = Console.ReadLine();

            ne = Int32.Parse(aux);

            for (int i = 0; i < ne; i++)
            {
                Console.Write("Dati elem " + i.ToString() + ": ");
                aux = Console.ReadLine();
                ve[i] = Int32.Parse(aux);
                //ve.Add(Int32.Parse(aux));
            }

            for (int i = 0; i < ne; i++)
            {
                Console.WriteLine(ve[i]);
            }

            /*
            foreach (int i in ve) {
                Console.WriteLine(i);
            }
            */

            Console.WriteLine("Media elementelor este {0:#.##}", medie(ve, ne)); //#.## il scrie doar cu 2 zecimale, e specificator de format

            //Console.WriteLine("Media elementelor este {0:#.##}", ve.Average() /*echivalent cu ve.Sum() / (float) ve.Count()*/);



            

        }
    }
}
