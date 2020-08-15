using System;

public class Test
{
    public static void Main()
    {
        double size = double.Parse(Console.ReadLine());

        double radius = (size * Math.PI) * 2;

        Console.WriteLine($"{radius:F12}");

    }
}