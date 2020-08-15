using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{

    public static void Main()
    {
        List<string> words = Console.ReadLine().Split(' ').ToList();
        Random rnd = new Random();

        for (int i = 0; i < words.Count; i++)
        {
            rnd.Next(0, words.Count - 1);
            Console.WriteLine(words[i]);
        }
    }
}


