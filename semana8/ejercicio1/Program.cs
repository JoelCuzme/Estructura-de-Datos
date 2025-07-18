
class Programa
{
    static Queue<string> colaEspera = new Queue<string>();
    static Asiento cabeza = null; 
    static Stack<string> pilaSalidos = new Stack<string>();
    static List<string> personasRechazadas = new List<string>(); 
    const int ASIENTOS_MAX = 30;

    static void Main(string[] args)
    {

        Console.WriteLine("Ingresa los nombres de las personas en la fila :");
        while (true)
        {
            string nombre = Console.ReadLine();
            if (string.IsNullOrEmpty(nombre)) 
                break;
            colaEspera.Enqueue(nombre.Trim());
        }

        AsignarAsientos();

        Console.WriteLine("\nAsientos ocupados ");
        Mostrar();

        Console.WriteLine("\nBuscar Persona ");
        Console.Write("Ingresa un nombre para buscar en los asientos: ");
        string buscar = Console.ReadLine();
        int asientoEncontrado = Buscar(buscar);
        if (asientoEncontrado != -1)
            Console.WriteLine($"{buscar} se encuentra en el asiento: {asientoEncontrado}");
        else
            Console.WriteLine($"{buscar} NO se encuentra en los asientos.");

        Console.Write("Ingresa el nombre de quien abandona la atracción: ");
        string eliminar = Console.ReadLine();
        if (EliminarA(eliminar))
        {
            pilaSalidos.Push(eliminar);
            Console.WriteLine($"{eliminar} salió de la atracción.");
        }
        else
        {
            Console.WriteLine($"{eliminar} no estaba en la lista de asientos.");
        }

        Console.WriteLine("\nAsientos después de eliminación ");
        Mostrar();

        Console.WriteLine("\nAsientos ordenados por nombre");
        Ordenar();
        Mostrar();

        Console.WriteLine("\n--- Personas que salieron de la atracción");
        if (pilaSalidos.Count == 0)
        {
            Console.WriteLine("Nadie ha salido de la atracción todavía.");
        }
        while (pilaSalidos.Count > 0)
            Console.WriteLine(pilaSalidos.Pop());

        if (personasRechazadas.Count > 0)
        {
            Console.WriteLine("\nPersonas que no consiguieron asiento ");
            foreach (var nombreRechazado in personasRechazadas)
            {
                Console.WriteLine(nombreRechazado);
            }
        }

        Console.WriteLine("\nPresiona cualquier tecla para salir.");
        Console.ReadKey();
    }

   
    static void AsignarAsientos()
    {
        int numeroAsiento = 1;
        int asientosOcupadosCount = 0; 

        while (colaEspera.Count > 0)
        {
            string persona = colaEspera.Dequeue();
            if (asientosOcupadosCount < ASIENTOS_MAX)
            {
                AsientoFinal(persona, numeroAsiento);
                Console.WriteLine($"{persona} recibe el asiento #{numeroAsiento}.");
                numeroAsiento++;
                asientosOcupadosCount++; // Incrementamos el contador
            }
            else
            {
                Console.WriteLine($"{persona} no consiguió asiento y fue rechazado.");
                personasRechazadas.Add(persona);
            }
        }
    }

    
    static void AsientoFinal(string nombre, int numero)
    {
        Asiento nuevo = new Asiento(nombre, numero);
        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Asiento actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    
    static int Buscar(string nombre)
    {
        Asiento actual = cabeza;
        while (actual != null)
        {
            if (actual.GetNombre().Equals(nombre, StringComparison.OrdinalIgnoreCase))
                return actual.GetNumero();
            actual = actual.Siguiente;
        }
        return -1;
    }

    static bool EliminarA(string nombre)
    {
        Asiento actual = cabeza, previo = null;
        while (actual != null)
        {
            if (actual.GetNombre().Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                if (previo == null)
                    cabeza = actual.Siguiente; 
                    previo.Siguiente = actual.Siguiente; 
                return true;
            }
            previo = actual;
            actual = actual.Siguiente;
        }
        return false;
    }

    
    static void Mostrar()
    {
        if (cabeza == null)
        {
            Console.WriteLine("No hay asientos ocupados.");
            return;
        }

        Asiento actual = cabeza;
        while (actual != null)
        {
            Console.WriteLine($"Asiento #{actual.GetNumero()}: {actual.GetNombre()}");
            actual = actual.Siguiente;
        }
    }

    
    static void Ordenar()
    {
        if (cabeza == null) return;

        bool huboCambios;
        do
        {
            huboCambios = false;
            Asiento actual = cabeza;
            while (actual.Siguiente != null)
            {
                if (string.Compare(actual.GetNombre(), actual.Siguiente.GetNombre(), StringComparison.OrdinalIgnoreCase) > 0)
                {
                    string tempNombre = actual.GetNombre();
                    int tempNumero = actual.GetNumero();

                    actual.SetNombre(actual.Siguiente.GetNombre());
                    actual.SetNumero(actual.Siguiente.GetNumero());

                    actual.Siguiente.SetNombre(tempNombre);
                    actual.Siguiente.SetNumero(tempNumero);

                    huboCambios = true;
                }
                actual = actual.Siguiente;
            }
        } while (huboCambios);
    }
}