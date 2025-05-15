using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int año, an1, an2;
            Console.WriteLine("Ingrese un año para determinar si es bisiesto o no:");
            año = Convert.ToInt32(Console.ReadLine());
            an1 = año % 4;
            an2 = año % 400;
            if (an1 == 0 || an2 == 0)
            {
                Console.WriteLine("El año es bisiesto");
            }
            else
            {
                Console.WriteLine("El año es bisiesto");
            }
            Console.ReadKey();
        }
    }
}
