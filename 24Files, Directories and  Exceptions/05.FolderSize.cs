using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Test
{
    static void Main()
    {
        string[] files = Directory.GetFiles(@"D:/TestFoldier");

        double sumSizes = 0;

        foreach (var item in files)
        {
            FileInfo fileInfo = new FileInfo(item);
            sumSizes = sumSizes + fileInfo.Length;
        }

        double MB = sumSizes / 1024 / 1024;


        File.WriteAllText(@"D:/FolderSize.txt", sumSizes.ToString());
    }
}


