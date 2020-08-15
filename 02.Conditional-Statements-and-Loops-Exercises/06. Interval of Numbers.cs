using System;

class Test
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int lastNumber = int.Parse(Console.ReadLine());

        for(int i = firstNum; i <= lastNumber; i++)
        {
            Console.WriteLine(i);
        }

        if(firstNum > lastNumber)
        {
            for(int i = lastNumber; i <= firstNum; i++)
            {
                Console.WriteLine(i);
            }
        }

       
    }
}


