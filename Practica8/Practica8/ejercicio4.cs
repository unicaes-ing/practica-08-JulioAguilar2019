using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using extras;

namespace Practica8
{
    class ejercicio4
    {
        public enum tipoPago
        {
            efectivo = 0, debito = 1, credito = 2
        }
        static void Main(string[] args)
        {
            double pago=0;
            Validacion.Validar("Ingrese el precio del producto", out double precio);         
            Validacion.Validar("Ingrese la forma de pago:\n1. Efectivo ------------ 15%\n2. Tarjeta de debito --- 10%\n3. Tarjeta de credito -- 5%", out int tipo);
            switch ((tipoPago)(tipo-1))
            {
                case tipoPago.efectivo:
                     pago = precio * 0.15;
                    Console.WriteLine($"El total con el descuento aplicado es: {pago.ToString("c2")}");
                    break;
                case tipoPago.debito:
                    pago =  precio * 0.10;
                    Console.WriteLine($"El total con el descuento aplicado es: {pago.ToString("c2")}");
                    break;
                case tipoPago.credito:
                    pago =  precio * 0.05;
                    Console.WriteLine($"El total con el descuento aplicado es: {pago.ToString("c2")}");
                    break;                
            }
            Console.ReadKey();
        }
    }
}
