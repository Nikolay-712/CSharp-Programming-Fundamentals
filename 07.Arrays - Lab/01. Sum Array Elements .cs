using System;

class Test
{
    static void Main()
    {
        int numberofElement = int.Parse(Console.ReadLine());
        int[] array = new int[numberofElement];

        int sum = 0;

        for (int positon = 0; positon < array.Length; positon++)
        {
            array[positon] = int.Parse(Console.ReadLine());
            sum = sum + array[positon];
        }
      
      
        Console.WriteLine(sum);
    }
}
