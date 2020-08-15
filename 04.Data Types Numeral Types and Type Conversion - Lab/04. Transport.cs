using System;

public class Test
{
    public static void Main()
    {
        int tripsPiople = int.Parse(Console.ReadLine());
        int capacity = 24;
        int trips = 0;
        int counter = 0;

        int course = (tripsPiople / capacity);
        int leftPiople = tripsPiople - (course * capacity);
        
        if(leftPiople > 1)
        {
            counter++;
            trips = course + counter;
            
        }
        else
        {
          trips = course;
        }
        Console.WriteLine(trips);
    }
}