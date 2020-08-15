using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        Dictionary<string, string> validLogin = new Dictionary<string, string>();

        string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
        int countNotValid = 0;

        while (input[0] != "login")
        {
            string userName = input[0];
            string password = input[1];

            validLogin[userName] = password;

            input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
        }

        input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

        Login(validLogin, ref input, ref countNotValid);

        Console.WriteLine($"unsuccessful login attempts: {countNotValid}");



    }

    private static void Login(Dictionary<string, string> validLogin, ref string[] input, ref int countNotValid)
    {
        while (input[0] != "end")
        {
            string userName = input[0];
            string password = input[1];

            foreach (var item in validLogin)
            {
                if (validLogin.ContainsKey(userName) && validLogin.ContainsValue(password))
                {
                    Console.WriteLine($"{userName}: logged in successfully");
                    break;
                }
                else
                {
                    countNotValid++;
                    Console.WriteLine($"{userName}: login failed");
                    break;

                }

            }

            input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

        }
    }
}
    


