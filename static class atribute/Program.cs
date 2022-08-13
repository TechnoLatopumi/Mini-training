using Classes;


class Program
{
    static void Main(string[] args)
    {
        Song holiday =  new Song("Blast", "Jim", 200);
        Console.WriteLine(Song.songCount);
        Song fladed =  new Song("Fladed", "Carl", 300);
        Console.WriteLine(fladed.getSongCount());
   

        Console.ReadLine();
    }
}