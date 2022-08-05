internal partial class Program
{
    private static void Main(string[] args)
    {
        bool isMale = false;
        bool isTall = true ;
        if (isMale || isTall)
        {
            Console.WriteLine("You are probably tall or male or both");
        } else
        {
            Console.WriteLine("YOu are not tall and not a male");
        }
        Console.ReadLine();
    }
}