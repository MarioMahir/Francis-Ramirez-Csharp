using System;

public class Array1
{
    public static void Main(string[] args)
    {
        const int TAMANO_MATRIZ = 20; // Tamaño del array
        int[] matriz = new int[TAMANO_MATRIZ]; // Declarar e inicializar el array

        // Se debe inicializar cada elemento con índice * 5
        for (int i = 0; i < TAMANO_MATRIZ; i++)
        {
            matriz[i] = i * 5;
        }

        // Mandar a imprimir elementos en la consola
        Console.WriteLine("Elementos del array:");
        for (int i = 0; i < TAMANO_MATRIZ; i++)
        {
            Console.WriteLine($"Elemento [{i}] = {matriz[i]}");
        }
    }
}
