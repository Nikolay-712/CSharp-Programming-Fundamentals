using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Test
{
    class Web
    {
        public string Host { get; set; }

        public string Domain { get; set; }

        public List<string> Queries { get; set; }
    }

    public static void Main()
    {
        List<Web> InfoWeb = new List<Web>();

        List<string> WebSites = Console.ReadLine()
            .Split(new[] {" | ",","},StringSplitOptions.RemoveEmptyEntries).ToList();

        while (WebSites[0] != "end")
        {
            if (WebSites.Count < 3)
            {
                Web site = new Web
                {
                    Host = WebSites[0],
                    Domain = WebSites[1],
                    Queries = new List<string>()
                    
                };
                InfoWeb.Add(site);
            }
            else
            {
                Web site = new Web
                {
                    Host = WebSites[0],
                    Domain = WebSites[1],
                    Queries = WebSites.Skip(2).ToList()
                };
                InfoWeb.Add(site);
            }

            WebSites = Console.ReadLine()
            .Split(new[] { " | ", "," }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        StringBuilder Queries = new StringBuilder();

        foreach (var item in InfoWeb)
        {
            if (item.Queries.Count > 0)
            {
                foreach (var info in item.Queries)
                {
                    string quer = $"[{info}]&";
                    Queries.Append(quer);
                   
                }
                string result = Queries.ToString();
              
                Console.WriteLine($"https://www.{item.Host}.{item.Domain}/query?={result.TrimEnd('&')}");
                Queries.Clear();
            }
            else
            {
                Console.WriteLine($"https://www.{item.Host}.{item.Domain}");
            }

            
        }
    }
}
    
