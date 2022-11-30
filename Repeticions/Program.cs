using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeticions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++) //Inicialment i = 0, com i <= 10 es cumpleix i es fa i * 5, el que és = 0. Es repetiex però ara és i++ (i+1), seria 1 * 5 = 5. Seria tota l'estona el mateix fins que s'hagin fet les 11 vegades al anar sumant cada vegada un 1 a i.
            {
                Console.WriteLine(i * 5); //Repetició en bucle la qual no para d'executar i * 5 fins que no es cumpleixi el de la linia superior.
            }
            Console.WriteLine("Fi"); //Quan ha acabat la repetició passa a aquesta linia la qual diu "Fi"
        }
    }
}

