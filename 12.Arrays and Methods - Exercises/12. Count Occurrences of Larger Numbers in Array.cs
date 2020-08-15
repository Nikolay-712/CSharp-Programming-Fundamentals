using System;

class Test
{
    static void Main()
    {
        var counterNumbers = (Console.ReadLine().Split());
        double[] array = new double[counterNumbers.Length];
        double border = double.Parse(Console.ReadLine());
        int counter = 0;

        counter = BigestFromBorder(counterNumbers, array, border, counter);
        Console.WriteLine(counter);

    }

    private static int BigestFromBorder(string[] counterNumbers, double[] array, double border, int counter)
    {
        for (int elements = 0; elements < array.Length; elements++)
        {
            array[elements] = double.Parse(counterNumbers[elements]);

            if (array[elements] > border)
            {
                counter++;
            }
        }

        return counter;
    }

}
