using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_if_else__4_
{
    internal class Program
    {
        static void Main(string[] args)
        //En una granja tenemos un número de animales (numAnimales) , cada animal come una media diaria de unos kilogramos de pienso (KgAnimal).
        //Cada día nos llega una cantidad de kilos de pienso(comida). Se pedirá al usuario los valores anteriores y deberemos indicar si hay suficiente comida o no.
        //En caso de que no haya suficiente comida hay que indicar qué cantidad de kilos diaria falta.
        {
            int numAnimales;
            int KgAnimal;
            int KgPienso;

            Console.WriteLine("Indica el número de animales:");
            numAnimales = int.Parse(Console.ReadLine());
            Console.WriteLine("Indica el número de Kg de pienso que comen en total los animales:");
            KgAnimal = int.Parse(Console.ReadLine());
            Console.WriteLine("Indica el número de Kg de pienso que llega en la granja:");
            KgPienso = int.Parse(Console.ReadLine());

            if (KgAnimal <= KgPienso)
            {
                Console.WriteLine("Habrá sufieciente comida para todos.");
            }
            else
            {
                Console.WriteLine("No habrá suficiente comida para todos.");
                Console.WriteLine("La cantidad de comida que comen en total los animales es de " + KgAnimal + " kilos y el pienso que llega es de " + KgPienso + " kilos.");
                Console.WriteLine("Por tanto nos faltará una cantidad de " + (KgAnimal - KgPienso) + " kilos de pienso.");
            }
        }
    }
}
