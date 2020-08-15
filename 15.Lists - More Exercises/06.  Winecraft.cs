using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    static void Main(string[] args)
    {
        List<string> notes = new List<string>(new string[]
        {
          "C","C#","D","D#","E","F","F#","G","G#","A","A#","B"
            
        });

        List<double> frequencies = new List<double>(new double[]
         {
            261.63, 277.18, 293.66, 311.13, 329.63, 349.23,
            369.99, 392.00, 415.30, 440.00, 466.16, 493.88

         });

        List<double> frequenciesInput = Console.ReadLine().Split().
            Select(double.Parse).ToList();

        List<string> totalNotes = new List<string>();
        List<string> naturals = new List<string>();
        List<string> sharps = new List<string>();

        double naturalSum = 0;
        double sharpSum = 0;


        for (int i = 0; i < frequenciesInput.Count; i++)
        {
            int index = frequencies.IndexOf(frequenciesInput[i]);
            string curentNote = notes[index];

            totalNotes.Add(curentNote);

            double curentFrequenceInput = frequenciesInput[i]; 

            if (curentNote.Length == 1)
            {
                naturals.Add(curentNote);
                naturalSum = naturalSum + curentFrequenceInput;

            }
            else
            {
                sharps.Add(curentNote);
                sharpSum = sharpSum + curentFrequenceInput;
            }

        }

        Console.WriteLine("Notes: " + string.Join(" ",totalNotes));
        Console.WriteLine("Naturals: " + string.Join(",", naturals));
        Console.WriteLine("Sharps: " + string.Join(",",sharps));
        Console.WriteLine($"Naturals sum: {naturalSum}");
        Console.WriteLine($"Sharps sum: {sharpSum}");



    }
       


}

    
      


     

