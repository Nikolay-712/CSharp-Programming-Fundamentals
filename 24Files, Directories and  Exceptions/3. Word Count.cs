using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

public class Test
{
    public static void Main()
    {

        Regex regeh = new Regex(@"[a-zA-Z]+");

        string text = File.ReadAllText(@"D:/RightSide.txt").ToLower();
        var countWords = new Dictionary<string, int>();

        MatchCollection match = regeh.Matches(text);
        

        foreach (Match item in match)
        {
            if (!countWords.ContainsKey(item.ToString()))
            {
                countWords[item.ToString()] = 1;
            }
            else
            {
                countWords[item.ToString()]++;
            }
            
        }

        foreach (var item in countWords.OrderByDescending(x => x.Value))
        {
            File.AppendAllText("results.txt", $"{item.Key} - {item.Value + Environment.NewLine}");
        }



    }
}