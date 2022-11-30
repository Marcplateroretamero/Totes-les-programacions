using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_arrays__7_
{
    internal class Program
    {
        static void Main(string[] args)
        //Rellena un array de 10 valores de tipo entero de forma aleatoria del 1 al 100 ¿Cuantos valores son mayores de 50?
        {
            int[] numeros = new int[10];
            int mayores_50 = 0;

            Random aleatorio = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                List<int> list = new List<int>();

                numeros[i] = aleatorio.Next(1, 100);
                Console.WriteLine(numeros[i]);

                if (numeros[i] > 50) 
                {
                    mayores_50++; 
                }
            }
            Console.WriteLine("Hay una cantidad de " + mayores_50 + " números mayores de 50.");
        }
    }
}
