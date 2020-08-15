using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        int cntNumbers = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>();


        for (int i = 0; i < cntNumbers; i++)
        {
            int num = int.Parse(Console.ReadLine());

            numbers.Add(num);

        }

        int sumOfNumbers = numbers.Sum();
        int minNumber = numbers.Min();
        int maxNumber = numbers.Max();
        double averege = numbers.Average();

        Console.WriteLine($"Sum = {sumOfNumbers}");
        Console.WriteLine($"Min = {minNumber}");
        Console.WriteLine($"Max = {maxNumber}");
        Console.WriteLine($"Average = {averege}");


    }








}
