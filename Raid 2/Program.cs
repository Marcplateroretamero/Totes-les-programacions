using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // En aquest programa, s'obté el nombre de números que hi han dins de la raid de "t". Per exemple, si posem 3, dirà que hi han 3 de 3 en la raid.
            int[] t = { 1, 5, 6, 3, 8, 3, 5, 7, 3 };
            int num_casella;
            int n = 0;

            Console.WriteLine("Entra un número: ");
            num_casella = int.Parse(Console.ReadLine());

            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == num_casella)
                {
                    n++;
                }
            }
            Console.WriteLine("Hi han {0} números de {1}", n, num_casella);

        }
    }
}
