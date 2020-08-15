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
        string removeSymbols = Console.ReadLine();

        while (true)
        {

            while (removeSymbols.Length > 0)
            {
                if (text.Contains(removeSymbols))
                {
                    text = text.Replace(removeSymbols, string.Empty);
                }
                else
                {
                    removeSymbols = removeSymbols.Substring(1);
                    if (removeSymbols.Length > 0)
                    {
                        removeSymbols = removeSymbols.Remove(removeSymbols.Length - 1);
                    }
                }

            }
            text = text.Trim();

            if (text.Length > 0)
            {
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("(void)");
            }
            

                text = Console.ReadLine();
                if (text == "collapse")
                {
                    break;
                }
                removeSymbols = Console.ReadLine();
            }

        }
    }
