using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    internal class Entrenador
    { 


        
            public string Nombre { get; set; }
            public string Deporte { get; set; }

            public void HaceEjercicio()
            {
                Console.WriteLine($"{Nombre} está haciendo ejercicio.");
            }

            public void EntrenaEstudiantes()
            {
                Console.WriteLine($"{Nombre} está entrenando a los estudiantes.");
            }

            public override string ToString()
            {
                return $"Entrenador: {Nombre}, Deporte: {Deporte}";
            }
        }
    }


