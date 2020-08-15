using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Test
{
    class Message
    {
        public List<string> Content { get; set; }

        public string Sender { get; set; }
    }

    public class User
    {
        public string UserName { get; set; }

        public List<string> ReceivedMessages { get; set; }
    }


    public static void Main()
    {
        var input = Console.ReadLine();

        var senders = new Dictionary<string, Message>();
        var users = new List<string>();

        while (input != "exit")
        {
            var tokens = input.Split(' ');
            if (tokens[0] == "register")
            {
                users.Add(tokens[1]);
            }
            else
            {
                var sender = tokens[0];
                var recipient = tokens[2];
                var content = tokens[3];
                var currentUser = new User();
                var message = new Message();

                if (users.Contains(sender) && users.Contains(recipient))
                {
                    if (!senders.ContainsKey(sender))
                    {
                        message.Sender = sender;
                        message.Content = new List<string>();
                        senders.Add(message.Sender, message);
                    }
                    if (!senders.ContainsKey(recipient))
                    {
                        var newMessage = new Message
                        {
                            Sender = recipient,
                            Content = new List<string>()
                        };
                        senders.Add(newMessage.Sender, newMessage);
                    }
                    senders[sender].Content.Add(content);
                }
            }

            input = Console.ReadLine();
        }

        var newInput = Console.ReadLine().Split(' ');
        var firstUser = newInput[0];
        var secondUser = newInput[1];
        var hasMessages = false;

        if (senders.ContainsKey(firstUser) && senders.ContainsKey(secondUser))
        {
            var max = Math.Max(senders[firstUser].Content.Count, senders[secondUser].Content.Count);
            var firstCount = senders[firstUser].Content.Count;
            var secondCount = senders[secondUser].Content.Count;

            for (int i = 0; i < max; i++)
            {
                if (senders.ContainsKey(firstUser) && firstCount > 0)
                {
                    Console.WriteLine($"{senders[firstUser].Sender}: {senders[firstUser].Content[i]}");
                    hasMessages = true;
                }
                if (senders.ContainsKey(secondUser) && secondCount > 0)
                {
                    Console.WriteLine($"{senders[secondUser].Content[i]} :{senders[secondUser].Sender}");
                    hasMessages = true;
                }

                firstCount--;
                secondCount--;
            }
        }
        if (!hasMessages)
        {
            Console.WriteLine("No messages");
        }
    }
}

