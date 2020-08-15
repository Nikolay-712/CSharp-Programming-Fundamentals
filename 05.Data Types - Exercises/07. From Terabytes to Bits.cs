using System;

public class Test
{
    public static void Main()
    {
        decimal TB = decimal.Parse(Console.ReadLine());

        decimal oneTB = 8796093022208m;

        decimal bytes = (TB * oneTB);

        Console.WriteLine(Math.Round(bytes));





    }
}
    
