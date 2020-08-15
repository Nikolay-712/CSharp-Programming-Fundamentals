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
        string regex = (@"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))");
        string input = Console.ReadLine();

        MatchCollection matches = Regex.Matches(input, regex);
        

        foreach (Match item in matches)
        {
            Console.Write(item.Value + " ");

        }
        Console.WriteLine();
        




    }


}