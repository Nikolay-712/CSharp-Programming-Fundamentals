using System;
using System.Linq;

class Test
{
    static void Main()
    {
        string[] text = Console.ReadLine().Split();

        var single = text.Where(s => s.Length == 1).ToArray();
        int counter = 0;

        foreach (var item in single)
        {
            var chars = char.Parse(item);

            if (char.IsUpper(chars))
            {
                counter++;
            }
        }
        Console.WriteLine(counter);

    }
}

