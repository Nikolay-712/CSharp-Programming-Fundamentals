using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[i])
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }
        Console.WriteLine((string.Join(" ", numbers)));

    }
   
    
}
