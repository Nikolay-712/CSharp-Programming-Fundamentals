using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        int space = int.Parse(Console.ReadLine());

        int counterRound = 0;

        for (int i = 0; i < numbers.Count; i++)
        {

            if (i == 0 && numbers.Count == space) 
            {
                Console.WriteLine("already stable: " + string.Join(" ",numbers));
                break;
            }
          
           if(i == 0)
            {
                numbers.Remove(numbers[i]);
            }

            numbers.Reverse();

            numbers.Remove(numbers[i]);

            numbers.Reverse();
            counterRound++;

            if (numbers.Count == space)
            {
                Console.WriteLine($"{counterRound} rounds");
                Console.WriteLine("remaining: " + string.Join(" ", numbers));

                break;
            }

            i = -1;

           
        }
       
    }
     
}
