public class Nodo
{
    public Vehiculo Vehiculo;
    public Nodo Siguiente;

    public Nodo(Vehiculo vehiculo)
    {
        this.Vehiculo = vehiculo;
        this.Siguiente = null;
    }
}