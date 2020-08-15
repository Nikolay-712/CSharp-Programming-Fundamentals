using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        var info = new Dictionary<string, List<int>>();

        List<string> name = Console.ReadLine().Split(new[] { " -> ",", " }
        , StringSplitOptions.RemoveEmptyEntries).ToList();

        while (name[0] != "end")
        {
            try
            {
                string key = name[0];
                int value = int.Parse(name[1]);

                if (!info.ContainsKey(key))
                {
                    info[key] = new List<int>();
                }
                for (int i = 1; i < name.Count; i++)
                {
                    info[key].Add(int.Parse(name[i]));
                }



            }
            catch
            {
                string key = name[1];

                if (info.ContainsKey(key))
                {
                    info[name[0]] = new List<int>();
                    var value = info[key];

                    foreach (var item in value)
                    {
                        info[name[0]].Add(item);
                    }

                    

                }

            }

            name = Console.ReadLine().Split(new[] { " -> ", ", " }
        , StringSplitOptions.RemoveEmptyEntries).ToList();

        }

        foreach (var item in info)
        {
            string user = item.Key;
            var theValue = item.Value;

            Console.Write($"{user} === ");
            Console.WriteLine($"{string.Join(", ",theValue)}");

        }
       
    }

   


}