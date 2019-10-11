using extras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica8
{
    class ejercicio3
    {
        public struct Materia
        {
            public string nombre;
            private double nota;
            public void setNota(double nota)
            {
                if (nota > 0 && nota < 10)
                {
                    this.nota = nota;
                }
                else
                {
                    this.nota = 0;
                }
            }
            public double getNota()
            {
                return this.nota;
            }
            public string resultado(double nota)
            {
                if (nota < 7)
                {
                    return "Usted ha reprobado";
                }
                return "Usted ha aprobado";
            }
        }
        public struct Alumno
        {
            public string carnet;
            public string nombre;
            public string carrera;
            public Materia materia1;
            public Materia materia2;
            public Materia materia3;
            public Materia materia4;
        }
        static void Main(string[] args)
        {
            double nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0;
            Validacion.Validar("¿Cuantos alumnos son?", out int numAlumnos);           
            Alumno[] alumnos = new Alumno[numAlumnos];
            for (int i = 0; i < alumnos.Length; i++)
            {
                nota1 = 0;
                nota2 = 0;
                nota3 = 0;
                nota4 = 0;
                Console.WriteLine($"Nombre alumno: {i+1}");
                alumnos[i].nombre = Console.ReadLine();
                Console.WriteLine($"Carnet: {i + 1}");
                alumnos[i].carnet = Console.ReadLine();
                Console.WriteLine($"Carrera: {i + 1}");
                alumnos[i].carrera = Console.ReadLine();
                Validacion.ValidarMayor($"Nota de la materia 1 {i + 1}", out nota1, 10);              
                alumnos[i].materia1.setNota(nota1);
                Validacion.ValidarMayor($"Nota de la materia 2 {i + 1}", out nota2, 10);
                alumnos[i].materia2.setNota(nota2);
                Validacion.ValidarMayor($"Nota de la materia 3 {i + 1}", out nota3, 10);
                alumnos[i].materia3.setNota(nota3);
                Validacion.ValidarMayor($"Nota de la materia 4 {i + 1}", out nota4, 10);
                alumnos[i].materia4.setNota(nota4);
            }
            foreach (var alumno in alumnos)             
            {              
                Console.WriteLine("Nombre: " + alumno.nombre);
                Console.WriteLine("Carnet: " + alumno.carnet);
                Console.WriteLine("Carrera: " + alumno.carrera);             
                Console.WriteLine($"Materia 1, su nota es: {alumno.materia1.getNota()} {alumno.materia1.resultado(nota1)}"); 
                Console.WriteLine($"Materia 2, su nota es: {alumno.materia2.getNota()} {alumno.materia2.resultado(nota2)}");
                Console.WriteLine($"Materia 3, su nota es: {alumno.materia3.getNota()} {alumno.materia3.resultado(nota3)}");             
                Console.WriteLine($"Materia 4, su nota es: {alumno.materia4.getNota()} {alumno.materia4.resultado(nota4)}");
            }
        }
    }
}
