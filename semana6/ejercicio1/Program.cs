public class Program
{
    static void MostrarMenu()
    {
        Console.WriteLine("1. Agregar vehículo");
        Console.WriteLine("2. Buscar vehículo por placa");
        Console.WriteLine("3. Ver vehículos por año");
        Console.WriteLine("4. Ver todos los vehículos");
        Console.WriteLine("5. Eliminar vehículo por placa");
        Console.WriteLine("6. Salir");
    }

    public static void Main(string[] args)
    {
        Lista estacionamiento = new Lista();
        string opcion;

        do
        {
            MostrarMenu();
            Console.Write("Seleccione una opción:");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Agregar Nuevo Vehículo");
                    Console.Write("Placa: ");
                    string placa = Console.ReadLine().ToUpper();
                    Console.Write("Marca: ");
                    string marca = Console.ReadLine();
                    Console.Write("Modelo: ");
                    string modelo = Console.ReadLine();

                    int fecha;
                    Console.Write("Año: ");
                    while (!int.TryParse(Console.ReadLine(), out fecha))
                    {
                        Console.WriteLine("Año inválido. Ingrese un número.");
                        Console.Write("Año: ");
                    }

                    decimal precio;
                    Console.Write("Precio: ");
                    while (!decimal.TryParse(Console.ReadLine(), out precio))
                    {
                        Console.WriteLine("Precio inválido. Ingrese un número.");
                        Console.Write("Precio: ");
                    }

                    estacionamiento.Agregar(placa, marca, modelo, fecha, precio);
                    break;

                case "2":
                    Console.WriteLine("Buscar Vehículo");
                    Console.Write("Placa a buscar: ");
                    string placaBuscar = Console.ReadLine().ToUpper();
                    estacionamiento.BuscarVehiculoPorPlaca(placaBuscar);
                    break;

                case "3":
                    Console.WriteLine("Ver Vehículos por Año ");
                    int anioBuscar;
                    Console.Write("Año a filtrar: ");
                    while (!int.TryParse(Console.ReadLine(), out anioBuscar))
                    {
                        Console.WriteLine("Año inválido. Ingrese un número.");
                        Console.Write("Año a filtrar: ");
                    }
                    estacionamiento.VerVehiculosPorAnio(anioBuscar);
                    break;

                case "4":
                    estacionamiento.VerTodosLosVehiculos();
                    break;

                case "5":
                    Console.WriteLine("Eliminar Vehículo");
                    Console.Write("Placa a eliminar: ");
                    string placaEliminar = Console.ReadLine().ToUpper();
                    estacionamiento.EliminarVehiculoPorPlaca(placaEliminar);
                    break;

                case "6":
                    Console.WriteLine("Saliendo del programa");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        } while (opcion != "6");
    }
}