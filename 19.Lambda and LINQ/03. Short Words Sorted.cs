using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        char[] separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' ' };

        string sentens = Console.ReadLine().ToLower();
        string[] word = sentens.Split(separators, StringSplitOptions.RemoveEmptyEntries).Where(w => w.Length < 5).OrderBy(w => w).Distinct().ToArray();



        Console.WriteLine(string.Join(", ", word));
    }

}









