using System;

public class Test
{
    public static void Main()
    {
        int firstDigit = int.Parse(Console.ReadLine());
        char operation = char.Parse(Console.ReadLine());
        int secondDigit = int.Parse(Console.ReadLine());

        int calkulate = 0;

        switch (operation)
        {
            case '+':
                 calkulate = firstDigit + secondDigit;
                break;
            case '-':
                calkulate = firstDigit - secondDigit;
                break;
            case '*':
                calkulate = firstDigit * secondDigit;
                break;
            case '/':
                calkulate = firstDigit / secondDigit;
                break;

        }
        Console.WriteLine($"{firstDigit} {operation} {secondDigit} = {calkulate}");
    }
}
 

    
