using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cilindros, pistas, sectores;
            Console.WriteLine("Ingrese la cantidad de cilindros");
            cilindros = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de pistas");
            pistas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de sectores");
            sectores = Convert.ToInt32(Console.ReadLine());
            long capacidadBytes = (long)cilindros * pistas * sectores * 512;
            double capacidadKB = (double)capacidadBytes / 1024;
            double capacidadMB = capacidadKB / 1024;
            double capacidadGB = capacidadMB / 1024; Console.WriteLine("Capacidad del disco duro en: kilobytes " + capacidadKB + " || megabytes " + capacidadMB + " || gigabytes " + capacidadGB);
            Console.ReadKey();
        }
    }
}