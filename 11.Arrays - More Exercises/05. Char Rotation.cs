using System;
using System.Collections.Generic;
using System.Linq;

public class Test

{
    public static void Main()
    {
        var chars = Console.ReadLine().ToCharArray();
        var numbers = Console.ReadLine().Split().ToArray();

        string cryptCode = string.Empty;
        int result = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            int codeChar = (int)(chars[i]);
            int num = int.Parse(numbers[i]);

            if(num % 2 == 0)
            {
                result = codeChar - num;
                cryptCode = cryptCode + (char)result;
            }
            else
            {
                result = codeChar + num;
                cryptCode = cryptCode + (char)result;
            }
            Console.WriteLine(cryptCode);
                
        }

    }    
}

    



 
