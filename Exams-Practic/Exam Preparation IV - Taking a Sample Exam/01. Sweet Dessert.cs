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
        double money = double.Parse(Console.ReadLine());
        int guest = int.Parse(Console.ReadLine());

        double bananas = double.Parse(Console.ReadLine());
        double eggs = double.Parse(Console.ReadLine());
        double berries = double.Parse(Console.ReadLine());


        int countCoock = guest / 6;

        if (countCoock * 6 < guest)
        {
            countCoock++;

        }

        double MoneyBananas = (countCoock * bananas) * 2;
        double MoneyEggs = (countCoock * eggs) * 4;
        double Moneyberries = (berries * 0.2) * countCoock;

        double TotalMoney = MoneyBananas + Moneyberries + MoneyEggs;

        if (TotalMoney <= money)
        {
           

            Console.WriteLine($"Ivancho has enough money - it would cost {TotalMoney:F2}lv.");
        }
        else
        {
            double NeedMoney = TotalMoney - money;
            Console.WriteLine($"Ivancho will have to withdraw money - he will need {NeedMoney:F2}lv more.");

        }

       

       
    }
}