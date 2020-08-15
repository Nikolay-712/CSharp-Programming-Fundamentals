using System;

class Test
{
    static void Main(string[] args)
    {
        char firstChar = char.Parse(Console.ReadLine());
        char secondChar = char.Parse(Console.ReadLine());

        char noPrint = char.Parse(Console.ReadLine());

        char combination = ' ';

        for (char first = firstChar; first <= secondChar; first++)
        {
            for (char second = secondChar; second <= secondChar; second++)
            {
                Console.Write($"{first} {second}");
               

            }
            
        }
        Console.WriteLine();

    }

    }
