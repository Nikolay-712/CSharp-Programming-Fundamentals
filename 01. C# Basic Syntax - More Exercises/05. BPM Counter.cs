using System;

class Test
{
    static void Main(string[] args)
    {
        double BPM = double.Parse(Console.ReadLine());
        double bars = double.Parse(Console.ReadLine());

        double beats = Math.Round (bars / 4 , 1);
        double time = (bars * 60) / BPM;

        double minuts = (int)time / 60;
        double seconds = (int)time % 60;

        Console.WriteLine($"{beats} bars - {minuts}m {seconds}s");
        



    }

    }


            


