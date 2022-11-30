using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex_for__4_
{
    internal class Program
    {
        static void Main(string[] args)
        //Algoritmo que muestre un tablero de ajedrez, mostrando las casillas negras como # i las blancas como _
        {
            for (int blancas = 0; blancas < 8; blancas++)
            {
                for (int negras = 0; negras < 8; negras++)
                {
                    if ((blancas + negras) % 2 == 0)
                    {
                        Console.Write("_");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
