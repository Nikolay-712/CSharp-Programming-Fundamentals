using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        string revurse = string.Empty;

        revurse = ReverseNumbers(numbers, revurse);

        Console.WriteLine (revurse);





    }

    private static string ReverseNumbers(List<int> numbers, string revurse)
    {
        for (int i = numbers.Count - 1; i >= 0; i--)
        {
            revurse = revurse + numbers[i].ToString() + " ";
        }

        return revurse;
    }
}
