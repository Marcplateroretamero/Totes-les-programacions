using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguim_programant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100; //Valor de a, en aquest cas a = 100
            int b = 200; //Valor de b, en aquest cas b = 200
            int c = 250; //Valor de c, en aquest cas c = 250

            if (a > 0) { Console.WriteLine("Estamos en el if"); } //Si a és més gran que 0, llavors dirà "Estamos en el if"
            else { Console.WriteLine("Estamos en el else"); } //Si a és més petit que 0, llavors dirà "Estamos en el else"
            if (b < 500) { Console.WriteLine("Bon dia"); } //Si b és més petit que 500, llavors dirà "Bon dia"
            else { Console.WriteLine("Bona nit"); } //Si b és més gran que 500, llavors dirà "Bona nit"
            if (c > 150) { Console.WriteLine("Programa ben fet"); } //Si c és més gran que 150, llavors dirà "Programa ben fet"
            else { Console.WriteLine("Programa mal fet"); } //Si c és més petit que 150, llavors dirà "Programa mal fet"
            if (a > b) { Console.WriteLine("Sí"); } //Si a és més gran que b, llavors dirà "Sí"
            else { Console.WriteLine("No"); } //Si a és més petit que b, llavors és "No"
        }
    }
}
