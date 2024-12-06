using System;
using System.Collections.Generic;

public class Array3
{
    public static void Main(string[] args)
    {
        // Solicitar la cantidad de números
        Console.Write("¿Cuántos números desea ingresar? ");
        int n = int.Parse(Console.ReadLine());

        // Crear el array para almacenar los números
        int[] numeros = new int[n];

        // Leer los números desde la consola
        Console.WriteLine("Ingrese los números:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Encontrar el menor valor
        int menorValor = numeros[0];
        for (int i = 1; i < n; i++)
        {
            if (numeros[i] < menorValor)
            {
                menorValor = numeros[i];
            }
        }

        // Detectar repeticiones
        bool hayRepetidos = false;
        HashSet<int> elementosVistos = new HashSet<int>();
        foreach (int numero in numeros)
        {
            if (elementosVistos.Contains(numero))
            {
                hayRepetidos = true;
                break;
            }
            else
            {
                elementosVistos.Add(numero);
            }
        }

        // Mostrar resultados
        Console.WriteLine($"\nEl menor valor es: {menorValor}");
        if (hayRepetidos)
        {
            Console.WriteLine("Al menos un número se repite.");
        }
        else
        {
            Console.WriteLine("No hay números repetidos.");
        }
    }
}

