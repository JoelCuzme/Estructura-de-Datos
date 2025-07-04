
public class Programa
{
    public static void Main(string[] args)
    {
        Lista<int> listaNumeros = new Lista<int>();
        listaNumeros.Agregar(10);
        listaNumeros.Agregar(20);
        listaNumeros.Agregar(10);
        listaNumeros.Agregar(30);
        listaNumeros.Agregar(10);
        listaNumeros.Agregar(40);

        Console.WriteLine("Búsquedas de Números");

        int veces10 = listaNumeros.Buscar(10);
        if (veces10 > 0)
        {
            Console.WriteLine($"El número 10 se encontró {veces10} veces.");
        }

        Console.WriteLine("\n");

        int veces20 = listaNumeros.Buscar(20);
        if (veces20 > 0)
        {
            Console.WriteLine($"El número 20 se encontró {veces20} vez.");
        }

        Console.WriteLine("\n");

        int veces50 = listaNumeros.Buscar(50);
        if (veces50 > 0)
        {
            Console.WriteLine($"El número 50 se encontró {veces50} veces.");
        }
    }

        
}