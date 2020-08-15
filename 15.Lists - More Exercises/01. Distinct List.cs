using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        


        HashSet<int> theSameNumbers = new HashSet<int>(numbers);

        Console.WriteLine(string.Join(" ",theSameNumbers));
       
    }
}
