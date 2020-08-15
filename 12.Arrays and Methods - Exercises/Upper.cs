using System;
using System.Linq;

class Test
{
    static void Main()
    {
        var text = Console.ReadLine();

        var chars = text.ToCharArray();
        int upperCounter = 0;

        for (int counter = 0; counter < chars.Length; counter++)
        {
            if (char.IsUpper(chars[counter]))
            {
                upperCounter++;
            }
          

        }
        Console.WriteLine(upperCounter);
    }
       


    }


   
       
  
    
    
   

 


