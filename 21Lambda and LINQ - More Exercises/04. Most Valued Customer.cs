using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Test
{
    public static void Main()
    {
        var infoProducts = new Dictionary<string, double>();
        var infoCustumers = new Dictionary<string, List<string>>();

        List<string> input = Console.ReadLine().Split(' ').ToList();

        while (input[0] != "Shop")
        {
            string typeProduct = input[0];
            double price = double.Parse(input[1]);

            if (!infoProducts.ContainsKey(typeProduct))
            {
                infoProducts[typeProduct] = 0;
            }

            infoProducts[typeProduct] = price;


            input = Console.ReadLine().Split(' ').ToList();
        }

        List<string> custumers = Console.ReadLine().Split(new[] {":",", "," " }
        ,StringSplitOptions.RemoveEmptyEntries).ToList();


        while (custumers[0] != "Print")
        {

            if (custumers[0] == "Discount")
            {
                var discountProduct = infoProducts
                    .OrderByDescending(x => x.Value).Take(3);
                    

                foreach (var item in discountProduct)
                {
                    string typeProduct = item.Key;
                    double newPrice = item.Value * 0.9;

                    infoProducts[typeProduct] = newPrice;
                }


            }
            else
            {
                string name = custumers[0];

                if (!infoCustumers.ContainsKey(name))
                {
                    infoCustumers[name] = new List<string>();
                }

                for (int i = 1; i < custumers.Count; i++)
                {
                    infoCustumers[name].Add(custumers[i]);
                }
            }


            custumers = Console.ReadLine().Split(new[] { ":", ", ", " " }
        , StringSplitOptions.RemoveEmptyEntries).ToList();

        }

        var topCustumer = infoCustumers.
            OrderByDescending(x => x.Value.
            Sum(product => infoProducts[product]))
            .First();

        string nameCustumer = topCustumer.Key;
        var productsInBag = topCustumer.Value;

        Console.WriteLine($"Biggest spender: {nameCustumer}");
        Console.WriteLine($"^Products bought:");

        double totalSum = productsInBag.Sum(x => infoProducts[x]);
        var orderProducts = productsInBag.Distinct().OrderByDescending(x => infoProducts[x]);

        foreach (var item in orderProducts)
        {
            Console.WriteLine($"^^^{item}: {infoProducts[item]}");

        }

        Console.WriteLine($"Total: {totalSum:F2}");
    }
}
