using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        for (int i = 0; i < numbers.Count; i++)
        {
            numbers.Sort();

            Console.Write($"{numbers[i]} <= ");
        }
    }

      
}
       





           
           