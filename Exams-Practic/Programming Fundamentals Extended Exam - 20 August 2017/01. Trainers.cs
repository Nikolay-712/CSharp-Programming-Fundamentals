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
        var Teams = new Dictionary<string, decimal>();

        Teams["Technical"] = 0;
        Teams["Practical"] = 0;
        Teams["Theoretical"] = 0;

        int counterTeams = int.Parse(Console.ReadLine());

        for (int i = 0; i < counterTeams; i++)
        {
            int miles = int.Parse(Console.ReadLine());
            int carried = int.Parse(Console.ReadLine());
            string teamName = Console.ReadLine();

            int milesToMeters = miles * 1600;
            int carriedToKilograms = carried * 1000;

            decimal needMooneyForFuel = (milesToMeters * 0.7M) * 2.5M;
            decimal CargoMoney = (carriedToKilograms * 1.5M);

            decimal totalMoney = CargoMoney - needMooneyForFuel;


            Teams[teamName] = totalMoney;
        }

        

        foreach (var item in Teams.OrderByDescending(x => x.Value).Take(1))
        {
           Console.WriteLine($"The {item.Key} Trainers win with ${item.Value:f3}.");
        }

        

    }
}