using System;

class Test
{
    static void Main(string[] args)
    {
        int counter = 0;
        try
        {

            while (true)
            {

            int input = int.Parse(Console.ReadLine());
                counter++;
            }
            
        }
        catch (OverflowException)
        {
            Console.WriteLine(counter);
        }

    }

    }
