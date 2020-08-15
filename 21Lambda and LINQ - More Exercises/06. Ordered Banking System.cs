using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Test
{
    public static void Main()
    {
        var bankAcaunt = new Dictionary<string,Dictionary<string,decimal>>();


        List<string> infoUser = Console.ReadLine()
            .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();

        while (infoUser[0] != "end")
        {
            string bankName = infoUser[0];
            string UserName = infoUser[1];
            decimal balance = decimal.Parse(infoUser[2]);


            if (!bankAcaunt.ContainsKey(bankName))
            {
                bankAcaunt[bankName] = new Dictionary<string, decimal>();
            }

            if (!bankAcaunt[bankName].ContainsKey(UserName))
            {
                bankAcaunt[bankName][UserName] = 0;
            }

            bankAcaunt[bankName][UserName] = bankAcaunt[bankName][UserName] + balance;
            

            infoUser = Console.ReadLine()
            .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        var orderByAcaunt = bankAcaunt.OrderByDescending(x => x.Value.Values.Sum())
            .ToDictionary(x => x.Key,x => x.Value);

        foreach (var item in orderByAcaunt)
        {
            string BankName = item.Key;
            var Acaunts = item.Value;

            foreach (var User in Acaunts.OrderByDescending(x => x.Value))
            {
                string NameUser = User.Key;
                decimal balance = User.Value;

                Console.WriteLine($"{NameUser} -> {balance} ({BankName})");

            }
        }
       

    }
}
