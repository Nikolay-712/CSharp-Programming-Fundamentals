using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        string positiveNum = string.Empty;
        int negativeCounter = 0;

        for (int i = numbers.Count; i > 0; i--)
        {

            if(numbers[i - 1] > 0)
            {
                positiveNum = positiveNum + numbers[i - 1] + " ";
            }
            else
            {
                negativeCounter++;
            }

            if (negativeCounter == numbers.Count)
            {
                Console.WriteLine("empty");
            }

        }

        Console.WriteLine(string.Join(" ", positiveNum));






    }
}
