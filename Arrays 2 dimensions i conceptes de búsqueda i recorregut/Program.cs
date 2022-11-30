using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_2_dimensions_i_conceptes_de_búsqueda_i_recorregut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean encontrado = false;
            int suma = 0;
            Random rand = new Random();

            // Técnica del recorrido
            // Para encontrar el resultado hay que realizar sí o sí
            // el recorrido desde el inicio hasta el final del array
            int[] ar = new int[10];

            int fila = 0;

            for (int i = 0; i < ar.GetLength(0); i++)
            {
                ar[i] = rand.Next(0, 50);
            }
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                Console.WriteLine(ar[i]);
            }
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                if (ar[i] > 30)
                {
                    suma++;
                }
            }
            Console.WriteLine("hay " + suma + " valores mayor de 30");

            // Técnica de la búsqueda
            // En el momento en que se encuentra el resultado
            // de lo que se busca hay que salir del bucle
            while (fila < ar.GetLength(0) & !encontrado)
            {
                if (ar[fila] > 30)
                {
                    encontrado = true;
                }
                fila++;
            }

            Console.WriteLine(encontrado);


            int[,] ar2 = new int[5, 3];

            for (int i = 0; i < ar2.GetLength(0); i++)
            {
                for (int j = 0; j < ar2.GetLength(1); j++)
                {
                    ar2[i, j] = rand.Next(0, 100); //returns random number between 0-99
                }
                //   -----------------------------------------------
            }
            for (int i = 0; i < ar2.GetLength(0); i++)
            {
                for (int j = 0; j < ar2.GetLength(1); j++)
                {
                    Console.Write(ar2[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
