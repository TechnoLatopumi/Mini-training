internal class Program
{
    private static void Main(string[] args)
    {
        int cubedNumber = cube(6);
        Console.WriteLine(cubedNumber);
        Console.ReadLine();
    }

    static int cube(int num)
    {
        int result = num*num*num;
        return result;
    }
}