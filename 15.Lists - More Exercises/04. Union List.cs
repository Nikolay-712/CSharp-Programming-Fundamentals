using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    static void Main(string[] args)
    {
        List<int> primalList = Console.ReadLine().Split()
            .Select(int.Parse).ToList();
        int counterList = int.Parse(Console.ReadLine());

        List<int> newNum = new List<int>();
       
        for (int i = 0; i < counterList; i++)
        {
            List<int> newList = Console.ReadLine().Split()
                .Select(int.Parse).ToList();

           

            for (int j = 0; j < primalList.Count; j++)
            {
                for (int k = 0; k < newList.Count; k++)
                {
                    if (primalList[j] == newList[k])
                    {
                        primalList.RemoveAll(a => a == newList[k]);
                        newList.RemoveAll(a => a == newList[k]);


                        j = -1;
                        k = -1;

                        break;
                    }



                }

                   
            }

         var result = primalList.Concat(newList);
            primalList = result.ToList();

           
        }

        primalList.Sort();

        Console.WriteLine(string.Join(" ",primalList));

           
    }

       



}

    
      


     

