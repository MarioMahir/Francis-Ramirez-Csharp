using System;

public class LibroCalificaciones
{
    private string nombreCurso; // Nombre del curso representado por este libro de calificaciones
    private int[,] calificaciones; // Arreglo rectangular de calificaciones de estudiantes

    // Constructor con dos parámetros para inicializar nombreCurso y el arreglo calificaciones
    public LibroCalificaciones(string nombre, int[,] arregloCalificaciones)
    {
        NombreCurso = nombre; // Inicializa nombreCurso
        calificaciones = arregloCalificaciones; // Inicializa el arreglo calificaciones
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

    // Procesa las calificaciones del curso
    public void ProcesarCalificaciones()
    {
        // Imprime las calificaciones
        ImprimirCalificaciones();

        // Calcula y muestra la calificación más baja y la más alta
        Console.WriteLine($"\nLa calificación más baja en el libro de calificaciones es: {ObtenerMinima()}");
        Console.WriteLine($"La calificación más alta en el libro de calificaciones es: {ObtenerMaxima()}");

        // Imprime el gráfico de distribución de las calificaciones
        ImprimirGraficoBarras();
    }

    // Obtiene la calificación más baja
    public int ObtenerMinima()
    {
        int califBaja = calificaciones[0, 0];

        foreach (int calificacion in calificaciones)
        {
            if (calificacion < califBaja)
                califBaja = calificacion;
        }

        return califBaja;
    }

    // Obtiene la calificación más alta
    public int ObtenerMaxima()
    {
        int califAlta = calificaciones[0, 0];

        foreach (int calificacion in calificaciones)
        {
            if (calificacion > califAlta)
                califAlta = calificacion;
        }

        return califAlta;
    }

    // Calcula el promedio de calificaciones para un estudiante específico
    public double ObtenerPromedio(int estudiante)
    {
        int total = 0;
        int numPruebas = calificaciones.GetLength(1);

        for (int prueba = 0; prueba < numPruebas; prueba++)
            total += calificaciones[estudiante, prueba];

        return (double)total / numPruebas;
    }

    // Imprime un gráfico de barras que muestra la distribución de todas las calificaciones
    public void ImprimirGraficoBarras()
    {
        Console.WriteLine("\nDistribución total de calificaciones:");

        int[] frecuencia = new int[11];

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

    // Imprime el contenido del arreglo calificaciones
    public void ImprimirCalificaciones()
    {
        Console.WriteLine("Las calificaciones son:\n");

        Console.Write("       "); // Encabezado de columnas
        for (int prueba = 0; prueba < calificaciones.GetLength(1); prueba++)
            Console.Write($"Prueba {prueba + 1} ");

        Console.WriteLine("Promedio");

        for (int estudiante = 0; estudiante < calificaciones.GetLength(0); estudiante++)
        {
            Console.Write($"Estudiante {estudiante + 1,2}");

            for (int prueba = 0; prueba < calificaciones.GetLength(1); prueba++)
                Console.Write($"{calificaciones[estudiante, prueba],8}");

            Console.WriteLine($"{ObtenerPromedio(estudiante),9:F2}");
        }
    }
}
public class PruebaLibroCalificaciones
{
    public static void Main(string[] args)
    {
        // Arreglo rectangular de calificaciones de estudiantes
        int[,] arregloCalificaciones = {
            { 87, 96, 70 },
            { 68, 87, 90 },
            { 94, 100, 90 },
            { 100, 81, 82 },
            { 83, 65, 85 },
            { 78, 87, 65 },
            { 85, 75, 83 },
            { 91, 94, 100 },
            { 76, 72, 84 },
            { 87, 93, 73 }
        };

        // Crear objeto de LibroCalificaciones y procesar calificaciones
        LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones(
            "CS101 Introducción a la programación en C#", arregloCalificaciones);

        miLibroCalificaciones.MostrarMensaje();
        miLibroCalificaciones.ProcesarCalificaciones();
    }
}
