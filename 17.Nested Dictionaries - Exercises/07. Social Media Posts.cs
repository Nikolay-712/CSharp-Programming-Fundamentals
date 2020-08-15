using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {

        var proces = new Dictionary<string, Dictionary<string, string>>();
        var Like = new Dictionary<string, int>();
        var disLike = new Dictionary<string, int>();

        List<string> action = Console.ReadLine().Split(' ').ToList();

       

        while (action[0] != "drop")
        {
            string postName = action[1];

            switch (action[0])
            {
                case "post":

                    if (!proces.ContainsKey(postName))
                    {
                        proces[postName] = new Dictionary<string, string>();
                    }
                    break;

                case "comment":

                    string comentatorName = action[2];
                    string comentar = string.Empty;

                    for (int i = 3; i < action.Count; i++)
                    {
                        comentar = comentar  + (action[i] + " ");
                    }

                    if (!proces.ContainsKey(comentatorName))
                    {
                        proces[postName][comentatorName] = comentar;
                    }
                   // proces[postName][comentatorName] = comentar;
                    

                    break;

                case "like":

                    if (!Like.ContainsKey(postName))
                    {
                        Like.Add(postName, 0);
                    }

                    Like[postName]++;
                    
                    

                    break;

                case "dislike":

                    if (!disLike.ContainsKey(postName))
                    {
                        disLike.Add(postName, 0);
                    }
                     disLike[postName]++;
                    

                    break;
                
            }
            action = Console.ReadLine().Split(' ').ToList();
        }

        foreach (var item in proces)
        {
            string name = item.Key;
            var SMaction = item.Value;


            Console.Write($"Post: {name} ");

            CounterLikes(Like, name);
            CounterDisLike(disLike, name);

            Console.WriteLine($"Comments: ");

            if (SMaction.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item1 in SMaction)
                {
                    string neshto = item1.Key;
                    var drugo = item1.Value;

                    Console.Write($"*  {neshto}: ");
                    Console.WriteLine($"{drugo}");
                }

            }

        }







    }

    

    private static void CounterDisLike(Dictionary<string, int> disLike, string name)
    {
        foreach (var count in disLike)
        {
            string namePost = count.Key;

            if (namePost == name)
            {
                Console.WriteLine($"| Dislikes: {count.Value}");
                break;
            }

            if(!disLike.ContainsKey(name) && namePost != name)
            {
                Console.WriteLine($"| Dislikes: {0}");
                break;
            }

            


        }
    }

    private static void CounterLikes(Dictionary<string, int> Like, string name)
    {
        foreach (var count in Like)
        {
            string postName = count.Key;


            if (postName == name)
            {
                Console.Write($"| Likes: {count.Value} ");
                break;
            }
            if (!Like.ContainsKey(name) && postName != name)
            {
                Console.Write($"| Likes: {0} ");
                break;

            }




        }
    }






}
