using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        List<string> text = Console.ReadLine().Split(' ').ToList();
        int resut = 0;
        int counterChars = 0;

        List<string> newList = new List<string>();

        for (int i = 0; i < text.Count; i++)
        {
            var singleSymbol = text[i].ToCharArray();

            resut = ResultFromCharakters(ref resut, ref
               counterChars, singleSymbol);
            
        }

        for (int i = 0; i < text.Count; i++)
        {
            int sumSymbol = resut / counterChars;
            char lastChar = (char)sumSymbol;

            

            if (i == text.Count - 1)
            {
                newList.Add(text[i]);
            }
            else
            {
                newList.Add(text[i] + Char.ToUpper(lastChar));
            }

            

        }

       
        Console.WriteLine(string.Join("",newList).TrimEnd());

    }

    private static int ResultFromCharakters(ref int resut, ref int counterChars, char[] singleSymbol)
    {
        for (int j = 0; j < singleSymbol.Length; j++)
        {
            counterChars++;
            resut = resut + singleSymbol[j];

        }
        return resut;
    }
}
