using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1__13_Octubre_Bucle_amb_suma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hacer un bucle en el que pida un total de 5 números y que los vaya sumando en una variable.
            // Al final del bucle mostrar la suma de los 5 números.
            int numero = 0;
            int suma = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Numero " + i + ":");
                numero = int.Parse(Console.ReadLine());
                suma += numero;  // suma = suma + numero
            }
            Console.WriteLine("Suma total : " + suma);
        }
    }
}
