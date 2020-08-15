using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Test
{


    static void Main()
    {
        string sentence = Console.ReadLine();
        string delimiter = Console.ReadLine();

        sentence = sentence.Replace(delimiter, "newValue");

        string[] elements = sentence.Split(new string[] { "newValue" }, StringSplitOptions.None);

        Console.WriteLine("[" + string.Join(", ", elements) + "]");
    }


}
