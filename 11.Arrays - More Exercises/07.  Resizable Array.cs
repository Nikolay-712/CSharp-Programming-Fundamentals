using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System;
public class Test
{

    public static void Main()
    {
        List<int> numbers = new List<int>(4);
        string comand = Console.ReadLine();


        while (comand != "end")
        {
            var tokens = comand.Split(' ');
            
            switch (tokens[0])
            {
                case "push":
                    int digit = int.Parse(tokens[1]);
                    numbers.Add(digit);
                break;

                case "pop":
                    numbers.RemoveAt(numbers.Count - 1);
                    break;

                case "removeAt":
                    int index = int.Parse(tokens[1]);
                    numbers.RemoveAt(index);
                    break;

                case "clear":
                    numbers.Clear();
                    break;
            }


            comand = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ",numbers));

       

    }
}
