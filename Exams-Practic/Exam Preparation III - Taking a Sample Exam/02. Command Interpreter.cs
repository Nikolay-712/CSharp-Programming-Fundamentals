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
         List<string> numbers = Console.ReadLine().Split(new[] { " " }
         ,StringSplitOptions.RemoveEmptyEntries).ToList();
         List<string> comand = Console.ReadLine().Split(' ').ToList();

        
        while (comand[0] != "end")
        {
           
            switch (comand[0])
            {
                case "reverse":
                    int Start = int.Parse(comand[2]);
                    int Count = int.Parse(comand[4]);

                    if (Start < 0 || Count < 0 || Start + Count >= numbers.Count ||
                        Start > numbers.Count || Count > numbers.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        var FirstPart = numbers.Take(Start);
                        var token = numbers.Skip(Start).Take(Count).Reverse();
                        var LastPart = numbers.Skip(Start + Count);

                        numbers = FirstPart.Concat(token.Concat(LastPart)).ToList();
                    }
                    break;
                case "sort":
                    int StartSort = int.Parse(comand[2]);
                    int CountSort = int.Parse(comand[4]);

                    if (StartSort < 0 || CountSort < 0 || StartSort + CountSort >= numbers.Count ||
                        StartSort > numbers.Count || CountSort > numbers.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        var FirstPart = numbers.Take(StartSort);
                        var token = numbers.Skip(StartSort).Take(CountSort).OrderBy(x => x);
                        var LastPart = numbers.Skip(StartSort + CountSort);

                        numbers = FirstPart.Concat(token.Concat(LastPart)).ToList();
                    }
                        break;
                case "rollLeft":

                    int timesLeft = int.Parse(comand[1]);

                    for (int i = 0; i < timesLeft; i++)
                    {
                        string firstElement = numbers[0];

                        numbers.Take(1);
                        numbers.Add(firstElement);
                        numbers.RemoveAt(0);
                    }
                    break;
                case "rollRight":

                    int timesRight = int.Parse(comand[1]);
                    
                    for (int i = 0; i < timesRight; i++)
                    {
                        string lastElement = numbers[numbers.Count - 1];

                        numbers.Take(numbers.Count);
                        numbers.Insert(0, lastElement);
                        numbers.RemoveAt(numbers.Count - 1);
                       
                    }
                    break;
            }

            comand = Console.ReadLine().Split(' ').ToList();
        }
        Console.WriteLine($"[{string.Join(", ",numbers)}]");

    }

    
}
