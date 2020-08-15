using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

        numbers.Sort();
        numbers.Reverse();
        string SquaerNumbers = string.Empty;

        for (int i = 0; i < numbers.Count; i++)
        {
           
            if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt((numbers[i])))
            {

                SquaerNumbers = SquaerNumbers + numbers[i] + " ";
            }     
        }
        Console.WriteLine(string.Join(" " ,SquaerNumbers));
    }

      
}
       





           
           