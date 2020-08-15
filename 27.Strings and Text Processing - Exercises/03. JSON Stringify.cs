using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Test
{
    class Student
    {
        public string NameStudent{ get; set; }
        public int AgeStudent { get; set; }
        public List<string> GradesStudent { get; set; }
    }

    static void Main()
    {
        List<string> infoStudents = Console.ReadLine().Split(new[] { ":",  "->", ","," " }
        , StringSplitOptions.RemoveEmptyEntries).ToList();

        Regex corectName = new Regex(@"(^[^\s-:->,]+$)");
        List<Student> info = new List<Student>();

        string studInfo = infoStudents.Take(2).ToString();

        while (infoStudents[0] != "stringify")
        {
            List<string> grades = infoStudents.Skip(2).ToList();

            if (corectName.IsMatch(infoStudents[0]))
            {
                Student student = new Student
                {
                    NameStudent = infoStudents[0],
                    AgeStudent =  int.Parse(infoStudents[1]),
                    GradesStudent = grades
                };

                info.Add(student);

            }


            infoStudents = Console.ReadLine().Split(new[] { ":", "->", "," ," "}
           , StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        List<string> print = new List<string>();
        foreach (var item in info)
        {
            string student = $@"name:""{item.NameStudent}"",age:{item.AgeStudent},grades:[{string.Join(", ", item.GradesStudent)}]";

            string printInfo = "{" + student + "}";

            print.Add(printInfo);
        }

        Console.WriteLine("[" + string.Join(",",print) + "]");
    }


}
