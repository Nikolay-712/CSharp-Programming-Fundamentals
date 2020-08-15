using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        List<string> text = Console.ReadLine().Split(' ').ToList();

        List<double> numbers = new List<double>();
        List<string> world = new List<string>();

        List<string> newList = new List<string>();

        string resultNum = string.Empty;
        string resultWor = string.Empty;

        for (int i = 0; i < text.Count; i++)
        {
            while (i != text.Count)
            {
                try
                {
                    double num = double.Parse(text[i]);
                    numbers.Add(num);
                }
                catch
                {
                    world.Add(text[i]);
                }

                i++;

            }

        }
        
            world.Sort();


        resultNum = SortNumbers(numbers, resultNum);

        newList.Add(string.Join(" ", world));
        newList.Add(resultNum);
        

        Console.WriteLine(string.Join(" ", newList));

    }



    private static string SortNumbers(List<double> numbers, string resultNum)
    {
        while (numbers.Count != 0)
        {
            double minVeleu = double.MaxValue;
            double sort = checkMinNumber(numbers, minVeleu);

            resultNum = resultNum + sort + " ";
        }

        return resultNum.TrimEnd(' ');
    }

    private static double checkMinNumber(List<double> numbers, double minVeleu)
    {
        for (int position = 0; position < numbers.Count; position++)
        {

            if (minVeleu > numbers[position])
            {
                minVeleu = numbers[position];
            }
        }
        numbers.Remove(minVeleu);
        return minVeleu;
    }
}
