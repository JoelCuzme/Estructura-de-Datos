using System;
using System.Collections.Generic;

class Torres
{
    private Stack<int>[] torres;
    private int totalDiscos;

    public Torres(int discos)
    {
        totalDiscos = discos;
        torres = new Stack<int>[3];
        for (int i = 0; i < 3; i++)
            torres[i] = new Stack<int>();

        for (int i = discos; i >= 1; i--)
            torres[0].Push(i);
    }

    public void Resolver()
    {
        Console.WriteLine($"\nResolviendo Torres de Hanoi con {totalDiscos} discos:\n");
        MoverDiscos(totalDiscos, 0, 2, 1);
        ;
    }

    private void MoverDiscos(int n, int origen, int destino, int auxiliar)
    {
        if (n > 0)
        {
            MoverDiscos(n - 1, origen, auxiliar, destino);
            
            int disco = torres[origen].Pop();
            torres[destino].Push(disco);
            Console.WriteLine($"Mover disco {disco} de {(char)('A' + origen)} a {(char)('A' + destino)}");
            
            MoverDiscos(n - 1, auxiliar, destino, origen);
        }
    }

    
}
