using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo1
{
    public class Universidad
    {
        public static class Estudiante
        {

            public static string Nombre { get; set; }
            //SesionesT = Sesiones totales 
            public static double SesionesT { get; set; }
            //SesionesA = Sesiones Asistidas 
            public static double SesionesA { get; set; }

            internal class Asistencia
            {
                public static double CalcAsistencia()
                {
                    double Result = SesionesA / SesionesT;
                    return Result * 100;
                }

            }
        }
    }
}
