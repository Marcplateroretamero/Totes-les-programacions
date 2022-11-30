using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_while__3_
{
    internal class Program
    {
        static void Main(string[] args)
        //Lee una secuencia de notas enteras (0..10) hasta que se introduce el -1 y entonces nos dice la media aritmética de todas las notas introducidas,
        //cuántos han sacado excelente(9-10), cuánto notable(7-8), cuántos suficiente(5-6) , cuántos insuficiente(3-4) y cuántos muy deficiente.
        {
            double notas;
            int suma = 0;
            double media;
            double t = 0;
            int excelente = 10 | 9;
            int notable = 8 | 7;
            int suficiente = 6 | 5;
            int insuficiente = 4 | 3;
            int muy_deficiente = 2 | 1 | 0;
            int contador_excelente = 0;
            int contador_notable = 0;
            int contador_suficiente = 0;
            int contador_insuficiente = 0;
            int contador_muy_deficiente = 0;

            Console.WriteLine("Escribe tus notas en números enteros (0-10), si se escribe -1, te dirá la media aritmética de esas notas y también cuántos excelentes, notables, suficientes, insuficientes y muy deficientes hay.");
            do
            {
                notas = double.Parse(Console.ReadLine());
                if (notas != -1)
                {
                    if (notas < 10 & notas > 0)
                    {
                        t += notas;
                    }
                    if (notas == 10 | notas == 9)
                    {
                        contador_excelente++;
                        suma++;
                    }
                    if (notas == 8 | notas == 7)
                    {
                        contador_notable++;
                        suma++;
                    }
                    if (notas == 6 | notas == 5)
                    {
                        contador_suficiente++;
                        suma++;
                    }
                    if (notas == 4 | notas == 3)
                    {
                        contador_insuficiente++;
                        suma++;
                    }
                    if (notas == 2 | notas == 1 | notas == 0)
                    {
                        contador_muy_deficiente++;
                        suma++;
                    }
                }
            }
            while (notas != -1);
            {
                media = t / suma;
                Console.WriteLine("La media es = " + media);
                Console.WriteLine("Han sacado " + contador_excelente + " excelentes, " + contador_notable + " notables, " + contador_suficiente + " suficientes, " + contador_insuficiente + " insuficientes y " + contador_muy_deficiente + " muy deficientes.");
            }
        }
    }
}
