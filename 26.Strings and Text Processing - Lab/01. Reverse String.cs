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
        string text = Console.ReadLine();
        StringBuilder reverse = new StringBuilder();
        for (int i = text.Length - 1; i >= 0; i--)
        {
            reverse.Append(text[i]);
        }
        Console.WriteLine(reverse.ToString());
    }
}