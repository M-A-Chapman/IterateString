namespace iterateString;
class Program
{
    static void Main(string[] args)
    {
        var str = "Mike Chapman";
        foreach (var character in str)
        {
            Console.WriteLine(character);
        }
    }
}
