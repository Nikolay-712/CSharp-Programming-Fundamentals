using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Test
{

    static void Main()
    {
        string text = Console.ReadLine();
        List<string> comand = Console.ReadLine().Split(' ').ToList();

        while (comand[0] != "end")
        {
            switch (comand[0])
            {
                case "Left":
                    int countTimeL = int.Parse(comand[1]);

                    countTimeL = countTimeL % text.Length;
                    text = text.Substring(countTimeL) + text.Substring(0, countTimeL);

                    break;
                case "Right":
                    int countTimeR = int.Parse(comand[1]);

                    countTimeR = countTimeR % text.Length;
                    text = text.Substring(text.Length - countTimeR) 
                      + text.Substring(0, text.Length - countTimeR);
                    break;
                case "Insert":
                    int index = int.Parse(comand[1]);
                    string txt = comand[2];

                    text = text.Insert(index, txt);

                    break;
                case "Delete":
                    int startIndex = int.Parse(comand[1]);
                    int endIndex = int.Parse(comand[2]);

                    text = text.Remove(startIndex,endIndex + 1);
                    break;
            }
            comand = Console.ReadLine().Split(' ').ToList();
        }

        Console.WriteLine(text);
    }
}