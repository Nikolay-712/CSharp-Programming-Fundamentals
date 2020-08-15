using System;
using System.Collections.Generic;
using System.Linq;

public class Test

{
    public static void Main()
    {
        var array = Console.ReadLine().Split().ToArray();
        string result = string.Empty;
        
        for (int i = 0; i < array.Length; i++)
        {
            int numbers = int.Parse(array[i]);

            if(i == numbers)
            {
                result = $"{numbers}{" "}";
                Console.Write(result);
            }
        }
        Console.WriteLine();
        

           
          
    }

}

 

