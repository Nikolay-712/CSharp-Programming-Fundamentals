using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        List < string > parts = Console.ReadLine().Split('|').ToList();

        string result = string.Empty;

        for (int i = parts.Count; i > 0; i--)
        {
           
            string[] chekParts = parts[i - 1].Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries).ToArray();


            for (int j = 0; j < chekParts.Length; j++)
            {
                int numberInOnePart = int.Parse(chekParts[j]);

                if(numberInOnePart < 0)
                {

                }
                else
                {
                    result = result + chekParts[j] + " ";
                }
               

            }
        }

        Console.WriteLine(result);




    }
}
