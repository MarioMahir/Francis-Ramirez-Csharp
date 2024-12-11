using System;
using System.Collections.Generic;

public abstract class Empleado
{
    public string Nombre { get; }
    public string Apellido { get; }

    public Empleado(string nombre, string apellido)
    {
        Nombre = nombre;
        Apellido = apellido;
    }

    // Método abstracto para sobrescribir en clases derivadas
    public abstract decimal Ingresos();

    public override string ToString() => $"{Nombre} {Apellido}";
}
public class EmpleadoAsalariado : Empleado
{
    public decimal SalarioSemanal { get; }

    public EmpleadoAsalariado(string nombre, string apellido, decimal salarioSemanal)
        : base(nombre, apellido)
    {
        SalarioSemanal = salarioSemanal;
    }

    public override decimal Ingresos() => SalarioSemanal;

    public override string ToString() => $"{base.ToString()} - Asalariado: {SalarioSemanal:C}";
}
public class EmpleadoPorHoras : Empleado
{
    public decimal TarifaPorHora { get; }
    public decimal HorasTrabajadas { get; }

    public EmpleadoPorHoras(string nombre, string apellido, decimal tarifa, decimal horas)
        : base(nombre, apellido)
    {
        TarifaPorHora = tarifa;
        HorasTrabajadas = horas;
    }

    public override decimal Ingresos() =>
        HorasTrabajadas <= 40
            ? TarifaPorHora * HorasTrabajadas
            : (40 * TarifaPorHora) + ((HorasTrabajadas - 40) * TarifaPorHora * 1.5m);

    public override string ToString() => $"{base.ToString()} - Por Horas: {Ingresos():C}";
}
public class EmpleadoPorComision : Empleado
{
    public decimal VentasBrutas { get; }
    public decimal TasaComision { get; }

    public EmpleadoPorComision(string nombre, string apellido, decimal ventas, decimal tasa)
        : base(nombre, apellido)
    {
        VentasBrutas = ventas;
        TasaComision = tasa;
    }

    public override decimal Ingresos() => VentasBrutas * TasaComision;

    public override string ToString() => $"{base.ToString()} - Por Comisión: {Ingresos():C}";
}
public class EmpleadoBaseMasComision : EmpleadoPorComision
{
    public decimal SalarioBase { get; }

    public EmpleadoBaseMasComision(string nombre, string apellido, decimal salarioBase, decimal ventas, decimal tasa)
        : base(nombre, apellido, ventas, tasa)
    {
        SalarioBase = salarioBase;
    }

    public override decimal Ingresos() => SalarioBase + base.Ingresos();

    public override string ToString() => $"{base.ToString()} - Base más Comisión: {Ingresos():C}";
}

class Program
{
    static void Main()
    {
        var empleados = new List<Empleado>
        {
            new EmpleadoAsalariado("Juan", "Perez", 800.00m),
            new EmpleadoPorHoras("Maria", "Lopez", 20.00m, 45),
            new EmpleadoPorComision("Carlos", "Diaz", 10000.00m, 0.06m),
            new EmpleadoBaseMasComision("Ana", "Martinez", 500.00m, 5000.00m, 0.04m)
        };

        foreach (var empleado in empleados)
        {
            Console.WriteLine(empleado);
            Console.WriteLine($"Ingresos: {empleado.Ingresos():C}\n");
        }
    }
}
