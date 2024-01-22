namespace Git_Assignement_Class;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("My name is Brian");
        CountTo(8);
    }
    /// <summary>
    /// Test comment
    /// </summary>
    /// <param name="num"></param>

    static void CountTo(int num)
    {
        Console.WriteLine("Counting to " + num + ":");
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine(i);
        }
    }
}