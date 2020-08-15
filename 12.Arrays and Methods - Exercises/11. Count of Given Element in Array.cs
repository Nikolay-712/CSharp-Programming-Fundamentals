using System;

class Test
{
    static void Main()
    {
        var counterNumbers = (Console.ReadLine().Split());
        int[] array = new int[counterNumbers.Length];
        int theNumber = int.Parse(Console.ReadLine());
        int counter = 0;

        counter = GetTheSameDigits(counterNumbers, array, theNumber, counter);
        Console.WriteLine(counter);


    }

    private static int GetTheSameDigits(string[] counterNumbers, int[] array, int theNumber, int counter)
    {
        for (int elements = 0; elements < array.Length; elements++)
        {
            array[elements] = int.Parse(counterNumbers[elements]);

            if (array[elements] == theNumber)
            {
                counter++;
            }

        }

        return counter;
    }






}


