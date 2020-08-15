using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Test
{
    public static void Main()
    {
        string input = Console.ReadLine();
        List<string> ValidMesseges = new List<string>();
        Regex regex = new Regex(@"^\d+(?<Messeges>[a-zA-Z]+)[^a-z-A-Z]+$");

        while (input != "Decrypt!")
        {

            MatchCollection Messeges = regex.Matches(input);

            int LenghtString = int.Parse(Console.ReadLine());

            AddValideMesseges(ValidMesseges, Messeges, LenghtString);
            

            input = Console.ReadLine();
        }

        Regex MessegesAndCode = new Regex(@"^(?<Front>[0-9]+)(?<Messege>[a-zA-Z]+)(?<Back>[^a-zA-Z]+)$");
        var Result = new Dictionary<string, string>();


        foreach (var item in ValidMesseges)
        {
            MatchCollection Message = MessegesAndCode.Matches(item);
            foreach (Match Code in Message)
            {
                string TheMessege = Code.Groups["Messege"].Value;
                string TheCode = Code.Groups["Front"].Value + Code.Groups["Back"];

                string Decrypt = string.Empty;

                
               for (int j = 0; j < TheCode.Length; j++)
               {
                   if (char.IsDigit(TheCode[j]))
                   {
                       int index = TheCode[j] - '0';

                        try
                        {
                            Decrypt = Decrypt + TheMessege[index];
                        }
                        catch
                        {

                        }
                   }
               }

                if (!Result.ContainsKey(TheMessege))
                {
                    Result[TheMessege] = Decrypt;
                }
                
            }
        }

        foreach (var item in Result)
        {
            Console.WriteLine($"{item.Key} = {item.Value}");
        }


    }

    private static void AddValideMesseges(List<string> ValidMesseges, MatchCollection Messeges, int LenghtString)
    {
        foreach (Match item in Messeges)
        {
            string ValidMess = item.Groups["Messeges"].Value;

            if (ValidMess.Length == LenghtString)
            {
                ValidMesseges.Add(item.Value);
            }
        }
    }
}