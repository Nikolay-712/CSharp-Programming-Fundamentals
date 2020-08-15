using System;

class Test
{
    static void Main()
    {
        var numberElements = (Console.ReadLine().Split());
        var array = new double[numberElements.Length];

        double multyplay = double.Parse(Console.ReadLine());
       

        for (int position = 0; position < array.Length; position++)
        {
            array[position] = double.Parse(numberElements[position]);
        }
        for (int position = 0; position < array.Length; position++)
        {
            array[position] = array[position] * multyplay;
        }
        for (int position = 0; position < array.Length; position++)
        {
            Console.Write(array[position] + " ");
        }
        Console.WriteLine();
    }

}
