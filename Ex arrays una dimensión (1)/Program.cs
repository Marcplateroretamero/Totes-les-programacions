using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_arrays__1_
{
    internal class Program
    {
        static void Main(string[] args)
        //Rellena un array de 10 valores de tipo entero de forma aleatoria. Muestra por pantalla el valor mínimo y el máximo y en qué índice están ubicados.
        {
            int[] numeros = new int[10];
            int mínimo, máximo;
            Random aleatorio = new Random();

            // Llenamos un array con 10 valores aleatorios entre 1 y 1000.
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = aleatorio.Next(1, 1000);
                Console.WriteLine(numeros[i]);
            }

            // Buscamos el valor máximo y mínimo.
            mínimo = máximo = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                if (mínimo > numeros[i])
                {
                    mínimo = numeros[i];
                }
                else if (máximo < numeros[i])
                {
                    máximo = numeros[i];
                }
            }
            Console.WriteLine("El valor máximo del array es: " + máximo);
            Console.WriteLine("El valor mínimo del array es: " + mínimo);
        }
    }
}
