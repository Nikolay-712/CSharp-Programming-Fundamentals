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
        string[] words = Console.ReadLine().Split(new char[] { ',', ' ', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        List<string> palindromes = new List<string>();
        for (int word = 0; word < words.Length; word++)
        {
            string myString = words[word];
            bool palindrome = getStatus(myString);
            if (palindrome)
            {
                palindromes.Add(myString);
            }
        }
        palindromes = palindromes.Distinct().OrderBy(x => x).ToList();
        Console.WriteLine(string.Join(", ", palindromes));
    }


    public static bool getStatus(string myString)
    {
        string first = myString.Substring(0, myString.Length / 2);
        char[] arr = myString.ToCharArray();
        Array.Reverse(arr);
        string temp = new string(arr);
        string second = temp.Substring(0, temp.Length / 2);
        return first.Equals(second);
    }

}
