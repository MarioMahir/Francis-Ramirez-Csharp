using System;

public class CompararMatrices
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Comparación de dos matrices.");

        // Longitud de la primera matriz
        Console.Write("Ingrese la longitud de la primera matriz: ");
        int longitud1 = int.Parse(Console.ReadLine());
        int[] matriz1 = new int[longitud1];

        // los elementos de la primera matriz
        Console.WriteLine("Ingrese los elementos de la primera matriz:");
        for (int i = 0; i < longitud1; i++)
        {
            Console.Write($"Elemento [{i}]: ");
            matriz1[i] = int.Parse(Console.ReadLine());
        }

        // Longitud de la segunda matriz
        Console.Write("Ingrese la longitud de la segunda matriz: ");
        int longitud2 = int.Parse(Console.ReadLine());
        int[] matriz2 = new int[longitud2];

        // los elementos de la segunda matriz
        Console.WriteLine("Ingrese los elementos de la segunda matriz:");
        for (int i = 0; i < longitud2; i++)
        {
            Console.Write($"Elemento [{i}]: ");
            matriz2[i] = int.Parse(Console.ReadLine());
        }

        // Verificar si las matrices son iguales
        if (longitud1 != longitud2)
        {
            Console.WriteLine("Las matrices no son iguales porque tienen longitudes diferentes.");
        }
        else
        {
            bool sonIguales = true;

            for (int i = 0; i < longitud1; i++)
            {
                if (matriz1[i] != matriz2[i])
                {
                    sonIguales = false;
                    break;
                }
            }

            // Mostrar el resultado
            if (sonIguales)
            {
                Console.WriteLine("Las matrices son iguales.");
            }
            else
            {
                Console.WriteLine("Las matrices no son iguales.");
            }
        }
    }
}
