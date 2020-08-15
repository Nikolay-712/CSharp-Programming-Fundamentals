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
        string input = Console.ReadLine();

        while (input != "end")
        {
            string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
            string replacement = @"[URL href=$1]$2[/URL]";
            string replaced = Regex.Replace(input, pattern, replacement);

            Console.WriteLine(replaced);
            input = Console.ReadLine();
        }




    }


}