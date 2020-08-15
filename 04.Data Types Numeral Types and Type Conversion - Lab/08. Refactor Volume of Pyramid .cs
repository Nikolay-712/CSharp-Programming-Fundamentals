using System;

public class Test
{
    public static void Main()
    {
        
        Console.Write("Length: ");
        double Length = double.Parse(Console.ReadLine());

        Console.Write("Width: ");
        double Width = double.Parse(Console.ReadLine());

        Console.Write("Heigth: ");
        double Heigth = double.Parse(Console.ReadLine());

        double Piramide = (Length + Width + Heigth) * 3;
        Console.WriteLine("Pyramid Volume: {0:F2}", Piramide);

    }
}