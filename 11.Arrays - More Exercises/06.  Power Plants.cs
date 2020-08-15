using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System;
public class Test
{

    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int days = 1;
        int season = 0;

        while (true)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                int TheDay = i;

                if (TheDay == i)
                {
                    if (numbers[i] > 0)
                    {
                        numbers[i] = numbers[i] + 1;
                    }
                   
                }
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[j] > 0)
                    {
                        numbers[j] = numbers[j] - 1;
                    }
                    
                }

                if (numbers.Max() > 0) 
                {
                    days++;
                }
               
            }
            if (numbers.Max() == 0)
            {
                break;
            }
            season++;

            for (int j = 0; j < numbers.Count; j++)
            {
                if (numbers[j] > 0)
                {
                    numbers[j] = numbers[j] + 1;
                }

                
            }
        }

        Console.WriteLine($"survived {days} days ({season} season)");

    }
}
