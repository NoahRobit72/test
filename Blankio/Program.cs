using System.IO;

class Test
{
    public static void Main()
    {
        string hi = File.WriteAllText(@"/Users/noahrobitshek/Projects/Blankio/Blankio/Data/Data.txt", "hi");

        System.Console.WriteLine(hi);

        System.Console.WriteLine();
        System.Console.WriteLine("enter");
        System.Console.ReadLine();
        System.Console.WriteLine();
    }
}