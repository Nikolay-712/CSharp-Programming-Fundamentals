using System;


namespace FirstProjects
{
    class Test
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());


            for (int Multiplier = 1; Multiplier <= 10; Multiplier++)
            {
                int result = number * Multiplier;

                Console.WriteLine($"{number} X {Multiplier} = {result}");

            }

        }


    }


}







