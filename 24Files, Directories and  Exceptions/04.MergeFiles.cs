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
        string[] fileOne = File.ReadAllLines("FileOne.txt");
        string[] fileTwo = File.ReadAllLines("FileTwo.txt");

        string[] mergedLists = fileOne
            .Concat(fileTwo)
            .OrderBy(x => x)
            .ToArray();

        File.AppendAllText("MergeFiles.txt",
            string.Join(Environment.NewLine, mergedLists));
    }
}




