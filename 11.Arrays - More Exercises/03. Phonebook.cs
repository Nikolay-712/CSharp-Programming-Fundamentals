using System;
using System.Collections.Generic;
using System.Linq;

public class Test

{
    public static void Main()
    {
        var arrayPhone = Console.ReadLine().Split().ToArray();
        var name = Console.ReadLine().Split().ToArray();
        var GetName = Console.ReadLine();

        var phoneNumber = string.Empty;
        var person = string.Empty;
        var result = string.Empty;

        while(GetName != "done")
        {
            for (int i = 0; i < arrayPhone.Length; i++)
            {
                if(GetName == name[i])
                {
                    Console.WriteLine($"{name[i]} -> {arrayPhone[i]}");
                    break;
                }
            }
            GetName = Console.ReadLine();

        }
        
      
    }



    }




