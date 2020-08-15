using System;

public class Test
{
    public static void Main()
    {

        int n = int.Parse(Console.ReadLine());
       
        bool spinLeft = true;
        string currString = string.Empty;
        string prevString = string.Empty;
        string finalString = string.Empty;
        string nowString = string.Empty;

        for (int i = 0; i < n; i++)
        {
            currString = Console.ReadLine();
            nowString = currString;

            if (currString == "spin")
            {
                if (spinLeft)
                {
                    spinLeft = false;
                  
                }
                else
                {
                    spinLeft = true;
                    
                }
                i--;
                nowString = string.Empty;
            }

            if (prevString == currString)
            {
                if (currString == "spin")
                {
                    if (spinLeft)
                    {
                        spinLeft = false;
                       
                    }
                    else
                    {
                        spinLeft = true;
                        
                    }
                }
                finalString = string.Empty;
                continue;
            }

            if (spinLeft)
            {
                finalString = finalString + nowString;
            }
            else
            {
                finalString = nowString + finalString;
            }
            prevString = currString;
        }
        Console.WriteLine(finalString);
    }
}

        
 