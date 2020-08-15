using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        List<int> firstNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> secondNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
       

        int sumFromFirst = 0;
        int sumFromSecond = 0;

        for (int i = 0; i < firstNumbers.Count; i++)
        {
            sumFromFirst = sumFromFirst + firstNumbers[i];

        }

            for (int j = 0; j < secondNumbers.Count; j++)
            {
                

                bool theSameNumbers = firstNumbers.Contains(secondNumbers[j]);

                if (!theSameNumbers)
                {
                    sumFromSecond = sumFromSecond + secondNumbers[j];

                }
               

            }

        if (sumFromFirst == sumFromSecond)
        {
            Console.WriteLine($"Yes. Sum: {sumFromSecond}");
        }
        else
        {
           
            Console.WriteLine($"No Diff: { Math.Abs(sumFromSecond - sumFromFirst)}");
        }
        {

        }
        }

    } 
        



        
      


           