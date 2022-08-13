using Classes;

internal class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("Jim", "Business", 2.8);
        Student student2 = new Student("Carl", "Compsci", 3.2);
        Console.WriteLine(student1.GoodGpa());
        Console.WriteLine(student2.GoodGpa());
        Console.ReadLine();
    }
}