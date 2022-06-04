internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, Debbie");

        Console.Write("What is your name?");
        string name = "";
        name = Console.ReadLine();

        Console.WriteLine("Hello " + name);


        Console.ReadLine();
    }
}