using System;

public class Test
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int MaxValeuByte = 256;

        int Overflowed = number / MaxValeuByte;
        int leftDigit = Overflowed * MaxValeuByte;

        int nextNumber = number - leftDigit;

        if(number >= MaxValeuByte)
        {
            Console.WriteLine(nextNumber);
            Console.WriteLine($"Overflowed {Overflowed}");
        }
        else
        {
            Console.WriteLine(number);
        }
        

        

    }
}
    
