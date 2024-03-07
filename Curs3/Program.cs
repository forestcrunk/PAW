using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs3
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


        //static int mul(int x, int y) => x * y;

        static void Main(string[] args)
        {

            ////boxing si unboxing
            //int a = 100;
            //object o;

            //o = a; // referinta la valoarea din a

            //Console.WriteLine(a); // 100
            //Console.WriteLine(o); // 100
            //a = 234;
            //Console.WriteLine(a); // 234
            //Console.WriteLine(o); // 100 deoarece referinta a fost facuta catre acel 100

            //a = (int)o; //trebuie cast
            //Console.WriteLine(a); // 100
            //Console.WriteLine(o); // 100

            ////List<object> l = new List<object>();
            //ArrayList l = new ArrayList(); //automat facuta pentru tipul Object
            //l.Add(200);
            //l.Add("Salut!");
            //l.Add(300);

            //int s = 0;
            //foreach (object item in l)
            //{
            //    //Console.WriteLine(item);
            //    if (item is int)
            //    {
            //        s += (int)item;
            //    }
            //}
            //Console.WriteLine(s);

            Salariat s1 = new Salariat() { Nume = "Tudor", Numar_ore = 10, Salariul_orar = 1};
            Salariat s2 = s1; // copierea se face prin referinta
            Salariat s3 = /*(Salariat)*/ s1.Clone() as Salariat; //copierea se face prin clonare directa 
            // "(Type) ..." si "... as Type" sunt casturi ambele

            Console.WriteLine(s1);
            s1++;
            Console.WriteLine(s1);
            Console.WriteLine(s2); //prin referinta
            Console.WriteLine(s3); //prin Clone()
            Salariat s4 = s1 + s3;
            Console.WriteLine(s4);
            s1 += s2;
            Console.WriteLine(s1);
            Console.WriteLine();

            Console.WriteLine(s1[0]);




            //Curs 2

            //int a = 100, b = 7;
            ////fopa obf = new fopa((v,t) => v+t);
            //Func<int, int, int> obf = new Func<int, int, int>((v, t) => v + t);
            //Console.WriteLine(obf(a, b));

            //obf += mul;
            //Console.WriteLine(obf(a, b));

            ////foreach(fopa i in obf.GetInvocationList())
            ////{
            ////    Console.WriteLine(i(a,b));
            ////}
            //foreach (Func<int, int, int> item in obf.GetInvocationList())
            //{
            //    Console.WriteLine(item(a, b));
            //}




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
