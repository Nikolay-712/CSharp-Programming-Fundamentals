using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Test
{

    public static void Main()
    {
        var productInfo = new List<string>();

        List<string> input = Console.ReadLine().Split(new[] { " -> " }
        , StringSplitOptions.RemoveEmptyEntries).ToList();

        while (input[0] != "chop chop")
        {
            string typeProduct = input[0];
            int height = int.Parse(input[1]);

            productInfo.Add(typeProduct);
            productInfo.Add(height.ToString());
            

            input = Console.ReadLine().Split(new[] { " -> " }
        , StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        string Product = Console.ReadLine();
        int minHeight = int.Parse(Console.ReadLine());


        double sumAllHeigts = 0;
        double sumForTheProduct = 0;
        double sumNotUsedProduct = 0;

        string typeTree = string.Empty;

        for (int i = 0; i < productInfo.Count; i++)
        {
            if (i % 2 != 0)
            {
                 sumAllHeigts = sumAllHeigts + double.Parse(productInfo[i]);
            }
            else
            {
                typeTree = productInfo[i];

                if (typeTree == Product && double.Parse( productInfo[i + 1]) >= minHeight)
                {
                    sumForTheProduct = sumForTheProduct + double.Parse(productInfo[i + 1]);
                }
                else
                {
                    sumNotUsedProduct = sumNotUsedProduct + double.Parse(productInfo[i + 1]);
                }
            }

        }


        double sumforMeters = Math.Round( (sumAllHeigts / (productInfo.Count / 2)), 2);
        double sumforneedSumProduct = Math.Round(sumForTheProduct * sumforMeters, 2);
        double notUseTree = Math.Round(sumNotUsedProduct * (sumforMeters * 0.25), 2);
        double totalMoney = Math.Round(sumforneedSumProduct + notUseTree, 2);

       

        Console.WriteLine($"Price per meter: ${sumforMeters:F2}");
        Console.WriteLine($"Used logs price: ${sumforneedSumProduct:F2}");
        Console.WriteLine($"Unused logs price: ${notUseTree:F2}");
        Console.WriteLine($"CottageScraper subtotal: ${totalMoney:F2}");

    }


}
