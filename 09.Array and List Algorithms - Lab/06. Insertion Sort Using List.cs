using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        
        string sort = string.Empty;
        string result = string.Empty;

        while (numbers.Count != 0)
        {
            int smallNumber = int.MaxValue;

            smallNumber = CheckSmallNumber(numbers, smallNumber);

            result = result + smallNumber + " "; 

        }

        Console.WriteLine(result);

       

    }

    private static int CheckSmallNumber(List<int> numbers, int smallNumber)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (smallNumber > numbers[i])
            {
                smallNumber = numbers[i];
            }

        }

        numbers.Remove(smallNumber);

        return smallNumber;
    }

}
