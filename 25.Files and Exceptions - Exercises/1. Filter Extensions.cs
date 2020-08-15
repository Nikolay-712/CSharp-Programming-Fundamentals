using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class Test
 {
     static void Main()
     {
        string Extensions = Console.ReadLine();

        List<string> files = Directory.GetFiles(@"D:/input").ToList();

        foreach (var item in files)
        {
            FileInfo info = new FileInfo(item);

            if (info.Name.Contains(Extensions))
            {
                Console.WriteLine(info.Name);
                
            }
        }

        

    }
 }
