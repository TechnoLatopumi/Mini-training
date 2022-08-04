internal class Program
{
    private static void Main(string[] args)
    {
        SayHi("Tegar", 29);
        SayHi("Dimas", 28);
        SayHi("Pradana", 30);
        Console.ReadLine();

    }

    static void SayHi(string name, int age)
    {

        Console.WriteLine("Hello "+name+" you are "+age);
    }
}