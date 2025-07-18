using System;
using System.Collections.Generic;

// Clase para representar un asiento
class Asiento
{
    private string nombre;
    private int numero;
    public Asiento Siguiente; // Mantener para la lista enlazada manual

    // Constructor para inicializar las propiedades
    public Asiento(string nombre, int numero)
    {
        this.nombre = nombre;
        this.numero = numero;
        this.Siguiente = null; // Se inicializa como nulo por defecto
    }

    // Métodos para acceder a las propiedades (equivalente a get/set manual)
    public string GetNombre()
    {
        return nombre;
    }

    public void SetNombre(string value)
    {
        nombre = value;
    }

    public int GetNumero()
    {
        return numero;
    }

    public void SetNumero(int value)
    {
        numero = value;
    }
}