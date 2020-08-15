using System;

namespace ConsoleApp3
{
    public class Typs
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            NegativeOrPositiveNumber(number);

        }

        private static void NegativeOrPositiveNumber(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("The number 0 is zero.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is positive.");
            }
        }
    }




}


