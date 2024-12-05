using System;

public class InicArreglo
{
    public static void Main(string[] args)
    {
        // La lista inicializadora especifica el valor para cada elemento
        int[] arreglo = { 32, 27, 64, 18, 95, 14, 90, 70, 60, 37 };

        // Encabezados
        Console.WriteLine("{0,-6}{1,8}", "Índice", "Valor");

        // Imprime en pantalla el valor de cada elemento del arreglo
        for (int contador = 0; contador < arreglo.Length; contador++)
        {
            Console.WriteLine("{0,-6}{1,8}", contador, arreglo[contador]);
        }
    }
}

