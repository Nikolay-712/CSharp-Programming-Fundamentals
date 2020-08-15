using System;

class Test
{
    static void Main()
    {
        int counterNubers = int.Parse(Console.ReadLine());
        int[] array = new int[counterNubers];
        int negativeCounter = 0;

        negativeCounter = Test.negativeCounter(array, negativeCounter);
        Console.WriteLine(negativeCounter);


    }

    private static int negativeCounter(int[] array, int negativeCounter)
    {
        for (int elements = 0; elements < array.Length; elements++)
        {
            array[elements] = int.Parse(Console.ReadLine());

            if (array[elements] < 0)
            {
                negativeCounter++;
            }

        }

        return negativeCounter;
    }



}


