using System;

public class Cuenta
{
    private decimal saldo; 

    public Cuenta(decimal saldoInicial)
    {
        Saldo = saldoInicial; 
    }

    public void Acredita(decimal monto)
    {
        Saldo = Saldo + monto; 
    }

    public decimal Saldo
    {
        get
        {
            return saldo;
        }
        set
        {
            if (value >= 0)
                saldo = value;
        }
    }
}

public class PruebaCuenta
{
    public static void Main(string[] args)
    {
        Cuenta cuenta1 = new Cuenta(50.00M); 
        Cuenta cuenta2 = new Cuenta(-7.53M); 

        Console.WriteLine("Saldo de cuenta1: {0:C}", cuenta1.Saldo); 
        Console.WriteLine("Saldo de cuenta2: {0:C}\n", cuenta2.Saldo); 

        decimal montoDeposito; 

        Console.Write("Escriba el monto a depositar para la cuenta1: ");
        montoDeposito = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Se sumó {0:C} al saldo de cuenta1\n", montoDeposito);
        cuenta1.Acredita(montoDeposito);

        Console.WriteLine("Saldo de cuenta1: {0:C}", cuenta1.Saldo);
        Console.WriteLine("Saldo de cuenta2: {0:C}\n", cuenta2.Saldo);

        Console.Write("Escriba el monto a depositar para la cuenta2: ");
        montoDeposito = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Se sumó {0:C} al saldo de cuenta2\n", montoDeposito);
        cuenta2.Acredita(montoDeposito); 

        Console.WriteLine("Saldo de cuenta1: {0:C}", cuenta1.Saldo);
        Console.WriteLine("Saldo de cuenta2: {0:C}", cuenta2.Saldo);
    }
}
