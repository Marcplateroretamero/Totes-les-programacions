using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5__13_Octubre_Mostrar_nums_imparells_de_0_a_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mostrar los números impares del 0 al 10
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 != 0) //Poniendo un %, se toma el número del resto de un número. En este caso se toma del 2, pero está puesto con una !, 2 es par y tiene de resto 0, saldrá impar por la !.
                {
                    Console.WriteLine("Numero : " + i);
                }
            }
        }
    }
}
