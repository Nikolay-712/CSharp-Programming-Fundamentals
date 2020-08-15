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
        List<string> input = Console.ReadLine().Split('|').ToList();
        var info = new Dictionary<string, Dictionary<string, int>>();
            
        while (input[0] != "Result")
        {
            int points = int.Parse(input[2]);
            string team = string.Empty;
            string player = string.Empty;

            var patern = new[] { '@', '%', '$', '*' };

            var name = input[0].Split(patern, StringSplitOptions.RemoveEmptyEntries);
            var name1 = input[1].Split(patern, StringSplitOptions.RemoveEmptyEntries);

            Regex teamName = new Regex(@"\b[A-Z]+\b");
            Regex playerName = new Regex(@"^[A-Z]{1}[a-z]+");

            string checkName = string.Join("", name);
            string checkName1 = string.Join("", name1);

            if (teamName.IsMatch(checkName))
            {
                team = checkName;
                player = checkName1;
            }
            else
            {
                team = checkName1;
                player = checkName;
            }

            if (!info.ContainsKey(team))
            {
                info[team] = new Dictionary<string, int>();

            }
            info[team][player] = points;

            input = Console.ReadLine().Split('|').ToList();

        }

        foreach (var item in info.OrderByDescending(x => x.Value.Values.Sum()))
        {
            Console.WriteLine($"{item.Key} => {item.Value.Values.Sum()}");

            foreach (var player in item.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"Most points scored by {player.Key}");
                break;
            }
        }
    }


}
