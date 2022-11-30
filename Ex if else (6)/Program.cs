using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Ex_if_else__6_
{
    internal class Program
    {
        static void Main(string[] args)
        //Algoritmo que calcula el cambio a devolver. Solicitar el importe total de la compra y la cantidad pagada por el cliente.
        //Después de comprobar que la cantidad pagada sea mayor que el importe de la compra, se calculará cuántos billetes y monedas debemos devolver al cliente.
        {
            decimal importe;
            decimal cantidad_pagada;
            decimal resto_pagar;

            decimal moneda_001 = 0.01M;
            int moneda001 = 0;

            decimal moneda_002 = 0.02M;
            int moneda002 = 0;

            decimal moneda_005 = 0.05M;
            int moneda005 = 0;

            decimal moneda_010 = 0.1M;
            int moneda010 = 0;

            decimal moneda_020 = 0.2M;
            int moneda020 = 0;

            decimal moneda_050 = 0.5M;
            int moneda050 = 0;

            decimal moneda_100 = 1M;
            int moneda100 = 0;

            decimal moneda_200 = 2M;
            int moneda200 = 0;

            decimal billete_5 = 5M;
            int billete5 = 0;

            decimal billete_10 = 10M;
            int billete10 = 0;

            decimal billete_20 = 20M;
            int billete20 = 0;

            decimal billete_50 = 50M;
            int billete50 = 0;

            decimal billete_100 = 100M;
            int billete100 = 0;

            decimal billete_200 = 200M;
            int billete200 = 0;

            decimal billete_500 = 500M;
            int billete500 = 0;

            Console.WriteLine("Importe a pagar:");
            importe = int.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad pagada por el cliente:");
            cantidad_pagada = int.Parse(Console.ReadLine());

            resto_pagar = cantidad_pagada - importe;

            do
            {

                if (resto_pagar > billete_500)

                {
                    resto_pagar = resto_pagar - billete_500;
                    billete500++;

                }
                else if (resto_pagar > billete_200)

                {
                    resto_pagar = resto_pagar - billete_200;
                    billete200++;
                }
                else if (resto_pagar > billete_100)

                {
                    resto_pagar = resto_pagar - billete_100;
                    billete100++;
                }
                else if (resto_pagar > billete_50)

                {
                    resto_pagar = resto_pagar - billete_50;
                    billete50++;
                }
                else if (resto_pagar > billete_20)

                {
                    resto_pagar = resto_pagar - billete_20;
                    billete20++;
                }
                else if (resto_pagar > billete_10)

                {
                    resto_pagar = resto_pagar - billete_10;
                    billete10++;
                }
                else if (resto_pagar > billete_5)

                {
                    resto_pagar = resto_pagar - billete_5;
                    billete5++;
                }
                else if (resto_pagar > moneda_200)

                {
                    resto_pagar = resto_pagar - moneda_200;
                    moneda200++;
                }
                else if (resto_pagar > moneda_100)

                {
                    resto_pagar = resto_pagar - moneda_100;
                    moneda100++;
                }
                else if (resto_pagar > moneda_050)

                {
                    resto_pagar = resto_pagar - moneda_050;
                    moneda050++;
                }
                else if (resto_pagar > moneda_020)

                {
                    resto_pagar = resto_pagar - moneda_020;
                    moneda020++;
                }
                else if (resto_pagar > moneda_010)

                {
                    resto_pagar = resto_pagar - moneda_010;
                    moneda010++;
                }
                else if (resto_pagar > moneda_005)

                {
                    resto_pagar = resto_pagar - moneda_005;
                    moneda005++;
                }
                else if (resto_pagar > moneda_002)

                {
                    resto_pagar = resto_pagar - moneda_002;
                    moneda002++;
                }
                else if (resto_pagar > moneda_001)

                {
                    resto_pagar = resto_pagar - moneda_001;
                    moneda001++;
                }

            } while (resto_pagar != 0);


            if (importe > cantidad_pagada)
            {
                Console.WriteLine("Falta dinero por pagar.");
            }
            else if (importe == cantidad_pagada)
            {
                Console.WriteLine("No te debo cambio.");
            }
            else if (importe < cantidad_pagada)
            {
                Console.WriteLine("Ahora te doy cambio.");
            }

            Console.WriteLine("Te debo " + moneda001);
            Console.WriteLine("Te debo " + moneda002);
            Console.WriteLine("Te debo " + moneda005);
            Console.WriteLine("Te debo " + moneda010);
            Console.WriteLine("Te debo " + moneda020);
            Console.WriteLine("Te debo " + moneda050);
            Console.WriteLine("Te debo " + moneda100);
            Console.WriteLine("Te debo " + moneda200);
            Console.WriteLine("Te debo " + billete5);
            Console.WriteLine("Te debo " + billete10);
            Console.WriteLine("Te debo " + billete20);
            Console.WriteLine("Te debo " + billete50);
            Console.WriteLine("Te debo " + billete100);
            Console.WriteLine("Te debo " + billete200);
            Console.WriteLine("Te debo " + billete500);
        }

    }



}