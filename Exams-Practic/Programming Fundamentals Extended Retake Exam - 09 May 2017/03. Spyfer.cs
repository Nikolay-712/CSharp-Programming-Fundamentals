using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Test
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split()
            .Select(int.Parse).ToList();

        List<int> tokens = new List<int>();


        for (int i = 0; i < numbers.Count; i++)
        {
            tokens.Add(numbers[i]);

            if (tokens.Count == 3)
            {
                if (tokens[0] + tokens[2] == tokens[1])
                {
                    numbers.RemoveAt(i);
                    numbers.RemoveAt(i - 2);

                    i = -1;
                    tokens.Clear();
                    continue;
                }

                if (MoreCombination(numbers, i))
                {
                    numbers.Reverse();
                    i = -1;
                }

                tokens.Clear();
            }


        }
        if (numbers.Count == 2)
        {
            numbers.Reverse();
        }

        Console.WriteLine(string.Join(" ", numbers));


    }

    private static bool MoreCombination(List<int> numbers, int i)
    {
        if (numbers.Count == 4 && i == numbers.Count - 2)
        {

            return true;
        }
        else
        {
            return false;
        }
    }


}