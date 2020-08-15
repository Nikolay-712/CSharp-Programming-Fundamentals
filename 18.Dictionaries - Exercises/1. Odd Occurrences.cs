using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{

    public static void Main()
    {
        Dictionary<string, int> language = new Dictionary<string, int>();

        List<string> input = Console.ReadLine().ToLower().Split(' ').ToList();


        foreach (var item in input)
        {
            if (language.ContainsKey(item))
            {
                language[item]++;
            }
            else
            {
                language[item] = 1;
            }
        }

        List<string> result = new List<string>();

        foreach (var item in language)
        {
            if (item.Value % 2 == 1)
            {
                result.Add(item.Value.ToString());
                result.Add(item.Key);
            } 
        }
        Console.WriteLine(string.Join(", ",result));
    }
}
    


