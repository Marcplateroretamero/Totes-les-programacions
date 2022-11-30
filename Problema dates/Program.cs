using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia_avui = DateTime.Now.Day;
            int mes_avui = DateTime.Now.Month;
            int any_avui = DateTime.Now.Year;

            int dia_naixement, mes_naixement, any_naixement;

            Console.Write("Dia naixement: ");
            dia_naixement = int.Parse(Console.ReadLine());
            Console.Write("Mes naixement: ");
            mes_naixement = int.Parse(Console.ReadLine());
            Console.Write("Any naixement: ");
            any_naixement = int.Parse(Console.ReadLine());

            if (any_avui - any_naixement >= 18)
            {
                if (any_avui - any_naixement > 18)
                {
                    Console.WriteLine("Ets major d'edat");
                }
                else
                {
                    if (mes_avui - mes_naixement >= 0)
                    {
                        if (dia_avui - dia_naixement >= 0)
                        {
                            Console.WriteLine("Ets major d'edat");
                        }
                        else
                        {
                            Console.WriteLine("No ets major d'edat");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No ets major d'edat");
                    }
                }
            }
            else
            {
                Console.WriteLine("No ets major d'edat");
            }
        }
    }
}
