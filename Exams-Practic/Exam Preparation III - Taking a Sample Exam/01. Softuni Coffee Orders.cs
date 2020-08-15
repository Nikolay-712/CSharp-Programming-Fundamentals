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

        int orders = int.Parse(Console.ReadLine());
        decimal totalSum = 0L;

        for (int i = 0; i < orders; i++)
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            List<int> info = Console.ReadLine().Split('/').Select(int
            .Parse).ToList();
            int countProduct = int.Parse(Console.ReadLine());

            var days = System.DateTime.DaysInMonth(info[2], info[1]);

            decimal coffeSum = (days * countProduct) * pricePerCapsule;
            totalSum = totalSum + coffeSum;

            Console.WriteLine($"The price for the coffee is: ${coffeSum:F2}");
        }

        Console.WriteLine($"Total: ${totalSum:F2}");
    }
}
