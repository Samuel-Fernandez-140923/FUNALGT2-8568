using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    internal class alumno
    {
        public class Estudiante
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }

            public void Corre()
            {
                Console.WriteLine($"{Nombre} esta corriendo loco.");
            }

            public void Estudia()
            {
                Console.WriteLine($"{Nombre} est estudiando feliz.");
            }

            public override string ToString()
            {
                return $"Estudiante: {Nombre}, Edad: {Edad}";
            }
        }
    }
}
