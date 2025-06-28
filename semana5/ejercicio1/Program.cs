using System;
using System.Collections.Generic; 
public class Asignaturas 
{
    public static void Main(string[] args)
    {
        List<string> asignaturas = new List<string>
        {
            "Ciudadania",
            "Química",
            "Historia",
            "Lenguaje"
        };

        Console.WriteLine("Las asignaturas son:");

        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine(asignatura);
        }

        Console.ReadKey(); 
    }
}