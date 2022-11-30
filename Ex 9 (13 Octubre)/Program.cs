using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_9__13_Octubre_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedir 5 datos alfanuméricos por teclado.
            // Si uno de los datos es "ABCD" mostrar el texto "Respuesta Correcta"
            {
                String dato = "";
                Boolean encontradoABCD = false;
                Boolean encontradoAB12 = false;
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write("Dato : " + i);
                    dato = Console.ReadLine();
                    if (dato.Equals("ABCD"))
                    {
                        encontradoABCD = true;
                    }
                    else if (dato.Equals("AB12"))
                    {
                        encontradoAB12 = true;
                    }
                }

                if (encontradoABCD & encontradoAB12)
                {
                    Console.WriteLine("Respuesta correcta");
                }
            }
        }
    }
}
