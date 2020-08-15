using System;

class Test
{
    static void Main(string[] args)
    {

        int DemigePlayer1 = int.Parse(Console.ReadLine());
        int DemigePlayer2 = int.Parse(Console.ReadLine());

        int HealtPlayer1 = 100;
        int HealtPlayer2 = 100;

        int countRound = 0;

        while (true)
        {
            countRound++;

            if(countRound % 2 != 0)
            {
                HealtPlayer2 = HealtPlayer2 - DemigePlayer1;

                if(HealtPlayer2 <= 0)
                {
                    break;
                }

                Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {HealtPlayer2} health.");
            }
            if(countRound % 2 == 0)
            {
                HealtPlayer1 = HealtPlayer1 - DemigePlayer2;

                if(HealtPlayer1 <= 0)
                {
                    break;
                }

                Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {HealtPlayer1} health.");
            }

            if(countRound % 3 == 0)
            {
                HealtPlayer1 = HealtPlayer1 + 10;
                HealtPlayer2 = HealtPlayer2 + 10;
            }
               
        }
        if (HealtPlayer2 <= 0)
        {
            Console.WriteLine($"Gosho won in {countRound}th round.");
        } 
        if(HealtPlayer1 <= 0)
        {
            Console.WriteLine($"Pesho won in {countRound}th round.");
        }

    }
  }





    


