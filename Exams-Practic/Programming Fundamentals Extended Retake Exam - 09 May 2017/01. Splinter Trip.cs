using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Test
{
    public static void Main()
    {

        double miles = double.Parse(Console.ReadLine());
        double fuelTankCapacity = double.Parse(Console.ReadLine());
        double heavyWindsMiles = double.Parse(Console.ReadLine());

        double milesInNormalWinds = miles - heavyWindsMiles;
        double needFuel = milesInNormalWinds * 25;
        double bonusFuel = (heavyWindsMiles * 25) * 1.5;

        double totalFuel = bonusFuel + needFuel;
        double rateTolerance = totalFuel * 5 / 100;

        double totalFuelNeed = totalFuel + rateTolerance;

        if (fuelTankCapacity >= totalFuelNeed)
        {
            double leftFuel = fuelTankCapacity - totalFuelNeed;

            Console.WriteLine($"Fuel needed: {totalFuelNeed:F2}L");
            Console.WriteLine($"Enough with {leftFuel:F2}L to spare!");
        }
        else
        {
            double needMore = totalFuelNeed - fuelTankCapacity;

            Console.WriteLine($"Fuel needed: {totalFuelNeed:F2}L");
            Console.WriteLine($"We need {needMore:F2}L more fuel.");
        }
    }

}