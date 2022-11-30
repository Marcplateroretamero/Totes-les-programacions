using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passar_de_decimal_a_binari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Com és pot passar de decimal a binari?
            //Per poder passar-lo has d'agafar el número decimal que tens i has d'anar dividint-lo entre 2 fins que no puguis més. Has d'anar afegint els residus que t'hagin sortit (0 o 1),
            // fins acabar obtinguent un número com per exemple 10011101. S'ha de posar el número des de l'últim 0 o 1 que has obtingut fins al primer.

            //Per poder passar-ho al contrari, de binari a decimal, s'ha de mirar en quina posició està cada 0 i 1. Si per exemple el número binari que volem passar és:
            //10011, haurem de començar sabent que seria igual a 2^4 2^3 2^2 2^1 2^0. Llavors només hem de tenir en comte del número binari, els que són 1ns.
            //Lavors només multiplicariem el 2^4, 2^1 i 2^0. Quan tinguéssim en aquest cas els 3 números de resultats, s'haurien de sumar els 3 i tindriem el número en decimal     .
        }
    }
}
