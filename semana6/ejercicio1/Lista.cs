public class Lista
{
    public Nodo Cabeza;

    public Lista()
    {
        this.Cabeza = null;
    }

    public void Agregar(string placa, string marca, string modelo, int fecha, decimal precio)
    {
        Vehiculo nuevoVehiculo = new Vehiculo(placa, marca, modelo, fecha, precio);
        Nodo nuevoNodo = new Nodo(nuevoVehiculo);

        if (this.Cabeza == null)
        {
            this.Cabeza = nuevoNodo;
        }
        else
        {
            Nodo actual = this.Cabeza;
            while (actual.Siguiente != null) 
            {
                actual = actual.Siguiente; 
            }
            actual.Siguiente = nuevoNodo; 
        }
        Console.WriteLine($"Vehículo con placa {placa} agregado.");
    }

    public Vehiculo BuscarVehiculoPorPlaca(string placa)
    {
        Nodo actual = this.Cabeza;
        while (actual != null)
        {
            if (actual.Vehiculo.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\n--- Vehículo Encontrado ---");
                Console.WriteLine(actual.Vehiculo); 
                return actual.Vehiculo; 
            }
            actual = actual.Siguiente; 
        }
        Console.WriteLine($"No se encontró el vehículo con la placa '{placa}'.");
        return null;
    }

    public void VerVehiculosPorAnio(int anio)
    {
        Nodo actual = this.Cabeza;
        bool encontrados = false;
        Console.WriteLine($"\n--- Vehículos del Año {anio} ---");
        while (actual != null)
        {
            if (actual.Vehiculo.Anio == anio)
            {
                Console.WriteLine(actual.Vehiculo); 
                encontrados = true;
            }
            actual = actual.Siguiente; 
        }
        if (!encontrados)
        {
            Console.WriteLine($"No hay vehículos del año {anio}.");
        }
    }

    public void VerTodosLosVehiculos()
    {
        Nodo actual = this.Cabeza;
        if (actual == null)
        {
            Console.WriteLine("\nEl estacionamiento está vacío.");
            return;
        }

        Console.WriteLine("\n--- Todos los Vehículos Registrados ---");
        while (actual != null)
        {
            Console.WriteLine(actual.Vehiculo); 
            actual = actual.Siguiente; 
        }
    }

    public void EliminarVehiculoPorPlaca(string placa)
    {
        Nodo actual = this.Cabeza;
        Nodo anterior = null;

        if (actual != null && actual.Vehiculo.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase))
        {
            this.Cabeza = actual.Siguiente; 
            Console.WriteLine($"Vehículo con placa {placa} eliminado.");
            return;
        }

        while (actual != null && !actual.Vehiculo.Placa.Equals(placa, StringComparison.OrdinalIgnoreCase))
        {
            anterior = actual;
            actual = actual.Siguiente; 
        }

        if (actual == null)
        {
            Console.WriteLine($"No se encontró el vehículo con la placa '{placa}' para eliminar.");
            return;
        }

        if (anterior != null)
        {
            anterior.Siguiente = actual.Siguiente; 
        }
        Console.WriteLine($"Vehículo con placa {placa} eliminado.");
    }
}
