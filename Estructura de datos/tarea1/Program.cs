using System;

class Circulo {
    public double radio;
    
    public double Area() {
        return 3.14 * radio * radio;
    }
    
    public double Perimetro() {
        return 2 * 3.14 * radio;
    }
}

class Rectangulo {
    public double ancho, alto;
    
    public double Area() {
        return ancho * alto;
    }
    
    public double Perimetro() {
        return 2 * (ancho + alto);
    }
}

class Program
{
    static void Main()
    {
        // Círculo
        Circulo c = new Circulo();
        c.radio = 3;
        Console.WriteLine("Círculo ");
        Console.WriteLine("Área: " + c.Area());
        Console.WriteLine("Perímetro: " + c.Perimetro());

        // Rectángulo
        Rectangulo r = new Rectangulo();
        r.ancho = 5;
        r.alto = 4;
        Console.WriteLine("\nRectángulo ");
        Console.WriteLine("Área: " + r.Area());
        Console.WriteLine("Perímetro: " + r.Perimetro());

        Console.ReadKey();
    }
}
