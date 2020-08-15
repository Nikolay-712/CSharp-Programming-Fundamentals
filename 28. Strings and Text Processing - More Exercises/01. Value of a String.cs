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
        string caseCharacters = Console.ReadLine();

        text = new string(text.Where(char.IsLetter).ToArray());
        int sumOfLateters = 0;

        if (caseCharacters == "UPPERCASE")
        {
            var onlyUpper = new string(text.Where(char.IsUpper).ToArray());
            sumOfLateters = onlyUpper.ToList().Select(Convert.ToInt32).Sum();
        }
        else if (caseCharacters == "LOWERCASE")
        {
            var onlyLoweer = new string(text.Where(char.IsLower).ToArray());
            sumOfLateters = onlyLoweer.ToList().Select(Convert.ToInt32).Sum();
        }

        Console.WriteLine("The total sum is: " + sumOfLateters);
    }

}
