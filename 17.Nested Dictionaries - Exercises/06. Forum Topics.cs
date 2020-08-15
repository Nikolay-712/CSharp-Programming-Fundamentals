using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        var text = new Dictionary<string, HashSet<string>>();

        List<string> hashTag = Console.ReadLine()
            .Split(new[] { " -> ", ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

        while (hashTag[0] != "filter")
        {
            string findeText = hashTag[0];

            if (!text.ContainsKey(findeText))
            {
                text[findeText] = new HashSet<string>();
            }

            for (int i = 1; i < hashTag.Count; i++)
            {
                text[findeText].Add(hashTag[i]);
            }



            hashTag = Console.ReadLine()
            .Split(new[] { " -> ", ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        string[] tags = Console.ReadLine().Split(new string[] { ", "},StringSplitOptions.RemoveEmptyEntries);

      

        foreach (var item in text)
        {
            string words = item.Key;
            var theTags = item.Value;

            if (Contains(tags, theTags))
            {
                var hashtaggedTags = theTags.Select(t => "#" + t);

                Console.WriteLine($"{words} | {string.Join(", ", hashtaggedTags)}");


            }

        }



    }

    private static bool Contains(string[] tags, HashSet<string> theTags)
    {
        foreach (var tag in tags)
        {
            if (!theTags.Contains(tag))
            {
                return false;
            }
        }

        return true;
    }
}