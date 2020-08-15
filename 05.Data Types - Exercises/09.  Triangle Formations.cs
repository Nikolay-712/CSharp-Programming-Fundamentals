using System;

public class Test
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if(a + b > c && b + c > a && a + c > b)
        {
            Console.WriteLine("Triangle is valid.");

            if(a == b && b == c && c == a)
            {
                Console.WriteLine("Triangle has no right angles");
            }
            else if((Math.Pow(a,2) + Math.Pow(b,2) == Math.Pow(c, 2)))
            {
                Console.WriteLine("Triangle has a right angle between sides a and b");
            }
            else if(Math.Pow(b,2) + Math.Pow(c,2) == Math.Pow(a, 2))
            {
                Console.WriteLine("Triangle has a right angel between side b and c");

            }
            else if(Math.Pow(a,2) + Math.Pow(c,2) == Math.Pow(b, 2))
            {
                Console.WriteLine("Triangle has a right angel between side a and c");
            }
           
            
            }
        else
        {
            Console.WriteLine("Invalid Triangle.");
        }
    }

    }

    
