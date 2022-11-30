using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_for__2_
{
    internal class Program
    {
        static void Main(string[] args)
        //De una secuencia de 10 números cuántos son positivos, cuántos son negativos, cuántos son pares y cuántos múltiplos de 4.
        {
            int[] nums = new int[10];
            int contador_positivos = 0;
            int contador_negativos = 0;
            int contador_pares = 0;
            int contador_multiplos_4 = 0;

            Console.WriteLine("Escribe 10 números enteros y te diré cuantos son positivos, negativos, pares y múltiples de 4.");
            for (int i = 0; i < 10; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
                if (nums[i] >= 0)
                {
                    contador_positivos++;
                }
                if (nums[i] < 0)
                {
                    contador_negativos++;
                }
                if (nums[i] % 2 == 0)
                {
                    contador_pares++;
                }
                if (nums[i] % 4 == 0)
                {
                    contador_multiplos_4++;
                }
            }
            Console.WriteLine("Hay " + contador_positivos + " positivos, " + contador_negativos + " negativos, " + contador_pares + " pares y " + contador_multiplos_4 + " múltiplos de 4.");
        }
    }
}
