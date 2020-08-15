using System;


namespace FirstProjects
{
    class Test
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
        
            double Water = 0.70;
            double Coffee = 1.0;
            double Beer = 1.7;
            double Tea = 1.2;

            if (profession.Equals("Athlete"))
            {
                double money = Water * quantity;
                Console.WriteLine($"The {profession} has to pay {money:F2}.");
            }
            else if (profession.Equals("Businessman") || profession.Equals("Businesswoman"))
            {
                double money = Coffee * quantity;
                Console.WriteLine($"The {profession} has to pay {money:F2}.");

            }
            else if (profession.Equals("SoftUni Student"))
            {
                double money = Beer * quantity;
                Console.WriteLine($"The {profession} has to pay {money:F2}.");
            }
            else
            {
                double money = Tea * quantity;
                Console.WriteLine($"The {profession} has to pay {money:F2}.");
            }

        }

            
        }

    }





