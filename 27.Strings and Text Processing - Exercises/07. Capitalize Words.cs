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
        string inputLine = Console.ReadLine();

        while (inputLine != "end")
        {
            string[] elements = inputLine.Trim()
                .Split(new[] { ' ', '.', ',', ':', ';', '?', '!', '-', '_' },
                    StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < elements.Length; i++)
            {
                string word = elements[i].ToLower();
                string firstLetter = word[0].ToString().ToUpper();

                elements[i] = firstLetter + word.Substring(1);
            }
            Console.WriteLine(string.Join(", ", elements));

            inputLine = Console.ReadLine();
        }
    }


}
