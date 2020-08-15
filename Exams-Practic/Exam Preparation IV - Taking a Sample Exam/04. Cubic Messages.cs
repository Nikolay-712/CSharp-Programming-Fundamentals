using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

public class Test
{
    public static void Main()
    {
        Regex regex = new Regex(@"(?<Begining>^[0-9]*)(?<Midle>[a-zA-Z]*)(?<End>[^a-zA-Z]*$)");
        List<string> Decrypt = new List<string>();

        string Messages = Console.ReadLine();

        while (Messages != "Over!")
        {
            int LenghtMessage = int.Parse(Console.ReadLine());

            Match match = regex.Match(Messages);
            string TextMessege = match.Groups["Midle"].Value;
            string IndexInMessege = match.Groups["Begining"].Value +
                match.Groups["End"].Value;

            string DecryptMesseges = string.Empty;

            if (TextMessege.Length == LenghtMessage)
            {
                for (int i = 0; i < IndexInMessege.Length; i++)
                {
                    int indexPosition = IndexInMessege[i] - '0';

                    if (indexPosition <= TextMessege.Length - 1)
                    {
                        for (int j = 0; j < TextMessege.Length; j++)
                        {
                            if (indexPosition == j)
                            {
                                DecryptMesseges = DecryptMesseges + TextMessege[j];
                                break;
                            }
                        }
                    }
                    else
                    {
                        DecryptMesseges = DecryptMesseges + ' ';
                    }

                }

                string result = $"{TextMessege} == {DecryptMesseges}";
                Decrypt.Add(result);
            }

            Messages = Console.ReadLine();
        }

        Console.WriteLine(string.Join("\n",Decrypt));

       
       

        }
      
      
      
       

    }


