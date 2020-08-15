using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {

        List<int> numbers = new List<int>();

        string input = Console.ReadLine();

        int lastShotNumbers = 0;

        while (true)
        {
            if (input == "Bang")
            {
                if (numbers.Count == 0)
                {
                    Console.WriteLine("nobody left to shoot! last one was " + lastShotNumbers);

                    break;
                }

                double average = numbers.Average();
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (average > numbers[i])
                    {
                        lastShotNumbers = numbers[i];
                        numbers.RemoveAt(i);
                        Console.WriteLine("shot " + lastShotNumbers);

                        break;
                    }
                    else if(numbers.Count == 1)
                    {
                        lastShotNumbers = numbers[0];
                        numbers.RemoveAt(0);
                        Console.WriteLine("shot " + lastShotNumbers);

                        break;
                    }
                }

                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i]--;
                }
            }
            else if(input == "Stop")
            {
                if (numbers.Count == 0)
                {
                    Console.WriteLine("you shot them all. last one was " + lastShotNumbers);
                    break;
                }
                else
                {
                    Console.WriteLine($"survivors: {string.Join(" ",numbers)}");
                    break;
                }

            }
            else
            {
                int number = int.Parse(input);
                numbers.Insert(0, number);
            }

            input = Console.ReadLine();


        }

    }


}
