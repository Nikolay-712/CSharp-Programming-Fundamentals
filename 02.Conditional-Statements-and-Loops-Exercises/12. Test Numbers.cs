using System;

class Test
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int maximum = int.Parse(Console.ReadLine());
        int counter = 0;
        int calkulate = 0;

       
        
            for (int first = firstNumber; first >= 1; first--)
            {
                for (int second = 1; second <= secondNumber; second++)
                {
                    calkulate = calkulate + (3 * first * second);

                    counter++;

                if(calkulate >= maximum)
                {

                    Console.WriteLine($"{counter} combinations");
                    Console.WriteLine($"Sum: {calkulate} >= {maximum}");
                    return;
                }
               
                }

            }
                  Console.WriteLine($"{counter} combinations");
                  Console.WriteLine($"Sum: {calkulate}");
        
    }

    }
