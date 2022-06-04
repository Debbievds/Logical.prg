public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Give me somehting baby!");

        string whatever = Console.ReadLine().ToString();


        Console.WriteLine(SayAnything(whatever));
    }
    
    public static string SayAnything(string str) {
        return "I am a potato and my name is" + str.ToString();
    }
}