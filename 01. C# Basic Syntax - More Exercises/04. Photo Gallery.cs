using System;

class Test
{
    static void Main(string[] args)
    {
        int theName = int.Parse(Console.ReadLine());
        int day = int.Parse(Console.ReadLine());
        int mount = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        int time = int.Parse(Console.ReadLine());
        int miutes = int.Parse(Console.ReadLine());
        double size = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double convertSize = size / 1000000;

        
        Console.WriteLine($"Name: DSC_{theName:D4}.jpg");
        Console.WriteLine($"Date Taken: {day:D2}/{mount}/{year} {time:D2}:{miutes:D2}");
        //Console.WriteLine($"Size: {convertSize}MB");

        if (size < 1000)
        {
            Console.WriteLine($"Size: {size}B");
        }
        else if (size < 1000000)
        {
            size = size / 1000;
            Console.WriteLine($"Size: {size}KB");
        }
        else
        {
            size = size / 1000000;
            Console.WriteLine($"Size: {size}MB");
        }

        if (width == height)
        {
            Console.WriteLine($"Resolution: {width}X{height} (square)");
        }
        else if(width > height)
        {
            Console.WriteLine($"Resolution: {width}X{height} (landscape)");
        }
        else
        {
            Console.WriteLine($"Resolution: {width}X{height} (portrait)");

        }


    }
}



