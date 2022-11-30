using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_for__3_
{
    internal class Program
    {
        static void Main(string[] args)
        //Algoritmo que muestre la tabla de multiplicar del 7
        {
            int tabla_7 = 7, num_mínimo, num_máximo;

            Console.WriteLine("La tabla con la que multiplicarás cualquier número es la del 7.");

            Console.WriteLine("Escribe un número inicial:");
            num_mínimo = int.Parse(Console.ReadLine());

            Console.WriteLine("Escribe un número final:");
            num_máximo = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            for (int a = num_mínimo; a <= num_máximo; a++)
            {
                Console.WriteLine(a * tabla_7);
            }
        }
    }
}
