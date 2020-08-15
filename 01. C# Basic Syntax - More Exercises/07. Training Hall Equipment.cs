using System;

class Test
{
    static void Main(string[] args)
    {
        double money = double.Parse(Console.ReadLine());
        int counterElement = int.Parse(Console.ReadLine());
        double totalMoneyForProduct = 0;

        for (int counter = 0; counter < counterElement; counter++)
        {
            string product = Console.ReadLine();
            double moneyProduct = double.Parse(Console.ReadLine());
            double counterProduct = double.Parse(Console.ReadLine());

            Console.WriteLine($"Adding {counterProduct} {product} to cart.");

            totalMoneyForProduct =totalMoneyForProduct +( moneyProduct * counterProduct);
        }
            Console.WriteLine($"Subtotal: ${totalMoneyForProduct:F2}");

        if(money > totalMoneyForProduct)
        {
            double leftMoney = money - totalMoneyForProduct;
            Console.WriteLine($"Money left: ${leftMoney:F2}");
        }
        else
        {
            double needMoney = totalMoneyForProduct - money;
            Console.WriteLine($"Not enough. We need {needMoney} more.");
        }


    }
}

            


