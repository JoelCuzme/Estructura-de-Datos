using System;

// Estudiante
public class Estudiante
{
   
    public int Id;          
    public string Nombres;  
    public string Apellidos; 
    public string Direccion; 
    public string[] Telefonos; 

    public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
    {
        Id = id;
        Nombres = nombres;
        Apellidos = apellidos;
        Direccion = direccion;
        Telefonos = telefonos; // Simplemente asignamos los teléfonos que nos den
    }

    // Esta función nos ayuda a mostrar la información del estudiante
    public void MostrarInformacion()
    {
        Console.WriteLine("Datos del Estudiante");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Apellidos: {Apellidos}");
        Console.WriteLine($"Dirección: {Direccion}");
        Console.WriteLine("Teléfonos:");

        // Recorremos el grupo de teléfonos para mostrarlos uno por uno
        foreach (string telefono in Telefonos)
        {
            Console.WriteLine($"- {telefono}");
        }
        
    }
}

// Aquí es donde el programa empieza a funcionar
public class Inicio
{
    public static void Main(string[] args)
    {
        

        
        string[] misTelefonos = { "0998245879", "0984562135", "0987895203" };

        // Creamos un estudiante llamado "María"
        Estudiante maria = new Estudiante(
            1,
            "Juan",
            "Cuzme",
            "Calle El Recreo",
            misTelefonos
        );

        
        maria.MostrarInformacion();

        Console.WriteLine("\n¡Listo! Presiona cualquier tecla para cerrar.");
        Console.ReadKey();
    }
}