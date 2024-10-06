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


            Universidad.Estudiante.Asistencia.PrintMetodo();
        }
    }

}
