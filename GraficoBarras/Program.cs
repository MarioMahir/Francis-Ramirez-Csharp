using System;

public class GraficoBarras
{
    public static void Main(string[] args)
    {
        // Declaración e inicialización del arreglo
        int[] arreglo = { 0, 0, 0, 0, 0, 0, 1, 2, 4, 2, 1 };

        Console.WriteLine("Distribución de las calificaciones:");

        // Para cada elemento del arreglo, mostrar en pantalla una barra del gráfico
        for (int contador = 0; contador < arreglo.Length; contador++)
        {
            // Muestra etiquetas de las barras (por ejemplo, "00-09: ", ..., "90-99: ", "100: ")
            if (contador == 10)
            {
                Console.Write("  100: ");
            }
            else
            {
                Console.Write("{0:D2}-{1:D2}: ", contador * 10, contador * 10 + 9);
            }

            // Imprime barra de asteriscos
            for (int estrellas = 0; estrellas < arreglo[contador]; estrellas++)
            {
                Console.Write("*");
            }

            Console.WriteLine(); // Inicia una nueva línea de salida
        }
    }
}
