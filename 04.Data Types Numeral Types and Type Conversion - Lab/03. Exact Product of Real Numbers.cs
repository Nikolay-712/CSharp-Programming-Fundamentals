using System;

public class Test
{
    public static void Main()
    {
        {
            int numCount = int.Parse(Console.ReadLine());
            decimal sum = 0m;
            for (int i = 0; i < numCount; i++)
            {
                sum *= decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
    
