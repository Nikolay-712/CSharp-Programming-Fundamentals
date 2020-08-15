using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{

    public static void Main()
    {
        Dictionary<char, int> TheChar = new Dictionary<char, int>();
        string input = Console.ReadLine();

        string result = string.Empty;

          //  int count = input.(space => space == string.Empty);

            foreach (var item in input)
            {
                if (TheChar.ContainsKey(item))
                {
                    TheChar[item]++;
                }
                else
                {
                    TheChar[item] = 1;
                }
               
            }

        

        foreach (var item in TheChar)
        {
            var resultKey = item.Key;
            var resultVeleu = item.Value;


            Console.WriteLine($"{resultKey} -> {resultVeleu}");


        }




    }
}
    


