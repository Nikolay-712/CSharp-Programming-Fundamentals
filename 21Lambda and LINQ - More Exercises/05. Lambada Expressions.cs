using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System;
public class Test
{

    public static void Main()
    {
        var Info = new Dictionary<string, string>();
        var newInfo = new Dictionary<string, string>();

        List<string> comand = Console.ReadLine().Split(' ').ToList();


        while (comand[0] != "lambada")
        {
            if (comand[0] == "dance")
            {
                var temp = Info.ToDictionary(pair => pair.Key, pair => pair.Value);

                foreach (var item in temp)
                {
                    string[] value = temp[item.Key].Split('.');
                    string selectorObject = value[0];
                    string modifiedText = selectorObject + ".";

                    Info[item.Key] = modifiedText + Info[item.Key];
                }

                
            }
            else
            {
                string key = comand[0];
                string property = comand[2];

                Info[key] = property;
            }

            comand = Console.ReadLine().Split(' ').ToList();
        }

        foreach (var item in Info)
        {
            Console.WriteLine($"{item.Key} => {item.Value}");
        }
    }
}
