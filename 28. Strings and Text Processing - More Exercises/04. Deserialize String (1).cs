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
        StringBuilder word = new StringBuilder(new string(' ', 200));
        
        
        while (text != "end")
        {
            var tokens = text.Split(':', '/').ToList();

            var symbol = tokens[0];
            var positions = tokens.Skip(1).ToList().Select(int.Parse).ToList();

            for (int i = 0; i < positions.Count; i++)
            {
                word.Replace(" ", symbol, positions[i],1);
            }
            
           
            text = Console.ReadLine();
        }
       

        Console.WriteLine(word.ToString());
    }
}