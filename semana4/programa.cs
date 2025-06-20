public class Agenda
{
    private Usuario[] usuarios = new Usuario[50];
    private int total = 0;

    public void Agregar(string nombre, string telefono)
    {
        if (total >= 50) return;
        
        usuarios[total].Nombre = nombre;
        usuarios[total].Telefono = telefono;
        total++;
    }

    public void Buscar(string nombre)
    {
        for (int i = 0; i < total; i++)
        {
            if (usuarios[i].Nombre.Contains(nombre))
            {
                Console.WriteLine($"{usuarios[i].Nombre}: {usuarios[i].Telefono}");
            }
        }
    }

    public void Mostrar()
    {
        for (int i = 0; i < total; i++)
        {
            Console.WriteLine($"{i+1}. {usuarios[i].Nombre} - {usuarios [i].Telefono}");
        }
    }
}