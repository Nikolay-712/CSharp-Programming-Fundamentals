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
        List<string> elementandIndex = Console.ReadLine().Split(' ').ToList();

        char element = char.Parse(elementandIndex[0]);
        int position = int.Parse(elementandIndex[1]);

        var count = text.Where(x => x == element).Count();

        if (count < position)
        {
            Console.WriteLine("Find the letter yourself!");
            return;
            
        }

        for (int i = 0; i < text.Length; i++)
        {
            if (element == text[i])
            {
                position--;
                if (position == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }


}
