using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 10;
            int d = 25;

            if (a < 5) { Console.WriteLine("Hola"); } //Si a és més petit que 5, llavors dirà "Hola"
            else if (a == b) { Console.WriteLine("Hello"); } //Si a és igual a b, llavors dirà "Hello"
            else if (a == c) { Console.WriteLine("Hey"); } //Si a és igual a c, llavors dirà "Hey"

            if (d > 45) { Console.WriteLine("Bones"); } //Si d és més gran que 45, llavors dirà "Bones"
            if (d == 50) { Console.WriteLine("Dolentes"); } //Si d és igual a 50, llavors dirà "Dolentes"
            else { Console.WriteLine("Visca"); } //Si d no és igual a 50, llavors dirà "Visca"
        }
    }
}
