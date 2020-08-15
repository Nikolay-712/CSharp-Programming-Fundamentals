using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Test
{
    public static void Main()
    {
        var countryInfo = new Dictionary<string, Dictionary<string, int>>();

        List<string> input = Console.ReadLine().Split(new[] { " -> " }
        , StringSplitOptions.RemoveEmptyEntries).ToList();


        while (input[0] != "quit")
        {
            string countryName = input[0];
            string name = input[1];
            int number = int.Parse(input[2]);

            if (!countryInfo.ContainsKey(countryName))
            {
                countryInfo[countryName] = new Dictionary<string, int>();
            }

            countryInfo[countryName][name] = number;




            input = Console.ReadLine().Split(new[] { " -> " }
        , StringSplitOptions.RemoveEmptyEntries).ToList();
        }


        foreach (var item in countryInfo.OrderByDescending(x => x.Value.Count()))
        {
            string country = item.Key;
            var info = item.Value;

            Console.WriteLine($"Country: {country}");

            foreach (var name in info.OrderByDescending(name => name.Value))
            {
                string Name = name.Key;
                int num = name.Value;

                Console.WriteLine($"**{Name} : {num}");


            }
        }
    }




}