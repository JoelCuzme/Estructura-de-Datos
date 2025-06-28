using System;
using System.Collections.Generic;
using System.Linq;

public class Loteria
{
    public static void Main(string[] args)
    {
        List<int> numerosganadores = new List<int>();

        Console.WriteLine("Ingresa los 6 números ganadores de la Lotería:");

        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Número {i + 1}: ");
            int numero = int.Parse(Console.ReadLine()); 
            numerosganadores.Add(numero);
        }

        numerosganadores.Sort();

        Console.WriteLine("\nNúmeros Ganadores Ordenados:");
        Console.WriteLine(string.Join(", ", numerosganadores));

        Console.ReadKey();
    }
}