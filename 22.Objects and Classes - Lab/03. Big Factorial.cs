using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

public class Test
{

    public static void Main()
    {
        BigInteger result = 1;
        int Factorel = int.Parse(Console.ReadLine());

        for (int i = 1; i <= Factorel; i++)
        {
            result = result * i;
        }

        Console.WriteLine(result);

    }
}


