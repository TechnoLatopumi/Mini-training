internal partial class Program
{
    private static void Main(string[] args)
    {
        int [,] numberGrid = {
            {1, 2},
            {3, 4},
            {5, 6}
        };
        int[,] myArray = new int[2,3];
        Console.WriteLine(numberGrid[2, 1]);
        Console.ReadLine();
    }
}