using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Test
{
    public static void Main()
    {
        int Train = int.Parse(Console.ReadLine());
        int MaxKilograms = Train;
        int Total = 0;
        List<int> Vagons = new List<int>();

        while (true)
        {
            try
            {
                int composition = int.Parse(Console.ReadLine());
                Total = Total + composition;
                Vagons.Add(composition);

                if (Total > MaxKilograms)
                {
                    int average = Total / Vagons.Count;
                    var nearest = Vagons.OrderBy(x => Math.Abs((int)x - average)).First();

                    Vagons.Remove(nearest);
                    Vagons.Reverse();
                    Vagons.Add(MaxKilograms);

                    Console.WriteLine(string.Join(" ", Vagons));
                    break;
                }

            }
            catch
            {
                break;
            }
        }





    }
}