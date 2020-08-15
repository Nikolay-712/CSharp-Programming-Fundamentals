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
        string students = Console.ReadLine();

        Regex info = new Regex(@"name:""(?<name>[A-z]{1,})"",age:(?<age>[0-9]*),grades:\[(?<grades>[0-9, ]*)\]}");
        
        MatchCollection matchCollection = info.Matches(students);

        foreach (var item in matchCollection)
        {
            var studentName = info.Match(item.ToString()).Groups["name"].Value;
            var studentAge = info.Match(item.ToString()).Groups["age"].Value;
            var studentGrade = info.Match(item.ToString()).Groups["grades"].Value;

            if (studentGrade == string.Empty)
            {
                studentGrade = "None";
            }

            string result = $"{studentName} : {studentAge} -> {studentGrade}";

            Console.WriteLine(result.TrimEnd(new[] {'}',']' }));
        }
        
    }


}
