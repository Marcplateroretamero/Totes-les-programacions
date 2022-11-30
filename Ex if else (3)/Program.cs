using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ex_if_else__3_
{
    internal class Program
    {
        static void Main(string[] args)
        //Algoritmo que calcula el precio de un producto. Pediremos la cantidad y el precio unitario del producto y calcularemos el precio final.
        //Si el precio supera los 500 Euros le aplicaremos un descuento del 20%, y si supera los 1000 Euros un 40% de descuento.
        {
            int cantidad, precio_unitario;

            Console.WriteLine("Dime la cantidad del producto adquirido.");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el precio unitario del producto.");
            precio_unitario = int.Parse(Console.ReadLine());

            if (cantidad * precio_unitario <= 500)
            {
                Console.WriteLine("El precio final sin descuento es " + cantidad * precio_unitario);
            }

            else if (cantidad * precio_unitario > 1000) 
            {
                Console.WriteLine("Al ser superior a 1000 Euros aplicamos un 40% de descuento.");
                Console.WriteLine("Con un precio superior a los 500 Euros, quedarà un precio de " + cantidad * precio_unitario * 60 / 100 + " Euros");
            }

            else if (cantidad * precio_unitario > 500) 
            {
                Console.WriteLine("Al ser superior a 500 Euros aplicamos un 20% de descuento.");
                Console.WriteLine("Con un precio superior a los 500 Euros, quedarà un precio de " + cantidad * precio_unitario * 80 / 100 + " Euros");
            }
           
        }
    }
}
