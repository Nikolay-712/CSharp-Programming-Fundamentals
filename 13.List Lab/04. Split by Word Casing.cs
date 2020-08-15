using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        List<string> text = Console.ReadLine().Split(new char[]
            { ' ', ';', ',', '.', ':', '!', '(', ')', '\'', '"', '\\', '/', '[', ']' }).ToList();

        string LowerCase = string.Empty;
        string MixedCase = string.Empty;
        string UpperCase = string.Empty;

        for (int i = 0; i < text.Count; i++)
        {

            if (text[i].All(char.IsLower))
            {
                LowerCase = LowerCase + string.Join(", ", text[i]);
            }
           else if (text[i].All(char.IsUpper))
            {
                UpperCase = UpperCase + string.Join(", ", text[i]);
            }
            else
            {
                MixedCase = MixedCase + string.Join(", ", text[i]);


            }
            
        }
        Console.WriteLine($"Lower-case:  {LowerCase} ");
        Console.WriteLine($"Mixed-case: {MixedCase} ");
        Console.WriteLine($"Upper-case: {UpperCase} ");
    }
}
       





           
           