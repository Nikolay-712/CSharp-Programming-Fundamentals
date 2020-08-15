using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Test
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int serchElement = int.Parse(Console.ReadLine());

        int Linear = 0;
        int Binary = 0;

        Linear = LinearSerchCount(numbers, serchElement, Linear);
        Binary = BinarySerchCount(numbers, serchElement, Binary);

        if (numbers.Contains(serchElement))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }


        Console.WriteLine($"Linear search made {Linear} iterations");
        Console.WriteLine($"Binary search made {Binary} iterations");

    }

    private static int LinearSerchCount(int[] numbers, int serchElement, int Linear)
    {
        foreach (var item in numbers)
        {
            Linear++;
            if (item == serchElement)
            {
                break;
            }

        }
        return Linear;
    }
    private static int BinarySerchCount(int[] numbers, int serchElement, int Binary)
    {
        var SortNumbers = numbers.ToList(); SortNumbers.Sort();

        int lowerBound = 0;
        int upperBound = SortNumbers.Count;

        while (true)
        {
            Binary++;
            if (upperBound < lowerBound)
            {
                return Binary;
            }

            int Midel = lowerBound + (upperBound - lowerBound) / 2;

            if (SortNumbers[Midel] < serchElement)
            {
                lowerBound = Midel + 1;
            }
            if (SortNumbers[Midel] > serchElement)
            {
                upperBound = Midel - 1;
            }
            if (SortNumbers[Midel] == serchElement)
            {
                return Binary;
            }
        }




    }
}
