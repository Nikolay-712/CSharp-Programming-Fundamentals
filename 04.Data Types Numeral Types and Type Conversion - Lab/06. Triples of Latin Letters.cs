using System;

public class Test
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int first = 0; first < n; first++)
        {
            for (int second = 0; second < n; second++)
            {
                for (int tree = 0; tree < n; tree++)
                {
                    char symbol = (char)('a' + first);
                    char symbol1 = (char)('a' + second);
                    char symbol2 = (char)('a' + tree);

                    Console.WriteLine($"{symbol}{symbol1}{symbol2}");
                }
            }

        }
    }
}