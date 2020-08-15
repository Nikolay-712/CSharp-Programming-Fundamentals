using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{

    public static void Main()
    {
        Dictionary<string, int> name = new Dictionary<string, int>();
        string[] input = Console.ReadLine().Split(new string[] {" = "}, StringSplitOptions.RemoveEmptyEntries);


        while (input[0] != "end")
        {
            string nameKey = input[0];
            string moneyValue = input[1];

            int numbersValeu = 0;

            if (int.TryParse(moneyValue,out numbersValeu))
            {
                name[nameKey] = numbersValeu;
            }
            else
            {
                if (name.ContainsKey(moneyValue))
                {
                    name[nameKey] = name[moneyValue];
                }

            }

            input = Console.ReadLine().Split(new string[] { " = " }, StringSplitOptions.RemoveEmptyEntries);
        }

        Console.WriteLine($"{name.Keys} === {name.Values}");



    }
}
    


