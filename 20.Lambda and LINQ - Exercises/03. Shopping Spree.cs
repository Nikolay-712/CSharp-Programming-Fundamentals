using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Test
{

    public static void Main()
    {
        var theBag = new Dictionary<string, double>();

        double money = double.Parse(Console.ReadLine());
        List<string> productCost = Console.ReadLine().Split(' ').ToList();

        while (productCost[0] != "end")
        {
            string theProduct = productCost[0];
            double costMoney = double.Parse(productCost[1]);

            if (!theBag.ContainsKey(theProduct))
            {
                theBag[theProduct] = costMoney;
            }
            else
            {
                double lastPrice = theBag[theProduct];

                if (lastPrice > costMoney)
                {
                    theBag[theProduct] = costMoney;
                }
                else
                {
                    theBag[theProduct] = lastPrice;
                }

            }

            productCost = Console.ReadLine().Split(' ').ToList();
        }

        foreach (var item in theBag.OrderByDescending(x => x.Value).ThenBy(x => x.Key.Length))
        {
            string product = item.Key;
            double price = item.Value;

            double totalMoneyforProducts = theBag.Values.Sum();

            if (totalMoneyforProducts <= money)
            {
                Console.WriteLine($"{product} costs {price:F2}");

            }
            else
            {

                Console.WriteLine("Need more money... Just buy banichka");
                break;
            }

        }

    }
}