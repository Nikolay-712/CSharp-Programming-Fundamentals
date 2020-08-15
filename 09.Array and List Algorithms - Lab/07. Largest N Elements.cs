using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        int chekBigestNumber = int.Parse(Console.ReadLine());

        string bigestNumbers = string.Empty;

        bigestNumbers = CheckTheBigestNumbers(numbers, chekBigestNumber, bigestNumbers);

        Console.WriteLine(bigestNumbers);
    }

    private static string CheckTheBigestNumbers(List<int> numbers, int chekBigestNumber, string bigestNumbers)
    {
        for (int i = 0; i < chekBigestNumber; i++)
        {
            int maxVeliu = int.MinValue;

            for (int j = 0; j < numbers.Count; j++)
            {
                if (maxVeliu < numbers[j])
                {
                    maxVeliu = numbers[j];


                }
            }

            numbers.Remove(maxVeliu);
            bigestNumbers = bigestNumbers + maxVeliu + " ";


        }

        return bigestNumbers;
    }

}
