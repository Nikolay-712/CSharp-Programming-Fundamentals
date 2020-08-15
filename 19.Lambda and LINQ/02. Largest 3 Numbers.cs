using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        var lastDigits = numbers.OrderByDescending(x => x).Take(3).ToList();

        Console.WriteLine(string.Join(" ", lastDigits));

    }








}
