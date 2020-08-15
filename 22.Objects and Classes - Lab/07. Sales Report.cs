using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

public class Test
{
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }

    public static void Main()
    {
        var infoSaleInTown = new Dictionary<string, decimal>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();

            Sale SaleInCity = AddInfoForSales(input);

            decimal MoneyAfterSale = SaleInCity.Price * SaleInCity.Quantity;

            CalculateTotalMoney(infoSaleInTown, SaleInCity, MoneyAfterSale);

        }

        foreach (var item in infoSaleInTown.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key} -> {item.Value:F2}");
        }

    }

    private static void CalculateTotalMoney(Dictionary<string, decimal> infoSaleInTown, Sale SaleInCity, decimal MoneyAfterSale)
    {
        if (!infoSaleInTown.ContainsKey(SaleInCity.Town))
        {
            infoSaleInTown[SaleInCity.Town] = MoneyAfterSale;
        }
        else
        {
            decimal total = infoSaleInTown[SaleInCity.Town] + MoneyAfterSale;

            infoSaleInTown[SaleInCity.Town] = total;
        }
    }

    private static Sale AddInfoForSales(List<string> input)
    {
        return new Sale
        {
            Town = input[0],
            Product = input[1],
            Price = decimal.Parse(input[2]),
            Quantity = decimal.Parse(input[3])
        };
    }
}