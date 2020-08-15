using System;

class Test
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());

        int minNumber = 0;

        minNumber = GetMinNumber(number, number1);
        
        if(number2 < minNumber)
        {
            minNumber = number2;
        }
        
        Console.WriteLine(minNumber);
    }

    private static int GetMinNumber(int number, int number1)
    {
        int minNumber;
        if (number > number1)
        {
            minNumber = number1;
        }
        else
        {
            minNumber = number;
        }

        return minNumber;

        
    }
}
