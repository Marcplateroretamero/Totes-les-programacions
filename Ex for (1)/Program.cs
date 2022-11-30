using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ex_for__1_
{
    internal class Program
    {
        static void Main(string[] args)
        //Algoritmo que calcula la suma de los números pares y los números impares de los números entre 1 y 100.
        {
            int pares = 0;
            int impares = 0;
            
            Console.WriteLine("Programa que calcula la suma de pares y impares entre 1 y 100.");

            for (int i = 1; i < 100; i ++)
            {
                if (i % 2 == 0)
                {
                    pares = pares + i;
                }
                else
                {
                    impares = impares + i;
                }
            }
            Console.WriteLine("Suma de números pares = " + pares);
            Console.WriteLine("Suma de números impares = " + impares);
            Console.WriteLine("Suma de números pares y impares = " + (pares + impares));
        }
    }
}
