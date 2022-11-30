using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuario = "";

            while (!usuario.Equals(".")) //Mentres no sigui igual a "." no acabarà el programa.
            {
                Console.Write("Usuario:");
                usuario = Console.ReadLine();
            }
            Console.WriteLine("Fi del programa");
        }
    }
}
