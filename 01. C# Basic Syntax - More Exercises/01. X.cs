using System;

class Test
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int right = 0;
        int left = num - 1;

        for (int row = 0; row < num; row++)
        {
            for (int cow = 0; cow < num; cow++)
            {
                if ((cow == left )|| (cow == right))
                {
                    Console.Write("x");
                }
                else
                {
                    Console.Write(" ");
                }
                
            }
            Console.WriteLine();
            right++;
            left--;

        }

    }
}



