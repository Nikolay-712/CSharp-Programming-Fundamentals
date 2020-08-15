using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Test
{

    public static void Main()
    {
        var userRegiterDate = new Dictionary<string, DateTime>();

        List<string> user = Console.ReadLine().Split(new[] { " -> " }
        , StringSplitOptions.RemoveEmptyEntries).ToList();



        while (user[0] != "end")
        {
            string UserName = user[0];
            var theTime = user[1];

            DateTime data;

            data = DateTime.ParseExact(user[1], "dd/MM/yyyy", CultureInfo.InstalledUICulture);

            if (!userRegiterDate.ContainsKey(UserName))
            {
                userRegiterDate[UserName] = new DateTime();
            }

            userRegiterDate[UserName] = data;


            user = Console.ReadLine().Split(new[] { " -> " }
            , StringSplitOptions.RemoveEmptyEntries).ToList();
        }



        var result = userRegiterDate.Reverse().OrderBy(x => x.Value).Take(5)
            .OrderByDescending(x => x.Value)
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var item in result)
        {
            string name = item.Key;

            Console.WriteLine(name);
        }









    }
}









