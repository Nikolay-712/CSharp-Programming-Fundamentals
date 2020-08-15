using System;
using System.Collections.Generic;
using System.Linq;

class Test
{
    static void Main()

    {
        var comand = Console.ReadLine().Split().ToArray();

        string movement = string.Empty;
        string height = string.Empty;

        int valeu = 0;
        int skyMeters = 0;
        string metersInSky = string.Empty;

        string crash = string.Empty;

        for (int i = 0; i < comand.Length; i++)
        {
          

            switch (movement)
            {
                case "up":
                    skyMeters = skyMeters + valeu;
                    break;
                case "down":
                    skyMeters = skyMeters - valeu;
                    break;
            }

            if(i == 0)
            {
                metersInSky = comand[i];
                skyMeters = int.Parse(metersInSky);
            }
            else if (i % 2 != 0 )
            {
                movement = comand[i];
                height = comand[i + 1];

                valeu = int.Parse(height);
                
            }
            else
            {
                valeu = 0;
            }

            if (skyMeters <= 0)
            {
                crash = "crashed";
                break;
            }
            else
            {
                crash = ($"got through safely. current altitude: {skyMeters}m");
            }
          

        }
       
        Console.WriteLine(crash);
       



    }

   

}

    


