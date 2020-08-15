using System;

public class Test
{
    public static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        double power = double.Parse(Console.ReadLine());

        double result = PowerNumber(number, power);

        Console.WriteLine(result);

    }

    private static double PowerNumber(double number, double power)
    {
        return Math.Pow(number, power);
    }

}

