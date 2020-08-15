using System;
using System.Collections.Generic;
using System.Linq;

public class Test

{
    public static void Main()
    {
        var array = Console.ReadLine().Split().ToArray();


        for (int i = array.Length - 1; i > 0; i--)
        {

            if (array[i] == array[i - 1] && array[i] == array[i - 2])
            {

                Console.WriteLine($"{array[i]} {array[i]} {array[i]}");

                break;
            }



        }


    }
}
