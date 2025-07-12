class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el número de discos: ");
        int discos = int.Parse(Console.ReadLine());
        
        new Torres(discos).Resolver();
    }
}