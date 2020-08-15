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
        string Messege = Console.ReadLine().ToUpper();

        Regex regex = new Regex(@"(?<Text>[^0-9]+)(?<Count>[0-9]+)");
        MatchCollection matches = regex.Matches(Messege);

        StringBuilder TheMessege = new StringBuilder();

        foreach (Match match in matches)
        {
            string Text = match.Groups["Text"].ToString();
            int Repetition = int.Parse(match.Groups["Count"].ToString());


            for (int i = 0; i < Repetition; i++)
            {
                TheMessege.Append(Text);
            }
        }

        int count = TheMessege.ToString().Distinct().Count();
        Console.WriteLine($"Unique symbols used: {count}");
        Console.WriteLine(TheMessege);


    }

    
}
