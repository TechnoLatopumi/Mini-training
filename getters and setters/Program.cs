using Classes;

class Program
{
    static void Main(string[] args)
    {
        Movie runner = new Movie("runner", "Jim", "unknown");
        Movie transformer = new Movie("transformer", "Autobot", "R");
        // G, PG, PG-13, R, NR
        transformer.Rating = "chicken";
        Console.WriteLine(runner.Rating);
        Console.WriteLine(transformer.Rating);
        Console.ReadLine();
    }
}