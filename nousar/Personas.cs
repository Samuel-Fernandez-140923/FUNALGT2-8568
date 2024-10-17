public class Persona
{
    public string Nombre { get; set; }
    public int? Edad { get; set; } // Usar nullable para entrenador

    public string Deporte { get; set; } // Solo para el entrenador

    public void Corre()
    {
        if (Deporte != null)
        {
            Console.WriteLine($"{Nombre} (Entrenador de {Deporte}) está corriendo.");
        }
        else
        {
            Console.WriteLine($"{Nombre} está corriendo.");
        }
    }

    public void Estudia()
    {
        if (Deporte == null)
        {
            Console.WriteLine($"{Nombre} está estudiando.");
        }
    }

    public void HaceEjercicio()
    {
        if (Deporte != null)
        {
            Console.WriteLine($"{Nombre} está haciendo ejercicio.");
        }
    }

    public override string ToString()
    {
        return Deporte != null
            ? $"Entrenador: {Nombre}, Deporte: {Deporte}"
            : $"Estudiante: {Nombre}, Edad: {Edad}";
    }
}