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
        List<string> skipWords = Console.ReadLine()
            .Split(new[] { ", "},StringSplitOptions.RemoveEmptyEntries).ToList();

        string text = Console.ReadLine();

        Regex patern = new Regex(@"[a-zA-Z]+");
        MatchCollection matchCollection = patern.Matches(text);
        List<string> evryOneWord = matchCollection.Cast<Match>().Select(x => x.Value).ToList();

        foreach (var word in evryOneWord)
        {
            if (skipWords.Contains(word))
            {
               text = text.Replace(word, new string('*',word.Length));
            }
        }
        Console.WriteLine(text);
    }
}