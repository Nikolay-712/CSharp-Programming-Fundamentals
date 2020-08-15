using System;


namespace FirstProjects
{
    class Test
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int money = 0;

            if (day.Equals("Weekday"))
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    money = 12;
                }
                else if (age > 18 && age <= 64)
                {
                    money = 18;
                }
                else
                {
                    Console.WriteLine("Error!");
                }
                if (money != 0)
                {
                    Console.WriteLine(money + "$");
                }


            }

            if (day.Equals("Weekend"))
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    money = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    money = 20;
                }
                else
                {
                    Console.WriteLine("Error!");
                }
                if (money != 0)
                {
                    Console.WriteLine(money + "$");
                }

            }

            if (day.Equals("Holiday"))
            {
                if (0 <= age && age <= 18)
                {
                    money = 5;
                }
                else if (18 < age && age <= 64)
                {
                    money = 12;
                }
                else if (64 < age && age <= 122)
                {
                    money = 10;
                }
                else
                {
                    Console.WriteLine("Error!");
                }
                if (money != 0)
                {
                    Console.WriteLine(money + "$");
                }



            }


        }

    }


}


