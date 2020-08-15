using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class Test
 {
    class Product
    {
        public string ProductName { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

    }

     static void Main()
     {
        var products = new Dictionary<string, List<Product>>();
        List<string> input = File.ReadAllLines(@"D:\Input.txt").ToList();

        foreach (var item in input)
        {
            if (item == "exit")
            {
                break;
            }

            if (item == "sales")
            {

            }
            else if (item == "analyze")
            {

            }
            else if (item == "stock")
            {

            }
            else
            {
                var infoProduct = item.Split(' ').ToList();

                string product = infoProduct[0];
                string typeProduct = infoProduct[1];
                decimal priceProduct = decimal.Parse(infoProduct[2]);
                int quantityProduct = int.Parse(infoProduct[3]);

                Product addProduct = new Product
                {
                    ProductName = product,
                    Type = typeProduct,
                    Price = priceProduct,
                    Quantity = quantityProduct
                };

                if (!products.ContainsKey(typeProduct))
                {
                    products[typeProduct] = new List<Product>();
                }
                products[typeProduct].Add(addProduct);
                
            }

         
        }

     }
 }
