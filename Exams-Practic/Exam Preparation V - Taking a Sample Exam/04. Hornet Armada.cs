using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Test
{
    public static void Main()
    {
        var infoLegions = new Dictionary<string, int>();
        var infoUnity = new Dictionary<string, Dictionary<string, long>>();

        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            List<string> infoLegion = Console.ReadLine()
                .Split(new[] { " = ", " -> ", ":" }, StringSplitOptions
                .RemoveEmptyEntries).ToList();

            int lastActivity = int.Parse(infoLegion[0]);
            string legionName = infoLegion[1];
            string typeSoldier = infoLegion[2];
            long countUnity = long.Parse(infoLegion[3]);

            if (!infoLegions.ContainsKey(legionName))
            {
                infoLegions.Add(legionName, lastActivity);
                infoUnity.Add(legionName, new Dictionary<string, long>());
            }

            if (!infoUnity[legionName].ContainsKey(typeSoldier))
            {
                infoUnity[legionName][typeSoldier] = 0;

            }

            if (infoLegions[legionName] < lastActivity)
            {
                infoLegions[legionName] = (lastActivity);
            }


            infoUnity[legionName][typeSoldier] = infoUnity[legionName][typeSoldier] + countUnity;
        }





        List<string> comand = Console.ReadLine().Split('\\').ToList();

        if (comand.Count == 1)
        {
            string type = comand[0];

            foreach (var item in infoLegions.OrderByDescending(x => x.Value))
            {
                if (infoUnity[item.Key].ContainsKey(type))
                {
                    Console.WriteLine($"{item.Value} : {item.Key}");
                }
            }

        }
        else
        {
            long activiti = long.Parse(comand[0]);
            string type = comand[1];

            foreach (var item in infoUnity.Where(x => x.Value.ContainsKey(type))
                .OrderByDescending(x => x.Value[type]))
            {
                if (infoLegions[item.Key] < activiti)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value[type]}");

                }
            }
        }
    }


}