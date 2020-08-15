using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Test
{
    public static void Main()
    {
        var TrainInfo = new Dictionary<string, Dictionary<string,long>>();

        List<string> Trains = Console.ReadLine().Split(new[] 
        {" ",":" },StringSplitOptions.RemoveEmptyEntries).ToList();

        while (Trains[0] != "It's")
        {
            string TrainName = Trains[0];
            string Comand = Trains[1];


            string TrainA = string.Empty;
            string TrainB = string.Empty;
            string VagonName = string.Empty;
            long VagonPower = 0;

            if (Comand == "=")
            {
                TrainA = Trains[0];
                TrainB = Trains[2];

                if (!TrainInfo.ContainsKey(TrainA))
                {
                    TrainInfo[TrainA] = new Dictionary<string, long>();
                }
                if (TrainInfo.ContainsKey(TrainA))
                {
                    TrainInfo[TrainA].Clear();
                    foreach (var item in TrainInfo[TrainB])
                    {
                        string Vagon = item.Key;
                        long Power = item.Value;

                        TrainInfo[TrainA][Vagon] = Power; 
                    }
                }

               
            }
            if (Comand == "->" && Trains.Count == 3)
            {
                 TrainA = Trains[0];
                 TrainB = Trains[2];

                if (!TrainInfo.ContainsKey(TrainA))
                {
                    TrainInfo[TrainA] = new Dictionary<string, long>();
                }
                if (TrainInfo.ContainsKey(TrainA))
                {

                    foreach (var item in TrainInfo[TrainB])
                    {
                        string Vagon = item.Key;
                        long Power = item.Value;

                        TrainInfo[TrainA][Vagon] = Power;
                    }

                    TrainInfo.Remove(TrainB);
                }


            }
            if (Comand == "->" && Trains.Count > 3)
            {
                 VagonName = Trains[2];
                 VagonPower = long.Parse(Trains[3]);

                if (!TrainInfo.ContainsKey(TrainName))
                {
                    TrainInfo[TrainName] = new Dictionary<string, long>();

                }
                TrainInfo[TrainName][VagonName] = VagonPower;

                
            }

            Trains = Console.ReadLine().Split(new[]
            {" ",":" }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        foreach (var item in TrainInfo.
            OrderByDescending(x => x.Value.Values.Sum())
            .ThenBy(x => x.Value.Count))
        {
            Console.WriteLine($"Train: {item.Key}");

            foreach (var item1 in item.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"###{item1.Key} - {item1.Value}");
            }
        }

       


    }
}