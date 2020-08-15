using System;

class Test
{
    static void Main()
    {
        var elements = Console.ReadLine().Split();
        var array = new int[elements.Length];

        int minNumber = int.MaxValue;
        for (int position = 0; position < array.Length; position++)
        {
            array[position] = int.Parse(elements[position]);

           

            if(minNumber > array[position])
            {
                minNumber = array[position];
               
            }
        }
        Console.WriteLine(minNumber);
    }

}
