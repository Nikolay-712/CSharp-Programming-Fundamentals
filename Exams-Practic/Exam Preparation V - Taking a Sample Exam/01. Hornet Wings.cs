using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Test
{
    public static void Main()
    {
        int wing = int.Parse(Console.ReadLine());
        double distanceForMeters = double.Parse(Console.ReadLine());
        int endurance = int.Parse(Console.ReadLine());


        int Break = wing / endurance;
        decimal seconds = Break * 5L;
        double distance = (wing / 1000) * distanceForMeters;
        seconds = seconds + (wing / 100);

        Console.WriteLine($"{distance:F2} m.");
        Console.WriteLine($"{seconds} s.");




    }
}