using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        List<int> firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        List<int> newNumbers = new List<int>();
        int counter = 0;
        string result = string.Empty;


        for (int i = 0; i < secondNumbers.Count; i++)
        {
            if (secondNumbers[i] > 10)
            {
                secondNumbers.RemoveAt(secondNumbers[secondNumbers.Count]);
            }

            newNumbers.Add(secondNumbers[i]);



            for (int j = 0; j < firstNumbers.Count; j++)
            {
                bool ignor = firstNumbers[i] > 10;

                
                j = counter;

                if (firstNumbers[j] > 10)
                {
                    firstNumbers.RemoveAt(firstNumbers[j]);
                }

                newNumbers.Add(firstNumbers[j]);


                counter++;

                break;
            }

        }




    }


}





