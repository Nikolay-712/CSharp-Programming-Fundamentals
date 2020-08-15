using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        int count = 1;
        numbers.Sort();
        numbers.Add(int.MaxValue);

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            
            if(numbers[i] == numbers[i + 1])
            {
                count++;
            }
            else
            {
                Console.WriteLine($"{numbers[i]} -> {count}");
                count = 1;
            }

         

           


        }
       
        

    }

      
}
       





           
           