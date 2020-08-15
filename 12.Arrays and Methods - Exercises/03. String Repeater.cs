using System;

class Test
{
    static void Main()
    {
        string word = Console.ReadLine();
        int repeat = int.Parse(Console.ReadLine());

        string repeatString = string.Empty;

        repeatString = Repeat(word, repeat, repeatString);
        Console.WriteLine(repeatString);

    }

    private static string Repeat(string word, int repeat, string repeatString)
    {
        for (int counter = 0; counter < repeat; counter++)
        {
            repeatString = repeatString + word;
        }

        return repeatString;
    }
}
