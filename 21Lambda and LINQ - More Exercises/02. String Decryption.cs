using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Test
{

    public static void Main()
    {

        List<int> replece = Console.ReadLine().Split(' ')
            .Select(int.Parse).ToList();

        int removeNum = replece[0];
        int pasteNum = replece[1];


        List<int> numbers = Console.ReadLine().Split(' ').Select(int
          .Parse).ToList();

        numbers = numbers.Where(x => x >= 65 && x <= 90)
            .Skip(removeNum).Take(pasteNum).ToList();

        foreach (var item in numbers)
        {
            Console.WriteLine((char)item);
        }
    }


}
