using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_arrays__4_
{
    internal class Program
    {
        static void Main(string[] args)
        //Rellena un array de 10 valores de tipo entero de forma aleatoria. Mostrar cuantos valores son pares.
        {
            int[] numeros = new int[10];
            int contador_pares = 0;
            Random aleatorio = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = aleatorio.Next(1, 1000);
                Console.WriteLine(numeros[i]);

                if (numeros[i] % 2 == 0)
                {
                    contador_pares++;
                    Console.WriteLine("El número " + numeros[i] + " es par.");
                }
            }
            Console.WriteLine("Hay un total de " + contador_pares + " números pares.");
        }
    }
}
