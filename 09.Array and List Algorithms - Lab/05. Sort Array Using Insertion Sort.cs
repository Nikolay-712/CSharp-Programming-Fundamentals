using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        string sort = SortNumbers(numbers).ToString();

        Console.WriteLine(string.Join(" ",numbers));
      
    }

    static int [] SortNumbers (int[] numbers)
    {
        for(int i = 0; i < numbers.Length - 1; i++)
    {
            for (int j = i + 1; j > 0; j--)
            {
                if (numbers[j - 1] > numbers[j])
                {
                    int temp = numbers[j - 1];
                    numbers[j - 1] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }
        return numbers;
    }
   
    
}
