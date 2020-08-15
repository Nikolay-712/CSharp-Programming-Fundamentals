using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Test
{
    class BankAccount
    {
        public string UserName { get; set; }

        public string BankName { get; set; }

        public decimal MoneyInAccount { get; set; }
    }
    
    public static void Main()
    {
        var BankInfo = new List<BankAccount>();

        List<string> input = Console.ReadLine().Split(new[] { " | " }
        , StringSplitOptions.RemoveEmptyEntries).ToList();

        while (input[0] != "end")
        {

            BankAccount info = new BankAccount
            {
                UserName = input[1],
                BankName = input[0],
                MoneyInAccount = decimal.Parse(input[2])

            };

            BankInfo.Add(info);


            input = Console.ReadLine().Split(new[] { " | " }
        , StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        foreach (var item in BankInfo
            .OrderByDescending(x => x.MoneyInAccount)
            .ThenBy(x => x.BankName.Length))
        {
            Console.WriteLine($"{item.UserName} -> {item.MoneyInAccount} ({item.BankName})");
        }

    }
}
    
