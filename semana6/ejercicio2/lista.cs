
public class Coleccion
{
    private Elemento primerElemento; // El inicio de la colección

    public Coleccion()
    {
        primerElemento = null;
    }

    public void Anadir(int valorNuevo)
    {
        Elemento nuevo = new Elemento(valorNuevo);
        if (primerElemento == null)
        {
            primerElemento = nuevo;
        }
        else
        {
            Elemento actual = primerElemento;
            while (actual.SiguienteElemento != null)
            {
                actual = actual.SiguienteElemento;
            }
            actual.SiguienteElemento = nuevo;
        }
    }

    public void VerColeccion()
    {
        if (primerElemento == null)
        {
            Console.WriteLine("La colección está vacía.");
            return;
        }

        Console.Write("Elementos en la colección: ");
        Elemento actual = primerElemento;
        while (actual != null)
        {
            Console.Write(actual.Dato + " ");
            actual = actual.SiguienteElemento;
        }
        Console.WriteLine();
    }

    public int CuantasVecesAparece(int valorBuscado)
    {
        int cuenta = 0;
        Elemento actual = primerElemento;

        while (actual != null)
        {
            if (actual.Dato == valorBuscado)
            {
                cuenta++;
            }
            actual = actual.SiguienteElemento;
        }

        if (cuenta == 0)
        {
            Console.WriteLine($"El valor {valorBuscado} no se encontró en la colección.");
        }
        
        return cuenta;
    }
}
