using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Test
{

    public static void Main()
    {
        var info = new Dictionary<string, Dictionary<string, int>>();

        List<string> input = Console.ReadLine().Split(' ').ToList();

        while (input[0] != "end")
        {
            string nameOfThePerson = input[0];
            string camperModel = input[1];
            int nights = int.Parse(input[2]);

            if (!info.ContainsKey(nameOfThePerson))
            {
                info[nameOfThePerson] = new Dictionary<string, int>();
            }

            info[nameOfThePerson][camperModel] = nights;

            input = Console.ReadLine().Split(' ').ToList();


        }

         info = info.OrderByDescending(x => x.Value.Count)
            .ThenBy(item => item.Key.Length).ToDictionary(x => x.Key,x => x.Value);

        foreach (var item in info)
        {
            string name = item.Key;
            var infoCamps = item.Value;

            int vistCamp = infoCamps.Values.Count;
            int nightsinCamp = infoCamps.Values.Sum();


            Console.WriteLine($"{name}: {vistCamp}");

            foreach (var Camp in infoCamps)
            {
                string nameCamp = Camp.Key;
                

                Console.WriteLine($"***{nameCamp}");
            }
            Console.WriteLine($"Total stay: {nightsinCamp} nights");

        }
        
    }


}
