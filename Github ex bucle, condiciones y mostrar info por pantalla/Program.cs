using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github_ex_bucle__condiciones_y_mostrar_info_por_pantalla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String como_eres;

            do
            {
                Console.WriteLine("¿Cómo eres? ¿Feo, guapo o normal?");
                como_eres = Console.ReadLine();
                if (como_eres.ToUpper().Equals("FEO"))
                {
                    Console.WriteLine("Eres feo.");
                }
                else if (como_eres.ToUpper().Equals("GUAPO"))
                {
                    Console.WriteLine("Eres guapo.");
                }
                else if (como_eres.ToUpper().Equals("NORMAL"))
                {
                    Console.WriteLine("Eres normal.");
                }
                if (!como_eres.ToUpper().Equals("FEO") & !como_eres.ToUpper().Equals("GUAPO") & !como_eres.ToUpper().Equals("NORMAL"))
                {
                    Console.WriteLine("Contesta a lo que pregunta.");
                }

            } while (!como_eres.ToUpper().Equals("FEO") & !como_eres.ToUpper().Equals("GUAPO") & !como_eres.ToUpper().Equals("NORMAL"));
        }
    }
}
