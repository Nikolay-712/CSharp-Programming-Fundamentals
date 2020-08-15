using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class Test
 {
     static void Main()
     {
        List<string> input = File.ReadAllLines(@"D:\input.txt").ToList();
        string title = string.Empty;
        StringBuilder allInfo = new StringBuilder();

        var infoBody = new List<string>();

        foreach (var item in input)
        {
            if (item == "exit")
            {
                break;
            }

            var tokens = item.Split(' ');

            if (tokens[0] == "title")
            {
                title = tokens[1];
            }
            else
            {
               
                infoBody.Add(item);
               
            }

           
        }

        string type = $"<DOCTYPE html>{Environment.NewLine}" +
           $"<html>{Environment.NewLine}" +
           $"<head>{Environment.NewLine}" +
           $"\t<title>{title}</title>{Environment.NewLine}" +
           $"</head>{Environment.NewLine}" +
           $"<body>{Environment.NewLine}";

        foreach (var item in infoBody)
        {
            var token = item.Split();

            allInfo.Append($"\t<{token[0]}>{token[1]}</{token[0]}>{Environment.NewLine}");
        }

        string endDocument = $"</body>{Environment.NewLine}</html>";

        File.AppendAllText(@"D:\HTML.html", type);
        File.AppendAllText(@"D:\HTML.html", allInfo.ToString());
        File.AppendAllText(@"D:\HTML.html", endDocument);

    }
 }
