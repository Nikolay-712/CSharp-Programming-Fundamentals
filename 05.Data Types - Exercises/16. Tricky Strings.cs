using System;

public class Test
{
    public static void Main()
    {
        string symbol = Console.ReadLine();
        int counter = int.Parse(Console.ReadLine());

        string text = string.Empty;

        for (int i = 1; i <= counter; i++)
        {
            string world = Console.ReadLine();
          
            if(i < counter )
            {
                text = text + world + symbol;
            }
            else
            {
                text = text + world;
                
            }
        }
        Console.WriteLine(text);
        

    }
}
 

    
