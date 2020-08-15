using System;

class Test
{
    static void Main()
    {
        string name = GetName();

        Console.WriteLine($"Hello, {name}!");

    }

    private static string GetName()
    {
        return Console.ReadLine();
    }





}
