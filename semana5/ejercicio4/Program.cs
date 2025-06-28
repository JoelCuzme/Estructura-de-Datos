using System;
using System.Collections.Generic; // Esto nos ayuda a usar cosas como los diccionarios
using System.Linq; // Nos da herramientas geniales como .ToDictionary() y .Count()

public class Contarvocales
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Escribe una palabra:");
        string palabra = Console.ReadLine().ToLower(); 

        
        Dictionary<char, int> conteoVocales = new Dictionary<char, int>()
        {
            {'a', 0}, {'e', 0}, {'i', 0}, {'o', 0}, {'u', 0}
        };

        foreach (char letra in palabra)
        {
            if (conteoVocales.ContainsKey(letra))
            {
                conteoVocales[letra]++;
            }
        }

        Console.WriteLine("\nTus vocales:");
        foreach (var par in conteoVocales)
        {
            Console.WriteLine($"La '{par.Key}' apareció {par.Value} vez.");
        }

        Console.ReadKey(); 
    }
}