using System;
using System.Collections.Generic; 

public class Lista<T> 
{
    private List<T> elementos; 

    public Lista()
    {
      
        elementos = new List<T>();
    }

    public void Agregar(T dato)
    {
        elementos.Add(dato);
    }

    public int Buscar(T valorABuscar)
    {

        int contador = 0;
        foreach (T elemento in elementos)
        {
            if (EqualityComparer<T>.Default.Equals(elemento, valorABuscar))
            {
                contador++;
            }
        }

        if (contador > 0)
        {
            return contador;
        }
        else
        {
            Console.WriteLine($"El dato '{valorABuscar}' no fue encontrado en la lista.");
            return 0;
        }
    }
}

