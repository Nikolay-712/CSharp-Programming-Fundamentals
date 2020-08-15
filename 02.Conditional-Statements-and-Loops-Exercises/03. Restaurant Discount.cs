using System;


namespace FirstProjects
{
    class Test
    {
        static void Main(string[] args)
        {
            int GroupSize = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            double SmallHall = 2500;
            double Terrace = 5000;
            double GreatHall = 7500;

            double Normal = 500;
            double Gold = 750;
            double Platinum = 1000;

            switch (type)
            {
                case "Normal":
                    if(GroupSize <= 50)
                    {
                        double money = SmallHall + Normal;
                        double rate = money - ( money * 5 / 100);
                        double pricePerson = rate / GroupSize;

                        Console.WriteLine("We can offer you the Small Hall");
                        Console.WriteLine($"The price per person is {pricePerson:F2}$");
                    }
                    else if(GroupSize <= 100)
                    {
                        double money = Terrace + Normal;
                        double rate = money - (money * 5 / 100);
                        double pricePerson = rate / GroupSize;

                        Console.WriteLine("We can offer you the Terrace");
                        Console.WriteLine($"The price per person is {pricePerson:F2}$");
                    }
            
                    else if(GroupSize < 120)
                    {
                        double money = GreatHall + Normal;
                        double rate = money - (money * 5 / 100);
                        double pricePerson = rate / GroupSize;

                        Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine($"The price per person is {pricePerson:F2}$");

                    }
        
                    else
                    {
                        Console.WriteLine("We do not have an appropriate hall.");
                    }
                    break;

                case "Gold":
                    if (GroupSize <= 50)
                    {
                        double money = SmallHall + Gold;
                        double rate = money - (money * 10 / 100);
                        double pricePerson = rate / GroupSize;

                        Console.WriteLine("We can offer you the Small Hall");
                        Console.WriteLine($"The price per person is {pricePerson:F2}$");
                    }
                    else if (GroupSize <= 100)
                    {
                        double money = Terrace + Gold;
                        double rate = money - (money * 10 / 100);
                        double pricePerson = rate / GroupSize;

                        Console.WriteLine("We can offer you the Terrace");
                        Console.WriteLine($"The price per person is {pricePerson:F2}$");

                    }

                    else if (GroupSize < 120)
                    {
                        double money = GreatHall + Gold;
                        double rate = money - (money * 10 / 100);
                        double pricePerson = rate / GroupSize;

                        Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine($"The price per person is {pricePerson:F2}$");

                    }

                    else
                    {
                        Console.WriteLine("We do not have an appropriate hall.");
                    }
                    break;

                case "Platinum":
               
                    if (GroupSize <= 50)
                    {
                        double money = SmallHall + Platinum;
                        double rate = money - (money * 15 / 100);
                        double pricePerson = rate / GroupSize;

                        Console.WriteLine("We can offer you the Small Hall");
                        Console.WriteLine($"The price per person is {pricePerson:F2}$");
                    }
                    else if (GroupSize <= 100)
                    {
                        double money = Terrace + Platinum;
                        double rate = money - (money * 15 / 100);
                        double pricePerson = rate / GroupSize;

                        Console.WriteLine("We can offer you the Terrace");
                        Console.WriteLine($"The price per person is {pricePerson:F2}$");

                    }

                    else if (GroupSize < 120)
                    {
                        double money = GreatHall + Platinum;
                        double rate = money - (money * 15 / 100);
                        double pricePerson = rate / GroupSize;

                        Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine($"The price per person is {pricePerson:F2}$");

                    }

                    else
                    {
                        Console.WriteLine("We do not have an appropriate hall.");
                    }
                    break;
            }
        }

            
        }

    }





