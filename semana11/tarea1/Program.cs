using System;
using System.Collections.Generic;

class Programa
{
    
    private static Dictionary<string, string> traducciones = new Dictionary<string, string>
    {
        { "time", "tiempo" },
        { "person", "persona" },
        { "year", "año" },
        { "way", "camino" },
        { "day", "día" },
        { "thing", "cosa" },
        { "man", "hombre" },
        { "world", "mundo" },
        { "life", "vida" },
        { "hand", "mano" }
    };

    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("MENÚ" );
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("\nSeleccione una opción: ");

            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        TraducirFrase();
                        break;
                    case 2:
                        AgregarPalabras();
                        break;
                    case 0:
                        Console.WriteLine("\nGracias");
                        break;
                    default:
                        Console.WriteLine("\nOpción no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nEntrada no válida. Por favor, ingrese un número.");
                opcion = -1; 
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();

        } while (opcion != 0);
    }

    static void TraducirFrase()
    {
        Console.Write("\nIngrese la frase a traducir: ");
        string frase = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(frase))
        {
            Console.WriteLine("No se ingresó ninguna frase.");
            return;
        }

        string[] palabras = frase.Split(' ');
        Console.Write("Frase traducida: ");

        foreach (string palabra in palabras)
        {
            string palabraLimpia = palabra.ToLower().Trim(',', '.', '!', '?', ';', ':');
            
            if (traducciones.ContainsKey(palabraLimpia))
            {
                Console.Write(traducciones[palabraLimpia] + " ");
            }
            else
            {
                Console.Write(palabra + " ");
            }
        }
        Console.WriteLine();
    }

    static void AgregarPalabras()
    {
        Console.Write("\nIngrese la palabra en inglés: ");
        string ingles = Console.ReadLine()?.Trim().ToLower();

        Console.Write("Ingrese la traducción en español: ");
        string español = Console.ReadLine()?.Trim().ToLower();

        if (string.IsNullOrWhiteSpace(ingles) || string.IsNullOrWhiteSpace(español))
        {
            Console.WriteLine("Ambos campos son obligatorios. No se agregó la palabra.");
            return;
        }

        if (traducciones.ContainsKey(ingles))
        {
            Console.WriteLine($"La palabra '{ingles}' ya existe en el diccionario. No se agregó.");
        }
        else
        {
            traducciones.Add(ingles, español);
            Console.WriteLine($"La palabra '{ingles}' ha sido agregada con éxito");
        }
    }
}