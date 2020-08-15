using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Test
{
    public static void Main()
    {
        var InfoProducts = new Dictionary<string, decimal>();

        Regex regex = new Regex(@"(^[A-Z][a-z]+)([:][0-9]+\,[0-9]{2})");
        string input = Console.ReadLine();

      
        
        while (input != "bill")
        {
            Match Products = regex.Match(input);
            string TheProduct = Products.Value;

            if (regex.IsMatch(input))
            {
                var ProductAndPrice = TheProduct.Split(':');

                string Product = ProductAndPrice[0];
                decimal Price = decimal.Parse(ProductAndPrice[1]);

                if (!InfoProducts.ContainsKey(Product))
                {
                    InfoProducts[Product] = 0;
                }
                InfoProducts[Product] = Price;

            }
            

            input = Console.ReadLine();
        }
       
        foreach (var item in InfoProducts.OrderByDescending(x => x.Value))
        {
            Console.WriteLine($"{item.Key} costs {item.Value:f2}");
        }








    }
}