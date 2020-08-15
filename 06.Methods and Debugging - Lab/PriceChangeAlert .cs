using System;

public class Test
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int Evensum = 0;
        int OddSum = 0;
        int result = 0;

        GetEvenandOddSum( number,  Evensum,  OddSum , result);

       
    }

    private static void GetEvenandOddSum( int number,  int Evensum,  int OddSum, int result)
    {
        while (number != 0)
        {
            int lastDigits = Math.Abs(number % 10);

            if (lastDigits % 2 == 0)
            {
                Evensum = Evensum + lastDigits;
            }
            number = number / 10;

            if (lastDigits % 2 != 0)
            {
                OddSum = OddSum + lastDigits;
            }

            result = Math.Abs(Evensum * OddSum);

        }
        Console.WriteLine(result);
    }
}

