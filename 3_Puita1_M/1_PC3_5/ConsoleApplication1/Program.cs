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
            int dia, mes, año, diaa, mesa, añoa, cont;
            cont = 0;

            Console.WriteLine("Ingrese el número de su día de nacimiento:");
            dia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el número de su mes de nacimiento:");
            mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el número de su año de nacimiento:");
            año = Convert.ToInt32(Console.ReadLine());

            if (año > 0 && año < 2100)
            {
                Console.WriteLine("Ingrese el número del día actual:");
                diaa = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el número del mes actual:");
                mesa = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el número del año actual:");
                añoa = Convert.ToInt32(Console.ReadLine());

                while (dia != diaa || mes != mesa || año != añoa)
                {
                    dia++;
                    cont++;

                    int diasEnMes = 0;

                    if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                    {
                        diasEnMes = 31;
                    }
                    if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                    {
                        diasEnMes = 30;
                    }
                    if (mes == 2)
                    {
                        if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
                        {
                            diasEnMes = 29;
                        }
                        else
                        {
                            diasEnMes = 28;
                        }
                    }

                    if (dia > diasEnMes)
                    {
                        dia = 1;
                        mes++;
                    }

                    if (mes > 12)
                    {
                        mes = 1;
                        año++;
                    }
                }
                Console.WriteLine("Días vividos: " + cont);
            }
            Console.ReadKey();
        }
    }
}

