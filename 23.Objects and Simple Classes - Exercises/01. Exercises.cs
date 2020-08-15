using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Test
{
    class Solutions
    {
        public string Topic { get; set; }

        public string CourseName { get; set; }

        public string JudgeContestLink { get; set; }

        public List<string> Problems { get; set; }

    }


    public static void Main()
    {
        List<Solutions> PrintSolutions = new List<Solutions>();

        string input = Console.ReadLine();
        
        while (input != "go go go")
        {
            string[] splitInput = input.Split(new string[] { " -> ", ", " },
               StringSplitOptions.RemoveEmptyEntries);


            Solutions solutions = new Solutions
            {
                Topic = splitInput[0],
                CourseName = splitInput[1],
                JudgeContestLink = splitInput[2],
                Problems = splitInput.Skip(3).ToList()
            };

            PrintSolutions.Add(solutions);
            input = Console.ReadLine();


        }

        foreach (var item in PrintSolutions)
        {
            Console.WriteLine($"Exercises: {item.Topic}");
            Console.WriteLine($"Problems for exercises and homework for the \"{item.CourseName}\" course @ SoftUni.");
            Console.WriteLine($"Check your solutions here: {item.JudgeContestLink}");

            int counterProblems = 1;

            foreach (var problem in item.Problems)
            {
                Console.WriteLine($"{counterProblems++}. {problem}");
            }


        }

    }
}
    
