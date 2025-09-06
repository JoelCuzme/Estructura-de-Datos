using System;
using System.Collections.Generic;

namespace BibliotecaApp
{
    // Clase para representar un libro
    public class Libro
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacion { get; set; }
        public HashSet<string> Generos { get; set; } // Conjunto de géneros para evitar duplicados

        public Libro(string isbn, string titulo, string autor, int ano)
        {
            ISBN = isbn;
            Titulo = titulo;
            Autor = autor;
            AnoPublicacion = ano;
            Generos = new HashSet<string>();
        }

        public void AgregarGenero(string genero)
        {
            Generos.Add(genero);
        }
    }

    // Clase principal de la aplicación
    class Program
    {
        static Dictionary<string, Libro> biblioteca = new Dictionary<string, Libro>(); // Mapa: ISBN -> Libro

        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("\n--- Sistema de Registro de Libros en Biblioteca ---");
                Console.WriteLine("1. Registrar un nuevo libro");
                Console.WriteLine("2. Agregar género a un libro");
                Console.WriteLine("3. Consultar libro por ISBN");
                Console.WriteLine("4. Listar todos los libros");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarLibro();
                        break;
                    case "2":
                        AgregarGeneroALibro();
                        break;
                    case "3":
                        ConsultarLibro();
                        break;
                    case "4":
                        ListarLibros();
                        break;
                    case "5":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }

        static void RegistrarLibro()
        {
            Console.Write("Ingrese ISBN: ");
            string isbn = Console.ReadLine();
            if (biblioteca.ContainsKey(isbn))
            {
                Console.WriteLine("El libro con este ISBN ya existe.");
                return;
            }

            Console.Write("Ingrese Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Ingrese Autor: ");
            string autor = Console.ReadLine();
            Console.Write("Ingrese Año de Publicación: ");
            int ano;
            while (!int.TryParse(Console.ReadLine(), out ano))
            {
                Console.Write("Año inválido. Intente nuevamente: ");
            }

            Libro nuevoLibro = new Libro(isbn, titulo, autor, ano);
            biblioteca.Add(isbn, nuevoLibro);
            Console.WriteLine("Libro registrado exitosamente.");
        }

        static void AgregarGeneroALibro()
        {
            Console.Write("Ingrese ISBN del libro: ");
            string isbn = Console.ReadLine();
            if (!biblioteca.ContainsKey(isbn))
            {
                Console.WriteLine("Libro no encontrado.");
                return;
            }

            Console.Write("Ingrese género a agregar: ");
            string genero = Console.ReadLine();
            biblioteca[isbn].AgregarGenero(genero);
            Console.WriteLine("Género agregado.");
        }

        static void ConsultarLibro()
        {
            Console.Write("Ingrese ISBN: ");
            string isbn = Console.ReadLine();
            if (biblioteca.TryGetValue(isbn, out Libro libro))
            {
                Console.WriteLine($"Título: {libro.Titulo}");
                Console.WriteLine($"Autor: {libro.Autor}");
                Console.WriteLine($"Año: {libro.AnoPublicacion}");
                Console.WriteLine("Géneros: " + string.Join(", ", libro.Generos));
            }
            else
            {
                Console.WriteLine("Libro no encontrado.");
            }
        }

        static void ListarLibros()
        {
            if (biblioteca.Count == 0)
            {
                Console.WriteLine("No hay libros registrados.");
                return;
            }

            Console.WriteLine("Lista de libros:");
            foreach (var kvp in biblioteca)
            {
                Libro libro = kvp.Value;
                Console.WriteLine($"ISBN: {libro.ISBN}, Título: {libro.Titulo}, Autor: {libro.Autor}, Año: {libro.AnoPublicacion}");
                Console.WriteLine("Géneros: " + string.Join(", ", libro.Generos));
                Console.WriteLine("---");
            }
        }
    }
}
