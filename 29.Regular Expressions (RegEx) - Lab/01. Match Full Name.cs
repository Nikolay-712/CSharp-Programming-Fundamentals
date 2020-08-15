using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Test
{
    public static void Main()
    {
        string name = Console.ReadLine();
      
        Regex regex = new Regex(@"\b[A-Z][a-z]+\ [A-Z][a-z]+\b");
        MatchCollection match = regex.Matches(name);
        
        foreach (var item in match)
        {
            Console.Write(item + " ");
        }
        
        

        
    }

    
}