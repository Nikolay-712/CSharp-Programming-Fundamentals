using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        int theNumbers = int.Parse(Console.ReadLine());
        int firstNum = -1 ;
        int countPosition = 0;
        List<string> newNumbers = new List<string>(0);

        string chekPos = string.Empty;

        while (true)
        {
            try
            {
                int checkFirstNumber = GetFirstNumber(theNumbers, firstNum);

                countPosition++;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i == checkFirstNumber)
                    {
                        numbers.Insert(i, theNumbers);
                    }

                   

                }

              
                   theNumbers = int.Parse(Console.ReadLine());
               
            }

            catch
            {
                Console.WriteLine(string.Join(" ", numbers));


                return;
            }
            
                

            
        }

        
        

    }

    private static int GetFirstNumber(int theNumbers ,int firstNum)
    {
        while(theNumbers != 0)
        {
            firstNum = theNumbers / 10;

            if (firstNum == 0)
            {
                break;
            }

            theNumbers = theNumbers / 10;
            
           
        }
        return theNumbers;

    }
     
}
