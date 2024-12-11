using System;

public class Punto
{
    private double x;
    private double y;

    // Método para cargar los valores de x e y
    public void CargarValores(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    // Método para imprimir en qué cuadrante se encuentra el punto
    public void ImprimirCuadrante()
    {
        if (x > 0 && y > 0)
        {
            Console.WriteLine("El punto está en el primer cuadrante.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("El punto está en el segundo cuadrante.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("El punto está en el tercer cuadrante.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("El punto está en el cuarto cuadrante.");
        }
        else
        {
            Console.WriteLine("El punto está sobre uno de los ejes.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Punto punto = new Punto();
        
        // Cargar valores
        punto.CargarValores(3, 4);
        

        // Imprimir en qué cuadrante está
        punto.ImprimirCuadrante(); // Output: El punto está en el primer cuadrante.
    }
}
