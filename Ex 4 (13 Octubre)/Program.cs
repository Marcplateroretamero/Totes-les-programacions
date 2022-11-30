using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4__13_Octubre_Mostrar_nums_parells_de_0_a_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mostrar los números pares del 0 al 10
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0) //Poniendo un %, se toma el número del resto de un número. En este caso se toma del 2, como 2 es par y tiene de resto 0, saldrá par.
                {
                    Console.WriteLine("Numero : " + i);
                }
            }
        }
    }
}
