using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        List<string> Numbers = Console.ReadLine().Split(' ').ToList();
        List<string> newNumbrs = new List<string>();

        string result = string.Empty;

        for (int i = 0; i < Numbers.Count; i++)
        {

            if(i == 0 )
            {
                newNumbrs.Add(Numbers[i]);
                result = result + Numbers[i] + " ";
                Numbers.Reverse();
               
                continue;

            }

            else if (i == Numbers.Count - 1)
            {
                
                newNumbrs.Add(Numbers[i]);
                Numbers.Reverse();
                result = result + Numbers[i] + " ";


                break;
            }
            newNumbrs.Add(Numbers[i]);

            result = result + newNumbrs[i] + " ";
        }
        Console.WriteLine(string.Join(" ", result));




    }
        

    } 
        



        
      


           