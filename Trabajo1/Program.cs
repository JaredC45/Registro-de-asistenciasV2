using System;
using Trabajo1;

namespace tarea1
{
    class Program : Universidad
    {
        public static void Main(string[] args)
        {
            Universidad universidad = new Universidad();

            Console.WriteLine("Ingrese el nombre del estudiante:");
            Universidad.Estudiante.Nombre = Console.ReadLine();

            do
            {
                Console.WriteLine($"Ingrese el numero de sesiones totales del curso de: {Universidad.Estudiante.Nombre}");
                Universidad.Estudiante.SesionesT = Convert.ToInt32(Console.ReadLine());
            } while (Universidad.Estudiante.SesionesT <= 0);

            Universidad.Estudiante.Asistencia.PrintMetodo();
        }
    }

}
