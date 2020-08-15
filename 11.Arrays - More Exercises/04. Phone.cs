using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
      string[] phoneNumber = Console.ReadLine().Split().ToArray();
      string[] userName = Console.ReadLine().Split().ToArray();
      string[] comand = Console.ReadLine().Split().ToArray();

       while(comand [0] != "done")
        {
            switch (comand[0])
            {
                case "call":
                    for (int i = 0; i < phoneNumber.Length; i++)
                    {
                        int SumOfDigits = 0;
                        char[] symbol = phoneNumber[i].ToCharArray();

                        if (comand[1] == userName[i])
                        {
                            Console.WriteLine($"calling {phoneNumber[i]}");

                            SumOfDigits = GetTheSumOfDigits(symbol, SumOfDigits);
                            if (SumOfDigits % 2 == 0)
                            {
                                int minutes = SumOfDigits / 60;
                                int seconds = SumOfDigits % 60;
                                string duration = $"{minutes:d2}:{seconds:d2}";
                                Console.WriteLine($"call ended. duration: {duration}");
                            }
                            else
                            {
                                Console.WriteLine("no answer");
                            }
                        }

                        else
                        {
                            if (comand[1] == phoneNumber[i])
                            {
                                Console.WriteLine($"calling {userName[i]}");

                                SumOfDigits = GetTheSumOfDigits(symbol, SumOfDigits);
                                if (SumOfDigits % 2 == 0)
                                {
                                    int minutes = SumOfDigits / 60;
                                    int seconds = SumOfDigits % 60;
                                    string duration = $"{minutes:d2}:{seconds:d2}";
                                    Console.WriteLine($"call ended. duration: {duration}");
                                }
                                else
                                {

                                    Console.WriteLine("no answer");
                                }

                               

                            }

                        }
                    }
                    break;


                case "message":
                    for (int i = 0; i < phoneNumber.Length; i++)
                    {
                        int SumOfDigits = 0;
                        char[] symbol = phoneNumber[i].ToCharArray();

                        if (comand[1] == userName[i])
                        {
                            Console.WriteLine($"sending sms to {phoneNumber[i]}...");

                            SumOfDigits = GetTheSumOfDigits(symbol, SumOfDigits);
                            if (SumOfDigits % 2 == 0)
                            {
                                Console.WriteLine("meet me there");
                            }
                            else
                            {
                                Console.WriteLine("busy");
                            }
                        }

                        else
                        {
                            if (comand[1] == phoneNumber[i])
                            {
                                Console.WriteLine($"sending sms to {userName[i]}...");

                                SumOfDigits = GetTheSumOfDigits(symbol, SumOfDigits);
                                if (SumOfDigits % 2 == 0)
                                {
                                    Console.WriteLine("meet me there");
                                }
                                else
                                {
                                    Console.WriteLine("busy");
                                }



                            }

                        }
                    }
                    break;

                    
            }

            comand = Console.ReadLine().Split().ToArray();
        }


    }

    private static int GetTheSumOfDigits(char[] symbol, int SumOfDigits)
    {

        for (int j = 0; j < symbol.Length; j++)
        {
            int digitsOfNumber = (int)Char.GetNumericValue(symbol[j]);

            if (digitsOfNumber >= 0 && digitsOfNumber <= 9)
            {
                SumOfDigits = SumOfDigits + digitsOfNumber;

            }
        }
        return SumOfDigits;



    }

}