using System;
using System.Collections.Generic;

public class Alumno
{
    public string Nombre { get; set; }
    public int Matricula { get; set; }
    public string Carrera { get; set; }
    public List<int> Calificaciones { get; set; }

    // Constructor
    public Alumno()
    {
        Calificaciones = new List<int>();
    }

    // Método para calcular el promedio de las calificaciones
    public double CalcularPromedio()
    {
        if (Calificaciones.Count == 0)
        {
            return 0; // Para evitar división por cero
        }

        double suma = 0;
        foreach (int calificacion in Calificaciones)
        {
            suma += calificacion;
        }

        return suma / Calificaciones.Count;
    }

    // Método para mostrar la información del alumno
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine($"Carrera: {Carrera}");
        Console.WriteLine($"Promedio de Calificaciones: {CalcularPromedio():F2}"); // Promedio con dos decimales
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de Alumno
        Alumno alumno = new Alumno
        {
            Nombre = "Mario Sabala",
            Matricula = 123456,
            Carrera = "Ingeniería de Software", // Me aceptaron en el ITLA, aplicaré lo aprendido
            Calificaciones = new List<int> { 85, 90, 78, 92, 88 }
        };

        // Mostrar la información del alumno
        alumno.MostrarInformacion();
    }
}
