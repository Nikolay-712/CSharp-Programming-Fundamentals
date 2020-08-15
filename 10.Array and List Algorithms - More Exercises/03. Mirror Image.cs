using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Test
{
    public static void Main()
    {
        List<string> numbers = Console.ReadLine().Split(' ').ToList();
        string index = (Console.ReadLine());


        while (index != "Print")
        {

            int Index = int.Parse(index);

            var PartOnIndex = numbers[Index];
            var FirstPart = numbers.Take(Index).Reverse();
            var SecondPart = numbers.Skip(Index + 1).Reverse();

            numbers = FirstPart.ToList();
            numbers.Add(PartOnIndex);
            numbers = numbers.Concat(SecondPart).ToList();

            index = (Console.ReadLine());
        }

        Console.WriteLine(string.Join(" ",numbers));


    }
}
