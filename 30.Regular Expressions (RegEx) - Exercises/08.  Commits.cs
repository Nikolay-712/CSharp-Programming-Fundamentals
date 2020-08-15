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
        var Info = new SortedDictionary<string, SortedDictionary<string, List<string>>>();

        Regex regex = new Regex(@"^(https:\/\/github.com\/)(?<User>[a-zA-Z0-9\-]*)\/(?<Repo>[a-zA-Z\-_]*)\/(commit)\/(?<Comm>[a-f0-9]{40}),(?<Mess>[^\n]*),(?<Add>[0-9]*),(?<Del>[0-9]*)$");
        string input = Console.ReadLine();
        
        while (input != "git push")
        {

            Match match = regex.Match(input);

            string UserName = match.Groups["User"].Value;
            string Repository = match.Groups["Repo"].Value;
            string Commit = match.Groups["Comm"].Value;
            string Messege = match.Groups["Mess"].Value;

            decimal Additions = decimal.Parse(match.Groups["Add"].Value);
            decimal Deletions = decimal.Parse(match.Groups["Del"].Value);


            if (!Info.ContainsKey(UserName))
            {
                Info[UserName] = new SortedDictionary<string, List<string>>();
            }
            if (!Info[UserName].ContainsKey(Repository))
            {
                Info[UserName][Repository] = new List<string>();
            }

            string Result = $"commit {Commit}: {Messege} ({Additions} additions, {Deletions} deletions)";
            Info[UserName][Repository].Add(Result);


            input = Console.ReadLine();

        }

        foreach (var item in Info)
        {
            string UserName = item.Key;
            var InsideInfo = item.Value;

            Console.WriteLine($"{UserName}:");

            foreach (var inside in InsideInfo)
            {
                Console.WriteLine($"  {inside.Key}:");

                decimal TotalADD = 0;
                decimal TotalDEL = 0;

                foreach (var CommitInfo in inside.Value)
                {
                    Regex Numbers = new Regex(@"(?<Add>[0-9]+ (additions)), (?<Del>[0-9]+ (deletions))");
                    Match match = Numbers.Match(CommitInfo);

                    var Additions = (match.Groups["Add"].Value).Split(' ');
                    var Deletions = (match.Groups["Del"].Value).Split(' ');

                    decimal TotalAdditions = decimal.Parse(Additions[0]);
                    decimal TotalDeletions = decimal.Parse(Deletions[0]);

                    TotalADD = TotalADD + TotalAdditions;
                    TotalDEL = TotalDEL + TotalDeletions;

                    Console.WriteLine($"    {CommitInfo}");
                }

                Console.WriteLine($"    Total: {TotalADD} additions, {TotalDEL} deletions");
            }
        }

    }
}
