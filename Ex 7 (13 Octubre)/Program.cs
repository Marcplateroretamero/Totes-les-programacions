using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7__13_Octubre_ABCD_i_dir_resposta_correcte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedir 5 datos alfanuméricos por teclado.
            // Si uno de los datos es "ABCD" mostrar el texto "Respuesta Correcta"
            String dato = "";
            Boolean encontrado = false;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Dato : " + i);
                dato = Console.ReadLine();
                if (dato.Equals("ABCD"))
                {
                    encontrado = true;
                }
            }
            if (encontrado)
            {
                Console.WriteLine("correcto");
            }
        }
    }
}
