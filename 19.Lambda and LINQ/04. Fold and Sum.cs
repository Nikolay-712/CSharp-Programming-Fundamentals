using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int k = numbers.Length / 4;

        int[] rowLeft = numbers.Take(k).Reverse().ToArray();
        int[] rowRight = numbers.Reverse().Take(k).ToArray();

        int[] firstRow = rowLeft.Concat(rowRight).ToArray();

        int[] inSidePart = numbers.Skip(k).Take(k).ToArray();


        int[] inSidePart2 = numbers.Skip(k * 2).Reverse().Skip(k).Take(k).Reverse().ToArray();

        int[] secondRow = inSidePart.Concat(inSidePart2).ToArray();


        for (int i = 0; i < firstRow.Length; i++)
        {
            firstRow[i] = firstRow[i] + secondRow[i];

        }
        Console.WriteLine(string.Join(" ", firstRow));

    }

}









