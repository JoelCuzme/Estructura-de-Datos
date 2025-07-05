using System;
using System.Collections.Generic; 

public class Elemento
{
    public int Dato; 
    public Elemento SiguienteElemento; 

    public Elemento(int dato)
    {
        Dato = dato;
        SiguienteElemento = null;
    }
}
