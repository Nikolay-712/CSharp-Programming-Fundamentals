using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{

    public static void Main()
    {
        SortedDictionary<double, int> numbers = new SortedDictionary<double, int>();

        List<double> input = Console.ReadLine().Split(' ')
            .Select(double.Parse).ToList();

        foreach (var item in input)
        {
            if (numbers.ContainsKey(item))
            {
                numbers[item]++;
            }
            else
            {
                numbers[item] = 1;
            }
        }

        string result = string.Empty;

        foreach (var item in numbers)
        {
            result = (item.Key).ToString() + " "+ "->" + " " + (item.Value).ToString();
           

            Console.WriteLine($"{result}");
        }

       
      
    }
}
    


