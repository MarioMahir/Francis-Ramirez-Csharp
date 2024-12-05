using System;

public class EncuestaEstudiantil
{
    public static void Main(string[] args)
    {
        // Arreglo de respuestas a la encuesta
        int[] respuestas = { 1, 2, 6, 4, 8, 5, 9, 7, 8, 10, 1, 6, 3, 8, 6,
            10, 3, 8, 2, 7, 6, 5, 7, 6, 8, 6, 7, 5, 6, 6, 5, 6, 7, 5, 6,
            4, 8, 6, 8, 10 };

        // Arreglo de contadores de frecuencia
        int[] frecuencia = new int[11]; // Índices de 0 a 10, aunque el índice 0 no se usará

        // Contar la frecuencia de cada calificación en el arreglo "respuestas"
        for (int respuesta = 0; respuesta < respuestas.Length; respuesta++)
        {
            int calificacion = respuestas[respuesta];
            ++frecuencia[calificacion];
        }

        // Imprimir encabezados de la tabla
        Console.WriteLine("{0,12}{1,11}", "Calificación", "Frecuencia");

        // Imprimir la frecuencia de cada calificación
        for (int calificacion = 1; calificacion < frecuencia.Length; calificacion++)
        {
            Console.WriteLine("{0,12}{1,11}", calificacion, frecuencia[calificacion]);
        }
    }
}

