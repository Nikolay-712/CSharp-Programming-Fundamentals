using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        var transport = new Dictionary<string, Dictionary<string, List<int>>>();

        List <string> info = Console.ReadLine().Split(':').ToList();
        
        while (info[0] != "ready")
        {
            string city = info[0];

            List<string> tokens = info[1].Split(new char[] { '-', ',' }
            , StringSplitOptions.RemoveEmptyEntries).ToList();

            if (!transport.ContainsKey(city))
            {

                transport.Add(city, new Dictionary<string, List<int>>());

            }

            int capacity = 0;
            string typeTransport = string.Empty;

            SelectSpaceAndTransport(transport, city, tokens, ref capacity, ref typeTransport);

            info = Console.ReadLine().Split(':').ToList();
        }

        string[] destination = Console.ReadLine().Split();

        while (destination[0] != "travel")
        {
            string place = destination[0];
            int turist = int.Parse(destination[1]);



            foreach (var item in transport)
            {
                string cityKey = item.Key;
                var TransportInfo = item.Value;
                int totalSpots = 0;
                

                foreach (var infoTravel in TransportInfo)
                {
                    string typeTransport = infoTravel.Key;
                    var TransportCapacitet = infoTravel.Value;

                    totalSpots = MaxCapacytiTransport(place, cityKey, totalSpots, TransportCapacitet);

                }

                if (cityKey == place)
                {
                    if (totalSpots >= turist)
                    {
                        Console.WriteLine($"{cityKey} -> all {turist} accommodated");
                    }
                    else
                    {
                        int except = turist - totalSpots;

                        Console.WriteLine($"{cityKey} -> all except {except} accommodated");
                    }

                }


            }




            destination = Console.ReadLine().Split();
            
        }

        

    }

    private static int MaxCapacytiTransport(string place, string cityKey, int totalSpots, List<int> TransportCapacitet)
    {
        if (place == cityKey)
        {
            for (int i = 0; i < TransportCapacitet.Count; i++)
            {
                totalSpots = totalSpots + TransportCapacitet[i];
            }


        }

        return totalSpots;
    }

    private static void SelectSpaceAndTransport(Dictionary<string, Dictionary<string, List<int>>> transport, string city, List<string> tokens, ref int capacity, ref string typeTransport)
    {
        for (int i = 0; i < tokens.Count; i++)
        {
            if (i % 2 == 0)
            {
                typeTransport = tokens[i];

                if (!transport.ContainsKey(typeTransport))
                {
                    transport[city][typeTransport] = new List<int>();
                }
            }
            else
            {
                capacity = int.Parse(tokens[i]);
                transport[city][typeTransport].Add(capacity);

            }
        }
    }


}
