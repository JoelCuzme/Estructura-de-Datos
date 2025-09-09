using System;
using System.Collections.Generic;

public class Programa
{
    static List<string> revistas = new List<string>
    {
        "Recista1",
        "Recista2",
        "Recista3",
        "Recista4",
        "Recista5",
        "Recista6",
        "Recista7",
        "Recista8",
        "Recista9",
        "Recista10"
    };

    public static void Main(string[] args)
    {
        while (true) 
        {
            Console.WriteLine("Catálogo de Revistas ");
            Console.WriteLine("1. Buscar revista por título");
            Console.WriteLine("2. Salir");
            Console.Write("Selecciona una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("Ingresa el título a buscar: ");
                string tituloBuscado = Console.ReadLine();
                BuscarRevista(tituloBuscado);
            }
            else if (opcion == "2")
            {
                Console.WriteLine("Saliendo de la aplicación.");
                break; 
            }
            else
            {
                Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
            }
        }
    }

    static void BuscarRevista(string titulo)
    {
        bool encontrado = false;
        foreach (string revista in revistas)
        {
            if (revista.Equals(titulo, StringComparison.OrdinalIgnoreCase))
            {
                encontrado = true;
                break; 
            }
        }

        if (encontrado)
        {
            Console.WriteLine($" ¡Título '{titulo}' encontrado!");
        }
        else
        {
            Console.WriteLine($" Título '{titulo}' no encontrado.");
        }
    }
}