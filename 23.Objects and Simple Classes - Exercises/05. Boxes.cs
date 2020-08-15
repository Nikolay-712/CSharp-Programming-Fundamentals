using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Test
{
    public class Box
    {
        public Point UpperLeft { get; set; }

        public Point UpperRight { get; set; }

        public Point BottomLeft { get; set; }

        public Point BottomRight { get; set; }

        public double Width { get { return Point.CalculateDistance(UpperLeft, UpperRight); } }

        public double Height { get { return Point.CalculateDistance(UpperLeft, BottomLeft); } }

        public static double CalculatePerimeter(double width, double height)
        {
            double perimeter = (width * 2 + height * 2);

            return perimeter;
        }

        public static double CalculateArea(double width, double height)
        {
            double area = width * height;

            return area;
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static double CalculateDistance(Point first, Point second)
        {
            double deltaX = second.X - first.X;
            double deltaY = second.Y - first.Y;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return distance;
        }
    }


    public static void Main()
    {
        List<string> cordinats = Console.ReadLine()
             .Split(new[] { " | ", ":" }, StringSplitOptions.RemoveEmptyEntries)
             .ToList();

        var boxes = new List<Box>();
        var currentBox = default(Box);

        while (cordinats[0] != "end")
        {
            currentBox = ReadNewBox(cordinats);
            boxes.Add(currentBox);


            cordinats = Console.ReadLine()
             .Split(new[] { " | ", ":" }, StringSplitOptions.RemoveEmptyEntries)
             .ToList();
        }

        foreach (var box in boxes)
        {
            Console.WriteLine($"Box: {box.Width}, {box.Height}");
            Console.WriteLine($"Perimeter: {Box.CalculatePerimeter(box.Width, box.Height)}");
            Console.WriteLine($"Area: {Box.CalculateArea(box.Width, box.Height)}");
        }
    }

    public static Box ReadNewBox(List<string> cordinats)
    {
        return new Box
        {
            UpperLeft = new Point
            {
                X = int.Parse(cordinats[0]),
                Y = int.Parse(cordinats[1]),
            },
            UpperRight = new Point
            {
                X = int.Parse(cordinats[2]),
                Y = int.Parse(cordinats[3])
            },
            BottomLeft = new Point
            {
                X = int.Parse(cordinats[4]),
                Y = int.Parse(cordinats[5])
            },
            BottomRight = new Point
            {
                X = int.Parse(cordinats[6]),
                Y = int.Parse(cordinats[7])
            }
        };
    }
}
