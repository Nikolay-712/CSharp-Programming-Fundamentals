using System;

class Test
{
    static void Main()
    {
        var counter = Console.ReadLine().Split();
        var array = new int[counter.Length];
        int counterPosition = 0;

        for (int positoin = 0; positoin < array.Length; positoin++)
        {
            array[positoin] = int.Parse(counter[positoin]);

            if(positoin % 2 != 0 && array[positoin] % 2 != 0)
            {
                counterPosition++;
                Console.WriteLine($"Inedx{positoin} -> {array[positoin]}");
            }

           
        }
        
        

    }

}
