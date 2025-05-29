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
            int dia, mes, dian, mesn, año;
            Console.WriteLine("Ingrese un numero de dia:");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero de mes:");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero de año:");
            año = Convert.ToInt32(Console.ReadLine());
            dia = dia + 30;
            dian = 0;
            mesn = 0;
            if (año % 4 == 0 || año % 400 == 0)
            {
                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    if (dia > 31)
                    {
                        dian = dia % 31;
                        mesn = mes + 1;
                    }
                }
                if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    if (dia > 30)
                    {
                        dian = dia % 30;
                        mesn = mes + 1;
                    }
                }
                if (mes == 2)
                {
                    if (dia > 29)
                    {
                        dian = dia % 29;
                        mesn = mes + 1;
                    }
                }
                if (mes >= 12)
                {
                    dian = dia % 31;
                    mesn = mesn % 12;
                    año = año + 1;
                }
            }
            else
            {
                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    if (dia > 31)
                    {
                        dian = dia % 31;
                        mesn = mes + 1;
                    }
                }
                if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    if (dia > 30)
                    {
                        dian = dia % 30;
                        mesn = mes + 1;
                    }
                }
                if (mes == 2)
                {
                    if (dia > 28)
                    {
                        dian = dia % 28;
                        mesn = mes + 1;
                    }
                }
                if (mes >= 12)
                {
                    dian = dia % 31;
                    mesn = mesn % 12;
                    año = año + 1;
                }
            }
            Console.WriteLine("La nueva fecha es: " + dian + "/" + mesn + "/" + año);
            Console.ReadKey();
        }
    }
}