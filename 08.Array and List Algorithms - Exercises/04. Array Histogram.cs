using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        List<string> input = Console.ReadLine().Split(' ').ToList();

        List<string> theSameStrings = new List<string>();
        List<int> Counter = new List<int>();

        List<string> list = new List<string>();

       
        int count = 0;
        int sum = 0;

        for (int i = 0; i < input.Count; i++)
        {
            

            string word = input[i];

            if (input.Contains(word))
            {
                theSameStrings.Add(word);

                count = input.RemoveAll(a => a == word);

                Counter.Add(count);

                sum = sum + count;
            }

            i = -1;

        }

        for (int sort = 0; sort < Counter.Count - 1; sort++)
        {
            var index = sort + 1;

            while(index > 0)
            {
                if (Counter[index - 1] < Counter[index])
                {
                    int tempCount = Counter[index];
                    Counter[index] = Counter[index - 1];
                    Counter[index - 1] = tempCount;



                    string tempString = theSameStrings[index];
                    theSameStrings[index] = theSameStrings[index - 1];
                    theSameStrings[index - 1] = tempString;

                }

                index--;
            }

           
        }

        for (int i = 0; i < theSameStrings.Count; i++)
        {
            int rate = (Counter[i] / sum) * 100;

            Console.WriteLine($"{theSameStrings[i]} -> {Counter[i]} " +
                $"({sum:F2}%)");
        }






    }

    



}
