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
        StringBuilder word = new StringBuilder();
        SortedDictionary<int, string> allText = new SortedDictionary<int, string>();
        
        while (text != "end")
        {
            var tokens = text.Split(':', '/').ToList();

            var symbol = tokens[0];
            var positions = tokens.Skip(1).ToList().Select(int.Parse).ToList();

            for (int i = 0; i < positions.Count; i++)
            {
                allText[positions[i]] = symbol;
            }
            
           
            text = Console.ReadLine();
        }
        foreach (var item in allText)
        {
            word.Append(item.Value);
        }

        Console.WriteLine(word.ToString());
    }
}