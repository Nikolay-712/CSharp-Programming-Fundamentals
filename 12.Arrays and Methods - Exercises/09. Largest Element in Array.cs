using System;

class Test
{
    static void Main()
    {
        int counterNubers = int.Parse(Console.ReadLine());
        int[] array = new int[counterNubers];

        int maxNumber = int.MinValue;

        maxNumber = GetMaxDigit(array, maxNumber);
        Console.WriteLine(maxNumber);


    }

    private static int GetMaxDigit(int[] array, int maxNumber)
    {
        for (int elements = 0; elements < array.Length; elements++)
        {
            array[elements] = int.Parse(Console.ReadLine());

            if (array[elements] > maxNumber)
            {
                maxNumber = array[elements];
            }

        }

        return maxNumber;
    }
}

