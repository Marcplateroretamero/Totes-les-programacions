using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int any = DateTime.Now.Year;

           Console.WriteLine("Avui estem a aquest dia i hora: " + DateTime.Now);
        }
    }
}
