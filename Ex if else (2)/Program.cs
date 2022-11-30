using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_if_else__2_
{
    internal class Program
    {
        static void Main(string[] args)
        //Algoritmo que lee un número y nos dice si es múltiple de dos, o de tres, o de ninguno de ellos.
        {
            int num;

            Console.WriteLine("Escribe un número y te diré si es múltiple de 2, de 3 o de ninguno de los dos.");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0 || num % 3 == 0)
            {
                Console.WriteLine("El número ingresado es múltiple de 2 o 3.");
            }
            else
            {
                Console.WriteLine("No es múltiple.");
            }
        }
    }
}
