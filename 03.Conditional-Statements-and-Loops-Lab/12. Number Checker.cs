using System;


namespace FirstProjects
{
    class Test
    {
        static void Main(string[] args)
        {

            try
            {
                double.Parse(Console.ReadLine());

                Console.WriteLine("It is a number.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");

            }


        }


    }

}





