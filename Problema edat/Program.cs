using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_edat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edat, num_tutors;
            string nombre;

            Console.Write("Edat :"); //La consola al executar-se diu "Edat :"
            edat = int.Parse(Console.ReadLine());

            if (edat >= 18) { Console.WriteLine("Ets major d'edat"); }
            else { Console.WriteLine("Quants tutors tens?"); }
            num_tutors = int.Parse(Console.ReadLine());

            for (int a = 0; a < num_tutors; a++) ;
            {
                Console.Write("Nombre del tutor " + a + ": ");
                nombre = Console.ReadLine();
                Console.WriteLine("El nombre del tutor " + a + " es " + nombre);
            }
        }
    }
}
