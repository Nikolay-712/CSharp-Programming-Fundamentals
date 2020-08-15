using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Test
{

    public static void Main()
    {
          List<int> numbers = Console.ReadLine().Split(' ').Select(int
            .Parse).ToList();

        string comand = Console.ReadLine();
        double avg = numbers.Average();

        numbers = numbers.Where(x => x >= avg).ToList();

        if (comand == "All")
        {
            Console.WriteLine(string.Join(" ", numbers.OrderBy(x => x)));

        }
        else if (comand == "Min")
        {
            Console.WriteLine(string.Join(" ", numbers.Min()));
        }
        else
        {
            Console.WriteLine(string.Join(" ", numbers.Max()));
        }

    }


}
