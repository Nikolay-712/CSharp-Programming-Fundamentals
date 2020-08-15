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
        string pattern = @"(\+359([ |-])2\2\d{3}\2\d{4})\b";
        string photos = Console.ReadLine();

        MatchCollection phoneMatches = Regex.Matches(photos, pattern);

        string[] matchedPhones = phoneMatches.Cast<Match>()
            .Select(match => match.Value.Trim()).ToArray();

        Console.WriteLine(string.Join(", ", matchedPhones));





    }


}