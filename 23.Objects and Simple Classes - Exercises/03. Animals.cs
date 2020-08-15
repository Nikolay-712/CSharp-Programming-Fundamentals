using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Test
{
    class Dog
    {
        public string DogName { get; set; }

        public int DogAge { get; set; }

        public int NumbersOfLegs { get; set; }
    }

    class Cat
    {
        public string CatName { get; set; }

        public int CatAge { get; set; }

        public int IntelligenceQuotient { get; set; }
    }

    class Snake
    {
        public string SnakeName { get; set; }

        public int SnakeAge { get; set; }

        public int CrueltyCoefficien { get; set; }
    }

    
    public static void Main()
    {
        List<Dog> dogs = new List<Dog>();
        List<Cat> cats = new List<Cat>();
        List<Snake> snakes = new List<Snake>();

        List<string> animals = Console.ReadLine().Split(' ').ToList();

        while (animals[1] != "your")
        {
            if (animals.Count == 4)
            {
                string typeAnimal = animals[0];
                string nameAnimal = animals[1];
                int ageAnimal = int.Parse(animals[2]);
                int specification = int.Parse(animals[3]);

                switch (typeAnimal)
                {
                    case "Dog":

                        Dog TheDog = new Dog
                        {
                            DogName = nameAnimal,
                            DogAge = ageAnimal,
                            NumbersOfLegs = specification
                        };
                        dogs.Add(TheDog);
                        break;

                    case "Cat":
                        Cat TheCat = new Cat
                        {
                            CatAge = ageAnimal,
                            CatName = nameAnimal,
                            IntelligenceQuotient = specification
                        };
                        cats.Add(TheCat);
                        break;

                    case "Snake":
                        Snake TheSnake = new Snake
                        {
                            SnakeName = nameAnimal,
                            SnakeAge = ageAnimal,
                            CrueltyCoefficien = specification
                        };
                        snakes.Add(TheSnake);
                        break;
                }

            }

            if (animals.Count == 2)
            {
                string nameAnimal = animals[1];

                foreach (var item in dogs)
                {
                    if (item.DogName.Contains(nameAnimal))
                    {
                        Console.WriteLine($"I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
                        break;
                    }
                }
                foreach (var item in cats)
                {
                    if (item.CatName.Contains(nameAnimal))
                    {
                        Console.WriteLine($"I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
                        break;
                    }
                }
                foreach (var item in snakes)
                {
                    if (item.SnakeName.Contains(nameAnimal))
                    {
                        Console.WriteLine($"I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
                        break;
                    }
                }


            }

            animals = Console.ReadLine().Split(' ').ToList();
        }

        foreach (var item in dogs)
        {
            Console.WriteLine($"Dog: {item.DogName}, Age: {item.DogAge}, Number Of Legs: {item.NumbersOfLegs}");

        }
        foreach (var item in cats)
        {
            Console.WriteLine($"Cat: {item.CatName}, Age: {item.CatAge}, IQ: {item.IntelligenceQuotient}");

        }
        foreach (var item in snakes)
        {
            Console.WriteLine($"Snake: {item.SnakeName}, Age: {item.SnakeAge}, Cruelty: {item.CrueltyCoefficien}");
        }
    }
}
    
