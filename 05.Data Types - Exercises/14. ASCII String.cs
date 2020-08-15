using System;

public class Test
{
    public static void Main()
    {
        int counter = int.Parse(Console.ReadLine());
        string ASC = string.Empty;
        for (int i = 0; i < counter; i++)
        {
            int numbers = int.Parse(Console.ReadLine());

            char code = (char)numbers;
            ASC = ASC + code;           
        }
        Console.WriteLine(ASC);
    }
}
 

    
