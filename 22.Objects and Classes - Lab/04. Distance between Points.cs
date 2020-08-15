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
        List<int> first = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> second = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        Points FirstPoint = new Points { X = first[0], Y = first[1] };
        Points SecondPoint = new Points { X = second[0], Y = second[1] };

        var result = Math.Sqrt(Math.Pow(FirstPoint.X - SecondPoint.X, 2) + Math.Pow(FirstPoint.Y - SecondPoint.Y, 2));

        Console.WriteLine($"{result:F3}");
    }

    class Points
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}


