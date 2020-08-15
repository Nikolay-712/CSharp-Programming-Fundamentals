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
        Regex regex = new Regex(@"<[a-zA-Z0-9]+>");

        MatchCollection matchCollection = regex.Matches(text);

        if (matchCollection.Count > 0)
        {
            foreach (Match item in matchCollection)
            {
                string diamond = Convert.ToString(item);

                Regex digits = new Regex(@"[0-9]");
                MatchCollection match = digits.Matches(diamond);
                var carat = match.Cast<Match>().Select(x => x.Value).ToList().Select(int.Parse).Sum();
                

                Console.WriteLine($"Found {carat} carat diamond");
            }
        }
        else
        {
            Console.WriteLine("Better luck next time");
        }
    }
}