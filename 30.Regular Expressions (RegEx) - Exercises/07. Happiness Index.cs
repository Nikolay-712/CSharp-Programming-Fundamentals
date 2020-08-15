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
        string input = Console.ReadLine();

        Regex Sad = new Regex(@"([:][(])|([D][:])|([;][(])|([:][\[])|([;][\[])|([:][{])|([;][{])|([)][:])|([:][c])|([\]][:])|([\]][;])");
        Regex Happy = new Regex(@"([:][)])|([:][D])|([;][)])|([:][*])|([:][\]])|([;][\]])|([:][\]])|([:][}])|([;][}])|([(][:])|([*][:])|([c][:])|([\[][:])|([\[][;])");

        MatchCollection HappyFace = Happy.Matches(input);
        MatchCollection SadFace = Sad.Matches(input);

        int HappyCounter = 0;
        int SadCounter = 0;
        double HappyIndex = 0;

        string HappyStatus = string.Empty;

        foreach (Match item in HappyFace)
        {
            HappyCounter++;

        }
        foreach (Match item in SadFace)
        {
            SadCounter++;
        }

        HappyIndex = HappyCounter / Convert.ToDouble(SadCounter);

        if (HappyIndex >= 2)
        {
            HappyStatus = ":D";
        }
        else if (HappyIndex > 1)
        {
            HappyStatus = ":)";
        }
        else if (HappyIndex < 1)
        {
            HappyStatus = ":(";
        }

        Console.WriteLine($"Happiness index: {HappyIndex:F2} {HappyStatus}");
        Console.WriteLine($"[Happy count: {HappyCounter}, Sad count: {SadCounter}]");
    }
}