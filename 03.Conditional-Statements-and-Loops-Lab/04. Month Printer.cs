using System;


namespace FirstProjects
{
    class Test
    {
        static void Main(string[] args)
        {
            string Product = Console.ReadLine();
            var Quantity = double.Parse(Console.ReadLine());
            var Calories = double.Parse(Console.ReadLine());
            var Sugars = double.Parse(Console.ReadLine());

            double ContentSugrs = (Quantity * Sugars) / 100;
            double ContentCalories = (Quantity * Calories) / 100;

            Console.WriteLine($"{Quantity}ml {Product}:");
            Console.WriteLine($"{ContentCalories}kcal, {ContentSugrs}g sugars");



        }
            }
    
        }

                   
               




