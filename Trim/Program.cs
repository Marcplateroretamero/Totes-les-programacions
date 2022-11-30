using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom1, nom2;
            nom1 = "     Maria Garcia    ";
            nom2 = "  Josep López                           ";

            if (nom1.Trim().ToUpper().Equals(nom2.Trim().ToUpper()));
            { Console.WriteLine("Es la Maria"); }
            else { Console.WriteLine("No és la Maria"); }
        }
    }
}
