using System;

public class LibroCalificaciones
{
    private string nombreCurso; 

    public LibroCalificaciones(string nombre)
    {
        NombreCurso = nombre;
    }

    public string NombreCurso
    {
        get
        {
            return nombreCurso;
        }
        set
        {
            nombreCurso = value;
        }
    }

    public void MostrarMensaje()
    {
        Console.WriteLine("Bienvenido al libro de calificaciones para\n{0}!", NombreCurso);
    }
}

public class PruebaLibroCalificaciones
{
    public static void Main(string[] args)
    {
        LibroCalificaciones libroCalificaciones1 = new LibroCalificaciones("CS101 Introducción a la programación en C#");
        LibroCalificaciones libroCalificaciones2 = new LibroCalificaciones("CS102 Estructuras de datos en C#");

        Console.WriteLine("El nombre del curso de libroCalificaciones1 es: {0}", libroCalificaciones1.NombreCurso);
        Console.WriteLine("El nombre del curso de libroCalificaciones2 es: {0}", libroCalificaciones2.NombreCurso);
    }
}
