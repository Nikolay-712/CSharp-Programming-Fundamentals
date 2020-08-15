using System;

public class Test
{
    public static void Main()
    {
        var type = Console.ReadLine();

        switch(type)
        {
            case "int":
                int number = int.Parse(Console.ReadLine());
                int number1 = int.Parse(Console.ReadLine());

                GetMaxInteger(number, number1);
                break;

            case "char":
                char symbol = char.Parse(Console.ReadLine());
                char symbol1 = char.Parse(Console.ReadLine());

                GetMaxCharekter(symbol, symbol1);

                break;

            case "string":
                string word = Console.ReadLine();
                string word1 = Console.ReadLine();

                GetMaxString(word, word1);
                break;
        }

    }

    private static void GetMaxString(string word, string word1)
    {
        if (word.Equals(word1))
        {
            Console.WriteLine(word);
        }
        else
        {
            Console.WriteLine(word1);
        }
    }

    private static void GetMaxCharekter(char symbol, char symbol1)
    {
        if (symbol > symbol1)
        {
            Console.WriteLine(symbol);
        }
        else
        {
            Console.WriteLine(symbol1);
        }
    }

    private static void GetMaxInteger(int number, int number1)
    {
        if (number > number1)
        {
            Console.WriteLine(number);
        }
        else
        {
            Console.WriteLine(number1);
        }
    }
}

