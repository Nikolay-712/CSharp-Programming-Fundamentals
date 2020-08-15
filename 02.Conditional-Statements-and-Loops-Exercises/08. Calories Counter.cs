using System;

class Test
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        double total = 0;

        for(int i = 0; i < n; i++)
        {
            string product = Console.ReadLine().ToLower();

            double totalcalories = 0;

            if (product == "cheese")
            {
                totalcalories = 500;
            }
            if(product == "tomato sauce")
            {
                totalcalories = 150;
            }
            if(product == "salami")
            {
                totalcalories = 600;
            }
            if (product == "pepper")
            {
                totalcalories = 50;
            }

             total = total + totalcalories;
            
            }
        Console.WriteLine($"Total calories: {total}");



    }
       
       
    }

        
        



    

    




