using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_arrays__5_
{
    internal class Program
    {
        static void Main(string[] args)
        //Rellena un array de 10 valores de tipo entero de forma aleatoria. Obtener la media de todos los valores del array
        {
            int[] numeros = new int[10];
            int suma = 0;
            Random aleatorio = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = aleatorio.Next(1, 1000);
                Console.WriteLine(numeros[i]);

                suma += numeros[i];
            }
            double media = (double)suma / numeros.Length;
            Console.WriteLine("La media de los 10 números aleatorios es: " + media);
        }
    }
}
