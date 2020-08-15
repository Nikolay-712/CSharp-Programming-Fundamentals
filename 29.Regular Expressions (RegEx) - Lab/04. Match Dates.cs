using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Test
{
    public static void Main()
    {
        string regex = (@"\b(?<day>[0-9]{2})(\/|-|.)(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})\b");
        string input = Console.ReadLine();

        MatchCollection matches = Regex.Matches(input, regex);

        foreach (Match item in matches)
        {
            string day = item.Groups["days"].Value;
            string month = item.Groups["month"].Value;
            string year = item.Groups["year"].Value;

            Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");

        }




    }


}