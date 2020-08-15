using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {

        HashSet<string> names = new HashSet<string>();

        int namesCnt = int.Parse(Console.ReadLine());

        for (int i = 0; i < namesCnt; i++)
        {
            string name = Console.ReadLine();

            names.Add(name);
        }

        foreach (var item in names)
        {
            string perosnalName = item;
            Console.WriteLine(perosnalName);
        }



    }


   
    
}