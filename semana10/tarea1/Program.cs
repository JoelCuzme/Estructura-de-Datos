using System;
using System.Collections.Generic;

class Vacunacion
{
    static void Main(string[] args)
    {
        HashSet<string> ciudadanosTotales = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            ciudadanosTotales.Add("Ciudadano " + i);
        }

        HashSet<string> ciudadanosPfizer = new HashSet<string>();
        HashSet<string> ciudadanosAstraZeneca = new HashSet<string>();
        for (int i = 1; i <= 75; i++)
        {
            ciudadanosPfizer.Add("Ciudadano " + (i * 4));
            ciudadanosAstraZeneca.Add("Ciudadano " + (i * 3));
        }

       
        HashSet<string> vacunadosTotales = new HashSet<string>(ciudadanosPfizer);
        vacunadosTotales.UnionWith(ciudadanosAstraZeneca);
        HashSet<string> noVacunados = new HashSet<string>(ciudadanosTotales);
        noVacunados.ExceptWith(vacunadosTotales);

        HashSet<string> ambasDosis = new HashSet<string>(ciudadanosPfizer);
        ambasDosis.IntersectWith(ciudadanosAstraZeneca);
        
        HashSet<string> soloPfizer = new HashSet<string>(ciudadanosPfizer);
        soloPfizer.ExceptWith(ciudadanosAstraZeneca);

        HashSet<string> soloAstraZeneca = new HashSet<string>(ciudadanosAstraZeneca);
        soloAstraZeneca.ExceptWith(ciudadanosPfizer);

        Console.WriteLine("Resultados de la Campaña de Vacunación:");
        Console.WriteLine($"Ciudadanos que no vacunados: {noVacunados.Count}");
        Console.WriteLine($"Ciudadanos que han recibido ambas dosis: {ambasDosis.Count}");
        Console.WriteLine($"Ciudadanos con la vacuna de Pfizer: {soloPfizer.Count}");
        Console.WriteLine($"Ciudadanos con la vacuna de AstraZeneca: {soloAstraZeneca.Count}");
    }
}