using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        List<string> Numbers = Console.ReadLine().Split(' ').ToList();


        int theNum = 0;
        int lastDigit = 0;
        int firstDigit = 0;
        int counter = 0;

        string result = string.Empty;


        List<int> newNumbers = new List<int>();

        for (int i = 0; i < Numbers.Count; i++)
        {
            int count = Numbers.Count / 2;

            if (i >= count)
            {
                theNum =int.Parse( Numbers[i]);

                lastDigit = theNum % 10;
                firstDigit = theNum / 10;

                for (int j = 0; j < Numbers.Count / 2;  )
                {
                    j = counter;

                    newNumbers.Add(firstDigit);
                    newNumbers.Add (int.Parse(Numbers[j]));
                    newNumbers.Add(lastDigit);

                    result = result + newNumbers;
                    
                    counter++;
                    
                    break;
                    
                }
               
            }
        }

        Console.WriteLine(string.Join(" ", newNumbers));


    }
}

