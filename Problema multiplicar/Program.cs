using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_multiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabla, minimo, maximo;
            Console.WriteLine("Taula de multiplicar :");
            tabla = int.Parse(Console.ReadLine());

            Console.WriteLine("Número inicial :");
            minimo = int.Parse(Console.ReadLine());

            Console.WriteLine("Fins quin número? :");
            maximo = int.Parse(Console.ReadLine());

            for (int a = minimo; a <= maximo; a++)
            {
                Console.WriteLine(a + "*" + tabla + "=" + a * tabla);
            }
        }
    }
}
