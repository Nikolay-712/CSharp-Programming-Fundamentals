using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Test
{
    static string namePlayer;
    static string nameTeam;
    static long points;

    public static void Main()
    {
        var teamInfo = new Dictionary<string, Dictionary<string, long>>();

        List<string> playersInTeam = Console.ReadLine().Split('|').ToList();


        while (playersInTeam[0] != "stop the game")
        {
             namePlayer = playersInTeam[0];
             nameTeam = playersInTeam[1];
             points =  long.Parse(playersInTeam[2]);


            if (!teamInfo.ContainsKey(nameTeam))
            {
                teamInfo[nameTeam] = new Dictionary<string, long>();

            }

            teamInfo[nameTeam][namePlayer] = points;

            if (teamInfo[nameTeam].Values.Count > 3)
            {
                teamInfo[nameTeam].Remove(namePlayer);
            }


            playersInTeam = Console.ReadLine().Split('|').ToList();
        }


        int teamPosition = 1;

        teamInfo = teamInfo.Where(x => x.Value.Count == 3)
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var item in teamInfo.OrderByDescending(x => x.Value.Values.Sum()))
        {
            string team = item.Key;
            var players = item.Value;
           
           Console.WriteLine($"{teamPosition}. {team}; Players:");
           teamPosition++;


            foreach (var player in players.OrderByDescending(x => x.Value))
            {
                string name = player.Key;
                decimal points = player.Value;

                Console.WriteLine($"###{name}: {points}");
            }
        }

        
        

    }

    
}
