using System;

public class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Paginas { get; set; }

    // Método para mostrar la información del libro
    public void MostrarInformacion()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Páginas: {Paginas}");
    }

    // Método para determinar si el libro es largo (más de 500 páginas)
    public bool EsLargo()
    {
        return Paginas > 500;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Libro libro = new Libro
        {
            Titulo = "Hábitos Atómicos",
            Autor = "James Clear",
            Paginas = 320 
        };

        // Mostrar la información del libro
        libro.MostrarInformacion();

        // Verificar si es un libro largo
        bool esLargo = libro.EsLargo();
        Console.WriteLine($"¿Este libro es largo? {esLargo}");
    }
}
