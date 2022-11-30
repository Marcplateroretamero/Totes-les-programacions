using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_arrays__2_
{
    internal class Program
    {
        static void Main(string[] args)
        //Rellena un array de 10 valores de tipo entero de forma aleatoria. Ordena el array de menor a mayor en el mismo array.No se debe realizar un array complementario ni auxiliar.
        {
            int[] numeros = new int[10];
            Random aleatorio = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                List<int> list = new List<int>();

                numeros[i] = aleatorio.Next(1, 1000);
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
