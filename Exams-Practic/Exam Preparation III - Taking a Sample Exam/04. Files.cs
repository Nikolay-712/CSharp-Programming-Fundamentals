using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Test
{
    public static void Main()
    {
        var Info = new Dictionary<string, List<string>>();

        int count = int.Parse(Console.ReadLine());

        List<string> Directorys = Console.ReadLine().Split(';').ToList();

        for (int i = 0; i < count; i++)
        {
            string NameDirectrory = Directorys[0];
            ulong sizeFile = ulong.Parse(Directorys[1]);

            var Foldiers = NameDirectrory.Split('\\').ToList();

            string FileName = Foldiers[Foldiers.Count - 1];
            string FoldierName = Foldiers[0];

            if (!Info.ContainsKey(FoldierName))
            {
                Info[FoldierName] = new List<string>();
            }

            Info[FoldierName].Add($"{FileName}?{sizeFile}");
           

            Directorys = Console.ReadLine().Split(';').ToList();
        }

        var comand = Directorys[0].Split(' ').ToList();

        string SerchFile = comand[0];
        string SerchFoldier = comand[2];

        var MatchFiles = new Dictionary<string, ulong>();
        foreach (var item in Info)
        {
            string Foldier = item.Key;
            var FilesInFoldier = item.Value;

           

            for (int i = 0; i < FilesInFoldier.Count; i++)
            {

                if (FilesInFoldier[i].Contains(SerchFile) && SerchFoldier == Foldier)
                {
                     var infoFiles = FilesInFoldier[i].Split('?');

                    string file = infoFiles[0];
                    ulong sizeFile = ulong.Parse(infoFiles[1]);

                     if (!MatchFiles.ContainsKey(file))
                     {
                        MatchFiles[file] = sizeFile;
                     }
                     else
                     {
                        MatchFiles[file] = sizeFile;
                     }
                    

                    
                }
            }
        }

        if (MatchFiles.Count > 0)
        {
            foreach (var item in MatchFiles.OrderByDescending(x => x.Value).ThenBy(x => x.Key)) 
            {
                Console.WriteLine($"{item.Key} - {item.Value} KB");
            }
        }
        else
        {
            Console.WriteLine("No");
        }

        
           
            
       
    }
}