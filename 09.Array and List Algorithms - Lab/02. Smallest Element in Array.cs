using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int theSmallNumber = int.MaxValue;

        for (int i = 0; i < numbers.Length ; i++)
        {
            if (theSmallNumber > numbers[i])
            {
                theSmallNumber = numbers[i];
            }
           
        }

        Console.WriteLine(theSmallNumber);

    }

    
}
