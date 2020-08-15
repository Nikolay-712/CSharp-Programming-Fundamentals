using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Test
{
    static string TypeFlattenProduct;

    public static void Main()
    {
        var productInfo = new Dictionary<string, Dictionary<string,string>>();

        List<string> input = Console.ReadLine().Split(' ').ToList();
        List<string> flattenProduct = new List<string>();

        while (input[0] != "end")
        {
            if (input[0] == "flatten")
            {
               TypeFlattenProduct = input[1];


                foreach (var item in productInfo)
                {
                    string Product = item.Key;
                    var dadada = item.Value;

                    if (TypeFlattenProduct == Product)
                    {
                        foreach (var product in dadada)
                        {
                            string brand = product.Key;
                            string model = product.Value;

                            flattenProduct.Add(brand + model);
                        }

                        dadada.Clear();
                        break;
                    }
                    
                }
                
            }
            else
            {
                string theProduct = input[0];
                string brand = input[1];
                string model = input[2];

                if (!productInfo.ContainsKey(theProduct))
                {
                    productInfo[theProduct] = new Dictionary<string, string>();
                }

                productInfo[theProduct][brand] = model;
            }

            input = Console.ReadLine().Split(' ').ToList();
        }



        foreach (var item in productInfo.OrderByDescending(x => x.Key.Length))
        {
            string TypeProduct = item.Key;
            var BrandAndModel = item.Value;

            Console.WriteLine($"{TypeProduct}");

            int countPosition = 1;

            foreach (var model in BrandAndModel.OrderBy(x => x.Key.Length))
            {
                string Brand = model.Key;
                string Model = model.Value;

                Console.WriteLine($"{countPosition}. {Brand} - {Model}");
                countPosition++;
            }

             
            if (TypeProduct == TypeFlattenProduct)
            {
                foreach (var flatten in flattenProduct)
                {
                    Console.WriteLine($"{countPosition}. {flatten}");
                    countPosition++;
                }
            }

            

        }
       

    }

    
}
