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
        DateTime inputData = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InstalledUICulture);

        Console.WriteLine(inputData.DayOfWeek);
    }
}