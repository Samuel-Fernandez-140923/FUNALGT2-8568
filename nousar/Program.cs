// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public void Corre()
    {
        Console.WriteLine($"{Nombre} está corriendo.");
    }

    public void Estudia()
    {
        Console.WriteLine($"{Nombre} está estudiando.");
    }

    public override string ToString()
    {
        return $"Estudiante: {Nombre}, Edad: {Edad}";
    }
}

// Entrenador.cs
public class Entrenador
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