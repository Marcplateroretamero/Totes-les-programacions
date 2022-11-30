using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3__13_Octubre_Demanar_nums_sumar_los_i_quan_sigui_el_total_superior_o_igual_a_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedir números por teclado y sumarlos en una variable.
            // Se finaliza cuando la suma de los número introducidos sea mayor de 100.
            int numero = 0;
            int suma = 0;
            int i = 1;
            do
            {
                Console.Write("Numero " + i + ":");
                numero = int.Parse(Console.ReadLine());
                suma += numero;  // suma = suma + numero
                i++;
            } while (suma <= 100);

            Console.WriteLine("Suma total : " + suma);
        }
    }
}
