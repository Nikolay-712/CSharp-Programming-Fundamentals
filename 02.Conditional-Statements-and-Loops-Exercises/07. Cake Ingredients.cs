using System;

class Test
{
    static void Main()
    {

        string products = Console.ReadLine();
        string comand = "Bake!";
        int counterProducts = 0;

        while(comand != products)
        {
            counterProducts++;

            Console.WriteLine($"Adding ingredient {products}");

            products = Console.ReadLine();
        }
        Console.WriteLine($"Preparing cake with {counterProducts} ingredients.");
       
    }

        
        



    }

    




