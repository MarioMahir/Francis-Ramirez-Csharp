using System;

public class SumaArreglo
{
    public static void Main(string[] args)
    {
        // Declaración e inicialización del arreglo
        int[] arreglo = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };

        // Variable para almacenar la suma de los elementos
        int total = 0;

        // Sumar el valor de cada elemento al total
        for (int contador = 0; contador < arreglo.Length; contador++)
        {
            total += arreglo[contador];
        }

        // Mostrar el resultado de la suma
        Console.WriteLine("Total de los elementos del arreglo: {0}", total);
    }
}


