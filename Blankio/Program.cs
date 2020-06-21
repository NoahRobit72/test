using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using System.IO;

class Test
{
    public static void Main()
    {
        string dataPath = @"Data\Data.txt";
        string fileInfo;

        fileInfo = File.ReadAllText(dataPath);

        Console.WriteLine();
        Console.WriteLine("Press any key to continue");
        Console.ReadLine();
       
    }
}