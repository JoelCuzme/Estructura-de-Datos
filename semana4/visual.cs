class Visual
{
    static void Main()
    {
        Agenda agenda = new Agenda();
        
        while (true)
        {
            Console.WriteLine("\n1. Agregar\n2. Buscar\n3. Mostrar\n4. Salir");
            Console.Write("Opción: ");
            string op = Console.ReadLine();

            if (op == "1")
            {
                Console.Write("Nombre: ");
                string nom = Console.ReadLine();
                Console.Write("Teléfono: ");
                string tel = Console.ReadLine();
                agenda.Agregar(nom, tel);
            }
            else if (op == "2")
            {
                Console.Write("Buscar: ");
                agenda.Buscar(Console.ReadLine());
            }
            else if (op == "3")
            {
                agenda.Mostrar();
            }
            else if (op == "4")
            {
                break;
            }
        }
    }
}