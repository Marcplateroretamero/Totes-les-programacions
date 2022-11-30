using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2__13_Octubre_Introduir_nums_fins_igual_0_amb_suma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedir números por teclado hasta que se introduzca el número 0
            // Mostrar la suma de todos los números que se han introducido
            int numero = 0;
            int suma = 0;
            int i = 1;
            do
            {
                Console.Write("Numero " + i + ":");
                numero = int.Parse(Console.ReadLine());
                suma += numero;  // suma = suma + numero
                i++;
            } while (numero != 0);

            Console.WriteLine("Suma total : " + suma);
        }
    }
}
