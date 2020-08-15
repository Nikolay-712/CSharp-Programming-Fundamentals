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
        var LegueInfo = new List<string>();
        var TopStrickerInfo = new List<string>();

        var Info = new Dictionary<string, int>();
        var InfoStricker = new Dictionary<string, int>();

        string key = Console.ReadLine();
        List<string> teams = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();


        while (teams[0] != "final")
        {
            string TheTeamA = string.Empty;
            string TheTeamB = string.Empty;

            string teamA = teams[0];
            string teamB = teams[1];
            string[] result = teams[2].Split(':');

            TheTeamA = DecryptTeamA(key, ref TheTeamA, ref teamA);
            TheTeamB = DecryptTeamB(key, ref TheTeamB, ref teamB);

            int ScoreTeamA = int.Parse(result[0]);
            int ScoreTeamB = int.Parse(result[1]);
            int Points = 0;
            string Winer = string.Empty;

            if (ScoreTeamA > ScoreTeamB)
            {
                Points = 3;
                LegueInfo.Add($"{TheTeamA} {Points}");
                LegueInfo.Add($"{TheTeamB} {0}");

                TopStrickerInfo.Add($"{TheTeamA} {ScoreTeamA}");
                TopStrickerInfo.Add($"{TheTeamB} {ScoreTeamB}");



            }
            else if (ScoreTeamB > ScoreTeamA)
            {
                Points = 3;
                LegueInfo.Add($"{TheTeamB} {Points}");
                LegueInfo.Add($"{TheTeamA} {0}");

                TopStrickerInfo.Add($"{TheTeamA} {ScoreTeamA}");
                TopStrickerInfo.Add($"{TheTeamB} {ScoreTeamB}");


            }
            else if (ScoreTeamA == ScoreTeamB)
            {
                Points = 1;
                LegueInfo.Add($"{TheTeamA} {Points}");
                LegueInfo.Add($"{TheTeamB} {Points}");

                TopStrickerInfo.Add($"{TheTeamA} {ScoreTeamA}");
                TopStrickerInfo.Add($"{TheTeamB} {ScoreTeamB}");

            }




            teams = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        CalculateResults(LegueInfo, Info);

        for (int i = 0; i < TopStrickerInfo.Count; i++)
        {
            var result = TopStrickerInfo[i].Split(' ');
            string team = result[0];
            int goals = int.Parse(result[1]);

            if (!InfoStricker.ContainsKey(team))
            {
                InfoStricker[team] = goals;

            }
            else
            {
                InfoStricker[team] = InfoStricker[team] + goals;
            }

        }

        int counterPosition = 0;
        Console.WriteLine("League standings:");
        foreach (var item in Info.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            counterPosition++;
            string team = item.Key;
            int points = item.Value;

            Console.WriteLine($"{counterPosition}. {team} {points}");
        }

        Console.WriteLine("Top 3 scored goals:");
        foreach (var item in InfoStricker)
        {
            string team = item.Key;
            int goals = item.Value;

            Console.WriteLine($"- {team} -> {goals}");

        }
    }

    private static void CalculateResults(List<string> LegueInfo, Dictionary<string, int> Info)
    {
        for (int i = 0; i < LegueInfo.Count; i++)
        {
            var results = LegueInfo[i].Split(' ');
            string TeamName = results[0];
            int Points = int.Parse(results[1]);

            if (!Info.ContainsKey(TeamName))
            {
                Info[TeamName] = Points;

            }
            else
            {
                Info[TeamName] = Info[TeamName] + Points;
            }
        }
    }

    private static string DecryptTeamB(string key, ref string TheTeamB, ref string teamB)
    {
        if (teamB.Contains(key))
        {
            teamB = teamB.Replace(key, "|");
            char[] Team = teamB.ToCharArray();

            for (int i = 0; i < Team.Length; i++)
            {
                if (Team[i] == '|')
                {
                    Team = Team.Skip(i + 1).ToArray();
                    Team = Team.Reverse().ToArray();

                    i = -1;
                }
            }
            Team = Team.Reverse().ToArray();

            for (int i = 0; i < Team.Length; i++)
            {
                TheTeamB = TheTeamB + Team[i];

            }
        }
        return TheTeamB.ToUpper();
    }

    private static string DecryptTeamA(string key, ref string TheTeamA, ref string teamA)
    {
        if (teamA.Contains(key))
        {
            teamA = teamA.Replace(key, "|");
            char[] Team = teamA.ToCharArray();

            for (int i = 0; i < Team.Length; i++)
            {
                if (Team[i] == '|')
                {
                    Team = Team.Skip(i + 1).ToArray();
                    Team = Team.Reverse().ToArray();

                    i = -1;
                }
            }
            Team = Team.Reverse().ToArray();

            for (int i = 0; i < Team.Length; i++)
            {
                TheTeamA = TheTeamA + Team[i];

            }

        }
        return TheTeamA.ToUpper();
    }


}

