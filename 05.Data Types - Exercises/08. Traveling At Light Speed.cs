using System;

public class Test
{
    public static void Main()
    {
        decimal lightYears = decimal.Parse(Console.ReadLine());

        decimal kilometerslightYears = 9450000000000;
        decimal speedOfLight = 300000;

        decimal totalSekunds = (lightYears * kilometerslightYears) / speedOfLight;

        int minutes = (int)totalSekunds / 60;
        totalSekunds = totalSekunds % 60;
        int hours = (int)minutes / 60;
        minutes = minutes % 60;
        int days = hours / 24;
        hours = hours % 24;
        int week = days / 7;
        days = days % 7;

        Console.WriteLine($"{week} weeks");
        Console.WriteLine($"{days} days");
        Console.WriteLine($"{hours} hours");
        Console.WriteLine($"{minutes} minutes");
        Console.WriteLine($"{(int)totalSekunds} seconds");




    }
}
    
