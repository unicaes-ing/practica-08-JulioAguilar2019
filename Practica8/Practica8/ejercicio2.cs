using extras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica8
{
    class ejercicio2
    {
        public struct Producto
        {
            public string nombre;
            private int cantidad;
            private double precio;

            public void setCantidad(int cantidad)
            {
                if (cantidad > 0)
                {
                    this.cantidad = cantidad;
                }
                else
                {
                    this.cantidad = 0;
                }              
            }

            public int getCantidad()
            {
                return this.cantidad;
            }
            public void setPrecio(double precio)
            {
                if (precio > 0)
                {
                    this.precio = precio;
                }
                else
                {
                    this.precio = 0;
                }
            }
            public double getPrecio()
            {
                return this.precio * 0.13;
            }
        }

        static void Main(string[] args)
        {
            Producto producto = new Producto();
            Console.WriteLine("Nombre: ");
            producto.nombre = Console.ReadLine();        
            Validacion.Validar("Ingrese la cantida:", out int cantidad);
            producto.setCantidad(cantidad);   
            Validacion.Validar("Ingrese el precio:", out double precio);
            producto.setPrecio(precio);
            Console.WriteLine($"Nombre producto: {producto.nombre}");
            Console.WriteLine($"Cantidad: {producto.getCantidad().ToString("c2")}" );
            Console.WriteLine($"Precio: {producto.getPrecio().ToString("c2")} con iva incluido");
        }
    }
}
