using System;

class Test
{
    static void Main()
    {
        var array = Console.ReadLine().Split();
        var rotated = new string[array.Length];

        for (int elements = 0; elements < array.Length - 1; elements++)
        {
            rotated[elements + 1] = array[elements];

            var lastElement = array[rotated.Length - 1];
            rotated[0] = lastElement;
        }
        Console.WriteLine(string.Join(" ", rotated));

    }

}
