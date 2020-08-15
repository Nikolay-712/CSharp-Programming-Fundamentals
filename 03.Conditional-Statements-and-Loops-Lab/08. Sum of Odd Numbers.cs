using System;


namespace FirstProjects
{
    class Test
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int SumofDigits = 0;

            for (int i = 1; i <= n * 2; i++)
            {
                if (i % 2 != 0)
                {
                    SumofDigits = SumofDigits + i;
                    Console.WriteLine(i);
                }

            }
            Console.WriteLine($"Sum: {SumofDigits}");

        }


    }


}







