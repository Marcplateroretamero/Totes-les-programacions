using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_contrasenya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contrasenya = "";
            int intents = 0;

            while (!contrasenya.Equals("1234")) //Mentres no sigui igual a "1234" no acabarà el programa.
            {
                Console.Write("Contrasenya de 4 digits:");
                contrasenya = Console.ReadLine();
                {
                    if (!contrasenya.Equals("1234")) { Console.WriteLine("Contrasenya incorrecte, " + intents + 1 + " de 03 intents"); }
                }
            }
            Console.WriteLine("Contrasenya correcte"); 
        }
    }
}
