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
        string text = Console.ReadLine().ToLower();
        string searchString = Console.ReadLine().ToLower();

        int count = 0;
        int index = text.IndexOf(searchString);

        while (index != -1)
        {
            count++;
            index = text.IndexOf(searchString, index + 1);
        }
        Console.WriteLine(count);
    }
}