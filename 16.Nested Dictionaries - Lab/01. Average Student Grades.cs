using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

        int numbersStudents = int.Parse(Console.ReadLine());

        for (int i = 0; i < numbersStudents; i++)
        {
            List<string> book = Console.ReadLine().Split().ToList();

            string name = book[0];

            double grade = 0;

            if (!students.ContainsKey(name))
            {
                students[name] = new List<double>();
            }

            grade = GetTheGrade(students, book, name, grade);

        }

        foreach (var item in students)
        {
            string studentName = item.Key;
            var studentGrade = item.Value;

            double average = studentGrade.Average();

            Console.Write($"{studentName} -> ");

            foreach (var grade in studentGrade)
            {
                Console.Write($"{grade:F2} ");
            }

            Console.WriteLine($"(avg: {average:f2})");
        }


    }

    private static double GetTheGrade(Dictionary<string, List<double>> students, List<string> book, string name, double grade)
    {
        for (int cnt = 0; cnt < book.Count; cnt++)
        {
            if (cnt > 0)
            {
                grade = double.Parse(book[cnt]);
                students[name].Add(grade);
            }

        }

        return grade;
    }
}