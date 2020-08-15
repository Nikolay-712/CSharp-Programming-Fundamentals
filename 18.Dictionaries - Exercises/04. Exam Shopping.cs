using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        Dictionary<string, int> products = new Dictionary<string, int>();

        

        string stock = string.Empty;
        int quantity = 0;

        while (true)
        {
            string[] input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            if (input[0] == "exam")
            {
                foreach (var item in products)
                {
                    if (item.Value > 0) 
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                        return;
                    }
                }

            }
            else if (input[0] == "stock")
            {
                stock = input[1];
                quantity = int.Parse(input[2]);

                GetTheAllProducts(products, stock, quantity);
            }
            else if (input[0] == "buy")
            {
                stock = input[1];
                quantity = int.Parse(input[2]);

                GetProduct(products, stock, quantity);
            }

        }

    }

    private static void GetProduct(Dictionary<string, int> products, string stock, int quantity)
    {
        if (!products.ContainsKey(stock))
        {
            Console.WriteLine($"{stock} doesn't exist");
        }
        else if (products.ContainsKey(stock) && products[stock] > 0)
        {
            products[stock] = products[stock] - quantity;
        }
        else if (products.ContainsKey(stock) && products[stock] <= 0)
        {
            Console.WriteLine($"{stock} out of stock");
        }
    }

    private static void GetTheAllProducts(Dictionary<string, int> products, string stock, int quantity)
    {
        if (products.ContainsKey(stock))
        {
            products[stock] = products[stock] + quantity;
        }
        else
        {
            products[stock] = quantity;
        }
    }
}