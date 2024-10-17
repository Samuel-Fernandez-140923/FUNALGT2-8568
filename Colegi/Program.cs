

// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Persona[] personas = new Persona[4]; // 3 estudiantes + 1 entrenador
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Ingresar Estudiantes");
            Console.WriteLine("2. Ingresar Entrenador");
            Console.WriteLine("3. Mostrar Información");
            Console.WriteLine("4. Fin");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    for (int i = 0; i < 3; i++)
                    {
                        personas[i] = new Persona();
                        Console.WriteLine($"Ingrese el nombre del estudiante {i + 1}:");
                        personas[i].Nombre = Console.ReadLine();
                        Console.WriteLine($"Ingrese la edad del estudiante {i + 1}:");
                        personas[i].Edad = int.Parse(Console.ReadLine());
                    }
                    break;

                case "2":
                    personas[3] = new Persona();
                    Console.WriteLine("Ingrese el nombre del entrenador:");
                    personas[3].Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el deporte del entrenador:");
                    personas[3].Deporte = Console.ReadLine();
                    break;

                case "3":
                    Console.WriteLine("Información del salón:");
                    foreach (var persona in personas)
                    {
                        if (persona != null)
                        {
                            Console.WriteLine(persona);
                        }
                    }

                    if (personas[0] != null)
                    {
                        personas[0].Estudia();
                    }
                    if (personas[3] != null)
                    {
                        personas[3].HaceEjercicio();
                    }
                    break;

                case "4":
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }
        }
    }
}
