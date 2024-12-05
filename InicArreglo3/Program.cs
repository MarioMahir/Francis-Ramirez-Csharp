using System;

public class InicArreglo
{
    public static void Main(string[] args)
    {
        const int LONGITUD_ARREGLO = 10; // Crea una constante con nombre para la longitud del arreglo
        int[] arreglo = new int[LONGITUD_ARREGLO]; // Declara e inicializa el arreglo

        // Calcula el valor para cada elemento del arreglo
        for (int contador = 0; contador < arreglo.Length; contador++)
        {
            arreglo[contador] = 2 + 2 * contador;
        }

        // Imprime encabezados de la tabla
        Console.WriteLine("{0,-6}{1,8}", "Índice", "Valor");

        // Imprime el índice y el valor de cada elemento del arreglo
        for (int contador = 0; contador < arreglo.Length; contador++)
        {
            Console.WriteLine("{0,-6}{1,8}", contador, arreglo[contador]);
        }
    }
}
