using System;

public class InicArreglo
{
    public static void Main(string[] args)
    {
        // Declaración e inicialización del arreglo
        int[] arreglo = new int[10]; // Arreglo de 10 elementos, inicializado con ceros

        // Imprimir encabezados de la tabla
        Console.WriteLine("{0,-6} {1,8}", "Índice", "Valor");

        // Recorrer el arreglo e imprimir el índice y su valor correspondiente
        for (int contador = 0; contador < arreglo.Length; contador++)
        {
            Console.WriteLine("{0,-6} {1,8}", contador, arreglo[contador]);
        }
    }
}

