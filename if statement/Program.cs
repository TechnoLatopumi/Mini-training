internal partial class Program
{
    private static void Main(string[] args)
    {
        bool isMale = false;
        bool isTall = true;
        if (isMale && isTall)
        {
            Console.WriteLine("You are a tall male");
        } else if (isMale && !isTall) {
            Console.WriteLine("You are a male and not tall");
        } else if (!isMale && isTall) {
            Console.WriteLine("You are tall and not a male");
        } else {
            Console.WriteLine("You are not tall and not a male");
        }
        Console.ReadLine();
    }
}