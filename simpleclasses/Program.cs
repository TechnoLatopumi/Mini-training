using Classes;

internal class Program
{

    
    static void Main(string[] args)
    {
        Book book1 = new Book("Harry Potter", "JK Rowling", 400);
        
        Book book2 = new Book("Spy x Family", "Tatsuya Endou", 200);

        Book book3 = new Book();

        book2.title = "Spy x Family Limited Edition";
       
        Console.WriteLine(book2.title);
        Console.WriteLine(book1.author);

        
        
        Console.ReadLine();
    }
}