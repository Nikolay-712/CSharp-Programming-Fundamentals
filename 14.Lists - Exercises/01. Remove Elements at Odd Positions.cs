using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {

        List<string> symbol = Console.ReadLine().Split().ToList();

        string text = string.Empty;
        for (int i = 0; i < symbol.Count; i++)
        {
            if(i % 2 != 0)
            {
                text = text + symbol[i];
                
            }
        }

        Console.WriteLine(text);
            
                
            

        }
        
    }

      


           