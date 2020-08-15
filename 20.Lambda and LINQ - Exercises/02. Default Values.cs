using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Test
{

    public static void Main()
    {
        var info = new Dictionary<string, string>();

        List<string> input = Console.ReadLine().Split(new[] { " -> " },
            StringSplitOptions.RemoveEmptyEntries).ToList();



        while (input[0] != "end")
        {
            string TheKey = input[0];
            string TheValue = input[1];

            AddTheValue(info, TheKey, TheValue);

            input = Console.ReadLine().Split(new[] { " -> " },
            StringSplitOptions.RemoveEmptyEntries).ToList();

        }

        string ignorValue = Console.ReadLine();


        PrintValidValue(info);
        PrintIgnorValue(info, ignorValue);

    }

    private static void AddTheValue(Dictionary<string, string> info, string TheKey, string TheValue)
    {
        if (TheValue == null)
        {
            info[TheKey] = null;

        }
        else
        {
            info[TheKey] = TheValue;

        }
    }

    private static void PrintValidValue(Dictionary<string, string> info)
    {
        foreach (var item in info.Where(x => x.Value != "null")
            .OrderByDescending(x => x.Value.Length))
        {
            string key = item.Key;
            string value = item.Value;

            Console.WriteLine($"{key} <-> {value}");
        }
    }

    private static void PrintIgnorValue(Dictionary<string, string> info, string ignorValue)
    {
        foreach (var item in info.Where(x => x.Value == "null"))
        {
            string name = item.Key;

            Console.WriteLine($"{name} <-> {ignorValue}");

        }
    }
}









