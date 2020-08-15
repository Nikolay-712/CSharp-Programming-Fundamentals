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
        string Train = Console.ReadLine();
        Regex pattern = new Regex(@"^(<\[[^A-Za-z0-9]*]\.)(\.\[[A-Za-z0-9]*]\.)*$");


        while (Train != "Traincode!")
        {


            MatchCollection matches = pattern.Matches(Train);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
            }


            Train = Console.ReadLine();
        }
    }
}