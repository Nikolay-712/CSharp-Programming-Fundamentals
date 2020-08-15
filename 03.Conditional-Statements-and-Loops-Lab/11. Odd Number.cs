using System;


namespace FirstProjects
{
    class Test
    {
        static void Main(string[] args)
        {

            int theNumber = int.Parse(Console.ReadLine());

            while (theNumber % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");

                theNumber = int.Parse(Console.ReadLine());


            }

            Console.WriteLine($"The number is: {Math.Abs(theNumber)}");



        }


    }

}





