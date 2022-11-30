using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halloween
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String personaje;
            int puntos = 0;

            Console.WriteLine("Bienvenido/a a un programa para Halloween de Halloweb. Debes responder con una de las dos opciones para así saber que personaje de Halloween eres.");
            Console.WriteLine("Por favor, escribe las palabras sin faltas ortográficas ya que no te dejará avanzar.");

            do
            {
                Console.WriteLine("¿Cómo te sientes mejor?");
                Console.WriteLine("¿Solo o acompañado?");
                personaje = Console.ReadLine();
                if (personaje.ToUpper().Equals("SOLO"))
                {
                    puntos += 1; //punts = punts +1
                }
                else if (personaje.ToUpper().Equals("ACOMPAÑADO")) //L'ordre ToUpper() fa que siguin vàlides totes les diferents maneres d'escriure una paraula tant si està en majúscula o minúscula.
                {
                    puntos += 0;
                }
                if (!personaje.ToUpper().Equals("ACOMPAÑADO") & !personaje.ToUpper().Equals("SOLO"))
                {
                    Console.WriteLine("No escribas palabras que no son las indicadas."); //Amb ! i &, faig que totes les paraules que siguin diferents a "ACOMPAÑADO" & "SOLO" et digui "No escribas palabras que no son las indicadas". Si en canvi d'haver-hi una &, hi hagués un |, faria que fos tal paraula o l'altre.
                } 

            } while (!personaje.ToUpper().Equals("ACOMPAÑADO") & !personaje.ToUpper().Equals("SOLO")); //Amb do {} while faig que es repeteixi fins que es cumpleixi el programa.


            do
            {
                Console.WriteLine("¿Te gusta ser el centro de atención?");
                Console.WriteLine("¿Sí o no?");
                personaje = Console.ReadLine();
                if (personaje.ToUpper().Equals("SÍ"))
                {
                    puntos += 1;
                }
                else if (personaje.ToUpper().Equals("NO"))
                {
                    puntos += 0;
                }
                if (!personaje.ToUpper().Equals("SÍ") & !personaje.ToUpper().Equals("NO")) 
                {
                    Console.WriteLine("No escribas palabras que no son las indicadas.");
                }

            } while (!personaje.ToUpper().Equals("SÍ") & !personaje.ToUpper().Equals("NO"));


            do
            {
                Console.WriteLine("Eres una persona...");
                Console.WriteLine("¿Agresiva o dócil?");
                personaje = Console.ReadLine();
                if (personaje.ToUpper().Equals("AGRESIVA"))
                {
                    puntos += 1;
                }
                else if (personaje.ToUpper().Equals("DÓCIL"))
                {
                    puntos += 0;
                }
                if (!personaje.ToUpper().Equals("DÓCIL") & !personaje.ToUpper().Equals("AGRESIVA"))
                { 
                    Console.WriteLine("No escribas palabras que no son las indicadas.");
                }

            } while (!personaje.ToUpper().Equals("DÓCIL") & !personaje.ToUpper().Equals("AGRESIVA"));


            do
            {
                Console.WriteLine("¿Cuánta importancia le das a tu apariencia?");
                Console.WriteLine("¿Mucha o poca?");
                personaje = Console.ReadLine();
                if (personaje.ToUpper().Equals("MUCHA"))
                {
                    puntos += 1;
                }
                else if (personaje.ToUpper().Equals("POCA"))
                {
                    puntos += 0;
                }
                if (!personaje.ToUpper().Equals("MUCHA") & !personaje.ToUpper().Equals("POCA"))
                { 
                    Console.WriteLine("No escribas palabras que no son las indicadas."); 
                }

            } while (!personaje.ToUpper().Equals("MUCHA") & !personaje.ToUpper().Equals("POCA"));


            do
            {
                Console.WriteLine("Eres una persona...");
                Console.WriteLine("¿Buena o mala?");
                personaje = Console.ReadLine();
                if (personaje.ToUpper().Equals("MALA"))
                {
                    puntos += 1;
                }
                else if (personaje.ToUpper().Equals("BUENA"))
                {
                    puntos += 0;
                }
                if (!personaje.ToUpper().Equals("BUENA") & !personaje.ToUpper().Equals("MALA")) 
                { 
                    Console.WriteLine("No escribas palabras que no son las indicadas."); 
                }

            } while (!personaje.ToUpper().Equals("BUENA") & !personaje.ToUpper().Equals("MALA"));


            {
                if (puntos == 0) { Console.WriteLine("Eres un HOMBRE/MUJER LOBO."); }
                else if (puntos == 1) { Console.WriteLine("Eres un VAMPIRO."); }
                else if (puntos == 2) { Console.WriteLine("Eres una BRUJA."); }
                else if (puntos == 3) { Console.WriteLine("Eres una MOMIA."); }
                else if (puntos == 4) { Console.WriteLine("Eres un ZOMBI."); }
                else if (puntos == 5) { Console.WriteLine("Eres un FANTASMA."); }
            }

            Console.WriteLine("¡Fin del juego y feliz Halloween!");


        }
    }
}
