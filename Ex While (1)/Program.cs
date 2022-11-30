using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_while__1_
{
    internal class Program
    {
        static void Main(string[] args)
        //Lee una secuencia de letras hasta que se introduzca un punto. La salida nos dice el número de veces que lee la letra A (tanto mayúscula como minúscula).
        {
            string a = "";
            int contador_a = 0;

            Console.WriteLine("Escribe una secuencia de letras. No te diremos cuantas A/a has escrito hasta que uses un . (solo puedes escribir 1 letra por fila");
            while (!a.Equals("."))
            {
                a = Console.ReadLine();
                if (a.ToUpper().Equals("A"))
                {
                    contador_a++;
                }
            }
            Console.WriteLine("Has escrito un total de " + contador_a + " A/a.");
        }
    }
}
