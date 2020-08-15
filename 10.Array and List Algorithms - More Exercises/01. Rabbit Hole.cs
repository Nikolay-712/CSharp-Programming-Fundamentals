using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    static List<string> steps;
    public static void Main()
    {

        steps = Console.ReadLine().Split(' ').ToList();
        int energy = int.Parse(Console.ReadLine());

        int position = 0;
        int moveTo = 0;
        
        int getEnrgy = 0;
        bool explosion = false;

        while(true)
        {
            string[] curentPosition = steps[moveTo].Split('|');


            if (curentPosition[0] == "Right")
            {
                MoveOfRight(ref energy, ref position, ref moveTo, curentPosition);
            }
            else if(curentPosition[0] == "Left")
            {
                MoveOfLeft(ref energy, ref position, ref moveTo, curentPosition);
            }
            else if (curentPosition[0] == "RabbitHole")
            {
                Console.WriteLine("You have 5 years to save Kennedy!");
                return;
            }
            else
            {
                Bomb(ref energy, moveTo, ref getEnrgy, curentPosition);
                explosion = true;
            }

            if (energy <= 0 && explosion)
            {
                Console.WriteLine("You are dead due to bomb explosion!");
                return;
            }
            else if (energy <= 0 && !explosion)
            {
                Console.WriteLine("You are tired. You can't continue the mission.");
                return;
            }

            plantBomb(ref energy);
        }

    }

    private static void plantBomb(ref int energy)
    {
        if (steps[steps.Count - 1] == "RabbitHole" && energy > 0)
        {
            steps.Add($"Bomb|{energy}");
        }

        if (steps[steps.Count - 1] != "RabbitHole" && energy > 0)
        {
            steps[steps.Count - 1] = $"Bomb|{energy}";
        }
    }

    private static void Bomb(ref int energy, int moveTo, ref int getEnrgy, string[] curentPosition)
    {
           getEnrgy = int.Parse(curentPosition[1]);

            energy = energy - getEnrgy;
            steps.RemoveAt(moveTo);

            moveTo = 0;
        
    }

    private static void MoveOfLeft(ref int energy, ref int position, ref int moveTo, string[] curentPosition)
    {
       
       
        position = int.Parse(curentPosition[1]);
        moveTo = (position - moveTo) % steps.Count;
        energy = energy - position;
       
    }

    private static void MoveOfRight(ref int energy, ref int position, ref int moveTo, string[] curentPosition)
    {
         
        
          position = int.Parse(curentPosition[1]);
          moveTo = (position + moveTo) % steps.Count;
          energy = energy - position;

        
    }
}


