using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

public class Test
{
    public static void Main()
    {
        //string[] text = File.ReadAllLines(@"D:/RightSide.txt");
        //var oddLines = text.Where((line, index) => index % 2 == 1);
        //File.WriteAllLines("odd-lines.txt", oddLines);
        //
        //Console.WriteLine(string.Join("\n",oddLines));

        string[] text = File.ReadAllLines(@"D:/RightSide.txt");
        int count = 1;

        foreach (var item in text)
        {
            Console.WriteLine($"{count}. {item}");
            count++;
        }

    }
}