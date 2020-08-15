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
        List<string> Water = new List<string>();

        Regex FishWithTail = new Regex(@">*<\(+['\-x]>");

        string input = Console.ReadLine();

        MatchCollection Fish = FishWithTail.Matches(input);

        AddFish(Water, Fish);
        int FishCounter = 0;

        if (Water.Count == 0)
        {
            Console.WriteLine("No fish found.");
            return;

        }

        foreach (var TheFish in Water)
        {
            FishCounter++;

            string Statuses = string.Empty;
            int BodyLenght = 0;
            int TailLenght = 0;

            string TailStatus = string.Empty;
            string BodyStatus = string.Empty;

            Console.WriteLine($"Fish {FishCounter}: {TheFish}");

            for (int i = 0; i < TheFish.Length; i++)
            {
                Statuses = StatusFish(TheFish, Statuses);

                if (TheFish[i] == '(')
                {
                    BodyLenght++;
                }
                if (TheFish[i] == '>')
                {
                    TailLenght++;
                }
            }
            TailLenght--;

            TailStatus = TailType(TailLenght, TailStatus);
            BodyStatus = BodyType(BodyLenght);

            int TailInSM = TailLenght * 2;
            int BodyInSM = BodyLenght * 2;

            if (TailInSM == 0)
            {
                Console.WriteLine($"  Tail type: None");
            }
            else
            {
                Console.WriteLine($"  Tail type: {TailStatus} ({TailInSM} cm)");
            }

            
            Console.WriteLine($"  Body type: {BodyStatus} ({BodyInSM} cm)");
            Console.WriteLine($"  Status: {Statuses}");
        }


    }

    private static string BodyType(int BodyLenght)
    {
        string BodyStatus;
        if (BodyLenght > 10)
        {
            BodyStatus = "Long";
        }
        else if (BodyLenght > 5)
        {
            BodyStatus = "Medium";
        }
        else
        {
            BodyStatus = "Short";
        }

        return BodyStatus;
    }

    private static string TailType(int TailLenght, string TailStatus)
    {
        if (TailLenght > 5)
        {
            TailStatus = "Long";
        }
        else if (TailLenght > 1)
        {
            TailStatus = "Medium";
        }
        else if (TailLenght == 1)
        {
            TailStatus = "Short";
        }

        return TailStatus;
    }

    private static string StatusFish(string TheFish, string Statuses)
    {
        if (TheFish.Contains("'"))
        {
            Statuses = "Awake";
        }
        else if (TheFish.Contains("-"))
        {
            Statuses = "Asleep";
        }
        else if (TheFish.Contains("x"))
        {
            Statuses = "Dead";
        }

        return Statuses;
    }


    private static void AddFish(List<string> Water, MatchCollection Fish)
    {
        foreach (Match item in Fish)
        {
            string fish = item.Value;

            Water.Add(fish);
        }
    }
}