using System;

public class Test
{
    public static void Main()
    {

        double widht = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        TriangleArea(widht, height);
        
    }

    private static double TriangleArea(double widht, double height)
    {
        double TriangleArea = (widht * height) / 2;
        Console.WriteLine(TriangleArea);
        return TriangleArea;
    }
   

}

