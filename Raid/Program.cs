using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] t = { 6, 4, 7, 2, 9, 3 }; // Valors taula de raid, el primer número en aquest cas 6, està en la casella 1, el 4 estaria en la 2 i així respectivament.
            t[4] = 8; // Això faria que el valor de la casella 4 que en aquest cas és 2, passi a ser = 8.
            int[] ar = new int[10]; // Això fa que hi hagi fins un límit de 10 caràcters: 0, 1, 2, 3, 4, 5, 6, 7, 8 i 9.
            
            Console.WriteLine(t[4]);

            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = i;
            }

            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(ar[i]);
            }
      
        }
    }
}
