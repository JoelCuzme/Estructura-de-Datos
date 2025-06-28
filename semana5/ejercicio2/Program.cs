using System;
using System.Collections.Generic;
using System.Linq;

public class Numeros
{
    public static void Main(string[] args)
    {
        string result = string.Join(",", Enumerable.Range(1, 10).Reverse().Select(n => n.ToString()));

        Console.WriteLine(result);
        Console.ReadKey();
    }
}
