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
            int celsius, fahrenheit;
            Console.WriteLine("Ingrese un temperatura en Celsius");
            celsius = Convert.ToInt32(Console.ReadLine());
            fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine(celsius + "°C a fahrenheit: " + fahrenheit + "°F");
            Console.ReadKey();
        }
    }
}
