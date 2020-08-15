using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        List<string> skipSong = Console.ReadLine().Split(' ').ToList();
        string songs = Console.ReadLine();
        List<string> playlist = new List<string>();

        while (songs != "end")
        {
            bool contains = false;
            for (int i = 0; i < skipSong.Count; i++)
            {
                if (songs.Contains(skipSong[i]))
                {
                    contains = true;
                }

                if (!contains)
                {
                    playlist.Add(songs);
                }
            }
            
            songs = Console.ReadLine();
            playlist.Sort();

            

        }
        Console.WriteLine(string.Join("\n", playlist));




    }

}
        
      


           