using System;

public class Test
{
    public static void Main()
    {
        int counter = int.Parse(Console.ReadLine());
        PrintSquare(counter);
    }

    static void PrintHeaderRow(int n)
    {
        Console.WriteLine(new string('-', 2 * n));
    }

    static void PrintMiddleRow(int n)
    {
        Console.Write('-');
        for (int i = 1; i < n; i++)
        {
            Console.Write("\\/");
        }
        Console.WriteLine('-');
    }

    static void PrintSquare(int n)
    {
        PrintHeaderRow(n);
        for (int i = 0; i < n - 2; i++)
        {
            PrintMiddleRow(n);
        }

        PrintHeaderRow(n);
    }
}

