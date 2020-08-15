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
        List<string> input = Console.ReadLine()
            .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();

        while (input[0] != "end")
        {
            string text = input[0];
            var placeholders = input[1]
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < placeholders.Count; i++)
            {
                string currentPlaceholder = "{" + i + "}";
                text = text.Replace(currentPlaceholder, placeholders[i]);
                
            }
            Console.WriteLine(text);

            input = Console.ReadLine()
            .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();

        }
    }


}
