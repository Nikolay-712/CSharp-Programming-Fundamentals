using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        double[] power = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double[] costPower = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double hors = double.Parse(Console.ReadLine());


        for (int i = 0; i < power.Length; i++)
        {
            double leftEnregi = (power[i]) - (hors * costPower[i]);
            double rate = (leftEnregi / power[i]) * 100;

            int numberBateri = 1 + i;
            

            if (leftEnregi <= 0)
            {
                double workHors = Math.Ceiling(power[i] / costPower[i]);
                

                Console.WriteLine($"Battery {numberBateri}: dead (lasted {workHors} ) hours" );

                continue;
            }

            Console.WriteLine($"Battery {numberBateri}: {leftEnregi:F2} mAh ({rate:F2})%");
        }
        

    }


}
