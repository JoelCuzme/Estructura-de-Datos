
using System.Collections.Generic;
using System.Linq;

public class PreciosSimple
{
    public static void Main(string[] args)
    {
        List<int> precios = new List<int> { 50, 75, 46, 22, 80, 65, 8 };

        int precioMin = precios.Min();
        int precioMax = precios.Max();

        Console.WriteLine($"El precio más barato es: {precioMin}");
        Console.WriteLine($"El precio más caro es: {precioMax}");

        Console.ReadKey();
    }
}