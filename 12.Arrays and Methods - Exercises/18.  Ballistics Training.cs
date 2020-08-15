using System;
using System.Collections.Generic;
using System.Linq;

class Test
{
    static void Main()
    {
        var target = Console.ReadLine().Split().ToArray();
        var comand = Console.ReadLine().Split().ToArray();

        var x = 0;
        var y = 0;
        var valeu = 0;

        var cordinatX = int.Parse(target[0]);
        var cordinatY = int .Parse(target[1]);

        string position = string.Empty;
        string numbers = string.Empty;
        string result = string.Empty;
       
        

       for (int s = 0; s < comand.Length; s++)
       {
       if (s % 2 == 0)
       {
          position = comand[s];
          numbers = comand[s + 1];
          valeu = int.Parse(numbers);

       }
       else
       {
          valeu = 0;
       }

       switch (position)
       {
         case "up":
           y = y + valeu;
             break;
         case "down":
           y = y - valeu;
             break;
         case "right":
           x = x + valeu;
             break;
         case "left":
           x = x - valeu;
             break;
       }


       }
            if(cordinatX == x && cordinatY == y)
            {
            result = $"firing at [{x}, {y}]\ngot 'em!";
            }
            else
            {
            result = $"firing at [{x}, {y}]/nbetter luck next time...";
            
            }

              Console.WriteLine(result);
        
    }
 }










