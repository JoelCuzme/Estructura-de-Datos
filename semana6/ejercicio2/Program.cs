
public class Programa
{
    public static void Main(string[] args)
    {
        Coleccion miColeccion = new Coleccion();

        miColeccion.Anadir(100);
        miColeccion.Anadir(200);
        miColeccion.Anadir(100);
        miColeccion.Anadir(300);
        miColeccion.Anadir(400);
        miColeccion.Anadir(100);
        miColeccion.Anadir(200);


        // Ejemplos de búsqueda
        Console.WriteLine(" Resultados de búsqueda ");

        int buscar1 = 100;
        int veces1 = miColeccion.CuantasVecesAparece(buscar1);
        if (veces1 > 0)
        {
            Console.WriteLine($"El valor {buscar1} aparece {veces1} vez.");
        }

        Console.WriteLine();

        int buscar2 = 200;
        int veces2 = miColeccion.CuantasVecesAparece(buscar2);
        if (veces2 > 0)
        {
            Console.WriteLine($"El valor {buscar2} aparece {veces2} vez.");
        }

        
        Console.WriteLine();

        int buscar4 = 300;
        int veces4 = miColeccion.CuantasVecesAparece(buscar4);
        if (veces4 > 0)
        {
            Console.WriteLine($"El valor {buscar4} aparece {veces4} vez.");
        }
    }
}