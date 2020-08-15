using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
        

        for (int i = 0; i < numbers.Count; i++)
        {
            try
            {
                double digit = numbers[i];

                i++;

                double nextDigit = numbers[i];

                if (digit == nextDigit)
                {
                    double sum = digit + nextDigit;

                    numbers.Remove(digit);
                    numbers.Insert(i, sum);
                    numbers.Remove(nextDigit);

                    i = 0;
                }


                i--;

               
            }
            catch
            {
                break;
            }
           
        }
        Console.WriteLine(string.Join(" ", numbers));


    }
}
       





           
           