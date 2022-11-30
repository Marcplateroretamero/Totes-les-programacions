using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_arrays__8_
{
    internal class Program
    {
        static void Main(string[] args)
        //Rellena un array de 10 valores de tipo entero de forma aleatoria del 1 al 100 ¿Hay algún valor mayor de 50?
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
            if (mayores_50 == 1)
            {
                Console.WriteLine("Sí, hay 1 número mayor de 50.");
            }
            if (mayores_50 > 1)
            {
                Console.WriteLine("Sí, hay más de 1 número mayor de 50.");
                Console.WriteLine("De hecho hay " + mayores_50 + " números mayores de 50.");
            }
            else if (mayores_50 == 0)
            {
                Console.WriteLine("No hay números mayores de 50.");
            }
        }
    }
}
