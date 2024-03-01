using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs2
{
    internal class Program
    {
        /*
        static float medie(int[] v, int n)
        {
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                s += v[i];
            }

            return s / (float)n;
        } */

        /*
        static void medie(int[] v, int n, out float med)
        {
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                s += v[i];
            }

            med = s / (float)n;
        } */

        static float medie(params int[] v)
        {
            int s = 0;
            for (int i = 0; i < v.Length; i++)
            {
                s += v[i];
            }

            return s / (float)v.Length;
        }

        //delegate int fopa(int x, int y); //echivalent cu Func<...>


        static int mul(int x, int y) => x * y;

        static void Main(string[] args)
        {

            int a = 100, b = 7;
            //fopa obf = new fopa((v,t) => v+t);
            Func<int, int, int> obf = new Func<int, int, int>((v, t) => v + t);
            Console.WriteLine(obf(a, b));

            obf += mul;
            Console.WriteLine(obf(a, b));

            //foreach(fopa i in obf.GetInvocationList())
            //{
            //    Console.WriteLine(i(a,b));
            //}
            foreach (Func<int, int, int> i in obf.GetInvocationList())
            {
                Console.WriteLine(i(a, b));
            }


            //int ne;
            //int[] ve = new int[100];

            ////List<int> ve = new List<int>();
            //string aux;

            //Console.Write("Dati nr elem: ");
            //aux = Console.ReadLine();

            //ne = Int32.Parse(aux);

            //for (int i = 0; i < ne; i++)
            //{
            //    Console.Write("Dati elem " + i.ToString() + ": ");
            //    aux = Console.ReadLine();
            //    ve[i] = Int32.Parse(aux);
            //    //ve.Add(Int32.Parse(aux));
            //}

            //foreach (int i in ve)
            //{
            //    Console.WriteLine(i);
            //}



            //Console.WriteLine("Media elementelor este {0:#.##}", medie(ve,ne)); //#.## il scrie doar cu 2 zecimale, e specificator de format

            //Console.WriteLine("Media elementelor este {0:#.##}", medie(5,6,8)); //#.## il scrie doar cu 2 zecimale, e specificator de format

            //float rez;
            //medie(ve, ne, out rez);

            //Console.WriteLine("Media elementelor este {0:#.##}", rez); //#.## il scrie doar cu 2 zecimale, e specificator de format

            //Console.WriteLine("Media elementelor este {0:#.##}", ve.Average() /*echivalent cu ve.Sum() / (float) ve.Count()*/);


            ///*for(int i=0;i<ne;i++)
            //{
            //    Console.WriteLine(ve[i]);
            //}*/


            //Salariat sal1 = new Salariat() { Nume = "Mihai", Numar_ore = 5, Salariul_orar = 250.25F };
            //Console.Write("Introduceti numarul de ore: ");
            //try
            //{
            //    int nr_o = Int32.Parse(Console.ReadLine());
            //    sal1.Numar_ore = nr_o;
            //    Console.WriteLine(sal1.ToString());
            //}
            //catch (FormatException fe)
            //{
            //    Console.WriteLine("Erorare de formatare: " + fe.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

        }
    }
}
