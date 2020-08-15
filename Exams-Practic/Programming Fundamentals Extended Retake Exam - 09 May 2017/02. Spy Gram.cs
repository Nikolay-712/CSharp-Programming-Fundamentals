using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Test
{
    public static void Main()
    {
        var theCode = new Dictionary<string, List<string>>();


        int personalKey = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();



        while (input != "END")
        {
            List<string> ValidInput = input.Split(new[] { " " }
        , StringSplitOptions.RemoveEmptyEntries).ToList();

            string name = ValidInput[1];

            ValidMessages(theCode, input, ValidInput, name);

            input = Console.ReadLine();

        }

        foreach (var item in theCode.OrderBy(a => a.Key))
        {
            string name = item.Key;
            var messeges = item.Value.Select(a => a.ToCharArray());


            foreach (var message in messeges)
            {

                int count = 0;
                string result = string.Empty;

                GenerateCode(personalKey, message, ref count, ref result);

                Console.WriteLine(result);

            }




        }
    }

    private static void GenerateCode(int personalKey, char[] message, ref int count, ref string result)
    {
        foreach (var num in message)
        {
            int numberInASCII = Convert.ToInt32(num);
            string numbersInKey = personalKey.ToString();

            for (int i = count; i < numbersInKey.Length;)
            {
                count++;
                int newNumber = numberInASCII +
                    Convert.ToInt32(numbersInKey[i] - '0');

                char TheCode = Convert.ToChar(newNumber);

                result = result + (TheCode);

                if (i == numbersInKey.Length - 1)
                {
                    count = 0;
                }

                break;
            }
        }
    }


    private static void ValidMessages(Dictionary<string, List<string>> theCode, string input, List<string> ValidInput, string name)
    {
        if (ValidInput[0] == "TO:" && ValidInput[2] == "MESSAGE:" && ValidInput[1] == name.ToUpper())
        {
            if (!theCode.ContainsKey(name))
            {
                theCode[name] = new List<string>();
            }

            theCode[name].Add(input);

        }
    }
}