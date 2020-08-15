using System;
using System.Linq;

class Test
{
    static void Main()
    {
        string[] text = Console.ReadLine().Split();

        // var len = text.Length;

        string chekcFirst = string.Empty;
        var checkSecond = string.Empty;

        CheckForTheSame(text, ref chekcFirst, ref checkSecond);

        if (chekcFirst == checkSecond)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }


    }

    private static void CheckForTheSame(string[] text, ref string chekcFirst, ref string checkSecond)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (i == 0)
            {
                chekcFirst = text[i];
            }
            if (i == text.Length - 1)
            {
                checkSecond = text[i];
            }


        }
    }
}

