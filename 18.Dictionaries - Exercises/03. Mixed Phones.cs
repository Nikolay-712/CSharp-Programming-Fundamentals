using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        SortedDictionary<string, long> result = new SortedDictionary<string, long>();

        string [] phoneBook = Console.ReadLine().Split(new char[] {' ',':'}, StringSplitOptions.RemoveEmptyEntries);

        while (phoneBook[0] != "over")
        {
            string name = phoneBook[0];
            string phone = phoneBook[1];

            long theNumber = 0L;

            if (Int64.TryParse(phone,out theNumber))
            {
                result[name] = theNumber;
            }
            else
            {
                name = phoneBook[1];
                phone = phoneBook[0];

                result[name] = Convert.ToInt64(phone);
            }


            phoneBook = phoneBook = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
        }

        foreach (var item in result)
        {
            string name = item.Key;
            long theNumber = item.Value;

            Console.WriteLine($"{name} -> {theNumber}");

        }





       


    }
}