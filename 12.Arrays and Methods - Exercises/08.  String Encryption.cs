using System;

class Test
{
    static void Main()
    {
        int counterNubers = int.Parse(Console.ReadLine());

        int LastDigit = 0;
        int FirstDigit = 0;
        string text = string.Empty;

        string code = Encryption(counterNubers, ref LastDigit, ref FirstDigit, ref text);

        Console.WriteLine(code);
    }

    private static string Encryption(int counterNubers, ref int LastDigit, ref int FirstDigit, ref string text)
    {
        for (int position = 0; position < counterNubers; position++)
        {
            char symbol = char.Parse(Console.ReadLine());

            int chartoInt = (int)symbol;

            if (chartoInt < 100)
            {
                LastDigit = (chartoInt % 10);
                FirstDigit = (chartoInt / 10);
            }
            else
            {
                LastDigit = (chartoInt % 10);
                FirstDigit = 1;
            }

            int sumLastDigit = chartoInt + LastDigit;
            int sumFirstDigit = chartoInt - FirstDigit;

            char cryptSymbol = (char)sumLastDigit;
            char cryptSymbol1 = (char)sumFirstDigit;



            text = text + $"{cryptSymbol}{FirstDigit}{LastDigit}{cryptSymbol1}";
            
        }
        return text;
    }


}

