using System;

public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            int digitsSum = 0;
            int digits = i;

            while(digits > 0)
            {
                digitsSum = digitsSum + digits % 10;
                digits = digits / 10;
            }
            bool special = (digitsSum == 5 || digitsSum == 7 || digitsSum == 11);
            Console.WriteLine($"{i} => {special}");
        }
    }
}