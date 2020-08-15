using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        var data = new SortedDictionary<string, SortedDictionary<string, List<string>>>();

        int continentCnt = int.Parse(Console.ReadLine());

        for (int i = 0; i < continentCnt; i++)
        {
            List<string> info = Console.ReadLine().Split(' ').ToList();

            string continent = info[0];
            string country = info[1];
            string city = info[2];

            if (!data.ContainsKey(continent))
            {
                data[continent] = new SortedDictionary<string, List<string>>();
            }

            if (!data[continent].ContainsKey(country))
            {
                data[continent].Add(country, new List<string>());
            }

            data[continent][country].Add(city);
        }

        foreach (var continent in data)
        {
            string nameContinent = continent.Key;
            var countryInfo = continent.Value;

            Console.WriteLine($"{nameContinent}:");

            foreach (var country in countryInfo)
            {
                string nameCountry = country.Key;
                var cityInCountry = country.Value; 

                Console.WriteLine($"  {nameCountry} -> {string.Join(", ",cityInCountry)}");
            }

        }
    }
}