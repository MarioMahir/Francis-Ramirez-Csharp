using System;

public class LibroCalificaciones
{
    private string nombreCurso; // nombre del curso que representa este LibroCalificaciones
    private int[] calificaciones; // arreglo de calificaciones de los estudiantes

    // Constructor para inicializar nombreCurso y el arreglo calificaciones
    public LibroCalificaciones(string nombre, int[] arregloCalificaciones)
    {
        nombreCurso = nombre; // inicializa nombreCurso
        calificaciones = arregloCalificaciones; // inicializa el arreglo calificaciones
    }

    // Propiedad para obtener y establecer el nombre del curso
    public string NombreCurso
    {
        get { return nombreCurso; }
        set { nombreCurso = value; }
    }

    // Muestra un mensaje de bienvenida
    public void MostrarMensaje()
    {
        Console.WriteLine($"¡Bienvenido al libro de calificaciones para\n{NombreCurso}!\n");
    }

    // Procesa las calificaciones
    public void ProcesarCalificaciones()
    {
        // Imprime las calificaciones
        ImprimeCalificaciones();

        // Calcula y muestra el promedio de la clase
        Console.WriteLine($"\nEl promedio de la clase es {ObtenerPromedio():F2}");

        // Muestra la calificación más baja y la más alta
        Console.WriteLine($"La calificación más baja es {ObtenerMinimo()}\nLa calificación más alta es {ObtenerMaximo()}\n");

        // Imprime el gráfico de barras
        ImprimirGraficoBarras();
    }

    // Busca la calificación mínima
    public int ObtenerMinimo()
    {
        int califBaja = calificaciones[0];

        foreach (int calificacion in calificaciones)
        {
            if (calificacion < califBaja)
                califBaja = calificacion;
        }

        return califBaja;
    }

    // Busca la calificación máxima
    public int ObtenerMaximo()
    {
        int califAlta = calificaciones[0];

        foreach (int calificacion in calificaciones)
        {
            if (calificacion > califAlta)
                califAlta = calificacion;
        }

        return califAlta;
    }

    // Calcula el promedio de las calificaciones
    public double ObtenerPromedio()
    {
        int total = 0;

        foreach (int calificacion in calificaciones)
            total += calificacion;

        return (double)total / calificaciones.Length;
    }

    // Imprime un gráfico de barras que muestra la distribución de las calificaciones
    public void ImprimirGraficoBarras()
    {
        Console.WriteLine("Distribución de calificaciones:");

        int[] frecuencia = new int[11]; // Rango: 0-10, 11 categorías

        foreach (int calificacion in calificaciones)
            ++frecuencia[calificacion / 10];

        for (int cuenta = 0; cuenta < frecuencia.Length; cuenta++)
        {
            if (cuenta == 10)
                Console.Write("  100: ");
            else
                Console.Write($"{cuenta * 10:D2}-{cuenta * 10 + 9:D2}: ");

            for (int estrellas = 0; estrellas < frecuencia[cuenta]; estrellas++)
                Console.Write("*");

            Console.WriteLine();
        }
    }

    // Imprime las calificaciones de los estudiantes
    public void ImprimeCalificaciones()
    {
        Console.WriteLine("Las calificaciones son:\n");

        for (int estudiante = 0; estudiante < calificaciones.Length; estudiante++)
            Console.WriteLine($"Estudiante {estudiante + 1,2}: {calificaciones[estudiante],3}");
    }
}
public class PruebaLibroCalificaciones
{
    public static void Main(string[] args)
    {
        // Arreglo de calificaciones de estudiantes
        int[] arregloCalificaciones = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };

        // Crear objeto de LibroCalificaciones
        LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones(
            "CS101 Introducción a la programación en C#", arregloCalificaciones);

        // Mostrar el mensaje y procesar las calificaciones
        miLibroCalificaciones.MostrarMensaje();
        miLibroCalificaciones.ProcesarCalificaciones();
    }
}
