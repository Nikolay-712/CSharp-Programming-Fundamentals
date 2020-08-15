using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class Test
 {
    class User
    {
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public bool IsLoged { get; set; }
    }

     static void Main()
     {
        var infoUsers = new Dictionary<string, User>();
        var logList = new List<string>();

        List<string> input = File.ReadAllLines(@"D:/Input.txt").ToList();

        foreach (var item in input)
        {
            if (item == "exit")
            {
                break;
            }

            var info = item.Split();

            if (info[0] == "register")
            {
                string userName = info[1];
                string userPass = info[2];
                string confirmPass = info[3];

                if (userPass == confirmPass)
                {
                    if (!infoUsers.ContainsKey(userName))
                    {
                        User newUser = new User
                        {
                            UserName = userName,
                            UserPass = userPass,
                            IsLoged = false
                        };

                        infoUsers.Add(userName, newUser);

                    }
                    else
                    {
                        Console.WriteLine($"The given username already exists.");
                    }
                }
                else
                {
                    Console.WriteLine($"The two passwords must match.");

                }

            }
            else if (info[0] == "login")
            {
                string userName = info[1];
                string userPass = info[2];

               

                if (!infoUsers.ContainsKey(userName))
                {
                    Console.WriteLine($"There is no user with the given username.");
                }
                else
                {
                    string password = infoUsers[userName].UserPass;
                    if (password == userPass)
                    {
                        if (!logList.Contains(userName))
                        {
                            logList.Add(userName);
                            infoUsers[userName].IsLoged = true;
                        }
                        else
                        {
                            Console.WriteLine($"There is already a logged in user.");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"The password you entered is incorrect.");
                    }
                }
                

            }
            else if (info[0] == "logout")
            {
                if (logList.Count == 0)
                {
                    Console.WriteLine($"There is no currently logged in user.");
                }
                else
                {
                    infoUsers[logList[0]].IsLoged = false;
                    logList.Clear();
                }
            }
            
        }

        foreach (var item in infoUsers)
        {
            string status = string.Empty;

            if (item.Value.IsLoged)
            {
                status = "Online";
            }
            else
            {
                status = "Ofline";
            }

            string logResult = 
                $"User: {item.Key} " +
                $"Password: {item.Value.UserPass} " +
                $"Status: {status}" +
                $"{Environment.NewLine}";
            
            File.AppendAllText(@"D:\info.txt", logResult);
        }
    }
 }
