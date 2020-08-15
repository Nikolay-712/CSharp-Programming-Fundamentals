using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        List<int> frequence = Console.ReadLine().Split(' ', ',').Select(int.Parse).ToList();
        List<string> text = new List<string>();

        string leftSide = string.Empty;
        string rightSide = string.Empty;

        int counter = 0;

        

        for (int firstIndex = 0; firstIndex < frequence.Count; firstIndex++)
        {
            if (frequence[firstIndex] == 0)
            {
                continue;
            }

             char code = Convert.ToChar(frequence[firstIndex]);

            if (firstIndex % 2 == 0)
            {
                leftSide = leftSide + code;
            }
            else
            {
                rightSide = code + rightSide;
            }
            

        }

       

        Console.WriteLine(leftSide + rightSide);


       



    }


}
