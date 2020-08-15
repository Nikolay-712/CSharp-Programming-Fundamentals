using System;

public class Test
{
    public static void Main()
    {

        int n = int.Parse(Console.ReadLine());
       

        for (int i = 1; i <= n; i++)
        {
            int SumDigits = 0;
            int Digits = i;
            

            while (Digits > 0)
            {
                SumDigits = SumDigits + Digits % 10;
                Digits = Digits / 10;
            }
           
            bool special = ((SumDigits == 5) || (SumDigits == 7) || SumDigits == 11);
            Console.WriteLine($"{i} -> {special}");


        }

    }
}