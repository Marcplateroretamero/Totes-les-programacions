using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ex_while__2_
{
    internal class Program
    {
        static void Main(string[] args)
        //Lee una secuencia de números diferentes hasta introducir un 0 y luego el algoritmo nos dice cuántos son positivos, cuántos son negativos, cuántos son pares y cuántos múltiplos de 3.
        {
            int nums;
            int contador_positivos = 0;
            int contador_negativos = 0;
            int contador_pares = 0;
            int contador_multiplos_3 = 0;

            Console.WriteLine("Escribe números diferentes, cuando escribas 0 parará el programa y te dirá cuántos son positivos, negativos, pares y múltiplos de 3.");
            do
            {
                    nums = int.Parse(Console.ReadLine());
                    if (nums > 0)
                    {
                        contador_positivos++;
                    }
                    if (nums < 0)
                    {
                        contador_negativos++;
                    }
                    if (nums % 2 == 0)
                    {
                        contador_pares++;
                    }
                    if (nums % 3 == 0)
                    {
                        contador_multiplos_3++;
                    }
            } while (!nums.Equals(0));
            Console.WriteLine("Hay " + contador_positivos + " positivos, " + contador_negativos + " negativos, " + contador_pares + " pares y " + contador_multiplos_3 + " múltiplos de 3.");
        }
    }
}
