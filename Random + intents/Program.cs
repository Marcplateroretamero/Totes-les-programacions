using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random___intents
{
    internal class Program
    {
        static void Main(string[] args)
        //Amb aquest programa, tens 10 intents per acertar un número random entre 0 i 9. Quan l'adivinis et dirà "Lo adivinaste!".
        {
            int adivinar, numero;
            Random aleatorio = new Random();
            adivinar = aleatorio.Next(0, 9);
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Queda {0} intentos.", 10 - i);
                Console.WriteLine("Introduce un número");
                numero = int.Parse(Console.ReadLine());
                if (adivinar == numero)
                {
                    Console.WriteLine("Lo adivinaste!");
                    break;
                }
            }
        }
    }
}
