using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        var clothes = new Dictionary<string, Dictionary<string, int>>();

        int typeCnt = int.Parse(Console.ReadLine());
        string typeclCothes = string.Empty;


        for (int i = 0; i < typeCnt; i++)
        {
            List<string> color = Console.ReadLine().Split(new[] { " -> ", "," }
            , StringSplitOptions.RemoveEmptyEntries).ToList();

            string colore = color[0];
            var Typeclothes = color.Skip(1);

            if (!clothes.ContainsKey(colore))
            {
                clothes[colore] = new Dictionary<string, int>();
            }
            foreach (var item in Typeclothes)
            {
                if (!clothes[colore].ContainsKey(item))
                {
                    clothes[colore][item] = 0;
                }

                clothes[colore][item]++;
            }
            



        }
        List<string> checkClothes = Console.ReadLine().Split(' ').ToList();


        string findeColore = checkClothes[0];
        string findeProduct = checkClothes[1];

        foreach (var item in clothes)
        {
            string color = item.Key;
            var type = item.Value;
            Console.WriteLine($"{color} clothes:");
            

            foreach (var TypeClothes in type)
            {
                string product = TypeClothes.Key;
                int counter = TypeClothes.Value;
               
                if (findeColore == color && product == findeProduct )
                {
                    Console.WriteLine($"* {product} - {counter} (found!)");
                    continue;

                }
                Console.WriteLine($"* {product} - {counter} ");

            }
        }

    }


    
}

