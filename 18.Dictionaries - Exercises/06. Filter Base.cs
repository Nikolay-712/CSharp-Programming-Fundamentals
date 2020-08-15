using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{

    public static void Main()
    {
        Dictionary<string, string> position = new Dictionary<string, string>();
        Dictionary<string, int> age = new Dictionary<string, int>();
        Dictionary<string, double> salary = new Dictionary<string, double>();

        string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);


        int Age = 0;
        double Money = 0;
       // string Position = string.Empty;

        while (input[0] != "filter base")
        {
            string name = input[0];
            string checkType = input[1];

            if (int.TryParse(checkType, out Age))
            {
                age[name] = Age;
            }
            
            else if (double.TryParse(checkType, out Money))
            {
                salary[name] = Money;
            }
            else
            {
                position[name] = checkType;
            }
            


            input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

        }

        string type = Console.ReadLine().ToLower();

        switch (type)
        {
            case "age":
                foreach (var item in age)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Age: {item.Value}");
                    Console.WriteLine(new string('=',20));
                }

                break;

            case "position":
                foreach(var item in position)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Position: {item.Value}");
                    Console.WriteLine(new string('=', 20));
                }

                break;

            case "salary":
                foreach (var item in salary)
                {
                    Console.WriteLine($"Name: {item.Key}");
                    Console.WriteLine($"Salary: {item.Value}");
                    Console.WriteLine(new string('=', 20));
                }
                break;
        }


    }
}
    


