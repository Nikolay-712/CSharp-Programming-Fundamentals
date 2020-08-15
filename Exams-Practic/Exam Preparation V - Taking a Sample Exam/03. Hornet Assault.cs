using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Test
{
    public static void Main()
    {
        List<long> defenders = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
        List<long> attackers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();


        for (int i = 0; i < defenders.Count; i++)
        {

            if (attackers.Count <= 0)
            {
                break;
            }

            long defensPower = defenders[i];
            long attacPower = attackers.Sum();

            if (defensPower >= attacPower)
            {
                defenders[i] = defenders[i] - attacPower;
                attackers.RemoveAt(0);

            }
            else
            {
                defenders.RemoveAt(i);

                i--;



            }

        }

        if (defenders.Where(d => d > 0).ToList().Count > 0)
        {
            Console.WriteLine(string.Join(" ", defenders.Where(d => d > 0)));
        }
        else
        {
            Console.WriteLine(string.Join(" ", attackers));
        }


    }
}