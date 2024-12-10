using System;

public class Carta
{
    private string cara;
    private string palo;

    public Carta(string caraCarta, string paloCarta)
    {
        cara = caraCarta;
        palo = paloCarta;
    }

    public override string ToString()
    {
        return $"{cara} de {palo}";
    }
}

public class PaqueteDeCartas
{
    private Carta[] paquete; // Arreglo de cartas
    private int cartaActual; // Índice de la carta actual
    private const int NUMERO_DE_CARTAS = 52; // Total de cartas
    private Random numerosAleatorios; // Generador de números aleatorios

    public PaqueteDeCartas()
    {
        string[] caras = { "As", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete",
            "Ocho", "Nueve", "Diez", "Joto", "Quiña", "Rey" };
        string[] palos = { "Corazones", "Diamantes", "Tréboles", "Espadas" };

        paquete = new Carta[NUMERO_DE_CARTAS];
        cartaActual = 0;
        numerosAleatorios = new Random();

        // Crear el paquete de cartas
        for (int cuenta = 0; cuenta < paquete.Length; cuenta++)
        {
            paquete[cuenta] = new Carta(caras[cuenta % 13], palos[cuenta / 13]);
        }
    }

    public void Barajar()
    {
        cartaActual = 0; // Reinicia el índice

        for (int primera = 0; primera < paquete.Length; primera++)
        {
            int segunda = numerosAleatorios.Next(NUMERO_DE_CARTAS);

            // Intercambiar las cartas
            Carta temp = paquete[primera];
            paquete[primera] = paquete[segunda];
            paquete[segunda] = temp;
        }
    }

    public Carta RepartirCarta()
    {
        if (cartaActual < paquete.Length)
        {
            return paquete[cartaActual++];
        }
        else
        {
            return null; // No hay más cartas para repartir
        }
    }
}

public class PruebaPaqueteDeCartas
{
    public static void Main(string[] args)
    {
        PaqueteDeCartas miPaqueteDeCartas = new PaqueteDeCartas();
        miPaqueteDeCartas.Barajar();

        // Imprimir las 52 cartas en 13 filas de 4 cartas cada una
        for (int i = 0; i < 13; i++)
        {
            Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}",
                miPaqueteDeCartas.RepartirCarta(),
                miPaqueteDeCartas.RepartirCarta(),
                miPaqueteDeCartas.RepartirCarta(),
                miPaqueteDeCartas.RepartirCarta());
        }
    }
}
