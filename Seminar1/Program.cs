using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//IMPLEMEntare clasa simpla pentru 
//rezolvarea ec. de grad 2

namespace Seminar1 
{
    internal class Program 
    {
        
        static void Main(string[] args) 
        {

            try
            {
                Ec_gr2 ecuatie = new Ec_gr2() /*{ coef_x = 5, coef_tl = -6, coef_x2 = 7 }*/;

                Console.Write("Introduceti coeficientul lui x^2: ");
                ecuatie.coef_x2 = Int32.Parse(Console.ReadLine());
                Console.Write("Introduceti coeficientul lui x: ");
                ecuatie.coef_x = Int32.Parse(Console.ReadLine());
                Console.Write("Introduceti termenul liber: ");
                ecuatie.coef_tl = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Ecuatia este: {0}x^2 + {1}x + {2} = 0", ecuatie.coef_x2, ecuatie.coef_x, ecuatie.coef_tl);

                if (ecuatie.delta == 0)
                {
                    Console.WriteLine("Radacina 1 = Radacina 2 = {0:#.##}", ecuatie.radacina1);
                }
                else
                { 
                        Console.WriteLine("Radacina 1 = {0:#.##}", ecuatie.radacina1);
                        Console.WriteLine("Radacina 2 = {0:#.##}", ecuatie.radacina2);
                }
            }
            catch(FormatException fex)
            {
                Console.WriteLine(fex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
