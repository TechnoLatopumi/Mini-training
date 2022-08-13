namespace Giraffe {

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.title ="haol";
        book1.author ="hol";
        book1.pages = 400;
        Console.WriteLine(book1.title);
        Console.ReadLine();
    }
}
}