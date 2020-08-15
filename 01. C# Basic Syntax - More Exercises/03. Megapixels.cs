using System;

class Test
{
    static void Main(string[] args)
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double pixsel = Math.Round(width * height / 1000000, 1);

        Console.WriteLine($"{width}x{height} => {pixsel}MP");


    }

    }




