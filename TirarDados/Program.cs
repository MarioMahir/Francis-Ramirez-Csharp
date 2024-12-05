using System;

public class TirarDado
{
    public static void Main(string[] args)
    {
        // Generador de números aleatorios
        Random numerosAleatorios = new Random();

        // Arreglo para almacenar la frecuencia de cada cara (1-6)
        int[] frecuencia = new int[7];

        // Tira el dado 6000 veces
        for (int tiro = 1; tiro <= 6000; tiro++)
        {
            int resultado = numerosAleatorios.Next(1, 7); // Genera un número entre 1 y 6
            ++frecuencia[resultado]; // Incrementa el contador para la cara correspondiente
        }

        // Imprime encabezados
        Console.WriteLine("{0}{1,10}", "Cara", "Frecuencia");

        // Imprime la frecuencia de cada cara
        for (int cara = 1; cara < frecuencia.Length; cara++)
        {
            Console.WriteLine("{0,4}{1,10}", cara, frecuencia[cara]);
        }
    }
}
