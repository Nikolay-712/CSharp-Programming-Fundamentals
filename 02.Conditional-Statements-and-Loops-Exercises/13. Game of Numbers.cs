using System;

class Test
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int magikNum = int.Parse(Console.ReadLine());

        int TheNum = 0;
        int Numberfound = 0;
        int counter = 0;

       

        for (int first = firstNumber; first <= secondNumber; first++)
        {
            for (int second = firstNumber; second <= secondNumber; second++)
            {
               
                TheNum = first + second;

                counter++;

                if (TheNum == magikNum)
                {
                    Numberfound = TheNum;

                    Console.WriteLine($"Number found! {second} + {first} = {Numberfound}");
                    return;
                }
               

            }
        }
        Console.WriteLine($"{counter} combinations - neither equals {magikNum}");
       



    }

    }
