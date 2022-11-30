using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ex_if_else__1_
{
    internal class Program
    {
        static void Main(string[] args)
        //El programa debe pedir tres números por teclado, indicar (mostrar por pantalla) cual es el mayor, el menor y del medio.
        {
            int num_1, num_2, num_3;

            Console.WriteLine("Escribe tres números diferentes:");
            num_1 = int.Parse(Console.ReadLine());
            num_2 = int.Parse(Console.ReadLine());
            num_3 = int.Parse(Console.ReadLine());

            if (num_1 > num_2 & num_2 > num_3)
            {
                Console.WriteLine("Número 1 es mayor = " + num_1);
                Console.WriteLine("Número 2 es medio = " + num_2);
                Console.WriteLine("Número 3 es menor = " + num_3);
            }
            else if (num_2 > num_1 & num_1 > num_3)
            {
                Console.WriteLine("Número 1 es medio = " + num_1);
                Console.WriteLine("Número 2 es mayor = " + num_2);
                Console.WriteLine("Número 3 es menor= " + num_3);
            }
            else if (num_2 > num_1 & num_1 > num_3)
            {
                Console.WriteLine("Número 2 es mayor = " + num_2);
                Console.WriteLine("Número 1 es medio = " + num_1);
                Console.WriteLine("Número 3 es menor = " + num_3);
            }
            else if (num_2 > num_3 & num_3 > num_1)
            {
                Console.WriteLine("Número 2 es mayor = " + num_2);
                Console.WriteLine("Número 3 es medio = " + num_3);
                Console.WriteLine("Número 1 es menor = " + num_1);
            }
            else if (num_3 > num_1 & num_1 > num_2)
            {
                Console.WriteLine("Número 3 es mayor = " + num_3);
                Console.WriteLine("Número 1 es medio = " + num_1);
                Console.WriteLine("Número 2 es menor = " + num_2);
            }
            else if (num_3 > num_2 & num_2 > num_1)
            {
                Console.WriteLine("Número 3 es mayor = " + num_3);
                Console.WriteLine("Número 2 es medio = " + num_2);
                Console.WriteLine("Número 1 es menor = " + num_1);
            }
            else if (num_1 == num_2 & num_1 == num_3 && num_2 == num_3)
            {
                Console.WriteLine("Los tres números son iguales");
            }
        }
    }
}

