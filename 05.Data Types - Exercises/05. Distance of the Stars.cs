using System;

public class Test
{
    public static void Main()
    {
        decimal lightYear = 9450000000000m;

        decimal proxyma = 4.22m * lightYear;
        decimal galaxy = 26000 * lightYear;
        decimal milkWay = 100000 * lightYear;
        decimal universe = 46500000000 * lightYear;

        Console.WriteLine($"{proxyma:E2}");
        Console.WriteLine($"{galaxy:E2}");
        Console.WriteLine($"{milkWay:E2}");
        Console.WriteLine($"{universe:E2}");
    }
}
    
