using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int checkNumber = int.Parse(Console.ReadLine());
        string theSameNumber = string.Empty;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == checkNumber)
            {
                theSameNumber = "yes";
                break;
            }
            else
            {
                theSameNumber = "no";
            }
        }

        Console.WriteLine(theSameNumber);

    }
}
