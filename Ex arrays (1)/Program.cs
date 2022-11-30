using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_arrays__6_
{
    internal class Program
    {
        static void Main(string[] args)
        //Introducir un número entero de 5 cifras por teclado. Almacenar cada número de los 5 en una posición de un array de 5 casillas. Indicar si el número es capicúa.
        {
            Console.WriteLine("Escribe un número entero de 5 cifras y determinaré si es capicúa.");
            int número = int.Parse(Console.ReadLine());
            int dígito = 0;
            int invertir = 0;
            int e = número;

            while (número > 0)
            {
                dígito = número % 10;
                invertir = (invertir * 10) + dígito;
                número = (número - dígito) / 10;
            }
            if (invertir == e)
            {
                Console.WriteLine("Es un número capicúa.");
            }
            else
            {
                Console.WriteLine("No es un número capicúa.");
            }
        }
    }
}
