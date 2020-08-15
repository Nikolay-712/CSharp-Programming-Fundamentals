using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Test
{
    public static void Main()
    {
        Regex ValidString = new Regex(@"^[A-Z].*[.!?]");
        List<string> Word = new List<string>();

        string Filter = Console.ReadLine();
        string Input = Console.ReadLine();

        char Symbol = Filter[0];
        int Digit = int.Parse(Filter[1].ToString());

        while (Input != "end")
        {
            if (ValidString.IsMatch(Input))
            {
                Regex word = new Regex(@"[a-zA-Z]+");
                MatchCollection match = word.Matches(Input);

                foreach (Match item in match)
                {
                    int repetition = 0;

                    string TheWord = item.Value;
                    for (int i = 0; i < TheWord.Length; i++)
                    {
                        if (TheWord[i] == Symbol)
                        {
                            repetition++;

                        }
                    }


                    if (repetition == Digit)
                    {
                        Word.Add(TheWord);
                        
                    }
                } 
               
            }

            Input = Console.ReadLine();
        }

        Console.WriteLine(string.Join(", ",Word));
    }
}
