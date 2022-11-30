using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_while__4_
{
    internal class Program
    {
        static void Main(string[] args)
        //Dado un número, ¿Cuántos dígitos tiene? (Se puede obtener con divisiones entre 10 sucesivas)
        {
            int contador = 0;

            Console.WriteLine("Escribe cualquier número entero:");
            int num = int.Parse(Console.ReadLine());
            
            while (num >= 1)
            {
                contador++;
                num = num / 10;
            }
            Console.WriteLine("El número que has escrito tiene " + contador + " dígitos.");
        }
    }
}
