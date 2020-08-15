using System;
using System.Collections.Generic;
using System.Linq;

class Test
{
    static void Main()
    {
        var counterNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        string proces = string.Empty;

        for (int elements = 0; elements < counterNumbers.Length ; elements++)
        {
             
            if(counterNumbers[elements] == counterNumbers[elements ])
            {
                proces = "No";
                break;
            }
            else
            {
                proces = "Yes";
            }
          
        }
        Console.WriteLine(proces);


    }

   
       
    }
    
    
   

 


