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
        int[] numbers = Console.ReadLine().Split(' ').Select(int
            .Parse).ToArray();
        string[] comand = Console.ReadLine().Split(' ').ToArray();

        while (comand[0] != "end")
        {
            List<int> OddElements = new List<int>();
            List<int> EvenElements = new List<int>();

            switch (comand[0])
            {
                case "exchange":

                    int index = int.Parse(comand[1]);
                    numbers = Exchange(numbers, index);
                    break;

                case "max":

                    string TypeMax = comand[1];
                    CeckOddAndEvenDigits(numbers, OddElements, EvenElements);
                    PrintPositionOddIndex(numbers, TypeMax, OddElements);
                    PrintPositionEvenIndex(numbers, TypeMax, EvenElements);
                    break;

                case "min":

                    string TypeMin = comand[1];
                    CeckOddAndEvenDigits(numbers, OddElements, EvenElements);
                    PrintMinEvenPosition(numbers, TypeMin, EvenElements);
                    PrintMinOddPosition(numbers, TypeMin, OddElements);

                    break;

                case "first":
                    int FirstIndex = int.Parse(comand[1]);
                    string TypeNumberFirst = comand[2];
                    CeckOddAndEvenDigits(numbers, OddElements, EvenElements);

                    PrintFirstOddElements(numbers, OddElements, FirstIndex, TypeNumberFirst);
                    PrintFirstEvenElements(numbers, EvenElements, FirstIndex, TypeNumberFirst);
                    break;

                case "last":
                    int LastIndex = int.Parse(comand[1]);
                    string TypeNumberLast = comand[2];
                    CeckOddAndEvenDigits(numbers, OddElements, EvenElements);

                    PrindLastOddNumbers(numbers, OddElements, LastIndex, TypeNumberLast);

                    PrintLastEvenNumbers(numbers, OddElements, EvenElements, LastIndex, TypeNumberLast);

                    break;
            }

            comand = Console.ReadLine().Split(' ').ToArray();

        }

        Console.WriteLine($"[{string.Join(", ",numbers)}]");
    }

    private static void PrintLastEvenNumbers(int[] numbers, List<int> OddElements, List<int> EvenElements, int LastIndex, string TypeNumberLast)
    {
        if (TypeNumberLast == "even")
        {
            if (EvenElements.Count <= 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                if (LastIndex <= numbers.Length)
                {
                    List<int> LastEvenElements = new List<int>();
                    for (int i = OddElements.Count - 1; i >= 0; i--)
                    {
                        if (LastIndex == i + 1)
                        {
                            break;

                        }

                        LastEvenElements.Add(EvenElements[i]);


                    }

                    Console.WriteLine($"[{string.Join(", ", LastEvenElements)}]");
                }
                else
                {
                    Console.WriteLine("Invalid count");
                }

            }

        }
    }

    private static void PrindLastOddNumbers(int[] numbers, List<int> OddElements, int LastIndex, string TypeNumberLast)
    {
        if (TypeNumberLast == "odd")
        {
            if (OddElements.Count <= 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                if (LastIndex <= numbers.Length)
                {
                    List<int> LastOddElements = new List<int>();
                    for (int i = OddElements.Count - 1; i >= 0; i--)
                    {
                        if (LastIndex == i + 1)
                        {
                            break;

                        }
                        LastOddElements.Add(OddElements[i]);
                    }

                    Console.WriteLine($"[{string.Join(", ", LastOddElements)}]");
                }
                else
                {
                    Console.WriteLine("Invalid count");
                }

            }

        }
    }

    private static void PrintFirstEvenElements(int[] numbers, List<int> EvenElements, int FirstIndex, string TypeNumberFirst)
    {
        if (TypeNumberFirst == "even")
        {
            if (EvenElements.Count <= 0)
            {
                Console.WriteLine($"[]");

            }
            else
            {
                if (FirstIndex <= numbers.Length)
                {
                    var FirstEvenElements = EvenElements.Take(FirstIndex).ToArray();
                    Console.WriteLine($"[{string.Join(", ", FirstEvenElements)}]");
                }
                else
                {
                    Console.WriteLine("Invalid count");
                }

            }
        }
    }

    private static void PrintFirstOddElements(int[] numbers, List<int> OddElements, int FirstIndex, string TypeNumberFirst)
    {
        if (TypeNumberFirst == "odd")
        {
            if (OddElements.Count <= 0)
            {
                Console.WriteLine($"[]");

            }
            else
            {
                if (FirstIndex <= numbers.Length)
                {
                    var FirstoddElements = OddElements.Take(FirstIndex).ToArray();
                    Console.WriteLine($"[{string.Join(", ", FirstoddElements)}]");
                }
                else
                {
                    Console.WriteLine("Invalid count");
                }

            }

        }
    }

    private static void PrintMinOddPosition(int[] numbers, string TypeMin, List<int> OddElements)
    {
        if (TypeMin == "odd")
        {
            int MinOddIndexPosition = 0;

            if (OddElements.Count <= 0)
            {
                Console.WriteLine("No matches");

            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (OddElements.Min() == numbers[i])
                    {
                        MinOddIndexPosition = i;

                    }

                }

                Console.WriteLine(MinOddIndexPosition);
            }
        }
    }

    private static void PrintMinEvenPosition(int[] numbers, string TypeMin, List<int> EvenElements)
    {
        if (TypeMin == "even")
        {
            int MinEvenIndexPosition = 0;

            if (EvenElements.Count <= 0)
            {
                Console.WriteLine("No matches");

            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (EvenElements.Min() == numbers[i])
                    {
                        MinEvenIndexPosition = i;

                    }

                }

                Console.WriteLine(MinEvenIndexPosition);
            }

        }
    }

    private static void PrintPositionEvenIndex(int[] numbers, string TypeMax, List<int> EvenElements)
    {
        if (TypeMax == "even")
        {
            int MaxEvenIndexPosition = 0;

            if (EvenElements.Count <= 0)
            {
                Console.WriteLine("No matches");

            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (EvenElements.Max() == numbers[i])
                    {
                        MaxEvenIndexPosition = i;

                    }

                }

                Console.WriteLine(MaxEvenIndexPosition);
            }


        }
    }

    private static void PrintPositionOddIndex(int[] numbers, string TypeMax, List<int> OddElements)
    {
        if (TypeMax == "odd")
        {
            int MaxOdd = OddElements.Max();
            int MaxOddIndexPosition = 0;

            for (int i = 0; i < numbers.Length; i++)
            {

                if (OddElements.Count <= 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    if (MaxOdd == numbers[i])
                    {
                        MaxOddIndexPosition = i;
                    }
                }
            }

            Console.WriteLine(MaxOddIndexPosition);

        }
    }

    private static void CeckOddAndEvenDigits(int[] numbers, List<int> OddElements, List<int> EvenElements)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                EvenElements.Add(numbers[i]);
            }
            else
            {
                OddElements.Add(numbers[i]);

            }
        }
    }

    private static int[] Exchange(int[] numbers, int index)
    {
        if (index > numbers.Length - 1 || index < 0)
        {
            Console.WriteLine("Invalid index");
            return numbers;
        }
        else
        {
            int[] FirstPart = numbers.Skip(index + 1).ToArray();
            int[] LastPart = numbers.Take(index + 1).ToArray();

            numbers = FirstPart.Concat(LastPart).ToArray();

        }

        return numbers;
    }
}