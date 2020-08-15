using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Test
{

    static void Main()
    {
        string text = Console.ReadLine();
        var positions = new Dictionary<char, List<int>>();

        for (int i = 0; i < text.Length; i++)
        {
            if (!positions.ContainsKey(text[i]))
            {
                positions[text[i]] = new List<int>();
            }
            positions[text[i]].Add(i);
        }
        foreach (var item in positions)
        {
            Console.WriteLine($"{item.Key}:{string.Join("/",item.Value)}");
        }
    }
}