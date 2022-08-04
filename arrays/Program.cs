internal class Program
{
    private static void Main(string[] args)
    {
        int [] luckyNumbers = {4, 7, 40, 32, 15, 13, 22};

        luckyNumbers[1] = 700;

        Console.WriteLine( luckyNumbers[1]);

        Console.ReadLine();
    }
}