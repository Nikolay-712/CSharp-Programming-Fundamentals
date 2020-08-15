using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        var cityInfo = new Dictionary<string, HashSet<long>>();

       List<string> region = Console.ReadLine().Split(' ').ToList();

        while (region[0] != "Aggregate")
        {
            string city = region[0];
            int size = int.Parse(region[1]);

            if (!cityInfo.ContainsKey(city))
            {
                cityInfo[city] = new HashSet<long>();
            }

            cityInfo[city].Add(size);


            region = Console.ReadLine().Split(' ').ToList();
        }


        foreach (var item in cityInfo)
        {
            string nameCity = item.Key;
            var sizeInCity = item.Value.Sum();

            var result = sizeInCity - sizeInCity / item.Value.Count;

            Console.WriteLine($"{nameCity} -> {string.Join(",",item.Value)} ({result})");
        }
    }
}