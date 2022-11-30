using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Array_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] t = { 1, 4, 6, 3, 7, 2, 4, 2, 9, 7, 8, 3 };
            int mínim, màxim;
            int g = 0;
            int f = 0;

            Console.WriteLine("Mínim: ");
            mínim = int.Parse(Console.ReadLine());
            Console.WriteLine("Màxim: ");
            màxim = int.Parse(Console.ReadLine());

            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] >= mínim & t[i] <= màxim)
                {
                    Console.WriteLine(t[i]);
                    g++;
                }
            }
            Console.WriteLine("Hi han {0} números entre {1} i {2}", g, mínim, màxim); // Això fa que li diguis un mínim i un màxim, entre aquests valors et dirà quins números són i quants hi han.
            for (int i = 0; i < t.Length; i++) 
            {
                if (t[i] < mínim | t[i] > màxim)
                {
                    Console.WriteLine(t[i]);
                    f++;
                }
            }
            Console.WriteLine("Hi han {0} números fora entre {1} i {2}", g, mínim, màxim); // Això et diu els números que estan fora de del mínim i màxim nombrat anteriorment.
            int suma = 0;
            float mitjana;
            for (int i = 0; i < t.Length; i++) 
            {
                suma += t[i];
            }
            mitjana = (float)suma / t.Length;
            Console.WriteLine("Mitjana = " + mitjana); // Això et dona la mitjana dins dels valors mencionats en el mínim i màxim.
        }
    }
}
