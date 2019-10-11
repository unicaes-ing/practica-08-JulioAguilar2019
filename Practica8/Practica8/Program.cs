using extras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica8
{
    class Program
    {
        public struct Estudiante
        {
            public string carnet;
            public string nombre;
            public string carrera;
            private double cum;
            public void setCum(double cum)
            {
                if (cum > 0 && cum < 10)
                {
                    this.cum = cum;
                }
                else
                {
                    this.cum = 0;
                }
            }
            public double getCum()
            {
                return this.cum;
            }
        }
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante();
            Console.WriteLine("Carnet: ");
            estudiante.carnet = Console.ReadLine();
            Console.WriteLine("Nombre: ");
            estudiante.nombre = Console.ReadLine();
            Console.WriteLine("Carrera: ");
            estudiante.carrera = Console.ReadLine();
            Validacion.ValidarMayor("Cum: ", out double cum, 10);
            estudiante.setCum(cum);   
            Console.WriteLine($"Carnet: {estudiante.carnet}");
            Console.WriteLine($"Nombre: {estudiante.nombre}");
            Console.WriteLine($"Carrera: {estudiante.carrera}");
            Console.WriteLine($"Cum: {estudiante.getCum()}");
            Console.WriteLine("Presione <Enter> para continuar...");
            Console.ReadKey();
        }
    }
}
